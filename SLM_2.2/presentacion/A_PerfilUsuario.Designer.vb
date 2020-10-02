<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_PerfilUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.lblCod_MFact = New System.Windows.Forms.Label()
        Me.chkFacturacion = New System.Windows.Forms.CheckBox()
        Me.dtFacturacion = New System.Windows.Forms.DataGridView()
        Me.Cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodModulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblCod_MCont = New System.Windows.Forms.Label()
        Me.dtContabilidad = New System.Windows.Forms.DataGridView()
        Me.CodC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoC = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkContabilidad = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblCod_MLab = New System.Windows.Forms.Label()
        Me.chkLaboratorio = New System.Windows.Forms.CheckBox()
        Me.dtLaboratorio = New System.Windows.Forms.DataGridView()
        Me.CodL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoL = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblCod_MTalento = New System.Windows.Forms.Label()
        Me.chkTalentoHumano = New System.Windows.Forms.CheckBox()
        Me.dtTalentoHumano = New System.Windows.Forms.DataGridView()
        Me.CodT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoT = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.lblCod_MSist = New System.Windows.Forms.Label()
        Me.chkSistema = New System.Windows.Forms.CheckBox()
        Me.dtSistema = New System.Windows.Forms.DataGridView()
        Me.CodS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lblCod_MAlma = New System.Windows.Forms.Label()
        Me.chkAlmacen = New System.Windows.Forms.CheckBox()
        Me.dtAlmacen = New System.Windows.Forms.DataGridView()
        Me.CodA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pbarCarga = New System.Windows.Forms.ProgressBar()
        Me.btnNuevoPerfil = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxRegistros = New System.Windows.Forms.GroupBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtPerfiles = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxModulos.SuspendLayout()
        Me.tcModulos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtLaboratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dtTalentoHumano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dtSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.dtAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRegistros.SuspendLayout()
        CType(Me.dtPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Perfil"
        '
        'btnCrearPerfil
        '
        Me.btnCrearPerfil.Location = New System.Drawing.Point(386, 127)
        Me.btnCrearPerfil.Name = "btnCrearPerfil"
        Me.btnCrearPerfil.Size = New System.Drawing.Size(100, 23)
        Me.btnCrearPerfil.TabIndex = 3
        Me.btnCrearPerfil.Text = "Crear Perfil"
        Me.btnCrearPerfil.UseVisualStyleBackColor = True
        '
        'chkHabilitar
        '
        Me.chkHabilitar.AutoSize = True
        Me.chkHabilitar.Location = New System.Drawing.Point(120, 116)
        Me.chkHabilitar.Name = "chkHabilitar"
        Me.chkHabilitar.Size = New System.Drawing.Size(90, 17)
        Me.chkHabilitar.TabIndex = 2
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
        Me.txtDescripcion.TabIndex = 1
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
        Me.txtCodBreve.TabIndex = 0
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
        Me.gbxModulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxModulos.Controls.Add(Me.tcModulos)
        Me.gbxModulos.Enabled = False
        Me.gbxModulos.Location = New System.Drawing.Point(6, 229)
        Me.gbxModulos.Name = "gbxModulos"
        Me.gbxModulos.Size = New System.Drawing.Size(501, 344)
        Me.gbxModulos.TabIndex = 1
        Me.gbxModulos.TabStop = False
        Me.gbxModulos.Text = "Módulos Habilitados"
        '
        'tcModulos
        '
        Me.tcModulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tcModulos.Controls.Add(Me.TabPage1)
        Me.tcModulos.Controls.Add(Me.TabPage2)
        Me.tcModulos.Controls.Add(Me.TabPage3)
        Me.tcModulos.Controls.Add(Me.TabPage4)
        Me.tcModulos.Controls.Add(Me.TabPage5)
        Me.tcModulos.Controls.Add(Me.TabPage6)
        Me.tcModulos.Location = New System.Drawing.Point(11, 19)
        Me.tcModulos.Name = "tcModulos"
        Me.tcModulos.SelectedIndex = 0
        Me.tcModulos.Size = New System.Drawing.Size(485, 311)
        Me.tcModulos.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCod_MFact)
        Me.TabPage1.Controls.Add(Me.chkFacturacion)
        Me.TabPage1.Controls.Add(Me.dtFacturacion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(477, 285)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblCod_MFact
        '
        Me.lblCod_MFact.AutoSize = True
        Me.lblCod_MFact.Location = New System.Drawing.Point(411, 9)
        Me.lblCod_MFact.Name = "lblCod_MFact"
        Me.lblCod_MFact.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_MFact.TabIndex = 6
        Me.lblCod_MFact.Text = "Label6"
        Me.lblCod_MFact.Visible = False
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
        Me.dtFacturacion.AllowDrop = True
        Me.dtFacturacion.AllowUserToAddRows = False
        Me.dtFacturacion.AllowUserToDeleteRows = False
        Me.dtFacturacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtFacturacion.BackgroundColor = System.Drawing.Color.White
        Me.dtFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod, Me.Descrip, Me.Estado, Me.CodModulo})
        Me.dtFacturacion.Location = New System.Drawing.Point(4, 34)
        Me.dtFacturacion.Name = "dtFacturacion"
        Me.dtFacturacion.ReadOnly = True
        Me.dtFacturacion.Size = New System.Drawing.Size(468, 245)
        Me.dtFacturacion.TabIndex = 4
        '
        'Cod
        '
        Me.Cod.HeaderText = "Código"
        Me.Cod.Name = "Cod"
        Me.Cod.ReadOnly = True
        Me.Cod.Visible = False
        '
        'Descrip
        '
        Me.Descrip.HeaderText = "Descripción"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.ReadOnly = True
        Me.Descrip.Width = 369
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblCod_MCont)
        Me.TabPage2.Controls.Add(Me.dtContabilidad)
        Me.TabPage2.Controls.Add(Me.chkContabilidad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(477, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contabilidad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblCod_MCont
        '
        Me.lblCod_MCont.AutoSize = True
        Me.lblCod_MCont.Location = New System.Drawing.Point(423, 10)
        Me.lblCod_MCont.Name = "lblCod_MCont"
        Me.lblCod_MCont.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_MCont.TabIndex = 7
        Me.lblCod_MCont.Text = "Label6"
        Me.lblCod_MCont.Visible = False
        '
        'dtContabilidad
        '
        Me.dtContabilidad.AllowUserToAddRows = False
        Me.dtContabilidad.AllowUserToDeleteRows = False
        Me.dtContabilidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtContabilidad.BackgroundColor = System.Drawing.Color.White
        Me.dtContabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtContabilidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodC, Me.DataGridViewTextBoxColumn2, Me.EstadoC, Me.DataGridViewTextBoxColumn3})
        Me.dtContabilidad.Location = New System.Drawing.Point(4, 34)
        Me.dtContabilidad.Name = "dtContabilidad"
        Me.dtContabilidad.ReadOnly = True
        Me.dtContabilidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtContabilidad.Size = New System.Drawing.Size(468, 245)
        Me.dtContabilidad.TabIndex = 5
        '
        'CodC
        '
        Me.CodC.HeaderText = "Código"
        Me.CodC.Name = "CodC"
        Me.CodC.ReadOnly = True
        Me.CodC.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 369
        '
        'EstadoC
        '
        Me.EstadoC.HeaderText = "Estado"
        Me.EstadoC.Name = "EstadoC"
        Me.EstadoC.ReadOnly = True
        Me.EstadoC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EstadoC.Width = 55
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CodModulo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
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
        Me.TabPage3.Controls.Add(Me.lblCod_MLab)
        Me.TabPage3.Controls.Add(Me.chkLaboratorio)
        Me.TabPage3.Controls.Add(Me.dtLaboratorio)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(477, 285)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Laboratorio"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblCod_MLab
        '
        Me.lblCod_MLab.AutoSize = True
        Me.lblCod_MLab.Location = New System.Drawing.Point(432, 10)
        Me.lblCod_MLab.Name = "lblCod_MLab"
        Me.lblCod_MLab.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_MLab.TabIndex = 8
        Me.lblCod_MLab.Text = "Label6"
        Me.lblCod_MLab.Visible = False
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
        Me.dtLaboratorio.AllowUserToAddRows = False
        Me.dtLaboratorio.AllowUserToDeleteRows = False
        Me.dtLaboratorio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtLaboratorio.BackgroundColor = System.Drawing.Color.White
        Me.dtLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtLaboratorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodL, Me.Descripc, Me.EstadoL, Me.Column1})
        Me.dtLaboratorio.Location = New System.Drawing.Point(4, 34)
        Me.dtLaboratorio.Name = "dtLaboratorio"
        Me.dtLaboratorio.ReadOnly = True
        Me.dtLaboratorio.Size = New System.Drawing.Size(468, 248)
        Me.dtLaboratorio.TabIndex = 4
        '
        'CodL
        '
        Me.CodL.HeaderText = "Codigo"
        Me.CodL.Name = "CodL"
        Me.CodL.ReadOnly = True
        Me.CodL.Visible = False
        '
        'Descripc
        '
        Me.Descripc.HeaderText = "Descripción"
        Me.Descripc.Name = "Descripc"
        Me.Descripc.ReadOnly = True
        Me.Descripc.Width = 369
        '
        'EstadoL
        '
        Me.EstadoL.HeaderText = "Estado"
        Me.EstadoL.Name = "EstadoL"
        Me.EstadoL.ReadOnly = True
        Me.EstadoL.Width = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "CodModulo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lblCod_MTalento)
        Me.TabPage4.Controls.Add(Me.chkTalentoHumano)
        Me.TabPage4.Controls.Add(Me.dtTalentoHumano)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(477, 285)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Talento Humano"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lblCod_MTalento
        '
        Me.lblCod_MTalento.AutoSize = True
        Me.lblCod_MTalento.Location = New System.Drawing.Point(432, 9)
        Me.lblCod_MTalento.Name = "lblCod_MTalento"
        Me.lblCod_MTalento.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_MTalento.TabIndex = 8
        Me.lblCod_MTalento.Text = "Label6"
        Me.lblCod_MTalento.Visible = False
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
        Me.dtTalentoHumano.AllowUserToAddRows = False
        Me.dtTalentoHumano.AllowUserToDeleteRows = False
        Me.dtTalentoHumano.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtTalentoHumano.BackgroundColor = System.Drawing.Color.White
        Me.dtTalentoHumano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTalentoHumano.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodT, Me.descripccion, Me.EstadoT, Me.Column4})
        Me.dtTalentoHumano.Location = New System.Drawing.Point(4, 34)
        Me.dtTalentoHumano.Name = "dtTalentoHumano"
        Me.dtTalentoHumano.ReadOnly = True
        Me.dtTalentoHumano.Size = New System.Drawing.Size(468, 248)
        Me.dtTalentoHumano.TabIndex = 4
        '
        'CodT
        '
        Me.CodT.HeaderText = "Codigo"
        Me.CodT.Name = "CodT"
        Me.CodT.ReadOnly = True
        Me.CodT.Visible = False
        '
        'descripccion
        '
        Me.descripccion.HeaderText = "Descripción"
        Me.descripccion.Name = "descripccion"
        Me.descripccion.ReadOnly = True
        Me.descripccion.Width = 369
        '
        'EstadoT
        '
        Me.EstadoT.HeaderText = "Estado"
        Me.EstadoT.Name = "EstadoT"
        Me.EstadoT.ReadOnly = True
        Me.EstadoT.Width = 55
        '
        'Column4
        '
        Me.Column4.HeaderText = "CodModulo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column4.Visible = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.lblCod_MSist)
        Me.TabPage5.Controls.Add(Me.chkSistema)
        Me.TabPage5.Controls.Add(Me.dtSistema)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(477, 285)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Sistema"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'lblCod_MSist
        '
        Me.lblCod_MSist.AutoSize = True
        Me.lblCod_MSist.Location = New System.Drawing.Point(432, 9)
        Me.lblCod_MSist.Name = "lblCod_MSist"
        Me.lblCod_MSist.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_MSist.TabIndex = 8
        Me.lblCod_MSist.Text = "Label6"
        Me.lblCod_MSist.Visible = False
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
        Me.dtSistema.AllowUserToAddRows = False
        Me.dtSistema.AllowUserToDeleteRows = False
        Me.dtSistema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtSistema.BackgroundColor = System.Drawing.Color.White
        Me.dtSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSistema.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodS, Me.Column5, Me.EstadoS, Me.Column7})
        Me.dtSistema.Location = New System.Drawing.Point(4, 34)
        Me.dtSistema.Name = "dtSistema"
        Me.dtSistema.ReadOnly = True
        Me.dtSistema.Size = New System.Drawing.Size(468, 248)
        Me.dtSistema.TabIndex = 4
        '
        'CodS
        '
        Me.CodS.HeaderText = "Codigo"
        Me.CodS.Name = "CodS"
        Me.CodS.ReadOnly = True
        Me.CodS.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "Descripción"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 369
        '
        'EstadoS
        '
        Me.EstadoS.HeaderText = "Estado"
        Me.EstadoS.Name = "EstadoS"
        Me.EstadoS.ReadOnly = True
        Me.EstadoS.Width = 55
        '
        'Column7
        '
        Me.Column7.HeaderText = "CodModulo"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        Me.Column7.Width = 55
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.lblCod_MAlma)
        Me.TabPage6.Controls.Add(Me.chkAlmacen)
        Me.TabPage6.Controls.Add(Me.dtAlmacen)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(477, 285)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Almacen"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'lblCod_MAlma
        '
        Me.lblCod_MAlma.AutoSize = True
        Me.lblCod_MAlma.Location = New System.Drawing.Point(432, 10)
        Me.lblCod_MAlma.Name = "lblCod_MAlma"
        Me.lblCod_MAlma.Size = New System.Drawing.Size(39, 13)
        Me.lblCod_MAlma.TabIndex = 8
        Me.lblCod_MAlma.Text = "Label6"
        Me.lblCod_MAlma.Visible = False
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
        Me.dtAlmacen.AllowUserToAddRows = False
        Me.dtAlmacen.AllowUserToDeleteRows = False
        Me.dtAlmacen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtAlmacen.BackgroundColor = System.Drawing.Color.White
        Me.dtAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodA, Me.Column9, Me.EstadoE, Me.Column11})
        Me.dtAlmacen.Location = New System.Drawing.Point(4, 34)
        Me.dtAlmacen.Name = "dtAlmacen"
        Me.dtAlmacen.ReadOnly = True
        Me.dtAlmacen.Size = New System.Drawing.Size(468, 248)
        Me.dtAlmacen.TabIndex = 4
        '
        'CodA
        '
        Me.CodA.HeaderText = "Codigo"
        Me.CodA.Name = "CodA"
        Me.CodA.ReadOnly = True
        Me.CodA.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descripción"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 369
        '
        'EstadoE
        '
        Me.EstadoE.HeaderText = "Estado"
        Me.EstadoE.Name = "EstadoE"
        Me.EstadoE.ReadOnly = True
        Me.EstadoE.Width = 55
        '
        'Column11
        '
        Me.Column11.HeaderText = "CodModulo"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(692, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 25)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(773, 11)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 25)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(854, 11)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 25)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'pbarCarga
        '
        Me.pbarCarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbarCarga.BackColor = System.Drawing.Color.White
        Me.pbarCarga.ForeColor = System.Drawing.Color.LimeGreen
        Me.pbarCarga.Location = New System.Drawing.Point(0, 35)
        Me.pbarCarga.Name = "pbarCarga"
        Me.pbarCarga.Size = New System.Drawing.Size(942, 18)
        Me.pbarCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarCarga.TabIndex = 1
        '
        'btnNuevoPerfil
        '
        Me.btnNuevoPerfil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoPerfil.BackColor = System.Drawing.Color.White
        Me.btnNuevoPerfil.Enabled = False
        Me.btnNuevoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoPerfil.Location = New System.Drawing.Point(611, 11)
        Me.btnNuevoPerfil.Name = "btnNuevoPerfil"
        Me.btnNuevoPerfil.Size = New System.Drawing.Size(75, 25)
        Me.btnNuevoPerfil.TabIndex = 7
        Me.btnNuevoPerfil.Text = "Crear Nuevo"
        Me.btnNuevoPerfil.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Administración de Permisos"
        '
        'gbxRegistros
        '
        Me.gbxRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRegistros.Controls.Add(Me.txtBusqueda)
        Me.gbxRegistros.Controls.Add(Me.Label5)
        Me.gbxRegistros.Controls.Add(Me.dtPerfiles)
        Me.gbxRegistros.Location = New System.Drawing.Point(514, 64)
        Me.gbxRegistros.Name = "gbxRegistros"
        Me.gbxRegistros.Size = New System.Drawing.Size(414, 509)
        Me.gbxRegistros.TabIndex = 7
        Me.gbxRegistros.TabStop = False
        Me.gbxRegistros.Text = "Registros"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(51, 30)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(203, 20)
        Me.txtBusqueda.TabIndex = 2
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
        'dtPerfiles
        '
        Me.dtPerfiles.AllowUserToAddRows = False
        Me.dtPerfiles.AllowUserToDeleteRows = False
        Me.dtPerfiles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtPerfiles.BackgroundColor = System.Drawing.Color.White
        Me.dtPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtPerfiles.Location = New System.Drawing.Point(6, 62)
        Me.dtPerfiles.Name = "dtPerfiles"
        Me.dtPerfiles.ReadOnly = True
        Me.dtPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtPerfiles.Size = New System.Drawing.Size(402, 433)
        Me.dtPerfiles.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnNuevoPerfil)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 47)
        Me.Panel1.TabIndex = 8
        '
        'A_PerfilUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(940, 578)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbxRegistros)
        Me.Controls.Add(Me.gbxModulos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbarCarga)
        Me.KeyPreview = True
        Me.Name = "A_PerfilUsuario"
        Me.Text = "Configuración de Permisos"
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
        CType(Me.dtContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.gbxRegistros.ResumeLayout(False)
        Me.gbxRegistros.PerformLayout()
        CType(Me.dtPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents btnNuevoPerfil As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtContabilidad As DataGridView
    Friend WithEvents pbarCarga As ProgressBar
    Friend WithEvents Cod As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewCheckBoxColumn
    Friend WithEvents CodModulo As DataGridViewTextBoxColumn
    Friend WithEvents lblCod_MFact As Label
    Friend WithEvents lblCod_MCont As Label
    Friend WithEvents lblCod_MLab As Label
    Friend WithEvents lblCod_MTalento As Label
    Friend WithEvents lblCod_MSist As Label
    Friend WithEvents lblCod_MAlma As Label
    Friend WithEvents CodC As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoC As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CodL As DataGridViewTextBoxColumn
    Friend WithEvents Descripc As DataGridViewTextBoxColumn
    Friend WithEvents EstadoL As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents CodT As DataGridViewTextBoxColumn
    Friend WithEvents descripccion As DataGridViewTextBoxColumn
    Friend WithEvents EstadoT As DataGridViewCheckBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents CodS As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoS As DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents CodA As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents EstadoE As DataGridViewCheckBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
