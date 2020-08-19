Public Class E_frmProcesarSolicitudInterna
    Private Sub E_frmProcesarSolicitudInterna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarMisSolicitudes()
    End Sub

    Private Sub CargarMisSolicitudes()
        Try
            Dim clsOCOB As New clsOrdenInterna
            Dim dvOC As DataView = clsOCOB.TodasSolicitudes().DefaultView
            DataGridView3.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick

    End Sub

    Private Sub cargarDetalleSolicitudes(ByVal id As String)
        Try
            Dim clsOI As New clsOrdenInterna
            Dim dvOC As DataView = clsOI.listarDetallesMisSolicitudes(id).DefaultView

            DataGridView4.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cargarDetalleSolicitudes2(ByVal id As String)
        Try
            Dim clsOI As New clsOrdenInterna
            Dim dvOC As DataView = clsOI.listarDetallesMisSolicitudes(id).DefaultView

            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            cargarDetalleSolicitudes(DataGridView3.Rows(e.RowIndex).Cells(0).Value)

            TextBox1.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value

            If DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString = "creado" Then
                RadioButton1.Checked = True
                RadioButton2.Checked = False
                RadioButton3.Checked = False
            End If
            If DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString = "Procesado" Then
                RadioButton1.Checked = False
                RadioButton2.Checked = True
                RadioButton3.Checked = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim clsOI As New clsOrdenInterna
        Dim estado As String = ""
        If RadioButton1.Checked = True Then
            estado = "creado"
        ElseIf RadioButton2.Checked = True Then
            estado = "Procesado"
        ElseIf RadioButton3.Checked = True Then
            estado = "Cerrado"
        End If

        Try
            With clsOI
                .Id_oi1 = TextBox1.Text
                .Estado1 = estado
            End With
            If clsOI.ActualizarEstadoOrdenInterna() = "1" Then
                MsgBox("Se actualizo el estado a " + estado)
                DataGridView3.Columns.Clear()
                CargarMisSolicitudes()
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar una orden interna")
        End Try


    End Sub
    Private Sub CargarDGOCFecha()
        Try
            Dim clsOCOB As New clsOrdenInterna
            Dim dvOC As DataView = clsOCOB.SolicitudesFechaCerradas(DateTimePicker1.Value.Date, DateTimePicker3.Value.Date).DefaultView
            DataGridView2.DataSource = dvOC
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CargarDGOCFecha()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        cargarDetalleSolicitudes2(DataGridView2.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class