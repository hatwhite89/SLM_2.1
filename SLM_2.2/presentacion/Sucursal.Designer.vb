<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sucursal))
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnbuscarTipoObjeto = New System.Windows.Forms.Button()
        Me.txtcodigoTipoObjeto = New System.Windows.Forms.TextBox()
        Me.lbltipoObjeto = New System.Windows.Forms.Label()
        Me.btnbuscarJerarquia = New System.Windows.Forms.Button()
        Me.txtcodigoJerarquia = New System.Windows.Forms.TextBox()
        Me.lbljerarquia = New System.Windows.Forms.Label()
        Me.cbxcerrado = New System.Windows.Forms.CheckBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(95, 12)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 90
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(36, 15)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 89
        Me.lblcodigo.Text = "Código"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(95, 40)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(452, 22)
        Me.txtnombre.TabIndex = 115
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(30, 43)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 17)
        Me.lblnombre.TabIndex = 114
        Me.lblnombre.Text = "Nombre"
        '
        'btnbuscarTipoObjeto
        '
        Me.btnbuscarTipoObjeto.BackColor = System.Drawing.Color.White
        Me.btnbuscarTipoObjeto.BackgroundImage = CType(resources.GetObject("btnbuscarTipoObjeto.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarTipoObjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarTipoObjeto.FlatAppearance.BorderSize = 0
        Me.btnbuscarTipoObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarTipoObjeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarTipoObjeto.Location = New System.Drawing.Point(94, 68)
        Me.btnbuscarTipoObjeto.Name = "btnbuscarTipoObjeto"
        Me.btnbuscarTipoObjeto.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarTipoObjeto.TabIndex = 118
        Me.btnbuscarTipoObjeto.UseVisualStyleBackColor = False
        '
        'txtcodigoTipoObjeto
        '
        Me.txtcodigoTipoObjeto.Location = New System.Drawing.Point(149, 68)
        Me.txtcodigoTipoObjeto.Name = "txtcodigoTipoObjeto"
        Me.txtcodigoTipoObjeto.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoTipoObjeto.TabIndex = 117
        '
        'lbltipoObjeto
        '
        Me.lbltipoObjeto.AutoSize = True
        Me.lbltipoObjeto.Location = New System.Drawing.Point(5, 71)
        Me.lbltipoObjeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipoObjeto.Name = "lbltipoObjeto"
        Me.lbltipoObjeto.Size = New System.Drawing.Size(82, 17)
        Me.lbltipoObjeto.TabIndex = 116
        Me.lbltipoObjeto.Text = "Tipo Objeto"
        '
        'btnbuscarJerarquia
        '
        Me.btnbuscarJerarquia.BackColor = System.Drawing.Color.White
        Me.btnbuscarJerarquia.BackgroundImage = CType(resources.GetObject("btnbuscarJerarquia.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarJerarquia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarJerarquia.FlatAppearance.BorderSize = 0
        Me.btnbuscarJerarquia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarJerarquia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarJerarquia.Location = New System.Drawing.Point(367, 68)
        Me.btnbuscarJerarquia.Name = "btnbuscarJerarquia"
        Me.btnbuscarJerarquia.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarJerarquia.TabIndex = 121
        Me.btnbuscarJerarquia.UseVisualStyleBackColor = False
        '
        'txtcodigoJerarquia
        '
        Me.txtcodigoJerarquia.Location = New System.Drawing.Point(422, 68)
        Me.txtcodigoJerarquia.Name = "txtcodigoJerarquia"
        Me.txtcodigoJerarquia.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoJerarquia.TabIndex = 120
        '
        'lbljerarquia
        '
        Me.lbljerarquia.AutoSize = True
        Me.lbljerarquia.Location = New System.Drawing.Point(281, 71)
        Me.lbljerarquia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljerarquia.Name = "lbljerarquia"
        Me.lbljerarquia.Size = New System.Drawing.Size(68, 17)
        Me.lbljerarquia.TabIndex = 119
        Me.lbljerarquia.Text = "Jerarquía"
        '
        'cbxcerrado
        '
        Me.cbxcerrado.AutoSize = True
        Me.cbxcerrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxcerrado.Location = New System.Drawing.Point(95, 109)
        Me.cbxcerrado.Name = "cbxcerrado"
        Me.cbxcerrado.Size = New System.Drawing.Size(81, 21)
        Me.cbxcerrado.TabIndex = 122
        Me.cbxcerrado.Text = "Cerrado"
        Me.cbxcerrado.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(455, 101)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 124
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncrear.Location = New System.Drawing.Point(367, 101)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(78, 35)
        Me.btncrear.TabIndex = 123
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'Sucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 153)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.cbxcerrado)
        Me.Controls.Add(Me.btnbuscarJerarquia)
        Me.Controls.Add(Me.txtcodigoJerarquia)
        Me.Controls.Add(Me.lbljerarquia)
        Me.Controls.Add(Me.btnbuscarTipoObjeto)
        Me.Controls.Add(Me.txtcodigoTipoObjeto)
        Me.Controls.Add(Me.lbltipoObjeto)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.lblcodigo)
        Me.Name = "Sucursal"
        Me.Text = "Sucursal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents btnbuscarTipoObjeto As Button
    Friend WithEvents txtcodigoTipoObjeto As TextBox
    Friend WithEvents lbltipoObjeto As Label
    Friend WithEvents btnbuscarJerarquia As Button
    Friend WithEvents txtcodigoJerarquia As TextBox
    Friend WithEvents lbljerarquia As Label
    Friend WithEvents cbxcerrado As CheckBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btncrear As Button
End Class
