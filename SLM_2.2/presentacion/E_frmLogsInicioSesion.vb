Public Class E_frmLogsInicioSesion
    Private Sub E_frmLogsInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
    End Sub
    Public Sub cargarData()
        Try
            Dim clsDeOC As New clsLogs
            Dim dvOC As DataView = clsDeOC.CargarLogs(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView
            DataGridView1.DataSource = dvOC
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargarData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GridAExcel_global(DataGridView1)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim objOrd As New clsLogs


        Dim dv As DataView = objOrd.CargarLogs(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView

        dv.RowFilter = String.Format("CONVERT(usuario, System.String) LIKE '%{0}%'", TextBox1.Text)

        DataGridView1.DataSource = dv

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim objOrd As New clsLogs


        Dim dv As DataView = objOrd.CargarLogs(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView

        dv.RowFilter = String.Format("CONVERT(ip, System.String) LIKE '%{0}%'", TextBox2.Text)

        DataGridView1.DataSource = dv
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim objOrd As New clsLogs


        Dim dv As DataView = objOrd.CargarLogs(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView

        dv.RowFilter = String.Format("CONVERT(accion, System.String) LIKE '%{0}%'", ComboBox1.SelectedText)

        DataGridView1.DataSource = dv
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim objOrd As New clsLogs


        Dim dv As DataView = objOrd.CargarLogs(DateTimePicker1.Value, DateTimePicker2.Value).DefaultView

        dv.RowFilter = String.Format("CONVERT(accion, System.String) LIKE '%{0}%'", ComboBox1.SelectedText)

        DataGridView1.DataSource = dv
    End Sub
End Class