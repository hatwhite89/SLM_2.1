<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Medico))
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.lblcelular = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.lblcorreo2 = New System.Windows.Forms.Label()
        Me.btnbuscarEspecialidad = New System.Windows.Forms.Button()
        Me.txtcodigoEspecialidad = New System.Windows.Forms.TextBox()
        Me.lblespecialidad = New System.Windows.Forms.Label()
        Me.txtnombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblnombreCompleto = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.gbxmedico = New System.Windows.Forms.GroupBox()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.txtnombreEspecialidad = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxmedico.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(157, 36)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(179, 22)
        Me.txtcodigo.TabIndex = 88
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(97, 36)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 87
        Me.lblcodigo.Text = "Código"
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(446, 122)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcelular.MaxLength = 20
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(179, 22)
        Me.txtcelular.TabIndex = 92
        Me.txtcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcelular
        '
        Me.lblcelular.AutoSize = True
        Me.lblcelular.Location = New System.Drawing.Point(386, 126)
        Me.lblcelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(52, 17)
        Me.lblcelular.TabIndex = 91
        Me.lblcelular.Text = "Celular"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(446, 94)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttelefono.MaxLength = 20
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(179, 22)
        Me.txttelefono.TabIndex = 90
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(374, 97)
        Me.lbltelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(64, 17)
        Me.lbltelefono.TabIndex = 89
        Me.lbltelefono.Text = "Teléfono"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(156, 92)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcorreo.MaxLength = 50
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(179, 22)
        Me.txtcorreo.TabIndex = 94
        Me.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(97, 92)
        Me.lblcorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(51, 17)
        Me.lblcorreo.TabIndex = 93
        Me.lblcorreo.Text = "Correo"
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(157, 121)
        Me.txtcorreo2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcorreo2.MaxLength = 50
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.Size = New System.Drawing.Size(179, 22)
        Me.txtcorreo2.TabIndex = 96
        Me.txtcorreo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcorreo2
        '
        Me.lblcorreo2.AutoSize = True
        Me.lblcorreo2.Location = New System.Drawing.Point(87, 123)
        Me.lblcorreo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo2.Name = "lblcorreo2"
        Me.lblcorreo2.Size = New System.Drawing.Size(63, 17)
        Me.lblcorreo2.TabIndex = 95
        Me.lblcorreo2.Text = "Correo 2"
        '
        'btnbuscarEspecialidad
        '
        Me.btnbuscarEspecialidad.BackColor = System.Drawing.Color.White
        Me.btnbuscarEspecialidad.BackgroundImage = CType(resources.GetObject("btnbuscarEspecialidad.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarEspecialidad.FlatAppearance.BorderSize = 0
        Me.btnbuscarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarEspecialidad.Location = New System.Drawing.Point(155, 148)
        Me.btnbuscarEspecialidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarEspecialidad.Name = "btnbuscarEspecialidad"
        Me.btnbuscarEspecialidad.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarEspecialidad.TabIndex = 105
        Me.btnbuscarEspecialidad.Text = "..."
        Me.btnbuscarEspecialidad.UseVisualStyleBackColor = False
        '
        'txtcodigoEspecialidad
        '
        Me.txtcodigoEspecialidad.Location = New System.Drawing.Point(211, 150)
        Me.txtcodigoEspecialidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoEspecialidad.MaxLength = 20
        Me.txtcodigoEspecialidad.Name = "txtcodigoEspecialidad"
        Me.txtcodigoEspecialidad.Size = New System.Drawing.Size(125, 22)
        Me.txtcodigoEspecialidad.TabIndex = 104
        Me.txtcodigoEspecialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblespecialidad
        '
        Me.lblespecialidad.AutoSize = True
        Me.lblespecialidad.Location = New System.Drawing.Point(60, 151)
        Me.lblespecialidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblespecialidad.Name = "lblespecialidad"
        Me.lblespecialidad.Size = New System.Drawing.Size(88, 17)
        Me.lblespecialidad.TabIndex = 103
        Me.lblespecialidad.Text = "Especialidad"
        '
        'txtnombreCompleto
        '
        Me.txtnombreCompleto.Location = New System.Drawing.Point(157, 64)
        Me.txtnombreCompleto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreCompleto.MaxLength = 100
        Me.txtnombreCompleto.Name = "txtnombreCompleto"
        Me.txtnombreCompleto.Size = New System.Drawing.Size(468, 22)
        Me.txtnombreCompleto.TabIndex = 107
        Me.txtnombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnombreCompleto
        '
        Me.lblnombreCompleto.AutoSize = True
        Me.lblnombreCompleto.Location = New System.Drawing.Point(29, 66)
        Me.lblnombreCompleto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombreCompleto.Name = "lblnombreCompleto"
        Me.lblnombreCompleto.Size = New System.Drawing.Size(121, 17)
        Me.lblnombreCompleto.TabIndex = 106
        Me.lblnombreCompleto.Text = "Nombre Completo"
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(851, 15)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 109
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(649, 15)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(539, 15)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 110
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'gbxmedico
        '
        Me.gbxmedico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxmedico.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxmedico.Controls.Add(Me.Label6)
        Me.gbxmedico.Controls.Add(Me.Label5)
        Me.gbxmedico.Controls.Add(Me.Label4)
        Me.gbxmedico.Controls.Add(Me.Label3)
        Me.gbxmedico.Controls.Add(Me.Label2)
        Me.gbxmedico.Controls.Add(Me.Label1)
        Me.gbxmedico.Controls.Add(Me.Label62)
        Me.gbxmedico.Controls.Add(Me.Label61)
        Me.gbxmedico.Controls.Add(Me.Label60)
        Me.gbxmedico.Controls.Add(Me.Label59)
        Me.gbxmedico.Controls.Add(Me.lblForm)
        Me.gbxmedico.Controls.Add(Me.txtnombreEspecialidad)
        Me.gbxmedico.Controls.Add(Me.lblcodigo)
        Me.gbxmedico.Controls.Add(Me.txtcodigo)
        Me.gbxmedico.Controls.Add(Me.lbltelefono)
        Me.gbxmedico.Controls.Add(Me.txttelefono)
        Me.gbxmedico.Controls.Add(Me.txtnombreCompleto)
        Me.gbxmedico.Controls.Add(Me.lblcelular)
        Me.gbxmedico.Controls.Add(Me.lblnombreCompleto)
        Me.gbxmedico.Controls.Add(Me.txtcelular)
        Me.gbxmedico.Controls.Add(Me.btnbuscarEspecialidad)
        Me.gbxmedico.Controls.Add(Me.lblcorreo2)
        Me.gbxmedico.Controls.Add(Me.txtcodigoEspecialidad)
        Me.gbxmedico.Controls.Add(Me.txtcorreo2)
        Me.gbxmedico.Controls.Add(Me.lblespecialidad)
        Me.gbxmedico.Controls.Add(Me.lblcorreo)
        Me.gbxmedico.Controls.Add(Me.txtcorreo)
        Me.gbxmedico.Location = New System.Drawing.Point(23, 65)
        Me.gbxmedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxmedico.Name = "gbxmedico"
        Me.gbxmedico.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxmedico.Size = New System.Drawing.Size(920, 218)
        Me.gbxmedico.TabIndex = 111
        Me.gbxmedico.TabStop = False
        Me.gbxmedico.Text = "REGISTRAR MÉDICO"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(403, 9)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(36, 17)
        Me.lblForm.TabIndex = 115
        Me.lblForm.Text = "form"
        Me.lblForm.Visible = False
        '
        'txtnombreEspecialidad
        '
        Me.txtnombreEspecialidad.Location = New System.Drawing.Point(345, 150)
        Me.txtnombreEspecialidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreEspecialidad.Name = "txtnombreEspecialidad"
        Me.txtnombreEspecialidad.ReadOnly = True
        Me.txtnombreEspecialidad.Size = New System.Drawing.Size(280, 22)
        Me.txtnombreEspecialidad.TabIndex = 114
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(751, 15)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 111
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombre)
        Me.gbxbusqueda.Location = New System.Drawing.Point(23, 288)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(920, 302)
        Me.gbxbusqueda.TabIndex = 112
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR MÉDICO"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(172, 272)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 57)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(904, 213)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(17, 272)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(143, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE MÉDICOS"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(69, 27)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreB.MaxLength = 100
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(844, 22)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(5, 30)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 17)
        Me.lblnombre.TabIndex = 114
        Me.lblnombre.Text = "Nombre"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 600)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 113
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 60)
        Me.Panel1.TabIndex = 116
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(671, 115)
        Me.Label62.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(204, 17)
        Me.Label62.TabIndex = 213
        Me.Label62.Text = "Debe llenar uno de los campos"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(671, 78)
        Me.Label61.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(136, 17)
        Me.Label61.TabIndex = 212
        Me.Label61.Text = "Campos obligatorios"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(653, 80)
        Me.Label60.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(13, 17)
        Me.Label60.TabIndex = 211
        Me.Label60.Text = "*"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.Red
        Me.Label59.Location = New System.Drawing.Point(650, 115)
        Me.Label59.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(23, 17)
        Me.Label59.TabIndex = 210
        Me.Label59.Text = "(*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(39, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(343, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "(*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(355, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(66, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 17)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "(*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(60, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 17)
        Me.Label6.TabIndex = 219
        Me.Label6.Text = "(*)"
        '
        'M_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 622)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxmedico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_Medico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Médico"
        Me.gbxmedico.ResumeLayout(False)
        Me.gbxmedico.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents lblcelular As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents lbltelefono As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents lblcorreo2 As Label
    Friend WithEvents btnbuscarEspecialidad As Button
    Friend WithEvents txtcodigoEspecialidad As TextBox
    Friend WithEvents lblespecialidad As Label
    Friend WithEvents txtnombreCompleto As TextBox
    Friend WithEvents lblnombreCompleto As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents gbxmedico As GroupBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtnombreEspecialidad As TextBox
    Friend WithEvents lblForm As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label59 As Label
End Class
