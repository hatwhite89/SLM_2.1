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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_CAI))
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCAI
        '
        Me.lblCAI.AutoSize = True
        Me.lblCAI.Location = New System.Drawing.Point(83, 29)
        Me.lblCAI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCAI.Name = "lblCAI"
        Me.lblCAI.Size = New System.Drawing.Size(27, 13)
        Me.lblCAI.TabIndex = 0
        Me.lblCAI.Text = "CAI:"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(58, 80)
        Me.lbldesde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(41, 13)
        Me.lbldesde.TabIndex = 1
        Me.lbldesde.Text = "Desde:"
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.Location = New System.Drawing.Point(325, 87)
        Me.lblhasta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(38, 13)
        Me.lblhasta.TabIndex = 2
        Me.lblhasta.Text = "Hasta:"
        '
        'lblDesdeF
        '
        Me.lblDesdeF.AutoSize = True
        Me.lblDesdeF.Location = New System.Drawing.Point(32, 52)
        Me.lblDesdeF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesdeF.Name = "lblDesdeF"
        Me.lblDesdeF.Size = New System.Drawing.Size(74, 13)
        Me.lblDesdeF.TabIndex = 3
        Me.lblDesdeF.Text = "Desde Fecha:"
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.LightSalmon
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(646, 6)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 112
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnuevo.BackColor = System.Drawing.Color.White
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(376, 6)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 114
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnguardar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(459, 6)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 113
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'mtxtCAI
        '
        Me.mtxtCAI.Location = New System.Drawing.Point(115, 22)
        Me.mtxtCAI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtCAI.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA-AAAAAA-AA"
        Me.mtxtCAI.Name = "mtxtCAI"
        Me.mtxtCAI.Size = New System.Drawing.Size(400, 20)
        Me.mtxtCAI.TabIndex = 116
        Me.mtxtCAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblhastaF
        '
        Me.lblhastaF.AutoSize = True
        Me.lblhastaF.Location = New System.Drawing.Point(287, 53)
        Me.lblhastaF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhastaF.Name = "lblhastaF"
        Me.lblhastaF.Size = New System.Drawing.Size(71, 13)
        Me.lblhastaF.TabIndex = 117
        Me.lblhastaF.Text = "Hasta Fecha:"
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(325, 116)
        Me.lblserie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 118
        Me.lblserie.Text = "Serie:"
        '
        'lblmaquinaLocal
        '
        Me.lblmaquinaLocal.AutoSize = True
        Me.lblmaquinaLocal.Location = New System.Drawing.Point(26, 113)
        Me.lblmaquinaLocal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmaquinaLocal.Name = "lblmaquinaLocal"
        Me.lblmaquinaLocal.Size = New System.Drawing.Size(80, 13)
        Me.lblmaquinaLocal.TabIndex = 119
        Me.lblmaquinaLocal.Text = "Máquina Local:"
        '
        'dtpDesdeFecha
        '
        Me.dtpDesdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesdeFecha.Location = New System.Drawing.Point(116, 46)
        Me.dtpDesdeFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDesdeFecha.Name = "dtpDesdeFecha"
        Me.dtpDesdeFecha.Size = New System.Drawing.Size(151, 20)
        Me.dtpDesdeFecha.TabIndex = 120
        '
        'dtpHastaFecha
        '
        Me.dtpHastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHastaFecha.Location = New System.Drawing.Point(365, 52)
        Me.dtpHastaFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHastaFecha.Name = "dtpHastaFecha"
        Me.dtpHastaFecha.Size = New System.Drawing.Size(151, 20)
        Me.dtpHastaFecha.TabIndex = 121
        '
        'mtxtserie
        '
        Me.mtxtserie.Location = New System.Drawing.Point(364, 113)
        Me.mtxtserie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtserie.Mask = "000-000-00-"
        Me.mtxtserie.Name = "mtxtserie"
        Me.mtxtserie.Size = New System.Drawing.Size(152, 20)
        Me.mtxtserie.TabIndex = 122
        Me.mtxtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtdesde
        '
        Me.mtxtdesde.Location = New System.Drawing.Point(115, 80)
        Me.mtxtdesde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxtdesde.Mask = "00000000"
        Me.mtxtdesde.Name = "mtxtdesde"
        Me.mtxtdesde.Size = New System.Drawing.Size(152, 20)
        Me.mtxtdesde.TabIndex = 123
        Me.mtxtdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxthasta
        '
        Me.mtxthasta.Location = New System.Drawing.Point(364, 84)
        Me.mtxthasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mtxthasta.Mask = "00000000"
        Me.mtxthasta.Name = "mtxthasta"
        Me.mtxthasta.Size = New System.Drawing.Size(151, 20)
        Me.mtxthasta.TabIndex = 124
        Me.mtxthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescripcionMaquina
        '
        Me.txtdescripcionMaquina.Location = New System.Drawing.Point(142, 139)
        Me.txtdescripcionMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdescripcionMaquina.Name = "txtdescripcionMaquina"
        Me.txtdescripcionMaquina.ReadOnly = True
        Me.txtdescripcionMaquina.Size = New System.Drawing.Size(126, 20)
        Me.txtdescripcionMaquina.TabIndex = 127
        '
        'btnbuscarMaquinaLocal
        '
        Me.btnbuscarMaquinaLocal.BackColor = System.Drawing.Color.White
        Me.btnbuscarMaquinaLocal.BackgroundImage = CType(resources.GetObject("btnbuscarMaquinaLocal.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarMaquinaLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarMaquinaLocal.FlatAppearance.BorderSize = 0
        Me.btnbuscarMaquinaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarMaquinaLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarMaquinaLocal.Location = New System.Drawing.Point(107, 139)
        Me.btnbuscarMaquinaLocal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarMaquinaLocal.Name = "btnbuscarMaquinaLocal"
        Me.btnbuscarMaquinaLocal.Size = New System.Drawing.Size(22, 18)
        Me.btnbuscarMaquinaLocal.TabIndex = 126
        Me.btnbuscarMaquinaLocal.Text = "..."
        Me.btnbuscarMaquinaLocal.UseVisualStyleBackColor = False
        '
        'txtcodigoMaquina
        '
        Me.txtcodigoMaquina.Location = New System.Drawing.Point(116, 109)
        Me.txtcodigoMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoMaquina.MaxLength = 20
        Me.txtcodigoMaquina.Name = "txtcodigoMaquina"
        Me.txtcodigoMaquina.Size = New System.Drawing.Size(152, 20)
        Me.txtcodigoMaquina.TabIndex = 125
        Me.txtcodigoMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCodeMaquinaLocal
        '
        Me.lblCodeMaquinaLocal.AutoSize = True
        Me.lblCodeMaquinaLocal.Location = New System.Drawing.Point(32, 167)
        Me.lblCodeMaquinaLocal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeMaquinaLocal.Name = "lblCodeMaquinaLocal"
        Me.lblCodeMaquinaLocal.Size = New System.Drawing.Size(0, 13)
        Me.lblCodeMaquinaLocal.TabIndex = 128
        Me.lblCodeMaquinaLocal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.btnbuscarMaquinaLocal)
        Me.GroupBox1.Controls.Add(Me.txtdescripcionMaquina)
        Me.GroupBox1.Controls.Add(Me.lblhastaF)
        Me.GroupBox1.Controls.Add(Me.dtpHastaFecha)
        Me.GroupBox1.Controls.Add(Me.dtpDesdeFecha)
        Me.GroupBox1.Controls.Add(Me.chkEstado)
        Me.GroupBox1.Controls.Add(Me.txtcodigoMaquina)
        Me.GroupBox1.Controls.Add(Me.lblDesdeF)
        Me.GroupBox1.Controls.Add(Me.mtxtCAI)
        Me.GroupBox1.Controls.Add(Me.mtxtserie)
        Me.GroupBox1.Controls.Add(Me.lblmaquinaLocal)
        Me.GroupBox1.Controls.Add(Me.lblCAI)
        Me.GroupBox1.Controls.Add(Me.lblserie)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.mtxtdesde)
        Me.GroupBox1.Controls.Add(Me.mtxthasta)
        Me.GroupBox1.Controls.Add(Me.lblhasta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 234)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(68, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(20, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 219
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(44, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(11, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(272, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(310, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(310, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "*"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(574, 29)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(101, 13)
        Me.Label61.TabIndex = 212
        Me.Label61.Text = "Campos obligatorios"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(560, 31)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(11, 13)
        Me.Label60.TabIndex = 211
        Me.Label60.Text = "*"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(32, 29)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(39, 13)
        Me.lblCodigo.TabIndex = 131
        Me.lblCodigo.Text = "codigo"
        Me.lblCodigo.Visible = False
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(364, 145)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(118, 17)
        Me.chkEstado.TabIndex = 125
        Me.chkEstado.Text = "Activar Facturación"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(535, 6)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(107, 28)
        Me.btnModificar.TabIndex = 130
        Me.btnModificar.Text = "Modificar Estado"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 283)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(720, 22)
        Me.StatusStrip1.TabIndex = 130
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
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 39)
        Me.Panel1.TabIndex = 132
        '
        'M_CAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 305)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblCodeMaquinaLocal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_CAI"
        Me.Text = "CAI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
End Class
