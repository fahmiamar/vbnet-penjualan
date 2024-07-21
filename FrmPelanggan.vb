Imports System.Data.Odbc
Public Class FrmPelanggan
    Dim adp As Odbc.OdbcDataAdapter
    Dim cmdb As Odbc.OdbcCommandBuilder
    Dim tbl As DataTable
    Private Sub AutoNumber()
        Dim last As Integer
        Dim banyak As Single

        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd1 = New OdbcCommand("select max(MID(kodeplg,2,4)) from pelanggan", conn)
        cmd = New OdbcCommand("select count(*) from pelanggan", conn)
        Try
            banyak = cmd.ExecuteScalar
            If banyak < 1 Then
                TxKodeplg.Text = "C0001"
            Else
                last = cmd1.ExecuteScalar
                TxKodeplg.Text = "C" & Format(last + 1, "0000")
            End If
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try

    End Sub

    Private Sub JenisCari()
        CbCari.Items.Clear()
        CbCari.Items.Add("Nama Pelanggan")
        CbCari.Items.Add("Kode Pelanggan")
    End Sub

    Private Sub FrmPelanggan_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutoNumber()
        JenisCari()
        Isitabel()
        TxKodeplg.Enabled = False
        CbCari.Text = "Nama Pelanggan"
        LbTambah.BackColor = Color.White
        LbTambah.ForeColor = Color.MidnightBlue
        LbSimpan.BackColor = Color.White
        LbSimpan.ForeColor = Color.MidnightBlue
        LbHapus.BackColor = Color.White
        LbHapus.ForeColor = Color.MidnightBlue
        LbKeluar.BackColor = Color.White
        LbKeluar.ForeColor = Color.MidnightBlue
        TxNamaPlg.Focus()
    End Sub

    Private Sub Isitabel()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("select kodeplg,namaplg,telpplg,alamatplg from pelanggan", conn)
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
                .Columns(1).HeaderText = "NAMA PELANGGAN"
                .Columns(1).Width = 150
                .Columns(2).HeaderText = "TELPON"
                .Columns(2).Width = 80
                .Columns(3).HeaderText = "ALAMAT"
                .Columns(3).Width = 250

                .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige

            End With
        Catch ex As Exception

        End Try
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

    Private Sub Txnamaplg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxNamaPlg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxTelpplg.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxNamaPlg.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub Txtelpplg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTelpplg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxAlamatplg.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxTelpplg.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub Txalamatplg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxAlamatplg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            LbSimpan.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxAlamatplg.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub
    Private Sub Bersih()
        TxNamaPlg.Text = ""
        TxTelpplg.Text = ""
        TxAlamatplg.Text = ""
    End Sub

    Private Sub LbTambah_Click(sender As Object, e As EventArgs) Handles LbTambah.Click
        Bersih()
        AutoNumber()
        TxNamaPlg.Focus()
    End Sub
    Private Sub Koreksi()
        Dim sql As String
        Dim result As Single


        sql = " Update pelanggan set namaplg='" & TxNamaPlg.Text & "', telpplg='" & TxTelpplg.Text & "',alamatplg='" & TxAlamatplg.Text & "'  where kodebrplg='" & TxKodeplg.Text & "'  "
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery

                End Using
            End Using
        Catch ex As Exception

        End Try

        Bersih()
        AutoNumber()
        Isitabel()
        TxNamaPlg.Focus()

    End Sub
    Private Sub Tambah()


        sql = "insert into pelanggan (kodeplg,namaplg,telpplg,alamatplg) values ('" & TxKodeplg.Text & "','" & TxNamaPlg.Text & "','" & TxTelpplg.Text & "','" & TxAlamatplg.Text & "') "

        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery()

                End Using

            End Using


        Catch ex As Exception


        End Try
        MsgBox("Pelanggan dengan Kode :  '" & TxKodeplg.Text & "' Berhasil di tambah", MsgBoxStyle.OkOnly, "Informasi")

        Isitabel()
        Bersih()
        AutoNumber()
        TxNamaPlg.Focus()
    End Sub
    Private Sub LbSimpan_Click(sender As Object, e As EventArgs) Handles LbSimpan.Click
        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd = New OdbcCommand("select count(*) from pelanggan where kodeplg = '" & TxKodeplg.Text & "'", conn)
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
        TxKodeplg.DataBindings.Add("text", Me.BS, "kodeplg")
        TxNamaPlg.DataBindings.Add("text", Me.BS, "namaplg")
        TxTelpplg.DataBindings.Add("text", Me.BS, "telpplg")
        TxAlamatplg.DataBindings.Add("text", Me.BS, "alamatplg")

        TxKodeplg.DataBindings.Clear()
        TxNamaPlg.DataBindings.Clear()
        TxTelpplg.DataBindings.Clear()
        TxAlamatplg.DataBindings.Clear()

    End Sub
    Private Sub DGView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellDoubleClick
        Setbinding()
    End Sub

    Private Sub LbHapus_Click(sender As Object, e As EventArgs) Handles LbHapus.Click
        Dim result = MessageBox.Show("Pelanggan dengan kode '" & TxKodeplg.Text & "' akan dihapus", "Mohon Konfirmasinya", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            MsgBox("Pelanggan dengan Kode :  '" & TxKodeplg.Text & "' Batal dihapus", MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub

        Else
            Hapus()
        End If
    End Sub
    Private Sub Hapus()
        sql1 = "delete from pelanggan where kodeplg='" & TxKodeplg.Text & "'"
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()

                Using cmd1 As New OdbcCommand(sql1, conn)
                    result1 = cmd1.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("Pelanggan dengan Kode :  '" & TxKodeplg.Text & "' Berhasil dihapus", MsgBoxStyle.OkOnly, "Informasi")

            Isitabel()
            Bersih()
            AutoNumber()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class