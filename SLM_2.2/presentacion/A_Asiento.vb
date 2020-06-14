Public Class frmAsientos
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Cerrar Ventana de Asientos
        Me.Close()
    End Sub

    Private Sub frmAsientos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            alternarColoFilasDatagridview(dtDetalleAsiento)

            If txtNro.Text = "" Then

                MsgBox("El registro de hará bajo el periodo contable vigente.")
                txtNro.Enabled = True

            Else

                Dim Detalle As New ClsDetalleAsiento

                With Detalle

                    .Cod_Asiento = Convert.ToInt32(lblCodAsiento.Text)

                    Dim dt As DataTable
                    Dim row As DataRow

                    dt = .VerDetalleAsiento

                    For index As Integer = 0 To dt.Rows.Count - 1
                        row = dt.Rows(index)

                        Dim cuenta As New ClsCuenta
                        Dim data As DataTable
                        Dim rows As DataRow

                        cuenta.Cuent_a = Convert.ToInt32(row("cuenta"))

                        data = cuenta.Comprobar
                        rows = data.Rows(0)

                        dtDetalleAsiento.Rows.Add(New String() {(row("cuenta")), CStr(rows("nombre")), CStr(row("debe")), CStr(row("haber"))})

                    Next

                End With

                'Suma de columna Debe
                Dim Total As Single
                Dim Col As Integer = 2
                For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                    Total += Val(row.Cells(2).Value)
                Next
                txtTotalDebe.Text = Total.ToString

                'Suma de columna Haber
                Dim Total2 As Single
                Dim Col2 As Integer = 3
                For Each row As DataGridViewRow In dtDetalleAsiento.Rows
                    Total2 += Val(row.Cells(3).Value)
                Next
                txtTotalHaber.Text = Total2.ToString
            End If


        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
        End Try

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        If lblForm.Text <> "Listado" Then
            Me.Close()
        Else
            A_ListadoAsientos.Show()
            Me.Close()

        End If

    End Sub

    Sub Limpiar()

        txtNro.Clear()
        txtTexto.Clear()
        dtpFecha.ResetText()
        dtDetalleAsiento.Rows.Clear()
        lblCodAsiento.Text = "-"
        txtTotalDebe.Clear()
        txtTotalHaber.Clear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


        Try
            Dim asiento As New ClsAsientoContable
            Dim dasiento As New ClsDetalleAsiento
            Dim dt As New DataTable
            Dim row As DataRow

            With asiento

                .Cod_Periodo = 1
                .Descrip = txtTexto.Text
                .Fecha_ = dtpFecha.Value
                .Campo_Llave = 0

                .registrarAsiento()

                dt = .capturarCodAsiento()
                row = dt.Rows(0)

                lblCodAsiento.Text = row("cod_asiento")
                txtNro.Text = row("cod_asiento")
                txtTexto.Text = row("descripcion")
                dtpFecha.Value = row("fecha")

            End With



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class