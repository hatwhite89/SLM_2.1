<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_ReporteriaTalentoHumano
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_ReporteriaTalentoHumano))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxReporte = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbxHorario = New System.Windows.Forms.ComboBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.txtnombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblcodeEmpleado = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 47)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(714, 14)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Location = New System.Drawing.Point(637, 14)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
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
        Me.Label1.Size = New System.Drawing.Size(286, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reportes Talento Humano"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.cmbxReporte)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 234)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección de reporte"
        '
        'cmbxReporte
        '
        Me.cmbxReporte.FormattingEnabled = True
        Me.cmbxReporte.Items.AddRange(New Object() {"Reporte Personal Activo", "Reporte Personal Inactivo", "Reporte Capacitaciones ", "Reporte Permisos", "Reporte Horarios de Trabajo"})
        Me.cmbxReporte.Location = New System.Drawing.Point(17, 38)
        Me.cmbxReporte.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxReporte.Name = "cmbxReporte"
        Me.cmbxReporte.Size = New System.Drawing.Size(222, 21)
        Me.cmbxReporte.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(247, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.cmbxHorario)
        Me.GroupBox2.Controls.Add(Me.lblHorario)
        Me.GroupBox2.Controls.Add(Me.txtnombreEmpleado)
        Me.GroupBox2.Controls.Add(Me.lblcodeEmpleado)
        Me.GroupBox2.Controls.Add(Me.lblEmpleado)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox2.Controls.Add(Me.lblFechaFinal)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox2.Controls.Add(Me.lblFechaInicial)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 216)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de busqueda"
        '
        'cmbxHorario
        '
        Me.cmbxHorario.FormattingEnabled = True
        Me.cmbxHorario.Location = New System.Drawing.Point(88, 110)
        Me.cmbxHorario.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbxHorario.Name = "cmbxHorario"
        Me.cmbxHorario.Size = New System.Drawing.Size(151, 21)
        Me.cmbxHorario.TabIndex = 8
        Me.cmbxHorario.Visible = False
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(34, 106)
        Me.lblHorario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(41, 13)
        Me.lblHorario.TabIndex = 7
        Me.lblHorario.Text = "Horario"
        Me.lblHorario.Visible = False
        '
        'txtnombreEmpleado
        '
        Me.txtnombreEmpleado.Location = New System.Drawing.Point(88, 46)
        Me.txtnombreEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombreEmpleado.Name = "txtnombreEmpleado"
        Me.txtnombreEmpleado.ReadOnly = True
        Me.txtnombreEmpleado.Size = New System.Drawing.Size(151, 20)
        Me.txtnombreEmpleado.TabIndex = 6
        Me.txtnombreEmpleado.Visible = False
        '
        'lblcodeEmpleado
        '
        Me.lblcodeEmpleado.AutoSize = True
        Me.lblcodeEmpleado.Location = New System.Drawing.Point(22, 37)
        Me.lblcodeEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeEmpleado.Name = "lblcodeEmpleado"
        Me.lblcodeEmpleado.Size = New System.Drawing.Size(54, 13)
        Me.lblcodeEmpleado.TabIndex = 5
        Me.lblcodeEmpleado.Text = "Empleado"
        Me.lblcodeEmpleado.Visible = False
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(15, 51)
        Me.lblEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(54, 13)
        Me.lblEmpleado.TabIndex = 4
        Me.lblEmpleado.Text = "Empleado"
        Me.lblEmpleado.Visible = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(88, 137)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(162, 20)
        Me.dtpFechaFinal.TabIndex = 3
        Me.dtpFechaFinal.Visible = False
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(15, 137)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(62, 13)
        Me.lblFechaFinal.TabIndex = 2
        Me.lblFechaFinal.Text = "Fecha Final"
        Me.lblFechaFinal.Visible = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(88, 87)
        Me.dtpFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(162, 20)
        Me.dtpFechaInicial.TabIndex = 1
        Me.dtpFechaInicial.Visible = False
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(15, 91)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaInicial.TabIndex = 0
        Me.lblFechaInicial.Text = "Fecha Incial"
        Me.lblFechaInicial.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox3.Location = New System.Drawing.Point(270, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 456)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reporte"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 16)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(512, 437)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'M_ReporteriaTalentoHumano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "M_ReporteriaTalentoHumano"
        Me.Text = "Reporteria Talento Humano"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmbxReporte As ComboBox
    Friend WithEvents txtnombreEmpleado As TextBox
    Friend WithEvents lblcodeEmpleado As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lblFechaInicial As Label
    Friend WithEvents cmbxHorario As ComboBox
    Friend WithEvents lblHorario As Label
End Class
