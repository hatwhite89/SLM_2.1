<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_ImportarUserAD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ImportarUserAD))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtUsuariosAD = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCargar = New UIDC.UI_ButtonMaterial()
        Me.btnImportar = New UIDC.UI_ButtonMaterial()
        Me.btnCerrar = New UIDC.UI_ButtonMaterial()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtUsuariosAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtUsuariosAD)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(704, 424)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Usuarios de AD"
        '
        'dtUsuariosAD
        '
        Me.dtUsuariosAD.AllowUserToAddRows = False
        Me.dtUsuariosAD.AllowUserToDeleteRows = False
        Me.dtUsuariosAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtUsuariosAD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4})
        Me.dtUsuariosAD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtUsuariosAD.Location = New System.Drawing.Point(3, 16)
        Me.dtUsuariosAD.Name = "dtUsuariosAD"
        Me.dtUsuariosAD.ReadOnly = True
        Me.dtUsuariosAD.Size = New System.Drawing.Size(698, 405)
        Me.dtUsuariosAD.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Agregar"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 65.65144!
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.FillWeight = 65.65144!
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.FillWeight = 65.65144!
        Me.Column4.HeaderText = "Username"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargar.BGColor = "#3cc2e7"
        Me.btnCargar.Location = New System.Drawing.Point(354, 19)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(114, 41)
        Me.btnCargar.TabIndex = 9
        Me.btnCargar.Text = "Cargar Usuarios"
        Me.btnCargar.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.UIFontColor = "#ffffff"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnImportar
        '
        Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportar.BGColor = "#3cc2e7"
        Me.btnImportar.Enabled = False
        Me.btnImportar.Location = New System.Drawing.Point(469, 19)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(114, 41)
        Me.btnImportar.TabIndex = 10
        Me.btnImportar.Text = "Importar Usuarios"
        Me.btnImportar.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.UIFontColor = "#ffffff"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BGColor = "#E59090"
        Me.btnCerrar.Location = New System.Drawing.Point(584, 19)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(114, 41)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.UIFontColor = "#ffffff"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCerrar)
        Me.GroupBox1.Controls.Add(Me.btnCargar)
        Me.GroupBox1.Controls.Add(Me.btnImportar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 73)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Importar Usuarios AD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(246, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'A_ImportarUserAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(729, 533)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "A_ImportarUserAD"
        Me.Text = "Importar Usuarios de AD"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtUsuariosAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtUsuariosAD As DataGridView
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrar As UIDC.UI_ButtonMaterial
    Friend WithEvents btnImportar As UIDC.UI_ButtonMaterial
    Friend WithEvents btnCargar As UIDC.UI_ButtonMaterial
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
