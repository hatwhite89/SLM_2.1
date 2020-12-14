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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormaPago))
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
        Me.btnBuscarBanco = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCodFormaPago = New System.Windows.Forms.Label()
        Me.dtFormasPago = New System.Windows.Forms.DataGridView()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.gbxInfoFormaPago.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(11, 35)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(60, 13)
        Me.lblCod.TabIndex = 1
        Me.lblCod.Text = "Cód. Breve"
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
        Me.lblDescrip.Location = New System.Drawing.Point(401, 87)
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
        Me.lblTipo.Location = New System.Drawing.Point(401, 61)
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
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtCuenta.Location = New System.Drawing.Point(110, 52)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(97, 20)
        Me.txtCuenta.TabIndex = 11
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(501, 80)
        Me.txtComentario.MaxLength = 200
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(186, 66)
        Me.txtComentario.TabIndex = 12
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Location = New System.Drawing.Point(110, 76)
        Me.txtCtaBanco.MaxLength = 50
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(239, 20)
        Me.txtCtaBanco.TabIndex = 13
        Me.txtCtaBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.Location = New System.Drawing.Point(110, 100)
        Me.txtNombreBanco.MaxLength = 100
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.Size = New System.Drawing.Size(239, 20)
        Me.txtNombreBanco.TabIndex = 15
        '
        'txtFormulario
        '
        Me.txtFormulario.Location = New System.Drawing.Point(110, 126)
        Me.txtFormulario.MaxLength = 150
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(239, 20)
        Me.txtFormulario.TabIndex = 16
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(501, 54)
        Me.txtTipo.MaxLength = 50
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(186, 20)
        Me.txtTipo.TabIndex = 18
        '
        'lblBanco
        '
        Me.lblBanco.AutoSize = True
        Me.lblBanco.Location = New System.Drawing.Point(401, 34)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(38, 13)
        Me.lblBanco.TabIndex = 29
        Me.lblBanco.Text = "Banco"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(501, 28)
        Me.txtBanco.MaxLength = 100
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(156, 20)
        Me.txtBanco.TabIndex = 30
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(514, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 23)
        Me.btnGuardar.TabIndex = 47
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'gbxInfoFormaPago
        '
        Me.gbxInfoFormaPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfoFormaPago.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxInfoFormaPago.Controls.Add(Me.btnBuscarBanco)
        Me.gbxInfoFormaPago.Controls.Add(Me.Button1)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtCodigo)
        Me.gbxInfoFormaPago.Controls.Add(Me.lblCod)
        Me.gbxInfoFormaPago.Controls.Add(Me.txtCuenta)
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
        Me.gbxInfoFormaPago.Location = New System.Drawing.Point(12, 51)
        Me.gbxInfoFormaPago.Name = "gbxInfoFormaPago"
        Me.gbxInfoFormaPago.Size = New System.Drawing.Size(695, 158)
        Me.gbxInfoFormaPago.TabIndex = 51
        Me.gbxInfoFormaPago.TabStop = False
        Me.gbxInfoFormaPago.Text = "Información Forma de Pago"
        '
        'btnBuscarBanco
        '
        Me.btnBuscarBanco.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarBanco.BackgroundImage = CType(resources.GetObject("btnBuscarBanco.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarBanco.FlatAppearance.BorderSize = 0
        Me.btnBuscarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarBanco.Location = New System.Drawing.Point(663, 28)
        Me.btnBuscarBanco.Name = "btnBuscarBanco"
        Me.btnBuscarBanco.Size = New System.Drawing.Size(20, 19)
        Me.btnBuscarBanco.TabIndex = 56
        Me.btnBuscarBanco.Text = "..."
        Me.btnBuscarBanco.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(213, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 19)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCodFormaPago)
        Me.GroupBox1.Controls.Add(Me.dtFormasPago)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 254)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Formas de Pago"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCancelar.Location = New System.Drawing.Point(596, 23)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(59, 26)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(160, 20)
        Me.txtBusqueda.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código:"
        '
        'lblCodFormaPago
        '
        Me.lblCodFormaPago.AutoSize = True
        Me.lblCodFormaPago.Location = New System.Drawing.Point(390, 28)
        Me.lblCodFormaPago.Name = "lblCodFormaPago"
        Me.lblCodFormaPago.Size = New System.Drawing.Size(39, 13)
        Me.lblCodFormaPago.TabIndex = 4
        Me.lblCodFormaPago.Text = "Label1"
        Me.lblCodFormaPago.Visible = False
        '
        'dtFormasPago
        '
        Me.dtFormasPago.AllowUserToAddRows = False
        Me.dtFormasPago.AllowUserToDeleteRows = False
        Me.dtFormasPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtFormasPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtFormasPago.BackgroundColor = System.Drawing.Color.White
        Me.dtFormasPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFormasPago.GridColor = System.Drawing.Color.White
        Me.dtFormasPago.Location = New System.Drawing.Point(6, 55)
        Me.dtFormasPago.Name = "dtFormasPago"
        Me.dtFormasPago.ReadOnly = True
        Me.dtFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFormasPago.Size = New System.Drawing.Size(682, 193)
        Me.dtFormasPago.TabIndex = 0
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.BackColor = System.Drawing.Color.White
        Me.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.Black
        Me.btnCrear.Location = New System.Drawing.Point(322, 10)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(90, 23)
        Me.btnCrear.TabIndex = 5
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(418, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 23)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnCrear)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 46)
        Me.Panel1.TabIndex = 53
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(612, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(92, 23)
        Me.btnCerrar.TabIndex = 55
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 25)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Formas de Pago"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 54
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'frmFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 497)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoFormaPago)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Formas de Pago"
        Me.gbxInfoFormaPago.ResumeLayout(False)
        Me.gbxInfoFormaPago.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnBuscarBanco As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
