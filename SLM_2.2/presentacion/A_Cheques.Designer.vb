<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Cheques
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
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.rbtnRechazado = New System.Windows.Forms.RadioButton()
        Me.rbtnCancelado = New System.Windows.Forms.RadioButton()
        Me.rbtnAcreditado = New System.Windows.Forms.RadioButton()
        Me.rbtnEmitido = New System.Windows.Forms.RadioButton()
        Me.rbtnChequera = New System.Windows.Forms.RadioButton()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaVto = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaReg = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroCheq = New System.Windows.Forms.TextBox()
        Me.txtNroCheque = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbxTipo = New System.Windows.Forms.GroupBox()
        Me.rbtnCheque = New System.Windows.Forms.RadioButton()
        Me.rbtnPagare = New System.Windows.Forms.RadioButton()
        Me.rbtnDiferido = New System.Windows.Forms.RadioButton()
        Me.txtCtaDestino = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCtaTemporal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCtaOrigen = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNroCtaBanco = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpCancelado = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpRechazo = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpAcredita = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnombreBanco = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreProvee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodProvee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtVoucher = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxTipo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Controls.Add(Me.rbtnRechazado)
        Me.GroupBox1.Controls.Add(Me.rbtnCancelado)
        Me.GroupBox1.Controls.Add(Me.rbtnAcreditado)
        Me.GroupBox1.Controls.Add(Me.rbtnEmitido)
        Me.GroupBox1.Controls.Add(Me.rbtnChequera)
        Me.GroupBox1.Controls.Add(Me.txtMoneda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaReg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNroCheq)
        Me.GroupBox1.Controls.Add(Me.txtNroCheque)
        Me.GroupBox1.Controls.Add(Me.txtNro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Cheque"
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(646, 72)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 17
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.Visible = False
        '
        'rbtnRechazado
        '
        Me.rbtnRechazado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnRechazado.AutoSize = True
        Me.rbtnRechazado.Location = New System.Drawing.Point(635, 47)
        Me.rbtnRechazado.Name = "rbtnRechazado"
        Me.rbtnRechazado.Size = New System.Drawing.Size(80, 17)
        Me.rbtnRechazado.TabIndex = 16
        Me.rbtnRechazado.Text = "Rechazado"
        Me.rbtnRechazado.UseVisualStyleBackColor = True
        '
        'rbtnCancelado
        '
        Me.rbtnCancelado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCancelado.AutoSize = True
        Me.rbtnCancelado.Location = New System.Drawing.Point(635, 24)
        Me.rbtnCancelado.Name = "rbtnCancelado"
        Me.rbtnCancelado.Size = New System.Drawing.Size(76, 17)
        Me.rbtnCancelado.TabIndex = 15
        Me.rbtnCancelado.Text = "Cancelado"
        Me.rbtnCancelado.UseVisualStyleBackColor = True
        '
        'rbtnAcreditado
        '
        Me.rbtnAcreditado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnAcreditado.AutoSize = True
        Me.rbtnAcreditado.Location = New System.Drawing.Point(524, 70)
        Me.rbtnAcreditado.Name = "rbtnAcreditado"
        Me.rbtnAcreditado.Size = New System.Drawing.Size(76, 17)
        Me.rbtnAcreditado.TabIndex = 14
        Me.rbtnAcreditado.Text = "Acreditado"
        Me.rbtnAcreditado.UseVisualStyleBackColor = True
        '
        'rbtnEmitido
        '
        Me.rbtnEmitido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnEmitido.AutoSize = True
        Me.rbtnEmitido.Location = New System.Drawing.Point(524, 47)
        Me.rbtnEmitido.Name = "rbtnEmitido"
        Me.rbtnEmitido.Size = New System.Drawing.Size(59, 17)
        Me.rbtnEmitido.TabIndex = 13
        Me.rbtnEmitido.Text = "Emitido"
        Me.rbtnEmitido.UseVisualStyleBackColor = True
        '
        'rbtnChequera
        '
        Me.rbtnChequera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnChequera.AutoSize = True
        Me.rbtnChequera.Location = New System.Drawing.Point(524, 24)
        Me.rbtnChequera.Name = "rbtnChequera"
        Me.rbtnChequera.Size = New System.Drawing.Size(87, 17)
        Me.rbtnChequera.TabIndex = 12
        Me.rbtnChequera.Text = "En Chequera"
        Me.rbtnChequera.UseVisualStyleBackColor = True
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(301, 75)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtMoneda.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Moneda"
        '
        'dtpFechaVto
        '
        Me.dtpFechaVto.Location = New System.Drawing.Point(301, 49)
        Me.dtpFechaVto.Name = "dtpFechaVto"
        Me.dtpFechaVto.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaVto.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Vto."
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Location = New System.Drawing.Point(301, 23)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaReg.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Reg."
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(88, 75)
        Me.txtMonto.MaxLength = 15
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto"
        '
        'txtNroCheq
        '
        Me.txtNroCheq.Enabled = False
        Me.txtNroCheq.Location = New System.Drawing.Point(88, 49)
        Me.txtNroCheq.Name = "txtNroCheq"
        Me.txtNroCheq.Size = New System.Drawing.Size(100, 20)
        Me.txtNroCheq.TabIndex = 3
        '
        'txtNroCheque
        '
        Me.txtNroCheque.AutoSize = True
        Me.txtNroCheque.Location = New System.Drawing.Point(15, 52)
        Me.txtNroCheque.Name = "txtNroCheque"
        Me.txtNroCheque.Size = New System.Drawing.Size(67, 13)
        Me.txtNroCheque.TabIndex = 2
        Me.txtNroCheque.Text = "Nro. Cheque"
        '
        'txtNro
        '
        Me.txtNro.Enabled = False
        Me.txtNro.Location = New System.Drawing.Point(88, 23)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(100, 20)
        Me.txtNro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Serie"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 183)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 295)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbxTipo)
        Me.TabPage1.Controls.Add(Me.txtCtaDestino)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtCtaTemporal)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtCtaOrigen)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtNroCtaBanco)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.dtpCancelado)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.dtpEmision)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.dtpRechazo)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.dtpAcredita)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtComentario)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtnombreBanco)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtBanco)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtNombreProvee)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtcodProvee)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(754, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proveedor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbxTipo
        '
        Me.gbxTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxTipo.Controls.Add(Me.rbtnCheque)
        Me.gbxTipo.Controls.Add(Me.rbtnPagare)
        Me.gbxTipo.Controls.Add(Me.rbtnDiferido)
        Me.gbxTipo.Location = New System.Drawing.Point(530, 158)
        Me.gbxTipo.Name = "gbxTipo"
        Me.gbxTipo.Size = New System.Drawing.Size(200, 95)
        Me.gbxTipo.TabIndex = 28
        Me.gbxTipo.TabStop = False
        Me.gbxTipo.Text = "Tipo"
        '
        'rbtnCheque
        '
        Me.rbtnCheque.AutoSize = True
        Me.rbtnCheque.Checked = True
        Me.rbtnCheque.Location = New System.Drawing.Point(20, 63)
        Me.rbtnCheque.Name = "rbtnCheque"
        Me.rbtnCheque.Size = New System.Drawing.Size(62, 17)
        Me.rbtnCheque.TabIndex = 31
        Me.rbtnCheque.TabStop = True
        Me.rbtnCheque.Text = "Cheque"
        Me.rbtnCheque.UseVisualStyleBackColor = True
        '
        'rbtnPagare
        '
        Me.rbtnPagare.AutoSize = True
        Me.rbtnPagare.Location = New System.Drawing.Point(20, 41)
        Me.rbtnPagare.Name = "rbtnPagare"
        Me.rbtnPagare.Size = New System.Drawing.Size(59, 17)
        Me.rbtnPagare.TabIndex = 30
        Me.rbtnPagare.Text = "Pagaré"
        Me.rbtnPagare.UseVisualStyleBackColor = True
        '
        'rbtnDiferido
        '
        Me.rbtnDiferido.AutoSize = True
        Me.rbtnDiferido.Location = New System.Drawing.Point(20, 19)
        Me.rbtnDiferido.Name = "rbtnDiferido"
        Me.rbtnDiferido.Size = New System.Drawing.Size(101, 17)
        Me.rbtnDiferido.TabIndex = 29
        Me.rbtnDiferido.Text = "Cheque Diferido"
        Me.rbtnDiferido.UseVisualStyleBackColor = True
        '
        'txtCtaDestino
        '
        Me.txtCtaDestino.Location = New System.Drawing.Point(116, 233)
        Me.txtCtaDestino.Name = "txtCtaDestino"
        Me.txtCtaDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaDestino.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Cta. Destino"
        '
        'txtCtaTemporal
        '
        Me.txtCtaTemporal.Location = New System.Drawing.Point(116, 207)
        Me.txtCtaTemporal.Name = "txtCtaTemporal"
        Me.txtCtaTemporal.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaTemporal.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 210)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Cta. Temporal"
        '
        'txtCtaOrigen
        '
        Me.txtCtaOrigen.Location = New System.Drawing.Point(116, 181)
        Me.txtCtaOrigen.Name = "txtCtaOrigen"
        Me.txtCtaOrigen.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaOrigen.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Cta. Origen"
        '
        'txtNroCtaBanco
        '
        Me.txtNroCtaBanco.Location = New System.Drawing.Point(116, 155)
        Me.txtNroCtaBanco.Name = "txtNroCtaBanco"
        Me.txtNroCtaBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtNroCtaBanco.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Cuenta Banco"
        '
        'dtpCancelado
        '
        Me.dtpCancelado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpCancelado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCancelado.Location = New System.Drawing.Point(632, 129)
        Me.dtpCancelado.Name = "dtpCancelado"
        Me.dtpCancelado.Size = New System.Drawing.Size(98, 20)
        Me.dtpCancelado.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(527, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Fecha Cancelado"
        '
        'dtpEmision
        '
        Me.dtpEmision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmision.Location = New System.Drawing.Point(632, 103)
        Me.dtpEmision.Name = "dtpEmision"
        Me.dtpEmision.Size = New System.Drawing.Size(98, 20)
        Me.dtpEmision.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(527, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fecha Emisión"
        '
        'dtpRechazo
        '
        Me.dtpRechazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRechazo.Location = New System.Drawing.Point(116, 129)
        Me.dtpRechazo.Name = "dtpRechazo"
        Me.dtpRechazo.Size = New System.Drawing.Size(98, 20)
        Me.dtpRechazo.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Fecha Rechazo"
        '
        'dtpAcredita
        '
        Me.dtpAcredita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAcredita.Location = New System.Drawing.Point(116, 103)
        Me.dtpAcredita.Name = "dtpAcredita"
        Me.dtpAcredita.Size = New System.Drawing.Size(98, 20)
        Me.dtpAcredita.TabIndex = 13
        Me.dtpAcredita.Value = New Date(2019, 12, 11, 10, 21, 36, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Fecha Acreditación"
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(86, 61)
        Me.txtComentario.MaxLength = 500
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(644, 20)
        Me.txtComentario.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Comentario"
        '
        'txtnombreBanco
        '
        Me.txtnombreBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnombreBanco.Enabled = False
        Me.txtnombreBanco.Location = New System.Drawing.Point(263, 35)
        Me.txtnombreBanco.Name = "txtnombreBanco"
        Me.txtnombreBanco.Size = New System.Drawing.Size(467, 20)
        Me.txtnombreBanco.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nombre"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(86, 35)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Banco"
        '
        'txtNombreProvee
        '
        Me.txtNombreProvee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProvee.Enabled = False
        Me.txtNombreProvee.Location = New System.Drawing.Point(263, 9)
        Me.txtNombreProvee.Name = "txtNombreProvee"
        Me.txtNombreProvee.Size = New System.Drawing.Size(467, 20)
        Me.txtNombreProvee.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Proveedor"
        '
        'txtcodProvee
        '
        Me.txtcodProvee.Location = New System.Drawing.Point(86, 9)
        Me.txtcodProvee.MaxLength = 20
        Me.txtcodProvee.Name = "txtcodProvee"
        Me.txtcodProvee.Size = New System.Drawing.Size(100, 20)
        Me.txtcodProvee.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Proveedor"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtVoucher)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(754, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Voucher"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtVoucher
        '
        Me.txtVoucher.Location = New System.Drawing.Point(14, 31)
        Me.txtVoucher.Multiline = True
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(723, 70)
        Me.txtVoucher.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nota de Voucher"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(600, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 22)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(681, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 22)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(397, 16)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(93, 22)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir Cheque"
        Me.btnImprimir.UseVisualStyleBackColor = False
        Me.btnImprimir.Visible = False
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(780, 9)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(30, 13)
        Me.lblForm.TabIndex = 5
        Me.lblForm.Text = "Form"
        Me.lblForm.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(762, 50)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Location = New System.Drawing.Point(496, 15)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(98, 23)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar Estado"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Generación de Cheques"
        '
        'A_Cheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(785, 487)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "A_Cheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbxTipo.ResumeLayout(False)
        Me.gbxTipo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMoneda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaVto As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaReg As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNroCheq As TextBox
    Friend WithEvents txtNroCheque As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtnombreBanco As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreProvee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcodProvee As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpAcredita As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dtpEmision As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpRechazo As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCtaOrigen As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNroCtaBanco As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpCancelado As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents gbxTipo As GroupBox
    Friend WithEvents rbtnCheque As RadioButton
    Friend WithEvents rbtnPagare As RadioButton
    Friend WithEvents rbtnDiferido As RadioButton
    Friend WithEvents txtCtaDestino As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCtaTemporal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtVoucher As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents rbtnRechazado As RadioButton
    Friend WithEvents rbtnCancelado As RadioButton
    Friend WithEvents rbtnAcreditado As RadioButton
    Friend WithEvents rbtnEmitido As RadioButton
    Friend WithEvents rbtnChequera As RadioButton
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents lblForm As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label8 As Label
End Class
