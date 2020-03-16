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
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.rtxtdescripcionB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gbxcaja = New System.Windows.Forms.GroupBox()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.rtxtdescripcion = New System.Windows.Forms.RichTextBox()
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
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 154)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 336)
        Me.gbxbusqueda.TabIndex = 123
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR MÁQUINAS LOCALES"
        '
        'rtxtdescripcionB
        '
        Me.rtxtdescripcionB.Location = New System.Drawing.Point(188, 21)
        Me.rtxtdescripcionB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtdescripcionB.MaxLength = 200
        Me.rtxtdescripcionB.Name = "rtxtdescripcionB"
        Me.rtxtdescripcionB.Size = New System.Drawing.Size(145, 20)
        Me.rtxtdescripcionB.TabIndex = 118
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(120, 23)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(63, 13)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Descripción"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(322, 306)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(33, 53)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(390, 240)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(74, 306)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(171, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE MÁQUINAS LOCALES"
        '
        'gbxcaja
        '
        Me.gbxcaja.Controls.Add(Me.lblcode)
        Me.gbxcaja.Controls.Add(Me.rtxtdescripcion)
        Me.gbxcaja.Controls.Add(Me.lbldescripcion)
        Me.gbxcaja.Controls.Add(Me.lblcodigo)
        Me.gbxcaja.Controls.Add(Me.txtcodigo)
        Me.gbxcaja.Controls.Add(Me.btnmodificar)
        Me.gbxcaja.Controls.Add(Me.btncancelar)
        Me.gbxcaja.Controls.Add(Me.btnnuevo)
        Me.gbxcaja.Controls.Add(Me.btnguardar)
        Me.gbxcaja.Location = New System.Drawing.Point(11, 11)
        Me.gbxcaja.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxcaja.Name = "gbxcaja"
        Me.gbxcaja.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxcaja.Size = New System.Drawing.Size(696, 139)
        Me.gbxcaja.TabIndex = 122
        Me.gbxcaja.TabStop = False
        Me.gbxcaja.Text = "REGISTRAR MÁQUINAS LOCALES"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(305, 28)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 124
        Me.lblcode.Visible = False
        '
        'rtxtdescripcion
        '
        Me.rtxtdescripcion.Location = New System.Drawing.Point(373, 28)
        Me.rtxtdescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtdescripcion.MaxLength = 200
        Me.rtxtdescripcion.Name = "rtxtdescripcion"
        Me.rtxtdescripcion.Size = New System.Drawing.Size(318, 73)
        Me.rtxtdescripcion.TabIndex = 129
        Me.rtxtdescripcion.Text = ""
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(305, 28)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbldescripcion.TabIndex = 128
        Me.lbldescripcion.Text = "Descripción"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(4, 28)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 115
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(48, 28)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(131, 20)
        Me.txtcodigo.TabIndex = 114
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(163, 107)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
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
        Me.btncancelar.Location = New System.Drawing.Point(239, 107)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
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
        Me.btnnuevo.Location = New System.Drawing.Point(4, 107)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
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
        Me.btnguardar.Location = New System.Drawing.Point(87, 107)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'M_MaquinasLocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxcaja)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
