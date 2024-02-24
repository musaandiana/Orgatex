Imports System.ComponentModel
Imports System.Data.OleDb
Imports SingleStoreConnector

Public Class FormAddRecipe
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        koneksi()
        Saveprocess()
    End Sub

    Sub Saveprocess()
        Dim cmdi As OleDbCommand
        Dim simpan As String = "INSERT INTO tbl_kodekain (txt_kodekain, gsm) VALUES (@txt_kodekain, @gsm)"

        Try
            cmdi = New OleDbCommand(simpan, conn)
            cmdi.Parameters.AddWithValue("@txt_kodekain", "123")
            cmdi.Parameters.AddWithValue("@gsm", "====")

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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        With FormTableBuyer
            .StartPosition = FormStartPosition.Manual
            .TopMost = False
            .Owner = Me
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .Location = MousePosition
            .Text = String.Empty
            .Show()
        End With
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        With FormTableKodekain
            .StartPosition = FormStartPosition.Manual
            .TopMost = False
            .Owner = Me
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .Location = MousePosition
            .Text = String.Empty
            .Show()
        End With
    End Sub

    Private Sub FormAddRecipe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenuAwal.Show()
    End Sub
End Class