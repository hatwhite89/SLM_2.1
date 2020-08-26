<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_DiarioFacturacion
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
        Me.lblForm = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnumeroB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnumeroB = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxMedico = New System.Windows.Forms.ComboBox()
        Me.cbxTerminoPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.lblEsado = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.lblEsado)
        Me.GroupBox1.Controls.Add(Me.cbxTerminoPago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxMedico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.txtnumeroB)
        Me.GroupBox1.Controls.Add(Me.lblnombreB)
        Me.GroupBox1.Controls.Add(Me.lblForm)
        Me.GroupBox1.Controls.Add(Me.txtnombreB)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.lblnumeroB)
        Me.GroupBox1.Controls.Add(Me.dgbtabla)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1346, 738)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Diario de Facturación"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(624, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(50, 17)
        Me.lblForm.TabIndex = 119
        Me.lblForm.Text = "lblform"
        Me.lblForm.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(390, 697)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 118
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(21, 254)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(1303, 426)
        Me.dgbtabla.TabIndex = 116
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(60, 697)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(154, 17)
        Me.lbltotal.TabIndex = 117
        Me.lbltotal.Text = "TOTAL DE FACTURAS"
        '
        'txtnumeroB
        '
        Me.txtnumeroB.Location = New System.Drawing.Point(92, 37)
        Me.txtnumeroB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumeroB.MaxLength = 20
        Me.txtnumeroB.Name = "txtnumeroB"
        Me.txtnumeroB.Size = New System.Drawing.Size(279, 22)
        Me.txtnumeroB.TabIndex = 122
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(397, 40)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 121
        Me.lblnombreB.Text = "Nombre"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(475, 36)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(469, 22)
        Me.txtnombreB.TabIndex = 120
        '
        'lblnumeroB
        '
        Me.lblnumeroB.AutoSize = True
        Me.lblnumeroB.Location = New System.Drawing.Point(31, 40)
        Me.lblnumeroB.Name = "lblnumeroB"
        Me.lblnumeroB.Size = New System.Drawing.Size(58, 17)
        Me.lblnumeroB.TabIndex = 119
        Me.lblnumeroB.Text = "Número"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(986, 39)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 17)
        Me.lblFecha.TabIndex = 123
        Me.lblFecha.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(1049, 35)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpFecha.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Médico"
        '
        'cbxMedico
        '
        Me.cbxMedico.FormattingEnabled = True
        Me.cbxMedico.Location = New System.Drawing.Point(92, 87)
        Me.cbxMedico.Name = "cbxMedico"
        Me.cbxMedico.Size = New System.Drawing.Size(279, 24)
        Me.cbxMedico.TabIndex = 126
        '
        'cbxTerminoPago
        '
        Me.cbxTerminoPago.FormattingEnabled = True
        Me.cbxTerminoPago.Location = New System.Drawing.Point(563, 87)
        Me.cbxTerminoPago.Name = "cbxTerminoPago"
        Me.cbxTerminoPago.Size = New System.Drawing.Size(279, 24)
        Me.cbxTerminoPago.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Término de Pago"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activa", "Anulada"})
        Me.cmbEstado.Location = New System.Drawing.Point(970, 87)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(279, 24)
        Me.cmbEstado.TabIndex = 130
        '
        'lblEsado
        '
        Me.lblEsado.AutoSize = True
        Me.lblEsado.Location = New System.Drawing.Point(909, 94)
        Me.lblEsado.Name = "lblEsado"
        Me.lblEsado.Size = New System.Drawing.Size(52, 17)
        Me.lblEsado.TabIndex = 129
        Me.lblEsado.Text = "Estado"
        '
        'M_DiarioFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1397, 774)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "M_DiarioFacturacion"
        Me.Text = "M_DiarioFacturacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblForm As Label
    Friend WithEvents txtnumeroB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnumeroB As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecha As Label
    Friend WithEvents cbxMedico As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTerminoPago As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents lblEsado As Label
End Class
