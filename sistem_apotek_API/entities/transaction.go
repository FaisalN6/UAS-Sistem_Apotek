package entities

type Transaction struct {
	Nota       string            `json:"nota"`
	KdKategori string            `json:"kd_kategori"`
	KdSuplier  string            `json:"kd_suplier"`
	Items      []TransactionItem `json:"items"`
}

type TransactionItem struct {
	KdObat   string `json:"kd_obat"`
	NamaObat string `json:"nama_obat"`
	Harga    string `json:"harga"`
	Jumlah   string `json:"jumlah"`
	Total    string `json:"total"`
}
