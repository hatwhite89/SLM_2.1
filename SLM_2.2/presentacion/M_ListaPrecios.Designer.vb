<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_ListaPrecios
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
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.rbtnNo = New System.Windows.Forms.RadioButton()
        Me.rbtnSi = New System.Windows.Forms.RadioButton()
        Me.lblTipoConvenio = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoListaPrecios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupoOitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBreveDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtcodigoBreve = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbxclasificacion.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxclasificacion
        '
        Me.gbxclasificacion.Controls.Add(Me.rbtnNo)
        Me.gbxclasificacion.Controls.Add(Me.rbtnSi)
        Me.gbxclasificacion.Controls.Add(Me.lblTipoConvenio)
        Me.gbxclasificacion.Controls.Add(Me.dgbtabla)
        Me.gbxclasificacion.Controls.Add(Me.txtDescripcion)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoBreve)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigo)
        Me.gbxclasificacion.Controls.Add(Me.lbltipo)
        Me.gbxclasificacion.Controls.Add(Me.lbldescripcion)
        Me.gbxclasificacion.Controls.Add(Me.btnmodificar)
        Me.gbxclasificacion.Controls.Add(Me.btnnuevo)
        Me.gbxclasificacion.Controls.Add(Me.btnguardar)
        Me.gbxclasificacion.Controls.Add(Me.lblcodigo)
        Me.gbxclasificacion.Controls.Add(Me.btncancelar)
        Me.gbxclasificacion.Location = New System.Drawing.Point(11, 11)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(696, 466)
        Me.gbxclasificacion.TabIndex = 119
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR LISTA DE PRECIOS"
        '
        'rbtnNo
        '
        Me.rbtnNo.AutoSize = True
        Me.rbtnNo.Checked = True
        Me.rbtnNo.Location = New System.Drawing.Point(218, 94)
        Me.rbtnNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnNo.Name = "rbtnNo"
        Me.rbtnNo.Size = New System.Drawing.Size(39, 17)
        Me.rbtnNo.TabIndex = 150
        Me.rbtnNo.TabStop = True
        Me.rbtnNo.Text = "No"
        Me.rbtnNo.UseVisualStyleBackColor = True
        '
        'rbtnSi
        '
        Me.rbtnSi.AutoSize = True
        Me.rbtnSi.Location = New System.Drawing.Point(116, 96)
        Me.rbtnSi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtnSi.Name = "rbtnSi"
        Me.rbtnSi.Size = New System.Drawing.Size(34, 17)
        Me.rbtnSi.TabIndex = 149
        Me.rbtnSi.TabStop = True
        Me.rbtnSi.Text = "Si"
        Me.rbtnSi.UseVisualStyleBackColor = True
        '
        'lblTipoConvenio
        '
        Me.lblTipoConvenio.AutoSize = True
        Me.lblTipoConvenio.Location = New System.Drawing.Point(28, 96)
        Me.lblTipoConvenio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoConvenio.Name = "lblTipoConvenio"
        Me.lblTipoConvenio.Size = New System.Drawing.Size(76, 13)
        Me.lblTipoConvenio.TabIndex = 148
        Me.lblTipoConvenio.Text = "Tipo Convenio"
        '
        'dgbtabla
        '
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codigoListaPrecios, Me.grupoOitem, Me.Descuento, Me.CodigoBreveDescuento})
        Me.dgbtabla.Location = New System.Drawing.Point(4, 128)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(688, 290)
        Me.dgbtabla.TabIndex = 147
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Visible = False
        Me.codigo.Width = 125
        '
        'codigoListaPrecios
        '
        Me.codigoListaPrecios.HeaderText = "Codigo Lista Precios"
        Me.codigoListaPrecios.MinimumWidth = 6
        Me.codigoListaPrecios.Name = "codigoListaPrecios"
        Me.codigoListaPrecios.ReadOnly = True
        Me.codigoListaPrecios.Visible = False
        Me.codigoListaPrecios.Width = 125
        '
        'grupoOitem
        '
        Me.grupoOitem.HeaderText = "Grupo ó Examen"
        Me.grupoOitem.MinimumWidth = 6
        Me.grupoOitem.Name = "grupoOitem"
        Me.grupoOitem.ReadOnly = True
        Me.grupoOitem.Width = 125
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Codigo Descuento"
        Me.Descuento.MinimumWidth = 6
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.Visible = False
        Me.Descuento.Width = 125
        '
        'CodigoBreveDescuento
        '
        Me.CodigoBreveDescuento.HeaderText = "Descuento"
        Me.CodigoBreveDescuento.MinimumWidth = 6
        Me.CodigoBreveDescuento.Name = "CodigoBreveDescuento"
        Me.CodigoBreveDescuento.ReadOnly = True
        Me.CodigoBreveDescuento.Width = 125
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 55)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(414, 20)
        Me.txtDescripcion.TabIndex = 133
        '
        'txtcodigoBreve
        '
        Me.txtcodigoBreve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoBreve.Location = New System.Drawing.Point(393, 24)
        Me.txtcodigoBreve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoBreve.MaxLength = 20
        Me.txtcodigoBreve.Name = "txtcodigoBreve"
        Me.txtcodigoBreve.Size = New System.Drawing.Size(138, 20)
        Me.txtcodigoBreve.TabIndex = 132
        Me.txtcodigoBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(116, 24)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(138, 20)
        Me.txtcodigo.TabIndex = 131
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(309, 25)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(71, 13)
        Me.lbltipo.TabIndex = 130
        Me.lbltipo.Text = "Código Breve"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(41, 57)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbldescripcion.TabIndex = 126
        Me.lbldescripcion.Text = "Descripción"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(163, 434)
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
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(4, 434)
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
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(87, 434)
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
        Me.lblcodigo.Location = New System.Drawing.Point(63, 25)
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
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(239, 434)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'M_ListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 488)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_ListaPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Precios"
        Me.gbxclasificacion.ResumeLayout(False)
        Me.gbxclasificacion.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxclasificacion As GroupBox
    Friend WithEvents lbltipo As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtcodigoBreve As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents codigoListaPrecios As DataGridViewTextBoxColumn
    Friend WithEvents grupoOitem As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBreveDescuento As DataGridViewTextBoxColumn
    Friend WithEvents rbtnNo As RadioButton
    Friend WithEvents rbtnSi As RadioButton
    Friend WithEvents lblTipoConvenio As Label
End Class
