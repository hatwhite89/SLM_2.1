<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_ListarUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_ListarUnidades))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblbandera = New System.Windows.Forms.Label()
        Me.lblcodeItemExamenDet = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigoB = New System.Windows.Forms.TextBox()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lbltipoCta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtDescripcionB = New System.Windows.Forms.TextBox()
        Me.lblCodigoT = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxbusqueda.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxbusqueda.Controls.Add(Me.Button2)
        Me.gbxbusqueda.Controls.Add(Me.lblbandera)
        Me.gbxbusqueda.Controls.Add(Me.lblcodeItemExamenDet)
        Me.gbxbusqueda.Controls.Add(Me.Button1)
        Me.gbxbusqueda.Controls.Add(Me.lblNombre)
        Me.gbxbusqueda.Controls.Add(Me.txtCodigoB)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lbltipoCta)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtDescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lblCodigoT)
        Me.gbxbusqueda.Location = New System.Drawing.Point(15, 14)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(928, 607)
        Me.gbxbusqueda.TabIndex = 121
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR UNIDADES"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(821, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 123
        Me.Button2.Text = "Crear Nuevo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblbandera
        '
        Me.lblbandera.AutoSize = True
        Me.lblbandera.Location = New System.Drawing.Point(152, 66)
        Me.lblbandera.Name = "lblbandera"
        Me.lblbandera.Size = New System.Drawing.Size(51, 17)
        Me.lblbandera.TabIndex = 123
        Me.lblbandera.Text = "Label1"
        Me.lblbandera.Visible = False
        '
        'lblcodeItemExamenDet
        '
        Me.lblcodeItemExamenDet.AutoSize = True
        Me.lblcodeItemExamenDet.Location = New System.Drawing.Point(2, 67)
        Me.lblcodeItemExamenDet.Name = "lblcodeItemExamenDet"
        Me.lblcodeItemExamenDet.Size = New System.Drawing.Size(51, 17)
        Me.lblcodeItemExamenDet.TabIndex = 123
        Me.lblcodeItemExamenDet.Text = "Label1"
        Me.lblcodeItemExamenDet.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(821, 56)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Excel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(-23, 167)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 17)
        Me.lblNombre.TabIndex = 122
        Me.lblNombre.Text = "Label1"
        Me.lblNombre.Visible = False
        '
        'txtCodigoB
        '
        Me.txtCodigoB.Location = New System.Drawing.Point(111, 30)
        Me.txtCodigoB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Size = New System.Drawing.Size(192, 22)
        Me.txtCodigoB.TabIndex = 120
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
        Me.dgbtabla.Location = New System.Drawing.Point(5, 90)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(917, 484)
        Me.dgbtabla.TabIndex = 119
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(321, 32)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Nombre"
        '
        'lbltipoCta
        '
        Me.lbltipoCta.AutoSize = True
        Me.lbltipoCta.Location = New System.Drawing.Point(285, 182)
        Me.lbltipoCta.Name = "lbltipoCta"
        Me.lbltipoCta.Size = New System.Drawing.Size(0, 17)
        Me.lbltipoCta.TabIndex = 116
        Me.lbltipoCta.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(333, 576)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 576)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(151, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE UNIDADES"
        '
        'txtDescripcionB
        '
        Me.txtDescripcionB.Location = New System.Drawing.Point(385, 30)
        Me.txtDescripcionB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionB.MaxLength = 80
        Me.txtDescripcionB.Name = "txtDescripcionB"
        Me.txtDescripcionB.Size = New System.Drawing.Size(403, 22)
        Me.txtDescripcionB.TabIndex = 115
        '
        'lblCodigoT
        '
        Me.lblCodigoT.AutoSize = True
        Me.lblCodigoT.Location = New System.Drawing.Point(39, 33)
        Me.lblCodigoT.Name = "lblCodigoT"
        Me.lblCodigoT.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigoT.TabIndex = 114
        Me.lblCodigoT.Text = "Código"
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(-8, 144)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(51, 17)
        Me.lblFila.TabIndex = 121
        Me.lblFila.Text = "Label1"
        Me.lblFila.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 632)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 122
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'E_ListarUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(957, 654)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblFila)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "E_ListarUnidades"
        Me.Text = "SLM"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtCodigoB As TextBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lbltipoCta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtDescripcionB As TextBox
    Friend WithEvents lblCodigoT As Label
    Friend WithEvents lblFila As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents lblcodeItemExamenDet As Label
    Friend WithEvents lblbandera As Label
    Friend WithEvents Button2 As Button
End Class
