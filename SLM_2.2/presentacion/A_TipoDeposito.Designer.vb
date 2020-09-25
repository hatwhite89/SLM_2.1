<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTipoDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoDeposito))
        Me.btnTarjeta = New System.Windows.Forms.Button()
        Me.btnDeposito = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTarjeta
        '
        Me.btnTarjeta.BackColor = System.Drawing.Color.White
        Me.btnTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTarjeta.FlatAppearance.BorderSize = 0
        Me.btnTarjeta.Location = New System.Drawing.Point(8, 111)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(112, 23)
        Me.btnTarjeta.TabIndex = 0
        Me.btnTarjeta.Text = "Tarjeta"
        Me.btnTarjeta.UseVisualStyleBackColor = False
        '
        'btnDeposito
        '
        Me.btnDeposito.BackColor = System.Drawing.Color.White
        Me.btnDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeposito.FlatAppearance.BorderSize = 0
        Me.btnDeposito.Location = New System.Drawing.Point(126, 111)
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.Size = New System.Drawing.Size(112, 23)
        Me.btnDeposito.TabIndex = 1
        Me.btnDeposito.Text = "Deposito Bancario"
        Me.btnDeposito.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(131, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 93)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'frmTipoDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(243, 143)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDeposito)
        Me.Controls.Add(Me.btnTarjeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmTipoDeposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione el tipo de Deposito"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTarjeta As Button
    Friend WithEvents btnDeposito As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
