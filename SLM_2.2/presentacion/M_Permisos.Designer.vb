<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Permisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Permisos))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.gbxRegistrar = New System.Windows.Forms.GroupBox()
        Me.txtTotalDias = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTipoPermiso = New System.Windows.Forms.Button()
        Me.cmbxTipoPermiso = New System.Windows.Forms.ComboBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblcodeDepto = New System.Windows.Forms.Label()
        Me.lblcodeJefeInme = New System.Windows.Forms.Label()
        Me.lblcodigoEmpleado = New System.Windows.Forms.Label()
        Me.txtjefeInmediato = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpSalidaTemprano = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEntradaTarde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtxtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRegistrar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(13, 366)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(928, 322)
        Me.gbxbusqueda.TabIndex = 116
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR PERMISOS ESPECIALES"
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(295, 304)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
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
        Me.dgbtabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 57)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(917, 245)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 304)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(239, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE PERMISOS ESPECIALES"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(169, 21)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(753, 22)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(15, 23)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(148, 17)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Nombre del Empleado"
        '
        'gbxRegistrar
        '
        Me.gbxRegistrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRegistrar.Controls.Add(Me.txtTotalDias)
        Me.gbxRegistrar.Controls.Add(Me.Label10)
        Me.gbxRegistrar.Controls.Add(Me.btnTipoPermiso)
        Me.gbxRegistrar.Controls.Add(Me.cmbxTipoPermiso)
        Me.gbxRegistrar.Controls.Add(Me.lbltipo)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeDepto)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeJefeInme)
        Me.gbxRegistrar.Controls.Add(Me.lblcodigoEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.txtjefeInmediato)
        Me.gbxRegistrar.Controls.Add(Me.Label8)
        Me.gbxRegistrar.Controls.Add(Me.txtDepto)
        Me.gbxRegistrar.Controls.Add(Me.Label9)
        Me.gbxRegistrar.Controls.Add(Me.dtpSalidaTemprano)
        Me.gbxRegistrar.Controls.Add(Me.Label5)
        Me.gbxRegistrar.Controls.Add(Me.dtpFechaFinal)
        Me.gbxRegistrar.Controls.Add(Me.Label7)
        Me.gbxRegistrar.Controls.Add(Me.lblform)
        Me.gbxRegistrar.Controls.Add(Me.txtEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigo)
        Me.gbxRegistrar.Controls.Add(Me.dtpFechaInicial)
        Me.gbxRegistrar.Controls.Add(Me.Label4)
        Me.gbxRegistrar.Controls.Add(Me.dtpEntradaTarde)
        Me.gbxRegistrar.Controls.Add(Me.Label3)
        Me.gbxRegistrar.Controls.Add(Me.rtxtObservaciones)
        Me.gbxRegistrar.Controls.Add(Me.Label6)
        Me.gbxRegistrar.Controls.Add(Me.Label1)
        Me.gbxRegistrar.Controls.Add(Me.Label2)
        Me.gbxRegistrar.Location = New System.Drawing.Point(9, 64)
        Me.gbxRegistrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxRegistrar.Size = New System.Drawing.Size(933, 297)
        Me.gbxRegistrar.TabIndex = 115
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR PERMISO ESPECIAL"
        '
        'txtTotalDias
        '
        Me.txtTotalDias.Location = New System.Drawing.Point(666, 143)
        Me.txtTotalDias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalDias.Name = "txtTotalDias"
        Me.txtTotalDias.ReadOnly = True
        Me.txtTotalDias.Size = New System.Drawing.Size(200, 22)
        Me.txtTotalDias.TabIndex = 171
        Me.txtTotalDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(549, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "Total de Días:"
        '
        'btnTipoPermiso
        '
        Me.btnTipoPermiso.BackColor = System.Drawing.Color.White
        Me.btnTipoPermiso.BackgroundImage = CType(resources.GetObject("btnTipoPermiso.BackgroundImage"), System.Drawing.Image)
        Me.btnTipoPermiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTipoPermiso.FlatAppearance.BorderSize = 0
        Me.btnTipoPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoPermiso.Location = New System.Drawing.Point(377, 143)
        Me.btnTipoPermiso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTipoPermiso.Name = "btnTipoPermiso"
        Me.btnTipoPermiso.Size = New System.Drawing.Size(49, 22)
        Me.btnTipoPermiso.TabIndex = 146
        Me.btnTipoPermiso.Text = "..."
        Me.btnTipoPermiso.UseVisualStyleBackColor = False
        '
        'cmbxTipoPermiso
        '
        Me.cmbxTipoPermiso.DropDownWidth = 170
        Me.cmbxTipoPermiso.FormattingEnabled = True
        Me.cmbxTipoPermiso.Location = New System.Drawing.Point(226, 143)
        Me.cmbxTipoPermiso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbxTipoPermiso.Name = "cmbxTipoPermiso"
        Me.cmbxTipoPermiso.Size = New System.Drawing.Size(145, 24)
        Me.cmbxTipoPermiso.TabIndex = 145
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(88, 143)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(115, 17)
        Me.lbltipo.TabIndex = 144
        Me.lbltipo.Text = "Tipo de Permiso:"
        '
        'lblcodeDepto
        '
        Me.lblcodeDepto.AutoSize = True
        Me.lblcodeDepto.Location = New System.Drawing.Point(118, 53)
        Me.lblcodeDepto.Name = "lblcodeDepto"
        Me.lblcodeDepto.Size = New System.Drawing.Size(80, 17)
        Me.lblcodeDepto.TabIndex = 162
        Me.lblcodeDepto.Text = "codTalHum"
        Me.lblcodeDepto.Visible = False
        '
        'lblcodeJefeInme
        '
        Me.lblcodeJefeInme.AutoSize = True
        Me.lblcodeJefeInme.Location = New System.Drawing.Point(570, 52)
        Me.lblcodeJefeInme.Name = "lblcodeJefeInme"
        Me.lblcodeJefeInme.Size = New System.Drawing.Size(57, 17)
        Me.lblcodeJefeInme.TabIndex = 161
        Me.lblcodeJefeInme.Text = "codJeIn"
        Me.lblcodeJefeInme.Visible = False
        '
        'lblcodigoEmpleado
        '
        Me.lblcodigoEmpleado.AutoSize = True
        Me.lblcodigoEmpleado.Location = New System.Drawing.Point(546, 13)
        Me.lblcodigoEmpleado.Name = "lblcodigoEmpleado"
        Me.lblcodigoEmpleado.Size = New System.Drawing.Size(59, 17)
        Me.lblcodigoEmpleado.TabIndex = 160
        Me.lblcodigoEmpleado.Text = "codEmp"
        Me.lblcodigoEmpleado.Visible = False
        '
        'txtjefeInmediato
        '
        Me.txtjefeInmediato.Location = New System.Drawing.Point(666, 65)
        Me.txtjefeInmediato.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtjefeInmediato.MaxLength = 80
        Me.txtjefeInmediato.Name = "txtjefeInmediato"
        Me.txtjefeInmediato.ReadOnly = True
        Me.txtjefeInmediato.Size = New System.Drawing.Size(200, 22)
        Me.txtjefeInmediato.TabIndex = 159
        Me.txtjefeInmediato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(541, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Jefe Inmediato:"
        '
        'txtDepto
        '
        Me.txtDepto.Location = New System.Drawing.Point(228, 65)
        Me.txtDepto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDepto.MaxLength = 80
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.Size = New System.Drawing.Size(200, 22)
        Me.txtDepto.TabIndex = 157
        Me.txtDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Departamento:"
        '
        'dtpSalidaTemprano
        '
        Me.dtpSalidaTemprano.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaTemprano.Location = New System.Drawing.Point(666, 182)
        Me.dtpSalidaTemprano.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpSalidaTemprano.Name = "dtpSalidaTemprano"
        Me.dtpSalidaTemprano.Size = New System.Drawing.Size(200, 22)
        Me.dtpSalidaTemprano.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Fecha Inicial:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(666, 104)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaFinal.TabIndex = 151
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(560, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Fecha Final:"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(13, 30)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(51, 17)
        Me.lblform.TabIndex = 149
        Me.lblform.Text = "Label1"
        Me.lblform.Visible = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(668, 25)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmpleado.MaxLength = 80
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(200, 22)
        Me.txtEmpleado.TabIndex = 130
        Me.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(228, 27)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(200, 22)
        Me.txtcodigo.TabIndex = 124
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(228, 104)
        Me.dtpFechaInicial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaInicial.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(493, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre del Empleado:"
        '
        'dtpEntradaTarde
        '
        Me.dtpEntradaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntradaTarde.Location = New System.Drawing.Point(226, 187)
        Me.dtpEntradaTarde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpEntradaTarde.Name = "dtpEntradaTarde"
        Me.dtpEntradaTarde.Size = New System.Drawing.Size(200, 22)
        Me.dtpEntradaTarde.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'rtxtObservaciones
        '
        Me.rtxtObservaciones.Location = New System.Drawing.Point(226, 231)
        Me.rtxtObservaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtObservaciones.MaxLength = 200
        Me.rtxtObservaciones.Name = "rtxtObservaciones"
        Me.rtxtObservaciones.Size = New System.Drawing.Size(641, 37)
        Me.rtxtObservaciones.TabIndex = 144
        Me.rtxtObservaciones.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observaciones:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora de Entrada Tarde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora de Salida Temprano:"
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(744, 11)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 143
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(532, 11)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 142
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(643, 11)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 140
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(847, 11)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 141
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 696)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 117
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 52)
        Me.Panel1.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(3, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 25)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Permiso Especial"
        '
        'M_Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_Permisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLM - "
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRegistrar.ResumeLayout(False)
        Me.gbxRegistrar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents gbxRegistrar As GroupBox
    Friend WithEvents dtpSalidaTemprano As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lblform As Label
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpEntradaTarde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents rtxtObservaciones As RichTextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjefeInmediato As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDepto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblcodigoEmpleado As Label
    Friend WithEvents lblcodeDepto As Label
    Friend WithEvents lblcodeJefeInme As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnTipoPermiso As Button
    Friend WithEvents cmbxTipoPermiso As ComboBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents txtTotalDias As TextBox
    Friend WithEvents Label10 As Label
End Class
