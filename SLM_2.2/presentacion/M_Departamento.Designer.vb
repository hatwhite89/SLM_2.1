<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Departamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Departamento))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.txtNombreB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.gbxcaja = New System.Windows.Forms.GroupBox()
        Me.txtnombreArea = New System.Windows.Forms.TextBox()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.txtcodigoArea = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblform = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxcaja.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.Controls.Add(Me.txtNombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Location = New System.Drawing.Point(13, 213)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(929, 402)
        Me.gbxbusqueda.TabIndex = 123
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR DEPARTAMENTO"
        '
        'txtNombreB
        '
        Me.txtNombreB.Location = New System.Drawing.Point(81, 27)
        Me.txtNombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreB.MaxLength = 200
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Size = New System.Drawing.Size(835, 22)
        Me.txtNombreB.TabIndex = 118
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(17, 30)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Nombre"
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(336, 380)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 66)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(919, 311)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 380)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(205, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE DEPARTAMENTOS"
        '
        'gbxcaja
        '
        Me.gbxcaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxcaja.Controls.Add(Me.txtnombreArea)
        Me.gbxcaja.Controls.Add(Me.btnArea)
        Me.gbxcaja.Controls.Add(Me.txtcodigoArea)
        Me.gbxcaja.Controls.Add(Me.Label11)
        Me.gbxcaja.Controls.Add(Me.lblnombre)
        Me.gbxcaja.Controls.Add(Me.txtnombre)
        Me.gbxcaja.Controls.Add(Me.lblcodigo)
        Me.gbxcaja.Controls.Add(Me.txtcodigo)
        Me.gbxcaja.Location = New System.Drawing.Point(8, 58)
        Me.gbxcaja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxcaja.Name = "gbxcaja"
        Me.gbxcaja.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxcaja.Size = New System.Drawing.Size(935, 150)
        Me.gbxcaja.TabIndex = 122
        Me.gbxcaja.TabStop = False
        Me.gbxcaja.Text = "REGISTRAR DEPARTAMENTO"
        '
        'txtnombreArea
        '
        Me.txtnombreArea.Location = New System.Drawing.Point(259, 60)
        Me.txtnombreArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreArea.Name = "txtnombreArea"
        Me.txtnombreArea.ReadOnly = True
        Me.txtnombreArea.Size = New System.Drawing.Size(657, 22)
        Me.txtnombreArea.TabIndex = 163
        '
        'btnArea
        '
        Me.btnArea.BackColor = System.Drawing.Color.White
        Me.btnArea.BackgroundImage = CType(resources.GetObject("btnArea.BackgroundImage"), System.Drawing.Image)
        Me.btnArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnArea.FlatAppearance.BorderSize = 0
        Me.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.Location = New System.Drawing.Point(61, 59)
        Me.btnArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(49, 22)
        Me.btnArea.TabIndex = 164
        Me.btnArea.Text = "..."
        Me.btnArea.UseVisualStyleBackColor = False
        '
        'txtcodigoArea
        '
        Me.txtcodigoArea.Location = New System.Drawing.Point(117, 60)
        Me.txtcodigoArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoArea.MaxLength = 20
        Me.txtcodigoArea.Name = "txtcodigoArea"
        Me.txtcodigoArea.Size = New System.Drawing.Size(120, 22)
        Me.txtcodigoArea.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Area"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(253, 22)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(58, 17)
        Me.lblnombre.TabIndex = 126
        Me.lblnombre.Text = "Nombre"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(323, 18)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.MaxLength = 150
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(593, 22)
        Me.txtnombre.TabIndex = 125
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(5, 18)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblcodigo.TabIndex = 115
        Me.lblcodigo.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(63, 18)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(175, 22)
        Me.txtcodigo.TabIndex = 114
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(751, 9)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 34)
        Me.btnmodificar.TabIndex = 111
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(852, 9)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(539, 9)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 110
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(649, 9)
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
        Me.lblform.Location = New System.Drawing.Point(373, 9)
        Me.lblform.Name = "lblform"
        Me.lblform.Size = New System.Drawing.Size(71, 17)
        Me.lblform.TabIndex = 127
        Me.lblform.Text = "formulario"
        Me.lblform.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 623)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 128
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 52)
        Me.Panel1.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Departamento"
        '
        'M_Departamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 645)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblform)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxcaja)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_Departamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SLM -"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxcaja.ResumeLayout(False)
        Me.gbxcaja.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtNombreB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents gbxcaja As GroupBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents lblform As Label
    Friend WithEvents txtnombreArea As TextBox
    Friend WithEvents btnArea As Button
    Friend WithEvents txtcodigoArea As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
