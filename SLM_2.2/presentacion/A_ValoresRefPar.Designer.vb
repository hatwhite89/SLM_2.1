<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_ValoresRefPar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ValoresRefPar))
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtDataValoresRef = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarParametro = New System.Windows.Forms.Button()
        Me.lblCodParametro = New System.Windows.Forms.Label()
        Me.lblCodUnidad = New System.Windows.Forms.Label()
        Me.lblCodValorRef = New System.Windows.Forms.Label()
        Me.dtValoresRef = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxGenero = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarTXT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtDataValorRefTexto = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarParametro2 = New System.Windows.Forms.Button()
        Me.dtDetalleTexto = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxGenero2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEdaden = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEdadhasta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEdadde = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescripcion2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtunidad2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtParametro2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtDataValoresRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtValoresRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtDataValorRefTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtDetalleTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.Location = New System.Drawing.Point(258, 15)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 0
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.Location = New System.Drawing.Point(420, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.Location = New System.Drawing.Point(339, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCerrar.Location = New System.Drawing.Point(501, 15)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnCerrar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnCrear)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 49)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(6, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(225, 25)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Valores de Referencia"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(557, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Valores de Referencia Parámetros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.Controls.Add(Me.txtBusqueda)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.dtDataValoresRef)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 290)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registros"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(55, 24)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(478, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Buscar"
        '
        'dtDataValoresRef
        '
        Me.dtDataValoresRef.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDataValoresRef.BackgroundColor = System.Drawing.Color.White
        Me.dtDataValoresRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDataValoresRef.Location = New System.Drawing.Point(9, 52)
        Me.dtDataValoresRef.Name = "dtDataValoresRef"
        Me.dtDataValoresRef.RowHeadersWidth = 51
        Me.dtDataValoresRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtDataValoresRef.Size = New System.Drawing.Size(524, 232)
        Me.dtDataValoresRef.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.btnBuscarParametro)
        Me.GroupBox1.Controls.Add(Me.lblCodParametro)
        Me.GroupBox1.Controls.Add(Me.lblCodUnidad)
        Me.GroupBox1.Controls.Add(Me.lblCodValorRef)
        Me.GroupBox1.Controls.Add(Me.dtValoresRef)
        Me.GroupBox1.Controls.Add(Me.cbxGenero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtParametro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Valores de Referencia"
        '
        'btnBuscarParametro
        '
        Me.btnBuscarParametro.Location = New System.Drawing.Point(173, 21)
        Me.btnBuscarParametro.Name = "btnBuscarParametro"
        Me.btnBuscarParametro.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarParametro.TabIndex = 12
        Me.btnBuscarParametro.Text = "..."
        Me.btnBuscarParametro.UseVisualStyleBackColor = True
        '
        'lblCodParametro
        '
        Me.lblCodParametro.AutoSize = True
        Me.lblCodParametro.Location = New System.Drawing.Point(447, 86)
        Me.lblCodParametro.Name = "lblCodParametro"
        Me.lblCodParametro.Size = New System.Drawing.Size(84, 13)
        Me.lblCodParametro.TabIndex = 11
        Me.lblCodParametro.Text = "lblCodParametro"
        Me.lblCodParametro.Visible = False
        '
        'lblCodUnidad
        '
        Me.lblCodUnidad.AutoSize = True
        Me.lblCodUnidad.Location = New System.Drawing.Point(370, 86)
        Me.lblCodUnidad.Name = "lblCodUnidad"
        Me.lblCodUnidad.Size = New System.Drawing.Size(60, 13)
        Me.lblCodUnidad.TabIndex = 10
        Me.lblCodUnidad.Text = "CodUnidad"
        Me.lblCodUnidad.Visible = False
        '
        'lblCodValorRef
        '
        Me.lblCodValorRef.AutoSize = True
        Me.lblCodValorRef.Location = New System.Drawing.Point(291, 86)
        Me.lblCodValorRef.Name = "lblCodValorRef"
        Me.lblCodValorRef.Size = New System.Drawing.Size(67, 13)
        Me.lblCodValorRef.TabIndex = 9
        Me.lblCodValorRef.Text = "CodValorRef"
        Me.lblCodValorRef.Visible = False
        '
        'dtValoresRef
        '
        Me.dtValoresRef.AllowUserToDeleteRows = False
        Me.dtValoresRef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtValoresRef.BackgroundColor = System.Drawing.Color.White
        Me.dtValoresRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtValoresRef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dtValoresRef.GridColor = System.Drawing.Color.White
        Me.dtValoresRef.Location = New System.Drawing.Point(9, 114)
        Me.dtValoresRef.Name = "dtValoresRef"
        Me.dtValoresRef.RowHeadersWidth = 51
        Me.dtValoresRef.Size = New System.Drawing.Size(524, 155)
        Me.dtValoresRef.TabIndex = 8
        '
        'Column8
        '
        Me.Column8.HeaderText = "cod"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        Me.Column8.Width = 125
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Edad De"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Edad Hasta"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Edad En"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Valor Normal"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Hasta"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'cbxGenero
        '
        Me.cbxGenero.FormattingEnabled = True
        Me.cbxGenero.Items.AddRange(New Object() {"Ninguno", "M", "F"})
        Me.cbxGenero.Location = New System.Drawing.Point(67, 78)
        Me.cbxGenero.Name = "cbxGenero"
        Me.cbxGenero.Size = New System.Drawing.Size(121, 21)
        Me.cbxGenero.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Genero"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(67, 49)
        Me.txtDescripcion.MaxLength = 151
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(466, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'txtUnidad
        '
        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Location = New System.Drawing.Point(271, 23)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidad"
        '
        'txtParametro
        '
        Me.txtParametro.Enabled = False
        Me.txtParametro.Location = New System.Drawing.Point(67, 23)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parámetro"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(565, 609)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(557, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Valores de Referencia Texto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox5.Controls.Add(Me.txtBuscarTXT)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.dtDataValorRefTexto)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 303)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(545, 274)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registros"
        '
        'txtBuscarTXT
        '
        Me.txtBuscarTXT.Location = New System.Drawing.Point(55, 24)
        Me.txtBuscarTXT.MaxLength = 149
        Me.txtBuscarTXT.Name = "txtBuscarTXT"
        Me.txtBuscarTXT.Size = New System.Drawing.Size(182, 20)
        Me.txtBuscarTXT.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Buscar"
        '
        'dtDataValorRefTexto
        '
        Me.dtDataValorRefTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDataValorRefTexto.BackgroundColor = System.Drawing.Color.White
        Me.dtDataValorRefTexto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDataValorRefTexto.Location = New System.Drawing.Point(9, 52)
        Me.dtDataValorRefTexto.MultiSelect = False
        Me.dtDataValorRefTexto.Name = "dtDataValorRefTexto"
        Me.dtDataValorRefTexto.RowHeadersWidth = 51
        Me.dtDataValorRefTexto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtDataValorRefTexto.Size = New System.Drawing.Size(530, 216)
        Me.dtDataValorRefTexto.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox4.Controls.Add(Me.btnBuscarParametro2)
        Me.GroupBox4.Controls.Add(Me.dtDetalleTexto)
        Me.GroupBox4.Controls.Add(Me.cbxGenero2)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtEdaden)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtEdadhasta)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtEdadde)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion2)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtunidad2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtParametro2)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtCod)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(545, 291)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información de Valores de Referencia Texto"
        '
        'btnBuscarParametro2
        '
        Me.btnBuscarParametro2.Location = New System.Drawing.Point(355, 21)
        Me.btnBuscarParametro2.Name = "btnBuscarParametro2"
        Me.btnBuscarParametro2.Size = New System.Drawing.Size(28, 23)
        Me.btnBuscarParametro2.TabIndex = 17
        Me.btnBuscarParametro2.Text = "..."
        Me.btnBuscarParametro2.UseVisualStyleBackColor = True
        '
        'dtDetalleTexto
        '
        Me.dtDetalleTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDetalleTexto.BackgroundColor = System.Drawing.Color.White
        Me.dtDetalleTexto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetalleTexto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7})
        Me.dtDetalleTexto.Location = New System.Drawing.Point(6, 128)
        Me.dtDetalleTexto.Name = "dtDetalleTexto"
        Me.dtDetalleTexto.RowHeadersWidth = 51
        Me.dtDetalleTexto.Size = New System.Drawing.Size(533, 150)
        Me.dtDetalleTexto.TabIndex = 16
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Cod"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Texto"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'cbxGenero2
        '
        Me.cbxGenero2.FormattingEnabled = True
        Me.cbxGenero2.Items.AddRange(New Object() {"Ninguno", "M", "F"})
        Me.cbxGenero2.Location = New System.Drawing.Point(82, 101)
        Me.cbxGenero2.Name = "cbxGenero2"
        Me.cbxGenero2.Size = New System.Drawing.Size(121, 21)
        Me.cbxGenero2.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Genero"
        '
        'txtEdaden
        '
        Me.txtEdaden.Location = New System.Drawing.Point(465, 75)
        Me.txtEdaden.MaxLength = 9
        Me.txtEdaden.Name = "txtEdaden"
        Me.txtEdaden.Size = New System.Drawing.Size(74, 20)
        Me.txtEdaden.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(411, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Edad En"
        '
        'txtEdadhasta
        '
        Me.txtEdadhasta.Location = New System.Drawing.Point(276, 75)
        Me.txtEdadhasta.MaxLength = 4
        Me.txtEdadhasta.Name = "txtEdadhasta"
        Me.txtEdadhasta.Size = New System.Drawing.Size(75, 20)
        Me.txtEdadhasta.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(207, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Edad Hasta"
        '
        'txtEdadde
        '
        Me.txtEdadde.Location = New System.Drawing.Point(82, 75)
        Me.txtEdadde.MaxLength = 4
        Me.txtEdadde.Name = "txtEdadde"
        Me.txtEdadde.Size = New System.Drawing.Size(69, 20)
        Me.txtEdadde.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Edad De"
        '
        'txtDescripcion2
        '
        Me.txtDescripcion2.Location = New System.Drawing.Point(82, 49)
        Me.txtDescripcion2.MaxLength = 149
        Me.txtDescripcion2.Name = "txtDescripcion2"
        Me.txtDescripcion2.Size = New System.Drawing.Size(457, 20)
        Me.txtDescripcion2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descripción"
        '
        'txtunidad2
        '
        Me.txtunidad2.Enabled = False
        Me.txtunidad2.Location = New System.Drawing.Point(463, 23)
        Me.txtunidad2.Name = "txtunidad2"
        Me.txtunidad2.Size = New System.Drawing.Size(76, 20)
        Me.txtunidad2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(416, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Unidad"
        '
        'txtParametro2
        '
        Me.txtParametro2.Enabled = False
        Me.txtParametro2.Location = New System.Drawing.Point(251, 23)
        Me.txtParametro2.Name = "txtParametro2"
        Me.txtParametro2.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Parámetro"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(82, 23)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 20)
        Me.txtCod.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cod."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 668)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_ValoresRefPar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(584, 690)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_ValoresRefPar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valores de Referencia Parámetro"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtDataValoresRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtValoresRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtDataValorRefTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtDetalleTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrear As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtDataValoresRef As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCodUnidad As Label
    Friend WithEvents lblCodValorRef As Label
    Friend WithEvents dtValoresRef As DataGridView
    Friend WithEvents cbxGenero As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtBuscarTXT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtDataValorRefTexto As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtDetalleTexto As DataGridView
    Friend WithEvents cbxGenero2 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEdaden As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEdadhasta As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEdadde As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescripcion2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtunidad2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtParametro2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCodParametro As Label
    Friend WithEvents btnBuscarParametro As Button
    Friend WithEvents btnBuscarParametro2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
