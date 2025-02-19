Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Form_dataobat
    Private client As HttpClient

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        client = New HttpClient()
    End Sub

    Sub tampil()
        Try
            ' Pemanggilan ke endpoint Go untuk mendapatkan data obat
            Dim response = client.GetAsync("http://localhost:1323/getstockobat").Result
            response.EnsureSuccessStatusCode()
            Dim responseData = response.Content.ReadAsStringAsync().Result
            Dim obatList = JsonConvert.DeserializeObject(Of List(Of Obat))(responseData)

            ' Konversi List ke DataTable
            Dim tbl As New DataTable
            tbl.Columns.Add("kd_obat")
            tbl.Columns.Add("nama_obat")
            tbl.Columns.Add("description")
            tbl.Columns.Add("stock")
            tbl.Columns.Add("harga")
            tbl.Columns.Add("jenis_obat")
            tbl.Columns.Add("image_path")
            tbl.Columns.Add("kd_kategori")
            tbl.Columns.Add("kd_suplier")

            For Each obat In obatList
                tbl.Rows.Add(obat.Kd_Obat, obat.Nama_Obat, obat.Description, obat.Stock, obat.Harga, obat.Jenis_Obat, obat.Image_path, obat.Kd_Kategori, obat.Kd_Suplier)
            Next

            DataGridView1.DataSource = tbl

            ' Atur ukuran font pada DataGridView
            DataGridView1.DefaultCellStyle.Font = New Font("Source Sans Pro", 10)

            DataGridView1.Columns("kd_suplier").DefaultCellStyle.Format = "NO"
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub Form_dataobat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub txt_kodeobat_TextChanged(sender As Object, e As EventArgs) Handles txt_kodeobat.TextChanged
        Try
            Dim response = client.GetAsync("http://localhost:8080/getobat/" & txt_kodeobat.Text.Trim()).Result
            response.EnsureSuccessStatusCode()
            Dim responseData = response.Content.ReadAsStringAsync().Result
            Dim obat = JsonConvert.DeserializeObject(Of Obat)(responseData)

            If obat IsNot Nothing Then
                txt_namaobat.Text = obat.Nama_Obat
                txt_dec.Text = obat.Description
                txt_stock.Text = obat.Stock.ToString()
                txt_harga.Text = obat.Harga.ToString()
                txt_jenisobat.Text = obat.Jenis_Obat
                txt_img.Text = obat.Image_path
                txt_kategori.Text = obat.Kd_Kategori
                txt_suplier.Text = obat.Kd_Suplier
            Else
                txt_namaobat.Clear()
                txt_dec.Clear()
                txt_stock.Clear()
                txt_harga.Clear()
                txt_jenisobat.Clear()
                txt_img.Clear()
                txt_kategori.Clear()
                txt_suplier.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If txt_kodeobat.Text = "" Or txt_namaobat.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Try
                ' Memeriksa apakah obat sudah ada
                Dim response = Await client.GetAsync("http://localhost:1323/getstockobat/" & txt_kodeobat.Text.Trim())
                Dim obatExists = response.IsSuccessStatusCode

                Dim obat As New Obat With {
                    .Kd_Obat = txt_kodeobat.Text.Trim(),
                    .Nama_Obat = txt_namaobat.Text.Trim(),
                    .Description = txt_dec.Text.Trim(),
                    .Stock = Convert.ToInt32(txt_stock.Text.Trim()),
                    .Harga = (txt_harga.Text.Trim()),
                    .Jenis_Obat = txt_jenisobat.Text.Trim(),
                    .Image_path = txt_img.Text.Trim(),
                    .Kd_Kategori = txt_kategori.Text.Trim(),
                    .Kd_Suplier = txt_suplier.Text.Trim()
                }

                If obatExists Then
                    ' Update obat
                    Dim content = New StringContent(JsonConvert.SerializeObject(obat), Encoding.UTF8, "application/json")
                    response = Await client.PutAsync("http://localhost:1323/updateStock", content)
                Else
                    ' Insert obat
                    Dim content = New StringContent(JsonConvert.SerializeObject(obat), Encoding.UTF8, "application/json")
                    response = Await client.PostAsync("http://localhost:1323/addItem", content)
                End If

                If response.IsSuccessStatusCode Then
                    MsgBox("Data Tersimpan")
                Else
                    MsgBox("Gagal menyimpan data: " & response.StatusCode.ToString())
                End If

                tampil()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs)
        tampil()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Try
            Dim kodeObat = DataGridView1.Item("kd_obat", DataGridView1.CurrentRow.Index).Value.ToString()
            Dim response = client.DeleteAsync("http://localhost:1323/deleteItem/" & kodeObat).Result
            If response.IsSuccessStatusCode Then
                MsgBox("Data Terhapus")
                tampil()
            Else
                MsgBox("Gagal menghapus data: " & response.StatusCode.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        txt_kodeobat.Text = DataGridView1.Item("kd_obat", e.RowIndex).Value.ToString()
    End Sub

    Private Sub txt_harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_harga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            btn_simpan.Select()
        End If
    End Sub

    Private Sub txt_kodeobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kodeobat.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_namaobat.Select()
        End If
    End Sub

    Private Sub txt_namaobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_namaobat.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_dec.Select()
        End If
    End Sub

    Private Sub txt_dec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dec.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_stock.Select()
        End If
    End Sub

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_jenisobat.Select()
        End If
    End Sub

    Private Sub txt_jenisobat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jenisobat.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_img.Select()
        End If
    End Sub

    Private Sub txt_img_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_img.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_kategori.Select()
        End If
    End Sub

    Private Sub txt_kategori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kategori.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_suplier.Select()
        End If
    End Sub

    Private Sub txt_suplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_suplier.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_harga.Select()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class

Public Class Obat
    Public Property Kd_Obat As String
    Public Property Nama_Obat As String
    Public Property Description As String
    Public Property Stock As Integer
    Public Property Harga As Integer
    Public Property Jenis_Obat As String
    Public Property Image_path As String
    Public Property Kd_Kategori As String
    Public Property Kd_Suplier As String
End Class