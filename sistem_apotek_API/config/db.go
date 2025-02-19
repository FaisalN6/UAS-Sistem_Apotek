package config

import (
	"database/sql"
	"log"

	_ "github.com/go-sql-driver/mysql"
)

var db *sql.DB

// InitDB inisialisasi koneksi ke database
func InitDB() {
	var err error
	db, err = sql.Open("mysql", "root:@tcp(127.0.0.1:3306)/dbs_apotek")
	if err != nil {
		log.Fatal(err)
	}

	err = db.Ping()
	if err != nil {
		log.Fatal(err)
	}
}

// GetDB mengembalikan instance DB yang sudah diinisialisasi
func GetDB() *sql.DB {
	return db
}
