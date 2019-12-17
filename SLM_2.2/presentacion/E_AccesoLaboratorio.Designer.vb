<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_AccesoLaboratorio
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
        Me.gbxobjeto = New System.Windows.Forms.GroupBox()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.cbxValidar = New System.Windows.Forms.CheckBox()
        Me.cbxConfirmar = New System.Windows.Forms.CheckBox()
        Me.cbxObjetar = New System.Windows.Forms.CheckBox()
        Me.cbxIngresar = New System.Windows.Forms.CheckBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtusuarioB = New System.Windows.Forms.TextBox()
        Me.lblcodigoB = New System.Windows.Forms.Label()
        Me.gbxobjeto.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxobjeto
        '
        Me.gbxobjeto.Controls.Add(Me.lblcode)
        Me.gbxobjeto.Controls.Add(Me.cbxValidar)
        Me.gbxobjeto.Controls.Add(Me.cbxConfirmar)
        Me.gbxobjeto.Controls.Add(Me.cbxObjetar)
        Me.gbxobjeto.Controls.Add(Me.cbxIngresar)
        Me.gbxobjeto.Controls.Add(Me.txtnombre)
        Me.gbxobjeto.Controls.Add(Me.btnmodificar)
        Me.gbxobjeto.Controls.Add(Me.btnnuevo)
        Me.gbxobjeto.Controls.Add(Me.btnguardar)
        Me.gbxobjeto.Controls.Add(Me.lblcodigo)
        Me.gbxobjeto.Controls.Add(Me.btncancelar)
        Me.gbxobjeto.Controls.Add(Me.lblnombre)
        Me.gbxobjeto.Controls.Add(Me.txtusuario)
        Me.gbxobjeto.Location = New System.Drawing.Point(23, 25)
        Me.gbxobjeto.Name = "gbxobjeto"
        Me.gbxobjeto.Size = New System.Drawing.Size(613, 208)
        Me.gbxobjeto.TabIndex = 119
        Me.gbxobjeto.TabStop = False
        Me.gbxobjeto.Text = "REGISTRAR ACCESO LABORATORIO"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(447, 22)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 17)
        Me.lblcode.TabIndex = 122
        Me.lblcode.Visible = False
        '
        'cbxValidar
        '
        Me.cbxValidar.AutoSize = True
        Me.cbxValidar.Location = New System.Drawing.Point(305, 110)
        Me.cbxValidar.Name = "cbxValidar"
        Me.cbxValidar.Size = New System.Drawing.Size(194, 21)
        Me.cbxValidar.TabIndex = 121
        Me.cbxValidar.Text = "Permitir Validar Resultado"
        Me.cbxValidar.UseVisualStyleBackColor = True
        '
        'cbxConfirmar
        '
        Me.cbxConfirmar.AutoSize = True
        Me.cbxConfirmar.Location = New System.Drawing.Point(305, 83)
        Me.cbxConfirmar.Name = "cbxConfirmar"
        Me.cbxConfirmar.Size = New System.Drawing.Size(211, 21)
        Me.cbxConfirmar.TabIndex = 120
        Me.cbxConfirmar.Text = "Permitir Confirmar Resultado"
        Me.cbxConfirmar.UseVisualStyleBackColor = True
        '
        'cbxObjetar
        '
        Me.cbxObjetar.AutoSize = True
        Me.cbxObjetar.Location = New System.Drawing.Point(97, 110)
        Me.cbxObjetar.Name = "cbxObjetar"
        Me.cbxObjetar.Size = New System.Drawing.Size(197, 21)
        Me.cbxObjetar.TabIndex = 119
        Me.cbxObjetar.Text = "Permitir Objetar Resultado"
        Me.cbxObjetar.UseVisualStyleBackColor = True
        '
        'cbxIngresar
        '
        Me.cbxIngresar.AutoSize = True
        Me.cbxIngresar.Location = New System.Drawing.Point(97, 83)
        Me.cbxIngresar.Name = "cbxIngresar"
        Me.cbxIngresar.Size = New System.Drawing.Size(202, 21)
        Me.cbxIngresar.TabIndex = 118
        Me.cbxIngresar.Text = "Permitir Ingresar Resultado"
        Me.cbxIngresar.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(173, 51)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(343, 22)
        Me.txtnombre.TabIndex = 117
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(326, 149)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 35)
        Me.btnmodificar.TabIndex = 114
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(44, 149)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 35)
        Me.btnnuevo.TabIndex = 113
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(190, 149)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 35)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(103, 26)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(57, 17)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Usuario"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(468, 149)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(97, 54)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 17)
        Me.lblnombre.TabIndex = 39
        Me.lblnombre.Text = "Nombre"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(174, 23)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(183, 22)
        Me.txtusuario.TabIndex = 40
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtusuarioB)
        Me.gbxbusqueda.Controls.Add(Me.lblcodigoB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(23, 239)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Size = New System.Drawing.Size(613, 363)
        Me.gbxbusqueda.TabIndex = 118
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR ACCESO LABORATORIO"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(407, 322)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(44, 66)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(520, 245)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(118, 322)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(241, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE ACCESO LABORATORIO"
        '
        'txtusuarioB
        '
        Me.txtusuarioB.Location = New System.Drawing.Point(235, 26)
        Me.txtusuarioB.Name = "txtusuarioB"
        Me.txtusuarioB.Size = New System.Drawing.Size(192, 22)
        Me.txtusuarioB.TabIndex = 115
        '
        'lblcodigoB
        '
        Me.lblcodigoB.AutoSize = True
        Me.lblcodigoB.Location = New System.Drawing.Point(171, 28)
        Me.lblcodigoB.Name = "lblcodigoB"
        Me.lblcodigoB.Size = New System.Drawing.Size(57, 17)
        Me.lblcodigoB.TabIndex = 114
        Me.lblcodigoB.Text = "Usuario"
        '
        'E_AccesoLaboratorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 622)
        Me.Controls.Add(Me.gbxobjeto)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.KeyPreview = True
        Me.Name = "E_AccesoLaboratorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso Laboratorio"
        Me.gbxobjeto.ResumeLayout(False)
        Me.gbxobjeto.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxobjeto As GroupBox
    Friend WithEvents cbxValidar As CheckBox
    Friend WithEvents cbxConfirmar As CheckBox
    Friend WithEvents cbxObjetar As CheckBox
    Friend WithEvents cbxIngresar As CheckBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtusuarioB As TextBox
    Friend WithEvents lblcodigoB As Label
    Friend WithEvents lblcode As Label
End Class
