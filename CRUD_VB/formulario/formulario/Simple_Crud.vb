Imports logica
Imports entidad
Public Class SimpleCRUD

    Sub busca()
        Try
            Dim objlgk As New lgk_alu
            Dim dtabla As New DataTable
            Dim objenti As New propiedades
            With objenti
                ._idalu = Int32.Parse(txt_id.Text)
            End With

            dtabla = objlgk.bus_alumno(objenti)

            If Not IsNothing(dtabla) Then
                dgv_detalle.DataSource = dtabla
            Else
                dgv_detalle.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub refrescar()
        Dim objlgk As New lgk_alu
        Dim dtabla As New DataTable
        dtabla = objlgk.listar_alumno()
        dgv_detalle.DataSource = dtabla
    End Sub

    Sub llenargrilla()
        Try
            Dim objlgk As New lgk_alu
            Dim dtabla As New DataTable
            dtabla = objlgk.listar_alumno()
            If Not IsNothing(dtabla) Then
                dgv_detalle.DataSource = dtabla
            Else
                dgv_detalle.DataSource = Nothing
            End If
            refrescar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub SimpleCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar()
        llenargrilla()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            Dim objlgk As New lgk_alu
            Dim objenti As New propiedades

            With objenti
                ._nomalu = txt_nom.Text
                ._apealu = txt_ape.Text
                ._dnialu = txt_dni.Text
            End With

            objlgk.reg_alu(objenti)
            refrescar()
            MessageBox.Show("Registros guardados correctamente...", "Mensaje", MessageBoxButtons.OK)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            Dim objlgk As New lgk_alu
            Dim objenti As New propiedades

            With objenti
                ._idalu = Int32.Parse(txt_id.Text)
                ._nomalu = txt_nom.Text
                ._apealu = txt_ape.Text
                ._dnialu = txt_dni.Text
            End With

            objlgk.mod_alu(objenti)
            refrescar()
            MessageBox.Show("Registros modificaron correctamente...", "Mensaje", MessageBoxButtons.OK)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            Dim objlgk As New lgk_alu
            Dim objenti As New propiedades

            With objenti
                ._idalu = Int32.Parse(txt_id.Text)
            End With

            objlgk.mod_alu(objenti)
            refrescar()
            MessageBox.Show("Registros eliminaron correctamente...", "Mensaje", MessageBoxButtons.OK)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        busca()
    End Sub

    Private Sub dgv_detalle_DoubleClick(sender As Object, e As EventArgs) Handles dgv_detalle.DoubleClick
        txt_id.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells("idalu").Value)
        txt_nom.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells("nomalu").Value)
        txt_ape.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells("apealu").Value)
        txt_dni.Text = Convert.ToString(dgv_detalle.CurrentRow.Cells("dnialu").Value)
    End Sub
End Class
