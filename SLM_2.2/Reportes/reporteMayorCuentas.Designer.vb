<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteMayorCuentas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtCuenta = New System.Windows.Forms.RadioButton()
        Me.rbtRango = New System.Windows.Forms.RadioButton()
        Me.rbtCuentas = New System.Windows.Forms.RadioButton()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtRango2 = New System.Windows.Forms.TextBox()
        Me.txtRango1 = New System.Windows.Forms.TextBox()
        Me.txtCuentas = New System.Windows.Forms.TextBox()
        Me.crvMayor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1133, 47)
        Me.Panel1.TabIndex = 2
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGenerar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Location = New System.Drawing.Point(6, 554)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(190, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mayor de Cuentas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtCuentas)
        Me.GroupBox1.Controls.Add(Me.txtRango1)
        Me.GroupBox1.Controls.Add(Me.txtRango2)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.rbtCuentas)
        Me.GroupBox1.Controls.Add(Me.rbtRango)
        Me.GroupBox1.Controls.Add(Me.rbtCuenta)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 610)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de reporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(57, 29)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(139, 20)
        Me.dtpDesde.TabIndex = 4
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(57, 55)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(139, 20)
        Me.dtpHasta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.crvMayor)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(897, 610)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'rbtCuenta
        '
        Me.rbtCuenta.AutoSize = True
        Me.rbtCuenta.Location = New System.Drawing.Point(6, 93)
        Me.rbtCuenta.Name = "rbtCuenta"
        Me.rbtCuenta.Size = New System.Drawing.Size(59, 17)
        Me.rbtCuenta.TabIndex = 7
        Me.rbtCuenta.TabStop = True
        Me.rbtCuenta.Text = "Cuenta"
        Me.rbtCuenta.UseVisualStyleBackColor = True
        '
        'rbtRango
        '
        Me.rbtRango.AutoSize = True
        Me.rbtRango.Location = New System.Drawing.Point(6, 142)
        Me.rbtRango.Name = "rbtRango"
        Me.rbtRango.Size = New System.Drawing.Size(114, 17)
        Me.rbtRango.TabIndex = 8
        Me.rbtRango.TabStop = True
        Me.rbtRango.Text = "Rango de Cuentas"
        Me.rbtRango.UseVisualStyleBackColor = True
        '
        'rbtCuentas
        '
        Me.rbtCuentas.AutoSize = True
        Me.rbtCuentas.Location = New System.Drawing.Point(6, 192)
        Me.rbtCuentas.Name = "rbtCuentas"
        Me.rbtCuentas.Size = New System.Drawing.Size(153, 17)
        Me.rbtCuentas.TabIndex = 9
        Me.rbtCuentas.TabStop = True
        Me.rbtCuentas.Text = "Cuentas(separadas por "","")"
        Me.rbtCuentas.UseVisualStyleBackColor = True
        Me.rbtCuentas.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(6, 116)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(190, 20)
        Me.txtCuenta.TabIndex = 10
        '
        'txtRango2
        '
        Me.txtRango2.Enabled = False
        Me.txtRango2.Location = New System.Drawing.Point(102, 166)
        Me.txtRango2.Name = "txtRango2"
        Me.txtRango2.Size = New System.Drawing.Size(94, 20)
        Me.txtRango2.TabIndex = 11
        '
        'txtRango1
        '
        Me.txtRango1.Enabled = False
        Me.txtRango1.Location = New System.Drawing.Point(5, 166)
        Me.txtRango1.Name = "txtRango1"
        Me.txtRango1.Size = New System.Drawing.Size(94, 20)
        Me.txtRango1.TabIndex = 12
        '
        'txtCuentas
        '
        Me.txtCuentas.Enabled = False
        Me.txtCuentas.Location = New System.Drawing.Point(6, 215)
        Me.txtCuentas.Name = "txtCuentas"
        Me.txtCuentas.Size = New System.Drawing.Size(190, 20)
        Me.txtCuentas.TabIndex = 13
        Me.txtCuentas.Visible = False
        '
        'crvMayor
        '
        Me.crvMayor.ActiveViewIndex = -1
        Me.crvMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvMayor.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvMayor.DisplayStatusBar = False
        Me.crvMayor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvMayor.Location = New System.Drawing.Point(3, 16)
        Me.crvMayor.Name = "crvMayor"
        Me.crvMayor.Size = New System.Drawing.Size(891, 591)
        Me.crvMayor.TabIndex = 0
        Me.crvMayor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 579)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'reporteMayorCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1131, 674)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "reporteMayorCuentas"
        Me.Text = "Mayor de Cuentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCuentas As TextBox
    Friend WithEvents txtRango1 As TextBox
    Friend WithEvents txtRango2 As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents rbtCuentas As RadioButton
    Friend WithEvents rbtRango As RadioButton
    Friend WithEvents rbtCuenta As RadioButton
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents crvMayor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As Button
End Class
