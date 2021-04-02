Public Class E_frmLogsExcepcion
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub E_frmLogsExcepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel_global(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarData()
    End Sub
    Public Sub cargarData()
        Try
            Dim clsDeOC As New clsLogs
            Dim dvOC As DataView = clsDeOC.CargarLogsExcepciones(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim objOrd As New clsLogs


        Dim dv As DataView = objOrd.CargarLogsExcepciones(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView

        dv.RowFilter = String.Format("CONVERT(usuario, System.String) LIKE '%{0}%'", TextBox1.Text)

        DataGridView1.DataSource = dv
    End Sub
End Class