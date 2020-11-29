<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_TerminosPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_TerminosPago))
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtdiasNeto = New System.Windows.Forms.TextBox()
        Me.lbldiasNeto = New System.Windows.Forms.Label()
        Me.lblctaVentas = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblctaContado = New System.Windows.Forms.Label()
        Me.cbxtipoPago = New System.Windows.Forms.ComboBox()
        Me.btnctaContado = New System.Windows.Forms.Button()
        Me.txtcodigoCtaContado = New System.Windows.Forms.TextBox()
        Me.btnctaVentas = New System.Windows.Forms.Button()
        Me.txtcodigoCtaVentas = New System.Windows.Forms.TextBox()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.gbxterminosPago = New System.Windows.Forms.GroupBox()
        Me.lblcodeCtaVentas = New System.Windows.Forms.Label()
        Me.lblcodeCtaContado = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.txtnombreCtaVentas = New System.Windows.Forms.TextBox()
        Me.txtnombreCtaContado = New System.Windows.Forms.TextBox()
        Me.btntipoPago = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblform = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtdescripcionB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxterminosPago.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(304, 19)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbldescripcion.TabIndex = 87
        Me.lbldescripcion.Text = "Descripción"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(105, 16)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(135, 20)
        Me.txtcodigo.TabIndex = 86
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(59, 19)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 85
        Me.lblcodigo.Text = "Código"
        '
        'txtdiasNeto
        '
        Me.txtdiasNeto.Location = New System.Drawing.Point(105, 74)
        Me.txtdiasNeto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdiasNeto.MaxLength = 20
        Me.txtdiasNeto.Name = "txtdiasNeto"
        Me.txtdiasNeto.Size = New System.Drawing.Size(135, 20)
        Me.txtdiasNeto.TabIndex = 84
        Me.txtdiasNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldiasNeto
        '
        Me.lbldiasNeto.AutoSize = True
        Me.lbldiasNeto.Location = New System.Drawing.Point(46, 76)
        Me.lbldiasNeto.Name = "lbldiasNeto"
        Me.lbldiasNeto.Size = New System.Drawing.Size(56, 13)
        Me.lbldiasNeto.TabIndex = 83
        Me.lbldiasNeto.Text = "Días Neto"
        '
        'lblctaVentas
        '
        Me.lblctaVentas.AutoSize = True
        Me.lblctaVentas.Location = New System.Drawing.Point(33, 132)
        Me.lblctaVentas.Name = "lblctaVentas"
        Me.lblctaVentas.Size = New System.Drawing.Size(62, 13)
        Me.lblctaVentas.TabIndex = 103
        Me.lblctaVentas.Text = "Cta. Ventas"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(71, 47)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(28, 13)
        Me.lbltipo.TabIndex = 105
        Me.lbltipo.Text = "Tipo"
        '
        'lblctaContado
        '
        Me.lblctaContado.AutoSize = True
        Me.lblctaContado.Location = New System.Drawing.Point(26, 108)
        Me.lblctaContado.Name = "lblctaContado"
        Me.lblctaContado.Size = New System.Drawing.Size(69, 13)
        Me.lblctaContado.TabIndex = 109
        Me.lblctaContado.Text = "Cta. Contado"
        '
        'cbxtipoPago
        '
        Me.cbxtipoPago.DropDownWidth = 170
        Me.cbxtipoPago.FormattingEnabled = True
        Me.cbxtipoPago.Location = New System.Drawing.Point(105, 45)
        Me.cbxtipoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxtipoPago.Name = "cbxtipoPago"
        Me.cbxtipoPago.Size = New System.Drawing.Size(100, 21)
        Me.cbxtipoPago.TabIndex = 113
        '
        'btnctaContado
        '
        Me.btnctaContado.BackColor = System.Drawing.Color.White
        Me.btnctaContado.BackgroundImage = CType(resources.GetObject("btnctaContado.BackgroundImage"), System.Drawing.Image)
        Me.btnctaContado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnctaContado.FlatAppearance.BorderSize = 0
        Me.btnctaContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnctaContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnctaContado.Location = New System.Drawing.Point(103, 107)
        Me.btnctaContado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnctaContado.Name = "btnctaContado"
        Me.btnctaContado.Size = New System.Drawing.Size(37, 18)
        Me.btnctaContado.TabIndex = 117
        Me.btnctaContado.Text = "..."
        Me.btnctaContado.UseVisualStyleBackColor = False
        '
        'txtcodigoCtaContado
        '
        Me.txtcodigoCtaContado.Location = New System.Drawing.Point(146, 107)
        Me.txtcodigoCtaContado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCtaContado.MaxLength = 20
        Me.txtcodigoCtaContado.Name = "txtcodigoCtaContado"
        Me.txtcodigoCtaContado.Size = New System.Drawing.Size(89, 20)
        Me.txtcodigoCtaContado.TabIndex = 116
        Me.txtcodigoCtaContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnctaVentas
        '
        Me.btnctaVentas.BackColor = System.Drawing.Color.White
        Me.btnctaVentas.BackgroundImage = CType(resources.GetObject("btnctaVentas.BackgroundImage"), System.Drawing.Image)
        Me.btnctaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnctaVentas.FlatAppearance.BorderSize = 0
        Me.btnctaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnctaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnctaVentas.Location = New System.Drawing.Point(103, 129)
        Me.btnctaVentas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnctaVentas.Name = "btnctaVentas"
        Me.btnctaVentas.Size = New System.Drawing.Size(37, 18)
        Me.btnctaVentas.TabIndex = 121
        Me.btnctaVentas.Text = "..."
        Me.btnctaVentas.UseVisualStyleBackColor = False
        '
        'txtcodigoCtaVentas
        '
        Me.txtcodigoCtaVentas.Location = New System.Drawing.Point(146, 129)
        Me.txtcodigoCtaVentas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoCtaVentas.MaxLength = 20
        Me.txtcodigoCtaVentas.Name = "txtcodigoCtaVentas"
        Me.txtcodigoCtaVentas.Size = New System.Drawing.Size(89, 20)
        Me.txtcodigoCtaVentas.TabIndex = 120
        Me.txtcodigoCtaVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(374, 17)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtdescripcion.MaxLength = 80
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(318, 77)
        Me.rtxtdescripcion.TabIndex = 125
        Me.rtxtdescripcion.Text = ""
        '
        'gbxterminosPago
        '
        Me.gbxterminosPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxterminosPago.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxterminosPago.Controls.Add(Me.lblcodeCtaVentas)
        Me.gbxterminosPago.Controls.Add(Me.lblcodeCtaContado)
        Me.gbxterminosPago.Controls.Add(Me.lblcode)
        Me.gbxterminosPago.Controls.Add(Me.txtnombreCtaVentas)
        Me.gbxterminosPago.Controls.Add(Me.txtnombreCtaContado)
        Me.gbxterminosPago.Controls.Add(Me.btntipoPago)
        Me.gbxterminosPago.Controls.Add(Me.lblcodigo)
        Me.gbxterminosPago.Controls.Add(Me.rtxtdescripcion)
        Me.gbxterminosPago.Controls.Add(Me.lbldiasNeto)
        Me.gbxterminosPago.Controls.Add(Me.btnctaVentas)
        Me.gbxterminosPago.Controls.Add(Me.txtdiasNeto)
        Me.gbxterminosPago.Controls.Add(Me.txtcodigoCtaVentas)
        Me.gbxterminosPago.Controls.Add(Me.lbldescripcion)
        Me.gbxterminosPago.Controls.Add(Me.btnctaContado)
        Me.gbxterminosPago.Controls.Add(Me.txtcodigo)
        Me.gbxterminosPago.Controls.Add(Me.txtcodigoCtaContado)
        Me.gbxterminosPago.Controls.Add(Me.lblctaContado)
        Me.gbxterminosPago.Controls.Add(Me.cbxtipoPago)
        Me.gbxterminosPago.Controls.Add(Me.lbltipo)
        Me.gbxterminosPago.Controls.Add(Me.lblctaVentas)
        Me.gbxterminosPago.Location = New System.Drawing.Point(11, 46)
        Me.gbxterminosPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxterminosPago.Name = "gbxterminosPago"
        Me.gbxterminosPago.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxterminosPago.Size = New System.Drawing.Size(696, 154)
        Me.gbxterminosPago.TabIndex = 126
        Me.gbxterminosPago.TabStop = False
        Me.gbxterminosPago.Text = "REGISTRAR TÉRMINO DE PAGO"
        '
        'lblcodeCtaVentas
        '
        Me.lblcodeCtaVentas.AutoSize = True
        Me.lblcodeCtaVentas.Location = New System.Drawing.Point(14, 124)
        Me.lblcodeCtaVentas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeCtaVentas.Name = "lblcodeCtaVentas"
        Me.lblcodeCtaVentas.Size = New System.Drawing.Size(0, 13)
        Me.lblcodeCtaVentas.TabIndex = 135
        Me.lblcodeCtaVentas.Visible = False
        '
        'lblcodeCtaContado
        '
        Me.lblcodeCtaContado.AutoSize = True
        Me.lblcodeCtaContado.Location = New System.Drawing.Point(5, 97)
        Me.lblcodeCtaContado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeCtaContado.Name = "lblcodeCtaContado"
        Me.lblcodeCtaContado.Size = New System.Drawing.Size(0, 13)
        Me.lblcodeCtaContado.TabIndex = 134
        Me.lblcodeCtaContado.Visible = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(304, 19)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 128
        Me.lblcode.Visible = False
        '
        'txtnombreCtaVentas
        '
        Me.txtnombreCtaVentas.Location = New System.Drawing.Point(245, 129)
        Me.txtnombreCtaVentas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreCtaVentas.Name = "txtnombreCtaVentas"
        Me.txtnombreCtaVentas.ReadOnly = True
        Me.txtnombreCtaVentas.Size = New System.Drawing.Size(172, 20)
        Me.txtnombreCtaVentas.TabIndex = 133
        '
        'txtnombreCtaContado
        '
        Me.txtnombreCtaContado.Location = New System.Drawing.Point(245, 108)
        Me.txtnombreCtaContado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreCtaContado.Name = "txtnombreCtaContado"
        Me.txtnombreCtaContado.ReadOnly = True
        Me.txtnombreCtaContado.Size = New System.Drawing.Size(172, 20)
        Me.txtnombreCtaContado.TabIndex = 132
        '
        'btntipoPago
        '
        Me.btntipoPago.BackColor = System.Drawing.Color.White
        Me.btntipoPago.BackgroundImage = CType(resources.GetObject("btntipoPago.BackgroundImage"), System.Drawing.Image)
        Me.btntipoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntipoPago.FlatAppearance.BorderSize = 0
        Me.btntipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipoPago.Location = New System.Drawing.Point(207, 45)
        Me.btntipoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btntipoPago.Name = "btntipoPago"
        Me.btntipoPago.Size = New System.Drawing.Size(37, 18)
        Me.btntipoPago.TabIndex = 131
        Me.btntipoPago.Text = "..."
        Me.btntipoPago.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(560, 8)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 130
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(636, 8)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 127
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(401, 8)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 129
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(484, 8)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 128
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.lblform)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtdescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 204)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 277)
        Me.gbxbusqueda.TabIndex = 127
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR TÉRMINO DE PAGO"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(385, 18)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(0, 13)
        Me.lblform.TabIndex = 116
        Me.lblform.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(231, 257)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(8, 42)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(684, 213)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(14, 257)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(171, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE TÉRMINOS DE PAGO"
        '
        'txtdescripcionB
        '
        Me.txtdescripcionB.Location = New System.Drawing.Point(74, 18)
        Me.txtdescripcionB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionB.MaxLength = 80
        Me.txtdescripcionB.Name = "txtdescripcionB"
        Me.txtdescripcionB.Size = New System.Drawing.Size(618, 20)
        Me.txtdescripcionB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(6, 21)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(63, 13)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Descripción"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 128
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 42)
        Me.Panel1.TabIndex = 129
        '
        'M_TerminosPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxterminosPago)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_TerminosPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Términos de Pago"
        Me.gbxterminosPago.ResumeLayout(False)
        Me.gbxterminosPago.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtdiasNeto As TextBox
    Friend WithEvents lbldiasNeto As Label
    Friend WithEvents lblctaVentas As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblctaContado As Label
    Friend WithEvents cbxtipoPago As ComboBox
    Friend WithEvents btnctaContado As Button
    Friend WithEvents txtcodigoCtaContado As TextBox
    Friend WithEvents btnctaVentas As Button
    Friend WithEvents txtcodigoCtaVentas As TextBox
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents gbxterminosPago As GroupBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btntipoPago As Button
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtdescripcionB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents txtnombreCtaVentas As TextBox
    Friend WithEvents txtnombreCtaContado As TextBox
    Friend WithEvents lblform As Label
    Friend WithEvents lblcode As Label
    Friend WithEvents lblcodeCtaVentas As Label
    Friend WithEvents lblcodeCtaContado As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
End Class
