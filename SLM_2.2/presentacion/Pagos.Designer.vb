<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNro = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.lblFechaP = New System.Windows.Forms.Label()
        Me.dtpFechaP = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaT = New System.Windows.Forms.Label()
        Me.dtpFechaT = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormaP = New System.Windows.Forms.TextBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCtaBanco = New System.Windows.Forms.Label()
        Me.txtCtaBanco = New System.Windows.Forms.TextBox()
        Me.chxInfo = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodOrden = New System.Windows.Forms.TextBox()
        Me.txtIdioma = New System.Windows.Forms.TextBox()
        Me.lblComentario = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(558, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Location = New System.Drawing.Point(12, 43)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(27, 13)
        Me.lblNro.TabIndex = 1
        Me.lblNro.Text = "Nro."
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(78, 40)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(93, 20)
        Me.txtNro.TabIndex = 2
        '
        'lblFechaP
        '
        Me.lblFechaP.AutoSize = True
        Me.lblFechaP.Location = New System.Drawing.Point(185, 44)
        Me.lblFechaP.Name = "lblFechaP"
        Me.lblFechaP.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaP.TabIndex = 3
        Me.lblFechaP.Text = "Fecha Pago"
        '
        'dtpFechaP
        '
        Me.dtpFechaP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaP.Location = New System.Drawing.Point(256, 41)
        Me.dtpFechaP.Name = "dtpFechaP"
        Me.dtpFechaP.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaP.TabIndex = 4
        '
        'lblFechaT
        '
        Me.lblFechaT.AutoSize = True
        Me.lblFechaT.Location = New System.Drawing.Point(372, 44)
        Me.lblFechaT.Name = "lblFechaT"
        Me.lblFechaT.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaT.TabIndex = 5
        Me.lblFechaT.Text = "Fecha Trans."
        '
        'dtpFechaT
        '
        Me.dtpFechaT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaT.Location = New System.Drawing.Point(448, 41)
        Me.dtpFechaT.Name = "dtpFechaT"
        Me.dtpFechaT.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaT.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Forma Pago"
        '
        'txtFormaP
        '
        Me.txtFormaP.Location = New System.Drawing.Point(78, 64)
        Me.txtFormaP.Name = "txtFormaP"
        Me.txtFormaP.Size = New System.Drawing.Size(52, 20)
        Me.txtFormaP.TabIndex = 8
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(12, 89)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.lblReferencia.TabIndex = 9
        Me.lblReferencia.Text = "Referencia"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 20)
        Me.TextBox1.TabIndex = 10
        '
        'lblCtaBanco
        '
        Me.lblCtaBanco.AutoSize = True
        Me.lblCtaBanco.Location = New System.Drawing.Point(190, 67)
        Me.lblCtaBanco.Name = "lblCtaBanco"
        Me.lblCtaBanco.Size = New System.Drawing.Size(60, 13)
        Me.lblCtaBanco.TabIndex = 11
        Me.lblCtaBanco.Text = "Cta. Banco"
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.Location = New System.Drawing.Point(256, 64)
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(97, 20)
        Me.txtCtaBanco.TabIndex = 12
        '
        'chxInfo
        '
        Me.chxInfo.AutoSize = True
        Me.chxInfo.Location = New System.Drawing.Point(256, 89)
        Me.chxInfo.Name = "chxInfo"
        Me.chxInfo.Size = New System.Drawing.Size(122, 17)
        Me.chxInfo.TabIndex = 13
        Me.chxInfo.Text = "Inf. Prov. en Asiento"
        Me.chxInfo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cod. Orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Idioma"
        '
        'txtCodOrden
        '
        Me.txtCodOrden.Location = New System.Drawing.Point(452, 64)
        Me.txtCodOrden.Name = "txtCodOrden"
        Me.txtCodOrden.Size = New System.Drawing.Size(93, 20)
        Me.txtCodOrden.TabIndex = 16
        '
        'txtIdioma
        '
        Me.txtIdioma.Location = New System.Drawing.Point(452, 87)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(93, 20)
        Me.txtIdioma.TabIndex = 17
        '
        'lblComentario
        '
        Me.lblComentario.AutoSize = True
        Me.lblComentario.Location = New System.Drawing.Point(12, 115)
        Me.lblComentario.Name = "lblComentario"
        Me.lblComentario.Size = New System.Drawing.Size(60, 13)
        Me.lblComentario.TabIndex = 18
        Me.lblComentario.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(78, 112)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(172, 20)
        Me.txtComentario.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 138)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(530, 181)
        Me.DataGridView1.TabIndex = 20
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(558, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.lblComentario)
        Me.Controls.Add(Me.txtIdioma)
        Me.Controls.Add(Me.txtCodOrden)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chxInfo)
        Me.Controls.Add(Me.txtCtaBanco)
        Me.Controls.Add(Me.lblCtaBanco)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.txtFormaP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaT)
        Me.Controls.Add(Me.lblFechaT)
        Me.Controls.Add(Me.dtpFechaP)
        Me.Controls.Add(Me.lblFechaP)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.lblNro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPagos"
        Me.Text = "Pagos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNro As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents lblFechaP As Label
    Friend WithEvents dtpFechaP As DateTimePicker
    Friend WithEvents lblFechaT As Label
    Friend WithEvents dtpFechaT As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFormaP As TextBox
    Friend WithEvents lblReferencia As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCtaBanco As Label
    Friend WithEvents txtCtaBanco As TextBox
    Friend WithEvents chxInfo As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodOrden As TextBox
    Friend WithEvents txtIdioma As TextBox
    Friend WithEvents lblComentario As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
