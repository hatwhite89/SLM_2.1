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

    Private Sub txtTecnico_TextChanged(sender As Object, e As EventArgs) Handles txtTecnico.TextChanged
        If (Trim(txtTecnico.Text) <> "") Then
            Try
                With objUser
                    .Usuario_ = txtTecnico.Text
                End With
                Dim dt As New DataTable
                dt = objUser.LoginPass()
                Dim row As DataRow = dt.Rows(0)
                txtDescripcionTecnico.Text = "Correcto"
                lblCodeTecnico.Text = CStr(row("cod_usuario"))
            Catch ex As Exception
                lblCodeTecnico.Text = ""
                txtDescripcionTecnico.Text = "Incorrecto"
            End Try
        Else
            lblCodeTecnico.Text = ""
            txtDescripcionTecnico.Text = ""
        End If
    End Sub

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

    Private Sub btnTecnico_Click(sender As Object, e As EventArgs) Handles btnTecnico.Click

    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        M_Sucursal.lblform.Text = "E_EspecificarHojaTrabajo"
        M_Sucursal.ShowDialog()
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        If Trim(txtDescripcionSubArea.Text) <> "" And Trim(txtDescripcionSucursal.Text) <> "" And Trim(txtDescripcionTecnico.Text) = "Correcto" Then
            Dim objOrdTrab As New ClsOrdenDeTrabajo
            With objOrdTrab
                .codigoSucursal_ = lblCodeSucursal.Text
                .codigoSubArea_ = lblCodeSubArea.Text
            End With
            Try
                'Dim dv As DataView = objOrdTrab.BuscarHojaDeTrabajo.DefaultView
                'E_HojaTrabajo.dgvHojaTrab.DataSource = dv
                'E_HojaTrabajo.dgvHojaTrab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
                E_HojaTrabajo.txtsucursal.Text = txtSucursal.Text
                E_HojaTrabajo.txtSubarea.Text = txtSubArea.Text
                E_HojaTrabajo.txtArea.Text = lblCodigoGrupo.Text


                temp()


                E_HojaTrabajo.ShowDialog()
            Catch ex As Exception
                MsgBox("Al abrir " & ex.Message, MsgBoxStyle.Critical, "Validación")
            End Try
        End If
    End Sub

    Private Sub temp()

        Dim ds As New DataSet 'Orden de los examenes por grupo o laboratorio
        Try
            ' Add Table
            ds.Tables.Add("ListaExamenes")

            ' Add Columns
            Dim col As DataColumn

            col = New DataColumn("Orden #")
            ds.Tables("ListaExamenes").Columns.Add(col)

            col = New DataColumn("Paciente")
            ds.Tables("ListaExamenes").Columns.Add(col)

            col = New DataColumn("Edad")
            ds.Tables("ListaExamenes").Columns.Add(col)

            col = New DataColumn("Sexo")
            ds.Tables("ListaExamenes").Columns.Add(col)

            col = New DataColumn("Medico")
            ds.Tables("ListaExamenes").Columns.Add(col)

            Dim dt As New DataTable
            Dim row As DataRow
            Dim objItemDet As New ClsItemExamenDetalle
            objItemDet.codigoSubArea_ = lblCodeSubArea.Text
            dt = objItemDet.BuscarItemExamenDetalleSubArea()

            For index As Integer = 0 To dt.Rows.Count - 1
                row = dt.Rows(index)
                col = New DataColumn(CStr(row("nombre")))
                ds.Tables("ListaExamenes").Columns.Add(col)
                'dtResultados.Rows.Add(New String() {CStr(row("codigo")), CStr(row("nombre")), CStr(row("codigoUnidad")), CStr(row("unidad_codigo_breve"))})
            Next

            col = New DataColumn("Estado")
            ds.Tables("ListaExamenes").Columns.Add(col)

            'transformar de data a data table
            'dt = ds.Tables(0)

            E_HojaTrabajo.dgvHojaTrab.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("metodo temp " & ex.Message, MsgBoxStyle.Critical, "Validación")

        End Try

    End Sub

End Class