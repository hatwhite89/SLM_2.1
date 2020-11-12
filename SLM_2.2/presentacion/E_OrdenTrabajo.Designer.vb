<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_OrdenTrabajo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.lblFacturaNum = New System.Windows.Forms.Label()
        Me.lblcreadoPor = New System.Windows.Forms.Label()
        Me.lblsubArea = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.lblCurva = New System.Windows.Forms.Label()
        Me.lblSede = New System.Windows.Forms.Label()
        Me.lblTecnico = New System.Windows.Forms.Label()
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.lblanalizador = New System.Windows.Forms.Label()
        Me.lblFacturaToma = New System.Windows.Forms.Label()
        Me.lblTecnicoLab = New System.Windows.Forms.Label()
        Me.lblfechaEntrega = New System.Windows.Forms.Label()
        Me.lblresultados = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtcodigoArea = New System.Windows.Forms.TextBox()
        Me.txtnumeroFactura = New System.Windows.Forms.TextBox()
        Me.txtcodigoCajero = New System.Windows.Forms.TextBox()
        Me.txtcodigoSubArea = New System.Windows.Forms.TextBox()
        Me.txtcodigoSucursal = New System.Windows.Forms.TextBox()
        Me.txtcodigoPaciente = New System.Windows.Forms.TextBox()
        Me.txtnombrePaciente = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtgenero = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcodigoMedico = New System.Windows.Forms.TextBox()
        Me.txtnombreMedico = New System.Windows.Forms.TextBox()
        Me.txtcurva = New System.Windows.Forms.TextBox()
        Me.txtsede = New System.Windows.Forms.TextBox()
        Me.txtnombreSede = New System.Windows.Forms.TextBox()
        Me.txtcodigoTecnico = New System.Windows.Forms.TextBox()
        Me.txtnombreTecnico = New System.Windows.Forms.TextBox()
        Me.txtcodigoValidador = New System.Windows.Forms.TextBox()
        Me.txtnombreValidador = New System.Windows.Forms.TextBox()
        Me.txtcodigoObjeto = New System.Windows.Forms.TextBox()
        Me.txtfacturaTomaMuestra = New System.Windows.Forms.TextBox()
        Me.txttecnicoLab = New System.Windows.Forms.TextBox()
        Me.txtpmUsuario = New System.Windows.Forms.TextBox()
        Me.txtnpUsuario = New System.Windows.Forms.TextBox()
        Me.txtepUsuario = New System.Windows.Forms.TextBox()
        Me.txtprUsuario = New System.Windows.Forms.TextBox()
        Me.txtcoUsuario = New System.Windows.Forms.TextBox()
        Me.txtenUsuario = New System.Windows.Forms.TextBox()
        Me.txtinUsuario = New System.Windows.Forms.TextBox()
        Me.lblpm = New System.Windows.Forms.Label()
        Me.lblnp = New System.Windows.Forms.Label()
        Me.lblep = New System.Windows.Forms.Label()
        Me.lblpr = New System.Windows.Forms.Label()
        Me.lblco = New System.Windows.Forms.Label()
        Me.lblen = New System.Windows.Forms.Label()
        Me.lblin = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnverGrafica = New System.Windows.Forms.Button()
        Me.rbtnpendienteMuestra = New System.Windows.Forms.RadioButton()
        Me.rbtnNoProcesado = New System.Windows.Forms.RadioButton()
        Me.rbtnEnProceso = New System.Windows.Forms.RadioButton()
        Me.rbtnProcesado = New System.Windows.Forms.RadioButton()
        Me.rbtnValidado = New System.Windows.Forms.RadioButton()
        Me.rbtnEntregado = New System.Windows.Forms.RadioButton()
        Me.rbtnInvalidado = New System.Windows.Forms.RadioButton()
        Me.cbxWs = New System.Windows.Forms.CheckBox()
        Me.cbxEmail = New System.Windows.Forms.CheckBox()
        Me.cbxcortesia = New System.Windows.Forms.CheckBox()
        Me.cbxurgente = New System.Windows.Forms.CheckBox()
        Me.cbxentregaMedico = New System.Windows.Forms.CheckBox()
        Me.cbxentregaPaciente = New System.Windows.Forms.CheckBox()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.lblEstadoOrden = New System.Windows.Forms.Label()
        Me.lbllinea2 = New System.Windows.Forms.Label()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpPmFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpPmHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpNpHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpNpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpEpHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpEpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpPrHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpPrFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpCoHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpCoFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpInHora = New System.Windows.Forms.DateTimePicker()
        Me.dtpInFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFactura = New System.Windows.Forms.DateTimePicker()
        Me.lblpmUsuario = New System.Windows.Forms.Label()
        Me.lblnpUsuario = New System.Windows.Forms.Label()
        Me.lblepUsuario = New System.Windows.Forms.Label()
        Me.lblprUsuario = New System.Windows.Forms.Label()
        Me.lblcoUsuario = New System.Windows.Forms.Label()
        Me.lblenUsuario = New System.Windows.Forms.Label()
        Me.lblinUsuario = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblcodigoCajero = New System.Windows.Forms.Label()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(66, 55)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(35, 17)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "Nro."
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Location = New System.Drawing.Point(297, 51)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(38, 17)
        Me.lblarea.TabIndex = 1
        Me.lblarea.Text = "Área"
        '
        'lblFacturaNum
        '
        Me.lblFacturaNum.AutoSize = True
        Me.lblFacturaNum.Location = New System.Drawing.Point(511, 55)
        Me.lblFacturaNum.Name = "lblFacturaNum"
        Me.lblFacturaNum.Size = New System.Drawing.Size(117, 17)
        Me.lblFacturaNum.TabIndex = 2
        Me.lblFacturaNum.Text = "Factura Nro. /Fila"
        '
        'lblcreadoPor
        '
        Me.lblcreadoPor.AutoSize = True
        Me.lblcreadoPor.Location = New System.Drawing.Point(841, 56)
        Me.lblcreadoPor.Name = "lblcreadoPor"
        Me.lblcreadoPor.Size = New System.Drawing.Size(80, 17)
        Me.lblcreadoPor.TabIndex = 3
        Me.lblcreadoPor.Text = "Creado Por"
        '
        'lblsubArea
        '
        Me.lblsubArea.AutoSize = True
        Me.lblsubArea.Location = New System.Drawing.Point(267, 82)
        Me.lblsubArea.Name = "lblsubArea"
        Me.lblsubArea.Size = New System.Drawing.Size(67, 17)
        Me.lblsubArea.TabIndex = 5
        Me.lblsubArea.Text = "Sub Área"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(565, 87)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(63, 17)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.Text = "Sucursal"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(49, 119)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "Código"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(59, 152)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(41, 17)
        Me.lblEdad.TabIndex = 8
        Me.lblEdad.Text = "Edad"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(617, 128)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(52, 17)
        Me.lblestado.TabIndex = 9
        Me.lblestado.Text = "Estado"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(925, 128)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 17)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(1082, 128)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(39, 17)
        Me.lblhora.TabIndex = 11
        Me.lblhora.Text = "Hora"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(1233, 131)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(57, 17)
        Me.lblusuario.TabIndex = 12
        Me.lblusuario.Text = "Usuario"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(45, 187)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(56, 17)
        Me.lblGenero.TabIndex = 13
        Me.lblGenero.Text = "Genero"
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Location = New System.Drawing.Point(49, 222)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(53, 17)
        Me.lblMedico.TabIndex = 14
        Me.lblMedico.Text = "Médico"
        '
        'lblCurva
        '
        Me.lblCurva.AutoSize = True
        Me.lblCurva.Location = New System.Drawing.Point(57, 288)
        Me.lblCurva.Name = "lblCurva"
        Me.lblCurva.Size = New System.Drawing.Size(45, 17)
        Me.lblCurva.TabIndex = 15
        Me.lblCurva.Text = "Curva"
        '
        'lblSede
        '
        Me.lblSede.AutoSize = True
        Me.lblSede.Location = New System.Drawing.Point(59, 317)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(41, 17)
        Me.lblSede.TabIndex = 16
        Me.lblSede.Text = "Sede"
        '
        'lblTecnico
        '
        Me.lblTecnico.AutoSize = True
        Me.lblTecnico.Location = New System.Drawing.Point(43, 351)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(58, 17)
        Me.lblTecnico.TabIndex = 17
        Me.lblTecnico.Text = "Técnico"
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Location = New System.Drawing.Point(33, 378)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(68, 17)
        Me.lblValidador.TabIndex = 18
        Me.lblValidador.Text = "Validador"
        '
        'lblanalizador
        '
        Me.lblanalizador.AutoSize = True
        Me.lblanalizador.Location = New System.Drawing.Point(553, 379)
        Me.lblanalizador.Name = "lblanalizador"
        Me.lblanalizador.Size = New System.Drawing.Size(75, 17)
        Me.lblanalizador.TabIndex = 19
        Me.lblanalizador.Text = "Analizador"
        '
        'lblFacturaToma
        '
        Me.lblFacturaToma.AutoSize = True
        Me.lblFacturaToma.Location = New System.Drawing.Point(222, 416)
        Me.lblFacturaToma.Name = "lblFacturaToma"
        Me.lblFacturaToma.Size = New System.Drawing.Size(182, 17)
        Me.lblFacturaToma.TabIndex = 20
        Me.lblFacturaToma.Text = "Factura y Toma de Muestra"
        '
        'lblTecnicoLab
        '
        Me.lblTecnicoLab.AutoSize = True
        Me.lblTecnicoLab.Location = New System.Drawing.Point(249, 450)
        Me.lblTecnicoLab.Name = "lblTecnicoLab"
        Me.lblTecnicoLab.Size = New System.Drawing.Size(155, 17)
        Me.lblTecnicoLab.TabIndex = 21
        Me.lblTecnicoLab.Text = "Técnico de Laboratorio"
        '
        'lblfechaEntrega
        '
        Me.lblfechaEntrega.AutoSize = True
        Me.lblfechaEntrega.Location = New System.Drawing.Point(957, 373)
        Me.lblfechaEntrega.Name = "lblfechaEntrega"
        Me.lblfechaEntrega.Size = New System.Drawing.Size(145, 17)
        Me.lblfechaEntrega.TabIndex = 22
        Me.lblfechaEntrega.Text = "Fecha Entrega Aprox."
        '
        'lblresultados
        '
        Me.lblresultados.AutoSize = True
        Me.lblresultados.Location = New System.Drawing.Point(1023, 467)
        Me.lblresultados.Name = "lblresultados"
        Me.lblresultados.Size = New System.Drawing.Size(79, 17)
        Me.lblresultados.TabIndex = 23
        Me.lblresultados.Text = "Resultados"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(111, 51)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(167, 22)
        Me.txtnumero.TabIndex = 24
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoArea
        '
        Me.txtcodigoArea.Location = New System.Drawing.Point(353, 51)
        Me.txtcodigoArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoArea.Name = "txtcodigoArea"
        Me.txtcodigoArea.Size = New System.Drawing.Size(128, 22)
        Me.txtcodigoArea.TabIndex = 25
        Me.txtcodigoArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroFactura
        '
        Me.txtnumeroFactura.Location = New System.Drawing.Point(634, 51)
        Me.txtnumeroFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumeroFactura.Name = "txtnumeroFactura"
        Me.txtnumeroFactura.Size = New System.Drawing.Size(167, 22)
        Me.txtnumeroFactura.TabIndex = 26
        Me.txtnumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCajero
        '
        Me.txtcodigoCajero.Location = New System.Drawing.Point(927, 53)
        Me.txtcodigoCajero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoCajero.Name = "txtcodigoCajero"
        Me.txtcodigoCajero.Size = New System.Drawing.Size(123, 22)
        Me.txtcodigoCajero.TabIndex = 27
        Me.txtcodigoCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSubArea
        '
        Me.txtcodigoSubArea.Location = New System.Drawing.Point(353, 82)
        Me.txtcodigoSubArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoSubArea.Name = "txtcodigoSubArea"
        Me.txtcodigoSubArea.Size = New System.Drawing.Size(128, 22)
        Me.txtcodigoSubArea.TabIndex = 30
        Me.txtcodigoSubArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSucursal
        '
        Me.txtcodigoSucursal.Location = New System.Drawing.Point(634, 83)
        Me.txtcodigoSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoSucursal.Name = "txtcodigoSucursal"
        Me.txtcodigoSucursal.Size = New System.Drawing.Size(167, 22)
        Me.txtcodigoSucursal.TabIndex = 31
        Me.txtcodigoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoPaciente
        '
        Me.txtcodigoPaciente.Location = New System.Drawing.Point(111, 115)
        Me.txtcodigoPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoPaciente.Name = "txtcodigoPaciente"
        Me.txtcodigoPaciente.Size = New System.Drawing.Size(104, 22)
        Me.txtcodigoPaciente.TabIndex = 32
        Me.txtcodigoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombrePaciente
        '
        Me.txtnombrePaciente.Location = New System.Drawing.Point(225, 115)
        Me.txtnombrePaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombrePaciente.Name = "txtnombrePaciente"
        Me.txtnombrePaciente.ReadOnly = True
        Me.txtnombrePaciente.Size = New System.Drawing.Size(255, 22)
        Me.txtnombrePaciente.TabIndex = 33
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(111, 149)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(104, 22)
        Me.txtedad.TabIndex = 34
        Me.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(313, 149)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(167, 22)
        Me.txttelefono.TabIndex = 35
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(111, 183)
        Me.txtgenero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(104, 22)
        Me.txtgenero.TabIndex = 36
        Me.txtgenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(313, 183)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(167, 22)
        Me.txtemail.TabIndex = 37
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoMedico
        '
        Me.txtcodigoMedico.Location = New System.Drawing.Point(111, 217)
        Me.txtcodigoMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoMedico.Name = "txtcodigoMedico"
        Me.txtcodigoMedico.Size = New System.Drawing.Size(104, 22)
        Me.txtcodigoMedico.TabIndex = 38
        Me.txtcodigoMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreMedico
        '
        Me.txtnombreMedico.Location = New System.Drawing.Point(225, 218)
        Me.txtnombreMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreMedico.Name = "txtnombreMedico"
        Me.txtnombreMedico.ReadOnly = True
        Me.txtnombreMedico.Size = New System.Drawing.Size(255, 22)
        Me.txtnombreMedico.TabIndex = 39
        '
        'txtcurva
        '
        Me.txtcurva.Location = New System.Drawing.Point(111, 283)
        Me.txtcurva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcurva.Name = "txtcurva"
        Me.txtcurva.Size = New System.Drawing.Size(104, 22)
        Me.txtcurva.TabIndex = 40
        Me.txtcurva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsede
        '
        Me.txtsede.Location = New System.Drawing.Point(111, 314)
        Me.txtsede.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsede.Name = "txtsede"
        Me.txtsede.Size = New System.Drawing.Size(104, 22)
        Me.txtsede.TabIndex = 41
        Me.txtsede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreSede
        '
        Me.txtnombreSede.Location = New System.Drawing.Point(225, 314)
        Me.txtnombreSede.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreSede.Name = "txtnombreSede"
        Me.txtnombreSede.ReadOnly = True
        Me.txtnombreSede.Size = New System.Drawing.Size(255, 22)
        Me.txtnombreSede.TabIndex = 42
        '
        'txtcodigoTecnico
        '
        Me.txtcodigoTecnico.Location = New System.Drawing.Point(111, 345)
        Me.txtcodigoTecnico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoTecnico.Name = "txtcodigoTecnico"
        Me.txtcodigoTecnico.Size = New System.Drawing.Size(104, 22)
        Me.txtcodigoTecnico.TabIndex = 43
        Me.txtcodigoTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreTecnico
        '
        Me.txtnombreTecnico.Location = New System.Drawing.Point(225, 346)
        Me.txtnombreTecnico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreTecnico.Name = "txtnombreTecnico"
        Me.txtnombreTecnico.ReadOnly = True
        Me.txtnombreTecnico.Size = New System.Drawing.Size(255, 22)
        Me.txtnombreTecnico.TabIndex = 44
        '
        'txtcodigoValidador
        '
        Me.txtcodigoValidador.Location = New System.Drawing.Point(111, 375)
        Me.txtcodigoValidador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoValidador.Name = "txtcodigoValidador"
        Me.txtcodigoValidador.Size = New System.Drawing.Size(104, 22)
        Me.txtcodigoValidador.TabIndex = 45
        Me.txtcodigoValidador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreValidador
        '
        Me.txtnombreValidador.Location = New System.Drawing.Point(225, 376)
        Me.txtnombreValidador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreValidador.Name = "txtnombreValidador"
        Me.txtnombreValidador.ReadOnly = True
        Me.txtnombreValidador.Size = New System.Drawing.Size(255, 22)
        Me.txtnombreValidador.TabIndex = 46
        '
        'txtcodigoObjeto
        '
        Me.txtcodigoObjeto.Location = New System.Drawing.Point(634, 377)
        Me.txtcodigoObjeto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoObjeto.Name = "txtcodigoObjeto"
        Me.txtcodigoObjeto.Size = New System.Drawing.Size(167, 22)
        Me.txtcodigoObjeto.TabIndex = 47
        Me.txtcodigoObjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfacturaTomaMuestra
        '
        Me.txtfacturaTomaMuestra.Location = New System.Drawing.Point(415, 416)
        Me.txtfacturaTomaMuestra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtfacturaTomaMuestra.Name = "txtfacturaTomaMuestra"
        Me.txtfacturaTomaMuestra.Size = New System.Drawing.Size(385, 22)
        Me.txtfacturaTomaMuestra.TabIndex = 48
        Me.txtfacturaTomaMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttecnicoLab
        '
        Me.txttecnicoLab.Location = New System.Drawing.Point(415, 447)
        Me.txttecnicoLab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttecnicoLab.Name = "txttecnicoLab"
        Me.txttecnicoLab.Size = New System.Drawing.Size(385, 22)
        Me.txttecnicoLab.TabIndex = 49
        Me.txttecnicoLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpmUsuario
        '
        Me.txtpmUsuario.Location = New System.Drawing.Point(1199, 159)
        Me.txtpmUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpmUsuario.Name = "txtpmUsuario"
        Me.txtpmUsuario.ReadOnly = True
        Me.txtpmUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtpmUsuario.TabIndex = 50
        Me.txtpmUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnpUsuario
        '
        Me.txtnpUsuario.Location = New System.Drawing.Point(1199, 187)
        Me.txtnpUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnpUsuario.Name = "txtnpUsuario"
        Me.txtnpUsuario.ReadOnly = True
        Me.txtnpUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtnpUsuario.TabIndex = 57
        Me.txtnpUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtepUsuario
        '
        Me.txtepUsuario.Location = New System.Drawing.Point(1199, 215)
        Me.txtepUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtepUsuario.Name = "txtepUsuario"
        Me.txtepUsuario.ReadOnly = True
        Me.txtepUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtepUsuario.TabIndex = 60
        Me.txtepUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprUsuario
        '
        Me.txtprUsuario.Location = New System.Drawing.Point(1199, 243)
        Me.txtprUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprUsuario.Name = "txtprUsuario"
        Me.txtprUsuario.ReadOnly = True
        Me.txtprUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtprUsuario.TabIndex = 63
        Me.txtprUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcoUsuario
        '
        Me.txtcoUsuario.Location = New System.Drawing.Point(1199, 271)
        Me.txtcoUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcoUsuario.Name = "txtcoUsuario"
        Me.txtcoUsuario.ReadOnly = True
        Me.txtcoUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtcoUsuario.TabIndex = 66
        Me.txtcoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtenUsuario
        '
        Me.txtenUsuario.Location = New System.Drawing.Point(1199, 299)
        Me.txtenUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtenUsuario.Name = "txtenUsuario"
        Me.txtenUsuario.ReadOnly = True
        Me.txtenUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtenUsuario.TabIndex = 69
        Me.txtenUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinUsuario
        '
        Me.txtinUsuario.Location = New System.Drawing.Point(1199, 327)
        Me.txtinUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtinUsuario.Name = "txtinUsuario"
        Me.txtinUsuario.ReadOnly = True
        Me.txtinUsuario.Size = New System.Drawing.Size(135, 22)
        Me.txtinUsuario.TabIndex = 72
        Me.txtinUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpm
        '
        Me.lblpm.AutoSize = True
        Me.lblpm.Location = New System.Drawing.Point(841, 162)
        Me.lblpm.Name = "lblpm"
        Me.lblpm.Size = New System.Drawing.Size(28, 17)
        Me.lblpm.TabIndex = 75
        Me.lblpm.Text = "PM"
        '
        'lblnp
        '
        Me.lblnp.AutoSize = True
        Me.lblnp.Location = New System.Drawing.Point(841, 190)
        Me.lblnp.Name = "lblnp"
        Me.lblnp.Size = New System.Drawing.Size(27, 17)
        Me.lblnp.TabIndex = 76
        Me.lblnp.Text = "NP"
        '
        'lblep
        '
        Me.lblep.AutoSize = True
        Me.lblep.Location = New System.Drawing.Point(841, 219)
        Me.lblep.Name = "lblep"
        Me.lblep.Size = New System.Drawing.Size(26, 17)
        Me.lblep.TabIndex = 77
        Me.lblep.Text = "EP"
        '
        'lblpr
        '
        Me.lblpr.AutoSize = True
        Me.lblpr.Location = New System.Drawing.Point(841, 248)
        Me.lblpr.Name = "lblpr"
        Me.lblpr.Size = New System.Drawing.Size(27, 17)
        Me.lblpr.TabIndex = 78
        Me.lblpr.Text = "PR"
        '
        'lblco
        '
        Me.lblco.AutoSize = True
        Me.lblco.Location = New System.Drawing.Point(841, 276)
        Me.lblco.Name = "lblco"
        Me.lblco.Size = New System.Drawing.Size(28, 17)
        Me.lblco.TabIndex = 79
        Me.lblco.Text = "CO"
        '
        'lblen
        '
        Me.lblen.AutoSize = True
        Me.lblen.Location = New System.Drawing.Point(841, 304)
        Me.lblen.Name = "lblen"
        Me.lblen.Size = New System.Drawing.Size(27, 17)
        Me.lblen.TabIndex = 80
        Me.lblen.Text = "EN"
        '
        'lblin
        '
        Me.lblin.AutoSize = True
        Me.lblin.Location = New System.Drawing.Point(841, 331)
        Me.lblin.Name = "lblin"
        Me.lblin.Size = New System.Drawing.Size(21, 17)
        Me.lblin.TabIndex = 81
        Me.lblin.Text = "IN"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(243, 152)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.lblTelefono.TabIndex = 82
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(265, 185)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 83
        Me.lblEmail.Text = "Email"
        '
        'btnverGrafica
        '
        Me.btnverGrafica.Location = New System.Drawing.Point(267, 282)
        Me.btnverGrafica.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnverGrafica.Name = "btnverGrafica"
        Me.btnverGrafica.Size = New System.Drawing.Size(167, 23)
        Me.btnverGrafica.TabIndex = 84
        Me.btnverGrafica.Text = "Ver Gráfica"
        Me.btnverGrafica.UseVisualStyleBackColor = True
        '
        'rbtnpendienteMuestra
        '
        Me.rbtnpendienteMuestra.AutoSize = True
        Me.rbtnpendienteMuestra.Location = New System.Drawing.Point(635, 158)
        Me.rbtnpendienteMuestra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnpendienteMuestra.Name = "rbtnpendienteMuestra"
        Me.rbtnpendienteMuestra.Size = New System.Drawing.Size(148, 21)
        Me.rbtnpendienteMuestra.TabIndex = 85
        Me.rbtnpendienteMuestra.TabStop = True
        Me.rbtnpendienteMuestra.Text = "Pendiente Muestra"
        Me.rbtnpendienteMuestra.UseVisualStyleBackColor = True
        '
        'rbtnNoProcesado
        '
        Me.rbtnNoProcesado.AutoSize = True
        Me.rbtnNoProcesado.Location = New System.Drawing.Point(635, 185)
        Me.rbtnNoProcesado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnNoProcesado.Name = "rbtnNoProcesado"
        Me.rbtnNoProcesado.Size = New System.Drawing.Size(119, 21)
        Me.rbtnNoProcesado.TabIndex = 86
        Me.rbtnNoProcesado.TabStop = True
        Me.rbtnNoProcesado.Text = "No Procesado"
        Me.rbtnNoProcesado.UseVisualStyleBackColor = True
        '
        'rbtnEnProceso
        '
        Me.rbtnEnProceso.AutoSize = True
        Me.rbtnEnProceso.Location = New System.Drawing.Point(635, 212)
        Me.rbtnEnProceso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnEnProceso.Name = "rbtnEnProceso"
        Me.rbtnEnProceso.Size = New System.Drawing.Size(102, 21)
        Me.rbtnEnProceso.TabIndex = 87
        Me.rbtnEnProceso.TabStop = True
        Me.rbtnEnProceso.Text = "En Proceso"
        Me.rbtnEnProceso.UseVisualStyleBackColor = True
        '
        'rbtnProcesado
        '
        Me.rbtnProcesado.AutoSize = True
        Me.rbtnProcesado.Location = New System.Drawing.Point(635, 244)
        Me.rbtnProcesado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnProcesado.Name = "rbtnProcesado"
        Me.rbtnProcesado.Size = New System.Drawing.Size(97, 21)
        Me.rbtnProcesado.TabIndex = 88
        Me.rbtnProcesado.TabStop = True
        Me.rbtnProcesado.Text = "Procesado"
        Me.rbtnProcesado.UseVisualStyleBackColor = True
        '
        'rbtnValidado
        '
        Me.rbtnValidado.AutoSize = True
        Me.rbtnValidado.Location = New System.Drawing.Point(635, 272)
        Me.rbtnValidado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnValidado.Name = "rbtnValidado"
        Me.rbtnValidado.Size = New System.Drawing.Size(84, 21)
        Me.rbtnValidado.TabIndex = 89
        Me.rbtnValidado.TabStop = True
        Me.rbtnValidado.Text = "Validado"
        Me.rbtnValidado.UseVisualStyleBackColor = True
        '
        'rbtnEntregado
        '
        Me.rbtnEntregado.AutoSize = True
        Me.rbtnEntregado.Location = New System.Drawing.Point(635, 299)
        Me.rbtnEntregado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnEntregado.Name = "rbtnEntregado"
        Me.rbtnEntregado.Size = New System.Drawing.Size(95, 21)
        Me.rbtnEntregado.TabIndex = 90
        Me.rbtnEntregado.TabStop = True
        Me.rbtnEntregado.Text = "Entregado"
        Me.rbtnEntregado.UseVisualStyleBackColor = True
        '
        'rbtnInvalidado
        '
        Me.rbtnInvalidado.AutoSize = True
        Me.rbtnInvalidado.Location = New System.Drawing.Point(635, 328)
        Me.rbtnInvalidado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnInvalidado.Name = "rbtnInvalidado"
        Me.rbtnInvalidado.Size = New System.Drawing.Size(93, 21)
        Me.rbtnInvalidado.TabIndex = 91
        Me.rbtnInvalidado.TabStop = True
        Me.rbtnInvalidado.Text = "Invalidado"
        Me.rbtnInvalidado.UseVisualStyleBackColor = True
        '
        'cbxWs
        '
        Me.cbxWs.AutoSize = True
        Me.cbxWs.Location = New System.Drawing.Point(415, 478)
        Me.cbxWs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxWs.Name = "cbxWs"
        Me.cbxWs.Size = New System.Drawing.Size(107, 21)
        Me.cbxWs.TabIndex = 92
        Me.cbxWs.Text = "Enviada WS"
        Me.cbxWs.UseVisualStyleBackColor = True
        '
        'cbxEmail
        '
        Me.cbxEmail.AutoSize = True
        Me.cbxEmail.Location = New System.Drawing.Point(415, 505)
        Me.cbxEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxEmail.Name = "cbxEmail"
        Me.cbxEmail.Size = New System.Drawing.Size(119, 21)
        Me.cbxEmail.TabIndex = 93
        Me.cbxEmail.Text = "Enviada Email"
        Me.cbxEmail.UseVisualStyleBackColor = True
        '
        'cbxcortesia
        '
        Me.cbxcortesia.AutoSize = True
        Me.cbxcortesia.Location = New System.Drawing.Point(1026, 402)
        Me.cbxcortesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxcortesia.Name = "cbxcortesia"
        Me.cbxcortesia.Size = New System.Drawing.Size(82, 21)
        Me.cbxcortesia.TabIndex = 94
        Me.cbxcortesia.Text = "Cortesía"
        Me.cbxcortesia.UseVisualStyleBackColor = True
        '
        'cbxurgente
        '
        Me.cbxurgente.AutoSize = True
        Me.cbxurgente.Location = New System.Drawing.Point(1026, 429)
        Me.cbxurgente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxurgente.Name = "cbxurgente"
        Me.cbxurgente.Size = New System.Drawing.Size(81, 21)
        Me.cbxurgente.TabIndex = 95
        Me.cbxurgente.Text = "Urgente"
        Me.cbxurgente.UseVisualStyleBackColor = True
        '
        'cbxentregaMedico
        '
        Me.cbxentregaMedico.AutoSize = True
        Me.cbxentregaMedico.Location = New System.Drawing.Point(1026, 499)
        Me.cbxentregaMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxentregaMedico.Name = "cbxentregaMedico"
        Me.cbxentregaMedico.Size = New System.Drawing.Size(146, 21)
        Me.cbxentregaMedico.TabIndex = 96
        Me.cbxentregaMedico.Text = "Entregar a Médico"
        Me.cbxentregaMedico.UseVisualStyleBackColor = True
        '
        'cbxentregaPaciente
        '
        Me.cbxentregaPaciente.AutoSize = True
        Me.cbxentregaPaciente.Location = New System.Drawing.Point(1026, 526)
        Me.cbxentregaPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxentregaPaciente.Name = "cbxentregaPaciente"
        Me.cbxentregaPaciente.Size = New System.Drawing.Size(156, 21)
        Me.cbxentregaPaciente.TabIndex = 97
        Me.cbxentregaPaciente.Text = "Entregar a Paciente"
        Me.cbxentregaPaciente.UseVisualStyleBackColor = True
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(1107, 370)
        Me.dtpFechaEntrega.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(152, 22)
        Me.dtpFechaEntrega.TabIndex = 116
        Me.dtpFechaEntrega.Value = New Date(2020, 10, 29, 0, 0, 0, 0)
        '
        'lblEstadoOrden
        '
        Me.lblEstadoOrden.AutoSize = True
        Me.lblEstadoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoOrden.Location = New System.Drawing.Point(671, 128)
        Me.lblEstadoOrden.Name = "lblEstadoOrden"
        Me.lblEstadoOrden.Size = New System.Drawing.Size(152, 17)
        Me.lblEstadoOrden.TabIndex = 99
        Me.lblEstadoOrden.Text = "__________________"
        Me.lblEstadoOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbllinea2
        '
        Me.lbllinea2.AutoSize = True
        Me.lbllinea2.Location = New System.Drawing.Point(1107, 466)
        Me.lbllinea2.Name = "lbllinea2"
        Me.lbllinea2.Size = New System.Drawing.Size(152, 17)
        Me.lbllinea2.TabIndex = 100
        Me.lbllinea2.Text = "__________________"
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Descripcion, Me.Resultado, Me.Unidad, Me.Estado})
        Me.dgvResultados.Location = New System.Drawing.Point(13, 567)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowHeadersWidth = 51
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.Size = New System.Drawing.Size(1373, 215)
        Me.dgvResultados.TabIndex = 101
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "Resultado"
        Me.Resultado.MinimumWidth = 6
        Me.Resultado.Name = "Resultado"
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.MinimumWidth = 6
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'dtpPmFecha
        '
        Me.dtpPmFecha.Enabled = False
        Me.dtpPmFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPmFecha.Location = New System.Drawing.Point(883, 157)
        Me.dtpPmFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpPmFecha.Name = "dtpPmFecha"
        Me.dtpPmFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpPmFecha.TabIndex = 102
        '
        'dtpPmHora
        '
        Me.dtpPmHora.Enabled = False
        Me.dtpPmHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpPmHora.Location = New System.Drawing.Point(1041, 157)
        Me.dtpPmHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpPmHora.Name = "dtpPmHora"
        Me.dtpPmHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpPmHora.TabIndex = 103
        '
        'dtpNpHora
        '
        Me.dtpNpHora.Enabled = False
        Me.dtpNpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpNpHora.Location = New System.Drawing.Point(1041, 185)
        Me.dtpNpHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpNpHora.Name = "dtpNpHora"
        Me.dtpNpHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpNpHora.TabIndex = 105
        '
        'dtpNpFecha
        '
        Me.dtpNpFecha.Enabled = False
        Me.dtpNpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNpFecha.Location = New System.Drawing.Point(883, 185)
        Me.dtpNpFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpNpFecha.Name = "dtpNpFecha"
        Me.dtpNpFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpNpFecha.TabIndex = 104
        '
        'dtpEpHora
        '
        Me.dtpEpHora.Enabled = False
        Me.dtpEpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEpHora.Location = New System.Drawing.Point(1041, 215)
        Me.dtpEpHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEpHora.Name = "dtpEpHora"
        Me.dtpEpHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpEpHora.TabIndex = 107
        '
        'dtpEpFecha
        '
        Me.dtpEpFecha.Enabled = False
        Me.dtpEpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEpFecha.Location = New System.Drawing.Point(883, 215)
        Me.dtpEpFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEpFecha.Name = "dtpEpFecha"
        Me.dtpEpFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpEpFecha.TabIndex = 106
        '
        'dtpPrHora
        '
        Me.dtpPrHora.Enabled = False
        Me.dtpPrHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpPrHora.Location = New System.Drawing.Point(1041, 243)
        Me.dtpPrHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpPrHora.Name = "dtpPrHora"
        Me.dtpPrHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpPrHora.TabIndex = 109
        '
        'dtpPrFecha
        '
        Me.dtpPrFecha.Enabled = False
        Me.dtpPrFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPrFecha.Location = New System.Drawing.Point(883, 243)
        Me.dtpPrFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpPrFecha.Name = "dtpPrFecha"
        Me.dtpPrFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpPrFecha.TabIndex = 108
        '
        'dtpCoHora
        '
        Me.dtpCoHora.Enabled = False
        Me.dtpCoHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCoHora.Location = New System.Drawing.Point(1041, 272)
        Me.dtpCoHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpCoHora.Name = "dtpCoHora"
        Me.dtpCoHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpCoHora.TabIndex = 111
        '
        'dtpCoFecha
        '
        Me.dtpCoFecha.Enabled = False
        Me.dtpCoFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCoFecha.Location = New System.Drawing.Point(883, 272)
        Me.dtpCoFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpCoFecha.Name = "dtpCoFecha"
        Me.dtpCoFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpCoFecha.TabIndex = 110
        '
        'dtpEnHora
        '
        Me.dtpEnHora.Enabled = False
        Me.dtpEnHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnHora.Location = New System.Drawing.Point(1041, 299)
        Me.dtpEnHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEnHora.Name = "dtpEnHora"
        Me.dtpEnHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpEnHora.TabIndex = 113
        '
        'dtpEnFecha
        '
        Me.dtpEnFecha.Enabled = False
        Me.dtpEnFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnFecha.Location = New System.Drawing.Point(883, 299)
        Me.dtpEnFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEnFecha.Name = "dtpEnFecha"
        Me.dtpEnFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpEnFecha.TabIndex = 112
        '
        'dtpInHora
        '
        Me.dtpInHora.Enabled = False
        Me.dtpInHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpInHora.Location = New System.Drawing.Point(1041, 327)
        Me.dtpInHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpInHora.Name = "dtpInHora"
        Me.dtpInHora.Size = New System.Drawing.Size(135, 22)
        Me.dtpInHora.TabIndex = 115
        '
        'dtpInFecha
        '
        Me.dtpInFecha.Enabled = False
        Me.dtpInFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInFecha.Location = New System.Drawing.Point(883, 327)
        Me.dtpInFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpInFecha.Name = "dtpInFecha"
        Me.dtpInFecha.Size = New System.Drawing.Size(135, 22)
        Me.dtpInFecha.TabIndex = 114
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(1062, 53)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(120, 22)
        Me.dtpFechaFactura.TabIndex = 116
        '
        'dtpHoraFactura
        '
        Me.dtpHoraFactura.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFactura.Location = New System.Drawing.Point(1199, 54)
        Me.dtpHoraFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpHoraFactura.Name = "dtpHoraFactura"
        Me.dtpHoraFactura.Size = New System.Drawing.Size(141, 22)
        Me.dtpHoraFactura.TabIndex = 117
        '
        'lblpmUsuario
        '
        Me.lblpmUsuario.AutoSize = True
        Me.lblpmUsuario.Location = New System.Drawing.Point(1340, 160)
        Me.lblpmUsuario.Name = "lblpmUsuario"
        Me.lblpmUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblpmUsuario.TabIndex = 118
        Me.lblpmUsuario.Text = "Label1"
        Me.lblpmUsuario.Visible = False
        '
        'lblnpUsuario
        '
        Me.lblnpUsuario.AutoSize = True
        Me.lblnpUsuario.Location = New System.Drawing.Point(1340, 192)
        Me.lblnpUsuario.Name = "lblnpUsuario"
        Me.lblnpUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblnpUsuario.TabIndex = 119
        Me.lblnpUsuario.Text = "Label1"
        Me.lblnpUsuario.Visible = False
        '
        'lblepUsuario
        '
        Me.lblepUsuario.AutoSize = True
        Me.lblepUsuario.Location = New System.Drawing.Point(1340, 219)
        Me.lblepUsuario.Name = "lblepUsuario"
        Me.lblepUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblepUsuario.TabIndex = 120
        Me.lblepUsuario.Text = "Label1"
        Me.lblepUsuario.Visible = False
        '
        'lblprUsuario
        '
        Me.lblprUsuario.AutoSize = True
        Me.lblprUsuario.Location = New System.Drawing.Point(1340, 246)
        Me.lblprUsuario.Name = "lblprUsuario"
        Me.lblprUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblprUsuario.TabIndex = 121
        Me.lblprUsuario.Text = "Label1"
        Me.lblprUsuario.Visible = False
        '
        'lblcoUsuario
        '
        Me.lblcoUsuario.AutoSize = True
        Me.lblcoUsuario.Location = New System.Drawing.Point(1340, 274)
        Me.lblcoUsuario.Name = "lblcoUsuario"
        Me.lblcoUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblcoUsuario.TabIndex = 122
        Me.lblcoUsuario.Text = "Label1"
        Me.lblcoUsuario.Visible = False
        '
        'lblenUsuario
        '
        Me.lblenUsuario.AutoSize = True
        Me.lblenUsuario.Location = New System.Drawing.Point(1340, 304)
        Me.lblenUsuario.Name = "lblenUsuario"
        Me.lblenUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblenUsuario.TabIndex = 123
        Me.lblenUsuario.Text = "Label1"
        Me.lblenUsuario.Visible = False
        '
        'lblinUsuario
        '
        Me.lblinUsuario.AutoSize = True
        Me.lblinUsuario.Location = New System.Drawing.Point(1340, 328)
        Me.lblinUsuario.Name = "lblinUsuario"
        Me.lblinUsuario.Size = New System.Drawing.Size(51, 17)
        Me.lblinUsuario.TabIndex = 124
        Me.lblinUsuario.Text = "Label1"
        Me.lblinUsuario.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(981, 11)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(219, 34)
        Me.btnActualizar.TabIndex = 125
        Me.btnActualizar.Text = "Actualizar Estado"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblcodigoCajero
        '
        Me.lblcodigoCajero.AutoSize = True
        Me.lblcodigoCajero.Location = New System.Drawing.Point(861, 83)
        Me.lblcodigoCajero.Name = "lblcodigoCajero"
        Me.lblcodigoCajero.Size = New System.Drawing.Size(51, 17)
        Me.lblcodigoCajero.TabIndex = 126
        Me.lblcodigoCajero.Text = "Label1"
        Me.lblcodigoCajero.Visible = False
        '
        'E_OrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1403, 794)
        Me.Controls.Add(Me.lblcodigoCajero)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblinUsuario)
        Me.Controls.Add(Me.lblenUsuario)
        Me.Controls.Add(Me.lblcoUsuario)
        Me.Controls.Add(Me.lblprUsuario)
        Me.Controls.Add(Me.lblepUsuario)
        Me.Controls.Add(Me.lblnpUsuario)
        Me.Controls.Add(Me.lblpmUsuario)
        Me.Controls.Add(Me.dtpHoraFactura)
        Me.Controls.Add(Me.dtpFechaFactura)
        Me.Controls.Add(Me.dtpInHora)
        Me.Controls.Add(Me.dtpInFecha)
        Me.Controls.Add(Me.dtpEnHora)
        Me.Controls.Add(Me.dtpEnFecha)
        Me.Controls.Add(Me.dtpCoHora)
        Me.Controls.Add(Me.dtpCoFecha)
        Me.Controls.Add(Me.dtpPrHora)
        Me.Controls.Add(Me.dtpPrFecha)
        Me.Controls.Add(Me.dtpEpHora)
        Me.Controls.Add(Me.dtpEpFecha)
        Me.Controls.Add(Me.dtpNpHora)
        Me.Controls.Add(Me.dtpNpFecha)
        Me.Controls.Add(Me.dtpPmHora)
        Me.Controls.Add(Me.dtpPmFecha)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.lbllinea2)
        Me.Controls.Add(Me.lblEstadoOrden)
        Me.Controls.Add(Me.dtpFechaEntrega)
        Me.Controls.Add(Me.cbxentregaPaciente)
        Me.Controls.Add(Me.cbxentregaMedico)
        Me.Controls.Add(Me.cbxurgente)
        Me.Controls.Add(Me.cbxcortesia)
        Me.Controls.Add(Me.cbxEmail)
        Me.Controls.Add(Me.cbxWs)
        Me.Controls.Add(Me.rbtnInvalidado)
        Me.Controls.Add(Me.rbtnEntregado)
        Me.Controls.Add(Me.rbtnValidado)
        Me.Controls.Add(Me.rbtnProcesado)
        Me.Controls.Add(Me.rbtnEnProceso)
        Me.Controls.Add(Me.rbtnNoProcesado)
        Me.Controls.Add(Me.rbtnpendienteMuestra)
        Me.Controls.Add(Me.btnverGrafica)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblin)
        Me.Controls.Add(Me.lblen)
        Me.Controls.Add(Me.lblco)
        Me.Controls.Add(Me.lblpr)
        Me.Controls.Add(Me.lblep)
        Me.Controls.Add(Me.lblnp)
        Me.Controls.Add(Me.lblpm)
        Me.Controls.Add(Me.txtinUsuario)
        Me.Controls.Add(Me.txtenUsuario)
        Me.Controls.Add(Me.txtcoUsuario)
        Me.Controls.Add(Me.txtprUsuario)
        Me.Controls.Add(Me.txtepUsuario)
        Me.Controls.Add(Me.txtnpUsuario)
        Me.Controls.Add(Me.txtpmUsuario)
        Me.Controls.Add(Me.txttecnicoLab)
        Me.Controls.Add(Me.txtfacturaTomaMuestra)
        Me.Controls.Add(Me.txtcodigoObjeto)
        Me.Controls.Add(Me.txtnombreValidador)
        Me.Controls.Add(Me.txtcodigoValidador)
        Me.Controls.Add(Me.txtnombreTecnico)
        Me.Controls.Add(Me.txtcodigoTecnico)
        Me.Controls.Add(Me.txtnombreSede)
        Me.Controls.Add(Me.txtsede)
        Me.Controls.Add(Me.txtcurva)
        Me.Controls.Add(Me.txtnombreMedico)
        Me.Controls.Add(Me.txtcodigoMedico)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtgenero)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txtnombrePaciente)
        Me.Controls.Add(Me.txtcodigoPaciente)
        Me.Controls.Add(Me.txtcodigoSucursal)
        Me.Controls.Add(Me.txtcodigoSubArea)
        Me.Controls.Add(Me.txtcodigoCajero)
        Me.Controls.Add(Me.txtnumeroFactura)
        Me.Controls.Add(Me.txtcodigoArea)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblresultados)
        Me.Controls.Add(Me.lblfechaEntrega)
        Me.Controls.Add(Me.lblTecnicoLab)
        Me.Controls.Add(Me.lblFacturaToma)
        Me.Controls.Add(Me.lblanalizador)
        Me.Controls.Add(Me.lblValidador)
        Me.Controls.Add(Me.lblTecnico)
        Me.Controls.Add(Me.lblSede)
        Me.Controls.Add(Me.lblCurva)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.lblsubArea)
        Me.Controls.Add(Me.lblcreadoPor)
        Me.Controls.Add(Me.lblFacturaNum)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.lblnumero)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "E_OrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Trabajo"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnumero As Label
    Friend WithEvents lblarea As Label
    Friend WithEvents lblFacturaNum As Label
    Friend WithEvents lblcreadoPor As Label
    Friend WithEvents lblsubArea As Label
    Friend WithEvents lblSucursal As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblEdad As Label
    Friend WithEvents lblestado As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblMedico As Label
    Friend WithEvents lblCurva As Label
    Friend WithEvents lblSede As Label
    Friend WithEvents lblTecnico As Label
    Friend WithEvents lblValidador As Label
    Friend WithEvents lblanalizador As Label
    Friend WithEvents lblFacturaToma As Label
    Friend WithEvents lblTecnicoLab As Label
    Friend WithEvents lblfechaEntrega As Label
    Friend WithEvents lblresultados As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents txtcodigoArea As TextBox
    Friend WithEvents txtnumeroFactura As TextBox
    Friend WithEvents txtcodigoCajero As TextBox
    Friend WithEvents txtcodigoSubArea As TextBox
    Friend WithEvents txtcodigoSucursal As TextBox
    Friend WithEvents txtcodigoPaciente As TextBox
    Friend WithEvents txtnombrePaciente As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtgenero As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtcodigoMedico As TextBox
    Friend WithEvents txtnombreMedico As TextBox
    Friend WithEvents txtcurva As TextBox
    Friend WithEvents txtsede As TextBox
    Friend WithEvents txtnombreSede As TextBox
    Friend WithEvents txtcodigoTecnico As TextBox
    Friend WithEvents txtnombreTecnico As TextBox
    Friend WithEvents txtcodigoValidador As TextBox
    Friend WithEvents txtnombreValidador As TextBox
    Friend WithEvents txtcodigoObjeto As TextBox
    Friend WithEvents txtfacturaTomaMuestra As TextBox
    Friend WithEvents txttecnicoLab As TextBox
    Friend WithEvents txtpmUsuario As TextBox
    Friend WithEvents txtnpUsuario As TextBox
    Friend WithEvents txtepUsuario As TextBox
    Friend WithEvents txtprUsuario As TextBox
    Friend WithEvents txtcoUsuario As TextBox
    Friend WithEvents txtenUsuario As TextBox
    Friend WithEvents txtinUsuario As TextBox
    Friend WithEvents lblpm As Label
    Friend WithEvents lblnp As Label
    Friend WithEvents lblep As Label
    Friend WithEvents lblpr As Label
    Friend WithEvents lblco As Label
    Friend WithEvents lblen As Label
    Friend WithEvents lblin As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnverGrafica As Button
    Friend WithEvents rbtnpendienteMuestra As RadioButton
    Friend WithEvents rbtnNoProcesado As RadioButton
    Friend WithEvents rbtnEnProceso As RadioButton
    Friend WithEvents rbtnProcesado As RadioButton
    Friend WithEvents rbtnValidado As RadioButton
    Friend WithEvents rbtnEntregado As RadioButton
    Friend WithEvents rbtnInvalidado As RadioButton
    Friend WithEvents cbxWs As CheckBox
    Friend WithEvents cbxEmail As CheckBox
    Friend WithEvents cbxcortesia As CheckBox
    Friend WithEvents cbxurgente As CheckBox
    Friend WithEvents cbxentregaMedico As CheckBox
    Friend WithEvents cbxentregaPaciente As CheckBox
    Friend WithEvents dtpFechaEntrega As DateTimePicker
    Friend WithEvents lblEstadoOrden As Label
    Friend WithEvents lbllinea2 As Label
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents dtpPmFecha As DateTimePicker
    Friend WithEvents dtpPmHora As DateTimePicker
    Friend WithEvents dtpNpHora As DateTimePicker
    Friend WithEvents dtpNpFecha As DateTimePicker
    Friend WithEvents dtpEpHora As DateTimePicker
    Friend WithEvents dtpEpFecha As DateTimePicker
    Friend WithEvents dtpPrHora As DateTimePicker
    Friend WithEvents dtpPrFecha As DateTimePicker
    Friend WithEvents dtpCoHora As DateTimePicker
    Friend WithEvents dtpCoFecha As DateTimePicker
    Friend WithEvents dtpEnHora As DateTimePicker
    Friend WithEvents dtpEnFecha As DateTimePicker
    Friend WithEvents dtpInHora As DateTimePicker
    Friend WithEvents dtpInFecha As DateTimePicker
    Friend WithEvents dtpFechaFactura As DateTimePicker
    Friend WithEvents dtpHoraFactura As DateTimePicker
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents lblpmUsuario As Label
    Friend WithEvents lblnpUsuario As Label
    Friend WithEvents lblepUsuario As Label
    Friend WithEvents lblprUsuario As Label
    Friend WithEvents lblcoUsuario As Label
    Friend WithEvents lblenUsuario As Label
    Friend WithEvents lblinUsuario As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblcodigoCajero As Label
End Class
