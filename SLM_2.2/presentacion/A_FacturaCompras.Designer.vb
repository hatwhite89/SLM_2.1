<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_FacturaCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_FacturaCompras))
        Me.gbxInfoFact = New System.Windows.Forms.GroupBox()
        Me.lblSaldoPend = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCodTerminoPago = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNroFactura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.btnBuscarTerminoPago = New System.Windows.Forms.Button()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.dtpTransaccion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTerminoPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodFactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.codDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbxInfoFact.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInfoFact
        '
        Me.gbxInfoFact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfoFact.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxInfoFact.Controls.Add(Me.lblSaldoPend)
        Me.gbxInfoFact.Controls.Add(Me.Label16)
        Me.gbxInfoFact.Controls.Add(Me.lblCodTerminoPago)
        Me.gbxInfoFact.Controls.Add(Me.lblEstado)
        Me.gbxInfoFact.Controls.Add(Me.Label14)
        Me.gbxInfoFact.Controls.Add(Me.txtDescripcion)
        Me.gbxInfoFact.Controls.Add(Me.Label13)
        Me.gbxInfoFact.Controls.Add(Me.txtNroFactura)
        Me.gbxInfoFact.Controls.Add(Me.Label10)
        Me.gbxInfoFact.Controls.Add(Me.lblFila)
        Me.gbxInfoFact.Controls.Add(Me.btnBuscarTerminoPago)
        Me.gbxInfoFact.Controls.Add(Me.txtMoneda)
        Me.gbxInfoFact.Controls.Add(Me.Label9)
        Me.gbxInfoFact.Controls.Add(Me.dtpVencimiento)
        Me.gbxInfoFact.Controls.Add(Me.dtpTransaccion)
        Me.gbxInfoFact.Controls.Add(Me.Label8)
        Me.gbxInfoFact.Controls.Add(Me.Label7)
        Me.gbxInfoFact.Controls.Add(Me.txtTerminoPago)
        Me.gbxInfoFact.Controls.Add(Me.Label6)
        Me.gbxInfoFact.Controls.Add(Me.dtpFechaFactura)
        Me.gbxInfoFact.Controls.Add(Me.Label5)
        Me.gbxInfoFact.Controls.Add(Me.txtNombreProveedor)
        Me.gbxInfoFact.Controls.Add(Me.Label4)
        Me.gbxInfoFact.Controls.Add(Me.txtTotal)
        Me.gbxInfoFact.Controls.Add(Me.Label3)
        Me.gbxInfoFact.Controls.Add(Me.txtCodProveedor)
        Me.gbxInfoFact.Controls.Add(Me.Label2)
        Me.gbxInfoFact.Controls.Add(Me.txtCodFactura)
        Me.gbxInfoFact.Controls.Add(Me.Label1)
        Me.gbxInfoFact.Location = New System.Drawing.Point(7, 50)
        Me.gbxInfoFact.Name = "gbxInfoFact"
        Me.gbxInfoFact.Size = New System.Drawing.Size(748, 182)
        Me.gbxInfoFact.TabIndex = 0
        Me.gbxInfoFact.TabStop = False
        Me.gbxInfoFact.Text = "Información de Factura"
        '
        'lblSaldoPend
        '
        Me.lblSaldoPend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaldoPend.AutoSize = True
        Me.lblSaldoPend.Location = New System.Drawing.Point(543, 110)
        Me.lblSaldoPend.Name = "lblSaldoPend"
        Me.lblSaldoPend.Size = New System.Drawing.Size(16, 13)
        Me.lblSaldoPend.TabIndex = 29
        Me.lblSaldoPend.Text = "---"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(469, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Saldo Pend.:"
        '
        'lblCodTerminoPago
        '
        Me.lblCodTerminoPago.AutoSize = True
        Me.lblCodTerminoPago.Location = New System.Drawing.Point(644, 107)
        Me.lblCodTerminoPago.Name = "lblCodTerminoPago"
        Me.lblCodTerminoPago.Size = New System.Drawing.Size(45, 13)
        Me.lblCodTerminoPago.TabIndex = 27
        Me.lblCodTerminoPago.Text = "Label15"
        Me.lblCodTerminoPago.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(543, 133)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(16, 13)
        Me.lblEstado.TabIndex = 26
        Me.lblEstado.Text = "---"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(494, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Estado:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(109, 155)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(634, 20)
        Me.txtDescripcion.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Descripción"
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNroFactura.Location = New System.Drawing.Point(306, 25)
        Me.txtNroFactura.MaxLength = 100
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.Size = New System.Drawing.Size(436, 20)
        Me.txtNroFactura.TabIndex = 1
        Me.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nro. Factura"
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(644, 81)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(45, 13)
        Me.lblFila.TabIndex = 20
        Me.lblFila.Text = "Label10"
        Me.lblFila.Visible = False
        '
        'btnBuscarTerminoPago
        '
        Me.btnBuscarTerminoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarTerminoPago.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarTerminoPago.BackgroundImage = CType(resources.GetObject("btnBuscarTerminoPago.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarTerminoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarTerminoPago.FlatAppearance.BorderSize = 0
        Me.btnBuscarTerminoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTerminoPago.Location = New System.Drawing.Point(432, 78)
        Me.btnBuscarTerminoPago.Name = "btnBuscarTerminoPago"
        Me.btnBuscarTerminoPago.Size = New System.Drawing.Size(21, 20)
        Me.btnBuscarTerminoPago.TabIndex = 7
        Me.btnBuscarTerminoPago.Text = "..."
        Me.btnBuscarTerminoPago.UseVisualStyleBackColor = False
        '
        'txtMoneda
        '
        Me.txtMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoneda.Location = New System.Drawing.Point(306, 130)
        Me.txtMoneda.MaxLength = 10
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(120, 20)
        Me.txtMoneda.TabIndex = 9
        Me.txtMoneda.Text = "Lps"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Moneda"
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(109, 129)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(84, 20)
        Me.dtpVencimiento.TabIndex = 5
        '
        'dtpTransaccion
        '
        Me.dtpTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransaccion.Location = New System.Drawing.Point(109, 103)
        Me.dtpTransaccion.Name = "dtpTransaccion"
        Me.dtpTransaccion.Size = New System.Drawing.Size(84, 20)
        Me.dtpTransaccion.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha Vencimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Transacción"
        '
        'txtTerminoPago
        '
        Me.txtTerminoPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTerminoPago.Enabled = False
        Me.txtTerminoPago.Location = New System.Drawing.Point(306, 78)
        Me.txtTerminoPago.MaxLength = 10
        Me.txtTerminoPago.Name = "txtTerminoPago"
        Me.txtTerminoPago.Size = New System.Drawing.Size(120, 20)
        Me.txtTerminoPago.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Términos de Pago*"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(109, 77)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaFactura.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha Factura"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.Location = New System.Drawing.Point(306, 51)
        Me.txtNombreProveedor.MaxLength = 150
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(436, 20)
        Me.txtNombreProveedor.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre Proveedor"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(306, 104)
        Me.txtTotal.MaxLength = 10
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total*"
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.Location = New System.Drawing.Point(109, 51)
        Me.txtCodProveedor.MaxLength = 5
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.Size = New System.Drawing.Size(84, 20)
        Me.txtCodProveedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Proveedor*"
        '
        'txtCodFactura
        '
        Me.txtCodFactura.Enabled = False
        Me.txtCodFactura.Location = New System.Drawing.Point(110, 25)
        Me.txtCodFactura.Name = "txtCodFactura"
        Me.txtCodFactura.Size = New System.Drawing.Size(83, 20)
        Me.txtCodFactura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Factura"
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.White
        Me.btnCrear.Enabled = False
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.Black
        Me.btnCrear.Location = New System.Drawing.Point(455, 9)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 12
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(532, 9)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(609, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dtDetalleFactura)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 328)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Factura"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(695, 303)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(25, 13)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "0.0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(515, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Total de Factura:"
        '
        'dtDetalleFactura
        '
        Me.dtDetalleFactura.AllowUserToDeleteRows = False
        Me.dtDetalleFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtDetalleFactura.BackgroundColor = System.Drawing.Color.White
        Me.dtDetalleFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.dtDetalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetalleFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codDetalle, Me.Cuenta, Me.area, Me.Sede, Me.Descripción, Me.Monto})
        Me.dtDetalleFactura.GridColor = System.Drawing.Color.White
        Me.dtDetalleFactura.Location = New System.Drawing.Point(4, 15)
        Me.dtDetalleFactura.Name = "dtDetalleFactura"
        Me.dtDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtDetalleFactura.Size = New System.Drawing.Size(739, 277)
        Me.dtDetalleFactura.TabIndex = 10
        '
        'codDetalle
        '
        Me.codDetalle.HeaderText = "codDetalle"
        Me.codDetalle.Name = "codDetalle"
        Me.codDetalle.ReadOnly = True
        Me.codDetalle.Visible = False
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.MaxInputLength = 10
        Me.Cuenta.Name = "Cuenta"
        '
        'area
        '
        Me.area.HeaderText = "Centro de Costo"
        Me.area.MaxInputLength = 10
        Me.area.Name = "area"
        '
        'Sede
        '
        Me.Sede.HeaderText = "Sucursal"
        Me.Sede.MaxInputLength = 10
        Me.Sede.Name = "Sede"
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.MaxInputLength = 200
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.MaxInputLength = 10
        Me.Monto.Name = "Monto"
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.BackColor = System.Drawing.Color.White
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Location = New System.Drawing.Point(378, 9)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 14
        Me.btnRegresar.Text = "Listado"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(13, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(213, 25)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Factura de Compra"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCrear)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Location = New System.Drawing.Point(-6, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 43)
        Me.Panel1.TabIndex = 16
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(686, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-1, 570)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 22)
        Me.Panel2.TabIndex = 17
        '
        'A_FacturaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(766, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoFact)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "A_FacturaCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura de Compra"
        Me.gbxInfoFact.ResumeLayout(False)
        Me.gbxInfoFact.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInfoFact As GroupBox
    Friend WithEvents dtpVencimiento As DateTimePicker
    Friend WithEvents dtpTransaccion As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTerminoPago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaFactura As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodProveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodFactura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMoneda As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtDetalleFactura As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnBuscarTerminoPago As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lblFila As Label
    Friend WithEvents txtNroFactura As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblCodTerminoPago As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblSaldoPend As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents codDetalle As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents Sede As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
End Class
