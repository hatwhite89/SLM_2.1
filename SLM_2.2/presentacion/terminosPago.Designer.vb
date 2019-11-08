<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminosPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TerminosPago))
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtdiasNeto = New System.Windows.Forms.TextBox()
        Me.lbldiasNeto = New System.Windows.Forms.Label()
        Me.txtcodigoListaPrecios = New System.Windows.Forms.TextBox()
        Me.lbllistaPrecios = New System.Windows.Forms.Label()
        Me.txtdiasDescAcordado2 = New System.Windows.Forms.TextBox()
        Me.lbldiasDescAcordado2 = New System.Windows.Forms.Label()
        Me.txtdescAcordado2 = New System.Windows.Forms.TextBox()
        Me.lbldescAcordado2 = New System.Windows.Forms.Label()
        Me.txtdiasDescAcordado = New System.Windows.Forms.TextBox()
        Me.lbldiasDescAcordado = New System.Windows.Forms.Label()
        Me.txtdescAcordado = New System.Windows.Forms.TextBox()
        Me.lbldescAcordado = New System.Windows.Forms.Label()
        Me.lblctaVentas = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblcuotas = New System.Windows.Forms.Label()
        Me.lblctaContado = New System.Windows.Forms.Label()
        Me.cbxtipo = New System.Windows.Forms.ComboBox()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnbuscarListaPrecios = New System.Windows.Forms.Button()
        Me.btnbuscarCtaContado = New System.Windows.Forms.Button()
        Me.txtcodigoCtaContado = New System.Windows.Forms.TextBox()
        Me.btncuotas = New System.Windows.Forms.Button()
        Me.txtcodigoCuotas = New System.Windows.Forms.TextBox()
        Me.btnCtaVentas = New System.Windows.Forms.Button()
        Me.txtcodigoCtaVentas = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(423, 15)
        Me.lbldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcion.TabIndex = 87
        Me.lbldescripcion.Text = "Descripción"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(159, 12)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 86
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(99, 15)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 85
        Me.lblcodigo.Text = "Código"
        '
        'txtdiasNeto
        '
        Me.txtdiasNeto.Location = New System.Drawing.Point(159, 40)
        Me.txtdiasNeto.Name = "txtdiasNeto"
        Me.txtdiasNeto.Size = New System.Drawing.Size(179, 22)
        Me.txtdiasNeto.TabIndex = 84
        '
        'lbldiasNeto
        '
        Me.lbldiasNeto.AutoSize = True
        Me.lbldiasNeto.Location = New System.Drawing.Point(81, 43)
        Me.lbldiasNeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiasNeto.Name = "lbldiasNeto"
        Me.lbldiasNeto.Size = New System.Drawing.Size(70, 17)
        Me.lbldiasNeto.TabIndex = 83
        Me.lbldiasNeto.Text = "Días Neto"
        '
        'txtcodigoListaPrecios
        '
        Me.txtcodigoListaPrecios.Location = New System.Drawing.Point(220, 124)
        Me.txtcodigoListaPrecios.Name = "txtcodigoListaPrecios"
        Me.txtcodigoListaPrecios.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoListaPrecios.TabIndex = 76
        '
        'lbllistaPrecios
        '
        Me.lbllistaPrecios.AutoSize = True
        Me.lbllistaPrecios.Location = New System.Drawing.Point(62, 129)
        Me.lbllistaPrecios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllistaPrecios.Name = "lbllistaPrecios"
        Me.lbllistaPrecios.Size = New System.Drawing.Size(89, 17)
        Me.lbllistaPrecios.TabIndex = 75
        Me.lbllistaPrecios.Text = "Lista Precios"
        '
        'txtdiasDescAcordado2
        '
        Me.txtdiasDescAcordado2.Location = New System.Drawing.Point(512, 122)
        Me.txtdiasDescAcordado2.Name = "txtdiasDescAcordado2"
        Me.txtdiasDescAcordado2.Size = New System.Drawing.Size(179, 22)
        Me.txtdiasDescAcordado2.TabIndex = 74
        '
        'lbldiasDescAcordado2
        '
        Me.lbldiasDescAcordado2.AutoSize = True
        Me.lbldiasDescAcordado2.Location = New System.Drawing.Point(352, 127)
        Me.lbldiasDescAcordado2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiasDescAcordado2.Name = "lbldiasDescAcordado2"
        Me.lbldiasDescAcordado2.Size = New System.Drawing.Size(153, 17)
        Me.lbldiasDescAcordado2.TabIndex = 73
        Me.lbldiasDescAcordado2.Text = "Días Desc. Acordado 2"
        '
        'txtdescAcordado2
        '
        Me.txtdescAcordado2.Location = New System.Drawing.Point(512, 94)
        Me.txtdescAcordado2.Name = "txtdescAcordado2"
        Me.txtdescAcordado2.Size = New System.Drawing.Size(179, 22)
        Me.txtdescAcordado2.TabIndex = 72
        '
        'lbldescAcordado2
        '
        Me.lbldescAcordado2.AutoSize = True
        Me.lbldescAcordado2.Location = New System.Drawing.Point(368, 97)
        Me.lbldescAcordado2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescAcordado2.Name = "lbldescAcordado2"
        Me.lbldescAcordado2.Size = New System.Drawing.Size(137, 17)
        Me.lbldescAcordado2.TabIndex = 71
        Me.lbldescAcordado2.Text = "Desc. Acordado % 2"
        '
        'txtdiasDescAcordado
        '
        Me.txtdiasDescAcordado.Location = New System.Drawing.Point(159, 96)
        Me.txtdiasDescAcordado.Name = "txtdiasDescAcordado"
        Me.txtdiasDescAcordado.Size = New System.Drawing.Size(179, 22)
        Me.txtdiasDescAcordado.TabIndex = 70
        '
        'lbldiasDescAcordado
        '
        Me.lbldiasDescAcordado.AutoSize = True
        Me.lbldiasDescAcordado.Location = New System.Drawing.Point(10, 99)
        Me.lbldiasDescAcordado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiasDescAcordado.Name = "lbldiasDescAcordado"
        Me.lbldiasDescAcordado.Size = New System.Drawing.Size(141, 17)
        Me.lbldiasDescAcordado.TabIndex = 69
        Me.lbldiasDescAcordado.Text = "Días Desc. Acordado"
        '
        'txtdescAcordado
        '
        Me.txtdescAcordado.Location = New System.Drawing.Point(158, 68)
        Me.txtdescAcordado.Name = "txtdescAcordado"
        Me.txtdescAcordado.Size = New System.Drawing.Size(179, 22)
        Me.txtdescAcordado.TabIndex = 68
        '
        'lbldescAcordado
        '
        Me.lbldescAcordado.AutoSize = True
        Me.lbldescAcordado.Location = New System.Drawing.Point(26, 73)
        Me.lbldescAcordado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescAcordado.Name = "lbldescAcordado"
        Me.lbldescAcordado.Size = New System.Drawing.Size(125, 17)
        Me.lbldescAcordado.TabIndex = 67
        Me.lbldescAcordado.Text = "Desc. Acordado %"
        '
        'lblctaVentas
        '
        Me.lblctaVentas.AutoSize = True
        Me.lblctaVentas.Location = New System.Drawing.Point(424, 183)
        Me.lblctaVentas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblctaVentas.Name = "lblctaVentas"
        Me.lblctaVentas.Size = New System.Drawing.Size(81, 17)
        Me.lblctaVentas.TabIndex = 103
        Me.lblctaVentas.Text = "Cta. Ventas"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(115, 183)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(36, 17)
        Me.lbltipo.TabIndex = 105
        Me.lbltipo.Text = "Tipo"
        '
        'lblcuotas
        '
        Me.lblcuotas.AutoSize = True
        Me.lblcuotas.Location = New System.Drawing.Point(453, 152)
        Me.lblcuotas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcuotas.Name = "lblcuotas"
        Me.lblcuotas.Size = New System.Drawing.Size(52, 17)
        Me.lblcuotas.TabIndex = 111
        Me.lblcuotas.Text = "Cuotas"
        '
        'lblctaContado
        '
        Me.lblctaContado.AutoSize = True
        Me.lblctaContado.Location = New System.Drawing.Point(61, 152)
        Me.lblctaContado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblctaContado.Name = "lblctaContado"
        Me.lblctaContado.Size = New System.Drawing.Size(90, 17)
        Me.lblctaContado.TabIndex = 109
        Me.lblctaContado.Text = "Cta. Contado"
        '
        'cbxtipo
        '
        Me.cbxtipo.FormattingEnabled = True
        Me.cbxtipo.Location = New System.Drawing.Point(160, 180)
        Me.cbxtipo.Name = "cbxtipo"
        Me.cbxtipo.Size = New System.Drawing.Size(178, 24)
        Me.cbxtipo.TabIndex = 113
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(512, 12)
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(179, 76)
        Me.rtxtdescripcion.TabIndex = 114
        Me.rtxtdescripcion.Text = ""
        '
        'btnbuscarListaPrecios
        '
        Me.btnbuscarListaPrecios.BackColor = System.Drawing.Color.White
        Me.btnbuscarListaPrecios.BackgroundImage = CType(resources.GetObject("btnbuscarListaPrecios.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarListaPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarListaPrecios.FlatAppearance.BorderSize = 0
        Me.btnbuscarListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarListaPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarListaPrecios.Location = New System.Drawing.Point(163, 124)
        Me.btnbuscarListaPrecios.Name = "btnbuscarListaPrecios"
        Me.btnbuscarListaPrecios.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarListaPrecios.TabIndex = 115
        Me.btnbuscarListaPrecios.UseVisualStyleBackColor = False
        '
        'btnbuscarCtaContado
        '
        Me.btnbuscarCtaContado.BackColor = System.Drawing.Color.White
        Me.btnbuscarCtaContado.BackgroundImage = CType(resources.GetObject("btnbuscarCtaContado.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarCtaContado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarCtaContado.FlatAppearance.BorderSize = 0
        Me.btnbuscarCtaContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarCtaContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarCtaContado.Location = New System.Drawing.Point(163, 152)
        Me.btnbuscarCtaContado.Name = "btnbuscarCtaContado"
        Me.btnbuscarCtaContado.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarCtaContado.TabIndex = 117
        Me.btnbuscarCtaContado.UseVisualStyleBackColor = False
        '
        'txtcodigoCtaContado
        '
        Me.txtcodigoCtaContado.Location = New System.Drawing.Point(220, 152)
        Me.txtcodigoCtaContado.Name = "txtcodigoCtaContado"
        Me.txtcodigoCtaContado.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoCtaContado.TabIndex = 116
        '
        'btncuotas
        '
        Me.btncuotas.BackColor = System.Drawing.Color.White
        Me.btncuotas.BackgroundImage = CType(resources.GetObject("btncuotas.BackgroundImage"), System.Drawing.Image)
        Me.btncuotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncuotas.FlatAppearance.BorderSize = 0
        Me.btncuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncuotas.Location = New System.Drawing.Point(517, 152)
        Me.btncuotas.Name = "btncuotas"
        Me.btncuotas.Size = New System.Drawing.Size(49, 22)
        Me.btncuotas.TabIndex = 119
        Me.btncuotas.UseVisualStyleBackColor = False
        '
        'txtcodigoCuotas
        '
        Me.txtcodigoCuotas.Location = New System.Drawing.Point(574, 152)
        Me.txtcodigoCuotas.Name = "txtcodigoCuotas"
        Me.txtcodigoCuotas.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoCuotas.TabIndex = 118
        '
        'btnCtaVentas
        '
        Me.btnCtaVentas.BackColor = System.Drawing.Color.White
        Me.btnCtaVentas.BackgroundImage = CType(resources.GetObject("btnCtaVentas.BackgroundImage"), System.Drawing.Image)
        Me.btnCtaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCtaVentas.FlatAppearance.BorderSize = 0
        Me.btnCtaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCtaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCtaVentas.Location = New System.Drawing.Point(517, 180)
        Me.btnCtaVentas.Name = "btnCtaVentas"
        Me.btnCtaVentas.Size = New System.Drawing.Size(49, 22)
        Me.btnCtaVentas.TabIndex = 121
        Me.btnCtaVentas.UseVisualStyleBackColor = False
        '
        'txtcodigoCtaVentas
        '
        Me.txtcodigoCtaVentas.Location = New System.Drawing.Point(574, 180)
        Me.txtcodigoCtaVentas.Name = "txtcodigoCtaVentas"
        Me.txtcodigoCtaVentas.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoCtaVentas.TabIndex = 120
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(600, 224)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 126
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncrear.Location = New System.Drawing.Point(512, 224)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(78, 35)
        Me.btncrear.TabIndex = 125
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'TerminosPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 270)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.btnCtaVentas)
        Me.Controls.Add(Me.txtcodigoCtaVentas)
        Me.Controls.Add(Me.btncuotas)
        Me.Controls.Add(Me.txtcodigoCuotas)
        Me.Controls.Add(Me.btnbuscarCtaContado)
        Me.Controls.Add(Me.txtcodigoCtaContado)
        Me.Controls.Add(Me.btnbuscarListaPrecios)
        Me.Controls.Add(Me.rtxtdescripcion)
        Me.Controls.Add(Me.cbxtipo)
        Me.Controls.Add(Me.lblctaVentas)
        Me.Controls.Add(Me.lbltipo)
        Me.Controls.Add(Me.lblcuotas)
        Me.Controls.Add(Me.lblctaContado)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.lbldescAcordado)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.txtdescAcordado)
        Me.Controls.Add(Me.lbldiasDescAcordado)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.txtdiasDescAcordado)
        Me.Controls.Add(Me.txtdiasNeto)
        Me.Controls.Add(Me.lbldescAcordado2)
        Me.Controls.Add(Me.txtdescAcordado2)
        Me.Controls.Add(Me.lbldiasDescAcordado2)
        Me.Controls.Add(Me.lbldiasNeto)
        Me.Controls.Add(Me.txtdiasDescAcordado2)
        Me.Controls.Add(Me.lbllistaPrecios)
        Me.Controls.Add(Me.txtcodigoListaPrecios)
        Me.Name = "TerminosPago"
        Me.Text = "Términos de Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtdiasNeto As TextBox
    Friend WithEvents lbldiasNeto As Label
    Friend WithEvents txtcodigoListaPrecios As TextBox
    Friend WithEvents lbllistaPrecios As Label
    Friend WithEvents txtdiasDescAcordado2 As TextBox
    Friend WithEvents lbldiasDescAcordado2 As Label
    Friend WithEvents txtdescAcordado2 As TextBox
    Friend WithEvents lbldescAcordado2 As Label
    Friend WithEvents txtdiasDescAcordado As TextBox
    Friend WithEvents lbldiasDescAcordado As Label
    Friend WithEvents lbldescAcordado As Label
    Friend WithEvents lblctaVentas As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblcuotas As Label
    Friend WithEvents lblctaContado As Label
    Friend WithEvents cbxtipo As ComboBox
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents btnbuscarListaPrecios As Button
    Friend WithEvents btnbuscarCtaContado As Button
    Friend WithEvents txtcodigoCtaContado As TextBox
    Friend WithEvents btncuotas As Button
    Friend WithEvents txtcodigoCuotas As TextBox
    Friend WithEvents btnCtaVentas As Button
    Friend WithEvents txtcodigoCtaVentas As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btncrear As Button
    Friend WithEvents txtdescAcordado As TextBox
End Class
