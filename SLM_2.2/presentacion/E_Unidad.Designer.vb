<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_Unidad
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
        Me.gbxtipoObjeto = New System.Windows.Forms.GroupBox()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFactorCantidad = New System.Windows.Forms.TextBox()
        Me.rtxtcomentario = New System.Windows.Forms.RichTextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.lblcomentario = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtcomentarioB = New System.Windows.Forms.TextBox()
        Me.lblcomentarioB = New System.Windows.Forms.Label()
        Me.gbxtipoObjeto.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxtipoObjeto
        '
        Me.gbxtipoObjeto.Controls.Add(Me.lblcode)
        Me.gbxtipoObjeto.Controls.Add(Me.Label1)
        Me.gbxtipoObjeto.Controls.Add(Me.txtFactorCantidad)
        Me.gbxtipoObjeto.Controls.Add(Me.rtxtcomentario)
        Me.gbxtipoObjeto.Controls.Add(Me.btnmodificar)
        Me.gbxtipoObjeto.Controls.Add(Me.btnnuevo)
        Me.gbxtipoObjeto.Controls.Add(Me.btnguardar)
        Me.gbxtipoObjeto.Controls.Add(Me.lblcodigo)
        Me.gbxtipoObjeto.Controls.Add(Me.btncancelar)
        Me.gbxtipoObjeto.Controls.Add(Me.lblcomentario)
        Me.gbxtipoObjeto.Controls.Add(Me.txtcodigo)
        Me.gbxtipoObjeto.Location = New System.Drawing.Point(11, 11)
        Me.gbxtipoObjeto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxtipoObjeto.Name = "gbxtipoObjeto"
        Me.gbxtipoObjeto.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxtipoObjeto.Size = New System.Drawing.Size(696, 154)
        Me.gbxtipoObjeto.TabIndex = 119
        Me.gbxtipoObjeto.TabStop = False
        Me.gbxtipoObjeto.Text = "REGISTRAR UNIDAD"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Location = New System.Drawing.Point(214, 15)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(0, 13)
        Me.lblcode.TabIndex = 118
        Me.lblcode.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Factor Cantidad"
        '
        'txtFactorCantidad
        '
        Me.txtFactorCantidad.Location = New System.Drawing.Point(94, 51)
        Me.txtFactorCantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFactorCantidad.MaxLength = 20
        Me.txtFactorCantidad.Name = "txtFactorCantidad"
        Me.txtFactorCantidad.Size = New System.Drawing.Size(138, 20)
        Me.txtFactorCantidad.TabIndex = 116
        Me.txtFactorCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rtxtcomentario
        '
        Me.rtxtcomentario.Location = New System.Drawing.Point(356, 12)
        Me.rtxtcomentario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxtcomentario.MaxLength = 100
        Me.rtxtcomentario.Name = "rtxtcomentario"
        Me.rtxtcomentario.Size = New System.Drawing.Size(336, 77)
        Me.rtxtcomentario.TabIndex = 115
        Me.rtxtcomentario.Text = ""
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(166, 122)
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
        Me.btnnuevo.Location = New System.Drawing.Point(7, 122)
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
        Me.btnguardar.Location = New System.Drawing.Point(90, 122)
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
        Me.lblcodigo.Location = New System.Drawing.Point(4, 15)
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
        Me.btncancelar.Location = New System.Drawing.Point(242, 122)
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
        Me.lblcomentario.Location = New System.Drawing.Point(287, 15)
        Me.lblcomentario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcomentario.Name = "lblcomentario"
        Me.lblcomentario.Size = New System.Drawing.Size(60, 13)
        Me.lblcomentario.TabIndex = 39
        Me.lblcomentario.Text = "Comentario"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(52, 13)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(180, 20)
        Me.txtcodigo.TabIndex = 40
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtcomentarioB)
        Me.gbxbusqueda.Controls.Add(Me.lblcomentarioB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 169)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 295)
        Me.gbxbusqueda.TabIndex = 118
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR UNIDAD"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(221, 270)
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
        Me.dgbtabla.Location = New System.Drawing.Point(4, 46)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(688, 222)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(4, 270)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(158, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE TIPOS DE OBJETO"
        '
        'txtcomentarioB
        '
        Me.txtcomentarioB.Location = New System.Drawing.Point(83, 22)
        Me.txtcomentarioB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcomentarioB.MaxLength = 100
        Me.txtcomentarioB.Name = "txtcomentarioB"
        Me.txtcomentarioB.Size = New System.Drawing.Size(609, 20)
        Me.txtcomentarioB.TabIndex = 115
        '
        'lblcomentarioB
        '
        Me.lblcomentarioB.AutoSize = True
        Me.lblcomentarioB.Location = New System.Drawing.Point(18, 24)
        Me.lblcomentarioB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcomentarioB.Name = "lblcomentarioB"
        Me.lblcomentarioB.Size = New System.Drawing.Size(60, 13)
        Me.lblcomentarioB.TabIndex = 114
        Me.lblcomentarioB.Text = "Comentario"
        '
        'E_Unidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 475)
        Me.Controls.Add(Me.gbxtipoObjeto)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "E_Unidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidad"
        Me.gbxtipoObjeto.ResumeLayout(False)
        Me.gbxtipoObjeto.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxtipoObjeto As GroupBox
    Friend WithEvents rtxtcomentario As RichTextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents lblcomentario As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtcomentarioB As TextBox
    Friend WithEvents lblcomentarioB As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFactorCantidad As TextBox
    Friend WithEvents lblcode As Label
End Class
