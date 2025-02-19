package controller

import (
	"database/sql"
	"encoding/json"
	"io"
	"log"
	"net/http"

	"github.com/gorilla/mux"

	"sistem_apotek/config"
	"sistem_apotek/entities"
)

// GetStockObat handles the /getstockobat endpoint
func GetStockObat(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	rows, err := db.Query("SELECT kd_obat, nama_obat, description, stock, harga, jenis_obat, image_path, kd_kategori, kd_suplier FROM items")
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	defer rows.Close()

	var items []entities.Item
	for rows.Next() {
		var item entities.Item
		if err := rows.Scan(&item.KdObat, &item.NamaObat, &item.Description, &item.Stock, &item.Harga, &item.JenisObat, &item.ImagePath, &item.KdKategori, &item.KdSuplier); err != nil {
			http.Error(w, err.Error(), http.StatusInternalServerError)
			return
		}
		items = append(items, item)
	}

	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(items)
}

// GetStockObatByID handles the /getstockobat/{kd_obat} endpoint
func GetStockObatByID(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()
	vars := mux.Vars(r)
	kdObat := vars["kd_obat"]

	var item entities.Item
	err := db.QueryRow("SELECT kd_obat, nama_obat, description, stock, harga, jenis_obat, image_path, kd_kategori, kd_suplier FROM items WHERE kd_obat = ?", kdObat).Scan(
		&item.KdObat, &item.NamaObat, &item.Description, &item.Stock, &item.Harga, &item.JenisObat, &item.ImagePath, &item.KdKategori, &item.KdSuplier)
	if err != nil {
		if err == sql.ErrNoRows {
			http.Error(w, "Item not found", http.StatusNotFound)
		} else {
			http.Error(w, err.Error(), http.StatusInternalServerError)
		}
		return
	}

	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(item)
}

// UpdateStock handles the /updateStock endpoint

func UpdateStock(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	var item entities.Item
	if err := json.NewDecoder(r.Body).Decode(&item); err != nil {
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	_, err := db.Exec("UPDATE items SET stock = ?, harga = ?, kd_kategori = ?, kd_suplier = ? WHERE kd_obat = ?",
		item.Stock, item.Harga, item.KdKategori, item.KdSuplier, item.KdObat)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	w.WriteHeader(http.StatusOK)
	w.Write([]byte("Stok, harga, kd_kategori, dan kd_suplier berhasil diubah"))
}

// AddItem handles the /addItem endpoint
func AddItem(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	// Read the raw request body
	body, err := io.ReadAll(r.Body)
	if err != nil {
		log.Printf("Error reading request body: %v", err)
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	// Log the raw request body
	log.Printf("Raw request body: %s", body)

	var item entities.Item
	if err := json.Unmarshal(body, &item); err != nil {
		log.Printf("Error decoding item: %v", err)
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	// Log the received item data
	log.Printf("Item received: %+v", item)

	_, err = db.Exec("INSERT INTO items (kd_obat, nama_obat, description, stock, harga, jenis_obat, image_path, kd_kategori, kd_suplier) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)",
		item.KdObat, item.NamaObat, item.Description, item.Stock, item.Harga, item.JenisObat, item.ImagePath, item.KdKategori, item.KdSuplier)
	if err != nil {
		log.Printf("Error executing query: %v", err)
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	w.WriteHeader(http.StatusCreated)
	w.Write([]byte("Item berhasil ditambahkan"))
}

// delete item
func DeleteItem(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	var item entities.Item
	if err := json.NewDecoder(r.Body).Decode(&item); err != nil {
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	result, err := db.Exec("DELETE FROM items WHERE kd_obat = ?", item.KdObat)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	rowsAffected, err := result.RowsAffected()
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	if rowsAffected == 0 {
		http.Error(w, "No item found with the given kd_obat", http.StatusNotFound)
		return
	}

	w.WriteHeader(http.StatusOK)
	w.Write([]byte("Item berhasil dihapus"))
}
