<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_ClienteVentana
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_ClienteVentana))
        Me.txtnombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombreTerminos = New System.Windows.Forms.TextBox()
        Me.lblterminosPago = New System.Windows.Forms.Label()
        Me.txtnombreCategoria = New System.Windows.Forms.TextBox()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.txtnombreConvenio = New System.Windows.Forms.TextBox()
        Me.lblconvenio = New System.Windows.Forms.Label()
        Me.txttelefonoCasa = New System.Windows.Forms.TextBox()
        Me.lblaseguradora = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtpagoPaciente = New System.Windows.Forms.TextBox()
        Me.txtvuelto = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblvuelto = New System.Windows.Forms.Label()
        Me.lblpagoPaciente = New System.Windows.Forms.Label()
        Me.dgvtabla = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbxImagenes = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txttelefonoTrabajo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcorreo1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombreCompleto
        '
        Me.txtnombreCompleto.Location = New System.Drawing.Point(116, 15)
        Me.txtnombreCompleto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreCompleto.Name = "txtnombreCompleto"
        Me.txtnombreCompleto.ReadOnly = True
        Me.txtnombreCompleto.Size = New System.Drawing.Size(594, 20)
        Me.txtnombreCompleto.TabIndex = 64
        Me.txtnombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(20, 18)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(91, 13)
        Me.lblnombre.TabIndex = 63
        Me.lblnombre.Text = "Nombre Completo"
        '
        'txtnombreTerminos
        '
        Me.txtnombreTerminos.Location = New System.Drawing.Point(116, 64)
        Me.txtnombreTerminos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreTerminos.Name = "txtnombreTerminos"
        Me.txtnombreTerminos.ReadOnly = True
        Me.txtnombreTerminos.Size = New System.Drawing.Size(204, 20)
        Me.txtnombreTerminos.TabIndex = 115
        Me.txtnombreTerminos.Text = "Contado"
        Me.txtnombreTerminos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblterminosPago
        '
        Me.lblterminosPago.AutoSize = True
        Me.lblterminosPago.Location = New System.Drawing.Point(20, 67)
        Me.lblterminosPago.Name = "lblterminosPago"
        Me.lblterminosPago.Size = New System.Drawing.Size(93, 13)
        Me.lblterminosPago.TabIndex = 112
        Me.lblterminosPago.Text = "Términos de Pago"
        '
        'txtnombreCategoria
        '
        Me.txtnombreCategoria.Location = New System.Drawing.Point(116, 40)
        Me.txtnombreCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreCategoria.Name = "txtnombreCategoria"
        Me.txtnombreCategoria.ReadOnly = True
        Me.txtnombreCategoria.Size = New System.Drawing.Size(204, 20)
        Me.txtnombreCategoria.TabIndex = 119
        Me.txtnombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Location = New System.Drawing.Point(20, 43)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(54, 13)
        Me.lblcategoria.TabIndex = 116
        Me.lblcategoria.Text = "Categoría"
        '
        'txtnombreConvenio
        '
        Me.txtnombreConvenio.Location = New System.Drawing.Point(116, 89)
        Me.txtnombreConvenio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreConvenio.Name = "txtnombreConvenio"
        Me.txtnombreConvenio.ReadOnly = True
        Me.txtnombreConvenio.Size = New System.Drawing.Size(204, 20)
        Me.txtnombreConvenio.TabIndex = 123
        Me.txtnombreConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblconvenio
        '
        Me.lblconvenio.AutoSize = True
        Me.lblconvenio.Location = New System.Drawing.Point(21, 91)
        Me.lblconvenio.Name = "lblconvenio"
        Me.lblconvenio.Size = New System.Drawing.Size(52, 13)
        Me.lblconvenio.TabIndex = 120
        Me.lblconvenio.Text = "Convenio"
        '
        'txttelefonoCasa
        '
        Me.txttelefonoCasa.Location = New System.Drawing.Point(507, 64)
        Me.txttelefonoCasa.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelefonoCasa.Name = "txttelefonoCasa"
        Me.txttelefonoCasa.ReadOnly = True
        Me.txttelefonoCasa.Size = New System.Drawing.Size(203, 20)
        Me.txttelefonoCasa.TabIndex = 127
        Me.txttelefonoCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblaseguradora
        '
        Me.lblaseguradora.AutoSize = True
        Me.lblaseguradora.Location = New System.Drawing.Point(398, 67)
        Me.lblaseguradora.Name = "lblaseguradora"
        Me.lblaseguradora.Size = New System.Drawing.Size(76, 13)
        Me.lblaseguradora.TabIndex = 124
        Me.lblaseguradora.Text = "Teléfono Casa"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(470, 16)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(206, 22)
        Me.txttotal.TabIndex = 135
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpagoPaciente
        '
        Me.txtpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagoPaciente.Location = New System.Drawing.Point(470, 41)
        Me.txtpagoPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpagoPaciente.Name = "txtpagoPaciente"
        Me.txtpagoPaciente.ReadOnly = True
        Me.txtpagoPaciente.Size = New System.Drawing.Size(206, 22)
        Me.txtpagoPaciente.TabIndex = 134
        Me.txtpagoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtvuelto
        '
        Me.txtvuelto.BackColor = System.Drawing.Color.Khaki
        Me.txtvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvuelto.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtvuelto.Location = New System.Drawing.Point(470, 66)
        Me.txtvuelto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtvuelto.Name = "txtvuelto"
        Me.txtvuelto.ReadOnly = True
        Me.txtvuelto.Size = New System.Drawing.Size(206, 22)
        Me.txtvuelto.TabIndex = 133
        Me.txtvuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(422, 19)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(44, 16)
        Me.lbltotal.TabIndex = 132
        Me.lbltotal.Text = "Total"
        '
        'lblvuelto
        '
        Me.lblvuelto.AutoSize = True
        Me.lblvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvuelto.Location = New System.Drawing.Point(414, 66)
        Me.lblvuelto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblvuelto.Name = "lblvuelto"
        Me.lblvuelto.Size = New System.Drawing.Size(52, 16)
        Me.lblvuelto.TabIndex = 131
        Me.lblvuelto.Text = "Vuelto"
        '
        'lblpagoPaciente
        '
        Me.lblpagoPaciente.AutoSize = True
        Me.lblpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagoPaciente.Location = New System.Drawing.Point(293, 42)
        Me.lblpagoPaciente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpagoPaciente.Name = "lblpagoPaciente"
        Me.lblpagoPaciente.Size = New System.Drawing.Size(173, 16)
        Me.lblpagoPaciente.TabIndex = 130
        Me.lblpagoPaciente.Text = "A Pagar por el Paciente"
        '
        'dgvtabla
        '
        Me.dgvtabla.AllowUserToAddRows = False
        Me.dgvtabla.AllowUserToDeleteRows = False
        Me.dgvtabla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvtabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgvtabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Cantidad, Me.Precio, Me.Descripcion, Me.FechaEntrega, Me.Descuento, Me.Subtotal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvtabla.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvtabla.GridColor = System.Drawing.Color.White
        Me.dgvtabla.Location = New System.Drawing.Point(23, 280)
        Me.dgvtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvtabla.Name = "dgvtabla"
        Me.dgvtabla.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvtabla.RowHeadersVisible = False
        Me.dgvtabla.RowHeadersWidth = 51
        Me.dgvtabla.RowTemplate.Height = 24
        Me.dgvtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvtabla.Size = New System.Drawing.Size(715, 271)
        Me.dgvtabla.TabIndex = 136
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 100
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'FechaEntrega
        '
        Me.FechaEntrega.HeaderText = "Fecha Entrega"
        Me.FechaEntrega.MinimumWidth = 6
        Me.FechaEntrega.Name = "FechaEntrega"
        Me.FechaEntrega.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.MinimumWidth = 6
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'pbxImagenes
        '
        Me.pbxImagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxImagenes.Location = New System.Drawing.Point(764, 27)
        Me.pbxImagenes.Name = "pbxImagenes"
        Me.pbxImagenes.Size = New System.Drawing.Size(562, 628)
        Me.pbxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImagenes.TabIndex = 137
        Me.pbxImagenes.TabStop = False
        '
        'Timer1
        '
        '
        'txttelefonoTrabajo
        '
        Me.txttelefonoTrabajo.Location = New System.Drawing.Point(506, 89)
        Me.txttelefonoTrabajo.Margin = New System.Windows.Forms.Padding(2)
        Me.txttelefonoTrabajo.Name = "txttelefonoTrabajo"
        Me.txttelefonoTrabajo.ReadOnly = True
        Me.txttelefonoTrabajo.Size = New System.Drawing.Size(204, 20)
        Me.txttelefonoTrabajo.TabIndex = 139
        Me.txttelefonoTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(398, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Teléfono Trabajo"
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(506, 41)
        Me.txtcorreo2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.ReadOnly = True
        Me.txtcorreo2.Size = New System.Drawing.Size(204, 20)
        Me.txtcorreo2.TabIndex = 141
        Me.txtcorreo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Correo (Alternativo)"
        '
        'txtcorreo1
        '
        Me.txtcorreo1.Location = New System.Drawing.Point(116, 114)
        Me.txtcorreo1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcorreo1.Name = "txtcorreo1"
        Me.txtcorreo1.ReadOnly = True
        Me.txtcorreo1.Size = New System.Drawing.Size(204, 20)
        Me.txtcorreo1.TabIndex = 145
        Me.txtcorreo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Correo (Principal)"
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(507, 114)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.ReadOnly = True
        Me.txtcelular.Size = New System.Drawing.Size(203, 20)
        Me.txtcelular.TabIndex = 143
        Me.txtcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Celular"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(264, 29)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 84)
        Me.Panel1.TabIndex = 146
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.lblpagoPaciente)
        Me.GroupBox1.Controls.Add(Me.lblvuelto)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.txtvuelto)
        Me.GroupBox1.Controls.Add(Me.txtpagoPaciente)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 554)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(715, 96)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de pago"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.txtcorreo1)
        Me.GroupBox2.Controls.Add(Me.lblnombre)
        Me.GroupBox2.Controls.Add(Me.txtnombreCompleto)
        Me.GroupBox2.Controls.Add(Me.lblterminosPago)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtnombreTerminos)
        Me.GroupBox2.Controls.Add(Me.txtcelular)
        Me.GroupBox2.Controls.Add(Me.lblcategoria)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtnombreCategoria)
        Me.GroupBox2.Controls.Add(Me.txtcorreo2)
        Me.GroupBox2.Controls.Add(Me.lblconvenio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtnombreConvenio)
        Me.GroupBox2.Controls.Add(Me.txttelefonoTrabajo)
        Me.GroupBox2.Controls.Add(Me.lblaseguradora)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txttelefonoCasa)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 120)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(715, 148)
        Me.GroupBox2.TabIndex = 148
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Paciente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 654)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1359, 22)
        Me.StatusStrip1.TabIndex = 149
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1359, 24)
        Me.MenuStrip1.TabIndex = 150
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'M_ClienteVentana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1359, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbxImagenes)
        Me.Controls.Add(Me.dgvtabla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "M_ClienteVentana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorios Médicos"
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombreCompleto As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtnombreTerminos As TextBox
    Friend WithEvents lblterminosPago As Label
    Friend WithEvents txtnombreCategoria As TextBox
    Friend WithEvents lblcategoria As Label
    Friend WithEvents txtnombreConvenio As TextBox
    Friend WithEvents lblconvenio As Label
    Friend WithEvents txttelefonoCasa As TextBox
    Friend WithEvents lblaseguradora As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtpagoPaciente As TextBox
    Friend WithEvents txtvuelto As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblvuelto As Label
    Friend WithEvents lblpagoPaciente As Label
    Friend WithEvents dgvtabla As DataGridView
    Friend WithEvents pbxImagenes As PictureBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txttelefonoTrabajo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcorreo1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
