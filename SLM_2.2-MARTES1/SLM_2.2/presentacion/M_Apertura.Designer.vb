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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblcodeCajero = New System.Windows.Forms.Label()
        Me.lblcodeMaquinaLocal = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcodeCajero)
        Me.GroupBox1.Controls.Add(Me.lblcodeMaquinaLocal)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(931, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRAR APERTURA CAJA"
        '
        'lblcodeCajero
        '
        Me.lblcodeCajero.AutoSize = True
        Me.lblcodeCajero.Location = New System.Drawing.Point(315, 14)
        Me.lblcodeCajero.Name = "lblcodeCajero"
        Me.lblcodeCajero.Size = New System.Drawing.Size(16, 17)
        Me.lblcodeCajero.TabIndex = 127
        Me.lblcodeCajero.Text = "1"
        Me.lblcodeCajero.Visible = False
        '
        'lblcodeMaquinaLocal
        '
        Me.lblcodeMaquinaLocal.AutoSize = True
        Me.lblcodeMaquinaLocal.Location = New System.Drawing.Point(51, 17)
        Me.lblcodeMaquinaLocal.Name = "lblcodeMaquinaLocal"
        Me.lblcodeMaquinaLocal.Size = New System.Drawing.Size(67, 17)
        Me.lblcodeMaquinaLocal.TabIndex = 126
        Me.lblcodeMaquinaLocal.Text = "codeEsta"
        Me.lblcodeMaquinaLocal.Visible = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.Color.Black
        Me.btnnuevo.Location = New System.Drawing.Point(5, 191)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 125
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Location = New System.Drawing.Point(217, 191)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 124
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.Black
        Me.btnguardar.Location = New System.Drawing.Point(116, 191)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 123
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(696, 31)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(185, 22)
        Me.txtEstado.TabIndex = 122
        Me.txtEstado.Text = "Apertura"
        Me.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFondo
        '
        Me.txtFondo.Location = New System.Drawing.Point(696, 68)
        Me.txtFondo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFondo.Name = "txtFondo"
        Me.txtFondo.Size = New System.Drawing.Size(185, 22)
        Me.txtFondo.TabIndex = 121
        Me.txtFondo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(388, 69)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(185, 22)
        Me.txtHora.TabIndex = 120
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(105, 69)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(185, 22)
        Me.txtFecha.TabIndex = 119
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCajera
        '
        Me.txtCajera.Location = New System.Drawing.Point(388, 32)
        Me.txtCajera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCajera.Name = "txtCajera"
        Me.txtCajera.ReadOnly = True
        Me.txtCajera.Size = New System.Drawing.Size(185, 22)
        Me.txtCajera.TabIndex = 118
        Me.txtCajera.Text = "MEC"
        Me.txtCajera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaquinaLocal
        '
        Me.txtMaquinaLocal.Location = New System.Drawing.Point(105, 32)
        Me.txtMaquinaLocal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaquinaLocal.Name = "txtMaquinaLocal"
        Me.txtMaquinaLocal.ReadOnly = True
        Me.txtMaquinaLocal.Size = New System.Drawing.Size(185, 22)
        Me.txtMaquinaLocal.TabIndex = 117
        Me.txtMaquinaLocal.Text = "01_RD"
        Me.txtMaquinaLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(639, 31)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(52, 17)
        Me.lblEstado.TabIndex = 116
        Me.lblEstado.Text = "Estado"
        '
        'lblFondo
        '
        Me.lblFondo.AutoSize = True
        Me.lblFondo.Location = New System.Drawing.Point(641, 70)
        Me.lblFondo.Name = "lblFondo"
        Me.lblFondo.Size = New System.Drawing.Size(48, 17)
        Me.lblFondo.TabIndex = 115
        Me.lblFondo.Text = "Fondo"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(343, 70)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(39, 17)
        Me.lblHora.TabIndex = 114
        Me.lblHora.Text = "Hora"
        '
        'lblCajera
        '
        Me.lblCajera.AutoSize = True
        Me.lblCajera.Location = New System.Drawing.Point(315, 34)
        Me.lblCajera.Name = "lblCajera"
        Me.lblCajera.Size = New System.Drawing.Size(67, 17)
        Me.lblCajera.TabIndex = 113
        Me.lblCajera.Text = "Cajer(o)a"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(51, 71)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 17)
        Me.lblFecha.TabIndex = 112
        Me.lblFecha.Text = "Fecha"
        '
        'lblEstacion
        '
        Me.lblEstacion.AutoSize = True
        Me.lblEstacion.Location = New System.Drawing.Point(36, 34)
        Me.lblEstacion.Name = "lblEstacion"
        Me.lblEstacion.Size = New System.Drawing.Size(62, 17)
        Me.lblEstacion.TabIndex = 111
        Me.lblEstacion.Text = "Estacion"
        '
        'M_Apertura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 251)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_Apertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
