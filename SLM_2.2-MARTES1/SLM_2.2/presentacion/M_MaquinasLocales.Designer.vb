<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_MaquinasLocales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_MaquinasLocales))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.rtxtdescripcionB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gbxcaja = New System.Windows.Forms.GroupBox()
        Me.lblform = New System.Windows.Forms.Label()
        Me.lblcodeSucursal = New System.Windows.Forms.Label()
        Me.txtnombreSucursal = New System.Windows.Forms.TextBox()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.btnSucursal = New System.Windows.Forms.Button()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
        Me.txtcodigoSucursal = New System.Windows.Forms.TextBox()
        Me.lblctaContado = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxcaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.rtxtdescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Location = New System.Drawing.Point(15, 190)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(928, 414)
        Me.gbxbusqueda.TabIndex = 123
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR MÁQUINAS LOCALES"
        '
        'rtxtdescripcionB
        '
        Me.rtxtdescripcionB.Location = New System.Drawing.Point(94, 34)
        Me.rtxtdescripcionB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtdescripcionB.MaxLength = 200
        Me.rtxtdescripcionB.Name = "rtxtdescripcionB"
        Me.rtxtdescripcionB.Size = New System.Drawing.Size(828, 22)
        Me.rtxtdescripcionB.TabIndex = 118
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(6, 37)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(82, 17)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Descripción"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(372, 370)
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
        Me.dgbtabla.Location = New System.Drawing.Point(9, 64)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(913, 278)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(42, 370)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(220, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE MÁQUINAS LOCALES"
        '
        'gbxcaja
        '
        Me.gbxcaja.Controls.Add(Me.lblform)
        Me.gbxcaja.Controls.Add(Me.lblcodeSucursal)
        Me.gbxcaja.Controls.Add(Me.txtnombreSucursal)
        Me.gbxcaja.Controls.Add(Me.lblcode)
        Me.gbxcaja.Controls.Add(Me.btnSucursal)
        Me.gbxcaja.Controls.Add(Me.rtxtdescripcion)
        Me.gbxcaja.Controls.Add(Me.txtcodigoSucursal)
        Me.gbxcaja.Controls.Add(Me.lblctaContado)
        Me.gbxcaja.Controls.Add(Me.lbldescripcion)
        Me.gbxcaja.Controls.Add(Me.lblcodigo)
        Me.gbxcaja.Controls.Add(Me.txtcodigo)
        Me.gbxcaja.Controls.Add(Me.btnmodificar)
        Me.gbxcaja.Controls.Add(Me.btncancelar)
        Me.gbxcaja.Controls.Add(Me.btnnuevo)
        Me.gbxcaja.Controls.Add(Me.btnguardar)
        Me.gbxcaja.Location = New System.Drawing.Point(15, 14)
        Me.gbxcaja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxcaja.Name = "gbxcaja"
        Me.gbxcaja.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxcaja.Size = New System.Drawing.Size(928, 171)
        Me.gbxcaja.TabIndex = 122
        Me.gbxcaja.TabStop = False
        Me.gbxcaja.Text = "REGISTRAR MÁQUINAS LOCALES"
        '
        'lblform
        '
        Me.lblform.AutoSize = True
        Me.lblform.Location = New System.Drawing.Point(354, 0)
        Me.lblform.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(71, 17)
        Me.lblform.TabIndex = 138
        Me.lblform.Text = "formulario"
        Me.lblform.Visible = False
        '
        'lblcodeSucursal
        '
        Me.lblcodeSucursal.AutoSize = True
        Me.lblcodeSucursal.Location = New System.Drawing.Point(117, 71)
        Me.lblcodeSucursal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodeSucursal.Name = "lblcodeSucursal"
        Me.lblcodeSucursal.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeSucursal.TabIndex = 137
        Me.lblcodeSucursal.Visible = False
        '
        'txtnombreSucursal
        '
        Me.txtnombreSucursal.Location = New System.Drawing.Point(307, 91)
        Me.txtnombreSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreSucursal.Name = "txtnombreSucursal"
        Me.txtnombreSucursal.ReadOnly = True
        Me.txtnombreSucursal.Size = New System.Drawing.Size(615, 22)
        Me.txtnombreSucursal.TabIndex = 136
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(407, 34)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 17)
        Me.lblcode.TabIndex = 124
        Me.lblcode.Visible = False
        '
        'btnSucursal
        '
        Me.btnSucursal.BackColor = System.Drawing.Color.White
        Me.btnSucursal.BackgroundImage = CType(resources.GetObject("btnSucursal.BackgroundImage"), System.Drawing.Image)
        Me.btnSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSucursal.FlatAppearance.BorderSize = 0
        Me.btnSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSucursal.Location = New System.Drawing.Point(117, 90)
        Me.btnSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(49, 22)
        Me.btnSucursal.TabIndex = 135
        Me.btnSucursal.Text = "..."
        Me.btnSucursal.UseVisualStyleBackColor = False
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(497, 34)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxtdescripcion.MaxLength = 200
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(423, 42)
        Me.rtxtdescripcion.TabIndex = 129
        Me.rtxtdescripcion.Text = ""
        '
        'txtcodigoSucursal
        '
        Me.txtcodigoSucursal.Location = New System.Drawing.Point(175, 90)
        Me.txtcodigoSucursal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoSucursal.MaxLength = 20
        Me.txtcodigoSucursal.Name = "txtcodigoSucursal"
        Me.txtcodigoSucursal.Size = New System.Drawing.Size(117, 22)
        Me.txtcodigoSucursal.TabIndex = 134
        Me.txtcodigoSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblctaContado
        '
        Me.lblctaContado.AutoSize = True
        Me.lblctaContado.Location = New System.Drawing.Point(42, 91)
        Me.lblctaContado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblctaContado.Name = "lblctaContado"
        Me.lblctaContado.Size = New System.Drawing.Size(63, 17)
        Me.lblctaContado.TabIndex = 133
        Me.lblctaContado.Text = "Sucursal"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(407, 34)
        Me.lbldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcion.TabIndex = 128
        Me.lbldescripcion.Text = "Descripción"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(53, 37)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 115
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(120, 34)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(173, 22)
        Me.txtcodigo.TabIndex = 114
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(217, 132)
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
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(319, 132)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(5, 132)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 110
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(116, 132)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'M_MaquinasLocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 622)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxcaja)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_MaquinasLocales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Máquinas Locales"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxcaja.ResumeLayout(False)
        Me.gbxcaja.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents rtxtdescripcionB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents gbxcaja As GroupBox
    Friend WithEvents lblcode As Label
    Friend WithEvents rtxtdescripcion As RichTextBox
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtnombreSucursal As TextBox
    Friend WithEvents btnSucursal As Button
    Friend WithEvents txtcodigoSucursal As TextBox
    Friend WithEvents lblctaContado As Label
    Friend WithEvents lblcodeSucursal As Label
    Friend WithEvents lblform As Label
End Class
