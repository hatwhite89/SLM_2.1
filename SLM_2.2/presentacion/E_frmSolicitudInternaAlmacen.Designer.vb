<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_frmSolicitudInternaAlmacen
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadRequerida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAgregarInventario = New System.Windows.Forms.Button()
        Me.txtBuscarIventario = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSede = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.txtCodSolicitud = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(878, 535)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(870, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Crear Solicitud"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 37)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Salidas de almacen"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(615, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(777, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 290)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(859, 216)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle solicitud"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Buscar Producto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(667, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Quitar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(270, 20)
        Me.TextBox1.TabIndex = 8
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 39)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(846, 174)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtLote)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCantidadRequerida)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAgregarInventario)
        Me.GroupBox2.Controls.Add(Me.txtBuscarIventario)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(858, 155)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventario disponible"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(659, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Lote "
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(661, 26)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(187, 20)
        Me.txtLote.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(659, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Producto requerido"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(661, 64)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(187, 20)
        Me.txtProducto.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(659, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad requerida"
        '
        'txtCantidadRequerida
        '
        Me.txtCantidadRequerida.Location = New System.Drawing.Point(660, 103)
        Me.txtCantidadRequerida.Name = "txtCantidadRequerida"
        Me.txtCantidadRequerida.Size = New System.Drawing.Size(187, 20)
        Me.txtCantidadRequerida.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Producto"
        '
        'txtAgregarInventario
        '
        Me.txtAgregarInventario.Location = New System.Drawing.Point(660, 129)
        Me.txtAgregarInventario.Name = "txtAgregarInventario"
        Me.txtAgregarInventario.Size = New System.Drawing.Size(187, 23)
        Me.txtAgregarInventario.TabIndex = 2
        Me.txtAgregarInventario.Text = "Agregar"
        Me.txtAgregarInventario.UseVisualStyleBackColor = True
        '
        'txtBuscarIventario
        '
        Me.txtBuscarIventario.Location = New System.Drawing.Point(111, 14)
        Me.txtBuscarIventario.Name = "txtBuscarIventario"
        Me.txtBuscarIventario.Size = New System.Drawing.Size(270, 20)
        Me.txtBuscarIventario.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 109)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbSede)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamento)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSolicitante)
        Me.GroupBox1.Controls.Add(Me.txtCodSolicitud)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(858, 72)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ubicacion"
        '
        'cmbSede
        '
        Me.cmbSede.FormattingEnabled = True
        Me.cmbSede.Location = New System.Drawing.Point(473, 30)
        Me.cmbSede.Name = "cmbSede"
        Me.cmbSede.Size = New System.Drawing.Size(161, 21)
        Me.cmbSede.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Solicitante"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(649, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(290, 30)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(161, 21)
        Me.cmbDepartamento.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(652, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No Solicitud"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(124, 30)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.ReadOnly = True
        Me.txtSolicitante.Size = New System.Drawing.Size(143, 20)
        Me.txtSolicitante.TabIndex = 2
        '
        'txtCodSolicitud
        '
        Me.txtCodSolicitud.Location = New System.Drawing.Point(6, 30)
        Me.txtCodSolicitud.Name = "txtCodSolicitud"
        Me.txtCodSolicitud.ReadOnly = True
        Me.txtCodSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.txtCodSolicitud.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.DataGridView4)
        Me.TabPage2.Controls.Add(Me.DataGridView3)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.DateTimePicker3)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(870, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mis solicitudes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(731, 36)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Detalle de la orden interna"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(6, 287)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(858, 211)
        Me.DataGridView4.TabIndex = 5
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 83)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(858, 168)
        Me.DataGridView3.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(364, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Hasta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Desde"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(453, 36)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(74, 36)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(858, 71)
        Me.Panel2.TabIndex = 8
        '
        'E_frmSolicitudInternaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 545)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "E_frmSolicitudInternaAlmacen"
        Me.Text = "E_frmSolicitudInternaAlmacen"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCantidadRequerida As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAgregarInventario As Button
    Friend WithEvents txtBuscarIventario As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSede As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSolicitante As TextBox
    Friend WithEvents txtCodSolicitud As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Panel2 As Panel
End Class
