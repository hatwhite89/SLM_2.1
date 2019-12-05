<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFormaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormaPago))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtRetencion = New System.Windows.Forms.TextBox()
        Me.lblRetencion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.lblCodFormaPago = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(619, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(15, 43)
        Me.lblCod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(52, 17)
        Me.lblCod.TabIndex = 1
        Me.lblCod.Text = "Código"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(13, 73)
        Me.lblCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(53, 17)
        Me.lblCuenta.TabIndex = 2
        Me.lblCuenta.Text = "Cuenta"
        '
        'lblCuentaBanco
        '
        Me.lblCuentaBanco.AutoSize = True
        Me.lblCuentaBanco.Location = New System.Drawing.Point(13, 102)
        Me.lblCuentaBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuentaBanco.Name = "lblCuentaBanco"
        Me.lblCuentaBanco.Size = New System.Drawing.Size(108, 17)
        Me.lblCuentaBanco.TabIndex = 3
        Me.lblCuentaBanco.Text = "Nro. Cta. Banco"
        '
        'lblDescrip
        '
        Me.lblDescrip.AutoSize = True
        Me.lblDescrip.Location = New System.Drawing.Point(299, 100)
        Me.lblDescrip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescrip.Name = "lblDescrip"
        Me.lblDescrip.Size = New System.Drawing.Size(80, 17)
        Me.lblDescrip.TabIndex = 4
        Me.lblDescrip.Text = "Comentario"
        '
        'lblNombreBanco
        '
        Me.lblNombreBanco.AutoSize = True
        Me.lblNombreBanco.Location = New System.Drawing.Point(13, 132)
        Me.lblNombreBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreBanco.Name = "lblNombreBanco"
        Me.lblNombreBanco.Size = New System.Drawing.Size(102, 17)
        Me.lblNombreBanco.TabIndex = 6
        Me.lblNombreBanco.Text = "Nombre Banco"
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Location = New System.Drawing.Point(13, 164)
        Me.lblFormulario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(75, 17)
        Me.lblFormulario.TabIndex = 7
        Me.lblFormulario.Text = "Formulario"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(299, 68)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(36, 17)
        Me.lblTipo.TabIndex = 9
        Me.lblTipo.Text = "Tipo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(147, 34)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigo.TabIndex = 10
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta.Location = New System.Drawing.Point(147, 64)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(93, 23)
        Me.txtCuenta.TabIndex = 11
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(432, 91)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(132, 22)
        Me.txtComentario.TabIndex = 12
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Location = New System.Drawing.Point(147, 94)
        Me.txtCtaBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(132, 22)
        Me.txtCtaBanco.TabIndex = 13
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.Location = New System.Drawing.Point(147, 123)
        Me.txtNombreBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.Size = New System.Drawing.Size(132, 22)
        Me.txtNombreBanco.TabIndex = 15
        '
        'txtFormulario
        '
        Me.txtFormulario.Location = New System.Drawing.Point(147, 155)
        Me.txtFormulario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(132, 22)
        Me.txtFormulario.TabIndex = 16
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(432, 59)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(132, 22)
        Me.txtTipo.TabIndex = 18
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(299, 34)
        Me.lblBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(48, 17)
        Me.lblBanco.TabIndex = 29
        Me.lblBanco.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(432, 27)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(132, 22)
        Me.txtBanco.TabIndex = 30
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(457, 187)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 28)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'gbxInfoFormaPago
        '
        Me.gbxInfoFormaPago.Controls.Add(Me.Button1)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtRetencion)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblRetencion)
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
        Me.gbxInfoFormaPago.Location = New System.Drawing.Point(15, 42)
        Me.gbxInfoFormaPago.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxInfoFormaPago.Name = "gbxInfoFormaPago"
        Me.gbxInfoFormaPago.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxInfoFormaPago.Size = New System.Drawing.Size(591, 225)
        Me.gbxInfoFormaPago.TabIndex = 51
        Me.gbxInfoFormaPago.TabStop = False
        Me.gbxInfoFormaPago.Text = "Información Forma de Pago"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(249, 65)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 55
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtRetencion
        '
        Me.txtRetencion.Location = New System.Drawing.Point(432, 123)
        Me.txtRetencion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetencion.Name = "txtRetencion"
        Me.txtRetencion.Size = New System.Drawing.Size(132, 22)
        Me.txtRetencion.TabIndex = 54
        Me.txtRetencion.Text = "0.0"
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = True
        Me.lblRetencion.Location = New System.Drawing.Point(299, 127)
        Me.lblRetencion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(72, 17)
        Me.lblRetencion.TabIndex = 53
        Me.lblRetencion.Text = "Retención"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCrear)
        Me.GroupBox1.Controls.Add(Me.lblCodFormaPago)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.dtFormasPago)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 274)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(589, 271)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Formas de Pago"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(331, 228)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(120, 28)
        Me.btnCrear.TabIndex = 5
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        Me.btnCrear.Visible = False
        '
        'lblCodFormaPago
        '
        Me.lblCodFormaPago.AutoSize = True
        Me.lblCodFormaPago.Location = New System.Drawing.Point(271, 234)
        Me.lblCodFormaPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodFormaPago.Name = "lblCodFormaPago"
        Me.lblCodFormaPago.Size = New System.Drawing.Size(51, 17)
        Me.lblCodFormaPago.TabIndex = 4
        Me.lblCodFormaPago.Text = "Label1"
        Me.lblCodFormaPago.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(459, 228)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(120, 28)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'dtFormasPago
        '
        Me.dtFormasPago.AllowUserToAddRows = False
        Me.dtFormasPago.AllowUserToDeleteRows = False
        Me.dtFormasPago.BackgroundColor = System.Drawing.Color.White
        Me.dtFormasPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFormasPago.GridColor = System.Drawing.Color.White
        Me.dtFormasPago.Location = New System.Drawing.Point(8, 21)
        Me.dtFormasPago.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFormasPago.Name = "dtFormasPago"
        Me.dtFormasPago.ReadOnly = True
        Me.dtFormasPago.RowHeadersWidth = 51
        Me.dtFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFormasPago.Size = New System.Drawing.Size(571, 199)
        Me.dtFormasPago.TabIndex = 0
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 555)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoFormaPago)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents dtFormasPago As DataGridView
    Friend WithEvents lblCodFormaPago As Label
    Friend WithEvents txtRetencion As TextBox
    Friend WithEvents lblRetencion As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCrear As Button
End Class
