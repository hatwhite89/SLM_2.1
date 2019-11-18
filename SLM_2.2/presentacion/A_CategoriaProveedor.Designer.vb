<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_CategoriaProveedor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodBreve = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAcreedores = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAnticipos = New System.Windows.Forms.TextBox()
        Me.gbxInfo = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtCategorias = New System.Windows.Forms.DataGridView()
        Me.lblCodCat = New System.Windows.Forms.Label()
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
        Me.txtCodBreve.Name = "txtCodBreve"
        Me.txtCodBreve.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBreve.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción"
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(289, 27)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(158, 20)
        Me.txtDescrip.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cta. Acreedores"
        '
        'txtAcreedores
        '
        Me.txtAcreedores.Location = New System.Drawing.Point(94, 53)
        Me.txtAcreedores.Name = "txtAcreedores"
        Me.txtAcreedores.Size = New System.Drawing.Size(100, 20)
        Me.txtAcreedores.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cta. Anticipos"
        '
        'txtAnticipos
        '
        Me.txtAnticipos.Location = New System.Drawing.Point(289, 53)
        Me.txtAnticipos.Name = "txtAnticipos"
        Me.txtAnticipos.Size = New System.Drawing.Size(100, 20)
        Me.txtAnticipos.TabIndex = 7
        '
        'gbxInfo
        '
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
        Me.gbxInfo.Size = New System.Drawing.Size(455, 123)
        Me.gbxInfo.TabIndex = 8
        Me.gbxInfo.TabStop = False
        Me.gbxInfo.Text = "Información"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(373, 92)
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
        Me.btnModificar.Location = New System.Drawing.Point(292, 92)
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
        Me.btnCrear.Location = New System.Drawing.Point(211, 92)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 8
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        Me.btnCrear.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtCategorias)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 137)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias de Proveedor"
        '
        'dtCategorias
        '
        Me.dtCategorias.AllowUserToAddRows = False
        Me.dtCategorias.AllowUserToDeleteRows = False
        Me.dtCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCategorias.Location = New System.Drawing.Point(6, 19)
        Me.dtCategorias.Name = "dtCategorias"
        Me.dtCategorias.ReadOnly = True
        Me.dtCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCategorias.Size = New System.Drawing.Size(442, 112)
        Me.dtCategorias.TabIndex = 0
        '
        'lblCodCat
        '
        Me.lblCodCat.AutoSize = True
        Me.lblCodCat.Location = New System.Drawing.Point(154, 97)
        Me.lblCodCat.Name = "lblCodCat"
        Me.lblCodCat.Size = New System.Drawing.Size(39, 13)
        Me.lblCodCat.TabIndex = 11
        Me.lblCodCat.Text = "Label5"
        Me.lblCodCat.Visible = False
        '
        'A_CategoriaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 285)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "A_CategoriaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoria de Proveedor"
        Me.gbxInfo.ResumeLayout(False)
        Me.gbxInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
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
End Class
