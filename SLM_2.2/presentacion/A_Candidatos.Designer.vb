<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_Candidatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Candidatos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCandidato = New System.Windows.Forms.Label()
        Me.lblcodCargo = New System.Windows.Forms.Label()
        Me.lblcodProfesion = New System.Windows.Forms.Label()
        Me.lblcodArea = New System.Windows.Forms.Label()
        Me.btnBuscarCargo = New System.Windows.Forms.Button()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnBuscarPro = New System.Windows.Forms.Button()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBuscarCargoI = New System.Windows.Forms.Button()
        Me.txtCargoI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBuscarProfesionI = New System.Windows.Forms.Button()
        Me.txtProfesionI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtCandidatos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblCandidato)
        Me.GroupBox1.Controls.Add(Me.lblcodCargo)
        Me.GroupBox1.Controls.Add(Me.lblcodProfesion)
        Me.GroupBox1.Controls.Add(Me.lblcodArea)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCargo)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.btnBuscarPro)
        Me.GroupBox1.Controls.Add(Me.txtProfesion)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtContacto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 234)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Candidato"
        '
        'lblCandidato
        '
        Me.lblCandidato.AutoSize = True
        Me.lblCandidato.Location = New System.Drawing.Point(696, 64)
        Me.lblCandidato.Name = "lblCandidato"
        Me.lblCandidato.Size = New System.Drawing.Size(0, 13)
        Me.lblCandidato.TabIndex = 23
        Me.lblCandidato.Visible = False
        '
        'lblcodCargo
        '
        Me.lblcodCargo.AutoSize = True
        Me.lblcodCargo.Location = New System.Drawing.Point(696, 81)
        Me.lblcodCargo.Name = "lblcodCargo"
        Me.lblcodCargo.Size = New System.Drawing.Size(0, 13)
        Me.lblcodCargo.TabIndex = 22
        '
        'lblcodProfesion
        '
        Me.lblcodProfesion.AutoSize = True
        Me.lblcodProfesion.Location = New System.Drawing.Point(602, 81)
        Me.lblcodProfesion.Name = "lblcodProfesion"
        Me.lblcodProfesion.Size = New System.Drawing.Size(0, 13)
        Me.lblcodProfesion.TabIndex = 21
        '
        'lblcodArea
        '
        Me.lblcodArea.AutoSize = True
        Me.lblcodArea.Location = New System.Drawing.Point(602, 64)
        Me.lblcodArea.Name = "lblcodArea"
        Me.lblcodArea.Size = New System.Drawing.Size(0, 13)
        Me.lblcodArea.TabIndex = 20
        Me.lblcodArea.Visible = False
        '
        'btnBuscarCargo
        '
        Me.btnBuscarCargo.Location = New System.Drawing.Point(475, 71)
        Me.btnBuscarCargo.Name = "btnBuscarCargo"
        Me.btnBuscarCargo.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarCargo.TabIndex = 5
        Me.btnBuscarCargo.Text = "..."
        Me.btnBuscarCargo.UseVisualStyleBackColor = True
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(345, 73)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(127, 20)
        Me.txtCargo.TabIndex = 18
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(257, 70)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Location = New System.Drawing.Point(115, 71)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(138, 20)
        Me.txtArea.TabIndex = 16
        '
        'btnBuscarPro
        '
        Me.btnBuscarPro.Location = New System.Drawing.Point(475, 45)
        Me.btnBuscarPro.Name = "btnBuscarPro"
        Me.btnBuscarPro.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarPro.TabIndex = 3
        Me.btnBuscarPro.Text = "..."
        Me.btnBuscarPro.UseVisualStyleBackColor = True
        '
        'txtProfesion
        '
        Me.txtProfesion.Enabled = False
        Me.txtProfesion.Location = New System.Drawing.Point(345, 46)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(127, 20)
        Me.txtProfesion.TabIndex = 14
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(613, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(171, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(507, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha de Aplicación"
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(115, 45)
        Me.txtContacto.MaxLength = 200
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(170, 20)
        Me.txtContacto.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Contacto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Profesión"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(10, 113)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(774, 110)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción de Experiencia"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(114, 19)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(391, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre Candidato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cargo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(486, 11)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 25)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Candidatos"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(731, 11)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(650, 11)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(569, 11)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Enabled = False
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(405, 11)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.btnBuscarCargoI)
        Me.GroupBox3.Controls.Add(Me.txtCargoI)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.btnBuscarProfesionI)
        Me.GroupBox3.Controls.Add(Me.txtProfesionI)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.dtCandidatos)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(795, 290)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Candidatos"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(696, 71)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 13)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Generar Informe"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(714, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(327, 54)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(132, 20)
        Me.dtpFechaHasta.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(252, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Fecha Hasta"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(327, 25)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(132, 20)
        Me.dtpFechaDesde.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(252, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Fecha Desde"
        '
        'btnBuscarCargoI
        '
        Me.btnBuscarCargoI.Location = New System.Drawing.Point(210, 51)
        Me.btnBuscarCargoI.Name = "btnBuscarCargoI"
        Me.btnBuscarCargoI.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarCargoI.TabIndex = 18
        Me.btnBuscarCargoI.Text = "..."
        Me.btnBuscarCargoI.UseVisualStyleBackColor = True
        '
        'txtCargoI
        '
        Me.txtCargoI.Enabled = False
        Me.txtCargoI.Location = New System.Drawing.Point(80, 52)
        Me.txtCargoI.Name = "txtCargoI"
        Me.txtCargoI.Size = New System.Drawing.Size(127, 20)
        Me.txtCargoI.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cargo"
        '
        'btnBuscarProfesionI
        '
        Me.btnBuscarProfesionI.Location = New System.Drawing.Point(210, 22)
        Me.btnBuscarProfesionI.Name = "btnBuscarProfesionI"
        Me.btnBuscarProfesionI.Size = New System.Drawing.Size(27, 23)
        Me.btnBuscarProfesionI.TabIndex = 15
        Me.btnBuscarProfesionI.Text = "..."
        Me.btnBuscarProfesionI.UseVisualStyleBackColor = True
        '
        'txtProfesionI
        '
        Me.txtProfesionI.Enabled = False
        Me.txtProfesionI.Location = New System.Drawing.Point(80, 23)
        Me.txtProfesionI.Name = "txtProfesionI"
        Me.txtProfesionI.Size = New System.Drawing.Size(127, 20)
        Me.txtProfesionI.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Profesión"
        '
        'dtCandidatos
        '
        Me.dtCandidatos.AllowUserToAddRows = False
        Me.dtCandidatos.AllowUserToDeleteRows = False
        Me.dtCandidatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtCandidatos.BackgroundColor = System.Drawing.Color.White
        Me.dtCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCandidatos.GridColor = System.Drawing.Color.White
        Me.dtCandidatos.Location = New System.Drawing.Point(3, 94)
        Me.dtCandidatos.Name = "dtCandidatos"
        Me.dtCandidatos.ReadOnly = True
        Me.dtCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCandidatos.Size = New System.Drawing.Size(789, 188)
        Me.dtCandidatos.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 49)
        Me.Panel1.TabIndex = 3
        '
        'A_Candidatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(819, 607)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "A_Candidatos"
        Me.Text = "SLM: Módulo de Candidatos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtCandidatos As DataGridView
    Friend WithEvents lblcodCargo As Label
    Friend WithEvents lblcodProfesion As Label
    Friend WithEvents lblcodArea As Label
    Friend WithEvents btnBuscarCargo As Button
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btnBuscarPro As Button
    Friend WithEvents txtProfesion As TextBox
    Friend WithEvents lblCandidato As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dtpFechaDesde As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBuscarCargoI As Button
    Friend WithEvents txtCargoI As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnBuscarProfesionI As Button
    Friend WithEvents txtProfesionI As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaHasta As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
