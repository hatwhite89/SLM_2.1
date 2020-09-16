
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Security.Cryptography
Imports System.DirectoryServices


Module ModulosVarios

    '::::::::::::::::::::::::::::: Importar Excel ::::::::::::::::::::::::
    Sub importarExcel(ByVal tabla As DataGridView)
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
                MsgBox("Inserte un nombre válido de la Hoja que desea importar.", MsgBoxStyle.Information, "Información")
            Finally
                conn.Close()
            End Try

            MsgBox("Se ha cargado la importación correctamente. ", MsgBoxStyle.Information, "Importado con exito")

        Else

            MsgBox("No se logro la importación.")

        End If

    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::Final Importar Excel

    '::::::::::::::::::::::::::::: Numeros y Comas :::::::::::::::::::::::::::

    Public CODIGOSEPARADOR As Char = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator


    Sub NUMEROSCOMA(EV As KeyPressEventArgs, DECIMALES As Integer, TXB As TextBox)

        'PALNUMEROS(e, 2, sender)
        'El 2 es la cantidad de decimales 

        If DECIMALES < 0 Then DECIMALES = 0

        If EV.KeyChar = Convert.ToChar(Keys.Return) Then
            EV.Handled = True
            TXB.Focus()
        ElseIf EV.KeyChar = ","c Then
            If (TXB.Text.IndexOf(","c) >= 0) Or (DECIMALES = 0) Then
                EV.Handled = True
            Else
                EV.KeyChar = CODIGOSEPARADOR  REM","c
            End If
        ElseIf EV.KeyChar = "-"c And TXB.TextLength = 0 Then
            EV.KeyChar = "-"c
        ElseIf TXB.Text.IndexOf(","c) > 0 Then
            If (TXB.Text.Length - TXB.Text.IndexOf(","c) > DECIMALES) And (TXB.SelectionStart > TXB.Text.IndexOf(","c)) And (Not (Char.IsControl(EV.KeyChar))) Then
                EV.Handled = True
            End If
        ElseIf Not (Char.IsControl(EV.KeyChar) Or Char.IsDigit(EV.KeyChar)) Then
            EV.Handled = True
        End If
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::Final Numeros y Comas


    '::::::::::::::::::::::::::::: Numeros y Puntos :::::::::::::::::::::::::::

    Public CODIGOSEPARA As Char = System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.CurrencyDecimalSeparator

    Sub NUMEROSPUNTO(EV As KeyPressEventArgs, DECIMALES As Integer, TXB As TextBox)

        'PALNUMEROS(e, 2, sender)
        'El 2 es la cantidad de decimales 

        If DECIMALES < 0 Then DECIMALES = 0

        If EV.KeyChar = Convert.ToChar(Keys.Return) Then
            EV.Handled = True
            TXB.Focus()
        ElseIf EV.KeyChar = "."c Then
            If (TXB.Text.IndexOf(","c) >= 0) Or (DECIMALES = 0) Then
                EV.Handled = True
            Else
                EV.KeyChar = CODIGOSEPARA  REM","c
            End If
        ElseIf EV.KeyChar = "-"c And TXB.TextLength = 0 Then
            EV.KeyChar = "-"c
        ElseIf TXB.Text.IndexOf(","c) > 0 Then
            If (TXB.Text.Length - TXB.Text.IndexOf(","c) > DECIMALES) And (TXB.SelectionStart > TXB.Text.IndexOf(","c)) And (Not (Char.IsControl(EV.KeyChar))) Then
                EV.Handled = True
            End If
        ElseIf Not (Char.IsControl(EV.KeyChar) Or Char.IsDigit(EV.KeyChar)) Then
            EV.Handled = True
        End If
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::Final Numeros y Punto



    ':::::::::::::::::::::::::: ENVIO DE CORREO ELECTRONICO::::::::::::::::::::::::::::
    'Enviar correo Dinamico
    Sub enviarMail(correoSalida As String, pass As String, puerto As Integer, sslOK As Boolean, host As String, correoNoti As String, texto As String)

        'In the shadows of the moon

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(correoSalida, pass)
            Smtp_Server.Port = puerto
            Smtp_Server.EnableSsl = sslOK
            Smtp_Server.Host = host

            e_mail = New MailMessage()
            'txtfrom.text
            e_mail.From = New MailAddress(correoSalida)
            'txtto.text
            e_mail.To.Add(correoNoti)
            e_mail.Subject = "ALERTA DE SISTEMA"
            e_mail.IsBodyHtml = False
            'txtMessage.text
            e_mail.Body = texto
            Smtp_Server.Send(e_mail)

            'omitir mensaje
            MsgBox("Mail Sent")

        Catch ex As Exception
            MsgBox("No se envío el correo. " + ex.Message)
        End Try

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: Final envio de Correo Electronico




    ':::::::::::::::::::::::::::::::::::::: Encriptar Password

    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function
    ':::::::::::::::::::::::::::::::::::::: Final Encriptar Password


    ':::::::::::::::::::::::::::::::::::::: Desencriptar Password

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    ':::::::::::::::::::::::::::::::::::::: Final desencriptar Password



    ':::::::::::::::::::::::::::::::::::::: LOGIN
    Public Function LOGIN(User As String, Password As String)
        Try

            Dim usuario As New ClsUsuario

            With usuario

                .Usuario_ = User
                .password_ = Encriptar(Password)

            End With

            Dim dt As New DataTable
            Dim row As DataRow

            dt = usuario.Login

            If dt.Rows.Count < 0 Then 'Verificar existencia
                MsgBox("Error al ingresar. Verifique usuario y contraseña.")
            Else
                row = dt.Rows(0)
                If row("estado") = 0 Then

                    MsgBox("Su usuario ha sido deshabilitado. Contactar al administrador")

                Else
                    _1A_PantallaCarga.Show()

                    Form1.lblMiUser.Text = User
                    Form1.lblUserCod.Text = row("cod_usuario")
                    nombre_usurio = row("usuario")
                    codigo_usuario = row("cod_usuario")
                    'PERFIL DE USUARIO MODULOS HABILITADOS
                    Dim formulario As New ClsFormularios
                    Dim ventanas As New ClsVentanasModulos

                    With formulario

                        .Cod_Perfil = Convert.ToInt32(row("codPerfil"))

                        Dim dtPerfil, dtVentanas As New DataTable
                        Dim filas As Integer
                        dtPerfil = .formulariosDePerfil()
                        Try


                            'Recorrer Data para habilitar botones
                            For filas = 0 To dtPerfil.Rows.Count


                                If filas = 0 Then 'if conteo filas
                                    If dtPerfil.Rows(filas).Item(2) = True Then 'Permisos en Facturación
                                        Form1.btnFacturacion.Enabled = True

                                        With ventanas
                                            .Cod_Modulo = Convert.ToInt32(dtPerfil.Rows(filas).Item(0).ToString)
                                            dtVentanas = .listarPermisos
                                        End With

                                        For i = 0 To dtVentanas.Rows.Count

                                            If i = 0 Then 'if conteo

                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnFactura.Enabled = True
                                                End If
                                            ElseIf i = 1 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCotizar.Enabled = True
                                                End If

                                            ElseIf i = 2 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnRecibos.Enabled = True
                                                End If
                                            ElseIf i = 3 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnContactos.Enabled = True
                                                End If
                                            ElseIf i = 4 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnItem.Enabled = True
                                                End If
                                            ElseIf i = 5 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnGrupo.Enabled = True
                                                End If
                                            ElseIf i = 6 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnTermino.Enabled = True
                                                End If
                                            ElseIf i = 7 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPacienteF.Enabled = True
                                                End If
                                            ElseIf i = 8 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnApertura.Enabled = True
                                                End If
                                            ElseIf i = 9 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCierreCaja.Enabled = True
                                                End If
                                            ElseIf i = 10 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnArqueos.Enabled = True
                                                End If
                                            ElseIf i = 11 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnDiarioFacturacion.Enabled = True
                                                End If
                                            ElseIf i = 12 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    M_Factura.lblokay.Text = "Cajero"


                                                End If
                                            End If 'if conteo

                                        Next

                                        _1A_PantallaCarga.pBarInicio.Value += 20

                                    End If
                                ElseIf filas = 1 Then 'Permisos en Contabilidad
                                    If dtPerfil.Rows(filas).Item(2) = True Then
                                        Form1.btnContabilidad.Enabled = True

                                        With ventanas
                                            .Cod_Modulo = Convert.ToInt32(dtPerfil.Rows(filas).Item(0).ToString)
                                            dtVentanas = .listarPermisos
                                        End With

                                        For i = 0 To dtVentanas.Rows.Count

                                            If i = 0 Then 'if conteo

                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPrecio.Enabled = True
                                                End If
                                            ElseIf i = 1 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnListaPrecio.Enabled = True
                                                End If

                                            ElseIf i = 2 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnDescuento.Enabled = True
                                                End If
                                            ElseIf i = 3 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPromociones.Enabled = True
                                                End If
                                            ElseIf i = 4 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnConsolidar.Enabled = True
                                                End If
                                            ElseIf i = 5 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnDepreciacion.Enabled = True
                                                End If
                                            ElseIf i = 6 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPlanilla.Enabled = True
                                                End If
                                            ElseIf i = 7 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCuentas.Enabled = True
                                                End If
                                            ElseIf i = 8 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnAsientos.Enabled = True
                                                End If
                                            ElseIf i = 9 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCategoriaProveedor.Enabled = True
                                                End If
                                            ElseIf i = 10 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnProveedor.Enabled = True
                                                End If
                                            ElseIf i = 11 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnBancos.Enabled = True
                                                End If
                                            ElseIf i = 12 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPeriodoContable.Enabled = True
                                                End If
                                            ElseIf i = 13 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnFormaPago.Enabled = True
                                                End If
                                            ElseIf i = 14 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCAI.Enabled = True
                                                End If
                                            ElseIf i = 15 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnChequera.Enabled = True
                                                End If
                                            ElseIf i = 16 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCheques.Enabled = True
                                                End If
                                            ElseIf i = 17 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnDepoBanc.Enabled = True
                                                End If
                                            ElseIf i = 18 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnFacturaCompra.Enabled = True
                                                End If
                                            ElseIf i = 19 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPagos.Enabled = True
                                                End If
                                            End If 'if conteo

                                        Next

                                        _1A_PantallaCarga.pBarInicio.Value += 20

                                    End If
                                ElseIf filas = 2 Then 'Permisos en Laboratorio
                                    If dtPerfil.Rows(filas).Item(2) = True Then
                                        Form1.btnlaboratorio.Enabled = True


                                        With ventanas
                                            .Cod_Modulo = Convert.ToInt32(dtPerfil.Rows(filas).Item(0).ToString)
                                            dtVentanas = .listarPermisos
                                        End With

                                        For i = 0 To dtVentanas.Rows.Count

                                            If i = 0 Then 'if conteo

                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnExamen.Enabled = True
                                                Else
                                                    Form1.btnExamen.Enabled = False
                                                End If
                                            ElseIf i = 1 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnTrabajo.Enabled = True
                                                End If

                                            ElseIf i = 2 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnHojaTrabajo.Enabled = True
                                                End If
                                            ElseIf i = 3 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnEntrega.Enabled = True
                                                End If
                                            ElseIf i = 4 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnSede.Enabled = True
                                                End If
                                            ElseIf i = 5 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnSucursal.Enabled = True
                                                End If
                                            ElseIf i = 6 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnMedico.Enabled = True
                                                End If
                                            ElseIf i = 7 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPaciente.Enabled = True
                                                End If
                                            ElseIf i = 8 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnConvenio.Enabled = True
                                                End If
                                            ElseIf i = 9 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnValoresRef.Enabled = True
                                                End If
                                            ElseIf i = 10 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnInformes.Enabled = True
                                                End If

                                            End If 'if conteo

                                        Next

                                        _1A_PantallaCarga.pBarInicio.Value += 20

                                    End If

                                ElseIf filas = 3 Then 'Permisos talento humano
                                    If dtPerfil.Rows(filas).Item(2) = True Then
                                        Form1.btnTalentoHumano.Enabled = True

                                        With ventanas
                                            .Cod_Modulo = Convert.ToInt32(dtPerfil.Rows(filas).Item(0).ToString)
                                            dtVentanas = .listarPermisos
                                        End With

                                        For i = 0 To dtVentanas.Rows.Count

                                            If i = 0 Then 'if conteo

                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPuestoTrabajo.Enabled = True
                                                End If
                                            ElseIf i = 1 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnHorarios.Enabled = True
                                                End If

                                            ElseIf i = 2 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnContratos.Enabled = True
                                                End If
                                            ElseIf i = 3 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnSucursales.Enabled = True
                                                End If
                                            ElseIf i = 4 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPermisos.Enabled = True
                                                End If
                                            ElseIf i = 5 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnVacaciones.Enabled = True
                                                End If
                                            ElseIf i = 6 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnEmpleados.Enabled = True
                                                End If
                                            ElseIf i = 7 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnProfesion.Enabled = True
                                                End If
                                            ElseIf i = 8 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnTipoDeducciones.Enabled = True
                                                End If
                                            ElseIf i = 9 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnArea.Enabled = True
                                                End If
                                            ElseIf i = 10 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnDepto.Enabled = True
                                                End If
                                            End If
                                        Next


                                        _1A_PantallaCarga.pBarInicio.Value += 20

                                    End If

                                ElseIf filas = 4 Then 'permisos en sistemas
                                    If dtPerfil.Rows(filas).Item(2) = True Then

                                        Form1.btnSistema.Enabled = True
                                        With ventanas
                                            .Cod_Modulo = Convert.ToInt32(dtPerfil.Rows(filas).Item(0).ToString)
                                            dtVentanas = .listarPermisos
                                        End With


                                        For i = 0 To dtVentanas.Rows.Count

                                            If i = 0 Then 'if conteo

                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnUsuarios.Enabled = True
                                                End If
                                            ElseIf i = 1 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnPerfiles.Enabled = True
                                                End If

                                            ElseIf i = 2 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnServidorCorreo.Enabled = True
                                                Else
                                                    Form1.btnServidorCorreo.Enabled = False
                                                End If

                                            End If
                                        Next

                                        _1A_PantallaCarga.pBarInicio.Value += 5

                                    End If
                                ElseIf filas = 5 Then 'Permisos Almacen
                                    If dtPerfil.Rows(filas).Item(2) = True Then
                                        Form1.btnAlmacen.Enabled = True
                                        With ventanas
                                            .Cod_Modulo = Convert.ToInt32(dtPerfil.Rows(filas).Item(0).ToString)
                                            dtVentanas = .listarPermisos
                                        End With

                                        For i = 0 To dtVentanas.Rows.Count

                                            If i = 0 Then 'if conteo

                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnAlmacenes.Enabled = True
                                                End If
                                            ElseIf i = 1 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnSalidas.Enabled = True
                                                End If

                                            ElseIf i = 2 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnOrdeCompra.Enabled = True
                                                End If
                                            ElseIf i = 3 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnFactCompra.Enabled = True
                                                End If
                                            ElseIf i = 4 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnOrdenInterna.Enabled = True
                                                End If
                                            ElseIf i = 5 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnEntradas.Enabled = True
                                                End If
                                            ElseIf i = 6 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnProducto.Enabled = True
                                                End If
                                            ElseIf i = 7 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnProveedores.Enabled = True
                                                End If
                                            ElseIf i = 8 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnAutorizacion.Enabled = True

                                                End If
                                            ElseIf i = 9 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnBI.Enabled = True
                                                End If
                                            ElseIf i = 10 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnInventario.Enabled = True
                                                End If
                                            ElseIf i = 11 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnCategoria.Enabled = True
                                                End If
                                            ElseIf i = 12 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnUnidadMedida.Enabled = True
                                                End If
                                            ElseIf i = 13 Then
                                                If dtVentanas.Rows(i).Item(2) = True Then
                                                    Form1.btnSolicitudes.Enabled = True
                                                End If
                                            End If
                                        Next

                                    End If
                                    _1A_PantallaCarga.pBarInicio.Value += 15

                                    _1A_PantallaCarga.Close()
                                    Form1.Show()
                                End If ' final if conteo filas

                            Next
                        Catch ex As Exception
                            MsgBox(ex)
                        End Try

                    End With

                    M_InicioSesion.txtusuario.Text = ""
                    M_InicioSesion.txtPassword.Text = ""
                    M_InicioSesion.Hide()

                End If

            End If ' final verificar existencia

        Catch ex As Exception
            MsgBox("Usuario o contraseña incorrectos. Vuelva a intentarlo." + ex.Message)
        End Try

    End Function


    ':::::::::::::::::::::::::::::::::::::::::::: FINAL LOGIN


    ':::::::::::::::::::::::::::::::::::::::::::: LOGIN PASS

    Public Function LOGINPASS(User As String)
        Try

            Dim usuario As New ClsUsuario

            With usuario

                .Usuario_ = User

            End With

            Dim dt As New DataTable
            Dim row As DataRow

            dt = usuario.LoginPass
            row = dt.Rows(0)

            If row("pass") = "#changepass#" Then
                A_CambioPassword.ShowDialog()
            End If

        Catch ex As Exception
            MsgBox("Usuario incorrecto o hubo un error al realizar la consulta. Vuelva a intentarlo.")
        End Try

    End Function

    ':::::::::::::::::::::::::::::::::::::::::::: FINAL LOGIN

    Sub alternarColoFilasDatagridview(ByVal dgv As DataGridView)
        With dgv
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
        End With
    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::: ACTIVE DIRECTORY ::::::::::::::::::::::::::::::::::::::::::::
    'Función para consultar usuarios de Active Directory
    Sub ImportarUsuariosAD()

        Dim objDirectoryEntry As New DirectoryEntry("LDAP://laboratoriosmedicos.local", "sinergia", "@Tatiana1987")
        Dim objDirectorySearcher As New DirectorySearcher(objDirectoryEntry)
        Dim mySearcher As New System.DirectoryServices.DirectorySearcher(objDirectoryEntry)

        Dim result As System.DirectoryServices.SearchResult
        mySearcher.Filter = "(givenName=*)"
        For Each result In mySearcher.FindAll()
            A_ImportarUserAD.dtUsuariosAD.Rows.Add(False, result.GetDirectoryEntry().Properties("givenName").Value, result.GetDirectoryEntry().Properties("SN").Value, result.GetDirectoryEntry().Properties("SAMAccountName").Value)
        Next
        MsgBox("Carga de usuarios completada.")
    End Sub
    ':::::::::::::::::::::::::::::::::::::::::::: FINAL ACTIVE DIRECTORY ::::::::::::::::::::::::::::::::::::::::::::



End Module
