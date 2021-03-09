Imports System.Data.SqlClient

Public Class E_frmGraficaEstatica
    Dim sCommand As SqlCommand
    Dim sAdapter As SqlDataAdapter
    Dim sBuilder As SqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable
    Private Sub E_frmGraficaEstatica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Slm_testDataSet3._DATOS_' Puede moverla o quitarla según sea necesario.
        ' Me.DATOS_TableAdapter.Fill(Me.Slm_testDataSet3._DATOS_)

        'otros datos





        For xx As Integer = 0 To DataGridView1.Rows.Count - 1

            'Chart1.Series("Series1").Points.AddXY(DataGridView1.Columns(0).HeaderText, DataGridView1.Rows(xx).Cells(1).Value)

            'Chart1.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
            'Chart1.Series("Series1").Color = Color.Black

            'Chart1.Series("Series2").Points.AddXY(DataGridView1.Columns(0).HeaderText, DataGridView1.Rows(xx).Cells(2).Value)
            'Chart1.Series("Series2").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            'Chart1.Series("Series2").Color = Color.Black

            'Chart1.Series("Series3").Points.AddXY(DataGridView1.Columns(0).HeaderText, DataGridView1.Rows(xx).Cells(3).Value)
            'Chart1.Series("Series3").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            'Chart1.Series("Series3").Color = Color.Black

            'Chart1.Series("Series4").Points.AddXY(DataGridView1.Columns(0).HeaderText, DataGridView1.Rows(xx).Cells(4).Value)
            'Chart1.Series("Series4").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            'Chart1.Series("Series4").Color = Color.Black

            'Chart1.Series("Series5").Points.AddXY(DataGridView1.Columns(0).HeaderText, DataGridView1.Rows(xx).Cells(5).Value)
            'Chart1.Series("Series5").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            'Chart1.Series("Series5").Color = Color.Blue



            'Chart1.Series("Series6").Points.AddXY(DataGridView1.Columns(0).HeaderText, DataGridView1.Rows(xx).Cells(6).Value)
            'Chart1.Series("Series6").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
            'Chart1.Series("Series6").Color = Color.Red
            'Chart1.Series("Series6").Font = Font.Bold = True

        Next

        alternarColoFilasDatagridview(DataGridView1)
    End Sub

    Private Sub CargarData()
        Dim clsc As New ClsConnection
        'Dim connectionString As String = "Data Source=.;Initial Catalog=pubs;Integrated Security=True"
        Dim sql As String = "SELECT * FROM DatosGrafica where id_orden ='" + TextBox1.Text + "'"
        Dim connection As New SqlConnection(clsc.str_con)
        connection.Open()
        sCommand = New SqlCommand(sql, connection)
        sAdapter = New SqlDataAdapter(sCommand)
        sBuilder = New SqlCommandBuilder(sAdapter)
        sDs = New DataSet()
        sAdapter.Fill(sDs, "DatosGrafica$")
        sTable = sDs.Tables("DatosGrafica$")
        connection.Close()
        DataGridView1.DataSource = sDs.Tables("DatosGrafica$")
        DataGridView1.ReadOnly = False
        save_btn.Enabled = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sAdapter.Update(sTable)
            DataGridView1.[ReadOnly] = False
            save_btn.Enabled = True
            CargarData()
        Catch ex As Exception

        End Try

        'new_btn.Enabled = True
        'delete_btn.Enabled = True
    End Sub

    Private Sub new_btn_Click(sender As Object, e As EventArgs)
        DataGridView1.[ReadOnly] = False
        save_btn.Enabled = True

        ' delete_btn.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim clsA As New clsInventario
        Dim dvOC As DataTable = clsA.DatosGrafica(TextBox1.Text)
        Try
            CargarData()
        Catch ex As Exception

        End Try

        Chart1.DataSource = dvOC
        Chart1.Titles.Clear()

        Chart1.Series("Series1").YValueMembers = "f2"
        Chart1.Series("Series2").YValueMembers = "f3"
        Chart1.Series("Series3").YValueMembers = "f4"
        Chart1.Series("Series4").YValueMembers = "f5"
        Chart1.Series("Series5").YValueMembers = "f6"
        Chart1.Series("Series6").YValueMembers = "f7"

        Chart1.Series("Series1").XValueMember = "f1"
        Chart1.Series("Series2").XValueMember = "f1"
        Chart1.Series("Series3").XValueMember = "f1"
        Chart1.Series("Series4").XValueMember = "f1"
        Chart1.Series("Series5").XValueMember = "f1"
        Chart1.Series("Series6").XValueMember = "f1"

        Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("Series2").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("Series3").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("Series4").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("Series5").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series("Series6").ChartType = DataVisualization.Charting.SeriesChartType.Line

        Chart1.Series("Series2").BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
        Chart1.Series("Series3").BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Dash

        'colores
        Chart1.Series("Series1").Color = Color.Black
        Chart1.Series("Series2").Color = Color.Black
        Chart1.Series("Series3").Color = Color.Black
        Chart1.Series("Series4").Color = Color.Black
        Chart1.Series("Series5").Color = Color.Cyan
        Chart1.Series("Series6").Color = Color.Red
        'bordes
        Chart1.Series("Series1").BorderWidth = 3
        Chart1.Series("Series2").BorderWidth = 3
        Chart1.Series("Series3").BorderWidth = 3
        Chart1.Series("Series4").BorderWidth = 3
        Chart1.Series("Series5").BorderWidth = 3
        Chart1.Series("Series6").BorderWidth = 3

        Chart1.DataBind()
        Chart1.Titles.Add("FRAGILIDAD OSMOTICA")
        Chart1.ChartAreas(0).AxisX.Title = "% NaCL"
        Chart1.ChartAreas(0).AxisY.Title = "% HEMOLISIS"
        DataGridView1.Columns(0).Visible = False

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class