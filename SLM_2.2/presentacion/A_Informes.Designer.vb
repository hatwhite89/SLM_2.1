<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Informes))
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCodExamen = New System.Windows.Forms.Label()
        Me.lblCodSubArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreSubArea = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarExamen = New System.Windows.Forms.Button()
        Me.txtNombreExamen = New System.Windows.Forms.TextBox()
        Me.txtCodExamen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkExamenes = New System.Windows.Forms.CheckBox()
        Me.chkPeriodoTiempo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarSubArea = New System.Windows.Forms.Button()
        Me.txtSubArea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEjecutar.BackColor = System.Drawing.Color.White
        Me.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEjecutar.Location = New System.Drawing.Point(475, 13)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 2
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelar.Location = New System.Drawing.Point(556, 13)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generar Vista de Ordenes de Trabajo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblCodExamen)
        Me.GroupBox2.Controls.Add(Me.lblCodSubArea)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.txtNombreSubArea)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpHasta)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnBuscarExamen)
        Me.GroupBox2.Controls.Add(Me.txtNombreExamen)
        Me.GroupBox2.Controls.Add(Me.txtCodExamen)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.chkExamenes)
        Me.GroupBox2.Controls.Add(Me.chkPeriodoTiempo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnBuscarSubArea)
        Me.GroupBox2.Controls.Add(Me.txtSubArea)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpDesde)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(619, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de consulta"
        '
        'lblCodExamen
        '
        Me.lblCodExamen.AutoSize = True
        Me.lblCodExamen.Enabled = False
        Me.lblCodExamen.Location = New System.Drawing.Point(373, 144)
        Me.lblCodExamen.Name = "lblCodExamen"
        Me.lblCodExamen.Size = New System.Drawing.Size(64, 13)
        Me.lblCodExamen.TabIndex = 21
        Me.lblCodExamen.Text = "CodExamen"
        Me.lblCodExamen.Visible = False
        '
        'lblCodSubArea
        '
        Me.lblCodSubArea.AutoSize = True
        Me.lblCodSubArea.Enabled = False
        Me.lblCodSubArea.Location = New System.Drawing.Point(373, 126)
        Me.lblCodSubArea.Name = "lblCodSubArea"
        Me.lblCodSubArea.Size = New System.Drawing.Size(67, 13)
        Me.lblCodSubArea.TabIndex = 20
        Me.lblCodSubArea.Text = "CodSubArea"
        Me.lblCodSubArea.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "yyyy/MM/d"
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(63, 144)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'txtNombreSubArea
        '
        Me.txtNombreSubArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreSubArea.Enabled = False
        Me.txtNombreSubArea.Location = New System.Drawing.Point(169, 54)
        Me.txtNombreSubArea.Name = "txtNombreSubArea"
        Me.txtNombreSubArea.Size = New System.Drawing.Size(250, 20)
        Me.txtNombreSubArea.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(465, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "yyyy/MM/d"
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(227, 119)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtpHasta.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Desde:"
        '
        'btnBuscarExamen
        '
        Me.btnBuscarExamen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarExamen.Location = New System.Drawing.Point(425, 82)
        Me.btnBuscarExamen.Name = "btnBuscarExamen"
        Me.btnBuscarExamen.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarExamen.TabIndex = 11
        Me.btnBuscarExamen.Text = "..."
        Me.btnBuscarExamen.UseVisualStyleBackColor = True
        '
        'txtNombreExamen
        '
        Me.txtNombreExamen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreExamen.Enabled = False
        Me.txtNombreExamen.Location = New System.Drawing.Point(169, 84)
        Me.txtNombreExamen.Name = "txtNombreExamen"
        Me.txtNombreExamen.Size = New System.Drawing.Size(250, 20)
        Me.txtNombreExamen.TabIndex = 10
        '
        'txtCodExamen
        '
        Me.txtCodExamen.Enabled = False
        Me.txtCodExamen.Location = New System.Drawing.Point(63, 84)
        Me.txtCodExamen.Name = "txtCodExamen"
        Me.txtCodExamen.Size = New System.Drawing.Size(100, 20)
        Me.txtCodExamen.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Exámen:"
        '
        'chkExamenes
        '
        Me.chkExamenes.AutoSize = True
        Me.chkExamenes.Location = New System.Drawing.Point(63, 19)
        Me.chkExamenes.Name = "chkExamenes"
        Me.chkExamenes.Size = New System.Drawing.Size(116, 17)
        Me.chkExamenes.TabIndex = 7
        Me.chkExamenes.Text = "Exámenes y Fecha"
        Me.chkExamenes.UseVisualStyleBackColor = True
        '
        'chkPeriodoTiempo
        '
        Me.chkPeriodoTiempo.AutoSize = True
        Me.chkPeriodoTiempo.Location = New System.Drawing.Point(185, 20)
        Me.chkPeriodoTiempo.Name = "chkPeriodoTiempo"
        Me.chkPeriodoTiempo.Size = New System.Drawing.Size(169, 17)
        Me.chkPeriodoTiempo.TabIndex = 6
        Me.chkPeriodoTiempo.Text = "SubÁrea y Período de Tiempo"
        Me.chkPeriodoTiempo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filtrar por:"
        '
        'btnBuscarSubArea
        '
        Me.btnBuscarSubArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarSubArea.Enabled = False
        Me.btnBuscarSubArea.Location = New System.Drawing.Point(425, 53)
        Me.btnBuscarSubArea.Name = "btnBuscarSubArea"
        Me.btnBuscarSubArea.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarSubArea.TabIndex = 4
        Me.btnBuscarSubArea.Text = "..."
        Me.btnBuscarSubArea.UseVisualStyleBackColor = True
        '
        'txtSubArea
        '
        Me.txtSubArea.Enabled = False
        Me.txtSubArea.Location = New System.Drawing.Point(63, 54)
        Me.txtSubArea.Name = "txtSubArea"
        Me.txtSubArea.Size = New System.Drawing.Size(100, 20)
        Me.txtSubArea.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SubArea: "
        '
        'dtpDesde
        '
        Me.dtpDesde.CustomFormat = "yyyy/MM/d"
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(63, 118)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(100, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEjecutar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 45)
        Me.Panel1.TabIndex = 2
        '
        'A_Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 238)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "A_Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes de Ordenes de Trabajo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombreSubArea As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarExamen As Button
    Friend WithEvents txtNombreExamen As TextBox
    Friend WithEvents txtCodExamen As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkExamenes As CheckBox
    Friend WithEvents chkPeriodoTiempo As CheckBox
    Friend WithEvents btnBuscarSubArea As Button
    Friend WithEvents txtSubArea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblCodSubArea As Label
    Friend WithEvents lblCodExamen As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
