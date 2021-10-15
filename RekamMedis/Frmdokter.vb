Imports MySql.Data.MySqlClient
Public Class Frmdokter

    Dim Gender As String
    Dim koneksi = Module1.Koneksi
    Sub formkosong()
        txtkodedokter.Text = ""
        txtnama.Text = ""
        txtsip.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
        txtkodedokter.Focus()

    End Sub
    Sub FormNormal()
        Call formkosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnkeluar.Text = "Keluar"
    End Sub
    Sub kunci()
        txtkodedokter.Enabled = False
        txtnama.Enabled = False
        txtsip.Enabled = False
        txtalamat.Enabled = False
        txttelp.Enabled = False
    End Sub

    Sub buka()
        txtkodedokter.Enabled = True
        txtnama.Enabled = True
        txtsip.Enabled = True
        txtalamat.Enabled = True
        txttelp.Enabled = True
    End Sub

    Sub GridBerwarna()
        With Me.dgdokter
            .RowHeadersDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    Sub Panggildata()
        Dim Adapter As New MySqlDataAdapter("select * from dokter", Module1.Koneksi)
        Dim dt As New DataTable("dokter")
        Adapter.Fill(dt)
        dgdokter.DataSource = dt
        Call GridBerwarna()
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call buka()
        Call formkosong()
        Call Panggildata()
        btnsimpan.Enabled = True
        btntambah.Enabled = False
        btnubah.Enabled = False
        btnhapus.Enabled = False
        btnkeluar.Text = "Keluar"
        txtkodedokter.Focus()

    End Sub
    Private Sub frmdokter_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call kunci()
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call Panggildata()
        Dim Sql As String = String.Empty
        If txtkodedokter.Text <> "" Then
            Sql = "Insert INTO dokter(kd_dokter,nama_dokter,sip,alamat,telp)" & "Values('" & txtkodedokter.Text & "','" & txtnama.Text & "','" & txtsip.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "')"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & txtkodedokter.Text & " Sudah disimpan", "Simpan Data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Isikan dulu data", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkodedokter.Focus()
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

    Private Sub dgdokter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdokter.Click
        Dim i As Integer
        i = dgdokter.CurrentRow.Index
        txtkodedokter.Text = dgdokter.Item(0, i).Value
        txtnama.Text = dgdokter.Item(1, i).Value
        txtsip.Text = dgdokter.Item(2, i).Value
        txtalamat.Text = dgdokter.Item(3, i).Value
        txttelp.Text = dgdokter.Item(4, i).Value
        Call buka()
        txtkodedokter.Enabled = False
        btnhapus.Enabled = True
        btnubah.Enabled = True
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgdokter.CurrentRow.Index > -1 Then
            Dim Sql As String = String.Empty
            Sql = "Delete from dokter where kd_dokter = '" & txtkodedokter.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan Kode " & txtkodedokter.Text & "Sudah dihapus", "Penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Sql = "UPDATE dokter SET kd_dokter= '" & txtkodedokter.Text & "'," & "nama_dokter='" & txtnama.Text & "'," & "sip='" & txtsip.Text & "',alamat = '" & txtalamat.Text & "',telp = '" & txttelp.Text & "'WHERE kd_dokter = '" & txtkodedokter.Text & "'"
        Dim command As New MySqlCommand(Sql, Module1.Koneksi)
        command.ExecuteNonQuery()
        Module1.Koneksi.Close()
        MessageBox.Show("Data dengan kd_dokter " & txtkodedokter.Text & "Sudah diupdate", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call formkosong()
        Call Panggildata()
        btnhapus.Enabled = False
        btnubah.Enabled = False
    End Sub


    Private Sub txttelp_TextChanged(sender As Object, e As EventArgs) Handles txttelp.TextChanged

    End Sub

    Private Sub txttelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtkodedokter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodedokter.KeyPress
        If e.KeyChar = Chr(13) Then
            txtnama.Focus()
        End If
        Dim adapter As New MySqlDataAdapter("SELECT * from dokter where kd_dokter ='" & txtkodedokter.Text & "'", Module1.Koneksi)
        Dim dt As New DataTable("dokter")
        adapter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            MessageBox.Show("Data dengan kode " & txtkodedokter.Text & "Sudah ada,inputkan data lain", "Ditemukan data sama", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtkodedokter.Text = ""
        End If
        dgdokter.DataSource = dt
    End Sub

    Private Sub dgdokter_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdokter.CellContentClick

    End Sub

    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnama.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtsip.Focus()
        End If
    End Sub

    Private Sub txtsip_KeyPress(ByVal sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtsip.KeyPress
        If e.KeyChar = Chr(13) Then
            txtalamat.Focus()
        End If
    End Sub

    Private Sub txtalamat_KeyPress(ByVal sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtalamat.KeyPress
        If e.KeyChar = Chr(13) Then
            txttelp.Focus()
        End If
    End Sub

End Class