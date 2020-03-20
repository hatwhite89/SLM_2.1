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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rbtDiaria = New System.Windows.Forms.RadioButton()
        Me.rbtMensual = New System.Windows.Forms.RadioButton()
        Me.rbtAnual = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaCalculo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpCreacion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorResidual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtDepreciacion = New System.Windows.Forms.DataGridView()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Depre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepreciacionAcumulada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAnual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtDepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.rbtDiaria)
        Me.GroupBox1.Controls.Add(Me.rbtMensual)
        Me.GroupBox1.Controls.Add(Me.rbtAnual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFechaCalculo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpCreacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtValorResidual)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 522)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Activo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(292, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(292, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtDiaria
        '
        Me.rbtDiaria.AutoSize = True
        Me.rbtDiaria.Location = New System.Drawing.Point(16, 236)
        Me.rbtDiaria.Name = "rbtDiaria"
        Me.rbtDiaria.Size = New System.Drawing.Size(118, 17)
        Me.rbtDiaria.TabIndex = 11
        Me.rbtDiaria.TabStop = True
        Me.rbtDiaria.Text = "Depreciación Diaria"
        Me.rbtDiaria.UseVisualStyleBackColor = True
        '
        'rbtMensual
        '
        Me.rbtMensual.AutoSize = True
        Me.rbtMensual.Location = New System.Drawing.Point(16, 213)
        Me.rbtMensual.Name = "rbtMensual"
        Me.rbtMensual.Size = New System.Drawing.Size(131, 17)
        Me.rbtMensual.TabIndex = 10
        Me.rbtMensual.TabStop = True
        Me.rbtMensual.Text = "Depreciación Mensual"
        Me.rbtMensual.UseVisualStyleBackColor = True
        '
        'rbtAnual
        '
        Me.rbtAnual.AutoSize = True
        Me.rbtAnual.Location = New System.Drawing.Point(16, 190)
        Me.rbtAnual.Name = "rbtAnual"
        Me.rbtAnual.Size = New System.Drawing.Size(118, 17)
        Me.rbtAnual.TabIndex = 9
        Me.rbtAnual.TabStop = True
        Me.rbtAnual.Text = "Depreciación Anual"
        Me.rbtAnual.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Depreciación"
        '
        'dtpFechaCalculo
        '
        Me.dtpFechaCalculo.Location = New System.Drawing.Point(108, 120)
        Me.dtpFechaCalculo.Name = "dtpFechaCalculo"
        Me.dtpFechaCalculo.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCalculo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha a Calcular:"
        '
        'dtpCreacion
        '
        Me.dtpCreacion.Location = New System.Drawing.Point(108, 94)
        Me.dtpCreacion.Name = "dtpCreacion"
        Me.dtpCreacion.Size = New System.Drawing.Size(200, 20)
        Me.dtpCreacion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Creación:"
        '
        'txtValorResidual
        '
        Me.txtValorResidual.Location = New System.Drawing.Point(108, 68)
        Me.txtValorResidual.Name = "txtValorResidual"
        Me.txtValorResidual.Size = New System.Drawing.Size(200, 20)
        Me.txtValorResidual.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor Residual:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(108, 42)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(200, 20)
        Me.txtCosto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costo de Activo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtDepreciacion)
        Me.GroupBox2.Location = New System.Drawing.Point(343, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 522)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Depreciación"
        '
        'dtDepreciacion
        '
        Me.dtDepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDepreciacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.Depre, Me.DepreciacionAcumulada, Me.ValorAnual})
        Me.dtDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtDepreciacion.Location = New System.Drawing.Point(3, 16)
        Me.dtDepreciacion.Name = "dtDepreciacion"
        Me.dtDepreciacion.Size = New System.Drawing.Size(439, 503)
        Me.dtDepreciacion.TabIndex = 0
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
        'A_Depreciacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "A_Depreciacion"
        Me.Text = "Depreciación de Activo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtDepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rbtDiaria As RadioButton
    Friend WithEvents rbtMensual As RadioButton
    Friend WithEvents rbtAnual As RadioButton
    Friend WithEvents Label5 As Label
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
End Class
