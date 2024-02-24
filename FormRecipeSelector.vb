Public Class FormRecipeSelector
    Private Sub FormRecipeSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        query = "SELECT * FROM tbl_kodekain order by txt_kodekain asc"
        retrieve(query, dgrecipe)
    End Sub
End Class