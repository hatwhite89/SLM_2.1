<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoCheques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListadoCheques))
        Me.gbxCheque = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtCheques = New System.Windows.Forms.DataGridView()
        Me.ttBusqueda = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxCheque.SuspendLayout()
        CType(Me.dtCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCheque
        '
        Me.gbxCheque.Controls.Add(Me.btnCancelar)
        Me.gbxCheque.Controls.Add(Me.txtBusqueda)
        Me.gbxCheque.Controls.Add(Me.Label1)
        Me.gbxCheque.Controls.Add(Me.dtCheques)
        Me.gbxCheque.Location = New System.Drawing.Point(9, 12)
        Me.gbxCheque.Name = "gbxCheque"
        Me.gbxCheque.Size = New System.Drawing.Size(697, 334)
        Me.gbxCheque.TabIndex = 0
        Me.gbxCheque.TabStop = False
        Me.gbxCheque.Text = "Cheques Generados"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(293, 24)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(20, 18)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(52, 23)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(236, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar: "
        '
        'dtCheques
        '
        Me.dtCheques.BackgroundColor = System.Drawing.Color.White
        Me.dtCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCheques.GridColor = System.Drawing.Color.White
        Me.dtCheques.Location = New System.Drawing.Point(3, 52)
        Me.dtCheques.Name = "dtCheques"
        Me.dtCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCheques.Size = New System.Drawing.Size(688, 277)
        Me.dtCheques.TabIndex = 0
        '
        'A_ListadoCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 349)
        Me.Controls.Add(Me.gbxCheque)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_ListadoCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Cheques"
        Me.gbxCheque.ResumeLayout(False)
        Me.gbxCheque.PerformLayout()
        CType(Me.dtCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxCheque As GroupBox
    Friend WithEvents dtCheques As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ttBusqueda As ToolTip
End Class
