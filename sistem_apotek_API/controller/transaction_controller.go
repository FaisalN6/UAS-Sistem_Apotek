package controller

import (
	"database/sql"
	"encoding/json"
	"net/http"

	"sistem_apotek/config"
	"sistem_apotek/entities"

	"github.com/gorilla/mux"
)

func CreateTransaction(w http.ResponseWriter, r *http.Request) {
    var transaction entities.Transaction
    err := json.NewDecoder(r.Body).Decode(&transaction)
    if err != nil {
        http.Error(w, "Invalid request payload", http.StatusBadRequest)
        return
    }

    db := config.GetDB()
    tx, err := db.Begin()
    if err != nil {
        http.Error(w, "Failed to start transaction", http.StatusInternalServerError)
        return
    }

    _, err = tx.Exec("INSERT INTO transactions (nota, kd_kategori, kd_suplier) VALUES (?, ?, ?)",
        transaction.Nota, transaction.KdKategori, transaction.KdSuplier)
    if err != nil {
        tx.Rollback()
        http.Error(w, "Failed to insert transaction", http.StatusInternalServerError)
        return
    }

    for _, item := range transaction.Items {
        _, err = tx.Exec("INSERT INTO transaction_items (nota, kd_obat, nama_obat, harga, jumlah, total) VALUES (?, ?, ?, ?, ?, ?)",
            transaction.Nota, item.KdObat, item.NamaObat, item.Harga, item.Jumlah, item.Total)
        if err != nil {
            tx.Rollback()
            http.Error(w, "Failed to insert transaction item", http.StatusInternalServerError)
            return
        }

        _, err = tx.Exec("UPDATE items SET stock = stock - ? WHERE kd_obat = ?", item.Jumlah, item.KdObat)
        if err != nil {
            tx.Rollback()
            http.Error(w, "Failed to update stock", http.StatusInternalServerError)
            return
        }
    }

    err = tx.Commit()
    if err != nil {
        tx.Rollback()
        http.Error(w, "Failed to commit transaction", http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusCreated)
    json.NewEncoder(w).Encode(transaction)
}

func GetTransaction(w http.ResponseWriter, r *http.Request) {
    vars := mux.Vars(r)
    nota := vars["nota"]

    db := config.GetDB()
    var transaction entities.Transaction

    err := db.QueryRow("SELECT nota, kd_kategori, kd_suplier FROM transactions WHERE nota = ?", nota).Scan(
        &transaction.Nota, &transaction.KdKategori, &transaction.KdSuplier)
    if err != nil {
        if err == sql.ErrNoRows {
            http.Error(w, "Transaction not found", http.StatusNotFound)
        } else {
            http.Error(w, err.Error(), http.StatusInternalServerError)
        }
        return
    }

    rows, err := db.Query("SELECT kd_obat, nama_obat, harga, jumlah, total FROM transaction_items WHERE nota = ?", nota)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }
    defer rows.Close()

    var items []entities.TransactionItem
    for rows.Next() {
        var item entities.TransactionItem
        if err := rows.Scan(&item.KdObat, &item.NamaObat, &item.Harga, &item.Jumlah, &item.Total); err != nil {
            http.Error(w, err.Error(), http.StatusInternalServerError)
            return
        }
        items = append(items, item)
    }
    transaction.Items = items

    if err := rows.Err(); err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.Header().Set("Content-Type", "application/json")
    json.NewEncoder(w).Encode(transaction)
}

func UpdateTransaction(w http.ResponseWriter, r *http.Request) {
    vars := mux.Vars(r)
    nota := vars["nota"]

    var transaction entities.Transaction
    err := json.NewDecoder(r.Body).Decode(&transaction)
    if err != nil {
        http.Error(w, "Invalid request payload", http.StatusBadRequest)
        return
    }

    db := config.GetDB()
    tx, err := db.Begin()
    if err != nil {
        http.Error(w, "Failed to start transaction", http.StatusInternalServerError)
        return
    }

    _, err = tx.Exec("UPDATE transactions SET kd_kategori = ?, kd_suplier = ? WHERE nota = ?",
        transaction.KdKategori, transaction.KdSuplier, nota)
    if err != nil {
        tx.Rollback()
        http.Error(w, "Failed to update transaction", http.StatusInternalServerError)
        return
    }

    _, err = tx.Exec("DELETE FROM transaction_items WHERE nota = ?", nota)
    if err != nil {
        tx.Rollback()
        http.Error(w, "Failed to delete old transaction items", http.StatusInternalServerError)
        return
    }

    for _, item := range transaction.Items {
        _, err = tx.Exec("INSERT INTO transaction_items (nota, kd_obat, nama_obat, harga, jumlah, total) VALUES (?, ?, ?, ?, ?, ?)",
            nota, item.KdObat, item.NamaObat, item.Harga, item.Jumlah, item.Total)
        if err != nil {
            tx.Rollback()
            http.Error(w, "Failed to insert transaction item", http.StatusInternalServerError)
            return
        }

        _, err = tx.Exec("UPDATE items SET stock = stock - ? WHERE kd_obat = ?", item.Jumlah, item.KdObat)
        if err != nil {
            tx.Rollback()
            http.Error(w, "Failed to update stock", http.StatusInternalServerError)
            return
        }
    }

    err = tx.Commit()
    if err != nil {
        tx.Rollback()
        http.Error(w, "Failed to commit transaction", http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusOK)
    json.NewEncoder(w).Encode(transaction)
}
