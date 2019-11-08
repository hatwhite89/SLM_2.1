<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.gbxcajero = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblusuarioCajero = New System.Windows.Forms.Label()
        Me.gbxclientePaciente = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtnombreCliente = New System.Windows.Forms.TextBox()
        Me.lbltelefonoCliente = New System.Windows.Forms.Label()
        Me.lblnombreCliente = New System.Windows.Forms.Label()
        Me.btncrearCliente = New System.Windows.Forms.Button()
        Me.btnimprimirFactura = New System.Windows.Forms.Button()
        Me.btnbuscarCliente = New System.Windows.Forms.Button()
        Me.btngenerarFactura = New System.Windows.Forms.Button()
        Me.gbxlistadoExamenes = New System.Windows.Forms.GroupBox()
        Me.dgblistadoExamenes = New System.Windows.Forms.DataGridView()
        Me.gbxexamen = New System.Windows.Forms.GroupBox()
        Me.btnagregarExamen = New System.Windows.Forms.Button()
        Me.txtcodigoExamen = New System.Windows.Forms.TextBox()
        Me.lblcodigoExamen = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.gbxcosto = New System.Windows.Forms.GroupBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtimpuesto = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblimpuesto = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxcajero.SuspendLayout()
        Me.gbxclientePaciente.SuspendLayout()
        Me.gbxlistadoExamenes.SuspendLayout()
        CType(Me.dgblistadoExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxexamen.SuspendLayout()
        Me.gbxcosto.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxcajero
        '
        Me.gbxcajero.Controls.Add(Me.TextBox2)
        Me.gbxcajero.Controls.Add(Me.lblusuarioCajero)
        Me.gbxcajero.Location = New System.Drawing.Point(821, 132)
        Me.gbxcajero.Name = "gbxcajero"
        Me.gbxcajero.Size = New System.Drawing.Size(426, 106)
        Me.gbxcajero.TabIndex = 17
        Me.gbxcajero.TabStop = False
        Me.gbxcajero.Text = "Cajero"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(221, 22)
        Me.TextBox2.TabIndex = 5
        '
        'lblusuarioCajero
        '
        Me.lblusuarioCajero.AutoSize = True
        Me.lblusuarioCajero.Location = New System.Drawing.Point(47, 46)
        Me.lblusuarioCajero.Name = "lblusuarioCajero"
        Me.lblusuarioCajero.Size = New System.Drawing.Size(61, 17)
        Me.lblusuarioCajero.TabIndex = 1
        Me.lblusuarioCajero.Text = "Usuario:"
        '
        'gbxclientePaciente
        '
        Me.gbxclientePaciente.Controls.Add(Me.TextBox1)
        Me.gbxclientePaciente.Controls.Add(Me.Label1)
        Me.gbxclientePaciente.Controls.Add(Me.txttelefonoCliente)
        Me.gbxclientePaciente.Controls.Add(Me.txtnombreCliente)
        Me.gbxclientePaciente.Controls.Add(Me.lbltelefonoCliente)
        Me.gbxclientePaciente.Controls.Add(Me.lblnombreCliente)
        Me.gbxclientePaciente.Location = New System.Drawing.Point(55, 132)
        Me.gbxclientePaciente.Name = "gbxclientePaciente"
        Me.gbxclientePaciente.Size = New System.Drawing.Size(741, 106)
        Me.gbxclientePaciente.TabIndex = 16
        Me.gbxclientePaciente.TabStop = False
        Me.gbxclientePaciente.Text = "Cliente/Paciente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(479, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(221, 22)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo:"
        '
        'txttelefonoCliente
        '
        Me.txttelefonoCliente.Location = New System.Drawing.Point(108, 68)
        Me.txttelefonoCliente.Name = "txttelefonoCliente"
        Me.txttelefonoCliente.ReadOnly = True
        Me.txttelefonoCliente.Size = New System.Drawing.Size(221, 22)
        Me.txttelefonoCliente.TabIndex = 4
        '
        'txtnombreCliente
        '
        Me.txtnombreCliente.Location = New System.Drawing.Point(108, 29)
        Me.txtnombreCliente.Name = "txtnombreCliente"
        Me.txtnombreCliente.ReadOnly = True
        Me.txtnombreCliente.Size = New System.Drawing.Size(221, 22)
        Me.txtnombreCliente.TabIndex = 3
        '
        'lbltelefonoCliente
        '
        Me.lbltelefonoCliente.AutoSize = True
        Me.lbltelefonoCliente.Location = New System.Drawing.Point(26, 68)
        Me.lbltelefonoCliente.Name = "lbltelefonoCliente"
        Me.lbltelefonoCliente.Size = New System.Drawing.Size(68, 17)
        Me.lbltelefonoCliente.TabIndex = 2
        Me.lbltelefonoCliente.Text = "Teléfono:"
        '
        'lblnombreCliente
        '
        Me.lblnombreCliente.AutoSize = True
        Me.lblnombreCliente.Location = New System.Drawing.Point(32, 32)
        Me.lblnombreCliente.Name = "lblnombreCliente"
        Me.lblnombreCliente.Size = New System.Drawing.Size(62, 17)
        Me.lblnombreCliente.TabIndex = 0
        Me.lblnombreCliente.Text = "Nombre:"
        '
        'btncrearCliente
        '
        Me.btncrearCliente.BackColor = System.Drawing.Color.SkyBlue
        Me.btncrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncrearCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrearCliente.Location = New System.Drawing.Point(412, 63)
        Me.btncrearCliente.Name = "btncrearCliente"
        Me.btncrearCliente.Size = New System.Drawing.Size(138, 35)
        Me.btncrearCliente.TabIndex = 15
        Me.btncrearCliente.Text = "Crear Cliente"
        Me.btncrearCliente.UseVisualStyleBackColor = False
        '
        'btnimprimirFactura
        '
        Me.btnimprimirFactura.BackColor = System.Drawing.Color.SkyBlue
        Me.btnimprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnimprimirFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimirFactura.Location = New System.Drawing.Point(1052, 63)
        Me.btnimprimirFactura.Name = "btnimprimirFactura"
        Me.btnimprimirFactura.Size = New System.Drawing.Size(138, 35)
        Me.btnimprimirFactura.TabIndex = 14
        Me.btnimprimirFactura.Text = "Imprimir"
        Me.btnimprimirFactura.UseVisualStyleBackColor = False
        '
        'btnbuscarCliente
        '
        Me.btnbuscarCliente.BackColor = System.Drawing.Color.SkyBlue
        Me.btnbuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarCliente.Location = New System.Drawing.Point(90, 63)
        Me.btnbuscarCliente.Name = "btnbuscarCliente"
        Me.btnbuscarCliente.Size = New System.Drawing.Size(138, 35)
        Me.btnbuscarCliente.TabIndex = 13
        Me.btnbuscarCliente.Text = "Buscar Cliente"
        Me.btnbuscarCliente.UseVisualStyleBackColor = False
        '
        'btngenerarFactura
        '
        Me.btngenerarFactura.BackColor = System.Drawing.Color.SkyBlue
        Me.btngenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btngenerarFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngenerarFactura.Location = New System.Drawing.Point(730, 63)
        Me.btngenerarFactura.Name = "btngenerarFactura"
        Me.btngenerarFactura.Size = New System.Drawing.Size(138, 35)
        Me.btngenerarFactura.TabIndex = 12
        Me.btngenerarFactura.Text = "Generar Factura"
        Me.btngenerarFactura.UseVisualStyleBackColor = False
        '
        'gbxlistadoExamenes
        '
        Me.gbxlistadoExamenes.Controls.Add(Me.dgblistadoExamenes)
        Me.gbxlistadoExamenes.Location = New System.Drawing.Point(55, 352)
        Me.gbxlistadoExamenes.Name = "gbxlistadoExamenes"
        Me.gbxlistadoExamenes.Size = New System.Drawing.Size(1192, 205)
        Me.gbxlistadoExamenes.TabIndex = 11
        Me.gbxlistadoExamenes.TabStop = False
        Me.gbxlistadoExamenes.Text = "Listado Exámenes"
        '
        'dgblistadoExamenes
        '
        Me.dgblistadoExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgblistadoExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Examen, Me.Cantidad, Me.PrecioUnitario, Me.Descuento, Me.Subtotal})
        Me.dgblistadoExamenes.Location = New System.Drawing.Point(25, 35)
        Me.dgblistadoExamenes.Name = "dgblistadoExamenes"
        Me.dgblistadoExamenes.RowHeadersWidth = 51
        Me.dgblistadoExamenes.RowTemplate.Height = 24
        Me.dgblistadoExamenes.Size = New System.Drawing.Size(1144, 150)
        Me.dgblistadoExamenes.TabIndex = 0
        '
        'gbxexamen
        '
        Me.gbxexamen.Controls.Add(Me.Button1)
        Me.gbxexamen.Controls.Add(Me.btnagregarExamen)
        Me.gbxexamen.Controls.Add(Me.txtcodigoExamen)
        Me.gbxexamen.Controls.Add(Me.lblcodigoExamen)
        Me.gbxexamen.Location = New System.Drawing.Point(55, 254)
        Me.gbxexamen.Name = "gbxexamen"
        Me.gbxexamen.Size = New System.Drawing.Size(1192, 81)
        Me.gbxexamen.TabIndex = 10
        Me.gbxexamen.TabStop = False
        Me.gbxexamen.Text = "Examen"
        '
        'btnagregarExamen
        '
        Me.btnagregarExamen.BackColor = System.Drawing.Color.SkyBlue
        Me.btnagregarExamen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnagregarExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarExamen.Location = New System.Drawing.Point(736, 27)
        Me.btnagregarExamen.Name = "btnagregarExamen"
        Me.btnagregarExamen.Size = New System.Drawing.Size(138, 35)
        Me.btnagregarExamen.TabIndex = 8
        Me.btnagregarExamen.Text = "Agregar"
        Me.btnagregarExamen.UseVisualStyleBackColor = False
        '
        'txtcodigoExamen
        '
        Me.txtcodigoExamen.Location = New System.Drawing.Point(427, 34)
        Me.txtcodigoExamen.Name = "txtcodigoExamen"
        Me.txtcodigoExamen.Size = New System.Drawing.Size(224, 22)
        Me.txtcodigoExamen.TabIndex = 1
        '
        'lblcodigoExamen
        '
        Me.lblcodigoExamen.AutoSize = True
        Me.lblcodigoExamen.Location = New System.Drawing.Point(255, 37)
        Me.lblcodigoExamen.Name = "lblcodigoExamen"
        Me.lblcodigoExamen.Size = New System.Drawing.Size(128, 17)
        Me.lblcodigoExamen.TabIndex = 0
        Me.lblcodigoExamen.Text = "CÓDIGO EXAMEN:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(270, 698)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'gbxcosto
        '
        Me.gbxcosto.Controls.Add(Me.txttotal)
        Me.gbxcosto.Controls.Add(Me.txtimpuesto)
        Me.gbxcosto.Controls.Add(Me.txtsubtotal)
        Me.gbxcosto.Controls.Add(Me.lbltotal)
        Me.gbxcosto.Controls.Add(Me.lblimpuesto)
        Me.gbxcosto.Controls.Add(Me.lblsubtotal)
        Me.gbxcosto.Location = New System.Drawing.Point(55, 581)
        Me.gbxcosto.Name = "gbxcosto"
        Me.gbxcosto.Size = New System.Drawing.Size(1192, 100)
        Me.gbxcosto.TabIndex = 18
        Me.gbxcosto.TabStop = False
        Me.gbxcosto.Text = "Costo"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(640, 47)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(190, 22)
        Me.txttotal.TabIndex = 5
        '
        'txtimpuesto
        '
        Me.txtimpuesto.Location = New System.Drawing.Point(113, 65)
        Me.txtimpuesto.Name = "txtimpuesto"
        Me.txtimpuesto.ReadOnly = True
        Me.txtimpuesto.Size = New System.Drawing.Size(190, 22)
        Me.txtimpuesto.TabIndex = 4
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(113, 33)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.ReadOnly = True
        Me.txtsubtotal.Size = New System.Drawing.Size(190, 22)
        Me.txtsubtotal.TabIndex = 3
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(572, 47)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(44, 17)
        Me.lbltotal.TabIndex = 2
        Me.lbltotal.Text = "Total:"
        '
        'lblimpuesto
        '
        Me.lblimpuesto.AutoSize = True
        Me.lblimpuesto.Location = New System.Drawing.Point(25, 65)
        Me.lblimpuesto.Name = "lblimpuesto"
        Me.lblimpuesto.Size = New System.Drawing.Size(69, 17)
        Me.lblimpuesto.TabIndex = 1
        Me.lblimpuesto.Text = "Impuesto:"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.AutoSize = True
        Me.lblsubtotal.Location = New System.Drawing.Point(25, 33)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(64, 17)
        Me.lblsubtotal.TabIndex = 0
        Me.lblsubtotal.Text = "Subtotal:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(941, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Buscar Examen"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 120
        '
        'Examen
        '
        Me.Examen.HeaderText = "Examen"
        Me.Examen.MinimumWidth = 100
        Me.Examen.Name = "Examen"
        Me.Examen.ReadOnly = True
        Me.Examen.Width = 300
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.MinimumWidth = 6
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        Me.PrecioUnitario.Width = 120
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.MinimumWidth = 6
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.Width = 80
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 125
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 750)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.gbxcosto)
        Me.Controls.Add(Me.gbxcajero)
        Me.Controls.Add(Me.gbxclientePaciente)
        Me.Controls.Add(Me.btncrearCliente)
        Me.Controls.Add(Me.btnimprimirFactura)
        Me.Controls.Add(Me.btnbuscarCliente)
        Me.Controls.Add(Me.btngenerarFactura)
        Me.Controls.Add(Me.gbxlistadoExamenes)
        Me.Controls.Add(Me.gbxexamen)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.gbxcajero.ResumeLayout(False)
        Me.gbxcajero.PerformLayout()
        Me.gbxclientePaciente.ResumeLayout(False)
        Me.gbxclientePaciente.PerformLayout()
        Me.gbxlistadoExamenes.ResumeLayout(False)
        CType(Me.dgblistadoExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxexamen.ResumeLayout(False)
        Me.gbxexamen.PerformLayout()
        Me.gbxcosto.ResumeLayout(False)
        Me.gbxcosto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxcajero As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblusuarioCajero As Label
    Friend WithEvents gbxclientePaciente As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelefonoCliente As TextBox
    Friend WithEvents txtnombreCliente As TextBox
    Friend WithEvents lbltelefonoCliente As Label
    Friend WithEvents lblnombreCliente As Label
    Friend WithEvents btncrearCliente As Button
    Friend WithEvents btnimprimirFactura As Button
    Friend WithEvents btnbuscarCliente As Button
    Friend WithEvents btngenerarFactura As Button
    Friend WithEvents gbxlistadoExamenes As GroupBox
    Friend WithEvents dgblistadoExamenes As DataGridView
    Friend WithEvents gbxexamen As GroupBox
    Friend WithEvents btnagregarExamen As Button
    Friend WithEvents txtcodigoExamen As TextBox
    Friend WithEvents lblcodigoExamen As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents gbxcosto As GroupBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtimpuesto As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblimpuesto As Label
    Friend WithEvents lblsubtotal As Label
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Examen As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
