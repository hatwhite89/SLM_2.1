Public Class A_ListarExamenes

    Dim item As New ClsItemExamen
    Dim fila As DataRow
    Private Sub A_ListarExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtExamenes.DataSource = item.listarItemExamen

        'Columnas ocultas
        dtExamenes.Columns("codBreve").Visible = False
        dtExamenes.Columns("grupo").Visible = False
        dtExamenes.Columns("precioBase").Visible = False
        dtExamenes.Columns("clasificacion").Visible = False
        dtExamenes.Columns("abreviatura").Visible = False
        dtExamenes.Columns("comentario").Visible = False
        dtExamenes.Columns("estado").Visible = False

        'Propiedades de Columnas
        dtExamenes.Columns("descripcion").Width = 300
        dtExamenes.Columns("descripcion").HeaderText = "Descripción"
        dtExamenes.Columns("codItemExa").HeaderText = "Código"

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim i, rows As Integer
        rows = dtExamenes.Rows.Count - 1

        For i = 0 To rows
                If dtExamenes.Rows(i).Cells(0).Value = True Then
                'Agregar colección de exámenes

                If (A_Promociones.validarDetalle(dtExamenes.Rows(i).Cells(1).Value)) = 0 Then

                    A_Promociones.dtDetallePromo.Rows.Add(dtExamenes.Rows(i).Cells(1).Value, dtExamenes.Rows(i).Cells(3).Value)

                Else
                    MsgBox("El exámen ya ha sido agregado.")
                End If

            End If
            Next

        Me.Close()

    End Sub

    Private Sub dtExamenes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtExamenes.CellContentClick

    End Sub
End Class