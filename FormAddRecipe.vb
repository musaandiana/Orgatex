Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports SingleStoreConnector

Public Class FormAddRecipe
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If txt_recipe.Text = "" And cmb_process.Text = "" And txt_kodekain.Text = "" And txt_buyer.Text = "" Then
            MsgBox("Harap Isi Data")
        Else
            koneksi()
            Saveprocess()
            SaveprocessRecipe()
        End If
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

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        With panelkodekain
            .Visible = True ' Mengatur panel menjadi terlihat
            .BringToFront()
            .Text = String.Empty
            .Show()
        End With


    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        panelkodekain.Visible = False
    End Sub



    Private Sub FormAddRecipe_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        query = "SELECT txt_kodekain,gsm,lebar FROM tbl_kodekain order by ID asc"
        retrieve(query, dgkodekain)

        query = "SELECT kodebuyer,txt_buyer FROM tbl_buyer order by ID asc"
        retrieve(query, dgbuyer)


        query = "SELECT * FROM tbl_kumpulanrecipe order by ID asc"
        retrieve(query, dgkumpulanrecipe)

        dgkumpulanrecipe.Columns(0).Visible = False
        'dgkumpulanrecipe.Columns(1).HeaderText = "Recipe"
        'dgkumpulanrecipe.Columns(2).HeaderText = "Process"
        'dgkumpulanrecipe.Columns(3).HeaderText = "Kode Kain"
        'dgkumpulanrecipe.Columns(4).HeaderText = "Buyer"
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim cmdi As OleDbCommand
        Dim simpan As String = "INSERT INTO tbl_kodekain (txt_kodekain, gsm, lebar) VALUES (@txt_kodekain, @gsm, @lebar)"

        Try
            cmdi = New OleDbCommand(simpan, conn)
            cmdi.Parameters.AddWithValue("@txt_kodekain", txt_kodekaininput.Text)
            cmdi.Parameters.AddWithValue("@gsm", txt_gsminput.Text)
            cmdi.Parameters.AddWithValue("@lebar", txt_lebarinput.Text)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmdi.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            koneksi()
            query = "SELECT txt_kodekain,gsm,lebar FROM tbl_kodekain order by ID asc"
            retrieve(query, dgkodekain)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        panelbuyer.Visible = False
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim cmdi As OleDbCommand
        Dim simpan As String = "INSERT INTO tbl_buyer (kodebuyer, txt_buyer) VALUES (@kodebuyer, @txt_buyer)"

        Try
            cmdi = New OleDbCommand(simpan, conn)
            cmdi.Parameters.AddWithValue("@kodebuyer", txt_kodebuyerinput.Text)
            cmdi.Parameters.AddWithValue("@txt_buyer", txt_buyerinput.Text)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmdi.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            koneksi()
            query = "SELECT kodebuyer,txt_buyer FROM tbl_buyer order by ID asc"
            retrieve(query, dgbuyer)
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        With panelbuyer
            .Visible = True ' Mengatur panel menjadi terlihat
            .BringToFront()
            .Text = String.Empty
            .Show()
        End With
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        'panelinsert.Visible = False
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        'Dim row As String() = New String() {txt_kodeobatinsert.Text, txt_namaobatinsert.Text, txt_valueinsert.Text, txt_jenisobatinsert.Text}
        'dginsert.Rows.Add(row)
        'txt_kodeobatinsert.Clear()
        'txt_namaobatinsert.Clear()
        'txt_valueinsert.Clear()
        'txt_jenisobatinsert.Clear()
        'panelinsert.Visible = False
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        With panelinsert
            .Visible = True ' Mengatur panel menjadi terlihat
            .BringToFront()
            .Text = String.Empty
            .Show()
        End With
    End Sub
    Public newID As Integer = 0

    Sub Saveprocess()
        Dim cmdi As OleDbCommand
        Dim simpan As String = "INSERT INTO tbl_recipe (txt_recipe, txt_process, txt_kodekain, txt_buyer) VALUES (@txt_recipe, @txt_process, @txt_kodekain, @txt_buyer)"

        Try
            cmdi = New OleDbCommand(simpan, conn)
            cmdi.Parameters.AddWithValue("@txt_recipe", txt_recipe.Text)
            cmdi.Parameters.AddWithValue("@txt_process", cmb_process.Text)
            cmdi.Parameters.AddWithValue("@txt_kodekain", txt_kodekain.Text)
            cmdi.Parameters.AddWithValue("@txt_buyer", txt_buyer.Text)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmdi.ExecuteNonQuery() ' Jalankan perintah INSERT

            ' Setelah menyisipkan data, ambil nilai ID yang baru saja dimasukkan
            cmdi.CommandText = "SELECT @@IDENTITY"
            newID = Convert.ToInt32(cmdi.ExecuteScalar())

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Sub SaveprocessRecipe()
        Try

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            For Each row As DataGridViewRow In dginsert.Rows
                If Not row.IsNewRow Then
                    Dim simpan As String = "INSERT INTO tbl_recipedatagridview (id_recipe, txt_kodeobat, txt_namaobat, txt_value, txt_jenis) VALUES (@id_recipe, @txt_kodeobat, @txt_namaobat, @txt_value, @txt_jenis)"
                    Dim cmdi As New OleDbCommand(simpan, conn)
                    cmdi.Parameters.AddWithValue("@id_recipe", newID)

                    cmdi.Parameters.AddWithValue("@txt_kodeobat", row.Cells(0).Value.ToString())
                    cmdi.Parameters.AddWithValue("@txt_namaobat", row.Cells(1).Value.ToString())
                    cmdi.Parameters.AddWithValue("@txt_value", row.Cells(2).Value.ToString())
                    cmdi.Parameters.AddWithValue("@txt_jenis", row.Cells(3).Value.ToString())

                    cmdi.ExecuteNonQuery()
                End If
            Next

            MsgBox("Data berhasil disimpan")
        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        End Try
    End Sub


    Private Sub FormAddRecipe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormMenuAwal.Show()
    End Sub

End Class