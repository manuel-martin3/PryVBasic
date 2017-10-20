Imports System.Data
Imports System.Data.SqlClient
Imports entidad

Public Class cx
    Public source As String = "."
    Public catalogo As String = "matricula"
    Public user As String = "sa"
    Public password As String = "123456"

    Public Function objcxdb() As String
        Dim cn As String
        cn = "Data Source=" + source.ToString +
             ";Initial Catalog=" + catalogo.ToString +
             ";User ID=" + user.ToString +
             ";Password=" + password.ToString
        Return cn
    End Function
End Class
