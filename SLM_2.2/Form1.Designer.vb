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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbllaboratorio = New System.Windows.Forms.Label()
        Me.btnlaboratorio = New System.Windows.Forms.Button()
        Me.btnFacturacion = New System.Windows.Forms.Button()
        Me.lblfacturacion = New System.Windows.Forms.Label()
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
        Me.btnContabilidad.Location = New System.Drawing.Point(9, 22)
        Me.btnContabilidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnContabilidad.Name = "btnContabilidad"
        Me.btnContabilidad.Size = New System.Drawing.Size(80, 70)
        Me.btnContabilidad.TabIndex = 0
        Me.btnContabilidad.UseVisualStyleBackColor = False
        '
        'lblcontabilidad
        '
        Me.lblcontabilidad.AutoSize = True
        Me.lblcontabilidad.Location = New System.Drawing.Point(8, 94)
        Me.lblcontabilidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontabilidad.Name = "lblcontabilidad"
        Me.lblcontabilidad.Size = New System.Drawing.Size(86, 17)
        Me.lblcontabilidad.TabIndex = 1
        Me.lblcontabilidad.Text = "Contabilidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(168, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 80)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFacturacion)
        Me.GroupBox1.Controls.Add(Me.lblfacturacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbllaboratorio)
        Me.GroupBox1.Controls.Add(Me.btnlaboratorio)
        Me.GroupBox1.Controls.Add(Me.btnContabilidad)
        Me.GroupBox1.Controls.Add(Me.lblcontabilidad)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 336)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu de Opciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 213)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Item Exámenes"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(13, 138)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 71)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbllaboratorio
        '
        Me.lbllaboratorio.AutoSize = True
        Me.lbllaboratorio.Location = New System.Drawing.Point(104, 94)
        Me.lbllaboratorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbllaboratorio.Name = "lbllaboratorio"
        Me.lbllaboratorio.Size = New System.Drawing.Size(81, 17)
        Me.lbllaboratorio.TabIndex = 7
        Me.lbllaboratorio.Text = "Laboratorio"
        '
        'btnlaboratorio
        '
        Me.btnlaboratorio.BackgroundImage = CType(resources.GetObject("btnlaboratorio.BackgroundImage"), System.Drawing.Image)
        Me.btnlaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlaboratorio.FlatAppearance.BorderSize = 0
        Me.btnlaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaboratorio.Location = New System.Drawing.Point(101, 18)
        Me.btnlaboratorio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlaboratorio.Name = "btnlaboratorio"
        Me.btnlaboratorio.Size = New System.Drawing.Size(83, 71)
        Me.btnlaboratorio.TabIndex = 6
        Me.btnlaboratorio.UseVisualStyleBackColor = True
        '
        'btnFacturacion
        '
        Me.btnFacturacion.BackColor = System.Drawing.Color.Transparent
        Me.btnFacturacion.BackgroundImage = CType(resources.GetObject("btnFacturacion.BackgroundImage"), System.Drawing.Image)
        Me.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFacturacion.FlatAppearance.BorderSize = 0
        Me.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturacion.Location = New System.Drawing.Point(192, 23)
        Me.btnFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Size = New System.Drawing.Size(80, 70)
        Me.btnFacturacion.TabIndex = 10
        Me.btnFacturacion.UseVisualStyleBackColor = False
        '
        'lblfacturacion
        '
        Me.lblfacturacion.AutoSize = True
        Me.lblfacturacion.Location = New System.Drawing.Point(193, 94)
        Me.lblfacturacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfacturacion.Name = "lblfacturacion"
        Me.lblfacturacion.Size = New System.Drawing.Size(82, 17)
        Me.lblfacturacion.TabIndex = 11
        Me.lblfacturacion.Text = "Facturación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(523, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents btnFacturacion As Button
    Friend WithEvents lblfacturacion As Label
End Class
