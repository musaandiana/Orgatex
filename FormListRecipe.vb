Public Class FormListRecipe
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With FormAddRecipe
            .StartPosition = FormStartPosition.Manual
            .TopMost = False
            .Owner = Me
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .Location = MousePosition
            .Text = String.Empty
            .Show()
        End With
    End Sub
End Class