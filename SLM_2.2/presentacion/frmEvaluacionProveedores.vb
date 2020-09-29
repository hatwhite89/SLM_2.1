Imports System.Data.SqlClient

Public Class frmEvaluacionProveedores
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aencuesta1, aencuesta2, aencuesta3, aencuentas4, aencuesta5 As Integer
        Dim bencuesta1, bencuesta2, bencuesta3, bencuentas4, bencuesta5 As Integer
        Dim cencuesta1, cencuesta2, cencuesta3, cencuentas4, cencuesta5 As Integer
        Dim dencuesta1, dencuesta2, dencuesta3, dencuentas4, dencuesta5 As Integer
        Dim eencuesta1, eencuesta2, eencuesta3, eencuentas4, eencuesta5 As Integer

        'estos son los a
        If a1.Checked = True Then
            aencuesta1 = 1
        Else
            aencuesta1 = 0
        End If

        If a2.Checked = True Then
            aencuesta2 = 2
        Else
            aencuesta2 = 0
        End If
        If a3.Checked = True Then
            aencuesta3 = 3
        Else
            aencuesta3 = 0
        End If
        If a4.Checked = True Then
            aencuentas4 = 4
        Else
            aencuentas4 = 0
        End If
        If a5.Checked = True Then
            aencuesta5 = 5
        Else
            aencuesta5 = 0
        End If

        'estos son los b

        If b1.Checked = True Then
            bencuesta1 = 1
        Else
            bencuesta1 = 0
        End If

        If b2.Checked = True Then
            bencuesta2 = 2
        Else
            bencuesta2 = 0
        End If
        If b3.Checked = True Then
            bencuesta3 = 3
        Else
            bencuesta3 = 0
        End If
        If b4.Checked = True Then
            bencuentas4 = 4
        Else
            bencuentas4 = 0
        End If
        If b5.Checked = True Then
            bencuesta5 = 5
        Else
            bencuesta5 = 0
        End If
        'estos son los c

        If c1.Checked = True Then
            cencuesta1 = 1
        Else
            cencuesta1 = 0
        End If

        If c2.Checked = True Then
            cencuesta2 = 2
        Else
            cencuesta2 = 0
        End If
        If c3.Checked = True Then
            cencuesta3 = 3
        Else
            cencuesta3 = 0
        End If
        If c4.Checked = True Then
            cencuentas4 = 4
        Else
            cencuentas4 = 0
        End If
        If c5.Checked = True Then
            cencuesta5 = 5
        Else
            cencuesta5 = 0
        End If
        'estos son los d


        If d1.Checked = True Then
            dencuesta1 = 1
        Else
            dencuesta1 = 0
        End If

        If d2.Checked = True Then
            dencuesta2 = 2
        Else
            dencuesta2 = 0
        End If
        If d3.Checked = True Then
            dencuesta3 = 3
        Else
            dencuesta3 = 0
        End If
        If d4.Checked = True Then
            dencuentas4 = 4
        Else
            dencuentas4 = 0
        End If
        If d5.Checked = True Then
            dencuesta5 = 5
        Else
            dencuesta5 = 0
        End If
        'estos son los 3

        If e1.Checked = True Then
            eencuesta1 = 1
        Else
            eencuesta1 = 0
        End If

        If e2.Checked = True Then
            eencuesta2 = 2
        Else
            eencuesta2 = 0
        End If
        If e3.Checked = True Then
            eencuesta3 = 3
        Else
            eencuesta3 = 0
        End If
        If e4.Checked = True Then
            eencuentas4 = 4
        Else
            eencuentas4 = 0
        End If
        If e5.Checked = True Then
            eencuesta5 = 5
        Else
            eencuesta5 = 0
        End If

        Dim clsE As New ClsEvaluacionProveedor

        With clsE
            .Id_oc1 = TextBox1.Text
            .Aencuesta11 = aencuesta1
            .Aencuesta21 = aencuesta2
            .Aencuesta31 = aencuesta3
            .Aencuentas41 = aencuentas4
            .Aencuesta51 = aencuesta5

            .Bencuesta11 = bencuesta1
            .Bencuesta21 = bencuesta2
            .Bencuesta31 = bencuesta3
            .Bencuentas41 = bencuentas4
            .Bencuesta51 = bencuesta5

            .Cencuesta11 = cencuesta1
            .Cencuesta21 = cencuesta2
            .Cencuesta31 = cencuesta3
            .Cencuentas41 = cencuentas4
            .Cencuesta51 = cencuesta5

            .Dencuesta11 = dencuesta1
            .Dencuesta21 = dencuesta2
            .Dencuesta31 = dencuesta3
            .Dencuentas41 = dencuentas4
            .Dencuesta51 = dencuesta5

            .Eencuesta11 = eencuesta1
            .Eencuesta21 = eencuesta2
            .Eencuesta31 = eencuesta3
            .Eencuentas41 = eencuentas4
            .Eencuesta51 = eencuesta5


        End With

        If clsE.RegistrarEvaluacion() = "1" Then
            MsgBox("Registrado exitosamente")
            a3.Checked = True
            b3.Checked = True
            c3.Checked = True
            d3.Checked = True
            e3.Checked = True
            Button1.Enabled = False

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim objP As New ClsEvaluacionProveedor
            With objP
                .Id_oc1 = TextBox1.Text
            End With
            Dim dt As New DataTable
            dt = objP.validarOrdenCompra(TextBox1.Text)
            Dim row As DataRow = dt.Rows(0)

            TextBox4.Text = CStr(row("id_oc"))

        Catch ex As Exception
            TextBox4.Text = ""

        End Try

        If TextBox4.Text = "" Then
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
                a3.Checked = True
                b3.Checked = True
                c3.Checked = True
                d3.Checked = True
                e3.Checked = True


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
End Class