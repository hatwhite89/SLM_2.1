Public Class A_BuscarFormaPago

    Private Sub A_BuscarFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            alternarColoFilasDatagridview(dtFormasPago)
            Dim formaPago As New ClsFormaPago
            dtFormasPago.DataSource = formaPago.listarFormaPago


            dtFormasPago.Columns("nroCtaBanco").Visible = False
            dtFormasPago.Columns("codFormaPago").Visible = False
            dtFormasPago.Columns("banco").Visible = False
            dtFormasPago.Columns("cuenta").Visible = False
            dtFormasPago.Columns("comentario").Visible = False
            dtFormasPago.Columns("formulario").Visible = False
            dtFormasPago.Columns("tipo").Visible = False
            dtFormasPago.Columns("banco").Visible = False

        Catch ex As Exception
            MsgBox("Hubo un error al cargar información. " + ex.Message)
        End Try
        'llenar DataGrid de formas de pago


    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        Dim formPago As New ClsFormaPago
        Dim Dato As New DataView

        'Actualizar datos en datagrid con textbox
        formPago.Cod = txtCodigo.Text
        Dato = formPago.buscarCodFormaPago.DefaultView
        dtFormasPago.DataSource = Dato

    End Sub

    Private Sub dtFormasPago_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtFormasPago.CellClick
        Try

            Dim dt As New DataTable
            dt = dtFormasPago.DataSource
            Dim row As DataRow
            row = dt.Rows(e.RowIndex)



            'COPIAR CODIGO DE BANCO
            If lblJC.Text = "1" Then
                frmDeposito.txtBanco.Text = row("codigo")
                frmDeposito.lblCodFPBanco.Text = row("codFormaPago")
                Me.Close()
            ElseIf lblJC.Text = "2" Then
                frmDeposito.txtTipoConta.Text = row("codigo")
                frmDeposito.lblCodFPContado.Text = row("codFormaPago")
                Me.Close()
            ElseIf lblJC.Text = "3" Then
                A_Consolidacion.txtBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(4).Value
                A_Consolidacion.txtCodBanco.Text = dtFormasPago.Rows(e.RowIndex).Cells(0).Value
                Me.Close()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub A_BuscarFormaPago_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub


End Class