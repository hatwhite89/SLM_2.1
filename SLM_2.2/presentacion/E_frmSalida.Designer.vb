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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCantidadEntregada = New System.Windows.Forms.TextBox()
        Me.txtEntrega = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAlmacenRecibe = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(935, 514)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtCodOI)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(927, 488)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar Salida"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtCantidadEntregada)
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
        Me.GroupBox2.Controls.Add(Me.txtLote)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 207)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salidas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(528, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Cantidad entregada"
        '
        'txtCantidadEntregada
        '
        Me.txtCantidadEntregada.Location = New System.Drawing.Point(641, 147)
        Me.txtCantidadEntregada.Name = "txtCantidadEntregada"
        Me.txtCantidadEntregada.Size = New System.Drawing.Size(264, 20)
        Me.txtCantidadEntregada.TabIndex = 61
        '
        'txtEntrega
        '
        Me.txtEntrega.Location = New System.Drawing.Point(641, 121)
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(264, 20)
        Me.txtEntrega.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(554, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Entregado por"
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 131)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(419, 69)
        Me.RichTextBox1.TabIndex = 57
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Enviado a"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(543, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Fecha de salida"
        '
        'txtAlmacenRecibe
        '
        Me.txtAlmacenRecibe.Location = New System.Drawing.Point(641, 95)
        Me.txtAlmacenRecibe.Name = "txtAlmacenRecibe"
        Me.txtAlmacenRecibe.ReadOnly = True
        Me.txtAlmacenRecibe.Size = New System.Drawing.Size(264, 20)
        Me.txtAlmacenRecibe.TabIndex = 55
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(641, 16)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(264, 20)
        Me.DateTimePicker2.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Tipo de movimiento"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(315, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'txtPersonaRecibe
        '
        Me.txtPersonaRecibe.Location = New System.Drawing.Point(641, 69)
        Me.txtPersonaRecibe.Name = "txtPersonaRecibe"
        Me.txtPersonaRecibe.ReadOnly = True
        Me.txtPersonaRecibe.Size = New System.Drawing.Size(264, 20)
        Me.txtPersonaRecibe.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(544, 46)
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
        Me.txtAreaSolicitante.Location = New System.Drawing.Point(641, 43)
        Me.txtAreaSolicitante.Name = "txtAreaSolicitante"
        Me.txtAreaSolicitante.ReadOnly = True
        Me.txtAreaSolicitante.Size = New System.Drawing.Size(264, 20)
        Me.txtAreaSolicitante.TabIndex = 48
        '
        'txtCodOI
        '
        Me.txtCodOI.Location = New System.Drawing.Point(106, 46)
        Me.txtCodOI.Name = "txtCodOI"
        Me.txtCodOI.Size = New System.Drawing.Size(79, 20)
        Me.txtCodOI.TabIndex = 10
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(62, 79)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(124, 20)
        Me.txtLote.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(557, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Solicitado por"
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
        Me.Label11.Location = New System.Drawing.Point(12, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "No Orden interna"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(62, 43)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(366, 20)
        Me.txtProducto.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(760, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Registrar Salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(912, 183)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 37)
        Me.Panel1.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Salida del almacen"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.DataGridView3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(927, 488)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial de salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(410, 255)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Seleccionar salida"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.Panel2.Location = New System.Drawing.Point(9, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(909, 46)
        Me.Panel2.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(681, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Desde"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(70, 10)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(374, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Hasta"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(435, 10)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 1
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(9, 89)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(909, 212)
        Me.DataGridView3.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 156)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar salida"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(757, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Modificar Salida"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(84, 24)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 109)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Cantidad"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(44, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Lote"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(84, 76)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(199, 20)
        Me.TextBox7.TabIndex = 17
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(84, 102)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Producto"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(84, 50)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(199, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Cod Producto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(397, 304)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Seleccionar salida"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(397, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Producto"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(32, 70)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 13)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Lote"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(458, 63)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 42
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 41
        '
        'E_frmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 529)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "E_frmSalida"
        Me.Text = "E_frmSalida"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCantidadEntregada As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
