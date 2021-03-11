Public Class A_CentrodeCosto

    'Objeto
    Dim objCentroCosto As New ClsCentroCostos
    Dim objAreaLab As New ClsGrupoExamen

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            GroupBox1.Enabled = True
            Limpiar()
            btnGuardar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub llenarData()

        Dim dtCC, dtA As New DataTable
        Dim rowCC, rowA As DataRow

        dtCC = objCentroCosto.ListarCentrodeCosto

        If dtCC.Rows.Count > 0 Then


            For i = 0 To dtCC.Rows.Count - 1
                rowCC = dtCC.Rows(i)

                'Buscar area de centro de costo
                objAreaLab.codigo_ = Integer.Parse(rowCC("cod_area"))
                dtA = objAreaLab.BuscarGrupoExamenCodigo

                rowA = dtA.Rows(0)

                dgvCentroCosto.Rows.Add(CStr(rowCC("id_centrocosto")), rowCC("codBreve"), rowCC("nombre"), rowA("nombre"), CStr(rowA("codigo")))

            Next

        End If

    End Sub

    Private Sub Guardar()


        With objCentroCosto

            .nombre_ = txtNombre.Text
            .cod_area_ = Integer.Parse(lblcodArea.Text)
            .codBreve_ = txtCodBreve.Text

            If .RegistrarNuevoCentroCosto = 1 Then
                MsgBox("Se registro un nuevo Centro de Costo.")

            End If

        End With

    End Sub

    Private Sub Modificar()

        With objCentroCosto

            .ID = Integer.Parse(txtId.Text)
            .nombre_ = txtNombre.Text
            .cod_area_ = Integer.Parse(lblcodArea.Text)
            .codBreve_ = txtCodBreve.Text

            If .ActualizarCentroCosto = 1 Then
                MsgBox("Se actualizo el Centro de Costo.")

            End If

        End With

    End Sub

    Private Sub Limpiar()

        txtId.Clear()
        txtNombre.Clear()
        txtNombreArea.Clear()
        lblcodArea.Text = "codArea"
        txtCodBreve.Clear()

    End Sub

    Private Sub A_CentrodeCosto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarData()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try

            If txtNombre.Text <> "" Or lblcodArea.Text <> "codArea" Or txtCodBreve.Text <> "" Then
                Guardar()

                Limpiar()
                GroupBox1.Enabled = False
                btnGuardar.Enabled = False
                dgvCentroCosto.Rows.Clear()
                llenarData()

            ElseIf txtNombre.Text = "" Then
                MsgBox("Debe asignar un nombre al centro de costo.")
            ElseIf lblcodArea.Text = "codArea" Then
                MsgBox("Debe seleccionar un area para el centro de costo")
            ElseIf txtCodBreve.Text = "" Then
                MsgBox("Debe asignar un Código Breve al centro de costo.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            E_GrupoExamen.lblform.Text = "CentroCosto"
            E_GrupoExamen.Show()
            E_GrupoExamen.BringToFront()
            E_GrupoExamen.WindowState = WindowState.Normal
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try


            If txtNombre.Text <> "" Or lblcodArea.Text <> "codArea" Then
                Modificar()
                GroupBox1.Enabled = False
                Limpiar()
                dgvCentroCosto.Rows.Clear()
                llenarData()
                btnModificar.Enabled = False
            ElseIf txtNombre.Text = "" Then
                MsgBox("Debe asignar un nombre al centro de costo.")
            ElseIf lblcodArea.Text = "codArea" Then
                MsgBox("Debe seleccionar un area para el centro de costo")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub dgvCentroCosto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCentroCosto.CellDoubleClick

        Try

            txtId.Text = dgvCentroCosto.Rows(e.RowIndex).Cells(0).Value
            txtCodBreve.Text = dgvCentroCosto.Rows(e.RowIndex).Cells(1).Value.ToString
            txtNombre.Text = dgvCentroCosto.Rows(e.RowIndex).Cells(2).Value
            lblcodArea.Text = dgvCentroCosto.Rows(e.RowIndex).Cells(4).Value

            'Area
            Dim objarea As New ClsGrupoExamen
            Dim dtArea As New DataTable
            Dim row As DataRow

            With objarea

                .codigo_ = Integer.Parse(lblcodArea.Text)
                dtArea = .BuscarGrupoExamenCodigo
                row = dtArea.Rows(0)

                txtNombreArea.Text = row("nombre")

            End With

            GroupBox1.Enabled = True
            btnModificar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class