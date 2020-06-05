<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_DetalleExamenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_DetalleExamenes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodExamen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodBreve = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcodeSubGrupo = New System.Windows.Forms.Label()
        Me.txtCodigoSubArea = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcodigoGrupo = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtClasificación = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecioBase = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGrupoExamen = New System.Windows.Forms.Button()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtItem = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtResultados = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Exámen"
        '
        'txtCodExamen
        '
        Me.txtCodExamen.Enabled = False
        Me.txtCodExamen.Location = New System.Drawing.Point(116, 23)
        Me.txtCodExamen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodExamen.Name = "txtCodExamen"
        Me.txtCodExamen.Size = New System.Drawing.Size(132, 22)
        Me.txtCodExamen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cód. Breve"
        '
        'txtCodBreve
        '
        Me.txtCodBreve.Location = New System.Drawing.Point(116, 55)
        Me.txtCodBreve.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodBreve.Name = "txtCodBreve"
        Me.txtCodBreve.Size = New System.Drawing.Size(132, 22)
        Me.txtCodBreve.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 87)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(539, 22)
        Me.txtDescripcion.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcodeSubGrupo)
        Me.GroupBox1.Controls.Add(Me.txtCodigoSubArea)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblcodigoGrupo)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.txtComentario)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtAbreviatura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtClasificación)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPrecioBase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnGrupoExamen)
        Me.GroupBox1.Controls.Add(Me.txtGrupo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCodExamen)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodBreve)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(664, 254)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de Exámenes"
        '
        'lblcodeSubGrupo
        '
        Me.lblcodeSubGrupo.AutoSize = True
        Me.lblcodeSubGrupo.Location = New System.Drawing.Point(588, 3)
        Me.lblcodeSubGrupo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodeSubGrupo.Name = "lblcodeSubGrupo"
        Me.lblcodeSubGrupo.Size = New System.Drawing.Size(62, 17)
        Me.lblcodeSubGrupo.TabIndex = 23
        Me.lblcodeSubGrupo.Text = "Subárea"
        Me.lblcodeSubGrupo.Visible = False
        '
        'txtCodigoSubArea
        '
        Me.txtCodigoSubArea.Location = New System.Drawing.Point(591, 24)
        Me.txtCodigoSubArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoSubArea.Name = "txtCodigoSubArea"
        Me.txtCodigoSubArea.ReadOnly = True
        Me.txtCodigoSubArea.Size = New System.Drawing.Size(65, 22)
        Me.txtCodigoSubArea.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(525, 27)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Subárea"
        '
        'lblcodigoGrupo
        '
        Me.lblcodigoGrupo.AutoSize = True
        Me.lblcodigoGrupo.Location = New System.Drawing.Point(284, 56)
        Me.lblcodigoGrupo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodigoGrupo.Name = "lblcodigoGrupo"
        Me.lblcodigoGrupo.Size = New System.Drawing.Size(38, 17)
        Me.lblcodigoGrupo.TabIndex = 20
        Me.lblcodigoGrupo.Text = "label"
        Me.lblcodigoGrupo.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.Red
        Me.lblEstado.Location = New System.Drawing.Point(576, 56)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(56, 17)
        Me.lblEstado.TabIndex = 19
        Me.lblEstado.Text = "Inactivo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(515, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Estado"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(349, 56)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(112, 21)
        Me.chkEstado.TabIndex = 17
        Me.chkEstado.Text = "Habilitar Item"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(116, 215)
        Me.txtComentario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(539, 22)
        Me.txtComentario.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 219)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Comentario"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Location = New System.Drawing.Point(116, 183)
        Me.txtAbreviatura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(539, 22)
        Me.txtAbreviatura.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 187)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Abreviatura"
        '
        'txtClasificación
        '
        Me.txtClasificación.Location = New System.Drawing.Point(116, 151)
        Me.txtClasificación.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClasificación.Name = "txtClasificación"
        Me.txtClasificación.Size = New System.Drawing.Size(132, 22)
        Me.txtClasificación.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Clasificación"
        '
        'txtPrecioBase
        '
        Me.txtPrecioBase.Location = New System.Drawing.Point(116, 119)
        Me.txtPrecioBase.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioBase.Name = "txtPrecioBase"
        Me.txtPrecioBase.Size = New System.Drawing.Size(132, 22)
        Me.txtPrecioBase.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Precio Base"
        '
        'btnGrupoExamen
        '
        Me.btnGrupoExamen.BackColor = System.Drawing.Color.Transparent
        Me.btnGrupoExamen.BackgroundImage = CType(resources.GetObject("btnGrupoExamen.BackgroundImage"), System.Drawing.Image)
        Me.btnGrupoExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGrupoExamen.FlatAppearance.BorderSize = 0
        Me.btnGrupoExamen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupoExamen.Location = New System.Drawing.Point(421, 25)
        Me.btnGrupoExamen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrupoExamen.Name = "btnGrupoExamen"
        Me.btnGrupoExamen.Size = New System.Drawing.Size(29, 22)
        Me.btnGrupoExamen.TabIndex = 8
        Me.btnGrupoExamen.UseVisualStyleBackColor = False
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(349, 23)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(65, 22)
        Me.txtGrupo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Grupo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtItem)
        Me.GroupBox2.Location = New System.Drawing.Point(688, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(509, 560)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Exámenes"
        '
        'dtItem
        '
        Me.dtItem.AllowUserToAddRows = False
        Me.dtItem.AllowUserToDeleteRows = False
        Me.dtItem.BackgroundColor = System.Drawing.Color.White
        Me.dtItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtItem.GridColor = System.Drawing.Color.White
        Me.dtItem.Location = New System.Drawing.Point(4, 19)
        Me.dtItem.Margin = New System.Windows.Forms.Padding(4)
        Me.dtItem.Name = "dtItem"
        Me.dtItem.ReadOnly = True
        Me.dtItem.RowHeadersWidth = 51
        Me.dtItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtItem.Size = New System.Drawing.Size(501, 537)
        Me.dtItem.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(219, 31)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
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
        Me.btnModificar.Location = New System.Drawing.Point(113, 31)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(8, 31)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(100, 28)
        Me.btnCrear.TabIndex = 10
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(640, 586)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(59, 17)
        Me.lblFila.TabIndex = 11
        Me.lblFila.Text = "Label10"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtResultados)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 276)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(664, 299)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Descripción de Resultados"
        '
        'dtResultados
        '
        Me.dtResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.codigoUnidad, Me.unidad})
        Me.dtResultados.Location = New System.Drawing.Point(8, 23)
        Me.dtResultados.Margin = New System.Windows.Forms.Padding(4)
        Me.dtResultados.Name = "dtResultados"
        Me.dtResultados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dtResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtResultados.Size = New System.Drawing.Size(648, 268)
        Me.dtResultados.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Visible = False
        Me.codigo.Width = 125
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 125
        '
        'codigoUnidad
        '
        Me.codigoUnidad.HeaderText = "codigoUnidad"
        Me.codigoUnidad.MinimumWidth = 6
        Me.codigoUnidad.Name = "codigoUnidad"
        Me.codigoUnidad.Visible = False
        Me.codigoUnidad.Width = 125
        '
        'unidad
        '
        Me.unidad.HeaderText = "unidad"
        Me.unidad.MinimumWidth = 6
        Me.unidad.Name = "unidad"
        Me.unidad.Width = 125
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnModificar)
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Controls.Add(Me.btnCrear)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 575)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(617, 71)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'E_DetalleExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1209, 649)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblFila)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "E_DetalleExamenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Examenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodExamen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodBreve As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAbreviatura As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtClasificación As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecioBase As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGrupoExamen As Button
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtItem As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents lblFila As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtResultados As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents codigoUnidad As DataGridViewTextBoxColumn
    Friend WithEvents unidad As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblcodigoGrupo As Label
    Friend WithEvents txtCodigoSubArea As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcodeSubGrupo As Label
End Class
