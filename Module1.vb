Imports System.Data.Odbc
Module Module1
    Public connstr As String = "DSN=warung"
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public cmd1 As OdbcCommand
    Public cmd2 As OdbcCommand
    Public cmd3 As OdbcCommand
    Public cmd4 As OdbcCommand
    Public cmd5 As OdbcCommand
    Public cmd6 As OdbcCommand
    Public result As Single
    Public result1 As Single
    Public sql As String
    Public sql1 As String
    Public Sub konek_DB()
        conn = New OdbcConnection(connstr)
    End Sub

End Module
