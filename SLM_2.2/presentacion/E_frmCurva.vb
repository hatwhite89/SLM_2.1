Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class E_frmCurva
    Dim sCommand As SqlCommand
    Dim sAdapter As SqlDataAdapter
    Dim sBuilder As SqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable
    Private Sub E_frmCurva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnn3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim clsC As New ClsConnection
        cnn3.ConnectionString = clsC.str_con
        cmd3.Connection = cnn3

        Dim tblFields As String = "select i.codigo,h.hora, ot.cod_orden_trabajo,ie.descripcion,i.nombre,
SUBSTRING (ot.resultado, 0, Len(ot.resultado) - 1 ) as resultado  from OrdenTrabajoDetalle ot, ItemExamenDetalle i,Item_Examenes ie,HorasParametros h
where ot.cod_item_examen_detalle = i.codigo and ie.codItemExa = i.codigoItemExamen
and i.codigo = h.id_parametro
and ot.cod_orden_trabajo =1203 
order by h.hora"
        Dim oData As New SqlDataAdapter(tblFields, cnn3)
        Dim ds As New DataSet
        Dim oCmd As New SqlCommand(tblFields, cnn3)




        cnn3.Open()
        oData.Fill(ds, "tblTagInfo")
        cnn3.Close()

        Chart1.DataSource = ds.Tables("tblTagInfo")
        Dim Series1 As Series = Chart1.Series("Series1")
        Series1.Name = "Examen 2"

        Chart1.Series(Series1.Name).XValueMember = "hora"
        Chart1.Series(Series1.Name).YValueMembers = "resultado"

        Dim Series2 As Series = Chart1.Series("Series2")
        Series2.Name = "Examen 1"
        Chart1.Series(Series2.Name).XValueMember = "hora"
        Chart1.Series(Series2.Name).YValueMembers = "resultado"



        alternarColoFilasDatagridview(DataGridView1)
        cargarDataTolerancia()
    End Sub
    Private Sub cargarDataTolerancia()
        Dim clsOCOB As New ClsResultados
        Dim dv As DataView = clsOCOB.RecuperarToleranciaInsulina().DefaultView

        'dv.RowFilter = String.Format("CONVERT(lote+nombre_producto+id_producto, System.String) LIKE '%{0}%'", TextBox2.Text)
        DataGridView1.DataSource = dv

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False

        ListView1.DataBindings()
    End Sub
End Class