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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCtaBanco = New System.Windows.Forms.Label()
        Me.txtCtaBanco = New System.Windows.Forms.TextBox()
        Me.chxInfo = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodOrden = New System.Windows.Forms.TextBox()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
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
        Me.gbxDetalle = New System.Windows.Forms.GroupBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalSuma = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 20)
        Me.TextBox1.TabIndex = 10
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
        Me.Label2.Location = New System.Drawing.Point(490, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cod. Orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(513, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Idioma"
        '
        'txtCodOrden
        '
        Me.txtCodOrden.Location = New System.Drawing.Point(557, 41)
        Me.txtCodOrden.Name = "txtCodOrden"
        Me.txtCodOrden.Size = New System.Drawing.Size(93, 20)
        Me.txtCodOrden.TabIndex = 16
        '
        'txtIdioma
        '
        Me.txtIdioma.Location = New System.Drawing.Point(557, 64)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(93, 20)
        Me.txtIdioma.TabIndex = 17
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
        Me.txtComentario.Location = New System.Drawing.Point(77, 90)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(573, 20)
        Me.txtComentario.TabIndex = 19
        '
        'dtDetallePagos
        '
        Me.dtDetallePagos.BackgroundColor = System.Drawing.Color.White
        Me.dtDetallePagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtDetallePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetallePagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFac, Me.Proveedor, Me.Moneda, Me.ValorPago, Me.FORMAP, Me.NroCheque})
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
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'Moneda
        '
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        '
        'ValorPago
        '
        Me.ValorPago.HeaderText = "ValorPago"
        Me.ValorPago.Name = "ValorPago"
        '
        'FORMAP
        '
        Me.FORMAP.HeaderText = "F.Pago"
        Me.FORMAP.Name = "FORMAP"
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
        Me.btnBuscarFormaPago.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(596, 462)
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
        Me.btnModificar.Location = New System.Drawing.Point(514, 462)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 23
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(433, 462)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 24
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'gbxInfo
        '
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
        Me.gbxInfo.Controls.Add(Me.txtIdioma)
        Me.gbxInfo.Controls.Add(Me.lblReferencia)
        Me.gbxInfo.Controls.Add(Me.txtCodOrden)
        Me.gbxInfo.Controls.Add(Me.TextBox1)
        Me.gbxInfo.Controls.Add(Me.Label3)
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
        'gbxDetalle
        '
        Me.gbxDetalle.Controls.Add(Me.lblTotalSuma)
        Me.gbxDetalle.Controls.Add(Me.Label4)
        Me.gbxDetalle.Controls.Add(Me.dtDetallePagos)
        Me.gbxDetalle.Location = New System.Drawing.Point(12, 157)
        Me.gbxDetalle.Name = "gbxDetalle"
        Me.gbxDetalle.Size = New System.Drawing.Size(659, 293)
        Me.gbxDetalle.TabIndex = 26
        Me.gbxDetalle.TabStop = False
        Me.gbxDetalle.Text = "Detalle de Pago"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Location = New System.Drawing.Point(12, 456)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(33, 37)
        Me.btnRegresar.TabIndex = 27
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total de Pago:"
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(547, 259)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalSuma.TabIndex = 22
        Me.lblTotalSuma.Text = "0.0"
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 497)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCtaBanco As Label
    Friend WithEvents txtCtaBanco As TextBox
    Friend WithEvents chxInfo As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodOrden As TextBox
    Friend WithEvents txtIdioma As TextBox
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
    Friend WithEvents NroFac As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents ValorPago As DataGridViewTextBoxColumn
    Friend WithEvents FORMAP As DataGridViewTextBoxColumn
    Friend WithEvents NroCheque As DataGridViewTextBoxColumn
    Friend WithEvents lblTotalSuma As Label
    Friend WithEvents Label4 As Label
End Class
