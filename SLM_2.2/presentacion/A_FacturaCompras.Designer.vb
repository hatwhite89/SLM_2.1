<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_FacturaCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_FacturaCompras))
        Me.gbxInfoFact = New System.Windows.Forms.GroupBox()
        Me.txtNroFactura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.btnBuscarTerminoPago = New System.Windows.Forms.Button()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.dtpTransaccion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTerminoPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodFactura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.gbxInfoFact.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxInfoFact
        '
        Me.gbxInfoFact.Controls.Add(Me.txtNroFactura)
        Me.gbxInfoFact.Controls.Add(Me.Label10)
        Me.gbxInfoFact.Controls.Add(Me.lblFila)
        Me.gbxInfoFact.Controls.Add(Me.btnBuscarTerminoPago)
        Me.gbxInfoFact.Controls.Add(Me.txtMoneda)
        Me.gbxInfoFact.Controls.Add(Me.Label9)
        Me.gbxInfoFact.Controls.Add(Me.dtpVencimiento)
        Me.gbxInfoFact.Controls.Add(Me.dtpTransaccion)
        Me.gbxInfoFact.Controls.Add(Me.Label8)
        Me.gbxInfoFact.Controls.Add(Me.Label7)
        Me.gbxInfoFact.Controls.Add(Me.txtTerminoPago)
        Me.gbxInfoFact.Controls.Add(Me.Label6)
        Me.gbxInfoFact.Controls.Add(Me.dtpFechaFactura)
        Me.gbxInfoFact.Controls.Add(Me.Label5)
        Me.gbxInfoFact.Controls.Add(Me.txtNombreProveedor)
        Me.gbxInfoFact.Controls.Add(Me.Label4)
        Me.gbxInfoFact.Controls.Add(Me.txtTotal)
        Me.gbxInfoFact.Controls.Add(Me.Label3)
        Me.gbxInfoFact.Controls.Add(Me.txtCodProveedor)
        Me.gbxInfoFact.Controls.Add(Me.Label2)
        Me.gbxInfoFact.Controls.Add(Me.txtCodFactura)
        Me.gbxInfoFact.Controls.Add(Me.Label1)
        Me.gbxInfoFact.Location = New System.Drawing.Point(7, 5)
        Me.gbxInfoFact.Name = "gbxInfoFact"
        Me.gbxInfoFact.Size = New System.Drawing.Size(652, 164)
        Me.gbxInfoFact.TabIndex = 0
        Me.gbxInfoFact.TabStop = False
        Me.gbxInfoFact.Text = "Información de Factura"
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Location = New System.Drawing.Point(306, 25)
        Me.txtNroFactura.MaxLength = 100
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.Size = New System.Drawing.Size(340, 20)
        Me.txtNroFactura.TabIndex = 1
        Me.txtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(198, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nro. Factura"
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(485, 137)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(45, 13)
        Me.lblFila.TabIndex = 20
        Me.lblFila.Text = "Label10"
        Me.lblFila.Visible = False
        '
        'btnBuscarTerminoPago
        '
        Me.btnBuscarTerminoPago.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarTerminoPago.BackgroundImage = CType(resources.GetObject("btnBuscarTerminoPago.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarTerminoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarTerminoPago.FlatAppearance.BorderSize = 0
        Me.btnBuscarTerminoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTerminoPago.Location = New System.Drawing.Point(393, 78)
        Me.btnBuscarTerminoPago.Name = "btnBuscarTerminoPago"
        Me.btnBuscarTerminoPago.Size = New System.Drawing.Size(21, 20)
        Me.btnBuscarTerminoPago.TabIndex = 7
        Me.btnBuscarTerminoPago.UseVisualStyleBackColor = False
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(306, 130)
        Me.txtMoneda.MaxLength = 10
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(84, 20)
        Me.txtMoneda.TabIndex = 9
        Me.txtMoneda.Text = "Lps"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Moneda"
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(109, 129)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(84, 20)
        Me.dtpVencimiento.TabIndex = 5
        '
        'dtpTransaccion
        '
        Me.dtpTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransaccion.Location = New System.Drawing.Point(109, 103)
        Me.dtpTransaccion.Name = "dtpTransaccion"
        Me.dtpTransaccion.Size = New System.Drawing.Size(84, 20)
        Me.dtpTransaccion.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fecha Vencimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Transacción"
        '
        'txtTerminoPago
        '
        Me.txtTerminoPago.Enabled = False
        Me.txtTerminoPago.Location = New System.Drawing.Point(306, 78)
        Me.txtTerminoPago.MaxLength = 10
        Me.txtTerminoPago.Name = "txtTerminoPago"
        Me.txtTerminoPago.Size = New System.Drawing.Size(84, 20)
        Me.txtTerminoPago.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Términos de Pago"
        '
        'dtpFechaFactura
        '
        Me.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFactura.Location = New System.Drawing.Point(109, 77)
        Me.dtpFechaFactura.Name = "dtpFechaFactura"
        Me.dtpFechaFactura.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaFactura.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha Factura"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Enabled = False
        Me.txtNombreProveedor.Location = New System.Drawing.Point(306, 51)
        Me.txtNombreProveedor.MaxLength = 150
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(340, 20)
        Me.txtNombreProveedor.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre Proveedor"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(306, 104)
        Me.txtTotal.MaxLength = 10
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(84, 20)
        Me.txtTotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total"
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.Location = New System.Drawing.Point(109, 51)
        Me.txtCodProveedor.MaxLength = 5
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.Size = New System.Drawing.Size(84, 20)
        Me.txtCodProveedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Proveedor"
        '
        'txtCodFactura
        '
        Me.txtCodFactura.Enabled = False
        Me.txtCodFactura.Location = New System.Drawing.Point(110, 25)
        Me.txtCodFactura.Name = "txtCodFactura"
        Me.txtCodFactura.Size = New System.Drawing.Size(83, 20)
        Me.txtCodFactura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Factura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtDetalleFactura)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 310)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Factura"
        '
        'dtDetalleFactura
        '
        Me.dtDetalleFactura.AllowUserToDeleteRows = False
        Me.dtDetalleFactura.BackgroundColor = System.Drawing.Color.White
        Me.dtDetalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetalleFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuenta, Me.area, Me.Sede, Me.Descripción, Me.Monto})
        Me.dtDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtDetalleFactura.GridColor = System.Drawing.Color.White
        Me.dtDetalleFactura.Location = New System.Drawing.Point(3, 16)
        Me.dtDetalleFactura.Name = "dtDetalleFactura"
        Me.dtDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtDetalleFactura.Size = New System.Drawing.Size(649, 291)
        Me.dtDetalleFactura.TabIndex = 10
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.MaxInputLength = 10
        Me.Cuenta.Name = "Cuenta"
        '
        'area
        '
        Me.area.HeaderText = "Area"
        Me.area.MaxInputLength = 10
        Me.area.Name = "area"
        '
        'Sede
        '
        Me.Sede.HeaderText = "Sede"
        Me.Sede.MaxInputLength = 10
        Me.Sede.Name = "Sede"
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.MaxInputLength = 200
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.MaxInputLength = 10
        Me.Monto.Name = "Monto"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(588, 488)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 44)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(507, 488)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 44)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(426, 488)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 44)
        Me.btnCrear.TabIndex = 12
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Location = New System.Drawing.Point(7, 488)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(33, 37)
        Me.btnRegresar.TabIndex = 14
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'A_FacturaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 540)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoFact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_FacturaCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura de Compra"
        Me.gbxInfoFact.ResumeLayout(False)
        Me.gbxInfoFact.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInfoFact As GroupBox
    Friend WithEvents dtpVencimiento As DateTimePicker
    Friend WithEvents dtpTransaccion As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTerminoPago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaFactura As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodProveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodFactura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMoneda As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtDetalleFactura As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnBuscarTerminoPago As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lblFila As Label
    Friend WithEvents txtNroFactura As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents Sede As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
End Class
