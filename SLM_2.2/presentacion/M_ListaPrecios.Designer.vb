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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_ListaPrecios))
        Me.gbxclasificacion = New System.Windows.Forms.GroupBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.rbtnEfectivoNo = New System.Windows.Forms.RadioButton()
        Me.rbtnEfectivoSi = New System.Windows.Forms.RadioButton()
        Me.lblSolicitaEfectivo = New System.Windows.Forms.Label()
        Me.lblcodeT = New System.Windows.Forms.Label()
        Me.btnbuscarTermino = New System.Windows.Forms.Button()
        Me.txtDescripcionTermino = New System.Windows.Forms.TextBox()
        Me.txtcodigoTermino = New System.Windows.Forms.TextBox()
        Me.lblTerminoPago = New System.Windows.Forms.Label()
        Me.rbtnConvenioNo = New System.Windows.Forms.RadioButton()
        Me.rbtnConvenioSi = New System.Windows.Forms.RadioButton()
        Me.lblTipoConvenio = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoListaPrecios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoGrupoItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.gbxclasificacion.Controls.Add(Me.txtPorcentaje)
        Me.gbxclasificacion.Controls.Add(Me.lblPorcentaje)
        Me.gbxclasificacion.Controls.Add(Me.rbtnEfectivoNo)
        Me.gbxclasificacion.Controls.Add(Me.rbtnEfectivoSi)
        Me.gbxclasificacion.Controls.Add(Me.lblSolicitaEfectivo)
        Me.gbxclasificacion.Controls.Add(Me.lblcodeT)
        Me.gbxclasificacion.Controls.Add(Me.btnbuscarTermino)
        Me.gbxclasificacion.Controls.Add(Me.txtDescripcionTermino)
        Me.gbxclasificacion.Controls.Add(Me.txtcodigoTermino)
        Me.gbxclasificacion.Controls.Add(Me.lblTerminoPago)
        Me.gbxclasificacion.Controls.Add(Me.rbtnConvenioNo)
        Me.gbxclasificacion.Controls.Add(Me.rbtnConvenioSi)
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
        Me.gbxclasificacion.Location = New System.Drawing.Point(15, 14)
        Me.gbxclasificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxclasificacion.Name = "gbxclasificacion"
        Me.gbxclasificacion.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxclasificacion.Size = New System.Drawing.Size(928, 574)
        Me.gbxclasificacion.TabIndex = 119
        Me.gbxclasificacion.TabStop = False
        Me.gbxclasificacion.Text = "REGISTRAR LISTA DE PRECIOS"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcentaje.Location = New System.Drawing.Point(524, 164)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPorcentaje.MaxLength = 20
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(183, 22)
        Me.txtPorcentaje.TabIndex = 160
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(429, 164)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(76, 17)
        Me.lblPorcentaje.TabIndex = 159
        Me.lblPorcentaje.Text = "Porcentaje"
        '
        'rbtnEfectivoNo
        '
        Me.rbtnEfectivoNo.AutoSize = True
        Me.rbtnEfectivoNo.Checked = True
        Me.rbtnEfectivoNo.Location = New System.Drawing.Point(292, 162)
        Me.rbtnEfectivoNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnEfectivoNo.Name = "rbtnEfectivoNo"
        Me.rbtnEfectivoNo.Size = New System.Drawing.Size(47, 21)
        Me.rbtnEfectivoNo.TabIndex = 158
        Me.rbtnEfectivoNo.TabStop = True
        Me.rbtnEfectivoNo.Text = "No"
        Me.rbtnEfectivoNo.UseVisualStyleBackColor = True
        '
        'rbtnEfectivoSi
        '
        Me.rbtnEfectivoSi.AutoSize = True
        Me.rbtnEfectivoSi.Location = New System.Drawing.Point(156, 164)
        Me.rbtnEfectivoSi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnEfectivoSi.Name = "rbtnEfectivoSi"
        Me.rbtnEfectivoSi.Size = New System.Drawing.Size(41, 21)
        Me.rbtnEfectivoSi.TabIndex = 157
        Me.rbtnEfectivoSi.TabStop = True
        Me.rbtnEfectivoSi.Text = "Si"
        Me.rbtnEfectivoSi.UseVisualStyleBackColor = True
        '
        'lblSolicitaEfectivo
        '
        Me.lblSolicitaEfectivo.AutoSize = True
        Me.lblSolicitaEfectivo.Location = New System.Drawing.Point(30, 164)
        Me.lblSolicitaEfectivo.Name = "lblSolicitaEfectivo"
        Me.lblSolicitaEfectivo.Size = New System.Drawing.Size(107, 17)
        Me.lblSolicitaEfectivo.TabIndex = 156
        Me.lblSolicitaEfectivo.Text = "Solicita Efectivo"
        '
        'lblcodeT
        '
        Me.lblcodeT.AutoSize = True
        Me.lblcodeT.Location = New System.Drawing.Point(423, 131)
        Me.lblcodeT.Name = "lblcodeT"
        Me.lblcodeT.Size = New System.Drawing.Size(0, 17)
        Me.lblcodeT.TabIndex = 155
        '
        'btnbuscarTermino
        '
        Me.btnbuscarTermino.BackColor = System.Drawing.Color.White
        Me.btnbuscarTermino.BackgroundImage = CType(resources.GetObject("btnbuscarTermino.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarTermino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarTermino.FlatAppearance.BorderSize = 0
        Me.btnbuscarTermino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarTermino.Location = New System.Drawing.Point(528, 113)
        Me.btnbuscarTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarTermino.Name = "btnbuscarTermino"
        Me.btnbuscarTermino.Size = New System.Drawing.Size(49, 22)
        Me.btnbuscarTermino.TabIndex = 154
        Me.btnbuscarTermino.Text = "..."
        Me.btnbuscarTermino.UseVisualStyleBackColor = False
        '
        'txtDescripcionTermino
        '
        Me.txtDescripcionTermino.Location = New System.Drawing.Point(713, 113)
        Me.txtDescripcionTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionTermino.MaxLength = 20
        Me.txtDescripcionTermino.Name = "txtDescripcionTermino"
        Me.txtDescripcionTermino.ReadOnly = True
        Me.txtDescripcionTermino.Size = New System.Drawing.Size(183, 22)
        Me.txtDescripcionTermino.TabIndex = 153
        Me.txtDescripcionTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoTermino
        '
        Me.txtcodigoTermino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoTermino.Location = New System.Drawing.Point(585, 113)
        Me.txtcodigoTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoTermino.MaxLength = 20
        Me.txtcodigoTermino.Name = "txtcodigoTermino"
        Me.txtcodigoTermino.Size = New System.Drawing.Size(122, 22)
        Me.txtcodigoTermino.TabIndex = 152
        Me.txtcodigoTermino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTerminoPago
        '
        Me.lblTerminoPago.AutoSize = True
        Me.lblTerminoPago.Location = New System.Drawing.Point(408, 114)
        Me.lblTerminoPago.Name = "lblTerminoPago"
        Me.lblTerminoPago.Size = New System.Drawing.Size(97, 17)
        Me.lblTerminoPago.TabIndex = 151
        Me.lblTerminoPago.Text = "Término Pago"
        '
        'rbtnConvenioNo
        '
        Me.rbtnConvenioNo.AutoSize = True
        Me.rbtnConvenioNo.Checked = True
        Me.rbtnConvenioNo.Location = New System.Drawing.Point(291, 116)
        Me.rbtnConvenioNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnConvenioNo.Name = "rbtnConvenioNo"
        Me.rbtnConvenioNo.Size = New System.Drawing.Size(47, 21)
        Me.rbtnConvenioNo.TabIndex = 150
        Me.rbtnConvenioNo.TabStop = True
        Me.rbtnConvenioNo.Text = "No"
        Me.rbtnConvenioNo.UseVisualStyleBackColor = True
        '
        'rbtnConvenioSi
        '
        Me.rbtnConvenioSi.AutoSize = True
        Me.rbtnConvenioSi.Location = New System.Drawing.Point(155, 118)
        Me.rbtnConvenioSi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbtnConvenioSi.Name = "rbtnConvenioSi"
        Me.rbtnConvenioSi.Size = New System.Drawing.Size(41, 21)
        Me.rbtnConvenioSi.TabIndex = 149
        Me.rbtnConvenioSi.TabStop = True
        Me.rbtnConvenioSi.Text = "Si"
        Me.rbtnConvenioSi.UseVisualStyleBackColor = True
        '
        'lblTipoConvenio
        '
        Me.lblTipoConvenio.AutoSize = True
        Me.lblTipoConvenio.Location = New System.Drawing.Point(37, 118)
        Me.lblTipoConvenio.Name = "lblTipoConvenio"
        Me.lblTipoConvenio.Size = New System.Drawing.Size(99, 17)
        Me.lblTipoConvenio.TabIndex = 148
        Me.lblTipoConvenio.Text = "Tipo Convenio"
        '
        'dgbtabla
        '
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.codigoListaPrecios, Me.codigoGrupoItem, Me.codigoDescuento, Me.CodigoBreveDescuento})
        Me.dgbtabla.Location = New System.Drawing.Point(5, 204)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(917, 311)
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
        'codigoGrupoItem
        '
        Me.codigoGrupoItem.HeaderText = "Grupo ó Examen"
        Me.codigoGrupoItem.MinimumWidth = 6
        Me.codigoGrupoItem.Name = "codigoGrupoItem"
        Me.codigoGrupoItem.ReadOnly = True
        Me.codigoGrupoItem.Width = 125
        '
        'codigoDescuento
        '
        Me.codigoDescuento.HeaderText = "Codigo Descuento"
        Me.codigoDescuento.MinimumWidth = 6
        Me.codigoDescuento.Name = "codigoDescuento"
        Me.codigoDescuento.ReadOnly = True
        Me.codigoDescuento.Visible = False
        Me.codigoDescuento.Width = 125
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
        Me.txtDescripcion.Location = New System.Drawing.Point(156, 68)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(740, 22)
        Me.txtDescripcion.TabIndex = 133
        '
        'txtcodigoBreve
        '
        Me.txtcodigoBreve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigoBreve.Location = New System.Drawing.Point(524, 30)
        Me.txtcodigoBreve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoBreve.MaxLength = 20
        Me.txtcodigoBreve.Name = "txtcodigoBreve"
        Me.txtcodigoBreve.Size = New System.Drawing.Size(183, 22)
        Me.txtcodigoBreve.TabIndex = 132
        Me.txtcodigoBreve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(155, 30)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(183, 22)
        Me.txtcodigo.TabIndex = 131
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(412, 31)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(93, 17)
        Me.lbltipo.TabIndex = 130
        Me.lbltipo.Text = "Código Breve"
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(55, 70)
        Me.lbldescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lbldescripcion.TabIndex = 126
        Me.lbldescripcion.Text = "Descripción"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(217, 534)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
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
        Me.btnnuevo.Location = New System.Drawing.Point(5, 534)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
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
        Me.btnguardar.Location = New System.Drawing.Point(116, 534)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(84, 31)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(319, 534)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'M_ListaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 601)
        Me.Controls.Add(Me.gbxclasificacion)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents rbtnConvenioNo As RadioButton
    Friend WithEvents rbtnConvenioSi As RadioButton
    Friend WithEvents lblTipoConvenio As Label
    Friend WithEvents txtDescripcionTermino As TextBox
    Friend WithEvents txtcodigoTermino As TextBox
    Friend WithEvents lblTerminoPago As Label
    Friend WithEvents btnbuscarTermino As Button
    Friend WithEvents lblcodeT As Label
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents codigoListaPrecios As DataGridViewTextBoxColumn
    Friend WithEvents codigoGrupoItem As DataGridViewTextBoxColumn
    Friend WithEvents codigoDescuento As DataGridViewTextBoxColumn
    Friend WithEvents CodigoBreveDescuento As DataGridViewTextBoxColumn
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents rbtnEfectivoNo As RadioButton
    Friend WithEvents rbtnEfectivoSi As RadioButton
    Friend WithEvents lblSolicitaEfectivo As Label
End Class
