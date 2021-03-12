<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_PlanillaCalculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_PlanillaCalculo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDiasFaltados = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIHSS = New System.Windows.Forms.TextBox()
        Me.txtDescripcionPlanilla = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodPlanilla = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.dtData = New System.Windows.Forms.DataGridView()
        Me.Empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SueldoBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adicional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_Extra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasFaltados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IHSS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetISR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Embargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prest_Cofinter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdelantoSueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrestamoRAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetOptica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpVecinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAPVolunt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetRAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SueldoNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.chkDiasFaltados)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIHSS)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCodPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Empleado"
        '
        'chkDiasFaltados
        '
        Me.chkDiasFaltados.AutoSize = True
        Me.chkDiasFaltados.Location = New System.Drawing.Point(80, 54)
        Me.chkDiasFaltados.Name = "chkDiasFaltados"
        Me.chkDiasFaltados.Size = New System.Drawing.Size(168, 17)
        Me.chkDiasFaltados.TabIndex = 16
        Me.chkDiasFaltados.Text = "Ingreso Manual Días Faltados"
        Me.chkDiasFaltados.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(577, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "IHSS:"
        '
        'txtIHSS
        '
        Me.txtIHSS.Location = New System.Drawing.Point(614, 22)
        Me.txtIHSS.Name = "txtIHSS"
        Me.txtIHSS.Size = New System.Drawing.Size(100, 20)
        Me.txtIHSS.TabIndex = 14
        '
        'txtDescripcionPlanilla
        '
        Me.txtDescripcionPlanilla.Enabled = False
        Me.txtDescripcionPlanilla.Location = New System.Drawing.Point(295, 22)
        Me.txtDescripcionPlanilla.Name = "txtDescripcionPlanilla"
        Me.txtDescripcionPlanilla.Size = New System.Drawing.Size(252, 20)
        Me.txtDescripcionPlanilla.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Descrip. Planilla:"
        '
        'txtCodPlanilla
        '
        Me.txtCodPlanilla.Enabled = False
        Me.txtCodPlanilla.Location = New System.Drawing.Point(80, 22)
        Me.txtCodPlanilla.Name = "txtCodPlanilla"
        Me.txtCodPlanilla.Size = New System.Drawing.Size(119, 20)
        Me.txtCodPlanilla.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cód. Planilla:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox2.Controls.Add(Me.btnExportarExcel)
        Me.GroupBox2.Controls.Add(Me.dtData)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(819, 373)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportarExcel.BackColor = System.Drawing.Color.Green
        Me.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarExcel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExportarExcel.Location = New System.Drawing.Point(720, 9)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(93, 23)
        Me.btnExportarExcel.TabIndex = 4
        Me.btnExportarExcel.Text = "Exportar Excel"
        Me.btnExportarExcel.UseVisualStyleBackColor = False
        '
        'dtData
        '
        Me.dtData.AllowUserToAddRows = False
        Me.dtData.AllowUserToDeleteRows = False
        Me.dtData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtData.BackgroundColor = System.Drawing.Color.White
        Me.dtData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empleado, Me.SueldoBase, Me.Adicional, Me.T_Extra, Me.DiasFaltados, Me.TotalDev, Me.IHSS, Me.RetISR, Me.Embargos, Me.Prest_Cofinter, Me.AdelantoSueldo, Me.PrestamoRAP, Me.RetOptica, Me.RetPrestamo, Me.ImpVecinal, Me.RAPVolunt, Me.RetRAP, Me.SueldoNeto, Me.CodEmpleado})
        Me.dtData.Location = New System.Drawing.Point(6, 35)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(807, 332)
        Me.dtData.TabIndex = 0
        '
        'Empleado
        '
        Me.Empleado.Frozen = True
        Me.Empleado.HeaderText = "Nombre"
        Me.Empleado.Name = "Empleado"
        Me.Empleado.ReadOnly = True
        '
        'SueldoBase
        '
        Me.SueldoBase.HeaderText = "Sueldo Base"
        Me.SueldoBase.Name = "SueldoBase"
        Me.SueldoBase.ReadOnly = True
        '
        'Adicional
        '
        Me.Adicional.HeaderText = "Adicional (+)"
        Me.Adicional.Name = "Adicional"
        '
        'T_Extra
        '
        Me.T_Extra.HeaderText = "T. Extra"
        Me.T_Extra.Name = "T_Extra"
        '
        'DiasFaltados
        '
        Me.DiasFaltados.HeaderText = "Días Faltados"
        Me.DiasFaltados.Name = "DiasFaltados"
        '
        'TotalDev
        '
        Me.TotalDev.HeaderText = "Total Devengado"
        Me.TotalDev.Name = "TotalDev"
        Me.TotalDev.ReadOnly = True
        '
        'IHSS
        '
        Me.IHSS.HeaderText = "I.H.S.S."
        Me.IHSS.Name = "IHSS"
        '
        'RetISR
        '
        Me.RetISR.HeaderText = "Retención ISR"
        Me.RetISR.Name = "RetISR"
        '
        'Embargos
        '
        Me.Embargos.HeaderText = "Embargos"
        Me.Embargos.Name = "Embargos"
        '
        'Prest_Cofinter
        '
        Me.Prest_Cofinter.HeaderText = "Prest. Cofinter"
        Me.Prest_Cofinter.Name = "Prest_Cofinter"
        '
        'AdelantoSueldo
        '
        Me.AdelantoSueldo.HeaderText = "Adelantos Sueldo"
        Me.AdelantoSueldo.Name = "AdelantoSueldo"
        '
        'PrestamoRAP
        '
        Me.PrestamoRAP.HeaderText = "Prestamo RAP"
        Me.PrestamoRAP.Name = "PrestamoRAP"
        '
        'RetOptica
        '
        Me.RetOptica.HeaderText = "Retención Optica"
        Me.RetOptica.Name = "RetOptica"
        '
        'RetPrestamo
        '
        Me.RetPrestamo.HeaderText = "Ret. Prestamo"
        Me.RetPrestamo.Name = "RetPrestamo"
        '
        'ImpVecinal
        '
        Me.ImpVecinal.HeaderText = "Imp. Vecinal"
        Me.ImpVecinal.Name = "ImpVecinal"
        '
        'RAPVolunt
        '
        Me.RAPVolunt.HeaderText = "RAP Volunt."
        Me.RAPVolunt.Name = "RAPVolunt"
        '
        'RetRAP
        '
        Me.RetRAP.HeaderText = "Ret. RAP"
        Me.RetRAP.Name = "RetRAP"
        '
        'SueldoNeto
        '
        Me.SueldoNeto.HeaderText = "Sueldo Neto"
        Me.SueldoNeto.Name = "SueldoNeto"
        Me.SueldoNeto.ReadOnly = True
        '
        'CodEmpleado
        '
        Me.CodEmpleado.HeaderText = "CodEmpleado"
        Me.CodEmpleado.Name = "CodEmpleado"
        Me.CodEmpleado.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 47)
        Me.Panel1.TabIndex = 2
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(739, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(93, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.BackColor = System.Drawing.Color.Yellow
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.Location = New System.Drawing.Point(642, 10)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(93, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar Vista"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Location = New System.Drawing.Point(543, 10)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(93, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar Planilla"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cálculo de Planilla"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-1, 516)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 25)
        Me.Panel2.TabIndex = 3
        '
        'A_PlanillaCalculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(843, 529)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_PlanillaCalculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de Planilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtData As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents txtDescripcionPlanilla As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodPlanilla As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIHSS As TextBox
    Friend WithEvents chkDiasFaltados As CheckBox
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents Empleado As DataGridViewTextBoxColumn
    Friend WithEvents SueldoBase As DataGridViewTextBoxColumn
    Friend WithEvents Adicional As DataGridViewTextBoxColumn
    Friend WithEvents T_Extra As DataGridViewTextBoxColumn
    Friend WithEvents DiasFaltados As DataGridViewTextBoxColumn
    Friend WithEvents TotalDev As DataGridViewTextBoxColumn
    Friend WithEvents IHSS As DataGridViewTextBoxColumn
    Friend WithEvents RetISR As DataGridViewTextBoxColumn
    Friend WithEvents Embargos As DataGridViewTextBoxColumn
    Friend WithEvents Prest_Cofinter As DataGridViewTextBoxColumn
    Friend WithEvents AdelantoSueldo As DataGridViewTextBoxColumn
    Friend WithEvents PrestamoRAP As DataGridViewTextBoxColumn
    Friend WithEvents RetOptica As DataGridViewTextBoxColumn
    Friend WithEvents RetPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents ImpVecinal As DataGridViewTextBoxColumn
    Friend WithEvents RAPVolunt As DataGridViewTextBoxColumn
    Friend WithEvents RetRAP As DataGridViewTextBoxColumn
    Friend WithEvents SueldoNeto As DataGridViewTextBoxColumn
    Friend WithEvents CodEmpleado As DataGridViewTextBoxColumn
End Class
