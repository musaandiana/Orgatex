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
    End Sub

End Class
