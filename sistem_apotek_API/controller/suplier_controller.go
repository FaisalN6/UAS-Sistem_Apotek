package controller

import (
    "encoding/json"
    "net/http"

    "sistem_apotek/entities"
    "sistem_apotek/config"
    "github.com/gorilla/mux"
)

// GetSupliers handles the GET /supliers endpoint
func GetSupliers(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    rows, err := db.Query("SELECT kd_suplier, nama_suplier, no_tlpn, alamat, perusahaan FROM supliers")
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }
    defer rows.Close()

    var supliers []entities.Suplier
    for rows.Next() {
        var suplier entities.Suplier
        if err := rows.Scan(&suplier.KdSuplier, &suplier.NamaSuplier, &suplier.NoTlpn, &suplier.Alamat, &suplier.Perusahaan); err != nil {
            http.Error(w, err.Error(), http.StatusInternalServerError)
            return
        }
        supliers = append(supliers, suplier)
    }

    w.Header().Set("Content-Type", "application/json")
    json.NewEncoder(w).Encode(supliers)
}

// GetSuplier handles the GET /suplier/{kd_suplier} endpoint
func GetSuplier(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    params := mux.Vars(r)
    kdSuplier := params["kd_suplier"]

    row := db.QueryRow("SELECT kd_suplier, nama_suplier, no_tlpn, alamat, perusahaan FROM supliers WHERE kd_suplier = ?", kdSuplier)
    var suplier entities.Suplier
    err := row.Scan(&suplier.KdSuplier, &suplier.NamaSuplier, &suplier.NoTlpn, &suplier.Alamat, &suplier.Perusahaan)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.Header().Set("Content-Type", "application/json")
    json.NewEncoder(w).Encode(suplier)
}

// CreateSuplier handles the POST /suplier endpoint
func CreateSuplier(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    var suplier entities.Suplier
    if err := json.NewDecoder(r.Body).Decode(&suplier); err != nil {
        http.Error(w, err.Error(), http.StatusBadRequest)
        return
    }

    _, err := db.Exec("INSERT INTO supliers (kd_suplier, nama_suplier, no_tlpn, alamat, perusahaan) VALUES (?, ?, ?, ?, ?)",
        suplier.KdSuplier, suplier.NamaSuplier, suplier.NoTlpn, suplier.Alamat, suplier.Perusahaan)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusCreated)
    w.Write([]byte("Suplier berhasil ditambahkan"))
}

// UpdateSuplier handles the PUT /suplier/{kd_suplier} endpoint
// UpdateSuplier handles the PUT /suplier/{kd_suplier} endpoint to update all fields
func UpdateSuplier(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    var suplier entities.Suplier
    if err := json.NewDecoder(r.Body).Decode(&suplier); err != nil {
        http.Error(w, err.Error(), http.StatusBadRequest)
        return
    }

    params := mux.Vars(r)
    kdSuplier := params["kd_suplier"]

    // Construct the SQL query dynamically based on the fields received in the request
    query := "UPDATE supliers SET "
    if suplier.NamaSuplier != "" {
        query += "nama_suplier = '" + suplier.NamaSuplier + "', "
    }
    if suplier.NoTlpn != "" {
        query += "no_tlpn = '" + suplier.NoTlpn + "', "
    }
    if suplier.Alamat != "" {
        query += "alamat = '" + suplier.Alamat + "', "
    }
    if suplier.Perusahaan != "" {
        query += "perusahaan = '" + suplier.Perusahaan + "', "
    }

    // Remove the last comma and space
    query = query[:len(query)-2]

    query += " WHERE kd_suplier = ?"

    _, err := db.Exec(query, kdSuplier)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusOK)
    w.Write([]byte("Suplier berhasil diperbarui"))
}


// DeleteSuplier handles the DELETE /suplier/{kd_suplier} endpoint
func DeleteSuplier(w http.ResponseWriter, r *http.Request) {
    db := config.GetDB()

    params := mux.Vars(r)
    kdSuplier := params["kd_suplier"]

    _, err := db.Exec("DELETE FROM supliers WHERE kd_suplier = ?", kdSuplier)
    if err != nil {
        http.Error(w, err.Error(), http.StatusInternalServerError)
        return
    }

    w.WriteHeader(http.StatusOK)
    w.Write([]byte("Suplier berhasil dihapus"))
}
