<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_InicioSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.mtxtClave = New System.Windows.Forms.MaskedTextBox()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.gbxInicioSesion = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbxInicioSesion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(39, 32)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 119
        Me.lblUsuario.Text = "Usuario"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.Color.White
        Me.lblclave.Location = New System.Drawing.Point(39, 93)
        Me.lblclave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(34, 13)
        Me.lblclave.TabIndex = 117
        Me.lblclave.Text = "Clave"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(41, 57)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(158, 20)
        Me.txtusuario.TabIndex = 130
        '
        'mtxtClave
        '
        Me.mtxtClave.Location = New System.Drawing.Point(41, 119)
        Me.mtxtClave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtClave.Name = "mtxtClave"
        Me.mtxtClave.Size = New System.Drawing.Size(158, 20)
        Me.mtxtClave.TabIndex = 131
        Me.mtxtClave.UseSystemPasswordChar = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Location = New System.Drawing.Point(38, 165)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(79, 28)
        Me.btnInicioSesion.TabIndex = 133
        Me.btnInicioSesion.Text = "Entrar"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        '
        'gbxInicioSesion
        '
        Me.gbxInicioSesion.BackColor = System.Drawing.Color.Transparent
        Me.gbxInicioSesion.Controls.Add(Me.Button1)
        Me.gbxInicioSesion.Controls.Add(Me.lblUsuario)
        Me.gbxInicioSesion.Controls.Add(Me.btnInicioSesion)
        Me.gbxInicioSesion.Controls.Add(Me.lblclave)
        Me.gbxInicioSesion.Controls.Add(Me.txtusuario)
        Me.gbxInicioSesion.Controls.Add(Me.mtxtClave)
        Me.gbxInicioSesion.Location = New System.Drawing.Point(11, 193)
        Me.gbxInicioSesion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxInicioSesion.Name = "gbxInicioSesion"
        Me.gbxInicioSesion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxInicioSesion.Size = New System.Drawing.Size(240, 232)
        Me.gbxInicioSesion.TabIndex = 134
        Me.gbxInicioSesion.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 134
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'M_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(267, 468)
        Me.Controls.Add(Me.gbxInicioSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Button1 As Button
End Class
