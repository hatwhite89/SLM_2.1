<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Arqueos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigoMaquina = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCaja2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja"
        '
        'txtcodigoMaquina
        '
        Me.txtcodigoMaquina.Location = New System.Drawing.Point(127, 54)
        Me.txtcodigoMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoMaquina.Name = "txtcodigoMaquina"
        Me.txtcodigoMaquina.Size = New System.Drawing.Size(120, 20)
        Me.txtcodigoMaquina.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(273, 54)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(56, 19)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 106)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCaja2
        '
        Me.txtCaja2.Location = New System.Drawing.Point(127, 106)
        Me.txtCaja2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCaja2.Name = "txtCaja2"
        Me.txtCaja2.Size = New System.Drawing.Size(120, 20)
        Me.txtCaja2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Caja"
        '
        'M_Arqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 291)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCaja2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtcodigoMaquina)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Arqueos"
        Me.Text = "M_Arqueos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodigoMaquina As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCaja2 As TextBox
    Friend WithEvents Label2 As Label
End Class
