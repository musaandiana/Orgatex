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

    Private Sub FormListRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        query = "SELECT * FROM tbl_recipe order by ID asc"
        retrieve(query, dglistrecipe)
        dglistrecipe.Columns(0).Visible = False
        dglistrecipe.Columns(1).HeaderText = "Recipe"
        dglistrecipe.Columns(2).HeaderText = "Process"
        dglistrecipe.Columns(3).HeaderText = "Kode Kain"
        dglistrecipe.Columns(4).HeaderText = "Buyer"
    End Sub
End Class