Imports System.Data.OleDb

Public Class FormTableBuyer
    Private Sub FormTableBuyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        query = "SELECT txt_buyer FROM tbl_buyer order by ID asc"
        retrieve(query, dgbuyer)
    End Sub

    Private Sub dgbuyer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbuyer.CellContentClick

    End Sub

    Private Sub dgbuyer_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbuyer.RowHeaderMouseClick
        Dim dr As DataGridViewRow = dgbuyer.SelectedRows(0)
        If dr.Cells(0).Value.ToString() = "" Then
            Exit Sub
        End If

        FormAddRecipe.txt_buyer.Text = dr.Cells(0).Value.ToString()
        Me.Close()

    End Sub
End Class