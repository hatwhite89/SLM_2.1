﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPassword = New UIDC.UI_MaterialTextBox()
        Me.txtUsuario = New UIDC.UI_MaterialTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.UI_TitleBanner1 = New UIDC.UI_TitleBanner()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnInicioSesion)
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 402)
        Me.Panel1.TabIndex = 135
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.FocusedColor = "#508ef5"
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.IsEnabled = True
        Me.txtPassword.Location = New System.Drawing.Point(88, 254)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(202, 24)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.UIFontColor = "#999999"
        Me.txtPassword.UIMultiline = False
        Me.txtPassword.UIReadOnly = False
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.ValidateMessageText = "MessageBox Error Text "
        Me.txtPassword.ValidateMessageTitle = "MessageBox Title Text "
        Me.txtPassword.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Null
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.FocusedColor = "#508ef5"
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.IsEnabled = True
        Me.txtUsuario.Location = New System.Drawing.Point(88, 191)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(202, 24)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsuario.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.UIFontColor = "#999999"
        Me.txtUsuario.UIMultiline = False
        Me.txtUsuario.UIReadOnly = False
        Me.txtUsuario.UseSystemPasswordChar = False
        Me.txtUsuario.ValidateMessageText = "MessageBox Error Text "
        Me.txtUsuario.ValidateMessageTitle = "MessageBox Title Text "
        Me.txtUsuario.ValidateText = UIDC.UI_MaterialTextBox.TextValidate.Null
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(57, 249)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 130
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(55, 188)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 129
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 126
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(72, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Location = New System.Drawing.Point(72, 320)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(218, 28)
        Me.btnInicioSesion.TabIndex = 2
        Me.btnInicioSesion.Text = "Iniciar Sesión"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        '
        'UI_TitleBanner1
        '
        Me.UI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateON
        Me.UI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.UI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff
        Me.UI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close
        Me.UI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UI_TitleBanner1.FlatAppearance.BorderSize = 0
        Me.UI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.UI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.UI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UI_TitleBanner1.Font = New System.Drawing.Font("Roboto", 15.0!)
        Me.UI_TitleBanner1.ForeColor = System.Drawing.Color.White
        Me.UI_TitleBanner1.Location = New System.Drawing.Point(0, 0)
        Me.UI_TitleBanner1.MoveActive = True
        Me.UI_TitleBanner1.Name = "UI_TitleBanner1"
        Me.UI_TitleBanner1.Padding = New System.Windows.Forms.Padding(15, 12, 0, 0)
        Me.UI_TitleBanner1.ParentControl = Me
        Me.UI_TitleBanner1.Size = New System.Drawing.Size(357, 70)
        Me.UI_TitleBanner1.TabIndex = 137
        Me.UI_TitleBanner1.Text = "Login"
        Me.UI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.UI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Material
        Me.UI_TitleBanner1.UseVisualStyleBackColor = False
        '
        'M_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(357, 460)
        Me.Controls.Add(Me.UI_TitleBanner1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "M_InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsuario As UIDC.UI_MaterialTextBox
    Friend WithEvents txtPassword As UIDC.UI_MaterialTextBox
    Friend WithEvents UI_TitleBanner1 As UIDC.UI_TitleBanner
End Class
