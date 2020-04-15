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
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.gbxRegistrar = New System.Windows.Forms.GroupBox()
        Me.lblcodeTalentoHumano = New System.Windows.Forms.Label()
        Me.lblcodeJefeInme = New System.Windows.Forms.Label()
        Me.lblcodigoEmpleado = New System.Windows.Forms.Label()
        Me.txtjefeInmediato = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTalentoHumano = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpSalidaTemprano = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpSalidaTarde = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpEntradaTarde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.rtxtAsunto = New System.Windows.Forms.RichTextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRegistrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(14, 344)
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
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(307, 289)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 57)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(917, 215)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(17, 289)
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
        Me.gbxRegistrar.Controls.Add(Me.lblcodeTalentoHumano)
        Me.gbxRegistrar.Controls.Add(Me.lblcodeJefeInme)
        Me.gbxRegistrar.Controls.Add(Me.lblcodigoEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.txtjefeInmediato)
        Me.gbxRegistrar.Controls.Add(Me.Label8)
        Me.gbxRegistrar.Controls.Add(Me.txtTalentoHumano)
        Me.gbxRegistrar.Controls.Add(Me.Label9)
        Me.gbxRegistrar.Controls.Add(Me.dtpSalidaTemprano)
        Me.gbxRegistrar.Controls.Add(Me.Label5)
        Me.gbxRegistrar.Controls.Add(Me.dtpSalidaTarde)
        Me.gbxRegistrar.Controls.Add(Me.Label7)
        Me.gbxRegistrar.Controls.Add(Me.lblform)
        Me.gbxRegistrar.Controls.Add(Me.txtEmpleado)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigo)
        Me.gbxRegistrar.Controls.Add(Me.dtpFecha)
        Me.gbxRegistrar.Controls.Add(Me.Label4)
        Me.gbxRegistrar.Controls.Add(Me.dtpEntradaTarde)
        Me.gbxRegistrar.Controls.Add(Me.Label3)
        Me.gbxRegistrar.Controls.Add(Me.btnmodificar)
        Me.gbxRegistrar.Controls.Add(Me.btnnuevo)
        Me.gbxRegistrar.Controls.Add(Me.btnguardar)
        Me.gbxRegistrar.Controls.Add(Me.rtxtAsunto)
        Me.gbxRegistrar.Controls.Add(Me.btncancelar)
        Me.gbxRegistrar.Controls.Add(Me.Label6)
        Me.gbxRegistrar.Controls.Add(Me.Label1)
        Me.gbxRegistrar.Controls.Add(Me.Label2)
        Me.gbxRegistrar.Location = New System.Drawing.Point(14, 13)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Size = New System.Drawing.Size(928, 326)
        Me.gbxRegistrar.TabIndex = 115
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR PERMISO ESPECIAL"
        '
        'lblcodeTalentoHumano
        '
        Me.lblcodeTalentoHumano.AutoSize = True
        Me.lblcodeTalentoHumano.Location = New System.Drawing.Point(559, 230)
        Me.lblcodeTalentoHumano.Name = "lblcodeTalentoHumano"
        Me.lblcodeTalentoHumano.Size = New System.Drawing.Size(80, 17)
        Me.lblcodeTalentoHumano.TabIndex = 162
        Me.lblcodeTalentoHumano.Text = "codTalHum"
        Me.lblcodeTalentoHumano.Visible = False
        '
        'lblcodeJefeInme
        '
        Me.lblcodeJefeInme.AutoSize = True
        Me.lblcodeJefeInme.Location = New System.Drawing.Point(573, 193)
        Me.lblcodeJefeInme.Name = "lblcodeJefeInme"
        Me.lblcodeJefeInme.Size = New System.Drawing.Size(57, 17)
        Me.lblcodeJefeInme.TabIndex = 161
        Me.lblcodeJefeInme.Text = "codJeIn"
        Me.lblcodeJefeInme.Visible = False
        '
        'lblcodigoEmpleado
        '
        Me.lblcodigoEmpleado.AutoSize = True
        Me.lblcodigoEmpleado.Location = New System.Drawing.Point(213, 235)
        Me.lblcodigoEmpleado.Name = "lblcodigoEmpleado"
        Me.lblcodigoEmpleado.Size = New System.Drawing.Size(59, 17)
        Me.lblcodigoEmpleado.TabIndex = 160
        Me.lblcodigoEmpleado.Text = "codEmp"
        Me.lblcodigoEmpleado.Visible = False
        '
        'txtjefeInmediato
        '
        Me.txtjefeInmediato.Location = New System.Drawing.Point(669, 205)
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
        Me.Label8.Location = New System.Drawing.Point(546, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Jefe Inmediato:"
        '
        'txtTalentoHumano
        '
        Me.txtTalentoHumano.Location = New System.Drawing.Point(669, 242)
        Me.txtTalentoHumano.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTalentoHumano.MaxLength = 80
        Me.txtTalentoHumano.Name = "txtTalentoHumano"
        Me.txtTalentoHumano.ReadOnly = True
        Me.txtTalentoHumano.Size = New System.Drawing.Size(200, 22)
        Me.txtTalentoHumano.TabIndex = 157
        Me.txtTalentoHumano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(482, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 17)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Jefe de Talento Humano:"
        '
        'dtpSalidaTemprano
        '
        Me.dtpSalidaTemprano.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaTemprano.Location = New System.Drawing.Point(668, 69)
        Me.dtpSalidaTemprano.Name = "dtpSalidaTemprano"
        Me.dtpSalidaTemprano.Size = New System.Drawing.Size(200, 22)
        Me.dtpSalidaTemprano.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Fecha:"
        '
        'dtpSalidaTarde
        '
        Me.dtpSalidaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalidaTarde.Location = New System.Drawing.Point(668, 110)
        Me.dtpSalidaTarde.Name = "dtpSalidaTarde"
        Me.dtpSalidaTarde.Size = New System.Drawing.Size(200, 22)
        Me.dtpSalidaTarde.TabIndex = 151
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(501, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 17)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "Hora de Salida Tarde:"
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
        Me.txtEmpleado.Location = New System.Drawing.Point(228, 207)
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
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(228, 69)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpFecha.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre del Empleado:"
        '
        'dtpEntradaTarde
        '
        Me.dtpEntradaTarde.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntradaTarde.Location = New System.Drawing.Point(228, 110)
        Me.dtpEntradaTarde.Name = "dtpEntradaTarde"
        Me.dtpEntradaTarde.Size = New System.Drawing.Size(200, 22)
        Me.dtpEntradaTarde.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(228, 278)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 143
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(16, 278)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 142
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(127, 278)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 140
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'rtxtAsunto
        '
        Me.rtxtAsunto.Location = New System.Drawing.Point(228, 148)
        Me.rtxtAsunto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtAsunto.MaxLength = 200
        Me.rtxtAsunto.Name = "rtxtAsunto"
        Me.rtxtAsunto.Size = New System.Drawing.Size(641, 37)
        Me.rtxtAsunto.TabIndex = 144
        Me.rtxtAsunto.Text = ""
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(330, 278)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 141
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Asunto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora de Entrada Tarde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(474, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora de Salida Temprano:"
        '
        'M_Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 678)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.KeyPreview = True
        Me.Name = "M_Permisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permiso Especial"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRegistrar.ResumeLayout(False)
        Me.gbxRegistrar.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents dtpSalidaTarde As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lblform As Label
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpEntradaTarde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents rtxtAsunto As RichTextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjefeInmediato As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTalentoHumano As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblcodigoEmpleado As Label
    Friend WithEvents lblcodeTalentoHumano As Label
    Friend WithEvents lblcodeJefeInme As Label
End Class
