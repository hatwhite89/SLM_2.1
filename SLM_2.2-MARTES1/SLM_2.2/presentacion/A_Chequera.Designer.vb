<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_Chequera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Chequera))
        Me.gbxInfoChequeras = New System.Windows.Forms.GroupBox()
        Me.lblCodBanco = New System.Windows.Forms.Label()
        Me.lblCodCuenta = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mtxtNumInicio = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCtaDestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodChequera = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtChequeras = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.gbxInfoChequeras.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtChequeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInfoChequeras
        '
        Me.gbxInfoChequeras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxInfoChequeras.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbxInfoChequeras.Controls.Add(Me.lblCodBanco)
        Me.gbxInfoChequeras.Controls.Add(Me.lblCodCuenta)
        Me.gbxInfoChequeras.Controls.Add(Me.Button1)
        Me.gbxInfoChequeras.Controls.Add(Me.mtxtNumInicio)
        Me.gbxInfoChequeras.Controls.Add(Me.btnBuscar)
        Me.gbxInfoChequeras.Controls.Add(Me.txtBanco)
        Me.gbxInfoChequeras.Controls.Add(Me.Label5)
        Me.gbxInfoChequeras.Controls.Add(Me.txtCantidad)
        Me.gbxInfoChequeras.Controls.Add(Me.Label4)
        Me.gbxInfoChequeras.Controls.Add(Me.Label3)
        Me.gbxInfoChequeras.Controls.Add(Me.txtCtaDestino)
        Me.gbxInfoChequeras.Controls.Add(Me.Label2)
        Me.gbxInfoChequeras.Controls.Add(Me.txtCodChequera)
        Me.gbxInfoChequeras.Controls.Add(Me.Label1)
        Me.gbxInfoChequeras.Location = New System.Drawing.Point(12, 49)
        Me.gbxInfoChequeras.Name = "gbxInfoChequeras"
        Me.gbxInfoChequeras.Size = New System.Drawing.Size(694, 112)
        Me.gbxInfoChequeras.TabIndex = 0
        Me.gbxInfoChequeras.TabStop = False
        Me.gbxInfoChequeras.Text = "Información de Chequera"
        '
        'lblCodBanco
        '
        Me.lblCodBanco.AutoSize = True
        Me.lblCodBanco.Location = New System.Drawing.Point(421, 55)
        Me.lblCodBanco.Name = "lblCodBanco"
        Me.lblCodBanco.Size = New System.Drawing.Size(67, 13)
        Me.lblCodBanco.TabIndex = 17
        Me.lblCodBanco.Text = "lblCodBanco"
        '
        'lblCodCuenta
        '
        Me.lblCodCuenta.AutoSize = True
        Me.lblCodCuenta.Location = New System.Drawing.Point(421, 35)
        Me.lblCodCuenta.Name = "lblCodCuenta"
        Me.lblCodCuenta.Size = New System.Drawing.Size(70, 13)
        Me.lblCodCuenta.TabIndex = 16
        Me.lblCodCuenta.Text = "lblCodCuenta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(137, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 17)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mtxtNumInicio
        '
        Me.mtxtNumInicio.Location = New System.Drawing.Point(92, 78)
        Me.mtxtNumInicio.Mask = "00000000"
        Me.mtxtNumInicio.Name = "mtxtNumInicio"
        Me.mtxtNumInicio.Size = New System.Drawing.Size(70, 20)
        Me.mtxtNumInicio.TabIndex = 14
        Me.mtxtNumInicio.Text = "00000000"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(302, 54)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 17)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(257, 53)
        Me.txtBanco.MaxLength = 10
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(42, 20)
        Me.txtBanco.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Banco"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(257, 27)
        Me.txtCantidad.MaxLength = 3
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(70, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Numero Inicio"
        '
        'txtCtaDestino
        '
        Me.txtCtaDestino.Location = New System.Drawing.Point(92, 52)
        Me.txtCtaDestino.MaxLength = 6
        Me.txtCtaDestino.Name = "txtCtaDestino"
        Me.txtCtaDestino.Size = New System.Drawing.Size(42, 20)
        Me.txtCtaDestino.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cuenta Destino"
        '
        'txtCodChequera
        '
        Me.txtCodChequera.Enabled = False
        Me.txtCodChequera.Location = New System.Drawing.Point(92, 27)
        Me.txtCodChequera.MaxLength = 50
        Me.txtCodChequera.Name = "txtCodChequera"
        Me.txtCodChequera.Size = New System.Drawing.Size(70, 20)
        Me.txtCodChequera.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cód. Chequera"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(632, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Ejecutar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.dtChequeras)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 220)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Chequeras"
        '
        'dtChequeras
        '
        Me.dtChequeras.AllowUserToAddRows = False
        Me.dtChequeras.AllowUserToDeleteRows = False
        Me.dtChequeras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtChequeras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtChequeras.BackgroundColor = System.Drawing.Color.White
        Me.dtChequeras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtChequeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtChequeras.GridColor = System.Drawing.Color.White
        Me.dtChequeras.Location = New System.Drawing.Point(6, 19)
        Me.dtChequeras.Name = "dtChequeras"
        Me.dtChequeras.ReadOnly = True
        Me.dtChequeras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtChequeras.Size = New System.Drawing.Size(682, 195)
        Me.dtChequeras.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 44)
        Me.Panel1.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Generar Chequera"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_Chequera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 411)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoChequeras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "A_Chequera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Chequera"
        Me.gbxInfoChequeras.ResumeLayout(False)
        Me.gbxInfoChequeras.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtChequeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxInfoChequeras As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtChequeras As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCtaDestino As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodChequera As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents mtxtNumInicio As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblCodBanco As Label
    Friend WithEvents lblCodCuenta As Label
End Class
