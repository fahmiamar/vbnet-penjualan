Imports System.Data.Odbc
Public Class FrmPembelian
    Dim adp As Odbc.OdbcDataAdapter
    Dim adp1 As Odbc.OdbcDataAdapter
    Dim adp2 As Odbc.OdbcDataAdapter
    Dim cmdb As Odbc.OdbcCommandBuilder
    Dim tbl As DataTable
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
        TxCariFaktur.Text = ""
        TxCariFaktur.Focus()
    End Sub

    Private Sub BtnCariPemasok_Click(sender As Object, e As EventArgs) Handles BtnCariPemasok.Click
        PanelPemasok.Visible = True
        PanelPemasok.Size = New Size(598, 373)
        PanelPemasok.Location = New Point(251, 212)
        PanelPemasok.BringToFront()
        TxCariPemasok.Text = ""
        TxCariPemasok.Focus()
    End Sub

    Private Sub Lblkeluar_Click(sender As Object, e As EventArgs) Handles Lblkeluar.Click
        Me.Close()
    End Sub

    Private Sub FrmPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelPemasok.Visible = False
        PanelFaktur.Visible = False
        txtglfakt.Value = Now()
        TxTglJt.Value = Now()
        isitabelfaktur()
        IsiTabelBarang()
        IsiTabelPemasok()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PanelFaktur.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelPemasok.Visible = False
    End Sub
    Private Sub isitabelfaktur()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT nofakt,tglfakt,namapmk,totalfakt  from pembelian", conn)
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
                .Columns(0).Width = 100
                .Columns(1).HeaderText = "Tanggal"
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(1).Width = 100
                .Columns(2).HeaderText = "Nama Pemasok"
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(2).Width = 300
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
        ElseIf TxKodePmk.Text = "" Then
            MsgBox("Kode Supplier tidak boleh kosong !", MsgBoxStyle.OkOnly, "Perhatian")
            TxKodePmk.Focus()
            Exit Sub
        Else
            TxCariBarang.Text = ""

            PanelBarang.Visible = True
            PanelBarang.Size = New Size(720, 361)
            PanelBarang.Location = New Point(297, 291)
            PanelBarang.BringToFront()
            TxCariBarang.Focus()
            TxCariBarang.Text = ""
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

    Private Sub IsiTabelPemasok()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT * from pemasok", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BSPemasok.DataSource = tbl
            DGPemasok.DataSource = Me.BSPemasok
            Me.DGPemasok.Refresh()
            With DGPemasok
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
    Private Sub BindingPemasok()
        TxKodePmk.DataBindings.Add("text", Me.BSPemasok, "kodepmk")
        TxNamaPmk.DataBindings.Add("text", Me.BSPemasok, "namapmk")
        TxKodePmk.DataBindings.Clear()
        TxNamaPmk.DataBindings.Clear()
    End Sub
    Private Sub DGPemasok_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPemasok.CellDoubleClick
        BindingPemasok()
        PanelPemasok.Visible = False
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
        cmd = New OdbcCommand("select count(*) from pembelian where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd1 = New OdbcCommand("select tglfakt from pembelian  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd2 = New OdbcCommand("select kodepmk from pembelian where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd3 = New OdbcCommand("select namapmk from pembelian  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd4 = New OdbcCommand("select totalfakt  from pembelian  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd5 = New OdbcCommand("select jt  from pembelian  where nofakt = '" & TxNofakt.Text & "'", conn)
        cmd6 = New OdbcCommand("select top  from pembelian  where nofakt = '" & TxNofakt.Text & "'", conn)


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
                TxKodePmk.Text = hasil2
                TxNamaPmk.Text = hasil3
                txAmount.Text = hasil4.ToString("###,0")
                TxTglJt.Text = hasil5
                TxJT.Text = hasil6
                IsitabelPembelian()

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
        cmd2 = New OdbcCommand("select count(*) from pembeliandtl where nofakt='" & TxNofakt.Text & "'", conn)
        cmd1 = New OdbcCommand("select sum(total) from pembeliandtl where nofakt='" & TxNofakt.Text & "'", conn)
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
    Private Sub IsitabelPembelian()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("SELECT item,kodebrg,namabrg,satuan,harga,jumlah,discount,total  from pembeliandtl where nofakt='" & TxNofakt.Text & "'", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BSPembelian.DataSource = tbl
            DGVIEW.DataSource = Me.BSPembelian
            'Me.BS2.DataSource = tbl
            Me.DGVIEW.Refresh()
            With DGVIEW
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "No"
                .Columns(0).Width = 60
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Kode Barang"
                .Columns(1).Width = 110
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(2).HeaderText = "Nama Barang"
                .Columns(2).Width = 385
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
            IsiPembelian()
            IsiPembelianDtl()
            UpdateBarang()
            IsitabelPembelian()
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

        sql = "UPDATE barang set hargabeli= " & HargaBeli.ToString("##0") & ",stok=stok+" & Jumlah.ToString("##0") & " where kodebrg = '" & TxKodebrg.Text & "' "

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
    Private Sub IsiPembelianDtl()
        Dim val As Double
        Dim val1 As Double
        Dim val2 As Double
        Dim val3 As Double
        If TxDiscount.Text = "" Then TxDiscount.Text = 0

        val = TxHargasat.Text
        val1 = TxJumlah.Text
        val2 = TxDiscount.Text
        val3 = TxTotal.Text

        sql1 = "insert into pembeliandtl (nofakt,tglfakt,kodepmk,item,kodebrg,namabrg,satuan,harga,jumlah,discount,total) values ('" & TxNofakt.Text & "','" & Format(txtglfakt.Value, "yyyy-MM-dd") & "','" & TxKodePmk.Text & "'," & TxItem.Text & ",'" & TxKodebrg.Text & "','" & TxNamabrg.Text & "','" & Txsatuan.Text & "'," & val & "," & val1 & "," & val2 & "," & val3 & ")"
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

        sql1 = "update pembelian set tglfakt ='" & Format(txtglfakt.Value, "yyyy-MM-dd") & "', kodepmk='" & TxKodePmk.Text & "', namapmk='" & TxNamaPmk.Text & "',saldo=" & val & ", totalfakt=" & val & "  where nofakt='" & TxNofakt.Text & "'"
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
    Private Sub IsiPembelian()
        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd2 = New OdbcCommand("select count(*) from pembelian where nofakt = '" & TxNofakt.Text & "'", conn)
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

        sql1 = "insert into pembelian (nofakt,tglfakt,kodepmk,namapmk,totalfakt,jt,top,saldo) values ('" & TxNofakt.Text & "','" & Format(txtglfakt.Value, "yyyy-MM-dd") & "', '" & TxKodePmk.Text & "', '" & TxNamaPmk.Text & "'," & val & ",'" & Format(TxTglJt.Value, "yyyy-MM-dd") & "'," & TxJT.Text & "," & val & ")"
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

        cmd1 = New OdbcCommand("select max(urut) from pembeliandtl where nofakt='" & TxNofakt.Text & "'   ", conn)
        cmd = New OdbcCommand("select count(*) from pembeliandtl where nofakt='" & TxNofakt.Text & "'", conn)

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

    Private Sub LblSimpan_Click(sender As Object, e As EventArgs) Handles LblSimpan.Click
        IsiPembelian()
        MsgBox("Data Faktur Pembelian telah disimpan", , "Infomasi")
        Bersih()
        txtglfakt.Text = Now()
        TxNofakt.Text = ""
        txAmount.Text = ""
        TxKodePmk.Text = ""
        TxNamaPmk.Text = ""
        TxJT.Text = ""
        TxTglJt.Value = Now()
        IsitabelPembelian()
    End Sub
    Private Sub HapusDetail()

        sql = "delete from pembeliandtl where nofakt = '" & TxNofakt.Text & "' and item = " & TxItem.Text & " "
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


        sql = "delete from pembelian where nofakt = '" & TxNofakt.Text & "'  "
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
        TxKodebrg.DataBindings.Clear()
        TxNamabrg.DataBindings.Clear()
        Txsatuan.DataBindings.Clear()
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

    Private Sub Txkuncifaktur_TextChanged(sender As Object, e As EventArgs) Handles TxCariFaktur.TextChanged
        Dim strReplace As String = Me.TxCariFaktur.Text.Replace("'", "''")
        Dim str As String = "namapmk" &
                " LIKE '%" & strReplace & "%'"
        Try
            Me.BSFaktur.Filter = str
            Me.DGFaktur.DataSource = Me.BSFaktur
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TxCariPemasok_TextChanged(sender As Object, e As EventArgs) Handles TxCariPemasok.TextChanged
        Dim strReplace As String = Me.TxCariPemasok.Text.Replace("'", "''")
        Dim str As String = "namapmk" &
                " LIKE '%" & strReplace & "%'"
        Try
            Me.BSPemasok.Filter = str
            Me.DGPemasok.DataSource = Me.BSPemasok
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TxCariBarang_TextChanged(sender As Object, e As EventArgs) Handles TxCariBarang.TextChanged
        Dim strReplace As String = Me.TxCariBarang.Text.Replace("'", "''")
        Dim str As String = "namabrg" &
                " LIKE '%" & strReplace & "%'"
        Try
            Me.BSBarang.Filter = str
            Me.DGBarang.DataSource = Me.BSBarang
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


End Class