<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_DiarioFacturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_DiarioFacturacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.lblcodigoTipoClasif = New System.Windows.Forms.Label()
        Me.btnTipoClasificacion = New System.Windows.Forms.Button()
        Me.txtnombreClasificacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGrupoExamen = New System.Windows.Forms.Button()
        Me.btnExamen = New System.Windows.Forms.Button()
        Me.btnTerminoPago = New System.Windows.Forms.Button()
        Me.btnMedico = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtExamen = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtDescripcionTermino = New System.Windows.Forms.TextBox()
        Me.txtNombreMedico = New System.Windows.Forms.TextBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEsado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtnumeroB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lblnumeroB = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotalFacturas = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.lblcodigoTipoClasif)
        Me.GroupBox1.Controls.Add(Me.btnTipoClasificacion)
        Me.GroupBox1.Controls.Add(Me.txtnombreClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnGrupoExamen)
        Me.GroupBox1.Controls.Add(Me.btnExamen)
        Me.GroupBox1.Controls.Add(Me.btnTerminoPago)
        Me.GroupBox1.Controls.Add(Me.btnMedico)
        Me.GroupBox1.Controls.Add(Me.btnUsuario)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtGrupo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtExamen)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionTermino)
        Me.GroupBox1.Controls.Add(Me.txtNombreMedico)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.lblEsado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.txtnumeroB)
        Me.GroupBox1.Controls.Add(Me.lblnombreB)
        Me.GroupBox1.Controls.Add(Me.lblForm)
        Me.GroupBox1.Controls.Add(Me.txtnombreB)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.lblnumeroB)
        Me.GroupBox1.Controls.Add(Me.dgbtabla)
        Me.GroupBox1.Controls.Add(Me.lbltotalFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1065, 602)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diario de Facturación"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Green
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExcel.Location = New System.Drawing.Point(808, 162)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(86, 28)
        Me.btnExcel.TabIndex = 174
        Me.btnExcel.Text = "Generar Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'lblcodigoTipoClasif
        '
        Me.lblcodigoTipoClasif.AutoSize = True
        Me.lblcodigoTipoClasif.Location = New System.Drawing.Point(172, 145)
        Me.lblcodigoTipoClasif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigoTipoClasif.Name = "lblcodigoTipoClasif"
        Me.lblcodigoTipoClasif.Size = New System.Drawing.Size(0, 13)
        Me.lblcodigoTipoClasif.TabIndex = 173
        Me.lblcodigoTipoClasif.Visible = False
        '
        'btnTipoClasificacion
        '
        Me.btnTipoClasificacion.BackColor = System.Drawing.Color.White
        Me.btnTipoClasificacion.BackgroundImage = CType(resources.GetObject("btnTipoClasificacion.BackgroundImage"), System.Drawing.Image)
        Me.btnTipoClasificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTipoClasificacion.FlatAppearance.BorderSize = 0
        Me.btnTipoClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoClasificacion.Location = New System.Drawing.Point(283, 126)
        Me.btnTipoClasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTipoClasificacion.Name = "btnTipoClasificacion"
        Me.btnTipoClasificacion.Size = New System.Drawing.Size(30, 17)
        Me.btnTipoClasificacion.TabIndex = 172
        Me.btnTipoClasificacion.Text = "..."
        Me.btnTipoClasificacion.UseVisualStyleBackColor = False
        '
        'txtnombreClasificacion
        '
        Me.txtnombreClasificacion.Location = New System.Drawing.Point(116, 126)
        Me.txtnombreClasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreClasificacion.MaxLength = 20
        Me.txtnombreClasificacion.Name = "txtnombreClasificacion"
        Me.txtnombreClasificacion.ReadOnly = True
        Me.txtnombreClasificacion.Size = New System.Drawing.Size(163, 20)
        Me.txtnombreClasificacion.TabIndex = 171
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "Tipo Clasificación"
        '
        'btnGrupoExamen
        '
        Me.btnGrupoExamen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrupoExamen.BackColor = System.Drawing.Color.White
        Me.btnGrupoExamen.BackgroundImage = CType(resources.GetObject("btnGrupoExamen.BackgroundImage"), System.Drawing.Image)
        Me.btnGrupoExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrupoExamen.FlatAppearance.BorderSize = 0
        Me.btnGrupoExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupoExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupoExamen.Location = New System.Drawing.Point(1018, 92)
        Me.btnGrupoExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGrupoExamen.Name = "btnGrupoExamen"
        Me.btnGrupoExamen.Size = New System.Drawing.Size(30, 17)
        Me.btnGrupoExamen.TabIndex = 169
        Me.btnGrupoExamen.Text = "..."
        Me.btnGrupoExamen.UseVisualStyleBackColor = False
        '
        'btnExamen
        '
        Me.btnExamen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExamen.BackColor = System.Drawing.Color.White
        Me.btnExamen.BackgroundImage = CType(resources.GetObject("btnExamen.BackgroundImage"), System.Drawing.Image)
        Me.btnExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExamen.FlatAppearance.BorderSize = 0
        Me.btnExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExamen.Location = New System.Drawing.Point(643, 93)
        Me.btnExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExamen.Name = "btnExamen"
        Me.btnExamen.Size = New System.Drawing.Size(30, 17)
        Me.btnExamen.TabIndex = 168
        Me.btnExamen.Text = "..."
        Me.btnExamen.UseVisualStyleBackColor = False
        '
        'btnTerminoPago
        '
        Me.btnTerminoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTerminoPago.BackColor = System.Drawing.Color.White
        Me.btnTerminoPago.BackgroundImage = CType(resources.GetObject("btnTerminoPago.BackgroundImage"), System.Drawing.Image)
        Me.btnTerminoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTerminoPago.FlatAppearance.BorderSize = 0
        Me.btnTerminoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminoPago.Location = New System.Drawing.Point(643, 61)
        Me.btnTerminoPago.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTerminoPago.Name = "btnTerminoPago"
        Me.btnTerminoPago.Size = New System.Drawing.Size(30, 17)
        Me.btnTerminoPago.TabIndex = 167
        Me.btnTerminoPago.Text = "..."
        Me.btnTerminoPago.UseVisualStyleBackColor = False
        '
        'btnMedico
        '
        Me.btnMedico.BackColor = System.Drawing.Color.White
        Me.btnMedico.BackgroundImage = CType(resources.GetObject("btnMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMedico.FlatAppearance.BorderSize = 0
        Me.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedico.Location = New System.Drawing.Point(283, 61)
        Me.btnMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnMedico.Name = "btnMedico"
        Me.btnMedico.Size = New System.Drawing.Size(30, 17)
        Me.btnMedico.TabIndex = 166
        Me.btnMedico.Text = "..."
        Me.btnMedico.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.White
        Me.btnUsuario.BackgroundImage = CType(resources.GetObject("btnUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Location = New System.Drawing.Point(283, 93)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(30, 17)
        Me.btnUsuario.TabIndex = 165
        Me.btnUsuario.Text = "..."
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(962, 570)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(25, 13)
        Me.lblTotal.TabIndex = 145
        Me.lblTotal.Text = "000"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(792, 570)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "TOTAL "
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(806, 126)
        Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaHasta.TabIndex = 143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(732, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Fecha Hasta"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(429, 126)
        Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(210, 20)
        Me.dtpFechaDesde.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Fecha Desde"
        '
        'txtGrupo
        '
        Me.txtGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGrupo.Location = New System.Drawing.Point(805, 93)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGrupo.MaxLength = 20
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(210, 20)
        Me.txtGrupo.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(723, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Nombre Area"
        '
        'txtExamen
        '
        Me.txtExamen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExamen.Location = New System.Drawing.Point(429, 93)
        Me.txtExamen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtExamen.MaxLength = 20
        Me.txtExamen.Name = "txtExamen"
        Me.txtExamen.Size = New System.Drawing.Size(210, 20)
        Me.txtExamen.TabIndex = 137
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(69, 93)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(210, 20)
        Me.txtUsuario.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Nombre Examen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Usuario"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(928, 162)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 28)
        Me.btnBuscar.TabIndex = 133
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtDescripcionTermino
        '
        Me.txtDescripcionTermino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionTermino.Location = New System.Drawing.Point(429, 61)
        Me.txtDescripcionTermino.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcionTermino.MaxLength = 20
        Me.txtDescripcionTermino.Name = "txtDescripcionTermino"
        Me.txtDescripcionTermino.Size = New System.Drawing.Size(210, 20)
        Me.txtDescripcionTermino.TabIndex = 132
        '
        'txtNombreMedico
        '
        Me.txtNombreMedico.Location = New System.Drawing.Point(69, 61)
        Me.txtNombreMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreMedico.MaxLength = 20
        Me.txtNombreMedico.Name = "txtNombreMedico"
        Me.txtNombreMedico.Size = New System.Drawing.Size(210, 20)
        Me.txtNombreMedico.TabIndex = 131
        '
        'cmbEstado
        '
        Me.cmbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activa", "Anulada"})
        Me.cmbEstado.Location = New System.Drawing.Point(805, 59)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(210, 21)
        Me.cmbEstado.TabIndex = 130
        '
        'lblEsado
        '
        Me.lblEsado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEsado.AutoSize = True
        Me.lblEsado.Location = New System.Drawing.Point(759, 65)
        Me.lblEsado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEsado.Name = "lblEsado"
        Me.lblEsado.Size = New System.Drawing.Size(40, 13)
        Me.lblEsado.TabIndex = 129
        Me.lblEsado.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Término de Pago"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Médico"
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(805, 28)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(210, 20)
        Me.dtpFecha.TabIndex = 124
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(758, 32)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 123
        Me.lblFecha.Text = "Fecha"
        '
        'txtnumeroB
        '
        Me.txtnumeroB.Location = New System.Drawing.Point(69, 30)
        Me.txtnumeroB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumeroB.MaxLength = 20
        Me.txtnumeroB.Name = "txtnumeroB"
        Me.txtnumeroB.Size = New System.Drawing.Size(210, 20)
        Me.txtnumeroB.TabIndex = 122
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(298, 32)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(44, 13)
        Me.lblnombreB.TabIndex = 121
        Me.lblnombreB.Text = "Nombre"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(468, 0)
        Me.lblForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(37, 13)
        Me.lblForm.TabIndex = 119
        Me.lblForm.Text = "lblform"
        Me.lblForm.Visible = False
        '
        'txtnombreB
        '
        Me.txtnombreB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombreB.Location = New System.Drawing.Point(356, 29)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(353, 20)
        Me.txtnombreB.TabIndex = 120
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(292, 568)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 118
        Me.lblcantidad.Text = "000"
        '
        'lblnumeroB
        '
        Me.lblnumeroB.AutoSize = True
        Me.lblnumeroB.Location = New System.Drawing.Point(23, 32)
        Me.lblnumeroB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnumeroB.Name = "lblnumeroB"
        Me.lblnumeroB.Size = New System.Drawing.Size(44, 13)
        Me.lblnumeroB.TabIndex = 119
        Me.lblnumeroB.Text = "Número"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(16, 193)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersVisible = False
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(1033, 362)
        Me.dgbtabla.TabIndex = 116
        '
        'lbltotalFacturas
        '
        Me.lbltotalFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotalFacturas.AutoSize = True
        Me.lbltotalFacturas.Location = New System.Drawing.Point(45, 568)
        Me.lbltotalFacturas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotalFacturas.Name = "lbltotalFacturas"
        Me.lbltotalFacturas.Size = New System.Drawing.Size(140, 13)
        Me.lbltotalFacturas.TabIndex = 117
        Me.lbltotalFacturas.Text = "CANTIDAD DE FACTURAS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1103, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'M_DiarioFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1103, 609)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_DiarioFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "M_DiarioFacturacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotalFacturas As Label
    Friend WithEvents lblForm As Label
    Friend WithEvents txtnumeroB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnumeroB As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents lblEsado As Label
    Friend WithEvents txtDescripcionTermino As TextBox
    Friend WithEvents txtNombreMedico As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExamen As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnExamen As Button
    Friend WithEvents btnTerminoPago As Button
    Friend WithEvents btnMedico As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnGrupoExamen As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblcodigoTipoClasif As Label
    Friend WithEvents btnTipoClasificacion As Button
    Friend WithEvents txtnombreClasificacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnExcel As Button
End Class
