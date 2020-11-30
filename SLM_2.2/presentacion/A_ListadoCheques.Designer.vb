<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoCheques
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListadoCheques))
        Me.gbxCheque = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtCheques = New System.Windows.Forms.DataGridView()
        Me.ttBusqueda = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.gbxCheque.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxCheque
        '
        Me.gbxCheque.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxCheque.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxCheque.Controls.Add(Me.Button2)
        Me.gbxCheque.Controls.Add(Me.Button1)
        Me.gbxCheque.Controls.Add(Me.PictureBox1)
        Me.gbxCheque.Controls.Add(Me.dtpFin)
        Me.gbxCheque.Controls.Add(Me.Label4)
        Me.gbxCheque.Controls.Add(Me.dtpInicio)
        Me.gbxCheque.Controls.Add(Me.Label3)
        Me.gbxCheque.Controls.Add(Me.txtBanco)
        Me.gbxCheque.Controls.Add(Me.Label2)
        Me.gbxCheque.Controls.Add(Me.btnCancelar)
        Me.gbxCheque.Controls.Add(Me.txtBusqueda)
        Me.gbxCheque.Controls.Add(Me.Label1)
        Me.gbxCheque.Controls.Add(Me.dtCheques)
        Me.gbxCheque.Location = New System.Drawing.Point(9, 12)
        Me.gbxCheque.Name = "gbxCheque"
        Me.gbxCheque.Size = New System.Drawing.Size(921, 407)
        Me.gbxCheque.TabIndex = 0
        Me.gbxCheque.TabStop = False
        Me.gbxCheque.Text = "Cheques Generados"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(724, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 31)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Vista General"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(637, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Generar Vista"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(826, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(410, 50)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(97, 20)
        Me.dtpFin.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Fin:"
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(248, 49)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(97, 20)
        Me.dtpInicio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Inicio:"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(52, 49)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(119, 20)
        Me.txtBanco.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Banco:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(293, 24)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(20, 18)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(52, 23)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(236, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar: "
        '
        'dtCheques
        '
        Me.dtCheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCheques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtCheques.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtCheques.BackgroundColor = System.Drawing.Color.White
        Me.dtCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCheques.GridColor = System.Drawing.Color.White
        Me.dtCheques.Location = New System.Drawing.Point(3, 76)
        Me.dtCheques.Name = "dtCheques"
        Me.dtCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCheques.Size = New System.Drawing.Size(912, 325)
        Me.dtCheques.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(942, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_ListadoCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(942, 451)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gbxCheque)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "A_ListadoCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Cheques"
        Me.gbxCheque.ResumeLayout(False)
        Me.gbxCheque.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxCheque As GroupBox
    Friend WithEvents dtCheques As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ttBusqueda As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
