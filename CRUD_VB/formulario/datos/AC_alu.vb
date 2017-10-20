Imports System.Data
Imports System.Data.SqlClient
Imports entidad

Public Class AC_alu

    Public Sub regis_alu(ByVal var_alu As propiedades)
        Try
            Dim cn As String
            Dim objcn As New cx
            cn = objcn.objcxdb
            Dim con As New SqlConnection(cn)
            Dim cmd As New SqlCommand("insert_alumno", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nomalu", var_alu._nomalu)
            cmd.Parameters.AddWithValue("@apealu", var_alu._apealu)
            cmd.Parameters.AddWithValue("@dnialu", var_alu._dnialu)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub modifica_alu(ByVal var_alu As propiedades)
        Try
            Dim cn As String
            Dim objcn As New cx
            cn = objcn.objcxdb
            Dim con As New SqlConnection(cn)
            Dim cmd As New SqlCommand("modifica_alumno", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idalu", var_alu._idalu)
            cmd.Parameters.AddWithValue("@nomalu", var_alu._nomalu)
            cmd.Parameters.AddWithValue("@apealu", var_alu._apealu)
            cmd.Parameters.AddWithValue("@dnialu", var_alu._dnialu)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub elimina_alu(ByVal var_alu As propiedades)
        Try
            Dim cn As String
            Dim objcn As New cx
            cn = objcn.objcxdb
            Dim con As New SqlConnection(cn)
            Dim cmd As New SqlCommand("elimina_alumno", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idalu", var_alu._idalu)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Function listar_alu()
        Dim cn As String
        Dim objcn As New cx
        cn = objcn.objcxdb
        Dim con As New SqlConnection(cn)
        Dim cmd As New SqlCommand("listar_alumno", con)
        cmd.CommandType = CommandType.StoredProcedure
        Dim dtabla As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        con.Open()
        da.Fill(dtabla)
        con.Close()
        Return dtabla
    End Function

    Public Function buscar_alu(ByVal var_alu As propiedades)
        Dim cn As String
        Dim objcn As New cx
        cn = objcn.objcxdb
        Dim con As New SqlConnection(cn)
        Dim cmd As New SqlCommand("listar_alumno", con)
        cmd.Parameters.AddWithValue("@idalu", var_alu.idalu)
        cmd.CommandType = CommandType.StoredProcedure
        Dim dtabla As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        con.Open()
        da.Fill(dtabla)
        con.Close()
        Return dtabla
    End Function




End Class
