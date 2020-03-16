<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsientos
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
        Me.lblNro = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.dtDetalleAsiento = New System.Windows.Forms.DataGridView()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalDebe = New System.Windows.Forms.TextBox()
        Me.txtTotalHaber = New System.Windows.Forms.TextBox()
        Me.lblCodAsiento = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblForm = New System.Windows.Forms.Label()
        CType(Me.dtDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Location = New System.Drawing.Point(13, 11)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(27, 13)
        Me.lblNro.TabIndex = 1
        Me.lblNro.Text = "Nro."
        '
        'txtNro
        '
        Me.txtNro.Enabled = False
        Me.txtNro.Location = New System.Drawing.Point(53, 8)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(112, 20)
        Me.txtNro.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Trans."
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(249, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(112, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Texto"
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(53, 34)
        Me.txtTexto.MaxLength = 200
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(653, 20)
        Me.txtTexto.TabIndex = 6
        '
        'dtDetalleAsiento
        '
        Me.dtDetalleAsiento.AllowUserToAddRows = False
        Me.dtDetalleAsiento.AllowUserToDeleteRows = False
        Me.dtDetalleAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtDetalleAsiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuenta, Me.Descripcion, Me.Debe, Me.Haber})
        Me.dtDetalleAsiento.Location = New System.Drawing.Point(12, 64)
        Me.dtDetalleAsiento.Name = "dtDetalleAsiento"
        Me.dtDetalleAsiento.Size = New System.Drawing.Size(694, 365)
        Me.dtDetalleAsiento.TabIndex = 7
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 270
        '
        'Debe
        '
        Me.Debe.HeaderText = "Debe"
        Me.Debe.Name = "Debe"
        Me.Debe.ReadOnly = True
        '
        'Haber
        '
        Me.Haber.HeaderText = "Haber"
        Me.Haber.Name = "Haber"
        Me.Haber.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total"
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(424, 436)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalDebe.TabIndex = 13
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(531, 436)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.Size = New System.Drawing.Size(93, 20)
        Me.txtTotalHaber.TabIndex = 14
        '
        'lblCodAsiento
        '
        Me.lblCodAsiento.AutoSize = True
        Me.lblCodAsiento.Location = New System.Drawing.Point(494, 12)
        Me.lblCodAsiento.Name = "lblCodAsiento"
        Me.lblCodAsiento.Size = New System.Drawing.Size(10, 13)
        Me.lblCodAsiento.TabIndex = 15
        Me.lblCodAsiento.Text = "-"
        Me.lblCodAsiento.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Asiento Nro."
        Me.Label4.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(12, 434)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(93, 439)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(27, 13)
        Me.lblForm.TabIndex = 18
        Me.lblForm.Text = "form"
        Me.lblForm.Visible = False
        '
        'frmAsientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 463)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCodAsiento)
        Me.Controls.Add(Me.txtTotalHaber)
        Me.Controls.Add(Me.txtTotalDebe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtDetalleAsiento)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.lblNro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmAsientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asiento"
        CType(Me.dtDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNro As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents dtDetalleAsiento As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalDebe As TextBox
    Friend WithEvents txtTotalHaber As TextBox
    Friend WithEvents lblCodAsiento As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Debe As DataGridViewTextBoxColumn
    Friend WithEvents Haber As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblForm As Label
End Class
