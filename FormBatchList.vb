Imports System.ComponentModel

Public Class FormBatchList
    Private Sub FormBatchList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenuAwal.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        FormBatchScheduler.Show()
    End Sub
End Class