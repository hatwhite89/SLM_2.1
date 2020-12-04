<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_frmFirmaDigital
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_frmFirmaDigital))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtAbre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cod_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_completo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abreviatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_firma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(6, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.Color.White
        Me.btnExaminar.Location = New System.Drawing.Point(116, 154)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Examinar..."
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(6, 154)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNombreUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtNombreUsuario.Location = New System.Drawing.Point(151, 35)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(219, 20)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(6, 79)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(364, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.Location = New System.Drawing.Point(6, 35)
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.ReadOnly = True
        Me.txtCodUsuario.Size = New System.Drawing.Size(130, 20)
        Me.txtCodUsuario.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_usuario, Me.nombre_usuario, Me.nombre_completo, Me.puesto, Me.abreviatura, Me.imagen, Me.fecha_firma})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(765, 195)
        Me.DataGridView1.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 233)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de firmas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Click en la fila para cargar firma digital"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.btnExaminar)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(465, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 183)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Imagen"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(98, 154)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.txtAbre)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtPuesto)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Controls.Add(Me.txtCodUsuario)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(447, 183)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mantenimiento Firma"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.LightSalmon
        Me.btnModificar.Location = New System.Drawing.Point(190, 154)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Eliminar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtAbre
        '
        Me.txtAbre.Location = New System.Drawing.Point(207, 124)
        Me.txtAbre.Name = "txtAbre"
        Me.txtAbre.Size = New System.Drawing.Size(163, 20)
        Me.txtAbre.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Abreviatura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Puesto"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(6, 124)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.ReadOnly = True
        Me.txtPuesto.Size = New System.Drawing.Size(195, 20)
        Me.txtPuesto.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre Completo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*Escriba el nombre de usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cod Usuario"
        '
        'cod_usuario
        '
        Me.cod_usuario.DataPropertyName = "cod_usuario"
        Me.cod_usuario.HeaderText = "ID USUARIO"
        Me.cod_usuario.Name = "cod_usuario"
        '
        'nombre_usuario
        '
        Me.nombre_usuario.DataPropertyName = "nombre_usuario"
        Me.nombre_usuario.HeaderText = "USUARIO"
        Me.nombre_usuario.Name = "nombre_usuario"
        '
        'nombre_completo
        '
        Me.nombre_completo.DataPropertyName = "nombre_completo"
        Me.nombre_completo.HeaderText = "NOMBRE COMPLETO"
        Me.nombre_completo.Name = "nombre_completo"
        '
        'puesto
        '
        Me.puesto.DataPropertyName = "puesto"
        Me.puesto.HeaderText = "PUESTO"
        Me.puesto.Name = "puesto"
        '
        'abreviatura
        '
        Me.abreviatura.DataPropertyName = "abreviatura"
        Me.abreviatura.HeaderText = "ABREVIATURA"
        Me.abreviatura.Name = "abreviatura"
        '
        'imagen
        '
        Me.imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.imagen.DataPropertyName = "imagen"
        Me.imagen.HeaderText = "IMAGEN"
        Me.imagen.Name = "imagen"
        '
        'fecha_firma
        '
        Me.fecha_firma.DataPropertyName = "fecha_firma"
        Me.fecha_firma.HeaderText = "FECHA CREACION"
        Me.fecha_firma.Name = "fecha_firma"
        '
        'E_frmFirmaDigital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "E_frmFirmaDigital"
        Me.Text = "Firma Digital"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodUsuario As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtAbre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents cod_usuario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_usuario As DataGridViewTextBoxColumn
    Friend WithEvents nombre_completo As DataGridViewTextBoxColumn
    Friend WithEvents puesto As DataGridViewTextBoxColumn
    Friend WithEvents abreviatura As DataGridViewTextBoxColumn
    Friend WithEvents imagen As DataGridViewTextBoxColumn
    Friend WithEvents fecha_firma As DataGridViewTextBoxColumn
End Class
