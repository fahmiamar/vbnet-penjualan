<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPemasok
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbTambah = New System.Windows.Forms.Label()
        Me.CbCari = New System.Windows.Forms.ComboBox()
        Me.LbHapus = New System.Windows.Forms.Label()
        Me.TxtKunci = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.LbKeluar = New System.Windows.Forms.Label()
        Me.LbSimpan = New System.Windows.Forms.Label()
        Me.TxTelppmk = New System.Windows.Forms.TextBox()
        Me.TxAlamatpmk = New System.Windows.Forms.TextBox()
        Me.TxNamaPmk = New System.Windows.Forms.TextBox()
        Me.TxKodepmk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(530, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(275, 21)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Double klik untuk menampilkan data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(203, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 25)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(203, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 25)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(203, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 25)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(203, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 25)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = ":"
        '
        'LbTambah
        '
        Me.LbTambah.AutoSize = True
        Me.LbTambah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTambah.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTambah.Location = New System.Drawing.Point(805, 24)
        Me.LbTambah.Name = "LbTambah"
        Me.LbTambah.Size = New System.Drawing.Size(85, 32)
        Me.LbTambah.TabIndex = 91
        Me.LbTambah.Text = "Tambah"
        '
        'CbCari
        '
        Me.CbCari.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCari.FormattingEnabled = True
        Me.CbCari.Location = New System.Drawing.Point(736, 99)
        Me.CbCari.Name = "CbCari"
        Me.CbCari.Size = New System.Drawing.Size(173, 33)
        Me.CbCari.TabIndex = 90
        '
        'LbHapus
        '
        Me.LbHapus.AutoSize = True
        Me.LbHapus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbHapus.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHapus.Location = New System.Drawing.Point(1084, 24)
        Me.LbHapus.Name = "LbHapus"
        Me.LbHapus.Size = New System.Drawing.Size(70, 32)
        Me.LbHapus.TabIndex = 89
        Me.LbHapus.Text = "Hapus"
        '
        'TxtKunci
        '
        Me.TxtKunci.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKunci.Location = New System.Drawing.Point(929, 99)
        Me.TxtKunci.Name = "TxtKunci"
        Me.TxtKunci.Size = New System.Drawing.Size(339, 30)
        Me.TxtKunci.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(529, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 25)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Cari barang berdasarkan :"
        '
        'DGView
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGView.Location = New System.Drawing.Point(534, 151)
        Me.DGView.Name = "DGView"
        Me.DGView.RowHeadersWidth = 51
        Me.DGView.RowTemplate.Height = 24
        Me.DGView.Size = New System.Drawing.Size(734, 286)
        Me.DGView.TabIndex = 86
        '
        'LbKeluar
        '
        Me.LbKeluar.AutoSize = True
        Me.LbKeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKeluar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKeluar.Location = New System.Drawing.Point(1196, 24)
        Me.LbKeluar.Name = "LbKeluar"
        Me.LbKeluar.Size = New System.Drawing.Size(72, 32)
        Me.LbKeluar.TabIndex = 85
        Me.LbKeluar.Text = "Keluar"
        '
        'LbSimpan
        '
        Me.LbSimpan.AutoSize = True
        Me.LbSimpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSimpan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSimpan.Location = New System.Drawing.Point(949, 24)
        Me.LbSimpan.Name = "LbSimpan"
        Me.LbSimpan.Size = New System.Drawing.Size(82, 32)
        Me.LbSimpan.TabIndex = 84
        Me.LbSimpan.Text = "Simpan"
        '
        'TxTelppmk
        '
        Me.TxTelppmk.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTelppmk.Location = New System.Drawing.Point(230, 236)
        Me.TxTelppmk.Name = "TxTelppmk"
        Me.TxTelppmk.Size = New System.Drawing.Size(283, 30)
        Me.TxTelppmk.TabIndex = 83
        '
        'TxAlamatpmk
        '
        Me.TxAlamatpmk.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlamatpmk.Location = New System.Drawing.Point(230, 287)
        Me.TxAlamatpmk.Multiline = True
        Me.TxAlamatpmk.Name = "TxAlamatpmk"
        Me.TxAlamatpmk.Size = New System.Drawing.Size(283, 131)
        Me.TxAlamatpmk.TabIndex = 82
        '
        'TxNamaPmk
        '
        Me.TxNamaPmk.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNamaPmk.Location = New System.Drawing.Point(230, 191)
        Me.TxNamaPmk.Name = "TxNamaPmk"
        Me.TxNamaPmk.Size = New System.Drawing.Size(283, 30)
        Me.TxNamaPmk.TabIndex = 81
        '
        'TxKodepmk
        '
        Me.TxKodepmk.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKodepmk.Location = New System.Drawing.Point(230, 150)
        Me.TxKodepmk.Name = "TxKodepmk"
        Me.TxKodepmk.Size = New System.Drawing.Size(117, 30)
        Me.TxKodepmk.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "TELPON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "NAMA PEMASOK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "KODE PEMASOK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 59)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Master Data Pemasok"
        '
        'FrmPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 485)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbTambah)
        Me.Controls.Add(Me.CbCari)
        Me.Controls.Add(Me.LbHapus)
        Me.Controls.Add(Me.TxtKunci)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DGView)
        Me.Controls.Add(Me.LbKeluar)
        Me.Controls.Add(Me.LbSimpan)
        Me.Controls.Add(Me.TxTelppmk)
        Me.Controls.Add(Me.TxAlamatpmk)
        Me.Controls.Add(Me.TxNamaPmk)
        Me.Controls.Add(Me.TxKodepmk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPemasok"
        Me.Text = "FrmPemasok"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LbTambah As Label
    Friend WithEvents CbCari As ComboBox
    Friend WithEvents LbHapus As Label
    Friend WithEvents TxtKunci As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DGView As DataGridView
    Friend WithEvents LbKeluar As Label
    Friend WithEvents LbSimpan As Label
    Friend WithEvents TxTelppmk As TextBox
    Friend WithEvents TxAlamatpmk As TextBox
    Friend WithEvents TxNamaPmk As TextBox
    Friend WithEvents TxKodepmk As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BS As BindingSource
    Friend WithEvents Label1 As Label
End Class
