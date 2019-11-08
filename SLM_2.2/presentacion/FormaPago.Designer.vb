<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormaPago
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.lblCuentaBanco = New System.Windows.Forms.Label()
        Me.lblDescrip = New System.Windows.Forms.Label()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblNombreBanco = New System.Windows.Forms.Label()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.lblObjetos = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.txtCtaBanco = New System.Windows.Forms.TextBox()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.txtNombreBanco = New System.Windows.Forms.TextBox()
        Me.txtFormulario = New System.Windows.Forms.TextBox()
        Me.txtObjetos = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.lblDe1 = New System.Windows.Forms.Label()
        Me.txtDe1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblDe2 = New System.Windows.Forms.Label()
        Me.txtDe2 = New System.Windows.Forms.TextBox()
        Me.lblPa = New System.Windows.Forms.Label()
        Me.txtPa = New System.Windows.Forms.TextBox()
        Me.lblAsiento = New System.Windows.Forms.Label()
        Me.txtAsiento = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.lblImp = New System.Windows.Forms.Label()
        Me.txtImp = New System.Windows.Forms.TextBox()
        Me.lblCtaCaja = New System.Windows.Forms.Label()
        Me.txtCtaCaja = New System.Windows.Forms.TextBox()
        Me.lblCtaImp = New System.Windows.Forms.Label()
        Me.txtCtaImp = New System.Windows.Forms.TextBox()
        Me.lblForzar = New System.Windows.Forms.Label()
        Me.txtForzar = New System.Windows.Forms.TextBox()
        Me.lblCtaVueltoPOS = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCtaContado = New System.Windows.Forms.Label()
        Me.txtCtaContado = New System.Windows.Forms.TextBox()
        Me.lblCtaBack = New System.Windows.Forms.Label()
        Me.txtCtaBack = New System.Windows.Forms.TextBox()
        Me.lblCtaDiferencia = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(599, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(12, 38)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCod.TabIndex = 1
        Me.lblCod.Text = "Código"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(12, 63)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 2
        Me.lblCuenta.Text = "Cuenta"
        '
        'lblCuentaBanco
        '
        Me.lblCuentaBanco.AutoSize = True
        Me.lblCuentaBanco.Location = New System.Drawing.Point(12, 114)
        Me.lblCuentaBanco.Name = "lblCuentaBanco"
        Me.lblCuentaBanco.Size = New System.Drawing.Size(83, 13)
        Me.lblCuentaBanco.TabIndex = 3
        Me.lblCuentaBanco.Text = "Nro. Cta. Banco"
        '
        'lblDescrip
        '
        Me.lblDescrip.AutoSize = True
        Me.lblDescrip.Location = New System.Drawing.Point(12, 89)
        Me.lblDescrip.Name = "lblDescrip"
        Me.lblDescrip.Size = New System.Drawing.Size(63, 13)
        Me.lblDescrip.TabIndex = 4
        Me.lblDescrip.Text = "Descripción"
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Location = New System.Drawing.Point(14, 139)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(61, 13)
        Me.lblOrden.TabIndex = 5
        Me.lblOrden.Text = "Cod. Orden"
        '
        'lblNombreBanco
        '
        Me.lblNombreBanco.AutoSize = True
        Me.lblNombreBanco.Location = New System.Drawing.Point(14, 167)
        Me.lblNombreBanco.Name = "lblNombreBanco"
        Me.lblNombreBanco.Size = New System.Drawing.Size(78, 13)
        Me.lblNombreBanco.TabIndex = 6
        Me.lblNombreBanco.Text = "Nombre Banco"
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Location = New System.Drawing.Point(16, 192)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(55, 13)
        Me.lblFormulario.TabIndex = 7
        Me.lblFormulario.Text = "Formulario"
        '
        'lblObjetos
        '
        Me.lblObjetos.AutoSize = True
        Me.lblObjetos.Location = New System.Drawing.Point(16, 219)
        Me.lblObjetos.Name = "lblObjetos"
        Me.lblObjetos.Size = New System.Drawing.Size(43, 13)
        Me.lblObjetos.TabIndex = 8
        Me.lblObjetos.Text = "Objetos"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(16, 245)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 9
        Me.lblTipo.Text = "Tipo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(101, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(101, 60)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtCuenta.TabIndex = 11
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(101, 85)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(100, 20)
        Me.txtDescrip.TabIndex = 12
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Location = New System.Drawing.Point(101, 111)
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaBanco.TabIndex = 13
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(101, 137)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden.TabIndex = 14
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.Location = New System.Drawing.Point(101, 163)
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreBanco.TabIndex = 15
        '
        'txtFormulario
        '
        Me.txtFormulario.Location = New System.Drawing.Point(101, 189)
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(100, 20)
        Me.txtFormulario.TabIndex = 16
        '
        'txtObjetos
        '
        Me.txtObjetos.Location = New System.Drawing.Point(101, 216)
        Me.txtObjetos.Name = "txtObjetos"
        Me.txtObjetos.Size = New System.Drawing.Size(100, 20)
        Me.txtObjetos.TabIndex = 17
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(101, 242)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 18
        '
        'lblDe1
        '
        Me.lblDe1.AutoSize = True
        Me.lblDe1.Location = New System.Drawing.Point(215, 39)
        Me.lblDe1.Name = "lblDe1"
        Me.lblDe1.Size = New System.Drawing.Size(21, 13)
        Me.lblDe1.TabIndex = 19
        Me.lblDe1.Text = "De"
        '
        'txtDe1
        '
        Me.txtDe1.Location = New System.Drawing.Point(276, 36)
        Me.txtDe1.Name = "txtDe1"
        Me.txtDe1.Size = New System.Drawing.Size(100, 20)
        Me.txtDe1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "A"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(276, 62)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 22
        '
        'lblDe2
        '
        Me.lblDe2.AutoSize = True
        Me.lblDe2.Location = New System.Drawing.Point(215, 93)
        Me.lblDe2.Name = "lblDe2"
        Me.lblDe2.Size = New System.Drawing.Size(21, 13)
        Me.lblDe2.TabIndex = 23
        Me.lblDe2.Text = "De"
        '
        'txtDe2
        '
        Me.txtDe2.Location = New System.Drawing.Point(276, 90)
        Me.txtDe2.Name = "txtDe2"
        Me.txtDe2.Size = New System.Drawing.Size(100, 20)
        Me.txtDe2.TabIndex = 24
        '
        'lblPa
        '
        Me.lblPa.AutoSize = True
        Me.lblPa.Location = New System.Drawing.Point(216, 119)
        Me.lblPa.Name = "lblPa"
        Me.lblPa.Size = New System.Drawing.Size(20, 13)
        Me.lblPa.TabIndex = 25
        Me.lblPa.Text = "Pa"
        '
        'txtPa
        '
        Me.txtPa.Location = New System.Drawing.Point(276, 115)
        Me.txtPa.Name = "txtPa"
        Me.txtPa.Size = New System.Drawing.Size(100, 20)
        Me.txtPa.TabIndex = 26
        '
        'lblAsiento
        '
        Me.lblAsiento.AutoSize = True
        Me.lblAsiento.Location = New System.Drawing.Point(216, 144)
        Me.lblAsiento.Name = "lblAsiento"
        Me.lblAsiento.Size = New System.Drawing.Size(42, 13)
        Me.lblAsiento.TabIndex = 27
        Me.lblAsiento.Text = "Asiento"
        '
        'txtAsiento
        '
        Me.txtAsiento.Location = New System.Drawing.Point(276, 141)
        Me.txtAsiento.Name = "txtAsiento"
        Me.txtAsiento.Size = New System.Drawing.Size(100, 20)
        Me.txtAsiento.TabIndex = 28
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(216, 170)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 29
        Me.lblBanco.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(276, 167)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 30
        '
        'lblImp
        '
        Me.lblImp.AutoSize = True
        Me.lblImp.Location = New System.Drawing.Point(216, 197)
        Me.lblImp.Name = "lblImp"
        Me.lblImp.Size = New System.Drawing.Size(38, 13)
        Me.lblImp.TabIndex = 31
        Me.lblImp.Text = "% Imp."
        '
        'txtImp
        '
        Me.txtImp.Location = New System.Drawing.Point(276, 194)
        Me.txtImp.Name = "txtImp"
        Me.txtImp.Size = New System.Drawing.Size(100, 20)
        Me.txtImp.TabIndex = 32
        '
        'lblCtaCaja
        '
        Me.lblCtaCaja.AutoSize = True
        Me.lblCtaCaja.Location = New System.Drawing.Point(220, 221)
        Me.lblCtaCaja.Name = "lblCtaCaja"
        Me.lblCtaCaja.Size = New System.Drawing.Size(50, 13)
        Me.lblCtaCaja.TabIndex = 33
        Me.lblCtaCaja.Text = "Cta. Caja"
        '
        'txtCtaCaja
        '
        Me.txtCtaCaja.Location = New System.Drawing.Point(276, 218)
        Me.txtCtaCaja.Name = "txtCtaCaja"
        Me.txtCtaCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaCaja.TabIndex = 34
        '
        'lblCtaImp
        '
        Me.lblCtaImp.AutoSize = True
        Me.lblCtaImp.Location = New System.Drawing.Point(220, 245)
        Me.lblCtaImp.Name = "lblCtaImp"
        Me.lblCtaImp.Size = New System.Drawing.Size(49, 13)
        Me.lblCtaImp.TabIndex = 35
        Me.lblCtaImp.Text = "Cta. Imp."
        '
        'txtCtaImp
        '
        Me.txtCtaImp.Location = New System.Drawing.Point(276, 243)
        Me.txtCtaImp.Name = "txtCtaImp"
        Me.txtCtaImp.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaImp.TabIndex = 36
        '
        'lblForzar
        '
        Me.lblForzar.AutoSize = True
        Me.lblForzar.Location = New System.Drawing.Point(393, 41)
        Me.lblForzar.Name = "lblForzar"
        Me.lblForzar.Size = New System.Drawing.Size(36, 13)
        Me.lblForzar.TabIndex = 37
        Me.lblForzar.Text = "Forzar"
        '
        'txtForzar
        '
        Me.txtForzar.Location = New System.Drawing.Point(485, 36)
        Me.txtForzar.Name = "txtForzar"
        Me.txtForzar.Size = New System.Drawing.Size(100, 20)
        Me.txtForzar.TabIndex = 38
        '
        'lblCtaVueltoPOS
        '
        Me.lblCtaVueltoPOS.AutoSize = True
        Me.lblCtaVueltoPOS.Location = New System.Drawing.Point(393, 64)
        Me.lblCtaVueltoPOS.Name = "lblCtaVueltoPOS"
        Me.lblCtaVueltoPOS.Size = New System.Drawing.Size(84, 13)
        Me.lblCtaVueltoPOS.TabIndex = 39
        Me.lblCtaVueltoPOS.Text = "Cta. Vuelto POS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(485, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 40
        '
        'lblCtaContado
        '
        Me.lblCtaContado.AutoSize = True
        Me.lblCtaContado.Location = New System.Drawing.Point(393, 90)
        Me.lblCtaContado.Name = "lblCtaContado"
        Me.lblCtaContado.Size = New System.Drawing.Size(69, 13)
        Me.lblCtaContado.TabIndex = 41
        Me.lblCtaContado.Text = "Cta. Contado"
        '
        'txtCtaContado
        '
        Me.txtCtaContado.Location = New System.Drawing.Point(485, 84)
        Me.txtCtaContado.Name = "txtCtaContado"
        Me.txtCtaContado.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaContado.TabIndex = 42
        '
        'lblCtaBack
        '
        Me.lblCtaBack.AutoSize = True
        Me.lblCtaBack.Location = New System.Drawing.Point(393, 114)
        Me.lblCtaBack.Name = "lblCtaBack"
        Me.lblCtaBack.Size = New System.Drawing.Size(85, 13)
        Me.lblCtaBack.TabIndex = 43
        Me.lblCtaBack.Text = "Cta. Back Office"
        '
        'txtCtaBack
        '
        Me.txtCtaBack.Location = New System.Drawing.Point(485, 108)
        Me.txtCtaBack.Name = "txtCtaBack"
        Me.txtCtaBack.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaBack.TabIndex = 44
        '
        'lblCtaDiferencia
        '
        Me.lblCtaDiferencia.AutoSize = True
        Me.lblCtaDiferencia.Location = New System.Drawing.Point(392, 137)
        Me.lblCtaDiferencia.Name = "lblCtaDiferencia"
        Me.lblCtaDiferencia.Size = New System.Drawing.Size(82, 13)
        Me.lblCtaDiferencia.TabIndex = 45
        Me.lblCtaDiferencia.Text = "Cta. Diferencias"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(485, 132)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 46
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(495, 166)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 23)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.ForeColor = System.Drawing.Color.White
        Me.btnListar.Location = New System.Drawing.Point(495, 192)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(92, 23)
        Me.btnListar.TabIndex = 48
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(495, 219)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(92, 23)
        Me.btnLimpiar.TabIndex = 49
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(495, 245)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(92, 23)
        Me.btnSalir.TabIndex = 50
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(599, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblCtaDiferencia)
        Me.Controls.Add(Me.txtCtaBack)
        Me.Controls.Add(Me.lblCtaBack)
        Me.Controls.Add(Me.txtCtaContado)
        Me.Controls.Add(Me.lblCtaContado)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCtaVueltoPOS)
        Me.Controls.Add(Me.txtForzar)
        Me.Controls.Add(Me.lblForzar)
        Me.Controls.Add(Me.txtCtaImp)
        Me.Controls.Add(Me.lblCtaImp)
        Me.Controls.Add(Me.txtCtaCaja)
        Me.Controls.Add(Me.lblCtaCaja)
        Me.Controls.Add(Me.txtImp)
        Me.Controls.Add(Me.lblImp)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.lblBanco)
        Me.Controls.Add(Me.txtAsiento)
        Me.Controls.Add(Me.lblAsiento)
        Me.Controls.Add(Me.txtPa)
        Me.Controls.Add(Me.lblPa)
        Me.Controls.Add(Me.txtDe2)
        Me.Controls.Add(Me.lblDe2)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDe1)
        Me.Controls.Add(Me.lblDe1)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtObjetos)
        Me.Controls.Add(Me.txtFormulario)
        Me.Controls.Add(Me.txtNombreBanco)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.txtCtaBanco)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblObjetos)
        Me.Controls.Add(Me.lblFormulario)
        Me.Controls.Add(Me.lblNombreBanco)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.lblDescrip)
        Me.Controls.Add(Me.lblCuentaBanco)
        Me.Controls.Add(Me.lblCuenta)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Formas de Pago"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCod As Label
    Friend WithEvents lblCuenta As Label
    Friend WithEvents lblCuentaBanco As Label
    Friend WithEvents lblDescrip As Label
    Friend WithEvents lblOrden As Label
    Friend WithEvents lblNombreBanco As Label
    Friend WithEvents lblFormulario As Label
    Friend WithEvents lblObjetos As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents txtCtaBanco As TextBox
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents txtNombreBanco As TextBox
    Friend WithEvents txtFormulario As TextBox
    Friend WithEvents txtObjetos As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents lblDe1 As Label
    Friend WithEvents txtDe1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblDe2 As Label
    Friend WithEvents txtDe2 As TextBox
    Friend WithEvents lblPa As Label
    Friend WithEvents txtPa As TextBox
    Friend WithEvents lblAsiento As Label
    Friend WithEvents txtAsiento As TextBox
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents lblImp As Label
    Friend WithEvents txtImp As TextBox
    Friend WithEvents lblCtaCaja As Label
    Friend WithEvents txtCtaCaja As TextBox
    Friend WithEvents lblCtaImp As Label
    Friend WithEvents txtCtaImp As TextBox
    Friend WithEvents lblForzar As Label
    Friend WithEvents txtForzar As TextBox
    Friend WithEvents lblCtaVueltoPOS As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCtaContado As Label
    Friend WithEvents txtCtaContado As TextBox
    Friend WithEvents lblCtaBack As Label
    Friend WithEvents txtCtaBack As TextBox
    Friend WithEvents lblCtaDiferencia As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
