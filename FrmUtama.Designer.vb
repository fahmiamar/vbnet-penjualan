<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianDanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 81)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.PemasokToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDataToolStripMenuItem.Image = Global.warung_contoh.My.Resources.Resources.Master_Data
        Me.MasterDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(107, 77)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        Me.MasterDataToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(170, 28)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(170, 28)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'PemasokToolStripMenuItem
        '
        Me.PemasokToolStripMenuItem.Name = "PemasokToolStripMenuItem"
        Me.PemasokToolStripMenuItem.Size = New System.Drawing.Size(170, 28)
        Me.PemasokToolStripMenuItem.Text = "Pemasok"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianBarangToolStripMenuItem, Me.PenjualanBarangToolStripMenuItem})
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = Global.warung_contoh.My.Resources.Resources.transaksi
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(92, 77)
        Me.ToolStripMenuItem2.Text = "Transaksi"
        Me.ToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PembelianBarangToolStripMenuItem
        '
        Me.PembelianBarangToolStripMenuItem.Name = "PembelianBarangToolStripMenuItem"
        Me.PembelianBarangToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.PembelianBarangToolStripMenuItem.Text = "Pembelian Barang"
        '
        'PenjualanBarangToolStripMenuItem
        '
        Me.PenjualanBarangToolStripMenuItem.Name = "PenjualanBarangToolStripMenuItem"
        Me.PenjualanBarangToolStripMenuItem.Size = New System.Drawing.Size(223, 28)
        Me.PenjualanBarangToolStripMenuItem.Text = "Penjualan Barang"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPembelianDanPenjualanToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.warung_contoh.My.Resources.Resources.laporan
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(83, 77)
        Me.ToolStripMenuItem1.Text = "Laporan"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Image = Global.warung_contoh.My.Resources.Resources.medal
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(69, 77)
        Me.ToolStripMenuItem3.Text = "Keluar"
        Me.ToolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LaporanPembelianDanPenjualanToolStripMenuItem
        '
        Me.LaporanPembelianDanPenjualanToolStripMenuItem.Name = "LaporanPembelianDanPenjualanToolStripMenuItem"
        Me.LaporanPembelianDanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(336, 28)
        Me.LaporanPembelianDanPenjualanToolStripMenuItem.Text = "Laporan Pembelian dan Penjualan"
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmUtama"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemasokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianDanPenjualanToolStripMenuItem As ToolStripMenuItem
End Class
