Imports System.Data.OleDb

Module crud
    Public Sub cudfunction(ByVal query As String)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:/DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MsgBox("Operasi berhasil dilakukan.")
                    Else
                        MsgBox("Operasi gagal.", MsgBoxStyle.Critical)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub retrieveSingleResult(ByVal query As String)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:/DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        ' Lakukan sesuatu dengan hasil pembacaan di sini
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub retrieve(ByVal query As String, ByVal dtg As DataGridView)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:/DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    Using da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dtg.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub cudfunctionNOmsg(ByVal query As String)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:/DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Module
