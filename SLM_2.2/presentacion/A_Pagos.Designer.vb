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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodOrden = New System.Windows.Forms.TextBox()
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
        Me.chkPagado = New System.Windows.Forms.CheckBox()
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.lblNombreBanco = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.lblTotalSuma = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtDetallePagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfo.SuspendLayout()
        Me.gbxDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
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
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Location = New System.Drawing.Point(209, 22)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaP.TabIndex = 3
        Me.lblFechaP.Text = "Fecha Pago"
        '
        'dtpFechaP
        '
        Me.dtpFechaP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaP.Location = New System.Drawing.Point(280, 19)
        Me.dtpFechaP.Name = "dtpFechaP"
        Me.dtpFechaP.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaP.TabIndex = 4
        '
        'lblFechaT
        '
        Me.lblFechaT.AutoSize = True
        Me.lblFechaT.Location = New System.Drawing.Point(477, 21)
        Me.lblFechaT.Name = "lblFechaT"
        Me.lblFechaT.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaT.TabIndex = 5
        Me.lblFechaT.Text = "Fecha Trans."
        '
        'dtpFechaT
        '
        Me.dtpFechaT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaT.Location = New System.Drawing.Point(557, 18)
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
        Me.lblCtaBanco.AutoSize = True
        Me.lblCtaBanco.Location = New System.Drawing.Point(214, 45)
        Me.lblCtaBanco.Name = "lblCtaBanco"
        Me.lblCtaBanco.Size = New System.Drawing.Size(60, 13)
        Me.lblCtaBanco.TabIndex = 11
        Me.lblCtaBanco.Text = "Cta. Banco"
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Enabled = False
        Me.txtCtaBanco.Location = New System.Drawing.Point(280, 42)
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(114, 20)
        Me.txtCtaBanco.TabIndex = 12
        '
        'chxInfo
        '
        Me.chxInfo.AutoSize = True
        Me.chxInfo.Location = New System.Drawing.Point(280, 67)
        Me.chxInfo.Name = "chxInfo"
        Me.chxInfo.Size = New System.Drawing.Size(122, 17)
        Me.chxInfo.TabIndex = 13
        Me.chxInfo.Text = "Inf. Prov. en Asiento"
        Me.chxInfo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(490, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cod. Orden"
        '
        'txtCodOrden
        '
        Me.txtCodOrden.Location = New System.Drawing.Point(557, 64)
        Me.txtCodOrden.Name = "txtCodOrden"
        Me.txtCodOrden.Size = New System.Drawing.Size(93, 20)
        Me.txtCodOrden.TabIndex = 16
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
        Me.txtComentario.Enabled = False
        Me.txtComentario.Location = New System.Drawing.Point(77, 90)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(573, 20)
        Me.txtComentario.TabIndex = 19
        '
        'dtDetallePagos
        '
        Me.dtDetallePagos.AllowUserToDeleteRows = False
        Me.dtDetallePagos.BackgroundColor = System.Drawing.Color.White
        Me.dtDetallePagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetallePagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFac, Me.Proveedor, Me.Moneda, Me.ValorPago, Me.FORMAP, Me.NroCheque})
        Me.dtDetallePagos.Enabled = False
        Me.dtDetallePagos.GridColor = System.Drawing.Color.White
        Me.dtDetallePagos.Location = New System.Drawing.Point(6, 19)
        Me.dtDetallePagos.Name = "dtDetallePagos"
        Me.dtDetallePagos.Size = New System.Drawing.Size(644, 209)
        Me.dtDetallePagos.TabIndex = 20
        '
        'NroFac
        '
        Me.NroFac.HeaderText = "Nro.Fac"
        Me.NroFac.Name = "NroFac"
        Me.NroFac.Width = 50
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 300
        '
        'Moneda
        '
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Width = 30
        '
        'ValorPago
        '
        Me.ValorPago.HeaderText = "Monto"
        Me.ValorPago.Name = "ValorPago"
        Me.ValorPago.ReadOnly = True
        '
        'FORMAP
        '
        Me.FORMAP.HeaderText = "F.P"
        Me.FORMAP.Name = "FORMAP"
        Me.FORMAP.Width = 30
        '
        'NroCheque
        '
        Me.NroCheque.HeaderText = "Nro.Cheque"
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
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(596, 430)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(514, 430)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 23
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(433, 430)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 24
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        Me.btnCrear.Visible = False
        '
        'gbxInfo
        '
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
        Me.gbxInfo.Controls.Add(Me.txtCodOrden)
        Me.gbxInfo.Controls.Add(Me.txtReferencia)
        Me.gbxInfo.Controls.Add(Me.lblCtaBanco)
        Me.gbxInfo.Controls.Add(Me.Label2)
        Me.gbxInfo.Controls.Add(Me.txtCtaBanco)
        Me.gbxInfo.Controls.Add(Me.chxInfo)
        Me.gbxInfo.Location = New System.Drawing.Point(12, 27)
        Me.gbxInfo.Name = "gbxInfo"
        Me.gbxInfo.Size = New System.Drawing.Size(659, 124)
        Me.gbxInfo.TabIndex = 25
        Me.gbxInfo.TabStop = False
        Me.gbxInfo.Text = "Información de Pago"
        '
        'chkPagado
        '
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Location = New System.Drawing.Point(558, 44)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(63, 17)
        Me.chkPagado.TabIndex = 22
        Me.chkPagado.Text = "Pagado"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.lblNombreBanco)
        Me.gbxDetalle.Controls.Add(Me.lblFila)
        Me.gbxDetalle.Controls.Add(Me.lblTotalSuma)
        Me.gbxDetalle.Controls.Add(Me.Label4)
        Me.gbxDetalle.Controls.Add(Me.dtDetallePagos)
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 157)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(659, 267)
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
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(11, 240)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(39, 13)
        Me.lblFila.TabIndex = 23
        Me.lblFila.Text = "Label3"
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(555, 240)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalSuma.TabIndex = 22
        Me.lblTotalSuma.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total de Pago:"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Location = New System.Drawing.Point(12, 424)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(33, 37)
        Me.btnRegresar.TabIndex = 27
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 463)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.gbxDetalle)
        Me.Controls.Add(Me.gbxInfo)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtDetallePagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        Me.gbxDetalle.ResumeLayout(False)
        Me.gbxDetalle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodOrden As TextBox
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
    Friend WithEvents NroFac As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents ValorPago As DataGridViewTextBoxColumn
    Friend WithEvents FORMAP As DataGridViewTextBoxColumn
    Friend WithEvents NroCheque As DataGridViewTextBoxColumn
    Friend WithEvents chkPagado As CheckBox
    Friend WithEvents lblFila As Label
    Friend WithEvents lblNombreBanco As Label
End Class
