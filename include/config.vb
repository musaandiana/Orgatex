Imports System.Data.OleDb

Module config
    Public databasename As String = "\DBCelup.mdb"
    Private Function configdb() As OleDbConnection
        Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & databasename & ";Persist Security Info=False;"
        Return New OleDbConnection(connString)
    End Function
    Public con As OleDbConnection = configdb()
End Module

