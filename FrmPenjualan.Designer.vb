<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxTotal = New System.Windows.Forms.TextBox()
        Me.TxJumlah = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxItem = New System.Windows.Forms.TextBox()
        Me.DGVIEW = New System.Windows.Forms.DataGridView()
        Me.PanelFaktur = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txkuncifaktur = New System.Windows.Forms.TextBox()
        Me.DGFaktur = New System.Windows.Forms.DataGridView()
        Me.PanelPelanggan = New System.Windows.Forms.Panel()
        Me.txCariPelanggan = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.PanelBarang = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtkunci = New System.Windows.Forms.TextBox()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.TxDiscount = New System.Windows.Forms.TextBox()
        Me.TxHargasat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txsatuan = New System.Windows.Forms.TextBox()
        Me.TxNamabrg = New System.Windows.Forms.TextBox()
        Me.TxKodebrg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txAmount = New System.Windows.Forms.TextBox()
        Me.Lblkeluar = New System.Windows.Forms.Label()
        Me.LblHapus = New System.Windows.Forms.Label()
        Me.LblSimpan = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxNofakt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxTglJt = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxJT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txkatagori = New System.Windows.Forms.TextBox()
        Me.TxNamaPlg = New System.Windows.Forms.TextBox()
        Me.TxKodePlg = New System.Windows.Forms.TextBox()
        Me.txtglfakt = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BtnCariFaktur = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BtnCariPemasok = New System.Windows.Forms.Button()
        Me.BSBarang = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSFaktur = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSPelanggan = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSPenjualan = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFaktur.SuspendLayout()
        CType(Me.DGFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPelanggan.SuspendLayout()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarang.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSFaktur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxTotal
        '
        Me.TxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTotal.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTotal.Location = New System.Drawing.Point(1210, 344)
        Me.TxTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxTotal.Name = "TxTotal"
        Me.TxTotal.Size = New System.Drawing.Size(153, 34)
        Me.TxTotal.TabIndex = 960
        Me.TxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxJumlah
        '
        Me.TxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxJumlah.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxJumlah.Location = New System.Drawing.Point(996, 345)
        Me.TxJumlah.Margin = New System.Windows.Forms.Padding(4)
        Me.TxJumlah.Name = "TxJumlah"
        Me.TxJumlah.Size = New System.Drawing.Size(91, 34)
        Me.TxJumlah.TabIndex = 958
        Me.TxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1086, 266)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(55, 25)
        Me.Label22.TabIndex = 964
        Me.Label22.Text = "Item#"
        '
        'TxItem
        '
        Me.TxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxItem.Enabled = False
        Me.TxItem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxItem.Location = New System.Drawing.Point(1167, 264)
        Me.TxItem.Margin = New System.Windows.Forms.Padding(4)
        Me.TxItem.Name = "TxItem"
        Me.TxItem.Size = New System.Drawing.Size(41, 30)
        Me.TxItem.TabIndex = 962
        '
        'DGVIEW
        '
        Me.DGVIEW.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.MintCream
        Me.DGVIEW.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVIEW.BackgroundColor = System.Drawing.Color.White
        Me.DGVIEW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVIEW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVIEW.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGVIEW.Location = New System.Drawing.Point(31, 388)
        Me.DGVIEW.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVIEW.Name = "DGVIEW"
        Me.DGVIEW.RowHeadersVisible = False
        Me.DGVIEW.RowHeadersWidth = 45
        Me.DGVIEW.RowTemplate.Height = 24
        Me.DGVIEW.Size = New System.Drawing.Size(1331, 490)
        Me.DGVIEW.TabIndex = 961
        '
        'PanelFaktur
        '
        Me.PanelFaktur.BackColor = System.Drawing.Color.White
        Me.PanelFaktur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFaktur.Controls.Add(Me.Button6)
        Me.PanelFaktur.Controls.Add(Me.Label1)
        Me.PanelFaktur.Controls.Add(Me.txkuncifaktur)
        Me.PanelFaktur.Controls.Add(Me.DGFaktur)
        Me.PanelFaktur.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelFaktur.Location = New System.Drawing.Point(57, 446)
        Me.PanelFaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFaktur.Name = "PanelFaktur"
        Me.PanelFaktur.Size = New System.Drawing.Size(857, 82)
        Me.PanelFaktur.TabIndex = 965
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 30)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Nama Pelanggan : "
        '
        'txkuncifaktur
        '
        Me.txkuncifaktur.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txkuncifaktur.Location = New System.Drawing.Point(208, 22)
        Me.txkuncifaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.txkuncifaktur.Name = "txkuncifaktur"
        Me.txkuncifaktur.Size = New System.Drawing.Size(395, 34)
        Me.txkuncifaktur.TabIndex = 62
        '
        'DGFaktur
        '
        Me.DGFaktur.BackgroundColor = System.Drawing.Color.White
        Me.DGFaktur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGFaktur.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGFaktur.Location = New System.Drawing.Point(20, 64)
        Me.DGFaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.DGFaktur.Name = "DGFaktur"
        Me.DGFaktur.RowHeadersWidth = 51
        Me.DGFaktur.Size = New System.Drawing.Size(829, 308)
        Me.DGFaktur.TabIndex = 0
        '
        'PanelPelanggan
        '
        Me.PanelPelanggan.BackColor = System.Drawing.Color.White
        Me.PanelPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPelanggan.Controls.Add(Me.Button3)
        Me.PanelPelanggan.Controls.Add(Me.txCariPelanggan)
        Me.PanelPelanggan.Controls.Add(Me.Label14)
        Me.PanelPelanggan.Controls.Add(Me.DGPelanggan)
        Me.PanelPelanggan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelPelanggan.Location = New System.Drawing.Point(57, 548)
        Me.PanelPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelPelanggan.Name = "PanelPelanggan"
        Me.PanelPelanggan.Size = New System.Drawing.Size(809, 81)
        Me.PanelPelanggan.TabIndex = 967
        Me.PanelPelanggan.Visible = False
        '
        'txCariPelanggan
        '
        Me.txCariPelanggan.Location = New System.Drawing.Point(271, 19)
        Me.txCariPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.txCariPelanggan.Name = "txCariPelanggan"
        Me.txCariPelanggan.Size = New System.Drawing.Size(439, 34)
        Me.txCariPelanggan.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 19)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(173, 30)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Nama Pelanggan :"
        '
        'DGPelanggan
        '
        Me.DGPelanggan.BackgroundColor = System.Drawing.Color.White
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGPelanggan.DefaultCellStyle = DataGridViewCellStyle12
        Me.DGPelanggan.Location = New System.Drawing.Point(18, 64)
        Me.DGPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.RowHeadersWidth = 51
        Me.DGPelanggan.Size = New System.Drawing.Size(756, 344)
        Me.DGPelanggan.TabIndex = 0
        '
        'PanelBarang
        '
        Me.PanelBarang.BackColor = System.Drawing.Color.White
        Me.PanelBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBarang.Controls.Add(Me.Button4)
        Me.PanelBarang.Controls.Add(Me.Label15)
        Me.PanelBarang.Controls.Add(Me.txtkunci)
        Me.PanelBarang.Controls.Add(Me.DGBarang)
        Me.PanelBarang.Location = New System.Drawing.Point(57, 654)
        Me.PanelBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBarang.Name = "PanelBarang"
        Me.PanelBarang.Size = New System.Drawing.Size(943, 104)
        Me.PanelBarang.TabIndex = 968
        Me.PanelBarang.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 29)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(225, 30)
        Me.Label15.TabIndex = 195
        Me.Label15.Text = "Masukan Nama barang :"
        '
        'txtkunci
        '
        Me.txtkunci.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkunci.Location = New System.Drawing.Point(290, 24)
        Me.txtkunci.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkunci.Name = "txtkunci"
        Me.txtkunci.Size = New System.Drawing.Size(441, 34)
        Me.txtkunci.TabIndex = 192
        '
        'DGBarang
        '
        Me.DGBarang.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBarang.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGBarang.Location = New System.Drawing.Point(20, 73)
        Me.DGBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.RowHeadersWidth = 51
        Me.DGBarang.Size = New System.Drawing.Size(902, 360)
        Me.DGBarang.TabIndex = 0
        '
        'TxDiscount
        '
        Me.TxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxDiscount.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxDiscount.Location = New System.Drawing.Point(1091, 344)
        Me.TxDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxDiscount.Name = "TxDiscount"
        Me.TxDiscount.Size = New System.Drawing.Size(117, 34)
        Me.TxDiscount.TabIndex = 959
        Me.TxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxHargasat
        '
        Me.TxHargasat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxHargasat.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxHargasat.Location = New System.Drawing.Point(867, 345)
        Me.TxHargasat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxHargasat.Name = "TxHargasat"
        Me.TxHargasat.Size = New System.Drawing.Size(125, 34)
        Me.TxHargasat.TabIndex = 957
        Me.TxHargasat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1210, 298)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 43)
        Me.Label13.TabIndex = 956
        Me.Label13.Text = "Total"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1091, 298)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 43)
        Me.Label12.TabIndex = 955
        Me.Label12.Text = "Discount"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(996, 298)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 43)
        Me.Label11.TabIndex = 954
        Me.Label11.Text = "Jumlah"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(867, 298)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 43)
        Me.Label10.TabIndex = 953
        Me.Label10.Text = "Harga"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txsatuan
        '
        Me.Txsatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txsatuan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txsatuan.Location = New System.Drawing.Point(775, 345)
        Me.Txsatuan.Margin = New System.Windows.Forms.Padding(4)
        Me.Txsatuan.Name = "Txsatuan"
        Me.Txsatuan.Size = New System.Drawing.Size(91, 34)
        Me.Txsatuan.TabIndex = 951
        '
        'TxNamabrg
        '
        Me.TxNamabrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxNamabrg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNamabrg.Location = New System.Drawing.Point(259, 345)
        Me.TxNamabrg.Margin = New System.Windows.Forms.Padding(4)
        Me.TxNamabrg.Name = "TxNamabrg"
        Me.TxNamabrg.Size = New System.Drawing.Size(514, 34)
        Me.TxNamabrg.TabIndex = 950
        '
        'TxKodebrg
        '
        Me.TxKodebrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxKodebrg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKodebrg.Location = New System.Drawing.Point(119, 346)
        Me.TxKodebrg.Margin = New System.Windows.Forms.Padding(4)
        Me.TxKodebrg.Name = "TxKodebrg"
        Me.TxKodebrg.Size = New System.Drawing.Size(139, 34)
        Me.TxKodebrg.TabIndex = 949
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(775, 298)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 44)
        Me.Label8.TabIndex = 948
        Me.Label8.Text = "Satuan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(259, 298)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(514, 44)
        Me.Label4.TabIndex = 947
        Me.Label4.Text = "Nama Barang"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(119, 299)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 44)
        Me.Label3.TabIndex = 946
        Me.Label3.Text = "Kode Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txAmount
        '
        Me.txAmount.BackColor = System.Drawing.Color.White
        Me.txAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txAmount.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txAmount.Location = New System.Drawing.Point(881, 110)
        Me.txAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txAmount.Name = "txAmount"
        Me.txAmount.Size = New System.Drawing.Size(483, 98)
        Me.txAmount.TabIndex = 945
        Me.txAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txAmount.WordWrap = False
        '
        'Lblkeluar
        '
        Me.Lblkeluar.BackColor = System.Drawing.Color.White
        Me.Lblkeluar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblkeluar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblkeluar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Lblkeluar.Location = New System.Drawing.Point(1244, 43)
        Me.Lblkeluar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblkeluar.Name = "Lblkeluar"
        Me.Lblkeluar.Size = New System.Drawing.Size(119, 40)
        Me.Lblkeluar.TabIndex = 944
        Me.Lblkeluar.Text = "Keluar"
        Me.Lblkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHapus
        '
        Me.LblHapus.BackColor = System.Drawing.Color.White
        Me.LblHapus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHapus.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapus.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblHapus.Location = New System.Drawing.Point(1067, 43)
        Me.LblHapus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHapus.Name = "LblHapus"
        Me.LblHapus.Size = New System.Drawing.Size(119, 40)
        Me.LblHapus.TabIndex = 943
        Me.LblHapus.Text = "Hapus"
        Me.LblHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSimpan
        '
        Me.LblSimpan.BackColor = System.Drawing.Color.White
        Me.LblSimpan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSimpan.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSimpan.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblSimpan.Location = New System.Drawing.Point(881, 43)
        Me.LblSimpan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSimpan.Name = "LblSimpan"
        Me.LblSimpan.Size = New System.Drawing.Size(119, 40)
        Me.LblSimpan.TabIndex = 942
        Me.LblSimpan.Text = "Simpan"
        Me.LblSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label34.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(560, 214)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(19, 28)
        Me.Label34.TabIndex = 941
        Me.Label34.Text = ":"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(139, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 28)
        Me.Label2.TabIndex = 940
        Me.Label2.Text = ":"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(139, 215)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(19, 28)
        Me.Label33.TabIndex = 939
        Me.Label33.Text = ":"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label32.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(139, 172)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(19, 28)
        Me.Label32.TabIndex = 938
        Me.Label32.Text = ":"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label31.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(560, 115)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(19, 28)
        Me.Label31.TabIndex = 937
        Me.Label31.Text = ":"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(27, 115)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 30)
        Me.Label23.TabIndex = 936
        Me.Label23.Text = "No. Faktur "
        '
        'TxNofakt
        '
        Me.TxNofakt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNofakt.Location = New System.Drawing.Point(175, 115)
        Me.TxNofakt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxNofakt.Name = "TxNofakt"
        Me.TxNofakt.Size = New System.Drawing.Size(182, 34)
        Me.TxNofakt.TabIndex = 935
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(433, 118)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 30)
        Me.Label7.TabIndex = 929
        Me.Label7.Text = "Tgl. Faktur"
        '
        'TxTglJt
        '
        Me.TxTglJt.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.TxTglJt.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.TxTglJt.CustomFormat = "dd-MMM-yyyy"
        Me.TxTglJt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTglJt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxTglJt.Location = New System.Drawing.Point(594, 209)
        Me.TxTglJt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxTglJt.Name = "TxTglJt"
        Me.TxTglJt.Size = New System.Drawing.Size(197, 34)
        Me.TxTglJt.TabIndex = 934
        Me.TxTglJt.Value = New Date(2023, 6, 15, 0, 0, 0, 0)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(428, 214)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 30)
        Me.Label21.TabIndex = 933
        Me.Label21.Text = "Tgl. J.Tempo "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(247, 212)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 30)
        Me.Label20.TabIndex = 932
        Me.Label20.Text = "Hari"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(27, 215)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 30)
        Me.Label19.TabIndex = 931
        Me.Label19.Text = "Masa JT."
        '
        'TxJT
        '
        Me.TxJT.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxJT.Location = New System.Drawing.Point(174, 210)
        Me.TxJT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxJT.Name = "TxJT"
        Me.TxJT.Size = New System.Drawing.Size(67, 34)
        Me.TxJT.TabIndex = 930
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 169)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 30)
        Me.Label6.TabIndex = 928
        Me.Label6.Text = "Pelanggan"
        '
        'txkatagori
        '
        Me.txkatagori.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txkatagori.Location = New System.Drawing.Point(693, 165)
        Me.txkatagori.Margin = New System.Windows.Forms.Padding(4)
        Me.txkatagori.Name = "txkatagori"
        Me.txkatagori.Size = New System.Drawing.Size(0, 34)
        Me.txkatagori.TabIndex = 926
        '
        'TxNamaPlg
        '
        Me.TxNamaPlg.Enabled = False
        Me.TxNamaPlg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxNamaPlg.Location = New System.Drawing.Point(423, 169)
        Me.TxNamaPlg.Margin = New System.Windows.Forms.Padding(4)
        Me.TxNamaPlg.Name = "TxNamaPlg"
        Me.TxNamaPlg.Size = New System.Drawing.Size(368, 34)
        Me.TxNamaPlg.TabIndex = 925
        '
        'TxKodePlg
        '
        Me.TxKodePlg.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxKodePlg.Location = New System.Drawing.Point(174, 169)
        Me.TxKodePlg.Margin = New System.Windows.Forms.Padding(4)
        Me.TxKodePlg.Name = "TxKodePlg"
        Me.TxKodePlg.Size = New System.Drawing.Size(183, 34)
        Me.TxKodePlg.TabIndex = 924
        '
        'txtglfakt
        '
        Me.txtglfakt.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.txtglfakt.CalendarTitleBackColor = System.Drawing.Color.Transparent
        Me.txtglfakt.CustomFormat = "dd-MMM-yyyy"
        Me.txtglfakt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtglfakt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtglfakt.Location = New System.Drawing.Point(588, 110)
        Me.txtglfakt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtglfakt.Name = "txtglfakt"
        Me.txtglfakt.Size = New System.Drawing.Size(203, 34)
        Me.txtglfakt.TabIndex = 923
        Me.txtglfakt.Value = New Date(2023, 6, 15, 0, 0, 0, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label27.Location = New System.Drawing.Point(24, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(378, 59)
        Me.Label27.TabIndex = 922
        Me.Label27.Text = "Penjualan Barang"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.warung_contoh.My.Resources.Resources.close
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(882, 24)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 32)
        Me.Button4.TabIndex = 196
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.warung_contoh.My.Resources.Resources.close
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(729, 17)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 39)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.warung_contoh.My.Resources.Resources.close
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(804, 22)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 34)
        Me.Button6.TabIndex = 98
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BtnCariFaktur
        '
        Me.BtnCariFaktur.BackgroundImage = Global.warung_contoh.My.Resources.Resources.cari
        Me.BtnCariFaktur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCariFaktur.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariFaktur.Location = New System.Drawing.Point(365, 110)
        Me.BtnCariFaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCariFaktur.Name = "BtnCariFaktur"
        Me.BtnCariFaktur.Size = New System.Drawing.Size(50, 46)
        Me.BtnCariFaktur.TabIndex = 966
        Me.BtnCariFaktur.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.warung_contoh.My.Resources.Resources.add
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(1287, 215)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 79)
        Me.Button1.TabIndex = 963
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.warung_contoh.My.Resources.Resources.cari
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(30, 299)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(82, 81)
        Me.Button7.TabIndex = 952
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BtnCariPemasok
        '
        Me.BtnCariPemasok.BackgroundImage = Global.warung_contoh.My.Resources.Resources.cari
        Me.BtnCariPemasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCariPemasok.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariPemasok.Location = New System.Drawing.Point(365, 163)
        Me.BtnCariPemasok.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCariPemasok.Name = "BtnCariPemasok"
        Me.BtnCariPemasok.Size = New System.Drawing.Size(50, 46)
        Me.BtnCariPemasok.TabIndex = 927
        Me.BtnCariPemasok.UseVisualStyleBackColor = True
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 909)
        Me.Controls.Add(Me.PanelBarang)
        Me.Controls.Add(Me.PanelPelanggan)
        Me.Controls.Add(Me.PanelFaktur)
        Me.Controls.Add(Me.TxTotal)
        Me.Controls.Add(Me.TxJumlah)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxItem)
        Me.Controls.Add(Me.DGVIEW)
        Me.Controls.Add(Me.BtnCariFaktur)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxDiscount)
        Me.Controls.Add(Me.TxHargasat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Txsatuan)
        Me.Controls.Add(Me.TxNamabrg)
        Me.Controls.Add(Me.TxKodebrg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txAmount)
        Me.Controls.Add(Me.Lblkeluar)
        Me.Controls.Add(Me.LblHapus)
        Me.Controls.Add(Me.LblSimpan)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TxNofakt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxTglJt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxJT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCariPemasok)
        Me.Controls.Add(Me.txkatagori)
        Me.Controls.Add(Me.TxNamaPlg)
        Me.Controls.Add(Me.TxKodePlg)
        Me.Controls.Add(Me.txtglfakt)
        Me.Controls.Add(Me.Label27)
        Me.Name = "FrmPenjualan"
        Me.Text = "FrmPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFaktur.ResumeLayout(False)
        Me.PanelFaktur.PerformLayout()
        CType(Me.DGFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPelanggan.ResumeLayout(False)
        Me.PanelPelanggan.PerformLayout()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarang.ResumeLayout(False)
        Me.PanelBarang.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSFaktur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxTotal As TextBox
    Friend WithEvents TxJumlah As TextBox
    Friend WithEvents BSBarang As BindingSource
    Friend WithEvents Label22 As Label
    Friend WithEvents TxItem As TextBox
    Friend WithEvents DGVIEW As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelFaktur As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txkuncifaktur As TextBox
    Friend WithEvents DGFaktur As DataGridView
    Friend WithEvents PanelPelanggan As Panel
    Friend WithEvents txCariPelanggan As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DGPelanggan As DataGridView
    Friend WithEvents PanelBarang As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtkunci As TextBox
    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents BtnCariFaktur As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BSFaktur As BindingSource
    Friend WithEvents BSPelanggan As BindingSource
    Friend WithEvents TxDiscount As TextBox
    Friend WithEvents BSPenjualan As BindingSource
    Friend WithEvents TxHargasat As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Txsatuan As TextBox
    Friend WithEvents TxNamabrg As TextBox
    Friend WithEvents TxKodebrg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txAmount As TextBox
    Friend WithEvents Lblkeluar As Label
    Friend WithEvents LblHapus As Label
    Friend WithEvents LblSimpan As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TxNofakt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxTglJt As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TxJT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCariPemasok As Button
    Friend WithEvents txkatagori As TextBox
    Friend WithEvents TxNamaPlg As TextBox
    Friend WithEvents TxKodePlg As TextBox
    Friend WithEvents txtglfakt As DateTimePicker
    Friend WithEvents Label27 As Label
End Class
