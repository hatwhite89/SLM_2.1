<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Factura
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
        Me.gbxlistadoExamenes = New System.Windows.Forms.GroupBox()
        Me.dgblistadoExamenes = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtnombreSede = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbuscarSede = New System.Windows.Forms.Button()
        Me.btnbuscarMedico = New System.Windows.Forms.Button()
        Me.btnterminosPago = New System.Windows.Forms.Button()
        Me.txtpagoPaciente = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnentregarExamen = New System.Windows.Forms.Button()
        Me.btnbusquedaExamen = New System.Windows.Forms.Button()
        Me.btnmuestrasPendientes = New System.Windows.Forms.Button()
        Me.btnestadoFactura = New System.Windows.Forms.Button()
        Me.btnaplicarDescuento = New System.Windows.Forms.Button()
        Me.btntarjeta = New System.Windows.Forms.Button()
        Me.btncontado = New System.Windows.Forms.Button()
        Me.btnbuscarSucursal = New System.Windows.Forms.Button()
        Me.txtnombreSucursal = New System.Windows.Forms.TextBox()
        Me.txtdescripcionTermino = New System.Windows.Forms.TextBox()
        Me.gbxlistadoExamenes.SuspendLayout()
        CType(Me.dgblistadoExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(54, 72)
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
        Me.btnbuscarCliente.Location = New System.Drawing.Point(95, 91)
        Me.btnbuscarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarCliente.Name = "btnbuscarCliente"
        Me.btnbuscarCliente.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarCliente.TabIndex = 14
        Me.btnbuscarCliente.UseVisualStyleBackColor = False
        '
        'btnnueva
        '
        Me.btnnueva.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnueva.Location = New System.Drawing.Point(635, 33)
        Me.btnnueva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(62, 28)
        Me.btnnueva.TabIndex = 15
        Me.btnnueva.Text = "Nueva"
        Me.btnnueva.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsalir.Location = New System.Drawing.Point(710, 33)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(67, 28)
        Me.btnsalir.TabIndex = 17
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(788, 33)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(60, 28)
        Me.btnguardar.TabIndex = 18
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 71)
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
        Me.Label3.Location = New System.Drawing.Point(559, 70)
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
        Me.lblcliente.Location = New System.Drawing.Point(42, 95)
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
        Me.lblmedico.Location = New System.Drawing.Point(40, 118)
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
        Me.Label6.Location = New System.Drawing.Point(560, 96)
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
        Me.Label7.Location = New System.Drawing.Point(596, 118)
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
        Me.lblterminosPago.Location = New System.Drawing.Point(19, 141)
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
        Me.Label9.Location = New System.Drawing.Point(340, 165)
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
        Me.lblfechaVto.Location = New System.Drawing.Point(23, 165)
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
        Me.Label11.Location = New System.Drawing.Point(323, 189)
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
        Me.lblconvenio.Location = New System.Drawing.Point(30, 186)
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
        Me.lblpoliza.Location = New System.Drawing.Point(22, 209)
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
        Me.Label16.Location = New System.Drawing.Point(325, 209)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Terminal"
        '
        'gbxlistadoExamenes
        '
        Me.gbxlistadoExamenes.Controls.Add(Me.dgblistadoExamenes)
        Me.gbxlistadoExamenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxlistadoExamenes.Location = New System.Drawing.Point(21, 231)
        Me.gbxlistadoExamenes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxlistadoExamenes.Name = "gbxlistadoExamenes"
        Me.gbxlistadoExamenes.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxlistadoExamenes.Size = New System.Drawing.Size(828, 167)
        Me.gbxlistadoExamenes.TabIndex = 34
        Me.gbxlistadoExamenes.TabStop = False
        Me.gbxlistadoExamenes.Text = "Listado Exámenes"
        '
        'dgblistadoExamenes
        '
        Me.dgblistadoExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgblistadoExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Cantidad, Me.Precio, Me.Descripcion, Me.FechaEntrega, Me.Descuento, Me.Subtotal})
        Me.dgblistadoExamenes.Location = New System.Drawing.Point(16, 26)
        Me.dgblistadoExamenes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgblistadoExamenes.Name = "dgblistadoExamenes"
        Me.dgblistadoExamenes.RowHeadersWidth = 51
        Me.dgblistadoExamenes.RowTemplate.Height = 24
        Me.dgblistadoExamenes.Size = New System.Drawing.Size(796, 122)
        Me.dgblistadoExamenes.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 120
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 100
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 220
        '
        'FechaEntrega
        '
        Me.FechaEntrega.HeaderText = "Fecha Entrega"
        Me.FechaEntrega.MinimumWidth = 6
        Me.FechaEntrega.Name = "FechaEntrega"
        Me.FechaEntrega.ReadOnly = True
        Me.FechaEntrega.Width = 90
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.MinimumWidth = 6
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.Width = 80
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 118
        '
        'lblpagoPaciente
        '
        Me.lblpagoPaciente.AutoSize = True
        Me.lblpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagoPaciente.Location = New System.Drawing.Point(238, 409)
        Me.lblpagoPaciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpagoPaciente.Name = "lblpagoPaciente"
        Me.lblpagoPaciente.Size = New System.Drawing.Size(119, 13)
        Me.lblpagoPaciente.TabIndex = 36
        Me.lblpagoPaciente.Text = "A Pagar por el Paciente"
        '
        'lblvuelto
        '
        Me.lblvuelto.AutoSize = True
        Me.lblvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvuelto.Location = New System.Drawing.Point(496, 409)
        Me.lblvuelto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvuelto.Name = "lblvuelto"
        Me.lblvuelto.Size = New System.Drawing.Size(37, 13)
        Me.lblvuelto.TabIndex = 37
        Me.lblvuelto.Text = "Vuelto"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(664, 409)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.lbltotal.TabIndex = 38
        Me.lbltotal.Text = "Total"
        '
        'txtnumeroFactura
        '
        Me.txtnumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroFactura.Location = New System.Drawing.Point(85, 70)
        Me.txtnumeroFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroFactura.Name = "txtnumeroFactura"
        Me.txtnumeroFactura.Size = New System.Drawing.Size(208, 19)
        Me.txtnumeroFactura.TabIndex = 39
        Me.txtnumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroOficial
        '
        Me.txtnumeroOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroOficial.Location = New System.Drawing.Point(375, 70)
        Me.txtnumeroOficial.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroOficial.Name = "txtnumeroOficial"
        Me.txtnumeroOficial.Size = New System.Drawing.Size(173, 19)
        Me.txtnumeroOficial.TabIndex = 40
        Me.txtnumeroOficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCliente
        '
        Me.txtcodigoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCliente.Location = New System.Drawing.Point(153, 93)
        Me.txtcodigoCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCliente.Name = "txtcodigoCliente"
        Me.txtcodigoCliente.Size = New System.Drawing.Size(140, 19)
        Me.txtcodigoCliente.TabIndex = 41
        Me.txtcodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreCliente
        '
        Me.txtnombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreCliente.Location = New System.Drawing.Point(313, 93)
        Me.txtnombreCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreCliente.Name = "txtnombreCliente"
        Me.txtnombreCliente.ReadOnly = True
        Me.txtnombreCliente.Size = New System.Drawing.Size(236, 19)
        Me.txtnombreCliente.TabIndex = 42
        '
        'txtcodigoMedico
        '
        Me.txtcodigoMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoMedico.Location = New System.Drawing.Point(153, 115)
        Me.txtcodigoMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoMedico.Name = "txtcodigoMedico"
        Me.txtcodigoMedico.Size = New System.Drawing.Size(140, 19)
        Me.txtcodigoMedico.TabIndex = 43
        Me.txtcodigoMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnumeroPoliza
        '
        Me.txtnumeroPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroPoliza.Location = New System.Drawing.Point(85, 206)
        Me.txtnumeroPoliza.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroPoliza.Name = "txtnumeroPoliza"
        Me.txtnumeroPoliza.Size = New System.Drawing.Size(208, 19)
        Me.txtnumeroPoliza.TabIndex = 45
        Me.txtnumeroPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpfechaFactura
        '
        Me.dtpfechaFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaFactura.Location = New System.Drawing.Point(638, 71)
        Me.dtpfechaFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpfechaFactura.Name = "dtpfechaFactura"
        Me.dtpfechaFactura.Size = New System.Drawing.Size(212, 19)
        Me.dtpfechaFactura.TabIndex = 46
        '
        'dtpfechaVto
        '
        Me.dtpfechaVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaVto.Location = New System.Drawing.Point(85, 161)
        Me.dtpfechaVto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpfechaVto.Name = "dtpfechaVto"
        Me.dtpfechaVto.Size = New System.Drawing.Size(208, 19)
        Me.dtpfechaVto.TabIndex = 47
        '
        'txtcodigoConvenio
        '
        Me.txtcodigoConvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoConvenio.Location = New System.Drawing.Point(85, 184)
        Me.txtcodigoConvenio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoConvenio.Name = "txtcodigoConvenio"
        Me.txtcodigoConvenio.Size = New System.Drawing.Size(208, 19)
        Me.txtcodigoConvenio.TabIndex = 48
        Me.txtcodigoConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTerminal
        '
        Me.txtcodigoTerminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoTerminal.Location = New System.Drawing.Point(380, 208)
        Me.txtcodigoTerminal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTerminal.Name = "txtcodigoTerminal"
        Me.txtcodigoTerminal.Size = New System.Drawing.Size(169, 19)
        Me.txtcodigoTerminal.TabIndex = 49
        Me.txtcodigoTerminal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtcodigoRecepecionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoRecepecionista.Location = New System.Drawing.Point(638, 93)
        Me.txtcodigoRecepecionista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoRecepecionista.Name = "txtcodigoRecepecionista"
        Me.txtcodigoRecepecionista.Size = New System.Drawing.Size(212, 19)
        Me.txtcodigoRecepecionista.TabIndex = 51
        Me.txtcodigoRecepecionista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoCajero
        '
        Me.txtcodigoCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoCajero.Location = New System.Drawing.Point(638, 116)
        Me.txtcodigoCajero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCajero.Name = "txtcodigoCajero"
        Me.txtcodigoCajero.Size = New System.Drawing.Size(212, 19)
        Me.txtcodigoCajero.TabIndex = 52
        Me.txtcodigoCajero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSucursal
        '
        Me.txtcodigoSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoSucursal.Location = New System.Drawing.Point(448, 185)
        Me.txtcodigoSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoSucursal.Name = "txtcodigoSucursal"
        Me.txtcodigoSucursal.Size = New System.Drawing.Size(101, 19)
        Me.txtcodigoSucursal.TabIndex = 53
        Me.txtcodigoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreMedico
        '
        Me.txtnombreMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreMedico.Location = New System.Drawing.Point(313, 115)
        Me.txtnombreMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreMedico.Name = "txtnombreMedico"
        Me.txtnombreMedico.ReadOnly = True
        Me.txtnombreMedico.Size = New System.Drawing.Size(235, 19)
        Me.txtnombreMedico.TabIndex = 54
        '
        'txtcodigoTerminosPago
        '
        Me.txtcodigoTerminosPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoTerminosPago.Location = New System.Drawing.Point(153, 138)
        Me.txtcodigoTerminosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTerminosPago.Name = "txtcodigoTerminosPago"
        Me.txtcodigoTerminosPago.Size = New System.Drawing.Size(140, 19)
        Me.txtcodigoTerminosPago.TabIndex = 58
        Me.txtcodigoTerminosPago.Text = "CO"
        Me.txtcodigoTerminosPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoSede
        '
        Me.txtcodigoSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoSede.Location = New System.Drawing.Point(448, 162)
        Me.txtcodigoSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.txtvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvuelto.Location = New System.Drawing.Point(536, 406)
        Me.txtvuelto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtvuelto.Name = "txtvuelto"
        Me.txtvuelto.Size = New System.Drawing.Size(108, 19)
        Me.txtvuelto.TabIndex = 65
        Me.txtvuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxok
        '
        Me.cbxok.AutoSize = True
        Me.cbxok.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxok.Location = New System.Drawing.Point(77, 409)
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
        Me.btnimprimirComprobante.Location = New System.Drawing.Point(634, 441)
        Me.btnimprimirComprobante.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnimprimirComprobante.Name = "btnimprimirComprobante"
        Me.btnimprimirComprobante.Size = New System.Drawing.Size(94, 76)
        Me.btnimprimirComprobante.TabIndex = 70
        Me.btnimprimirComprobante.Text = "Imprimir Comprobante Examen"
        Me.btnimprimirComprobante.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.RegistroToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(873, 24)
        Me.MenuStrip1.TabIndex = 76
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanaToolStripMenuItem.Text = "Ventana"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'txtnombreSede
        '
        Me.txtnombreSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreSede.Location = New System.Drawing.Point(556, 163)
        Me.txtnombreSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreSede.Name = "txtnombreSede"
        Me.txtnombreSede.ReadOnly = True
        Me.txtnombreSede.Size = New System.Drawing.Size(138, 19)
        Me.txtnombreSede.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxentregarMedico)
        Me.GroupBox1.Controls.Add(Me.cbxentregarPaciente)
        Me.GroupBox1.Controls.Add(Me.cbxenviarCorreo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(702, 138)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(147, 98)
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
        Me.btnbuscarSede.Location = New System.Drawing.Point(390, 162)
        Me.btnbuscarSede.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarSede.Name = "btnbuscarSede"
        Me.btnbuscarSede.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarSede.TabIndex = 80
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
        Me.btnbuscarMedico.Location = New System.Drawing.Point(95, 115)
        Me.btnbuscarMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarMedico.Name = "btnbuscarMedico"
        Me.btnbuscarMedico.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarMedico.TabIndex = 81
        Me.btnbuscarMedico.UseVisualStyleBackColor = False
        '
        'btnterminosPago
        '
        Me.btnterminosPago.BackColor = System.Drawing.Color.White
        Me.btnterminosPago.BackgroundImage = CType(resources.GetObject("btnterminosPago.BackgroundImage"), System.Drawing.Image)
        Me.btnterminosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnterminosPago.FlatAppearance.BorderSize = 0
        Me.btnterminosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnterminosPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnterminosPago.Location = New System.Drawing.Point(95, 138)
        Me.btnterminosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnterminosPago.Name = "btnterminosPago"
        Me.btnterminosPago.Size = New System.Drawing.Size(37, 18)
        Me.btnterminosPago.TabIndex = 82
        Me.btnterminosPago.UseVisualStyleBackColor = False
        '
        'txtpagoPaciente
        '
        Me.txtpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagoPaciente.Location = New System.Drawing.Point(362, 406)
        Me.txtpagoPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtpagoPaciente.Name = "txtpagoPaciente"
        Me.txtpagoPaciente.Size = New System.Drawing.Size(108, 19)
        Me.txtpagoPaciente.TabIndex = 83
        Me.txtpagoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(698, 406)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(108, 19)
        Me.txttotal.TabIndex = 84
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnentregarExamen
        '
        Me.btnentregarExamen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentregarExamen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnentregarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentregarExamen.Location = New System.Drawing.Point(732, 441)
        Me.btnentregarExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnentregarExamen.Name = "btnentregarExamen"
        Me.btnentregarExamen.Size = New System.Drawing.Size(94, 76)
        Me.btnentregarExamen.TabIndex = 85
        Me.btnentregarExamen.Text = "Entregar Examen"
        Me.btnentregarExamen.UseVisualStyleBackColor = False
        '
        'btnbusquedaExamen
        '
        Me.btnbusquedaExamen.BackColor = System.Drawing.Color.Yellow
        Me.btnbusquedaExamen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbusquedaExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusquedaExamen.Location = New System.Drawing.Point(536, 441)
        Me.btnbusquedaExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbusquedaExamen.Name = "btnbusquedaExamen"
        Me.btnbusquedaExamen.Size = New System.Drawing.Size(94, 76)
        Me.btnbusquedaExamen.TabIndex = 86
        Me.btnbusquedaExamen.Text = "Búsqueda de Examen"
        Me.btnbusquedaExamen.UseVisualStyleBackColor = False
        '
        'btnmuestrasPendientes
        '
        Me.btnmuestrasPendientes.BackColor = System.Drawing.Color.Yellow
        Me.btnmuestrasPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmuestrasPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmuestrasPendientes.Location = New System.Drawing.Point(437, 441)
        Me.btnmuestrasPendientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmuestrasPendientes.Name = "btnmuestrasPendientes"
        Me.btnmuestrasPendientes.Size = New System.Drawing.Size(94, 76)
        Me.btnmuestrasPendientes.TabIndex = 87
        Me.btnmuestrasPendientes.Text = "Muestras Pendientes"
        Me.btnmuestrasPendientes.UseVisualStyleBackColor = False
        '
        'btnestadoFactura
        '
        Me.btnestadoFactura.BackColor = System.Drawing.Color.Yellow
        Me.btnestadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnestadoFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnestadoFactura.Location = New System.Drawing.Point(339, 441)
        Me.btnestadoFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnestadoFactura.Name = "btnestadoFactura"
        Me.btnestadoFactura.Size = New System.Drawing.Size(94, 76)
        Me.btnestadoFactura.TabIndex = 88
        Me.btnestadoFactura.Text = "Estado Factura"
        Me.btnestadoFactura.UseVisualStyleBackColor = False
        '
        'btnaplicarDescuento
        '
        Me.btnaplicarDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaplicarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaplicarDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaplicarDescuento.Location = New System.Drawing.Point(241, 441)
        Me.btnaplicarDescuento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnaplicarDescuento.Name = "btnaplicarDescuento"
        Me.btnaplicarDescuento.Size = New System.Drawing.Size(94, 76)
        Me.btnaplicarDescuento.TabIndex = 89
        Me.btnaplicarDescuento.Text = "Aplicar Descuento"
        Me.btnaplicarDescuento.UseVisualStyleBackColor = False
        '
        'btntarjeta
        '
        Me.btntarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btntarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btntarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntarjeta.Location = New System.Drawing.Point(142, 441)
        Me.btntarjeta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btntarjeta.Name = "btntarjeta"
        Me.btntarjeta.Size = New System.Drawing.Size(94, 76)
        Me.btntarjeta.TabIndex = 90
        Me.btntarjeta.Text = "Tarjeta"
        Me.btntarjeta.UseVisualStyleBackColor = False
        '
        'btncontado
        '
        Me.btncontado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncontado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncontado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontado.Location = New System.Drawing.Point(44, 441)
        Me.btncontado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncontado.Name = "btncontado"
        Me.btncontado.Size = New System.Drawing.Size(94, 76)
        Me.btncontado.TabIndex = 91
        Me.btncontado.Text = "Contado"
        Me.btncontado.UseVisualStyleBackColor = False
        '
        'btnbuscarSucursal
        '
        Me.btnbuscarSucursal.BackColor = System.Drawing.Color.White
        Me.btnbuscarSucursal.BackgroundImage = CType(resources.GetObject("btnbuscarSucursal.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarSucursal.FlatAppearance.BorderSize = 0
        Me.btnbuscarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarSucursal.Location = New System.Drawing.Point(391, 185)
        Me.btnbuscarSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarSucursal.Name = "btnbuscarSucursal"
        Me.btnbuscarSucursal.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarSucursal.TabIndex = 92
        Me.btnbuscarSucursal.UseVisualStyleBackColor = False
        '
        'txtnombreSucursal
        '
        Me.txtnombreSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreSucursal.Location = New System.Drawing.Point(556, 187)
        Me.txtnombreSucursal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreSucursal.Name = "txtnombreSucursal"
        Me.txtnombreSucursal.ReadOnly = True
        Me.txtnombreSucursal.Size = New System.Drawing.Size(138, 19)
        Me.txtnombreSucursal.TabIndex = 94
        '
        'txtdescripcionTermino
        '
        Me.txtdescripcionTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcionTermino.Location = New System.Drawing.Point(313, 138)
        Me.txtdescripcionTermino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionTermino.Name = "txtdescripcionTermino"
        Me.txtdescripcionTermino.ReadOnly = True
        Me.txtdescripcionTermino.Size = New System.Drawing.Size(235, 19)
        Me.txtdescripcionTermino.TabIndex = 95
        '
        'M_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 543)
        Me.Controls.Add(Me.txtdescripcionTermino)
        Me.Controls.Add(Me.txtnombreSucursal)
        Me.Controls.Add(Me.btnbuscarSucursal)
        Me.Controls.Add(Me.btncontado)
        Me.Controls.Add(Me.btntarjeta)
        Me.Controls.Add(Me.btnaplicarDescuento)
        Me.Controls.Add(Me.btnestadoFactura)
        Me.Controls.Add(Me.btnmuestrasPendientes)
        Me.Controls.Add(Me.btnbusquedaExamen)
        Me.Controls.Add(Me.btnentregarExamen)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtpagoPaciente)
        Me.Controls.Add(Me.btnterminosPago)
        Me.Controls.Add(Me.btnbuscarMedico)
        Me.Controls.Add(Me.btnbuscarSede)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnombreSede)
        Me.Controls.Add(Me.btnimprimirComprobante)
        Me.Controls.Add(Me.cbxok)
        Me.Controls.Add(Me.txtvuelto)
        Me.Controls.Add(Me.txtcodigoSede)
        Me.Controls.Add(Me.txtcodigoTerminosPago)
        Me.Controls.Add(Me.txtnombreMedico)
        Me.Controls.Add(Me.txtcodigoSucursal)
        Me.Controls.Add(Me.txtcodigoCajero)
        Me.Controls.Add(Me.txtcodigoRecepecionista)
        Me.Controls.Add(Me.txtcodigoTerminal)
        Me.Controls.Add(Me.txtcodigoConvenio)
        Me.Controls.Add(Me.dtpfechaVto)
        Me.Controls.Add(Me.dtpfechaFactura)
        Me.Controls.Add(Me.txtnumeroPoliza)
        Me.Controls.Add(Me.txtcodigoMedico)
        Me.Controls.Add(Me.txtnombreCliente)
        Me.Controls.Add(Me.txtcodigoCliente)
        Me.Controls.Add(Me.txtnumeroOficial)
        Me.Controls.Add(Me.txtnumeroFactura)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblvuelto)
        Me.Controls.Add(Me.lblpagoPaciente)
        Me.Controls.Add(Me.gbxlistadoExamenes)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblpoliza)
        Me.Controls.Add(Me.lblconvenio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblfechaVto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblterminosPago)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblmedico)
        Me.Controls.Add(Me.lblcliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnueva)
        Me.Controls.Add(Me.btnbuscarCliente)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura Laboratorios Médicos"
        Me.gbxlistadoExamenes.ResumeLayout(False)
        CType(Me.dgblistadoExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents gbxlistadoExamenes As GroupBox
    Friend WithEvents dgblistadoExamenes As DataGridView
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtnombreSede As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscarSede As Button
    Friend WithEvents btnbuscarMedico As Button
    Friend WithEvents btnterminosPago As Button
    Friend WithEvents txtpagoPaciente As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnentregarExamen As Button
    Friend WithEvents btnbusquedaExamen As Button
    Friend WithEvents btnmuestrasPendientes As Button
    Friend WithEvents btnestadoFactura As Button
    Friend WithEvents btnaplicarDescuento As Button
    Friend WithEvents btntarjeta As Button
    Friend WithEvents btncontado As Button
    Friend WithEvents btnbuscarSucursal As Button
    Friend WithEvents txtnombreSucursal As TextBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents txtdescripcionTermino As TextBox
End Class
