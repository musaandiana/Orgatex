Public Class FormRecipeSelector
    Private Sub FormRecipeSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        query = "SELECT * FROM tbl_kodekain order by regex asc"
        retrieve(query, dgbuyer)
    End Sub
End Class