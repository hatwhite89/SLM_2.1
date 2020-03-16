<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_BuscarFormaPago
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFormasPago = New System.Windows.Forms.DataGridView()
        Me.lblJC = New System.Windows.Forms.Label()
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(79, 11)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(382, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar ID:"
        '
        'dtFormasPago
        '
        Me.dtFormasPago.AllowUserToAddRows = False
        Me.dtFormasPago.AllowUserToDeleteRows = False
        Me.dtFormasPago.AllowUserToResizeColumns = False
        Me.dtFormasPago.AllowUserToResizeRows = False
        Me.dtFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dtFormasPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dtFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFormasPago.Location = New System.Drawing.Point(12, 37)
        Me.dtFormasPago.MultiSelect = False
        Me.dtFormasPago.Name = "dtFormasPago"
        Me.dtFormasPago.ReadOnly = True
        Me.dtFormasPago.RowHeadersWidth = 51
        Me.dtFormasPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtFormasPago.ShowCellErrors = False
        Me.dtFormasPago.ShowCellToolTips = False
        Me.dtFormasPago.ShowEditingIcon = False
        Me.dtFormasPago.Size = New System.Drawing.Size(694, 286)
        Me.dtFormasPago.TabIndex = 3
        '
        'lblJC
        '
        Me.lblJC.AutoSize = True
        Me.lblJC.Location = New System.Drawing.Point(476, 15)
        Me.lblJC.Name = "lblJC"
        Me.lblJC.Size = New System.Drawing.Size(27, 13)
        Me.lblJC.TabIndex = 4
        Me.lblJC.Text = "form"
        Me.lblJC.Visible = False
        '
        'A_BuscarFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblJC)
        Me.Controls.Add(Me.dtFormasPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_BuscarFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar forma de pago"
        CType(Me.dtFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFormasPago As DataGridView
    Friend WithEvents lblJC As Label
End Class
