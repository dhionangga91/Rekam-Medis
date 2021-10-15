Imports MySql.Data.MySqlClient
Public Class user
    Dim koneksi = Module1.Koneksi
    Sub formkosong()
        txtkode.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtkode.Focus()
    End Sub

    Sub buka()
        txtkode.Enabled = True
        txtuser.Enabled = True
        txtpass.Enabled = True
    End Sub

    Sub kunci()
        txtkode.Enabled = False
        txtuser.Enabled = False
        txtpass.Enabled = False
    End Sub

    Sub formnormal()
        Call formkosong()
        btntambah.Enabled = True
        btnhapus.Enabled = True
        btnsimpan.Enabled = True
        btnkeluar.Enabled = True
    End Sub

    Sub GridBerwarna()
        With Me.dguser
            .RowsDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub

    Sub panggildata()
        Dim adapter As New MySqlDataAdapter("select * from user", Module1.Koneksi)
        Dim dt As New DataTable("user")
        adapter.Fill(dt)
        dguser.DataSource = dt
        Call GridBerwarna()
    End Sub

    Private Sub btntambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call buka()
        Call formkosong()
        Call panggildata()
        btnsimpan.Enabled = True
        btntambah.Enabled = True
        btnhapus.Enabled = True
        btnubah.Enabled = True
        btnkeluar.Text = "Keluar"
        txtkode.Focus()
    End Sub

    Private Sub user_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call kunci()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim sql As String = String.Empty
        If txtkode.Text <> "" Then
            sql = "INSERT INTO user(id_user,nama_user,password)" & "VALUES ('" & txtkode.Text & "','" & txtuser.Text & "','" & txtpass.Text & "')"
            Dim command As New MySqlCommand(sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & "Sudah disimpan", "Simpan Data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Isikan dulu data", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkode.Focus()
        End If
        Call formkosong()
        Call panggildata()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Dim a As Integer
        a = MsgBox("Anda yakin akan keluar?", vbYesNo, "Warning")
        If a = vbYes Then
            Me.Close()
        Else
            Call buka()
        End If
    End Sub
    Private Sub dguser_Cellformatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dguser.CellFormatting
        If (e.ColumnIndex <> -1 AndAlso
            dguser.Columns(e.ColumnIndex).DataPropertyName = "password") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtuser.Focus()
        End If
        Dim adapter As New MySqlDataAdapter("SELECT * from user where id_user = '" & txtkode.Text & "'", Module1.Koneksi)
        Dim dt As New DataTable("user")
        adapter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            MessageBox.Show("Data dengan kode " & txtkode.Text & "Sudah ada,cari yang lain", "Ditemukan data sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkode.Text = ""
        End If
        dguser.DataSource = dt
    End Sub

    Private Sub dguser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dguser.Click
        Dim i As Integer
        i = dguser.CurrentRow.Index
        txtkode.Text = dguser.Item(0, i).Value
        txtuser.Text = dguser.Item(1, i).Value
        txtpass.Text = dguser.Item(2, i).Value
        Call buka()
        txtkode.Enabled = False
        btnhapus.Enabled = True
        btnubah.Enabled = True
    End Sub

    Private Sub btnhapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        If dguser.CurrentRow.Index > -1 Then
            Dim sql As String = String.Empty
            sql = "Delete from user where id_user ='" & txtkode.Text & "'"
            Dim command As New MySqlCommand(sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkode.Text & "Sudah dihapus", "penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call formkosong()
            Call panggildata()
            btnhapus.Enabled = False
            btnubah.Enabled = False
        Else
            MessageBox.Show("Pilih data yang akan dihapus", "Tidak ada yang dipilih", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnubah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Dim sql As String = String.Empty
        sql = "UPDATE user SET id_user = '" & txtkode.Text & "'," & "nama_user='" & txtuser.Text & "',password = '" & txtpass.Text & "' WHERE id_user='" & txtkode.Text & "'"
        Dim command As New MySqlCommand(sql, Module1.Koneksi)
        command.ExecuteNonQuery()
        Module1.Koneksi.Close()
        MessageBox.Show("Data dengan kode " & txtkode.Text & "Sudah di update", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call formkosong()
        Call panggildata()
        btnhapus.Enabled = False
        btnubah.Enabled = False
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtpass.Focus()
        End If
    End Sub
    Private Sub txtpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnsimpan.Focus()
        End If
    End Sub

End Class