Imports System.ComponentModel
Public Class M_BuscarEmpleados
    Private Sub M_BuscarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim n As String = ""
            If e.RowIndex >= 0 Then
                n = MsgBox("¿Desea ver los datos del empleado?", MsgBoxStyle.YesNo)
            End If
            If n = vbYes Then
                M_Empleados.limpiar()
                Dim objEmp As New ClsEmpleados
                objEmp.codigo_ = dgbtabla.Rows(e.RowIndex).Cells(0).Value()

                Dim dt As New DataTable
                dt = objEmp.BuscarDatosEmpleadoPorCodigo()
                Dim row As DataRow = dt.Rows(0)

                M_Empleados.txtcodigo.Text = CStr(row("codigo"))

                M_Empleados.txtnombre1.Text = CStr(row("nombre1"))
                M_Empleados.txtnombre2.Text = CStr(row("nombre2"))
                M_Empleados.txtapellido1.Text = CStr(row("apellido1"))
                M_Empleados.txtapellido2.Text = CStr(row("apellido2"))
                M_Empleados.txtnombreCompleto.Text = CStr(row("nombreCompleto"))
                M_Empleados.lblcodigoArea.Text = CStr(row("codigoArea"))
                'M_Empleados.txtcodigoArea.Text = CStr(row("numero"))
                M_Empleados.dtpfechaAlta.Text = CStr(row("fechaAlta"))
                M_Empleados.mtxtidentidad.Text = CStr(row("nIdentidad"))

                M_Empleados.txtseguroSocial.Text = CStr(row("nSeguroSocial"))
                M_Empleados.txtseguroVida.Text = CStr(row("nSeguroVida"))
                M_Empleados.txtcodigoHorario.Text = CStr(row("codigoHorario"))
                M_Empleados.txtbanco.Text = CStr(row("banco"))
                M_Empleados.txtcuentaBancaria.Text = CStr(row("cuentaBancaria"))
                M_Empleados.txtcodigoFormaPago.Text = CStr(row("codigoFormaPago"))

                If IsDBNull(row("fechaBaja")) = False Then
                    M_Empleados.dtpfechaBaja.Text = CStr(row("fechaBaja"))
                Else
                    M_Empleados.dtpfechaBaja.Format = DateTimePickerFormat.Custom
                    M_Empleados.dtpfechaBaja.CustomFormat = " "
                End If

                If IsDBNull(row("fechaAvisoBaja")) = False Then
                    M_Empleados.dtpFechaAvisoBaja.Text = CStr(row("fechaAvisoBaja"))
                Else
                    M_Empleados.dtpFechaAvisoBaja.Format = DateTimePickerFormat.Custom
                    M_Empleados.dtpFechaAvisoBaja.CustomFormat = " "
                End If

                M_Empleados.rtxtmotivoBaja.Text = CStr(row("motivoBaja"))
                M_Empleados.lblcodePuesto.Text = CStr(row("codigoPuestoTrab"))
                M_Empleados.lblcodeDepto.Text = CStr(row("codigoDepto"))
                M_Empleados.txtsalario.Text = Convert.ToDecimal(CStr(row("salario"))).ToString("N2")
                M_Empleados.cmbxtipoCuenta.SelectedItem = CStr(row("tipoCuenta"))

                M_Empleados.llenarContratos()
                M_Empleados.cmbxcodigoContrato.SelectedValue = CStr(row("codigoContrato"))
                M_Empleados.cmbxestadoLaboral.SelectedItem = CStr(row("estadoLaboral"))
                M_Empleados.rtxtdireccion.Text = CStr(row("direccion1"))
                M_Empleados.rtxtdireccion2.Text = CStr(row("direccion2"))
                M_Empleados.txtcorreo.Text = CStr(row("correo1"))
                M_Empleados.txtcorreo2.Text = CStr(row("correo2"))
                M_Empleados.txttelefono.Text = CStr(row("telefono"))
                M_Empleados.txtcelular.Text = CStr(row("celular"))
                M_Empleados.txtRTN.Text = CStr(row("rtn"))
                M_Empleados.dtpfechaNacimiento.Text = CStr(row("fechaNacimiento"))
                M_Empleados.rtxtlugarNacimiento.Text = CStr(row("lugarNacimiento"))
                M_Empleados.txtcodigoProfesion.Text = CStr(row("codigoProfesion"))

                M_Empleados.txtgrupoSanguineo.Text = CStr(row("grupoSanguineo"))
                M_Empleados.txtcontactoUrgencias.Text = CStr(row("contactoUrgencias"))
                M_Empleados.txttelUrgencias.Text = CStr(row("telUrgencias"))
                M_Empleados.txtcelularUrgencias.Text = CStr(row("celUrgencias"))
                M_Empleados.txtnombreConyugue.Text = CStr(row("nombreConyugue"))

                M_Empleados.txtnombrePadre.Text = CStr(row("nombrePadre"))

                M_Empleados.txtnombreMadre.Text = CStr(row("nombreMadre"))
                If CStr(row("genero")) = "Masculino" Then
                    M_Empleados.rbtnmasculino.Checked = True
                Else
                    M_Empleados.rbtnfemenino.Checked = True
                End If

                'contacto urgencias 2
                M_Empleados.txtcontactoUrgencias2.Text = CStr(row("contactoUrgencias2"))
                M_Empleados.txttelUrgencias2.Text = CStr(row("telUrgencias2"))
                M_Empleados.txtcelularUrgencias2.Text = CStr(row("celUrgencias2"))

                'radio boton 
                M_Empleados.lblEstadoCvl2.Text = CStr(row("estadoCivil"))

                ''imagen 
                'If IsDBNull(row("imagen")) = False Or Trim(row("imagen").ToString) <> "" Then
                If Trim(row("imagen").ToString) <> "" Then
                    M_Empleados.txtRuta.Text = CStr(row("imagen"))
                    M_Empleados.pbxEmpleado.LoadAsync(row("imagen"))
                End If

                M_Empleados.btnguardar.Enabled = False
                M_Empleados.btnmodificar.Enabled = True
                M_Empleados.lblform.Text = "M_BuscarEmpleados"
                M_Empleados.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtcodigoB_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoB.TextChanged
        If (txtcodigoB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.codigo_ = txtcodigoB.Text
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
    Private Sub txtnombreB_TextChanged(sender As Object, e As EventArgs) Handles txtnombreB.TextChanged
        If (txtnombreB.Text <> "") Then
            Try
                Dim objEmp As New ClsEmpleados
                objEmp.NombreCompleto_ = txtnombreB.Text
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
    Private Sub btnnueva_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        'Me.Close()
        M_Empleados.llenarContratos()
        M_Empleados.limpiar()
        M_Empleados.lblform.Text = "M_BuscarEmpleados"
        M_Empleados.Show()
    End Sub

End Class