<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Depreciacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Depreciacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSede = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtDiaria = New System.Windows.Forms.RadioButton()
        Me.rbtMensual = New System.Windows.Forms.RadioButton()
        Me.rbtAnual = New System.Windows.Forms.RadioButton()
        Me.dtpFechaCalculo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpCreacion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorResidual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtDepreciacion = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Depre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepreciacionAcumulada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAnual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtSede)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rbtDiaria)
        Me.GroupBox1.Controls.Add(Me.rbtMensual)
        Me.GroupBox1.Controls.Add(Me.rbtAnual)
        Me.GroupBox1.Controls.Add(Me.dtpFechaCalculo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpCreacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtValorResidual)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 477)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Activo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(190, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Seleccionar tipo de Depreciación"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSede
        '
        Me.txtSede.Enabled = False
        Me.txtSede.Location = New System.Drawing.Point(294, 59)
        Me.txtSede.Name = "txtSede"
        Me.txtSede.Size = New System.Drawing.Size(92, 20)
        Me.txtSede.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(256, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Sede:"
        '
        'txtTipo
        '
        Me.txtTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTipo.Location = New System.Drawing.Point(85, 58)
        Me.txtTipo.MaxLength = 50
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(165, 20)
        Me.txtTipo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Tipo:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(186, 269)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(86, 13)
        Me.lblTipo.TabIndex = 20
        Me.lblTipo.Text = "Seleccion Depre"
        Me.lblTipo.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(85, 85)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(334, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Descripción:"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(85, 32)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(63, 20)
        Me.txtCod.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Código:"
        '
        'rbtDiaria
        '
        Me.rbtDiaria.AutoSize = True
        Me.rbtDiaria.Location = New System.Drawing.Point(13, 301)
        Me.rbtDiaria.Name = "rbtDiaria"
        Me.rbtDiaria.Size = New System.Drawing.Size(118, 17)
        Me.rbtDiaria.TabIndex = 8
        Me.rbtDiaria.TabStop = True
        Me.rbtDiaria.Text = "Depreciación Diaria"
        Me.rbtDiaria.UseVisualStyleBackColor = True
        '
        'rbtMensual
        '
        Me.rbtMensual.AutoSize = True
        Me.rbtMensual.Location = New System.Drawing.Point(13, 278)
        Me.rbtMensual.Name = "rbtMensual"
        Me.rbtMensual.Size = New System.Drawing.Size(131, 17)
        Me.rbtMensual.TabIndex = 7
        Me.rbtMensual.TabStop = True
        Me.rbtMensual.Text = "Depreciación Mensual"
        Me.rbtMensual.UseVisualStyleBackColor = True
        '
        'rbtAnual
        '
        Me.rbtAnual.AutoSize = True
        Me.rbtAnual.Location = New System.Drawing.Point(13, 255)
        Me.rbtAnual.Name = "rbtAnual"
        Me.rbtAnual.Size = New System.Drawing.Size(118, 17)
        Me.rbtAnual.TabIndex = 6
        Me.rbtAnual.TabStop = True
        Me.rbtAnual.Text = "Depreciación Anual"
        Me.rbtAnual.UseVisualStyleBackColor = True
        '
        'dtpFechaCalculo
        '
        Me.dtpFechaCalculo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCalculo.Location = New System.Drawing.Point(109, 192)
        Me.dtpFechaCalculo.Name = "dtpFechaCalculo"
        Me.dtpFechaCalculo.Size = New System.Drawing.Size(108, 20)
        Me.dtpFechaCalculo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha a Calcular:"
        '
        'dtpCreacion
        '
        Me.dtpCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCreacion.Location = New System.Drawing.Point(109, 166)
        Me.dtpCreacion.Name = "dtpCreacion"
        Me.dtpCreacion.Size = New System.Drawing.Size(107, 20)
        Me.dtpCreacion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Creación:"
        '
        'txtValorResidual
        '
        Me.txtValorResidual.Location = New System.Drawing.Point(85, 140)
        Me.txtValorResidual.MaxLength = 10
        Me.txtValorResidual.Name = "txtValorResidual"
        Me.txtValorResidual.Size = New System.Drawing.Size(131, 20)
        Me.txtValorResidual.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor Residual:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(85, 114)
        Me.txtCosto.MaxLength = 10
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(131, 20)
        Me.txtCosto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costo:"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(721, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 28)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(627, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 28)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(817, 10)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(90, 28)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Cancelar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.White
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Location = New System.Drawing.Point(435, 10)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(90, 28)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.dtDepreciacion)
        Me.GroupBox2.Location = New System.Drawing.Point(449, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 477)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Depreciación"
        '
        'dtDepreciacion
        '
        Me.dtDepreciacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtDepreciacion.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDepreciacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.Depre, Me.DepreciacionAcumulada, Me.ValorAnual})
        Me.dtDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtDepreciacion.Location = New System.Drawing.Point(3, 16)
        Me.dtDepreciacion.Name = "dtDepreciacion"
        Me.dtDepreciacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtDepreciacion.Size = New System.Drawing.Size(452, 458)
        Me.dtDepreciacion.TabIndex = 13
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        '
        'Depre
        '
        Me.Depre.HeaderText = "Depreciación"
        Me.Depre.Name = "Depre"
        '
        'DepreciacionAcumulada
        '
        Me.DepreciacionAcumulada.HeaderText = "Depreciación Acumulada"
        Me.DepreciacionAcumulada.Name = "DepreciacionAcumulada"
        '
        'ValorAnual
        '
        Me.ValorAnual.HeaderText = "Valor Anual"
        Me.ValorAnual.Name = "ValorAnual"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnExportar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 52)
        Me.Panel1.TabIndex = 13
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Location = New System.Drawing.Point(531, 10)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(90, 28)
        Me.btnExportar.TabIndex = 15
        Me.btnExportar.Text = "Exportar Excel"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(267, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Depreciación de Activos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(917, 22)
        Me.StatusStrip1.TabIndex = 14
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_Depreciacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 559)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "A_Depreciacion"
        Me.Text = "Depreciación de Activo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtDiaria As RadioButton
    Friend WithEvents rbtMensual As RadioButton
    Friend WithEvents rbtAnual As RadioButton
    Friend WithEvents dtpFechaCalculo As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpCreacion As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValorResidual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtDepreciacion As DataGridView
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents Depre As DataGridViewTextBoxColumn
    Friend WithEvents DepreciacionAcumulada As DataGridViewTextBoxColumn
    Friend WithEvents ValorAnual As DataGridViewTextBoxColumn
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtSede As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExportar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
