<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Me.LbHapus = New System.Windows.Forms.Label()
        Me.TxtKunci = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGView = New System.Windows.Forms.DataGridView()
        Me.LbKeluar = New System.Windows.Forms.Label()
        Me.LbSimpan = New System.Windows.Forms.Label()
        Me.TxStok = New System.Windows.Forms.TextBox()
        Me.TxHargaBeli = New System.Windows.Forms.TextBox()
        Me.TxHargajual = New System.Windows.Forms.TextBox()
        Me.TxSatuan = New System.Windows.Forms.TextBox()
        Me.TxNamaBrg = New System.Windows.Forms.TextBox()
        Me.TxKodeBrg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbCari = New System.Windows.Forms.ComboBox()
        Me.LbTambah = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbHapus
        '
        Me.LbHapus.AutoSize = True
        Me.LbHapus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbHapus.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHapus.Location = New System.Drawing.Point(1086, 46)
        Me.LbHapus.Name = "LbHapus"
        Me.LbHapus.Size = New System.Drawing.Size(70, 32)
        Me.LbHapus.TabIndex = 37
        Me.LbHapus.Text = "Hapus"
        '
        'TxtKunci
        '
        Me.TxtKunci.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKunci.Location = New System.Drawing.Point(931, 121)
        Me.TxtKunci.Name = "TxtKunci"
        Me.TxtKunci.Size = New System.Drawing.Size(339, 30)
        Me.TxtKunci.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(531, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 25)
        Me.Label10.TabIndex = 35
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
        Me.DGView.Location = New System.Drawing.Point(536, 170)
        Me.DGView.Name = "DGView"
        Me.DGView.RowHeadersWidth = 51
        Me.DGView.RowTemplate.Height = 24
        Me.DGView.Size = New System.Drawing.Size(734, 296)
        Me.DGView.TabIndex = 34
        '
        'LbKeluar
        '
        Me.LbKeluar.AutoSize = True
        Me.LbKeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbKeluar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbKeluar.Location = New System.Drawing.Point(1198, 46)
        Me.LbKeluar.Name = "LbKeluar"
        Me.LbKeluar.Size = New System.Drawing.Size(72, 32)
        Me.LbKeluar.TabIndex = 33
        Me.LbKeluar.Text = "Keluar"
        '
        'LbSimpan
        '
        Me.LbSimpan.AutoSize = True
        Me.LbSimpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbSimpan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSimpan.Location = New System.Drawing.Point(951, 46)
        Me.LbSimpan.Name = "LbSimpan"
        Me.LbSimpan.Size = New System.Drawing.Size(82, 32)
        Me.LbSimpan.TabIndex = 32
        Me.LbSimpan.Text = "Simpan"
        '
        'TxStok
        '
        Me.TxStok.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxStok.Location = New System.Drawing.Point(238, 376)
        Me.TxStok.Name = "TxStok"
        Me.TxStok.Size = New System.Drawing.Size(100, 30)
        Me.TxStok.TabIndex = 31
        '
        'TxHargaBeli
        '
        Me.TxHargaBeli.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHargaBeli.Location = New System.Drawing.Point(238, 333)
        Me.TxHargaBeli.Name = "TxHargaBeli"
        Me.TxHargaBeli.Size = New System.Drawing.Size(145, 30)
        Me.TxHargaBeli.TabIndex = 30
        '
        'TxHargajual
        '
        Me.TxHargajual.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHargajual.Location = New System.Drawing.Point(238, 295)
        Me.TxHargajual.Name = "TxHargajual"
        Me.TxHargajual.Size = New System.Drawing.Size(145, 30)
        Me.TxHargajual.TabIndex = 29
        '
        'TxSatuan
        '
        Me.TxSatuan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxSatuan.Location = New System.Drawing.Point(238, 254)
        Me.TxSatuan.Name = "TxSatuan"
        Me.TxSatuan.Size = New System.Drawing.Size(100, 30)
        Me.TxSatuan.TabIndex = 28
        '
        'TxNamaBrg
        '
        Me.TxNamaBrg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNamaBrg.Location = New System.Drawing.Point(238, 211)
        Me.TxNamaBrg.Name = "TxNamaBrg"
        Me.TxNamaBrg.Size = New System.Drawing.Size(283, 30)
        Me.TxNamaBrg.TabIndex = 27
        '
        'TxKodeBrg
        '
        Me.TxKodeBrg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKodeBrg.Location = New System.Drawing.Point(238, 170)
        Me.TxKodeBrg.Name = "TxKodeBrg"
        Me.TxKodeBrg.Size = New System.Drawing.Size(117, 30)
        Me.TxKodeBrg.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "STOK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "HARGA BELI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "HARGA JUAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "SATUAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "NAMA BARANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "KODE BARANG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 54)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Master Data Barang"
        '
        'CbCari
        '
        Me.CbCari.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCari.FormattingEnabled = True
        Me.CbCari.Location = New System.Drawing.Point(738, 121)
        Me.CbCari.Name = "CbCari"
        Me.CbCari.Size = New System.Drawing.Size(173, 33)
        Me.CbCari.TabIndex = 38
        '
        'LbTambah
        '
        Me.LbTambah.AutoSize = True
        Me.LbTambah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbTambah.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTambah.Location = New System.Drawing.Point(807, 46)
        Me.LbTambah.Name = "LbTambah"
        Me.LbTambah.Size = New System.Drawing.Size(85, 32)
        Me.LbTambah.TabIndex = 39
        Me.LbTambah.Text = "Tambah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(197, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 25)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(197, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 25)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(197, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 25)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(197, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 25)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(197, 376)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 25)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(532, 469)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(275, 21)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Double klik untuk menampilkan data"
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 523)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
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
        Me.Controls.Add(Me.TxStok)
        Me.Controls.Add(Me.TxHargaBeli)
        Me.Controls.Add(Me.TxHargajual)
        Me.Controls.Add(Me.TxSatuan)
        Me.Controls.Add(Me.TxNamaBrg)
        Me.Controls.Add(Me.TxKodeBrg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBarang"
        CType(Me.DGView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BS As BindingSource
    Friend WithEvents LbHapus As Label
    Friend WithEvents TxtKunci As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DGView As DataGridView
    Friend WithEvents LbKeluar As Label
    Friend WithEvents LbSimpan As Label
    Friend WithEvents TxStok As TextBox
    Friend WithEvents TxHargaBeli As TextBox
    Friend WithEvents TxHargajual As TextBox
    Friend WithEvents TxSatuan As TextBox
    Friend WithEvents TxNamaBrg As TextBox
    Friend WithEvents TxKodeBrg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbCari As ComboBox
    Friend WithEvents LbTambah As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
