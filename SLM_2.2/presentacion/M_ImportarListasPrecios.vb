Imports System.Data.OleDb

Public Class M_ImportarListasPrecios

    Private Sub M_ImportarListasPrecios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
    Sub importarExcel2(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        If myFileDialog.FileName.ToString <> "" Then

            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Ingrese el nombre de la hoja a importar", "Complete")
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Información")
            Finally
                conn.Close()
            End Try

            MsgBox("Se ha cargado la importación correctamente. ", MsgBoxStyle.Information, "Importado con exito")

        Else

            MsgBox("No se logro la importación.")

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        importarExcel2(dtExcel)

        lblCantidadR.Text = dtExcel.Rows.Count - 1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            M_ListaPrecios.dgbtabla.Rows.Clear()
            For fila = 0 To dtExcel.Rows.Count - 2
                M_ListaPrecios.dgbtabla.Rows.Add(New String() {"", "", dtExcel.Rows(fila).Cells(0).Value, dtExcel.Rows(fila).Cells(2).Value, dtExcel.Rows(fila).Cells(3).Value, dtExcel.Rows(fila).Cells(4).Value})
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub M_ImportarListasPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(dtExcel)
    End Sub
End Class