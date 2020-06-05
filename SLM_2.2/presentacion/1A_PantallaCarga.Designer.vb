<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _1A_PantallaCarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_1A_PantallaCarga))
        Me.pBarInicio = New System.Windows.Forms.ProgressBar()
        Me.lblCarga = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pBarInicio
        '
        Me.pBarInicio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pBarInicio.Location = New System.Drawing.Point(13, 348)
        Me.pBarInicio.Name = "pBarInicio"
        Me.pBarInicio.Size = New System.Drawing.Size(642, 23)
        Me.pBarInicio.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pBarInicio.TabIndex = 0
        '
        'lblCarga
        '
        Me.lblCarga.AutoSize = True
        Me.lblCarga.BackColor = System.Drawing.Color.Transparent
        Me.lblCarga.Location = New System.Drawing.Point(12, 332)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(207, 13)
        Me.lblCarga.TabIndex = 1
        Me.lblCarga.Text = "Cargando Sistema...Permisos de Usuario..."
        '
        '_1A_PantallaCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 382)
        Me.Controls.Add(Me.lblCarga)
        Me.Controls.Add(Me.pBarInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "_1A_PantallaCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_1A_PantallaCarga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pBarInicio As ProgressBar
    Friend WithEvents lblCarga As Label
End Class
