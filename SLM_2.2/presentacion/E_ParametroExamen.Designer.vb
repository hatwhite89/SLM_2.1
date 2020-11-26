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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Resultados = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxNoCalc
        '
        Me.cbxNoCalc.AutoSize = True
        Me.cbxNoCalc.Location = New System.Drawing.Point(89, 105)
        Me.cbxNoCalc.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxNoCalc.Name = "cbxNoCalc"
        Me.cbxNoCalc.Size = New System.Drawing.Size(149, 17)
        Me.cbxNoCalc.TabIndex = 127
        Me.cbxNoCalc.Text = "No Cal. Fecha de Entrega"
        Me.cbxNoCalc.UseVisualStyleBackColor = True
        '
        'txtcomentarioUnidad
        '
        Me.txtcomentarioUnidad.Location = New System.Drawing.Point(202, 37)
        Me.txtcomentarioUnidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcomentarioUnidad.Name = "txtcomentarioUnidad"
        Me.txtcomentarioUnidad.ReadOnly = True
        Me.txtcomentarioUnidad.Size = New System.Drawing.Size(117, 20)
        Me.txtcomentarioUnidad.TabIndex = 125
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(37, 78)
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
        Me.btnbuscarUnidad.Location = New System.Drawing.Point(83, 37)
        Me.btnbuscarUnidad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscarUnidad.Name = "btnbuscarUnidad"
        Me.btnbuscarUnidad.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarUnidad.TabIndex = 123
        Me.btnbuscarUnidad.Text = "..."
        Me.btnbuscarUnidad.UseVisualStyleBackColor = False
        '
        'txtcodigoUnidad
        '
        Me.txtcodigoUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoUnidad.Location = New System.Drawing.Point(131, 37)
        Me.txtcodigoUnidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoUnidad.MaxLength = 20
        Me.txtcodigoUnidad.Name = "txtcodigoUnidad"
        Me.txtcodigoUnidad.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoUnidad.TabIndex = 122
        '
        'lbldireccion1
        '
        Me.lbldireccion1.AutoSize = True
        Me.lbldireccion1.Location = New System.Drawing.Point(284, 16)
        Me.lbldireccion1.Name = "lbldireccion1"
        Me.lbldireccion1.Size = New System.Drawing.Size(63, 13)
        Me.lbldireccion1.TabIndex = 130
        Me.lbldireccion1.Text = "Descripción"
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(369, 13)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtdescripcion.MaxLength = 100
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(314, 51)
        Me.rtxtdescripcion.TabIndex = 131
        Me.rtxtdescripcion.Text = ""
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(37, 15)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 129
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(83, 13)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtcodigo.TabIndex = 128
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Breve"
        '
        'txtBreve
        '
        Me.txtBreve.Location = New System.Drawing.Point(369, 75)
        Me.txtBreve.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBreve.MaxLength = 50
        Me.txtBreve.Name = "txtBreve"
        Me.txtBreve.Size = New System.Drawing.Size(101, 20)
        Me.txtBreve.TabIndex = 133
        Me.txtBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxRequiereDet
        '
        Me.cbxRequiereDet.AutoSize = True
        Me.cbxRequiereDet.Location = New System.Drawing.Point(88, 74)
        Me.cbxRequiereDet.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxRequiereDet.Name = "cbxRequiereDet"
        Me.cbxRequiereDet.Size = New System.Drawing.Size(105, 17)
        Me.cbxRequiereDet.TabIndex = 135
        Me.cbxRequiereDet.Text = "Requiere Detalle"
        Me.cbxRequiereDet.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(562, 4)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 139
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(403, 4)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 138
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(486, 4)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 137
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(638, 4)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 136
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'dgbtabla
        '
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbtabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgbtabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posiblesResultados})
        Me.dgbtabla.Location = New System.Drawing.Point(17, 219)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(685, 256)
        Me.dgbtabla.TabIndex = 140
        '
        'posiblesResultados
        '
        Me.posiblesResultados.HeaderText = "Posibles Resultados"
        Me.posiblesResultados.MinimumWidth = 6
        Me.posiblesResultados.Name = "posiblesResultados"
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.cbxRequiereDet)
        Me.Panel1.Controls.Add(Me.txtBreve)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtcomentarioUnidad)
        Me.Panel1.Controls.Add(Me.cbxNoCalc)
        Me.Panel1.Controls.Add(Me.txtcodigoUnidad)
        Me.Panel1.Controls.Add(Me.btnbuscarUnidad)
        Me.Panel1.Controls.Add(Me.rtxtdescripcion)
        Me.Panel1.Controls.Add(Me.lbldireccion1)
        Me.Panel1.Controls.Add(Me.txtcodigo)
        Me.Panel1.Controls.Add(Me.lbltipo)
        Me.Panel1.Controls.Add(Me.lblcodigo)
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 144)
        Me.Panel1.TabIndex = 143
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 144
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Resultados
        '
        Me.Resultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Resultados.BackColor = System.Drawing.Color.AliceBlue
        Me.Resultados.Location = New System.Drawing.Point(12, 201)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(695, 279)
        Me.Resultados.TabIndex = 145
        Me.Resultados.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnnuevo)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnguardar)
        Me.Panel2.Controls.Add(Me.btnmodificar)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(718, 37)
        Me.Panel2.TabIndex = 146
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(10, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Parámetro de Examen"
        '
        'E_ParametroExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.lblcodeUnidad)
        Me.Controls.Add(Me.dgbtabla)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Resultados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "E_ParametroExamen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetro de Examen"
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Resultados As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
End Class
