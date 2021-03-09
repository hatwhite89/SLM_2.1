Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class E_frmCurva
    Dim sCommand As SqlCommand
    Dim sAdapter As SqlDataAdapter
    Dim sBuilder As SqlCommandBuilder
    Public respuesta As SqlDataReader
    Dim sDs As DataSet
    Public enunciado As SqlCommand
    Dim sTable As DataTable
    Private Sub E_frmCurva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = id_examen_curva
        alternarColoFilasDatagridview(DataGridView1)
        cargarDataTolerancia()
        generarGrafica()
    End Sub

    Public Sub cargarDataGlucosa()

    End Sub
    Public Sub generarGrafica()

        Dim cnn3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim clsC As New ClsConnection
        cnn3.ConnectionString = clsC.str_con
        cmd3.Connection = cnn3

        Dim tblFields As String = "select i.codigo,h.hora, ot.cod_orden_trabajo,ie.descripcion,i.nombre,
SUBSTRING (ot.resultado, 0, Len(ot.resultado) - 1 ) as resultado  from OrdenTrabajoDetalle ot, ItemExamenDetalle i,Item_Examenes ie,HorasParametros h
where ot.cod_item_examen_detalle = i.codigo and ie.codItemExa = i.codigoItemExamen
and i.codigo = h.id_parametro
and ot.cod_orden_trabajo ='" + TextBox1.Text + "' 
order by h.hora"
        Dim oData As New SqlDataAdapter(tblFields, cnn3)
        Dim ds As New DataSet
        Dim oCmd As New SqlCommand(tblFields, cnn3)




        cnn3.Open()
        oData.Fill(ds, "tblTagInfo")
        cnn3.Close()

        Chart1.DataSource = ds.Tables("tblTagInfo")
        Dim Series1 As Series = Chart1.Series("Series1")


        Chart1.Series(Series1.Name).XValueMember = "hora"
        Chart1.Series(Series1.Name).YValueMembers = "resultado"

        Dim Series2 As Series = Chart1.Series("Series2")

        Chart1.Series(Series2.Name).XValueMember = "hora"
        Chart1.Series(Series2.Name).YValueMembers = "resultado"

        Chart1.ChartAreas(0).AxisX.Title = "Hora"
        Chart1.ChartAreas(0).AxisY.Title = "Glicemia"

        Chart1.Series("Series1").BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Dash
        Chart1.Series("Series1").BorderWidth = 2
        Chart1.Series("Series2").BorderWidth = 2
        Chart1.Series("Series1").Color = Color.OrangeRed

        Chart1.Series("Series1").MarkerStyle = MarkerStyle.Diamond
        Chart1.Series("Series1").MarkerColor = Color.Black
        Chart1.Series("Series1").MarkerBorderColor = Color.Black
        Chart1.Series("Series1").MarkerSize = 7

        Chart1.Series("Series1").IsVisibleInLegend = True
        'Chart1.Series(0).Points(0).AxisLabel.ToString()
    End Sub

    Private Sub cargarDataTolerancia()
        Dim clsOCOB As New ClsResultados
        Dim dv As DataView
        Try
            dv = clsOCOB.RecuperarToleranciaInsulina(TextBox1.Text).DefaultView
        Catch ex As Exception

        End Try


        'dv.RowFilter = String.Format("CONVERT(lote+nombre_producto+id_producto, System.String) LIKE '%{0}%'", TextBox2.Text)
        DataGridView1.DataSource = dv

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False

        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select  ot.cod_orden_trabajo,f.numero,s.nombre,c.nombreCompleto as 
paciente,c.genero,c.fechaNacimiento,m.nombre_completo as medico
from OrdenDeTrabajo ot, Factura f,cliente c,Sede s,Medico m
where ot.cod_factura = f.numero and f.codigoCliente =c.codigo and s.codigo =ot.cod_sede and m.codigo = f.codigoMedico
and ot.cod_orden_trabajo ='" + TextBox1.Text + "'", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                TextBox1.Text = respuesta.Item("cod_orden_trabajo")
                TextBox2.Text = respuesta.Item("paciente")
                TextBox3.Text = respuesta.Item("medico")
                TextBox4.Text = respuesta.Item("nombre")
                TextBox5.Text = respuesta.Item("genero")
                TextBox6.Text = DateDiff("yyyy", CDate(respuesta.Item("fechaNacimiento")), Date.Now)

            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
End Class