<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdokter
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
        Me.txtkodedokter = New System.Windows.Forms.TextBox()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtsip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.dgdokter = New System.Windows.Forms.DataGridView()
        CType(Me.dgdokter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surat Ijin Praktek"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor Telepon"
        '
        'txtkodedokter
        '
        Me.txtkodedokter.Location = New System.Drawing.Point(122, 21)
        Me.txtkodedokter.Name = "txtkodedokter"
        Me.txtkodedokter.Size = New System.Drawing.Size(100, 20)
        Me.txtkodedokter.TabIndex = 5
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(403, 54)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(100, 20)
        Me.txttelp.TabIndex = 6
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(403, 18)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 20)
        Me.txtalamat.TabIndex = 7
        '
        'txtsip
        '
        Me.txtsip.Location = New System.Drawing.Point(122, 90)
        Me.txtsip.Name = "txtsip"
        Me.txtsip.Size = New System.Drawing.Size(100, 20)
        Me.txtsip.TabIndex = 8
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(122, 57)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 9
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.Location = New System.Drawing.Point(31, 146)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 10
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.Location = New System.Drawing.Point(131, 146)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 11
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnubah.Location = New System.Drawing.Point(233, 146)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 12
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.Location = New System.Drawing.Point(330, 146)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 13
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnkeluar.Location = New System.Drawing.Point(428, 146)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 14
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'dgdokter
        '
        Me.dgdokter.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dgdokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdokter.Location = New System.Drawing.Point(31, 188)
        Me.dgdokter.Name = "dgdokter"
        Me.dgdokter.Size = New System.Drawing.Size(472, 123)
        Me.dgdokter.TabIndex = 15
        '
        'Frmdokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(546, 323)
        Me.Controls.Add(Me.dgdokter)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtsip)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.txtkodedokter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmdokter"
        Me.Text = "Frmdokter"
        CType(Me.dgdokter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkodedokter As TextBox
    Friend WithEvents txttelp As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtsip As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents dgdokter As DataGridView
End Class
