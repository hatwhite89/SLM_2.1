<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarExamenes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dtExamenes = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblform = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.dtExamenes)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione los exámenes"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(559, 18)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(133, 23)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar Selección"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dtExamenes
        '
        Me.dtExamenes.AllowUserToAddRows = False
        Me.dtExamenes.AllowUserToDeleteRows = False
        Me.dtExamenes.BackgroundColor = System.Drawing.Color.White
        Me.dtExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.dtExamenes.Location = New System.Drawing.Point(4, 47)
        Me.dtExamenes.Name = "dtExamenes"
        Me.dtExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtExamenes.Size = New System.Drawing.Size(688, 252)
        Me.dtExamenes.TabIndex = 0
        '
        'chk
        '
        Me.chk.HeaderText = "Agregar"
        Me.chk.Name = "chk"
        Me.chk.Width = 50
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(222, 18)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(37, 13)
        Me.lblform.TabIndex = 4
        Me.lblform.Text = "lblform"
        '
        'A_ListarExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 326)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "A_ListarExamenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Examenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtExamenes As DataGridView
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblform As Label
End Class
