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
        Me.btnDepoBanc = New System.Windows.Forms.Button()
        Me.tpPagos = New System.Windows.Forms.TabPage()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.TpMantenimiento = New System.Windows.Forms.TabPage()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.tcMenu.SuspendLayout()
        Me.tpCheque.SuspendLayout()
        Me.tpPagos.SuspendLayout()
        Me.TpMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMenu
        '
        Me.tcMenu.Controls.Add(Me.tpCheque)
        Me.tcMenu.Controls.Add(Me.tpPagos)
        Me.tcMenu.Controls.Add(Me.TpMantenimiento)
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
        'btnDepoBanc
        '
        Me.btnDepoBanc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDepoBanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepoBanc.ForeColor = System.Drawing.Color.White
        Me.btnDepoBanc.Location = New System.Drawing.Point(20, 28)
        Me.btnDepoBanc.Name = "btnDepoBanc"
        Me.btnDepoBanc.Size = New System.Drawing.Size(110, 23)
        Me.btnDepoBanc.TabIndex = 0
        Me.btnDepoBanc.Text = "Deposito Bancario"
        Me.btnDepoBanc.UseVisualStyleBackColor = False
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
        'btnPagos
        '
        Me.btnPagos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagos.ForeColor = System.Drawing.Color.White
        Me.btnPagos.Location = New System.Drawing.Point(20, 28)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(110, 23)
        Me.btnPagos.TabIndex = 0
        Me.btnPagos.Text = "Pagos"
        Me.btnPagos.UseVisualStyleBackColor = False
        '
        'TpMantenimiento
        '
        Me.TpMantenimiento.Controls.Add(Me.btnFormaPago)
        Me.TpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.TpMantenimiento.Name = "TpMantenimiento"
        Me.TpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TpMantenimiento.Size = New System.Drawing.Size(282, 317)
        Me.TpMantenimiento.TabIndex = 2
        Me.TpMantenimiento.Text = "Mantenimiento"
        Me.TpMantenimiento.UseVisualStyleBackColor = True
        '
        'btnFormaPago
        '
        Me.btnFormaPago.Location = New System.Drawing.Point(6, 6)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(94, 23)
        Me.btnFormaPago.TabIndex = 0
        Me.btnFormaPago.Text = "Forma de Pago"
        Me.btnFormaPago.UseVisualStyleBackColor = True
        '
        'frmMenuConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 366)
        Me.Controls.Add(Me.tcMenu)
        Me.Name = "frmMenuConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidad"
        Me.tcMenu.ResumeLayout(False)
        Me.tpCheque.ResumeLayout(False)
        Me.tpPagos.ResumeLayout(False)
        Me.TpMantenimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMenu As TabControl
    Friend WithEvents tpCheque As TabPage
    Friend WithEvents btnDepoBanc As Button
    Friend WithEvents tpPagos As TabPage
    Friend WithEvents btnPagos As Button
    Friend WithEvents TpMantenimiento As TabPage
    Friend WithEvents btnFormaPago As Button
End Class
