<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Categoria))
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.lblform = New System.Windows.Forms.Label()
        Me.lblCodePriceList = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.txtdescripcionListaPrecios = New System.Windows.Forms.TextBox()
        Me.txtdescripcionTipo = New System.Windows.Forms.TextBox()
        Me.btnBuscarListaPrecios = New System.Windows.Forms.Button()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.txtcodigoListaPrecios = New System.Windows.Forms.TextBox()
        Me.lblListaPrecios = New System.Windows.Forms.Label()
        Me.btnbuscarTipo = New System.Windows.Forms.Button()
        Me.txtcodigoTipo = New System.Windows.Forms.TextBox()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtdescripcionB = New System.Windows.Forms.TextBox()
        Me.lblcomentarioB = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxclasificacion.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxclasificacion
        '
        Me.gbxclasificacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxclasificacion.Controls.Add(Me.Label1)
        Me.gbxclasificacion.Controls.Add(Me.Label60)
        Me.gbxclasificacion.Controls.Add(Me.lblform)
        Me.gbxclasificacion.Controls.Add(Me.lblCodePriceList)
        Me.gbxclasificacion.Controls.Add(Me.lblcode)
        Me.gbxclasificacion.Controls.Add(Me.txtdescripcionListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.txtdescripcionTipo)
        Me.gbxclasificacion.Controls.Add(Me.btnBuscarListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.lbltipo)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.lblListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.btnbuscarTipo)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoTipo)
        Me.gbxclasificacion.Controls.Add(Me.rtxtdescripcion)
        Me.gbxclasificacion.Controls.Add(Me.lbldescripcion)
        Me.gbxclasificacion.Controls.Add(Me.lblcodigo)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigo)
        Me.gbxclasificacion.Location = New System.Drawing.Point(11, 45)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(696, 134)
        Me.gbxclasificacion.TabIndex = 117
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR CATEGORÍA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "*"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(303, 24)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(11, 13)
        Me.Label60.TabIndex = 212
        Me.Label60.Text = "*"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(280, -4)
        Me.lblform.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(27, 13)
        Me.lblform.TabIndex = 144
        Me.lblform.Text = "form"
        Me.lblform.Visible = False
        '
        'lblCodePriceList
        '
        Me.lblCodePriceList.AutoSize = True
        Me.lblCodePriceList.Location = New System.Drawing.Point(20, 83)
        Me.lblCodePriceList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodePriceList.Name = "lblCodePriceList"
        Me.lblCodePriceList.Size = New System.Drawing.Size(0, 13)
        Me.lblCodePriceList.TabIndex = 143
        Me.lblCodePriceList.Visible = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(305, 28)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 132
        Me.lblcode.Visible = False
        '
        'txtdescripcionListaPrecios
        '
        Me.txtdescripcionListaPrecios.Location = New System.Drawing.Point(214, 80)
        Me.txtdescripcionListaPrecios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionListaPrecios.Name = "txtdescripcionListaPrecios"
        Me.txtdescripcionListaPrecios.ReadOnly = True
        Me.txtdescripcionListaPrecios.Size = New System.Drawing.Size(43, 20)
        Me.txtdescripcionListaPrecios.TabIndex = 142
        Me.txtdescripcionListaPrecios.Visible = False
        '
        'txtdescripcionTipo
        '
        Me.txtdescripcionTipo.Location = New System.Drawing.Point(214, 52)
        Me.txtdescripcionTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionTipo.Name = "txtdescripcionTipo"
        Me.txtdescripcionTipo.ReadOnly = True
        Me.txtdescripcionTipo.Size = New System.Drawing.Size(43, 20)
        Me.txtdescripcionTipo.TabIndex = 131
        Me.txtdescripcionTipo.Visible = False
        '
        'btnBuscarListaPrecios
        '
        Me.btnBuscarListaPrecios.BackColor = System.Drawing.Color.White
        Me.btnBuscarListaPrecios.BackgroundImage = CType(resources.GetObject("btnBuscarListaPrecios.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarListaPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarListaPrecios.FlatAppearance.BorderSize = 0
        Me.btnBuscarListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarListaPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarListaPrecios.Location = New System.Drawing.Point(102, 80)
        Me.btnBuscarListaPrecios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscarListaPrecios.Name = "btnBuscarListaPrecios"
        Me.btnBuscarListaPrecios.Size = New System.Drawing.Size(37, 18)
        Me.btnBuscarListaPrecios.TabIndex = 141
        Me.btnBuscarListaPrecios.Text = "..."
        Me.btnBuscarListaPrecios.UseVisualStyleBackColor = False
        Me.btnBuscarListaPrecios.Visible = False
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(63, 55)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(28, 13)
        Me.lbltipo.TabIndex = 130
        Me.lbltipo.Text = "Tipo"
        Me.lbltipo.Visible = False
        '
        'txtcodigoListaPrecios
        '
        Me.txtcodigoListaPrecios.Location = New System.Drawing.Point(143, 81)
        Me.txtcodigoListaPrecios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoListaPrecios.MaxLength = 20
        Me.txtcodigoListaPrecios.Name = "txtcodigoListaPrecios"
        Me.txtcodigoListaPrecios.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoListaPrecios.TabIndex = 140
        Me.txtcodigoListaPrecios.Visible = False
        '
        'lblListaPrecios
        '
        Me.lblListaPrecios.AutoSize = True
        Me.lblListaPrecios.Location = New System.Drawing.Point(25, 82)
        Me.lblListaPrecios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListaPrecios.Name = "lblListaPrecios"
        Me.lblListaPrecios.Size = New System.Drawing.Size(67, 13)
        Me.lblListaPrecios.TabIndex = 139
        Me.lblListaPrecios.Text = "Lista Precios"
        Me.lblListaPrecios.Visible = False
        '
        'btnbuscarTipo
        '
        Me.btnbuscarTipo.BackColor = System.Drawing.Color.White
        Me.btnbuscarTipo.BackgroundImage = CType(resources.GetObject("btnbuscarTipo.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarTipo.FlatAppearance.BorderSize = 0
        Me.btnbuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarTipo.Location = New System.Drawing.Point(102, 52)
        Me.btnbuscarTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarTipo.Name = "btnbuscarTipo"
        Me.btnbuscarTipo.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarTipo.TabIndex = 129
        Me.btnbuscarTipo.Text = "..."
        Me.btnbuscarTipo.UseVisualStyleBackColor = False
        Me.btnbuscarTipo.Visible = False
        '
        'txtcodigoTipo
        '
        Me.txtcodigoTipo.Location = New System.Drawing.Point(143, 52)
        Me.txtcodigoTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTipo.MaxLength = 20
        Me.txtcodigoTipo.Name = "txtcodigoTipo"
        Me.txtcodigoTipo.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoTipo.TabIndex = 128
        Me.txtcodigoTipo.Visible = False
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(386, 22)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtdescripcion.MaxLength = 100
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(295, 78)
        Me.rtxtdescripcion.TabIndex = 127
        Me.rtxtdescripcion.Text = ""
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(319, 24)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbldescripcion.TabIndex = 126
        Me.lbldescripcion.Text = "Descripción"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(22, 24)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(71, 13)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código Breve"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(99, 22)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(138, 20)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(567, 5)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 114
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(408, 5)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 113
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(491, 5)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(643, 5)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
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
        Me.gbxbusqueda.Controls.Add(Me.txtdescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lblcomentarioB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 183)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 312)
        Me.gbxbusqueda.TabIndex = 116
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR CATEGORÍA"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(224, 288)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 55)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(688, 222)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(7, 288)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(132, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE CATEGORIAS"
        '
        'txtdescripcionB
        '
        Me.txtdescripcionB.Location = New System.Drawing.Point(68, 21)
        Me.txtdescripcionB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionB.MaxLength = 100
        Me.txtdescripcionB.Name = "txtdescripcionB"
        Me.txtdescripcionB.Size = New System.Drawing.Size(624, 20)
        Me.txtdescripcionB.TabIndex = 115
        '
        'lblcomentarioB
        '
        Me.lblcomentarioB.AutoSize = True
        Me.lblcomentarioB.Location = New System.Drawing.Point(4, 24)
        Me.lblcomentarioB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcomentarioB.Name = "lblcomentarioB"
        Me.lblcomentarioB.Size = New System.Drawing.Size(63, 13)
        Me.lblcomentarioB.TabIndex = 114
        Me.lblcomentarioB.Text = "Descripción"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 118
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 39)
        Me.Panel1.TabIndex = 145
        '
        'M_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoría del Cliente"
        Me.gbxclasificacion.ResumeLayout(False)
        Me.gbxclasificacion.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxclasificacion As GroupBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtdescripcionB As TextBox
    Friend WithEvents lblcomentarioB As Label
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents txtdescripcionTipo As TextBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents btnbuscarTipo As Button
    Friend WithEvents txtcodigoTipo As TextBox
    Friend WithEvents lblcode As Label
    Friend WithEvents lblCodePriceList As Label
    Friend WithEvents txtdescripcionListaPrecios As TextBox
    Friend WithEvents btnBuscarListaPrecios As Button
    Friend WithEvents txtcodigoListaPrecios As TextBox
    Friend WithEvents lblListaPrecios As Label
    Friend WithEvents lblform As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label60 As Label
End Class
