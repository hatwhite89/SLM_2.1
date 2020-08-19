<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_PuestoTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_PuestoTrabajo))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtdescripcionB = New System.Windows.Forms.TextBox()
        Me.lbldescripcionB = New System.Windows.Forms.Label()
        Me.gbxsucursal = New System.Windows.Forms.GroupBox()
        Me.txtnombreDepto = New System.Windows.Forms.TextBox()
        Me.btnDepto = New System.Windows.Forms.Button()
        Me.txtcodigoDepto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbldireccion1 = New System.Windows.Forms.Label()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblform = New System.Windows.Forms.Label()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxsucursal.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtdescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lbldescripcionB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(14, 191)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbxbusqueda.Size = New System.Drawing.Size(928, 416)
        Me.gbxbusqueda.TabIndex = 119
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR PUESTO DE TRABAJO"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(295, 386)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 59)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(917, 313)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(6, 386)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(238, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE PUESTOS DE TRABAJO"
        '
        'txtdescripcionB
        '
        Me.txtdescripcionB.Location = New System.Drawing.Point(107, 30)
        Me.txtdescripcionB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripcionB.MaxLength = 80
        Me.txtdescripcionB.Name = "txtdescripcionB"
        Me.txtdescripcionB.Size = New System.Drawing.Size(815, 22)
        Me.txtdescripcionB.TabIndex = 115
        '
        'lbldescripcionB
        '
        Me.lbldescripcionB.AutoSize = True
        Me.lbldescripcionB.Location = New System.Drawing.Point(17, 31)
        Me.lbldescripcionB.Name = "lbldescripcionB"
        Me.lbldescripcionB.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcionB.TabIndex = 114
        Me.lbldescripcionB.Text = "Descripción"
        '
        'gbxsucursal
        '
        Me.gbxsucursal.Controls.Add(Me.txtnombreDepto)
        Me.gbxsucursal.Controls.Add(Me.btnDepto)
        Me.gbxsucursal.Controls.Add(Me.txtcodigoDepto)
        Me.gbxsucursal.Controls.Add(Me.Label11)
        Me.gbxsucursal.Controls.Add(Me.lbldireccion1)
        Me.gbxsucursal.Controls.Add(Me.rtxtdescripcion)
        Me.gbxsucursal.Controls.Add(Me.btnmodificar)
        Me.gbxsucursal.Controls.Add(Me.btncancelar)
        Me.gbxsucursal.Controls.Add(Me.lblcodigo)
        Me.gbxsucursal.Controls.Add(Me.btnnuevo)
        Me.gbxsucursal.Controls.Add(Me.txtcodigo)
        Me.gbxsucursal.Controls.Add(Me.btnguardar)
        Me.gbxsucursal.Location = New System.Drawing.Point(14, 16)
        Me.gbxsucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxsucursal.Name = "gbxsucursal"
        Me.gbxsucursal.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxsucursal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbxsucursal.Size = New System.Drawing.Size(928, 170)
        Me.gbxsucursal.TabIndex = 118
        Me.gbxsucursal.TabStop = False
        Me.gbxsucursal.Text = "REGISTRAR PUESTO DE TRABAJO"
        '
        'txtnombreDepto
        '
        Me.txtnombreDepto.Location = New System.Drawing.Point(337, 77)
        Me.txtnombreDepto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreDepto.Name = "txtnombreDepto"
        Me.txtnombreDepto.ReadOnly = True
        Me.txtnombreDepto.Size = New System.Drawing.Size(568, 22)
        Me.txtnombreDepto.TabIndex = 167
        '
        'btnDepto
        '
        Me.btnDepto.BackColor = System.Drawing.Color.White
        Me.btnDepto.BackgroundImage = CType(resources.GetObject("btnDepto.BackgroundImage"), System.Drawing.Image)
        Me.btnDepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDepto.FlatAppearance.BorderSize = 0
        Me.btnDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepto.Location = New System.Drawing.Point(145, 76)
        Me.btnDepto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDepto.Name = "btnDepto"
        Me.btnDepto.Size = New System.Drawing.Size(49, 22)
        Me.btnDepto.TabIndex = 168
        Me.btnDepto.Text = "..."
        Me.btnDepto.UseVisualStyleBackColor = False
        '
        'txtcodigoDepto
        '
        Me.txtcodigoDepto.Location = New System.Drawing.Point(200, 77)
        Me.txtcodigoDepto.MaxLength = 20
        Me.txtcodigoDepto.Name = "txtcodigoDepto"
        Me.txtcodigoDepto.Size = New System.Drawing.Size(120, 22)
        Me.txtcodigoDepto.TabIndex = 170
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Departamento"
        '
        'lbldireccion1
        '
        Me.lbldireccion1.AutoSize = True
        Me.lbldireccion1.Location = New System.Drawing.Point(364, 25)
        Me.lbldireccion1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion1.Name = "lbldireccion1"
        Me.lbldireccion1.Size = New System.Drawing.Size(82, 17)
        Me.lbldireccion1.TabIndex = 125
        Me.lbldireccion1.Text = "Descripción"
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(482, 21)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtdescripcion.MaxLength = 80
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(423, 44)
        Me.rtxtdescripcion.TabIndex = 126
        Me.rtxtdescripcion.Text = ""
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(233, 118)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 111
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(335, 118)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(68, 28)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(21, 118)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 110
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(139, 25)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(181, 22)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(132, 118)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(383, 9)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(71, 17)
        Me.lblform.TabIndex = 127
        Me.lblform.Text = "formulario"
        Me.lblform.Visible = False
        '
        'M_PuestoTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 622)
        Me.Controls.Add(Me.lblform)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxsucursal)
        Me.KeyPreview = True
        Me.Name = "M_PuestoTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puesto de Trabajo"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxsucursal.ResumeLayout(False)
        Me.gbxsucursal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtdescripcionB As TextBox
    Friend WithEvents lbldescripcionB As Label
    Friend WithEvents gbxsucursal As GroupBox
    Friend WithEvents lbldireccion1 As Label
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblform As Label
    Friend WithEvents txtnombreDepto As TextBox
    Friend WithEvents btnDepto As Button
    Friend WithEvents txtcodigoDepto As TextBox
    Friend WithEvents Label11 As Label
End Class
