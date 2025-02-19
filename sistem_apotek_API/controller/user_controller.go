package controller

import (
	"database/sql"
	"encoding/json"
	"net/http"

	"sistem_apotek/config"
	"sistem_apotek/entities"

	"github.com/gorilla/mux"
	"golang.org/x/crypto/bcrypt"

	_ "github.com/go-sql-driver/mysql"
)

func VwUser(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	rows, err := db.Query("SELECT id, name, email, password, role FROM users")
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}
	defer rows.Close()

	var users []entities.Pengguna
	for rows.Next() {
		var user entities.Pengguna
		var role sql.NullString
		if err := rows.Scan(&user.ID, &user.Name, &user.Email, &user.Password, &role); err != nil {
			http.Error(w, err.Error(), http.StatusInternalServerError)
			return
		}
		user.Role = role.String // if role.Valid is false, role.String will be an empty string
		users = append(users, user)
	}

	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(users)
}

func GetUserById(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	params := mux.Vars(r)
	ID := params["id"]

	row := db.QueryRow("SELECT id, name, email, password, role FROM users WHERE id = ?", ID)
	var user entities.Pengguna
	err := row.Scan(&user.ID, &user.Name, &user.Email, &user.Password, &user.Role)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	w.Header().Set("Content-Type", "application/json")
	json.NewEncoder(w).Encode(user)
}

func AddUser(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	var user entities.Pengguna
	if err := json.NewDecoder(r.Body).Decode(&user); err != nil {
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	// Hash the user's password
	hashedPassword, err := bcrypt.GenerateFromPassword([]byte(user.Password), bcrypt.DefaultCost)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	// Update the user object with the hashed password
	user.Password = string(hashedPassword)

	_, err = db.Exec("INSERT INTO users (id, name, email, password, role) VALUES (?, ?, ?, ?, ?)",
		user.ID, user.Name, user.Email, user.Password, user.Role)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	w.WriteHeader(http.StatusCreated)
	w.Write([]byte("User berhasil ditambahkan"))
}

func EditUser(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	var user entities.Pengguna
	if err := json.NewDecoder(r.Body).Decode(&user); err != nil {
		http.Error(w, err.Error(), http.StatusBadRequest)
		return
	}

	params := mux.Vars(r)
	ID := params["id"]

	// Hash the user's password
	hashedPassword, err := bcrypt.GenerateFromPassword([]byte(user.Password), bcrypt.DefaultCost)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	// Update the user object with the hashed password
	user.Password = string(hashedPassword)

	_, err = db.Exec("UPDATE users SET name = ?, email = ?, password = ?, role = ? WHERE id = ?",
		user.Name, user.Email, user.Password, user.Role, ID)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	w.WriteHeader(http.StatusOK)
	w.Write([]byte("User berhasil diperbarui"))
}

func DeleteUser(w http.ResponseWriter, r *http.Request) {
	db := config.GetDB()

	params := mux.Vars(r)
	ID := params["id"]

	_, err := db.Exec("DELETE FROM users WHERE id = ?", ID)
	if err != nil {
		http.Error(w, err.Error(), http.StatusInternalServerError)
		return
	}

	w.WriteHeader(http.StatusOK)
	w.Write([]byte("User berhasil dihapus"))
}
