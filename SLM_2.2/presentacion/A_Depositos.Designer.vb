<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposito))
        Me.lblNro = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarDepositosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.lblContado = New System.Windows.Forms.Label()
        Me.lbltipoCon = New System.Windows.Forms.Label()
        Me.txtContado = New System.Windows.Forms.TextBox()
        Me.txtTipoConta = New System.Windows.Forms.TextBox()
        Me.lblTotalDep = New System.Windows.Forms.Label()
        Me.txtTotalDep = New System.Windows.Forms.TextBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.lblMonBase = New System.Windows.Forms.Label()
        Me.txtMonBase = New System.Windows.Forms.TextBox()
        Me.lblTDepo = New System.Windows.Forms.Label()
        Me.lblTipoDeposito = New System.Windows.Forms.Label()
        Me.lblComision = New System.Windows.Forms.Label()
        Me.txtComision = New System.Windows.Forms.TextBox()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.gbxInfoDepo = New System.Windows.Forms.GroupBox()
        Me.chkAnular = New System.Windows.Forms.CheckBox()
        Me.lblCodFPContado = New System.Windows.Forms.Label()
        Me.lblCodFPBanco = New System.Windows.Forms.Label()
        Me.btnBuscarTipoConta = New System.Windows.Forms.Button()
        Me.btnBuscarBanco = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrearNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscaCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaBuscar = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtDepositos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxInfoDepo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Location = New System.Drawing.Point(21, 37)
        Me.lblNro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(35, 17)
        Me.lblNro.TabIndex = 1
        Me.lblNro.Text = "Nro."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarDepositosToolStripMenuItem, Me.CerrarToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ListarDepositosToolStripMenuItem
        '
        Me.ListarDepositosToolStripMenuItem.Name = "ListarDepositosToolStripMenuItem"
        Me.ListarDepositosToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.ListarDepositosToolStripMenuItem.Text = "Asiento"
        '
        'CerrarToolStripMenuItem1
        '
        Me.CerrarToolStripMenuItem1.Name = "CerrarToolStripMenuItem1"
        Me.CerrarToolStripMenuItem1.Size = New System.Drawing.Size(142, 26)
        Me.CerrarToolStripMenuItem1.Text = "Cerrar"
        '
        'txtNro
        '
        Me.txtNro.Enabled = False
        Me.txtNro.Location = New System.Drawing.Point(128, 33)
        Me.txtNro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(236, 22)
        Me.txtNro.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(525, 39)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 17)
        Me.lblFecha.TabIndex = 31
        Me.lblFecha.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(653, 33)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(231, 22)
        Me.dtpFecha.TabIndex = 2
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(23, 65)
        Me.lblFormaPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(48, 17)
        Me.lblFormaPago.TabIndex = 33
        Me.lblFormaPago.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(129, 63)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBanco.MaxLength = 4
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(235, 22)
        Me.txtBanco.TabIndex = 3
        '
        'lblContado
        '
        Me.lblContado.AutoSize = True
        Me.lblContado.Location = New System.Drawing.Point(23, 102)
        Me.lblContado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContado.Name = "lblContado"
        Me.lblContado.Size = New System.Drawing.Size(61, 17)
        Me.lblContado.TabIndex = 35
        Me.lblContado.Text = "Contado"
        '
        'lbltipoCon
        '
        Me.lbltipoCon.AutoSize = True
        Me.lbltipoCon.Location = New System.Drawing.Point(23, 132)
        Me.lbltipoCon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipoCon.Name = "lbltipoCon"
        Me.lbltipoCon.Size = New System.Drawing.Size(93, 17)
        Me.lbltipoCon.TabIndex = 36
        Me.lbltipoCon.Text = "Tipo Contado"
        '
        'txtContado
        '
        Me.txtContado.Location = New System.Drawing.Point(128, 97)
        Me.txtContado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContado.MaxLength = 10
        Me.txtContado.Name = "txtContado"
        Me.txtContado.Size = New System.Drawing.Size(237, 22)
        Me.txtContado.TabIndex = 5
        '
        'txtTipoConta
        '
        Me.txtTipoConta.Enabled = False
        Me.txtTipoConta.Location = New System.Drawing.Point(128, 128)
        Me.txtTipoConta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoConta.MaxLength = 4
        Me.txtTipoConta.Name = "txtTipoConta"
        Me.txtTipoConta.Size = New System.Drawing.Size(237, 22)
        Me.txtTipoConta.TabIndex = 6
        '
        'lblTotalDep
        '
        Me.lblTotalDep.AutoSize = True
        Me.lblTotalDep.Location = New System.Drawing.Point(23, 161)
        Me.lblTotalDep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalDep.Name = "lblTotalDep"
        Me.lblTotalDep.Size = New System.Drawing.Size(74, 17)
        Me.lblTotalDep.TabIndex = 39
        Me.lblTotalDep.Text = "Total Dep."
        '
        'txtTotalDep
        '
        Me.txtTotalDep.Enabled = False
        Me.txtTotalDep.Location = New System.Drawing.Point(128, 160)
        Me.txtTotalDep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalDep.Name = "txtTotalDep"
        Me.txtTotalDep.Size = New System.Drawing.Size(164, 22)
        Me.txtTotalDep.TabIndex = 8
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(24, 194)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(59, 17)
        Me.lblMoneda.TabIndex = 41
        Me.lblMoneda.Text = "Moneda"
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(128, 191)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMoneda.MaxLength = 5
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(165, 22)
        Me.txtMoneda.TabIndex = 9
        Me.txtMoneda.Text = "Lps"
        '
        'lblMonBase
        '
        Me.lblMonBase.AutoSize = True
        Me.lblMonBase.Location = New System.Drawing.Point(21, 225)
        Me.lblMonBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonBase.Name = "lblMonBase"
        Me.lblMonBase.Size = New System.Drawing.Size(87, 17)
        Me.lblMonBase.TabIndex = 43
        Me.lblMonBase.Text = "Mon. Base 1"
        '
        'txtMonBase
        '
        Me.txtMonBase.Location = New System.Drawing.Point(128, 222)
        Me.txtMonBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMonBase.MaxLength = 8
        Me.txtMonBase.Name = "txtMonBase"
        Me.txtMonBase.Size = New System.Drawing.Size(165, 22)
        Me.txtMonBase.TabIndex = 10
        Me.txtMonBase.Text = "1"
        '
        'lblTDepo
        '
        Me.lblTDepo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTDepo.AutoSize = True
        Me.lblTDepo.Location = New System.Drawing.Point(524, 66)
        Me.lblTDepo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTDepo.Name = "lblTDepo"
        Me.lblTDepo.Size = New System.Drawing.Size(116, 17)
        Me.lblTDepo.TabIndex = 48
        Me.lblTDepo.Text = "Tipo de Depósito"
        '
        'lblTipoDeposito
        '
        Me.lblTipoDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoDeposito.AutoSize = True
        Me.lblTipoDeposito.Location = New System.Drawing.Point(657, 68)
        Me.lblTipoDeposito.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoDeposito.Name = "lblTipoDeposito"
        Me.lblTipoDeposito.Size = New System.Drawing.Size(61, 17)
        Me.lblTipoDeposito.TabIndex = 49
        Me.lblTipoDeposito.Text = "Ninguno"
        '
        'lblComision
        '
        Me.lblComision.AutoSize = True
        Me.lblComision.Location = New System.Drawing.Point(21, 257)
        Me.lblComision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComision.Name = "lblComision"
        Me.lblComision.Size = New System.Drawing.Size(65, 17)
        Me.lblComision.TabIndex = 60
        Me.lblComision.Text = "Comisión"
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(129, 254)
        Me.txtComision.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComision.MaxLength = 10
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(164, 22)
        Me.txtComision.TabIndex = 11
        '
        'lblCajero
        '
        Me.lblCajero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Location = New System.Drawing.Point(525, 96)
        Me.lblCajero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(49, 17)
        Me.lblCajero.TabIndex = 70
        Me.lblCajero.Text = "Cajero"
        '
        'txtCajero
        '
        Me.txtCajero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCajero.Location = New System.Drawing.Point(653, 94)
        Me.txtCajero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCajero.MaxLength = 7
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.Size = New System.Drawing.Size(231, 22)
        Me.txtCajero.TabIndex = 12
        '
        'lblComentario
        '
        Me.lblComentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Location = New System.Drawing.Point(525, 134)
        Me.lblComentario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(80, 17)
        Me.lblComentario.TabIndex = 72
        Me.lblComentario.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario.Location = New System.Drawing.Point(527, 158)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComentario.MaxLength = 100
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(357, 83)
        Me.txtComentario.TabIndex = 13
        '
        'gbxInfoDepo
        '
        Me.gbxInfoDepo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfoDepo.BackColor = System.Drawing.Color.Transparent
        Me.gbxInfoDepo.Controls.Add(Me.chkAnular)
        Me.gbxInfoDepo.Controls.Add(Me.lblCodFPContado)
        Me.gbxInfoDepo.Controls.Add(Me.lblCodFPBanco)
        Me.gbxInfoDepo.Controls.Add(Me.btnBuscarTipoConta)
        Me.gbxInfoDepo.Controls.Add(Me.btnBuscarBanco)
        Me.gbxInfoDepo.Controls.Add(Me.txtComentario)
        Me.gbxInfoDepo.Controls.Add(Me.lblNro)
        Me.gbxInfoDepo.Controls.Add(Me.lblComentario)
        Me.gbxInfoDepo.Controls.Add(Me.txtNro)
        Me.gbxInfoDepo.Controls.Add(Me.txtCajero)
        Me.gbxInfoDepo.Controls.Add(Me.lblFecha)
        Me.gbxInfoDepo.Controls.Add(Me.lblCajero)
        Me.gbxInfoDepo.Controls.Add(Me.dtpFecha)
        Me.gbxInfoDepo.Controls.Add(Me.lblFormaPago)
        Me.gbxInfoDepo.Controls.Add(Me.txtBanco)
        Me.gbxInfoDepo.Controls.Add(Me.lblContado)
        Me.gbxInfoDepo.Controls.Add(Me.lbltipoCon)
        Me.gbxInfoDepo.Controls.Add(Me.txtComision)
        Me.gbxInfoDepo.Controls.Add(Me.txtContado)
        Me.gbxInfoDepo.Controls.Add(Me.lblComision)
        Me.gbxInfoDepo.Controls.Add(Me.txtTipoConta)
        Me.gbxInfoDepo.Controls.Add(Me.lblTipoDeposito)
        Me.gbxInfoDepo.Controls.Add(Me.lblTotalDep)
        Me.gbxInfoDepo.Controls.Add(Me.lblTDepo)
        Me.gbxInfoDepo.Controls.Add(Me.txtTotalDep)
        Me.gbxInfoDepo.Controls.Add(Me.lblMoneda)
        Me.gbxInfoDepo.Controls.Add(Me.txtMoneda)
        Me.gbxInfoDepo.Controls.Add(Me.lblMonBase)
        Me.gbxInfoDepo.Controls.Add(Me.txtMonBase)
        Me.gbxInfoDepo.Location = New System.Drawing.Point(16, 92)
        Me.gbxInfoDepo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxInfoDepo.Name = "gbxInfoDepo"
        Me.gbxInfoDepo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxInfoDepo.Size = New System.Drawing.Size(925, 293)
        Me.gbxInfoDepo.TabIndex = 74
        Me.gbxInfoDepo.TabStop = False
        Me.gbxInfoDepo.Text = "Información de Deposito"
        '
        'chkAnular
        '
        Me.chkAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAnular.AutoSize = True
        Me.chkAnular.Location = New System.Drawing.Point(532, 256)
        Me.chkAnular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAnular.Name = "chkAnular"
        Me.chkAnular.Size = New System.Drawing.Size(131, 21)
        Me.chkAnular.TabIndex = 82
        Me.chkAnular.Text = "Anular Depósito"
        Me.chkAnular.UseVisualStyleBackColor = True
        '
        'lblCodFPContado
        '
        Me.lblCodFPContado.AutoSize = True
        Me.lblCodFPContado.Location = New System.Drawing.Point(376, 254)
        Me.lblCodFPContado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodFPContado.Name = "lblCodFPContado"
        Me.lblCodFPContado.Size = New System.Drawing.Size(89, 17)
        Me.lblCodFPContado.TabIndex = 81
        Me.lblCodFPContado.Text = "TipoContado"
        Me.lblCodFPContado.Visible = False
        '
        'lblCodFPBanco
        '
        Me.lblCodFPBanco.AutoSize = True
        Me.lblCodFPBanco.Location = New System.Drawing.Point(376, 231)
        Me.lblCodFPBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodFPBanco.Name = "lblCodFPBanco"
        Me.lblCodFPBanco.Size = New System.Drawing.Size(47, 17)
        Me.lblCodFPBanco.TabIndex = 80
        Me.lblCodFPBanco.Text = "banco"
        Me.lblCodFPBanco.Visible = False
        '
        'btnBuscarTipoConta
        '
        Me.btnBuscarTipoConta.BackgroundImage = CType(resources.GetObject("btnBuscarTipoConta.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarTipoConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarTipoConta.FlatAppearance.BorderSize = 0
        Me.btnBuscarTipoConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTipoConta.Location = New System.Drawing.Point(384, 132)
        Me.btnBuscarTipoConta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarTipoConta.Name = "btnBuscarTipoConta"
        Me.btnBuscarTipoConta.Size = New System.Drawing.Size(28, 21)
        Me.btnBuscarTipoConta.TabIndex = 7
        Me.btnBuscarTipoConta.Text = "..."
        Me.btnBuscarTipoConta.UseVisualStyleBackColor = True
        '
        'btnBuscarBanco
        '
        Me.btnBuscarBanco.BackgroundImage = CType(resources.GetObject("btnBuscarBanco.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarBanco.FlatAppearance.BorderSize = 0
        Me.btnBuscarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarBanco.Location = New System.Drawing.Point(380, 66)
        Me.btnBuscarBanco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarBanco.Name = "btnBuscarBanco"
        Me.btnBuscarBanco.Size = New System.Drawing.Size(28, 21)
        Me.btnBuscarBanco.TabIndex = 4
        Me.btnBuscarBanco.Text = "..."
        Me.btnBuscarBanco.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(620, 12)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnModificar.TabIndex = 79
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCrearNuevo
        '
        Me.btnCrearNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrearNuevo.BackColor = System.Drawing.Color.White
        Me.btnCrearNuevo.FlatAppearance.BorderSize = 0
        Me.btnCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnCrearNuevo.Location = New System.Drawing.Point(512, 12)
        Me.btnCrearNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrearNuevo.Name = "btnCrearNuevo"
        Me.btnCrearNuevo.Size = New System.Drawing.Size(100, 28)
        Me.btnCrearNuevo.TabIndex = 77
        Me.btnCrearNuevo.Text = "Crear Nuevo"
        Me.btnCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuardar.Location = New System.Drawing.Point(728, 12)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBuscaCodigo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaBuscar)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtDepositos)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 393)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(925, 409)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Depositos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Buscar (Fecha):"
        '
        'txtBuscaCodigo
        '
        Me.txtBuscaCodigo.Location = New System.Drawing.Point(257, 49)
        Me.txtBuscaCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBuscaCodigo.MaxLength = 50
        Me.txtBuscaCodigo.Name = "txtBuscaCodigo"
        Me.txtBuscaCodigo.Size = New System.Drawing.Size(199, 22)
        Me.txtBuscaCodigo.TabIndex = 24
        Me.txtBuscaCodigo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Buscar (Correlativo):"
        '
        'dtpFechaBuscar
        '
        Me.dtpFechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaBuscar.Location = New System.Drawing.Point(495, 49)
        Me.dtpFechaBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaBuscar.Name = "dtpFechaBuscar"
        Me.dtpFechaBuscar.Size = New System.Drawing.Size(199, 22)
        Me.dtpFechaBuscar.TabIndex = 22
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(817, 46)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(17, 49)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBusqueda.MaxLength = 50
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(199, 22)
        Me.txtBusqueda.TabIndex = 20
        Me.txtBusqueda.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Buscar (Usuario o Comentario):"
        '
        'dtDepositos
        '
        Me.dtDepositos.AllowUserToAddRows = False
        Me.dtDepositos.AllowUserToDeleteRows = False
        Me.dtDepositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtDepositos.BackgroundColor = System.Drawing.Color.White
        Me.dtDepositos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDepositos.GridColor = System.Drawing.Color.White
        Me.dtDepositos.Location = New System.Drawing.Point(16, 81)
        Me.dtDepositos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtDepositos.Name = "dtDepositos"
        Me.dtDepositos.ReadOnly = True
        Me.dtDepositos.RowHeadersWidth = 51
        Me.dtDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtDepositos.Size = New System.Drawing.Size(901, 320)
        Me.dtDepositos.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCrearNuevo)
        Me.Panel1.Location = New System.Drawing.Point(-1, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 57)
        Me.Panel1.TabIndex = 76
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCerrar.Location = New System.Drawing.Point(835, 12)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnCerrar.TabIndex = 80
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 31)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Depositos Bancarios"
        '
        'frmDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 816)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoDepo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposito Bancario"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxInfoDepo.ResumeLayout(False)
        Me.gbxInfoDepo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNro As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarDepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtNro As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFormaPago As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents lblContado As Label
    Friend WithEvents lbltipoCon As Label
    Friend WithEvents txtContado As TextBox
    Friend WithEvents txtTipoConta As TextBox
    Friend WithEvents lblTotalDep As Label
    Friend WithEvents txtTotalDep As TextBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents txtMoneda As TextBox
    Friend WithEvents lblMonBase As Label
    Friend WithEvents txtMonBase As TextBox
    Friend WithEvents lblTDepo As Label
    Friend WithEvents lblTipoDeposito As Label
    Friend WithEvents lblComision As Label
    Friend WithEvents txtComision As TextBox
    Friend WithEvents lblCajero As Label
    Friend WithEvents txtCajero As TextBox
    Friend WithEvents lblComentario As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents gbxInfoDepo As GroupBox
    Friend WithEvents btnBuscarTipoConta As Button
    Friend WithEvents btnBuscarBanco As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtDepositos As DataGridView
    Friend WithEvents btnCrearNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblCodFPContado As Label
    Friend WithEvents lblCodFPBanco As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAnular As CheckBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dtpFechaBuscar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscaCodigo As TextBox
    Friend WithEvents Label3 As Label
End Class
