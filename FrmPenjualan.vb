Imports System.Data.Odbc
Public Class FrmPenjualan
    Dim adp As Odbc.OdbcDataAdapter
    Dim adp1 As Odbc.OdbcDataAdapter
    Dim adp2 As Odbc.OdbcDataAdapter
    Dim cmdb As Odbc.OdbcCommandBuilder
    Dim tbl As DataTable
    Private Sub AutoNumber()
        Dim last As Integer
        Dim banyak As Single
        Dim th As String
        th = "F" & Format(Now(), "yy") & Format(Now(), "MM")
        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd1 = New OdbcCommand("select max(mid(nofakt,6,5)) from penjualan where mid(nofakt,1,5)='" & th & "'  ", conn)
        cmd = New OdbcCommand("select count(*) from penjualan where mid(nofakt,1,5)='" & th & "' ", conn)
        Try
            banyak = cmd.ExecuteScalar
            If banyak < 1 Then
                TxNofakt.Text = th & "00001"
            Else
                last = cmd1.ExecuteScalar
                TxNofakt.Text = th & Format(last + 1, "00000")
            End If
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try

    End Sub
    Private Sub Lbledit_MouseMove(sender As Object, e As MouseEventArgs) Handles LblHapus.MouseMove
        Me.Cursor = Cursors.Hand
        LblHapus.BackColor = Color.MidnightBlue
        LblHapus.ForeColor = Color.White
    End Sub
    Private Sub Lbledit_MouseLeave(sender As Object, e As EventArgs) Handles LblHapus.MouseLeave
        Me.Cursor = Cursors.Default
        LblHapus.BackColor = Color.White
        LblHapus.ForeColor = Color.MidnightBlue

    End Sub
    Private Sub LblKeluar_MouseMove(sender As Object, e As MouseEventArgs) Handles Lblkeluar.MouseMove
        Me.Cursor = Cursors.Hand
        Lblkeluar.BackColor = Color.MidnightBlue
        Lblkeluar.ForeColor = Color.White
    End Sub
    Private Sub LblKeluar_MouseLeave(sender As Object, e As EventArgs) Handles Lblkeluar.MouseLeave
        Me.Cursor = Cursors.Default
        Lblkeluar.BackColor = Color.White
        Lblkeluar.ForeColor = Color.MidnightBlue

    End Sub

    Private Sub Lblsimpan_MouseMove(sender As Object, e As MouseEventArgs) Handles LblSimpan.MouseMove
        Me.Cursor = Cursors.Hand
        LblSimpan.BackColor = Color.MidnightBlue
        LblSimpan.ForeColor = Color.White
    End Sub
    Private Sub Lblsimpan_MouseLeave(sender As Object, e As EventArgs) Handles LblSimpan.MouseLeave
        Me.Cursor = Cursors.Default
        LblSimpan.BackColor = Color.White
        LblSimpan.ForeColor = Color.MidnightBlue

    End Sub

    Private Sub BtnCariFaktur_Click(sender As Object, e As EventArgs) Handles BtnCariFaktur.Click
        PanelFaktur.Visible = True
        PanelFaktur.BringToFront()
        PanelFaktur.Size = New Size(650, 330)
        PanelFaktur.Location = New Point(251, 151)
        txkuncifaktur.Text = ""
        txkuncifaktur.Focus()
    End Sub

    Private Sub BtnCariPemasok_Click(sender As Object, e As EventArgs) Handles BtnCariPemasok.Click
        PanelPelanggan.Visible = True
        PanelPelanggan.Size = New Size(598, 373)
        PanelPelanggan.Location = New Point(251, 212)
        PanelPelanggan.BringToFront()
        txCariPelanggan.Text = ""
        txCariPelanggan.Focus()
    End Sub

    Private Sub Lblkeluar_Click(sender As Object, e As EventArgs) Handles Lblkeluar.Click
        Me.Close()
    End Sub

    Private Sub FrmPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelPelanggan.Visible = False
        PanelFaktur.Visible = False
        txtglfakt.Value = Now()
        TxTglJt.Value = Now()
        isitabelfaktur()
        IsiTabelBarang()
        IsiTabelPelanggan()
        AutoNumber()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PanelFaktur.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelPelanggan.Visible = False
    End Sub
    Private Sub isitabelfaktur()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT nofakt,tglfakt,namaplg,totalfakt  from penjualan", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BSFaktur.DataSource = tbl
            DGFaktur.DataSource = Me.BSFaktur
            Me.DGFaktur.Refresh()
            With DGFaktur
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "No Faktur"
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(0).Width = 110
                .Columns(1).HeaderText = "Tanggal"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).Width = 110
                .Columns(2).HeaderText = "Nama Pemasok"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).Width = 280
                .Columns(3).HeaderText = "Total faktur"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(3).DefaultCellStyle.Format = "N0"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warung Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelBarang.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TxJT.Text = "" Then
            MsgBox("Masa Jatuh Tempo tidak boleh kosong !", MsgBoxStyle.OkOnly, "Perhatian")
            TxJT.Focus()
            Exit Sub
        ElseIf TxKodePlg.Text = "" Then
            MsgBox("Kode Supplier tidak boleh kosong !", MsgBoxStyle.OkOnly, "Perhatian")
            TxKodePlg.Focus()
            Exit Sub
        Else
            txtkunci.Text = ""

            PanelBarang.Visible = True
            PanelBarang.Size = New Size(720, 361)
            PanelBarang.Location = New Point(297, 291)
            PanelBarang.BringToFront()
            txtkunci.Focus()
            txtkunci.Text = ""
            IsiTabelBarang()
        End If

    End Sub
    Private Sub IsiTabelBarang()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT kodebrg,namabrg,satuan,hargabeli,hargajual  from barang", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BSBarang.DataSource = tbl
            DGBarang.DataSource = Me.BSBarang

            Me.DGBarang.Refresh()
            With DGBarang
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "Kode"
                .Columns(0).Width = 70
                .Columns(1).HeaderText = "Nama Barang"
                .Columns(1).Width = 350
                .Columns(2).HeaderText = "Satuan"
                .Columns(2).Width = 50
                .Columns(3).HeaderText = "Harga Beli"
                .Columns(3).Width = 100
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).HeaderText = "Harga Jual"
                .Columns(4).Width = 100
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub IsiTabelPelanggan()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT * from pelanggan", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BSPelanggan.DataSource = tbl
            DGPelanggan.DataSource = Me.BSPelanggan
            Me.DGPelanggan.Refresh()
            With DGPelanggan
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "Kode"
                .Columns(0).Width = 80
                .Columns(1).HeaderText = "Nama pemasok"
                .Columns(1).Width = 300
                .Columns(2).HeaderText = "Alamat"
                .Columns(2).Width = 400
                .Columns(3).HeaderText = "Telpon"
                .Columns(3).Width = 100
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warung Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BindingPelanggan()
        TxKodePlg.DataBindings.Add("text", Me.BSPelanggan, "kodeplg")
        TxNamaPlg.DataBindings.Add("text", Me.BSPelanggan, "namaplg")
        TxKodePlg.DataBindings.Clear()
        TxNamaPlg.DataBindings.Clear()
    End Sub
    Private Sub DGPelangan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPelanggan.CellDoubleClick
        BindingPelanggan()
        PanelPelanggan.Visible = False
        TxJT.Focus()

    End Sub
    Private Sub BindingFaktur()
        TxNofakt.DataBindings.Add("text", Me.BSFaktur, "nofakt")
        TxNofakt.DataBindings.Clear()
        PanelFaktur.Visible = False
    End Sub

    Private Sub DGFaktur_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFaktur.CellDoubleClick
        BindingFaktur()
        AmbilFaktur()
    End Sub
    Private Sub AmbilFaktur()
        Dim hasil As Single
        Dim hasil1 As String
        Dim hasil2 As String
        Dim hasil3 As String
        Dim hasil4 As Double
        Dim hasil5 As String
        Dim hasil6 As Single

        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd = New OdbcCommand("select count(*) from penjualan where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd1 = New OdbcCommand("select tglfakt from penjualan  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd2 = New OdbcCommand("select kodeplg from penjualan where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd3 = New OdbcCommand("select namaplg from penjualan  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd4 = New OdbcCommand("select totalfakt  from penjualan  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd5 = New OdbcCommand("select jt  from penjualan  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd6 = New OdbcCommand("select top  from penjualan  where nofakt = '" & TxNofakt.Text & "'", conn)


        Try
            hasil = cmd.ExecuteScalar
            If (hasil > 0) Then
                hasil = cmd.ExecuteScalar
                hasil1 = cmd1.ExecuteScalar
                hasil2 = cmd2.ExecuteScalar
                hasil3 = cmd3.ExecuteScalar
                hasil4 = cmd4.ExecuteScalar
                hasil5 = cmd5.ExecuteScalar
                hasil6 = cmd6.ExecuteScalar


                txtglfakt.Text = hasil1
                TxKodePlg.Text = hasil2
                TxNamaPlg.Text = hasil3
                txAmount.Text = hasil4.ToString("###,0")
                TxTglJt.Text = hasil5
                TxJT.Text = hasil6
                IsitabelPenjualan()

                Ttl()
            Else
                MsgBox("Faktur tidak ditemukan", , "Infomasi")
                TxNofakt.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try
    End Sub
    Private Sub Ttl()
        Dim TOTAL As Single
        Dim kosong As Single

        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd2 = New OdbcCommand("select count(*) from penjualandtl where nofakt='" & TxNofakt.Text & "'", conn)
        cmd1 = New OdbcCommand("select sum(total) from penjualandtl where nofakt='" & TxNofakt.Text & "'", conn)
        Try
            kosong = cmd2.ExecuteScalar
            If kosong > 0 Then
                TOTAL = cmd1.ExecuteScalar
                txAmount.Text = FormatNumber(TOTAL, 0, , , TriState.True)
            Else
                txAmount.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try

    End Sub


    Private Sub IsitabelPenjualan()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT item,kodebrg,namabrg,satuan,harga,jumlah,discount,total  from penjualandtl where nofakt='" & TxNofakt.Text & "'", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BSPenjualan.DataSource = tbl
            DGVIEW.DataSource = Me.BSPenjualan
            'Me.BS2.DataSource = tbl
            Me.DGVIEW.Refresh()
            With DGVIEW
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "No"
                .Columns(0).Width = 60
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Kode"
                .Columns(1).Width = 120
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).HeaderText = "Nama Barang"
                .Columns(2).Width = 375
                .Columns(3).HeaderText = "Satuan"
                .Columns(3).Width = 75
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).HeaderText = "Harga"
                .Columns(4).Width = 90
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).HeaderText = "Jumlah"
                .Columns(5).Width = 70
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(6).HeaderText = "Discount"
                .Columns(6).Width = 90
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Format = "N0"
                .Columns(7).HeaderText = "Total"
                .Columns(7).Width = 100
                .Columns(7).DefaultCellStyle.Format = "N0"
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warung Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxHargasat.Text = "" Then
            MsgBox("Harga satuan tidak boleh kosong !", MsgBoxStyle.OkOnly, "Perhatian")
            Exit Sub
        ElseIf TxJumlah.Text = "" Then
            MsgBox("Jumlah tidak boleh kosong !", MsgBoxStyle.OkOnly, "Perhatian")
            Exit Sub

        ElseIf TxDiscount.Text = "" Then
            MsgBox("Discount tidak boleh kosong", MsgBoxStyle.OkOnly, "Perhatian")
            Exit Sub
        Else
            nomorurut()
            HitungTotal()
            IsiPenjualan()
            IsiPenjualanDtl()
            UpdateBarang()
            IsitabelPenjualan()
            Bersih()

        End If
    End Sub
    Private Sub Bersih()
        TxKodebrg.Text = ""
        TxNamabrg.Text = ""
        TxHargasat.Text = ""
        Txsatuan.Text = ""
        TxJumlah.Text = ""
        TxDiscount.Text = ""
        TxTotal.Text = ""
    End Sub
    Private Sub UpdateBarang()

        conn = New OdbcConnection(connstr)
        conn.Open()
        Dim HargaBeli As Single
        Dim Jumlah As Single

        HargaBeli = TxHargasat.Text
        Jumlah = TxJumlah.Text

        sql = "UPDATE barang set hargabeli= " & HargaBeli.ToString("##0") & ",stok=stok-" & Jumlah.ToString("##0") & " where kodebrg = '" & TxKodebrg.Text & "' "

        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery()
                End Using


            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub IsiPenjualanDtl()
        Dim val As Double
        Dim val1 As Double
        Dim val2 As Double
        Dim val3 As Double
        If TxDiscount.Text = "" Then TxDiscount.Text = 0

        val = TxHargasat.Text
        val1 = TxJumlah.Text
        val2 = TxDiscount.Text
        val3 = TxTotal.Text

        sql1 = "insert into penjualandtl (nofakt,tglfakt,kodeplg,item,kodebrg,namabrg,satuan,harga,jumlah,discount,total) values ('" & TxNofakt.Text & "','" & Format(txtglfakt.Value, "yyyy-MM-dd") & "','" & TxKodePlg.Text & "'," & TxItem.Text & ",'" & TxKodebrg.Text & "','" & TxNamabrg.Text & "','" & Txsatuan.Text & "'," & val & "," & val1 & "," & val2 & "," & val3 & ")"
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
    Private Sub koreksi()
        Dim val As Double

        val = txAmount.Text

        sql1 = "update penjualan set tglfakt ='" & Format(txtglfakt.Value, "yyyy-MM-dd") & "', kodeplg='" & TxKodePlg.Text & "', namaplg='" & TxNamaPlg.Text & "',saldo=" & val & ", totalfakt=" & val & "  where nofakt='" & TxNofakt.Text & "'"
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
    Private Sub IsiPenjualan()
        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd2 = New OdbcCommand("select count(*) from penjualan where nofakt = '" & TxNofakt.Text & "'", conn)
        Try
            result1 = cmd2.ExecuteScalar
            If (result1 > 0) Then
                koreksi()
            Else
                tambah()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tambah()
        Dim val As Double

        val = txAmount.Text

        sql1 = "insert into penjualan (nofakt,tglfakt,kodeplg,namaplg,totalfakt,jt,top,saldo) values ('" & TxNofakt.Text & "','" & Format(txtglfakt.Value, "yyyy-MM-dd") & "', '" & TxKodePlg.Text & "', '" & TxNamaPlg.Text & "'," & val & ",'" & Format(TxTglJt.Value, "yyyy-MM-dd") & "'," & TxJT.Text & "," & val & ")"
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
    Private Sub HitungTotal()
        Dim total As Double
        Dim amt As Double
        Dim totalan As Double
        If txAmount.Text = "" Then txAmount.Text = 0
        total = txAmount.Text
        amt = TxTotal.Text
        totalan = total + amt
        txAmount.Text = totalan.ToString("###,0")

    End Sub
    Private Sub nomorurut()
        Dim last As Integer
        Dim banyak As Single



        conn = New OdbcConnection(connstr)
        conn.Open()

        cmd1 = New OdbcCommand("select max(item) from penjualandtl where nofakt='" & TxNofakt.Text & "'   ", conn)
        cmd = New OdbcCommand("select count(*) from penjualandtl where nofakt='" & TxNofakt.Text & "'", conn)

        Try
            banyak = cmd.ExecuteScalar
            If banyak < 1 Then
                TxItem.Text = "1"
            Else
                last = cmd1.ExecuteScalar
                If TxItem.Text = "" Then
                    TxItem.Text = last + 1
                End If
            End If
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try
    End Sub
    Private Sub CetakFaktur()
        Dim str As String

        str = "select penjualan.nofakt,penjualan.tglfakt,penjualan.kodeplg,penjualan.namaplg,penjualan.jt,pelanggan.alamatplg,pelanggan.telpplg,penjualandtl.kodebrg,penjualandtl.namabrg,penjualandtl.satuan,penjualandtl.harga,penjualandtl.jumlah,penjualandtl.harga,penjualandtl.discount,penjualandtl.total from penjualandtl inner join penjualan on penjualandtl.nofakt=penjualan.nofakt inner join pelanggan on penjualandtl.kodeplg=pelanggan.kodeplg where penjualan.nofakt ='" & TxNofakt.Text & "'"

        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            CetakanFaktur.DSFaktur.Clear()
            CetakanFaktur.DSFaktur.EnforceConstraints = False
            Call konek_DB()
            adp = New Odbc.OdbcDataAdapter(str, conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            adp.Fill(CetakanFaktur.DSFaktur.DataTable1)

            cmdb.Dispose()
            adp.Dispose()

            conn.Close()
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.Message)
        End Try
        CetakanFaktur.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        CetakanFaktur.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        CetakanFaktur.ReportViewer1.ZoomPercent = 100
        CetakanFaktur.ReportViewer1.RefreshReport()

        CetakanFaktur.ReportViewer1.Dock = DockStyle.Fill
        CetakanFaktur.Show()



    End Sub

    Private Sub LblSimpan_Click(sender As Object, e As EventArgs) Handles LblSimpan.Click
        IsiPenjualan()
        MsgBox("Data Faktur Penjualan telah disimpan", , "Infomasi")
        Bersih()
        txtglfakt.Text = Now()
        txAmount.Text = ""
        TxKodePlg.Text = ""
        TxNamaPlg.Text = ""
        TxJT.Text = ""
        TxTglJt.Value = Now()
        IsitabelPenjualan()
        CetakFaktur()
        AutoNumber()
    End Sub
    Private Sub HapusDetail()

        sql = "delete from penjualandtl where nofakt = '" & TxNofakt.Text & "' and item = " & TxItem.Text & " "
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub HapusFaktur()


        sql = "delete from penjualan where nofakt = '" & TxNofakt.Text & "'  "
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TxJT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxJT.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Dim top As DateTime
            Dim jt As Integer
            jt = TxJT.Text.ToString
            top = txtglfakt.Value.AddDays(jt)
            TxTglJt.Value = top

        End If
    End Sub
    Private Sub LblHapus_Click(sender As Object, e As EventArgs) Handles LblHapus.Click
        Dim result = MessageBox.Show("Faktur dengan Nomor : '" & TxNofakt.Text & "' akan dihapus", "Mohon Konfirmasinya", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            MsgBox("Faktur dengan nomor :  '" & TxNofakt.Text & "' Batal dihapus", MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub

        Else
            HapusFaktur()
            HapusDetail()
        End If


    End Sub

    Private Sub DGBarang_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellDoubleClick
        bindingBarang()
        PanelBarang.Visible = False
        TxHargasat.Focus()
    End Sub
    Private Sub bindingBarang()
        TxKodebrg.DataBindings.Add("text", Me.BSBarang, "kodebrg")
        TxNamabrg.DataBindings.Add("text", Me.BSBarang, "namabrg")
        Txsatuan.DataBindings.Add("text", Me.BSBarang, "satuan")
        TxHargasat.DataBindings.Add("text", Me.BSBarang, "hargajual")
        TxKodebrg.DataBindings.Clear()
        TxNamabrg.DataBindings.Clear()
        Txsatuan.DataBindings.Clear()
        TxHargasat.DataBindings.Clear()
    End Sub
    Private Sub TxHargasat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxHargasat.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not IsNumeric(TxHargasat.Text) Or TxHargasat.Text = "" Then
                MsgBox("Harga harus berupa angka", , "Perhatian")
                Exit Sub
            End If
            Dim val1 As Double
            val1 = TxHargasat.Text
            TxHargasat.Text = FormatNumber(val1, 0, , , TriState.True)
            TxJumlah.Focus()
        End If
    End Sub

    Private Sub txdiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxDiscount.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If TxDiscount.Text = "" Then TxDiscount.Text = 0
            If Not IsNumeric(TxDiscount.Text) Or TxDiscount.Text = "" Then
                MsgBox("Discount must be a number", , "Warning")
                Exit Sub
            End If
            Dim val1 As Double
            val1 = TxDiscount.Text
            TxDiscount.Text = FormatNumber(val1, 0, , , TriState.True)
            TxTotal.Text = TxHargasat.Text * TxJumlah.Text - TxDiscount.Text
            Dim val As Double
            val = TxTotal.Text
            TxTotal.Text = FormatNumber(val, 0, , , TriState.True)
            Button1.Focus()
        End If
    End Sub
    Private Sub txjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxJumlah.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Not IsNumeric(TxJumlah.Text) Or TxJumlah.Text = "" Then
                MsgBox("Quantity must be a number", , "Warning")
                Exit Sub
            End If
            TxTotal.Text = TxHargasat.Text * TxJumlah.Text
            Dim val As Double
            val = TxTotal.Text
            TxTotal.Text = FormatNumber(val, 0, , , TriState.True)
            TxDiscount.Focus()
        End If
    End Sub

    Private Sub DGVIEW_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVIEW.CellDoubleClick
        BindingPenjualan()
        HapusDetailPenjualan()
        IsitabelPenjualan()
        Ttl()
        FormatAngka()

    End Sub
    Private Sub BindingPenjualan()
        TxItem.DataBindings.Add("text", Me.BSPenjualan, "item")
        TxKodebrg.DataBindings.Add("text", Me.BSPenjualan, "kodebrg")
        TxNamabrg.DataBindings.Add("text", Me.BSPenjualan, "namabrg")
        Txsatuan.DataBindings.Add("text", Me.BSPenjualan, "satuan")
        TxHargasat.DataBindings.Add("text", Me.BSPenjualan, "harga")
        TxJumlah.DataBindings.Add("text", Me.BSPenjualan, "jumlah")
        TxDiscount.DataBindings.Add("text", Me.BSPenjualan, "discount")
        TxTotal.DataBindings.Add("text", Me.BSPenjualan, "total")
        TxItem.DataBindings.Clear()
        TxKodebrg.DataBindings.Clear()
        TxNamabrg.DataBindings.Clear()
        Txsatuan.DataBindings.Clear()
        TxHargasat.DataBindings.Clear()
        TxJumlah.DataBindings.Clear()
        TxDiscount.DataBindings.Clear()
        TxTotal.DataBindings.Clear()
    End Sub
    Private Sub HapusDetailPenjualan()
        sql = "delete from penjualandtl where nofakt = '" & TxNofakt.Text & "' and item='" & TxItem.Text & "' "
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FormatAngka()
        Dim hs As Single
        Dim ds As Single
        Dim tl As Single
        hs = TxHargasat.Text
        ds = TxDiscount.Text
        tl = TxTotal.Text
        TxHargasat.Text = FormatNumber(hs, 0, , , TriState.True)
        TxDiscount.Text = FormatNumber(ds, 0, , , TriState.True)
        TxTotal.Text = FormatNumber(tl, 0, , , TriState.True)
    End Sub
End Class