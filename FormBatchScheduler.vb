Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FormBatchScheduler

    Public txt_gsm As String = 123
    Public txt_lebar As String = 60
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        FormRecipeSelector.Show()
    End Sub

    Private Sub FormBatchScheduler_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormBatchList.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        koneksi()
        Saveprocess()
        FormBatchList.loadawal()
    End Sub

    Sub Saveprocess()
        Dim cmdi As OleDbCommand
        Dim simpan As String = "INSERT INTO tbl_batchschedule (name, batch1, batch2, customer, kodekain, ockh, yard, yard11, yard12, kg, kg11, kg12, comment, recipeid, recipe, gsm, lebar, dyeqty, chemqty, BulanTahun) VALUES (@name, @batch1, @batch2, @customer, @kodekain, @ockh, @yard, @yard11, @yard12, @kg, @kg11, @kg12, @comment, @recipeid, @recipe, @gsm, @lebar, @dyeqty, @chemqty, @BulanTahun)"

        Try
            cmdi = New OleDbCommand(simpan, conn)
            cmdi.Parameters.AddWithValue("@name", txt_name.Text)
            cmdi.Parameters.AddWithValue("@batch1", txt_batch1.Text)
            cmdi.Parameters.AddWithValue("@batch2", txt_batch2.Text)
            cmdi.Parameters.AddWithValue("@customer", txt_customer.Text)
            cmdi.Parameters.AddWithValue("@kodekain", txt_kk.Text)
            cmdi.Parameters.AddWithValue("@@ockh", txt_ockh.Text)
            cmdi.Parameters.AddWithValue("@yard", txt_y.Text)
            cmdi.Parameters.AddWithValue("@yard11", txt_y11.Text)
            cmdi.Parameters.AddWithValue("@yard12", txt_y12.Text)
            cmdi.Parameters.AddWithValue("@kg", txt_kg.Text)
            cmdi.Parameters.AddWithValue("@kg11", txt_kg11.Text)
            cmdi.Parameters.AddWithValue("@kg12", txt_kg12.Text)
            cmdi.Parameters.AddWithValue("@comment", txt_comment.Text)
            cmdi.Parameters.AddWithValue("@recipeid", txt_recipeID.Text)
            cmdi.Parameters.AddWithValue("@recipe", txt_recipe.Text)
            cmdi.Parameters.AddWithValue("@gsm", txt_gsm)
            cmdi.Parameters.AddWithValue("@lebar", txt_lebar)
            cmdi.Parameters.AddWithValue("@dyeqty", CDbl(txt_kg.Text) * 0.8)
            cmdi.Parameters.AddWithValue("@chemqty", CDbl(txt_kg.Text) * 0.2)
            cmdi.Parameters.AddWithValue("@BulanTahun", Today())

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmdi.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class