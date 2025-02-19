package entities

type Item struct {
	KdObat      string `json:"kd_obat"`
	NamaObat    string `json:"nama_obat"`
	Description string `json:"description"`
	Stock       int `json:"stock"`
	Harga       string `json:"harga"`
	JenisObat   string `json:"jenis_obat"`
	ImagePath   string `json:"image_path"` // Simpan path atau nama file gambar di sini
	KdKategori  string `json:"kd_kategori"`
	KdSuplier   string `json:"kd_suplier"`
}
