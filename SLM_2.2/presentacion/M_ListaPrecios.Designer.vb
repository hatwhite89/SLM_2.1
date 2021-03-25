<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_ListaPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_ListaPrecios))
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.txtrtn = New System.Windows.Forms.TextBox()
        Me.lblrtn = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnConvenioSi = New System.Windows.Forms.RadioButton()
        Me.rbtnConvenioNo = New System.Windows.Forms.RadioButton()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.rbtnPagoNo = New System.Windows.Forms.RadioButton()
        Me.rbtnPagoSi = New System.Windows.Forms.RadioButton()
        Me.lblSolicitaEfectivo = New System.Windows.Forms.Label()
        Me.lblcodeT = New System.Windows.Forms.Label()
        Me.btnbuscarTermino = New System.Windows.Forms.Button()
        Me.txtDescripcionTermino = New System.Windows.Forms.TextBox()
        Me.txtcodigoTermino = New System.Windows.Forms.TextBox()
        Me.lblTerminoPago = New System.Windows.Forms.Label()
        Me.lblTipoConvenio = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoListaPrecios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoGrupoItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBreveDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodigoBreve = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.gbxclasificacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxclasificacion
        '
        Me.gbxclasificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxclasificacion.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxclasificacion.Controls.Add(Me.btnImportar)
        Me.gbxclasificacion.Controls.Add(Me.txtrtn)
        Me.gbxclasificacion.Controls.Add(Me.lblrtn)
        Me.gbxclasificacion.Controls.Add(Me.Panel1)
        Me.gbxclasificacion.Controls.Add(Me.txtPorcentaje)
        Me.gbxclasificacion.Controls.Add(Me.lblPorcentaje)
        Me.gbxclasificacion.Controls.Add(Me.rbtnPagoNo)
        Me.gbxclasificacion.Controls.Add(Me.rbtnPagoSi)
        Me.gbxclasificacion.Controls.Add(Me.lblSolicitaEfectivo)
        Me.gbxclasificacion.Controls.Add(Me.lblcodeT)
        Me.gbxclasificacion.Controls.Add(Me.btnbuscarTermino)
        Me.gbxclasificacion.Controls.Add(Me.txtDescripcionTermino)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoTermino)
        Me.gbxclasificacion.Controls.Add(Me.lblTerminoPago)
        Me.gbxclasificacion.Controls.Add(Me.lblTipoConvenio)
        Me.gbxclasificacion.Controls.Add(Me.dgbtabla)
        Me.gbxclasificacion.Controls.Add(Me.txtDescripcion)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoBreve)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigo)
        Me.gbxclasificacion.Controls.Add(Me.lbltipo)
        Me.gbxclasificacion.Controls.Add(Me.lbldescripcion)
        Me.gbxclasificacion.Controls.Add(Me.lblcodigo)
        Me.gbxclasificacion.Location = New System.Drawing.Point(15, 57)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(928, 529)
        Me.gbxclasificacion.TabIndex = 119
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR LISTA DE PRECIOS"
        '
        'txtrtn
        '
        Me.txtrtn.Location = New System.Drawing.Point(156, 175)
        Me.txtrtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtrtn.MaxLength = 20
        Me.txtrtn.Name = "txtrtn"
        Me.txtrtn.Size = New System.Drawing.Size(183, 22)
        Me.txtrtn.TabIndex = 163
        Me.txtrtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblrtn
        '
        Me.lblrtn.AutoSize = True
        Me.lblrtn.Location = New System.Drawing.Point(99, 175)
        Me.lblrtn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrtn.Name = "lblrtn"
        Me.lblrtn.Size = New System.Drawing.Size(37, 17)
        Me.lblrtn.TabIndex = 162
        Me.lblrtn.Text = "RTN"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnConvenioSi)
        Me.Panel1.Controls.Add(Me.rbtnConvenioNo)
        Me.Panel1.Location = New System.Drawing.Point(141, 102)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 55)
        Me.Panel1.TabIndex = 161
        '
        'rbtnConvenioSi
        '
        Me.rbtnConvenioSi.AutoSize = True
        Me.rbtnConvenioSi.Location = New System.Drawing.Point(13, 12)
        Me.rbtnConvenioSi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnConvenioSi.Name = "rbtnConvenioSi"
        Me.rbtnConvenioSi.Size = New System.Drawing.Size(41, 21)
        Me.rbtnConvenioSi.TabIndex = 149
        Me.rbtnConvenioSi.TabStop = True
        Me.rbtnConvenioSi.Text = "Si"
        Me.rbtnConvenioSi.UseVisualStyleBackColor = True
        '
        'rbtnConvenioNo
        '
        Me.rbtnConvenioNo.AutoSize = True
        Me.rbtnConvenioNo.Checked = True
        Me.rbtnConvenioNo.Location = New System.Drawing.Point(149, 12)
        Me.rbtnConvenioNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnConvenioNo.Name = "rbtnConvenioNo"
        Me.rbtnConvenioNo.Size = New System.Drawing.Size(47, 21)
        Me.rbtnConvenioNo.TabIndex = 150
        Me.rbtnConvenioNo.TabStop = True
        Me.rbtnConvenioNo.Text = "No"
        Me.rbtnConvenioNo.UseVisualStyleBackColor = True
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcentaje.Location = New System.Drawing.Point(156, 217)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPorcentaje.MaxLength = 20
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(183, 22)
        Me.txtPorcentaje.TabIndex = 160
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(61, 217)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(76, 17)
        Me.lblPorcentaje.TabIndex = 159
        Me.lblPorcentaje.Text = "Porcentaje"
        '
        'rbtnPagoNo
        '
        Me.rbtnPagoNo.AutoSize = True
        Me.rbtnPagoNo.Checked = True
        Me.rbtnPagoNo.Location = New System.Drawing.Point(669, 174)
        Me.rbtnPagoNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnPagoNo.Name = "rbtnPagoNo"
        Me.rbtnPagoNo.Size = New System.Drawing.Size(47, 21)
        Me.rbtnPagoNo.TabIndex = 158
        Me.rbtnPagoNo.TabStop = True
        Me.rbtnPagoNo.Text = "No"
        Me.rbtnPagoNo.UseVisualStyleBackColor = True
        '
        'rbtnPagoSi
        '
        Me.rbtnPagoSi.AutoSize = True
        Me.rbtnPagoSi.Location = New System.Drawing.Point(533, 175)
        Me.rbtnPagoSi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnPagoSi.Name = "rbtnPagoSi"
        Me.rbtnPagoSi.Size = New System.Drawing.Size(41, 21)
        Me.rbtnPagoSi.TabIndex = 157
        Me.rbtnPagoSi.TabStop = True
        Me.rbtnPagoSi.Text = "Si"
        Me.rbtnPagoSi.UseVisualStyleBackColor = True
        '
        'lblSolicitaEfectivo
        '
        Me.lblSolicitaEfectivo.AutoSize = True
        Me.lblSolicitaEfectivo.Location = New System.Drawing.Point(423, 175)
        Me.lblSolicitaEfectivo.Name = "lblSolicitaEfectivo"
        Me.lblSolicitaEfectivo.Size = New System.Drawing.Size(90, 17)
        Me.lblSolicitaEfectivo.TabIndex = 156
        Me.lblSolicitaEfectivo.Text = "Solicita Pago"
        '
        'lblcodeT
        '
        Me.lblcodeT.AutoSize = True
        Me.lblcodeT.Location = New System.Drawing.Point(423, 130)
        Me.lblcodeT.Name = "lblcodeT"
        Me.lblcodeT.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeT.TabIndex = 155
        '
        'btnbuscarTermino
        '
        Me.btnbuscarTermino.BackColor = System.Drawing.Color.White
        Me.btnbuscarTermino.BackgroundImage = CType(resources.GetObject("btnbuscarTermino.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarTermino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarTermino.FlatAppearance.BorderSize = 0
        Me.btnbuscarTermino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarTermino.Location = New System.Drawing.Point(528, 113)
        Me.btnbuscarTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarTermino.Name = "btnbuscarTermino"
        Me.btnbuscarTermino.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarTermino.TabIndex = 154
        Me.btnbuscarTermino.Text = "..."
        Me.btnbuscarTermino.UseVisualStyleBackColor = False
        '
        'txtDescripcionTermino
        '
        Me.txtDescripcionTermino.Location = New System.Drawing.Point(713, 113)
        Me.txtDescripcionTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionTermino.MaxLength = 20
        Me.txtDescripcionTermino.Name = "txtDescripcionTermino"
        Me.txtDescripcionTermino.ReadOnly = True
        Me.txtDescripcionTermino.Size = New System.Drawing.Size(183, 22)
        Me.txtDescripcionTermino.TabIndex = 153
        Me.txtDescripcionTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTermino
        '
        Me.txtcodigoTermino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoTermino.Location = New System.Drawing.Point(585, 113)
        Me.txtcodigoTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoTermino.MaxLength = 20
        Me.txtcodigoTermino.Name = "txtcodigoTermino"
        Me.txtcodigoTermino.Size = New System.Drawing.Size(121, 22)
        Me.txtcodigoTermino.TabIndex = 152
        Me.txtcodigoTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTerminoPago
        '
        Me.lblTerminoPago.AutoSize = True
        Me.lblTerminoPago.Location = New System.Drawing.Point(408, 114)
        Me.lblTerminoPago.Name = "lblTerminoPago"
        Me.lblTerminoPago.Size = New System.Drawing.Size(97, 17)
        Me.lblTerminoPago.TabIndex = 151
        Me.lblTerminoPago.Text = "Término Pago"
        '
        'lblTipoConvenio
        '
        Me.lblTipoConvenio.AutoSize = True
        Me.lblTipoConvenio.Location = New System.Drawing.Point(37, 118)
        Me.lblTipoConvenio.Name = "lblTipoConvenio"
        Me.lblTipoConvenio.Size = New System.Drawing.Size(99, 17)
        Me.lblTipoConvenio.TabIndex = 148
        Me.lblTipoConvenio.Text = "Tipo Convenio"
        '
        'dgbtabla
        '
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codigoListaPrecios, Me.codigoGrupoItem, Me.nombre, Me.codigoDescuento, Me.CodigoBreveDescuento})
        Me.dgbtabla.Location = New System.Drawing.Point(0, 258)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(928, 266)
        Me.dgbtabla.TabIndex = 147
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 125
        '
        'codigoListaPrecios
        '
        Me.codigoListaPrecios.HeaderText = "Codigo Lista Precios"
        Me.codigoListaPrecios.MinimumWidth = 6
        Me.codigoListaPrecios.Name = "codigoListaPrecios"
        Me.codigoListaPrecios.ReadOnly = True
        Me.codigoListaPrecios.Visible = False
        Me.codigoListaPrecios.Width = 125
        '
        'codigoGrupoItem
        '
        Me.codigoGrupoItem.HeaderText = "Exámen"
        Me.codigoGrupoItem.MinimumWidth = 6
        Me.codigoGrupoItem.Name = "codigoGrupoItem"
        Me.codigoGrupoItem.ReadOnly = True
        Me.codigoGrupoItem.Width = 125
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 125
        '
        'codigoDescuento
        '
        Me.codigoDescuento.HeaderText = "Codigo Descuento"
        Me.codigoDescuento.MinimumWidth = 6
        Me.codigoDescuento.Name = "codigoDescuento"
        Me.codigoDescuento.ReadOnly = True
        Me.codigoDescuento.Visible = False
        Me.codigoDescuento.Width = 125
        '
        'CodigoBreveDescuento
        '
        Me.CodigoBreveDescuento.HeaderText = "Descuento"
        Me.CodigoBreveDescuento.MinimumWidth = 6
        Me.CodigoBreveDescuento.Name = "CodigoBreveDescuento"
        Me.CodigoBreveDescuento.ReadOnly = True
        Me.CodigoBreveDescuento.Width = 125
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(156, 68)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(740, 22)
        Me.txtDescripcion.TabIndex = 133
        '
        'txtcodigoBreve
        '
        Me.txtcodigoBreve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoBreve.Location = New System.Drawing.Point(524, 30)
        Me.txtcodigoBreve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoBreve.MaxLength = 20
        Me.txtcodigoBreve.Name = "txtcodigoBreve"
        Me.txtcodigoBreve.Size = New System.Drawing.Size(183, 22)
        Me.txtcodigoBreve.TabIndex = 132
        Me.txtcodigoBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(155, 30)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(183, 22)
        Me.txtcodigo.TabIndex = 131
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(412, 31)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(93, 17)
        Me.lbltipo.TabIndex = 130
        Me.lbltipo.Text = "Código Breve"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(55, 70)
        Me.lbldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcion.TabIndex = 126
        Me.lbldescripcion.Text = "Descripción"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(84, 31)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(749, 9)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
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
        Me.btnnuevo.Location = New System.Drawing.Point(537, 9)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
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
        Me.btnguardar.Location = New System.Drawing.Point(648, 9)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
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
        Me.btncancelar.Location = New System.Drawing.Point(851, 9)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnnuevo)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.btnguardar)
        Me.Panel2.Controls.Add(Me.btnmodificar)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(959, 50)
        Me.Panel2.TabIndex = 120
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 593)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 121
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnImportar.FlatAppearance.BorderSize = 0
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.ForeColor = System.Drawing.Color.White
        Me.btnImportar.Location = New System.Drawing.Point(821, 224)
        Me.btnImportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(100, 28)
        Me.btnImportar.TabIndex = 164
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'M_ListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 615)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_ListaPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Precios"
        Me.gbxclasificacion.ResumeLayout(False)
        Me.gbxclasificacion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxclasificacion As GroupBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtcodigoBreve As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents rbtnConvenioNo As RadioButton
    Friend WithEvents rbtnConvenioSi As RadioButton
    Friend WithEvents lblTipoConvenio As Label
    Friend WithEvents txtDescripcionTermino As TextBox
    Friend WithEvents txtcodigoTermino As TextBox
    Friend WithEvents lblTerminoPago As Label
    Friend WithEvents btnbuscarTermino As Button
    Friend WithEvents lblcodeT As Label
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents rbtnPagoNo As RadioButton
    Friend WithEvents rbtnPagoSi As RadioButton
    Friend WithEvents lblSolicitaEfectivo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtrtn As TextBox
    Friend WithEvents lblrtn As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents codigoListaPrecios As DataGridViewTextBoxColumn
    Friend WithEvents codigoGrupoItem As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents codigoDescuento As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBreveDescuento As DataGridViewTextBoxColumn
    Friend WithEvents btnImportar As Button
End Class
