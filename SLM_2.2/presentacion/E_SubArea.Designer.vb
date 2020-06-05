<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_SubArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_SubArea))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubArea = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblform = New System.Windows.Forms.Label()
        Me.cmbxCodigoArea = New System.Windows.Forms.ComboBox()
        Me.btnCrearNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkConsolidado = New System.Windows.Forms.CheckBox()
        Me.chkNoSolitar = New System.Windows.Forms.CheckBox()
        Me.txtSecImpre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFormulario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(569, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SubArea"
        '
        'txtSubArea
        '
        Me.txtSubArea.Location = New System.Drawing.Point(641, 26)
        Me.txtSubArea.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubArea.Name = "txtSubArea"
        Me.txtSubArea.Size = New System.Drawing.Size(132, 22)
        Me.txtSubArea.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblform)
        Me.GroupBox1.Controls.Add(Me.cmbxCodigoArea)
        Me.GroupBox1.Controls.Add(Me.btnCrearNuevo)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkConsolidado)
        Me.GroupBox1.Controls.Add(Me.chkNoSolitar)
        Me.GroupBox1.Controls.Add(Me.txtSecImpre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFormulario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSubArea)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(925, 228)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información de SubArea"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(444, -6)
        Me.lblform.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(71, 17)
        Me.lblform.TabIndex = 165
        Me.lblform.Text = "formulario"
        '
        'cmbxCodigoArea
        '
        Me.cmbxCodigoArea.DropDownWidth = 180
        Me.cmbxCodigoArea.FormattingEnabled = True
        Me.cmbxCodigoArea.Location = New System.Drawing.Point(368, 27)
        Me.cmbxCodigoArea.Name = "cmbxCodigoArea"
        Me.cmbxCodigoArea.Size = New System.Drawing.Size(132, 24)
        Me.cmbxCodigoArea.TabIndex = 164
        '
        'btnCrearNuevo
        '
        Me.btnCrearNuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrearNuevo.FlatAppearance.BorderSize = 0
        Me.btnCrearNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearNuevo.ForeColor = System.Drawing.Color.White
        Me.btnCrearNuevo.Location = New System.Drawing.Point(11, 192)
        Me.btnCrearNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrearNuevo.Name = "btnCrearNuevo"
        Me.btnCrearNuevo.Size = New System.Drawing.Size(100, 28)
        Me.btnCrearNuevo.TabIndex = 16
        Me.btnCrearNuevo.Text = "Crear Nuevo"
        Me.btnCrearNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(119, 192)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(227, 192)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(119, 27)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(132, 22)
        Me.txtCodigo.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Código"
        '
        'chkConsolidado
        '
        Me.chkConsolidado.AutoSize = True
        Me.chkConsolidado.Location = New System.Drawing.Point(277, 133)
        Me.chkConsolidado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkConsolidado.Name = "chkConsolidado"
        Me.chkConsolidado.Size = New System.Drawing.Size(179, 21)
        Me.chkConsolidado.TabIndex = 11
        Me.chkConsolidado.Text = "Formulario Consolidado"
        Me.chkConsolidado.UseVisualStyleBackColor = True
        '
        'chkNoSolitar
        '
        Me.chkNoSolitar.AutoSize = True
        Me.chkNoSolitar.Location = New System.Drawing.Point(277, 105)
        Me.chkNoSolitar.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNoSolitar.Name = "chkNoSolitar"
        Me.chkNoSolitar.Size = New System.Drawing.Size(267, 21)
        Me.chkNoSolitar.TabIndex = 10
        Me.chkNoSolitar.Text = "No Solicitar Sucursal en Hoja Trabajo"
        Me.chkNoSolitar.UseVisualStyleBackColor = True
        '
        'txtSecImpre
        '
        Me.txtSecImpre.Location = New System.Drawing.Point(119, 134)
        Me.txtSecImpre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSecImpre.Name = "txtSecImpre"
        Me.txtSecImpre.Size = New System.Drawing.Size(132, 22)
        Me.txtSecImpre.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sec. Impresión"
        '
        'txtFormulario
        '
        Me.txtFormulario.Location = New System.Drawing.Point(119, 102)
        Me.txtFormulario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormulario.Name = "txtFormulario"
        Me.txtFormulario.Size = New System.Drawing.Size(132, 22)
        Me.txtFormulario.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Formulario"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(119, 64)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(381, 22)
        Me.txtNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Area"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcantidad)
        Me.GroupBox2.Controls.Add(Me.dgbtabla)
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.txtnombreB)
        Me.GroupBox2.Controls.Add(Me.lblnombreB)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 250)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(925, 462)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Parametros"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(316, 421)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 119
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(14, 59)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(894, 345)
        Me.dgbtabla.TabIndex = 116
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(26, 421)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(155, 17)
        Me.lbltotal.TabIndex = 117
        Me.lbltotal.Text = "TOTAL DE SUBÁREAS"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(178, 23)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(730, 22)
        Me.txtnombreB.TabIndex = 120
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(24, 25)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(116, 17)
        Me.lblnombreB.TabIndex = 118
        Me.lblnombreB.Text = "Nombre Subárea"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegresar.BackgroundImage = CType(resources.GetObject("btnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Location = New System.Drawing.Point(16, 711)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(44, 46)
        Me.btnRegresar.TabIndex = 15
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'E_SubArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 769)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "E_SubArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Subárea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubArea As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkConsolidado As CheckBox
    Friend WithEvents chkNoSolitar As CheckBox
    Friend WithEvents txtSecImpre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFormulario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCrearNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents cmbxCodigoArea As ComboBox
    Friend WithEvents lblform As Label
End Class
