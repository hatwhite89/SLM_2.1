<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_ListarTipoClasificacion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtTipoClasific = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtTipoClasific, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtTipoClasific)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un tipo"
        '
        'dtTipoClasific
        '
        Me.dtTipoClasific.AllowUserToAddRows = False
        Me.dtTipoClasific.AllowUserToDeleteRows = False
        Me.dtTipoClasific.AllowUserToResizeColumns = False
        Me.dtTipoClasific.AllowUserToResizeRows = False
        Me.dtTipoClasific.BackgroundColor = System.Drawing.Color.White
        Me.dtTipoClasific.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTipoClasific.GridColor = System.Drawing.Color.White
        Me.dtTipoClasific.Location = New System.Drawing.Point(6, 19)
        Me.dtTipoClasific.Name = "dtTipoClasific"
        Me.dtTipoClasific.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtTipoClasific.Size = New System.Drawing.Size(682, 280)
        Me.dtTipoClasific.TabIndex = 0
        '
        'A_ListarTipoClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 329)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "A_ListarTipoClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Clasificacion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtTipoClasific, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtTipoClasific As DataGridView
End Class
