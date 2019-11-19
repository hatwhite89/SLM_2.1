<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoDeposito))
        Me.btnTarjeta = New System.Windows.Forms.Button()
        Me.btnDeposito = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTarjeta
        '
        Me.btnTarjeta.BackColor = System.Drawing.Color.Transparent
        Me.btnTarjeta.BackgroundImage = CType(resources.GetObject("btnTarjeta.BackgroundImage"), System.Drawing.Image)
        Me.btnTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTarjeta.FlatAppearance.BorderSize = 0
        Me.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarjeta.Location = New System.Drawing.Point(9, 13)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(101, 101)
        Me.btnTarjeta.TabIndex = 0
        Me.btnTarjeta.UseVisualStyleBackColor = False
        '
        'btnDeposito
        '
        Me.btnDeposito.BackColor = System.Drawing.Color.Transparent
        Me.btnDeposito.BackgroundImage = CType(resources.GetObject("btnDeposito.BackgroundImage"), System.Drawing.Image)
        Me.btnDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeposito.FlatAppearance.BorderSize = 0
        Me.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposito.Location = New System.Drawing.Point(124, 4)
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.Size = New System.Drawing.Size(115, 118)
        Me.btnDeposito.TabIndex = 1
        Me.btnDeposito.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tarjetas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Depositos Bancarios"
        '
        'frmTipoDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(243, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeposito)
        Me.Controls.Add(Me.btnTarjeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmTipoDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione el tipo de Deposito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTarjeta As Button
    Friend WithEvents btnDeposito As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
