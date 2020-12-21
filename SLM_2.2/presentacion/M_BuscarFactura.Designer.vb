<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_BuscarFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_BuscarFactura))
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtnumeroB = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltipoCta = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnumeroB = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.gbxbusqueda.Controls.Add(Me.Button4)
        Me.gbxbusqueda.Controls.Add(Me.Button3)
        Me.gbxbusqueda.Controls.Add(Me.Button2)
        Me.gbxbusqueda.Controls.Add(Me.Button1)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.btnnueva)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.txtnumeroB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltipoCta)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnumeroB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(12, 12)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(931, 613)
        Me.gbxbusqueda.TabIndex = 117
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR FACTURA"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(149, 14)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 123
        Me.Button3.Text = "Arqueo"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(389, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "Cierre Caja"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 583)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(154, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE FACTURAS"
        '
        'btnnueva
        '
        Me.btnnueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnueva.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.Color.White
        Me.btnnueva.Location = New System.Drawing.Point(707, 14)
        Me.btnnueva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(219, 34)
        Me.btnnueva.TabIndex = 120
        Me.btnnueva.Text = "Nueva Factura"
        Me.btnnueva.UseVisualStyleBackColor = False
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(233, 583)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'txtnumeroB
        '
        Me.txtnumeroB.Location = New System.Drawing.Point(72, 54)
        Me.txtnumeroB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnumeroB.MaxLength = 20
        Me.txtnumeroB.Name = "txtnumeroB"
        Me.txtnumeroB.Size = New System.Drawing.Size(279, 22)
        Me.txtnumeroB.TabIndex = 118
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(377, 57)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Nombre"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbtabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(8, 84)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersVisible = False
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(917, 480)
        Me.dgbtabla.TabIndex = 119
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
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(455, 53)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreB.MaxLength = 80
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(469, 22)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnumeroB
        '
        Me.lblnumeroB.AutoSize = True
        Me.lblnumeroB.Location = New System.Drawing.Point(11, 57)
        Me.lblnumeroB.Name = "lblnumeroB"
        Me.lblnumeroB.Size = New System.Drawing.Size(58, 17)
        Me.lblnumeroB.TabIndex = 114
        Me.lblnumeroB.Text = "Número"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 645)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 22)
        Me.StatusStrip1.TabIndex = 118
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(528, 14)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 23)
        Me.Button4.TabIndex = 124
        Me.Button4.Text = "ColaPacientes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'M_BuscarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 667)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_BuscarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Facturas"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtnumeroB As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lbltipoCta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnumeroB As Label
    Friend WithEvents btnnueva As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Button4 As Button
End Class
