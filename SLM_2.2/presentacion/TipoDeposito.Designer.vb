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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTarjeta
        '
        Me.btnTarjeta.BackColor = System.Drawing.Color.SkyBlue
        Me.btnTarjeta.BackgroundImage = CType(resources.GetObject("btnTarjeta.BackgroundImage"), System.Drawing.Image)
        Me.btnTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTarjeta.FlatAppearance.BorderSize = 0
        Me.btnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTarjeta.Location = New System.Drawing.Point(12, 31)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(115, 118)
        Me.btnTarjeta.TabIndex = 0
        Me.btnTarjeta.UseVisualStyleBackColor = False
        '
        'btnDeposito
        '
        Me.btnDeposito.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDeposito.BackgroundImage = CType(resources.GetObject("btnDeposito.BackgroundImage"), System.Drawing.Image)
        Me.btnDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeposito.FlatAppearance.BorderSize = 0
        Me.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeposito.Location = New System.Drawing.Point(133, 29)
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.Size = New System.Drawing.Size(115, 118)
        Me.btnDeposito.TabIndex = 1
        Me.btnDeposito.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Location = New System.Drawing.Point(238, 1)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(25, 22)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "X"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'frmTipoDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(260, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnDeposito)
        Me.Controls.Add(Me.btnTarjeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTipoDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTarjeta As Button
    Friend WithEvents btnDeposito As Button
    Friend WithEvents btnRegresar As Button
End Class
