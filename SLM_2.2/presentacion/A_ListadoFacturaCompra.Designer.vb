﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPagadas = New System.Windows.Forms.CheckBox()
        Me.chkPendientes = New System.Windows.Forms.CheckBox()
        Me.chkIngresada = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFacturasCompra = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCrearNueva = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFacturasCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnCrearNueva)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpHasta)
        Me.GroupBox1.Controls.Add(Me.dtpDesde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkPagadas)
        Me.GroupBox1.Controls.Add(Me.chkPendientes)
        Me.GroupBox1.Controls.Add(Me.chkIngresada)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtFacturasCompra)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 457)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Facturas de Compra"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(648, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "-"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(457, 50)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(98, 20)
        Me.dtpHasta.TabIndex = 5
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(324, 50)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(98, 20)
        Me.dtpDesde.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Período de Fecha:"
        '
        'chkPagadas
        '
        Me.chkPagadas.AutoSize = True
        Me.chkPagadas.Location = New System.Drawing.Point(493, 25)
        Me.chkPagadas.Name = "chkPagadas"
        Me.chkPagadas.Size = New System.Drawing.Size(68, 17)
        Me.chkPagadas.TabIndex = 3
        Me.chkPagadas.Text = "Pagadas"
        Me.chkPagadas.UseVisualStyleBackColor = True
        '
        'chkPendientes
        '
        Me.chkPendientes.AutoSize = True
        Me.chkPendientes.Location = New System.Drawing.Point(408, 25)
        Me.chkPendientes.Name = "chkPendientes"
        Me.chkPendientes.Size = New System.Drawing.Size(79, 17)
        Me.chkPendientes.TabIndex = 2
        Me.chkPendientes.Text = "Pendientes"
        Me.chkPendientes.UseVisualStyleBackColor = True
        '
        'chkIngresada
        '
        Me.chkIngresada.AutoSize = True
        Me.chkIngresada.Location = New System.Drawing.Point(324, 24)
        Me.chkIngresada.Name = "chkIngresada"
        Me.chkIngresada.Size = New System.Drawing.Size(78, 17)
        Me.chkIngresada.TabIndex = 1
        Me.chkIngresada.Text = "Ingresadas"
        Me.chkIngresada.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Estado:"
        '
        'dtFacturasCompra
        '
        Me.dtFacturasCompra.AllowUserToAddRows = False
        Me.dtFacturasCompra.AllowUserToDeleteRows = False
        Me.dtFacturasCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFacturasCompra.BackgroundColor = System.Drawing.Color.White
        Me.dtFacturasCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtFacturasCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFacturasCompra.GridColor = System.Drawing.Color.White
        Me.dtFacturasCompra.Location = New System.Drawing.Point(6, 76)
        Me.dtFacturasCompra.Name = "dtFacturasCompra"
        Me.dtFacturasCompra.ReadOnly = True
        Me.dtFacturasCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFacturasCompra.Size = New System.Drawing.Size(761, 375)
        Me.dtFacturasCompra.TabIndex = 0
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(107, 23)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(130, 20)
        Me.txtBusqueda.TabIndex = 0
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Proveedor:"
        '
        'btnCrearNueva
        '
        Me.btnCrearNueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearNueva.BackColor = System.Drawing.Color.White
        Me.btnCrearNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearNueva.ForeColor = System.Drawing.Color.Black
        Me.btnCrearNueva.Location = New System.Drawing.Point(648, 17)
        Me.btnCrearNueva.Name = "btnCrearNueva"
        Me.btnCrearNueva.Size = New System.Drawing.Size(119, 23)
        Me.btnCrearNueva.TabIndex = 14
        Me.btnCrearNueva.Text = "Nueva Factura"
        Me.btnCrearNueva.UseVisualStyleBackColor = False
        '
        'A_ListadoFacturaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 481)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "A_ListadoFacturaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas de Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtFacturasCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFacturasCompra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents chkPagadas As CheckBox
    Friend WithEvents chkPendientes As CheckBox
    Friend WithEvents chkIngresada As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCrearNueva As Button
End Class
