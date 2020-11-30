<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListarCuentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.dtCuentas = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.lblForm)
        Me.GroupBox1.Controls.Add(Me.dtCuentas)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 342)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Cuenta"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(430, 27)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(30, 13)
        Me.lblForm.TabIndex = 4
        Me.lblForm.Text = "Form"
        Me.lblForm.Visible = False
        '
        'dtCuentas
        '
        Me.dtCuentas.AllowDrop = True
        Me.dtCuentas.AllowUserToOrderColumns = True
        Me.dtCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtCuentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtCuentas.BackgroundColor = System.Drawing.Color.White
        Me.dtCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.cuenta})
        Me.dtCuentas.GridColor = System.Drawing.Color.White
        Me.dtCuentas.Location = New System.Drawing.Point(6, 50)
        Me.dtCuentas.Name = "dtCuentas"
        Me.dtCuentas.ReadOnly = True
        Me.dtCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCuentas.Size = New System.Drawing.Size(682, 286)
        Me.dtCuentas.TabIndex = 3
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE DE CUENTA"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cuenta
        '
        Me.cuenta.DataPropertyName = "cuenta"
        Me.cuenta.HeaderText = "NUMERO DE CUENTA"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(52, 24)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(303, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 47)
        Me.Panel1.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Listado de Cuentas"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 400)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 123
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_ListarCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_ListarCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtCuentas As DataGridView
    Friend WithEvents lblForm As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
