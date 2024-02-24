Imports SingleStoreConnector

Public Class FormAddRecipe
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        koneksi()
        Saveprocess()
        MsgBox("Data Berhasil Di simpan")
    End Sub

    Sub Saveprocess()
        Dim cmdi As SingleStoreCommand
        Dim simpan As String = "INSERT INTO tbl_recipe
            (
txt_recipe,
txt_pesanan,
txt_poockh,
txt_kodekain,
txt_warna,
txt_noacc,
txt_namaobat,
txt_obat,
txt_koreksi
) 
            VALUES
            (@txt_recipe,
@txt_pesanan,
@txt_poockh,
@txt_kodekain,
@txt_warna,
@txt_noacc,
@txt_namaobat,
@txt_obat,
@txt_koreksi
)"
        cmdi = New SingleStoreCommand(simpan, conn)

        cmdi.Parameters.Add("@txt_recipe", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_pesanan", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_poockh", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_kodekain", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_warna", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_noacc", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_namaobat", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_obat", SingleStoreDbType.VarChar)
        cmdi.Parameters.Add("@txt_koreksi", SingleStoreDbType.VarChar)


        cmdi.Connection = conn

        cmdi.Parameters(0).Value = txt_recipe.Text
        cmdi.Parameters(1).Value = txt_pesanan.Text
        cmdi.Parameters(2).Value = txt_poockh.Text
        cmdi.Parameters(3).Value = txt_kodekain.Text
        cmdi.Parameters(4).Value = txt_warna.Text
        cmdi.Parameters(5).Value = txt_noacc.Text
        cmdi.Parameters(6).Value = ""
        cmdi.Parameters(7).Value = ""
        cmdi.Parameters(8).Value = ""



        cmdi.ExecuteNonQuery()
    End Sub
End Class