<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Proveedor))
        Me.lblCodeProveedor = New System.Windows.Forms.Label()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.txtSitioWeb = New System.Windows.Forms.TextBox()
        Me.lblSitioWeb = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefonoProv = New System.Windows.Forms.Label()
        Me.txtNombreProvee = New System.Windows.Forms.TextBox()
        Me.lblNombreProv = New System.Windows.Forms.Label()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.gbxInformacion = New System.Windows.Forms.GroupBox()
        Me.lblCodCuenta = New System.Windows.Forms.Label()
        Me.btnBuscarCuenta = New System.Windows.Forms.Button()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.txtCodBreve = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCodeTerminoPago = New System.Windows.Forms.Label()
        Me.btnBuscarTerminoPago = New System.Windows.Forms.Button()
        Me.txtIdTribu = New System.Windows.Forms.TextBox()
        Me.lblIdTrib = New System.Windows.Forms.Label()
        Me.lblCategoriaProv = New System.Windows.Forms.Label()
        Me.txtCodigoTerminoPago = New System.Windows.Forms.TextBox()
        Me.lblTerminoPago = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gbxListado = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.txtNombreBusqueda = New System.Windows.Forms.TextBox()
        Me.lblBuscarProv = New System.Windows.Forms.Label()
        Me.gbxContactos = New System.Windows.Forms.GroupBox()
        Me.dgvDetalleContactos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInformacion.SuspendLayout()
        Me.gbxListado.SuspendLayout()
        Me.gbxContactos.SuspendLayout()
        CType(Me.dgvDetalleContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodeProveedor
        '
        Me.lblCodeProveedor.AutoSize = True
        Me.lblCodeProveedor.Location = New System.Drawing.Point(10, 34)
        Me.lblCodeProveedor.Name = "lblCodeProveedor"
        Me.lblCodeProveedor.Size = New System.Drawing.Size(92, 13)
        Me.lblCodeProveedor.TabIndex = 0
        Me.lblCodeProveedor.Text = "Código Proveedor"
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.Location = New System.Drawing.Point(111, 31)
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.ReadOnly = True
        Me.txtCodProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtCodProveedor.TabIndex = 1
        Me.txtCodProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSitioWeb
        '
        Me.txtSitioWeb.Location = New System.Drawing.Point(515, 83)
        Me.txtSitioWeb.MaxLength = 100
        Me.txtSitioWeb.Name = "txtSitioWeb"
        Me.txtSitioWeb.Size = New System.Drawing.Size(144, 20)
        Me.txtSitioWeb.TabIndex = 7
        '
        'lblSitioWeb
        '
        Me.lblSitioWeb.AutoSize = True
        Me.lblSitioWeb.Location = New System.Drawing.Point(451, 84)
        Me.lblSitioWeb.Name = "lblSitioWeb"
        Me.lblSitioWeb.Size = New System.Drawing.Size(53, 13)
        Me.lblSitioWeb.TabIndex = 2
        Me.lblSitioWeb.Text = "Sitio Web"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(111, 108)
        Me.txtDireccion.MaxLength = 200
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(282, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(11, 111)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(111, 82)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(282, 20)
        Me.txtEmail.TabIndex = 3
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(10, 85)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(32, 13)
        Me.lblCorreo.TabIndex = 6
        Me.lblCorreo.Text = "Email"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(515, 58)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'lblTelefonoProv
        '
        Me.lblTelefonoProv.AutoSize = True
        Me.lblTelefonoProv.Location = New System.Drawing.Point(401, 59)
        Me.lblTelefonoProv.Name = "lblTelefonoProv"
        Me.lblTelefonoProv.Size = New System.Drawing.Size(101, 13)
        Me.lblTelefonoProv.TabIndex = 8
        Me.lblTelefonoProv.Text = "Teléfono Proveedor"
        '
        'txtNombreProvee
        '
        Me.txtNombreProvee.Location = New System.Drawing.Point(111, 57)
        Me.txtNombreProvee.MaxLength = 50
        Me.txtNombreProvee.Name = "txtNombreProvee"
        Me.txtNombreProvee.Size = New System.Drawing.Size(282, 20)
        Me.txtNombreProvee.TabIndex = 2
        '
        'lblNombreProv
        '
        Me.lblNombreProv.AutoSize = True
        Me.lblNombreProv.Location = New System.Drawing.Point(10, 60)
        Me.lblNombreProv.Name = "lblNombreProv"
        Me.lblNombreProv.Size = New System.Drawing.Size(96, 13)
        Me.lblNombreProv.TabIndex = 10
        Me.lblNombreProv.Text = "Nombre Proveedor"
        '
        'dgvProveedores
        '
        Me.dgvProveedores.AllowUserToAddRows = False
        Me.dgvProveedores.AllowUserToDeleteRows = False
        Me.dgvProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.BackgroundColor = System.Drawing.Color.White
        Me.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.GridColor = System.Drawing.Color.White
        Me.dgvProveedores.Location = New System.Drawing.Point(13, 59)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RowHeadersWidth = 51
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(727, 188)
        Me.dgvProveedores.TabIndex = 12
        '
        'gbxInformacion
        '
        Me.gbxInformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInformacion.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gbxInformacion.Controls.Add(Me.lblCodCuenta)
        Me.gbxInformacion.Controls.Add(Me.btnBuscarCuenta)
        Me.gbxInformacion.Controls.Add(Me.txtCuenta)
        Me.gbxInformacion.Controls.Add(Me.Label2)
        Me.gbxInformacion.Controls.Add(Me.lblEstado)
        Me.gbxInformacion.Controls.Add(Me.cbxCategoria)
        Me.gbxInformacion.Controls.Add(Me.txtCodBreve)
        Me.gbxInformacion.Controls.Add(Me.Label9)
        Me.gbxInformacion.Controls.Add(Me.lblCodeTerminoPago)
        Me.gbxInformacion.Controls.Add(Me.btnBuscarTerminoPago)
        Me.gbxInformacion.Controls.Add(Me.txtIdTribu)
        Me.gbxInformacion.Controls.Add(Me.lblIdTrib)
        Me.gbxInformacion.Controls.Add(Me.lblCategoriaProv)
        Me.gbxInformacion.Controls.Add(Me.txtCodigoTerminoPago)
        Me.gbxInformacion.Controls.Add(Me.lblTerminoPago)
        Me.gbxInformacion.Controls.Add(Me.txtCodProveedor)
        Me.gbxInformacion.Controls.Add(Me.lblCodeProveedor)
        Me.gbxInformacion.Controls.Add(Me.txtDireccion)
        Me.gbxInformacion.Controls.Add(Me.lblDireccion)
        Me.gbxInformacion.Controls.Add(Me.txtEmail)
        Me.gbxInformacion.Controls.Add(Me.lblCorreo)
        Me.gbxInformacion.Controls.Add(Me.txtSitioWeb)
        Me.gbxInformacion.Controls.Add(Me.lblSitioWeb)
        Me.gbxInformacion.Controls.Add(Me.txtTelefono)
        Me.gbxInformacion.Controls.Add(Me.lblTelefonoProv)
        Me.gbxInformacion.Controls.Add(Me.txtNombreProvee)
        Me.gbxInformacion.Controls.Add(Me.lblNombreProv)
        Me.gbxInformacion.Location = New System.Drawing.Point(6, 6)
        Me.gbxInformacion.Name = "gbxInformacion"
        Me.gbxInformacion.Size = New System.Drawing.Size(747, 175)
        Me.gbxInformacion.TabIndex = 13
        Me.gbxInformacion.TabStop = False
        Me.gbxInformacion.Text = "Información de Proveedor"
        '
        'lblCodCuenta
        '
        Me.lblCodCuenta.AutoSize = True
        Me.lblCodCuenta.Location = New System.Drawing.Point(535, 144)
        Me.lblCodCuenta.Name = "lblCodCuenta"
        Me.lblCodCuenta.Size = New System.Drawing.Size(59, 13)
        Me.lblCodCuenta.TabIndex = 33
        Me.lblCodCuenta.Text = "codCuenta"
        Me.lblCodCuenta.Visible = False
        '
        'btnBuscarCuenta
        '
        Me.btnBuscarCuenta.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarCuenta.BackgroundImage = CType(resources.GetObject("btnBuscarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCuenta.FlatAppearance.BorderSize = 0
        Me.btnBuscarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCuenta.Location = New System.Drawing.Point(638, 112)
        Me.btnBuscarCuenta.Name = "btnBuscarCuenta"
        Me.btnBuscarCuenta.Size = New System.Drawing.Size(20, 17)
        Me.btnBuscarCuenta.TabIndex = 32
        Me.btnBuscarCuenta.UseVisualStyleBackColor = False
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(515, 111)
        Me.txtCuenta.MaxLength = 20
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(118, 20)
        Me.txtCuenta.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Cuenta"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(251, 177)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 13)
        Me.lblEstado.TabIndex = 29
        Me.lblEstado.Visible = False
        '
        'cbxCategoria
        '
        Me.cbxCategoria.DropDownWidth = 170
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(294, 135)
        Me.cbxCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(99, 21)
        Me.cbxCategoria.TabIndex = 28
        '
        'txtCodBreve
        '
        Me.txtCodBreve.Location = New System.Drawing.Point(294, 32)
        Me.txtCodBreve.MaxLength = 50
        Me.txtCodBreve.Name = "txtCodBreve"
        Me.txtCodBreve.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBreve.TabIndex = 27
        Me.txtCodBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Código Breve"
        '
        'lblCodeTerminoPago
        '
        Me.lblCodeTerminoPago.AutoSize = True
        Me.lblCodeTerminoPago.Location = New System.Drawing.Point(435, 15)
        Me.lblCodeTerminoPago.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeTerminoPago.Name = "lblCodeTerminoPago"
        Me.lblCodeTerminoPago.Size = New System.Drawing.Size(0, 13)
        Me.lblCodeTerminoPago.TabIndex = 25
        Me.lblCodeTerminoPago.Visible = False
        '
        'btnBuscarTerminoPago
        '
        Me.btnBuscarTerminoPago.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarTerminoPago.BackgroundImage = CType(resources.GetObject("btnBuscarTerminoPago.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarTerminoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarTerminoPago.FlatAppearance.BorderSize = 0
        Me.btnBuscarTerminoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTerminoPago.Location = New System.Drawing.Point(638, 32)
        Me.btnBuscarTerminoPago.Name = "btnBuscarTerminoPago"
        Me.btnBuscarTerminoPago.Size = New System.Drawing.Size(20, 17)
        Me.btnBuscarTerminoPago.TabIndex = 24
        Me.btnBuscarTerminoPago.UseVisualStyleBackColor = False
        '
        'txtIdTribu
        '
        Me.txtIdTribu.Location = New System.Drawing.Point(111, 135)
        Me.txtIdTribu.MaxLength = 20
        Me.txtIdTribu.Name = "txtIdTribu"
        Me.txtIdTribu.Size = New System.Drawing.Size(114, 20)
        Me.txtIdTribu.TabIndex = 23
        '
        'lblIdTrib
        '
        Me.lblIdTrib.AutoSize = True
        Me.lblIdTrib.Location = New System.Drawing.Point(13, 139)
        Me.lblIdTrib.Name = "lblIdTrib"
        Me.lblIdTrib.Size = New System.Drawing.Size(65, 13)
        Me.lblIdTrib.TabIndex = 22
        Me.lblIdTrib.Text = "ID Tributario"
        '
        'lblCategoriaProv
        '
        Me.lblCategoriaProv.AutoSize = True
        Me.lblCategoriaProv.Location = New System.Drawing.Point(231, 139)
        Me.lblCategoriaProv.Name = "lblCategoriaProv"
        Me.lblCategoriaProv.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoriaProv.TabIndex = 19
        Me.lblCategoriaProv.Text = "Categoria"
        '
        'txtCodigoTerminoPago
        '
        Me.txtCodigoTerminoPago.Enabled = False
        Me.txtCodigoTerminoPago.Location = New System.Drawing.Point(515, 31)
        Me.txtCodigoTerminoPago.MaxLength = 20
        Me.txtCodigoTerminoPago.Name = "txtCodigoTerminoPago"
        Me.txtCodigoTerminoPago.Size = New System.Drawing.Size(118, 20)
        Me.txtCodigoTerminoPago.TabIndex = 4
        '
        'lblTerminoPago
        '
        Me.lblTerminoPago.AutoSize = True
        Me.lblTerminoPago.Location = New System.Drawing.Point(414, 34)
        Me.lblTerminoPago.Name = "lblTerminoPago"
        Me.lblTerminoPago.Size = New System.Drawing.Size(88, 13)
        Me.lblTerminoPago.TabIndex = 15
        Me.lblTerminoPago.Text = "Término de Pago"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(618, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(698, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Location = New System.Drawing.Point(539, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'gbxListado
        '
        Me.gbxListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxListado.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxListado.Controls.Add(Me.btnLimpiarBusqueda)
        Me.gbxListado.Controls.Add(Me.txtNombreBusqueda)
        Me.gbxListado.Controls.Add(Me.lblBuscarProv)
        Me.gbxListado.Controls.Add(Me.dgvProveedores)
        Me.gbxListado.Location = New System.Drawing.Point(6, 187)
        Me.gbxListado.Name = "gbxListado"
        Me.gbxListado.Size = New System.Drawing.Size(747, 253)
        Me.gbxListado.TabIndex = 14
        Me.gbxListado.TabStop = False
        Me.gbxListado.Text = "Proveedores Registrados"
        '
        'btnLimpiarBusqueda
        '
        Me.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiarBusqueda.BackgroundImage = CType(resources.GetObject("btnLimpiarBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0
        Me.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarBusqueda.Location = New System.Drawing.Point(365, 29)
        Me.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda"
        Me.btnLimpiarBusqueda.Size = New System.Drawing.Size(18, 17)
        Me.btnLimpiarBusqueda.TabIndex = 15
        Me.btnLimpiarBusqueda.UseVisualStyleBackColor = False
        '
        'txtNombreBusqueda
        '
        Me.txtNombreBusqueda.Location = New System.Drawing.Point(115, 28)
        Me.txtNombreBusqueda.MaxLength = 50
        Me.txtNombreBusqueda.Name = "txtNombreBusqueda"
        Me.txtNombreBusqueda.Size = New System.Drawing.Size(246, 20)
        Me.txtNombreBusqueda.TabIndex = 14
        '
        'lblBuscarProv
        '
        Me.lblBuscarProv.AutoSize = True
        Me.lblBuscarProv.Location = New System.Drawing.Point(14, 29)
        Me.lblBuscarProv.Name = "lblBuscarProv"
        Me.lblBuscarProv.Size = New System.Drawing.Size(96, 13)
        Me.lblBuscarProv.TabIndex = 13
        Me.lblBuscarProv.Text = "Nombre Proveedor"
        '
        'gbxContactos
        '
        Me.gbxContactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxContactos.Controls.Add(Me.dgvDetalleContactos)
        Me.gbxContactos.Location = New System.Drawing.Point(6, 45)
        Me.gbxContactos.Name = "gbxContactos"
        Me.gbxContactos.Size = New System.Drawing.Size(747, 385)
        Me.gbxContactos.TabIndex = 15
        Me.gbxContactos.TabStop = False
        Me.gbxContactos.Text = "Contactos Principales"
        '
        'dgvDetalleContactos
        '
        Me.dgvDetalleContactos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleContactos.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalleContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleContactos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Nombre, Me.Telefono, Me.Correo})
        Me.dgvDetalleContactos.GridColor = System.Drawing.Color.White
        Me.dgvDetalleContactos.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetalleContactos.Name = "dgvDetalleContactos"
        Me.dgvDetalleContactos.RowHeadersWidth = 51
        Me.dgvDetalleContactos.Size = New System.Drawing.Size(738, 363)
        Me.dgvDetalleContactos.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre Contacto"
        Me.Nombre.MaxInputLength = 100
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.MaxInputLength = 40
        Me.Telefono.MinimumWidth = 6
        Me.Telefono.Name = "Telefono"
        '
        'Correo
        '
        Me.Correo.HeaderText = "Correo"
        Me.Correo.MaxInputLength = 80
        Me.Correo.MinimumWidth = 6
        Me.Correo.Name = "Correo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 47)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedores"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(767, 473)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbxInformacion)
        Me.TabPage1.Controls.Add(Me.gbxListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(759, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proveedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.gbxContactos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(759, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contactos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(594, 20)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Código Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nombre Proveedor"
        '
        'A_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 527)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "A_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Proveedores"
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInformacion.ResumeLayout(False)
        Me.gbxInformacion.PerformLayout()
        Me.gbxListado.ResumeLayout(False)
        Me.gbxListado.PerformLayout()
        Me.gbxContactos.ResumeLayout(False)
        CType(Me.dgvDetalleContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCodeProveedor As Label
    Friend WithEvents txtCodProveedor As TextBox
    Friend WithEvents txtSitioWeb As TextBox
    Friend WithEvents lblSitioWeb As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefonoProv As Label
    Friend WithEvents txtNombreProvee As TextBox
    Friend WithEvents lblNombreProv As Label
    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents gbxInformacion As GroupBox
    Friend WithEvents gbxListado As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnLimpiarBusqueda As Button
    Friend WithEvents txtNombreBusqueda As TextBox
    Friend WithEvents lblBuscarProv As Label
    Friend WithEvents txtCodigoTerminoPago As TextBox
    Friend WithEvents lblTerminoPago As Label
    Friend WithEvents lblCategoriaProv As Label
    Friend WithEvents txtIdTribu As TextBox
    Friend WithEvents lblIdTrib As Label
    Friend WithEvents gbxContactos As GroupBox
    Friend WithEvents dgvDetalleContactos As DataGridView
    Friend WithEvents lblCodeTerminoPago As Label
    Friend WithEvents btnBuscarTerminoPago As Button
    Friend WithEvents txtCodBreve As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents lblEstado As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCuenta As Button
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCodCuenta As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
