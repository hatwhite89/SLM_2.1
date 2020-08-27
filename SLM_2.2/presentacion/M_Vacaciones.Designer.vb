<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Vacaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Vacaciones))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.gbxRegistrar = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rtxtcubrira = New System.Windows.Forms.RichTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblcodeTalHum = New System.Windows.Forms.Label()
        Me.lblcodeJefeDepto = New System.Windows.Forms.Label()
        Me.txtJefeDepto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTalentoHumano = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.rbtnNo = New System.Windows.Forms.RadioButton()
        Me.lblcodeSupervisor = New System.Windows.Forms.Label()
        Me.rbtnSi = New System.Windows.Forms.RadioButton()
        Me.rtxtMotivoInasistencia = New System.Windows.Forms.RichTextBox()
        Me.dtpFechaInasistencia = New System.Windows.Forms.DateTimePicker()
        Me.lblcodeEmpleado = New System.Windows.Forms.Label()
        Me.txtFirmaEmpleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupervisor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.rtxtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.gbxbusqueda.Location = New System.Drawing.Point(10, 312)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(708, 262)
        Me.gbxbusqueda.TabIndex = 118
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR HOJA DE INASISTENCIA O SOLICITUD DE VACACIONES"
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(398, 247)
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
        Me.dgbtabla.Location = New System.Drawing.Point(4, 46)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(700, 199)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(1, 247)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(346, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE HOJA DE INASISTENCIA O SOLICITUD DE VACACIONES"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(127, 17)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(566, 20)
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
        Me.gbxRegistrar.Controls.Add(Me.lblEstado)
        Me.gbxRegistrar.Controls.Add(Me.Label15)
        Me.gbxRegistrar.Controls.Add(Me.rtxtcubrira)
        Me.gbxRegistrar.Controls.Add(Me.Label14)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeTalHum)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeJefeDepto)
        Me.gbxRegistrar.Controls.Add(Me.txtJefeDepto)
        Me.gbxRegistrar.Controls.Add(Me.Label12)
        Me.gbxRegistrar.Controls.Add(Me.txtTalentoHumano)
        Me.gbxRegistrar.Controls.Add(Me.Label13)
        Me.gbxRegistrar.Controls.Add(Me.dtpfecha)
        Me.gbxRegistrar.Controls.Add(Me.rbtnNo)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeSupervisor)
        Me.gbxRegistrar.Controls.Add(Me.rbtnSi)
        Me.gbxRegistrar.Controls.Add(Me.rtxtMotivoInasistencia)
        Me.gbxRegistrar.Controls.Add(Me.dtpFechaInasistencia)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.txtFirmaEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.Label8)
        Me.gbxRegistrar.Controls.Add(Me.txtSupervisor)
        Me.gbxRegistrar.Controls.Add(Me.Label9)
        Me.gbxRegistrar.Controls.Add(Me.Label5)
        Me.gbxRegistrar.Controls.Add(Me.Label7)
        Me.gbxRegistrar.Controls.Add(Me.lblform)
        Me.gbxRegistrar.Controls.Add(Me.txtEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigo)
        Me.gbxRegistrar.Controls.Add(Me.Label4)
        Me.gbxRegistrar.Controls.Add(Me.Label3)
        Me.gbxRegistrar.Controls.Add(Me.rtxtObservaciones)
        Me.gbxRegistrar.Controls.Add(Me.Label6)
        Me.gbxRegistrar.Controls.Add(Me.Label1)
        Me.gbxRegistrar.Controls.Add(Me.Label2)
        Me.gbxRegistrar.Location = New System.Drawing.Point(6, 43)
        Me.gbxRegistrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxRegistrar.Size = New System.Drawing.Size(712, 265)
        Me.gbxRegistrar.TabIndex = 117
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR HOJA DE INASISTENCIA O SOLICITUD DE VACACIONES"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(10, 38)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(66, 13)
        Me.lblEstado.TabIndex = 177
        Me.lblEstado.Text = "LabelEstado"
        Me.lblEstado.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(81, 102)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(170, 13)
        Me.Label15.TabIndex = 176
        Me.Label15.Text = "Uso exclusivo de Talento Humano"
        '
        'rtxtcubrira
        '
        Me.rtxtcubrira.Location = New System.Drawing.Point(110, 137)
        Me.rtxtcubrira.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtcubrira.MaxLength = 200
        Me.rtxtcubrira.Name = "rtxtcubrira"
        Me.rtxtcubrira.Size = New System.Drawing.Size(208, 52)
        Me.rtxtcubrira.TabIndex = 175
        Me.rtxtcubrira.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(62, 140)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 174
        Me.Label14.Text = "Cubrirá:"
        '
        'lblcodeTalHum
        '
        Me.lblcodeTalHum.AutoSize = True
        Me.lblcodeTalHum.Location = New System.Drawing.Point(638, 231)
        Me.lblcodeTalHum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeTalHum.Name = "lblcodeTalHum"
        Me.lblcodeTalHum.Size = New System.Drawing.Size(62, 13)
        Me.lblcodeTalHum.TabIndex = 173
        Me.lblcodeTalHum.Text = "codTalHum"
        Me.lblcodeTalHum.Visible = False
        '
        'lblcodeJefeDepto
        '
        Me.lblcodeJefeDepto.AutoSize = True
        Me.lblcodeJefeDepto.Location = New System.Drawing.Point(656, 207)
        Me.lblcodeJefeDepto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeJefeDepto.Name = "lblcodeJefeDepto"
        Me.lblcodeJefeDepto.Size = New System.Drawing.Size(65, 13)
        Me.lblcodeJefeDepto.TabIndex = 172
        Me.lblcodeJefeDepto.Text = "codJeDepto"
        Me.lblcodeJefeDepto.Visible = False
        '
        'txtJefeDepto
        '
        Me.txtJefeDepto.Location = New System.Drawing.Point(502, 203)
        Me.txtJefeDepto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtJefeDepto.MaxLength = 80
        Me.txtJefeDepto.Name = "txtJefeDepto"
        Me.txtJefeDepto.ReadOnly = True
        Me.txtJefeDepto.Size = New System.Drawing.Size(151, 20)
        Me.txtJefeDepto.TabIndex = 171
        Me.txtJefeDepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(399, 207)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 170
        Me.Label12.Text = "Firma Jefe Depto:"
        '
        'txtTalentoHumano
        '
        Me.txtTalentoHumano.Location = New System.Drawing.Point(502, 231)
        Me.txtTalentoHumano.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTalentoHumano.MaxLength = 80
        Me.txtTalentoHumano.Name = "txtTalentoHumano"
        Me.txtTalentoHumano.ReadOnly = True
        Me.txtTalentoHumano.Size = New System.Drawing.Size(151, 20)
        Me.txtTalentoHumano.TabIndex = 169
        Me.txtTalentoHumano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(332, 235)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 13)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "Firma Gestión Talento Humano:"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(521, 98)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(133, 20)
        Me.dtpfecha.TabIndex = 167
        '
        'rbtnNo
        '
        Me.rbtnNo.AutoSize = True
        Me.rbtnNo.Location = New System.Drawing.Point(430, 99)
        Me.rbtnNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnNo.Name = "rbtnNo"
        Me.rbtnNo.Size = New System.Drawing.Size(39, 17)
        Me.rbtnNo.TabIndex = 166
        Me.rbtnNo.TabStop = True
        Me.rbtnNo.Text = "No"
        Me.rbtnNo.UseVisualStyleBackColor = True
        '
        'lblcodeSupervisor
        '
        Me.lblcodeSupervisor.AutoSize = True
        Me.lblcodeSupervisor.Location = New System.Drawing.Point(638, 176)
        Me.lblcodeSupervisor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeSupervisor.Name = "lblcodeSupervisor"
        Me.lblcodeSupervisor.Size = New System.Drawing.Size(31, 13)
        Me.lblcodeSupervisor.TabIndex = 162
        Me.lblcodeSupervisor.Text = "code"
        Me.lblcodeSupervisor.Visible = False
        '
        'rbtnSi
        '
        Me.rbtnSi.AutoSize = True
        Me.rbtnSi.Location = New System.Drawing.Point(394, 99)
        Me.rbtnSi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnSi.Name = "rbtnSi"
        Me.rbtnSi.Size = New System.Drawing.Size(34, 17)
        Me.rbtnSi.TabIndex = 165
        Me.rbtnSi.TabStop = True
        Me.rbtnSi.Text = "Si"
        Me.rbtnSi.UseVisualStyleBackColor = True
        '
        'rtxtMotivoInasistencia
        '
        Me.rtxtMotivoInasistencia.Location = New System.Drawing.Point(502, 48)
        Me.rtxtMotivoInasistencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtMotivoInasistencia.MaxLength = 200
        Me.rtxtMotivoInasistencia.Name = "rtxtMotivoInasistencia"
        Me.rtxtMotivoInasistencia.Size = New System.Drawing.Size(151, 31)
        Me.rtxtMotivoInasistencia.TabIndex = 164
        Me.rtxtMotivoInasistencia.Text = ""
        '
        'dtpFechaInasistencia
        '
        Me.dtpFechaInasistencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInasistencia.Location = New System.Drawing.Point(166, 60)
        Me.dtpFechaInasistencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaInasistencia.Name = "dtpFechaInasistencia"
        Me.dtpFechaInasistencia.Size = New System.Drawing.Size(151, 20)
        Me.dtpFechaInasistencia.TabIndex = 163
        '
        'lblcodeEmpleado
        '
        Me.lblcodeEmpleado.AutoSize = True
        Me.lblcodeEmpleado.Location = New System.Drawing.Point(658, 26)
        Me.lblcodeEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeEmpleado.Name = "lblcodeEmpleado"
        Me.lblcodeEmpleado.Size = New System.Drawing.Size(46, 13)
        Me.lblcodeEmpleado.TabIndex = 160
        Me.lblcodeEmpleado.Text = "codEmp"
        Me.lblcodeEmpleado.Visible = False
        '
        'txtFirmaEmpleado
        '
        Me.txtFirmaEmpleado.Location = New System.Drawing.Point(502, 146)
        Me.txtFirmaEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFirmaEmpleado.MaxLength = 80
        Me.txtFirmaEmpleado.Name = "txtFirmaEmpleado"
        Me.txtFirmaEmpleado.ReadOnly = True
        Me.txtFirmaEmpleado.Size = New System.Drawing.Size(151, 20)
        Me.txtFirmaEmpleado.TabIndex = 159
        Me.txtFirmaEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 149)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Firma del Empleado:"
        '
        'txtSupervisor
        '
        Me.txtSupervisor.Location = New System.Drawing.Point(502, 176)
        Me.txtSupervisor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSupervisor.MaxLength = 80
        Me.txtSupervisor.Name = "txtSupervisor"
        Me.txtSupervisor.ReadOnly = True
        Me.txtSupervisor.Size = New System.Drawing.Size(151, 20)
        Me.txtSupervisor.TabIndex = 157
        Me.txtSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(382, 178)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Firma del Supervisor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Fecha de Inasistencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 101)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Fecha:"
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
        Me.txtEmpleado.Location = New System.Drawing.Point(503, 20)
        Me.txtEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmpleado.MaxLength = 80
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.ReadOnly = True
        Me.txtEmpleado.Size = New System.Drawing.Size(151, 20)
        Me.txtEmpleado.TabIndex = 130
        Me.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(166, 22)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(151, 20)
        Me.txtcodigo.TabIndex = 124
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre del Empleado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(577, 10)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btnnuevo.Location = New System.Drawing.Point(418, 10)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
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
        Me.btnguardar.Location = New System.Drawing.Point(501, 10)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 140
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'rtxtObservaciones
        '
        Me.rtxtObservaciones.Location = New System.Drawing.Point(109, 203)
        Me.rtxtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtObservaciones.MaxLength = 200
        Me.rtxtObservaciones.Name = "rtxtObservaciones"
        Me.rtxtObservaciones.Size = New System.Drawing.Size(208, 48)
        Me.rtxtObservaciones.TabIndex = 144
        Me.rtxtObservaciones.Text = ""
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(654, 10)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 141
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observaciones:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Notificó:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(368, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Motivo de Inasistencia:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 576)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(728, 22)
        Me.StatusStrip1.TabIndex = 119
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 42)
        Me.Panel1.TabIndex = 132
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(2, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Vacaciones"
        '
        'M_Vacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 598)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Vacaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLM -"
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
    Friend WithEvents lblcodeSupervisor As Label
    Friend WithEvents lblcodeEmpleado As Label
    Friend WithEvents txtFirmaEmpleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSupervisor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblform As Label
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents rtxtObservaciones As RichTextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents rbtnSi As RadioButton
    Friend WithEvents rtxtMotivoInasistencia As RichTextBox
    Friend WithEvents dtpFechaInasistencia As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents rtxtcubrira As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblcodeTalHum As Label
    Friend WithEvents lblcodeJefeDepto As Label
    Friend WithEvents txtJefeDepto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTalentoHumano As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
End Class
