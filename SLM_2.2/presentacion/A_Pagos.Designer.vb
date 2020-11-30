<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagos))
        Me.lblNro = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.lblFechaP = New System.Windows.Forms.Label()
        Me.dtpFechaP = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaT = New System.Windows.Forms.Label()
        Me.dtpFechaT = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormaP = New System.Windows.Forms.TextBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.lblCtaBanco = New System.Windows.Forms.Label()
        Me.txtCtaBanco = New System.Windows.Forms.TextBox()
        Me.chxInfo = New System.Windows.Forms.CheckBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.dtDetallePagos = New System.Windows.Forms.DataGridView()
        Me.NroFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FORMAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarFormaPago = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.gbxInfo = New System.Windows.Forms.GroupBox()
        Me.lblCodigoProveedor = New System.Windows.Forms.Label()
        Me.chkPagado = New System.Windows.Forms.CheckBox()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.lblNombreBanco = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.lblTotalSuma = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dtDetallePagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfo.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Location = New System.Drawing.Point(11, 21)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(27, 13)
        Me.lblNro.TabIndex = 1
        Me.lblNro.Text = "Nro."
        '
        'txtNro
        '
        Me.txtNro.Enabled = False
        Me.txtNro.Location = New System.Drawing.Point(77, 18)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(93, 20)
        Me.txtNro.TabIndex = 2
        '
        'lblFechaP
        '
        Me.lblFechaP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Location = New System.Drawing.Point(260, 22)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaP.TabIndex = 3
        Me.lblFechaP.Text = "Fecha Pago"
        '
        'dtpFechaP
        '
        Me.dtpFechaP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaP.Location = New System.Drawing.Point(331, 19)
        Me.dtpFechaP.Name = "dtpFechaP"
        Me.dtpFechaP.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaP.TabIndex = 4
        '
        'lblFechaT
        '
        Me.lblFechaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaT.AutoSize = True
        Me.lblFechaT.Location = New System.Drawing.Point(528, 21)
        Me.lblFechaT.Name = "lblFechaT"
        Me.lblFechaT.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaT.TabIndex = 5
        Me.lblFechaT.Text = "Fecha Trans."
        '
        'dtpFechaT
        '
        Me.dtpFechaT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaT.Location = New System.Drawing.Point(608, 18)
        Me.dtpFechaT.Name = "dtpFechaT"
        Me.dtpFechaT.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaT.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Forma Pago"
        '
        'txtFormaP
        '
        Me.txtFormaP.Location = New System.Drawing.Point(77, 42)
        Me.txtFormaP.Name = "txtFormaP"
        Me.txtFormaP.Size = New System.Drawing.Size(64, 20)
        Me.txtFormaP.TabIndex = 8
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(11, 67)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 9
        Me.lblReferencia.Text = "Referencia"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(77, 66)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(93, 20)
        Me.txtReferencia.TabIndex = 10
        '
        'lblCtaBanco
        '
        Me.lblCtaBanco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtaBanco.AutoSize = True
        Me.lblCtaBanco.Location = New System.Drawing.Point(265, 45)
        Me.lblCtaBanco.Name = "lblCtaBanco"
        Me.lblCtaBanco.Size = New System.Drawing.Size(60, 13)
        Me.lblCtaBanco.TabIndex = 11
        Me.lblCtaBanco.Text = "Cta. Banco"
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCtaBanco.Enabled = False
        Me.txtCtaBanco.Location = New System.Drawing.Point(331, 42)
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(114, 20)
        Me.txtCtaBanco.TabIndex = 12
        '
        'chxInfo
        '
        Me.chxInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chxInfo.AutoSize = True
        Me.chxInfo.Location = New System.Drawing.Point(310, 68)
        Me.chxInfo.Name = "chxInfo"
        Me.chxInfo.Size = New System.Drawing.Size(122, 17)
        Me.chxInfo.TabIndex = 13
        Me.chxInfo.Text = "Inf. Prov. en Asiento"
        Me.chxInfo.UseVisualStyleBackColor = True
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Location = New System.Drawing.Point(11, 93)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(60, 13)
        Me.lblComentario.TabIndex = 18
        Me.lblComentario.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(77, 90)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(741, 20)
        Me.txtComentario.TabIndex = 19
        '
        'dtDetallePagos
        '
        Me.dtDetallePagos.AllowUserToDeleteRows = False
        Me.dtDetallePagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDetallePagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtDetallePagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtDetallePagos.BackgroundColor = System.Drawing.Color.White
        Me.dtDetallePagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetallePagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFac, Me.Proveedor, Me.Moneda, Me.ValorPago, Me.FORMAP, Me.NroCheque})
        Me.dtDetallePagos.GridColor = System.Drawing.Color.White
        Me.dtDetallePagos.Location = New System.Drawing.Point(6, 19)
        Me.dtDetallePagos.Name = "dtDetallePagos"
        Me.dtDetallePagos.Size = New System.Drawing.Size(816, 230)
        Me.dtDetallePagos.TabIndex = 20
        '
        'NroFac
        '
        Me.NroFac.HeaderText = "Nro.Fac"
        Me.NroFac.Name = "NroFac"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'Moneda
        '
        Me.Moneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        '
        'ValorPago
        '
        Me.ValorPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValorPago.HeaderText = "Monto"
        Me.ValorPago.Name = "ValorPago"
        '
        'FORMAP
        '
        Me.FORMAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FORMAP.HeaderText = "F.P"
        Me.FORMAP.Name = "FORMAP"
        '
        'NroCheque
        '
        Me.NroCheque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NroCheque.HeaderText = "Cheque/Transf."
        Me.NroCheque.Name = "NroCheque"
        '
        'btnBuscarFormaPago
        '
        Me.btnBuscarFormaPago.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarFormaPago.BackgroundImage = CType(resources.GetObject("btnBuscarFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarFormaPago.FlatAppearance.BorderSize = 0
        Me.btnBuscarFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarFormaPago.Location = New System.Drawing.Point(147, 42)
        Me.btnBuscarFormaPago.Name = "btnBuscarFormaPago"
        Me.btnBuscarFormaPago.Size = New System.Drawing.Size(18, 18)
        Me.btnBuscarFormaPago.TabIndex = 21
        Me.btnBuscarFormaPago.Text = "..."
        Me.btnBuscarFormaPago.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(681, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(599, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 23
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.White
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.Black
        Me.btnCrear.Location = New System.Drawing.Point(518, 10)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 24
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'gbxInfo
        '
        Me.gbxInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxInfo.Controls.Add(Me.lblCodigoProveedor)
        Me.gbxInfo.Controls.Add(Me.chkPagado)
        Me.gbxInfo.Controls.Add(Me.dtpFechaP)
        Me.gbxInfo.Controls.Add(Me.lblNro)
        Me.gbxInfo.Controls.Add(Me.txtNro)
        Me.gbxInfo.Controls.Add(Me.lblFechaP)
        Me.gbxInfo.Controls.Add(Me.lblFechaT)
        Me.gbxInfo.Controls.Add(Me.btnBuscarFormaPago)
        Me.gbxInfo.Controls.Add(Me.dtpFechaT)
        Me.gbxInfo.Controls.Add(Me.txtComentario)
        Me.gbxInfo.Controls.Add(Me.Label1)
        Me.gbxInfo.Controls.Add(Me.lblComentario)
        Me.gbxInfo.Controls.Add(Me.txtFormaP)
        Me.gbxInfo.Controls.Add(Me.lblReferencia)
        Me.gbxInfo.Controls.Add(Me.txtReferencia)
        Me.gbxInfo.Controls.Add(Me.lblCtaBanco)
        Me.gbxInfo.Controls.Add(Me.txtCtaBanco)
        Me.gbxInfo.Controls.Add(Me.chxInfo)
        Me.gbxInfo.Location = New System.Drawing.Point(6, 49)
        Me.gbxInfo.Name = "gbxInfo"
        Me.gbxInfo.Size = New System.Drawing.Size(828, 124)
        Me.gbxInfo.TabIndex = 25
        Me.gbxInfo.TabStop = False
        Me.gbxInfo.Text = "Información de Pago"
        '
        'lblCodigoProveedor
        '
        Me.lblCodigoProveedor.AutoSize = True
        Me.lblCodigoProveedor.Location = New System.Drawing.Point(528, 45)
        Me.lblCodigoProveedor.Name = "lblCodigoProveedor"
        Me.lblCodigoProveedor.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoProveedor.TabIndex = 23
        Me.lblCodigoProveedor.Text = "CodProveedor"
        Me.lblCodigoProveedor.Visible = False
        '
        'chkPagado
        '
        Me.chkPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Enabled = False
        Me.chkPagado.Location = New System.Drawing.Point(711, 18)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(63, 17)
        Me.chkPagado.TabIndex = 22
        Me.chkPagado.Text = "Pagado"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalle.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxDetalle.Controls.Add(Me.lblNombreBanco)
        Me.gbxDetalle.Controls.Add(Me.lblFila)
        Me.gbxDetalle.Controls.Add(Me.lblTotalSuma)
        Me.gbxDetalle.Controls.Add(Me.Label4)
        Me.gbxDetalle.Controls.Add(Me.dtDetallePagos)
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 179)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(828, 288)
        Me.gbxDetalle.TabIndex = 26
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle de Pago"
        '
        'lblNombreBanco
        '
        Me.lblNombreBanco.AutoSize = True
        Me.lblNombreBanco.Location = New System.Drawing.Point(56, 240)
        Me.lblNombreBanco.Name = "lblNombreBanco"
        Me.lblNombreBanco.Size = New System.Drawing.Size(66, 13)
        Me.lblNombreBanco.TabIndex = 24
        Me.lblNombreBanco.Text = "NameBanco"
        Me.lblNombreBanco.Visible = False
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(11, 240)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(39, 13)
        Me.lblFila.TabIndex = 23
        Me.lblFila.Text = "Label3"
        Me.lblFila.Visible = False
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(764, 261)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalSuma.TabIndex = 22
        Me.lblTotalSuma.Text = "-"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(642, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total de Pago:"
        '
        'btnRegresar
        '
        Me.btnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegresar.BackColor = System.Drawing.Color.Plum
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.ForeColor = System.Drawing.Color.Black
        Me.btnRegresar.Location = New System.Drawing.Point(442, 10)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(70, 23)
        Me.btnRegresar.TabIndex = 27
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnCrear)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 42)
        Me.Panel1.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(762, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Generar Pago"
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 476)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.gbxInfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        CType(Me.dtDetallePagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNro As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents lblFechaP As Label
    Friend WithEvents dtpFechaP As DateTimePicker
    Friend WithEvents lblFechaT As Label
    Friend WithEvents dtpFechaT As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFormaP As TextBox
    Friend WithEvents lblReferencia As Label
    Friend WithEvents txtReferencia As TextBox
    Friend WithEvents lblCtaBanco As Label
    Friend WithEvents txtCtaBanco As TextBox
    Friend WithEvents chxInfo As CheckBox
    Friend WithEvents lblComentario As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents dtDetallePagos As DataGridView
    Friend WithEvents btnBuscarFormaPago As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents gbxInfo As GroupBox
    Friend WithEvents gbxDetalle As GroupBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lblTotalSuma As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkPagado As CheckBox
    Friend WithEvents lblFila As Label
    Friend WithEvents lblNombreBanco As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCodigoProveedor As Label
    Friend WithEvents NroFac As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents ValorPago As DataGridViewTextBoxColumn
    Friend WithEvents FORMAP As DataGridViewTextBoxColumn
    Friend WithEvents NroCheque As DataGridViewTextBoxColumn
End Class
