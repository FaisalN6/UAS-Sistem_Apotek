package controller

import (
	"database/sql"
	"encoding/json"
	"net/http"
	"sistem_apotek/config"
	"sistem_apotek/entities"
)

func Authenticate(username, password string) (*entities.User, error) {
	user := &entities.User{}
	query := "SELECT id, username, role FROM tbl_user WHERE username = ? AND password = ?"
	err := config.GetDB().QueryRow(query, username, password).Scan(&user.ID, &user.Username, &user.Role)
	if err != nil {
		if err == sql.ErrNoRows {
			return nil, nil
		}
		return nil, err
	}
	return user, nil
}

func Login(w http.ResponseWriter, r *http.Request) {
	var credentials struct {
		Username string `json:"username"`
		Password string `json:"password"`
	}

	err := json.NewDecoder(r.Body).Decode(&credentials)
	if err != nil {
		http.Error(w, "Permintaan tidak valid", http.StatusBadRequest)
		return
	}

	user, err := Authenticate(credentials.Username, credentials.Password)
	if err != nil {
		http.Error(w, "Kesalahan server", http.StatusInternalServerError)
		return
	}

	if user == nil {
		http.Error(w, "Kredensial tidak valid", http.StatusUnauthorized)
		return
	}

	// Mengembalikan peran pengguna untuk menentukan halaman yang dituju
	json.NewEncoder(w).Encode(map[string]string{
		"role": user.Role,
	})
}
