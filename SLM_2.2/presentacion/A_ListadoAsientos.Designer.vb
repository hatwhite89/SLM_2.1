<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoAsientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListadoAsientos))
        Me.gbxAsientos = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dtAsientos = New System.Windows.Forms.DataGridView()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.btnIngresarAsiento = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoCCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteCCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosPorAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeAsientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxAsientos.SuspendLayout()
        CType(Me.dtAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxAsientos
        '
        Me.gbxAsientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxAsientos.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxAsientos.Controls.Add(Me.btnCancelar)
        Me.gbxAsientos.Controls.Add(Me.dtAsientos)
        Me.gbxAsientos.Controls.Add(Me.txtCod)
        Me.gbxAsientos.Controls.Add(Me.lblCod)
        Me.gbxAsientos.Location = New System.Drawing.Point(12, 66)
        Me.gbxAsientos.Name = "gbxAsientos"
        Me.gbxAsientos.Size = New System.Drawing.Size(694, 364)
        Me.gbxAsientos.TabIndex = 0
        Me.gbxAsientos.TabStop = False
        Me.gbxAsientos.Text = "Asientos Contables"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(329, 26)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(20, 18)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "X"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dtAsientos
        '
        Me.dtAsientos.AllowUserToAddRows = False
        Me.dtAsientos.AllowUserToDeleteRows = False
        Me.dtAsientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtAsientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtAsientos.BackgroundColor = System.Drawing.Color.White
        Me.dtAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtAsientos.GridColor = System.Drawing.Color.White
        Me.dtAsientos.Location = New System.Drawing.Point(6, 57)
        Me.dtAsientos.Name = "dtAsientos"
        Me.dtAsientos.ReadOnly = True
        Me.dtAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtAsientos.Size = New System.Drawing.Size(682, 301)
        Me.dtAsientos.TabIndex = 2
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(88, 26)
        Me.txtCod.MaxLength = 8
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(235, 20)
        Me.txtCod.TabIndex = 1
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(17, 29)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(65, 13)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Nro. Asiento"
        '
        'btnIngresarAsiento
        '
        Me.btnIngresarAsiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngresarAsiento.BackColor = System.Drawing.Color.Yellow
        Me.btnIngresarAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresarAsiento.Location = New System.Drawing.Point(575, 8)
        Me.btnIngresarAsiento.Name = "btnIngresarAsiento"
        Me.btnIngresarAsiento.Size = New System.Drawing.Size(131, 23)
        Me.btnIngresarAsiento.TabIndex = 4
        Me.btnIngresarAsiento.Text = "Ingresar Asiento Manual"
        Me.btnIngresarAsiento.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 437)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnIngresarAsiento)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asientos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(718, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoCCToolStripMenuItem, Me.ReporteCCToolStripMenuItem, Me.IngresosPorAreaToolStripMenuItem, Me.InformeAsientosToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menú"
        '
        'MantenimientoCCToolStripMenuItem
        '
        Me.MantenimientoCCToolStripMenuItem.Name = "MantenimientoCCToolStripMenuItem"
        Me.MantenimientoCCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MantenimientoCCToolStripMenuItem.Text = "Mantenimiento CC"
        '
        'ReporteCCToolStripMenuItem
        '
        Me.ReporteCCToolStripMenuItem.Name = "ReporteCCToolStripMenuItem"
        Me.ReporteCCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReporteCCToolStripMenuItem.Text = "Reporte CC"
        '
        'IngresosPorAreaToolStripMenuItem
        '
        Me.IngresosPorAreaToolStripMenuItem.Name = "IngresosPorAreaToolStripMenuItem"
        Me.IngresosPorAreaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IngresosPorAreaToolStripMenuItem.Text = "Ingresos por Area"
        '
        'InformeAsientosToolStripMenuItem
        '
        Me.InformeAsientosToolStripMenuItem.Name = "InformeAsientosToolStripMenuItem"
        Me.InformeAsientosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformeAsientosToolStripMenuItem.Text = "Informe Asientos"
        '
        'A_ListadoAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gbxAsientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_ListadoAsientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Asientos"
        Me.gbxAsientos.ResumeLayout(False)
        Me.gbxAsientos.PerformLayout()
        CType(Me.dtAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxAsientos As GroupBox
    Friend WithEvents dtAsientos As DataGridView
    Friend WithEvents txtCod As TextBox
    Friend WithEvents lblCod As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnIngresarAsiento As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoCCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteCCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresosPorAreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeAsientosToolStripMenuItem As ToolStripMenuItem
End Class
