<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.dguser = New System.Windows.Forms.DataGridView()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(102, 19)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(100, 20)
        Me.txtkode.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(102, 112)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 4
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(102, 63)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 20)
        Me.txtuser.TabIndex = 5
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btntambah.Location = New System.Drawing.Point(240, 17)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 6
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnkeluar.Location = New System.Drawing.Point(349, 62)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 7
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnhapus.Location = New System.Drawing.Point(240, 114)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 8
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnubah.Location = New System.Drawing.Point(349, 19)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 9
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnsimpan.Location = New System.Drawing.Point(240, 63)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 10
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'dguser
        '
        Me.dguser.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.Location = New System.Drawing.Point(27, 167)
        Me.dguser.Name = "dguser"
        Me.dguser.Size = New System.Drawing.Size(397, 82)
        Me.dguser.TabIndex = 11
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(460, 261)
        Me.Controls.Add(Me.dguser)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "user"
        Me.Text = "user"
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents dguser As DataGridView
End Class
