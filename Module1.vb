Imports System.Data.OleDb

Module Module1

    Public str As String
    Public conn As OleDbConnection
    Public cmdi As OleDbCommand
    Public dr As OleDbDataReader

    Sub koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:/DBCelup.mdb;Persist Security Info=False;"
        conn = New OleDbConnection(str)
        Try
            conn.Open()
            If conn.State = ConnectionState.Open Then

            Else
                MsgBox("Gagal terhubung ke database, cek modul 1")
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

End Module
