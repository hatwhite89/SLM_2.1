<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_Cuenta
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
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbxCuenta = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblTipoDetalle = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cbxTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.lblEstadoColor = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCodCuenta = New System.Windows.Forms.Label()
        Me.gbxCuentas = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtCuentas = New System.Windows.Forms.DataGridView()
        Me.gbxCuenta.SuspendLayout()
        Me.gbxCuentas.SuspendLayout()
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(7, 32)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "Cuenta"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(54, 28)
        Me.txtCuenta.MaxLength = 8
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtCuenta.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(7, 57)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(54, 54)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(316, 20)
        Me.txtNombre.TabIndex = 3
        '
        'gbxCuenta
        '
        Me.gbxCuenta.Controls.Add(Me.btnNuevo)
        Me.gbxCuenta.Controls.Add(Me.lblTipoDetalle)
        Me.gbxCuenta.Controls.Add(Me.btnModificar)
        Me.gbxCuenta.Controls.Add(Me.btnGuardar)
        Me.gbxCuenta.Controls.Add(Me.lblTipo)
        Me.gbxCuenta.Controls.Add(Me.cbxTipoCuenta)
        Me.gbxCuenta.Controls.Add(Me.txtCuenta)
        Me.gbxCuenta.Controls.Add(Me.lblEstadoColor)
        Me.gbxCuenta.Controls.Add(Me.lblCuenta)
        Me.gbxCuenta.Controls.Add(Me.txtNombre)
        Me.gbxCuenta.Controls.Add(Me.chkEstado)
        Me.gbxCuenta.Controls.Add(Me.lblNombre)
        Me.gbxCuenta.Controls.Add(Me.lblEstado)
        Me.gbxCuenta.Location = New System.Drawing.Point(13, 12)
        Me.gbxCuenta.Name = "gbxCuenta"
        Me.gbxCuenta.Size = New System.Drawing.Size(698, 152)
        Me.gbxCuenta.TabIndex = 4
        Me.gbxCuenta.TabStop = False
        Me.gbxCuenta.Text = "Información de Cuenta"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(6, 123)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Crear Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        Me.btnNuevo.Visible = False
        '
        'lblTipoDetalle
        '
        Me.lblTipoDetalle.AutoSize = True
        Me.lblTipoDetalle.Location = New System.Drawing.Point(160, 83)
        Me.lblTipoDetalle.Name = "lblTipoDetalle"
        Me.lblTipoDetalle.Size = New System.Drawing.Size(17, 13)
        Me.lblTipoDetalle.TabIndex = 16
        Me.lblTipoDetalle.Text = "lbl"
        Me.lblTipoDetalle.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(84, 123)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(162, 123)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(7, 83)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 11
        Me.lblTipo.Text = "Tipo"
        '
        'cbxTipoCuenta
        '
        Me.cbxTipoCuenta.FormattingEnabled = True
        Me.cbxTipoCuenta.Items.AddRange(New Object() {"Activo", "Pasivo", "Patrimonio", "Ingresos", "Gastos"})
        Me.cbxTipoCuenta.Location = New System.Drawing.Point(54, 80)
        Me.cbxTipoCuenta.Name = "cbxTipoCuenta"
        Me.cbxTipoCuenta.Size = New System.Drawing.Size(100, 21)
        Me.cbxTipoCuenta.TabIndex = 13
        '
        'lblEstadoColor
        '
        Me.lblEstadoColor.AutoSize = True
        Me.lblEstadoColor.BackColor = System.Drawing.Color.Transparent
        Me.lblEstadoColor.ForeColor = System.Drawing.Color.Red
        Me.lblEstadoColor.Location = New System.Drawing.Point(418, 57)
        Me.lblEstadoColor.Name = "lblEstadoColor"
        Me.lblEstadoColor.Size = New System.Drawing.Size(16, 13)
        Me.lblEstadoColor.TabIndex = 12
        Me.lblEstadoColor.Text = "---"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(378, 28)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(101, 17)
        Me.chkEstado.TabIndex = 10
        Me.chkEstado.Text = "Habilitar Cuenta"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(375, 57)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado"
        '
        'lblCodCuenta
        '
        Me.lblCodCuenta.AutoSize = True
        Me.lblCodCuenta.Location = New System.Drawing.Point(728, 66)
        Me.lblCodCuenta.Name = "lblCodCuenta"
        Me.lblCodCuenta.Size = New System.Drawing.Size(39, 13)
        Me.lblCodCuenta.TabIndex = 15
        Me.lblCodCuenta.Text = "Label1"
        Me.lblCodCuenta.Visible = False
        '
        'gbxCuentas
        '
        Me.gbxCuentas.Controls.Add(Me.btnCancelar)
        Me.gbxCuentas.Controls.Add(Me.txtBusqueda)
        Me.gbxCuentas.Controls.Add(Me.Label1)
        Me.gbxCuentas.Controls.Add(Me.dtCuentas)
        Me.gbxCuentas.Location = New System.Drawing.Point(13, 170)
        Me.gbxCuentas.Name = "gbxCuentas"
        Me.gbxCuentas.Size = New System.Drawing.Size(698, 271)
        Me.gbxCuentas.TabIndex = 7
        Me.gbxCuentas.TabStop = False
        Me.gbxCuentas.Text = "Listado de Cuentas"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(617, 23)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(60, 25)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(374, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'dtCuentas
        '
        Me.dtCuentas.AllowUserToAddRows = False
        Me.dtCuentas.AllowUserToDeleteRows = False
        Me.dtCuentas.BackgroundColor = System.Drawing.Color.White
        Me.dtCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtCuentas.GridColor = System.Drawing.Color.White
        Me.dtCuentas.Location = New System.Drawing.Point(6, 51)
        Me.dtCuentas.MultiSelect = False
        Me.dtCuentas.Name = "dtCuentas"
        Me.dtCuentas.ReadOnly = True
        Me.dtCuentas.RowHeadersVisible = False
        Me.dtCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCuentas.Size = New System.Drawing.Size(686, 210)
        Me.dtCuentas.TabIndex = 0
        '
        'A_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCodCuenta)
        Me.Controls.Add(Me.gbxCuentas)
        Me.Controls.Add(Me.gbxCuenta)
        Me.KeyPreview = True
        Me.Name = "A_Cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Cuentas"
        Me.gbxCuenta.ResumeLayout(False)
        Me.gbxCuenta.PerformLayout()
        Me.gbxCuentas.ResumeLayout(False)
        Me.gbxCuentas.PerformLayout()
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCuenta As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents gbxCuenta As GroupBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents gbxCuentas As GroupBox
    Friend WithEvents dtCuentas As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblEstadoColor As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbxTipoCuenta As ComboBox
    Friend WithEvents lblCodCuenta As Label
    Friend WithEvents lblTipoDetalle As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
End Class
