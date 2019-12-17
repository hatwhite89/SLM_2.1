Public Class A_ListadoCheques

    Dim cheque As New ClsCheques
    Private Sub A_ListadoCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtCheques.DataSource = cheque.listarCheques

        Catch ex As Exception
            MsgBox("Hubo un error al intentar listar los cheques. Detalle: " + ex.Message)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        txtBusqueda.Text = ""
        dtCheques.DataSource = cheque.listarCheques

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged

        Try
            Dim Dato As New DataView
            'Actualizar datos en datagrid con textbox
            With cheque

                .Numero_Cheque = txtBusqueda.Text
                .Nombre_Proveedor = txtBusqueda.Text

                Dato = cheque.buscarCheques.DefaultView
                dtCheques.DataSource = Dato

            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub A_ListadoCheques_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As Object, e As EventArgs) Handles txtBusqueda.MouseHover
        ttBusqueda.SetToolTip(txtBusqueda, "Ingrese el Nro.Cheque o Nombre de Proveedor")
        ttBusqueda.ToolTipTitle = "Búsqueda"
        ttBusqueda.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class