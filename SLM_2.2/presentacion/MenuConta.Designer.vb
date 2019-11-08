<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuConta
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
        Me.tcMenu = New System.Windows.Forms.TabControl()
        Me.tpCheque = New System.Windows.Forms.TabPage()
        Me.tpPagos = New System.Windows.Forms.TabPage()
        Me.btnDepoBanc = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.tcMenu.SuspendLayout()
        Me.tpCheque.SuspendLayout()
        Me.tpPagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMenu
        '
        Me.tcMenu.Controls.Add(Me.tpCheque)
        Me.tcMenu.Controls.Add(Me.tpPagos)
        Me.tcMenu.Location = New System.Drawing.Point(12, 12)
        Me.tcMenu.Name = "tcMenu"
        Me.tcMenu.SelectedIndex = 0
        Me.tcMenu.Size = New System.Drawing.Size(290, 343)
        Me.tcMenu.TabIndex = 0
        '
        'tpCheque
        '
        Me.tpCheque.Controls.Add(Me.btnDepoBanc)
        Me.tpCheque.Location = New System.Drawing.Point(4, 22)
        Me.tpCheque.Name = "tpCheque"
        Me.tpCheque.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCheque.Size = New System.Drawing.Size(282, 317)
        Me.tpCheque.TabIndex = 0
        Me.tpCheque.Text = "Cheque"
        Me.tpCheque.UseVisualStyleBackColor = True
        '
        'tpPagos
        '
        Me.tpPagos.Controls.Add(Me.btnPagos)
        Me.tpPagos.Location = New System.Drawing.Point(4, 22)
        Me.tpPagos.Name = "tpPagos"
        Me.tpPagos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPagos.Size = New System.Drawing.Size(282, 317)
        Me.tpPagos.TabIndex = 1
        Me.tpPagos.Text = "Pagos"
        Me.tpPagos.UseVisualStyleBackColor = True
        '
        'btnDepoBanc
        '
        Me.btnDepoBanc.Location = New System.Drawing.Point(6, 6)
        Me.btnDepoBanc.Name = "btnDepoBanc"
        Me.btnDepoBanc.Size = New System.Drawing.Size(114, 23)
        Me.btnDepoBanc.TabIndex = 0
        Me.btnDepoBanc.Text = "Deposito Bancario"
        Me.btnDepoBanc.UseVisualStyleBackColor = True
        '
        'btnPagos
        '
        Me.btnPagos.Location = New System.Drawing.Point(6, 6)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(75, 23)
        Me.btnPagos.TabIndex = 0
        Me.btnPagos.Text = "Pagos"
        Me.btnPagos.UseVisualStyleBackColor = True
        '
        'frmMenuConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 366)
        Me.Controls.Add(Me.tcMenu)
        Me.Name = "frmMenuConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidad"
        Me.tcMenu.ResumeLayout(False)
        Me.tpCheque.ResumeLayout(False)
        Me.tpPagos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMenu As TabControl
    Friend WithEvents tpCheque As TabPage
    Friend WithEvents btnDepoBanc As Button
    Friend WithEvents tpPagos As TabPage
    Friend WithEvents btnPagos As Button
End Class
