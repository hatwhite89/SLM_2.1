<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_EspecificarHojaTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_EspecificarHojaTrabajo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCodeSubArea = New System.Windows.Forms.Label()
        Me.lblCodeTecnico = New System.Windows.Forms.Label()
        Me.lblCodeSucursal = New System.Windows.Forms.Label()
        Me.btnSubarea = New System.Windows.Forms.Button()
        Me.btnTecnico = New System.Windows.Forms.Button()
        Me.btnSucursal = New System.Windows.Forms.Button()
        Me.txtSubArea = New System.Windows.Forms.TextBox()
        Me.txtTecnico = New System.Windows.Forms.TextBox()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.txtDescripcionSubArea = New System.Windows.Forms.TextBox()
        Me.txtDescripcionTecnico = New System.Windows.Forms.TextBox()
        Me.txtDescripcionSucursal = New System.Windows.Forms.TextBox()
        Me.lblCodigoGrupo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subárea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Técnico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal"
        '
        'lblCodeSubArea
        '
        Me.lblCodeSubArea.AutoSize = True
        Me.lblCodeSubArea.Location = New System.Drawing.Point(68, 54)
        Me.lblCodeSubArea.Name = "lblCodeSubArea"
        Me.lblCodeSubArea.Size = New System.Drawing.Size(51, 17)
        Me.lblCodeSubArea.TabIndex = 3
        Me.lblCodeSubArea.Text = "Label4"
        Me.lblCodeSubArea.Visible = False
        '
        'lblCodeTecnico
        '
        Me.lblCodeTecnico.AutoSize = True
        Me.lblCodeTecnico.Location = New System.Drawing.Point(63, 119)
        Me.lblCodeTecnico.Name = "lblCodeTecnico"
        Me.lblCodeTecnico.Size = New System.Drawing.Size(51, 17)
        Me.lblCodeTecnico.TabIndex = 4
        Me.lblCodeTecnico.Text = "Label5"
        Me.lblCodeTecnico.Visible = False
        '
        'lblCodeSucursal
        '
        Me.lblCodeSucursal.AutoSize = True
        Me.lblCodeSucursal.Location = New System.Drawing.Point(63, 158)
        Me.lblCodeSucursal.Name = "lblCodeSucursal"
        Me.lblCodeSucursal.Size = New System.Drawing.Size(51, 17)
        Me.lblCodeSucursal.TabIndex = 5
        Me.lblCodeSucursal.Text = "Label6"
        Me.lblCodeSucursal.Visible = False
        '
        'btnSubarea
        '
        Me.btnSubarea.BackColor = System.Drawing.Color.White
        Me.btnSubarea.BackgroundImage = CType(resources.GetObject("btnSubarea.BackgroundImage"), System.Drawing.Image)
        Me.btnSubarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSubarea.FlatAppearance.BorderSize = 0
        Me.btnSubarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubarea.Location = New System.Drawing.Point(140, 68)
        Me.btnSubarea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubarea.Name = "btnSubarea"
        Me.btnSubarea.Size = New System.Drawing.Size(49, 22)
        Me.btnSubarea.TabIndex = 118
        Me.btnSubarea.Text = "..."
        Me.btnSubarea.UseVisualStyleBackColor = False
        '
        'btnTecnico
        '
        Me.btnTecnico.BackColor = System.Drawing.Color.White
        Me.btnTecnico.BackgroundImage = CType(resources.GetObject("btnTecnico.BackgroundImage"), System.Drawing.Image)
        Me.btnTecnico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTecnico.FlatAppearance.BorderSize = 0
        Me.btnTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTecnico.Location = New System.Drawing.Point(140, 119)
        Me.btnTecnico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTecnico.Name = "btnTecnico"
        Me.btnTecnico.Size = New System.Drawing.Size(49, 22)
        Me.btnTecnico.TabIndex = 119
        Me.btnTecnico.Text = "..."
        Me.btnTecnico.UseVisualStyleBackColor = False
        '
        'btnSucursal
        '
        Me.btnSucursal.BackColor = System.Drawing.Color.White
        Me.btnSucursal.BackgroundImage = CType(resources.GetObject("btnSucursal.BackgroundImage"), System.Drawing.Image)
        Me.btnSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSucursal.FlatAppearance.BorderSize = 0
        Me.btnSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSucursal.Location = New System.Drawing.Point(140, 170)
        Me.btnSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(49, 22)
        Me.btnSucursal.TabIndex = 120
        Me.btnSucursal.Text = "..."
        Me.btnSucursal.UseVisualStyleBackColor = False
        '
        'txtSubArea
        '
        Me.txtSubArea.Location = New System.Drawing.Point(195, 66)
        Me.txtSubArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubArea.MaxLength = 20
        Me.txtSubArea.Name = "txtSubArea"
        Me.txtSubArea.Size = New System.Drawing.Size(117, 22)
        Me.txtSubArea.TabIndex = 121
        Me.txtSubArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTecnico
        '
        Me.txtTecnico.Location = New System.Drawing.Point(195, 116)
        Me.txtTecnico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTecnico.MaxLength = 30
        Me.txtTecnico.Name = "txtTecnico"
        Me.txtTecnico.Size = New System.Drawing.Size(117, 22)
        Me.txtTecnico.TabIndex = 122
        Me.txtTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(195, 170)
        Me.txtSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSucursal.MaxLength = 20
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(117, 22)
        Me.txtSucursal.TabIndex = 123
        Me.txtSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAbrir
        '
        Me.btnAbrir.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAbrir.Location = New System.Drawing.Point(263, 250)
        Me.btnAbrir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(105, 34)
        Me.btnAbrir.TabIndex = 130
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = False
        '
        'txtDescripcionSubArea
        '
        Me.txtDescripcionSubArea.Location = New System.Drawing.Point(318, 66)
        Me.txtDescripcionSubArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionSubArea.Name = "txtDescripcionSubArea"
        Me.txtDescripcionSubArea.ReadOnly = True
        Me.txtDescripcionSubArea.Size = New System.Drawing.Size(228, 22)
        Me.txtDescripcionSubArea.TabIndex = 133
        '
        'txtDescripcionTecnico
        '
        Me.txtDescripcionTecnico.Location = New System.Drawing.Point(318, 116)
        Me.txtDescripcionTecnico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionTecnico.Name = "txtDescripcionTecnico"
        Me.txtDescripcionTecnico.ReadOnly = True
        Me.txtDescripcionTecnico.Size = New System.Drawing.Size(228, 22)
        Me.txtDescripcionTecnico.TabIndex = 134
        '
        'txtDescripcionSucursal
        '
        Me.txtDescripcionSucursal.Location = New System.Drawing.Point(318, 170)
        Me.txtDescripcionSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionSucursal.Name = "txtDescripcionSucursal"
        Me.txtDescripcionSucursal.ReadOnly = True
        Me.txtDescripcionSucursal.Size = New System.Drawing.Size(228, 22)
        Me.txtDescripcionSucursal.TabIndex = 135
        '
        'lblCodigoGrupo
        '
        Me.lblCodigoGrupo.AutoSize = True
        Me.lblCodigoGrupo.Location = New System.Drawing.Point(63, 33)
        Me.lblCodigoGrupo.Name = "lblCodigoGrupo"
        Me.lblCodigoGrupo.Size = New System.Drawing.Size(51, 17)
        Me.lblCodigoGrupo.TabIndex = 136
        Me.lblCodigoGrupo.Text = "Label7"
        Me.lblCodigoGrupo.Visible = False
        '
        'E_EspecificarHojaTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(621, 332)
        Me.Controls.Add(Me.lblCodigoGrupo)
        Me.Controls.Add(Me.txtDescripcionSucursal)
        Me.Controls.Add(Me.txtDescripcionTecnico)
        Me.Controls.Add(Me.txtDescripcionSubArea)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.txtTecnico)
        Me.Controls.Add(Me.txtSubArea)
        Me.Controls.Add(Me.btnSucursal)
        Me.Controls.Add(Me.btnTecnico)
        Me.Controls.Add(Me.btnSubarea)
        Me.Controls.Add(Me.lblCodeSucursal)
        Me.Controls.Add(Me.lblCodeTecnico)
        Me.Controls.Add(Me.lblCodeSubArea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "E_EspecificarHojaTrabajo"
        Me.Text = "Especificación Hoja de Trabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCodeSubArea As Label
    Friend WithEvents lblCodeTecnico As Label
    Friend WithEvents lblCodeSucursal As Label
    Friend WithEvents btnSubarea As Button
    Friend WithEvents btnTecnico As Button
    Friend WithEvents btnSucursal As Button
    Friend WithEvents txtSubArea As TextBox
    Friend WithEvents txtTecnico As TextBox
    Friend WithEvents txtSucursal As TextBox
    Friend WithEvents btnAbrir As Button
    Friend WithEvents txtDescripcionSubArea As TextBox
    Friend WithEvents txtDescripcionTecnico As TextBox
    Friend WithEvents txtDescripcionSucursal As TextBox
    Friend WithEvents lblCodigoGrupo As Label
End Class
