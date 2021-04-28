Public Class A_ListarCuentas


    Dim cuentas As New ClsCuenta
    Private Sub A_ListarCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            alternarColoFilasDatagridview(dtCuentas)
            dtCuentas.DataSource = cuentas.listarCuentasNombre()

            dtCuentas.Columns("codCuenta").Visible = False
            dtCuentas.Columns("tipoCuenta").Visible = False
            dtCuentas.Columns("estado").Visible = False
            dtCuentas.Columns("cuenta").HeaderText = "N. de Cuenta"
            dtCuentas.Columns("nombre").HeaderText = "Nombre de Cuentas"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Cargar cuentas en DataGrid


    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Dim Dato As New DataView

        Try
            'Actualizar datos en datagrid con textbox
            cuentas.Nombr_e = txtBusqueda.Text

            Dato = cuentas.buscarCtaXNombre.DefaultView
            dtCuentas.DataSource = Dato
        Catch ex As Exception
            'MessageBox.Show("El código es incorrecto o el campo está vacio.")
        End Try

    End Sub
    Private Sub dtCuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCuentas.CellDoubleClick
        'Seleccionar campo cuenta para formulario forma pago
        Try

            If lblForm.Text = "facturaCompra" Then

                Dim n As String = MsgBox("¿Desea utilizar la cuenta?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    Dim cuenta, nombre As String

                    cuenta = dtCuentas.Rows(e.RowIndex).Cells(1).Value
                    nombre = dtCuentas.Rows(e.RowIndex).Cells(2).Value

                    'Asignar busqueda en Datagrid
                    'A_FacturaCompras.dtDetalleFactura.Rows.Remove(A_FacturaCompras.dtDetalleFactura.Rows(e.RowIndex.ToString))
                    A_FacturaCompras.dtDetalleFactura.Rows.Add(New String() {"0", cuenta, "", "", nombre})
                End If
            ElseIf lblForm.Text = "asientos" Then
                Dim n As String = MsgBox("¿Desea utilizar la cuenta?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    'Llenar campo de asientos contables
                    Dim acuenta, anombre As String
                    acuenta = dtCuentas.Rows(e.RowIndex).Cells(1).Value
                    anombre = dtCuentas.Rows(e.RowIndex).Cells(2).Value

                    frmAsientos.dtDetalleAsiento.Rows.Add(New String() {"0", acuenta, anombre, 0.0, 0.0})
                End If
            ElseIf lblForm.Text = "proveedor" Then
                Dim n As String = MsgBox("¿Desea utilizar la cuenta?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then
                    A_Proveedor.lblCodCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(0).Value
                    A_Proveedor.txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(1).Value
                End If

            ElseIf lblForm.Text = "CC" Then
                Dim n As String = MsgBox("¿Desea utilizar la cuenta?", MsgBoxStyle.YesNo, "Validación")
                If n = vbYes Then

                    A_CentrodeCosto.codCuenta = dtCuentas.Rows(e.RowIndex).Cells(0).Value
                    A_CentrodeCosto.txtNombreCuenta = dtCuentas.Rows(e.RowIndex).Cells(2).Value
                    Me.Close()
                End If

            Else
                frmFormaPago.txtCuenta.Text = dtCuentas.Rows(e.RowIndex).Cells(1).Value

            End If

                'Cerrar forma al seleccionar
                Me.Close()

        Catch ex As Exception
            MsgBox("Seleccion de cuenta. " + ex.Message)
        End Try


    End Sub
End Class