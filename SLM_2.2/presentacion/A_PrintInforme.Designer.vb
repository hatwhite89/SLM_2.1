<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_PrintInforme
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
        Me.crvInformeOrdenesTrabajo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvInformeOrdenesTrabajo
        '
        Me.crvInformeOrdenesTrabajo.ActiveViewIndex = -1
        Me.crvInformeOrdenesTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInformeOrdenesTrabajo.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInformeOrdenesTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvInformeOrdenesTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.crvInformeOrdenesTrabajo.Name = "crvInformeOrdenesTrabajo"
        Me.crvInformeOrdenesTrabajo.Size = New System.Drawing.Size(885, 544)
        Me.crvInformeOrdenesTrabajo.TabIndex = 0
        Me.crvInformeOrdenesTrabajo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'A_PrintInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 544)
        Me.Controls.Add(Me.crvInformeOrdenesTrabajo)
        Me.Name = "A_PrintInforme"
        Me.Text = "Informe de Ordenes de Trabajo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvInformeOrdenesTrabajo As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
