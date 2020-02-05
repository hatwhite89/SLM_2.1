<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Notificacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Notificacion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMensajeDias = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMensajeFact = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(77, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Notifique al Administrador"
        '
        'lblMensajeDias
        '
        Me.lblMensajeDias.AutoSize = True
        Me.lblMensajeDias.BackColor = System.Drawing.Color.Transparent
        Me.lblMensajeDias.ForeColor = System.Drawing.Color.Black
        Me.lblMensajeDias.Location = New System.Drawing.Point(77, 31)
        Me.lblMensajeDias.Name = "lblMensajeDias"
        Me.lblMensajeDias.Size = New System.Drawing.Size(16, 13)
        Me.lblMensajeDias.TabIndex = 2
        Me.lblMensajeDias.Text = "---"
        Me.lblMensajeDias.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'lblMensajeFact
        '
        Me.lblMensajeFact.AutoSize = True
        Me.lblMensajeFact.BackColor = System.Drawing.Color.Transparent
        Me.lblMensajeFact.ForeColor = System.Drawing.Color.Black
        Me.lblMensajeFact.Location = New System.Drawing.Point(77, 49)
        Me.lblMensajeFact.Name = "lblMensajeFact"
        Me.lblMensajeFact.Size = New System.Drawing.Size(16, 13)
        Me.lblMensajeFact.TabIndex = 3
        Me.lblMensajeFact.Text = "---"
        Me.lblMensajeFact.Visible = False
        '
        'A_Notificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(294, 79)
        Me.Controls.Add(Me.lblMensajeFact)
        Me.Controls.Add(Me.lblMensajeDias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "A_Notificacion"
        Me.Text = "A_Notificacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMensajeDias As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblMensajeFact As Label
End Class
