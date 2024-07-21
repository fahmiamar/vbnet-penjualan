Imports System.Data.Odbc
Public Class FrmBarang
    Dim adp As Odbc.OdbcDataAdapter
    Dim cmdb As Odbc.OdbcCommandBuilder
    Dim tbl As DataTable
    Private Sub AutoNumber()
        Dim last As Integer
        Dim banyak As Single

        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd1 = New OdbcCommand("select max(MID(kodebrg,2,4)) from barang", conn)
        cmd = New OdbcCommand("select count(*) from barang", conn)
        Try
            banyak = cmd.ExecuteScalar
            If banyak < 1 Then
                TxKodeBrg.Text = "B0001"
            Else
                last = cmd1.ExecuteScalar
                TxKodeBrg.Text = "B" & Format(last + 1, "0000")
            End If
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try

    End Sub

    Private Sub JenisCari()
        CbCari.Items.Clear()
        CbCari.Items.Add("Nama Barang")
        CbCari.Items.Add("Kode Barang")
    End Sub
    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutoNumber()
        JenisCari()
        Isitabel()
        TxKodeBrg.Enabled = False
        CbCari.Text = "Nama Barang"
        LbTambah.BackColor = Color.White
        LbTambah.ForeColor = Color.MidnightBlue
        LbSimpan.BackColor = Color.White
        LbSimpan.ForeColor = Color.MidnightBlue
        LbHapus.BackColor = Color.White
        LbHapus.ForeColor = Color.MidnightBlue
        LbKeluar.BackColor = Color.White
        LbKeluar.ForeColor = Color.MidnightBlue
        TxNamaBrg.Focus()

    End Sub
    Private Sub LbTambah_MouseMove(sender As Object, e As MouseEventArgs) Handles LbTambah.MouseMove
        Me.Cursor = Cursors.Hand
        LbTambah.BackColor = Color.MidnightBlue
        LbTambah.ForeColor = Color.White
    End Sub
    Private Sub LbTambah_MouseLeave(sender As Object, e As EventArgs) Handles LbTambah.MouseLeave
        Me.Cursor = Cursors.Default
        LbTambah.BackColor = Color.White
        LbTambah.ForeColor = Color.MidnightBlue

    End Sub

    Private Sub Lbsimpan_MouseMove(sender As Object, e As MouseEventArgs) Handles LbSimpan.MouseMove
        Me.Cursor = Cursors.Hand
        LbSimpan.BackColor = Color.MidnightBlue
        LbSimpan.ForeColor = Color.White
    End Sub
    Private Sub Lbsimpan_MouseLeave(sender As Object, e As EventArgs) Handles LbSimpan.MouseLeave
        Me.Cursor = Cursors.Default
        LbSimpan.BackColor = Color.White
        LbSimpan.ForeColor = Color.MidnightBlue

    End Sub
    Private Sub Lbhapus_MouseMove(sender As Object, e As MouseEventArgs) Handles LbHapus.MouseMove
        Me.Cursor = Cursors.Hand
        LbHapus.BackColor = Color.MidnightBlue
        LbHapus.ForeColor = Color.White
    End Sub
    Private Sub Lbhapus_MouseLeave(sender As Object, e As EventArgs) Handles LbHapus.MouseLeave
        Me.Cursor = Cursors.Default
        LbHapus.BackColor = Color.White
        LbHapus.ForeColor = Color.MidnightBlue

    End Sub
    Private Sub LbKeluar_MouseMove(sender As Object, e As MouseEventArgs) Handles LbKeluar.MouseMove
        Me.Cursor = Cursors.Hand
        LbKeluar.BackColor = Color.MidnightBlue
        LbKeluar.ForeColor = Color.White
    End Sub
    Private Sub LbKeluar_MouseLeave(sender As Object, e As EventArgs) Handles LbKeluar.MouseLeave
        Me.Cursor = Cursors.Default
        LbKeluar.BackColor = Color.White
        LbKeluar.ForeColor = Color.MidnightBlue

    End Sub
    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles LbKeluar.Click
        Me.Close()

    End Sub

    Private Sub Txnamabrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxNamaBrg.KeyPress
        If Char.IsLower(e.KeyChar) Then

            TxNamaBrg.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If

        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxSatuan.Focus()
        End If

    End Sub
    Private Sub Txsatuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxSatuan.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxHargajual.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxSatuan.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub TxHargajual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxHargajual.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If Not IsNumeric(TxHargajual.Text) Or TxHargajual.Text = "" Then
                MsgBox("Harga jual harus berupa angka", , "Perhatian")
                Exit Sub
            End If
            Dim val As Double
            val = TxHargajual.Text
            TxHargajual.Text = FormatNumber(val, 0, , , TriState.True)
            TxHargaBeli.Focus()
        End If
    End Sub
    Private Sub TxHargabeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxHargaBeli.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If Not IsNumeric(TxHargaBeli.Text) Or TxHargaBeli.Text = "" Then
                MsgBox("Harga beli harus berupa angka", , "Perhatian")
                Exit Sub
            End If
            Dim val As Double
            val = TxHargaBeli.Text
            TxHargaBeli.Text = FormatNumber(val, 0, , , TriState.True)
            TxStok.Focus()
        End If
    End Sub
    Private Sub TxStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxStok.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If Not IsNumeric(TxStok.Text) Or TxStok.Text = "" Then
                MsgBox("Stok harus berupa angka", , "Perhatian")
                Exit Sub
            End If
            Dim val As Double
            val = TxStok.Text
            TxStok.Text = FormatNumber(val, 0, , , TriState.True)
            LbSimpan.Focus()
        End If
    End Sub


    Private Sub Koreksi()
        Dim sql As String
        Dim result As Single
        Dim valjual As Single
        Dim valbeli As Single
        Dim valstok As Single

        valjual = TxHargajual.Text
        valbeli = TxHargaBeli.Text
        valstok = TxStok.Text

        sql = " Update barang set namabrg='" & TxNamaBrg.Text & "', satuan='" & TxSatuan.Text & "',hargajual=" & valjual.ToString("##0") & ",hargabeli=" & valbeli.ToString("##0") & ",stok=" & valstok.ToString("##0") & " where kodebrg='" & TxKodeBrg.Text & "'  "
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery

                End Using
            End Using
        Catch ex As Exception

        End Try
        MsgBox("Barang dengan Kode :  '" & TxKodeBrg.Text & "' Berhasil di update", MsgBoxStyle.OkOnly, "Informasi")
        Bersih()
        AutoNumber()
        Isitabel()
        TxNamaBrg.Focus()

    End Sub

    Private Sub Bersih()
        TxNamaBrg.Text = ""
        TxSatuan.Text = ""
        TxHargaBeli.Text = ""
        TxHargajual.Text = ""
        TxStok.Text = ""

    End Sub
    Private Sub Gelap()
        TxNamaBrg.Enabled = False
        TxSatuan.Enabled = False
        TxHargaBeli.Enabled = False
        TxHargajual.Enabled = False
        TxHargajual.Enabled = False
        TxStok.Enabled = False
    End Sub
    Private Sub Isitabel()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("select kodebrg,namabrg,satuan,hargajual,hargabeli,stok from barang", conn)
            cmdb = New Odbc.OdbcCommandBuilder(adp)
            tbl = New DataTable
            adp.Fill(tbl)
            Me.BS.DataSource = tbl
            DGView.DataSource = Me.BS
            Me.DGView.Refresh()
            With DGView
                .RowHeadersVisible = False
                .Columns(0).HeaderText = "KODE"
                .Columns(0).Width = 70
                .Columns(1).HeaderText = "NAMA BARANG"
                .Columns(1).Width = 150
                .Columns(2).HeaderText = "SATUAN"
                .Columns(2).Width = 60
                .Columns(3).HeaderText = "HARGA JUAL"
                .Columns(3).Width = 100
                .Columns(3).DefaultCellStyle.Format = "N0"
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).HeaderText = "HARGA BELI "
                .Columns(4).Width = 100
                .Columns(4).DefaultCellStyle.Format = "N0"
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).HeaderText = "STOK"
                .Columns(5).Width = 60
                .Columns(5).DefaultCellStyle.Format = "N0"
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tambah()
        Dim valjual As Single
        Dim valbeli As Single
        Dim valstok As Single
        valjual = TxHargajual.Text
        valbeli = TxHargaBeli.Text
        valstok = TxStok.Text

        sql = "insert into barang (kodebrg,namabrg,satuan,hargajual,hargabeli,stok) values ('" & TxKodeBrg.Text & "','" & TxNamaBrg.Text & "','" & TxSatuan.Text & "'," & valjual.ToString("##0") & "," & valbeli.ToString("##0") & "," & valstok.ToString("##0") & ") "

        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery()

                End Using

            End Using


        Catch ex As Exception


        End Try
        MsgBox("Barang dengan Kode :  '" & TxKodeBrg.Text & "' Berhasil di tambah", MsgBoxStyle.OkOnly, "Informasi")

        Isitabel()
        Bersih()
        AutoNumber()
        TxNamaBrg.Focus()
    End Sub

    Private Sub LbSimpan_Click(sender As Object, e As EventArgs) Handles LbSimpan.Click
        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd = New OdbcCommand("select count(*) from barang where kodebrg = '" & TxKodeBrg.Text & "'", conn)
        Try
            result = cmd.ExecuteScalar
            If (result > 0) Then
                Koreksi()

            Else
                Tambah()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Setbinding()
        TxKodeBrg.DataBindings.Add("text", Me.BS, "kodebrg")
        TxNamaBrg.DataBindings.Add("text", Me.BS, "namabrg")
        TxSatuan.DataBindings.Add("text", Me.BS, "satuan")
        TxHargajual.DataBindings.Add("text", Me.BS, "hargajual")
        TxHargaBeli.DataBindings.Add("text", Me.BS, "hargabeli")
        TxStok.DataBindings.Add("text", Me.BS, "stok")

        TxKodeBrg.DataBindings.Clear()
        TxNamaBrg.DataBindings.Clear()
        TxSatuan.DataBindings.Clear()
        TxHargajual.DataBindings.Clear()
        TxHargaBeli.DataBindings.Clear()
        TxStok.DataBindings.Clear()

        FormatAngka()

    End Sub
    Private Sub FormatAngka()
        Dim valHargajual As Single
        Dim valHargabeli As Single
        Dim valStok As Single

        If TxHargajual.Text = "" Then TxHargajual.Text = 0
        If TxHargaBeli.Text = "" Then TxHargaBeli.Text = 0
        If TxStok.Text = "" Then TxStok.Text = 0

        valHargajual = TxHargajual.Text
        valHargabeli = TxHargaBeli.Text
        valStok = TxStok.Text

        TxHargajual.Text = FormatNumber(valHargajual, 0, , , TriState.True)
        TxHargaBeli.Text = FormatNumber(valHargabeli, 0, , , TriState.True)
        TxStok.Text = FormatNumber(valStok, 0, , , TriState.True)
    End Sub

    Private Sub DGView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellDoubleClick
        Setbinding()

    End Sub

    Private Sub LbTambah_Click(sender As Object, e As EventArgs) Handles LbTambah.Click
        Bersih()
        AutoNumber()
        TxNamaBrg.Focus()

    End Sub
    Private Sub Terang()
        TxNamaBrg.Enabled = True
        TxSatuan.Enabled = True
        TxHargajual.Enabled = True
        TxHargaBeli.Enabled = True
        TxStok.Enabled = True

    End Sub

    Private Sub txtKunci_TextChanged(sender As Object, e As EventArgs) Handles TxtKunci.TextChanged
        Dim strReplace As String =
                    Me.TxtKunci.Text.Replace("'", "''")
        If CbCari.Text = "Nama Barang" Then
            Dim str As String = "namabrg" &
            " LIKE '%" & strReplace & "%'"
            Try
                Me.BS.Filter = str
                Me.DGView.DataSource = Me.BS
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf CbCari.Text = "Kode Barang" Then
            Dim str As String = "kodebrg" &
            " LIKE '%" & strReplace & "%'"
            Try
                Me.BS.Filter = str
                Me.DGView.DataSource = Me.BS
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub LbHapus_Click(sender As Object, e As EventArgs) Handles LbHapus.Click
        Dim result = MessageBox.Show("Barang dengan kode '" & TxKodeBrg.Text & "' akan dihapus", "Mohon Konfirmasinya", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            MsgBox("Barang dengan Kode :  '" & TxKodeBrg.Text & "' Batal dihapus", MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub

        Else
            Hapus()
        End If
    End Sub
    Private Sub Hapus()
        sql1 = "delete from barang where kodebrg='" & TxKodeBrg.Text & "'"
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()

                Using cmd1 As New OdbcCommand(sql1, conn)
                    result1 = cmd1.ExecuteNonQuery()

                End Using
            End Using
            Isitabel()
            Bersih()
            AutoNumber()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class