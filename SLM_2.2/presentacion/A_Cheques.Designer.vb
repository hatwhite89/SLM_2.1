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
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxTipo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Cheque"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(861, 89)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(52, 17)
        Me.lblEstado.TabIndex = 17
        Me.lblEstado.Text = "Estado"
        '
        'rbtnRechazado
        '
        Me.rbtnRechazado.AutoSize = True
        Me.rbtnRechazado.Location = New System.Drawing.Point(847, 58)
        Me.rbtnRechazado.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnRechazado.Name = "rbtnRechazado"
        Me.rbtnRechazado.Size = New System.Drawing.Size(101, 21)
        Me.rbtnRechazado.TabIndex = 16
        Me.rbtnRechazado.Text = "Rechazado"
        Me.rbtnRechazado.UseVisualStyleBackColor = True
        '
        'rbtnCancelado
        '
        Me.rbtnCancelado.AutoSize = True
        Me.rbtnCancelado.Location = New System.Drawing.Point(847, 30)
        Me.rbtnCancelado.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnCancelado.Name = "rbtnCancelado"
        Me.rbtnCancelado.Size = New System.Drawing.Size(96, 21)
        Me.rbtnCancelado.TabIndex = 15
        Me.rbtnCancelado.Text = "Cancelado"
        Me.rbtnCancelado.UseVisualStyleBackColor = True
        '
        'rbtnAcreditado
        '
        Me.rbtnAcreditado.AutoSize = True
        Me.rbtnAcreditado.Location = New System.Drawing.Point(699, 86)
        Me.rbtnAcreditado.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnAcreditado.Name = "rbtnAcreditado"
        Me.rbtnAcreditado.Size = New System.Drawing.Size(97, 21)
        Me.rbtnAcreditado.TabIndex = 14
        Me.rbtnAcreditado.Text = "Acreditado"
        Me.rbtnAcreditado.UseVisualStyleBackColor = True
        '
        'rbtnEmitido
        '
        Me.rbtnEmitido.AutoSize = True
        Me.rbtnEmitido.Location = New System.Drawing.Point(699, 58)
        Me.rbtnEmitido.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnEmitido.Name = "rbtnEmitido"
        Me.rbtnEmitido.Size = New System.Drawing.Size(75, 21)
        Me.rbtnEmitido.TabIndex = 13
        Me.rbtnEmitido.Text = "Emitido"
        Me.rbtnEmitido.UseVisualStyleBackColor = True
        '
        'rbtnChequera
        '
        Me.rbtnChequera.AutoSize = True
        Me.rbtnChequera.Location = New System.Drawing.Point(699, 30)
        Me.rbtnChequera.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnChequera.Name = "rbtnChequera"
        Me.rbtnChequera.Size = New System.Drawing.Size(112, 21)
        Me.rbtnChequera.TabIndex = 12
        Me.rbtnChequera.Text = "En Chequera"
        Me.rbtnChequera.UseVisualStyleBackColor = True
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.Location = New System.Drawing.Point(401, 92)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(132, 22)
        Me.txtMoneda.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Moneda"
        '
        'dtpFechaVto
        '
        Me.dtpFechaVto.Location = New System.Drawing.Point(401, 60)
        Me.dtpFechaVto.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaVto.Name = "dtpFechaVto"
        Me.dtpFechaVto.Size = New System.Drawing.Size(265, 22)
        Me.dtpFechaVto.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Vto."
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Location = New System.Drawing.Point(401, 28)
        Me.dtpFechaReg.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(265, 22)
        Me.dtpFechaReg.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Reg."
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(117, 92)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonto.MaxLength = 15
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(132, 22)
        Me.txtMonto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto"
        '
        'txtNroCheq
        '
        Me.txtNroCheq.Enabled = False
        Me.txtNroCheq.Location = New System.Drawing.Point(117, 60)
        Me.txtNroCheq.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroCheq.Name = "txtNroCheq"
        Me.txtNroCheq.Size = New System.Drawing.Size(132, 22)
        Me.txtNroCheq.TabIndex = 3
        '
        'txtNroCheque
        '
        Me.txtNroCheque.AutoSize = True
        Me.txtNroCheque.Location = New System.Drawing.Point(20, 64)
        Me.txtNroCheque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtNroCheque.Name = "txtNroCheque"
        Me.txtNroCheque.Size = New System.Drawing.Size(88, 17)
        Me.txtNroCheque.TabIndex = 2
        Me.txtNroCheque.Text = "Nro. Cheque"
        '
        'txtNro
        '
        Me.txtNro.Enabled = False
        Me.txtNro.Location = New System.Drawing.Point(117, 28)
        Me.txtNro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(132, 22)
        Me.txtNro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Serie"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 156)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1016, 363)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1008, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proveedor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbxTipo
        '
        Me.gbxTipo.Controls.Add(Me.rbtnCheque)
        Me.gbxTipo.Controls.Add(Me.rbtnPagare)
        Me.gbxTipo.Controls.Add(Me.rbtnDiferido)
        Me.gbxTipo.Location = New System.Drawing.Point(324, 194)
        Me.gbxTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxTipo.Name = "gbxTipo"
        Me.gbxTipo.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxTipo.Size = New System.Drawing.Size(267, 117)
        Me.gbxTipo.TabIndex = 28
        Me.gbxTipo.TabStop = False
        Me.gbxTipo.Text = "Tipo"
        '
        'rbtnCheque
        '
        Me.rbtnCheque.AutoSize = True
        Me.rbtnCheque.Checked = True
        Me.rbtnCheque.Location = New System.Drawing.Point(27, 78)
        Me.rbtnCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnCheque.Name = "rbtnCheque"
        Me.rbtnCheque.Size = New System.Drawing.Size(78, 21)
        Me.rbtnCheque.TabIndex = 31
        Me.rbtnCheque.TabStop = True
        Me.rbtnCheque.Text = "Cheque"
        Me.rbtnCheque.UseVisualStyleBackColor = True
        '
        'rbtnPagare
        '
        Me.rbtnPagare.AutoSize = True
        Me.rbtnPagare.Location = New System.Drawing.Point(27, 50)
        Me.rbtnPagare.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnPagare.Name = "rbtnPagare"
        Me.rbtnPagare.Size = New System.Drawing.Size(75, 21)
        Me.rbtnPagare.TabIndex = 30
        Me.rbtnPagare.Text = "Pagaré"
        Me.rbtnPagare.UseVisualStyleBackColor = True
        '
        'rbtnDiferido
        '
        Me.rbtnDiferido.AutoSize = True
        Me.rbtnDiferido.Location = New System.Drawing.Point(27, 23)
        Me.rbtnDiferido.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnDiferido.Name = "rbtnDiferido"
        Me.rbtnDiferido.Size = New System.Drawing.Size(131, 21)
        Me.rbtnDiferido.TabIndex = 29
        Me.rbtnDiferido.Text = "Cheque Diferido"
        Me.rbtnDiferido.UseVisualStyleBackColor = True
        '
        'txtCtaDestino
        '
        Me.txtCtaDestino.Location = New System.Drawing.Point(155, 287)
        Me.txtCtaDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCtaDestino.Name = "txtCtaDestino"
        Me.txtCtaDestino.Size = New System.Drawing.Size(132, 22)
        Me.txtCtaDestino.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 290)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 17)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Cta. Destino"
        '
        'txtCtaTemporal
        '
        Me.txtCtaTemporal.Location = New System.Drawing.Point(155, 255)
        Me.txtCtaTemporal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCtaTemporal.Name = "txtCtaTemporal"
        Me.txtCtaTemporal.Size = New System.Drawing.Size(132, 22)
        Me.txtCtaTemporal.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 258)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 17)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Cta. Temporal"
        '
        'txtCtaOrigen
        '
        Me.txtCtaOrigen.Location = New System.Drawing.Point(155, 223)
        Me.txtCtaOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCtaOrigen.Name = "txtCtaOrigen"
        Me.txtCtaOrigen.Size = New System.Drawing.Size(132, 22)
        Me.txtCtaOrigen.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 226)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 17)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Cta. Origen"
        '
        'txtNroCtaBanco
        '
        Me.txtNroCtaBanco.Location = New System.Drawing.Point(155, 191)
        Me.txtNroCtaBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroCtaBanco.Name = "txtNroCtaBanco"
        Me.txtNroCtaBanco.Size = New System.Drawing.Size(132, 22)
        Me.txtNroCtaBanco.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 194)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 17)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Cuenta Banco"
        '
        'dtpCancelado
        '
        Me.dtpCancelado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCancelado.Location = New System.Drawing.Point(460, 159)
        Me.dtpCancelado.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpCancelado.Name = "dtpCancelado"
        Me.dtpCancelado.Size = New System.Drawing.Size(129, 22)
        Me.dtpCancelado.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(320, 162)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 17)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Fecha Cancelado"
        '
        'dtpEmision
        '
        Me.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEmision.Location = New System.Drawing.Point(460, 127)
        Me.dtpEmision.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEmision.Name = "dtpEmision"
        Me.dtpEmision.Size = New System.Drawing.Size(129, 22)
        Me.dtpEmision.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(320, 130)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fecha Emisión"
        '
        'dtpRechazo
        '
        Me.dtpRechazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRechazo.Location = New System.Drawing.Point(155, 159)
        Me.dtpRechazo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpRechazo.Name = "dtpRechazo"
        Me.dtpRechazo.Size = New System.Drawing.Size(129, 22)
        Me.dtpRechazo.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Fecha Rechazo"
        '
        'dtpAcredita
        '
        Me.dtpAcredita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAcredita.Location = New System.Drawing.Point(155, 127)
        Me.dtpAcredita.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpAcredita.Name = "dtpAcredita"
        Me.dtpAcredita.Size = New System.Drawing.Size(129, 22)
        Me.dtpAcredita.TabIndex = 13
        Me.dtpAcredita.Value = New Date(2019, 12, 11, 10, 21, 36, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 130)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Fecha Acreditación"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(115, 75)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario.MaxLength = 500
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(800, 22)
        Me.txtComentario.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Comentario"
        '
        'txtnombreBanco
        '
        Me.txtnombreBanco.Enabled = False
        Me.txtnombreBanco.Location = New System.Drawing.Point(351, 43)
        Me.txtnombreBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombreBanco.Name = "txtnombreBanco"
        Me.txtnombreBanco.Size = New System.Drawing.Size(564, 22)
        Me.txtnombreBanco.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 47)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Nombre"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(115, 43)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(132, 22)
        Me.txtBanco.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 47)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Banco"
        '
        'txtNombreProvee
        '
        Me.txtNombreProvee.Enabled = False
        Me.txtNombreProvee.Location = New System.Drawing.Point(351, 11)
        Me.txtNombreProvee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProvee.Name = "txtNombreProvee"
        Me.txtNombreProvee.Size = New System.Drawing.Size(564, 22)
        Me.txtNombreProvee.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(268, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Proveedor"
        '
        'txtcodProvee
        '
        Me.txtcodProvee.Location = New System.Drawing.Point(115, 11)
        Me.txtcodProvee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcodProvee.MaxLength = 20
        Me.txtcodProvee.Name = "txtcodProvee"
        Me.txtcodProvee.Size = New System.Drawing.Size(132, 22)
        Me.txtcodProvee.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Proveedor"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtVoucher)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1008, 334)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Voucher"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtVoucher
        '
        Me.txtVoucher.Location = New System.Drawing.Point(19, 38)
        Me.txtVoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVoucher.Multiline = True
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(963, 85)
        Me.txtVoucher.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 16)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nota de Voucher"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(824, 527)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 33)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(932, 527)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 33)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(21, 527)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(87, 33)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        Me.btnImprimir.Visible = False
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(395, 544)
        Me.lblForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(40, 17)
        Me.lblForm.TabIndex = 5
        Me.lblForm.Text = "Form"
        Me.lblForm.Visible = False
        '
        'A_Cheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1047, 570)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
End Class
