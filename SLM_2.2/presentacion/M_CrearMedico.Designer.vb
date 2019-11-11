<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_CrearMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_CrearMedico))
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.lblcorreo2 = New System.Windows.Forms.Label()
        Me.btnbuscarEspecialidad = New System.Windows.Forms.Button()
        Me.txtcodigoEspecialidad = New System.Windows.Forms.TextBox()
        Me.lblespecialidad = New System.Windows.Forms.Label()
        Me.txtnombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(145, 36)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 88
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(86, 36)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 87
        Me.lblcodigo.Text = "Código"
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(402, 122)
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(179, 22)
        Me.txtcelular.TabIndex = 92
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Celular"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(402, 94)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(179, 22)
        Me.txttelefono.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Teléfono"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(144, 92)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(179, 22)
        Me.txtcorreo.TabIndex = 94
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(86, 92)
        Me.lblcorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(51, 17)
        Me.lblcorreo.TabIndex = 93
        Me.lblcorreo.Text = "Correo"
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(145, 120)
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.Size = New System.Drawing.Size(179, 22)
        Me.txtcorreo2.TabIndex = 96
        '
        'lblcorreo2
        '
        Me.lblcorreo2.AutoSize = True
        Me.lblcorreo2.Location = New System.Drawing.Point(74, 123)
        Me.lblcorreo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo2.Name = "lblcorreo2"
        Me.lblcorreo2.Size = New System.Drawing.Size(63, 17)
        Me.lblcorreo2.TabIndex = 95
        Me.lblcorreo2.Text = "Correo 2"
        '
        'btnbuscarEspecialidad
        '
        Me.btnbuscarEspecialidad.BackColor = System.Drawing.Color.White
        Me.btnbuscarEspecialidad.BackgroundImage = CType(resources.GetObject("btnbuscarEspecialidad.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarEspecialidad.FlatAppearance.BorderSize = 0
        Me.btnbuscarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarEspecialidad.Location = New System.Drawing.Point(143, 148)
        Me.btnbuscarEspecialidad.Name = "btnbuscarEspecialidad"
        Me.btnbuscarEspecialidad.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarEspecialidad.TabIndex = 105
        Me.btnbuscarEspecialidad.UseVisualStyleBackColor = False
        '
        'txtcodigoEspecialidad
        '
        Me.txtcodigoEspecialidad.Location = New System.Drawing.Point(198, 148)
        Me.txtcodigoEspecialidad.Name = "txtcodigoEspecialidad"
        Me.txtcodigoEspecialidad.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoEspecialidad.TabIndex = 104
        '
        'lblespecialidad
        '
        Me.lblespecialidad.AutoSize = True
        Me.lblespecialidad.Location = New System.Drawing.Point(48, 151)
        Me.lblespecialidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblespecialidad.Name = "lblespecialidad"
        Me.lblespecialidad.Size = New System.Drawing.Size(88, 17)
        Me.lblespecialidad.TabIndex = 103
        Me.lblespecialidad.Text = "Especialidad"
        '
        'txtnombreCompleto
        '
        Me.txtnombreCompleto.Location = New System.Drawing.Point(145, 64)
        Me.txtnombreCompleto.Name = "txtnombreCompleto"
        Me.txtnombreCompleto.Size = New System.Drawing.Size(435, 22)
        Me.txtnombreCompleto.TabIndex = 107
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(17, 67)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(121, 17)
        Me.lblnombre.TabIndex = 106
        Me.lblnombre.Text = "Nombre Completo"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(476, 195)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 109
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(198, 195)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 35)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(51, 195)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 35)
        Me.btnnuevo.TabIndex = 110
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtnombreCompleto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.txtcelular)
        Me.GroupBox1.Controls.Add(Me.btnbuscarEspecialidad)
        Me.GroupBox1.Controls.Add(Me.lblcorreo2)
        Me.GroupBox1.Controls.Add(Me.txtcodigoEspecialidad)
        Me.GroupBox1.Controls.Add(Me.txtcorreo2)
        Me.GroupBox1.Controls.Add(Me.lblespecialidad)
        Me.GroupBox1.Controls.Add(Me.lblcorreo)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 260)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRAR MÉDICO"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(334, 195)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 35)
        Me.btnmodificar.TabIndex = 111
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcantidad)
        Me.GroupBox2.Controls.Add(Me.dgbtabla)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(613, 302)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR MÉDICO"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(177, 36)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(192, 22)
        Me.txtnombre.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Nombre"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnbuscar.Location = New System.Drawing.Point(375, 30)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(78, 35)
        Me.btnbuscar.TabIndex = 113
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'dgbtabla
        '
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre})
        Me.dgbtabla.Location = New System.Drawing.Point(39, 90)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(520, 150)
        Me.dgbtabla.TabIndex = 22
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 122
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 215
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "TOTAL DE CLIENTES"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(402, 260)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'M_CrearMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 622)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "M_CrearMedico"
        Me.Text = "Médico: Crear"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents lblcorreo2 As Label
    Friend WithEvents btnbuscarEspecialidad As Button
    Friend WithEvents txtcodigoEspecialidad As TextBox
    Friend WithEvents lblespecialidad As Label
    Friend WithEvents txtnombreCompleto As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
End Class
