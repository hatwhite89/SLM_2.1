<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarCAI
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
        Me.gbxRegistros = New System.Windows.Forms.GroupBox()
        Me.dtCAIS = New System.Windows.Forms.DataGridView()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbxRegistros.SuspendLayout()
        CType(Me.dtCAIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRegistros
        '
        Me.gbxRegistros.Controls.Add(Me.dtCAIS)
        Me.gbxRegistros.Location = New System.Drawing.Point(12, 12)
        Me.gbxRegistros.Name = "gbxRegistros"
        Me.gbxRegistros.Size = New System.Drawing.Size(515, 397)
        Me.gbxRegistros.TabIndex = 0
        Me.gbxRegistros.TabStop = False
        Me.gbxRegistros.Text = "Registros"
        '
        'dtCAIS
        '
        Me.dtCAIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCAIS.Location = New System.Drawing.Point(6, 19)
        Me.dtCAIS.Name = "dtCAIS"
        Me.dtCAIS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCAIS.Size = New System.Drawing.Size(503, 372)
        Me.dtCAIS.TabIndex = 0
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(366, 415)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(452, 415)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'A_ListarCAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 446)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.gbxRegistros)
        Me.Name = "A_ListarCAI"
        Me.Text = "Registros"
        Me.gbxRegistros.ResumeLayout(False)
        CType(Me.dtCAIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxRegistros As GroupBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dtCAIS As DataGridView
End Class
