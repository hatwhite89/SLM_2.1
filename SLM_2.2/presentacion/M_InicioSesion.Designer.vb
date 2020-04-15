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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_InicioSesion))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.gbxInicioSesion = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.gbxInicioSesion.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Location = New System.Drawing.Point(43, 40)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 119
        Me.lblUsuario.Text = "Usuario"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.BackColor = System.Drawing.Color.Transparent
        Me.lblclave.Location = New System.Drawing.Point(43, 102)
        Me.lblclave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(34, 13)
        Me.lblclave.TabIndex = 117
        Me.lblclave.Text = "Clave"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(41, 57)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusuario.MaxLength = 50
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(158, 20)
        Me.txtusuario.TabIndex = 0
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Location = New System.Drawing.Point(40, 165)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(79, 28)
        Me.btnInicioSesion.TabIndex = 2
        Me.btnInicioSesion.Text = "Entrar"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        '
        'gbxInicioSesion
        '
        Me.gbxInicioSesion.BackColor = System.Drawing.Color.Transparent
        Me.gbxInicioSesion.Controls.Add(Me.txtPassword)
        Me.gbxInicioSesion.Controls.Add(Me.Button1)
        Me.gbxInicioSesion.Controls.Add(Me.lblUsuario)
        Me.gbxInicioSesion.Controls.Add(Me.btnInicioSesion)
        Me.gbxInicioSesion.Controls.Add(Me.lblclave)
        Me.gbxInicioSesion.Controls.Add(Me.txtusuario)
        Me.gbxInicioSesion.Location = New System.Drawing.Point(11, 193)
        Me.gbxInicioSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxInicioSesion.Name = "gbxInicioSesion"
        Me.gbxInicioSesion.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxInicioSesion.Size = New System.Drawing.Size(240, 232)
        Me.gbxInicioSesion.TabIndex = 134
        Me.gbxInicioSesion.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(124, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'SkinEngine1
        '
        Me.SkinEngine1.DefaultButtonStyle = Sunisoft.IrisSkin.DefaultButtonStyle.FocusRectangle
        Me.SkinEngine1.ResSysMenuClose = ""
        Me.SkinEngine1.ResSysMenuMax = ""
        Me.SkinEngine1.ResSysMenuMin = ""
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = Nothing
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(41, 118)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'M_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(267, 437)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxInicioSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "M_InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar: Laboratorios Médicos S de R L"
        Me.gbxInicioSesion.ResumeLayout(False)
        Me.gbxInicioSesion.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblclave As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents gbxInicioSesion As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents txtPassword As TextBox
End Class
