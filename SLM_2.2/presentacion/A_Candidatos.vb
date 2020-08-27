Public Class A_Candidatos
    Private Sub A_Candidatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            cargardata()

        Catch ex As Exception

        End Try

    End Sub

    Sub cargardata()
        Dim candidatos As New ClsCandidatos
        dtCandidatos.DataSource = candidatos.SeleccionarCandidatos
    End Sub

    Sub limpiar()

        txtNombre.Clear()
        txtContacto.Clear()
        txtDescripcion.Clear()
        txtProfesion.Clear()
        txtArea.Clear()
        txtCargo.Clear()
        dtpFecha.Value = Date.Now

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        limpiar()
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False

    End Sub

    Private Sub btnBuscarPro_Click(sender As Object, e As EventArgs) Handles btnBuscarPro.Click
        Try

            M_Profesion.Show()
            M_Profesion.lblform.Text = "Candidatos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscarCargo_Click(sender As Object, e As EventArgs) Handles btnBuscarCargo.Click
        Try

            M_PuestoTrabajo.Show()
            M_PuestoTrabajo.lblform.Text = "Candidatos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            M_Area.Show()
            M_Area.lblform.Text = "Candidatos"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            Dim candidato As New ClsCandidatos

            With candidato

                .codigoArea_ = Convert.ToInt32(lblcodArea.Text)
                .codigoPuestoTrabajo_ = Convert.ToInt32(lblcodCargo.Text)
                .codigoProfesion_ = Convert.ToInt32(lblcodProfesion.Text)
                .Nombre_ = txtNombre.Text
                .descripcionExperiencia_ = txtDescripcion.Text
                .telContacto_ = txtContacto.Text
                .fechaAplicacion_ = dtpFecha.Value

                If .RegistrarNuevoCandidato = 1 Then
                    MsgBox("Se registro un nuevo candidato.")
                    cargardata()
                    limpiar()
                End If
            End With

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dtCandidatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtCandidatos.CellDoubleClick

        Try
            Dim area As New ClsArea
            Dim profesion As New ClsProfesion
            Dim cargo As New ClsPuestoTrabajo

            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtCandidatos.DataSource
            row = dt.Rows(e.RowIndex)

            lblCandidato.Text = row("codigo")
            lblcodArea.Text = row("codigoArea")
            lblcodCargo.Text = row("codigoPuestoTrabajo")
            txtDescripcion.Text = row("descripcionExperiencia")
            txtContacto.Text = row("telContacto")
            lblcodProfesion.Text = row("codigoProfesion")
            dtpFecha.Value = row("fechaAplicacion")
            txtNombre.Text = row("nombre")

            'buscar area
            area.codigo_ = Convert.ToInt32(lblcodArea.Text)
            dt = area.BuscarArea
            row = dt.Rows(0)
            txtArea.Text = row("nombre")

            'buscar profesion
            profesion.Codigo_ = Convert.ToInt32(lblcodProfesion.Text)
            dt = profesion.BuscarProfesionCode
            row = dt.Rows(0)
            txtProfesion.Text = row("descripcion")

            'buscar cargo
            cargo.Codigo_ = Convert.ToInt32(lblcodCargo.Text)
            dt = cargo.BuscarPuestoTrabajoCode
            row = dt.Rows(0)
            txtCargo.Text = row("descripcion")

            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGuardar.Enabled = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim candidato As New ClsCandidatos

            With candidato

                .codigo_ = Convert.ToInt32(lblCandidato.Text)
                .codigoArea_ = Convert.ToInt32(lblcodArea.Text)
                .codigoPuestoTrabajo_ = Convert.ToInt32(lblcodCargo.Text)
                .codigoProfesion_ = Convert.ToInt32(lblcodProfesion.Text)
                .Nombre_ = txtNombre.Text
                .descripcionExperiencia_ = txtDescripcion.Text
                .telContacto_ = txtContacto.Text
                .fechaAplicacion_ = dtpFecha.Value

                If .ModificarCandidatos = 1 Then
                    MsgBox("Se modifico el registro.")
                    cargardata()
                    limpiar()
                End If
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            Dim candidato As New ClsCandidatos

            With candidato

                .codigo_ = Convert.ToInt32(lblCandidato.Text)
                .EliminarCandidato()
                limpiar()

            End With
            cargardata()

        Catch ex As Exception

        End Try
    End Sub
End Class