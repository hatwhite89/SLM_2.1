<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Objeto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Objeto))
        Me.gbxobjeto = New System.Windows.Forms.GroupBox()
        Me.lblcodeTipoObjeto = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.cbxcerrado = New System.Windows.Forms.CheckBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcomentarioTipo = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnbuscarTipo = New System.Windows.Forms.Button()
        Me.txtcodigoTipo = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.gbxobjeto.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxobjeto
        '
        Me.gbxobjeto.Controls.Add(Me.lblcodeTipoObjeto)
        Me.gbxobjeto.Controls.Add(Me.lblcode)
        Me.gbxobjeto.Controls.Add(Me.cbxcerrado)
        Me.gbxobjeto.Controls.Add(Me.txtnombre)
        Me.gbxobjeto.Controls.Add(Me.txtcomentarioTipo)
        Me.gbxobjeto.Controls.Add(Me.btnmodificar)
        Me.gbxobjeto.Controls.Add(Me.btnnuevo)
        Me.gbxobjeto.Controls.Add(Me.btnguardar)
        Me.gbxobjeto.Controls.Add(Me.lblcodigo)
        Me.gbxobjeto.Controls.Add(Me.lbltipo)
        Me.gbxobjeto.Controls.Add(Me.btncancelar)
        Me.gbxobjeto.Controls.Add(Me.btnbuscarTipo)
        Me.gbxobjeto.Controls.Add(Me.txtcodigoTipo)
        Me.gbxobjeto.Controls.Add(Me.lblnombre)
        Me.gbxobjeto.Controls.Add(Me.txtcodigo)
        Me.gbxobjeto.Location = New System.Drawing.Point(17, 17)
        Me.gbxobjeto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxobjeto.Name = "gbxobjeto"
        Me.gbxobjeto.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxobjeto.Size = New System.Drawing.Size(690, 158)
        Me.gbxobjeto.TabIndex = 117
        Me.gbxobjeto.TabStop = False
        Me.gbxobjeto.Text = "REGISTRAR OBJETO"
        '
        'lblcodeTipoObjeto
        '
        Me.lblcodeTipoObjeto.AutoSize = True
        Me.lblcodeTipoObjeto.Location = New System.Drawing.Point(46, 70)
        Me.lblcodeTipoObjeto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeTipoObjeto.Name = "lblcodeTipoObjeto"
        Me.lblcodeTipoObjeto.Size = New System.Drawing.Size(0, 13)
        Me.lblcodeTipoObjeto.TabIndex = 124
        Me.lblcodeTipoObjeto.Visible = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(246, 24)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 123
        Me.lblcode.Visible = False
        '
        'cbxcerrado
        '
        Me.cbxcerrado.AutoSize = True
        Me.cbxcerrado.Location = New System.Drawing.Point(434, 43)
        Me.cbxcerrado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxcerrado.Name = "cbxcerrado"
        Me.cbxcerrado.Size = New System.Drawing.Size(63, 17)
        Me.cbxcerrado.TabIndex = 118
        Me.cbxcerrado.Text = "Cerrado"
        Me.cbxcerrado.UseVisualStyleBackColor = True
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(57, 46)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre.MaxLength = 80
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(242, 20)
        Me.txtnombre.TabIndex = 117
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcomentarioTipo
        '
        Me.txtcomentarioTipo.Location = New System.Drawing.Point(548, 19)
        Me.txtcomentarioTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcomentarioTipo.Name = "txtcomentarioTipo"
        Me.txtcomentarioTipo.ReadOnly = True
        Me.txtcomentarioTipo.Size = New System.Drawing.Size(128, 20)
        Me.txtcomentarioTipo.TabIndex = 116
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(166, 121)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 114
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(7, 121)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 113
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(90, 121)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(8, 24)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(394, 22)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(28, 13)
        Me.lbltipo.TabIndex = 109
        Me.lbltipo.Text = "Tipo"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(242, 121)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnbuscarTipo
        '
        Me.btnbuscarTipo.BackColor = System.Drawing.Color.White
        Me.btnbuscarTipo.BackgroundImage = CType(resources.GetObject("btnbuscarTipo.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarTipo.FlatAppearance.BorderSize = 0
        Me.btnbuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarTipo.Location = New System.Drawing.Point(436, 19)
        Me.btnbuscarTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarTipo.Name = "btnbuscarTipo"
        Me.btnbuscarTipo.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarTipo.TabIndex = 108
        Me.btnbuscarTipo.Text = "..."
        Me.btnbuscarTipo.UseVisualStyleBackColor = False
        '
        'txtcodigoTipo
        '
        Me.txtcodigoTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoTipo.Location = New System.Drawing.Point(477, 19)
        Me.txtcodigoTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTipo.MaxLength = 20
        Me.txtcodigoTipo.Name = "txtcodigoTipo"
        Me.txtcodigoTipo.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoTipo.TabIndex = 107
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(1, 48)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 39
        Me.lblnombre.Text = "Nombre"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(57, 22)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(138, 20)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(17, 179)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(690, 295)
        Me.gbxbusqueda.TabIndex = 116
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR OBJETO"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(154, 271)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 54)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(682, 199)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(4, 271)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(112, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE OBJETOS"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(52, 24)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(634, 20)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(4, 27)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(44, 13)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Nombre"
        '
        'M_Objeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 483)
        Me.Controls.Add(Me.gbxobjeto)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Objeto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Objeto"
        Me.gbxobjeto.ResumeLayout(False)
        Me.gbxobjeto.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxobjeto As GroupBox
    Friend WithEvents txtcomentarioTipo As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnbuscarTipo As Button
    Friend WithEvents txtcodigoTipo As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents cbxcerrado As CheckBox
    Friend WithEvents lblcodeTipoObjeto As Label
    Friend WithEvents lblcode As Label
End Class
