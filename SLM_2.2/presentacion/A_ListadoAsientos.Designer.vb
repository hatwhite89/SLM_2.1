<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoAsientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListadoAsientos))
        Me.gbxAsientos = New System.Windows.Forms.GroupBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.dtAsientos = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxAsientos.SuspendLayout()
        CType(Me.dtAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxAsientos
        '
        Me.gbxAsientos.Controls.Add(Me.btnCancelar)
        Me.gbxAsientos.Controls.Add(Me.dtAsientos)
        Me.gbxAsientos.Controls.Add(Me.txtCod)
        Me.gbxAsientos.Controls.Add(Me.lblCod)
        Me.gbxAsientos.Location = New System.Drawing.Point(12, 12)
        Me.gbxAsientos.Name = "gbxAsientos"
        Me.gbxAsientos.Size = New System.Drawing.Size(476, 322)
        Me.gbxAsientos.TabIndex = 0
        Me.gbxAsientos.TabStop = False
        Me.gbxAsientos.Text = "Asientos Contables"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(248, 25)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(65, 13)
        Me.lblCod.TabIndex = 0
        Me.lblCod.Text = "Nro. Asiento"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(319, 22)
        Me.txtCod.MaxLength = 8
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(120, 20)
        Me.txtCod.TabIndex = 1
        '
        'dtAsientos
        '
        Me.dtAsientos.AllowUserToAddRows = False
        Me.dtAsientos.BackgroundColor = System.Drawing.Color.White
        Me.dtAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtAsientos.GridColor = System.Drawing.Color.White
        Me.dtAsientos.Location = New System.Drawing.Point(6, 57)
        Me.dtAsientos.Name = "dtAsientos"
        Me.dtAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtAsientos.Size = New System.Drawing.Size(464, 259)
        Me.dtAsientos.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(445, 22)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(20, 18)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'A_ListadoAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 342)
        Me.Controls.Add(Me.gbxAsientos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "A_ListadoAsientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Asientos"
        Me.gbxAsientos.ResumeLayout(False)
        Me.gbxAsientos.PerformLayout()
        CType(Me.dtAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxAsientos As GroupBox
    Friend WithEvents dtAsientos As DataGridView
    Friend WithEvents txtCod As TextBox
    Friend WithEvents lblCod As Label
    Friend WithEvents btnCancelar As Button
End Class
