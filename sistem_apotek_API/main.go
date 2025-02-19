package main

import (
	"fmt"
	"log"
	"net/http"

	"sistem_apotek/config"
	"sistem_apotek/controller"

	"github.com/gorilla/mux" // Import Gorilla Mux
)

func main() {
	// Inisialisasi koneksi database
	config.InitDB()

	// Inisialisasi router menggunakan Gorilla Mux
	router := mux.NewRouter()

	// Definisi endpoint

	//items
	router.HandleFunc("/getstockobat", controller.GetStockObat).Methods("GET")
	router.HandleFunc("/getstockobat/{kd_obat}", controller.GetStockObatByID).Methods("GET")
	router.HandleFunc("/updateStock", controller.UpdateStock).Methods("POST")
	router.HandleFunc("/addItem", controller.AddItem).Methods("PUT")
	router.HandleFunc("/deleteItem", controller.DeleteItem).Methods("DELETE")

	//suplier
	router.HandleFunc("/supliers", controller.GetSupliers).Methods("GET")
	router.HandleFunc("/suplier/{kd_suplier}", controller.GetSuplier).Methods("GET")
	router.HandleFunc("/suplier", controller.CreateSuplier).Methods("POST")
	router.HandleFunc("/suplier/{kd_suplier}", controller.UpdateSuplier).Methods("PUT")
	router.HandleFunc("/suplier/{kd_suplier}", controller.DeleteSuplier).Methods("DELETE")

	// Routes for kategori
	router.HandleFunc("/kategoris", controller.GetKategoris).Methods("GET")
	router.HandleFunc("/kategori/{kd_kategori}", controller.GetKategori).Methods("GET")
	router.HandleFunc("/kategori", controller.CreateKategori).Methods("POST")
	router.HandleFunc("/kategori/{kd_kategori}", controller.UpdateKategori).Methods("PUT")
	router.HandleFunc("/kategori/{kd_kategori}", controller.DeleteKategori).Methods("DELETE")

	// Routes untuk laravel login
	router.HandleFunc("/loginlaravel", controller.LoginHandler).Methods("POST")

	// route user
	router.HandleFunc("/users", controller.VwUser).Methods("GET")
	router.HandleFunc("/user/{id}", controller.GetUserById).Methods("GET")
	router.HandleFunc("/user/add", controller.AddUser).Methods("POST")
	router.HandleFunc("/user/{id}", controller.EditUser).Methods("PUT")
	router.HandleFunc("/user/{id}", controller.DeleteUser).Methods("DELETE")
	
	// Menjalankan server
	fmt.Println("Server running at http://localhost:1323/")
	log.Fatal(http.ListenAndServe(":1323", router))
}
