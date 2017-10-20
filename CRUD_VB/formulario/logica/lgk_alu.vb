Imports entidad
Imports datos

Public Class lgk_alu
    Public Sub reg_alu(ByVal var_alu As propiedades)
        Try
            Dim objcx As New AC_alu
            Dim enti As New propiedades
            With enti
                ._nomalu = var_alu._nomalu
                ._apealu = var_alu._apealu
                ._dnialu = var_alu._dnialu
            End With
            objcx.regis_alu(enti)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mod_alu(ByVal var_alu As propiedades)
        Try
            Dim objcx As New AC_alu
            Dim enti As New propiedades
            With enti
                ._idalu = var_alu._idalu
                ._nomalu = var_alu._nomalu
                ._apealu = var_alu._apealu
                ._dnialu = var_alu._dnialu
            End With
            objcx.modifica_alu(enti)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub eli_alu(ByVal var_alu As propiedades)
        Try
            Dim objcx As New AC_alu
            Dim enti As New propiedades
            With enti
                ._idalu = var_alu._idalu
            End With
            objcx.elimina_alu(enti)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function bus_alumno(ByVal var_alu As propiedades) As DataTable
        Try
            Dim objcx As New AC_alu
            Dim dtabla As New DataTable
            Dim objenti As New propiedades
            With objenti
                ._idalu = var_alu._idalu
            End With
            dtabla = objcx.buscar_alu(objenti)
            If Not IsNothing(dtabla) Then
                Return dtabla
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function listar_alumno() As DataTable
        Try
            Dim objcx As New AC_alu
            Dim dtabla As New DataTable
            dtabla = objcx.listar_alu()
            If Not IsNothing(dtabla) Then
                Return dtabla
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Function



End Class
