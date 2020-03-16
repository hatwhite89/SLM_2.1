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
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(51, 24)
        Me.lblnumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(27, 13)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "Nro."
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Location = New System.Drawing.Point(224, 21)
        Me.lblarea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(29, 13)
        Me.lblarea.TabIndex = 1
        Me.lblarea.Text = "Área"
        '
        'lblFacturaNum
        '
        Me.lblFacturaNum.AutoSize = True
        Me.lblFacturaNum.Location = New System.Drawing.Point(385, 24)
        Me.lblFacturaNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFacturaNum.Name = "lblFacturaNum"
        Me.lblFacturaNum.Size = New System.Drawing.Size(90, 13)
        Me.lblFacturaNum.TabIndex = 2
        Me.lblFacturaNum.Text = "Factura Nro. /Fila"
        '
        'lblcreadoPor
        '
        Me.lblcreadoPor.AutoSize = True
        Me.lblcreadoPor.Location = New System.Drawing.Point(632, 25)
        Me.lblcreadoPor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcreadoPor.Name = "lblcreadoPor"
        Me.lblcreadoPor.Size = New System.Drawing.Size(60, 13)
        Me.lblcreadoPor.TabIndex = 3
        Me.lblcreadoPor.Text = "Creado Por"
        '
        'lblsubArea
        '
        Me.lblsubArea.AutoSize = True
        Me.lblsubArea.Location = New System.Drawing.Point(202, 46)
        Me.lblsubArea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsubArea.Name = "lblsubArea"
        Me.lblsubArea.Size = New System.Drawing.Size(51, 13)
        Me.lblsubArea.TabIndex = 5
        Me.lblsubArea.Text = "Sub Área"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(425, 50)
        Me.lblSucursal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.Text = "Sucursal"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(38, 76)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "Código"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(46, 103)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 8
        Me.lblEdad.Text = "Edad"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(464, 84)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(40, 13)
        Me.lblestado.TabIndex = 9
        Me.lblestado.Text = "Estado"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(695, 84)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(813, 84)
        Me.lblhora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(30, 13)
        Me.lblhora.TabIndex = 11
        Me.lblhora.Text = "Hora"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(926, 86)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.lblusuario.TabIndex = 12
        Me.lblusuario.Text = "Usuario"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(35, 132)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(42, 13)
        Me.lblGenero.TabIndex = 13
        Me.lblGenero.Text = "Genero"
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Location = New System.Drawing.Point(38, 160)
        Me.lblMedico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(42, 13)
        Me.lblMedico.TabIndex = 14
        Me.lblMedico.Text = "Médico"
        '
        'lblCurva
        '
        Me.lblCurva.AutoSize = True
        Me.lblCurva.Location = New System.Drawing.Point(44, 214)
        Me.lblCurva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurva.Name = "lblCurva"
        Me.lblCurva.Size = New System.Drawing.Size(35, 13)
        Me.lblCurva.TabIndex = 15
        Me.lblCurva.Text = "Curva"
        '
        'lblSede
        '
        Me.lblSede.AutoSize = True
        Me.lblSede.Location = New System.Drawing.Point(46, 237)
        Me.lblSede.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(32, 13)
        Me.lblSede.TabIndex = 16
        Me.lblSede.Text = "Sede"
        '
        'lblTecnico
        '
        Me.lblTecnico.AutoSize = True
        Me.lblTecnico.Location = New System.Drawing.Point(34, 265)
        Me.lblTecnico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(46, 13)
        Me.lblTecnico.TabIndex = 17
        Me.lblTecnico.Text = "Técnico"
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Location = New System.Drawing.Point(26, 287)
        Me.lblValidador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(51, 13)
        Me.lblValidador.TabIndex = 18
        Me.lblValidador.Text = "Validador"
        '
        'lblanalizador
        '
        Me.lblanalizador.AutoSize = True
        Me.lblanalizador.Location = New System.Drawing.Point(416, 288)
        Me.lblanalizador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblanalizador.Name = "lblanalizador"
        Me.lblanalizador.Size = New System.Drawing.Size(56, 13)
        Me.lblanalizador.TabIndex = 19
        Me.lblanalizador.Text = "Analizador"
        '
        'lblFacturaToma
        '
        Me.lblFacturaToma.AutoSize = True
        Me.lblFacturaToma.Location = New System.Drawing.Point(168, 318)
        Me.lblFacturaToma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFacturaToma.Name = "lblFacturaToma"
        Me.lblFacturaToma.Size = New System.Drawing.Size(137, 13)
        Me.lblFacturaToma.TabIndex = 20
        Me.lblFacturaToma.Text = "Factura y Toma de Muestra"
        '
        'lblTecnicoLab
        '
        Me.lblTecnicoLab.AutoSize = True
        Me.lblTecnicoLab.Location = New System.Drawing.Point(188, 345)
        Me.lblTecnicoLab.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTecnicoLab.Name = "lblTecnicoLab"
        Me.lblTecnicoLab.Size = New System.Drawing.Size(117, 13)
        Me.lblTecnicoLab.TabIndex = 21
        Me.lblTecnicoLab.Text = "Técnico de Laboratorio"
        '
        'lblfechaEntrega
        '
        Me.lblfechaEntrega.AutoSize = True
        Me.lblfechaEntrega.Location = New System.Drawing.Point(719, 283)
        Me.lblfechaEntrega.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfechaEntrega.Name = "lblfechaEntrega"
        Me.lblfechaEntrega.Size = New System.Drawing.Size(110, 13)
        Me.lblfechaEntrega.TabIndex = 22
        Me.lblfechaEntrega.Text = "Fecha Entrega Aprox."
        '
        'lblresultados
        '
        Me.lblresultados.AutoSize = True
        Me.lblresultados.Location = New System.Drawing.Point(769, 359)
        Me.lblresultados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblresultados.Name = "lblresultados"
        Me.lblresultados.Size = New System.Drawing.Size(60, 13)
        Me.lblresultados.TabIndex = 23
        Me.lblresultados.Text = "Resultados"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(85, 21)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(126, 20)
        Me.txtnumero.TabIndex = 24
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoArea
        '
        Me.txtcodigoArea.Location = New System.Drawing.Point(266, 21)
        Me.txtcodigoArea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoArea.Name = "txtcodigoArea"
        Me.txtcodigoArea.Size = New System.Drawing.Size(97, 20)
        Me.txtcodigoArea.TabIndex = 25
        Me.txtcodigoArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroFactura
        '
        Me.txtnumeroFactura.Location = New System.Drawing.Point(477, 21)
        Me.txtnumeroFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroFactura.Name = "txtnumeroFactura"
        Me.txtnumeroFactura.Size = New System.Drawing.Size(126, 20)
        Me.txtnumeroFactura.TabIndex = 26
        Me.txtnumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCajero
        '
        Me.txtcodigoCajero.Location = New System.Drawing.Point(697, 23)
        Me.txtcodigoCajero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCajero.Name = "txtcodigoCajero"
        Me.txtcodigoCajero.Size = New System.Drawing.Size(93, 20)
        Me.txtcodigoCajero.TabIndex = 27
        Me.txtcodigoCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSubArea
        '
        Me.txtcodigoSubArea.Location = New System.Drawing.Point(266, 46)
        Me.txtcodigoSubArea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoSubArea.Name = "txtcodigoSubArea"
        Me.txtcodigoSubArea.Size = New System.Drawing.Size(97, 20)
        Me.txtcodigoSubArea.TabIndex = 30
        Me.txtcodigoSubArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSucursal
        '
        Me.txtcodigoSucursal.Location = New System.Drawing.Point(477, 47)
        Me.txtcodigoSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoSucursal.Name = "txtcodigoSucursal"
        Me.txtcodigoSucursal.Size = New System.Drawing.Size(126, 20)
        Me.txtcodigoSucursal.TabIndex = 31
        Me.txtcodigoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoPaciente
        '
        Me.txtcodigoPaciente.Location = New System.Drawing.Point(85, 73)
        Me.txtcodigoPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoPaciente.Name = "txtcodigoPaciente"
        Me.txtcodigoPaciente.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoPaciente.TabIndex = 32
        Me.txtcodigoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombrePaciente
        '
        Me.txtnombrePaciente.Location = New System.Drawing.Point(170, 73)
        Me.txtnombrePaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombrePaciente.Name = "txtnombrePaciente"
        Me.txtnombrePaciente.ReadOnly = True
        Me.txtnombrePaciente.Size = New System.Drawing.Size(192, 20)
        Me.txtnombrePaciente.TabIndex = 33
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(85, 101)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(79, 20)
        Me.txtedad.TabIndex = 34
        Me.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(236, 101)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(126, 20)
        Me.txttelefono.TabIndex = 35
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(85, 128)
        Me.txtgenero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(79, 20)
        Me.txtgenero.TabIndex = 36
        Me.txtgenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(236, 128)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(126, 20)
        Me.txtemail.TabIndex = 37
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoMedico
        '
        Me.txtcodigoMedico.Location = New System.Drawing.Point(85, 156)
        Me.txtcodigoMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoMedico.Name = "txtcodigoMedico"
        Me.txtcodigoMedico.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoMedico.TabIndex = 38
        Me.txtcodigoMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreMedico
        '
        Me.txtnombreMedico.Location = New System.Drawing.Point(170, 157)
        Me.txtnombreMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreMedico.Name = "txtnombreMedico"
        Me.txtnombreMedico.ReadOnly = True
        Me.txtnombreMedico.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreMedico.TabIndex = 39
        '
        'txtcurva
        '
        Me.txtcurva.Location = New System.Drawing.Point(85, 210)
        Me.txtcurva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcurva.Name = "txtcurva"
        Me.txtcurva.Size = New System.Drawing.Size(79, 20)
        Me.txtcurva.TabIndex = 40
        Me.txtcurva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsede
        '
        Me.txtsede.Location = New System.Drawing.Point(85, 235)
        Me.txtsede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtsede.Name = "txtsede"
        Me.txtsede.Size = New System.Drawing.Size(79, 20)
        Me.txtsede.TabIndex = 41
        Me.txtsede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreSede
        '
        Me.txtnombreSede.Location = New System.Drawing.Point(170, 235)
        Me.txtnombreSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreSede.Name = "txtnombreSede"
        Me.txtnombreSede.ReadOnly = True
        Me.txtnombreSede.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreSede.TabIndex = 42
        '
        'txtcodigoTecnico
        '
        Me.txtcodigoTecnico.Location = New System.Drawing.Point(85, 260)
        Me.txtcodigoTecnico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTecnico.Name = "txtcodigoTecnico"
        Me.txtcodigoTecnico.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoTecnico.TabIndex = 43
        Me.txtcodigoTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreTecnico
        '
        Me.txtnombreTecnico.Location = New System.Drawing.Point(170, 261)
        Me.txtnombreTecnico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreTecnico.Name = "txtnombreTecnico"
        Me.txtnombreTecnico.ReadOnly = True
        Me.txtnombreTecnico.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreTecnico.TabIndex = 44
        '
        'txtcodigoValidador
        '
        Me.txtcodigoValidador.Location = New System.Drawing.Point(85, 284)
        Me.txtcodigoValidador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoValidador.Name = "txtcodigoValidador"
        Me.txtcodigoValidador.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoValidador.TabIndex = 45
        Me.txtcodigoValidador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreValidador
        '
        Me.txtnombreValidador.Location = New System.Drawing.Point(170, 285)
        Me.txtnombreValidador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreValidador.Name = "txtnombreValidador"
        Me.txtnombreValidador.ReadOnly = True
        Me.txtnombreValidador.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreValidador.TabIndex = 46
        '
        'txtcodigoObjeto
        '
        Me.txtcodigoObjeto.Location = New System.Drawing.Point(477, 286)
        Me.txtcodigoObjeto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoObjeto.Name = "txtcodigoObjeto"
        Me.txtcodigoObjeto.Size = New System.Drawing.Size(126, 20)
        Me.txtcodigoObjeto.TabIndex = 47
        Me.txtcodigoObjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfacturaTomaMuestra
        '
        Me.txtfacturaTomaMuestra.Location = New System.Drawing.Point(313, 318)
        Me.txtfacturaTomaMuestra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfacturaTomaMuestra.Name = "txtfacturaTomaMuestra"
        Me.txtfacturaTomaMuestra.Size = New System.Drawing.Size(290, 20)
        Me.txtfacturaTomaMuestra.TabIndex = 48
        Me.txtfacturaTomaMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttecnicoLab
        '
        Me.txttecnicoLab.Location = New System.Drawing.Point(313, 343)
        Me.txttecnicoLab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttecnicoLab.Name = "txttecnicoLab"
        Me.txttecnicoLab.Size = New System.Drawing.Size(290, 20)
        Me.txttecnicoLab.TabIndex = 49
        Me.txttecnicoLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpmUsuario
        '
        Me.txtpmUsuario.Location = New System.Drawing.Point(901, 109)
        Me.txtpmUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpmUsuario.Name = "txtpmUsuario"
        Me.txtpmUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtpmUsuario.TabIndex = 50
        Me.txtpmUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnpUsuario
        '
        Me.txtnpUsuario.Location = New System.Drawing.Point(901, 132)
        Me.txtnpUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnpUsuario.Name = "txtnpUsuario"
        Me.txtnpUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtnpUsuario.TabIndex = 57
        Me.txtnpUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtepUsuario
        '
        Me.txtepUsuario.Location = New System.Drawing.Point(901, 154)
        Me.txtepUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtepUsuario.Name = "txtepUsuario"
        Me.txtepUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtepUsuario.TabIndex = 60
        Me.txtepUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprUsuario
        '
        Me.txtprUsuario.Location = New System.Drawing.Point(901, 177)
        Me.txtprUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtprUsuario.Name = "txtprUsuario"
        Me.txtprUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtprUsuario.TabIndex = 63
        Me.txtprUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcoUsuario
        '
        Me.txtcoUsuario.Location = New System.Drawing.Point(901, 200)
        Me.txtcoUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcoUsuario.Name = "txtcoUsuario"
        Me.txtcoUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtcoUsuario.TabIndex = 66
        Me.txtcoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtenUsuario
        '
        Me.txtenUsuario.Location = New System.Drawing.Point(901, 223)
        Me.txtenUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtenUsuario.Name = "txtenUsuario"
        Me.txtenUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtenUsuario.TabIndex = 69
        Me.txtenUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinUsuario
        '
        Me.txtinUsuario.Location = New System.Drawing.Point(901, 245)
        Me.txtinUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtinUsuario.Name = "txtinUsuario"
        Me.txtinUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtinUsuario.TabIndex = 72
        Me.txtinUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpm
        '
        Me.lblpm.AutoSize = True
        Me.lblpm.Location = New System.Drawing.Point(632, 111)
        Me.lblpm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpm.Name = "lblpm"
        Me.lblpm.Size = New System.Drawing.Size(23, 13)
        Me.lblpm.TabIndex = 75
        Me.lblpm.Text = "PM"
        '
        'lblnp
        '
        Me.lblnp.AutoSize = True
        Me.lblnp.Location = New System.Drawing.Point(632, 134)
        Me.lblnp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnp.Name = "lblnp"
        Me.lblnp.Size = New System.Drawing.Size(22, 13)
        Me.lblnp.TabIndex = 76
        Me.lblnp.Text = "NP"
        '
        'lblep
        '
        Me.lblep.AutoSize = True
        Me.lblep.Location = New System.Drawing.Point(632, 158)
        Me.lblep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblep.Name = "lblep"
        Me.lblep.Size = New System.Drawing.Size(21, 13)
        Me.lblep.TabIndex = 77
        Me.lblep.Text = "EP"
        '
        'lblpr
        '
        Me.lblpr.AutoSize = True
        Me.lblpr.Location = New System.Drawing.Point(632, 181)
        Me.lblpr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpr.Name = "lblpr"
        Me.lblpr.Size = New System.Drawing.Size(22, 13)
        Me.lblpr.TabIndex = 78
        Me.lblpr.Text = "PR"
        '
        'lblco
        '
        Me.lblco.AutoSize = True
        Me.lblco.Location = New System.Drawing.Point(632, 204)
        Me.lblco.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblco.Name = "lblco"
        Me.lblco.Size = New System.Drawing.Size(22, 13)
        Me.lblco.TabIndex = 79
        Me.lblco.Text = "CO"
        '
        'lblen
        '
        Me.lblen.AutoSize = True
        Me.lblen.Location = New System.Drawing.Point(632, 227)
        Me.lblen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblen.Name = "lblen"
        Me.lblen.Size = New System.Drawing.Size(22, 13)
        Me.lblen.TabIndex = 80
        Me.lblen.Text = "EN"
        '
        'lblin
        '
        Me.lblin.AutoSize = True
        Me.lblin.Location = New System.Drawing.Point(632, 249)
        Me.lblin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblin.Name = "lblin"
        Me.lblin.Size = New System.Drawing.Size(18, 13)
        Me.lblin.TabIndex = 81
        Me.lblin.Text = "IN"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(184, 103)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 82
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(200, 130)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 83
        Me.lblEmail.Text = "Email"
        '
        'btnverGrafica
        '
        Me.btnverGrafica.Location = New System.Drawing.Point(202, 209)
        Me.btnverGrafica.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnverGrafica.Name = "btnverGrafica"
        Me.btnverGrafica.Size = New System.Drawing.Size(125, 19)
        Me.btnverGrafica.TabIndex = 84
        Me.btnverGrafica.Text = "Ver Gráfica"
        Me.btnverGrafica.UseVisualStyleBackColor = True
        '
        'rbtnpendienteMuestra
        '
        Me.rbtnpendienteMuestra.AutoSize = True
        Me.rbtnpendienteMuestra.Location = New System.Drawing.Point(478, 108)
        Me.rbtnpendienteMuestra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnpendienteMuestra.Name = "rbtnpendienteMuestra"
        Me.rbtnpendienteMuestra.Size = New System.Drawing.Size(114, 17)
        Me.rbtnpendienteMuestra.TabIndex = 85
        Me.rbtnpendienteMuestra.TabStop = True
        Me.rbtnpendienteMuestra.Text = "Pendiente Muestra"
        Me.rbtnpendienteMuestra.UseVisualStyleBackColor = True
        '
        'rbtnNoProcesado
        '
        Me.rbtnNoProcesado.AutoSize = True
        Me.rbtnNoProcesado.Location = New System.Drawing.Point(478, 130)
        Me.rbtnNoProcesado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnNoProcesado.Name = "rbtnNoProcesado"
        Me.rbtnNoProcesado.Size = New System.Drawing.Size(93, 17)
        Me.rbtnNoProcesado.TabIndex = 86
        Me.rbtnNoProcesado.TabStop = True
        Me.rbtnNoProcesado.Text = "No Procesado"
        Me.rbtnNoProcesado.UseVisualStyleBackColor = True
        '
        'rbtnEnProceso
        '
        Me.rbtnEnProceso.AutoSize = True
        Me.rbtnEnProceso.Location = New System.Drawing.Point(478, 152)
        Me.rbtnEnProceso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnEnProceso.Name = "rbtnEnProceso"
        Me.rbtnEnProceso.Size = New System.Drawing.Size(80, 17)
        Me.rbtnEnProceso.TabIndex = 87
        Me.rbtnEnProceso.TabStop = True
        Me.rbtnEnProceso.Text = "En Proceso"
        Me.rbtnEnProceso.UseVisualStyleBackColor = True
        '
        'rbtnProcesado
        '
        Me.rbtnProcesado.AutoSize = True
        Me.rbtnProcesado.Location = New System.Drawing.Point(478, 178)
        Me.rbtnProcesado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnProcesado.Name = "rbtnProcesado"
        Me.rbtnProcesado.Size = New System.Drawing.Size(76, 17)
        Me.rbtnProcesado.TabIndex = 88
        Me.rbtnProcesado.TabStop = True
        Me.rbtnProcesado.Text = "Procesado"
        Me.rbtnProcesado.UseVisualStyleBackColor = True
        '
        'rbtnValidado
        '
        Me.rbtnValidado.AutoSize = True
        Me.rbtnValidado.Location = New System.Drawing.Point(478, 201)
        Me.rbtnValidado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnValidado.Name = "rbtnValidado"
        Me.rbtnValidado.Size = New System.Drawing.Size(66, 17)
        Me.rbtnValidado.TabIndex = 89
        Me.rbtnValidado.TabStop = True
        Me.rbtnValidado.Text = "Validado"
        Me.rbtnValidado.UseVisualStyleBackColor = True
        '
        'rbtnEntregado
        '
        Me.rbtnEntregado.AutoSize = True
        Me.rbtnEntregado.Location = New System.Drawing.Point(478, 223)
        Me.rbtnEntregado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnEntregado.Name = "rbtnEntregado"
        Me.rbtnEntregado.Size = New System.Drawing.Size(74, 17)
        Me.rbtnEntregado.TabIndex = 90
        Me.rbtnEntregado.TabStop = True
        Me.rbtnEntregado.Text = "Entregado"
        Me.rbtnEntregado.UseVisualStyleBackColor = True
        '
        'rbtnInvalidado
        '
        Me.rbtnInvalidado.AutoSize = True
        Me.rbtnInvalidado.Location = New System.Drawing.Point(478, 246)
        Me.rbtnInvalidado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnInvalidado.Name = "rbtnInvalidado"
        Me.rbtnInvalidado.Size = New System.Drawing.Size(74, 17)
        Me.rbtnInvalidado.TabIndex = 91
        Me.rbtnInvalidado.TabStop = True
        Me.rbtnInvalidado.Text = "Invalidado"
        Me.rbtnInvalidado.UseVisualStyleBackColor = True
        '
        'cbxWs
        '
        Me.cbxWs.AutoSize = True
        Me.cbxWs.Location = New System.Drawing.Point(313, 368)
        Me.cbxWs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxWs.Name = "cbxWs"
        Me.cbxWs.Size = New System.Drawing.Size(86, 17)
        Me.cbxWs.TabIndex = 92
        Me.cbxWs.Text = "Enviada WS"
        Me.cbxWs.UseVisualStyleBackColor = True
        '
        'cbxEmail
        '
        Me.cbxEmail.AutoSize = True
        Me.cbxEmail.Location = New System.Drawing.Point(313, 390)
        Me.cbxEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxEmail.Name = "cbxEmail"
        Me.cbxEmail.Size = New System.Drawing.Size(93, 17)
        Me.cbxEmail.TabIndex = 93
        Me.cbxEmail.Text = "Enviada Email"
        Me.cbxEmail.UseVisualStyleBackColor = True
        '
        'cbxcortesia
        '
        Me.cbxcortesia.AutoSize = True
        Me.cbxcortesia.Location = New System.Drawing.Point(771, 306)
        Me.cbxcortesia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxcortesia.Name = "cbxcortesia"
        Me.cbxcortesia.Size = New System.Drawing.Size(66, 17)
        Me.cbxcortesia.TabIndex = 94
        Me.cbxcortesia.Text = "Cortesía"
        Me.cbxcortesia.UseVisualStyleBackColor = True
        '
        'cbxurgente
        '
        Me.cbxurgente.AutoSize = True
        Me.cbxurgente.Location = New System.Drawing.Point(771, 328)
        Me.cbxurgente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxurgente.Name = "cbxurgente"
        Me.cbxurgente.Size = New System.Drawing.Size(64, 17)
        Me.cbxurgente.TabIndex = 95
        Me.cbxurgente.Text = "Urgente"
        Me.cbxurgente.UseVisualStyleBackColor = True
        '
        'cbxentregaMedico
        '
        Me.cbxentregaMedico.AutoSize = True
        Me.cbxentregaMedico.Location = New System.Drawing.Point(771, 385)
        Me.cbxentregaMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxentregaMedico.Name = "cbxentregaMedico"
        Me.cbxentregaMedico.Size = New System.Drawing.Size(113, 17)
        Me.cbxentregaMedico.TabIndex = 96
        Me.cbxentregaMedico.Text = "Entregar a Médico"
        Me.cbxentregaMedico.UseVisualStyleBackColor = True
        '
        'cbxentregaPaciente
        '
        Me.cbxentregaPaciente.AutoSize = True
        Me.cbxentregaPaciente.Location = New System.Drawing.Point(771, 407)
        Me.cbxentregaPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxentregaPaciente.Name = "cbxentregaPaciente"
        Me.cbxentregaPaciente.Size = New System.Drawing.Size(120, 17)
        Me.cbxentregaPaciente.TabIndex = 97
        Me.cbxentregaPaciente.Text = "Entregar a Paciente"
        Me.cbxentregaPaciente.UseVisualStyleBackColor = True
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(832, 280)
        Me.dtpFechaEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(115, 20)
        Me.dtpFechaEntrega.TabIndex = 98
        Me.dtpFechaEntrega.Value = New Date(2020, 2, 3, 16, 27, 34, 0)
        '
        'lblEstadoOrden
        '
        Me.lblEstadoOrden.AutoSize = True
        Me.lblEstadoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoOrden.Location = New System.Drawing.Point(505, 84)
        Me.lblEstadoOrden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstadoOrden.Name = "lblEstadoOrden"
        Me.lblEstadoOrden.Size = New System.Drawing.Size(115, 13)
        Me.lblEstadoOrden.TabIndex = 99
        Me.lblEstadoOrden.Text = "__________________"
        Me.lblEstadoOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbllinea2
        '
        Me.lbllinea2.AutoSize = True
        Me.lbllinea2.Location = New System.Drawing.Point(832, 358)
        Me.lbllinea2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllinea2.Name = "lbllinea2"
        Me.lbllinea2.Size = New System.Drawing.Size(115, 13)
        Me.lbllinea2.TabIndex = 100
        Me.lbllinea2.Text = "__________________"
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Descripcion, Me.Resultado, Me.Unidad, Me.Estado})
        Me.dgvResultados.Location = New System.Drawing.Point(11, 440)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowHeadersWidth = 51
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.Size = New System.Drawing.Size(1030, 175)
        Me.dgvResultados.TabIndex = 101
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "Resultado"
        Me.Resultado.MinimumWidth = 6
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Width = 200
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.MinimumWidth = 6
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 175
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 300
        '
        'dtpPmFecha
        '
        Me.dtpPmFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPmFecha.Location = New System.Drawing.Point(664, 107)
        Me.dtpPmFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpPmFecha.Name = "dtpPmFecha"
        Me.dtpPmFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpPmFecha.TabIndex = 102
        '
        'dtpPmHora
        '
        Me.dtpPmHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpPmHora.Location = New System.Drawing.Point(782, 107)
        Me.dtpPmHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpPmHora.Name = "dtpPmHora"
        Me.dtpPmHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpPmHora.TabIndex = 103
        '
        'dtpNpHora
        '
        Me.dtpNpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpNpHora.Location = New System.Drawing.Point(782, 130)
        Me.dtpNpHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNpHora.Name = "dtpNpHora"
        Me.dtpNpHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpNpHora.TabIndex = 105
        '
        'dtpNpFecha
        '
        Me.dtpNpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNpFecha.Location = New System.Drawing.Point(664, 130)
        Me.dtpNpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNpFecha.Name = "dtpNpFecha"
        Me.dtpNpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpNpFecha.TabIndex = 104
        '
        'dtpEpHora
        '
        Me.dtpEpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEpHora.Location = New System.Drawing.Point(782, 154)
        Me.dtpEpHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpEpHora.Name = "dtpEpHora"
        Me.dtpEpHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpEpHora.TabIndex = 107
        '
        'dtpEpFecha
        '
        Me.dtpEpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEpFecha.Location = New System.Drawing.Point(664, 154)
        Me.dtpEpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpEpFecha.Name = "dtpEpFecha"
        Me.dtpEpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpEpFecha.TabIndex = 106
        '
        'dtpPrHora
        '
        Me.dtpPrHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpPrHora.Location = New System.Drawing.Point(782, 177)
        Me.dtpPrHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpPrHora.Name = "dtpPrHora"
        Me.dtpPrHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpPrHora.TabIndex = 109
        '
        'dtpPrFecha
        '
        Me.dtpPrFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPrFecha.Location = New System.Drawing.Point(664, 177)
        Me.dtpPrFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpPrFecha.Name = "dtpPrFecha"
        Me.dtpPrFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpPrFecha.TabIndex = 108
        '
        'dtpCoHora
        '
        Me.dtpCoHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCoHora.Location = New System.Drawing.Point(782, 201)
        Me.dtpCoHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpCoHora.Name = "dtpCoHora"
        Me.dtpCoHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpCoHora.TabIndex = 111
        '
        'dtpCoFecha
        '
        Me.dtpCoFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCoFecha.Location = New System.Drawing.Point(664, 201)
        Me.dtpCoFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpCoFecha.Name = "dtpCoFecha"
        Me.dtpCoFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpCoFecha.TabIndex = 110
        '
        'dtpEnHora
        '
        Me.dtpEnHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnHora.Location = New System.Drawing.Point(782, 223)
        Me.dtpEnHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpEnHora.Name = "dtpEnHora"
        Me.dtpEnHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpEnHora.TabIndex = 113
        '
        'dtpEnFecha
        '
        Me.dtpEnFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnFecha.Location = New System.Drawing.Point(664, 223)
        Me.dtpEnFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpEnFecha.Name = "dtpEnFecha"
        Me.dtpEnFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpEnFecha.TabIndex = 112
        '
        'dtpInHora
        '
        Me.dtpInHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpInHora.Location = New System.Drawing.Point(782, 245)
        Me.dtpInHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpInHora.Name = "dtpInHora"
        Me.dtpInHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpInHora.TabIndex = 115
        '
        'dtpInFecha
        '
        Me.dtpInFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInFecha.Location = New System.Drawing.Point(664, 245)
        Me.dtpInFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpInFecha.Name = "dtpInFecha"
        Me.dtpInFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpInFecha.TabIndex = 114
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(798, 23)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(78, 20)
        Me.dtpFechaFactura.TabIndex = 116
        '
        'dtpHoraFactura
        '
        Me.dtpHoraFactura.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFactura.Location = New System.Drawing.Point(880, 23)
        Me.dtpHoraFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHoraFactura.Name = "dtpHoraFactura"
        Me.dtpHoraFactura.Size = New System.Drawing.Size(78, 20)
        Me.dtpHoraFactura.TabIndex = 117
        '
        'E_OrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 623)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "E_OrdenTrabajo"
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
End Class
