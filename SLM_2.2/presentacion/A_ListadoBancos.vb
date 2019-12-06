﻿Public Class A_ListadoBancos
    'Objeto Banco
    Dim Banco As New ClsBancos

    Private Sub A_ListadoBancos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Listar Bancos 
        dtBancos.DataSource = Banco.listarBancosNombreCod
    End Sub

    Private Sub dtBancos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtBancos.CellDoubleClick

        If lblFormBanco.Text = "1" Then 'Campo Banco en Mantenimiento de Forma Pago

            frmFormaPago.txtBanco.Text = dtBancos.Rows(e.RowIndex).Cells(1).Value

        Else

            A_Chequera.txtBanco.Text = dtBancos.Rows(e.RowIndex).Cells(0).Value
            A_Chequera.lblNombreBanc.Text = dtBancos.Rows(e.RowIndex).Cells(1).Value

        End If

        'Cerrar forma al seleccionar banco
        Me.Close()

    End Sub
End Class