<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposito))
        Me.lblNro = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarDepositosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.gbxInfoDepo = New System.Windows.Forms.GroupBox()
        Me.btnBuscarTipoConta = New System.Windows.Forms.Button()
        Me.lblCodFormaPago = New System.Windows.Forms.Label()
        Me.btnBuscarBanco = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxInfoDepo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Location = New System.Drawing.Point(16, 30)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(27, 13)
        Me.lblNro.TabIndex = 1
        Me.lblNro.Text = "Nro."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(397, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarDepositosToolStripMenuItem, Me.CerrarToolStripMenuItem, Me.CerrarToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ListarDepositosToolStripMenuItem
        '
        Me.ListarDepositosToolStripMenuItem.Name = "ListarDepositosToolStripMenuItem"
        Me.ListarDepositosToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ListarDepositosToolStripMenuItem.Text = "Crear Asiento"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CerrarToolStripMenuItem.Text = "Listar Depositos"
        '
        'CerrarToolStripMenuItem1
        '
        Me.CerrarToolStripMenuItem1.Name = "CerrarToolStripMenuItem1"
        Me.CerrarToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.CerrarToolStripMenuItem1.Text = "Cerrar"
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(96, 27)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(70, 20)
        Me.txtNro.TabIndex = 30
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(16, 57)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 31
        Me.lblFecha.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(96, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(70, 20)
        Me.dtpFecha.TabIndex = 32
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.Location = New System.Drawing.Point(16, 80)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(38, 13)
        Me.lblFormaPago.TabIndex = 33
        Me.lblFormaPago.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(96, 78)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(48, 20)
        Me.txtBanco.TabIndex = 34
        '
        'lblContado
        '
        Me.lblContado.AutoSize = True
        Me.lblContado.Location = New System.Drawing.Point(16, 106)
        Me.lblContado.Name = "lblContado"
        Me.lblContado.Size = New System.Drawing.Size(47, 13)
        Me.lblContado.TabIndex = 35
        Me.lblContado.Text = "Contado"
        '
        'lbltipoCon
        '
        Me.lbltipoCon.AutoSize = True
        Me.lbltipoCon.Location = New System.Drawing.Point(16, 130)
        Me.lbltipoCon.Name = "lbltipoCon"
        Me.lbltipoCon.Size = New System.Drawing.Size(71, 13)
        Me.lbltipoCon.TabIndex = 36
        Me.lbltipoCon.Text = "Tipo Contado"
        '
        'txtContado
        '
        Me.txtContado.Location = New System.Drawing.Point(95, 102)
        Me.txtContado.Name = "txtContado"
        Me.txtContado.Size = New System.Drawing.Size(71, 20)
        Me.txtContado.TabIndex = 37
        '
        'txtTipoConta
        '
        Me.txtTipoConta.Location = New System.Drawing.Point(95, 127)
        Me.txtTipoConta.Name = "txtTipoConta"
        Me.txtTipoConta.Size = New System.Drawing.Size(49, 20)
        Me.txtTipoConta.TabIndex = 38
        '
        'lblTotalDep
        '
        Me.lblTotalDep.AutoSize = True
        Me.lblTotalDep.Location = New System.Drawing.Point(16, 152)
        Me.lblTotalDep.Name = "lblTotalDep"
        Me.lblTotalDep.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalDep.TabIndex = 39
        Me.lblTotalDep.Text = "Total Dep."
        '
        'txtTotalDep
        '
        Me.txtTotalDep.Location = New System.Drawing.Point(95, 151)
        Me.txtTotalDep.Name = "txtTotalDep"
        Me.txtTotalDep.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalDep.TabIndex = 40
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(17, 179)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(46, 13)
        Me.lblMoneda.TabIndex = 41
        Me.lblMoneda.Text = "Moneda"
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(95, 176)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(71, 20)
        Me.txtMoneda.TabIndex = 42
        Me.txtMoneda.Text = "Lps"
        '
        'lblMonBase
        '
        Me.lblMonBase.AutoSize = True
        Me.lblMonBase.Location = New System.Drawing.Point(15, 204)
        Me.lblMonBase.Name = "lblMonBase"
        Me.lblMonBase.Size = New System.Drawing.Size(67, 13)
        Me.lblMonBase.TabIndex = 43
        Me.lblMonBase.Text = "Mon. Base 1"
        '
        'txtMonBase
        '
        Me.txtMonBase.Location = New System.Drawing.Point(95, 201)
        Me.txtMonBase.Name = "txtMonBase"
        Me.txtMonBase.Size = New System.Drawing.Size(71, 20)
        Me.txtMonBase.TabIndex = 44
        '
        'lblTDepo
        '
        Me.lblTDepo.AutoSize = True
        Me.lblTDepo.Location = New System.Drawing.Point(188, 31)
        Me.lblTDepo.Name = "lblTDepo"
        Me.lblTDepo.Size = New System.Drawing.Size(88, 13)
        Me.lblTDepo.TabIndex = 48
        Me.lblTDepo.Text = "Tipo de Depósito"
        '
        'lblTipoDeposito
        '
        Me.lblTipoDeposito.AutoSize = True
        Me.lblTipoDeposito.Location = New System.Drawing.Point(286, 30)
        Me.lblTipoDeposito.Name = "lblTipoDeposito"
        Me.lblTipoDeposito.Size = New System.Drawing.Size(47, 13)
        Me.lblTipoDeposito.TabIndex = 49
        Me.lblTipoDeposito.Text = "Ninguno"
        '
        'lblComision
        '
        Me.lblComision.AutoSize = True
        Me.lblComision.Location = New System.Drawing.Point(15, 230)
        Me.lblComision.Name = "lblComision"
        Me.lblComision.Size = New System.Drawing.Size(49, 13)
        Me.lblComision.TabIndex = 60
        Me.lblComision.Text = "Comisión"
        '
        'txtComision
        '
        Me.txtComision.Enabled = False
        Me.txtComision.Location = New System.Drawing.Point(93, 227)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(72, 20)
        Me.txtComision.TabIndex = 61
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(282, 186)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(282, 209)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 68
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnUltimo
        '
        Me.btnUltimo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.ForeColor = System.Drawing.Color.White
        Me.btnUltimo.Location = New System.Drawing.Point(282, 232)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 23)
        Me.btnUltimo.TabIndex = 69
        Me.btnUltimo.Text = "Ver último"
        Me.btnUltimo.UseVisualStyleBackColor = False
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Location = New System.Drawing.Point(188, 52)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(37, 13)
        Me.lblCajero.TabIndex = 70
        Me.lblCajero.Text = "Cajero"
        '
        'txtCajero
        '
        Me.txtCajero.Location = New System.Drawing.Point(284, 50)
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.Size = New System.Drawing.Size(71, 20)
        Me.txtCajero.TabIndex = 71
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Location = New System.Drawing.Point(188, 74)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(60, 13)
        Me.lblComentario.TabIndex = 72
        Me.lblComentario.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(191, 90)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(165, 90)
        Me.txtComentario.TabIndex = 73
        '
        'gbxInfoDepo
        '
        Me.gbxInfoDepo.Controls.Add(Me.btnBuscarTipoConta)
        Me.gbxInfoDepo.Controls.Add(Me.lblCodFormaPago)
        Me.gbxInfoDepo.Controls.Add(Me.btnBuscarBanco)
        Me.gbxInfoDepo.Controls.Add(Me.txtComentario)
        Me.gbxInfoDepo.Controls.Add(Me.btnListar)
        Me.gbxInfoDepo.Controls.Add(Me.btnUltimo)
        Me.gbxInfoDepo.Controls.Add(Me.btnGuardar)
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
        Me.gbxInfoDepo.Location = New System.Drawing.Point(12, 36)
        Me.gbxInfoDepo.Name = "gbxInfoDepo"
        Me.gbxInfoDepo.Size = New System.Drawing.Size(373, 265)
        Me.gbxInfoDepo.TabIndex = 74
        Me.gbxInfoDepo.TabStop = False
        Me.gbxInfoDepo.Text = "Información de Deposito"
        '
        'btnBuscarTipoConta
        '
        Me.btnBuscarTipoConta.BackgroundImage = CType(resources.GetObject("btnBuscarTipoConta.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarTipoConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarTipoConta.FlatAppearance.BorderSize = 0
        Me.btnBuscarTipoConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarTipoConta.Location = New System.Drawing.Point(147, 129)
        Me.btnBuscarTipoConta.Name = "btnBuscarTipoConta"
        Me.btnBuscarTipoConta.Size = New System.Drawing.Size(21, 17)
        Me.btnBuscarTipoConta.TabIndex = 76
        Me.btnBuscarTipoConta.UseVisualStyleBackColor = True
        '
        'lblCodFormaPago
        '
        Me.lblCodFormaPago.AutoSize = True
        Me.lblCodFormaPago.Location = New System.Drawing.Point(237, 183)
        Me.lblCodFormaPago.Name = "lblCodFormaPago"
        Me.lblCodFormaPago.Size = New System.Drawing.Size(0, 13)
        Me.lblCodFormaPago.TabIndex = 75
        '
        'btnBuscarBanco
        '
        Me.btnBuscarBanco.BackgroundImage = CType(resources.GetObject("btnBuscarBanco.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarBanco.FlatAppearance.BorderSize = 0
        Me.btnBuscarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarBanco.Location = New System.Drawing.Point(146, 79)
        Me.btnBuscarBanco.Name = "btnBuscarBanco"
        Me.btnBuscarBanco.Size = New System.Drawing.Size(21, 17)
        Me.btnBuscarBanco.TabIndex = 74
        Me.btnBuscarBanco.UseVisualStyleBackColor = True
        '
        'frmDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxInfoDepo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposito Bancario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxInfoDepo.ResumeLayout(False)
        Me.gbxInfoDepo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNro As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarDepositosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents lblCajero As Label
    Friend WithEvents txtCajero As TextBox
    Friend WithEvents lblComentario As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents gbxInfoDepo As GroupBox
    Friend WithEvents lblCodFormaPago As Label
    Friend WithEvents btnBuscarTipoConta As Button
    Friend WithEvents btnBuscarBanco As Button
End Class
