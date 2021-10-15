Imports MySql.Data.MySqlClient
Public Class frmobat

    Dim Gender As String
    Dim koneksi = Module1.Koneksi
    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader
    Sub formkosong()
        kdobat.Text = ""
        txtnama.Text = ""
        txtdosis.Text = ""
        txtharga.Text = ""
        txtjenis.Text = ""
        txtstok.Text = ""
        kdobat.Focus()

    End Sub
    Sub FormNormal()
        Call formkosong()
        btntambah.Enabled = True
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnkeluar.Text = "Keluar"
    End Sub
    Sub kunci()
        kdobat.Enabled = False
        txtnama.Enabled = False
        txtdosis.Enabled = False
        txtharga.Enabled = False
        txtjenis.Enabled = False
        txtstok.Enabled = False
    End Sub

    Sub buka()
        kdobat.Enabled = True
        txtnama.Enabled = True
        txtharga.Enabled = True
        txtdosis.Enabled = True
        txtjenis.Enabled = True
        txtstok.Enabled = True
    End Sub

    Sub GridBerwarna()
        With Me.dgobat
            .RowHeadersDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    Sub Panggildata()
        Dim Adapter As New MySqlDataAdapter("select * from obat", Module1.Koneksi)
        Dim dt As New DataTable("obat")
        Adapter.Fill(dt)
        dgobat.DataSource = dt
        Call GridBerwarna()
    End Sub


    Private Sub frmobat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call buka()
        Call formkosong()
        Call Panggildata()
        Call kode_otomatis()
        kdobat.Enabled = False
        txtnama.Focus()
        btnsimpan.Enabled = True
        btntambah.Enabled = True
        btnhapus.Enabled = True
        btnubah.Enabled = True
        kdobat.Focus()
    End Sub

    Private Sub frmobat_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call kunci()
    End Sub

    Sub kode_otomatis()
        CMD = New MySqlCommand("Select* from obat where kd_obat in(select max(kd_obat) from obat)", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows = 0 Then
            kdobat.Text = "OBT001"
            RD.Close()
        End If
        If Not RD.HasRows Then
            kdobat.Text = "OBT" + "001"
            RD.Close()
        Else
            kdobat.Text = Val(Microsoft.VisualBasic.Mid(RD.Item("kd_obat").ToString, 4, 3)) + 1
            If Len(kdobat.Text) = 1 Then
                kdobat.Text = "OBT00" & kdobat.Text & ""
            ElseIf Len(kdobat.Text) = 2 Then
                kdobat.Text = "OBT0" & kdobat.Text & ""
            ElseIf Len(kdobat.Text) = 3 Then
                kdobat.Text = "OBT" & kdobat.Text & ""
            End If
            RD.Close()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call Panggildata()
        Dim Sql As String = String.Empty

        If kdobat.Text <> "" Then
            Sql = "Insert INTO obat(kd_obat,nama_obat,dosis,harga,jenis,stok)" & "Values('" & kdobat.Text & "','" & txtnama.Text & "','" & txtdosis.Text & "','" & txtharga.Text & "','" & txtjenis.Text & "','" & txtstok.Text & "')"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode " & kdobat.Text & " Sudah disimpan", "Simpan Data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Isikan dulu data", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kdobat.Focus()
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
    Private Sub dgobat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgobat.CellContentClick

    End Sub
    Private Sub dgobat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgobat.Click

        Dim i As Integer
        i = dgobat.CurrentRow.Index
        kdobat.Text = dgobat.Item(0, i).Value
        txtnama.Text = dgobat.Item(1, i).Value
        txtdosis.Text = dgobat.Item(2, i).Value
        txtharga.Text = dgobat.Item(3, i).Value
        txtjenis.Text = dgobat.Item(4, i).Value
        txtstok.Text = dgobat.Item(5, i).Value
        Call buka()
        kdobat.Enabled = False
        btnhapus.Enabled = True
        btnubah.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgobat.CurrentRow.Index > -1 Then
            Dim Sql As String = String.Empty
            Sql = "Delete from obat where kd_obat = '" & kdobat.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan Kode " & kdobat.Text & "Sudah dihapus", "Penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        Sql = "UPDATE obat SET kd_obat= '" & kdobat.Text & "'," & "nama_obat='" & txtnama.Text & "'," & "dosis='" & txtdosis.Text & "'," & "harga='" & txtharga.Text & "',jenis = '" & txtjenis.Text & "',stok = '" & txtstok.Text & "'Where kd_obat = '" & kdobat.Text & "'"
        Dim command As New MySqlCommand(Sql, Module1.Koneksi)
        command.ExecuteNonQuery()
        Module1.Koneksi.Close()
        MessageBox.Show("Data dengan kd_obat" & kdobat.Text & "Sudah diupdate", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call formkosong()
        Call Panggildata()
        btnhapus.Enabled = False
        btnubah.Enabled = False
    End Sub


    Private Sub txtharga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtharga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

End Class