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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuConta))
        Me.tcMenu = New System.Windows.Forms.TabControl()
        Me.tpCheque = New System.Windows.Forms.TabPage()
        Me.btnDepoBanc = New System.Windows.Forms.Button()
        Me.tpPagos = New System.Windows.Forms.TabPage()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.TpMantenimiento = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCategoriaProveedor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnDepoBanc.Location = New System.Drawing.Point(6, 6)
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
        Me.btnPagos.Location = New System.Drawing.Point(6, 6)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(110, 23)
        Me.btnPagos.TabIndex = 0
        Me.btnPagos.Text = "Pagos"
        Me.btnPagos.UseVisualStyleBackColor = False
        '
        'TpMantenimiento
        '
        Me.TpMantenimiento.Controls.Add(Me.Label4)
        Me.TpMantenimiento.Controls.Add(Me.btnProveedor)
        Me.TpMantenimiento.Controls.Add(Me.Label3)
        Me.TpMantenimiento.Controls.Add(Me.btnCategoriaProveedor)
        Me.TpMantenimiento.Controls.Add(Me.Label2)
        Me.TpMantenimiento.Controls.Add(Me.btnCuentas)
        Me.TpMantenimiento.Controls.Add(Me.Label1)
        Me.TpMantenimiento.Controls.Add(Me.btnFormaPago)
        Me.TpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.TpMantenimiento.Name = "TpMantenimiento"
        Me.TpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TpMantenimiento.Size = New System.Drawing.Size(282, 317)
        Me.TpMantenimiento.TabIndex = 2
        Me.TpMantenimiento.Text = "Mantenimiento"
        Me.TpMantenimiento.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Proveedor"
        '
        'btnProveedor
        '
        Me.btnProveedor.BackgroundImage = CType(resources.GetObject("btnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Location = New System.Drawing.Point(161, 7)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(41, 38)
        Me.btnProveedor.TabIndex = 6
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria Proveedor"
        '
        'btnCategoriaProveedor
        '
        Me.btnCategoriaProveedor.BackgroundImage = CType(resources.GetObject("btnCategoriaProveedor.BackgroundImage"), System.Drawing.Image)
        Me.btnCategoriaProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoriaProveedor.FlatAppearance.BorderSize = 0
        Me.btnCategoriaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoriaProveedor.Location = New System.Drawing.Point(29, 146)
        Me.btnCategoriaProveedor.Name = "btnCategoriaProveedor"
        Me.btnCategoriaProveedor.Size = New System.Drawing.Size(41, 38)
        Me.btnCategoriaProveedor.TabIndex = 4
        Me.btnCategoriaProveedor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cuentas"
        '
        'btnCuentas
        '
        Me.btnCuentas.BackgroundImage = CType(resources.GetObject("btnCuentas.BackgroundImage"), System.Drawing.Image)
        Me.btnCuentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCuentas.FlatAppearance.BorderSize = 0
        Me.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentas.Location = New System.Drawing.Point(26, 75)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(41, 38)
        Me.btnCuentas.TabIndex = 2
        Me.btnCuentas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Formas de Pago"
        '
        'btnFormaPago
        '
        Me.btnFormaPago.BackgroundImage = CType(resources.GetObject("btnFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFormaPago.FlatAppearance.BorderSize = 0
        Me.btnFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaPago.Location = New System.Drawing.Point(26, 7)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(41, 38)
        Me.btnFormaPago.TabIndex = 0
        Me.btnFormaPago.UseVisualStyleBackColor = True
        '
        'frmMenuConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(312, 366)
        Me.Controls.Add(Me.tcMenu)
        Me.KeyPreview = True
        Me.Name = "frmMenuConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilidad"
        Me.tcMenu.ResumeLayout(False)
        Me.tpCheque.ResumeLayout(False)
        Me.tpPagos.ResumeLayout(False)
        Me.TpMantenimiento.ResumeLayout(False)
        Me.TpMantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMenu As TabControl
    Friend WithEvents tpCheque As TabPage
    Friend WithEvents btnDepoBanc As Button
    Friend WithEvents tpPagos As TabPage
    Friend WithEvents btnPagos As Button
    Friend WithEvents TpMantenimiento As TabPage
    Friend WithEvents btnFormaPago As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCuentas As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCategoriaProveedor As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProveedor As Button
End Class
