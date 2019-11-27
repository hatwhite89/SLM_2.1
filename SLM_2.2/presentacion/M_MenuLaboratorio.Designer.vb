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
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.lblmedico = New System.Windows.Forms.Label()
        Me.btnmedico = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblpaciente)
        Me.GroupBox1.Controls.Add(Me.btnCliente)
        Me.GroupBox1.Controls.Add(Me.lblmedico)
        Me.GroupBox1.Controls.Add(Me.btnmedico)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 411)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menú Módulo Laboratorio"
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
        'lblmedico
        '
        Me.lblmedico.AutoSize = True
        Me.lblmedico.Location = New System.Drawing.Point(219, 102)
        Me.lblmedico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmedico.Name = "lblmedico"
        Me.lblmedico.Size = New System.Drawing.Size(53, 17)
        Me.lblmedico.TabIndex = 7
        Me.lblmedico.Text = "Médico"
        '
        'btnmedico
        '
        Me.btnmedico.BackgroundImage = CType(resources.GetObject("btnmedico.BackgroundImage"), System.Drawing.Image)
        Me.btnmedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmedico.FlatAppearance.BorderSize = 0
        Me.btnmedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmedico.Location = New System.Drawing.Point(205, 27)
        Me.btnmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmedico.Name = "btnmedico"
        Me.btnmedico.Size = New System.Drawing.Size(80, 70)
        Me.btnmedico.TabIndex = 6
        Me.btnmedico.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Médico"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(303, 28)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 70)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Exámenes"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(111, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 70)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = True
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
    Friend WithEvents lblmedico As Label
    Friend WithEvents btnmedico As Button
    Friend WithEvents lblpaciente As Label
    Friend WithEvents btnCliente As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
