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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_OrdenTrabajo))
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
        Me.lblEstadoOrden = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbllinea2 = New System.Windows.Forms.Label()
        Me.lblresultados = New System.Windows.Forms.Label()
        Me.cbxurgente = New System.Windows.Forms.CheckBox()
        Me.cbxcortesia = New System.Windows.Forms.CheckBox()
        Me.cbxentregaPaciente = New System.Windows.Forms.CheckBox()
        Me.cbxentregaMedico = New System.Windows.Forms.CheckBox()
        Me.lblfechaEntrega = New System.Windows.Forms.Label()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(7, 12)
        Me.lblnumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(74, 13)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "Nro. de Orden"
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Location = New System.Drawing.Point(209, 13)
        Me.lblarea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(29, 13)
        Me.lblarea.TabIndex = 1
        Me.lblarea.Text = "Área"
        '
        'lblFacturaNum
        '
        Me.lblFacturaNum.AutoSize = True
        Me.lblFacturaNum.Location = New System.Drawing.Point(369, 13)
        Me.lblFacturaNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFacturaNum.Name = "lblFacturaNum"
        Me.lblFacturaNum.Size = New System.Drawing.Size(90, 13)
        Me.lblFacturaNum.TabIndex = 2
        Me.lblFacturaNum.Text = "Factura Nro. /Fila"
        '
        'lblcreadoPor
        '
        Me.lblcreadoPor.AutoSize = True
        Me.lblcreadoPor.Location = New System.Drawing.Point(619, 13)
        Me.lblcreadoPor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcreadoPor.Name = "lblcreadoPor"
        Me.lblcreadoPor.Size = New System.Drawing.Size(60, 13)
        Me.lblcreadoPor.TabIndex = 3
        Me.lblcreadoPor.Text = "Creado Por"
        '
        'lblsubArea
        '
        Me.lblsubArea.AutoSize = True
        Me.lblsubArea.Location = New System.Drawing.Point(187, 38)
        Me.lblsubArea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsubArea.Name = "lblsubArea"
        Me.lblsubArea.Size = New System.Drawing.Size(51, 13)
        Me.lblsubArea.TabIndex = 5
        Me.lblsubArea.Text = "Sub Área"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(411, 38)
        Me.lblSucursal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.Text = "Sucursal"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 23)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "Código"
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(27, 46)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 8
        Me.lblEdad.Text = "Edad"
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(463, 104)
        Me.lblestado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(40, 13)
        Me.lblestado.TabIndex = 9
        Me.lblestado.Text = "Estado"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(694, 104)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha"
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(812, 104)
        Me.lblhora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(30, 13)
        Me.lblhora.TabIndex = 11
        Me.lblhora.Text = "Hora"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(925, 106)
        Me.lblusuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(43, 13)
        Me.lblusuario.TabIndex = 12
        Me.lblusuario.Text = "Usuario"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(20, 71)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(42, 13)
        Me.lblGenero.TabIndex = 13
        Me.lblGenero.Text = "Genero"
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Location = New System.Drawing.Point(20, 94)
        Me.lblMedico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(42, 13)
        Me.lblMedico.TabIndex = 14
        Me.lblMedico.Text = "Médico"
        '
        'lblCurva
        '
        Me.lblCurva.AutoSize = True
        Me.lblCurva.Location = New System.Drawing.Point(27, 141)
        Me.lblCurva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurva.Name = "lblCurva"
        Me.lblCurva.Size = New System.Drawing.Size(35, 13)
        Me.lblCurva.TabIndex = 15
        Me.lblCurva.Text = "Curva"
        '
        'lblSede
        '
        Me.lblSede.AutoSize = True
        Me.lblSede.Location = New System.Drawing.Point(28, 171)
        Me.lblSede.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(32, 13)
        Me.lblSede.TabIndex = 16
        Me.lblSede.Text = "Sede"
        '
        'lblTecnico
        '
        Me.lblTecnico.AutoSize = True
        Me.lblTecnico.Location = New System.Drawing.Point(14, 202)
        Me.lblTecnico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(46, 13)
        Me.lblTecnico.TabIndex = 17
        Me.lblTecnico.Text = "Técnico"
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Location = New System.Drawing.Point(9, 229)
        Me.lblValidador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(51, 13)
        Me.lblValidador.TabIndex = 18
        Me.lblValidador.Text = "Validador"
        '
        'lblanalizador
        '
        Me.lblanalizador.AutoSize = True
        Me.lblanalizador.Location = New System.Drawing.Point(83, 315)
        Me.lblanalizador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblanalizador.Name = "lblanalizador"
        Me.lblanalizador.Size = New System.Drawing.Size(56, 13)
        Me.lblanalizador.TabIndex = 19
        Me.lblanalizador.Text = "Analizador"
        '
        'lblFacturaToma
        '
        Me.lblFacturaToma.AutoSize = True
        Me.lblFacturaToma.Location = New System.Drawing.Point(7, 254)
        Me.lblFacturaToma.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFacturaToma.Name = "lblFacturaToma"
        Me.lblFacturaToma.Size = New System.Drawing.Size(137, 13)
        Me.lblFacturaToma.TabIndex = 20
        Me.lblFacturaToma.Text = "Factura y Toma de Muestra"
        '
        'lblTecnicoLab
        '
        Me.lblTecnicoLab.AutoSize = True
        Me.lblTecnicoLab.Location = New System.Drawing.Point(22, 284)
        Me.lblTecnicoLab.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTecnicoLab.Name = "lblTecnicoLab"
        Me.lblTecnicoLab.Size = New System.Drawing.Size(117, 13)
        Me.lblTecnicoLab.TabIndex = 21
        Me.lblTecnicoLab.Text = "Técnico de Laboratorio"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(86, 9)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(119, 20)
        Me.txtnumero.TabIndex = 24
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoArea
        '
        Me.txtcodigoArea.Location = New System.Drawing.Point(246, 9)
        Me.txtcodigoArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoArea.Name = "txtcodigoArea"
        Me.txtcodigoArea.ReadOnly = True
        Me.txtcodigoArea.Size = New System.Drawing.Size(97, 20)
        Me.txtcodigoArea.TabIndex = 25
        Me.txtcodigoArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroFactura
        '
        Me.txtnumeroFactura.Location = New System.Drawing.Point(463, 9)
        Me.txtnumeroFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnumeroFactura.Name = "txtnumeroFactura"
        Me.txtnumeroFactura.ReadOnly = True
        Me.txtnumeroFactura.Size = New System.Drawing.Size(126, 20)
        Me.txtnumeroFactura.TabIndex = 26
        Me.txtnumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCajero
        '
        Me.txtcodigoCajero.Location = New System.Drawing.Point(683, 6)
        Me.txtcodigoCajero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoCajero.Name = "txtcodigoCajero"
        Me.txtcodigoCajero.ReadOnly = True
        Me.txtcodigoCajero.Size = New System.Drawing.Size(93, 20)
        Me.txtcodigoCajero.TabIndex = 27
        Me.txtcodigoCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSubArea
        '
        Me.txtcodigoSubArea.Location = New System.Drawing.Point(246, 35)
        Me.txtcodigoSubArea.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoSubArea.Name = "txtcodigoSubArea"
        Me.txtcodigoSubArea.ReadOnly = True
        Me.txtcodigoSubArea.Size = New System.Drawing.Size(97, 20)
        Me.txtcodigoSubArea.TabIndex = 30
        Me.txtcodigoSubArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSucursal
        '
        Me.txtcodigoSucursal.Location = New System.Drawing.Point(463, 33)
        Me.txtcodigoSucursal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoSucursal.Name = "txtcodigoSucursal"
        Me.txtcodigoSucursal.ReadOnly = True
        Me.txtcodigoSucursal.Size = New System.Drawing.Size(126, 20)
        Me.txtcodigoSucursal.TabIndex = 31
        Me.txtcodigoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoPaciente
        '
        Me.txtcodigoPaciente.Location = New System.Drawing.Point(65, 16)
        Me.txtcodigoPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoPaciente.Name = "txtcodigoPaciente"
        Me.txtcodigoPaciente.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoPaciente.TabIndex = 32
        Me.txtcodigoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombrePaciente
        '
        Me.txtnombrePaciente.Location = New System.Drawing.Point(153, 5)
        Me.txtnombrePaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombrePaciente.Name = "txtnombrePaciente"
        Me.txtnombrePaciente.ReadOnly = True
        Me.txtnombrePaciente.Size = New System.Drawing.Size(192, 20)
        Me.txtnombrePaciente.TabIndex = 33
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(65, 40)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(79, 20)
        Me.txtedad.TabIndex = 34
        Me.txtedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(223, 118)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(126, 20)
        Me.txttelefono.TabIndex = 35
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(65, 64)
        Me.txtgenero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(79, 20)
        Me.txtgenero.TabIndex = 36
        Me.txtgenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(217, 63)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(126, 20)
        Me.txtemail.TabIndex = 37
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoMedico
        '
        Me.txtcodigoMedico.Location = New System.Drawing.Point(65, 88)
        Me.txtcodigoMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoMedico.Name = "txtcodigoMedico"
        Me.txtcodigoMedico.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoMedico.TabIndex = 38
        Me.txtcodigoMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreMedico
        '
        Me.txtnombreMedico.Location = New System.Drawing.Point(157, 168)
        Me.txtnombreMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreMedico.Name = "txtnombreMedico"
        Me.txtnombreMedico.ReadOnly = True
        Me.txtnombreMedico.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreMedico.TabIndex = 39
        '
        'txtcurva
        '
        Me.txtcurva.Location = New System.Drawing.Point(65, 133)
        Me.txtcurva.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcurva.Name = "txtcurva"
        Me.txtcurva.Size = New System.Drawing.Size(79, 20)
        Me.txtcurva.TabIndex = 40
        Me.txtcurva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsede
        '
        Me.txtsede.Location = New System.Drawing.Point(65, 164)
        Me.txtsede.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsede.Name = "txtsede"
        Me.txtsede.Size = New System.Drawing.Size(79, 20)
        Me.txtsede.TabIndex = 41
        Me.txtsede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreSede
        '
        Me.txtnombreSede.Location = New System.Drawing.Point(151, 164)
        Me.txtnombreSede.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreSede.Name = "txtnombreSede"
        Me.txtnombreSede.ReadOnly = True
        Me.txtnombreSede.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreSede.TabIndex = 42
        '
        'txtcodigoTecnico
        '
        Me.txtcodigoTecnico.Location = New System.Drawing.Point(65, 195)
        Me.txtcodigoTecnico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoTecnico.Name = "txtcodigoTecnico"
        Me.txtcodigoTecnico.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoTecnico.TabIndex = 43
        Me.txtcodigoTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreTecnico
        '
        Me.txtnombreTecnico.Location = New System.Drawing.Point(151, 195)
        Me.txtnombreTecnico.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreTecnico.Name = "txtnombreTecnico"
        Me.txtnombreTecnico.ReadOnly = True
        Me.txtnombreTecnico.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreTecnico.TabIndex = 44
        '
        'txtcodigoValidador
        '
        Me.txtcodigoValidador.Location = New System.Drawing.Point(83, 305)
        Me.txtcodigoValidador.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoValidador.Name = "txtcodigoValidador"
        Me.txtcodigoValidador.Size = New System.Drawing.Size(79, 20)
        Me.txtcodigoValidador.TabIndex = 45
        Me.txtcodigoValidador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreValidador
        '
        Me.txtnombreValidador.Location = New System.Drawing.Point(151, 222)
        Me.txtnombreValidador.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreValidador.Name = "txtnombreValidador"
        Me.txtnombreValidador.ReadOnly = True
        Me.txtnombreValidador.Size = New System.Drawing.Size(192, 20)
        Me.txtnombreValidador.TabIndex = 46
        '
        'txtcodigoObjeto
        '
        Me.txtcodigoObjeto.Location = New System.Drawing.Point(149, 310)
        Me.txtcodigoObjeto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoObjeto.Name = "txtcodigoObjeto"
        Me.txtcodigoObjeto.Size = New System.Drawing.Size(126, 20)
        Me.txtcodigoObjeto.TabIndex = 47
        Me.txtcodigoObjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfacturaTomaMuestra
        '
        Me.txtfacturaTomaMuestra.Location = New System.Drawing.Point(149, 249)
        Me.txtfacturaTomaMuestra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfacturaTomaMuestra.Name = "txtfacturaTomaMuestra"
        Me.txtfacturaTomaMuestra.Size = New System.Drawing.Size(195, 20)
        Me.txtfacturaTomaMuestra.TabIndex = 48
        Me.txtfacturaTomaMuestra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttecnicoLab
        '
        Me.txttecnicoLab.Location = New System.Drawing.Point(149, 280)
        Me.txttecnicoLab.Margin = New System.Windows.Forms.Padding(2)
        Me.txttecnicoLab.Name = "txttecnicoLab"
        Me.txttecnicoLab.Size = New System.Drawing.Size(196, 20)
        Me.txttecnicoLab.TabIndex = 49
        Me.txttecnicoLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpmUsuario
        '
        Me.txtpmUsuario.Location = New System.Drawing.Point(899, 129)
        Me.txtpmUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpmUsuario.Name = "txtpmUsuario"
        Me.txtpmUsuario.ReadOnly = True
        Me.txtpmUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtpmUsuario.TabIndex = 50
        Me.txtpmUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnpUsuario
        '
        Me.txtnpUsuario.Location = New System.Drawing.Point(899, 152)
        Me.txtnpUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnpUsuario.Name = "txtnpUsuario"
        Me.txtnpUsuario.ReadOnly = True
        Me.txtnpUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtnpUsuario.TabIndex = 57
        Me.txtnpUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtepUsuario
        '
        Me.txtepUsuario.Location = New System.Drawing.Point(899, 175)
        Me.txtepUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtepUsuario.Name = "txtepUsuario"
        Me.txtepUsuario.ReadOnly = True
        Me.txtepUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtepUsuario.TabIndex = 60
        Me.txtepUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtprUsuario
        '
        Me.txtprUsuario.Location = New System.Drawing.Point(899, 197)
        Me.txtprUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprUsuario.Name = "txtprUsuario"
        Me.txtprUsuario.ReadOnly = True
        Me.txtprUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtprUsuario.TabIndex = 63
        Me.txtprUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcoUsuario
        '
        Me.txtcoUsuario.Location = New System.Drawing.Point(899, 220)
        Me.txtcoUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcoUsuario.Name = "txtcoUsuario"
        Me.txtcoUsuario.ReadOnly = True
        Me.txtcoUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtcoUsuario.TabIndex = 66
        Me.txtcoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtenUsuario
        '
        Me.txtenUsuario.Location = New System.Drawing.Point(899, 243)
        Me.txtenUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtenUsuario.Name = "txtenUsuario"
        Me.txtenUsuario.ReadOnly = True
        Me.txtenUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtenUsuario.TabIndex = 69
        Me.txtenUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtinUsuario
        '
        Me.txtinUsuario.Location = New System.Drawing.Point(899, 266)
        Me.txtinUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtinUsuario.Name = "txtinUsuario"
        Me.txtinUsuario.ReadOnly = True
        Me.txtinUsuario.Size = New System.Drawing.Size(102, 20)
        Me.txtinUsuario.TabIndex = 72
        Me.txtinUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblpm
        '
        Me.lblpm.AutoSize = True
        Me.lblpm.Location = New System.Drawing.Point(243, 52)
        Me.lblpm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpm.Name = "lblpm"
        Me.lblpm.Size = New System.Drawing.Size(23, 13)
        Me.lblpm.TabIndex = 75
        Me.lblpm.Text = "PM"
        '
        'lblnp
        '
        Me.lblnp.AutoSize = True
        Me.lblnp.Location = New System.Drawing.Point(243, 75)
        Me.lblnp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnp.Name = "lblnp"
        Me.lblnp.Size = New System.Drawing.Size(22, 13)
        Me.lblnp.TabIndex = 76
        Me.lblnp.Text = "NP"
        '
        'lblep
        '
        Me.lblep.AutoSize = True
        Me.lblep.Location = New System.Drawing.Point(243, 99)
        Me.lblep.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblep.Name = "lblep"
        Me.lblep.Size = New System.Drawing.Size(21, 13)
        Me.lblep.TabIndex = 77
        Me.lblep.Text = "EP"
        '
        'lblpr
        '
        Me.lblpr.AutoSize = True
        Me.lblpr.Location = New System.Drawing.Point(242, 121)
        Me.lblpr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpr.Name = "lblpr"
        Me.lblpr.Size = New System.Drawing.Size(22, 13)
        Me.lblpr.TabIndex = 78
        Me.lblpr.Text = "PR"
        '
        'lblco
        '
        Me.lblco.AutoSize = True
        Me.lblco.Location = New System.Drawing.Point(243, 145)
        Me.lblco.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblco.Name = "lblco"
        Me.lblco.Size = New System.Drawing.Size(22, 13)
        Me.lblco.TabIndex = 79
        Me.lblco.Text = "CO"
        '
        'lblen
        '
        Me.lblen.AutoSize = True
        Me.lblen.Location = New System.Drawing.Point(242, 167)
        Me.lblen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblen.Name = "lblen"
        Me.lblen.Size = New System.Drawing.Size(22, 13)
        Me.lblen.TabIndex = 80
        Me.lblen.Text = "EN"
        '
        'lblin
        '
        Me.lblin.AutoSize = True
        Me.lblin.Location = New System.Drawing.Point(243, 190)
        Me.lblin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblin.Name = "lblin"
        Me.lblin.Size = New System.Drawing.Size(18, 13)
        Me.lblin.TabIndex = 81
        Me.lblin.Text = "IN"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(164, 43)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 82
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(173, 69)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 83
        Me.lblEmail.Text = "Email"
        '
        'btnverGrafica
        '
        Me.btnverGrafica.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnverGrafica.Location = New System.Drawing.Point(172, 128)
        Me.btnverGrafica.Margin = New System.Windows.Forms.Padding(2)
        Me.btnverGrafica.Name = "btnverGrafica"
        Me.btnverGrafica.Size = New System.Drawing.Size(173, 28)
        Me.btnverGrafica.TabIndex = 84
        Me.btnverGrafica.Text = "Ver Gráfica"
        Me.btnverGrafica.UseVisualStyleBackColor = False
        '
        'rbtnpendienteMuestra
        '
        Me.rbtnpendienteMuestra.AutoSize = True
        Me.rbtnpendienteMuestra.Location = New System.Drawing.Point(93, 49)
        Me.rbtnpendienteMuestra.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtnNoProcesado.Location = New System.Drawing.Point(93, 74)
        Me.rbtnNoProcesado.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtnEnProceso.Location = New System.Drawing.Point(93, 96)
        Me.rbtnEnProceso.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtnProcesado.Location = New System.Drawing.Point(93, 119)
        Me.rbtnProcesado.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtnValidado.Location = New System.Drawing.Point(93, 142)
        Me.rbtnValidado.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtnEntregado.Location = New System.Drawing.Point(93, 165)
        Me.rbtnEntregado.Margin = New System.Windows.Forms.Padding(2)
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
        Me.rbtnInvalidado.Location = New System.Drawing.Point(93, 188)
        Me.rbtnInvalidado.Margin = New System.Windows.Forms.Padding(2)
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
        Me.cbxWs.Location = New System.Drawing.Point(190, 342)
        Me.cbxWs.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxWs.Name = "cbxWs"
        Me.cbxWs.Size = New System.Drawing.Size(86, 17)
        Me.cbxWs.TabIndex = 92
        Me.cbxWs.Text = "Enviada WS"
        Me.cbxWs.UseVisualStyleBackColor = True
        '
        'cbxEmail
        '
        Me.cbxEmail.AutoSize = True
        Me.cbxEmail.Location = New System.Drawing.Point(51, 342)
        Me.cbxEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxEmail.Name = "cbxEmail"
        Me.cbxEmail.Size = New System.Drawing.Size(93, 17)
        Me.cbxEmail.TabIndex = 93
        Me.cbxEmail.Text = "Enviada Email"
        Me.cbxEmail.UseVisualStyleBackColor = True
        '
        'lblEstadoOrden
        '
        Me.lblEstadoOrden.AutoSize = True
        Me.lblEstadoOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoOrden.Location = New System.Drawing.Point(503, 104)
        Me.lblEstadoOrden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstadoOrden.Name = "lblEstadoOrden"
        Me.lblEstadoOrden.Size = New System.Drawing.Size(115, 13)
        Me.lblEstadoOrden.TabIndex = 99
        Me.lblEstadoOrden.Text = "__________________"
        Me.lblEstadoOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Descripcion, Me.Resultado, Me.Unidad, Me.Estado})
        Me.dgvResultados.Location = New System.Drawing.Point(4, 18)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.RowHeadersWidth = 51
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.Size = New System.Drawing.Size(1026, 124)
        Me.dgvResultados.TabIndex = 101
        '
        'codigo
        '
        Me.codigo.HeaderText = "ID"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "DESCRIPCION"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "RESULTADO"
        Me.Resultado.MinimumWidth = 6
        Me.Resultado.Name = "Resultado"
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "UNIDAD"
        Me.Unidad.MinimumWidth = 6
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "ESTADO"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'dtpPmFecha
        '
        Me.dtpPmFecha.Enabled = False
        Me.dtpPmFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPmFecha.Location = New System.Drawing.Point(662, 128)
        Me.dtpPmFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpPmFecha.Name = "dtpPmFecha"
        Me.dtpPmFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpPmFecha.TabIndex = 102
        '
        'dtpPmHora
        '
        Me.dtpPmHora.Enabled = False
        Me.dtpPmHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpPmHora.Location = New System.Drawing.Point(781, 128)
        Me.dtpPmHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpPmHora.Name = "dtpPmHora"
        Me.dtpPmHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpPmHora.TabIndex = 103
        '
        'dtpNpHora
        '
        Me.dtpNpHora.Enabled = False
        Me.dtpNpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpNpHora.Location = New System.Drawing.Point(781, 150)
        Me.dtpNpHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNpHora.Name = "dtpNpHora"
        Me.dtpNpHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpNpHora.TabIndex = 105
        '
        'dtpNpFecha
        '
        Me.dtpNpFecha.Enabled = False
        Me.dtpNpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNpFecha.Location = New System.Drawing.Point(662, 150)
        Me.dtpNpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNpFecha.Name = "dtpNpFecha"
        Me.dtpNpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpNpFecha.TabIndex = 104
        '
        'dtpEpHora
        '
        Me.dtpEpHora.Enabled = False
        Me.dtpEpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEpHora.Location = New System.Drawing.Point(781, 175)
        Me.dtpEpHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEpHora.Name = "dtpEpHora"
        Me.dtpEpHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpEpHora.TabIndex = 107
        '
        'dtpEpFecha
        '
        Me.dtpEpFecha.Enabled = False
        Me.dtpEpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEpFecha.Location = New System.Drawing.Point(662, 175)
        Me.dtpEpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEpFecha.Name = "dtpEpFecha"
        Me.dtpEpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpEpFecha.TabIndex = 106
        '
        'dtpPrHora
        '
        Me.dtpPrHora.Enabled = False
        Me.dtpPrHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpPrHora.Location = New System.Drawing.Point(781, 197)
        Me.dtpPrHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpPrHora.Name = "dtpPrHora"
        Me.dtpPrHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpPrHora.TabIndex = 109
        '
        'dtpPrFecha
        '
        Me.dtpPrFecha.Enabled = False
        Me.dtpPrFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPrFecha.Location = New System.Drawing.Point(662, 197)
        Me.dtpPrFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpPrFecha.Name = "dtpPrFecha"
        Me.dtpPrFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpPrFecha.TabIndex = 108
        '
        'dtpCoHora
        '
        Me.dtpCoHora.Enabled = False
        Me.dtpCoHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCoHora.Location = New System.Drawing.Point(781, 221)
        Me.dtpCoHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCoHora.Name = "dtpCoHora"
        Me.dtpCoHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpCoHora.TabIndex = 111
        '
        'dtpCoFecha
        '
        Me.dtpCoFecha.Enabled = False
        Me.dtpCoFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCoFecha.Location = New System.Drawing.Point(662, 221)
        Me.dtpCoFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCoFecha.Name = "dtpCoFecha"
        Me.dtpCoFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpCoFecha.TabIndex = 110
        '
        'dtpEnHora
        '
        Me.dtpEnHora.Enabled = False
        Me.dtpEnHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEnHora.Location = New System.Drawing.Point(781, 243)
        Me.dtpEnHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEnHora.Name = "dtpEnHora"
        Me.dtpEnHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpEnHora.TabIndex = 113
        '
        'dtpEnFecha
        '
        Me.dtpEnFecha.Enabled = False
        Me.dtpEnFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnFecha.Location = New System.Drawing.Point(662, 243)
        Me.dtpEnFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEnFecha.Name = "dtpEnFecha"
        Me.dtpEnFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpEnFecha.TabIndex = 112
        '
        'dtpInHora
        '
        Me.dtpInHora.Enabled = False
        Me.dtpInHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpInHora.Location = New System.Drawing.Point(781, 266)
        Me.dtpInHora.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpInHora.Name = "dtpInHora"
        Me.dtpInHora.Size = New System.Drawing.Size(102, 20)
        Me.dtpInHora.TabIndex = 115
        '
        'dtpInFecha
        '
        Me.dtpInFecha.Enabled = False
        Me.dtpInFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInFecha.Location = New System.Drawing.Point(662, 266)
        Me.dtpInFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpInFecha.Name = "dtpInFecha"
        Me.dtpInFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpInFecha.TabIndex = 114
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(787, 6)
        Me.dtpFechaFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaFactura.TabIndex = 116
        '
        'dtpHoraFactura
        '
        Me.dtpHoraFactura.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFactura.Location = New System.Drawing.Point(887, 6)
        Me.dtpHoraFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHoraFactura.Name = "dtpHoraFactura"
        Me.dtpHoraFactura.Size = New System.Drawing.Size(107, 20)
        Me.dtpHoraFactura.TabIndex = 117
        '
        'lblpmUsuario
        '
        Me.lblpmUsuario.AutoSize = True
        Me.lblpmUsuario.Location = New System.Drawing.Point(1005, 130)
        Me.lblpmUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpmUsuario.Name = "lblpmUsuario"
        Me.lblpmUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblpmUsuario.TabIndex = 118
        Me.lblpmUsuario.Text = "Label1"
        Me.lblpmUsuario.Visible = False
        '
        'lblnpUsuario
        '
        Me.lblnpUsuario.AutoSize = True
        Me.lblnpUsuario.Location = New System.Drawing.Point(1005, 156)
        Me.lblnpUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnpUsuario.Name = "lblnpUsuario"
        Me.lblnpUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblnpUsuario.TabIndex = 119
        Me.lblnpUsuario.Text = "Label1"
        Me.lblnpUsuario.Visible = False
        '
        'lblepUsuario
        '
        Me.lblepUsuario.AutoSize = True
        Me.lblepUsuario.Location = New System.Drawing.Point(1005, 178)
        Me.lblepUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblepUsuario.Name = "lblepUsuario"
        Me.lblepUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblepUsuario.TabIndex = 120
        Me.lblepUsuario.Text = "Label1"
        Me.lblepUsuario.Visible = False
        '
        'lblprUsuario
        '
        Me.lblprUsuario.AutoSize = True
        Me.lblprUsuario.Location = New System.Drawing.Point(1005, 200)
        Me.lblprUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblprUsuario.Name = "lblprUsuario"
        Me.lblprUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblprUsuario.TabIndex = 121
        Me.lblprUsuario.Text = "Label1"
        Me.lblprUsuario.Visible = False
        '
        'lblcoUsuario
        '
        Me.lblcoUsuario.AutoSize = True
        Me.lblcoUsuario.Location = New System.Drawing.Point(1005, 223)
        Me.lblcoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcoUsuario.Name = "lblcoUsuario"
        Me.lblcoUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblcoUsuario.TabIndex = 122
        Me.lblcoUsuario.Text = "Label1"
        Me.lblcoUsuario.Visible = False
        '
        'lblenUsuario
        '
        Me.lblenUsuario.AutoSize = True
        Me.lblenUsuario.Location = New System.Drawing.Point(1005, 247)
        Me.lblenUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblenUsuario.Name = "lblenUsuario"
        Me.lblenUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblenUsuario.TabIndex = 123
        Me.lblenUsuario.Text = "Label1"
        Me.lblenUsuario.Visible = False
        '
        'lblinUsuario
        '
        Me.lblinUsuario.AutoSize = True
        Me.lblinUsuario.Location = New System.Drawing.Point(1005, 266)
        Me.lblinUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblinUsuario.Name = "lblinUsuario"
        Me.lblinUsuario.Size = New System.Drawing.Size(39, 13)
        Me.lblinUsuario.TabIndex = 124
        Me.lblinUsuario.Text = "Label1"
        Me.lblinUsuario.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(486, 207)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(164, 28)
        Me.btnActualizar.TabIndex = 125
        Me.btnActualizar.Text = "Actualizar Estado"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblcodigoCajero
        '
        Me.lblcodigoCajero.AutoSize = True
        Me.lblcodigoCajero.Location = New System.Drawing.Point(261, 0)
        Me.lblcodigoCajero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigoCajero.Name = "lblcodigoCajero"
        Me.lblcodigoCajero.Size = New System.Drawing.Size(39, 13)
        Me.lblcodigoCajero.TabIndex = 126
        Me.lblcodigoCajero.Text = "Label1"
        Me.lblcodigoCajero.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.txtnombreMedico)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1032, 454)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden De Trabajo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.dtpHoraFactura)
        Me.Panel1.Controls.Add(Me.lblcreadoPor)
        Me.Panel1.Controls.Add(Me.dtpFechaFactura)
        Me.Panel1.Controls.Add(Me.txtcodigoCajero)
        Me.Panel1.Controls.Add(Me.lblnumero)
        Me.Panel1.Controls.Add(Me.lblarea)
        Me.Panel1.Controls.Add(Me.lblsubArea)
        Me.Panel1.Controls.Add(Me.lblFacturaNum)
        Me.Panel1.Controls.Add(Me.lblSucursal)
        Me.Panel1.Controls.Add(Me.txtnumeroFactura)
        Me.Panel1.Controls.Add(Me.txtcodigoSucursal)
        Me.Panel1.Controls.Add(Me.txtcodigoArea)
        Me.Panel1.Controls.Add(Me.txtcodigoSubArea)
        Me.Panel1.Controls.Add(Me.txtnumero)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 59)
        Me.Panel1.TabIndex = 127
        '
        'Panel2
        '
        Me.Panel2.AccessibleDescription = "ahh"
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cbxEmail)
        Me.Panel2.Controls.Add(Me.txtcodigoMedico)
        Me.Panel2.Controls.Add(Me.txtgenero)
        Me.Panel2.Controls.Add(Me.txtemail)
        Me.Panel2.Controls.Add(Me.txtedad)
        Me.Panel2.Controls.Add(Me.txtcodigoPaciente)
        Me.Panel2.Controls.Add(Me.cbxWs)
        Me.Panel2.Controls.Add(Me.lblCodigo)
        Me.Panel2.Controls.Add(Me.lblanalizador)
        Me.Panel2.Controls.Add(Me.lblEdad)
        Me.Panel2.Controls.Add(Me.lblTecnicoLab)
        Me.Panel2.Controls.Add(Me.txtnombrePaciente)
        Me.Panel2.Controls.Add(Me.lblGenero)
        Me.Panel2.Controls.Add(Me.lblTelefono)
        Me.Panel2.Controls.Add(Me.lblFacturaToma)
        Me.Panel2.Controls.Add(Me.btnverGrafica)
        Me.Panel2.Controls.Add(Me.txtfacturaTomaMuestra)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.txttecnicoLab)
        Me.Panel2.Controls.Add(Me.lblMedico)
        Me.Panel2.Controls.Add(Me.txtcodigoObjeto)
        Me.Panel2.Controls.Add(Me.txtnombreSede)
        Me.Panel2.Controls.Add(Me.txtcurva)
        Me.Panel2.Controls.Add(Me.lblCurva)
        Me.Panel2.Controls.Add(Me.txtsede)
        Me.Panel2.Controls.Add(Me.lblSede)
        Me.Panel2.Controls.Add(Me.txtnombreTecnico)
        Me.Panel2.Controls.Add(Me.txtcodigoTecnico)
        Me.Panel2.Controls.Add(Me.lblTecnico)
        Me.Panel2.Controls.Add(Me.lblValidador)
        Me.Panel2.Controls.Add(Me.txtnombreValidador)
        Me.Panel2.Location = New System.Drawing.Point(6, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 367)
        Me.Panel2.TabIndex = 128
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnActualizar)
        Me.Panel3.Controls.Add(Me.lblcodigoCajero)
        Me.Panel3.Controls.Add(Me.rbtnEnProceso)
        Me.Panel3.Controls.Add(Me.rbtnNoProcesado)
        Me.Panel3.Controls.Add(Me.rbtnpendienteMuestra)
        Me.Panel3.Controls.Add(Me.lblin)
        Me.Panel3.Controls.Add(Me.lblen)
        Me.Panel3.Controls.Add(Me.lblco)
        Me.Panel3.Controls.Add(Me.lblpr)
        Me.Panel3.Controls.Add(Me.lblep)
        Me.Panel3.Controls.Add(Me.lblnp)
        Me.Panel3.Controls.Add(Me.lblpm)
        Me.Panel3.Controls.Add(Me.rbtnInvalidado)
        Me.Panel3.Controls.Add(Me.rbtnEntregado)
        Me.Panel3.Controls.Add(Me.rbtnValidado)
        Me.Panel3.Controls.Add(Me.rbtnProcesado)
        Me.Panel3.Location = New System.Drawing.Point(376, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(652, 239)
        Me.Panel3.TabIndex = 129
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lbllinea2)
        Me.Panel4.Controls.Add(Me.lblresultados)
        Me.Panel4.Controls.Add(Me.cbxurgente)
        Me.Panel4.Controls.Add(Me.cbxcortesia)
        Me.Panel4.Controls.Add(Me.cbxentregaPaciente)
        Me.Panel4.Controls.Add(Me.cbxentregaMedico)
        Me.Panel4.Controls.Add(Me.lblfechaEntrega)
        Me.Panel4.Controls.Add(Me.dtpFechaEntrega)
        Me.Panel4.Location = New System.Drawing.Point(374, 326)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(652, 122)
        Me.Panel4.TabIndex = 138
        '
        'lbllinea2
        '
        Me.lbllinea2.AutoSize = True
        Me.lbllinea2.Location = New System.Drawing.Point(102, 87)
        Me.lbllinea2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbllinea2.Name = "lbllinea2"
        Me.lbllinea2.Size = New System.Drawing.Size(115, 13)
        Me.lbllinea2.TabIndex = 136
        Me.lbllinea2.Text = "__________________"
        '
        'lblresultados
        '
        Me.lblresultados.AutoSize = True
        Me.lblresultados.Location = New System.Drawing.Point(38, 87)
        Me.lblresultados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblresultados.Name = "lblresultados"
        Me.lblresultados.Size = New System.Drawing.Size(60, 13)
        Me.lblresultados.TabIndex = 131
        Me.lblresultados.Text = "Resultados"
        '
        'cbxurgente
        '
        Me.cbxurgente.AutoSize = True
        Me.cbxurgente.Location = New System.Drawing.Point(41, 58)
        Me.cbxurgente.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxurgente.Name = "cbxurgente"
        Me.cbxurgente.Size = New System.Drawing.Size(64, 17)
        Me.cbxurgente.TabIndex = 133
        Me.cbxurgente.Text = "Urgente"
        Me.cbxurgente.UseVisualStyleBackColor = True
        '
        'cbxcortesia
        '
        Me.cbxcortesia.AutoSize = True
        Me.cbxcortesia.Location = New System.Drawing.Point(41, 37)
        Me.cbxcortesia.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxcortesia.Name = "cbxcortesia"
        Me.cbxcortesia.Size = New System.Drawing.Size(66, 17)
        Me.cbxcortesia.TabIndex = 132
        Me.cbxcortesia.Text = "Cortesía"
        Me.cbxcortesia.UseVisualStyleBackColor = True
        '
        'cbxentregaPaciente
        '
        Me.cbxentregaPaciente.AutoSize = True
        Me.cbxentregaPaciente.Location = New System.Drawing.Point(395, 58)
        Me.cbxentregaPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxentregaPaciente.Name = "cbxentregaPaciente"
        Me.cbxentregaPaciente.Size = New System.Drawing.Size(120, 17)
        Me.cbxentregaPaciente.TabIndex = 135
        Me.cbxentregaPaciente.Text = "Entregar a Paciente"
        Me.cbxentregaPaciente.UseVisualStyleBackColor = True
        '
        'cbxentregaMedico
        '
        Me.cbxentregaMedico.AutoSize = True
        Me.cbxentregaMedico.Location = New System.Drawing.Point(395, 37)
        Me.cbxentregaMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxentregaMedico.Name = "cbxentregaMedico"
        Me.cbxentregaMedico.Size = New System.Drawing.Size(113, 17)
        Me.cbxentregaMedico.TabIndex = 134
        Me.cbxentregaMedico.Text = "Entregar a Médico"
        Me.cbxentregaMedico.UseVisualStyleBackColor = True
        '
        'lblfechaEntrega
        '
        Me.lblfechaEntrega.AutoSize = True
        Me.lblfechaEntrega.Location = New System.Drawing.Point(38, 15)
        Me.lblfechaEntrega.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfechaEntrega.Name = "lblfechaEntrega"
        Me.lblfechaEntrega.Size = New System.Drawing.Size(110, 13)
        Me.lblfechaEntrega.TabIndex = 130
        Me.lblfechaEntrega.Text = "Fecha Entrega Aprox."
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(153, 9)
        Me.dtpFechaEntrega.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(115, 20)
        Me.dtpFechaEntrega.TabIndex = 137
        Me.dtpFechaEntrega.Value = New Date(2020, 10, 29, 0, 0, 0, 0)
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.dgvResultados)
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(12, 462)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1032, 144)
        Me.Panel6.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(476, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESULTADOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'E_OrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1052, 609)
        Me.Controls.Add(Me.lblinUsuario)
        Me.Controls.Add(Me.lblenUsuario)
        Me.Controls.Add(Me.lblcoUsuario)
        Me.Controls.Add(Me.lblprUsuario)
        Me.Controls.Add(Me.lblepUsuario)
        Me.Controls.Add(Me.lblnpUsuario)
        Me.Controls.Add(Me.lblpmUsuario)
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
        Me.Controls.Add(Me.lblEstadoOrden)
        Me.Controls.Add(Me.txtinUsuario)
        Me.Controls.Add(Me.txtenUsuario)
        Me.Controls.Add(Me.txtcoUsuario)
        Me.Controls.Add(Me.txtprUsuario)
        Me.Controls.Add(Me.txtepUsuario)
        Me.Controls.Add(Me.txtnpUsuario)
        Me.Controls.Add(Me.txtpmUsuario)
        Me.Controls.Add(Me.txtcodigoValidador)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "E_OrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Trabajo"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents lblEstadoOrden As Label
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
    Friend WithEvents lblpmUsuario As Label
    Friend WithEvents lblnpUsuario As Label
    Friend WithEvents lblepUsuario As Label
    Friend WithEvents lblprUsuario As Label
    Friend WithEvents lblcoUsuario As Label
    Friend WithEvents lblenUsuario As Label
    Friend WithEvents lblinUsuario As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblcodigoCajero As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbllinea2 As Label
    Friend WithEvents lblresultados As Label
    Friend WithEvents cbxurgente As CheckBox
    Friend WithEvents cbxcortesia As CheckBox
    Friend WithEvents cbxentregaPaciente As CheckBox
    Friend WithEvents cbxentregaMedico As CheckBox
    Friend WithEvents lblfechaEntrega As Label
    Friend WithEvents dtpFechaEntrega As DateTimePicker
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
End Class
