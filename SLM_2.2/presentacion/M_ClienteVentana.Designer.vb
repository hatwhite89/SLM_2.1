<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_ClienteVentana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_ClienteVentana))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtnombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombreTerminos = New System.Windows.Forms.TextBox()
        Me.lblterminosPago = New System.Windows.Forms.Label()
        Me.txtnombreCategoria = New System.Windows.Forms.TextBox()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.txtnombreConvenio = New System.Windows.Forms.TextBox()
        Me.lblconvenio = New System.Windows.Forms.Label()
        Me.txtnombreAseguradora = New System.Windows.Forms.TextBox()
        Me.lblaseguradora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtpagoPaciente = New System.Windows.Forms.TextBox()
        Me.txtvuelto = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblvuelto = New System.Windows.Forms.Label()
        Me.lblpagoPaciente = New System.Windows.Forms.Label()
        Me.dgvtabla = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombreCompleto
        '
        Me.txtnombreCompleto.Location = New System.Drawing.Point(245, 167)
        Me.txtnombreCompleto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreCompleto.Name = "txtnombreCompleto"
        Me.txtnombreCompleto.ReadOnly = True
        Me.txtnombreCompleto.Size = New System.Drawing.Size(461, 22)
        Me.txtnombreCompleto.TabIndex = 64
        Me.txtnombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(99, 174)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(121, 17)
        Me.lblnombre.TabIndex = 63
        Me.lblnombre.Text = "Nombre Completo"
        '
        'txtnombreTerminos
        '
        Me.txtnombreTerminos.Location = New System.Drawing.Point(245, 249)
        Me.txtnombreTerminos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreTerminos.Name = "txtnombreTerminos"
        Me.txtnombreTerminos.ReadOnly = True
        Me.txtnombreTerminos.Size = New System.Drawing.Size(313, 22)
        Me.txtnombreTerminos.TabIndex = 115
        Me.txtnombreTerminos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblterminosPago
        '
        Me.lblterminosPago.AutoSize = True
        Me.lblterminosPago.Location = New System.Drawing.Point(95, 251)
        Me.lblterminosPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblterminosPago.Name = "lblterminosPago"
        Me.lblterminosPago.Size = New System.Drawing.Size(124, 17)
        Me.lblterminosPago.TabIndex = 112
        Me.lblterminosPago.Text = "Términos de Pago"
        '
        'txtnombreCategoria
        '
        Me.txtnombreCategoria.Location = New System.Drawing.Point(245, 209)
        Me.txtnombreCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreCategoria.Name = "txtnombreCategoria"
        Me.txtnombreCategoria.ReadOnly = True
        Me.txtnombreCategoria.Size = New System.Drawing.Size(313, 22)
        Me.txtnombreCategoria.TabIndex = 119
        Me.txtnombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Location = New System.Drawing.Point(149, 212)
        Me.lblcategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(69, 17)
        Me.lblcategoria.TabIndex = 116
        Me.lblcategoria.Text = "Categoría"
        '
        'txtnombreConvenio
        '
        Me.txtnombreConvenio.Location = New System.Drawing.Point(685, 209)
        Me.txtnombreConvenio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreConvenio.Name = "txtnombreConvenio"
        Me.txtnombreConvenio.ReadOnly = True
        Me.txtnombreConvenio.Size = New System.Drawing.Size(313, 22)
        Me.txtnombreConvenio.TabIndex = 123
        Me.txtnombreConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblconvenio
        '
        Me.lblconvenio.AutoSize = True
        Me.lblconvenio.Location = New System.Drawing.Point(593, 212)
        Me.lblconvenio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblconvenio.Name = "lblconvenio"
        Me.lblconvenio.Size = New System.Drawing.Size(67, 17)
        Me.lblconvenio.TabIndex = 120
        Me.lblconvenio.Text = "Convenio"
        '
        'txtnombreAseguradora
        '
        Me.txtnombreAseguradora.Location = New System.Drawing.Point(687, 245)
        Me.txtnombreAseguradora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreAseguradora.Name = "txtnombreAseguradora"
        Me.txtnombreAseguradora.ReadOnly = True
        Me.txtnombreAseguradora.Size = New System.Drawing.Size(313, 22)
        Me.txtnombreAseguradora.TabIndex = 127
        Me.txtnombreAseguradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblaseguradora
        '
        Me.lblaseguradora.AutoSize = True
        Me.lblaseguradora.Location = New System.Drawing.Point(571, 249)
        Me.lblaseguradora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblaseguradora.Name = "lblaseguradora"
        Me.lblaseguradora.Size = New System.Drawing.Size(90, 17)
        Me.lblaseguradora.TabIndex = 124
        Me.lblaseguradora.Text = "Aseguradora"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(413, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 132)
        Me.Label1.TabIndex = 128
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(792, 572)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(143, 22)
        Me.txttotal.TabIndex = 135
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpagoPaciente
        '
        Me.txtpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagoPaciente.Location = New System.Drawing.Point(344, 572)
        Me.txtpagoPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpagoPaciente.Name = "txtpagoPaciente"
        Me.txtpagoPaciente.ReadOnly = True
        Me.txtpagoPaciente.Size = New System.Drawing.Size(143, 22)
        Me.txtpagoPaciente.TabIndex = 134
        Me.txtpagoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtvuelto
        '
        Me.txtvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvuelto.Location = New System.Drawing.Point(576, 572)
        Me.txtvuelto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtvuelto.Name = "txtvuelto"
        Me.txtvuelto.ReadOnly = True
        Me.txtvuelto.Size = New System.Drawing.Size(143, 22)
        Me.txtvuelto.TabIndex = 133
        Me.txtvuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(747, 575)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(40, 17)
        Me.lbltotal.TabIndex = 132
        Me.lbltotal.Text = "Total"
        '
        'lblvuelto
        '
        Me.lblvuelto.AutoSize = True
        Me.lblvuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvuelto.Location = New System.Drawing.Point(523, 575)
        Me.lblvuelto.Name = "lblvuelto"
        Me.lblvuelto.Size = New System.Drawing.Size(48, 17)
        Me.lblvuelto.TabIndex = 131
        Me.lblvuelto.Text = "Vuelto"
        '
        'lblpagoPaciente
        '
        Me.lblpagoPaciente.AutoSize = True
        Me.lblpagoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagoPaciente.Location = New System.Drawing.Point(179, 575)
        Me.lblpagoPaciente.Name = "lblpagoPaciente"
        Me.lblpagoPaciente.Size = New System.Drawing.Size(158, 17)
        Me.lblpagoPaciente.TabIndex = 130
        Me.lblpagoPaciente.Text = "A Pagar por el Paciente"
        '
        'dgvtabla
        '
        Me.dgvtabla.AllowUserToAddRows = False
        Me.dgvtabla.AllowUserToDeleteRows = False
        Me.dgvtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgvtabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Cantidad, Me.Precio, Me.Descripcion, Me.FechaEntrega, Me.Descuento, Me.Subtotal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvtabla.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvtabla.GridColor = System.Drawing.Color.White
        Me.dgvtabla.Location = New System.Drawing.Point(33, 297)
        Me.dgvtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvtabla.Name = "dgvtabla"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvtabla.RowHeadersWidth = 51
        Me.dgvtabla.RowTemplate.Height = 24
        Me.dgvtabla.Size = New System.Drawing.Size(1061, 247)
        Me.dgvtabla.TabIndex = 136
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 120
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 60
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 100
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 220
        '
        'FechaEntrega
        '
        Me.FechaEntrega.HeaderText = "Fecha Entrega"
        Me.FechaEntrega.MinimumWidth = 6
        Me.FechaEntrega.Name = "FechaEntrega"
        Me.FechaEntrega.ReadOnly = True
        Me.FechaEntrega.Width = 90
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
        Me.Subtotal.Width = 118
        '
        'M_ClienteVentana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1131, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvtabla)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtpagoPaciente)
        Me.Controls.Add(Me.txtvuelto)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblvuelto)
        Me.Controls.Add(Me.lblpagoPaciente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombreAseguradora)
        Me.Controls.Add(Me.lblaseguradora)
        Me.Controls.Add(Me.txtnombreConvenio)
        Me.Controls.Add(Me.lblconvenio)
        Me.Controls.Add(Me.txtnombreCategoria)
        Me.Controls.Add(Me.lblcategoria)
        Me.Controls.Add(Me.txtnombreTerminos)
        Me.Controls.Add(Me.lblterminosPago)
        Me.Controls.Add(Me.txtnombreCompleto)
        Me.Controls.Add(Me.lblnombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_ClienteVentana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorios Médicos"
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombreCompleto As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtnombreTerminos As TextBox
    Friend WithEvents lblterminosPago As Label
    Friend WithEvents txtnombreCategoria As TextBox
    Friend WithEvents lblcategoria As Label
    Friend WithEvents txtnombreConvenio As TextBox
    Friend WithEvents lblconvenio As Label
    Friend WithEvents txtnombreAseguradora As TextBox
    Friend WithEvents lblaseguradora As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtpagoPaciente As TextBox
    Friend WithEvents txtvuelto As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblvuelto As Label
    Friend WithEvents lblpagoPaciente As Label
    Friend WithEvents dgvtabla As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
End Class
