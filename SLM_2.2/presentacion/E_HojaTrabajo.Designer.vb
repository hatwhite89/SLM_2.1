﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_HojaTrabajo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubarea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsucursal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvHojaTrab = New System.Windows.Forms.DataGridView()
        Me.rbtnUrgentes = New System.Windows.Forms.RadioButton()
        Me.rbtnCortesia = New System.Windows.Forms.RadioButton()
        Me.rbtnNombrePaciente = New System.Windows.Forms.RadioButton()
        Me.rbtnNroOrdTrab = New System.Windows.Forms.RadioButton()
        Me.btnActualizarVista = New System.Windows.Forms.Button()
        Me.btnDetalleResultado = New System.Windows.Forms.Button()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtValorActual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInstrTecnico = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHora2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFecha2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValidador = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtValoresRef = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxValidado = New System.Windows.Forms.CheckBox()
        Me.cbxProcesado = New System.Windows.Forms.CheckBox()
        Me.cbxEnProceso = New System.Windows.Forms.CheckBox()
        Me.cbxNoProcesado = New System.Windows.Forms.CheckBox()
        Me.cbxPendMuestra = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCodeSubArea = New System.Windows.Forms.Label()
        Me.lblCodeSucursal = New System.Windows.Forms.Label()
        CType(Me.dgvHojaTrab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro."
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.Location = New System.Drawing.Point(52, 48)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(100, 22)
        Me.txtNumero.TabIndex = 1
        '
        'txtArea
        '
        Me.txtArea.BackColor = System.Drawing.Color.White
        Me.txtArea.Location = New System.Drawing.Point(235, 48)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(100, 22)
        Me.txtArea.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area"
        '
        'txtSubarea
        '
        Me.txtSubarea.BackColor = System.Drawing.Color.White
        Me.txtSubarea.Location = New System.Drawing.Point(445, 47)
        Me.txtSubarea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubarea.Name = "txtSubarea"
        Me.txtSubarea.ReadOnly = True
        Me.txtSubarea.Size = New System.Drawing.Size(100, 22)
        Me.txtSubarea.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subárea"
        '
        'txtsucursal
        '
        Me.txtsucursal.BackColor = System.Drawing.Color.White
        Me.txtsucursal.Location = New System.Drawing.Point(645, 44)
        Me.txtsucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsucursal.Name = "txtsucursal"
        Me.txtsucursal.ReadOnly = True
        Me.txtsucursal.Size = New System.Drawing.Size(100, 22)
        Me.txtsucursal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(579, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sucursal"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(816, 47)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 22)
        Me.txtFecha.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(765, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(973, 47)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(100, 22)
        Me.txtHora.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(932, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hora"
        '
        'dgvHojaTrab
        '
        Me.dgvHojaTrab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHojaTrab.BackgroundColor = System.Drawing.Color.White
        Me.dgvHojaTrab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHojaTrab.GridColor = System.Drawing.Color.White
        Me.dgvHojaTrab.Location = New System.Drawing.Point(15, 254)
        Me.dgvHojaTrab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvHojaTrab.Name = "dgvHojaTrab"
        Me.dgvHojaTrab.RowHeadersWidth = 51
        Me.dgvHojaTrab.RowTemplate.Height = 24
        Me.dgvHojaTrab.Size = New System.Drawing.Size(1379, 378)
        Me.dgvHojaTrab.TabIndex = 12
        '
        'rbtnUrgentes
        '
        Me.rbtnUrgentes.AutoSize = True
        Me.rbtnUrgentes.BackColor = System.Drawing.Color.Transparent
        Me.rbtnUrgentes.Location = New System.Drawing.Point(7, 30)
        Me.rbtnUrgentes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnUrgentes.Name = "rbtnUrgentes"
        Me.rbtnUrgentes.Size = New System.Drawing.Size(140, 21)
        Me.rbtnUrgentes.TabIndex = 19
        Me.rbtnUrgentes.TabStop = True
        Me.rbtnUrgentes.Text = "Urgentes Primero"
        Me.rbtnUrgentes.UseVisualStyleBackColor = False
        '
        'rbtnCortesia
        '
        Me.rbtnCortesia.AutoSize = True
        Me.rbtnCortesia.BackColor = System.Drawing.Color.Transparent
        Me.rbtnCortesia.Location = New System.Drawing.Point(168, 30)
        Me.rbtnCortesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnCortesia.Name = "rbtnCortesia"
        Me.rbtnCortesia.Size = New System.Drawing.Size(134, 21)
        Me.rbtnCortesia.TabIndex = 20
        Me.rbtnCortesia.TabStop = True
        Me.rbtnCortesia.Text = "Cortesia Primero"
        Me.rbtnCortesia.UseVisualStyleBackColor = False
        '
        'rbtnNombrePaciente
        '
        Me.rbtnNombrePaciente.AutoSize = True
        Me.rbtnNombrePaciente.BackColor = System.Drawing.Color.Transparent
        Me.rbtnNombrePaciente.Location = New System.Drawing.Point(7, 57)
        Me.rbtnNombrePaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnNombrePaciente.Name = "rbtnNombrePaciente"
        Me.rbtnNombrePaciente.Size = New System.Drawing.Size(138, 21)
        Me.rbtnNombrePaciente.TabIndex = 21
        Me.rbtnNombrePaciente.TabStop = True
        Me.rbtnNombrePaciente.Text = "Nombre Paciente"
        Me.rbtnNombrePaciente.UseVisualStyleBackColor = False
        '
        'rbtnNroOrdTrab
        '
        Me.rbtnNroOrdTrab.AutoSize = True
        Me.rbtnNroOrdTrab.BackColor = System.Drawing.Color.Transparent
        Me.rbtnNroOrdTrab.Location = New System.Drawing.Point(171, 57)
        Me.rbtnNroOrdTrab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnNroOrdTrab.Name = "rbtnNroOrdTrab"
        Me.rbtnNroOrdTrab.Size = New System.Drawing.Size(126, 21)
        Me.rbtnNroOrdTrab.TabIndex = 22
        Me.rbtnNroOrdTrab.TabStop = True
        Me.rbtnNroOrdTrab.Text = "Nro. Ord. Trab."
        Me.rbtnNroOrdTrab.UseVisualStyleBackColor = False
        '
        'btnActualizarVista
        '
        Me.btnActualizarVista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizarVista.BackColor = System.Drawing.Color.White
        Me.btnActualizarVista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizarVista.Location = New System.Drawing.Point(1083, 139)
        Me.btnActualizarVista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnActualizarVista.Name = "btnActualizarVista"
        Me.btnActualizarVista.Size = New System.Drawing.Size(148, 23)
        Me.btnActualizarVista.TabIndex = 23
        Me.btnActualizarVista.Text = "Actualizar Vista"
        Me.btnActualizarVista.UseVisualStyleBackColor = False
        '
        'btnDetalleResultado
        '
        Me.btnDetalleResultado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetalleResultado.BackColor = System.Drawing.Color.White
        Me.btnDetalleResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDetalleResultado.Location = New System.Drawing.Point(1083, 167)
        Me.btnDetalleResultado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDetalleResultado.Name = "btnDetalleResultado"
        Me.btnDetalleResultado.Size = New System.Drawing.Size(148, 23)
        Me.btnDetalleResultado.TabIndex = 24
        Me.btnDetalleResultado.Text = "Detalle Resultado"
        Me.btnDetalleResultado.UseVisualStyleBackColor = False
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.Color.White
        Me.txtOrden.Location = New System.Drawing.Point(107, 164)
        Me.txtOrden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(100, 22)
        Me.txtOrden.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Orden"
        '
        'txtPaciente
        '
        Me.txtPaciente.BackColor = System.Drawing.Color.White
        Me.txtPaciente.Location = New System.Drawing.Point(312, 164)
        Me.txtPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.ReadOnly = True
        Me.txtPaciente.Size = New System.Drawing.Size(236, 22)
        Me.txtPaciente.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Paciente"
        '
        'txtParametro
        '
        Me.txtParametro.BackColor = System.Drawing.Color.White
        Me.txtParametro.Location = New System.Drawing.Point(703, 164)
        Me.txtParametro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.ReadOnly = True
        Me.txtParametro.Size = New System.Drawing.Size(100, 22)
        Me.txtParametro.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(620, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Parametro"
        '
        'txtValorActual
        '
        Me.txtValorActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorActual.BackColor = System.Drawing.Color.White
        Me.txtValorActual.Location = New System.Drawing.Point(899, 164)
        Me.txtValorActual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValorActual.Name = "txtValorActual"
        Me.txtValorActual.ReadOnly = True
        Me.txtValorActual.Size = New System.Drawing.Size(133, 22)
        Me.txtValorActual.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(823, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Valor Act."
        '
        'txtInstrTecnico
        '
        Me.txtInstrTecnico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInstrTecnico.BackColor = System.Drawing.Color.White
        Me.txtInstrTecnico.Location = New System.Drawing.Point(703, 196)
        Me.txtInstrTecnico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInstrTecnico.Name = "txtInstrTecnico"
        Me.txtInstrTecnico.ReadOnly = True
        Me.txtInstrTecnico.Size = New System.Drawing.Size(371, 22)
        Me.txtInstrTecnico.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(604, 198)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Instr. Técnico"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(703, 224)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(371, 22)
        Me.txtBuscar.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(645, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Location = New System.Drawing.Point(1083, 225)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(148, 23)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(96, 645)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(463, 17)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Usar Comandos en Resultados; -V p/Validar, R- p/Objetar, **p/Confirmar"
        '
        'txtHora2
        '
        Me.txtHora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHora2.Location = New System.Drawing.Point(528, 678)
        Me.txtHora2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHora2.Name = "txtHora2"
        Me.txtHora2.ReadOnly = True
        Me.txtHora2.Size = New System.Drawing.Size(100, 22)
        Me.txtHora2.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(483, 679)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 17)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Hora"
        '
        'txtFecha2
        '
        Me.txtFecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFecha2.Location = New System.Drawing.Point(333, 681)
        Me.txtFecha2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha2.Name = "txtFecha2"
        Me.txtFecha2.ReadOnly = True
        Me.txtFecha2.Size = New System.Drawing.Size(100, 22)
        Me.txtFecha2.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(281, 681)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 17)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Fecha"
        '
        'txtValidador
        '
        Me.txtValidador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValidador.Location = New System.Drawing.Point(135, 679)
        Me.txtValidador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValidador.Name = "txtValidador"
        Me.txtValidador.ReadOnly = True
        Me.txtValidador.Size = New System.Drawing.Size(100, 22)
        Me.txtValidador.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(35, 681)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 17)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Validador Por"
        '
        'txtValoresRef
        '
        Me.txtValoresRef.BackColor = System.Drawing.Color.White
        Me.txtValoresRef.Location = New System.Drawing.Point(107, 198)
        Me.txtValoresRef.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValoresRef.Name = "txtValoresRef"
        Me.txtValoresRef.ReadOnly = True
        Me.txtValoresRef.Size = New System.Drawing.Size(441, 22)
        Me.txtValoresRef.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 199)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 17)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Valores Ref."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbtnNroOrdTrab)
        Me.GroupBox1.Controls.Add(Me.rbtnUrgentes)
        Me.GroupBox1.Controls.Add(Me.rbtnCortesia)
        Me.GroupBox1.Controls.Add(Me.rbtnNombrePaciente)
        Me.GroupBox1.Location = New System.Drawing.Point(1083, 38)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(311, 95)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenado Por"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbxValidado)
        Me.GroupBox2.Controls.Add(Me.cbxProcesado)
        Me.GroupBox2.Controls.Add(Me.cbxEnProceso)
        Me.GroupBox2.Controls.Add(Me.cbxNoProcesado)
        Me.GroupBox2.Controls.Add(Me.cbxPendMuestra)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 84)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1060, 65)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado de Orden de Trabajo"
        '
        'cbxValidado
        '
        Me.cbxValidado.AutoSize = True
        Me.cbxValidado.BackColor = System.Drawing.Color.Transparent
        Me.cbxValidado.Location = New System.Drawing.Point(600, 25)
        Me.cbxValidado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxValidado.Name = "cbxValidado"
        Me.cbxValidado.Size = New System.Drawing.Size(85, 21)
        Me.cbxValidado.TabIndex = 22
        Me.cbxValidado.Text = "Validado"
        Me.cbxValidado.UseVisualStyleBackColor = False
        '
        'cbxProcesado
        '
        Me.cbxProcesado.AutoSize = True
        Me.cbxProcesado.BackColor = System.Drawing.Color.Transparent
        Me.cbxProcesado.Location = New System.Drawing.Point(479, 25)
        Me.cbxProcesado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxProcesado.Name = "cbxProcesado"
        Me.cbxProcesado.Size = New System.Drawing.Size(98, 21)
        Me.cbxProcesado.TabIndex = 21
        Me.cbxProcesado.Text = "Procesado"
        Me.cbxProcesado.UseVisualStyleBackColor = False
        '
        'cbxEnProceso
        '
        Me.cbxEnProceso.AutoSize = True
        Me.cbxEnProceso.BackColor = System.Drawing.Color.Transparent
        Me.cbxEnProceso.Location = New System.Drawing.Point(352, 25)
        Me.cbxEnProceso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxEnProceso.Name = "cbxEnProceso"
        Me.cbxEnProceso.Size = New System.Drawing.Size(103, 21)
        Me.cbxEnProceso.TabIndex = 20
        Me.cbxEnProceso.Text = "En Proceso"
        Me.cbxEnProceso.UseVisualStyleBackColor = False
        '
        'cbxNoProcesado
        '
        Me.cbxNoProcesado.AutoSize = True
        Me.cbxNoProcesado.BackColor = System.Drawing.Color.Transparent
        Me.cbxNoProcesado.Location = New System.Drawing.Point(208, 25)
        Me.cbxNoProcesado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxNoProcesado.Name = "cbxNoProcesado"
        Me.cbxNoProcesado.Size = New System.Drawing.Size(120, 21)
        Me.cbxNoProcesado.TabIndex = 19
        Me.cbxNoProcesado.Text = "No Procesado"
        Me.cbxNoProcesado.UseVisualStyleBackColor = False
        '
        'cbxPendMuestra
        '
        Me.cbxPendMuestra.AutoSize = True
        Me.cbxPendMuestra.BackColor = System.Drawing.Color.Transparent
        Me.cbxPendMuestra.Location = New System.Drawing.Point(16, 25)
        Me.cbxPendMuestra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPendMuestra.Name = "cbxPendMuestra"
        Me.cbxPendMuestra.Size = New System.Drawing.Size(169, 21)
        Me.cbxPendMuestra.TabIndex = 18
        Me.cbxPendMuestra.Text = "Pendiente de Muestra"
        Me.cbxPendMuestra.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1405, 28)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidarDatosToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 26)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ValidarDatosToolStripMenuItem
        '
        Me.ValidarDatosToolStripMenuItem.Name = "ValidarDatosToolStripMenuItem"
        Me.ValidarDatosToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ValidarDatosToolStripMenuItem.Text = "Validar Datos"
        '
        'lblCodeSubArea
        '
        Me.lblCodeSubArea.AutoSize = True
        Me.lblCodeSubArea.Location = New System.Drawing.Point(471, 70)
        Me.lblCodeSubArea.Name = "lblCodeSubArea"
        Me.lblCodeSubArea.Size = New System.Drawing.Size(62, 17)
        Me.lblCodeSubArea.TabIndex = 51
        Me.lblCodeSubArea.Text = "Subárea"
        Me.lblCodeSubArea.Visible = False
        '
        'lblCodeSucursal
        '
        Me.lblCodeSucursal.AutoSize = True
        Me.lblCodeSucursal.Location = New System.Drawing.Point(665, 68)
        Me.lblCodeSucursal.Name = "lblCodeSucursal"
        Me.lblCodeSucursal.Size = New System.Drawing.Size(63, 17)
        Me.lblCodeSucursal.TabIndex = 52
        Me.lblCodeSucursal.Text = "Sucursal"
        Me.lblCodeSucursal.Visible = False
        '
        'E_HojaTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1405, 714)
        Me.Controls.Add(Me.lblCodeSucursal)
        Me.Controls.Add(Me.lblCodeSubArea)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtValoresRef)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtHora2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtFecha2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtValidador)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtInstrTecnico)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtValorActual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDetalleResultado)
        Me.Controls.Add(Me.btnActualizarVista)
        Me.Controls.Add(Me.dgvHojaTrab)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsucursal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSubarea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "E_HojaTrabajo"
        Me.Text = "Hoja de Trabajo"
        CType(Me.dgvHojaTrab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubarea As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsucursal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvHojaTrab As DataGridView
    Friend WithEvents rbtnUrgentes As RadioButton
    Friend WithEvents rbtnCortesia As RadioButton
    Friend WithEvents rbtnNombrePaciente As RadioButton
    Friend WithEvents rbtnNroOrdTrab As RadioButton
    Friend WithEvents btnActualizarVista As Button
    Friend WithEvents btnDetalleResultado As Button
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPaciente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtValorActual As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtInstrTecnico As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtHora2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFecha2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtValidador As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtValoresRef As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbxValidado As CheckBox
    Friend WithEvents cbxProcesado As CheckBox
    Friend WithEvents cbxEnProceso As CheckBox
    Friend WithEvents cbxNoProcesado As CheckBox
    Friend WithEvents cbxPendMuestra As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCodeSubArea As Label
    Friend WithEvents lblCodeSucursal As Label
End Class
