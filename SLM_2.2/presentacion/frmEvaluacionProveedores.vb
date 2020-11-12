Imports System.Data.SqlClient

Public Class frmEvaluacionProveedores
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcal1.Text = "" Or txtcal2.Text = "" Or txtcal3.Text = "" Or txtcal4.Text = "" Or txtcal5.Text = "" Or txtcal6.Text = "" Or txtcal7.Text = "" Or txtcal8.Text = "" Or txtcal9.Text = "" Or txtcal10.Text = "" Or txtcal11.Text = "" Then
            MsgBox("Debe agregar todas las calificaciones")
            Exit Sub
        End If
        Promediar()
        Dim cls As New clsCalificicacionProveedores
        With cls
            .Id12 = txtcal1.Text
            .Id21 = txtcal2.Text
            .Id31 = txtcal3.Text
            .Id41 = txtcal4.Text
            .Id51 = txtcal5.Text
            .Id61 = txtcal6.Text
            .Id71 = txtcal7.Text
            .Id81 = txtcal8.Text
            .Id91 = txtcal9.Text
            .Id101 = txtcal10.Text
            .Id111 = txtcal11.Text
            .Id_oc1 = TextBox1.Text
            .Id_proveedor1 = cod_proveedor
            .Id_usuario1 = codigo_usuario
            .Id_departamento2 = ComboBox1.SelectedValue


        End With
        If cls.RegistraCalificacion() = "1" Then
            MsgBox("Registrado exitosamente")
            Button1.Enabled = False
        End If
    End Sub
    Public Sub Promediar()
        Dim contador As Integer
        Dim denominador As Integer

        If txtcal1.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal2.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal3.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal4.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal5.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal6.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal7.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal8.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal9.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal10.Text <> "0" Then
            contador = contador + 100
        End If
        If txtcal11.Text <> "0" Then
            contador = contador + 100
        End If

        Try
            Dim nota As Double
            nota = ((Integer.Parse(txtcal1.Text) + Integer.Parse(txtcal2.Text) + Integer.Parse(txtcal3.Text) + Integer.Parse(txtcal4.Text) + Integer.Parse(txtcal5.Text) + Integer.Parse(txtcal6.Text) + Integer.Parse(txtcal7.Text) + Integer.Parse(txtcal8.Text) + Integer.Parse(txtcal9.Text) + Integer.Parse(txtcal10.Text) + Integer.Parse(txtcal11.Text)) / contador) * 100
            Label37.Text = nota
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button1.Enabled = False
        Try
            Dim objP As New ClsEvaluacionProveedor
            With objP
                .Id_oc1 = TextBox1.Text
            End With
            Dim dt As New DataTable
            dt = objP.validarOrdenCompra(TextBox1.Text)
            Dim row As DataRow = dt.Rows(0)

            TextBox3.Text = CStr(row("id_oc"))


        Catch ex As Exception
            TextBox3.Text = ""

        End Try

        If TextBox3.Text = "" Then
            Try
                Dim objP As New ClsEvaluacionProveedor
                With objP
                    .Id_oc1 = TextBox1.Text
                End With
                Dim dt As New DataTable
                dt = objP.listarProveedoresOC2(TextBox1.Text)
                Dim row As DataRow = dt.Rows(0)

                TextBox2.Text = CStr(row("nombreProveedor"))

                Button1.Enabled = True


            Catch ex As Exception


            End Try
        Else
            MsgBox("Esta Orden de compra ya se encuentra calificada")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)


    End Sub


    Public Sub sumarData()

        Dim existencia, Total, precio As Double
        Dim cantidad, contador As Integer

        contador = -1
        For Each row As DataGridViewRow In Me.DataGridView1.Rows

            cantidad += Val(row.Cells(6).Value)
            contador += 1
        Next
        Label12.Text = (cantidad / contador).ToString


    End Sub

    Private Sub frmEvaluacionProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColoFilasDatagridview(DataGridView1)
        autoCompletarTexbox(TextBox6)

        Dim clsD As New ClsDepartamento

        Dim ds As New DataTable


        ds.Load(clsD.RecuperarDepartamentos)

        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "nombre"
        ComboBox1.ValueMember = "codigo"
    End Sub
    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=10.172.3.10; Initial Catalog=slm_test; Min Pool Size=0; Max Pool Size=1024; Pooling=true; User Id=sa; Password=Lbm2019")
            conexiones.Open()
            MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select * from Proveedor", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombreProveedor"))

            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim cls As New ClsEvaluacionProveedor
        TextBox7.Text = cls.RecuperarCodigoProveedor2(TextBox6.Text)

        Try
            Dim clsDeOC As New ClsEvaluacionProveedor
            Dim dvOC As DataView = clsDeOC.calcularEvaluacion(TextBox7.Text).DefaultView
            DataGridView1.DataSource = dvOC
            sumarData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class