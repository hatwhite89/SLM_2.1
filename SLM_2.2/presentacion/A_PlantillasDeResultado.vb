Imports System.Xml

Public Class A_PlantillasDeResultado
    Dim plantilla As New ClsPlantillaResultado
    Private Sub A_PlantillasDeResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alternarColoFilasDatagridview(dtPlantillas)
            ListarPlantillas()


            btnNuevo.Enabled = False
            btnModificar.Enabled = False


        Catch ex As Exception
            MsgBox("No se pudieron listar los registros. Error: " + ex.Message)

        End Try

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If txtSimbolo.Text <> "" And rtxtDescripcion.Text <> "" And (txtCodigoArea.Text) <> "" Then

                With plantilla
                    .simbolo_ = txtSimbolo.Text
                    .descripcion_ = rtxtDescripcion.Text
                    .codGrupoExamen_ = Convert.ToInt64(txtCodigoArea.Text)
                    If .registrarNuevaPlantilla() = 1 Then
                        ListarPlantillas()
                        LimpiarCampos()
                    Else
                        MsgBox("Error al guardar la plantilla de resultado.", MsgBoxStyle.Critical, "Validación.")
                    End If
                End With
                MsgBox("Registrado correctamente.", MsgBoxStyle.Information, "Validación.")
            Else
                MsgBox("Debe llenar los campos necesarios para guardar la plantilla de resultado.", MsgBoxStyle.Exclamation, "Validación.")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            If txtSimbolo.Text <> "" And rtxtDescripcion.Text <> "" And txtCodigo.Text <> "" And (txtCodigoArea.Text) <> "" Then

                With plantilla
                    .Cod = Convert.ToInt64(txtCodigo.Text)
                    .codGrupoExamen_ = Convert.ToInt64(txtCodigoArea.Text)
                    .simbolo_ = txtSimbolo.Text
                    .descripcion_ = rtxtDescripcion.Text
                    If .modificarPlantilla() = 1 Then
                        ListarPlantillas()
                        LimpiarCampos()
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Enabled = True
                    Else
                        MsgBox("Error al actualizar la plantilla de resultado.", MsgBoxStyle.Critical, "Validación.")
                    End If
                End With
                MsgBox("Actualizado correctamente.", MsgBoxStyle.Information, "Validación.")
            Else
                MsgBox("Debe llenar los campos necesarios para actualizar la plantilla de resultado.", MsgBoxStyle.Exclamation, "Validación.")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtPlantillas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtPlantillas.CellDoubleClick

        Try
            btnNuevo.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False
            Dim dt As New DataTable
            Dim row As DataRow

            dt = dtPlantillas.DataSource
            row = dt.Rows(e.RowIndex)

            txtCodigo.Text = row("cod_Plantilla")
            txtSimbolo.Text = row("simbolo")
            rtxtDescripcion.Text = row("descripcion")
            txtCodigoArea.Text = row("codGrupoExamen")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub ListarPlantillas()

        dtPlantillas.DataSource = plantilla.listarPlantillas

        If dtPlantillas.Columns.Contains("cod_Plantilla") = True Then

            dtPlantillas.Columns("cod_Plantilla").Visible = False
            dtPlantillas.Columns("codGrupoExamen").Visible = False

            dtPlantillas.Columns("simbolo").HeaderText = "Símbolo"
            dtPlantillas.Columns("simbolo").HeaderText = "Descripción"

        End If

    End Sub

    Sub LimpiarCampos()

        txtCodigo.Clear()
        txtSimbolo.Clear()
        rtxtDescripcion.Clear()
        txtCodigoArea.Clear()
        btnModificar.Enabled = False
        btnGuardar.Enabled = True

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub txtCodigoArea_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoArea.TextChanged
        If (txtCodigoArea.Text <> "") Then
            Try
                Dim objGrpE As New ClsGrupoExamen
                With objGrpE
                    .codigo_ = txtCodigoArea.Text
                End With
                Dim dt As New DataTable
                dt = objGrpE.BuscarGrupoExamenCodigo()
                Dim row As DataRow = dt.Rows(0)
                txtNombreArea.Text = CStr(row("nombre"))
                txtCodigoArea.BackColor = Color.White
            Catch ex As Exception
                txtCodigoArea.BackColor = Color.Red
                txtNombreArea.Text = ""
                ' MsgBox("No existe el código de la sede.", MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            txtCodigoArea.Text = ""
            txtNombreArea.Text = ""
            txtCodigoArea.BackColor = Color.White
        End If
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Private Sub txtCodigoArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoArea.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscarArea_Click(sender As Object, e As EventArgs) Handles btnBuscarArea.Click
        E_GrupoExamen.lblform.Text = "A_PlantillasDeResultado"
        E_GrupoExamen.Show()
    End Sub

End Class