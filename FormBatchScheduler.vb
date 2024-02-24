Imports System.ComponentModel

Public Class FormBatchScheduler
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        FormRecipeSelector.Show()
    End Sub

    Private Sub FormBatchScheduler_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormBatchList.Show()
    End Sub
End Class