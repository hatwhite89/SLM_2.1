<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Precio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Precio))
        Me.gbxPrecio = New System.Windows.Forms.GroupBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtdescripcionListaPrecios = New System.Windows.Forms.TextBox()
        Me.txtdescripcionItem = New System.Windows.Forms.TextBox()
        Me.btnBuscarListaPrecios = New System.Windows.Forms.Button()
        Me.btnbuscarItem = New System.Windows.Forms.Button()
        Me.txtcodigoListaPrecios = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtcodigoItem = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblListaPrecios = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtCodigoB = New System.Windows.Forms.TextBox()
        Me.lblcodigoB = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbxPrecio.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPrecio
        '
        Me.gbxPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxPrecio.Controls.Add(Me.lblCode)
        Me.gbxPrecio.Controls.Add(Me.txtdescripcionListaPrecios)
        Me.gbxPrecio.Controls.Add(Me.txtdescripcionItem)
        Me.gbxPrecio.Controls.Add(Me.btnBuscarListaPrecios)
        Me.gbxPrecio.Controls.Add(Me.btnbuscarItem)
        Me.gbxPrecio.Controls.Add(Me.txtcodigoListaPrecios)
        Me.gbxPrecio.Controls.Add(Me.txtPrecio)
        Me.gbxPrecio.Controls.Add(Me.txtcodigoItem)
        Me.gbxPrecio.Controls.Add(Me.txtcodigo)
        Me.gbxPrecio.Controls.Add(Me.lblPrecio)
        Me.gbxPrecio.Controls.Add(Me.lblListaPrecios)
        Me.gbxPrecio.Controls.Add(Me.lblItem)
        Me.gbxPrecio.Controls.Add(Me.lblcodigo)
        Me.gbxPrecio.Location = New System.Drawing.Point(11, 51)
        Me.gbxPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxPrecio.Name = "gbxPrecio"
        Me.gbxPrecio.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxPrecio.Size = New System.Drawing.Size(696, 129)
        Me.gbxPrecio.TabIndex = 119
        Me.gbxPrecio.TabStop = False
        Me.gbxPrecio.Text = "REGISTRAR PRECIO"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(14, 105)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(0, 13)
        Me.lblCode.TabIndex = 138
        Me.lblCode.Visible = False
        '
        'txtdescripcionListaPrecios
        '
        Me.txtdescripcionListaPrecios.Location = New System.Drawing.Point(433, 57)
        Me.txtdescripcionListaPrecios.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcionListaPrecios.Name = "txtdescripcionListaPrecios"
        Me.txtdescripcionListaPrecios.ReadOnly = True
        Me.txtdescripcionListaPrecios.Size = New System.Drawing.Size(205, 20)
        Me.txtdescripcionListaPrecios.TabIndex = 137
        '
        'txtdescripcionItem
        '
        Me.txtdescripcionItem.Location = New System.Drawing.Point(435, 21)
        Me.txtdescripcionItem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcionItem.Name = "txtdescripcionItem"
        Me.txtdescripcionItem.ReadOnly = True
        Me.txtdescripcionItem.Size = New System.Drawing.Size(205, 20)
        Me.txtdescripcionItem.TabIndex = 132
        '
        'btnBuscarListaPrecios
        '
        Me.btnBuscarListaPrecios.BackColor = System.Drawing.Color.White
        Me.btnBuscarListaPrecios.BackgroundImage = CType(resources.GetObject("btnBuscarListaPrecios.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarListaPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarListaPrecios.FlatAppearance.BorderSize = 0
        Me.btnBuscarListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarListaPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarListaPrecios.Location = New System.Drawing.Point(321, 57)
        Me.btnBuscarListaPrecios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarListaPrecios.Name = "btnBuscarListaPrecios"
        Me.btnBuscarListaPrecios.Size = New System.Drawing.Size(37, 18)
        Me.btnBuscarListaPrecios.TabIndex = 136
        Me.btnBuscarListaPrecios.Text = "..."
        Me.btnBuscarListaPrecios.UseVisualStyleBackColor = False
        '
        'btnbuscarItem
        '
        Me.btnbuscarItem.BackColor = System.Drawing.Color.White
        Me.btnbuscarItem.BackgroundImage = CType(resources.GetObject("btnbuscarItem.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarItem.FlatAppearance.BorderSize = 0
        Me.btnbuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarItem.Location = New System.Drawing.Point(323, 21)
        Me.btnbuscarItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscarItem.Name = "btnbuscarItem"
        Me.btnbuscarItem.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarItem.TabIndex = 135
        Me.btnbuscarItem.Text = "..."
        Me.btnbuscarItem.UseVisualStyleBackColor = False
        '
        'txtcodigoListaPrecios
        '
        Me.txtcodigoListaPrecios.Location = New System.Drawing.Point(362, 58)
        Me.txtcodigoListaPrecios.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoListaPrecios.MaxLength = 20
        Me.txtcodigoListaPrecios.Name = "txtcodigoListaPrecios"
        Me.txtcodigoListaPrecios.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoListaPrecios.TabIndex = 134
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(58, 60)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecio.MaxLength = 20
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(138, 20)
        Me.txtPrecio.TabIndex = 133
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigoItem
        '
        Me.txtcodigoItem.Location = New System.Drawing.Point(364, 21)
        Me.txtcodigoItem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoItem.MaxLength = 20
        Me.txtcodigoItem.Name = "txtcodigoItem"
        Me.txtcodigoItem.Size = New System.Drawing.Size(67, 20)
        Me.txtcodigoItem.TabIndex = 132
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(58, 22)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(138, 20)
        Me.txtcodigo.TabIndex = 120
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(8, 60)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 131
        Me.lblPrecio.Text = "Precio"
        '
        'lblListaPrecios
        '
        Me.lblListaPrecios.AutoSize = True
        Me.lblListaPrecios.Location = New System.Drawing.Point(240, 60)
        Me.lblListaPrecios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListaPrecios.Name = "lblListaPrecios"
        Me.lblListaPrecios.Size = New System.Drawing.Size(67, 13)
        Me.lblListaPrecios.TabIndex = 130
        Me.lblListaPrecios.Text = "Lista Precios"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(282, 21)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(27, 13)
        Me.lblItem.TabIndex = 126
        Me.lblItem.Text = "Item"
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.Yellow
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.Black
        Me.btnmodificar.Location = New System.Drawing.Point(564, 11)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 114
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(405, 11)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 113
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(488, 11)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 112
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(5, 24)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 41
        Me.lblcodigo.Text = "Código"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(640, 11)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 37
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.btnImportar)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtCodigoB)
        Me.gbxbusqueda.Controls.Add(Me.lblcodigoB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 184)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 297)
        Me.gbxbusqueda.TabIndex = 118
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR PRECIO"
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnImportar.FlatAppearance.BorderSize = 0
        Me.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportar.ForeColor = System.Drawing.Color.White
        Me.btnImportar.Location = New System.Drawing.Point(604, 17)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(75, 23)
        Me.btnImportar.TabIndex = 116
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(198, 273)
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
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 54)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(688, 204)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(8, 273)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(110, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE PRECIOS"
        '
        'txtCodigoB
        '
        Me.txtCodigoB.Location = New System.Drawing.Point(68, 17)
        Me.txtCodigoB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoB.MaxLength = 100
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Size = New System.Drawing.Size(145, 20)
        Me.txtCodigoB.TabIndex = 115
        '
        'lblcodigoB
        '
        Me.lblcodigoB.AutoSize = True
        Me.lblcodigoB.Location = New System.Drawing.Point(15, 17)
        Me.lblcodigoB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigoB.Name = "lblcodigoB"
        Me.lblcodigoB.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigoB.TabIndex = 114
        Me.lblcodigoB.Text = "Código"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(715, 22)
        Me.StatusStrip1.TabIndex = 120
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 46)
        Me.Panel1.TabIndex = 121
        '
        'M_Precio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(715, 505)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxPrecio)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "M_Precio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precios"
        Me.gbxPrecio.ResumeLayout(False)
        Me.gbxPrecio.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxPrecio As GroupBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblListaPrecios As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents lblcodigo As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtCodigoB As TextBox
    Friend WithEvents lblcodigoB As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtcodigoItem As TextBox
    Friend WithEvents txtcodigoListaPrecios As TextBox
    Friend WithEvents btnBuscarListaPrecios As Button
    Friend WithEvents btnbuscarItem As Button
    Friend WithEvents txtdescripcionListaPrecios As TextBox
    Friend WithEvents txtdescripcionItem As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents btnImportar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
End Class
