<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Cliente))
        Me.mtxtidentidadClienteB = New System.Windows.Forms.MaskedTextBox()
        Me.btnbuscarCliente = New System.Windows.Forms.Button()
        Me.lblidCliente = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxinfoCliente = New System.Windows.Forms.GroupBox()
        Me.cmbxClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtapellido2 = New System.Windows.Forms.TextBox()
        Me.txtapellido1 = New System.Windows.Forms.TextBox()
        Me.txtnombre2 = New System.Windows.Forms.TextBox()
        Me.txtnombre1 = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lblcodeTerminoPago = New System.Windows.Forms.Label()
        Me.lblcodeCategoria = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnseleccionarCliente = New System.Windows.Forms.Button()
        Me.txtnombreCategoria = New System.Windows.Forms.TextBox()
        Me.txtnombreClasificacion = New System.Windows.Forms.TextBox()
        Me.txtnombreConvenio = New System.Windows.Forms.TextBox()
        Me.txtnombreTerminos = New System.Windows.Forms.TextBox()
        Me.txtnombreAseguradora = New System.Windows.Forms.TextBox()
        Me.btnguardarCliente = New System.Windows.Forms.Button()
        Me.btnclasificacion = New System.Windows.Forms.Button()
        Me.txtcodigoClasificacion = New System.Windows.Forms.TextBox()
        Me.btnterminosPago = New System.Windows.Forms.Button()
        Me.txtcodigoTermino = New System.Windows.Forms.TextBox()
        Me.btnconvenio = New System.Windows.Forms.Button()
        Me.txtconvenio = New System.Windows.Forms.TextBox()
        Me.btnaseguradora = New System.Windows.Forms.Button()
        Me.txtaseguradora = New System.Windows.Forms.TextBox()
        Me.btncategoria = New System.Windows.Forms.Button()
        Me.dtpfechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.gbxgenero = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbtnmasculino = New System.Windows.Forms.RadioButton()
        Me.rbtnfemenino = New System.Windows.Forms.RadioButton()
        Me.lblclasificacion = New System.Windows.Forms.Label()
        Me.lblconvenio = New System.Windows.Forms.Label()
        Me.lblfechaNacimiento = New System.Windows.Forms.Label()
        Me.lblterminosPago = New System.Windows.Forms.Label()
        Me.lblaseguradora = New System.Windows.Forms.Label()
        Me.txtcodigoCategoria = New System.Windows.Forms.TextBox()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.btnactualizarCliente = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.rtxtdireccion = New System.Windows.Forms.RichTextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txttelefonoCasa = New System.Windows.Forms.TextBox()
        Me.txtscanId = New System.Windows.Forms.TextBox()
        Me.txtnombreCompleto = New System.Windows.Forms.TextBox()
        Me.mtxtidentidad = New System.Windows.Forms.MaskedTextBox()
        Me.lbltelefonoCasa = New System.Windows.Forms.Label()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.lblscanId = New System.Windows.Forms.Label()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.lblcorreo2 = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcelular = New System.Windows.Forms.Label()
        Me.lblidentidadCliente = New System.Windows.Forms.Label()
        Me.txttelefonoTrabajo = New System.Windows.Forms.TextBox()
        Me.lbltelefonoTrabajo = New System.Windows.Forms.Label()
        Me.txtrtn = New System.Windows.Forms.TextBox()
        Me.lblrtn = New System.Windows.Forms.Label()
        Me.lblapellido2 = New System.Windows.Forms.Label()
        Me.lblnombre2 = New System.Windows.Forms.Label()
        Me.lblapellido1 = New System.Windows.Forms.Label()
        Me.lblnombre1 = New System.Windows.Forms.Label()
        Me.btnpaciente = New System.Windows.Forms.Button()
        Me.btnbuscarPorNombre = New System.Windows.Forms.Button()
        Me.lblNombreB = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxinfoCliente.SuspendLayout()
        Me.gbxgenero.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtxtidentidadClienteB
        '
        Me.mtxtidentidadClienteB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtidentidadClienteB.Location = New System.Drawing.Point(164, 41)
        Me.mtxtidentidadClienteB.Mask = "0000-0000-00000"
        Me.mtxtidentidadClienteB.Name = "mtxtidentidadClienteB"
        Me.mtxtidentidadClienteB.Size = New System.Drawing.Size(206, 24)
        Me.mtxtidentidadClienteB.TabIndex = 20
        Me.mtxtidentidadClienteB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnbuscarCliente
        '
        Me.btnbuscarCliente.BackgroundImage = CType(resources.GetObject("btnbuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnbuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarCliente.Location = New System.Drawing.Point(382, 41)
        Me.btnbuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscarCliente.Name = "btnbuscarCliente"
        Me.btnbuscarCliente.Size = New System.Drawing.Size(46, 32)
        Me.btnbuscarCliente.TabIndex = 17
        Me.btnbuscarCliente.UseVisualStyleBackColor = True
        '
        'lblidCliente
        '
        Me.lblidCliente.AutoSize = True
        Me.lblidCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidCliente.Location = New System.Drawing.Point(86, 43)
        Me.lblidCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidCliente.Name = "lblidCliente"
        Me.lblidCliente.Size = New System.Drawing.Size(71, 18)
        Me.lblidCliente.TabIndex = 18
        Me.lblidCliente.Text = "ID Cliente"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1056, 28)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'gbxinfoCliente
        '
        Me.gbxinfoCliente.Controls.Add(Me.cmbxClasificacion)
        Me.gbxinfoCliente.Controls.Add(Me.Label7)
        Me.gbxinfoCliente.Controls.Add(Me.Label5)
        Me.gbxinfoCliente.Controls.Add(Me.Label4)
        Me.gbxinfoCliente.Controls.Add(Me.Label3)
        Me.gbxinfoCliente.Controls.Add(Me.Label2)
        Me.gbxinfoCliente.Controls.Add(Me.Label1)
        Me.gbxinfoCliente.Controls.Add(Me.txtapellido2)
        Me.gbxinfoCliente.Controls.Add(Me.txtapellido1)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombre2)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombre1)
        Me.gbxinfoCliente.Controls.Add(Me.txtEdad)
        Me.gbxinfoCliente.Controls.Add(Me.lblcodeTerminoPago)
        Me.gbxinfoCliente.Controls.Add(Me.lblcodeCategoria)
        Me.gbxinfoCliente.Controls.Add(Me.btnnuevo)
        Me.gbxinfoCliente.Controls.Add(Me.btnseleccionarCliente)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombreCategoria)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombreClasificacion)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombreConvenio)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombreTerminos)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombreAseguradora)
        Me.gbxinfoCliente.Controls.Add(Me.btnguardarCliente)
        Me.gbxinfoCliente.Controls.Add(Me.btnclasificacion)
        Me.gbxinfoCliente.Controls.Add(Me.txtcodigoClasificacion)
        Me.gbxinfoCliente.Controls.Add(Me.btnterminosPago)
        Me.gbxinfoCliente.Controls.Add(Me.txtcodigoTermino)
        Me.gbxinfoCliente.Controls.Add(Me.btnconvenio)
        Me.gbxinfoCliente.Controls.Add(Me.txtconvenio)
        Me.gbxinfoCliente.Controls.Add(Me.btnaseguradora)
        Me.gbxinfoCliente.Controls.Add(Me.txtaseguradora)
        Me.gbxinfoCliente.Controls.Add(Me.btncategoria)
        Me.gbxinfoCliente.Controls.Add(Me.dtpfechaNacimiento)
        Me.gbxinfoCliente.Controls.Add(Me.gbxgenero)
        Me.gbxinfoCliente.Controls.Add(Me.lblclasificacion)
        Me.gbxinfoCliente.Controls.Add(Me.lblconvenio)
        Me.gbxinfoCliente.Controls.Add(Me.lblfechaNacimiento)
        Me.gbxinfoCliente.Controls.Add(Me.lblterminosPago)
        Me.gbxinfoCliente.Controls.Add(Me.lblaseguradora)
        Me.gbxinfoCliente.Controls.Add(Me.txtcodigoCategoria)
        Me.gbxinfoCliente.Controls.Add(Me.lblcategoria)
        Me.gbxinfoCliente.Controls.Add(Me.btnactualizarCliente)
        Me.gbxinfoCliente.Controls.Add(Me.txtcodigo)
        Me.gbxinfoCliente.Controls.Add(Me.rtxtdireccion)
        Me.gbxinfoCliente.Controls.Add(Me.txtcorreo)
        Me.gbxinfoCliente.Controls.Add(Me.lbldireccion)
        Me.gbxinfoCliente.Controls.Add(Me.lblcodigo)
        Me.gbxinfoCliente.Controls.Add(Me.txttelefonoCasa)
        Me.gbxinfoCliente.Controls.Add(Me.txtscanId)
        Me.gbxinfoCliente.Controls.Add(Me.txtnombreCompleto)
        Me.gbxinfoCliente.Controls.Add(Me.mtxtidentidad)
        Me.gbxinfoCliente.Controls.Add(Me.lbltelefonoCasa)
        Me.gbxinfoCliente.Controls.Add(Me.lblcorreo)
        Me.gbxinfoCliente.Controls.Add(Me.lblscanId)
        Me.gbxinfoCliente.Controls.Add(Me.txtcorreo2)
        Me.gbxinfoCliente.Controls.Add(Me.lblcorreo2)
        Me.gbxinfoCliente.Controls.Add(Me.txtcelular)
        Me.gbxinfoCliente.Controls.Add(Me.lblnombre)
        Me.gbxinfoCliente.Controls.Add(Me.lblcelular)
        Me.gbxinfoCliente.Controls.Add(Me.lblidentidadCliente)
        Me.gbxinfoCliente.Controls.Add(Me.txttelefonoTrabajo)
        Me.gbxinfoCliente.Controls.Add(Me.lbltelefonoTrabajo)
        Me.gbxinfoCliente.Controls.Add(Me.txtrtn)
        Me.gbxinfoCliente.Controls.Add(Me.lblrtn)
        Me.gbxinfoCliente.Controls.Add(Me.lblapellido2)
        Me.gbxinfoCliente.Controls.Add(Me.lblnombre2)
        Me.gbxinfoCliente.Controls.Add(Me.lblapellido1)
        Me.gbxinfoCliente.Controls.Add(Me.lblnombre1)
        Me.gbxinfoCliente.Location = New System.Drawing.Point(24, 79)
        Me.gbxinfoCliente.Name = "gbxinfoCliente"
        Me.gbxinfoCliente.Size = New System.Drawing.Size(996, 473)
        Me.gbxinfoCliente.TabIndex = 54
        Me.gbxinfoCliente.TabStop = False
        Me.gbxinfoCliente.Text = "Información de Cliente/Paciente"
        Me.gbxinfoCliente.Visible = False
        '
        'cmbxClasificacion
        '
        Me.cmbxClasificacion.FormattingEnabled = True
        Me.cmbxClasificacion.Location = New System.Drawing.Point(232, 355)
        Me.cmbxClasificacion.Name = "cmbxClasificacion"
        Me.cmbxClasificacion.Size = New System.Drawing.Size(404, 24)
        Me.cmbxClasificacion.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(361, 33)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 17)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(642, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(66, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(66, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(63, 361)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(26, 302)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "*"
        '
        'txtapellido2
        '
        Me.txtapellido2.Location = New System.Drawing.Point(458, 114)
        Me.txtapellido2.MaxLength = 20
        Me.txtapellido2.Name = "txtapellido2"
        Me.txtapellido2.Size = New System.Drawing.Size(179, 22)
        Me.txtapellido2.TabIndex = 125
        Me.txtapellido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtapellido1
        '
        Me.txtapellido1.Location = New System.Drawing.Point(175, 114)
        Me.txtapellido1.MaxLength = 20
        Me.txtapellido1.Name = "txtapellido1"
        Me.txtapellido1.Size = New System.Drawing.Size(179, 22)
        Me.txtapellido1.TabIndex = 124
        Me.txtapellido1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(458, 86)
        Me.txtnombre2.MaxLength = 20
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(179, 22)
        Me.txtnombre2.TabIndex = 123
        Me.txtnombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(174, 86)
        Me.txtnombre1.MaxLength = 20
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(179, 22)
        Me.txtnombre1.TabIndex = 122
        Me.txtnombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(911, 89)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.ReadOnly = True
        Me.txtEdad.Size = New System.Drawing.Size(72, 22)
        Me.txtEdad.TabIndex = 121
        '
        'lblcodeTerminoPago
        '
        Me.lblcodeTerminoPago.AutoSize = True
        Me.lblcodeTerminoPago.Location = New System.Drawing.Point(26, 301)
        Me.lblcodeTerminoPago.Name = "lblcodeTerminoPago"
        Me.lblcodeTerminoPago.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeTerminoPago.TabIndex = 120
        Me.lblcodeTerminoPago.Visible = False
        '
        'lblcodeCategoria
        '
        Me.lblcodeCategoria.AutoSize = True
        Me.lblcodeCategoria.Location = New System.Drawing.Point(372, 33)
        Me.lblcodeCategoria.Name = "lblcodeCategoria"
        Me.lblcodeCategoria.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeCategoria.TabIndex = 119
        Me.lblcodeCategoria.Visible = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.SkyBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(187, 410)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(130, 38)
        Me.btnnuevo.TabIndex = 116
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnseleccionarCliente
        '
        Me.btnseleccionarCliente.BackColor = System.Drawing.Color.SkyBlue
        Me.btnseleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnseleccionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseleccionarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnseleccionarCliente.Location = New System.Drawing.Point(650, 410)
        Me.btnseleccionarCliente.Name = "btnseleccionarCliente"
        Me.btnseleccionarCliente.Size = New System.Drawing.Size(130, 38)
        Me.btnseleccionarCliente.TabIndex = 115
        Me.btnseleccionarCliente.Text = "Seleccionar"
        Me.btnseleccionarCliente.UseVisualStyleBackColor = False
        '
        'txtnombreCategoria
        '
        Me.txtnombreCategoria.Location = New System.Drawing.Point(645, 30)
        Me.txtnombreCategoria.Name = "txtnombreCategoria"
        Me.txtnombreCategoria.ReadOnly = True
        Me.txtnombreCategoria.Size = New System.Drawing.Size(338, 22)
        Me.txtnombreCategoria.TabIndex = 114
        '
        'txtnombreClasificacion
        '
        Me.txtnombreClasificacion.Location = New System.Drawing.Point(368, 355)
        Me.txtnombreClasificacion.Name = "txtnombreClasificacion"
        Me.txtnombreClasificacion.ReadOnly = True
        Me.txtnombreClasificacion.Size = New System.Drawing.Size(267, 22)
        Me.txtnombreClasificacion.TabIndex = 113
        Me.txtnombreClasificacion.Visible = False
        '
        'txtnombreConvenio
        '
        Me.txtnombreConvenio.Location = New System.Drawing.Point(368, 327)
        Me.txtnombreConvenio.Name = "txtnombreConvenio"
        Me.txtnombreConvenio.ReadOnly = True
        Me.txtnombreConvenio.Size = New System.Drawing.Size(267, 22)
        Me.txtnombreConvenio.TabIndex = 112
        '
        'txtnombreTerminos
        '
        Me.txtnombreTerminos.Location = New System.Drawing.Point(368, 299)
        Me.txtnombreTerminos.Name = "txtnombreTerminos"
        Me.txtnombreTerminos.ReadOnly = True
        Me.txtnombreTerminos.Size = New System.Drawing.Size(268, 22)
        Me.txtnombreTerminos.TabIndex = 111
        '
        'txtnombreAseguradora
        '
        Me.txtnombreAseguradora.Location = New System.Drawing.Point(368, 271)
        Me.txtnombreAseguradora.Name = "txtnombreAseguradora"
        Me.txtnombreAseguradora.ReadOnly = True
        Me.txtnombreAseguradora.Size = New System.Drawing.Size(267, 22)
        Me.txtnombreAseguradora.TabIndex = 110
        '
        'btnguardarCliente
        '
        Me.btnguardarCliente.BackColor = System.Drawing.Color.SkyBlue
        Me.btnguardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnguardarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnguardarCliente.Location = New System.Drawing.Point(341, 410)
        Me.btnguardarCliente.Name = "btnguardarCliente"
        Me.btnguardarCliente.Size = New System.Drawing.Size(130, 38)
        Me.btnguardarCliente.TabIndex = 109
        Me.btnguardarCliente.Text = "Guardar"
        Me.btnguardarCliente.UseVisualStyleBackColor = False
        '
        'btnclasificacion
        '
        Me.btnclasificacion.BackColor = System.Drawing.Color.White
        Me.btnclasificacion.BackgroundImage = CType(resources.GetObject("btnclasificacion.BackgroundImage"), System.Drawing.Image)
        Me.btnclasificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclasificacion.FlatAppearance.BorderSize = 0
        Me.btnclasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclasificacion.Location = New System.Drawing.Point(177, 355)
        Me.btnclasificacion.Name = "btnclasificacion"
        Me.btnclasificacion.Size = New System.Drawing.Size(49, 22)
        Me.btnclasificacion.TabIndex = 108
        Me.btnclasificacion.Text = "..."
        Me.btnclasificacion.UseVisualStyleBackColor = False
        '
        'txtcodigoClasificacion
        '
        Me.txtcodigoClasificacion.Location = New System.Drawing.Point(232, 355)
        Me.txtcodigoClasificacion.Name = "txtcodigoClasificacion"
        Me.txtcodigoClasificacion.ReadOnly = True
        Me.txtcodigoClasificacion.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoClasificacion.TabIndex = 107
        Me.txtcodigoClasificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtcodigoClasificacion.Visible = False
        '
        'btnterminosPago
        '
        Me.btnterminosPago.BackColor = System.Drawing.Color.White
        Me.btnterminosPago.BackgroundImage = CType(resources.GetObject("btnterminosPago.BackgroundImage"), System.Drawing.Image)
        Me.btnterminosPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnterminosPago.FlatAppearance.BorderSize = 0
        Me.btnterminosPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnterminosPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnterminosPago.Location = New System.Drawing.Point(175, 299)
        Me.btnterminosPago.Name = "btnterminosPago"
        Me.btnterminosPago.Size = New System.Drawing.Size(49, 22)
        Me.btnterminosPago.TabIndex = 106
        Me.btnterminosPago.Text = "..."
        Me.btnterminosPago.UseVisualStyleBackColor = False
        '
        'txtcodigoTermino
        '
        Me.txtcodigoTermino.Location = New System.Drawing.Point(230, 299)
        Me.txtcodigoTermino.Name = "txtcodigoTermino"
        Me.txtcodigoTermino.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoTermino.TabIndex = 105
        Me.txtcodigoTermino.Text = "CO"
        Me.txtcodigoTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnconvenio
        '
        Me.btnconvenio.BackColor = System.Drawing.Color.White
        Me.btnconvenio.BackgroundImage = CType(resources.GetObject("btnconvenio.BackgroundImage"), System.Drawing.Image)
        Me.btnconvenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnconvenio.Enabled = False
        Me.btnconvenio.FlatAppearance.BorderSize = 0
        Me.btnconvenio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconvenio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvenio.Location = New System.Drawing.Point(177, 327)
        Me.btnconvenio.Name = "btnconvenio"
        Me.btnconvenio.Size = New System.Drawing.Size(49, 22)
        Me.btnconvenio.TabIndex = 104
        Me.btnconvenio.UseVisualStyleBackColor = False
        '
        'txtconvenio
        '
        Me.txtconvenio.Location = New System.Drawing.Point(232, 327)
        Me.txtconvenio.Name = "txtconvenio"
        Me.txtconvenio.ReadOnly = True
        Me.txtconvenio.Size = New System.Drawing.Size(125, 22)
        Me.txtconvenio.TabIndex = 103
        Me.txtconvenio.Text = "x"
        Me.txtconvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnaseguradora
        '
        Me.btnaseguradora.BackColor = System.Drawing.Color.White
        Me.btnaseguradora.BackgroundImage = CType(resources.GetObject("btnaseguradora.BackgroundImage"), System.Drawing.Image)
        Me.btnaseguradora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnaseguradora.Enabled = False
        Me.btnaseguradora.FlatAppearance.BorderSize = 0
        Me.btnaseguradora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaseguradora.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaseguradora.Location = New System.Drawing.Point(175, 271)
        Me.btnaseguradora.Name = "btnaseguradora"
        Me.btnaseguradora.Size = New System.Drawing.Size(49, 22)
        Me.btnaseguradora.TabIndex = 102
        Me.btnaseguradora.UseVisualStyleBackColor = False
        '
        'txtaseguradora
        '
        Me.txtaseguradora.Location = New System.Drawing.Point(230, 271)
        Me.txtaseguradora.Name = "txtaseguradora"
        Me.txtaseguradora.ReadOnly = True
        Me.txtaseguradora.Size = New System.Drawing.Size(125, 22)
        Me.txtaseguradora.TabIndex = 101
        Me.txtaseguradora.Text = "x"
        Me.txtaseguradora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncategoria
        '
        Me.btncategoria.BackColor = System.Drawing.Color.White
        Me.btncategoria.BackgroundImage = CType(resources.GetObject("btncategoria.BackgroundImage"), System.Drawing.Image)
        Me.btncategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncategoria.FlatAppearance.BorderSize = 0
        Me.btncategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncategoria.Location = New System.Drawing.Point(455, 30)
        Me.btncategoria.Name = "btncategoria"
        Me.btncategoria.Size = New System.Drawing.Size(49, 22)
        Me.btncategoria.TabIndex = 100
        Me.btncategoria.Text = "..."
        Me.btncategoria.UseVisualStyleBackColor = False
        '
        'dtpfechaNacimiento
        '
        Me.dtpfechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaNacimiento.Location = New System.Drawing.Point(790, 89)
        Me.dtpfechaNacimiento.Name = "dtpfechaNacimiento"
        Me.dtpfechaNacimiento.Size = New System.Drawing.Size(115, 22)
        Me.dtpfechaNacimiento.TabIndex = 99
        '
        'gbxgenero
        '
        Me.gbxgenero.Controls.Add(Me.Label6)
        Me.gbxgenero.Controls.Add(Me.rbtnmasculino)
        Me.gbxgenero.Controls.Add(Me.rbtnfemenino)
        Me.gbxgenero.Location = New System.Drawing.Point(790, 114)
        Me.gbxgenero.Name = "gbxgenero"
        Me.gbxgenero.Size = New System.Drawing.Size(193, 74)
        Me.gbxgenero.TabIndex = 98
        Me.gbxgenero.TabStop = False
        Me.gbxgenero.Text = "Género"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(7, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "*"
        '
        'rbtnmasculino
        '
        Me.rbtnmasculino.AutoSize = True
        Me.rbtnmasculino.Location = New System.Drawing.Point(41, 21)
        Me.rbtnmasculino.Name = "rbtnmasculino"
        Me.rbtnmasculino.Size = New System.Drawing.Size(92, 21)
        Me.rbtnmasculino.TabIndex = 8
        Me.rbtnmasculino.TabStop = True
        Me.rbtnmasculino.Text = "Masculino"
        Me.rbtnmasculino.UseVisualStyleBackColor = True
        '
        'rbtnfemenino
        '
        Me.rbtnfemenino.AutoSize = True
        Me.rbtnfemenino.Location = New System.Drawing.Point(41, 47)
        Me.rbtnfemenino.Name = "rbtnfemenino"
        Me.rbtnfemenino.Size = New System.Drawing.Size(91, 21)
        Me.rbtnfemenino.TabIndex = 9
        Me.rbtnfemenino.TabStop = True
        Me.rbtnfemenino.Text = "Femenino"
        Me.rbtnfemenino.UseVisualStyleBackColor = True
        '
        'lblclasificacion
        '
        Me.lblclasificacion.AutoSize = True
        Me.lblclasificacion.Location = New System.Drawing.Point(84, 360)
        Me.lblclasificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblclasificacion.Name = "lblclasificacion"
        Me.lblclasificacion.Size = New System.Drawing.Size(86, 17)
        Me.lblclasificacion.TabIndex = 96
        Me.lblclasificacion.Text = "Clasificación"
        '
        'lblconvenio
        '
        Me.lblconvenio.AutoSize = True
        Me.lblconvenio.Location = New System.Drawing.Point(100, 328)
        Me.lblconvenio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblconvenio.Name = "lblconvenio"
        Me.lblconvenio.Size = New System.Drawing.Size(67, 17)
        Me.lblconvenio.TabIndex = 94
        Me.lblconvenio.Text = "Convenio"
        '
        'lblfechaNacimiento
        '
        Me.lblfechaNacimiento.AutoSize = True
        Me.lblfechaNacimiento.Location = New System.Drawing.Point(657, 91)
        Me.lblfechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfechaNacimiento.Name = "lblfechaNacimiento"
        Me.lblfechaNacimiento.Size = New System.Drawing.Size(121, 17)
        Me.lblfechaNacimiento.TabIndex = 93
        Me.lblfechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblterminosPago
        '
        Me.lblterminosPago.AutoSize = True
        Me.lblterminosPago.Location = New System.Drawing.Point(43, 302)
        Me.lblterminosPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblterminosPago.Name = "lblterminosPago"
        Me.lblterminosPago.Size = New System.Drawing.Size(124, 17)
        Me.lblterminosPago.TabIndex = 91
        Me.lblterminosPago.Text = "Términos de Pago"
        '
        'lblaseguradora
        '
        Me.lblaseguradora.AutoSize = True
        Me.lblaseguradora.Location = New System.Drawing.Point(74, 274)
        Me.lblaseguradora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblaseguradora.Name = "lblaseguradora"
        Me.lblaseguradora.Size = New System.Drawing.Size(90, 17)
        Me.lblaseguradora.TabIndex = 89
        Me.lblaseguradora.Text = "Aseguradora"
        '
        'txtcodigoCategoria
        '
        Me.txtcodigoCategoria.Location = New System.Drawing.Point(510, 30)
        Me.txtcodigoCategoria.MaxLength = 20
        Me.txtcodigoCategoria.Name = "txtcodigoCategoria"
        Me.txtcodigoCategoria.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoCategoria.TabIndex = 88
        Me.txtcodigoCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Location = New System.Drawing.Point(382, 30)
        Me.lblcategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(69, 17)
        Me.lblcategoria.TabIndex = 87
        Me.lblcategoria.Text = "Categoría"
        '
        'btnactualizarCliente
        '
        Me.btnactualizarCliente.BackColor = System.Drawing.Color.SkyBlue
        Me.btnactualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnactualizarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactualizarCliente.ForeColor = System.Drawing.Color.Black
        Me.btnactualizarCliente.Location = New System.Drawing.Point(497, 410)
        Me.btnactualizarCliente.Name = "btnactualizarCliente"
        Me.btnactualizarCliente.Size = New System.Drawing.Size(130, 38)
        Me.btnactualizarCliente.TabIndex = 66
        Me.btnactualizarCliente.Text = "Modificar"
        Me.btnactualizarCliente.UseVisualStyleBackColor = False
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(175, 30)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 86
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtxtdireccion
        '
        Me.rtxtdireccion.Location = New System.Drawing.Point(174, 170)
        Me.rtxtdireccion.MaxLength = 200
        Me.rtxtdireccion.Name = "rtxtdireccion"
        Me.rtxtdireccion.Size = New System.Drawing.Size(461, 95)
        Me.rtxtdireccion.TabIndex = 61
        Me.rtxtdireccion.Text = ""
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(790, 278)
        Me.txtcorreo.MaxLength = 100
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(193, 22)
        Me.txtcorreo.TabIndex = 65
        Me.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(23, 173)
        Me.lbldireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(145, 17)
        Me.lbldireccion.TabIndex = 60
        Me.lbldireccion.Text = "Dirección Facturación"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(115, 30)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 85
        Me.lblcodigo.Text = "Código"
        '
        'txttelefonoCasa
        '
        Me.txttelefonoCasa.Location = New System.Drawing.Point(790, 194)
        Me.txttelefonoCasa.MaxLength = 20
        Me.txttelefonoCasa.Name = "txttelefonoCasa"
        Me.txttelefonoCasa.Size = New System.Drawing.Size(193, 22)
        Me.txttelefonoCasa.TabIndex = 64
        Me.txttelefonoCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtscanId
        '
        Me.txtscanId.Location = New System.Drawing.Point(174, 58)
        Me.txtscanId.MaxLength = 50
        Me.txtscanId.Name = "txtscanId"
        Me.txtscanId.Size = New System.Drawing.Size(179, 22)
        Me.txtscanId.TabIndex = 84
        Me.txtscanId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombreCompleto
        '
        Me.txtnombreCompleto.Location = New System.Drawing.Point(175, 142)
        Me.txtnombreCompleto.MaxLength = 80
        Me.txtnombreCompleto.Name = "txtnombreCompleto"
        Me.txtnombreCompleto.ReadOnly = True
        Me.txtnombreCompleto.Size = New System.Drawing.Size(461, 22)
        Me.txtnombreCompleto.TabIndex = 62
        Me.txtnombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtidentidad
        '
        Me.mtxtidentidad.BackColor = System.Drawing.Color.White
        Me.mtxtidentidad.Location = New System.Drawing.Point(457, 58)
        Me.mtxtidentidad.Mask = "0000-0000-00000"
        Me.mtxtidentidad.Name = "mtxtidentidad"
        Me.mtxtidentidad.Size = New System.Drawing.Size(179, 22)
        Me.mtxtidentidad.TabIndex = 63
        Me.mtxtidentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltelefonoCasa
        '
        Me.lbltelefonoCasa.AutoSize = True
        Me.lbltelefonoCasa.Location = New System.Drawing.Point(674, 194)
        Me.lbltelefonoCasa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelefonoCasa.Name = "lbltelefonoCasa"
        Me.lbltelefonoCasa.Size = New System.Drawing.Size(100, 17)
        Me.lbltelefonoCasa.TabIndex = 59
        Me.lbltelefonoCasa.Text = "Teléfono Casa"
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(663, 280)
        Me.lblcorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(111, 17)
        Me.lblcorreo.TabIndex = 58
        Me.lblcorreo.Text = "Correo Personal"
        '
        'lblscanId
        '
        Me.lblscanId.AutoSize = True
        Me.lblscanId.Location = New System.Drawing.Point(105, 64)
        Me.lblscanId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblscanId.Name = "lblscanId"
        Me.lblscanId.Size = New System.Drawing.Size(62, 17)
        Me.lblscanId.TabIndex = 83
        Me.lblscanId.Text = "SCAN ID"
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(790, 306)
        Me.txtcorreo2.MaxLength = 100
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.Size = New System.Drawing.Size(193, 22)
        Me.txtcorreo2.TabIndex = 82
        Me.txtcorreo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcorreo2
        '
        Me.lblcorreo2.AutoSize = True
        Me.lblcorreo2.Location = New System.Drawing.Point(649, 309)
        Me.lblcorreo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo2.Name = "lblcorreo2"
        Me.lblcorreo2.Size = New System.Drawing.Size(132, 17)
        Me.lblcorreo2.TabIndex = 81
        Me.lblcorreo2.Text = "Correo (Alternativo)"
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(790, 250)
        Me.txtcelular.MaxLength = 20
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(193, 22)
        Me.txtcelular.TabIndex = 80
        Me.txtcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(47, 145)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(121, 17)
        Me.lblnombre.TabIndex = 56
        Me.lblnombre.Text = "Nombre Completo"
        '
        'lblcelular
        '
        Me.lblcelular.AutoSize = True
        Me.lblcelular.Location = New System.Drawing.Point(720, 252)
        Me.lblcelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(52, 17)
        Me.lblcelular.TabIndex = 79
        Me.lblcelular.Text = "Celular"
        '
        'lblidentidadCliente
        '
        Me.lblidentidadCliente.AutoSize = True
        Me.lblidentidadCliente.Location = New System.Drawing.Point(387, 61)
        Me.lblidentidadCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidentidadCliente.Name = "lblidentidadCliente"
        Me.lblidentidadCliente.Size = New System.Drawing.Size(66, 17)
        Me.lblidentidadCliente.TabIndex = 57
        Me.lblidentidadCliente.Text = "Identidad"
        '
        'txttelefonoTrabajo
        '
        Me.txttelefonoTrabajo.Location = New System.Drawing.Point(790, 222)
        Me.txttelefonoTrabajo.MaxLength = 20
        Me.txttelefonoTrabajo.Name = "txttelefonoTrabajo"
        Me.txttelefonoTrabajo.Size = New System.Drawing.Size(193, 22)
        Me.txttelefonoTrabajo.TabIndex = 78
        Me.txttelefonoTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltelefonoTrabajo
        '
        Me.lbltelefonoTrabajo.AutoSize = True
        Me.lbltelefonoTrabajo.Location = New System.Drawing.Point(657, 225)
        Me.lbltelefonoTrabajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelefonoTrabajo.Name = "lbltelefonoTrabajo"
        Me.lbltelefonoTrabajo.Size = New System.Drawing.Size(117, 17)
        Me.lbltelefonoTrabajo.TabIndex = 77
        Me.lbltelefonoTrabajo.Text = "Teléfono Trabajo"
        '
        'txtrtn
        '
        Me.txtrtn.Location = New System.Drawing.Point(790, 61)
        Me.txtrtn.MaxLength = 20
        Me.txtrtn.Name = "txtrtn"
        Me.txtrtn.Size = New System.Drawing.Size(193, 22)
        Me.txtrtn.TabIndex = 76
        Me.txtrtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblrtn
        '
        Me.lblrtn.AutoSize = True
        Me.lblrtn.Location = New System.Drawing.Point(737, 61)
        Me.lblrtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrtn.Name = "lblrtn"
        Me.lblrtn.Size = New System.Drawing.Size(37, 17)
        Me.lblrtn.TabIndex = 75
        Me.lblrtn.Text = "RTN"
        '
        'lblapellido2
        '
        Me.lblapellido2.AutoSize = True
        Me.lblapellido2.Location = New System.Drawing.Point(369, 117)
        Me.lblapellido2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblapellido2.Name = "lblapellido2"
        Me.lblapellido2.Size = New System.Drawing.Size(86, 17)
        Me.lblapellido2.TabIndex = 73
        Me.lblapellido2.Text = "2do Apellido"
        '
        'lblnombre2
        '
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(370, 89)
        Me.lblnombre2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(86, 17)
        Me.lblnombre2.TabIndex = 71
        Me.lblnombre2.Text = "2do Nombre"
        '
        'lblapellido1
        '
        Me.lblapellido1.AutoSize = True
        Me.lblapellido1.Location = New System.Drawing.Point(81, 117)
        Me.lblapellido1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblapellido1.Name = "lblapellido1"
        Me.lblapellido1.Size = New System.Drawing.Size(83, 17)
        Me.lblapellido1.TabIndex = 69
        Me.lblapellido1.Text = "1er Apellido"
        '
        'lblnombre1
        '
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(84, 89)
        Me.lblnombre1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(83, 17)
        Me.lblnombre1.TabIndex = 67
        Me.lblnombre1.Text = "1er Nombre"
        '
        'btnpaciente
        '
        Me.btnpaciente.BackColor = System.Drawing.Color.SkyBlue
        Me.btnpaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaciente.ForeColor = System.Drawing.Color.Black
        Me.btnpaciente.Location = New System.Drawing.Point(840, 37)
        Me.btnpaciente.Name = "btnpaciente"
        Me.btnpaciente.Size = New System.Drawing.Size(130, 32)
        Me.btnpaciente.TabIndex = 117
        Me.btnpaciente.Text = "Paciente"
        Me.btnpaciente.UseVisualStyleBackColor = False
        '
        'btnbuscarPorNombre
        '
        Me.btnbuscarPorNombre.BackgroundImage = CType(resources.GetObject("btnbuscarPorNombre.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarPorNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarPorNombre.FlatAppearance.BorderSize = 0
        Me.btnbuscarPorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarPorNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarPorNombre.Location = New System.Drawing.Point(733, 39)
        Me.btnbuscarPorNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.btnbuscarPorNombre.Name = "btnbuscarPorNombre"
        Me.btnbuscarPorNombre.Size = New System.Drawing.Size(46, 32)
        Me.btnbuscarPorNombre.TabIndex = 118
        Me.btnbuscarPorNombre.UseVisualStyleBackColor = True
        '
        'lblNombreB
        '
        Me.lblNombreB.AutoSize = True
        Me.lblNombreB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreB.Location = New System.Drawing.Point(454, 46)
        Me.lblNombreB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreB.Name = "lblNombreB"
        Me.lblNombreB.Size = New System.Drawing.Size(62, 18)
        Me.lblNombreB.TabIndex = 119
        Me.lblNombreB.Text = "Nombre"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(523, 45)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(206, 22)
        Me.txtnombreB.TabIndex = 117
        '
        'M_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1056, 582)
        Me.Controls.Add(Me.txtnombreB)
        Me.Controls.Add(Me.btnbuscarPorNombre)
        Me.Controls.Add(Me.lblNombreB)
        Me.Controls.Add(Me.btnpaciente)
        Me.Controls.Add(Me.gbxinfoCliente)
        Me.Controls.Add(Me.mtxtidentidadClienteB)
        Me.Controls.Add(Me.btnbuscarCliente)
        Me.Controls.Add(Me.lblidCliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "M_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxinfoCliente.ResumeLayout(False)
        Me.gbxinfoCliente.PerformLayout()
        Me.gbxgenero.ResumeLayout(False)
        Me.gbxgenero.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtxtidentidadClienteB As MaskedTextBox
    Friend WithEvents btnbuscarCliente As Button
    Friend WithEvents lblidCliente As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbxinfoCliente As GroupBox
    Friend WithEvents dtpfechaNacimiento As DateTimePicker
    Friend WithEvents gbxgenero As GroupBox
    Friend WithEvents rbtnmasculino As RadioButton
    Friend WithEvents rbtnfemenino As RadioButton
    Friend WithEvents lblclasificacion As Label
    Friend WithEvents lblconvenio As Label
    Friend WithEvents lblfechaNacimiento As Label
    Friend WithEvents lblterminosPago As Label
    Friend WithEvents lblaseguradora As Label
    Friend WithEvents lblcategoria As Label
    Friend WithEvents btnactualizarCliente As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents rtxtdireccion As RichTextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txttelefonoCasa As TextBox
    Friend WithEvents txtscanId As TextBox
    Friend WithEvents txtnombreCompleto As TextBox
    Friend WithEvents mtxtidentidad As MaskedTextBox
    Friend WithEvents lbltelefonoCasa As Label
    Friend WithEvents lblcorreo As Label
    Friend WithEvents lblscanId As Label
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents lblcorreo2 As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblcelular As Label
    Friend WithEvents lblidentidadCliente As Label
    Friend WithEvents txttelefonoTrabajo As TextBox
    Friend WithEvents lbltelefonoTrabajo As Label
    Friend WithEvents txtrtn As TextBox
    Friend WithEvents lblrtn As Label
    Friend WithEvents lblapellido2 As Label
    Friend WithEvents lblnombre2 As Label
    Friend WithEvents lblapellido1 As Label
    Friend WithEvents lblnombre1 As Label
    Friend WithEvents txtcodigoCategoria As TextBox
    Friend WithEvents btnclasificacion As Button
    Friend WithEvents txtcodigoClasificacion As TextBox
    Friend WithEvents btnterminosPago As Button
    Friend WithEvents txtcodigoTermino As TextBox
    Friend WithEvents btnconvenio As Button
    Friend WithEvents txtconvenio As TextBox
    Friend WithEvents btnaseguradora As Button
    Friend WithEvents txtaseguradora As TextBox
    Friend WithEvents btncategoria As Button
    Friend WithEvents btnguardarCliente As Button
    Friend WithEvents txtnombreCategoria As TextBox
    Friend WithEvents txtnombreClasificacion As TextBox
    Friend WithEvents txtnombreConvenio As TextBox
    Friend WithEvents txtnombreTerminos As TextBox
    Friend WithEvents txtnombreAseguradora As TextBox
    Friend WithEvents btnseleccionarCliente As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnpaciente As Button
    Friend WithEvents btnbuscarPorNombre As Button
    Friend WithEvents lblNombreB As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblcodeCategoria As Label
    Friend WithEvents lblcodeTerminoPago As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtapellido2 As TextBox
    Friend WithEvents txtapellido1 As TextBox
    Friend WithEvents txtnombre2 As TextBox
    Friend WithEvents txtnombre1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbxClasificacion As ComboBox
End Class
