<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Factura
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Factura))
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btnbuscarCliente = New System.Windows.Forms.Button()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.lblmedico = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblterminosPago = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblfechaVto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblconvenio = New System.Windows.Forms.Label()
        Me.lblpoliza = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblpagoPaciente = New System.Windows.Forms.Label()
        Me.lblvuelto = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnumeroFactura = New System.Windows.Forms.TextBox()
        Me.txtnumeroOficial = New System.Windows.Forms.TextBox()
        Me.txtcodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtnombreCliente = New System.Windows.Forms.TextBox()
        Me.txtcodigoMedico = New System.Windows.Forms.TextBox()
        Me.txtnumeroPoliza = New System.Windows.Forms.TextBox()
        Me.dtpfechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaVto = New System.Windows.Forms.DateTimePicker()
        Me.txtcodigoConvenio = New System.Windows.Forms.TextBox()
        Me.txtcodigoTerminal = New System.Windows.Forms.TextBox()
        Me.cbxentregarMedico = New System.Windows.Forms.CheckBox()
        Me.txtcodigoRecepecionista = New System.Windows.Forms.TextBox()
        Me.txtcodigoCajero = New System.Windows.Forms.TextBox()
        Me.txtcodigoSucursal = New System.Windows.Forms.TextBox()
        Me.txtnombreMedico = New System.Windows.Forms.TextBox()
        Me.txtcodigoTerminosPago = New System.Windows.Forms.TextBox()
        Me.txtcodigoSede = New System.Windows.Forms.TextBox()
        Me.cbxentregarPaciente = New System.Windows.Forms.CheckBox()
        Me.cbxenviarCorreo = New System.Windows.Forms.CheckBox()
        Me.txtvuelto = New System.Windows.Forms.TextBox()
        Me.cbxok = New System.Windows.Forms.CheckBox()
        Me.btnimprimirComprobante = New System.Windows.Forms.Button()
        Me.txtnombreSede = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarSede = New System.Windows.Forms.Button()
        Me.btnbuscarMedico = New System.Windows.Forms.Button()
        Me.btnbuscarTerminosPago = New System.Windows.Forms.Button()
        Me.txtpagoPaciente = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnentregarExamen = New System.Windows.Forms.Button()
        Me.btnbusquedaExamen = New System.Windows.Forms.Button()
        Me.btnmuestrasPendientes = New System.Windows.Forms.Button()
        Me.btnestadoFactura = New System.Windows.Forms.Button()
        Me.btnbuscarSucursal = New System.Windows.Forms.Button()
        Me.txtnombreSucursal = New System.Windows.Forms.TextBox()
        Me.txtdescripcionTermino = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblcodeSucursal = New System.Windows.Forms.Label()
        Me.lblcodeTerminoPago = New System.Windows.Forms.Label()
        Me.lblcodePriceList = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.lblTarjeta = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbxAnular = New System.Windows.Forms.CheckBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombreCajero = New System.Windows.Forms.TextBox()
        Me.txtNombreRecepcionista = New System.Windows.Forms.TextBox()
        Me.txtCodigoBreveMaquina = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblVuelto2 = New System.Windows.Forms.Label()
        Me.txtvuelto2 = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.lblTransferencia = New System.Windows.Forms.Label()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.lblDeposito = New System.Windows.Forms.Label()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.tbpObservaciones = New System.Windows.Forms.TabPage()
        Me.dgbObservaciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpExamenes = New System.Windows.Forms.TabPage()
        Me.lblPromocion = New System.Windows.Forms.Label()
        Me.dgblistadoExamenes = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codeDetFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codeItemExam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarPromocion = New System.Windows.Forms.Button()
        Me.btnPromocion = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnNuevaCotizacion = New System.Windows.Forms.Button()
        Me.lblOKAY = New System.Windows.Forms.Label()
        Me.lblRTN = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbpObservaciones.SuspendLayout()
        CType(Me.dgbObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpExamenes.SuspendLayout()
        CType(Me.dgblistadoExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.BackColor = System.Drawing.Color.White
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(54, 84)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(27, 13)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "Nro."
        '
        'btnbuscarCliente
        '
        Me.btnbuscarCliente.BackColor = System.Drawing.Color.White
        Me.btnbuscarCliente.BackgroundImage = CType(resources.GetObject("btnbuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnbuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarCliente.Location = New System.Drawing.Point(95, 102)
        Me.btnbuscarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarCliente.Name = "btnbuscarCliente"
        Me.btnbuscarCliente.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarCliente.TabIndex = 14
        Me.btnbuscarCliente.Text = "..."
        Me.btnbuscarCliente.UseVisualStyleBackColor = False
        '
        'btnnueva
        '
        Me.btnnueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnueva.BackColor = System.Drawing.Color.GhostWhite
        Me.btnnueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.Color.Black
        Me.btnnueva.Location = New System.Drawing.Point(562, 6)
        Me.btnnueva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(97, 28)
        Me.btnnueva.TabIndex = 15
        Me.btnnueva.Text = "Nueva Factura"
        Me.btnnueva.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.BackColor = System.Drawing.Color.LightSalmon
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.Black
        Me.btnsalir.Location = New System.Drawing.Point(926, 6)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 28)
        Me.btnsalir.TabIndex = 17
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(856, 6)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(66, 28)
        Me.btnguardar.TabIndex = 18
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(296, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nro. Oficial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fecha Factura"
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.Location = New System.Drawing.Point(27, 44)
        Me.lblcliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(39, 13)
        Me.lblcliente.TabIndex = 21
        Me.lblcliente.Text = "Cliente"
        '
        'lblmedico
        '
        Me.lblmedico.AutoSize = True
        Me.lblmedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmedico.Location = New System.Drawing.Point(24, 67)
        Me.lblmedico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmedico.Name = "lblmedico"
        Me.lblmedico.Size = New System.Drawing.Size(42, 13)
        Me.lblmedico.TabIndex = 22
        Me.lblmedico.Text = "Médico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(544, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Recepcionista"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(581, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cajero"
        '
        'lblterminosPago
        '
        Me.lblterminosPago.AutoSize = True
        Me.lblterminosPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterminosPago.Location = New System.Drawing.Point(4, 90)
        Me.lblterminosPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblterminosPago.Name = "lblterminosPago"
        Me.lblterminosPago.Size = New System.Drawing.Size(62, 13)
        Me.lblterminosPago.TabIndex = 25
        Me.lblterminosPago.Text = "Term. Pago"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 112)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Sede"
        '
        'lblfechaVto
        '
        Me.lblfechaVto.AutoSize = True
        Me.lblfechaVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechaVto.Location = New System.Drawing.Point(5, 112)
        Me.lblfechaVto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfechaVto.Name = "lblfechaVto"
        Me.lblfechaVto.Size = New System.Drawing.Size(59, 13)
        Me.lblfechaVto.TabIndex = 27
        Me.lblfechaVto.Text = "Fecha Vto."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(308, 137)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Sucursal"
        '
        'lblconvenio
        '
        Me.lblconvenio.AutoSize = True
        Me.lblconvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconvenio.Location = New System.Drawing.Point(14, 135)
        Me.lblconvenio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblconvenio.Name = "lblconvenio"
        Me.lblconvenio.Size = New System.Drawing.Size(52, 13)
        Me.lblconvenio.TabIndex = 29
        Me.lblconvenio.Text = "Convenio"
        '
        'lblpoliza
        '
        Me.lblpoliza.AutoSize = True
        Me.lblpoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpoliza.Location = New System.Drawing.Point(6, 158)
        Me.lblpoliza.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpoliza.Name = "lblpoliza"
        Me.lblpoliza.Size = New System.Drawing.Size(58, 13)
        Me.lblpoliza.TabIndex = 32
        Me.lblpoliza.Text = "Nro. Poliza"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(731, 132)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Terminal"
        '
        'lblpagoPaciente
        '
        Me.lblpagoPaciente.AutoSize = True
        Me.lblpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagoPaciente.Location = New System.Drawing.Point(7, 15)
        Me.lblpagoPaciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpagoPaciente.Name = "lblpagoPaciente"
        Me.lblpagoPaciente.Size = New System.Drawing.Size(173, 16)
        Me.lblpagoPaciente.TabIndex = 36
        Me.lblpagoPaciente.Text = "A Pagar por el Paciente"
        '
        'lblvuelto
        '
        Me.lblvuelto.AutoSize = True
        Me.lblvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvuelto.Location = New System.Drawing.Point(301, 15)
        Me.lblvuelto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvuelto.Name = "lblvuelto"
        Me.lblvuelto.Size = New System.Drawing.Size(52, 16)
        Me.lblvuelto.TabIndex = 37
        Me.lblvuelto.Text = "Vuelto"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(500, 15)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(44, 16)
        Me.lbltotal.TabIndex = 38
        Me.lbltotal.Text = "Total"
        '
        'txtnumeroFactura
        '
        Me.txtnumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroFactura.Location = New System.Drawing.Point(85, 81)
        Me.txtnumeroFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroFactura.Name = "txtnumeroFactura"
        Me.txtnumeroFactura.ReadOnly = True
        Me.txtnumeroFactura.Size = New System.Drawing.Size(208, 19)
        Me.txtnumeroFactura.TabIndex = 39
        Me.txtnumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroOficial
        '
        Me.txtnumeroOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroOficial.Location = New System.Drawing.Point(375, 81)
        Me.txtnumeroOficial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroOficial.Name = "txtnumeroOficial"
        Me.txtnumeroOficial.ReadOnly = True
        Me.txtnumeroOficial.Size = New System.Drawing.Size(173, 19)
        Me.txtnumeroOficial.TabIndex = 40
        Me.txtnumeroOficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCliente
        '
        Me.txtcodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCliente.Location = New System.Drawing.Point(153, 104)
        Me.txtcodigoCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCliente.MaxLength = 20
        Me.txtcodigoCliente.Name = "txtcodigoCliente"
        Me.txtcodigoCliente.Size = New System.Drawing.Size(140, 19)
        Me.txtcodigoCliente.TabIndex = 41
        Me.txtcodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreCliente
        '
        Me.txtnombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreCliente.Location = New System.Drawing.Point(313, 104)
        Me.txtnombreCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreCliente.Name = "txtnombreCliente"
        Me.txtnombreCliente.ReadOnly = True
        Me.txtnombreCliente.Size = New System.Drawing.Size(236, 19)
        Me.txtnombreCliente.TabIndex = 42
        '
        'txtcodigoMedico
        '
        Me.txtcodigoMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoMedico.Location = New System.Drawing.Point(153, 127)
        Me.txtcodigoMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoMedico.MaxLength = 20
        Me.txtcodigoMedico.Name = "txtcodigoMedico"
        Me.txtcodigoMedico.Size = New System.Drawing.Size(140, 19)
        Me.txtcodigoMedico.TabIndex = 43
        Me.txtcodigoMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroPoliza
        '
        Me.txtnumeroPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroPoliza.Location = New System.Drawing.Point(85, 218)
        Me.txtnumeroPoliza.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroPoliza.Name = "txtnumeroPoliza"
        Me.txtnumeroPoliza.Size = New System.Drawing.Size(208, 19)
        Me.txtnumeroPoliza.TabIndex = 45
        Me.txtnumeroPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpfechaFactura
        '
        Me.dtpfechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaFactura.Location = New System.Drawing.Point(638, 82)
        Me.dtpfechaFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpfechaFactura.Name = "dtpfechaFactura"
        Me.dtpfechaFactura.Size = New System.Drawing.Size(178, 19)
        Me.dtpfechaFactura.TabIndex = 46
        '
        'dtpfechaVto
        '
        Me.dtpfechaVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaVto.Location = New System.Drawing.Point(85, 172)
        Me.dtpfechaVto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpfechaVto.Name = "dtpfechaVto"
        Me.dtpfechaVto.Size = New System.Drawing.Size(208, 19)
        Me.dtpfechaVto.TabIndex = 47
        '
        'txtcodigoConvenio
        '
        Me.txtcodigoConvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoConvenio.Location = New System.Drawing.Point(85, 195)
        Me.txtcodigoConvenio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoConvenio.Name = "txtcodigoConvenio"
        Me.txtcodigoConvenio.ReadOnly = True
        Me.txtcodigoConvenio.Size = New System.Drawing.Size(208, 19)
        Me.txtcodigoConvenio.TabIndex = 48
        Me.txtcodigoConvenio.Text = "x`"
        Me.txtcodigoConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTerminal
        '
        Me.txtcodigoTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoTerminal.Location = New System.Drawing.Point(791, 147)
        Me.txtcodigoTerminal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTerminal.Name = "txtcodigoTerminal"
        Me.txtcodigoTerminal.ReadOnly = True
        Me.txtcodigoTerminal.Size = New System.Drawing.Size(176, 19)
        Me.txtcodigoTerminal.TabIndex = 49
        Me.txtcodigoTerminal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigoTerminal.Visible = False
        '
        'cbxentregarMedico
        '
        Me.cbxentregarMedico.AutoSize = True
        Me.cbxentregarMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxentregarMedico.Location = New System.Drawing.Point(13, 23)
        Me.cbxentregarMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxentregarMedico.Name = "cbxentregarMedico"
        Me.cbxentregarMedico.Size = New System.Drawing.Size(127, 19)
        Me.cbxentregarMedico.TabIndex = 50
        Me.cbxentregarMedico.Text = "Entregar a Médico"
        Me.cbxentregarMedico.UseVisualStyleBackColor = True
        '
        'txtcodigoRecepecionista
        '
        Me.txtcodigoRecepecionista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoRecepecionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoRecepecionista.Location = New System.Drawing.Point(638, 104)
        Me.txtcodigoRecepecionista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoRecepecionista.Name = "txtcodigoRecepecionista"
        Me.txtcodigoRecepecionista.Size = New System.Drawing.Size(30, 19)
        Me.txtcodigoRecepecionista.TabIndex = 51
        Me.txtcodigoRecepecionista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigoRecepecionista.Visible = False
        '
        'txtcodigoCajero
        '
        Me.txtcodigoCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCajero.Location = New System.Drawing.Point(638, 128)
        Me.txtcodigoCajero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCajero.Name = "txtcodigoCajero"
        Me.txtcodigoCajero.Size = New System.Drawing.Size(30, 19)
        Me.txtcodigoCajero.TabIndex = 52
        Me.txtcodigoCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigoCajero.Visible = False
        '
        'txtcodigoSucursal
        '
        Me.txtcodigoSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoSucursal.Location = New System.Drawing.Point(448, 197)
        Me.txtcodigoSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoSucursal.MaxLength = 20
        Me.txtcodigoSucursal.Name = "txtcodigoSucursal"
        Me.txtcodigoSucursal.Size = New System.Drawing.Size(101, 19)
        Me.txtcodigoSucursal.TabIndex = 53
        Me.txtcodigoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreMedico
        '
        Me.txtnombreMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreMedico.Location = New System.Drawing.Point(313, 127)
        Me.txtnombreMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreMedico.Name = "txtnombreMedico"
        Me.txtnombreMedico.ReadOnly = True
        Me.txtnombreMedico.Size = New System.Drawing.Size(235, 19)
        Me.txtnombreMedico.TabIndex = 54
        '
        'txtcodigoTerminosPago
        '
        Me.txtcodigoTerminosPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoTerminosPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoTerminosPago.Location = New System.Drawing.Point(153, 150)
        Me.txtcodigoTerminosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTerminosPago.MaxLength = 20
        Me.txtcodigoTerminosPago.Name = "txtcodigoTerminosPago"
        Me.txtcodigoTerminosPago.Size = New System.Drawing.Size(140, 19)
        Me.txtcodigoTerminosPago.TabIndex = 58
        Me.txtcodigoTerminosPago.Text = "CO"
        Me.txtcodigoTerminosPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSede
        '
        Me.txtcodigoSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoSede.Location = New System.Drawing.Point(448, 173)
        Me.txtcodigoSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoSede.MaxLength = 20
        Me.txtcodigoSede.Name = "txtcodigoSede"
        Me.txtcodigoSede.Size = New System.Drawing.Size(101, 19)
        Me.txtcodigoSede.TabIndex = 60
        Me.txtcodigoSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxentregarPaciente
        '
        Me.cbxentregarPaciente.AutoSize = True
        Me.cbxentregarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxentregarPaciente.Location = New System.Drawing.Point(13, 46)
        Me.cbxentregarPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxentregarPaciente.Name = "cbxentregarPaciente"
        Me.cbxentregarPaciente.Size = New System.Drawing.Size(134, 19)
        Me.cbxentregarPaciente.TabIndex = 62
        Me.cbxentregarPaciente.Text = "Entregar a Paciente"
        Me.cbxentregarPaciente.UseVisualStyleBackColor = True
        '
        'cbxenviarCorreo
        '
        Me.cbxenviarCorreo.AutoSize = True
        Me.cbxenviarCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxenviarCorreo.Location = New System.Drawing.Point(13, 68)
        Me.cbxenviarCorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxenviarCorreo.Name = "cbxenviarCorreo"
        Me.cbxenviarCorreo.Size = New System.Drawing.Size(121, 19)
        Me.cbxenviarCorreo.TabIndex = 63
        Me.cbxenviarCorreo.Text = "Enviar por Correo"
        Me.cbxenviarCorreo.UseVisualStyleBackColor = True
        '
        'txtvuelto
        '
        Me.txtvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvuelto.Location = New System.Drawing.Point(367, 9)
        Me.txtvuelto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtvuelto.Name = "txtvuelto"
        Me.txtvuelto.ReadOnly = True
        Me.txtvuelto.Size = New System.Drawing.Size(108, 22)
        Me.txtvuelto.TabIndex = 65
        Me.txtvuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxok
        '
        Me.cbxok.AutoSize = True
        Me.cbxok.Enabled = False
        Me.cbxok.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxok.Location = New System.Drawing.Point(12, 5)
        Me.cbxok.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxok.Name = "cbxok"
        Me.cbxok.Size = New System.Drawing.Size(41, 17)
        Me.cbxok.TabIndex = 67
        Me.cbxok.Text = "OK"
        Me.cbxok.UseVisualStyleBackColor = True
        '
        'btnimprimirComprobante
        '
        Me.btnimprimirComprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnimprimirComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimprimirComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimirComprobante.Location = New System.Drawing.Point(557, 119)
        Me.btnimprimirComprobante.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnimprimirComprobante.Name = "btnimprimirComprobante"
        Me.btnimprimirComprobante.Size = New System.Drawing.Size(94, 58)
        Me.btnimprimirComprobante.TabIndex = 70
        Me.btnimprimirComprobante.Text = "Imprimir Comprobante Examen"
        Me.btnimprimirComprobante.UseVisualStyleBackColor = False
        '
        'txtnombreSede
        '
        Me.txtnombreSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreSede.Location = New System.Drawing.Point(556, 175)
        Me.txtnombreSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreSede.Name = "txtnombreSede"
        Me.txtnombreSede.ReadOnly = True
        Me.txtnombreSede.Size = New System.Drawing.Size(138, 19)
        Me.txtnombreSede.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.cbxentregarMedico)
        Me.GroupBox1.Controls.Add(Me.cbxentregarPaciente)
        Me.GroupBox1.Controls.Add(Me.cbxenviarCorreo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(813, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(152, 96)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'btnbuscarSede
        '
        Me.btnbuscarSede.BackColor = System.Drawing.Color.White
        Me.btnbuscarSede.BackgroundImage = CType(resources.GetObject("btnbuscarSede.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarSede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarSede.FlatAppearance.BorderSize = 0
        Me.btnbuscarSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarSede.Location = New System.Drawing.Point(390, 173)
        Me.btnbuscarSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarSede.Name = "btnbuscarSede"
        Me.btnbuscarSede.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarSede.TabIndex = 80
        Me.btnbuscarSede.Text = "..."
        Me.btnbuscarSede.UseVisualStyleBackColor = False
        '
        'btnbuscarMedico
        '
        Me.btnbuscarMedico.BackColor = System.Drawing.Color.White
        Me.btnbuscarMedico.BackgroundImage = CType(resources.GetObject("btnbuscarMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarMedico.FlatAppearance.BorderSize = 0
        Me.btnbuscarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarMedico.Location = New System.Drawing.Point(95, 127)
        Me.btnbuscarMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarMedico.Name = "btnbuscarMedico"
        Me.btnbuscarMedico.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarMedico.TabIndex = 81
        Me.btnbuscarMedico.Text = "..."
        Me.btnbuscarMedico.UseVisualStyleBackColor = False
        '
        'btnbuscarTerminosPago
        '
        Me.btnbuscarTerminosPago.BackColor = System.Drawing.Color.White
        Me.btnbuscarTerminosPago.BackgroundImage = CType(resources.GetObject("btnbuscarTerminosPago.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarTerminosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarTerminosPago.FlatAppearance.BorderSize = 0
        Me.btnbuscarTerminosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarTerminosPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarTerminosPago.Location = New System.Drawing.Point(95, 150)
        Me.btnbuscarTerminosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarTerminosPago.Name = "btnbuscarTerminosPago"
        Me.btnbuscarTerminosPago.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarTerminosPago.TabIndex = 82
        Me.btnbuscarTerminosPago.Text = "..."
        Me.btnbuscarTerminosPago.UseVisualStyleBackColor = False
        '
        'txtpagoPaciente
        '
        Me.txtpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagoPaciente.Location = New System.Drawing.Point(184, 9)
        Me.txtpagoPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpagoPaciente.MaxLength = 20
        Me.txtpagoPaciente.Name = "txtpagoPaciente"
        Me.txtpagoPaciente.ReadOnly = True
        Me.txtpagoPaciente.Size = New System.Drawing.Size(108, 22)
        Me.txtpagoPaciente.TabIndex = 83
        Me.txtpagoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.Khaki
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.Color.OrangeRed
        Me.txttotal.Location = New System.Drawing.Point(552, 9)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(147, 22)
        Me.txttotal.TabIndex = 84
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnentregarExamen
        '
        Me.btnentregarExamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentregarExamen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnentregarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentregarExamen.Location = New System.Drawing.Point(655, 119)
        Me.btnentregarExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnentregarExamen.Name = "btnentregarExamen"
        Me.btnentregarExamen.Size = New System.Drawing.Size(94, 58)
        Me.btnentregarExamen.TabIndex = 85
        Me.btnentregarExamen.Text = "Entregar Examen"
        Me.btnentregarExamen.UseVisualStyleBackColor = False
        '
        'btnbusquedaExamen
        '
        Me.btnbusquedaExamen.BackColor = System.Drawing.Color.Yellow
        Me.btnbusquedaExamen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbusquedaExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusquedaExamen.Location = New System.Drawing.Point(459, 119)
        Me.btnbusquedaExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbusquedaExamen.Name = "btnbusquedaExamen"
        Me.btnbusquedaExamen.Size = New System.Drawing.Size(94, 58)
        Me.btnbusquedaExamen.TabIndex = 86
        Me.btnbusquedaExamen.Text = "Búsqueda de Examen"
        Me.btnbusquedaExamen.UseVisualStyleBackColor = False
        '
        'btnmuestrasPendientes
        '
        Me.btnmuestrasPendientes.BackColor = System.Drawing.Color.Yellow
        Me.btnmuestrasPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmuestrasPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmuestrasPendientes.Location = New System.Drawing.Point(360, 119)
        Me.btnmuestrasPendientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmuestrasPendientes.Name = "btnmuestrasPendientes"
        Me.btnmuestrasPendientes.Size = New System.Drawing.Size(94, 58)
        Me.btnmuestrasPendientes.TabIndex = 87
        Me.btnmuestrasPendientes.Text = "Muestras Pendientes"
        Me.btnmuestrasPendientes.UseVisualStyleBackColor = False
        '
        'btnestadoFactura
        '
        Me.btnestadoFactura.BackColor = System.Drawing.Color.Yellow
        Me.btnestadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnestadoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnestadoFactura.Location = New System.Drawing.Point(262, 119)
        Me.btnestadoFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnestadoFactura.Name = "btnestadoFactura"
        Me.btnestadoFactura.Size = New System.Drawing.Size(94, 58)
        Me.btnestadoFactura.TabIndex = 88
        Me.btnestadoFactura.Text = "Estado Factura"
        Me.btnestadoFactura.UseVisualStyleBackColor = False
        '
        'btnbuscarSucursal
        '
        Me.btnbuscarSucursal.BackColor = System.Drawing.Color.White
        Me.btnbuscarSucursal.BackgroundImage = CType(resources.GetObject("btnbuscarSucursal.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarSucursal.FlatAppearance.BorderSize = 0
        Me.btnbuscarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarSucursal.Location = New System.Drawing.Point(391, 197)
        Me.btnbuscarSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarSucursal.Name = "btnbuscarSucursal"
        Me.btnbuscarSucursal.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarSucursal.TabIndex = 92
        Me.btnbuscarSucursal.Text = "..."
        Me.btnbuscarSucursal.UseVisualStyleBackColor = False
        '
        'txtnombreSucursal
        '
        Me.txtnombreSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreSucursal.Location = New System.Drawing.Point(556, 198)
        Me.txtnombreSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreSucursal.Name = "txtnombreSucursal"
        Me.txtnombreSucursal.ReadOnly = True
        Me.txtnombreSucursal.Size = New System.Drawing.Size(138, 19)
        Me.txtnombreSucursal.TabIndex = 94
        '
        'txtdescripcionTermino
        '
        Me.txtdescripcionTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionTermino.Location = New System.Drawing.Point(313, 150)
        Me.txtdescripcionTermino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionTermino.Name = "txtdescripcionTermino"
        Me.txtdescripcionTermino.ReadOnly = True
        Me.txtdescripcionTermino.Size = New System.Drawing.Size(235, 19)
        Me.txtdescripcionTermino.TabIndex = 95
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.BackColor = System.Drawing.Color.AliceBlue
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.Black
        Me.btnActualizar.Location = New System.Drawing.Point(780, 6)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 28)
        Me.btnActualizar.TabIndex = 97
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'lblcodeSucursal
        '
        Me.lblcodeSucursal.AutoSize = True
        Me.lblcodeSucursal.Location = New System.Drawing.Point(297, 201)
        Me.lblcodeSucursal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeSucursal.Name = "lblcodeSucursal"
        Me.lblcodeSucursal.Size = New System.Drawing.Size(0, 13)
        Me.lblcodeSucursal.TabIndex = 98
        Me.lblcodeSucursal.Visible = False
        '
        'lblcodeTerminoPago
        '
        Me.lblcodeTerminoPago.AutoSize = True
        Me.lblcodeTerminoPago.Location = New System.Drawing.Point(9, 141)
        Me.lblcodeTerminoPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeTerminoPago.Name = "lblcodeTerminoPago"
        Me.lblcodeTerminoPago.Size = New System.Drawing.Size(0, 13)
        Me.lblcodeTerminoPago.TabIndex = 99
        Me.lblcodeTerminoPago.Visible = False
        '
        'lblcodePriceList
        '
        Me.lblcodePriceList.AutoSize = True
        Me.lblcodePriceList.Location = New System.Drawing.Point(23, 47)
        Me.lblcodePriceList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodePriceList.Name = "lblcodePriceList"
        Me.lblcodePriceList.Size = New System.Drawing.Size(39, 13)
        Me.lblcodePriceList.TabIndex = 100
        Me.lblcodePriceList.Text = "Label1"
        Me.lblcodePriceList.Visible = False
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(82, 47)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaNacimiento.TabIndex = 101
        Me.lblFechaNacimiento.Text = "Label1"
        Me.lblFechaNacimiento.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectivo.Location = New System.Drawing.Point(106, 50)
        Me.txtEfectivo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEfectivo.MaxLength = 20
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(140, 19)
        Me.txtEfectivo.TabIndex = 103
        Me.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTarjeta
        '
        Me.txtTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarjeta.Location = New System.Drawing.Point(97, 59)
        Me.txtTarjeta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTarjeta.MaxLength = 20
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(140, 19)
        Me.txtTarjeta.TabIndex = 102
        Me.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEfectivo
        '
        Me.lblEfectivo.AutoSize = True
        Me.lblEfectivo.Location = New System.Drawing.Point(7, 42)
        Me.lblEfectivo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(46, 13)
        Me.lblEfectivo.TabIndex = 104
        Me.lblEfectivo.Text = "Efectivo"
        '
        'lblTarjeta
        '
        Me.lblTarjeta.AutoSize = True
        Me.lblTarjeta.Location = New System.Drawing.Point(7, 65)
        Me.lblTarjeta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTarjeta.Name = "lblTarjeta"
        Me.lblTarjeta.Size = New System.Drawing.Size(40, 13)
        Me.lblTarjeta.TabIndex = 105
        Me.lblTarjeta.Text = "Tarjeta"
        '
        'Timer1
        '
        '
        'cbxAnular
        '
        Me.cbxAnular.AutoSize = True
        Me.cbxAnular.Location = New System.Drawing.Point(97, 5)
        Me.cbxAnular.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxAnular.Name = "cbxAnular"
        Me.cbxAnular.Size = New System.Drawing.Size(95, 17)
        Me.cbxAnular.TabIndex = 107
        Me.cbxAnular.Text = "Anular Factura"
        Me.cbxAnular.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.Yellow
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(483, 6)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(74, 28)
        Me.btnImprimir.TabIndex = 108
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtNombreCajero)
        Me.GroupBox2.Controls.Add(Me.txtNombreRecepcionista)
        Me.GroupBox2.Controls.Add(Me.txtCodigoBreveMaquina)
        Me.GroupBox2.Controls.Add(Me.txtcodigoTerminal)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblcliente)
        Me.GroupBox2.Controls.Add(Me.lblmedico)
        Me.GroupBox2.Controls.Add(Me.lblterminosPago)
        Me.GroupBox2.Controls.Add(Me.lblfechaVto)
        Me.GroupBox2.Controls.Add(Me.lblconvenio)
        Me.GroupBox2.Controls.Add(Me.lblpoliza)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 66)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(969, 181)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Cliente"
        '
        'txtNombreCajero
        '
        Me.txtNombreCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCajero.Location = New System.Drawing.Point(622, 63)
        Me.txtNombreCajero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreCajero.Name = "txtNombreCajero"
        Me.txtNombreCajero.ReadOnly = True
        Me.txtNombreCajero.Size = New System.Drawing.Size(178, 19)
        Me.txtNombreCajero.TabIndex = 112
        Me.txtNombreCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreRecepcionista
        '
        Me.txtNombreRecepcionista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreRecepcionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreRecepcionista.Location = New System.Drawing.Point(622, 40)
        Me.txtNombreRecepcionista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreRecepcionista.Name = "txtNombreRecepcionista"
        Me.txtNombreRecepcionista.ReadOnly = True
        Me.txtNombreRecepcionista.Size = New System.Drawing.Size(178, 19)
        Me.txtNombreRecepcionista.TabIndex = 111
        Me.txtNombreRecepcionista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigoBreveMaquina
        '
        Me.txtCodigoBreveMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBreveMaquina.Location = New System.Drawing.Point(791, 125)
        Me.txtCodigoBreveMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigoBreveMaquina.Name = "txtCodigoBreveMaquina"
        Me.txtCodigoBreveMaquina.ReadOnly = True
        Me.txtCodigoBreveMaquina.Size = New System.Drawing.Size(174, 19)
        Me.txtCodigoBreveMaquina.TabIndex = 50
        Me.txtCodigoBreveMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.btnestadoFactura)
        Me.GroupBox3.Controls.Add(Me.txtEfectivo)
        Me.GroupBox3.Controls.Add(Me.btnimprimirComprobante)
        Me.GroupBox3.Controls.Add(Me.btnentregarExamen)
        Me.GroupBox3.Controls.Add(Me.btnbusquedaExamen)
        Me.GroupBox3.Controls.Add(Me.btnmuestrasPendientes)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 488)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(970, 182)
        Me.GroupBox3.TabIndex = 110
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de pago"
        '
        'lblVuelto2
        '
        Me.lblVuelto2.AutoSize = True
        Me.lblVuelto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVuelto2.Location = New System.Drawing.Point(46, 59)
        Me.lblVuelto2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVuelto2.Name = "lblVuelto2"
        Me.lblVuelto2.Size = New System.Drawing.Size(37, 13)
        Me.lblVuelto2.TabIndex = 118
        Me.lblVuelto2.Text = "Vuelto"
        '
        'txtvuelto2
        '
        Me.txtvuelto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvuelto2.Location = New System.Drawing.Point(87, 53)
        Me.txtvuelto2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtvuelto2.Name = "txtvuelto2"
        Me.txtvuelto2.ReadOnly = True
        Me.txtvuelto2.Size = New System.Drawing.Size(108, 19)
        Me.txtvuelto2.TabIndex = 119
        Me.txtvuelto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.Location = New System.Drawing.Point(304, 53)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.ReadOnly = True
        Me.txtPorcentaje.Size = New System.Drawing.Size(108, 19)
        Me.txtPorcentaje.TabIndex = 117
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.Location = New System.Drawing.Point(202, 56)
        Me.lblPorcentaje.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(98, 13)
        Me.lblPorcentaje.TabIndex = 116
        Me.lblPorcentaje.Text = "Porcentaje a Pagar"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.Location = New System.Drawing.Point(466, 50)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(108, 19)
        Me.txtsubtotal.TabIndex = 115
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(416, 53)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 114
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblCheque
        '
        Me.lblCheque.AutoSize = True
        Me.lblCheque.Location = New System.Drawing.Point(7, 134)
        Me.lblCheque.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(44, 13)
        Me.lblCheque.TabIndex = 113
        Me.lblCheque.Text = "Cheque"
        '
        'txtCheque
        '
        Me.txtCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(97, 128)
        Me.txtCheque.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCheque.MaxLength = 20
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(140, 19)
        Me.txtCheque.TabIndex = 112
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTransferencia
        '
        Me.lblTransferencia.AutoSize = True
        Me.lblTransferencia.Location = New System.Drawing.Point(9, 111)
        Me.lblTransferencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTransferencia.Name = "lblTransferencia"
        Me.lblTransferencia.Size = New System.Drawing.Size(72, 13)
        Me.lblTransferencia.TabIndex = 111
        Me.lblTransferencia.Text = "Transferencia"
        '
        'txtTransferencia
        '
        Me.txtTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferencia.Location = New System.Drawing.Point(97, 105)
        Me.txtTransferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTransferencia.MaxLength = 20
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(140, 19)
        Me.txtTransferencia.TabIndex = 110
        Me.txtTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDeposito
        '
        Me.lblDeposito.AutoSize = True
        Me.lblDeposito.Location = New System.Drawing.Point(7, 88)
        Me.lblDeposito.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDeposito.Name = "lblDeposito"
        Me.lblDeposito.Size = New System.Drawing.Size(49, 13)
        Me.lblDeposito.TabIndex = 109
        Me.lblDeposito.Text = "Depósito"
        '
        'txtDeposito
        '
        Me.txtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposito.Location = New System.Drawing.Point(97, 82)
        Me.txtDeposito.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDeposito.MaxLength = 20
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(140, 19)
        Me.txtDeposito.TabIndex = 108
        Me.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbpObservaciones
        '
        Me.tbpObservaciones.BackColor = System.Drawing.Color.White
        Me.tbpObservaciones.Controls.Add(Me.dgbObservaciones)
        Me.tbpObservaciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpObservaciones.Name = "tbpObservaciones"
        Me.tbpObservaciones.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpObservaciones.Size = New System.Drawing.Size(966, 197)
        Me.tbpObservaciones.TabIndex = 1
        Me.tbpObservaciones.Text = "Observaciones"
        '
        'dgbObservaciones
        '
        Me.dgbObservaciones.AllowUserToAddRows = False
        Me.dgbObservaciones.AllowUserToDeleteRows = False
        Me.dgbObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbObservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbObservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgbObservaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgbObservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbObservaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn9})
        Me.dgbObservaciones.Location = New System.Drawing.Point(8, 4)
        Me.dgbObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbObservaciones.Name = "dgbObservaciones"
        Me.dgbObservaciones.RowHeadersVisible = False
        Me.dgbObservaciones.RowHeadersWidth = 51
        Me.dgbObservaciones.RowTemplate.Height = 24
        Me.dgbObservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbObservaciones.Size = New System.Drawing.Size(948, 189)
        Me.dgbObservaciones.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 23.80952!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código Examen"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 176.1905!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "codeDetFact"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'tbpExamenes
        '
        Me.tbpExamenes.BackColor = System.Drawing.Color.White
        Me.tbpExamenes.Controls.Add(Me.lblPromocion)
        Me.tbpExamenes.Controls.Add(Me.dgblistadoExamenes)
        Me.tbpExamenes.Controls.Add(Me.btnQuitarPromocion)
        Me.tbpExamenes.Controls.Add(Me.btnPromocion)
        Me.tbpExamenes.Location = New System.Drawing.Point(4, 22)
        Me.tbpExamenes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpExamenes.Name = "tbpExamenes"
        Me.tbpExamenes.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbpExamenes.Size = New System.Drawing.Size(966, 207)
        Me.tbpExamenes.TabIndex = 0
        Me.tbpExamenes.Text = "Exámenes"
        '
        'lblPromocion
        '
        Me.lblPromocion.AutoSize = True
        Me.lblPromocion.Location = New System.Drawing.Point(372, 8)
        Me.lblPromocion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPromocion.Name = "lblPromocion"
        Me.lblPromocion.Size = New System.Drawing.Size(13, 13)
        Me.lblPromocion.TabIndex = 105
        Me.lblPromocion.Text = "0"
        Me.lblPromocion.Visible = False
        '
        'dgblistadoExamenes
        '
        Me.dgblistadoExamenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgblistadoExamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgblistadoExamenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgblistadoExamenes.BackgroundColor = System.Drawing.Color.White
        Me.dgblistadoExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgblistadoExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Cantidad, Me.Precio, Me.Descripcion, Me.FechaEntrega, Me.Descuento, Me.Subtotal, Me.subArea, Me.codeDetFact, Me.codeItemExam})
        Me.dgblistadoExamenes.Location = New System.Drawing.Point(10, 41)
        Me.dgblistadoExamenes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgblistadoExamenes.Name = "dgblistadoExamenes"
        Me.dgblistadoExamenes.RowHeadersVisible = False
        Me.dgblistadoExamenes.RowHeadersWidth = 51
        Me.dgblistadoExamenes.RowTemplate.Height = 24
        Me.dgblistadoExamenes.Size = New System.Drawing.Size(953, 163)
        Me.dgblistadoExamenes.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.FillWeight = 61.71429!
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        '
        'Cantidad
        '
        Me.Cantidad.FillWeight = 78.78874!
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.FillWeight = 70.54861!
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 110.2328!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 100
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'FechaEntrega
        '
        Me.FechaEntrega.FillWeight = 122.8278!
        Me.FechaEntrega.HeaderText = "Fecha Entrega"
        Me.FechaEntrega.MinimumWidth = 6
        Me.FechaEntrega.Name = "FechaEntrega"
        Me.FechaEntrega.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.FillWeight = 111.2212!
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.MinimumWidth = 6
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.FillWeight = 97.66737!
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'subArea
        '
        Me.subArea.HeaderText = "subArea"
        Me.subArea.MinimumWidth = 6
        Me.subArea.Name = "subArea"
        Me.subArea.Visible = False
        '
        'codeDetFact
        '
        Me.codeDetFact.HeaderText = "codeDetFact"
        Me.codeDetFact.MinimumWidth = 6
        Me.codeDetFact.Name = "codeDetFact"
        Me.codeDetFact.Visible = False
        '
        'codeItemExam
        '
        Me.codeItemExam.FillWeight = 146.9992!
        Me.codeItemExam.HeaderText = "codeItemExam"
        Me.codeItemExam.MinimumWidth = 6
        Me.codeItemExam.Name = "codeItemExam"
        Me.codeItemExam.Visible = False
        '
        'btnQuitarPromocion
        '
        Me.btnQuitarPromocion.BackColor = System.Drawing.Color.LightSalmon
        Me.btnQuitarPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarPromocion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarPromocion.ForeColor = System.Drawing.Color.Black
        Me.btnQuitarPromocion.Location = New System.Drawing.Point(685, 9)
        Me.btnQuitarPromocion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuitarPromocion.Name = "btnQuitarPromocion"
        Me.btnQuitarPromocion.Size = New System.Drawing.Size(156, 28)
        Me.btnQuitarPromocion.TabIndex = 104
        Me.btnQuitarPromocion.Text = "Quitar Promoción"
        Me.btnQuitarPromocion.UseVisualStyleBackColor = False
        '
        'btnPromocion
        '
        Me.btnPromocion.BackColor = System.Drawing.Color.LawnGreen
        Me.btnPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromocion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromocion.ForeColor = System.Drawing.Color.Black
        Me.btnPromocion.Location = New System.Drawing.Point(10, 9)
        Me.btnPromocion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPromocion.Name = "btnPromocion"
        Me.btnPromocion.Size = New System.Drawing.Size(162, 28)
        Me.btnPromocion.TabIndex = 103
        Me.btnPromocion.Text = "Agregar Promoción"
        Me.btnPromocion.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbpExamenes)
        Me.TabControl1.Controls.Add(Me.tbpObservaciones)
        Me.TabControl1.Location = New System.Drawing.Point(16, 251)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 233)
        Me.TabControl1.TabIndex = 112
        '
        'btnNuevaCotizacion
        '
        Me.btnNuevaCotizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaCotizacion.BackColor = System.Drawing.Color.White
        Me.btnNuevaCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaCotizacion.ForeColor = System.Drawing.Color.Black
        Me.btnNuevaCotizacion.Location = New System.Drawing.Point(663, 6)
        Me.btnNuevaCotizacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNuevaCotizacion.Name = "btnNuevaCotizacion"
        Me.btnNuevaCotizacion.Size = New System.Drawing.Size(111, 28)
        Me.btnNuevaCotizacion.TabIndex = 113
        Me.btnNuevaCotizacion.Text = "Nueva Cotización"
        Me.btnNuevaCotizacion.UseVisualStyleBackColor = False
        '
        'lblOKAY
        '
        Me.lblOKAY.AutoSize = True
        Me.lblOKAY.Location = New System.Drawing.Point(140, 47)
        Me.lblOKAY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOKAY.Name = "lblOKAY"
        Me.lblOKAY.Size = New System.Drawing.Size(39, 13)
        Me.lblOKAY.TabIndex = 114
        Me.lblOKAY.Text = "Label1"
        Me.lblOKAY.Visible = False
        '
        'lblRTN
        '
        Me.lblRTN.AutoSize = True
        Me.lblRTN.Location = New System.Drawing.Point(222, 47)
        Me.lblRTN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRTN.Name = "lblRTN"
        Me.lblRTN.Size = New System.Drawing.Size(35, 13)
        Me.lblRTN.TabIndex = 115
        Me.lblRTN.Text = "label1"
        Me.lblRTN.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 672)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1001, 22)
        Me.StatusStrip1.TabIndex = 116
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 27)
        Me.Button1.TabIndex = 117
        Me.Button1.Text = "Buscar Examen"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnsalir)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnnueva)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.btnNuevaCotizacion)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 40)
        Me.Panel1.TabIndex = 113
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.txtsubtotal)
        Me.Panel2.Controls.Add(Me.lbltotal)
        Me.Panel2.Controls.Add(Me.lblvuelto)
        Me.Panel2.Controls.Add(Me.txttotal)
        Me.Panel2.Controls.Add(Me.txtvuelto)
        Me.Panel2.Controls.Add(Me.lblpagoPaciente)
        Me.Panel2.Controls.Add(Me.txtPorcentaje)
        Me.Panel2.Controls.Add(Me.lblSubtotal)
        Me.Panel2.Controls.Add(Me.txtvuelto2)
        Me.Panel2.Controls.Add(Me.lblPorcentaje)
        Me.Panel2.Controls.Add(Me.txtpagoPaciente)
        Me.Panel2.Controls.Add(Me.lblVuelto2)
        Me.Panel2.Location = New System.Drawing.Point(261, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(704, 100)
        Me.Panel2.TabIndex = 120
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.txtCheque)
        Me.Panel3.Controls.Add(Me.txtTransferencia)
        Me.Panel3.Controls.Add(Me.txtTarjeta)
        Me.Panel3.Controls.Add(Me.txtDeposito)
        Me.Panel3.Controls.Add(Me.lblEfectivo)
        Me.Panel3.Controls.Add(Me.lblTarjeta)
        Me.Panel3.Controls.Add(Me.lblCheque)
        Me.Panel3.Controls.Add(Me.cbxAnular)
        Me.Panel3.Controls.Add(Me.lblDeposito)
        Me.Panel3.Controls.Add(Me.lblTransferencia)
        Me.Panel3.Controls.Add(Me.cbxok)
        Me.Panel3.Location = New System.Drawing.Point(9, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 163)
        Me.Panel3.TabIndex = 121
        '
        'M_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1001, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblRTN)
        Me.Controls.Add(Me.lblOKAY)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblFechaNacimiento)
        Me.Controls.Add(Me.lblcodePriceList)
        Me.Controls.Add(Me.lblcodeTerminoPago)
        Me.Controls.Add(Me.lblcodeSucursal)
        Me.Controls.Add(Me.txtdescripcionTermino)
        Me.Controls.Add(Me.txtnombreSucursal)
        Me.Controls.Add(Me.btnbuscarSucursal)
        Me.Controls.Add(Me.btnbuscarTerminosPago)
        Me.Controls.Add(Me.btnbuscarMedico)
        Me.Controls.Add(Me.btnbuscarSede)
        Me.Controls.Add(Me.txtnombreSede)
        Me.Controls.Add(Me.txtcodigoSede)
        Me.Controls.Add(Me.txtcodigoTerminosPago)
        Me.Controls.Add(Me.txtnombreMedico)
        Me.Controls.Add(Me.txtcodigoSucursal)
        Me.Controls.Add(Me.txtcodigoCajero)
        Me.Controls.Add(Me.txtcodigoRecepecionista)
        Me.Controls.Add(Me.txtcodigoConvenio)
        Me.Controls.Add(Me.dtpfechaVto)
        Me.Controls.Add(Me.dtpfechaFactura)
        Me.Controls.Add(Me.txtnumeroPoliza)
        Me.Controls.Add(Me.txtcodigoMedico)
        Me.Controls.Add(Me.txtnombreCliente)
        Me.Controls.Add(Me.txtcodigoCliente)
        Me.Controls.Add(Me.txtnumeroOficial)
        Me.Controls.Add(Me.txtnumeroFactura)
        Me.Controls.Add(Me.btnbuscarCliente)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Factura"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Laboratorios Médicos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbpObservaciones.ResumeLayout(False)
        CType(Me.dgbObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpExamenes.ResumeLayout(False)
        Me.tbpExamenes.PerformLayout()
        CType(Me.dgblistadoExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcodigo As Label
    Friend WithEvents btnbuscarCliente As Button
    Friend WithEvents btnnueva As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcliente As Label
    Friend WithEvents lblmedico As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblterminosPago As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblfechaVto As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblconvenio As Label
    Friend WithEvents lblpoliza As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblpagoPaciente As Label
    Friend WithEvents lblvuelto As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnumeroFactura As TextBox
    Friend WithEvents txtnumeroOficial As TextBox
    Friend WithEvents txtcodigoCliente As TextBox
    Friend WithEvents txtnombreCliente As TextBox
    Friend WithEvents txtcodigoMedico As TextBox
    Friend WithEvents txtnumeroPoliza As TextBox
    Friend WithEvents dtpfechaFactura As DateTimePicker
    Friend WithEvents dtpfechaVto As DateTimePicker
    Friend WithEvents txtcodigoConvenio As TextBox
    Friend WithEvents txtcodigoTerminal As TextBox
    Friend WithEvents cbxentregarMedico As CheckBox
    Friend WithEvents txtcodigoRecepecionista As TextBox
    Friend WithEvents txtcodigoCajero As TextBox
    Friend WithEvents txtcodigoSucursal As TextBox
    Friend WithEvents txtnombreMedico As TextBox
    Friend WithEvents txtcodigoTerminosPago As TextBox
    Friend WithEvents txtcodigoSede As TextBox
    Friend WithEvents cbxentregarPaciente As CheckBox
    Friend WithEvents cbxenviarCorreo As CheckBox
    Friend WithEvents txtvuelto As TextBox
    Friend WithEvents cbxok As CheckBox
    Friend WithEvents btnimprimirComprobante As Button
    Friend WithEvents txtnombreSede As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscarSede As Button
    Friend WithEvents btnbuscarMedico As Button
    Friend WithEvents btnbuscarTerminosPago As Button
    Friend WithEvents txtpagoPaciente As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnentregarExamen As Button
    Friend WithEvents btnbusquedaExamen As Button
    Friend WithEvents btnmuestrasPendientes As Button
    Friend WithEvents btnestadoFactura As Button
    Friend WithEvents btnbuscarSucursal As Button
    Friend WithEvents txtnombreSucursal As TextBox
    Friend WithEvents txtdescripcionTermino As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblcodeSucursal As Label
    Friend WithEvents lblcodeTerminoPago As Label
    Friend WithEvents lblcodePriceList As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents lblEfectivo As Label
    Friend WithEvents lblTarjeta As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbxAnular As CheckBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCodigoBreveMaquina As TextBox
    Friend WithEvents txtNombreRecepcionista As TextBox
    Friend WithEvents lblCheque As Label
    Friend WithEvents txtCheque As TextBox
    Friend WithEvents lblTransferencia As Label
    Friend WithEvents txtTransferencia As TextBox
    Friend WithEvents lblDeposito As Label
    Friend WithEvents txtDeposito As TextBox
    Friend WithEvents tbpObservaciones As TabPage
    Friend WithEvents dgbObservaciones As DataGridView
    Friend WithEvents tbpExamenes As TabPage
    Friend WithEvents lblPromocion As Label
    Friend WithEvents dgblistadoExamenes As DataGridView
    Friend WithEvents btnQuitarPromocion As Button
    Friend WithEvents btnPromocion As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreCajero As TextBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents subArea As DataGridViewTextBoxColumn
    Friend WithEvents codeDetFact As DataGridViewTextBoxColumn
    Friend WithEvents codeItemExam As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevaCotizacion As Button
    Friend WithEvents lblOKAY As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents lblVuelto2 As Label
    Friend WithEvents txtvuelto2 As TextBox
    Friend WithEvents lblRTN As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
