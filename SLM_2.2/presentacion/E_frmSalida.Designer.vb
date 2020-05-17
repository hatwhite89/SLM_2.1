<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_frmSalida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtPersonaRecibe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtAreaSolicitante = New System.Windows.Forms.TextBox()
        Me.txtCodOI = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAlmacenRecibe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(931, 549)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(923, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Salida"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEntrega)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtAlmacenRecibe)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.txtPersonaRecibe)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.txtAreaSolicitante)
        Me.GroupBox2.Controls.Add(Me.txtCodOI)
        Me.GroupBox2.Controls.Add(Me.txtLote)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 468)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar  producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Tipo de movimiento"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(320, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'txtPersonaRecibe
        '
        Me.txtPersonaRecibe.Location = New System.Drawing.Point(641, 73)
        Me.txtPersonaRecibe.Name = "txtPersonaRecibe"
        Me.txtPersonaRecibe.Size = New System.Drawing.Size(264, 20)
        Me.txtPersonaRecibe.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(544, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Area Solicitante"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(247, 79)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(181, 20)
        Me.txtCantidad.TabIndex = 54
        '
        'txtAreaSolicitante
        '
        Me.txtAreaSolicitante.Location = New System.Drawing.Point(641, 42)
        Me.txtAreaSolicitante.Name = "txtAreaSolicitante"
        Me.txtAreaSolicitante.Size = New System.Drawing.Size(264, 20)
        Me.txtAreaSolicitante.TabIndex = 48
        '
        'txtCodOI
        '
        Me.txtCodOI.Location = New System.Drawing.Point(101, 17)
        Me.txtCodOI.Name = "txtCodOI"
        Me.txtCodOI.Size = New System.Drawing.Size(79, 20)
        Me.txtCodOI.TabIndex = 10
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(62, 79)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(124, 20)
        Me.txtLote.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(566, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Entregar a "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "No Orden interna"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(62, 43)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(366, 20)
        Me.txtProducto.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(757, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Registrar Salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(912, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 37)
        Me.Panel1.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(637, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Mofidicar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(530, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(734, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Cancelar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(544, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Fecha de salida"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(641, 14)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(264, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(923, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtAlmacenRecibe
        '
        Me.txtAlmacenRecibe.Location = New System.Drawing.Point(638, 131)
        Me.txtAlmacenRecibe.Name = "txtAlmacenRecibe"
        Me.txtAlmacenRecibe.Size = New System.Drawing.Size(264, 20)
        Me.txtAlmacenRecibe.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(563, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Enviado a"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 131)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(419, 69)
        Me.RichTextBox1.TabIndex = 57
        Me.RichTextBox1.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Observaciones"
        '
        'txtEntrega
        '
        Me.txtEntrega.Location = New System.Drawing.Point(638, 99)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(264, 20)
        Me.txtEntrega.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(563, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Entregar a "
        '
        'E_frmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 573)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "E_frmSalida"
        Me.Text = "E_frmSalida"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtPersonaRecibe As TextBox
    Friend WithEvents txtAreaSolicitante As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodOI As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAlmacenRecibe As TextBox
    Friend WithEvents txtEntrega As TextBox
    Friend WithEvents Label8 As Label
End Class
