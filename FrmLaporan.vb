Imports System.Data.Odbc
Public Class FrmLaporan
    Dim adp As Odbc.OdbcDataAdapter
    Dim adp1 As Odbc.OdbcDataAdapter
    Dim adp2 As Odbc.OdbcDataAdapter
    Dim cmdb As Odbc.OdbcCommandBuilder
    Dim cmdb1 As Odbc.OdbcCommandBuilder
    Dim tbl As DataTable
    Private Sub CetakJualBarang()
        Dim str As String
        Dim str1 As String
        str = "SELECT nofakt,tglfakt,kodebrg,namabrg,satuan,harga,jumlah,discount,total,namaplg from penjualandtl INNER JOIN pelanggan ON penjualandtl.kodeplg = pelanggan.kodeplg  where  tglfakt>='" & Format(dr.Value, "yyyy-MM-dd") & "' and tglfakt <='" & Format(sd.Value, "yyyy-MM-dd") & "'  order by namabrg ASC"
        str1 = "select dari,sd from tanggal"
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            CetakLapJualBarang.DSJualBarang.Clear()
            CetakLapJualBarang.DSJualBarang.EnforceConstraints = False
            Call konek_DB()
            adp = New Odbc.OdbcDataAdapter(str, conn)
            adp1 = New Odbc.OdbcDataAdapter(str1, conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            cmdb1 = New Odbc.OdbcCommandBuilder(adp1)
            adp.Fill(CetakLapJualBarang.DSJualBarang.DataTable1)
            adp1.Fill(CetakLapJualBarang.DSJualBarang.DataTable2)
            cmdb.Dispose()
            adp.Dispose()
            cmdb1.Dispose()
            adp1.Dispose()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        CetakLapJualBarang.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        CetakLapJualBarang.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        CetakLapJualBarang.ReportViewer1.ZoomPercent = 100
        CetakLapJualBarang.ReportViewer1.RefreshReport()

        CetakLapJualBarang.ReportViewer1.Dock = DockStyle.Fill
        CetakLapJualBarang.Show()

    End Sub
    Private Sub CetakBeliBarang()
        Dim str As String
        Dim str1 As String
        str = "SELECT nofakt,tglfakt,kodebrg,namabrg,satuan,harga,jumlah,discount,total,namapmk from pembeliandtl INNER JOIN pemasok ON pembeliandtl.kodepmk = pemasok.kodepmk  where  tglfakt>='" & Format(dr.Value, "yyyy-MM-dd") & "' and tglfakt <='" & Format(sd.Value, "yyyy-MM-dd") & "'  order by namabrg ASC"
        str1 = "select dari,sd from tanggal"
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            CetakLapBeliBarang.DSBeliBarang.Clear()
            CetakLapBeliBarang.DSBeliBarang.EnforceConstraints = False
            Call konek_DB()
            adp = New Odbc.OdbcDataAdapter(str, conn)
            adp1 = New Odbc.OdbcDataAdapter(str1, conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            cmdb1 = New Odbc.OdbcCommandBuilder(adp1)
            adp.Fill(CetakLapBeliBarang.DSBeliBarang.DataTable1)
            adp1.Fill(CetakLapBeliBarang.DSBeliBarang.DataTable2)
            cmdb.Dispose()
            adp.Dispose()
            cmdb1.Dispose()
            adp1.Dispose()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        CetakLapBeliBarang.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        CetakLapBeliBarang.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        CetakLapBeliBarang.ReportViewer1.ZoomPercent = 100
        CetakLapBeliBarang.ReportViewer1.RefreshReport()

        CetakLapBeliBarang.ReportViewer1.Dock = DockStyle.Fill
        CetakLapBeliBarang.Show()

    End Sub
    Private Sub CetakJualPelanggan()
        Dim str As String
        Dim str1 As String
        str = "select * from penjualan where  tglfakt>='" & Format(dr.Value, "yyyy-MM-dd") & "' and tglfakt <='" & Format(sd.Value, "yyyy-MM-dd") & "'  order by namaplg ASC"
        str1 = "select dari,sd from tanggal"
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            CetakLapJualPelanggan.DSPenjualan.Clear()
            CetakLapJualPelanggan.DSPenjualan.EnforceConstraints = False
            Call konek_DB()
            adp = New Odbc.OdbcDataAdapter(str, conn)
            adp1 = New Odbc.OdbcDataAdapter(str1, conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            cmdb1 = New Odbc.OdbcCommandBuilder(adp1)
            adp.Fill(CetakLapJualPelanggan.DSPenjualan.DataTable1)
            adp1.Fill(CetakLapJualPelanggan.DSPenjualan.DataTable2)
            cmdb.Dispose()
            adp.Dispose()
            cmdb1.Dispose()
            adp1.Dispose()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        CetakLapJualPelanggan.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        CetakLapJualPelanggan.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        CetakLapJualPelanggan.ReportViewer1.ZoomPercent = 100
        CetakLapJualPelanggan.ReportViewer1.RefreshReport()

        CetakLapJualPelanggan.ReportViewer1.Dock = DockStyle.Fill
        CetakLapJualPelanggan.Show()

    End Sub
    Private Sub CetakBeliPemasok()
        Dim str As String
        Dim str1 As String
        str = "select * from pembelian where  tglfakt>='" & Format(dr.Value, "yyyy-MM-dd") & "' and tglfakt <='" & Format(sd.Value, "yyyy-MM-dd") & "'  order by namapmk ASC"
        str1 = "select dari,sd from tanggal"
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            CetakanLapBeliPemasok.DSPembelian.Clear()
            CetakanLapBeliPemasok.DSPembelian.EnforceConstraints = False
            Call konek_DB()
            adp = New Odbc.OdbcDataAdapter(str, conn)
            adp1 = New Odbc.OdbcDataAdapter(str1, conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            cmdb1 = New Odbc.OdbcCommandBuilder(adp1)
            adp.Fill(CetakanLapBeliPemasok.DSPembelian.DataTable1)
            adp1.Fill(CetakanLapBeliPemasok.DSPembelian.DataTable2)
            cmdb.Dispose()
            adp.Dispose()
            cmdb1.Dispose()
            adp1.Dispose()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        CetakanLapBeliPemasok.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        CetakanLapBeliPemasok.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        CetakanLapBeliPemasok.ReportViewer1.ZoomPercent = 100
        CetakanLapBeliPemasok.ReportViewer1.RefreshReport()

        CetakanLapBeliPemasok.ReportViewer1.Dock = DockStyle.Fill
        CetakanLapBeliPemasok.Show()



    End Sub

    Private Sub LbEdit_Click(sender As Object, e As EventArgs) Handles LbEdit.Click
        tanggalreport()
        If RB1.Checked = True Then
            CetakBeliPemasok()
        ElseIf RB2.Checked = True Then
            CetakBeliBarang()
        ElseIf RB3.Checked = True Then
            CetakJualPelanggan()
        ElseIf RB4.Checked = True Then
            CetakJualBarang()

        End If
    End Sub
    Private Sub LbEdit_MouseLeave(sender As Object, e As EventArgs) Handles LbEdit.MouseLeave
        Me.Cursor = Cursors.Default
        LbEdit.BackColor = Color.White
        LbEdit.ForeColor = Color.MidnightBlue

    End Sub
    Private Sub LbEdit_MouseMove(sender As Object, e As MouseEventArgs) Handles LbEdit.MouseMove
        Me.Cursor = Cursors.Hand
        LbEdit.BackColor = Color.MidnightBlue
        LbEdit.ForeColor = Color.White
    End Sub
    Private Sub LbKeluar_MouseLeave(sender As Object, e As EventArgs) Handles Lbkeluar.MouseLeave
        Me.Cursor = Cursors.Default
        Lbkeluar.BackColor = Color.White
        Lbkeluar.ForeColor = Color.MidnightBlue

    End Sub
    Private Sub LbKeluar_MouseMove(sender As Object, e As MouseEventArgs) Handles Lbkeluar.MouseMove
        Me.Cursor = Cursors.Hand
        Lbkeluar.BackColor = Color.MidnightBlue
        Lbkeluar.ForeColor = Color.White
    End Sub

    Private Sub FrmLaporan_Load(sender As Object, e As EventArgs) Handles Me.Load
        sd.Value = Now()
        dr.Value = Now()
        RB1.Checked = True
    End Sub
    Private Sub tanggalreport()

        sql1 = "update tanggal set dari='" & Format(dr.Value, "yyyy-MM-dd") & "',sd ='" & Format(sd.Value, "yyyy-MM-dd") & "'"
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()

                Using cmd1 As New OdbcCommand(sql1, conn)
                    result1 = cmd1.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Lbkeluar_Click(sender As Object, e As EventArgs) Handles Lbkeluar.Click
        Me.Close()

    End Sub
End Class