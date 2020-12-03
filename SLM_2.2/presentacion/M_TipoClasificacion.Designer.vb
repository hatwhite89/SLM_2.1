<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_TipoClasificacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_TipoClasificacion))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.txtcomentarioB = New System.Windows.Forms.TextBox()
        Me.lblcomentarioB = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.lblCodePriceList = New System.Windows.Forms.Label()
        Me.lblListaPrecios = New System.Windows.Forms.Label()
        Me.txtdescripcionListaPrecios = New System.Windows.Forms.TextBox()
        Me.btnBuscarListaPrecios = New System.Windows.Forms.Button()
        Me.txtcodigoListaPrecios = New System.Windows.Forms.TextBox()
        Me.lblcodeCategoria = New System.Windows.Forms.Label()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.btnCategoriaCliente = New System.Windows.Forms.Button()
        Me.txtcodigoCategoriaCliente = New System.Windows.Forms.TextBox()
        Me.lblctaContado = New System.Windows.Forms.Label()
        Me.rtxtcomentario = New System.Windows.Forms.RichTextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.lblcomentario = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxclasificacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.lbltipo)
        Me.gbxbusqueda.Controls.Add(Me.txtcomentarioB)
        Me.gbxbusqueda.Controls.Add(Me.lblcomentarioB)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Location = New System.Drawing.Point(15, 220)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(928, 366)
        Me.gbxbusqueda.TabIndex = 114
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR TIPO CLASIFICACIÓN"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(521, 36)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(0, 17)
        Me.lbltipo.TabIndex = 118
        Me.lbltipo.Visible = False
        '
        'txtcomentarioB
        '
        Me.txtcomentarioB.Location = New System.Drawing.Point(91, 34)
        Me.txtcomentarioB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcomentarioB.MaxLength = 200
        Me.txtcomentarioB.Name = "txtcomentarioB"
        Me.txtcomentarioB.Size = New System.Drawing.Size(831, 22)
        Me.txtcomentarioB.TabIndex = 117
        '
        'lblcomentarioB
        '
        Me.lblcomentarioB.AutoSize = True
        Me.lblcomentarioB.Location = New System.Drawing.Point(5, 36)
        Me.lblcomentarioB.Name = "lblcomentarioB"
        Me.lblcomentarioB.Size = New System.Drawing.Size(80, 17)
        Me.lblcomentarioB.TabIndex = 116
        Me.lblcomentarioB.Text = "Comentario"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(303, 337)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(9, 64)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(913, 266)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(13, 337)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(194, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL TIPO CLASIFICACIÓN"
        '
        'gbxclasificacion
        '
        Me.gbxclasificacion.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxclasificacion.Controls.Add(Me.lblCodePriceList)
        Me.gbxclasificacion.Controls.Add(Me.lblListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.txtdescripcionListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.btnBuscarListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoListaPrecios)
        Me.gbxclasificacion.Controls.Add(Me.lblcodeCategoria)
        Me.gbxclasificacion.Controls.Add(Me.txtNombreCategoria)
        Me.gbxclasificacion.Controls.Add(Me.btnCategoriaCliente)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoCategoriaCliente)
        Me.gbxclasificacion.Controls.Add(Me.lblctaContado)
        Me.gbxclasificacion.Controls.Add(Me.rtxtcomentario)
        Me.gbxclasificacion.Controls.Add(Me.lblcodigo)
        Me.gbxclasificacion.Controls.Add(Me.lblcomentario)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigo)
        Me.gbxclasificacion.Location = New System.Drawing.Point(15, 64)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(928, 151)
        Me.gbxclasificacion.TabIndex = 116
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR CLASIFICACIÓN"
        '
        'lblCodePriceList
        '
        Me.lblCodePriceList.AutoSize = True
        Me.lblCodePriceList.Location = New System.Drawing.Point(35, 107)
        Me.lblCodePriceList.Name = "lblCodePriceList"
        Me.lblCodePriceList.Size = New System.Drawing.Size(0, 17)
        Me.lblCodePriceList.TabIndex = 148
        Me.lblCodePriceList.Visible = False
        '
        'lblListaPrecios
        '
        Me.lblListaPrecios.AutoSize = True
        Me.lblListaPrecios.Location = New System.Drawing.Point(41, 106)
        Me.lblListaPrecios.Name = "lblListaPrecios"
        Me.lblListaPrecios.Size = New System.Drawing.Size(89, 17)
        Me.lblListaPrecios.TabIndex = 147
        Me.lblListaPrecios.Text = "Lista Precios"
        '
        'txtdescripcionListaPrecios
        '
        Me.txtdescripcionListaPrecios.Location = New System.Drawing.Point(288, 106)
        Me.txtdescripcionListaPrecios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripcionListaPrecios.Name = "txtdescripcionListaPrecios"
        Me.txtdescripcionListaPrecios.ReadOnly = True
        Me.txtdescripcionListaPrecios.Size = New System.Drawing.Size(272, 22)
        Me.txtdescripcionListaPrecios.TabIndex = 146
        '
        'btnBuscarListaPrecios
        '
        Me.btnBuscarListaPrecios.BackColor = System.Drawing.Color.White
        Me.btnBuscarListaPrecios.BackgroundImage = CType(resources.GetObject("btnBuscarListaPrecios.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarListaPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarListaPrecios.FlatAppearance.BorderSize = 0
        Me.btnBuscarListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarListaPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarListaPrecios.Location = New System.Drawing.Point(139, 103)
        Me.btnBuscarListaPrecios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscarListaPrecios.Name = "btnBuscarListaPrecios"
        Me.btnBuscarListaPrecios.Size = New System.Drawing.Size(49, 22)
        Me.btnBuscarListaPrecios.TabIndex = 145
        Me.btnBuscarListaPrecios.Text = "..."
        Me.btnBuscarListaPrecios.UseVisualStyleBackColor = False
        '
        'txtcodigoListaPrecios
        '
        Me.txtcodigoListaPrecios.Location = New System.Drawing.Point(195, 106)
        Me.txtcodigoListaPrecios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoListaPrecios.MaxLength = 20
        Me.txtcodigoListaPrecios.Name = "txtcodigoListaPrecios"
        Me.txtcodigoListaPrecios.Size = New System.Drawing.Size(88, 22)
        Me.txtcodigoListaPrecios.TabIndex = 144
        Me.txtcodigoListaPrecios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcodeCategoria
        '
        Me.lblcodeCategoria.AutoSize = True
        Me.lblcodeCategoria.Location = New System.Drawing.Point(112, 47)
        Me.lblcodeCategoria.Name = "lblcodeCategoria"
        Me.lblcodeCategoria.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeCategoria.TabIndex = 137
        Me.lblcodeCategoria.Visible = False
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(288, 66)
        Me.txtNombreCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.ReadOnly = True
        Me.txtNombreCategoria.Size = New System.Drawing.Size(272, 22)
        Me.txtNombreCategoria.TabIndex = 136
        '
        'btnCategoriaCliente
        '
        Me.btnCategoriaCliente.BackColor = System.Drawing.Color.White
        Me.btnCategoriaCliente.BackgroundImage = CType(resources.GetObject("btnCategoriaCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnCategoriaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoriaCliente.FlatAppearance.BorderSize = 0
        Me.btnCategoriaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoriaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoriaCliente.Location = New System.Drawing.Point(139, 65)
        Me.btnCategoriaCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCategoriaCliente.Name = "btnCategoriaCliente"
        Me.btnCategoriaCliente.Size = New System.Drawing.Size(49, 22)
        Me.btnCategoriaCliente.TabIndex = 135
        Me.btnCategoriaCliente.Text = "..."
        Me.btnCategoriaCliente.UseVisualStyleBackColor = False
        '
        'txtcodigoCategoriaCliente
        '
        Me.txtcodigoCategoriaCliente.Location = New System.Drawing.Point(195, 65)
        Me.txtcodigoCategoriaCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoCategoriaCliente.MaxLength = 20
        Me.txtcodigoCategoriaCliente.Name = "txtcodigoCategoriaCliente"
        Me.txtcodigoCategoriaCliente.Size = New System.Drawing.Size(88, 22)
        Me.txtcodigoCategoriaCliente.TabIndex = 134
        Me.txtcodigoCategoriaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblctaContado
        '
        Me.lblctaContado.AutoSize = True
        Me.lblctaContado.Location = New System.Drawing.Point(13, 66)
        Me.lblctaContado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblctaContado.Name = "lblctaContado"
        Me.lblctaContado.Size = New System.Drawing.Size(116, 17)
        Me.lblctaContado.TabIndex = 133
        Me.lblctaContado.Text = "Categoría Cliente"
        '
        'rtxtcomentario
        '
        Me.rtxtcomentario.Location = New System.Drawing.Point(597, 26)
        Me.rtxtcomentario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtcomentario.MaxLength = 200
        Me.rtxtcomentario.Name = "rtxtcomentario"
        Me.rtxtcomentario.Size = New System.Drawing.Size(311, 117)
        Me.rtxtcomentario.TabIndex = 115
        Me.rtxtcomentario.Text = ""
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(73, 28)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'lblcomentario
        '
        Me.lblcomentario.AutoSize = True
        Me.lblcomentario.Location = New System.Drawing.Point(480, 26)
        Me.lblcomentario.Name = "lblcomentario"
        Me.lblcomentario.Size = New System.Drawing.Size(80, 17)
        Me.lblcomentario.TabIndex = 39
        Me.lblcomentario.Text = "Comentario"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(139, 25)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(183, 22)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(751, 14)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 114
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(539, 14)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 113
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(649, 14)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(852, 14)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 600)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 117
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 54)
        Me.Panel1.TabIndex = 118
        '
        'M_TipoClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 622)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_TipoClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Clasificación"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxclasificacion.ResumeLayout(False)
        Me.gbxclasificacion.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents gbxclasificacion As GroupBox
    Friend WithEvents rtxtcomentario As RichTextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblcomentario As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtcomentarioB As TextBox
    Friend WithEvents lblcomentarioB As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents btnCategoriaCliente As Button
    Friend WithEvents txtcodigoCategoriaCliente As TextBox
    Friend WithEvents lblctaContado As Label
    Friend WithEvents lblcodeCategoria As Label
    Friend WithEvents txtdescripcionListaPrecios As TextBox
    Friend WithEvents btnBuscarListaPrecios As Button
    Friend WithEvents txtcodigoListaPrecios As TextBox
    Friend WithEvents lblCodePriceList As Label
    Friend WithEvents lblListaPrecios As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
End Class
