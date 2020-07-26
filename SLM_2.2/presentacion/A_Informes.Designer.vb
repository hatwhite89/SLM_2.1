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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCodExamen = New System.Windows.Forms.Label()
        Me.lblCodSubArea = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnEjecutar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEjecutar.Location = New System.Drawing.Point(492, 19)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 2
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(573, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
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
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(654, 226)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de consulta"
        '
        'lblCodExamen
        '
        Me.lblCodExamen.AutoSize = True
        Me.lblCodExamen.Location = New System.Drawing.Point(400, 197)
        Me.lblCodExamen.Name = "lblCodExamen"
        Me.lblCodExamen.Size = New System.Drawing.Size(64, 13)
        Me.lblCodExamen.TabIndex = 21
        Me.lblCodExamen.Text = "CodExamen"
        '
        'lblCodSubArea
        '
        Me.lblCodSubArea.AutoSize = True
        Me.lblCodSubArea.Location = New System.Drawing.Point(400, 179)
        Me.lblCodSubArea.Name = "lblCodSubArea"
        Me.lblCodSubArea.Size = New System.Drawing.Size(67, 13)
        Me.lblCodSubArea.TabIndex = 20
        Me.lblCodSubArea.Text = "CodSubArea"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(63, 190)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(261, 81)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Fecha Especifica"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtNombreSubArea
        '
        Me.txtNombreSubArea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreSubArea.Enabled = False
        Me.txtNombreSubArea.Location = New System.Drawing.Point(169, 33)
        Me.txtNombreSubArea.Name = "txtNombreSubArea"
        Me.txtNombreSubArea.Size = New System.Drawing.Size(285, 20)
        Me.txtNombreSubArea.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(498, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(174, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(227, 152)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtpHasta.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Desde:"
        '
        'btnBuscarExamen
        '
        Me.btnBuscarExamen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarExamen.Location = New System.Drawing.Point(460, 114)
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
        Me.txtNombreExamen.Location = New System.Drawing.Point(169, 116)
        Me.txtNombreExamen.Name = "txtNombreExamen"
        Me.txtNombreExamen.Size = New System.Drawing.Size(285, 20)
        Me.txtNombreExamen.TabIndex = 10
        '
        'txtCodExamen
        '
        Me.txtCodExamen.Location = New System.Drawing.Point(63, 116)
        Me.txtCodExamen.Name = "txtCodExamen"
        Me.txtCodExamen.Size = New System.Drawing.Size(100, 20)
        Me.txtCodExamen.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Exámen:"
        '
        'chkExamenes
        '
        Me.chkExamenes.AutoSize = True
        Me.chkExamenes.Location = New System.Drawing.Point(63, 80)
        Me.chkExamenes.Name = "chkExamenes"
        Me.chkExamenes.Size = New System.Drawing.Size(75, 17)
        Me.chkExamenes.TabIndex = 7
        Me.chkExamenes.Text = "Exámenes"
        Me.chkExamenes.UseVisualStyleBackColor = True
        '
        'chkPeriodoTiempo
        '
        Me.chkPeriodoTiempo.AutoSize = True
        Me.chkPeriodoTiempo.Location = New System.Drawing.Point(144, 80)
        Me.chkPeriodoTiempo.Name = "chkPeriodoTiempo"
        Me.chkPeriodoTiempo.Size = New System.Drawing.Size(111, 17)
        Me.chkPeriodoTiempo.TabIndex = 6
        Me.chkPeriodoTiempo.Text = "Periodo de tiempo"
        Me.chkPeriodoTiempo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filtrar por:"
        '
        'btnBuscarSubArea
        '
        Me.btnBuscarSubArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarSubArea.Location = New System.Drawing.Point(460, 32)
        Me.btnBuscarSubArea.Name = "btnBuscarSubArea"
        Me.btnBuscarSubArea.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarSubArea.TabIndex = 4
        Me.btnBuscarSubArea.Text = "..."
        Me.btnBuscarSubArea.UseVisualStyleBackColor = True
        '
        'txtSubArea
        '
        Me.txtSubArea.Location = New System.Drawing.Point(63, 33)
        Me.txtSubArea.Name = "txtSubArea"
        Me.txtSubArea.Size = New System.Drawing.Size(100, 20)
        Me.txtSubArea.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SubArea: "
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(63, 151)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(100, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'A_Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 303)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "A_Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes de Ordenes de Trabajo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarSubArea As Button
    Friend WithEvents txtSubArea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblCodSubArea As Label
    Friend WithEvents lblCodExamen As Label
End Class
