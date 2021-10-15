<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasien
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
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.dtlahir = New System.Windows.Forms.DateTimePicker()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.dgpasien = New System.Windows.Forms.DataGridView()
        CType(Me.dgpasien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(282, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nomor Telepon"
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(105, 9)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(121, 20)
        Me.txtno.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(105, 44)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(121, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(105, 76)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(121, 20)
        Me.txtalamat.TabIndex = 9
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(372, 44)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(100, 20)
        Me.txttelp.TabIndex = 10
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(372, 12)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(64, 17)
        Me.rblaki.TabIndex = 11
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki-laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(460, 12)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 12
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'cbagama
        '
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Items.AddRange(New Object() {"Islam", "Katolik", "Protestan", "Hindu", "Budha", "Kong khu chu"})
        Me.cbagama.Location = New System.Drawing.Point(105, 109)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(121, 21)
        Me.cbagama.TabIndex = 13
        '
        'dtlahir
        '
        Me.dtlahir.Location = New System.Drawing.Point(372, 76)
        Me.dtlahir.Name = "dtlahir"
        Me.dtlahir.Size = New System.Drawing.Size(200, 20)
        Me.dtlahir.TabIndex = 14
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.Location = New System.Drawing.Point(32, 153)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 15
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.Location = New System.Drawing.Point(151, 153)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 16
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnubah.Location = New System.Drawing.Point(259, 153)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 17
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.Location = New System.Drawing.Point(374, 153)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 18
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnkeluar.Location = New System.Drawing.Point(482, 153)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 19
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'dgpasien
        '
        Me.dgpasien.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgpasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpasien.Location = New System.Drawing.Point(32, 218)
        Me.dgpasien.Name = "dgpasien"
        Me.dgpasien.Size = New System.Drawing.Size(525, 150)
        Me.dgpasien.TabIndex = 20
        '
        'frmPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(584, 380)
        Me.Controls.Add(Me.dgpasien)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dtlahir)
        Me.Controls.Add(Me.cbagama)
        Me.Controls.Add(Me.rbperempuan)
        Me.Controls.Add(Me.rblaki)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPasien"
        Me.Text = "Form1"
        CType(Me.dgpasien, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtno As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txttelp As TextBox
    Friend WithEvents rblaki As RadioButton
    Friend WithEvents rbperempuan As RadioButton
    Friend WithEvents cbagama As ComboBox
    Friend WithEvents dtlahir As DateTimePicker
    Friend WithEvents btntambah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents dgpasien As DataGridView
End Class
