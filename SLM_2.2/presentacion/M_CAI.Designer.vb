<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_CAI
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
        Me.lblCAI = New System.Windows.Forms.Label()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.lblhasta = New System.Windows.Forms.Label()
        Me.lblDesdeF = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.mtxtCAI = New System.Windows.Forms.MaskedTextBox()
        Me.lblhastaF = New System.Windows.Forms.Label()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.lblmaquinaLocal = New System.Windows.Forms.Label()
        Me.dtpDesdeFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpHastaFecha = New System.Windows.Forms.DateTimePicker()
        Me.mtxtserie = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtdesde = New System.Windows.Forms.MaskedTextBox()
        Me.mtxthasta = New System.Windows.Forms.MaskedTextBox()
        Me.txtdescripcionMaquina = New System.Windows.Forms.TextBox()
        Me.btnbuscarMaquinaLocal = New System.Windows.Forms.Button()
        Me.txtcodigoMaquina = New System.Windows.Forms.TextBox()
        Me.lblCodeMaquinaLocal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCAI
        '
        Me.lblCAI.AutoSize = True
        Me.lblCAI.Location = New System.Drawing.Point(93, 36)
        Me.lblCAI.Name = "lblCAI"
        Me.lblCAI.Size = New System.Drawing.Size(33, 17)
        Me.lblCAI.TabIndex = 0
        Me.lblCAI.Text = "CAI:"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(60, 98)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(53, 17)
        Me.lbldesde.TabIndex = 1
        Me.lbldesde.Text = "Desde:"
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.Location = New System.Drawing.Point(415, 107)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(49, 17)
        Me.lblhasta.TabIndex = 2
        Me.lblhasta.Text = "Hasta:"
        '
        'lblDesdeF
        '
        Me.lblDesdeF.AutoSize = True
        Me.lblDesdeF.Location = New System.Drawing.Point(31, 74)
        Me.lblDesdeF.Name = "lblDesdeF"
        Me.lblDesdeF.Size = New System.Drawing.Size(96, 17)
        Me.lblDesdeF.TabIndex = 3
        Me.lblDesdeF.Text = "Desde Fecha:"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(369, 212)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(91, 34)
        Me.btncancelar.TabIndex = 112
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(15, 220)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(105, 34)
        Me.btnnuevo.TabIndex = 114
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(125, 220)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(96, 34)
        Me.btnguardar.TabIndex = 113
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'mtxtCAI
        '
        Me.mtxtCAI.Location = New System.Drawing.Point(141, 33)
        Me.mtxtCAI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxtCAI.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA-AAAAAA-AA"
        Me.mtxtCAI.Name = "mtxtCAI"
        Me.mtxtCAI.Size = New System.Drawing.Size(532, 22)
        Me.mtxtCAI.TabIndex = 116
        Me.mtxtCAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblhastaF
        '
        Me.lblhastaF.AutoSize = True
        Me.lblhastaF.Location = New System.Drawing.Point(376, 74)
        Me.lblhastaF.Name = "lblhastaF"
        Me.lblhastaF.Size = New System.Drawing.Size(92, 17)
        Me.lblhastaF.TabIndex = 117
        Me.lblhastaF.Text = "Hasta Fecha:"
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(415, 143)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(45, 17)
        Me.lblserie.TabIndex = 118
        Me.lblserie.Text = "Serie:"
        '
        'lblmaquinaLocal
        '
        Me.lblmaquinaLocal.AutoSize = True
        Me.lblmaquinaLocal.Location = New System.Drawing.Point(23, 151)
        Me.lblmaquinaLocal.Name = "lblmaquinaLocal"
        Me.lblmaquinaLocal.Size = New System.Drawing.Size(104, 17)
        Me.lblmaquinaLocal.TabIndex = 119
        Me.lblmaquinaLocal.Text = "Máquina Local:"
        '
        'dtpDesdeFecha
        '
        Me.dtpDesdeFecha.Location = New System.Drawing.Point(141, 74)
        Me.dtpDesdeFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDesdeFecha.Name = "dtpDesdeFecha"
        Me.dtpDesdeFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpDesdeFecha.TabIndex = 120
        '
        'dtpHastaFecha
        '
        Me.dtpHastaFecha.Location = New System.Drawing.Point(475, 74)
        Me.dtpHastaFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpHastaFecha.Name = "dtpHastaFecha"
        Me.dtpHastaFecha.Size = New System.Drawing.Size(200, 22)
        Me.dtpHastaFecha.TabIndex = 121
        '
        'mtxtserie
        '
        Me.mtxtserie.Location = New System.Drawing.Point(467, 139)
        Me.mtxtserie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxtserie.Mask = "000-000-00-"
        Me.mtxtserie.Name = "mtxtserie"
        Me.mtxtserie.Size = New System.Drawing.Size(201, 22)
        Me.mtxtserie.TabIndex = 122
        Me.mtxtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtdesde
        '
        Me.mtxtdesde.Location = New System.Drawing.Point(135, 98)
        Me.mtxtdesde.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxtdesde.Mask = "00000000"
        Me.mtxtdesde.Name = "mtxtdesde"
        Me.mtxtdesde.Size = New System.Drawing.Size(201, 22)
        Me.mtxtdesde.TabIndex = 123
        Me.mtxtdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxthasta
        '
        Me.mtxthasta.Location = New System.Drawing.Point(468, 103)
        Me.mtxthasta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mtxthasta.Mask = "00000000"
        Me.mtxthasta.Name = "mtxthasta"
        Me.mtxthasta.Size = New System.Drawing.Size(200, 22)
        Me.mtxthasta.TabIndex = 124
        Me.mtxthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescripcionMaquina
        '
        Me.txtdescripcionMaquina.Location = New System.Drawing.Point(176, 183)
        Me.txtdescripcionMaquina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescripcionMaquina.Name = "txtdescripcionMaquina"
        Me.txtdescripcionMaquina.ReadOnly = True
        Me.txtdescripcionMaquina.Size = New System.Drawing.Size(166, 22)
        Me.txtdescripcionMaquina.TabIndex = 127
        '
        'btnbuscarMaquinaLocal
        '
        Me.btnbuscarMaquinaLocal.BackColor = System.Drawing.Color.White
        Me.btnbuscarMaquinaLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarMaquinaLocal.FlatAppearance.BorderSize = 0
        Me.btnbuscarMaquinaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarMaquinaLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarMaquinaLocal.Location = New System.Drawing.Point(141, 183)
        Me.btnbuscarMaquinaLocal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnbuscarMaquinaLocal.Name = "btnbuscarMaquinaLocal"
        Me.btnbuscarMaquinaLocal.Size = New System.Drawing.Size(29, 22)
        Me.btnbuscarMaquinaLocal.TabIndex = 126
        Me.btnbuscarMaquinaLocal.Text = "..."
        Me.btnbuscarMaquinaLocal.UseVisualStyleBackColor = False
        '
        'txtcodigoMaquina
        '
        Me.txtcodigoMaquina.Location = New System.Drawing.Point(141, 148)
        Me.txtcodigoMaquina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigoMaquina.MaxLength = 20
        Me.txtcodigoMaquina.Name = "txtcodigoMaquina"
        Me.txtcodigoMaquina.Size = New System.Drawing.Size(201, 22)
        Me.txtcodigoMaquina.TabIndex = 125
        Me.txtcodigoMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCodeMaquinaLocal
        '
        Me.lblCodeMaquinaLocal.AutoSize = True
        Me.lblCodeMaquinaLocal.Location = New System.Drawing.Point(43, 206)
        Me.lblCodeMaquinaLocal.Name = "lblCodeMaquinaLocal"
        Me.lblCodeMaquinaLocal.Size = New System.Drawing.Size(0, 17)
        Me.lblCodeMaquinaLocal.TabIndex = 128
        Me.lblCodeMaquinaLocal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.mtxtserie)
        Me.GroupBox1.Controls.Add(Me.lblserie)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.mtxtdesde)
        Me.GroupBox1.Controls.Add(Me.mtxthasta)
        Me.GroupBox1.Controls.Add(Me.lblhasta)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(937, 265)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAI"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(25, 27)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(50, 17)
        Me.lblCodigo.TabIndex = 131
        Me.lblCodigo.Text = "codigo"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(221, 212)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(143, 34)
        Me.btnModificar.TabIndex = 130
        Me.btnModificar.Text = "Modificar Estado"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(468, 178)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(151, 21)
        Me.chkEstado.TabIndex = 125
        Me.chkEstado.Text = "Activar Facturación"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'M_CAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(959, 283)
        Me.Controls.Add(Me.lblCodeMaquinaLocal)
        Me.Controls.Add(Me.txtdescripcionMaquina)
        Me.Controls.Add(Me.btnbuscarMaquinaLocal)
        Me.Controls.Add(Me.txtcodigoMaquina)
        Me.Controls.Add(Me.dtpHastaFecha)
        Me.Controls.Add(Me.dtpDesdeFecha)
        Me.Controls.Add(Me.lblmaquinaLocal)
        Me.Controls.Add(Me.lblhastaF)
        Me.Controls.Add(Me.mtxtCAI)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.lblDesdeF)
        Me.Controls.Add(Me.lblCAI)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_CAI"
        Me.Text = "CAI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCAI As Label
    Friend WithEvents lbldesde As Label
    Friend WithEvents lblhasta As Label
    Friend WithEvents lblDesdeF As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents mtxtCAI As MaskedTextBox
    Friend WithEvents lblhastaF As Label
    Friend WithEvents lblserie As Label
    Friend WithEvents lblmaquinaLocal As Label
    Friend WithEvents dtpDesdeFecha As DateTimePicker
    Friend WithEvents dtpHastaFecha As DateTimePicker
    Friend WithEvents mtxtserie As MaskedTextBox
    Friend WithEvents mtxtdesde As MaskedTextBox
    Friend WithEvents mtxthasta As MaskedTextBox
    Friend WithEvents txtdescripcionMaquina As TextBox
    Friend WithEvents btnbuscarMaquinaLocal As Button
    Friend WithEvents txtcodigoMaquina As TextBox
    Friend WithEvents lblCodeMaquinaLocal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblCodigo As Label
End Class
