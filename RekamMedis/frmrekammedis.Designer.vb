<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrekammedis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgrekammedis = New System.Windows.Forms.DataGridView()
        Me.txtrekam = New System.Windows.Forms.TextBox()
        Me.kdobat = New System.Windows.Forms.TextBox()
        Me.txtkodedokter = New System.Windows.Forms.TextBox()
        Me.txtbiayaobat = New System.Windows.Forms.TextBox()
        Me.txtbiayadokter = New System.Windows.Forms.TextBox()
        Me.txtjumlahobat = New System.Windows.Forms.TextBox()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.txtdiagnosa = New System.Windows.Forms.TextBox()
        Me.txtkeluhan = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.dttgl = New System.Windows.Forms.DateTimePicker()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnamapasien = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txthargaobat = New System.Windows.Forms.TextBox()
        Me.txtnamaobat = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnprint = New System.Windows.Forms.Button()
        CType(Me.dgrekammedis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Rekam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Dokter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nomor Pasien"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Obat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Keterangan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Diagnosa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Keluhan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(264, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tanggal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Kode Obat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Biaya Obat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Biaya Dokter"
        '
        'dgrekammedis
        '
        Me.dgrekammedis.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgrekammedis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrekammedis.Location = New System.Drawing.Point(12, 328)
        Me.dgrekammedis.Name = "dgrekammedis"
        Me.dgrekammedis.Size = New System.Drawing.Size(886, 105)
        Me.dgrekammedis.TabIndex = 12
        '
        'txtrekam
        '
        Me.txtrekam.Location = New System.Drawing.Point(107, 19)
        Me.txtrekam.Name = "txtrekam"
        Me.txtrekam.Size = New System.Drawing.Size(100, 20)
        Me.txtrekam.TabIndex = 13
        '
        'kdobat
        '
        Me.kdobat.Location = New System.Drawing.Point(81, 26)
        Me.kdobat.Name = "kdobat"
        Me.kdobat.Size = New System.Drawing.Size(100, 20)
        Me.kdobat.TabIndex = 14
        '
        'txtkodedokter
        '
        Me.txtkodedokter.Location = New System.Drawing.Point(94, 30)
        Me.txtkodedokter.Name = "txtkodedokter"
        Me.txtkodedokter.Size = New System.Drawing.Size(100, 20)
        Me.txtkodedokter.TabIndex = 15
        '
        'txtbiayaobat
        '
        Me.txtbiayaobat.Location = New System.Drawing.Point(94, 59)
        Me.txtbiayaobat.Name = "txtbiayaobat"
        Me.txtbiayaobat.Size = New System.Drawing.Size(100, 20)
        Me.txtbiayaobat.TabIndex = 16
        '
        'txtbiayadokter
        '
        Me.txtbiayadokter.Location = New System.Drawing.Point(94, 26)
        Me.txtbiayadokter.Name = "txtbiayadokter"
        Me.txtbiayadokter.Size = New System.Drawing.Size(100, 20)
        Me.txtbiayadokter.TabIndex = 17
        '
        'txtjumlahobat
        '
        Me.txtjumlahobat.Location = New System.Drawing.Point(81, 117)
        Me.txtjumlahobat.Name = "txtjumlahobat"
        Me.txtjumlahobat.Size = New System.Drawing.Size(100, 20)
        Me.txtjumlahobat.TabIndex = 18
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(95, 187)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(100, 20)
        Me.txtketerangan.TabIndex = 19
        '
        'txtdiagnosa
        '
        Me.txtdiagnosa.Location = New System.Drawing.Point(95, 154)
        Me.txtdiagnosa.Name = "txtdiagnosa"
        Me.txtdiagnosa.Size = New System.Drawing.Size(100, 20)
        Me.txtdiagnosa.TabIndex = 20
        '
        'txtkeluhan
        '
        Me.txtkeluhan.Location = New System.Drawing.Point(95, 120)
        Me.txtkeluhan.Name = "txtkeluhan"
        Me.txtkeluhan.Size = New System.Drawing.Size(100, 20)
        Me.txtkeluhan.TabIndex = 21
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(94, 117)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 22
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(95, 23)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(100, 20)
        Me.txtno.TabIndex = 23
        '
        'dttgl
        '
        Me.dttgl.Location = New System.Drawing.Point(334, 19)
        Me.dttgl.Name = "dttgl"
        Me.dttgl.Size = New System.Drawing.Size(200, 20)
        Me.dttgl.TabIndex = 24
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.Location = New System.Drawing.Point(12, 290)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 25
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.Location = New System.Drawing.Point(172, 290)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 26
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnubah.Location = New System.Drawing.Point(334, 290)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 27
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.Location = New System.Drawing.Point(506, 290)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 28
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnkeluar.Location = New System.Drawing.Point(823, 290)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 29
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.txtkeluhan)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdiagnosa)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtnamapasien)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtketerangan)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 221)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pasien"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(95, 87)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 20)
        Me.txtalamat.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Alamat"
        '
        'txtnamapasien
        '
        Me.txtnamapasien.Location = New System.Drawing.Point(95, 55)
        Me.txtnamapasien.Name = "txtnamapasien"
        Me.txtnamapasien.Size = New System.Drawing.Size(100, 20)
        Me.txtnamapasien.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Nama Pasien"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txthargaobat)
        Me.GroupBox2.Controls.Add(Me.txtnamaobat)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.kdobat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtjumlahobat)
        Me.GroupBox2.Location = New System.Drawing.Point(258, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 167)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Obat"
        '
        'txthargaobat
        '
        Me.txthargaobat.Location = New System.Drawing.Point(81, 84)
        Me.txthargaobat.Name = "txthargaobat"
        Me.txthargaobat.Size = New System.Drawing.Size(100, 20)
        Me.txthargaobat.TabIndex = 26
        '
        'txtnamaobat
        '
        Me.txtnamaobat.Location = New System.Drawing.Point(81, 56)
        Me.txtnamaobat.Name = "txtnamaobat"
        Me.txtnamaobat.Size = New System.Drawing.Size(100, 20)
        Me.txtnamaobat.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Harga Obat"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Nama Obat"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtkodedokter)
        Me.GroupBox3.Controls.Add(Me.txttelp)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtnamadokter)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(482, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 137)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Dokter"
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(94, 95)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(100, 20)
        Me.txttelp.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Telepon"
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Location = New System.Drawing.Point(94, 62)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(100, 20)
        Me.txtnamadokter.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Nama Dokter"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btntotal)
        Me.GroupBox4.Controls.Add(Me.txtkembali)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtbayar)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtbiayadokter)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtbiayaobat)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txttotal)
        Me.GroupBox4.Location = New System.Drawing.Point(698, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 218)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Biaya-Biaya"
        '
        'btntotal
        '
        Me.btntotal.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntotal.Location = New System.Drawing.Point(9, 88)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(185, 23)
        Me.btntotal.TabIndex = 35
        Me.btntotal.Text = "TOTAL"
        Me.btntotal.UseVisualStyleBackColor = False
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(94, 184)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(100, 20)
        Me.txtkembali.TabIndex = 30
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 187)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Kembali"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(94, 151)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(100, 20)
        Me.txtbayar.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Bayar"
        '
        'PrintDocument1
        '
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnprint.Location = New System.Drawing.Point(663, 290)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 35
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'frmrekammedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(910, 439)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dttgl)
        Me.Controls.Add(Me.txtrekam)
        Me.Controls.Add(Me.dgrekammedis)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmrekammedis"
        Me.Text = "Formrekammedis"
        CType(Me.dgrekammedis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dgrekammedis As DataGridView
    Friend WithEvents txtrekam As TextBox
    Friend WithEvents kdobat As TextBox
    Friend WithEvents txtkodedokter As TextBox
    Friend WithEvents txtbiayaobat As TextBox
    Friend WithEvents txtbiayadokter As TextBox
    Friend WithEvents txtjumlahobat As TextBox
    Friend WithEvents txtketerangan As TextBox
    Friend WithEvents txtdiagnosa As TextBox
    Friend WithEvents txtkeluhan As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents dttgl As DateTimePicker
    Friend WithEvents btntambah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtnamapasien As TextBox
    Friend WithEvents txthargaobat As TextBox
    Friend WithEvents txtnamaobat As TextBox
    Friend WithEvents txttelp As TextBox
    Friend WithEvents txtnamadokter As TextBox
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents btntotal As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnprint As Button
End Class
