<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Horarios))
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCodigoBreve = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxRegistrar = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpSalidaFinSemana = New System.Windows.Forms.DateTimePicker()
        Me.cbxDomingo = New System.Windows.Forms.CheckBox()
        Me.lblsalidaFinSemana = New System.Windows.Forms.Label()
        Me.cbxSabado = New System.Windows.Forms.CheckBox()
        Me.lblEntradaFinSemana = New System.Windows.Forms.Label()
        Me.dtpEntradaFinSemana = New System.Windows.Forms.DateTimePicker()
        Me.estadoForm = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtcodigoBreve = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.gbxDiasSemanales = New System.Windows.Forms.GroupBox()
        Me.cbxMiercoles = New System.Windows.Forms.CheckBox()
        Me.cbxLunes = New System.Windows.Forms.CheckBox()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.cbxViernes = New System.Windows.Forms.CheckBox()
        Me.cbxMartes = New System.Windows.Forms.CheckBox()
        Me.cbxJueves = New System.Windows.Forms.CheckBox()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.rtxtObservacion = New System.Windows.Forms.RichTextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbxRegistrar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxDiasSemanales.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Location = New System.Drawing.Point(98, 54)
        Me.lblEntrada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(47, 13)
        Me.lblEntrada.TabIndex = 0
        Me.lblEntrada.Text = "Entrada:"
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Location = New System.Drawing.Point(367, 56)
        Me.lblSalida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(39, 13)
        Me.lblSalida.TabIndex = 1
        Me.lblSalida.Text = "Salida:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(53, 22)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 9
        Me.lblCodigo.Text = "Código:"
        '
        'lblCodigoBreve
        '
        Me.lblCodigoBreve.AutoSize = True
        Me.lblCodigoBreve.Location = New System.Drawing.Point(283, 22)
        Me.lblCodigoBreve.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoBreve.Name = "lblCodigoBreve"
        Me.lblCodigoBreve.Size = New System.Drawing.Size(74, 13)
        Me.lblCodigoBreve.TabIndex = 10
        Me.lblCodigoBreve.Text = "Código Breve:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(49, 48)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observación:"
        '
        'gbxRegistrar
        '
        Me.gbxRegistrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRegistrar.Controls.Add(Me.GroupBox1)
        Me.gbxRegistrar.Controls.Add(Me.estadoForm)
        Me.gbxRegistrar.Controls.Add(Me.lblform)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigoBreve)
        Me.gbxRegistrar.Controls.Add(Me.txtnombre)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigo)
        Me.gbxRegistrar.Controls.Add(Me.gbxDiasSemanales)
        Me.gbxRegistrar.Controls.Add(Me.lblCodigoBreve)
        Me.gbxRegistrar.Controls.Add(Me.lblCodigo)
        Me.gbxRegistrar.Controls.Add(Me.lblNombre)
        Me.gbxRegistrar.Controls.Add(Me.rtxtObservacion)
        Me.gbxRegistrar.Controls.Add(Me.Label6)
        Me.gbxRegistrar.Location = New System.Drawing.Point(6, 47)
        Me.gbxRegistrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxRegistrar.Size = New System.Drawing.Size(710, 273)
        Me.gbxRegistrar.TabIndex = 14
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR HORARIO DE TRABAJO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.dtpSalidaFinSemana)
        Me.GroupBox1.Controls.Add(Me.cbxDomingo)
        Me.GroupBox1.Controls.Add(Me.lblsalidaFinSemana)
        Me.GroupBox1.Controls.Add(Me.cbxSabado)
        Me.GroupBox1.Controls.Add(Me.lblEntradaFinSemana)
        Me.GroupBox1.Controls.Add(Me.dtpEntradaFinSemana)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 157)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(702, 56)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fin de Semana"
        '
        'dtpSalidaFinSemana
        '
        Me.dtpSalidaFinSemana.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaFinSemana.Location = New System.Drawing.Point(502, 26)
        Me.dtpSalidaFinSemana.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpSalidaFinSemana.Name = "dtpSalidaFinSemana"
        Me.dtpSalidaFinSemana.ShowUpDown = True
        Me.dtpSalidaFinSemana.Size = New System.Drawing.Size(135, 20)
        Me.dtpSalidaFinSemana.TabIndex = 156
        '
        'cbxDomingo
        '
        Me.cbxDomingo.AutoSize = True
        Me.cbxDomingo.Location = New System.Drawing.Point(104, 26)
        Me.cbxDomingo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxDomingo.Name = "cbxDomingo"
        Me.cbxDomingo.Size = New System.Drawing.Size(68, 17)
        Me.cbxDomingo.TabIndex = 154
        Me.cbxDomingo.Text = "Domingo"
        Me.cbxDomingo.UseVisualStyleBackColor = True
        '
        'lblsalidaFinSemana
        '
        Me.lblsalidaFinSemana.AutoSize = True
        Me.lblsalidaFinSemana.Location = New System.Drawing.Point(460, 28)
        Me.lblsalidaFinSemana.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsalidaFinSemana.Name = "lblsalidaFinSemana"
        Me.lblsalidaFinSemana.Size = New System.Drawing.Size(39, 13)
        Me.lblsalidaFinSemana.TabIndex = 154
        Me.lblsalidaFinSemana.Text = "Salida:"
        '
        'cbxSabado
        '
        Me.cbxSabado.AutoSize = True
        Me.cbxSabado.Location = New System.Drawing.Point(28, 26)
        Me.cbxSabado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxSabado.Name = "cbxSabado"
        Me.cbxSabado.Size = New System.Drawing.Size(63, 17)
        Me.cbxSabado.TabIndex = 153
        Me.cbxSabado.Text = "Sabado"
        Me.cbxSabado.UseVisualStyleBackColor = True
        '
        'lblEntradaFinSemana
        '
        Me.lblEntradaFinSemana.AutoSize = True
        Me.lblEntradaFinSemana.Location = New System.Drawing.Point(202, 28)
        Me.lblEntradaFinSemana.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntradaFinSemana.Name = "lblEntradaFinSemana"
        Me.lblEntradaFinSemana.Size = New System.Drawing.Size(47, 13)
        Me.lblEntradaFinSemana.TabIndex = 153
        Me.lblEntradaFinSemana.Text = "Entrada:"
        '
        'dtpEntradaFinSemana
        '
        Me.dtpEntradaFinSemana.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntradaFinSemana.Location = New System.Drawing.Point(253, 26)
        Me.dtpEntradaFinSemana.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpEntradaFinSemana.Name = "dtpEntradaFinSemana"
        Me.dtpEntradaFinSemana.ShowUpDown = True
        Me.dtpEntradaFinSemana.Size = New System.Drawing.Size(135, 20)
        Me.dtpEntradaFinSemana.TabIndex = 155
        '
        'estadoForm
        '
        Me.estadoForm.AutoSize = True
        Me.estadoForm.Location = New System.Drawing.Point(10, 24)
        Me.estadoForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.estadoForm.Name = "estadoForm"
        Me.estadoForm.Size = New System.Drawing.Size(39, 13)
        Me.estadoForm.TabIndex = 149
        Me.estadoForm.Text = "Label1"
        Me.estadoForm.Visible = False
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(580, 24)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(39, 13)
        Me.lblform.TabIndex = 148
        Me.lblform.Text = "Label1"
        Me.lblform.Visible = False
        '
        'txtcodigoBreve
        '
        Me.txtcodigoBreve.Location = New System.Drawing.Point(360, 20)
        Me.txtcodigoBreve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoBreve.MaxLength = 20
        Me.txtcodigoBreve.Name = "txtcodigoBreve"
        Me.txtcodigoBreve.Size = New System.Drawing.Size(135, 20)
        Me.txtcodigoBreve.TabIndex = 130
        Me.txtcodigoBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(100, 46)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre.MaxLength = 80
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(396, 20)
        Me.txtnombre.TabIndex = 131
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(100, 20)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(135, 20)
        Me.txtcodigo.TabIndex = 124
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxDiasSemanales
        '
        Me.gbxDiasSemanales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDiasSemanales.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxDiasSemanales.Controls.Add(Me.cbxMiercoles)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxLunes)
        Me.gbxDiasSemanales.Controls.Add(Me.dtpSalida)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxViernes)
        Me.gbxDiasSemanales.Controls.Add(Me.lblSalida)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxMartes)
        Me.gbxDiasSemanales.Controls.Add(Me.lblEntrada)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxJueves)
        Me.gbxDiasSemanales.Controls.Add(Me.dtpEntrada)
        Me.gbxDiasSemanales.Location = New System.Drawing.Point(4, 67)
        Me.gbxDiasSemanales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxDiasSemanales.Name = "gbxDiasSemanales"
        Me.gbxDiasSemanales.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxDiasSemanales.Size = New System.Drawing.Size(702, 85)
        Me.gbxDiasSemanales.TabIndex = 147
        Me.gbxDiasSemanales.TabStop = False
        Me.gbxDiasSemanales.Text = "Días Semanales"
        '
        'cbxMiercoles
        '
        Me.cbxMiercoles.AutoSize = True
        Me.cbxMiercoles.Location = New System.Drawing.Point(291, 24)
        Me.cbxMiercoles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxMiercoles.Name = "cbxMiercoles"
        Me.cbxMiercoles.Size = New System.Drawing.Size(71, 17)
        Me.cbxMiercoles.TabIndex = 150
        Me.cbxMiercoles.Text = "Miercoles"
        Me.cbxMiercoles.UseVisualStyleBackColor = True
        '
        'cbxLunes
        '
        Me.cbxLunes.AutoSize = True
        Me.cbxLunes.Location = New System.Drawing.Point(45, 24)
        Me.cbxLunes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxLunes.Name = "cbxLunes"
        Me.cbxLunes.Size = New System.Drawing.Size(55, 17)
        Me.cbxLunes.TabIndex = 148
        Me.cbxLunes.Text = "Lunes"
        Me.cbxLunes.UseVisualStyleBackColor = True
        '
        'dtpSalida
        '
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalida.Location = New System.Drawing.Point(410, 54)
        Me.dtpSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.ShowUpDown = True
        Me.dtpSalida.Size = New System.Drawing.Size(135, 20)
        Me.dtpSalida.TabIndex = 146
        '
        'cbxViernes
        '
        Me.cbxViernes.AutoSize = True
        Me.cbxViernes.Location = New System.Drawing.Point(558, 24)
        Me.cbxViernes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxViernes.Name = "cbxViernes"
        Me.cbxViernes.Size = New System.Drawing.Size(61, 17)
        Me.cbxViernes.TabIndex = 152
        Me.cbxViernes.Text = "Viernes"
        Me.cbxViernes.UseVisualStyleBackColor = True
        '
        'cbxMartes
        '
        Me.cbxMartes.AutoSize = True
        Me.cbxMartes.Location = New System.Drawing.Point(164, 24)
        Me.cbxMartes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxMartes.Name = "cbxMartes"
        Me.cbxMartes.Size = New System.Drawing.Size(58, 17)
        Me.cbxMartes.TabIndex = 149
        Me.cbxMartes.Text = "Martes"
        Me.cbxMartes.UseVisualStyleBackColor = True
        '
        'cbxJueves
        '
        Me.cbxJueves.AutoSize = True
        Me.cbxJueves.Location = New System.Drawing.Point(423, 24)
        Me.cbxJueves.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxJueves.Name = "cbxJueves"
        Me.cbxJueves.Size = New System.Drawing.Size(60, 17)
        Me.cbxJueves.TabIndex = 151
        Me.cbxJueves.Text = "Jueves"
        Me.cbxJueves.UseVisualStyleBackColor = True
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntrada.Location = New System.Drawing.Point(149, 52)
        Me.dtpEntrada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.ShowUpDown = True
        Me.dtpEntrada.Size = New System.Drawing.Size(135, 20)
        Me.dtpEntrada.TabIndex = 145
        '
        'rtxtObservacion
        '
        Me.rtxtObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtObservacion.Location = New System.Drawing.Point(84, 233)
        Me.rtxtObservacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtObservacion.MaxLength = 200
        Me.rtxtObservacion.Name = "rtxtObservacion"
        Me.rtxtObservacion.Size = New System.Drawing.Size(622, 33)
        Me.rtxtObservacion.TabIndex = 144
        Me.rtxtObservacion.Text = ""
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(571, 10)
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
        Me.btnnuevo.Location = New System.Drawing.Point(412, 10)
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
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(495, 10)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.btncancelar.Location = New System.Drawing.Point(648, 10)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 141
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.Label1)
        Me.gbxbusqueda.Controls.Add(Me.Button4)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(6, 324)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(710, 265)
        Me.gbxbusqueda.TabIndex = 114
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR HORARIO DE TRABAJO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Seleccione una fila para cargar la información "
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(630, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 117
        Me.Button4.Text = "Excel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(222, 244)
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
        Me.dgbtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(8, 57)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(698, 181)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 244)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(190, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE HORARIOS DE TRABAJO"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(59, 17)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(560, 20)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(11, 19)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(44, 13)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Nombre"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 115
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 42)
        Me.Panel1.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(2, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Horarios de Trabajo"
        '
        'M_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Horarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLM -"
        Me.gbxRegistrar.ResumeLayout(False)
        Me.gbxRegistrar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxDiasSemanales.ResumeLayout(False)
        Me.gbxDiasSemanales.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEntrada As Label
    Friend WithEvents lblSalida As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblCodigoBreve As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbxRegistrar As GroupBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtcodigoBreve As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents rtxtObservacion As RichTextBox
    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents gbxDiasSemanales As GroupBox
    Friend WithEvents cbxDomingo As CheckBox
    Friend WithEvents cbxMiercoles As CheckBox
    Friend WithEvents cbxSabado As CheckBox
    Friend WithEvents cbxLunes As CheckBox
    Friend WithEvents cbxViernes As CheckBox
    Friend WithEvents cbxMartes As CheckBox
    Friend WithEvents cbxJueves As CheckBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lblform As Label
    Friend WithEvents estadoForm As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpSalidaFinSemana As DateTimePicker
    Friend WithEvents lblsalidaFinSemana As Label
    Friend WithEvents lblEntradaFinSemana As Label
    Friend WithEvents dtpEntradaFinSemana As DateTimePicker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
