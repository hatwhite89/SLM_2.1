﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Recibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Recibo))
        Me.lblnro = New System.Windows.Forms.Label()
        Me.lblFechaTrans = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblFormaP = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.dtpFechaTrans = New System.Windows.Forms.DateTimePicker()
        Me.rtxtReferencia = New System.Windows.Forms.RichTextBox()
        Me.txtcodigoFormaPago = New System.Windows.Forms.TextBox()
        Me.cbxInfoClte = New System.Windows.Forms.CheckBox()
        Me.cbxOk = New System.Windows.Forms.CheckBox()
        Me.txtMoneda = New System.Windows.Forms.TextBox()
        Me.txtDepositado = New System.Windows.Forms.TextBox()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.lblDepositado = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnbuscarFormaPago = New System.Windows.Forms.Button()
        Me.txtnombreFormaPago = New System.Windows.Forms.TextBox()
        Me.lblcodeFormaPago = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.texto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorRecibido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.rtxtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnro
        '
        Me.lblnro.AutoSize = True
        Me.lblnro.Location = New System.Drawing.Point(88, 31)
        Me.lblnro.Name = "lblnro"
        Me.lblnro.Size = New System.Drawing.Size(35, 17)
        Me.lblnro.TabIndex = 0
        Me.lblnro.Text = "Nro."
        '
        'lblFechaTrans
        '
        Me.lblFechaTrans.AutoSize = True
        Me.lblFechaTrans.Location = New System.Drawing.Point(283, 31)
        Me.lblFechaTrans.Name = "lblFechaTrans"
        Me.lblFechaTrans.Size = New System.Drawing.Size(92, 17)
        Me.lblFechaTrans.TabIndex = 1
        Me.lblFechaTrans.Text = "Fecha Trans."
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(618, 30)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(77, 17)
        Me.lblReferencia.TabIndex = 2
        Me.lblReferencia.Text = "Referencia"
        '
        'lblFormaP
        '
        Me.lblFormaP.AutoSize = True
        Me.lblFormaP.Location = New System.Drawing.Point(18, 74)
        Me.lblFormaP.Name = "lblFormaP"
        Me.lblFormaP.Size = New System.Drawing.Size(105, 17)
        Me.lblFormaP.TabIndex = 3
        Me.lblFormaP.Text = "Forma de Pago"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(133, 29)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.ReadOnly = True
        Me.txtnumero.Size = New System.Drawing.Size(133, 22)
        Me.txtnumero.TabIndex = 5
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpFechaTrans
        '
        Me.dtpFechaTrans.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTrans.Location = New System.Drawing.Point(380, 30)
        Me.dtpFechaTrans.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFechaTrans.Name = "dtpFechaTrans"
        Me.dtpFechaTrans.Size = New System.Drawing.Size(217, 22)
        Me.dtpFechaTrans.TabIndex = 6
        '
        'rtxtReferencia
        '
        Me.rtxtReferencia.Location = New System.Drawing.Point(622, 54)
        Me.rtxtReferencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtReferencia.MaxLength = 100
        Me.rtxtReferencia.Name = "rtxtReferencia"
        Me.rtxtReferencia.Size = New System.Drawing.Size(323, 89)
        Me.rtxtReferencia.TabIndex = 7
        Me.rtxtReferencia.Text = ""
        '
        'txtcodigoFormaPago
        '
        Me.txtcodigoFormaPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoFormaPago.Location = New System.Drawing.Point(180, 72)
        Me.txtcodigoFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoFormaPago.MaxLength = 20
        Me.txtcodigoFormaPago.Name = "txtcodigoFormaPago"
        Me.txtcodigoFormaPago.Size = New System.Drawing.Size(79, 22)
        Me.txtcodigoFormaPago.TabIndex = 8
        Me.txtcodigoFormaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxInfoClte
        '
        Me.cbxInfoClte.AutoSize = True
        Me.cbxInfoClte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxInfoClte.Location = New System.Drawing.Point(635, 166)
        Me.cbxInfoClte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxInfoClte.Name = "cbxInfoClte"
        Me.cbxInfoClte.Size = New System.Drawing.Size(212, 21)
        Me.cbxInfoClte.TabIndex = 10
        Me.cbxInfoClte.Text = "Info Clte. en Asiento Contable"
        Me.cbxInfoClte.UseVisualStyleBackColor = True
        '
        'cbxOk
        '
        Me.cbxOk.AutoSize = True
        Me.cbxOk.Location = New System.Drawing.Point(882, 166)
        Me.cbxOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxOk.Name = "cbxOk"
        Me.cbxOk.Size = New System.Drawing.Size(48, 21)
        Me.cbxOk.TabIndex = 11
        Me.cbxOk.Text = "Ok"
        Me.cbxOk.UseVisualStyleBackColor = True
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(126, 498)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(133, 22)
        Me.txtMoneda.TabIndex = 24
        Me.txtMoneda.Text = "LPS"
        Me.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDepositado
        '
        Me.txtDepositado.Location = New System.Drawing.Point(381, 499)
        Me.txtDepositado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDepositado.Name = "txtDepositado"
        Me.txtDepositado.ReadOnly = True
        Me.txtDepositado.Size = New System.Drawing.Size(133, 22)
        Me.txtDepositado.TabIndex = 25
        Me.txtDepositado.Text = "0"
        Me.txtDepositado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(61, 501)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(59, 17)
        Me.lblMoneda.TabIndex = 26
        Me.lblMoneda.Text = "Moneda"
        '
        'lblDepositado
        '
        Me.lblDepositado.AutoSize = True
        Me.lblDepositado.Location = New System.Drawing.Point(295, 502)
        Me.lblDepositado.Name = "lblDepositado"
        Me.lblDepositado.Size = New System.Drawing.Size(80, 17)
        Me.lblDepositado.TabIndex = 27
        Me.lblDepositado.Text = "Depositado"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(25, 550)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 139
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(135, 550)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 140
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(237, 550)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 141
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(338, 550)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 142
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnbuscarFormaPago
        '
        Me.btnbuscarFormaPago.BackColor = System.Drawing.Color.White
        Me.btnbuscarFormaPago.BackgroundImage = CType(resources.GetObject("btnbuscarFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarFormaPago.FlatAppearance.BorderSize = 0
        Me.btnbuscarFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarFormaPago.Location = New System.Drawing.Point(134, 72)
        Me.btnbuscarFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarFormaPago.Name = "btnbuscarFormaPago"
        Me.btnbuscarFormaPago.Size = New System.Drawing.Size(28, 22)
        Me.btnbuscarFormaPago.TabIndex = 143
        Me.btnbuscarFormaPago.Text = "..."
        Me.btnbuscarFormaPago.UseVisualStyleBackColor = False
        '
        'txtnombreFormaPago
        '
        Me.txtnombreFormaPago.Location = New System.Drawing.Point(277, 73)
        Me.txtnombreFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreFormaPago.Name = "txtnombreFormaPago"
        Me.txtnombreFormaPago.ReadOnly = True
        Me.txtnombreFormaPago.Size = New System.Drawing.Size(321, 22)
        Me.txtnombreFormaPago.TabIndex = 144
        '
        'lblcodeFormaPago
        '
        Me.lblcodeFormaPago.AutoSize = True
        Me.lblcodeFormaPago.Location = New System.Drawing.Point(20, 105)
        Me.lblcodeFormaPago.Name = "lblcodeFormaPago"
        Me.lblcodeFormaPago.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeFormaPago.TabIndex = 145
        Me.lblcodeFormaPago.Visible = False
        '
        'dgbtabla
        '
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nroFactura, Me.cliente, Me.texto, Me.FechaPago, Me.mBanco, Me.MontoBanco, Me.mRec, Me.valorRecibido})
        Me.dgbtabla.Location = New System.Drawing.Point(11, 224)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(934, 257)
        Me.dgbtabla.TabIndex = 146
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'nroFactura
        '
        Me.nroFactura.HeaderText = "Nro. Factura"
        Me.nroFactura.MinimumWidth = 6
        Me.nroFactura.Name = "nroFactura"
        Me.nroFactura.ReadOnly = True
        Me.nroFactura.Width = 125
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.MinimumWidth = 6
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Width = 125
        '
        'texto
        '
        Me.texto.HeaderText = "Texto"
        Me.texto.MinimumWidth = 6
        Me.texto.Name = "texto"
        Me.texto.ReadOnly = True
        Me.texto.Width = 125
        '
        'FechaPago
        '
        Me.FechaPago.HeaderText = "Fecha Pago"
        Me.FechaPago.MinimumWidth = 6
        Me.FechaPago.Name = "FechaPago"
        Me.FechaPago.ReadOnly = True
        Me.FechaPago.Width = 125
        '
        'mBanco
        '
        Me.mBanco.HeaderText = "M. Bco."
        Me.mBanco.MinimumWidth = 6
        Me.mBanco.Name = "mBanco"
        Me.mBanco.ReadOnly = True
        Me.mBanco.Width = 125
        '
        'MontoBanco
        '
        Me.MontoBanco.HeaderText = "Monto Banco"
        Me.MontoBanco.MinimumWidth = 6
        Me.MontoBanco.Name = "MontoBanco"
        Me.MontoBanco.ReadOnly = True
        Me.MontoBanco.Width = 125
        '
        'mRec
        '
        Me.mRec.HeaderText = "M. Rec."
        Me.mRec.MinimumWidth = 6
        Me.mRec.Name = "mRec"
        Me.mRec.ReadOnly = True
        Me.mRec.Width = 125
        '
        'valorRecibido
        '
        Me.valorRecibido.HeaderText = "Valor Recibido"
        Me.valorRecibido.MinimumWidth = 6
        Me.valorRecibido.Name = "valorRecibido"
        Me.valorRecibido.ReadOnly = True
        Me.valorRecibido.Width = 125
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(571, 133)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(0, 17)
        Me.lblEstado.TabIndex = 147
        Me.lblEstado.Visible = False
        '
        'rtxtObservaciones
        '
        Me.rtxtObservaciones.Location = New System.Drawing.Point(135, 117)
        Me.rtxtObservaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtObservaciones.MaxLength = 100
        Me.rtxtObservaciones.Name = "rtxtObservaciones"
        Me.rtxtObservaciones.Size = New System.Drawing.Size(463, 89)
        Me.rtxtObservaciones.TabIndex = 149
        Me.rtxtObservaciones.Text = ""
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 117)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(103, 17)
        Me.lblObservaciones.TabIndex = 148
        Me.lblObservaciones.Text = "Observaciones"
        '
        'M_Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 597)
        Me.Controls.Add(Me.rtxtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.dgbtabla)
        Me.Controls.Add(Me.lblcodeFormaPago)
        Me.Controls.Add(Me.txtnombreFormaPago)
        Me.Controls.Add(Me.btnbuscarFormaPago)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.lblDepositado)
        Me.Controls.Add(Me.lblMoneda)
        Me.Controls.Add(Me.txtDepositado)
        Me.Controls.Add(Me.txtMoneda)
        Me.Controls.Add(Me.cbxOk)
        Me.Controls.Add(Me.cbxInfoClte)
        Me.Controls.Add(Me.txtcodigoFormaPago)
        Me.Controls.Add(Me.rtxtReferencia)
        Me.Controls.Add(Me.dtpFechaTrans)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblFormaP)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.lblFechaTrans)
        Me.Controls.Add(Me.lblnro)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_Recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo"
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnro As Label
    Friend WithEvents lblFechaTrans As Label
    Friend WithEvents lblReferencia As Label
    Friend WithEvents lblFormaP As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents dtpFechaTrans As DateTimePicker
    Friend WithEvents rtxtReferencia As RichTextBox
    Friend WithEvents txtcodigoFormaPago As TextBox
    Friend WithEvents cbxInfoClte As CheckBox
    Friend WithEvents cbxOk As CheckBox
    Friend WithEvents txtMoneda As TextBox
    Friend WithEvents txtDepositado As TextBox
    Friend WithEvents lblMoneda As Label
    Friend WithEvents lblDepositado As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnbuscarFormaPago As Button
    Friend WithEvents txtnombreFormaPago As TextBox
    Friend WithEvents lblcodeFormaPago As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nroFactura As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents texto As DataGridViewTextBoxColumn
    Friend WithEvents FechaPago As DataGridViewTextBoxColumn
    Friend WithEvents mBanco As DataGridViewTextBoxColumn
    Friend WithEvents MontoBanco As DataGridViewTextBoxColumn
    Friend WithEvents mRec As DataGridViewTextBoxColumn
    Friend WithEvents valorRecibido As DataGridViewTextBoxColumn
    Friend WithEvents lblEstado As Label
    Friend WithEvents rtxtObservaciones As RichTextBox
    Friend WithEvents lblObservaciones As Label
End Class