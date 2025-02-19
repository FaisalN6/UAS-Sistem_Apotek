// entities/suplier.go

package entities

type Suplier struct {
    KdSuplier   string `json:"kd_suplier"`
    NamaSuplier string `json:"nama_suplier"`
    NoTlpn      string `json:"no_tlpn"`
    Alamat      string `json:"alamat"`
    Perusahaan  string `json:"perusahaan"`
}
