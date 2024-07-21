<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelanggan
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
        Me.TxTelpplg = New System.Windows.Forms.TextBox()
        Me.TxAlamatplg = New System.Windows.Forms.TextBox()
        Me.TxNamaPlg = New System.Windows.Forms.TextBox()
        Me.TxKodeplg = New System.Windows.Forms.TextBox()
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
        Me.Label15.Location = New System.Drawing.Point(524, 445)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(275, 21)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Double klik untuk menampilkan data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(197, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 25)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(197, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 25)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(197, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 25)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 25)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = ":"
        '
        'LbTambah
        '
        Me.LbTambah.AutoSize = True
        Me.LbTambah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTambah.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTambah.Location = New System.Drawing.Point(799, 29)
        Me.LbTambah.Name = "LbTambah"
        Me.LbTambah.Size = New System.Drawing.Size(85, 32)
        Me.LbTambah.TabIndex = 67
        Me.LbTambah.Text = "Tambah"
        '
        'CbCari
        '
        Me.CbCari.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCari.FormattingEnabled = True
        Me.CbCari.Location = New System.Drawing.Point(730, 104)
        Me.CbCari.Name = "CbCari"
        Me.CbCari.Size = New System.Drawing.Size(173, 33)
        Me.CbCari.TabIndex = 66
        '
        'LbHapus
        '
        Me.LbHapus.AutoSize = True
        Me.LbHapus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbHapus.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHapus.Location = New System.Drawing.Point(1078, 29)
        Me.LbHapus.Name = "LbHapus"
        Me.LbHapus.Size = New System.Drawing.Size(70, 32)
        Me.LbHapus.TabIndex = 65
        Me.LbHapus.Text = "Hapus"
        '
        'TxtKunci
        '
        Me.TxtKunci.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKunci.Location = New System.Drawing.Point(923, 104)
        Me.TxtKunci.Name = "TxtKunci"
        Me.TxtKunci.Size = New System.Drawing.Size(339, 30)
        Me.TxtKunci.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 25)
        Me.Label10.TabIndex = 63
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
        Me.DGView.Location = New System.Drawing.Point(528, 156)
        Me.DGView.Name = "DGView"
        Me.DGView.RowHeadersWidth = 51
        Me.DGView.RowTemplate.Height = 24
        Me.DGView.Size = New System.Drawing.Size(734, 286)
        Me.DGView.TabIndex = 62
        '
        'LbKeluar
        '
        Me.LbKeluar.AutoSize = True
        Me.LbKeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKeluar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKeluar.Location = New System.Drawing.Point(1190, 29)
        Me.LbKeluar.Name = "LbKeluar"
        Me.LbKeluar.Size = New System.Drawing.Size(72, 32)
        Me.LbKeluar.TabIndex = 61
        Me.LbKeluar.Text = "Keluar"
        '
        'LbSimpan
        '
        Me.LbSimpan.AutoSize = True
        Me.LbSimpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSimpan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSimpan.Location = New System.Drawing.Point(943, 29)
        Me.LbSimpan.Name = "LbSimpan"
        Me.LbSimpan.Size = New System.Drawing.Size(82, 32)
        Me.LbSimpan.TabIndex = 60
        Me.LbSimpan.Text = "Simpan"
        '
        'TxTelpplg
        '
        Me.TxTelpplg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTelpplg.Location = New System.Drawing.Point(224, 241)
        Me.TxTelpplg.Name = "TxTelpplg"
        Me.TxTelpplg.Size = New System.Drawing.Size(283, 30)
        Me.TxTelpplg.TabIndex = 57
        '
        'TxAlamatplg
        '
        Me.TxAlamatplg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxAlamatplg.Location = New System.Drawing.Point(224, 292)
        Me.TxAlamatplg.Multiline = True
        Me.TxAlamatplg.Name = "TxAlamatplg"
        Me.TxAlamatplg.Size = New System.Drawing.Size(283, 131)
        Me.TxAlamatplg.TabIndex = 56
        '
        'TxNamaPlg
        '
        Me.TxNamaPlg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNamaPlg.Location = New System.Drawing.Point(224, 196)
        Me.TxNamaPlg.Name = "TxNamaPlg"
        Me.TxNamaPlg.Size = New System.Drawing.Size(283, 30)
        Me.TxNamaPlg.TabIndex = 55
        '
        'TxKodeplg
        '
        Me.TxKodeplg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKodeplg.Location = New System.Drawing.Point(224, 155)
        Me.TxKodeplg.Name = "TxKodeplg"
        Me.TxKodeplg.Size = New System.Drawing.Size(117, 30)
        Me.TxKodeplg.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "TELPON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 25)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "NAMA PELANGGAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "KODE PELANGGAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 59)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Master Data Pelanggan"
        '
        'FrmPelanggan
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
        Me.Controls.Add(Me.TxTelpplg)
        Me.Controls.Add(Me.TxAlamatplg)
        Me.Controls.Add(Me.TxNamaPlg)
        Me.Controls.Add(Me.TxKodeplg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPelanggan"
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
    Friend WithEvents BS As BindingSource
    Friend WithEvents CbCari As ComboBox
    Friend WithEvents LbHapus As Label
    Friend WithEvents TxtKunci As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DGView As DataGridView
    Friend WithEvents LbKeluar As Label
    Friend WithEvents LbSimpan As Label
    Friend WithEvents TxTelpplg As TextBox
    Friend WithEvents TxAlamatplg As TextBox
    Friend WithEvents TxNamaPlg As TextBox
    Friend WithEvents TxKodeplg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
