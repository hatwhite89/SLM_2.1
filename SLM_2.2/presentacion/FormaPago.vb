

Public Class frmFormaPago
    Private Sub lblNombreBanco_Click(sender As Object, e As EventArgs) Handles lblNombreBanco.Click

    End Sub

    Private Sub lblFormulario_Click(sender As Object, e As EventArgs) Handles lblFormulario.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Guardar nuevo registro de forma de pago.

        Try
            Dim FormaPago As New ClsFormaPago

            FormaPago.Cod = txtCodigo.Text
            FormaPago.Cuen_ta = Convert.ToInt32(txtCuenta.Text)
            FormaPago.Comenta_rio = txtComentario.Text
            FormaPago.Cuenta_Banco = Convert.ToInt32(txtCtaBanco.Text)
            FormaPago.Nombre_Banco = txtNombreBanco.Text
            FormaPago.Formu_lario = txtFormulario.Text
            FormaPago.Ti_po = txtTipo.Text
            FormaPago.Ban_co = txtBanco.Text
            'FormaPago.Comi_sion = Convert.ToDouble(txtComision.Text)

            FormaPago.RegistrarNuevoPaciente()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try






    End Sub

    Private Sub frmFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class