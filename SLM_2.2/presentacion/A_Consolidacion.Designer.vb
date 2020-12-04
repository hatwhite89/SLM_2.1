<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_Consolidacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Consolidacion))
        Me.dtTransferencia = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbxTransferencias = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxTransferencia = New System.Windows.Forms.ComboBox()
        Me.txtCodBanco = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnBanco = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxConsolidacion = New System.Windows.Forms.GroupBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.dtExcel = New System.Windows.Forms.DataGridView()
        Me.check2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dtTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTransferencias.SuspendLayout()
        Me.gbxConsolidacion.SuspendLayout()
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTransferencia
        '
        Me.dtTransferencia.AllowUserToAddRows = False
        Me.dtTransferencia.AllowUserToDeleteRows = False
        Me.dtTransferencia.BackgroundColor = System.Drawing.Color.White
        Me.dtTransferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTransferencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check})
        Me.dtTransferencia.Location = New System.Drawing.Point(6, 80)
        Me.dtTransferencia.MultiSelect = False
        Me.dtTransferencia.Name = "dtTransferencia"
        Me.dtTransferencia.ReadOnly = True
        Me.dtTransferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtTransferencia.Size = New System.Drawing.Size(458, 461)
        Me.dtTransferencia.TabIndex = 0
        '
        'check
        '
        Me.check.Frozen = True
        Me.check.HeaderText = "Check"
        Me.check.Name = "check"
        Me.check.ReadOnly = True
        Me.check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'gbxTransferencias
        '
        Me.gbxTransferencias.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxTransferencias.Controls.Add(Me.Button2)
        Me.gbxTransferencias.Controls.Add(Me.dtTransferencia)
        Me.gbxTransferencias.Controls.Add(Me.Button1)
        Me.gbxTransferencias.Location = New System.Drawing.Point(12, 139)
        Me.gbxTransferencias.Name = "gbxTransferencias"
        Me.gbxTransferencias.Size = New System.Drawing.Size(470, 547)
        Me.gbxTransferencias.TabIndex = 1
        Me.gbxTransferencias.TabStop = False
        Me.gbxTransferencias.Text = "Transferencias Registradas SLM"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(96, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 52)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Suprimir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 52)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbxTransferencia
        '
        Me.cbxTransferencia.FormattingEnabled = True
        Me.cbxTransferencia.Items.AddRange(New Object() {"Depositos Bancarios", "Cheques"})
        Me.cbxTransferencia.Location = New System.Drawing.Point(107, 19)
        Me.cbxTransferencia.Name = "cbxTransferencia"
        Me.cbxTransferencia.Size = New System.Drawing.Size(176, 21)
        Me.cbxTransferencia.TabIndex = 11
        '
        'txtCodBanco
        '
        Me.txtCodBanco.Enabled = False
        Me.txtCodBanco.Location = New System.Drawing.Point(336, 20)
        Me.txtCodBanco.Name = "txtCodBanco"
        Me.txtCodBanco.Size = New System.Drawing.Size(36, 20)
        Me.txtCodBanco.TabIndex = 10
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackColor = System.Drawing.Color.Salmon
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(799, 9)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Cancelar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Location = New System.Drawing.Point(718, 9)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'btnBanco
        '
        Me.btnBanco.Location = New System.Drawing.Point(519, 19)
        Me.btnBanco.Name = "btnBanco"
        Me.btnBanco.Size = New System.Drawing.Size(24, 23)
        Me.btnBanco.TabIndex = 5
        Me.btnBanco.Text = "..."
        Me.btnBanco.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transferencia:"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(378, 21)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(135, 20)
        Me.txtBanco.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco:"
        '
        'gbxConsolidacion
        '
        Me.gbxConsolidacion.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxConsolidacion.Controls.Add(Me.btnProcesar)
        Me.gbxConsolidacion.Controls.Add(Me.dtExcel)
        Me.gbxConsolidacion.Controls.Add(Me.btnImportar)
        Me.gbxConsolidacion.Location = New System.Drawing.Point(488, 139)
        Me.gbxConsolidacion.Name = "gbxConsolidacion"
        Me.gbxConsolidacion.Size = New System.Drawing.Size(470, 547)
        Me.gbxConsolidacion.TabIndex = 2
        Me.gbxConsolidacion.TabStop = False
        Me.gbxConsolidacion.Text = "Transferencias de Banco"
        '
        'btnProcesar
        '
        Me.btnProcesar.BackColor = System.Drawing.Color.Gold
        Me.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcesar.Location = New System.Drawing.Point(96, 23)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(88, 52)
        Me.btnProcesar.TabIndex = 4
        Me.btnProcesar.Text = "Suprimir"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'dtExcel
        '
        Me.dtExcel.AllowUserToAddRows = False
        Me.dtExcel.AllowUserToDeleteRows = False
        Me.dtExcel.BackgroundColor = System.Drawing.Color.White
        Me.dtExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtExcel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check2})
        Me.dtExcel.Location = New System.Drawing.Point(6, 83)
        Me.dtExcel.MultiSelect = False
        Me.dtExcel.Name = "dtExcel"
        Me.dtExcel.ReadOnly = True
        Me.dtExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtExcel.Size = New System.Drawing.Size(458, 458)
        Me.dtExcel.TabIndex = 0
        '
        'check2
        '
        Me.check2.Frozen = True
        Me.check2.HeaderText = "Check"
        Me.check2.Name = "check2"
        Me.check2.ReadOnly = True
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.Location = New System.Drawing.Point(6, 23)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(84, 52)
        Me.btnImportar.TabIndex = 3
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnConsultar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(966, 43)
        Me.Panel1.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Consolidación de Cuentas"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrar.Location = New System.Drawing.Point(880, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cbxTransferencia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodBanco)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBanco)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(940, 84)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(336, 48)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(207, 20)
        Me.dtpHasta.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Desde:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(107, 48)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(180, 20)
        Me.dtpDesde.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(877, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'A_Consolidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(966, 689)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbxConsolidacion)
        Me.Controls.Add(Me.gbxTransferencias)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_Consolidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidación"
        CType(Me.dtTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTransferencias.ResumeLayout(False)
        Me.gbxConsolidacion.ResumeLayout(False)
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtTransferencia As DataGridView
    Friend WithEvents gbxTransferencias As GroupBox
    Friend WithEvents btnBanco As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxConsolidacion As GroupBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents dtExcel As DataGridView
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtCodBanco As TextBox
    Friend WithEvents cbxTransferencia As ComboBox
    Friend WithEvents check As DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents check2 As DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
End Class
