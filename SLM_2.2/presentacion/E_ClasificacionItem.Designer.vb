<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_ClasificacionItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_ClasificacionItem))
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.txtcomentarioTipo = New System.Windows.Forms.TextBox()
        Me.rtxtNombre = New System.Windows.Forms.RichTextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnbuscarTipo = New System.Windows.Forms.Button()
        Me.txtcodigoTipo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtNombreB = New System.Windows.Forms.TextBox()
        Me.lblNombreB = New System.Windows.Forms.Label()
        Me.gbxclasificacion.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxclasificacion
        '
        Me.gbxclasificacion.Controls.Add(Me.lblcode)
        Me.gbxclasificacion.Controls.Add(Me.txtcomentarioTipo)
        Me.gbxclasificacion.Controls.Add(Me.rtxtNombre)
        Me.gbxclasificacion.Controls.Add(Me.btnmodificar)
        Me.gbxclasificacion.Controls.Add(Me.btnnuevo)
        Me.gbxclasificacion.Controls.Add(Me.btnguardar)
        Me.gbxclasificacion.Controls.Add(Me.lblcodigo)
        Me.gbxclasificacion.Controls.Add(Me.lbltipo)
        Me.gbxclasificacion.Controls.Add(Me.btncancelar)
        Me.gbxclasificacion.Controls.Add(Me.btnbuscarTipo)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoTipo)
        Me.gbxclasificacion.Controls.Add(Me.lblNombre)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigo)
        Me.gbxclasificacion.Location = New System.Drawing.Point(4, 11)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(703, 135)
        Me.gbxclasificacion.TabIndex = 117
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR CLASIFICACIÓN ITEM"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(212, 13)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 117
        Me.lblcode.Visible = False
        '
        'txtcomentarioTipo
        '
        Me.txtcomentarioTipo.Location = New System.Drawing.Point(175, 51)
        Me.txtcomentarioTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcomentarioTipo.Name = "txtcomentarioTipo"
        Me.txtcomentarioTipo.ReadOnly = True
        Me.txtcomentarioTipo.Size = New System.Drawing.Size(128, 20)
        Me.txtcomentarioTipo.TabIndex = 116
        '
        'rtxtNombre
        '
        Me.rtxtNombre.Location = New System.Drawing.Point(375, 17)
        Me.rtxtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtNombre.MaxLength = 100
        Me.rtxtNombre.Name = "rtxtNombre"
        Me.rtxtNombre.Size = New System.Drawing.Size(324, 68)
        Me.rtxtNombre.TabIndex = 115
        Me.rtxtNombre.Text = ""
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(177, 100)
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
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(18, 100)
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
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(101, 100)
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
        Me.lblcodigo.Location = New System.Drawing.Point(15, 15)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(24, 52)
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
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(253, 100)
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
        Me.btnbuscarTipo.Location = New System.Drawing.Point(64, 51)
        Me.btnbuscarTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarTipo.Name = "btnbuscarTipo"
        Me.btnbuscarTipo.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarTipo.TabIndex = 108
        Me.btnbuscarTipo.Text = "..."
        Me.btnbuscarTipo.UseVisualStyleBackColor = False
        '
        'txtcodigoTipo
        '
        Me.txtcodigoTipo.Location = New System.Drawing.Point(105, 51)
        Me.txtcodigoTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoTipo.MaxLength = 20
        Me.txtcodigoTipo.Name = "txtcodigoTipo"
        Me.txtcodigoTipo.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoTipo.TabIndex = 107
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(322, 19)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 39
        Me.lblNombre.Text = "Nombre"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(64, 13)
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
        Me.gbxbusqueda.Controls.Add(Me.txtNombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblNombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(4, 150)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(703, 344)
        Me.gbxbusqueda.TabIndex = 116
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR CLASIFICACIÓN ITEM"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(224, 320)
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
        Me.dgbtabla.Location = New System.Drawing.Point(4, 47)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(695, 271)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(7, 320)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(156, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE CLASIFICACIONES"
        '
        'txtNombreB
        '
        Me.txtNombreB.Location = New System.Drawing.Point(79, 23)
        Me.txtNombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreB.MaxLength = 100
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Size = New System.Drawing.Size(620, 20)
        Me.txtNombreB.TabIndex = 115
        '
        'lblNombreB
        '
        Me.lblNombreB.AutoSize = True
        Me.lblNombreB.Location = New System.Drawing.Point(15, 26)
        Me.lblNombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreB.Name = "lblNombreB"
        Me.lblNombreB.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreB.TabIndex = 114
        Me.lblNombreB.Text = "Nombre"
        '
        'E_ClasificacionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "E_ClasificacionItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación Item"
        Me.gbxclasificacion.ResumeLayout(False)
        Me.gbxclasificacion.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxclasificacion As GroupBox
    Friend WithEvents txtcomentarioTipo As TextBox
    Friend WithEvents rtxtNombre As RichTextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnbuscarTipo As Button
    Friend WithEvents txtcodigoTipo As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtNombreB As TextBox
    Friend WithEvents lblNombreB As Label
    Friend WithEvents lblcode As Label
End Class
