<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_TerminosPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_TerminosPago))
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtdiasNeto = New System.Windows.Forms.TextBox()
        Me.lbldiasNeto = New System.Windows.Forms.Label()
        Me.lblctaVentas = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lblctaContado = New System.Windows.Forms.Label()
        Me.cbxtipoPago = New System.Windows.Forms.ComboBox()
        Me.btnctaContado = New System.Windows.Forms.Button()
        Me.txtcodigoCtaContado = New System.Windows.Forms.TextBox()
        Me.btnctaVentas = New System.Windows.Forms.Button()
        Me.txtcodigoCtaVentas = New System.Windows.Forms.TextBox()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.gbxterminosPago = New System.Windows.Forms.GroupBox()
        Me.txtnombreCtaVentas = New System.Windows.Forms.TextBox()
        Me.txtnombreCtaContado = New System.Windows.Forms.TextBox()
        Me.btntipoPago = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtdescripcionB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.lblform = New System.Windows.Forms.Label()
        Me.gbxterminosPago.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(45, 51)
        Me.lbldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcion.TabIndex = 87
        Me.lbldescripcion.Text = "Descripción"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(134, 20)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 86
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(74, 23)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 85
        Me.lblcodigo.Text = "Código"
        '
        'txtdiasNeto
        '
        Me.txtdiasNeto.Location = New System.Drawing.Point(135, 91)
        Me.txtdiasNeto.Name = "txtdiasNeto"
        Me.txtdiasNeto.Size = New System.Drawing.Size(179, 22)
        Me.txtdiasNeto.TabIndex = 84
        '
        'lbldiasNeto
        '
        Me.lbldiasNeto.AutoSize = True
        Me.lbldiasNeto.Location = New System.Drawing.Point(57, 94)
        Me.lbldiasNeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiasNeto.Name = "lbldiasNeto"
        Me.lbldiasNeto.Size = New System.Drawing.Size(70, 17)
        Me.lbldiasNeto.TabIndex = 83
        Me.lbldiasNeto.Text = "Días Neto"
        '
        'lblctaVentas
        '
        Me.lblctaVentas.AutoSize = True
        Me.lblctaVentas.Location = New System.Drawing.Point(47, 150)
        Me.lblctaVentas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblctaVentas.Name = "lblctaVentas"
        Me.lblctaVentas.Size = New System.Drawing.Size(81, 17)
        Me.lblctaVentas.TabIndex = 103
        Me.lblctaVentas.Text = "Cta. Ventas"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(326, 94)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(36, 17)
        Me.lbltipo.TabIndex = 105
        Me.lbltipo.Text = "Tipo"
        '
        'lblctaContado
        '
        Me.lblctaContado.AutoSize = True
        Me.lblctaContado.Location = New System.Drawing.Point(38, 121)
        Me.lblctaContado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblctaContado.Name = "lblctaContado"
        Me.lblctaContado.Size = New System.Drawing.Size(90, 17)
        Me.lblctaContado.TabIndex = 109
        Me.lblctaContado.Text = "Cta. Contado"
        '
        'cbxtipoPago
        '
        Me.cbxtipoPago.DropDownWidth = 170
        Me.cbxtipoPago.FormattingEnabled = True
        Me.cbxtipoPago.Location = New System.Drawing.Point(369, 91)
        Me.cbxtipoPago.Name = "cbxtipoPago"
        Me.cbxtipoPago.Size = New System.Drawing.Size(132, 24)
        Me.cbxtipoPago.TabIndex = 113
        '
        'btnctaContado
        '
        Me.btnctaContado.BackColor = System.Drawing.Color.White
        Me.btnctaContado.BackgroundImage = CType(resources.GetObject("btnctaContado.BackgroundImage"), System.Drawing.Image)
        Me.btnctaContado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnctaContado.FlatAppearance.BorderSize = 0
        Me.btnctaContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnctaContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnctaContado.Location = New System.Drawing.Point(140, 119)
        Me.btnctaContado.Name = "btnctaContado"
        Me.btnctaContado.Size = New System.Drawing.Size(49, 22)
        Me.btnctaContado.TabIndex = 117
        Me.btnctaContado.UseVisualStyleBackColor = False
        '
        'txtcodigoCtaContado
        '
        Me.txtcodigoCtaContado.Location = New System.Drawing.Point(197, 119)
        Me.txtcodigoCtaContado.Name = "txtcodigoCtaContado"
        Me.txtcodigoCtaContado.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoCtaContado.TabIndex = 116
        '
        'btnctaVentas
        '
        Me.btnctaVentas.BackColor = System.Drawing.Color.White
        Me.btnctaVentas.BackgroundImage = CType(resources.GetObject("btnctaVentas.BackgroundImage"), System.Drawing.Image)
        Me.btnctaVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnctaVentas.FlatAppearance.BorderSize = 0
        Me.btnctaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnctaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnctaVentas.Location = New System.Drawing.Point(140, 147)
        Me.btnctaVentas.Name = "btnctaVentas"
        Me.btnctaVentas.Size = New System.Drawing.Size(49, 22)
        Me.btnctaVentas.TabIndex = 121
        Me.btnctaVentas.UseVisualStyleBackColor = False
        '
        'txtcodigoCtaVentas
        '
        Me.txtcodigoCtaVentas.Location = New System.Drawing.Point(197, 147)
        Me.txtcodigoCtaVentas.Name = "txtcodigoCtaVentas"
        Me.txtcodigoCtaVentas.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoCtaVentas.TabIndex = 120
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(134, 48)
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(423, 37)
        Me.rtxtdescripcion.TabIndex = 125
        Me.rtxtdescripcion.Text = ""
        '
        'gbxterminosPago
        '
        Me.gbxterminosPago.Controls.Add(Me.txtnombreCtaVentas)
        Me.gbxterminosPago.Controls.Add(Me.txtnombreCtaContado)
        Me.gbxterminosPago.Controls.Add(Me.btntipoPago)
        Me.gbxterminosPago.Controls.Add(Me.btnmodificar)
        Me.gbxterminosPago.Controls.Add(Me.btncancelar)
        Me.gbxterminosPago.Controls.Add(Me.lblcodigo)
        Me.gbxterminosPago.Controls.Add(Me.btnnuevo)
        Me.gbxterminosPago.Controls.Add(Me.rtxtdescripcion)
        Me.gbxterminosPago.Controls.Add(Me.btnguardar)
        Me.gbxterminosPago.Controls.Add(Me.lbldiasNeto)
        Me.gbxterminosPago.Controls.Add(Me.btnctaVentas)
        Me.gbxterminosPago.Controls.Add(Me.txtdiasNeto)
        Me.gbxterminosPago.Controls.Add(Me.txtcodigoCtaVentas)
        Me.gbxterminosPago.Controls.Add(Me.lbldescripcion)
        Me.gbxterminosPago.Controls.Add(Me.btnctaContado)
        Me.gbxterminosPago.Controls.Add(Me.txtcodigo)
        Me.gbxterminosPago.Controls.Add(Me.txtcodigoCtaContado)
        Me.gbxterminosPago.Controls.Add(Me.lblctaContado)
        Me.gbxterminosPago.Controls.Add(Me.cbxtipoPago)
        Me.gbxterminosPago.Controls.Add(Me.lbltipo)
        Me.gbxterminosPago.Controls.Add(Me.lblctaVentas)
        Me.gbxterminosPago.Location = New System.Drawing.Point(24, 10)
        Me.gbxterminosPago.Name = "gbxterminosPago"
        Me.gbxterminosPago.Size = New System.Drawing.Size(607, 226)
        Me.gbxterminosPago.TabIndex = 126
        Me.gbxterminosPago.TabStop = False
        Me.gbxterminosPago.Text = "REGISTRAR TÉRMINO DE PAGO"
        '
        'txtnombreCtaVentas
        '
        Me.txtnombreCtaVentas.Location = New System.Drawing.Point(330, 147)
        Me.txtnombreCtaVentas.Name = "txtnombreCtaVentas"
        Me.txtnombreCtaVentas.ReadOnly = True
        Me.txtnombreCtaVentas.Size = New System.Drawing.Size(228, 22)
        Me.txtnombreCtaVentas.TabIndex = 133
        '
        'txtnombreCtaContado
        '
        Me.txtnombreCtaContado.Location = New System.Drawing.Point(329, 120)
        Me.txtnombreCtaContado.Name = "txtnombreCtaContado"
        Me.txtnombreCtaContado.ReadOnly = True
        Me.txtnombreCtaContado.Size = New System.Drawing.Size(228, 22)
        Me.txtnombreCtaContado.TabIndex = 132
        '
        'btntipoPago
        '
        Me.btntipoPago.BackColor = System.Drawing.Color.White
        Me.btntipoPago.BackgroundImage = CType(resources.GetObject("btntipoPago.BackgroundImage"), System.Drawing.Image)
        Me.btntipoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntipoPago.FlatAppearance.BorderSize = 0
        Me.btntipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntipoPago.Location = New System.Drawing.Point(507, 91)
        Me.btntipoPago.Name = "btntipoPago"
        Me.btntipoPago.Size = New System.Drawing.Size(49, 22)
        Me.btntipoPago.TabIndex = 131
        Me.btntipoPago.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(326, 177)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 35)
        Me.btnmodificar.TabIndex = 130
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(464, 177)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 127
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(44, 177)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 35)
        Me.btnnuevo.TabIndex = 129
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(190, 177)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 35)
        Me.btnguardar.TabIndex = 128
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblform)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtdescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.btnbuscar)
        Me.gbxbusqueda.Location = New System.Drawing.Point(18, 235)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Size = New System.Drawing.Size(613, 375)
        Me.gbxbusqueda.TabIndex = 127
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR TÉRMINO DE PAGO"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(407, 340)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(44, 77)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(520, 245)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(118, 340)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(155, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL ESPECIALIDAD"
        '
        'txtdescripcionB
        '
        Me.txtdescripcionB.Location = New System.Drawing.Point(207, 31)
        Me.txtdescripcionB.Name = "txtdescripcionB"
        Me.txtdescripcionB.Size = New System.Drawing.Size(192, 22)
        Me.txtdescripcionB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(116, 34)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(82, 17)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Descripción"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnbuscar.Location = New System.Drawing.Point(407, 25)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(78, 35)
        Me.btnbuscar.TabIndex = 113
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(513, 22)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(0, 17)
        Me.lblform.TabIndex = 116
        Me.lblform.Visible = False
        '
        'M_TerminosPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 622)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxterminosPago)
        Me.Name = "M_TerminosPago"
        Me.Text = "Términos de Pago"
        Me.gbxterminosPago.ResumeLayout(False)
        Me.gbxterminosPago.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtdiasNeto As TextBox
    Friend WithEvents lbldiasNeto As Label
    Friend WithEvents lblctaVentas As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents lblctaContado As Label
    Friend WithEvents cbxtipoPago As ComboBox
    Friend WithEvents btnctaContado As Button
    Friend WithEvents txtcodigoCtaContado As TextBox
    Friend WithEvents btnctaVentas As Button
    Friend WithEvents txtcodigoCtaVentas As TextBox
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents gbxterminosPago As GroupBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btntipoPago As Button
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtdescripcionB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents txtnombreCtaVentas As TextBox
    Friend WithEvents txtnombreCtaContado As TextBox
    Friend WithEvents lblform As Label
End Class
