Imports System.Data.Odbc

Module Module1
    Public cmd As OdbcCommand
    Public conn As OdbcConnection
    Public rd As OdbcDataReader
    Public da As OdbcDataAdapter
    ' Public tbl As DataTable

    Sub koneksi()
        conn = New OdbcConnection
        conn.ConnectionString = "dsn=kasir_1"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub
End Module









