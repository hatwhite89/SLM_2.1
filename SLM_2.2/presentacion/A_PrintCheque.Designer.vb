<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_PrintCheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_PrintCheque))
        Me.crvImprimirCheque = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvImprimirCheque
        '
        Me.crvImprimirCheque.ActiveViewIndex = -1
        Me.crvImprimirCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvImprimirCheque.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvImprimirCheque.DisplayStatusBar = False
        Me.crvImprimirCheque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvImprimirCheque.Location = New System.Drawing.Point(0, 0)
        Me.crvImprimirCheque.Name = "crvImprimirCheque"
        Me.crvImprimirCheque.ShowLogo = False
        Me.crvImprimirCheque.Size = New System.Drawing.Size(800, 450)
        Me.crvImprimirCheque.TabIndex = 0
        Me.crvImprimirCheque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'A_PrintCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crvImprimirCheque)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_PrintCheque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Cheque"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvImprimirCheque As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
