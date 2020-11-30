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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_BuscarFormaPago))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFormasPago = New System.Windows.Forms.DataGridView()
        Me.lblJC = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
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
        Me.dtFormasPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dtFormasPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dtFormasPago.BackgroundColor = System.Drawing.Color.White
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
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_BuscarFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 362)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblJC)
        Me.Controls.Add(Me.dtFormasPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
