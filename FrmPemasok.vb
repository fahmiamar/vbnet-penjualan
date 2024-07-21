Imports System.Data.Odbc
Public Class FrmPemasok
    Dim adp As Odbc.OdbcDataAdapter
    Dim cmdb As Odbc.OdbcCommandBuilder
    Dim tbl As DataTable
    Private Sub AutoNumber()
        Dim last As Integer
        Dim banyak As Single

        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd1 = New OdbcCommand("select max(MID(kodepmk,2,4)) from pemasok", conn)
        cmd = New OdbcCommand("select count(*) from pemasok", conn)
        Try
            banyak = cmd.ExecuteScalar
            If banyak < 1 Then
                TxKodepmk.Text = "S0001"
            Else
                last = cmd1.ExecuteScalar
                TxKodepmk.Text = "S" & Format(last + 1, "0000")
            End If
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)
        End Try

    End Sub

    Private Sub JenisCari()
        CbCari.Items.Clear()
        CbCari.Items.Add("Nama pemasok")
        CbCari.Items.Add("Kode pemasok")
    End Sub

    Private Sub Frmpemasok_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutoNumber()
        JenisCari()
        Isitabel()
        TxKodepmk.Enabled = False
        CbCari.Text = "Nama pemasok"
        LbTambah.BackColor = Color.White
        LbTambah.ForeColor = Color.MidnightBlue
        LbSimpan.BackColor = Color.White
        LbSimpan.ForeColor = Color.MidnightBlue
        LbHapus.BackColor = Color.White
        LbHapus.ForeColor = Color.MidnightBlue
        LbKeluar.BackColor = Color.White
        LbKeluar.ForeColor = Color.MidnightBlue
        TxNamaPmk.Focus()
    End Sub

    Private Sub Isitabel()
        Try
            conn = New Odbc.OdbcConnection(connstr)
            conn.Open()
            adp = New Odbc.OdbcDataAdapter("select kodepmk,namapmk,telppmk,alamatpmk from pemasok", conn)
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
                .Columns(1).HeaderText = "NAMA PEMASOK"
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

    Private Sub Txnamapmk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxNamaPmk.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxTelppmk.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxNamaPmk.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub Txtelppmk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxTelppmk.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            TxAlamatpmk.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxTelppmk.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub Txalamatpmk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxAlamatpmk.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            LbSimpan.Focus()
        End If
        If Char.IsLower(e.KeyChar) Then
            'Convert to uppercase, and put at the caret position in the TextBox.
            TxAlamatpmk.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub
    Private Sub Bersih()
        TxNamaPmk.Text = ""
        TxTelppmk.Text = ""
        TxAlamatpmk.Text = ""
    End Sub

    Private Sub LbTambah_Click(sender As Object, e As EventArgs) Handles LbTambah.Click
        Bersih()
        AutoNumber()
        TxNamaPmk.Focus()
    End Sub
    Private Sub Koreksi()
        Dim sql As String
        Dim result As Single


        sql = " Update pemasok set namapmk='" & TxNamaPmk.Text & "', telppmk='" & TxTelppmk.Text & "',alamatpmk='" & TxAlamatpmk.Text & "'  where kodebrpmk='" & TxKodepmk.Text & "'  "
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
        TxNamaPmk.Focus()

    End Sub
    Private Sub Tambah()


        sql = "insert into pemasok (kodepmk,namapmk,telppmk,alamatpmk) values ('" & TxKodepmk.Text & "','" & TxNamaPmk.Text & "','" & TxTelppmk.Text & "','" & TxAlamatpmk.Text & "') "

        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()
                Using cmd As New OdbcCommand(sql, conn)
                    result = cmd.ExecuteNonQuery()

                End Using

            End Using


        Catch ex As Exception


        End Try
        MsgBox("pemasok dengan Kode :  '" & TxKodepmk.Text & "' Berhasil di tambah", MsgBoxStyle.OkOnly, "Informasi")

        Isitabel()
        Bersih()
        AutoNumber()
        TxNamaPmk.Focus()
    End Sub
    Private Sub LbSimpan_Click(sender As Object, e As EventArgs) Handles LbSimpan.Click
        conn = New OdbcConnection(connstr)
        conn.Open()
        cmd = New OdbcCommand("select count(*) from pemasok where kodepmk = '" & TxKodepmk.Text & "'", conn)
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
        TxKodepmk.DataBindings.Add("text", Me.BS, "kodepmk")
        TxNamaPmk.DataBindings.Add("text", Me.BS, "namapmk")
        TxTelppmk.DataBindings.Add("text", Me.BS, "telppmk")
        TxAlamatpmk.DataBindings.Add("text", Me.BS, "alamatpmk")

        TxKodepmk.DataBindings.Clear()
        TxNamaPmk.DataBindings.Clear()
        TxTelppmk.DataBindings.Clear()
        TxAlamatpmk.DataBindings.Clear()

    End Sub
    Private Sub DGView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView.CellDoubleClick
        Setbinding()
    End Sub

    Private Sub LbHapus_Click(sender As Object, e As EventArgs) Handles LbHapus.Click
        Dim result = MessageBox.Show("pemasok dengan kode '" & TxKodepmk.Text & "' akan dihapus", "Mohon Konfirmasinya", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then
            MsgBox("pemasok dengan Kode :  '" & TxKodepmk.Text & "' Batal dihapus", MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub

        Else
            Hapus()
        End If
    End Sub
    Private Sub Hapus()
        sql1 = "delete from pemasok where kodepmk='" & TxKodepmk.Text & "'"
        Try
            Using conn As New OdbcConnection(connstr)
                conn.Open()

                Using cmd1 As New OdbcCommand(sql1, conn)
                    result1 = cmd1.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("pemasok dengan Kode :  '" & TxKodepmk.Text & "' Berhasil dihapus", MsgBoxStyle.OkOnly, "Informasi")

            Isitabel()
            Bersih()
            AutoNumber()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtKunci_TextChanged(sender As Object, e As EventArgs) Handles TxtKunci.TextChanged

    End Sub
End Class