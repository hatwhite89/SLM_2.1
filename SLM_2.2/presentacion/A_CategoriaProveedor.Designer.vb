<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_CategoriaProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_CategoriaProveedor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodBreve = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAcreedores = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAnticipos = New System.Windows.Forms.TextBox()
        Me.gbxInfo = New System.Windows.Forms.GroupBox()
        Me.btnBuscarClas = New System.Windows.Forms.Button()
        Me.txtClasifica = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCodCat = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtCategorias = New System.Windows.Forms.DataGridView()
        Me.gbxInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Breve"
        '
        'txtCodBreve
        '
        Me.txtCodBreve.Location = New System.Drawing.Point(93, 27)
        Me.txtCodBreve.MaxLength = 50
        Me.txtCodBreve.Name = "txtCodBreve"
        Me.txtCodBreve.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBreve.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(93, 54)
        Me.txtDescrip.MaxLength = 150
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(261, 20)
        Me.txtDescrip.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cta. Acreedores"
        '
        'txtAcreedores
        '
        Me.txtAcreedores.Location = New System.Drawing.Point(450, 27)
        Me.txtAcreedores.MaxLength = 20
        Me.txtAcreedores.Name = "txtAcreedores"
        Me.txtAcreedores.Size = New System.Drawing.Size(100, 20)
        Me.txtAcreedores.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cta. Anticipos"
        '
        'txtAnticipos
        '
        Me.txtAnticipos.Location = New System.Drawing.Point(450, 53)
        Me.txtAnticipos.MaxLength = 20
        Me.txtAnticipos.Name = "txtAnticipos"
        Me.txtAnticipos.Size = New System.Drawing.Size(100, 20)
        Me.txtAnticipos.TabIndex = 7
        '
        'gbxInfo
        '
        Me.gbxInfo.Controls.Add(Me.btnBuscarClas)
        Me.gbxInfo.Controls.Add(Me.txtClasifica)
        Me.gbxInfo.Controls.Add(Me.Label5)
        Me.gbxInfo.Controls.Add(Me.lblCodCat)
        Me.gbxInfo.Controls.Add(Me.btnGuardar)
        Me.gbxInfo.Controls.Add(Me.btnModificar)
        Me.gbxInfo.Controls.Add(Me.btnCrear)
        Me.gbxInfo.Controls.Add(Me.txtAnticipos)
        Me.gbxInfo.Controls.Add(Me.Label1)
        Me.gbxInfo.Controls.Add(Me.Label4)
        Me.gbxInfo.Controls.Add(Me.txtCodBreve)
        Me.gbxInfo.Controls.Add(Me.txtAcreedores)
        Me.gbxInfo.Controls.Add(Me.Label2)
        Me.gbxInfo.Controls.Add(Me.Label3)
        Me.gbxInfo.Controls.Add(Me.txtDescrip)
        Me.gbxInfo.Location = New System.Drawing.Point(10, 10)
        Me.gbxInfo.Name = "gbxInfo"
        Me.gbxInfo.Size = New System.Drawing.Size(559, 146)
        Me.gbxInfo.TabIndex = 8
        Me.gbxInfo.TabStop = False
        Me.gbxInfo.Text = "Información"
        '
        'btnBuscarClas
        '
        Me.btnBuscarClas.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarClas.BackgroundImage = CType(resources.GetObject("btnBuscarClas.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarClas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarClas.FlatAppearance.BorderSize = 0
        Me.btnBuscarClas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarClas.Location = New System.Drawing.Point(158, 82)
        Me.btnBuscarClas.Name = "btnBuscarClas"
        Me.btnBuscarClas.Size = New System.Drawing.Size(27, 18)
        Me.btnBuscarClas.TabIndex = 14
        Me.btnBuscarClas.Text = "..."
        Me.btnBuscarClas.UseVisualStyleBackColor = False
        '
        'txtClasifica
        '
        Me.txtClasifica.Location = New System.Drawing.Point(93, 80)
        Me.txtClasifica.MaxLength = 50
        Me.txtClasifica.Name = "txtClasifica"
        Me.txtClasifica.Size = New System.Drawing.Size(60, 20)
        Me.txtClasifica.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Clasificación"
        '
        'lblCodCat
        '
        Me.lblCodCat.AutoSize = True
        Me.lblCodCat.Location = New System.Drawing.Point(259, 122)
        Me.lblCodCat.Name = "lblCodCat"
        Me.lblCodCat.Size = New System.Drawing.Size(39, 13)
        Me.lblCodCat.TabIndex = 11
        Me.lblCodCat.Text = "Label5"
        Me.lblCodCat.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(478, 117)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(397, 117)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(316, 117)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 8
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        Me.btnCrear.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtCategorias)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 261)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias de Proveedor"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(228, 22)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 20)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(53, 22)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(169, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Buscar:"
        '
        'dtCategorias
        '
        Me.dtCategorias.AllowUserToAddRows = False
        Me.dtCategorias.AllowUserToDeleteRows = False
        Me.dtCategorias.BackgroundColor = System.Drawing.Color.White
        Me.dtCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCategorias.GridColor = System.Drawing.Color.White
        Me.dtCategorias.Location = New System.Drawing.Point(6, 48)
        Me.dtCategorias.Name = "dtCategorias"
        Me.dtCategorias.ReadOnly = True
        Me.dtCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCategorias.Size = New System.Drawing.Size(544, 207)
        Me.dtCategorias.TabIndex = 0
        '
        'A_CategoriaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 430)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_CategoriaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoria de Proveedor"
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodBreve As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAcreedores As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAnticipos As TextBox
    Friend WithEvents gbxInfo As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCrear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtCategorias As DataGridView
    Friend WithEvents lblCodCat As Label
    Friend WithEvents txtClasifica As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscarClas As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label6 As Label
End Class
