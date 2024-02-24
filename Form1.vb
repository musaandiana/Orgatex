Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports SingleStoreConnector
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub txt_recipe_TextChanged(sender As Object, e As EventArgs) Handles txt_recipe.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_recipe.Click
        With Form2
            .StartPosition = FormStartPosition.Manual
            .TopMost = False
            .Owner = Me
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .Location = MousePosition
            .Text = String.Empty
            .Show()
        End With
    End Sub



    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        koneksi()
        Saveprocess()
    End Sub


    Sub Saveprocess()
        Dim cmdi As SingleStoreCommand
        Dim simpan As String = "INSERT INTO tbl_oragatex
            (txt_recipe,
txt_bacthid,
txt_lotno1,
txt_lotno2,
txt_kodekain,
txt_buyer,
txt_schedule,
txt_ockh1,
txt_ockh2,
txt_qtyyard1,
txt_qtyyard2,
txt_qtykg1,
txt_qtykg2
) 
            VALUES
            (@txt_recipe,
@txt_bacthid,
@txt_lotno1,
@txt_lotno2,
@txt_kodekain,
@txt_buyer,
@txt_schedule,
@txt_ockh1,
@txt_ockh2,
@txt_qtyyard1,
@txt_qtyyard2,
@txt_qtykg1,
@txt_qtykg2
)"
        cmdi = New SingleStoreCommand(simpan, conn)

        cmdi.Parameters.Add("@txt_recipe", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_bacthid", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_lotno1", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_lotno2", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_kodekain", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_buyer", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_schedule", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_ockh1", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_ockh2", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_qtyyard1", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_qtyyard2", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_qtykg1", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_qtykg2", SingleStoreDbType.VarChar)


        cmdi.Connection = conn

        cmdi.Parameters(0).Value = txt_recipe.Text
        cmdi.Parameters(1).Value = txt_bacthid.Text
        cmdi.Parameters(2).Value = txt_lotno1.Text
        cmdi.Parameters(3).Value = txt_lotno2.Text
        cmdi.Parameters(4).Value = txt_kodekain.Text
        cmdi.Parameters(5).Value = txt_buyer.Text
        cmdi.Parameters(6).Value = txt_schedule.Text
        cmdi.Parameters(7).Value = txt_ockh1.Text
        cmdi.Parameters(8).Value = txt_ockh2.Text
        cmdi.Parameters(9).Value = txt_qtyyard1.Text
        cmdi.Parameters(10).Value = txt_qtyyard2.Text
        cmdi.Parameters(11).Value = txt_qtykg1.Text
        cmdi.Parameters(12).Value = txt_qtykg2.Text


        cmdi.ExecuteNonQuery()

    End Sub
End Class
