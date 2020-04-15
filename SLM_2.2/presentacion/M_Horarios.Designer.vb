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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxRegistrar = New System.Windows.Forms.GroupBox()
        Me.estadoForm = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.txtcodigoBreve = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.gbxDiasSemanales = New System.Windows.Forms.GroupBox()
        Me.cbxDomingo = New System.Windows.Forms.CheckBox()
        Me.cbxMiercoles = New System.Windows.Forms.CheckBox()
        Me.cbxSabado = New System.Windows.Forms.CheckBox()
        Me.cbxLunes = New System.Windows.Forms.CheckBox()
        Me.cbxViernes = New System.Windows.Forms.CheckBox()
        Me.cbxMartes = New System.Windows.Forms.CheckBox()
        Me.cbxJueves = New System.Windows.Forms.CheckBox()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.rtxtObservacion = New System.Windows.Forms.RichTextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.gbxRegistrar.SuspendLayout()
        Me.gbxDiasSemanales.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Código Breve:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Observación:"
        '
        'gbxRegistrar
        '
        Me.gbxRegistrar.Controls.Add(Me.estadoForm)
        Me.gbxRegistrar.Controls.Add(Me.lblform)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigoBreve)
        Me.gbxRegistrar.Controls.Add(Me.txtnombre)
        Me.gbxRegistrar.Controls.Add(Me.txtcodigo)
        Me.gbxRegistrar.Controls.Add(Me.dtpSalida)
        Me.gbxRegistrar.Controls.Add(Me.gbxDiasSemanales)
        Me.gbxRegistrar.Controls.Add(Me.Label4)
        Me.gbxRegistrar.Controls.Add(Me.dtpEntrada)
        Me.gbxRegistrar.Controls.Add(Me.Label3)
        Me.gbxRegistrar.Controls.Add(Me.btnmodificar)
        Me.gbxRegistrar.Controls.Add(Me.Label5)
        Me.gbxRegistrar.Controls.Add(Me.btnnuevo)
        Me.gbxRegistrar.Controls.Add(Me.btnguardar)
        Me.gbxRegistrar.Controls.Add(Me.rtxtObservacion)
        Me.gbxRegistrar.Controls.Add(Me.btncancelar)
        Me.gbxRegistrar.Controls.Add(Me.Label6)
        Me.gbxRegistrar.Controls.Add(Me.Label1)
        Me.gbxRegistrar.Controls.Add(Me.Label2)
        Me.gbxRegistrar.Location = New System.Drawing.Point(15, 14)
        Me.gbxRegistrar.Name = "gbxRegistrar"
        Me.gbxRegistrar.Size = New System.Drawing.Size(928, 326)
        Me.gbxRegistrar.TabIndex = 14
        Me.gbxRegistrar.TabStop = False
        Me.gbxRegistrar.Text = "REGISTRAR HORARIO DE TRABAJO"
        '
        'estadoForm
        '
        Me.estadoForm.AutoSize = True
        Me.estadoForm.Location = New System.Drawing.Point(13, 30)
        Me.estadoForm.Name = "estadoForm"
        Me.estadoForm.Size = New System.Drawing.Size(51, 17)
        Me.estadoForm.TabIndex = 149
        Me.estadoForm.Text = "Label1"
        Me.estadoForm.Visible = False
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(773, 30)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(51, 17)
        Me.lblform.TabIndex = 148
        Me.lblform.Text = "Label1"
        Me.lblform.Visible = False
        '
        'txtcodigoBreve
        '
        Me.txtcodigoBreve.Location = New System.Drawing.Point(480, 24)
        Me.txtcodigoBreve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoBreve.MaxLength = 80
        Me.txtcodigoBreve.Name = "txtcodigoBreve"
        Me.txtcodigoBreve.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigoBreve.TabIndex = 130
        Me.txtcodigoBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(133, 56)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.MaxLength = 80
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(423, 22)
        Me.txtnombre.TabIndex = 131
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(133, 25)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 124
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpSalida
        '
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpSalida.Location = New System.Drawing.Point(480, 91)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.Size = New System.Drawing.Size(179, 22)
        Me.dtpSalida.TabIndex = 146
        '
        'gbxDiasSemanales
        '
        Me.gbxDiasSemanales.Controls.Add(Me.cbxDomingo)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxMiercoles)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxSabado)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxLunes)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxViernes)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxMartes)
        Me.gbxDiasSemanales.Controls.Add(Me.cbxJueves)
        Me.gbxDiasSemanales.Location = New System.Drawing.Point(20, 122)
        Me.gbxDiasSemanales.Name = "gbxDiasSemanales"
        Me.gbxDiasSemanales.Size = New System.Drawing.Size(880, 69)
        Me.gbxDiasSemanales.TabIndex = 147
        Me.gbxDiasSemanales.TabStop = False
        Me.gbxDiasSemanales.Text = "Días Semanales"
        '
        'cbxDomingo
        '
        Me.cbxDomingo.AutoSize = True
        Me.cbxDomingo.Location = New System.Drawing.Point(731, 30)
        Me.cbxDomingo.Name = "cbxDomingo"
        Me.cbxDomingo.Size = New System.Drawing.Size(86, 21)
        Me.cbxDomingo.TabIndex = 154
        Me.cbxDomingo.Text = "Domingo"
        Me.cbxDomingo.UseVisualStyleBackColor = True
        '
        'cbxMiercoles
        '
        Me.cbxMiercoles.AutoSize = True
        Me.cbxMiercoles.Location = New System.Drawing.Point(300, 30)
        Me.cbxMiercoles.Name = "cbxMiercoles"
        Me.cbxMiercoles.Size = New System.Drawing.Size(90, 21)
        Me.cbxMiercoles.TabIndex = 150
        Me.cbxMiercoles.Text = "Miercoles"
        Me.cbxMiercoles.UseVisualStyleBackColor = True
        '
        'cbxSabado
        '
        Me.cbxSabado.AutoSize = True
        Me.cbxSabado.Location = New System.Drawing.Point(629, 30)
        Me.cbxSabado.Name = "cbxSabado"
        Me.cbxSabado.Size = New System.Drawing.Size(79, 21)
        Me.cbxSabado.TabIndex = 153
        Me.cbxSabado.Text = "Sabado"
        Me.cbxSabado.UseVisualStyleBackColor = True
        '
        'cbxLunes
        '
        Me.cbxLunes.AutoSize = True
        Me.cbxLunes.Location = New System.Drawing.Point(60, 30)
        Me.cbxLunes.Name = "cbxLunes"
        Me.cbxLunes.Size = New System.Drawing.Size(69, 21)
        Me.cbxLunes.TabIndex = 148
        Me.cbxLunes.Text = "Lunes"
        Me.cbxLunes.UseVisualStyleBackColor = True
        '
        'cbxViernes
        '
        Me.cbxViernes.AutoSize = True
        Me.cbxViernes.Location = New System.Drawing.Point(521, 30)
        Me.cbxViernes.Name = "cbxViernes"
        Me.cbxViernes.Size = New System.Drawing.Size(78, 21)
        Me.cbxViernes.TabIndex = 152
        Me.cbxViernes.Text = "Viernes"
        Me.cbxViernes.UseVisualStyleBackColor = True
        '
        'cbxMartes
        '
        Me.cbxMartes.AutoSize = True
        Me.cbxMartes.Location = New System.Drawing.Point(186, 30)
        Me.cbxMartes.Name = "cbxMartes"
        Me.cbxMartes.Size = New System.Drawing.Size(73, 21)
        Me.cbxMartes.TabIndex = 149
        Me.cbxMartes.Text = "Martes"
        Me.cbxMartes.UseVisualStyleBackColor = True
        '
        'cbxJueves
        '
        Me.cbxJueves.AutoSize = True
        Me.cbxJueves.Location = New System.Drawing.Point(422, 30)
        Me.cbxJueves.Name = "cbxJueves"
        Me.cbxJueves.Size = New System.Drawing.Size(75, 21)
        Me.cbxJueves.TabIndex = 151
        Me.cbxJueves.Text = "Jueves"
        Me.cbxJueves.UseVisualStyleBackColor = True
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEntrada.Location = New System.Drawing.Point(133, 89)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.Size = New System.Drawing.Size(179, 22)
        Me.dtpEntrada.TabIndex = 145
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
        'rtxtObservacion
        '
        Me.rtxtObservacion.Location = New System.Drawing.Point(133, 205)
        Me.rtxtObservacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtObservacion.MaxLength = 200
        Me.rtxtObservacion.Name = "rtxtObservacion"
        Me.rtxtObservacion.Size = New System.Drawing.Size(423, 37)
        Me.rtxtObservacion.TabIndex = 144
        Me.rtxtObservacion.Text = ""
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
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(15, 345)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(928, 322)
        Me.gbxbusqueda.TabIndex = 114
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR HORARIO DE TRABAJO"
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
        Me.lbltotal.Size = New System.Drawing.Size(245, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE HORARIOS DE TRABAJO"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(79, 21)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(843, 22)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(15, 23)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Nombre"
        '
        'M_Horarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 678)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxRegistrar)
        Me.KeyPreview = True
        Me.Name = "M_Horarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios de Trabajo"
        Me.gbxRegistrar.ResumeLayout(False)
        Me.gbxRegistrar.PerformLayout()
        Me.gbxDiasSemanales.ResumeLayout(False)
        Me.gbxDiasSemanales.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
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
End Class
