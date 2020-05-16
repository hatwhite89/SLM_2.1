<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_PerfilUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_PerfilUsuario))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrearPerfil = New System.Windows.Forms.Button()
        Me.chkHabilitar = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodBreve = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxModulos = New System.Windows.Forms.GroupBox()
        Me.tcModulos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chkFacturacion = New System.Windows.Forms.CheckBox()
        Me.dtFacturacion = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkContabilidad = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkLaboratorio = New System.Windows.Forms.CheckBox()
        Me.dtLaboratorio = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.chkTalentoHumano = New System.Windows.Forms.CheckBox()
        Me.dtTalentoHumano = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.chkSistema = New System.Windows.Forms.CheckBox()
        Me.dtSistema = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.chkAlmacen = New System.Windows.Forms.CheckBox()
        Me.dtAlmacen = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxPerfil = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxRegistros = New System.Windows.Forms.GroupBox()
        Me.dtPerfiles = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodModulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtContabilidad = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxModulos.SuspendLayout()
        Me.tcModulos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtLaboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dtTalentoHumano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dtSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dtAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPerfil.SuspendLayout()
        Me.gbxRegistros.SuspendLayout()
        CType(Me.dtPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCrearPerfil)
        Me.GroupBox1.Controls.Add(Me.chkHabilitar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodBreve)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Perfil"
        '
        'btnCrearPerfil
        '
        Me.btnCrearPerfil.Location = New System.Drawing.Point(397, 127)
        Me.btnCrearPerfil.Name = "btnCrearPerfil"
        Me.btnCrearPerfil.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearPerfil.TabIndex = 8
        Me.btnCrearPerfil.Text = "Crear Perfil"
        Me.btnCrearPerfil.UseVisualStyleBackColor = True
        '
        'chkHabilitar
        '
        Me.chkHabilitar.AutoSize = True
        Me.chkHabilitar.Location = New System.Drawing.Point(120, 116)
        Me.chkHabilitar.Name = "chkHabilitar"
        Me.chkHabilitar.Size = New System.Drawing.Size(90, 17)
        Me.chkHabilitar.TabIndex = 7
        Me.chkHabilitar.Text = "Habilitar Perfil"
        Me.chkHabilitar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(386, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 86)
        Me.txtDescripcion.MaxLength = 149
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(235, 20)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'txtCodBreve
        '
        Me.txtCodBreve.Location = New System.Drawing.Point(120, 60)
        Me.txtCodBreve.MaxLength = 19
        Me.txtCodBreve.Name = "txtCodBreve"
        Me.txtCodBreve.Size = New System.Drawing.Size(235, 20)
        Me.txtCodBreve.TabIndex = 3
        Me.txtCodBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cod. Breve:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(120, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. :"
        '
        'gbxModulos
        '
        Me.gbxModulos.Controls.Add(Me.tcModulos)
        Me.gbxModulos.Enabled = False
        Me.gbxModulos.Location = New System.Drawing.Point(12, 237)
        Me.gbxModulos.Name = "gbxModulos"
        Me.gbxModulos.Size = New System.Drawing.Size(501, 259)
        Me.gbxModulos.TabIndex = 1
        Me.gbxModulos.TabStop = False
        Me.gbxModulos.Text = "Módulos Habilitados"
        '
        'tcModulos
        '
        Me.tcModulos.Controls.Add(Me.TabPage1)
        Me.tcModulos.Controls.Add(Me.TabPage2)
        Me.tcModulos.Controls.Add(Me.TabPage3)
        Me.tcModulos.Controls.Add(Me.TabPage4)
        Me.tcModulos.Controls.Add(Me.TabPage5)
        Me.tcModulos.Controls.Add(Me.TabPage6)
        Me.tcModulos.Location = New System.Drawing.Point(10, 19)
        Me.tcModulos.Name = "tcModulos"
        Me.tcModulos.SelectedIndex = 0
        Me.tcModulos.Size = New System.Drawing.Size(485, 234)
        Me.tcModulos.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkFacturacion)
        Me.TabPage1.Controls.Add(Me.dtFacturacion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(477, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkFacturacion
        '
        Me.chkFacturacion.AutoSize = True
        Me.chkFacturacion.Location = New System.Drawing.Point(15, 9)
        Me.chkFacturacion.Name = "chkFacturacion"
        Me.chkFacturacion.Size = New System.Drawing.Size(120, 17)
        Me.chkFacturacion.TabIndex = 5
        Me.chkFacturacion.Text = "Módulo Facturación"
        Me.chkFacturacion.UseVisualStyleBackColor = True
        '
        'dtFacturacion
        '
        Me.dtFacturacion.AllowUserToAddRows = False
        Me.dtFacturacion.AllowUserToDeleteRows = False
        Me.dtFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Descrip, Me.Estado, Me.CodModulo})
        Me.dtFacturacion.Location = New System.Drawing.Point(4, 34)
        Me.dtFacturacion.Name = "dtFacturacion"
        Me.dtFacturacion.ReadOnly = True
        Me.dtFacturacion.Size = New System.Drawing.Size(468, 165)
        Me.dtFacturacion.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtContabilidad)
        Me.TabPage2.Controls.Add(Me.chkContabilidad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(477, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contabilidad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkContabilidad
        '
        Me.chkContabilidad.AutoSize = True
        Me.chkContabilidad.Location = New System.Drawing.Point(15, 9)
        Me.chkContabilidad.Name = "chkContabilidad"
        Me.chkContabilidad.Size = New System.Drawing.Size(122, 17)
        Me.chkContabilidad.TabIndex = 3
        Me.chkContabilidad.Text = "Módulo Contabilidad"
        Me.chkContabilidad.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkLaboratorio)
        Me.TabPage3.Controls.Add(Me.dtLaboratorio)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(477, 208)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Laboratorio"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkLaboratorio
        '
        Me.chkLaboratorio.AutoSize = True
        Me.chkLaboratorio.Location = New System.Drawing.Point(15, 9)
        Me.chkLaboratorio.Name = "chkLaboratorio"
        Me.chkLaboratorio.Size = New System.Drawing.Size(117, 17)
        Me.chkLaboratorio.TabIndex = 5
        Me.chkLaboratorio.Text = "Módulo Laboratorio"
        Me.chkLaboratorio.UseVisualStyleBackColor = True
        '
        'dtLaboratorio
        '
        Me.dtLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtLaboratorio.Location = New System.Drawing.Point(4, 34)
        Me.dtLaboratorio.Name = "dtLaboratorio"
        Me.dtLaboratorio.Size = New System.Drawing.Size(468, 165)
        Me.dtLaboratorio.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.chkTalentoHumano)
        Me.TabPage4.Controls.Add(Me.dtTalentoHumano)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(477, 208)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Talento Humano"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chkTalentoHumano
        '
        Me.chkTalentoHumano.AutoSize = True
        Me.chkTalentoHumano.Location = New System.Drawing.Point(15, 9)
        Me.chkTalentoHumano.Name = "chkTalentoHumano"
        Me.chkTalentoHumano.Size = New System.Drawing.Size(143, 17)
        Me.chkTalentoHumano.TabIndex = 5
        Me.chkTalentoHumano.Text = "Módulo Talento Humano"
        Me.chkTalentoHumano.UseVisualStyleBackColor = True
        '
        'dtTalentoHumano
        '
        Me.dtTalentoHumano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTalentoHumano.Location = New System.Drawing.Point(4, 34)
        Me.dtTalentoHumano.Name = "dtTalentoHumano"
        Me.dtTalentoHumano.Size = New System.Drawing.Size(468, 165)
        Me.dtTalentoHumano.TabIndex = 4
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.chkSistema)
        Me.TabPage5.Controls.Add(Me.dtSistema)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(477, 208)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sistema"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'chkSistema
        '
        Me.chkSistema.AutoSize = True
        Me.chkSistema.Location = New System.Drawing.Point(15, 9)
        Me.chkSistema.Name = "chkSistema"
        Me.chkSistema.Size = New System.Drawing.Size(101, 17)
        Me.chkSistema.TabIndex = 5
        Me.chkSistema.Text = "Módulo Sistema"
        Me.chkSistema.UseVisualStyleBackColor = True
        '
        'dtSistema
        '
        Me.dtSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSistema.Location = New System.Drawing.Point(4, 34)
        Me.dtSistema.Name = "dtSistema"
        Me.dtSistema.Size = New System.Drawing.Size(468, 165)
        Me.dtSistema.TabIndex = 4
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.chkAlmacen)
        Me.TabPage6.Controls.Add(Me.dtAlmacen)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(477, 208)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Almacen"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'chkAlmacen
        '
        Me.chkAlmacen.AutoSize = True
        Me.chkAlmacen.Location = New System.Drawing.Point(15, 9)
        Me.chkAlmacen.Name = "chkAlmacen"
        Me.chkAlmacen.Size = New System.Drawing.Size(105, 17)
        Me.chkAlmacen.TabIndex = 5
        Me.chkAlmacen.Text = "Módulo Almacen"
        Me.chkAlmacen.UseVisualStyleBackColor = True
        '
        'dtAlmacen
        '
        Me.dtAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtAlmacen.Location = New System.Drawing.Point(4, 34)
        Me.dtAlmacen.Name = "dtAlmacen"
        Me.dtAlmacen.Size = New System.Drawing.Size(468, 165)
        Me.dtAlmacen.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(258, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 38)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(339, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 38)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(420, 15)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 38)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbxPerfil
        '
        Me.gbxPerfil.Controls.Add(Me.btnCrear)
        Me.gbxPerfil.Controls.Add(Me.Label4)
        Me.gbxPerfil.Controls.Add(Me.btnGuardar)
        Me.gbxPerfil.Controls.Add(Me.btnCancelar)
        Me.gbxPerfil.Controls.Add(Me.btnModificar)
        Me.gbxPerfil.Location = New System.Drawing.Point(12, 5)
        Me.gbxPerfil.Name = "gbxPerfil"
        Me.gbxPerfil.Size = New System.Drawing.Size(502, 63)
        Me.gbxPerfil.TabIndex = 6
        Me.gbxPerfil.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Administración de Permisos"
        '
        'gbxRegistros
        '
        Me.gbxRegistros.Controls.Add(Me.txtBusqueda)
        Me.gbxRegistros.Controls.Add(Me.Label5)
        Me.gbxRegistros.Controls.Add(Me.dtPerfiles)
        Me.gbxRegistros.Location = New System.Drawing.Point(520, 12)
        Me.gbxRegistros.Name = "gbxRegistros"
        Me.gbxRegistros.Size = New System.Drawing.Size(315, 484)
        Me.gbxRegistros.TabIndex = 7
        Me.gbxRegistros.TabStop = False
        Me.gbxRegistros.Text = "Registros"
        '
        'dtPerfiles
        '
        Me.dtPerfiles.AllowUserToAddRows = False
        Me.dtPerfiles.AllowUserToDeleteRows = False
        Me.dtPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtPerfiles.Location = New System.Drawing.Point(6, 62)
        Me.dtPerfiles.Name = "dtPerfiles"
        Me.dtPerfiles.ReadOnly = True
        Me.dtPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtPerfiles.Size = New System.Drawing.Size(303, 416)
        Me.dtPerfiles.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Buscar:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(55, 30)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(203, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'btnCrear
        '
        Me.btnCrear.Enabled = False
        Me.btnCrear.Location = New System.Drawing.Point(177, 15)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 38)
        Me.btnCrear.TabIndex = 7
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Cod
        '
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        '
        'Descrip
        '
        Me.Descrip.HeaderText = "Descripción"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.ReadOnly = True
        Me.Descrip.Width = 270
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 55
        '
        'CodModulo
        '
        Me.CodModulo.HeaderText = "CodModulo"
        Me.CodModulo.Name = "CodModulo"
        Me.CodModulo.ReadOnly = True
        Me.CodModulo.Visible = False
        '
        'dtContabilidad
        '
        Me.dtContabilidad.AllowUserToAddRows = False
        Me.dtContabilidad.AllowUserToDeleteRows = False
        Me.dtContabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtContabilidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.dtContabilidad.Location = New System.Drawing.Point(4, 34)
        Me.dtContabilidad.Name = "dtContabilidad"
        Me.dtContabilidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtContabilidad.Size = New System.Drawing.Size(468, 165)
        Me.dtContabilidad.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 270
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CodModulo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'A_PerfilUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 504)
        Me.Controls.Add(Me.gbxRegistros)
        Me.Controls.Add(Me.gbxPerfil)
        Me.Controls.Add(Me.gbxModulos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "A_PerfilUsuario"
        Me.Text = "Perfiles de Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxModulos.ResumeLayout(False)
        Me.tcModulos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dtLaboratorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dtTalentoHumano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.dtSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dtAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPerfil.ResumeLayout(False)
        Me.gbxPerfil.PerformLayout()
        Me.gbxRegistros.ResumeLayout(False)
        Me.gbxRegistros.PerformLayout()
        CType(Me.dtPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkHabilitar As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodBreve As TextBox
    Friend WithEvents gbxModulos As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tcModulos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents gbxPerfil As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkFacturacion As CheckBox
    Friend WithEvents dtFacturacion As DataGridView
    Friend WithEvents chkContabilidad As CheckBox
    Friend WithEvents chkLaboratorio As CheckBox
    Friend WithEvents dtLaboratorio As DataGridView
    Friend WithEvents chkTalentoHumano As CheckBox
    Friend WithEvents dtTalentoHumano As DataGridView
    Friend WithEvents chkSistema As CheckBox
    Friend WithEvents dtSistema As DataGridView
    Friend WithEvents chkAlmacen As CheckBox
    Friend WithEvents dtAlmacen As DataGridView
    Friend WithEvents btnCrearPerfil As Button
    Friend WithEvents gbxRegistros As GroupBox
    Friend WithEvents dtPerfiles As DataGridView
    Friend WithEvents btnCrear As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewCheckBoxColumn
    Friend WithEvents CodModulo As DataGridViewTextBoxColumn
    Friend WithEvents dtContabilidad As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
