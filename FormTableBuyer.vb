Imports System.Data.OleDb

Public Class FormTableBuyer
    Private Sub FormTableBuyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        query = "SELECT * FROM tbl_kodekain order by regex asc"
        retrieve(query, dgbuyer)
    End Sub

End Class