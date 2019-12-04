<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Especialidad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbxespecialidad = New System.Windows.Forms.GroupBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.gbxespecialidad.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(64, 37)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(129, 34)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(58, 65)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 17)
        Me.lblnombre.TabIndex = 39
        Me.lblnombre.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(129, 62)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(371, 22)
        Me.txtnombre.TabIndex = 38
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(474, 107)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(90, 35)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'gbxespecialidad
        '
        Me.gbxespecialidad.Controls.Add(Me.btnmodificar)
        Me.gbxespecialidad.Controls.Add(Me.btncancelar)
        Me.gbxespecialidad.Controls.Add(Me.lblcodigo)
        Me.gbxespecialidad.Controls.Add(Me.btnnuevo)
        Me.gbxespecialidad.Controls.Add(Me.txtcodigo)
        Me.gbxespecialidad.Controls.Add(Me.lblnombre)
        Me.gbxespecialidad.Controls.Add(Me.txtnombre)
        Me.gbxespecialidad.Controls.Add(Me.btnguardar)
        Me.gbxespecialidad.Location = New System.Drawing.Point(26, 23)
        Me.gbxespecialidad.Name = "gbxespecialidad"
        Me.gbxespecialidad.Size = New System.Drawing.Size(613, 168)
        Me.gbxespecialidad.TabIndex = 112
        Me.gbxespecialidad.TabStop = False
        Me.gbxespecialidad.Text = "REGISTRAR ESPECIALIDAD"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(336, 107)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 35)
        Me.btnmodificar.TabIndex = 111
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(54, 107)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 35)
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
        Me.btnguardar.Location = New System.Drawing.Point(200, 107)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 35)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(26, 197)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Size = New System.Drawing.Size(613, 394)
        Me.gbxbusqueda.TabIndex = 113
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR ESPECIALIDAD"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(407, 351)
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
        Me.dgbtabla.Location = New System.Drawing.Point(44, 88)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(520, 245)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(118, 351)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(196, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE ESPECIALIDADES"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(220, 34)
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(192, 22)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(156, 37)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 114
        Me.lblnombreB.Text = "Nombre"
        '
        'M_Especialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 622)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxespecialidad)
        Me.KeyPreview = True
        Me.Name = "M_Especialidad"
        Me.Text = "Especialidad Médica"
        Me.gbxespecialidad.ResumeLayout(False)
        Me.gbxespecialidad.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents gbxespecialidad As GroupBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombreB As Label
End Class
