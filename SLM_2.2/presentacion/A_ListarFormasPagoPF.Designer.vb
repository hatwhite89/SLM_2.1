<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarFormasPagoPF
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
        Me.dtFormasPago = New System.Windows.Forms.DataGridView()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFormasPago)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 334)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la forma de pago"
        '
        'dtFormasPago
        '
        Me.dtFormasPago.AllowUserToAddRows = False
        Me.dtFormasPago.BackgroundColor = System.Drawing.Color.White
        Me.dtFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFormasPago.GridColor = System.Drawing.Color.White
        Me.dtFormasPago.Location = New System.Drawing.Point(6, 19)
        Me.dtFormasPago.Name = "dtFormasPago"
        Me.dtFormasPago.ReadOnly = True
        Me.dtFormasPago.RowHeadersWidth = 51
        Me.dtFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFormasPago.Size = New System.Drawing.Size(297, 309)
        Me.dtFormasPago.TabIndex = 0
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(206, 7)
        Me.lblForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(0, 13)
        Me.lblForm.TabIndex = 57
        Me.lblForm.Visible = False
        '
        'A_ListarFormasPagoPF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 358)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_ListarFormasPagoPF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formas Pago"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFormasPago As DataGridView
    Friend WithEvents lblForm As Label
End Class
