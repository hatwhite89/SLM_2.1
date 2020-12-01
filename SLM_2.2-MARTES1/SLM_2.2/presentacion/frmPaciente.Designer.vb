<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaciente
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPrimer_nombre = New System.Windows.Forms.TextBox()
        Me.txtSegundo_nombre = New System.Windows.Forms.TextBox()
        Me.txtPrimer_apellido = New System.Windows.Forms.TextBox()
        Me.txtSegundo_apellido = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(311, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPrimer_nombre
        '
        Me.txtPrimer_nombre.Location = New System.Drawing.Point(286, 36)
        Me.txtPrimer_nombre.Name = "txtPrimer_nombre"
        Me.txtPrimer_nombre.Size = New System.Drawing.Size(100, 22)
        Me.txtPrimer_nombre.TabIndex = 1
        '
        'txtSegundo_nombre
        '
        Me.txtSegundo_nombre.Location = New System.Drawing.Point(286, 85)
        Me.txtSegundo_nombre.Name = "txtSegundo_nombre"
        Me.txtSegundo_nombre.Size = New System.Drawing.Size(100, 22)
        Me.txtSegundo_nombre.TabIndex = 2
        '
        'txtPrimer_apellido
        '
        Me.txtPrimer_apellido.Location = New System.Drawing.Point(286, 133)
        Me.txtPrimer_apellido.Name = "txtPrimer_apellido"
        Me.txtPrimer_apellido.Size = New System.Drawing.Size(100, 22)
        Me.txtPrimer_apellido.TabIndex = 3
        '
        'txtSegundo_apellido
        '
        Me.txtSegundo_apellido.Location = New System.Drawing.Point(286, 170)
        Me.txtSegundo_apellido.Name = "txtSegundo_apellido"
        Me.txtSegundo_apellido.Size = New System.Drawing.Size(100, 22)
        Me.txtSegundo_apellido.TabIndex = 4
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSegundo_apellido)
        Me.Controls.Add(Me.txtPrimer_apellido)
        Me.Controls.Add(Me.txtSegundo_nombre)
        Me.Controls.Add(Me.txtPrimer_nombre)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmPaciente"
        Me.Text = "frmPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtPrimer_nombre As TextBox
    Friend WithEvents txtSegundo_nombre As TextBox
    Friend WithEvents txtPrimer_apellido As TextBox
    Friend WithEvents txtSegundo_apellido As TextBox
End Class
