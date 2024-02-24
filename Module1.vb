'imports singlestoreconnector
Imports SingleStoreConnector
Module Module1

    Public str As String
    Public conn As SingleStoreConnection
    Public cmdi As SingleStoreCommand
    Public dr As SingleStoreDataReader

    Sub koneksi()
        str = "host=svc-fcc7225b-5d78-4f3a-82af-7462d4ce7089-dml.aws-jakarta-1.svc.singlestore.com;port=3306;userid=admin;password=Regexbro123;database=MarketingTools;"
        conn = New SingleStoreConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            MsgBox(“Koneksi gagal, cek modul 1”)
        End If
    End Sub

End Module
