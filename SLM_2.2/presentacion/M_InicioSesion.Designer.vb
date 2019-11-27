<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_InicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_InicioSesion))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.mtxtClave = New System.Windows.Forms.MaskedTextBox()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.gbxInicioSesion = New System.Windows.Forms.GroupBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.gbxInicioSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(52, 39)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 119
        Me.lblUsuario.Text = "Usuario"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.Color.White
        Me.lblclave.Location = New System.Drawing.Point(52, 115)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(43, 17)
        Me.lblclave.TabIndex = 117
        Me.lblclave.Text = "Clave"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(55, 70)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(210, 22)
        Me.txtusuario.TabIndex = 130
        '
        'mtxtClave
        '
        Me.mtxtClave.Location = New System.Drawing.Point(55, 146)
        Me.mtxtClave.Name = "mtxtClave"
        Me.mtxtClave.Size = New System.Drawing.Size(210, 22)
        Me.mtxtClave.TabIndex = 131
        Me.mtxtClave.UseSystemPasswordChar = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Location = New System.Drawing.Point(100, 209)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(105, 35)
        Me.btnInicioSesion.TabIndex = 133
        Me.btnInicioSesion.Text = "OK"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        '
        'gbxInicioSesion
        '
        Me.gbxInicioSesion.BackColor = System.Drawing.Color.Transparent
        Me.gbxInicioSesion.Controls.Add(Me.lblUsuario)
        Me.gbxInicioSesion.Controls.Add(Me.btnInicioSesion)
        Me.gbxInicioSesion.Controls.Add(Me.lblclave)
        Me.gbxInicioSesion.Controls.Add(Me.txtusuario)
        Me.gbxInicioSesion.Controls.Add(Me.mtxtClave)
        Me.gbxInicioSesion.Location = New System.Drawing.Point(185, 143)
        Me.gbxInicioSesion.Name = "gbxInicioSesion"
        Me.gbxInicioSesion.Size = New System.Drawing.Size(320, 286)
        Me.gbxInicioSesion.TabIndex = 134
        Me.gbxInicioSesion.TabStop = False
        '
        'lblLogo
        '
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLogo.Image = CType(resources.GetObject("lblLogo.Image"), System.Drawing.Image)
        Me.lblLogo.Location = New System.Drawing.Point(183, 9)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(322, 133)
        Me.lblLogo.TabIndex = 134
        '
        'M_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 485)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.gbxInicioSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "M_InicioSesion"
        Me.Text = "Ingresar: Laboratorios Médicos S de R L"
        Me.gbxInicioSesion.ResumeLayout(False)
        Me.gbxInicioSesion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblclave As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents mtxtClave As MaskedTextBox
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents gbxInicioSesion As GroupBox
    Friend WithEvents lblLogo As Label
End Class
