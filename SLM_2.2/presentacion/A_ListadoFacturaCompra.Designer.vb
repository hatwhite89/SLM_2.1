<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoFacturaCompra
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFacturasCompra = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnCrearFactura = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFacturasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFacturasCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Facturas de Compra"
        '
        'dtFacturasCompra
        '
        Me.dtFacturasCompra.AllowUserToAddRows = False
        Me.dtFacturasCompra.AllowUserToDeleteRows = False
        Me.dtFacturasCompra.BackgroundColor = System.Drawing.Color.White
        Me.dtFacturasCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtFacturasCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFacturasCompra.GridColor = System.Drawing.Color.White
        Me.dtFacturasCompra.Location = New System.Drawing.Point(6, 19)
        Me.dtFacturasCompra.Name = "dtFacturasCompra"
        Me.dtFacturasCompra.ReadOnly = True
        Me.dtFacturasCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFacturasCompra.Size = New System.Drawing.Size(573, 292)
        Me.dtFacturasCompra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Proveedor"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(421, 12)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(176, 20)
        Me.txtBusqueda.TabIndex = 3
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCrearFactura
        '
        Me.btnCrearFactura.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrearFactura.FlatAppearance.BorderSize = 0
        Me.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearFactura.ForeColor = System.Drawing.Color.White
        Me.btnCrearFactura.Location = New System.Drawing.Point(452, 364)
        Me.btnCrearFactura.Name = "btnCrearFactura"
        Me.btnCrearFactura.Size = New System.Drawing.Size(145, 23)
        Me.btnCrearFactura.TabIndex = 5
        Me.btnCrearFactura.Text = "Crear Nueva Factura"
        Me.btnCrearFactura.UseVisualStyleBackColor = False
        '
        'A_ListadoFacturaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 397)
        Me.Controls.Add(Me.btnCrearFactura)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_ListadoFacturaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas de Compra"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtFacturasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFacturasCompra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnCrearFactura As Button
End Class
