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
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.lblCuentaBanco = New System.Windows.Forms.Label()
        Me.lblDescrip = New System.Windows.Forms.Label()
        Me.lblNombreBanco = New System.Windows.Forms.Label()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.txtCtaBanco = New System.Windows.Forms.TextBox()
        Me.txtNombreBanco = New System.Windows.Forms.TextBox()
        Me.txtFormulario = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.lblBanco = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbxInfoFormaPago = New System.Windows.Forms.GroupBox()
        Me.txtRetencion = New System.Windows.Forms.TextBox()
        Me.lblRetencion = New System.Windows.Forms.Label()
        Me.txtComision = New System.Windows.Forms.TextBox()
        Me.lblComision = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCodFormaPago = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dtFormasPago = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxInfoFormaPago.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(464, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(11, 35)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCod.TabIndex = 1
        Me.lblCod.Text = "Código"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(10, 59)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 2
        Me.lblCuenta.Text = "Cuenta"
        '
        'lblCuentaBanco
        '
        Me.lblCuentaBanco.AutoSize = True
        Me.lblCuentaBanco.Location = New System.Drawing.Point(10, 83)
        Me.lblCuentaBanco.Name = "lblCuentaBanco"
        Me.lblCuentaBanco.Size = New System.Drawing.Size(83, 13)
        Me.lblCuentaBanco.TabIndex = 3
        Me.lblCuentaBanco.Text = "Nro. Cta. Banco"
        '
        'lblDescrip
        '
        Me.lblDescrip.AutoSize = True
        Me.lblDescrip.Location = New System.Drawing.Point(224, 81)
        Me.lblDescrip.Name = "lblDescrip"
        Me.lblDescrip.Size = New System.Drawing.Size(60, 13)
        Me.lblDescrip.TabIndex = 4
        Me.lblDescrip.Text = "Comentario"
        '
        'lblNombreBanco
        '
        Me.lblNombreBanco.AutoSize = True
        Me.lblNombreBanco.Location = New System.Drawing.Point(10, 107)
        Me.lblNombreBanco.Name = "lblNombreBanco"
        Me.lblNombreBanco.Size = New System.Drawing.Size(78, 13)
        Me.lblNombreBanco.TabIndex = 6
        Me.lblNombreBanco.Text = "Nombre Banco"
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Location = New System.Drawing.Point(10, 133)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(55, 13)
        Me.lblFormulario.TabIndex = 7
        Me.lblFormulario.Text = "Formulario"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(224, 55)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 9
        Me.lblTipo.Text = "Tipo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(110, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(110, 52)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(100, 20)
        Me.txtCuenta.TabIndex = 11
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(324, 74)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(100, 20)
        Me.txtComentario.TabIndex = 12
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Location = New System.Drawing.Point(110, 76)
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtCtaBanco.TabIndex = 13
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.Location = New System.Drawing.Point(110, 100)
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreBanco.TabIndex = 15
        '
        'txtFormulario
        '
        Me.txtFormulario.Location = New System.Drawing.Point(110, 126)
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(100, 20)
        Me.txtFormulario.TabIndex = 16
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(324, 48)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 18
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(224, 28)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 29
        Me.lblBanco.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(324, 22)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 30
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(345, 177)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 23)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'gbxInfoFormaPago
        '
        Me.gbxInfoFormaPago.Controls.Add(Me.txtRetencion)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblRetencion)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtComision)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblComision)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtCodigo)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblCod)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtCuenta)
        Me.gbxInfoFormaPago.Controls.Add(Me.btnGuardar)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblCuenta)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtCtaBanco)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtFormulario)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblFormulario)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtTipo)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtBanco)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtComentario)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblBanco)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblCuentaBanco)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblDescrip)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtNombreBanco)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblTipo)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblNombreBanco)
        Me.gbxInfoFormaPago.Location = New System.Drawing.Point(11, 34)
        Me.gbxInfoFormaPago.Name = "gbxInfoFormaPago"
        Me.gbxInfoFormaPago.Size = New System.Drawing.Size(443, 206)
        Me.gbxInfoFormaPago.TabIndex = 51
        Me.gbxInfoFormaPago.TabStop = False
        Me.gbxInfoFormaPago.Text = "Información Forma de Pago"
        '
        'txtRetencion
        '
        Me.txtRetencion.Location = New System.Drawing.Point(324, 126)
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(100, 20)
        Me.txtRetencion.TabIndex = 54
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = True
        Me.lblRetencion.Location = New System.Drawing.Point(224, 129)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(56, 13)
        Me.lblRetencion.TabIndex = 53
        Me.lblRetencion.Text = "Retención"
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(324, 100)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Size = New System.Drawing.Size(100, 20)
        Me.txtComision.TabIndex = 52
        '
        'lblComision
        '
        Me.lblComision.AutoSize = True
        Me.lblComision.Location = New System.Drawing.Point(225, 104)
        Me.lblComision.Name = "lblComision"
        Me.lblComision.Size = New System.Drawing.Size(49, 13)
        Me.lblComision.TabIndex = 51
        Me.lblComision.Text = "Comisión"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCodFormaPago)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.dtFormasPago)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 187)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Formas de Pago"
        '
        'lblCodFormaPago
        '
        Me.lblCodFormaPago.AutoSize = True
        Me.lblCodFormaPago.Location = New System.Drawing.Point(395, 166)
        Me.lblCodFormaPago.Name = "lblCodFormaPago"
        Me.lblCodFormaPago.Size = New System.Drawing.Size(39, 13)
        Me.lblCodFormaPago.TabIndex = 4
        Me.lblCodFormaPago.Text = "Label1"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(344, 46)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(344, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'dtFormasPago
        '
        Me.dtFormasPago.AllowUserToAddRows = False
        Me.dtFormasPago.AllowUserToDeleteRows = False
        Me.dtFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFormasPago.Location = New System.Drawing.Point(11, 17)
        Me.dtFormasPago.Name = "dtFormasPago"
        Me.dtFormasPago.ReadOnly = True
        Me.dtFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFormasPago.Size = New System.Drawing.Size(327, 162)
        Me.dtFormasPago.TabIndex = 0
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(464, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoFormaPago)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Formas de Pago"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxInfoFormaPago.ResumeLayout(False)
        Me.gbxInfoFormaPago.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCod As Label
    Friend WithEvents lblCuenta As Label
    Friend WithEvents lblCuentaBanco As Label
    Friend WithEvents lblDescrip As Label
    Friend WithEvents lblNombreBanco As Label
    Friend WithEvents lblFormulario As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents txtCtaBanco As TextBox
    Friend WithEvents txtNombreBanco As TextBox
    Friend WithEvents txtFormulario As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents lblBanco As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents gbxInfoFormaPago As GroupBox
    Friend WithEvents txtComision As TextBox
    Friend WithEvents lblComision As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents dtFormasPago As DataGridView
    Friend WithEvents lblCodFormaPago As Label
    Friend WithEvents txtRetencion As TextBox
    Friend WithEvents lblRetencion As Label
End Class
