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
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.Label12)
        Me.gbxbusqueda.Controls.Add(Me.Button4)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(10, 297)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 262)
        Me.gbxbusqueda.TabIndex = 116
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR PERMISOS ESPECIALES"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(616, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 119
        Me.Button4.Text = "Excel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(221, 241)
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
        Me.dgbtabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 57)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersVisible = False
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(688, 177)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(4, 241)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(187, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE PERMISOS ESPECIALES"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(127, 17)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(430, 20)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(11, 19)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(111, 13)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Nombre del Empleado"
        '
        'gbxRegistrar
        '
        Me.gbxRegistrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.gbxRegistrar.Location = New System.Drawing.Point(7, 52)
        Me.gbxRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxRegistrar.Size = New System.Drawing.Size(700, 241)
        Me.gbxRegistrar.TabIndex = 115
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR PERMISO ESPECIAL"
        '
        'txtTotalDias
        '
        Me.txtTotalDias.Location = New System.Drawing.Point(500, 116)
        Me.txtTotalDias.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalDias.Name = "txtTotalDias"
        Me.txtTotalDias.ReadOnly = True
        Me.txtTotalDias.Size = New System.Drawing.Size(151, 20)
        Me.txtTotalDias.TabIndex = 171
        Me.txtTotalDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(412, 119)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
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
        Me.btnTipoPermiso.Location = New System.Drawing.Point(283, 116)
        Me.btnTipoPermiso.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTipoPermiso.Name = "btnTipoPermiso"
        Me.btnTipoPermiso.Size = New System.Drawing.Size(37, 18)
        Me.btnTipoPermiso.TabIndex = 146
        Me.btnTipoPermiso.Text = "..."
        Me.btnTipoPermiso.UseVisualStyleBackColor = False
        '
        'cmbxTipoPermiso
        '
        Me.cmbxTipoPermiso.DropDownWidth = 170
        Me.cmbxTipoPermiso.FormattingEnabled = True
        Me.cmbxTipoPermiso.Location = New System.Drawing.Point(170, 116)
        Me.cmbxTipoPermiso.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxTipoPermiso.Name = "cmbxTipoPermiso"
        Me.cmbxTipoPermiso.Size = New System.Drawing.Size(110, 21)
        Me.cmbxTipoPermiso.TabIndex = 145
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(66, 116)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(86, 13)
        Me.lbltipo.TabIndex = 144
        Me.lbltipo.Text = "Tipo de Permiso:"
        '
        'lblcodeDepto
        '
        Me.lblcodeDepto.AutoSize = True
        Me.lblcodeDepto.Location = New System.Drawing.Point(88, 43)
        Me.lblcodeDepto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeDepto.Name = "lblcodeDepto"
        Me.lblcodeDepto.Size = New System.Drawing.Size(62, 13)
        Me.lblcodeDepto.TabIndex = 162
        Me.lblcodeDepto.Text = "codTalHum"
        Me.lblcodeDepto.Visible = False
        '
        'lblcodeJefeInme
        '
        Me.lblcodeJefeInme.AutoSize = True
        Me.lblcodeJefeInme.Location = New System.Drawing.Point(428, 42)
        Me.lblcodeJefeInme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeJefeInme.Name = "lblcodeJefeInme"
        Me.lblcodeJefeInme.Size = New System.Drawing.Size(45, 13)
        Me.lblcodeJefeInme.TabIndex = 161
        Me.lblcodeJefeInme.Text = "codJeIn"
        Me.lblcodeJefeInme.Visible = False
        '
        'lblcodigoEmpleado
        '
        Me.lblcodigoEmpleado.AutoSize = True
        Me.lblcodigoEmpleado.Location = New System.Drawing.Point(410, 11)
        Me.lblcodigoEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigoEmpleado.Name = "lblcodigoEmpleado"
        Me.lblcodigoEmpleado.Size = New System.Drawing.Size(46, 13)
        Me.lblcodigoEmpleado.TabIndex = 160
        Me.lblcodigoEmpleado.Text = "codEmp"
        Me.lblcodigoEmpleado.Visible = False
        '
        'txtjefeInmediato
        '
        Me.txtjefeInmediato.Location = New System.Drawing.Point(500, 53)
        Me.txtjefeInmediato.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjefeInmediato.MaxLength = 80
        Me.txtjefeInmediato.Name = "txtjefeInmediato"
        Me.txtjefeInmediato.ReadOnly = True
        Me.txtjefeInmediato.Size = New System.Drawing.Size(151, 20)
        Me.txtjefeInmediato.TabIndex = 159
        Me.txtjefeInmediato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(406, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Jefe Inmediato:"
        '
        'txtDepto
        '
        Me.txtDepto.Location = New System.Drawing.Point(171, 53)
        Me.txtDepto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDepto.MaxLength = 80
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.Size = New System.Drawing.Size(151, 20)
        Me.txtDepto.TabIndex = 157
        Me.txtDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Departamento:"
        '
        'dtpSalidaTemprano
        '
        Me.dtpSalidaTemprano.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaTemprano.Location = New System.Drawing.Point(500, 148)
        Me.dtpSalidaTemprano.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpSalidaTemprano.Name = "dtpSalidaTemprano"
        Me.dtpSalidaTemprano.Size = New System.Drawing.Size(151, 20)
        Me.dtpSalidaTemprano.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Fecha Inicial:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(500, 84)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(151, 20)
        Me.dtpFechaFinal.TabIndex = 151
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(420, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Fecha Final:"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(10, 24)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(39, 13)
        Me.lblform.TabIndex = 149
        Me.lblform.Text = "Label1"
        Me.lblform.Visible = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Location = New System.Drawing.Point(501, 20)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmpleado.MaxLength = 80
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(151, 20)
        Me.txtEmpleado.TabIndex = 130
        Me.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(171, 22)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(151, 20)
        Me.txtcodigo.TabIndex = 124
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(171, 84)
        Me.dtpFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(151, 20)
        Me.dtpFechaInicial.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre del Empleado:"
        '
        'dtpEntradaTarde
        '
        Me.dtpEntradaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntradaTarde.Location = New System.Drawing.Point(170, 152)
        Me.dtpEntradaTarde.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEntradaTarde.Name = "dtpEntradaTarde"
        Me.dtpEntradaTarde.Size = New System.Drawing.Size(151, 20)
        Me.dtpEntradaTarde.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'rtxtObservaciones
        '
        Me.rtxtObservaciones.Location = New System.Drawing.Point(170, 188)
        Me.rtxtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtObservaciones.MaxLength = 200
        Me.rtxtObservaciones.Name = "rtxtObservaciones"
        Me.rtxtObservaciones.Size = New System.Drawing.Size(482, 31)
        Me.rtxtObservaciones.TabIndex = 144
        Me.rtxtObservaciones.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observaciones:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora de Entrada Tarde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora de Salida Temprano:"
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(558, 9)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
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
        Me.btnnuevo.Location = New System.Drawing.Point(399, 9)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 142
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(482, 9)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 140
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(635, 9)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 141
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 561)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 117
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 42)
        Me.Panel1.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(2, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Permiso Especial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(221, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(272, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Seleccione una fila para cargar la información "
        '
        'M_Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Button4 As Button
    Friend WithEvents Label12 As Label
End Class
