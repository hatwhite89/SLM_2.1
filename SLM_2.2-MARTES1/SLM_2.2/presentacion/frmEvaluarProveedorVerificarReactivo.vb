Imports System.Data.SqlClient

Public Class frmEvaluarProveedorVerificarReactivo
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""

        Try
            Dim objP As New ClsEvaluacionProveedor
            With objP
                .Id_oc1 = TextBox1.Text
            End With
            Dim dt As New DataTable
            dt = objP.listarProveedoresOC2EvaluacionReacitvos(TextBox1.Text)
            Dim row As DataRow = dt.Rows(0)

            TextBox2.Text = CStr(row("nombreProveedor"))
            TextBox3.Text = CStr(row("fecha_elaboracion"))




        Catch ex As Exception


        End Try
    End Sub

    Private Sub frmEvaluarProveedorVerificarReactivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Text = Date.Now
        autoCompletarTexbox(TextBox4)
    End Sub

    Sub autoCompletarTexbox(ByVal campoTexto As TextBox)
        Dim clsC As New ClsConnection
        Try
            enunciado = New SqlCommand("select * from ProductoAlmacen", clsC.getConexion)
            respuesta = enunciado.ExecuteReader()
            While respuesta.Read
                campoTexto.AutoCompleteCustomSource.Add(respuesta.Item("nombre_producto"))

            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' TextBox5.Text = DateDiff("m", Now, DateTimePicker1.Value)
        TextBox6.Text = ((DateTimePicker1.Value.Year - Now.Year) * 12) + DateTimePicker1.Value.Month - Now.Month
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim calificacionEntrega, calificacionTemperatura, calificacionVencimiento, calificacionFechaEntrega, empaque As Integer
        If RadioButton6.Checked = True Then
            calificacionEntrega = 10
        End If
        If RadioButton5.Checked = True Then
            calificacionEntrega = 0
        End If

        If RadioButton1.Checked = True Then
            calificacionTemperatura = 0
        End If
        If RadioButton2.Checked = True Then
            calificacionTemperatura = 30
        End If


        If RadioButton4.Checked = True Then
            calificacionVencimiento = 20
        End If
        If RadioButton3.Checked = True Then
            calificacionVencimiento = 0
        End If

        If RadioButton8.Checked = True Then
            calificacionFechaEntrega = 30
        End If
        If RadioButton7.Checked = True Then
            calificacionFechaEntrega = 0
        End If

        If RadioButton10.Checked = True Then
            empaque = 10
        End If
        If RadioButton9.Checked = True Then
            empaque = 0
        End If
    End Sub
End Class