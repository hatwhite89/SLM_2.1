<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarCuentas_Chequera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListarCuentas_Chequera))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCuentaBusqueda = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dtCuentas = New System.Windows.Forms.DataGridView()
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta"
        '
        'txtCuentaBusqueda
        '
        Me.txtCuentaBusqueda.Location = New System.Drawing.Point(56, 23)
        Me.txtCuentaBusqueda.Name = "txtCuentaBusqueda"
        Me.txtCuentaBusqueda.Size = New System.Drawing.Size(330, 20)
        Me.txtCuentaBusqueda.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(392, 23)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(22, 20)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dtCuentas
        '
        Me.dtCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtCuentas.BackgroundColor = System.Drawing.Color.White
        Me.dtCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCuentas.GridColor = System.Drawing.Color.White
        Me.dtCuentas.Location = New System.Drawing.Point(12, 49)
        Me.dtCuentas.Name = "dtCuentas"
        Me.dtCuentas.RowHeadersVisible = False
        Me.dtCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCuentas.Size = New System.Drawing.Size(694, 389)
        Me.dtCuentas.TabIndex = 3
        '
        'A_ListarCuentas_Chequera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtCuentas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtCuentaBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "A_ListarCuentas_Chequera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione una Cuenta"
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCuentaBusqueda As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtCuentas As DataGridView
End Class
