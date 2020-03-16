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
        Me.cbxNoCalc.Location = New System.Drawing.Point(92, 114)
        Me.cbxNoCalc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxNoCalc.Name = "cbxNoCalc"
        Me.cbxNoCalc.Size = New System.Drawing.Size(149, 17)
        Me.cbxNoCalc.TabIndex = 127
        Me.cbxNoCalc.Text = "No Cal. Fecha de Entrega"
        Me.cbxNoCalc.UseVisualStyleBackColor = True
        '
        'txtcomentarioUnidad
        '
        Me.txtcomentarioUnidad.Location = New System.Drawing.Point(214, 84)
        Me.txtcomentarioUnidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcomentarioUnidad.Name = "txtcomentarioUnidad"
        Me.txtcomentarioUnidad.ReadOnly = True
        Me.txtcomentarioUnidad.Size = New System.Drawing.Size(117, 20)
        Me.txtcomentarioUnidad.TabIndex = 125
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(49, 84)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(41, 13)
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
        Me.btnbuscarUnidad.Location = New System.Drawing.Point(100, 84)
        Me.btnbuscarUnidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarUnidad.Name = "btnbuscarUnidad"
        Me.btnbuscarUnidad.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarUnidad.TabIndex = 123
        Me.btnbuscarUnidad.Text = "..."
        Me.btnbuscarUnidad.UseVisualStyleBackColor = False
        '
        'txtcodigoUnidad
        '
        Me.txtcodigoUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoUnidad.Location = New System.Drawing.Point(144, 84)
        Me.txtcodigoUnidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoUnidad.MaxLength = 20
        Me.txtcodigoUnidad.Name = "txtcodigoUnidad"
        Me.txtcodigoUnidad.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoUnidad.TabIndex = 122
        '
        'lbldireccion1
        '
        Me.lbldireccion1.AutoSize = True
        Me.lbldireccion1.Location = New System.Drawing.Point(302, 25)
        Me.lbldireccion1.Name = "lbldireccion1"
        Me.lbldireccion1.Size = New System.Drawing.Size(63, 13)
        Me.lbldireccion1.TabIndex = 130
        Me.lbldireccion1.Text = "Descripción"
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(380, 21)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtdescripcion.MaxLength = 100
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(327, 51)
        Me.rtxtdescripcion.TabIndex = 131
        Me.rtxtdescripcion.Text = ""
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(49, 24)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 129
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(94, 22)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtcodigo.TabIndex = 128
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(341, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Breve"
        '
        'txtBreve
        '
        Me.txtBreve.Location = New System.Drawing.Point(380, 84)
        Me.txtBreve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBreve.MaxLength = 50
        Me.txtBreve.Name = "txtBreve"
        Me.txtBreve.Size = New System.Drawing.Size(101, 20)
        Me.txtBreve.TabIndex = 133
        Me.txtBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxRequiereDet
        '
        Me.cbxRequiereDet.AutoSize = True
        Me.cbxRequiereDet.Location = New System.Drawing.Point(92, 55)
        Me.cbxRequiereDet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxRequiereDet.Name = "cbxRequiereDet"
        Me.cbxRequiereDet.Size = New System.Drawing.Size(105, 17)
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
        Me.btnmodificar.Location = New System.Drawing.Point(183, 466)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
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
        Me.btnnuevo.Location = New System.Drawing.Point(24, 466)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
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
        Me.btnguardar.Location = New System.Drawing.Point(107, 466)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
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
        Me.btncancelar.Location = New System.Drawing.Point(259, 466)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 136
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'dgbtabla
        '
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posiblesResultados})
        Me.dgbtabla.Location = New System.Drawing.Point(24, 158)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(683, 291)
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
        Me.lblcodeUnidad.Location = New System.Drawing.Point(10, 85)
        Me.lblcodeUnidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeUnidad.Name = "lblcodeUnidad"
        Me.lblcodeUnidad.Size = New System.Drawing.Size(0, 13)
        Me.lblcodeUnidad.TabIndex = 141
        Me.lblcodeUnidad.Visible = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(21, 25)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 142
        '
        'E_ParametroExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "E_ParametroExamen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
