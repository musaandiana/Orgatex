Imports System.IO
Imports System.Data.OleDb

Module publicfunction
    Public Sub clear(ByVal container As Object)
        Try
            For Each txt As Control In container.Controls
                If TypeOf txt Is TextBox Or TypeOf txt Is RichTextBox Or TypeOf txt Is ComboBox Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception
            logs(ex.Message & " at clear sub Procedure")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cleargb(ByVal container As Object)
        Try
            For Each groupbox As Control In container.controls
                If TypeOf groupbox Is GroupBox Then
                    For Each txt As Control In groupbox.Controls
                        If TypeOf txt Is TextBox Or TypeOf txt Is RichTextBox Then
                            txt.Text = ""
                        End If

                    Next
                End If
            Next
        Catch ex As Exception
            logs(ex.Message & " at clear sub Procedure")
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub logs(ByVal errormsg As Object)
        Try
            Dim path_file As String = String.Format(Application.StartupPath & "\errorlogs\Logs.log", DateTime.Today.ToString("dd-MMM-yyyy"))
            Dim exist_file As Boolean = File.Exists(path_file)
            Using stream_writer As New StreamWriter(path_file, True)
                If Not exist_file Then
                    stream_writer.WriteLine("Log starts")
                End If
                stream_writer.WriteLine("The Error Occured at " & DateTime.Now & " :: " & errormsg)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "at logs sub")
        End Try
    End Sub

    Public Sub CBOFILL(ByVal query As String, ByVal combo As ComboBox, ByVal member As String, ByVal id As String)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    Using da As New OleDbDataAdapter(cmd)
                        Dim ds As New DataSet()
                        da.Fill(ds)
                        With combo
                            .DataSource = ds.Tables(0)
                            .DisplayMember = member
                            .ValueMember = id
                        End With
                    End Using
                End Using
            Catch ex As Exception
                logs(ex.Message & " at CBOFILL sub Procedure")
                MsgBox(ex.Message & " at CBOFILL sub Procedure")
            End Try
        End Using
    End Sub

    Public Sub txtAutoComplete(ByVal query As String, ByVal txt As Object)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(query, con)
                    Using da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        txt.AutoCompleteMode = AutoCompleteMode.Suggest
                        txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                        txt.AutoCompleteCustomSource.clear()
                        For Each row As DataRow In dt.Rows
                            txt.AutoCompleteCustomSource.Add(row.Item(0).ToString())
                        Next
                    End Using
                End Using
            Catch ex As Exception
                logs(ex.Message & " at txtAutoComplete sub Procedure")
                MsgBox(ex.Message & " at txtAutoComplete sub Procedure")
            End Try
        End Using
    End Sub

    Public Sub checkData(ByVal Checkquery As String, ByVal insertQuery As String, ByVal updateQuery As String)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand(Checkquery, con)
                    Using da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            cudfunctionNOmsg(updateQuery)
                        Else
                            cudfunctionNOmsg(insertQuery)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                logs(ex.Message & " at checkData sub Procedure")
                MsgBox(ex.Message & " at checkData sub Procedure")
            End Try
        End Using
    End Sub

    Public Sub txtAutoNumber(ByVal autoid As Integer, ByVal txt As Object)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand("SELECT (STARTNUM & INCNUM) FROM tblAutoNumber WHERE ID=" & autoid, con)
                    Using da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txt.text = dt.Rows(0).Item(0)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                logs(ex.Message & " at txtAutoNumber sub Procedure")
                MsgBox(ex.Message & " at txtAutoNumber sub Procedure")
            End Try
        End Using
    End Sub

    Public Sub updateAutoNumber(ByVal autoid As Integer)
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBCelup.mdb;Persist Security Info=False;")
            Try
                con.Open()
                Using cmd As New OleDbCommand("UPDATE tblAutoNumber SET INCNUM=INCNUM + 1 WHERE ID=" & autoid, con)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                logs(ex.Message & " at txtAutoNumber sub Procedure")
                MsgBox(ex.Message & " at txtAutoNumber sub Procedure")
            End Try
        End Using
    End Sub

    Public Sub frmMaxMinSize(ByVal frm As Form, ByVal w As Integer, ByVal h As Integer)
        frm.MaximumSize = New Size(w, h)
        frm.MinimumSize = New Size(w, h)
    End Sub

    Public Sub ShowForm(ByVal mainForm As Form, ByVal OpenForm As Form)
        Try
            OpenForm.Show()
            OpenForm.Focus()
        Catch ex As Exception

        End Try
    End Sub

#Region "EDIT TRANSACTIONS"
    Public Sub TRANSACTIONPROCESS(ByVal ACTIONTABLE As String, ByVal TBL As String, ByVal TRANSNUM As Integer, ByVal QTY As Double)
        Try
            Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBCelup.mdb;Persist Security Info=False;")
                con.Open()
                Select Case ACTIONTABLE
                    Case "ADD_QTY_PRODUCT"
                        updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY + " & QTY & " WHERE P.PROCODE = S.PROCODE AND TRANSNUM =" & TRANSNUM
                        cudfunctionNOmsg(updateQuery)

                    Case "DEDUCT_QTY_PRODUCT"
                        updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY- " & QTY & " WHERE P.PROCODE = S.PROCODE AND TRANSNUM =" & TRANSNUM
                        cudfunctionNOmsg(updateQuery)

                    Case "DEDUCT_QTY_STOCKOUT"
                        updateQuery = "UPDATE  " & TBL & "  SET OUTQTY = OUTQTY - " & QTY & " WHERE  TRANSNUM =" & TRANSNUM
                        cudfunctionNOmsg(updateQuery)

                    Case "ADD_QTY_STOCKOUT"
                        updateQuery = "UPDATE  " & TBL & "  SET OUTQTY = OUTQTY + " & QTY & " WHERE  TRANSNUM =" & TRANSNUM
                        cudfunctionNOmsg(updateQuery)

                    Case "ADD_QTY_RETURN"
                        updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY + " & QTY & " WHERE P.PROCODE = S.PROCODE AND RETURNEDPROID =" & TRANSNUM
                        cudfunctionNOmsg(updateQuery)

                    Case "DEDUCT_QTY_RETURN"
                        updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY - " & QTY & " WHERE P.PROCODE = S.PROCODE AND RETURNEDPROID =" & TRANSNUM
                        cudfunctionNOmsg(updateQuery)

                End Select
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Module
