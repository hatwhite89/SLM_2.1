<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_CrearTipoObjeto
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
        Me.lbllongitud = New System.Windows.Forms.Label()
        Me.txtjerarquia = New System.Windows.Forms.TextBox()
        Me.lbljerarquia = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtlongitud = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lbllongitud
        '
        Me.lbllongitud.AutoSize = True
        Me.lbllongitud.Location = New System.Drawing.Point(30, 170)
        Me.lbllongitud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllongitud.Name = "lbllongitud"
        Me.lbllongitud.Size = New System.Drawing.Size(63, 17)
        Me.lbllongitud.TabIndex = 132
        Me.lbllongitud.Text = "Longitud"
        '
        'txtjerarquia
        '
        Me.txtjerarquia.Location = New System.Drawing.Point(100, 142)
        Me.txtjerarquia.Name = "txtjerarquia"
        Me.txtjerarquia.Size = New System.Drawing.Size(179, 22)
        Me.txtjerarquia.TabIndex = 130
        '
        'lbljerarquia
        '
        Me.lbljerarquia.AutoSize = True
        Me.lbljerarquia.Location = New System.Drawing.Point(25, 142)
        Me.lbljerarquia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljerarquia.Name = "lbljerarquia"
        Me.lbljerarquia.Size = New System.Drawing.Size(68, 17)
        Me.lbljerarquia.TabIndex = 129
        Me.lbljerarquia.Text = "Jerarquía"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(13, 43)
        Me.lbldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcion.TabIndex = 127
        Me.lbldescripcion.Text = "Descripción"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(100, 12)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 123
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(41, 15)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 122
        Me.lblcodigo.Text = "Código"
        '
        'txtlongitud
        '
        Me.txtlongitud.Location = New System.Drawing.Point(100, 170)
        Me.txtlongitud.Name = "txtlongitud"
        Me.txtlongitud.Size = New System.Drawing.Size(179, 22)
        Me.txtlongitud.TabIndex = 133
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(152, 214)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 135
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncrear.Location = New System.Drawing.Point(64, 214)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(78, 35)
        Me.btncrear.TabIndex = 134
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(100, 40)
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(179, 96)
        Me.rtxtdescripcion.TabIndex = 136
        Me.rtxtdescripcion.Text = ""
        '
        'TipoObjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 268)
        Me.Controls.Add(Me.rtxtdescripcion)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.txtlongitud)
        Me.Controls.Add(Me.lbllongitud)
        Me.Controls.Add(Me.txtjerarquia)
        Me.Controls.Add(Me.lbljerarquia)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.lblcodigo)
        Me.Name = "TipoObjeto"
        Me.Text = "TipoObjeto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllongitud As Label
    Friend WithEvents txtjerarquia As TextBox
    Friend WithEvents lbljerarquia As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtlongitud As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btncrear As Button
    Friend WithEvents rtxtdescripcion As RichTextBox
End Class
