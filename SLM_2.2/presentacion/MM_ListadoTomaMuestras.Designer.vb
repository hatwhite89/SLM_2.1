<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MM_ListadoTomaMuestras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.txtDescripcionB = New System.Windows.Forms.TextBox()
        Me.txtCodMuestraB = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.btnnueva)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.dgbtabla)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionB)
        Me.GroupBox1.Controls.Add(Me.txtCodMuestraB)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(928, 614)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda Toma de Muestras"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(308, 33)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion.TabIndex = 123
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(17, 33)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(52, 17)
        Me.lblNumero.TabIndex = 122
        Me.lblNumero.Text = "Código"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(295, 587)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 117
        Me.lblcantidad.Text = "000"
        '
        'btnnueva
        '
        Me.btnnueva.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.Color.White
        Me.btnnueva.Location = New System.Drawing.Point(703, 24)
        Me.btnnueva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(219, 34)
        Me.btnnueva.TabIndex = 121
        Me.btnnueva.Text = "Nueva Toma Muestra"
        Me.btnnueva.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 587)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(141, 17)
        Me.lbltotal.TabIndex = 116
        Me.lbltotal.Text = "TOTAL DE RECIBOS"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 70)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(917, 498)
        Me.dgbtabla.TabIndex = 2
        '
        'txtDescripcionB
        '
        Me.txtDescripcionB.Location = New System.Drawing.Point(392, 31)
        Me.txtDescripcionB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionB.Name = "txtDescripcionB"
        Me.txtDescripcionB.Size = New System.Drawing.Size(295, 22)
        Me.txtDescripcionB.TabIndex = 1
        '
        'txtCodMuestraB
        '
        Me.txtCodMuestraB.Location = New System.Drawing.Point(83, 31)
        Me.txtCodMuestraB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodMuestraB.Name = "txtCodMuestraB"
        Me.txtCodMuestraB.Size = New System.Drawing.Size(192, 22)
        Me.txtCodMuestraB.TabIndex = 0
        '
        'MM_ListadoTomaMuestras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 657)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "MM_ListadoTomaMuestras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Toma de Muestras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents btnnueva As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtDescripcionB As TextBox
    Friend WithEvents txtCodMuestraB As TextBox
End Class
