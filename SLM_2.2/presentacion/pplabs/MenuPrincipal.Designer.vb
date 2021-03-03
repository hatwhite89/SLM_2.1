<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UI_ButtonMaterial1 = New UIDC.UI_ButtonMaterial()
        Me.UI_ButtonMaterial2 = New UIDC.UI_ButtonMaterial()
        Me.UI_ButtonMaterial3 = New UIDC.UI_ButtonMaterial()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(286, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UI_ButtonMaterial1
        '
        Me.UI_ButtonMaterial1.BGColor = "#508ef5"
        Me.UI_ButtonMaterial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial1.Location = New System.Drawing.Point(61, 209)
        Me.UI_ButtonMaterial1.Name = "UI_ButtonMaterial1"
        Me.UI_ButtonMaterial1.Size = New System.Drawing.Size(175, 41)
        Me.UI_ButtonMaterial1.TabIndex = 1
        Me.UI_ButtonMaterial1.Text = "Citología"
        Me.UI_ButtonMaterial1.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial1.UIFontColor = "#ffffff"
        Me.UI_ButtonMaterial1.UseVisualStyleBackColor = True
        '
        'UI_ButtonMaterial2
        '
        Me.UI_ButtonMaterial2.BGColor = "#508ef5"
        Me.UI_ButtonMaterial2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial2.Location = New System.Drawing.Point(61, 256)
        Me.UI_ButtonMaterial2.Name = "UI_ButtonMaterial2"
        Me.UI_ButtonMaterial2.Size = New System.Drawing.Size(175, 41)
        Me.UI_ButtonMaterial2.TabIndex = 2
        Me.UI_ButtonMaterial2.Text = "Histopatología"
        Me.UI_ButtonMaterial2.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial2.UIFontColor = "#ffffff"
        Me.UI_ButtonMaterial2.UseVisualStyleBackColor = True
        '
        'UI_ButtonMaterial3
        '
        Me.UI_ButtonMaterial3.BGColor = "#EC6464"
        Me.UI_ButtonMaterial3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial3.Location = New System.Drawing.Point(61, 303)
        Me.UI_ButtonMaterial3.Name = "UI_ButtonMaterial3"
        Me.UI_ButtonMaterial3.Size = New System.Drawing.Size(175, 41)
        Me.UI_ButtonMaterial3.TabIndex = 3
        Me.UI_ButtonMaterial3.Text = "Cerrar"
        Me.UI_ButtonMaterial3.UIFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UI_ButtonMaterial3.UIFontColor = "#ffffff"
        Me.UI_ButtonMaterial3.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 363)
        Me.Controls.Add(Me.UI_ButtonMaterial3)
        Me.Controls.Add(Me.UI_ButtonMaterial2)
        Me.Controls.Add(Me.UI_ButtonMaterial1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menú Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UI_ButtonMaterial1 As UIDC.UI_ButtonMaterial
    Friend WithEvents UI_ButtonMaterial2 As UIDC.UI_ButtonMaterial
    Friend WithEvents UI_ButtonMaterial3 As UIDC.UI_ButtonMaterial
End Class
