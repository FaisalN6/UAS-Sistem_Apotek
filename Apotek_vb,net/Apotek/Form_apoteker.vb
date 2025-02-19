Imports System.Data.Odbc

Public Class Form_apoteker
    ' Metode untuk menampilkan data obat
    Private Sub tampilObat()
        Dim str As String = "SELECT * FROM tbl_dataobat WHERE kd_obat LIKE '%" & txt_cariobat.Text & "%'"
        Dim da As New OdbcDataAdapter(str, conn)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dg_obat.DataSource = tbl
    End Sub

    ' Metode untuk menampilkan data transaksi
    Private Sub tampilTransaksi()
        Dim str As String = "SELECT * FROM tbl_transaksi WHERE kd_obat LIKE '%" & txtcari_transaksi.Text & "%'"
        Dim da As New OdbcDataAdapter(str, conn)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dg_transaksi.DataSource = tbl
    End Sub

    Private Sub btn_cariobat_Click(sender As Object, e As EventArgs) Handles btn_cariobat.Click
        tampilObat()
    End Sub

    Private Sub btn_caritransaksi_Click(sender As Object, e As EventArgs) Handles btn_caritransaksi.Click
        tampilTransaksi()
    End Sub

    Private Sub Form_apoteker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilObat()
        tampilTransaksi()
    End Sub
End Class