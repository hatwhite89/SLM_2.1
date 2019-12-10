<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_MenuLaboratorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_MenuLaboratorio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblhojaTrabajo = New System.Windows.Forms.Label()
        Me.lblmedico = New System.Windows.Forms.Label()
        Me.btnHojaTrabajo = New System.Windows.Forms.Button()
        Me.btnMedico = New System.Windows.Forms.Button()
        Me.lblexamenes = New System.Windows.Forms.Label()
        Me.btnExamenes = New System.Windows.Forms.Button()
        Me.lblentregaResultado = New System.Windows.Forms.Label()
        Me.btnEntregaResultado = New System.Windows.Forms.Button()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.lblordentrabajo = New System.Windows.Forms.Label()
        Me.btnOrdenTrab = New System.Windows.Forms.Button()
        Me.btnSede = New System.Windows.Forms.Button()
        Me.lblSede = New System.Windows.Forms.Label()
        Me.btnSucursal = New System.Windows.Forms.Button()
        Me.lblsucursal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSucursal)
        Me.GroupBox1.Controls.Add(Me.lblsucursal)
        Me.GroupBox1.Controls.Add(Me.btnSede)
        Me.GroupBox1.Controls.Add(Me.lblSede)
        Me.GroupBox1.Controls.Add(Me.lblhojaTrabajo)
        Me.GroupBox1.Controls.Add(Me.lblmedico)
        Me.GroupBox1.Controls.Add(Me.btnHojaTrabajo)
        Me.GroupBox1.Controls.Add(Me.btnMedico)
        Me.GroupBox1.Controls.Add(Me.lblexamenes)
        Me.GroupBox1.Controls.Add(Me.btnExamenes)
        Me.GroupBox1.Controls.Add(Me.lblentregaResultado)
        Me.GroupBox1.Controls.Add(Me.btnEntregaResultado)
        Me.GroupBox1.Controls.Add(Me.lblpaciente)
        Me.GroupBox1.Controls.Add(Me.btnCliente)
        Me.GroupBox1.Controls.Add(Me.lblordentrabajo)
        Me.GroupBox1.Controls.Add(Me.btnOrdenTrab)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 411)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menú Módulo Laboratorio"
        '
        'lblhojaTrabajo
        '
        Me.lblhojaTrabajo.Location = New System.Drawing.Point(24, 223)
        Me.lblhojaTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblhojaTrabajo.Name = "lblhojaTrabajo"
        Me.lblhojaTrabajo.Size = New System.Drawing.Size(69, 51)
        Me.lblhojaTrabajo.TabIndex = 13
        Me.lblhojaTrabajo.Text = "Hoja Trabajo Lab."
        Me.lblhojaTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmedico
        '
        Me.lblmedico.AutoSize = True
        Me.lblmedico.Location = New System.Drawing.Point(406, 103)
        Me.lblmedico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedico.Name = "lblmedico"
        Me.lblmedico.Size = New System.Drawing.Size(60, 17)
        Me.lblmedico.TabIndex = 15
        Me.lblmedico.Text = "Médicos"
        '
        'btnHojaTrabajo
        '
        Me.btnHojaTrabajo.BackgroundImage = CType(resources.GetObject("btnHojaTrabajo.BackgroundImage"), System.Drawing.Image)
        Me.btnHojaTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHojaTrabajo.FlatAppearance.BorderSize = 0
        Me.btnHojaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHojaTrabajo.Location = New System.Drawing.Point(31, 154)
        Me.btnHojaTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHojaTrabajo.Name = "btnHojaTrabajo"
        Me.btnHojaTrabajo.Size = New System.Drawing.Size(61, 64)
        Me.btnHojaTrabajo.TabIndex = 12
        Me.btnHojaTrabajo.UseVisualStyleBackColor = True
        '
        'btnMedico
        '
        Me.btnMedico.BackgroundImage = CType(resources.GetObject("btnMedico.BackgroundImage"), System.Drawing.Image)
        Me.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMedico.FlatAppearance.BorderSize = 0
        Me.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedico.Location = New System.Drawing.Point(392, 28)
        Me.btnMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMedico.Name = "btnMedico"
        Me.btnMedico.Size = New System.Drawing.Size(80, 70)
        Me.btnMedico.TabIndex = 14
        Me.btnMedico.UseVisualStyleBackColor = True
        '
        'lblexamenes
        '
        Me.lblexamenes.AutoSize = True
        Me.lblexamenes.Location = New System.Drawing.Point(116, 100)
        Me.lblexamenes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblexamenes.Name = "lblexamenes"
        Me.lblexamenes.Size = New System.Drawing.Size(73, 17)
        Me.lblexamenes.TabIndex = 13
        Me.lblexamenes.Text = "Exámenes"
        '
        'btnExamenes
        '
        Me.btnExamenes.BackgroundImage = CType(resources.GetObject("btnExamenes.BackgroundImage"), System.Drawing.Image)
        Me.btnExamenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExamenes.FlatAppearance.BorderSize = 0
        Me.btnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExamenes.Location = New System.Drawing.Point(111, 23)
        Me.btnExamenes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExamenes.Name = "btnExamenes"
        Me.btnExamenes.Size = New System.Drawing.Size(80, 75)
        Me.btnExamenes.TabIndex = 12
        Me.btnExamenes.UseVisualStyleBackColor = True
        '
        'lblentregaResultado
        '
        Me.lblentregaResultado.Location = New System.Drawing.Point(292, 100)
        Me.lblentregaResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblentregaResultado.Name = "lblentregaResultado"
        Me.lblentregaResultado.Size = New System.Drawing.Size(91, 44)
        Me.lblentregaResultado.TabIndex = 11
        Me.lblentregaResultado.Text = "Entrega Resultados"
        Me.lblentregaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEntregaResultado
        '
        Me.btnEntregaResultado.BackgroundImage = CType(resources.GetObject("btnEntregaResultado.BackgroundImage"), System.Drawing.Image)
        Me.btnEntregaResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEntregaResultado.FlatAppearance.BorderSize = 0
        Me.btnEntregaResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregaResultado.Location = New System.Drawing.Point(303, 28)
        Me.btnEntregaResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEntregaResultado.Name = "btnEntregaResultado"
        Me.btnEntregaResultado.Size = New System.Drawing.Size(80, 70)
        Me.btnEntregaResultado.TabIndex = 10
        Me.btnEntregaResultado.UseVisualStyleBackColor = True
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Location = New System.Drawing.Point(31, 100)
        Me.lblpaciente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(70, 17)
        Me.lblpaciente.TabIndex = 9
        Me.lblpaciente.Text = "Pacientes"
        '
        'btnCliente
        '
        Me.btnCliente.BackgroundImage = CType(resources.GetObject("btnCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Location = New System.Drawing.Point(19, 26)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(84, 72)
        Me.btnCliente.TabIndex = 8
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'lblordentrabajo
        '
        Me.lblordentrabajo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblordentrabajo.Location = New System.Drawing.Point(210, 100)
        Me.lblordentrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblordentrabajo.Name = "lblordentrabajo"
        Me.lblordentrabajo.Size = New System.Drawing.Size(72, 44)
        Me.lblordentrabajo.TabIndex = 7
        Me.lblordentrabajo.Text = "Orden de Trabajo"
        Me.lblordentrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrdenTrab
        '
        Me.btnOrdenTrab.BackgroundImage = CType(resources.GetObject("btnOrdenTrab.BackgroundImage"), System.Drawing.Image)
        Me.btnOrdenTrab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrdenTrab.FlatAppearance.BorderSize = 0
        Me.btnOrdenTrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenTrab.Location = New System.Drawing.Point(205, 27)
        Me.btnOrdenTrab.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrdenTrab.Name = "btnOrdenTrab"
        Me.btnOrdenTrab.Size = New System.Drawing.Size(80, 70)
        Me.btnOrdenTrab.TabIndex = 6
        Me.btnOrdenTrab.UseVisualStyleBackColor = True
        '
        'btnSede
        '
        Me.btnSede.BackgroundImage = CType(resources.GetObject("btnSede.BackgroundImage"), System.Drawing.Image)
        Me.btnSede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSede.FlatAppearance.BorderSize = 0
        Me.btnSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSede.Location = New System.Drawing.Point(109, 151)
        Me.btnSede.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSede.Name = "btnSede"
        Me.btnSede.Size = New System.Drawing.Size(80, 70)
        Me.btnSede.TabIndex = 17
        Me.btnSede.UseVisualStyleBackColor = True
        '
        'lblSede
        '
        Me.lblSede.AutoSize = True
        Me.lblSede.Location = New System.Drawing.Point(128, 225)
        Me.lblSede.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(41, 17)
        Me.lblSede.TabIndex = 16
        Me.lblSede.Text = "Sede"
        '
        'btnSucursal
        '
        Me.btnSucursal.BackgroundImage = CType(resources.GetObject("btnSucursal.BackgroundImage"), System.Drawing.Image)
        Me.btnSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSucursal.FlatAppearance.BorderSize = 0
        Me.btnSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSucursal.Location = New System.Drawing.Point(202, 154)
        Me.btnSucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(80, 70)
        Me.btnSucursal.TabIndex = 19
        Me.btnSucursal.UseVisualStyleBackColor = True
        '
        'lblsucursal
        '
        Me.lblsucursal.AutoSize = True
        Me.lblsucursal.Location = New System.Drawing.Point(211, 227)
        Me.lblsucursal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsucursal.Name = "lblsucursal"
        Me.lblsucursal.Size = New System.Drawing.Size(63, 17)
        Me.lblsucursal.TabIndex = 18
        Me.lblsucursal.Text = "Sucursal"
        '
        'M_MenuLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 477)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "M_MenuLaboratorio"
        Me.Text = "Laboratorio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblordentrabajo As Label
    Friend WithEvents btnOrdenTrab As Button
    Friend WithEvents lblpaciente As Label
    Friend WithEvents btnCliente As Button
    Friend WithEvents lblexamenes As Label
    Friend WithEvents btnExamenes As Button
    Friend WithEvents lblentregaResultado As Label
    Friend WithEvents btnEntregaResultado As Button
    Friend WithEvents lblhojaTrabajo As Label
    Friend WithEvents lblmedico As Label
    Friend WithEvents btnHojaTrabajo As Button
    Friend WithEvents btnMedico As Button
    Friend WithEvents btnSede As Button
    Friend WithEvents lblSede As Label
    Friend WithEvents btnSucursal As Button
    Friend WithEvents lblsucursal As Label
End Class
