<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmobat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kdobat = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtdosis = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.dgobat = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgobat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama_Obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dosis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis"
        '
        'kdobat
        '
        Me.kdobat.Location = New System.Drawing.Point(76, 21)
        Me.kdobat.Name = "kdobat"
        Me.kdobat.Size = New System.Drawing.Size(100, 20)
        Me.kdobat.TabIndex = 5
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(271, 99)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(73, 20)
        Me.txtharga.TabIndex = 7
        '
        'txtdosis
        '
        Me.txtdosis.Location = New System.Drawing.Point(244, 21)
        Me.txtdosis.Name = "txtdosis"
        Me.txtdosis.Size = New System.Drawing.Size(100, 20)
        Me.txtdosis.TabIndex = 8
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(76, 62)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 9
        '
        'dgobat
        '
        Me.dgobat.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgobat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgobat.Location = New System.Drawing.Point(12, 153)
        Me.dgobat.Name = "dgobat"
        Me.dgobat.Size = New System.Drawing.Size(596, 111)
        Me.dgobat.TabIndex = 10
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.Location = New System.Drawing.Point(382, 21)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(100, 23)
        Me.btntambah.TabIndex = 12
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnubah.Location = New System.Drawing.Point(508, 19)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(100, 23)
        Me.btnubah.TabIndex = 13
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.Location = New System.Drawing.Point(382, 60)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(100, 23)
        Me.btnsimpan.TabIndex = 14
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.Location = New System.Drawing.Point(508, 62)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(100, 23)
        Me.btnhapus.TabIndex = 15
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnkeluar.Location = New System.Drawing.Point(382, 97)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(100, 23)
        Me.btnkeluar.TabIndex = 16
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(244, 62)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(100, 20)
        Me.txtjenis.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Stok"
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(76, 102)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(100, 20)
        Me.txtstok.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Rp."
        '
        'frmobat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(644, 309)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtjenis)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dgobat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtdosis)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.kdobat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmobat"
        Me.Text = "obat"
        CType(Me.dgobat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kdobat As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtdosis As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents dgobat As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents txtjenis As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstok As TextBox
    Friend WithEvents Label7 As Label
End Class
