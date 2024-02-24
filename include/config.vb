Imports SingleStoreConnector
Module config
    Public databasename As String = "\MTdb.accdb"
    Private Function configdb() As SingleStoreConnection
        Return New SingleStoreConnection(hostdarilogin)
    End Function
    Public con As SingleStoreConnection = configdb()
End Module
