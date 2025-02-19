// controller/kategori.go

package controller

import (
    "encoding/json"
    "net/http"

    "sistem_apotek/entities"
    "sistem_apotek/config"
    "github.com/gorilla/mux"
)

// GetKategoris handles the GET /kategoris endpoint
func GetKategoris(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    rows, err := db.Query("SELECT kd_kategori, nama_kategori FROM kategoris")
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }
    defer rows.Close()

    var kategoris []entities.Kategori
    for rows.Next() {
        var kategori entities.Kategori
        if err := rows.Scan(&kategori.KdKategori, &kategori.NamaKategori); err != nil {
            http.Error(w, err.Error(), http.StatusInternalServerError)
            return
        }
        kategoris = append(kategoris, kategori)
    }

    w.Header().Set("Content-Type", "application/json")
    json.NewEncoder(w).Encode(kategoris)
}

// GetKategori handles the GET /kategori/{kd_kategori} endpoint
func GetKategori(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    params := mux.Vars(r)
    kdKategori := params["kd_kategori"]

    row := db.QueryRow("SELECT kd_kategori, nama_kategori FROM kategoris WHERE kd_kategori = ?", kdKategori)
    var kategori entities.Kategori
    err := row.Scan(&kategori.KdKategori, &kategori.NamaKategori)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.Header().Set("Content-Type", "application/json")
    json.NewEncoder(w).Encode(kategori)
}

// CreateKategori handles the POST /kategori endpoint
func CreateKategori(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    var kategori entities.Kategori
    if err := json.NewDecoder(r.Body).Decode(&kategori); err != nil {
        http.Error(w, err.Error(), http.StatusBadRequest)
        return
    }

    _, err := db.Exec("INSERT INTO kategoris (kd_kategori, nama_kategori) VALUES (?, ?)",
        kategori.KdKategori, kategori.NamaKategori)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusCreated)
    w.Write([]byte("Kategori berhasil ditambahkan"))
}

// UpdateKategori handles the PUT /kategori/{kd_kategori} endpoint
func UpdateKategori(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    var kategori entities.Kategori
    if err := json.NewDecoder(r.Body).Decode(&kategori); err != nil {
        http.Error(w, err.Error(), http.StatusBadRequest)
        return
    }

    params := mux.Vars(r)
    kdKategori := params["kd_kategori"]

    _, err := db.Exec("UPDATE kategoris SET nama_kategori = ? WHERE kd_kategori = ?",
        kategori.NamaKategori, kdKategori)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusOK)
    w.Write([]byte("Kategori berhasil diperbarui"))
}

// DeleteKategori handles the DELETE /kategori/{kd_kategori} endpoint
func DeleteKategori(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    params := mux.Vars(r)
    kdKategori := params["kd_kategori"]

    _, err := db.Exec("DELETE FROM kategoris WHERE kd_kategori = ?", kdKategori)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusOK)
    w.Write([]byte("Kategori berhasil dihapus"))
}
