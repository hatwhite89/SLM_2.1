<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citologia
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
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccionEntrega = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdCito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscarCito = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOtrosA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkIndice = New System.Windows.Forms.CheckBox()
        Me.chkCancer = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaMuestra2 = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFechaMuestra = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxFirma1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.cbxIdentificador = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAborto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtGravidad = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpFUP = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFUR = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtOtros2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtMedico)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDireccionEntrega)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEmail2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEmail1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtGenero)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdCito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Factura"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(518, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Buscar Factura"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtMedico
        '
        Me.txtMedico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedico.Enabled = False
        Me.txtMedico.Location = New System.Drawing.Point(430, 102)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(159, 20)
        Me.txtMedico.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(433, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Médico"
        '
        'txtDireccionEntrega
        '
        Me.txtDireccionEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccionEntrega.Enabled = False
        Me.txtDireccionEntrega.Location = New System.Drawing.Point(238, 102)
        Me.txtDireccionEntrega.Name = "txtDireccionEntrega"
        Me.txtDireccionEntrega.Size = New System.Drawing.Size(186, 20)
        Me.txtDireccionEntrega.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Dirección de Entrega"
        '
        'txtEmail2
        '
        Me.txtEmail2.Enabled = False
        Me.txtEmail2.Location = New System.Drawing.Point(122, 102)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(110, 20)
        Me.txtEmail2.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "E-mail 2"
        '
        'txtEmail1
        '
        Me.txtEmail1.Enabled = False
        Me.txtEmail1.Location = New System.Drawing.Point(6, 102)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(110, 20)
        Me.txtEmail1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "E-mail"
        '
        'txtGenero
        '
        Me.txtGenero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenero.Enabled = False
        Me.txtGenero.Location = New System.Drawing.Point(513, 46)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(76, 20)
        Me.txtGenero.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Género"
        '
        'txtEdad
        '
        Me.txtEdad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(431, 46)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(76, 20)
        Me.txtEdad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Edad"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombrePaciente.Enabled = False
        Me.txtNombrePaciente.Location = New System.Drawing.Point(238, 46)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(187, 20)
        Me.txtNombrePaciente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Paciente"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(122, 46)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(110, 20)
        Me.txtNumeroFactura.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. de Factura"
        '
        'txtIdCito
        '
        Me.txtIdCito.Enabled = False
        Me.txtIdCito.Location = New System.Drawing.Point(6, 46)
        Me.txtIdCito.Name = "txtIdCito"
        Me.txtIdCito.Size = New System.Drawing.Size(110, 20)
        Me.txtIdCito.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. de Citología"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnBuscarCito)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 54)
        Me.Panel1.TabIndex = 1
        '
        'btnBuscarCito
        '
        Me.btnBuscarCito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarCito.BackColor = System.Drawing.Color.Orange
        Me.btnBuscarCito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCito.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCito.Location = New System.Drawing.Point(553, 10)
        Me.btnBuscarCito.Name = "btnBuscarCito"
        Me.btnBuscarCito.Size = New System.Drawing.Size(70, 34)
        Me.btnBuscarCito.TabIndex = 4
        Me.btnBuscarCito.Text = "Buscar"
        Me.btnBuscarCito.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(479, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 34)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Agregar Citología"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtOtrosA)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.chkIndice)
        Me.GroupBox2.Controls.Add(Me.chkCancer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 77)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtOtrosA
        '
        Me.txtOtrosA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOtrosA.Location = New System.Drawing.Point(152, 30)
        Me.txtOtrosA.Name = "txtOtrosA"
        Me.txtOtrosA.Size = New System.Drawing.Size(452, 20)
        Me.txtOtrosA.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(155, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Otros"
        '
        'chkIndice
        '
        Me.chkIndice.AutoSize = True
        Me.chkIndice.Location = New System.Drawing.Point(12, 42)
        Me.chkIndice.Name = "chkIndice"
        Me.chkIndice.Size = New System.Drawing.Size(129, 17)
        Me.chkIndice.TabIndex = 1
        Me.chkIndice.Text = "Indice de Maduración"
        Me.chkIndice.UseVisualStyleBackColor = True
        '
        'chkCancer
        '
        Me.chkCancer.AutoSize = True
        Me.chkCancer.Location = New System.Drawing.Point(12, 19)
        Me.chkCancer.Name = "chkCancer"
        Me.chkCancer.Size = New System.Drawing.Size(127, 17)
        Me.chkCancer.TabIndex = 0
        Me.chkCancer.Text = "Detección de Cáncer"
        Me.chkCancer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtOtros2)
        Me.GroupBox3.Controls.Add(Me.dtpFechaMuestra2)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.dtpFechaMuestra)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cbxFirma1)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.cbxIdentificador)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtAborto)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPara)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtGravidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.dtpFUP)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dtpFUR)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtDiagnostico)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 290)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'dtpFechaMuestra2
        '
        Me.dtpFechaMuestra2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaMuestra2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMuestra2.Location = New System.Drawing.Point(420, 211)
        Me.dtpFechaMuestra2.Name = "dtpFechaMuestra2"
        Me.dtpFechaMuestra2.Size = New System.Drawing.Size(167, 20)
        Me.dtpFechaMuestra2.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(417, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Fecha de Informe"
        '
        'dtpFechaMuestra
        '
        Me.dtpFechaMuestra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaMuestra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMuestra.Location = New System.Drawing.Point(420, 161)
        Me.dtpFechaMuestra.Name = "dtpFechaMuestra"
        Me.dtpFechaMuestra.Size = New System.Drawing.Size(167, 20)
        Me.dtpFechaMuestra.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(417, 145)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Fecha de Muestra"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(244, 210)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox3.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(247, 194)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Firma 2"
        '
        'cbxFirma1
        '
        Me.cbxFirma1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxFirma1.FormattingEnabled = True
        Me.cbxFirma1.Location = New System.Drawing.Point(244, 161)
        Me.cbxFirma1.Name = "cbxFirma1"
        Me.cbxFirma1.Size = New System.Drawing.Size(167, 21)
        Me.cbxFirma1.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(247, 145)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Firma 1"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(18, 201)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox3.TabIndex = 30
        Me.CheckBox3.Text = "Sin nota Citología"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'cbxIdentificador
        '
        Me.cbxIdentificador.FormattingEnabled = True
        Me.cbxIdentificador.Location = New System.Drawing.Point(18, 161)
        Me.cbxIdentificador.Name = "cbxIdentificador"
        Me.cbxIdentificador.Size = New System.Drawing.Size(208, 21)
        Me.cbxIdentificador.TabIndex = 29
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Identificador Citología"
        '
        'txtAborto
        '
        Me.txtAborto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAborto.Location = New System.Drawing.Point(477, 120)
        Me.txtAborto.Name = "txtAborto"
        Me.txtAborto.Size = New System.Drawing.Size(110, 20)
        Me.txtAborto.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(480, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Aborto"
        '
        'txtPara
        '
        Me.txtPara.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPara.Location = New System.Drawing.Point(361, 120)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(110, 20)
        Me.txtPara.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(364, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Para"
        '
        'txtGravidad
        '
        Me.txtGravidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGravidad.Location = New System.Drawing.Point(245, 120)
        Me.txtGravidad.Name = "txtGravidad"
        Me.txtGravidad.Size = New System.Drawing.Size(110, 20)
        Me.txtGravidad.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(248, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Gravidad"
        '
        'dtpFUP
        '
        Me.dtpFUP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFUP.Location = New System.Drawing.Point(128, 120)
        Me.dtpFUP.Name = "dtpFUP"
        Me.dtpFUP.Size = New System.Drawing.Size(98, 20)
        Me.dtpFUP.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(125, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "F.U.P."
        '
        'dtpFUR
        '
        Me.dtpFUR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFUR.Location = New System.Drawing.Point(18, 120)
        Me.dtpFUR.Name = "dtpFUR"
        Me.dtpFUR.Size = New System.Drawing.Size(98, 20)
        Me.dtpFUR.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "F.U.R."
        '
        'txtDiagnostico
        '
        Me.txtDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiagnostico.Location = New System.Drawing.Point(18, 33)
        Me.txtDiagnostico.Name = "txtDiagnostico"
        Me.txtDiagnostico.Size = New System.Drawing.Size(570, 58)
        Me.txtDiagnostico.TabIndex = 20
        Me.txtDiagnostico.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Diagnóstico"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(430, 139)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Editar Factura"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtOtros2
        '
        Me.txtOtros2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOtros2.Location = New System.Drawing.Point(18, 252)
        Me.txtOtros2.Name = "txtOtros2"
        Me.txtOtros2.Size = New System.Drawing.Size(569, 20)
        Me.txtOtros2.TabIndex = 22
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(21, 236)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Otros"
        '
        'Citologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 633)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Citologia"
        Me.Text = "Citologia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtMedico As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccionEntrega As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumeroFactura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdCito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscarCito As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOtrosA As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkIndice As CheckBox
    Friend WithEvents chkCancer As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpFechaMuestra2 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents dtpFechaMuestra As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxFirma1 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents cbxIdentificador As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtAborto As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPara As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtGravidad As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpFUP As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpFUR As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDiagnostico As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtOtros2 As TextBox
    Friend WithEvents Label23 As Label
End Class
