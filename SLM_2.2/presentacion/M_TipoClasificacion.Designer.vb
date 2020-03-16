<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_TipoClasificacion
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
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.txtcomentarioB = New System.Windows.Forms.TextBox()
        Me.lblcomentarioB = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.rtxtcomentario = New System.Windows.Forms.RichTextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lblcomentario = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxclasificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lbltipo)
        Me.gbxbusqueda.Controls.Add(Me.txtcomentarioB)
        Me.gbxbusqueda.Controls.Add(Me.lblcomentarioB)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 179)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 317)
        Me.gbxbusqueda.TabIndex = 114
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR TIPO CLASIFICACIÓN"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(391, 29)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(0, 13)
        Me.lbltipo.TabIndex = 118
        Me.lbltipo.Visible = False
        '
        'txtcomentarioB
        '
        Me.txtcomentarioB.Location = New System.Drawing.Point(68, 28)
        Me.txtcomentarioB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcomentarioB.MaxLength = 200
        Me.txtcomentarioB.Name = "txtcomentarioB"
        Me.txtcomentarioB.Size = New System.Drawing.Size(624, 20)
        Me.txtcomentarioB.TabIndex = 117
        '
        'lblcomentarioB
        '
        Me.lblcomentarioB.AutoSize = True
        Me.lblcomentarioB.Location = New System.Drawing.Point(4, 29)
        Me.lblcomentarioB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcomentarioB.Name = "lblcomentarioB"
        Me.lblcomentarioB.Size = New System.Drawing.Size(60, 13)
        Me.lblcomentarioB.TabIndex = 116
        Me.lblcomentarioB.Text = "Comentario"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(224, 293)
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
        Me.dgbtabla.Location = New System.Drawing.Point(7, 52)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(685, 226)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(7, 293)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(152, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL TIPO CLASIFICACIÓN"
        '
        'gbxclasificacion
        '
        Me.gbxclasificacion.Controls.Add(Me.rtxtcomentario)
        Me.gbxclasificacion.Controls.Add(Me.btnmodificar)
        Me.gbxclasificacion.Controls.Add(Me.btnnuevo)
        Me.gbxclasificacion.Controls.Add(Me.btnguardar)
        Me.gbxclasificacion.Controls.Add(Me.lblcodigo)
        Me.gbxclasificacion.Controls.Add(Me.btncancelar)
        Me.gbxclasificacion.Controls.Add(Me.lblcomentario)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigo)
        Me.gbxclasificacion.Location = New System.Drawing.Point(11, 11)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(696, 164)
        Me.gbxclasificacion.TabIndex = 116
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR CLASIFICACIÓN"
        '
        'rtxtcomentario
        '
        Me.rtxtcomentario.Location = New System.Drawing.Point(365, 21)
        Me.rtxtcomentario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtcomentario.MaxLength = 200
        Me.rtxtcomentario.Name = "rtxtcomentario"
        Me.rtxtcomentario.Size = New System.Drawing.Size(327, 98)
        Me.rtxtcomentario.TabIndex = 115
        Me.rtxtcomentario.Text = ""
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(163, 132)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 114
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(4, 132)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 113
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(87, 132)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(15, 22)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(239, 132)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'lblcomentario
        '
        Me.lblcomentario.AutoSize = True
        Me.lblcomentario.Location = New System.Drawing.Point(296, 23)
        Me.lblcomentario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcomentario.Name = "lblcomentario"
        Me.lblcomentario.Size = New System.Drawing.Size(60, 13)
        Me.lblcomentario.TabIndex = 39
        Me.lblcomentario.Text = "Comentario"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(64, 20)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(138, 20)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'M_TipoClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_TipoClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Clasificación"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxclasificacion.ResumeLayout(False)
        Me.gbxclasificacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents gbxclasificacion As GroupBox
    Friend WithEvents rtxtcomentario As RichTextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblcomentario As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtcomentarioB As TextBox
    Friend WithEvents lblcomentarioB As Label
    Friend WithEvents lbltipo As Label
End Class
