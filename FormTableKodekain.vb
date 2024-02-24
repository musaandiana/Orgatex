Public Class FormTableKodekain
    Private Sub FormTableKodekain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        query = "SELECT txt_kodekain,gsm FROM tbl_kodekain order by ID asc"
        retrieve(query, dgkodekain)
    End Sub

    Private Sub dgkodekain_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgkodekain.RowHeaderMouseClick
        Dim dr As DataGridViewRow = dgkodekain.SelectedRows(0)
        If dr.Cells(0).Value.ToString() = "" Then
            Exit Sub
        End If

        FormAddRecipe.txt_kodekain.Text = dr.Cells(0).Value.ToString()
        Me.Close()
    End Sub
End Class