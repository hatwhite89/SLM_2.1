Imports System.ComponentModel
Public Class M_ListadoEmpleados

    Private Sub M_ListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeleccionarEmpleados()
    End Sub
    Public Sub SeleccionarEmpleados()
        Dim objEmp As New ClsEmpleados
        Dim dv As DataView = objEmp.SeleccionarEmpleados.DefaultView
        dgbtabla.DataSource = dv
        lblcantidad.Text = dv.Count
        dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub dgbtabla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgbtabla.CellMouseDoubleClick
        Try
            If lblform.Text = "M_Permisos_JefeInmediato" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Permisos.lblcodeJefeInme.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Permisos.txtjefeInmediato.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Permisos_TalentoHumano" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Permisos.lblcodeTalentoHumano.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Permisos.txtTalentoHumano.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            ElseIf lblform.Text = "M_Permisos_Empleado" Then
                Dim n As String = ""
                If e.RowIndex >= 0 Then
                    n = MsgBox("¿Desea utilizar el empleado?", MsgBoxStyle.YesNo)
                End If
                If n = vbYes Then
                    M_Permisos.lblcodigoEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(0).Value()
                    M_Permisos.txtEmpleado.Text = dgbtabla.Rows(e.RowIndex).Cells(1).Value()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoB.TextChanged
        If (txtCodigoB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.codigo_ = txtCodigoB.Text
                Dim dv As DataView = objEmp.BuscarEmpleadosPorCodigo.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe el empleados con el respectivo código.", MsgBoxStyle.Information, "Validación")
            End Try
        Else
            SeleccionarEmpleados()
        End If
    End Sub
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtNombreB.TextChanged
        If (txtNombreB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.NombreCompleto_ = txtNombreB.Text
                Dim dv As DataView = objEmp.BuscarEmpleadosPorNombre.DefaultView
                dgbtabla.DataSource = dv
                lblcantidad.Text = dv.Count
                dgbtabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Catch ex As Exception
                MsgBox("No existe la empleado con ese nombre.", MsgBoxStyle.Information, "Validación")
            End Try
        Else
            SeleccionarEmpleados()
        End If
    End Sub

End Class