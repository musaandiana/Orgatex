Imports System.ComponentModel

Public Class FormBatchList
    Private Sub FormBatchList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenuAwal.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        FormBatchScheduler.txt_id.Text = ""
        FormBatchScheduler.Show()
    End Sub

    Private Sub FormBatchList_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadawal()
    End Sub

    Sub loadawal()
        koneksi()
        query = "SELECT * from tbl_batchschedule order by ID desc"
        retrieve(query, dgbuyer)
    End Sub
End Class