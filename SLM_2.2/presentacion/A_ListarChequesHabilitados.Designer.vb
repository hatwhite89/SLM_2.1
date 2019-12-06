<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarChequesHabilitados
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
        Me.gbxCheque = New System.Windows.Forms.GroupBox()
        Me.dtCheques = New System.Windows.Forms.DataGridView()
        Me.gbxCheque.SuspendLayout()
        CType(Me.dtCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCheque
        '
        Me.gbxCheque.Controls.Add(Me.dtCheques)
        Me.gbxCheque.Location = New System.Drawing.Point(12, 12)
        Me.gbxCheque.Name = "gbxCheque"
        Me.gbxCheque.Size = New System.Drawing.Size(520, 266)
        Me.gbxCheque.TabIndex = 0
        Me.gbxCheque.TabStop = False
        Me.gbxCheque.Text = "Seleccione un Cheque"
        '
        'dtCheques
        '
        Me.dtCheques.BackgroundColor = System.Drawing.Color.White
        Me.dtCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCheques.GridColor = System.Drawing.Color.White
        Me.dtCheques.Location = New System.Drawing.Point(6, 19)
        Me.dtCheques.Name = "dtCheques"
        Me.dtCheques.Size = New System.Drawing.Size(508, 241)
        Me.dtCheques.TabIndex = 0
        '
        'A_ListarChequesHabilitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 290)
        Me.Controls.Add(Me.gbxCheque)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "A_ListarChequesHabilitados"
        Me.Text = "Cheques Disponibles"
        Me.gbxCheque.ResumeLayout(False)
        CType(Me.dtCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCheque As GroupBox
    Friend WithEvents dtCheques As DataGridView
End Class
