<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_ParametroExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_ParametroExamen))
        Me.cbxNoCalc = New System.Windows.Forms.CheckBox()
        Me.txtcomentarioUnidad = New System.Windows.Forms.TextBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btnbuscarUnidad = New System.Windows.Forms.Button()
        Me.txtcodigoUnidad = New System.Windows.Forms.TextBox()
        Me.lbldireccion1 = New System.Windows.Forms.Label()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBreve = New System.Windows.Forms.TextBox()
        Me.cbxRequiereDet = New System.Windows.Forms.CheckBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.posiblesResultados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblcodeUnidad = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxNoCalc
        '
        Me.cbxNoCalc.AutoSize = True
        Me.cbxNoCalc.Location = New System.Drawing.Point(123, 140)
        Me.cbxNoCalc.Name = "cbxNoCalc"
        Me.cbxNoCalc.Size = New System.Drawing.Size(193, 21)
        Me.cbxNoCalc.TabIndex = 127
        Me.cbxNoCalc.Text = "No Cal. Fecha de Entrega"
        Me.cbxNoCalc.UseVisualStyleBackColor = True
        '
        'txtcomentarioUnidad
        '
        Me.txtcomentarioUnidad.Location = New System.Drawing.Point(272, 103)
        Me.txtcomentarioUnidad.Name = "txtcomentarioUnidad"
        Me.txtcomentarioUnidad.ReadOnly = True
        Me.txtcomentarioUnidad.Size = New System.Drawing.Size(169, 22)
        Me.txtcomentarioUnidad.TabIndex = 125
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(57, 104)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(53, 17)
        Me.lbltipo.TabIndex = 124
        Me.lbltipo.Text = "Unidad"
        '
        'btnbuscarUnidad
        '
        Me.btnbuscarUnidad.BackColor = System.Drawing.Color.White
        Me.btnbuscarUnidad.BackgroundImage = CType(resources.GetObject("btnbuscarUnidad.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarUnidad.FlatAppearance.BorderSize = 0
        Me.btnbuscarUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarUnidad.Location = New System.Drawing.Point(123, 103)
        Me.btnbuscarUnidad.Name = "btnbuscarUnidad"
        Me.btnbuscarUnidad.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarUnidad.TabIndex = 123
        Me.btnbuscarUnidad.UseVisualStyleBackColor = False
        '
        'txtcodigoUnidad
        '
        Me.txtcodigoUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoUnidad.Location = New System.Drawing.Point(178, 103)
        Me.txtcodigoUnidad.Name = "txtcodigoUnidad"
        Me.txtcodigoUnidad.Size = New System.Drawing.Size(88, 22)
        Me.txtcodigoUnidad.TabIndex = 122
        '
        'lbldireccion1
        '
        Me.lbldireccion1.AutoSize = True
        Me.lbldireccion1.Location = New System.Drawing.Point(28, 64)
        Me.lbldireccion1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion1.Name = "lbldireccion1"
        Me.lbldireccion1.Size = New System.Drawing.Size(82, 17)
        Me.lbldireccion1.TabIndex = 130
        Me.lbldireccion1.Text = "Descripción"
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(121, 56)
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(525, 37)
        Me.rtxtdescripcion.TabIndex = 131
        Me.rtxtdescripcion.Text = ""
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(58, 29)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 129
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(123, 26)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(133, 22)
        Me.txtcodigo.TabIndex = 128
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(462, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Breve"
        '
        'txtBreve
        '
        Me.txtBreve.Location = New System.Drawing.Point(513, 104)
        Me.txtBreve.Name = "txtBreve"
        Me.txtBreve.Size = New System.Drawing.Size(133, 22)
        Me.txtBreve.TabIndex = 133
        Me.txtBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxRequiereDet
        '
        Me.cbxRequiereDet.AutoSize = True
        Me.cbxRequiereDet.Location = New System.Drawing.Point(354, 27)
        Me.cbxRequiereDet.Name = "cbxRequiereDet"
        Me.cbxRequiereDet.Size = New System.Drawing.Size(136, 21)
        Me.cbxRequiereDet.TabIndex = 135
        Me.cbxRequiereDet.Text = "Requiere Detalle"
        Me.cbxRequiereDet.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(354, 558)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 35)
        Me.btnmodificar.TabIndex = 139
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(72, 558)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 35)
        Me.btnnuevo.TabIndex = 138
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(218, 558)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 35)
        Me.btnguardar.TabIndex = 137
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(496, 558)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 136
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'dgbtabla
        '
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posiblesResultados})
        Me.dgbtabla.Location = New System.Drawing.Point(39, 174)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(600, 358)
        Me.dgbtabla.TabIndex = 140
        '
        'posiblesResultados
        '
        Me.posiblesResultados.HeaderText = "Posibles Resultados"
        Me.posiblesResultados.MinimumWidth = 6
        Me.posiblesResultados.Name = "posiblesResultados"
        Me.posiblesResultados.Width = 206
        '
        'lblcodeUnidad
        '
        Me.lblcodeUnidad.AutoSize = True
        Me.lblcodeUnidad.Location = New System.Drawing.Point(13, 105)
        Me.lblcodeUnidad.Name = "lblcodeUnidad"
        Me.lblcodeUnidad.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeUnidad.TabIndex = 141
        Me.lblcodeUnidad.Visible = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(28, 31)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 17)
        Me.lblcode.TabIndex = 142
        '
        'E_ParametroExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 622)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.lblcodeUnidad)
        Me.Controls.Add(Me.dgbtabla)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.cbxRequiereDet)
        Me.Controls.Add(Me.txtBreve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbldireccion1)
        Me.Controls.Add(Me.rtxtdescripcion)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.cbxNoCalc)
        Me.Controls.Add(Me.txtcomentarioUnidad)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.btnbuscarUnidad)
        Me.Controls.Add(Me.txtcodigoUnidad)
        Me.Name = "E_ParametroExamen"
        Me.Text = "Parámetro de Examen"
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxNoCalc As CheckBox
    Friend WithEvents txtcomentarioUnidad As TextBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents btnbuscarUnidad As Button
    Friend WithEvents txtcodigoUnidad As TextBox
    Friend WithEvents lbldireccion1 As Label
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBreve As TextBox
    Friend WithEvents cbxRequiereDet As CheckBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents posiblesResultados As DataGridViewTextBoxColumn
    Friend WithEvents lblcodeUnidad As Label
    Friend WithEvents lblcode As Label
End Class
