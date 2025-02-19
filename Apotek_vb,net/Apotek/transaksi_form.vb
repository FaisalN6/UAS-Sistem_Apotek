Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class transaksi_form

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        ' Insert item into DataGridView
        Dim row As String() = New String() {txt_nota.Text, txt_kdobat.Text, txt_namaobat.Text, txt_harga.Text, txt_jumlah.Text, txt_total.Text}
        dg_transaksi.Rows.Add(row)
        ' Update item count and total
        UpdateItemCountAndTotal()
        ' Clear input fields
        ClearInputFields()
    End Sub

    Private Sub btm_simpan_Click(sender As Object, e As EventArgs) Handles btm_simpan.Click
        ' Save transaction to the backend
        SaveTransaction()
    End Sub

    Private Async Sub SaveTransaction()
        Dim items As New List(Of Item)()
        For Each row As DataGridViewRow In dg_transaksi.Rows
            If Not row.IsNewRow Then
                Dim item As New Item With {
                    .Nota = row.Cells("ColumnNota").Value?.ToString(),
                    .Kd_Obat = row.Cells("ColumnKdObat").Value?.ToString(),
                    .Nama_Obat = row.Cells("ColumnNamaObat").Value?.ToString(),
                    .Harga = Decimal.Parse(row.Cells("ColumnHarga").Value?.ToString()),
                    .Jumlah = Integer.Parse(row.Cells("ColumnJumlah").Value?.ToString()),
                    .Total = Decimal.Parse(row.Cells("ColumnTotal").Value?.ToString())
                }
                items.Add(item)
            End If
        Next

        Dim transaction As New Transaction With {
            .Nota = txt_nota.Text,
            .KdKategori = txt_kdkategori.Text,
            .KdSuplier = txt_kdsupllier.Text,
            .Items = items
        }

        Dim json As String = JsonConvert.SerializeObject(transaction)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:1323/transactions", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Transaction saved successfully")
                Else
                    Dim errorMessage As String = $"Failed to save transaction. Server returned: {response.StatusCode} - {response.ReasonPhrase}"
                    MessageBox.Show(errorMessage)
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub ClearInputFields()
        txt_kdobat.Clear()
        txt_namaobat.Clear()
        txt_harga.Clear()
        txt_jumlah.Clear()
        txt_total.Clear()
        txt_kdkategori.Clear()
        txt_kdsupllier.Clear()
    End Sub

    Private Sub UpdateItemCountAndTotal()
        Dim itemCount As Integer = dg_transaksi.Rows.Count
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dg_transaksi.Rows
            If Not row.IsNewRow Then
                Dim itemTotal As Decimal = 0
                If Decimal.TryParse(row.Cells("ColumnTotal").Value?.ToString(), itemTotal) Then
                    total += itemTotal
                End If
            End If
        Next

        lbl_qty.Text = (itemCount - 1).ToString() ' Subtract 1 to exclude the new row
        txt_total.Text = total.ToString("F2")
    End Sub

    Private Async Sub FetchItemDetails()
        Dim kdObat As String = txt_kdobat.Text
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:1323/getstockobat/{kdObat}")
                If response.IsSuccessStatusCode Then
                    Dim item As Item = JsonConvert.DeserializeObject(Of Item)(Await response.Content.ReadAsStringAsync())
                    txt_namaobat.Text = item.Nama_Obat
                    txt_harga.Text = item.Harga.ToString("F2")
                    txt_stock.Text = item.Stock.ToString()
                    txt_kdkategori.Text = item.Kd_Kategori
                    txt_kdsupllier.Text = item.Kd_Suplier
                    UpdateItemCountAndTotal()
                Else
                    MessageBox.Show("Failed to fetch item details")
                End If
            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try
        End Using
    End Sub

    Private Sub transaksi_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add columns to DataGridView
        dg_transaksi.Columns.Add("ColumnNota", "Kode Transaksi")
        dg_transaksi.Columns.Add("ColumnKdObat", "Kode Obat")
        dg_transaksi.Columns.Add("ColumnNamaObat", "Nama Obat")
        dg_transaksi.Columns.Add("ColumnHarga", "Harga")
        dg_transaksi.Columns.Add("ColumnJumlah", "Jumlah")
        dg_transaksi.Columns.Add("ColumnTotal", "Total")

    End Sub

    Public Class Item
        Public Property Nota As String
        Public Property Kd_Obat As String
        Public Property Nama_Obat As String
        Public Property Harga As Decimal
        Public Property Jumlah As Integer
        Public Property Total As Decimal
        Public Property Stock As Integer
        Public Property Kd_Kategori As String
        Public Property Kd_Suplier As String
    End Class

    Public Class Transaction
        Public Property Nota As String
        Public Property KdKategori As String
        Public Property KdSuplier As String
        Public Property Items As List(Of Item)
    End Class
End Class