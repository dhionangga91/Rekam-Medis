Imports MySql.Data.MySqlClient
Public Class login

    Dim koneksi = Module1.Koneksi

    Private Sub login_Activated(ByVal seder As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtuser.Focus()
    End Sub
    Private Sub Btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpass.Focus()
        End If
    End Sub

    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(13) Then
            btnlogin.Focus()
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim aksi As String = String.Empty
        aksi = "select * from user where id_user = '" + txtuser.Text + "' AND password = '" + txtpass.Text + "'"
        Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
        Dim myreader As MySqlDataReader
        myreader = sqlku.ExecuteReader
        If myreader.HasRows = 0 Then
            MsgBox("username atau password ada yang salah !", MsgBoxStyle.Exclamation, "Error login")
            txtuser.Clear()
            txtpass.Clear()
            txtuser.Focus()
        Else
            MsgBox("Login berhasil,Selamat Datang " & txtuser.Text & "!", MsgBoxStyle.Information, "Succesfull login")
            MenuUtama.Show()
            Me.Hide()
        End If
    End Sub
End Class