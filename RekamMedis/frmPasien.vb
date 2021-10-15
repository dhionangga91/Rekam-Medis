Imports MySql.Data.MySqlClient
Public Class frmPasien
    Dim Gender As String
    Dim koneksi = Module1.Koneksi
    Sub formkosong()
        txtno.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
        rblaki.Checked = True
        rbperempuan.Checked = False
        cbagama.Text = ""
        dtlahir.Text = ""
        txtno.Focus()

    End Sub
    Sub FormNormal()
        Call formkosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnkeluar.Text = "Keluar"
    End Sub
    Sub kunci()
        txtno.Enabled = False
        txtnama.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False
        rblaki.Enabled = False
        rbperempuan.Enabled = False
        cbagama.Enabled = False
        dtlahir.Enabled = False
    End Sub

    Sub buka()
        txtno.Enabled = True
        txtnama.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
        rblaki.Enabled = True
        rbperempuan.Enabled = True
        cbagama.Enabled = True
        dtlahir.Enabled = True
    End Sub

    Sub GridBerwarna()
        With Me.dgpasien
            .RowHeadersDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    Sub Panggildata()
        Dim Adapter As New MySqlDataAdapter("select * from pasien", Module1.Koneksi)
        Dim dt As New DataTable("pasien")
        Adapter.Fill(dt)
        dgpasien.DataSource = dt
    End Sub
    Private Sub frmPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtalamat.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call buka()
        txtno.Focus()
        Call Panggildata()

    End Sub

    Private Sub frmPasien_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call kunci()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call Panggildata()
        Dim Sql As String = String.Empty
        If rblaki.Checked = True Then
            Gender = rblaki.Text
        ElseIf rbperempuan.Checked = True Then
            Gender = rbperempuan.Text
        End If
        If txtno.Text <> "" Then
            Sql = "Insert INTO pasien(no_pasien,nama_pasien,alamat,Jenis_kelamin,agama,tgl_lahir,telp)" & "Values('" & txtno.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & Gender & "','" & cbagama.Text & "','" & Format(dtlahir.Value, "yyyy-MM-dd") & "','" & txttelp.Text & "')"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtno.Text & " Sudah disimpan", "Simpan Data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Isikan dulu data", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtno.Focus()
        End If
        Call formkosong()
        Call Panggildata()
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

    Private Sub rbperempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbperempuan.CheckedChanged

    End Sub

    Private Sub dgpasien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgpasien.CellContentClick

    End Sub

    Private Sub dgpasien_Click(sender As Object, e As EventArgs) Handles dgpasien.Click
        Dim i As Integer
        i = dgpasien.CurrentRow.Index
        txtno.Text = dgpasien.Item(0, i).Value
        txtnama.Text = dgpasien.Item(1, i).Value
        txtalamat.Text = dgpasien.Item(2, i).Value
        If dgpasien.Item(3, i).Value = "laki-laki" Then
            rblaki.Checked = True
        Else
            rbperempuan.Checked = True
        End If
        cbagama.Text = dgpasien.Item(4, i).Value
        dtlahir.Text = dgpasien.Item(5, i).Value
        txttelp.Text = dgpasien.Item(6, i).Value
        Call buka()
        txtno.Enabled = False
        btnhapus.Enabled = True
        btnubah.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgpasien.CurrentRow.Index > -1 Then
            Dim Sql As String = String.Empty
            Sql = "Delete from pasien where no_pasien = '" & txtno.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan Kode " & txtno.Text & "Sudah dihapus", "Penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call formkosong()
            Call Panggildata()
            btnhapus.Enabled = False
            btnubah.Enabled = False
        Else
            MessageBox.Show("Pilih dulu data yang akan dihapus", "Tidak ada data yang akan dihapus", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnubah.Click
        Dim Sql As String = String.Empty
        If rblaki.Checked = True Then
            Gender = rblaki.Text
        ElseIf rbperempuan.Checked = True Then
            Gender = rbperempuan.Text
        End If
        Sql = "UPDATE pasien SET no_pasien= '" & txtno.Text & "'," & "nama_pasien='" & txtnama.Text & "',Jenis_kelamin = '" & Gender & "',agama = '" & cbagama.Text & "',alamat = '" & txtalamat.Text & "',tgl_lahir = '" & Format(dtlahir.Value, "yyyy-MM-dd") & "',telp = '" & txttelp.Text & "'Where no_pasien = '" & txtno.Text & "'"
        Dim command As New MySqlCommand(Sql, Module1.Koneksi)
        command.ExecuteNonQuery()
        Module1.Koneksi.Close()
        MessageBox.Show("Data dengan no_pasien " & txtno.Text & "Sudah diupdate", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call formkosong()
        Call Panggildata()
        btnhapus.Enabled = False
        btnubah.Enabled = False
    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(13) Then
            rblaki.Focus()
        End If
    End Sub

    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnama.Focus()
        End If

    End Sub

    Private Sub txttelp_TextChanged(sender As Object, e As EventArgs) Handles txttelp.TextChanged

    End Sub

    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtno_TextChanged(sender As Object, e As EventArgs) Handles txtno.TextChanged

    End Sub
End Class
