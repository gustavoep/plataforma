Imports System.Data.OleDb
Module mdlAcesso

    Public Function GetConnection() As OleDbConnection
        Dim conesao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\GEOMATICA\Gustavo+Curso Geoestatistica UFRGS\Catalisa Sensor Green\Database\Testes\QrCode\Database5.accdb"
        Return New OleDbConnection(conesao)
    End Function
End Module
