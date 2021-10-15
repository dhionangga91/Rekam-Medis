Imports MySql.Data.MySqlClient
Public Class frmrekammedis

    Dim CMD As MySqlCommand
    Dim RD As MySqlDataReader
    Dim Gender As String
    Dim koneksi = Module1.Koneksi
    Sub formkosong()
        txtrekam.Text = ""
        txtno.Text = ""
        txtnamapasien.Text = ""
        txtalamat.Text = ""
        txtkodedokter.Text = ""
        txtnamadokter.Text = ""
        txttelp.Text = ""
        txtkeluhan.Text = ""
        txtdiagnosa.Text = ""
        txtketerangan.Text = ""
        kdobat.Text = ""
        txtnamaobat.Text = ""
        txthargaobat.Text = ""
        txtjumlahobat.Text = ""
        txtbiayadokter.Text = ""
        txtbiayaobat.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""
        txtrekam.Focus()

    End Sub
    Sub FormNormal()
        Call formkosong()
        btntambah.Enabled = True
        btntotal.Enabled = True
        btnsimpan.Enabled = False
        btnkeluar.Text = "Keluar"
    End Sub

    Sub Kode_Otomatis()

        Dim Urutan As String
        Dim Hitung, Cari As Long
        CMD = New MySqlCommand("Select * from rekam_medis where no_rekam in(select max(no_rekam)from rekam_medis)", koneksi)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Urutan = "RKM/" & Date.Now.Year & "/" & "000001"
        Else
            Cari = Microsoft.VisualBasic.Right(RD.GetString(0), 6)
            If Microsoft.VisualBasic.Left(RD.Getstring(0), 9) <> "RKM/" & Date.Now.Year & "/" Then
                Urutan = "RKM/" & Date.Now.Year & "/" & "000001"
            Else
                Hitung = Microsoft.VisualBasic.Right(RD.GetString(0), 6) + 1
                Urutan = "RKM/" & Date.Now.Year & "/" & Microsoft.VisualBasic.Right("000000" & Hitung, 6)
            End If
        End If
        RD.Close()
        txtrekam.Text = Urutan
    End Sub
    Sub kunci()
        dttgl.Enabled = False
        txtrekam.Enabled = False
        txtno.Enabled = False
        txtnamapasien.Enabled = False
        txtalamat.Enabled = False
        txtkodedokter.Enabled = False
        txtnamadokter.Enabled = False
        txttelp.Enabled = False
        txtkeluhan.Enabled = False
        txtdiagnosa.Enabled = False
        txtketerangan.Enabled = False
        kdobat.Enabled = False
        txtnamaobat.Enabled = False
        txthargaobat.Enabled = False
        txtjumlahobat.Enabled = False
        txtbiayadokter.Enabled = False
        txtbiayaobat.Enabled = False
        txttotal.Enabled = False
        txtbayar.Enabled = False
        txtkembali.Enabled = False
    End Sub

    Sub buka()
        dttgl.Enabled = True
        txtrekam.Enabled = True
        txtno.Enabled = True
        txtnamapasien.Enabled = True
        txtalamat.Enabled = True
        txtkodedokter.Enabled = True
        txtnamadokter.Enabled = True
        txttelp.Enabled = True
        txtkeluhan.Enabled = True
        txtdiagnosa.Enabled = True
        txtketerangan.Enabled = True
        kdobat.Enabled = True
        txtnamaobat.Enabled = True
        txthargaobat.Enabled = True
        txtjumlahobat.Enabled = True
        txtbiayadokter.Enabled = True
        txtbiayaobat.Enabled = True
        txttotal.Enabled = True
        txtbayar.Enabled = True
        txtkembali.Enabled = True

    End Sub

    Sub GridBerwarna()
        With Me.dgrekammedis
            .RowHeadersDefaultCellStyle.BackColor = Color.BlanchedAlmond
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        End With
    End Sub
    Sub Panggildata()
        Dim Adapter As New MySqlDataAdapter("Select * from rekam_medis", Module1.Koneksi)
        Dim dt As New DataTable("rekam_medis")
        Adapter.Fill(dt)
        dgrekammedis.DataSource = dt
        Call GridBerwarna()
    End Sub


    Private Sub frmrekammedis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Call buka()
        Call formkosong()
        Kode_Otomatis()
        txtrekam.Enabled = False
        txtno.Focus()
    End Sub
    Private Sub frmrekammedis_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call kunci()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Dim Sql As String = String.Empty
        Dim jumlah_obat As Integer
        For i As Integer = 0 To dgrekammedis.RowCount - 1
            jumlah_obat += dgrekammedis.Item(4, i).Value
        Next
        kdobat.Text = kdobat.ToString
        txtjumlahobat.Text = jumlah_obat.ToString
        If txtrekam.Text <> "" Then
            Sql = "Insert INTO rekam_medis(no_rekam,tgl,keluhan,diagnosa,keterangan,jumlah_obat,biaya_dokter,biaya_obat,total,kd_dokter,no_pasien)" &
                "Values('" & txtrekam.Text & "','" & Format(dttgl.Value, "yyyy-MM-dd") & "','" & txtkeluhan.Text & "','" & txtdiagnosa.Text & "','" & txtketerangan.Text & "','" & txtjumlahobat.Text & "','" & txtbiayadokter.Text & "','" & txtbiayaobat.Text & "','" & txttotal.Text & "','" & txtkodedokter.Text & "','" & txtno.Text & "')"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan kode" & txtrekam.Text & " Sudah disimpan", "Simpan Data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Isikan dulu data", "Simpan gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtrekam.Focus()
        End If
        Call formkosong()
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

    Private Sub PrintDocument1_printpage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Nomor Rekam :", Font, Brushes.Black, 50, 50)
        e.Graphics.DrawString(txtrekam.Text, txtno.Font, Brushes.Black, 150, 50)
        e.Graphics.DrawString("Tanggal :", Font, Brushes.Black, 320, 50)
        e.Graphics.DrawString(dttgl.Text, dttgl.Font, Brushes.Black, 400, 50)
        e.Graphics.DrawString("Nama Pasien :", Font, Brushes.Black, 50, 70)
        e.Graphics.DrawString(txtnamapasien.Text, txtnamapasien.Font, Brushes.Black, 150, 70)
        e.Graphics.DrawString("Nama Dokter :", Font, Brushes.Black, 50, 90)
        e.Graphics.DrawString(txtnamadokter.Text, txtnamadokter.Font, Brushes.Black, 150, 90)
        e.Graphics.DrawString("Keluhan :", Font, Brushes.Black, 50, 110)
        e.Graphics.DrawString(txtkeluhan.Text, txtkeluhan.Font, Brushes.Black, 150, 110)
        e.Graphics.DrawString("Diagnosa :", Font, Brushes.Black, 50, 50)
        e.Graphics.DrawString(txtdiagnosa.Text, txtdiagnosa.Font, Brushes.Black, 50, 130)
        e.Graphics.DrawString("Biaya Dokter :", Font, Brushes.Black, 50, 150)
        e.Graphics.DrawString(txtbiayadokter.Text, txtbiayadokter.Font, Brushes.Black, 150, 150)
        e.Graphics.DrawString("Biaya Obat :", Font, Brushes.Black, 320, 150)
        e.Graphics.DrawString(txtbiayaobat.Text, txtbiayaobat.Font, Brushes.Black, 400, 150)
        e.Graphics.DrawString("Total :", Font, Brushes.Black, 50, 170)
        e.Graphics.DrawString(txttotal.Text, txttotal.Font, Brushes.Black, 150, 170)
        e.Graphics.DrawString("Bayar :", Font, Brushes.Black, 320, 170)
        e.Graphics.DrawString(txtbayar.Text, txtbayar.Font, Brushes.Black, 400, 170)
        e.Graphics.DrawString("Kembali :", Font, Brushes.Black, 320, 190)
        e.Graphics.DrawString(txtkembali.Text, txtkembali.Font, Brushes.Black, 200, 250)
        e.Graphics.DrawString("----------Terima Kasih atas kunjungan anda,semoga lekas sembuh----------", Font, Brushes.Black, 200, 250)
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If dgrekammedis.CurrentRow.Index > -1 Then
            Dim Sql As String = String.Empty
            Sql = "Delete from rekam_medis where no_rekam = '" & txtrekam.Text & "'"
            Dim command As New MySqlCommand(Sql, Module1.Koneksi)
            command.ExecuteNonQuery()
            Module1.Koneksi.Close()
            MessageBox.Show("Data dengan Kode " & txtrekam.Text & "Sudah dihapus", "Penghapusan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Sql = "UPDATE rekam_medis SET no_rekam= '" & txtrekam.Text & "',tgl = '" & Format(dttgl.Value, "yyyy-MM-dd") & "',keluhan = '" & txtkeluhan.Text & "',diagnosa = '" & txtdiagnosa.Text & "',keterangan = '" & txtketerangan.Text & "', jumlah_obat = '" & txtjumlahobat.Text & "',biaya_dokter = '" & txtbiayadokter.Text & "',biaya_obat = '" & txtbiayaobat.Text & "',total = '" & txttotal.Text & "',kd_dokter = '" & txtkodedokter.Text & "',no_pasien = '" & txtno.Text & "'Where no_rekam = '" & txtrekam.Text & "'"
        Dim command As New MySqlCommand(Sql, Module1.Koneksi)
        command.ExecuteNonQuery()
        Module1.Koneksi.Close()
        MessageBox.Show("Data dengan no_pasien" & txtrekam.Text & "Sudah diupdate", "Update data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call formkosong()
        Call Panggildata()
        btnhapus.Enabled = False
        btnubah.Enabled = False
    End Sub

    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from pasien where no_pasien ='" & txtno.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnamapasien.Text = myreader.Item(1)
                txtalamat.Text = myreader.Item(2)
                txtkodedokter.Focus()
                txtnamapasien.Enabled = False
                txtalamat.Enabled = False
            Else
                MessageBox.Show("Kode pasien tidak terdaftar...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtno.Text = ""
                txtno.Focus()
            End If
        End If
    End Sub

    Private Sub txtkodedokter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkodedokter.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from dokter where kd_dokter ='" & txtkodedokter.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnamadokter.Text = myreader.Item(1)
                txttelp.Text = myreader.Item(4)
                txtkeluhan.Focus()
                txtnamadokter.Enabled = False
                txttelp.Enabled = False
            Else
                MessageBox.Show("Kode dokter tidak terdaftar...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtkodedokter.Text = ""
                txtkodedokter.Focus()
            End If
        End If
    End Sub

    Private Sub kdobat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kdobat.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim aksi As String = String.Empty
            aksi = "select * from obat where kd_obat ='" & kdobat.Text & "'"
            Dim sqlku As New MySqlCommand(aksi, Module1.Koneksi)
            Dim myreader As MySqlDataReader
            myreader = sqlku.ExecuteReader
            If myreader.Read Then
                txtnamaobat.Text = myreader.Item(1)
                txthargaobat.Text = myreader.Item(3)
                txtjumlahobat.Focus()
            Else
                MessageBox.Show("Kode obat tidak terdaftar...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                kdobat.Text = ""
                kdobat.Focus()
            End If
        End If
    End Sub

    Private Sub txtjumlahobat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlahobat.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dgrekammedis.RowCount = dgrekammedis.RowCount + 1
            dgrekammedis(0, dgrekammedis.RowCount - 2).Value = kdobat.Text
            dgrekammedis(1, dgrekammedis.RowCount - 2).Value = txtnamaobat.Text
            dgrekammedis(2, dgrekammedis.RowCount - 2).Value = txthargaobat.Text
            dgrekammedis(3, dgrekammedis.RowCount - 2).Value = txtjumlahobat.Text
            dgrekammedis(4, dgrekammedis.RowCount - 2).Value = txtjumlahobat.Text * txthargaobat.Text
            If kdobat.Text = "" Then
                MsgBox("data masih kosong broooo")
            End If
            kdobat.Clear()
            txtnamaobat.Clear()
            txthargaobat.Clear()
            txtjumlahobat.Clear()
            kdobat.Focus()
        End If
    End Sub


    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        Dim total As Integer
        For i As Integer = 0 To dgrekammedis.RowCount - 1
            total += dgrekammedis.Item(4, i).Value
        Next
        txtbiayaobat.Text = Val(txtjumlahobat.Text) * Val(txthargaobat.Text)
        txtbiayadokter.Text = 200000
        txttotal.Text = Val(txtbiayadokter.Text) + Val(txtbiayaobat.Text)
        txtbayar.Focus()
    End Sub

    Private Sub txtbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbayar.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtkembali.Text = txtbayar.Text - txttotal.Text
            Call kunci()
        End If
    End Sub

    Private Sub txtkeluhan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkeluhan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtdiagnosa.Focus()
        End If
    End Sub
    Private Sub txtdiagnosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdiagnosa.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtketerangan.Focus()
        End If
    End Sub
    Private Sub txtketerangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtketerangan.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            kdobat.Focus()
        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        With PrintDocument1
            .PrinterSettings.DefaultPageSettings.Landscape = False
            .Print()
        End With
    End Sub

    Private Sub dgrekammedis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgrekammedis.Click
        Dim i As Integer
        i = dgrekammedis.CurrentRow.Index
        txtrekam.Text = dgrekammedis.Item(0, i).Value
        dttgl.Text = dgrekammedis.Item(1, i).Value
        txtkeluhan.Text = dgrekammedis.Item(2, i).Value
        txtdiagnosa.Text = dgrekammedis.Item(3, i).Value
        txtketerangan.Text = dgrekammedis.Item(4, i).Value
        txtjumlahobat.Text = dgrekammedis.Item(5, i).Value
        txtbiayadokter.Text = dgrekammedis.Item(6, i).Value
        txtbiayaobat.Text = dgrekammedis.Item(7, i).Value
        txttotal.Text = dgrekammedis.Item(8, i).Value
        txtkodedokter.Text = dgrekammedis.Item(9, i).Value
        txtno.Text = dgrekammedis.Item(10, i).Value
        Call buka()
        txtrekam.Enabled = False
        btnhapus.Enabled = True
        btnubah.Enabled = True
    End Sub

    Private Sub kdobat_TextChanged(sender As Object, e As EventArgs) Handles kdobat.TextChanged

    End Sub
End Class