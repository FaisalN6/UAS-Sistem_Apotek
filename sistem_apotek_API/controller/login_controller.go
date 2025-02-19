package controller

import (
	"encoding/json"
	"net/http"
	"os"
	"time"

	"sistem_apotek/config"
	"sistem_apotek/entities"

	"github.com/dgrijalva/jwt-go"
	"golang.org/x/crypto/bcrypt"
)

var jwtKey = []byte(os.Getenv("JWT_SECRET"))

type Credentials struct {
    Email    string `json:"email"`
    Password string `json:"password"`
}

type Claims struct {
    UserID int    `json:"id"`
    Role   string `json:"role"`
    jwt.StandardClaims
}

func LoginHandler(w http.ResponseWriter, r *http.Request) {
    var creds Credentials
    err := json.NewDecoder(r.Body).Decode(&creds)
    if err != nil {
        http.Error(w, "Invalid request payload", http.StatusBadRequest)
        return
    }

    pengguna, err := getPenggunaByEmail(creds.Email)
    if err != nil {
        http.Error(w, "Invalid ac", http.StatusUnauthorized)
        return
    }

    if err := bcrypt.CompareHashAndPassword([]byte(pengguna.Password), []byte(creds.Password)); err != nil {
        http.Error(w, "Invalid ab", http.StatusUnauthorized)
        return
    }

    expirationTime := time.Now().Add(24 * time.Hour)
    claims := &Claims{
        UserID: pengguna.ID,
        Role:   pengguna.Role,
        StandardClaims: jwt.StandardClaims{
            ExpiresAt: expirationTime.Unix(),
        },
    }

    token := jwt.NewWithClaims(jwt.SigningMethodHS256, claims)
    tokenString, err := token.SignedString(jwtKey)
    if err != nil {
        http.Error(w, "Error generating token", http.StatusInternalServerError)
        return
    }

    http.SetCookie(w, &http.Cookie{
        Name:    "token",
        Value:   tokenString,
        Expires: expirationTime,
    })

    w.Header().Set("Content-Type", "application/json")
    json.NewEncoder(w).Encode(map[string]string{"token": tokenString})
}

func getPenggunaByEmail(email string) (*entities.Pengguna, error) {
    var pengguna entities.Pengguna
    query := "SELECT id, email, password, role FROM users WHERE email = ?"
    row := config.GetDB().QueryRow(query, email)
    err := row.Scan(&pengguna.ID, &pengguna.Email, &pengguna.Password, &pengguna.Role)
    if err != nil {
        return nil, err
    }
    return &pengguna, nil
}

