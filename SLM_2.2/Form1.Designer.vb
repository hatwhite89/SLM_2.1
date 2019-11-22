<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnContabilidad = New System.Windows.Forms.Button()
        Me.lblcontabilidad = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbllaboratorio = New System.Windows.Forms.Label()
        Me.btnlaboratorio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContabilidad
        '
        Me.btnContabilidad.BackColor = System.Drawing.Color.Transparent
        Me.btnContabilidad.BackgroundImage = CType(resources.GetObject("btnContabilidad.BackgroundImage"), System.Drawing.Image)
        Me.btnContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContabilidad.FlatAppearance.BorderSize = 0
        Me.btnContabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContabilidad.Location = New System.Drawing.Point(7, 18)
        Me.btnContabilidad.Name = "btnContabilidad"
        Me.btnContabilidad.Size = New System.Drawing.Size(60, 57)
        Me.btnContabilidad.TabIndex = 0
        Me.btnContabilidad.UseVisualStyleBackColor = False
        '
        'lblcontabilidad
        '
        Me.lblcontabilidad.AutoSize = True
        Me.lblcontabilidad.Location = New System.Drawing.Point(6, 76)
        Me.lblcontabilidad.Name = "lblcontabilidad"
        Me.lblcontabilidad.Size = New System.Drawing.Size(65, 13)
        Me.lblcontabilidad.TabIndex = 1
        Me.lblcontabilidad.Text = "Contabilidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(126, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 65)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbllaboratorio)
        Me.GroupBox1.Controls.Add(Me.btnlaboratorio)
        Me.GroupBox1.Controls.Add(Me.btnContabilidad)
        Me.GroupBox1.Controls.Add(Me.lblcontabilidad)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 273)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu de Opciones"
        '
        'lbllaboratorio
        '
        Me.lbllaboratorio.AutoSize = True
        Me.lbllaboratorio.Location = New System.Drawing.Point(78, 76)
        Me.lbllaboratorio.Name = "lbllaboratorio"
        Me.lbllaboratorio.Size = New System.Drawing.Size(60, 13)
        Me.lbllaboratorio.TabIndex = 7
        Me.lbllaboratorio.Text = "Laboratorio"
        '
        'btnlaboratorio
        '
        Me.btnlaboratorio.BackgroundImage = CType(resources.GetObject("btnlaboratorio.BackgroundImage"), System.Drawing.Image)
        Me.btnlaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlaboratorio.FlatAppearance.BorderSize = 0
        Me.btnlaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaboratorio.Location = New System.Drawing.Point(76, 15)
        Me.btnlaboratorio.Name = "btnlaboratorio"
        Me.btnlaboratorio.Size = New System.Drawing.Size(62, 58)
        Me.btnlaboratorio.TabIndex = 6
        Me.btnlaboratorio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(10, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 58)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Item Exámenes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(392, 350)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnContabilidad As Button
    Friend WithEvents lblcontabilidad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbllaboratorio As Label
    Friend WithEvents btnlaboratorio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
