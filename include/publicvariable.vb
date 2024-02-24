Imports SingleStoreConnector
Module publicvariable
    ' Public PASSWORDS As String = "JET SingleStore:Database Password = JANOBE"
    Public query As String
    Public da As New SingleStoreDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet
    Public cmd As New SingleStoreCommand
    Public cmd123 As New SingleStoreCommand 'kusus woven prij list
    Public result As Boolean
    Public msgfalse As String = "false"
    Public msgtrue As String = "True"
    Public fields As String = ""
    Public fvalue As String = ""
    Public checkQuery As String = ""
    Public insertQuery As String = ""
    Public updateQuery As String = ""
    Public inistd As String = ""
    Public labelyearly As String
    Public usernameCS As String
    Public TriggerPesan As String
    Public modeonline As Boolean
    Public onoff As Boolean
    Public hostdarilogin As String
End Module
