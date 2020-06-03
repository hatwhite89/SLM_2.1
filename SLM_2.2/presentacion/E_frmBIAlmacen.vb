Public Class E_frmBIAlmacen
    Private Sub E_frmBIAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clsA As New clsInventario
        Dim dvOC As DataTable = clsA.BIAlmacen
        Chart1.DataSource = dvOC
        Chart1.Series("Series1").YValueMembers = "cantidad"
        Chart1.Series("Series1").XValueMember = "nombre_almacen"

        Chart1.DataBind()
        Chart1.Titles.Add("Tamaño almacen segun cantidad de productos")

        'Chart1.Series("Series1").Points.AddXY("Sara", 23)
        'Chart1.Series("Series1").Points.AddXY("Sara", 24)
        'Chart1.Series("Series1").Points.AddXY("Sara", 25)
        'Chart1.Series("Series1").Points.AddXY("Sara", 26)

        ComboBox2.Items.Add("5")
        ComboBox2.Items.Add("10")
        ComboBox2.Items.Add("15")
        ComboBox2.Items.Add("20")
        ComboBox2.Items.Add("25")
        ComboBox2.Items.Add("30")
        ComboAlmacen()
    End Sub
    Private Sub ComboAlmacen()
        Dim clsD As New ClsAlmacen

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarAlmacenes())

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "nombre_almacen"
        ComboBox1.ValueMember = "id_almacen"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim clsA As New clsInventario
            Dim dvOC As DataTable = clsA.BIAlmacen2(ComboBox1.SelectedValue, ComboBox2.SelectedItem)
            Chart2.DataSource = dvOC
            Chart2.Series("Producto").YValueMembers = "cantidad"
            Chart2.Series("Producto").XValueMember = "nombre_producto"

            Chart2.DataBind()

        Catch ex As Exception

        End Try

    End Sub
End Class