Imports System.Data.Odbc
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO

Public Class Form_login

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpass.PasswordChar = "*" ' Menyembunyikan password dengan karakter *

        txtuser.Text = "Username"
        txtuser.ForeColor = Color.DarkGray

        txtpass.Text = "Password"
        txtpass.ForeColor = Color.DarkGray
    End Sub

    Private Function Login(username As String, password As String) As String
        Dim url As String = "http://localhost:1323/login" ' Ganti dengan URL yang sesuai
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"

        Dim postData As String = JsonConvert.SerializeObject(New With {
            .username = username,
            .password = password
        })
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Try
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            If response.StatusCode = HttpStatusCode.OK Then
                Dim reader As New StreamReader(response.GetResponseStream())
                Dim responseFromServer As String = reader.ReadToEnd()
                reader.Close()
                response.Close()
                Return responseFromServer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghubungi server.")
            Return Nothing
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtuser.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("Mohon masukkan Username dan Password anda terlebih dahulu!")
        Else
            Dim response As String = Login(txtuser.Text.Trim(), txtpass.Text.Trim())
            If response IsNot Nothing Then
                Try
                    Dim jsonResponse As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response)
                    If jsonResponse.ContainsKey("role") Then
                        Select Case jsonResponse("role").ToLower()
                            Case "apoteker"
                                Me.Hide()
                                Form_MenuApoteker.Show()
                            Case "kasir"
                                Me.Hide()
                                Form_menu.Show()
                            Case Else
                                MessageBox.Show("Peran pengguna tidak dikenal.")
                        End Select
                    Else
                        MessageBox.Show("Username atau Password salah!")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan dalam memproses respons server.")
                End Try
            Else
                MessageBox.Show("Username atau Password salah!")
            End If
        End If
    End Sub

    Public Sub ClearFields()
        txtuser.Text = String.Empty
        txtpass.Text = String.Empty
    End Sub

    Private Sub txtusernane_GotFocus(sender As Object, e As EventArgs) Handles txtuser.GotFocus
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusernane_LostFocus(sender As Object, e As EventArgs) Handles txtuser.LostFocus
        If txtuser.Text = "" Then
            txtuser.Text = "Username"
            txtuser.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtpassword_GotFocus(sender As Object, e As EventArgs) Handles txtpass.GotFocus
        If txtpass.Text = "Password" Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpassword_Layout(sender As Object, e As LayoutEventArgs) Handles txtpass.Layout
        If txtpass.Text = "" Then
            txtpass.Text = "Password"
            txtpass.ForeColor = Color.DarkGray
        End If
    End Sub
End Class