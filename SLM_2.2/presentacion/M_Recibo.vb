Imports System.Net.Mail
Imports System
Imports System.Text
Imports System.Globalization
Imports System.ComponentModel
Public Class M_Recibo
    Public letras As String
    Dim codigoDetalleRecibo As ArrayList = New ArrayList()
    Private Sub btnbuscarUnidad_Click(sender As Object, e As EventArgs) Handles btnbuscarFormaPago.Click
        A_ListarFormasPagoPF.lblForm.Text = "M_Recibo"
        A_ListarFormasPagoPF.Show()
    End Sub

    Private Sub txtcodigoFormaPago_TextChanged(sender As Object, e As EventArgs) Handles txtcodigoFormaPago.TextChanged
        If (txtcodigoFormaPago.Text <> "") Then
            Try
                Dim objFrmPgo As New ClsFormaPago
                With objFrmPgo
                    .Cod = txtcodigoFormaPago.Text
                End With

                Dim dt As New DataTable
                dt = objFrmPgo.buscarCodigoFormaPago()
                Dim row As DataRow = dt.Rows(0)
                txtnombreFormaPago.Text = CStr(row("nombreBanco"))
                lblcodeFormaPago.Text = CStr(row("codFormaPago"))
                txtcodigoFormaPago.BackColor = Color.White
            Catch ex As Exception
                txtcodigoFormaPago.BackColor = Color.Red
                txtnombreFormaPago.Text = ""
                lblcodeFormaPago.Text = ""
            End Try
        Else
            txtcodigoFormaPago.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            txtcodigoFormaPago.BackColor = Color.White
        End If
    End Sub
    Public Sub limpiar()

        Try
            txtnumero.Text = ""
            dtpFechaTrans.Value = Date.Now
            rtxtReferencia.Text = ""
            txtnombreFormaPago.Text = ""
            lblcodeFormaPago.Text = ""
            txtcodigoFormaPago.Text = "CR"
            cbxInfoClte.Checked = False
            cbxOk.Checked = False
            txtMoneda.Text = "LPS"
            txtDepositado.Text = "0"
            rtxtObservaciones.Clear()
            lblEstado.Text = "Nuevo"

            dgbtabla.Rows.Clear()

            dtpFechaTrans.Enabled = True
            rtxtReferencia.ReadOnly = False
            txtcodigoFormaPago.ReadOnly = False
            cbxInfoClte.Enabled = True
            cbxOk.Enabled = True
            txtMoneda.ReadOnly = False
            rtxtObservaciones.ReadOnly = False

            btnbuscarFormaPago.Enabled = True
            btnmodificar.Enabled = False
            btnguardar.Enabled = True

            codigoDetalleRecibo.Clear()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub deshabilitar()

        dtpFechaTrans.Enabled = False
        rtxtReferencia.ReadOnly = True
        txtcodigoFormaPago.ReadOnly = True
        cbxInfoClte.Enabled = False
        cbxOk.Enabled = False
        txtMoneda.ReadOnly = True
        rtxtObservaciones.ReadOnly = True

        btnbuscarFormaPago.Enabled = False
        btnmodificar.Enabled = False
        btnguardar.Enabled = False

    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        limpiar()
        Me.Close()
    End Sub
    Private Function sinDobleEspacio(ByVal cadena As String) As String
        Dim texto As String = ""
        Dim testArray() As String = Split(cadena)
        For i As Integer = 0 To testArray.Length - 1
            If testArray(i) <> "" Then
                texto += testArray(i) + " "
            End If
        Next
        Return RTrim(texto)
    End Function
    Public Function validarFactura(ByVal numeroFactura As Integer) As Integer
        For index As Integer = 0 To dgbtabla.Rows.Count - 2
            If (dgbtabla.Rows(index).Cells(1).Value() = numeroFactura) Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Private Sub ImprimirRecibo()
        letras = M_Recibo.Numalet.ToCardinal(txtDepositado.Text)
        Dim objReporte As New Cry_Recibo

        objReporte.SetParameterValue("@numero", Convert.ToInt64(txtnumero.Text))
        objReporte.SetParameterValue("numalet", letras)
        objReporte.SetParameterValue("cajero", Form1.lblMiUser.Text)
        objReporte.DataSourceConnections.Item(0).SetLogon("sa", "Lbm2019")
        M_ImprimirFacturaReport.CrystalReportViewer1.ReportSource = objReporte

        M_ImprimirFacturaReport.Show()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub dgblistadoExamenes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellEndEdit
        If e.ColumnIndex = 0 Then
            'MsgBox("cambia los datos")
            Try
                If (Trim(dgbtabla.Rows(e.RowIndex).Cells(8).Value()) <> "") Then
                    MsgBox("funciona")
                    calcularTotal()
                Else
                    MsgBox("entra en el else")
                    calcularTotal()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Try
            rtxtReferencia.Text = sinDobleEspacio(rtxtReferencia.Text)
            If (Trim(rtxtReferencia.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "" And txtcodigoFormaPago.BackColor = Color.White And dgbtabla.Rows.Count > 1 And Trim(txtMoneda.Text) <> "") Then

                Dim objRbo As New ClsRecibo

                With objRbo
                    .fechaTrans_ = dtpFechaTrans.Value
                    .referencia_ = rtxtReferencia.Text
                    .codigoFormaPago_ = lblcodeFormaPago.Text
                    .infoClte_ = cbxInfoClte.Checked
                    .ok_ = cbxOk.Checked
                    .moneda_ = txtMoneda.Text
                    .observaciones_ = rtxtObservaciones.Text
                    .depositado_ = Convert.ToDouble(txtDepositado.Text)
                End With

                If objRbo.RegistrarNuevoRecibo() = 1 Then
                    'deshabilitar()
                    btnguardar.Enabled = False
                    Dim dt As New DataTable
                    dt = objRbo.CapturarRecibo()
                    Dim row As DataRow = dt.Rows(0)

                    txtnumero.Text = CStr(row("numero"))
                    Dim objDetRbo As New ClsDetalleRecibo
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        With objDetRbo
                            .codigoRecibo_ = txtnumero.Text
                            .numeroFactura_ = dgbtabla.Rows(index).Cells(1).Value()
                            .totalRecibo_ = Double.Parse(dgbtabla.Rows(index).Cells(8).Value())
                        End With
                        If objDetRbo.RegistrarNuevoDetalleRecibo() = 0 Then
                            MsgBox("Error al querer insertar el detalle del recibo.", MsgBoxStyle.Critical)
                        End If
                    Next
                    MsgBox("Registrado el recibo correctamente.", MsgBoxStyle.Information)
                    M_BuscarRecibo.seleccionarRecibo()
                    If cbxOk.Checked Then
                        MsgBox("Imprimiendo recibo.", MsgBoxStyle.Information, "Validación.")
                        ImprimirRecibo()
                    End If

                Else
                        MsgBox("Error al querer ingresar el recibo.", MsgBoxStyle.Critical)
                End If

            Else
                MsgBox("Debe ingresar los campos necesarios correctamente.", MsgBoxStyle.Critical, "Validación")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            rtxtReferencia.Text = sinDobleEspacio(rtxtReferencia.Text)
            If (Trim(rtxtReferencia.Text) <> "" And Trim(txtcodigoFormaPago.Text) <> "" And txtcodigoFormaPago.BackColor = Color.White And dgbtabla.Rows.Count > 1 And Trim(txtMoneda.Text) <> "") Then

                Dim objRbo As New ClsRecibo
                With objRbo
                    .numero_ = txtnumero.Text
                    .fechaTrans_ = dtpFechaTrans.Value
                    .referencia_ = rtxtReferencia.Text
                    .codigoFormaPago_ = lblcodeFormaPago.Text
                    .infoClte_ = cbxInfoClte.Checked
                    .ok_ = cbxOk.Checked
                    .moneda_ = txtMoneda.Text
                    .observaciones_ = rtxtObservaciones.Text
                    .depositado_ = Convert.ToDouble(txtDepositado.Text)
                End With

                If objRbo.ModificarRecibo() = 1 Then
                    Dim objDetRbo As New ClsDetalleRecibo
                    For index As Integer = 0 To codigoDetalleRecibo.Count - 1
                        objDetRbo.codigo_ = Convert.ToInt64(codigoDetalleRecibo(index))
                        If objDetRbo.EliminarDetalleRecibo() <> 1 Then
                            MsgBox("Error al querer modificar el recibo")
                        End If
                    Next
                    codigoDetalleRecibo.Clear()
                    For index As Integer = 0 To dgbtabla.Rows.Count - 2
                        If dgbtabla.Rows(index).Cells(0).Value() = 0 Then
                            'agrega
                            With objDetRbo
                                .codigoRecibo_ = txtnumero.Text
                                .numeroFactura_ = dgbtabla.Rows(index).Cells(1).Value()
                                .totalRecibo_ = Double.Parse(dgbtabla.Rows(index).Cells(8).Value())
                            End With
                            If objDetRbo.RegistrarNuevoDetalleRecibo() = 0 Then
                                MsgBox("Error al querer insertar el detalle del recibo.", MsgBoxStyle.Critical)
                            End If
                        Else

                            'actualiza los recibos
                            With objDetRbo
                                .codigo_ = dgbtabla.Rows(index).Cells(0).Value()
                                .codigoRecibo_ = txtnumero.Text
                                .numeroFactura_ = dgbtabla.Rows(index).Cells(1).Value()
                                .totalRecibo_ = Double.Parse(dgbtabla.Rows(index).Cells(8).Value())
                            End With
                            If objDetRbo.ModificarDetalleRecibo() = 0 Then
                                MsgBox("Error al querer modificar el recibo.", MsgBoxStyle.Critical)
                            End If
                        End If
                    Next
                    MsgBox("Modificado correctamente.", MsgBoxStyle.Information)
                    'btnmodificar.Enabled = False
                End If

                If (cbxOk.Checked) Then
                    deshabilitar()
                    MsgBox("Imprimiendo recibo.", MsgBoxStyle.Information, "Validación.")
                    ImprimirRecibo()
                End If
                M_BuscarRecibo.seleccionarRecibo()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub calcularTotal()
        Dim total As Double
        For index As Integer = 0 To dgbtabla.Rows.Count - 1
            total += Convert.ToDouble(dgbtabla.Rows(index).Cells(8).Value())
        Next
        txtDepositado.Text = total
    End Sub
    Private Sub dgbtabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellClick
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 1 And lblEstado.Text <> "OK" Then
                    M_ListarFactura.Show()
                ElseIf e.ColumnIndex = 10 And lblEstado.Text = "Nuevo" Then
                    Dim n As String = MsgBox("¿Desea eliminar la factura del recibo?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                        calcularTotal()
                    End If
                ElseIf e.ColumnIndex = 10 And lblEstado.Text = "Modificar" And Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value() <> "" Then
                    Dim n As String = MsgBox("¿Desea eliminar la factura del recibo?", MsgBoxStyle.YesNo, "Validación")
                    If n = vbYes Then
                        codigoDetalleRecibo.Add(Me.dgbtabla.Rows(e.RowIndex).Cells(0).Value())
                        dgbtabla.Rows.Remove(dgbtabla.Rows(e.RowIndex.ToString))
                        calcularTotal()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub lblcodeFormaPago_TextChanged(sender As Object, e As EventArgs) Handles lblcodeFormaPago.TextChanged
        Try
            Dim objFmaPgo As New ClsFormaPago
            With objFmaPgo
                .Codigo_FormaPago = lblcodeFormaPago.Text
            End With
            Dim dt As New DataTable
            dt = objFmaPgo.buscarFormaPago()
            Dim row As DataRow = dt.Rows(0)
            txtcodigoFormaPago.Text = CStr(row("codigo"))
            txtnombreFormaPago.Text = UCase(CStr(row("nombreBanco")))
        Catch ex As Exception
            'MsgBox("No existe el código del término de pago.", MsgBoxStyle.Critical, "Validación")
        End Try
    End Sub
    Private Sub M_Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.dgbtabla.Columns("codigo").Visible = False

            If dgbtabla.Columns.Contains("btnEliminar") = False Then
                Dim btn As New DataGridViewButtonColumn()
                dgbtabla.Columns.Add(btn)
                btn.HeaderText = "Eliminar"
                btn.Text = "Eliminar"
                btn.Name = "btnEliminar"
                btn.UseColumnTextForButtonValue = True
            End If
        Catch ex As Exception

        End Try
        alternarColoFilasDatagridview(dgbtabla)
    End Sub


    Private Sub dgbtabla_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgbtabla.CellValueChanged
        If dgbtabla.Rows.Count > 1 Then
            calcularTotal()
        End If
    End Sub

    'Convertir numeros a letras para impresión de RECIBO
    Public NotInheritable Class Numalet

#Region "Miembros estáticos"

        Private Const UNI As Integer = 0, DIECI As Integer = 1, DECENA As Integer = 2, CENTENA As Integer = 3
        Private Shared _matriz As String(,) = New String(CENTENA, 9) {
            {Nothing, " UNO", " DOS", " TRES", " CUATRO", " CINCO", " SEIS", " SIETE", " OCHO", " NUEVE"},
            {" DIEZ", " ONCE", " DOCE", " TRECE", " CATORCE", " QUINCE", " DIECISEIS", " DIECISIETE", " DIECIOCHO", " DIECINUEVE"},
            {Nothing, Nothing, Nothing, " TREINTA", " CUARENTA", " CONCUENTA", " SESENTA", " SETENTA", " OCHENTA", " NOVENTA"},
            {Nothing, Nothing, Nothing, Nothing, Nothing, " QUINIENTOS", Nothing, " SETECIENTOS", Nothing, " NOVECIENTOS"}}
        Private Const [sub] As Char = CChar(ChrW(26))
        'Cambiar acá si se quiere otro comportamiento en los métodos de clase
        Public Const SeparadorDecimalSalidaDefault As String = "LEMPIRAS CON "
        Public Const MascaraSalidaDecimalDefault As String = "00' CENTAVOS.'"
        Public Const DecimalesDefault As Int32 = 2
        Public Const LetraCapitalDefault As Boolean = False
        Public Const ConvertirDecimalesDefault As Boolean = False
        Public Const ApocoparUnoParteEnteraDefault As Boolean = False
        Public Const ApocoparUnoParteDecimalDefault As Boolean = False

#End Region

#Region "Propiedades"

        Private _decimales As Int32 = DecimalesDefault
        Private _cultureInfo As CultureInfo = Globalization.CultureInfo.CurrentCulture
        Private _separadorDecimalSalida As String = SeparadorDecimalSalidaDefault
        Private _posiciones As Int32 = DecimalesDefault
        Private _mascaraSalidaDecimal As String, _mascaraSalidaDecimalInterna As String = MascaraSalidaDecimalDefault
        Private _esMascaraNumerica As Boolean = True
        Private _letraCapital As Boolean = LetraCapitalDefault
        Private _convertirDecimales As Boolean = ConvertirDecimalesDefault
        Private _apocoparUnoParteEntera As Boolean = False
        Private _apocoparUnoParteDecimal As Boolean

        ''' <summary>
        ''' Indica la cantidad de decimales que se pasarán a entero para la conversión
        ''' </summary>
        ''' <remarks>Esta propiedad cambia al cambiar MascaraDecimal por un valor que empieze con '0'</remarks>
        Public Property Decimales() As Int32
            Get
                Return _decimales
            End Get
            Set(ByVal value As Int32)
                If value > 10 Then
                    Throw New ArgumentException(value.ToString() + " excede el número máximo de decimales admitidos, solo se admiten hasta 10.")
                End If
                _decimales = value
            End Set
        End Property

        ''' <summary>
        ''' Objeto CultureInfo utilizado para convertir las cadenas de entrada en números
        ''' </summary>
        Public Property CultureInfo() As CultureInfo
            Get
                Return _cultureInfo
            End Get
            Set(ByVal value As CultureInfo)
                _cultureInfo = value
            End Set
        End Property

        ''' <summary>
        ''' Indica la cadena a intercalar entre la parte entera y la decimal del número
        ''' </summary>
        Public Property SeparadorDecimalSalida() As String
            Get
                Return _separadorDecimalSalida
            End Get
            Set(ByVal value As String)
                _separadorDecimalSalida = value
                'Si el separador decimal es compuesto, infiero que estoy cuantificando algo,
                'por lo que apocopo el "uno" convirtiéndolo en "un"
                If value.Trim().IndexOf(" ") > 0 Then
                    _apocoparUnoParteEntera = True
                Else
                    _apocoparUnoParteEntera = False
                End If
            End Set
        End Property

        ''' <summary>
        ''' Indica el formato que se le dara a la parte decimal del número
        ''' </summary>
        Public Property MascaraSalidaDecimal() As String
            Get
                If Not [String].IsNullOrEmpty(_mascaraSalidaDecimal) Then
                    Return _mascaraSalidaDecimal
                Else
                    Return ""
                End If
            End Get
            Set(ByVal value As String)
                'determino la cantidad de cifras a redondear a partir de la cantidad de '0' o ''
                'que haya al principio de la cadena, y también si es una máscara numérica
                Dim i As Integer = 0
                While i < value.Length AndAlso (value(i) = "0"c OrElse value(i) = "#")
                    i += 1
                End While
                _posiciones = i
                If i > 0 Then
                    _decimales = i
                    _esMascaraNumerica = True
                Else
                    _esMascaraNumerica = False
                End If
                _mascaraSalidaDecimal = value
                If _esMascaraNumerica Then
                    _mascaraSalidaDecimalInterna = value.Substring(0, _posiciones) + "'" + value.Substring(_posiciones).Replace("''", [sub].ToString()).Replace("'", [String].Empty).Replace([sub].ToString(), "'") + "'"
                Else
                    _mascaraSalidaDecimalInterna = value.Replace("''", [sub].ToString()).Replace("'", [String].Empty).Replace([sub].ToString(), "'")
                End If
            End Set
        End Property

        ''' <summary>
        ''' Indica si la primera letra del resultado debe estár en mayúscula
        ''' </summary>
        Public Property LetraCapital() As Boolean
            Get
                Return _letraCapital
            End Get
            Set(ByVal value As Boolean)
                _letraCapital = value
            End Set
        End Property

        ''' <summary>
        ''' Indica si se deben convertir los decimales a su expresión nominal
        ''' </summary>
        Public Property ConvertirDecimales() As Boolean
            Get
                Return _convertirDecimales
            End Get
            Set(ByVal value As Boolean)
                _convertirDecimales = value
                _apocoparUnoParteDecimal = value
                If value Then
                    ' Si la máscara es la default, la borro
                    If _mascaraSalidaDecimal = MascaraSalidaDecimalDefault Then
                        MascaraSalidaDecimal = ""
                    End If
                ElseIf [String].IsNullOrEmpty(_mascaraSalidaDecimal) Then
                    MascaraSalidaDecimal = MascaraSalidaDecimalDefault
                    'Si no hay máscara dejo la default
                End If
            End Set
        End Property

        ''' <summary>
        ''' Indica si de debe cambiar "uno" por "un" en las unidades.
        ''' </summary>
        Public Property ApocoparUnoParteEntera() As Boolean
            Get
                Return _apocoparUnoParteEntera
            End Get
            Set(ByVal value As Boolean)
                _apocoparUnoParteEntera = value
            End Set
        End Property

        ''' <summary>
        ''' Determina si se debe apococopar el "uno" en la parte decimal
        ''' </summary>
        ''' <remarks>El valor de esta propiedad cambia al setear ConvertirDecimales</remarks>
        Public Property ApocoparUnoParteDecimal() As Boolean
            Get
                Return _apocoparUnoParteDecimal
            End Get
            Set(ByVal value As Boolean)
                _apocoparUnoParteDecimal = value
            End Set
        End Property

#End Region

#Region "Constructores"

        Public Sub New()
            MascaraSalidaDecimal = MascaraSalidaDecimalDefault
            SeparadorDecimalSalida = SeparadorDecimalSalidaDefault
            LetraCapital = LetraCapitalDefault
            ConvertirDecimales = _convertirDecimales
        End Sub

        Public Sub New(ByVal ConvertirDecimales As Boolean, ByVal MascaraSalidaDecimal As String, ByVal SeparadorDecimalSalida As String, ByVal LetraCapital As Boolean)
            If Not [String].IsNullOrEmpty(MascaraSalidaDecimal) Then
                Me.MascaraSalidaDecimal = MascaraSalidaDecimal
            End If
            If Not [String].IsNullOrEmpty(SeparadorDecimalSalida) Then
                _separadorDecimalSalida = SeparadorDecimalSalida
            End If
            _letraCapital = LetraCapital
            _convertirDecimales = ConvertirDecimales
        End Sub

#End Region

#Region "Conversores de instancia"

        Public Function ToCustomCardinal(ByVal Numero As Double) As String
            Return Convertir(Convert.ToDecimal(Numero), _decimales, _separadorDecimalSalida, _mascaraSalidaDecimalInterna, _esMascaraNumerica, _letraCapital,
            _convertirDecimales, _apocoparUnoParteEntera, _apocoparUnoParteDecimal)
        End Function

        Public Function ToCustomCardinal(ByVal Numero As String) As String
            Dim dNumero As Double
            If [Double].TryParse(Numero, NumberStyles.Float, _cultureInfo, dNumero) Then
                Return ToCustomCardinal(dNumero)
            Else
                Throw New ArgumentException("'" + Numero + "' no es un número válido.")
            End If
        End Function

        Public Function ToCustomCardinal(ByVal Numero As Decimal) As String
            Return ToCardinal(Numero)
        End Function

        Public Function ToCustomCardinal(ByVal Numero As Int32) As String
            Return Convertir(Convert.ToDecimal(Numero), 0, _separadorDecimalSalida, _mascaraSalidaDecimalInterna, _esMascaraNumerica, _letraCapital,
            _convertirDecimales, _apocoparUnoParteEntera, False)
        End Function

#End Region

#Region "Conversores estáticos"

        Public Shared Function ToCardinal(ByVal Numero As Int32) As String
            Return Convertir(Convert.ToDecimal(Numero), 0, Nothing, Nothing, True, LetraCapitalDefault,
            ConvertirDecimalesDefault, ApocoparUnoParteEnteraDefault, ApocoparUnoParteDecimalDefault)
        End Function

        Public Shared Function ToCardinal(ByVal Numero As Double) As String
            Return Convertir(Convert.ToDecimal(Numero), DecimalesDefault, SeparadorDecimalSalidaDefault, MascaraSalidaDecimalDefault, True, LetraCapitalDefault,
            ConvertirDecimalesDefault, ApocoparUnoParteEnteraDefault, ApocoparUnoParteDecimalDefault)
        End Function

        Public Shared Function ToCardinal(ByVal Numero As String, ByVal ReferenciaCultural As CultureInfo) As String
            Dim dNumero As Double
            If [Double].TryParse(Numero, NumberStyles.Float, ReferenciaCultural, dNumero) Then
                Return ToCardinal(dNumero)
            Else
                Throw New ArgumentException("'" + Numero + "' no es un número válido.")
            End If
        End Function

        Public Shared Function ToCardinal(ByVal Numero As String) As String
            Return Numalet.ToCardinal(Numero, CultureInfo.CurrentCulture)
        End Function

        Public Shared Function ToCardinal(ByVal Numero As Decimal) As String
            Return ToCardinal(Convert.ToDouble(Numero))
        End Function

#End Region

        Private Shared Function Convertir(ByVal Numero As Decimal, ByVal Decimales As Int32, ByVal SeparadorDecimalSalida As String, ByVal MascaraSalidaDecimal As String, ByVal EsMascaraNumerica As Boolean, ByVal LetraCapital As Boolean,
        ByVal ConvertirDecimales As Boolean, ByVal ApocoparUnoParteEntera As Boolean, ByVal ApocoparUnoParteDecimal As Boolean) As String
            Dim Num As Int64
            Dim terna As Int32, centenaTerna As Int32, decenaTerna As Int32, unidadTerna As Int32, iTerna As Int32
            Dim cadTerna As String
            Dim Resultado As New StringBuilder()

            Num = Math.Floor(Math.Abs(Numero))

            If Num >= 1000000000001 OrElse Num < 0 Then
                Throw New ArgumentException("El número '" + Numero.ToString() + "' excedió los límites del conversor: [0;1.000.000.000.001]")
            End If
            If Num = 0 Then
                Resultado.Append(" CERO")
            Else
                iTerna = 0

                Do Until Num = 0

                    iTerna += 1
                    cadTerna = String.Empty
                    terna = Num Mod 1000

                    centenaTerna = Int(terna / 100)
                    decenaTerna = terna - centenaTerna * 100 'Decena junto con la unidad
                    unidadTerna = (decenaTerna - Math.Floor(decenaTerna / 10) * 10)

                    Select Case decenaTerna
                        Case 1 To 9
                            cadTerna = _matriz(UNI, unidadTerna) + cadTerna
                        Case 10 To 19
                            cadTerna = cadTerna + _matriz(DIECI, unidadTerna)
                        Case 20
                            cadTerna = cadTerna + " VEINTE"
                        Case 21 To 29
                            cadTerna = " VEINTI" + _matriz(UNI, unidadTerna).Substring(1)
                        Case 30 To 99
                            If unidadTerna <> 0 Then
                                cadTerna = _matriz(DECENA, Int(decenaTerna / 10)) + " Y" + _matriz(UNI, unidadTerna) + cadTerna
                            Else
                                cadTerna += _matriz(DECENA, Int(decenaTerna / 10))
                            End If
                    End Select

                    Select Case centenaTerna
                        Case 1
                            If decenaTerna > 0 Then
                                cadTerna = " CIENTO" + cadTerna
                            Else
                                cadTerna = " CIEN" + cadTerna
                            End If
                            Exit Select
                        Case 5, 7, 9
                            cadTerna = _matriz(CENTENA, Int(terna / 100)) + cadTerna
                            Exit Select
                        Case Else
                            If Int(terna / 100) > 1 Then
                                cadTerna = _matriz(UNI, Int(terna / 100)) + "CIENTOS" + cadTerna
                            End If
                            Exit Select
                    End Select
                    'Reemplazo el 'uno' por 'un' si no es en las únidades o si se solicító apocopar
                    If (iTerna > 1 OrElse ApocoparUnoParteEntera) AndAlso decenaTerna = 21 Then
                        cadTerna = cadTerna.Replace("VEINTIUNO", "VEINTIUN")
                    ElseIf (iTerna > 1 OrElse ApocoparUnoParteEntera) AndAlso unidadTerna = 1 AndAlso decenaTerna <> 11 Then
                        cadTerna = cadTerna.Substring(0, cadTerna.Length - 1)
                        'Acentúo 'veintidós', 'veintitrés' y 'veintiséis'
                    ElseIf decenaTerna = 22 Then
                        cadTerna = cadTerna.Replace("VEINTIDOS", "VEINTIDOS")
                    ElseIf decenaTerna = 23 Then
                        cadTerna = cadTerna.Replace("VEINTITRES", "VEINTITRES")
                    ElseIf decenaTerna = 26 Then
                        cadTerna = cadTerna.Replace("VEINTISEIS", "VEINTISEIS")
                    End If

                    'Completo miles y millones
                    Select Case iTerna
                        Case 3
                            If Numero < 2000000 Then
                                cadTerna += " MILLON"
                            Else
                                cadTerna += " MILLONES"
                            End If
                        Case 2, 4
                            If terna > 0 Then cadTerna += " MIL"
                    End Select
                    Resultado.Insert(0, cadTerna)
                    Num = Int(Num / 1000)
                Loop
            End If

            'Se agregan los decimales si corresponde
            If Decimales > 0 Then
                Resultado.Append(" " + SeparadorDecimalSalida + " ")
                Dim EnteroDecimal As Int32 = Int(Math.Round((Numero - Int(Numero)) * Math.Pow(10, Decimales)))
                If ConvertirDecimales Then
                    Dim esMascaraDecimalDefault As Boolean = MascaraSalidaDecimal = MascaraSalidaDecimalDefault
                    Resultado.Append(Convertir(Convert.ToDecimal(EnteroDecimal), 0, Nothing, Nothing, EsMascaraNumerica, False,
                    False, (ApocoparUnoParteDecimal AndAlso Not EsMascaraNumerica), False) + " " + (IIf(EsMascaraNumerica, "", MascaraSalidaDecimal)))
                ElseIf EsMascaraNumerica Then
                    Resultado.Append(EnteroDecimal.ToString(MascaraSalidaDecimal))
                Else
                    Resultado.Append(EnteroDecimal.ToString() + " " + MascaraSalidaDecimal)
                End If
            End If
            'Se pone la primer letra en mayúscula si corresponde y se retorna el resultado
            If LetraCapital Then
                Return Resultado(1).ToString().ToUpper() + Resultado.ToString(2, Resultado.Length - 2)
            Else
                Return Resultado.ToString().Substring(1)
            End If
        End Function

    End Class

End Class