<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Cuenta
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
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.gbxCuentas = New System.Windows.Forms.GroupBox()
        Me.dtCuentas = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblEstadoColor = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.gbxCuentas.SuspendLayout()
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(11, 24)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "Cuenta"
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(55, 21)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtCuenta.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(169, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(216, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(185, 20)
        Me.txtNombre.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(13, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 144)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Cuenta"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(168, 60)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado"
        '
        'gbxCuentas
        '
        Me.gbxCuentas.Controls.Add(Me.dtCuentas)
        Me.gbxCuentas.Location = New System.Drawing.Point(14, 219)
        Me.gbxCuentas.Name = "gbxCuentas"
        Me.gbxCuentas.Size = New System.Drawing.Size(385, 235)
        Me.gbxCuentas.TabIndex = 7
        Me.gbxCuentas.TabStop = False
        Me.gbxCuentas.Text = "Listado de Cuentas"
        '
        'dtCuentas
        '
        Me.dtCuentas.AllowUserToAddRows = False
        Me.dtCuentas.AllowUserToDeleteRows = False
        Me.dtCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCuentas.Location = New System.Drawing.Point(6, 19)
        Me.dtCuentas.Name = "dtCuentas"
        Me.dtCuentas.ReadOnly = True
        Me.dtCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCuentas.Size = New System.Drawing.Size(373, 210)
        Me.dtCuentas.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(243, 181)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(324, 181)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(172, 84)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(118, 17)
        Me.chkEstado.TabIndex = 10
        Me.chkEstado.Text = "Deshabilitar Cuenta"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(136, 133)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 13)
        Me.lblTipo.TabIndex = 11
        Me.lblTipo.Text = "Label1"
        '
        'lblEstadoColor
        '
        Me.lblEstadoColor.AutoSize = True
        Me.lblEstadoColor.Location = New System.Drawing.Point(219, 60)
        Me.lblEstadoColor.Name = "lblEstadoColor"
        Me.lblEstadoColor.Size = New System.Drawing.Size(16, 13)
        Me.lblEstadoColor.TabIndex = 12
        Me.lblEstadoColor.Text = "---"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Activo", "Pasivo", "Patrimonio", "Ingresos", "Gastos"})
        Me.ComboBox1.Location = New System.Drawing.Point(222, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'A_Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblEstadoColor)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbxCuentas)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.lblCuenta)
        Me.KeyPreview = True
        Me.Name = "A_Cuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimeinto de Cuentas"
        Me.gbxCuentas.ResumeLayout(False)
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCuenta As Label
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents gbxCuentas As GroupBox
    Friend WithEvents dtCuentas As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblEstadoColor As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
