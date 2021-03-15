<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Apertura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Apertura))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lblcodeCajero = New System.Windows.Forms.Label()
        Me.lblcodeMaquinaLocal = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtFondo = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtCajera = New System.Windows.Forms.TextBox()
        Me.txtMaquinaLocal = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblFondo = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblCajera = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblEstacion = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label62)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.Label59)
        Me.GroupBox1.Controls.Add(Me.lblcodeCajero)
        Me.GroupBox1.Controls.Add(Me.lblcodeMaquinaLocal)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtFondo)
        Me.GroupBox1.Controls.Add(Me.txtHora)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtCajera)
        Me.GroupBox1.Controls.Add(Me.txtMaquinaLocal)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Controls.Add(Me.lblFondo)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.Controls.Add(Me.lblCajera)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.lblEstacion)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(698, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRAR APERTURA CAJA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(466, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "*"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(60, 130)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(173, 13)
        Me.Label62.TabIndex = 213
        Me.Label62.Text = "Debe llenar uno de los dos campos"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(60, 100)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(101, 13)
        Me.Label61.TabIndex = 212
        Me.Label61.Text = "Campos obligatorios"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(46, 102)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(11, 13)
        Me.Label60.TabIndex = 211
        Me.Label60.Text = "*"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.Red
        Me.Label59.Location = New System.Drawing.Point(44, 130)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(17, 13)
        Me.Label59.TabIndex = 210
        Me.Label59.Text = "(*)"
        '
        'lblcodeCajero
        '
        Me.lblcodeCajero.AutoSize = True
        Me.lblcodeCajero.Location = New System.Drawing.Point(236, 11)
        Me.lblcodeCajero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeCajero.Name = "lblcodeCajero"
        Me.lblcodeCajero.Size = New System.Drawing.Size(13, 13)
        Me.lblcodeCajero.TabIndex = 127
        Me.lblcodeCajero.Text = "1"
        Me.lblcodeCajero.Visible = False
        '
        'lblcodeMaquinaLocal
        '
        Me.lblcodeMaquinaLocal.AutoSize = True
        Me.lblcodeMaquinaLocal.Location = New System.Drawing.Point(38, 14)
        Me.lblcodeMaquinaLocal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodeMaquinaLocal.Name = "lblcodeMaquinaLocal"
        Me.lblcodeMaquinaLocal.Size = New System.Drawing.Size(52, 13)
        Me.lblcodeMaquinaLocal.TabIndex = 126
        Me.lblcodeMaquinaLocal.Text = "codeEsta"
        Me.lblcodeMaquinaLocal.Visible = False
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(522, 25)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(140, 20)
        Me.txtEstado.TabIndex = 122
        Me.txtEstado.Text = "Apertura"
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFondo
        '
        Me.txtFondo.Location = New System.Drawing.Point(522, 55)
        Me.txtFondo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFondo.Name = "txtFondo"
        Me.txtFondo.Size = New System.Drawing.Size(140, 20)
        Me.txtFondo.TabIndex = 121
        Me.txtFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(291, 56)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(140, 20)
        Me.txtHora.TabIndex = 120
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(79, 56)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(140, 20)
        Me.txtFecha.TabIndex = 119
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCajera
        '
        Me.txtCajera.Location = New System.Drawing.Point(291, 26)
        Me.txtCajera.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCajera.Name = "txtCajera"
        Me.txtCajera.ReadOnly = True
        Me.txtCajera.Size = New System.Drawing.Size(140, 20)
        Me.txtCajera.TabIndex = 118
        Me.txtCajera.Text = "MEC"
        Me.txtCajera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaquinaLocal
        '
        Me.txtMaquinaLocal.Location = New System.Drawing.Point(79, 26)
        Me.txtMaquinaLocal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaquinaLocal.Name = "txtMaquinaLocal"
        Me.txtMaquinaLocal.ReadOnly = True
        Me.txtMaquinaLocal.Size = New System.Drawing.Size(140, 20)
        Me.txtMaquinaLocal.TabIndex = 117
        Me.txtMaquinaLocal.Text = "01_RD"
        Me.txtMaquinaLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(479, 25)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 116
        Me.lblEstado.Text = "Estado"
        '
        'lblFondo
        '
        Me.lblFondo.AutoSize = True
        Me.lblFondo.Location = New System.Drawing.Point(481, 57)
        Me.lblFondo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFondo.Name = "lblFondo"
        Me.lblFondo.Size = New System.Drawing.Size(37, 13)
        Me.lblFondo.TabIndex = 115
        Me.lblFondo.Text = "Fondo"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(257, 57)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 114
        Me.lblHora.Text = "Hora"
        '
        'lblCajera
        '
        Me.lblCajera.AutoSize = True
        Me.lblCajera.Location = New System.Drawing.Point(236, 28)
        Me.lblCajera.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCajera.Name = "lblCajera"
        Me.lblCajera.Size = New System.Drawing.Size(49, 13)
        Me.lblCajera.TabIndex = 113
        Me.lblCajera.Text = "Cajer(o)a"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(38, 58)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 112
        Me.lblFecha.Text = "Fecha"
        '
        'lblEstacion
        '
        Me.lblEstacion.AutoSize = True
        Me.lblEstacion.Location = New System.Drawing.Point(27, 28)
        Me.lblEstacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstacion.Name = "lblEstacion"
        Me.lblEstacion.Size = New System.Drawing.Size(48, 13)
        Me.lblEstacion.TabIndex = 111
        Me.lblEstacion.Text = "Estacion"
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(477, 10)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 125
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(636, 10)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 124
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(560, 10)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 123
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 230)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnnuevo)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 44)
        Me.Panel1.TabIndex = 2
        '
        'M_Apertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 252)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Apertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtFondo As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtCajera As TextBox
    Friend WithEvents txtMaquinaLocal As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblFondo As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblCajera As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblEstacion As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents lblcodeCajero As Label
    Friend WithEvents lblcodeMaquinaLocal As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label59 As Label
End Class
