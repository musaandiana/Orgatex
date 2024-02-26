Imports System.ComponentModel
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office

Public Class FormBatchList
    Public idserc As String
    Private Sub FormBatchList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenuAwal.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        FormBatchScheduler.txt_id.Text = ""
        FormBatchScheduler.Show()
    End Sub

    Private Sub FormBatchList_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadawal()
    End Sub

    Sub loadawal()
        koneksi()
        query = "SELECT * from tbl_batchschedule order by ID desc"
        retrieve(query, dgbatch)
    End Sub

    Private Sub dgbatch_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbatch.CellClick

        On Error Resume Next

        Dim i As Integer
        i = dgbatch.CurrentRow.Index
        idserc = dgbatch.Item(0, i).Value

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        FormBatchScheduler.txt_id.Text = idserc

        Dim cmd As OleDbCommand
        Dim RD As OleDbDataReader
        Dim query As String
        query = "Select * from tbl_batchschedule where ID =" & idserc
        cmd = New OleDbCommand(query, conn)
        Debug.Print(query)
        RD = cmd.ExecuteReader
        RD.Read()

        If Not RD.HasRows Then
            MsgBox("Data not found")
        Else
            On Error Resume Next
            FormBatchScheduler.txt_name.Text = RD.Item("name")
            FormBatchScheduler.txt_batch1.Text = RD.Item("batch1")
            FormBatchScheduler.txt_batch2.Text = RD.Item("batch2")
            FormBatchScheduler.txt_customer.Text = RD.Item("customer")
            FormBatchScheduler.txt_kk.Text = RD.Item("kodekain")
            FormBatchScheduler.txt_ockh.Text = RD.Item("ockh")
            FormBatchScheduler.txt_y.Text = RD.Item("yard")
            FormBatchScheduler.txt_y11.Text = RD.Item("yard11")
            FormBatchScheduler.txt_y12.Text = RD.Item("yard12")
        End If


        FormBatchScheduler.Show()
    End Sub
End Class