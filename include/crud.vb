Imports SingleStoreConnector
Module crud
    Public Sub cudfunction(ByVal query As String)
        con.Open()
        Try
            With cmd
                .Connection = con
                .CommandText = query
            End With
            result = cmd.ExecuteNonQuery()

            If result = True Then
                MsgBox(msgtrue)
            Else
                MsgBox(msgfalse, MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            logs(ex.Message & " at cudfunction sub Procedure")
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub retrieveSingleResult(ByVal query As String)

        Try
            con.Open()
            cmd = New SingleStoreCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New SingleStoreDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            'da.Fill(ds, "tblProductInfo")

        Catch ex As Exception
            logs(ex.Message & " at retrieveSingleResult sub Procedure")
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Public Sub retrieve(ByVal query As String, ByVal dtg As DataGridView)

        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New SingleStoreCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New SingleStoreDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)
            dtg.DataSource = dt

        Catch ex As Exception
            logs(ex.Message & " at retrieve sub Procedure")
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub cudfunctionNOmsg(ByVal query As String)
        con.Open()
        Try
            With cmd
                .Connection = con
                .CommandText = query
            End With
            result = cmd.ExecuteNonQuery()

        Catch ex As Exception
            logs(ex.Message & " at cudfunction sub Procedure")
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    'Public Sub gambarloading()

    '    With Image
    '        .background
    '    End With

    'End Sub
End Module
