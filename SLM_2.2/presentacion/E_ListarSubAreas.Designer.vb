<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_ListarSubAreas
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
        Me.lblform = New System.Windows.Forms.Label()
        Me.dgbSubAreas = New System.Windows.Forms.DataGridView()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbSubAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.dgbSubAreas)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(612, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SubAreas"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(260, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(51, 17)
        Me.lblform.TabIndex = 1
        Me.lblform.Text = "Label1"
        '
        'dgbSubAreas
        '
        Me.dgbSubAreas.BackgroundColor = System.Drawing.Color.White
        Me.dgbSubAreas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgbSubAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbSubAreas.GridColor = System.Drawing.Color.White
        Me.dgbSubAreas.Location = New System.Drawing.Point(8, 23)
        Me.dgbSubAreas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgbSubAreas.Name = "dgbSubAreas"
        Me.dgbSubAreas.RowHeadersWidth = 51
        Me.dgbSubAreas.Size = New System.Drawing.Size(596, 256)
        Me.dgbSubAreas.TabIndex = 0
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(528, 306)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(100, 28)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear Nueva"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'E_ListarSubAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(644, 341)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "E_ListarSubAreas"
        Me.Text = "Listado de SubAreas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbSubAreas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgbSubAreas As DataGridView
    Friend WithEvents btnCrear As Button
    Friend WithEvents lblform As Label
End Class
