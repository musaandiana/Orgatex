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
End Class