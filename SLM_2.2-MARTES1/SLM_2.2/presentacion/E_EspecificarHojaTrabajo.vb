Public Class E_EspecificarHojaTrabajo
    Dim objUser As New ClsUsuario
    Dim objSuc As New ClsSucursal
    Dim objSubA As New ClsSubArea
    Private Sub txtSubArea_TextChanged(sender As Object, e As EventArgs) Handles txtSubArea.TextChanged
        If (Trim(txtSubArea.Text) <> "") Then
            Try
                With objSubA
                    .Cod_SubArea = txtSubArea.Text
                End With
                Dim dt As New DataTable
                dt = objSubA.BuscarSubAreaCodigoBreve()
                Dim row As DataRow = dt.Rows(0)
                lblCodigoGrupo.Text = CStr(row("codigoArea"))
                txtDescripcionSubArea.Text = CStr(row("nombre"))
                lblCodeSubArea.Text = CStr(row("codSubArea"))
            Catch ex As Exception
                lblCodeSubArea.Text = ""
                txtDescripcionSubArea.Text = ""
            End Try
        Else
            lblCodeSubArea.Text = ""
            txtDescripcionSubArea.Text = ""
        End If
    End Sub

    'Private Sub txtTecnico_TextChanged(sender As Object, e As EventArgs)
    '    If (Trim(txtTecnico.Text) <> "") Then
    '        Try
    '            With objUser
    '                .Usuario_ = txtTecnico.Text
    '            End With
    '            Dim dt As New DataTable
    '            dt = objUser.LoginPass()
    '            Dim row As DataRow = dt.Rows(0)
    '            txtDescripcionTecnico.Text = "Correcto"
    '            lblCodeTecnico.Text = CStr(row("cod_usuario"))
    '        Catch ex As Exception
    '            lblCodeTecnico.Text = ""
    '            txtDescripcionTecnico.Text = "Incorrecto"
    '        End Try
    '    Else
    '        lblCodeTecnico.Text = ""
    '        txtDescripcionTecnico.Text = ""
    '    End If
    'End Sub

    Private Sub txtSucursal_TextChanged(sender As Object, e As EventArgs) Handles txtSucursal.TextChanged
        If (Trim(txtSucursal.Text) <> "") Then
            Try
                With objSuc
                    .codigoSucursal_ = txtSucursal.Text
                End With
                Dim dt As New DataTable
                dt = objSuc.BuscarSucursalCode()
                Dim row As DataRow = dt.Rows(0)
                txtDescripcionSucursal.Text = CStr(row("nombre"))
                lblCodeSucursal.Text = CStr(row("codigo"))
            Catch ex As Exception
                lblCodeSucursal.Text = ""
                txtDescripcionSucursal.Text = ""
            End Try
        Else
            lblCodeSucursal.Text = ""
            txtDescripcionSucursal.Text = ""
        End If
    End Sub

    Private Sub btnSubarea_Click(sender As Object, e As EventArgs) Handles btnSubarea.Click
        E_ListarSubAreas.lblform.Text = "E_EspecificarHojaTrabajo"
        E_ListarSubAreas.ShowDialog()
    End Sub

    Private Sub btnTecnico_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        M_Sucursal.lblform.Text = "E_EspecificarHojaTrabajo"
        M_Sucursal.ShowDialog()
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        'If Trim(txtDescripcionSubArea.Text) <> "" And Trim(txtDescripcionSucursal.Text) <> "" And Trim(txtDescripcionTecnico.Text) = "Correcto" Then
        If Trim(txtDescripcionSubArea.Text) <> "" And Trim(txtDescripcionSucursal.Text) <> "" Then

            Try
                E_HojaTrabajo.txtsucursal.Text = txtDescripcionSucursal.Text
                E_HojaTrabajo.txtSubarea.Text = txtDescripcionSubArea.Text
                E_HojaTrabajo.txtArea.Text = lblCodigoGrupo.Text
                E_HojaTrabajo.lblCodeSucursal.Text = lblCodeSucursal.Text
                E_HojaTrabajo.lblCodeSubArea.Text = lblCodeSubArea.Text

                GenerarTablaHojaTrabajo()
                E_HojaTrabajo.ShowDialog()


            Catch ex As Exception
                MsgBox("Al abrir " & ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        Else
            MsgBox("Debe ingresar la sucursal y subárea.", MsgBoxStyle.Information)
        End If
    End Sub
    Private Function CalcularEdad(ByVal fecha As Date) As String
        Dim yr As Integer = DateDiff(DateInterval.Year, fecha, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, fecha, Now)
        Dim day As Integer = DateDiff(DateInterval.Day, fecha, Now)
        Dim edad As String = ""

        If (Now.Month < fecha.Month) Then
            yr -= 1
        ElseIf (Now.Month = fecha.Month And Now.Day < fecha.Day) Then
            yr -= 1
        End If

        If (yr = 0 And month = 1 And Now.Day < fecha.Day) Then
            month -= 1
        End If

        If (yr >= 1) Then
            edad = yr & "a"
        ElseIf (yr = 0 And month > 0) Then
            edad = month & "m"
        Else
            edad = day & "d"
        End If

        'retorna la edad 
        Return edad
    End Function
    Private Sub LlenadoDatos()
        Try
            Dim edad As String
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim row As DataRow

            'LLENADO DE FILAS
            E_HojaTrabajo.ds = ds


            Dim colColl As DataColumnCollection = ds.Tables("HojaTrabajo").Columns


            'orden de trabajo
            Dim objOrdTrab As New ClsOrdenDeTrabajo
            'Dim dt As New DataTable ' ordenes de trabajo
            Dim rowO As DataRow ' fila orden de trabajo

            'detalle orden de trabajo
            Dim objOrdTrabDet As New ClsOrdenTrabajoDetalle
            Dim dtDet As New DataTable ' detalle orden de trabajo
            Dim rowDet As DataRow ' fila detalle orden de trabajo

            'parametros de busqueda
            With objOrdTrab
                .codigoSucursal_ = lblCodeSucursal.Text
                .codigoSubArea_ = lblCodeSubArea.Text
            End With
            dt = objOrdTrab.BuscarHojaDeTrabajo

            For index As Integer = 0 To dt.Rows.Count - 1
                rowO = dt.Rows(index)
                edad = CalcularEdad(Convert.ToDateTime(rowO("fechaNacimiento")))

                row = ds.Tables("HojaTrabajo").Rows.Add

                row.Item(0) = CStr(rowO("cod_orden_trabajo"))
                If rowO("estadoFactura") = "0" Then
                    row.Item(1) = CStr(rowO("paciente"))
                    row.Item(colColl.IndexOf("Estado")) = CStr(rowO("estado"))
                Else
                    row.Item(1) = CStr(rowO("paciente") & " (ANULADA)")
                    row.Item(colColl.IndexOf("Estado")) = "ANULADA"
                End If
                row.Item(2) = edad
                row.Item(3) = CStr(rowO("genero"))
                row.Item(4) = CStr(rowO("medico"))

                'LLENADO DETALLE ORDEN DE TRABAJO
                objOrdTrabDet.cod_orden_trabajo_ = Convert.ToInt64(rowO("cod_orden_trabajo"))
                dtDet = objOrdTrabDet.BuscarOrdenTrabajoDetalle
                For index2 As Integer = 0 To dtDet.Rows.Count - 1
                    rowDet = dtDet.Rows(index2)
                    'marcar los * 

                    If IsDBNull(rowDet("resultado")) = True Then
                        row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = "*"
                    ElseIf CStr(rowDet("resultado")) = "0" Then
                        row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = "*"
                        'row.Item(CStr(rowDet("nombre"))) = "*"
                        'row.Item(row.Table.Columns.IndexOf(CStr(rowDet("nombre")))) = "*"
                    Else
                        row.Item(colColl.IndexOf(CStr(rowDet("nombre")))) = CStr(rowDet("resultado"))
                        'row.Item(CStr(rowDet("nombre"))) = CStr(rowDet("resultado"))
                        'row.Item(row.Table.Columns.IndexOf(CStr(rowDet("nombre")))) = CStr(rowDet("resultado"))
                    End If
                Next
            Next

            'le asigno la tabla
            E_HojaTrabajo.dgvHojaTrab.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("llenado de datos. " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GenerarTablaHojaTrabajo1()

        Dim ds As New DataSet 'Orden de los examenes por grupo o laboratorio
        Try
            ' Add Table
            ds.Tables.Add("HojaTrabajo")

            ' Add Columns
            Dim col As DataColumn

            col = New DataColumn("Orden #")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Paciente")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Edad")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Sexo")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Medico")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            Dim dt As New DataTable
            Dim row As DataRow
            Dim objItemDet As New ClsItemExamenDetalle
            objItemDet.codigoSubArea_ = lblCodeSubArea.Text
            dt = objItemDet.BuscarItemExamenDetalleSubArea()

            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                col = New DataColumn(CStr(row("nombre")))
                ds.Tables("HojaTrabajo").Columns.Add(col)
                'dtResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("codigoUnidad")), CStr(row("unidad_codigo_breve"))})
            Next

            col = New DataColumn("Estado")
            'col.ReadOnly = True
            ds.Tables("HojaTrabajo").Columns.Add(col)

            'le asigno la tabla
            E_HojaTrabajo.dgvHojaTrab.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try

    End Sub
    Private Sub GenerarTablaHojaTrabajo()

        Dim ds As New DataSet  'Orden de los examenes por grupo o laboratorio
        Try

            'LLENADO DE COLUMNAS

            ' Add Table
            ds.Tables.Add("HojaTrabajo")

            ' Add Columns
            Dim col As DataColumn

            col = New DataColumn("Orden #")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Paciente")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Edad")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Genero")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            col = New DataColumn("Medico")
            ds.Tables("HojaTrabajo").Columns.Add(col)

            Dim dt As New DataTable
            Dim row As DataRow
            Dim objItemDet As New ClsItemExamenDetalle
            objItemDet.codigoSubArea_ = lblCodeSubArea.Text
            dt = objItemDet.BuscarItemExamenDetalleSubArea()

            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                col = New DataColumn(CStr(row("nombre")))
                ds.Tables("HojaTrabajo").Columns.Add(col)
                'dtResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("codigoUnidad")), CStr(row("unidad_codigo_breve"))})
            Next

            col = New DataColumn("Estado")
            'col.ReadOnly = True
            ds.Tables("HojaTrabajo").Columns.Add(col)

            'Asigna la creacion de la hoja de trabajo al dataset
            E_HojaTrabajo.ds = ds

            'le asigno la tabla
            E_HojaTrabajo.dgvHojaTrab.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Validación")
        End Try

    End Sub

    Private Sub E_EspecificarHojaTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtTecnico.Text = Form1.lblMiUser.Text
        txtSubArea.ResetText()
        txtSucursal.ResetText()
    End Sub
End Class