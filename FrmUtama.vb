Public Class FrmUtama
    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.Show()

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Close()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub PemasokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemasokToolStripMenuItem.Click
        FrmPemasok.Show()
    End Sub

    Private Sub PembelianBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianBarangToolStripMenuItem.Click
        FrmPembelian.Show()

    End Sub

    Private Sub PenjualanBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanBarangToolStripMenuItem.Click
        FrmPenjualan.Show()
    End Sub

    Private Sub LaporanPembelianDanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianDanPenjualanToolStripMenuItem.Click
        FrmLaporan.Show()
    End Sub
End Class
