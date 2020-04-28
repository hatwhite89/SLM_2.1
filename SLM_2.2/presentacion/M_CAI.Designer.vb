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
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCAI
        '
        Me.lblCAI.AutoSize = True
        Me.lblCAI.Location = New System.Drawing.Point(70, 29)
        Me.lblCAI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCAI.Name = "lblCAI"
        Me.lblCAI.Size = New System.Drawing.Size(27, 13)
        Me.lblCAI.TabIndex = 0
        Me.lblCAI.Text = "CAI:"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(45, 80)
        Me.lbldesde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(41, 13)
        Me.lbldesde.TabIndex = 1
        Me.lbldesde.Text = "Desde:"
        '
        'lblhasta
        '
        Me.lblhasta.AutoSize = True
        Me.lblhasta.Location = New System.Drawing.Point(311, 87)
        Me.lblhasta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(38, 13)
        Me.lblhasta.TabIndex = 2
        Me.lblhasta.Text = "Hasta:"
        '
        'lblDesdeF
        '
        Me.lblDesdeF.AutoSize = True
        Me.lblDesdeF.Location = New System.Drawing.Point(23, 60)
        Me.lblDesdeF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesdeF.Name = "lblDesdeF"
        Me.lblDesdeF.Size = New System.Drawing.Size(74, 13)
        Me.lblDesdeF.TabIndex = 3
        Me.lblDesdeF.Text = "Desde Fecha:"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(277, 172)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
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
        Me.btnnuevo.Location = New System.Drawing.Point(11, 179)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
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
        Me.btnguardar.Location = New System.Drawing.Point(94, 179)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 113
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'mtxtCAI
        '
        Me.mtxtCAI.Location = New System.Drawing.Point(106, 27)
        Me.mtxtCAI.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxtCAI.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA-AAAAAA-AA"
        Me.mtxtCAI.Name = "mtxtCAI"
        Me.mtxtCAI.Size = New System.Drawing.Size(400, 20)
        Me.mtxtCAI.TabIndex = 116
        Me.mtxtCAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblhastaF
        '
        Me.lblhastaF.AutoSize = True
        Me.lblhastaF.Location = New System.Drawing.Point(282, 60)
        Me.lblhastaF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblhastaF.Name = "lblhastaF"
        Me.lblhastaF.Size = New System.Drawing.Size(71, 13)
        Me.lblhastaF.TabIndex = 117
        Me.lblhastaF.Text = "Hasta Fecha:"
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(311, 116)
        Me.lblserie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 118
        Me.lblserie.Text = "Serie:"
        '
        'lblmaquinaLocal
        '
        Me.lblmaquinaLocal.AutoSize = True
        Me.lblmaquinaLocal.Location = New System.Drawing.Point(17, 123)
        Me.lblmaquinaLocal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblmaquinaLocal.Name = "lblmaquinaLocal"
        Me.lblmaquinaLocal.Size = New System.Drawing.Size(80, 13)
        Me.lblmaquinaLocal.TabIndex = 119
        Me.lblmaquinaLocal.Text = "Máquina Local:"
        '
        'dtpDesdeFecha
        '
        Me.dtpDesdeFecha.Location = New System.Drawing.Point(106, 60)
        Me.dtpDesdeFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDesdeFecha.Name = "dtpDesdeFecha"
        Me.dtpDesdeFecha.Size = New System.Drawing.Size(151, 20)
        Me.dtpDesdeFecha.TabIndex = 120
        '
        'dtpHastaFecha
        '
        Me.dtpHastaFecha.Location = New System.Drawing.Point(356, 60)
        Me.dtpHastaFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHastaFecha.Name = "dtpHastaFecha"
        Me.dtpHastaFecha.Size = New System.Drawing.Size(151, 20)
        Me.dtpHastaFecha.TabIndex = 121
        '
        'mtxtserie
        '
        Me.mtxtserie.Location = New System.Drawing.Point(350, 113)
        Me.mtxtserie.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxtserie.Mask = "000-000-00-"
        Me.mtxtserie.Name = "mtxtserie"
        Me.mtxtserie.Size = New System.Drawing.Size(152, 20)
        Me.mtxtserie.TabIndex = 122
        Me.mtxtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxtdesde
        '
        Me.mtxtdesde.Location = New System.Drawing.Point(101, 80)
        Me.mtxtdesde.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxtdesde.Mask = "00000000"
        Me.mtxtdesde.Name = "mtxtdesde"
        Me.mtxtdesde.Size = New System.Drawing.Size(152, 20)
        Me.mtxtdesde.TabIndex = 123
        Me.mtxtdesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtxthasta
        '
        Me.mtxthasta.Location = New System.Drawing.Point(351, 84)
        Me.mtxthasta.Margin = New System.Windows.Forms.Padding(2)
        Me.mtxthasta.Mask = "00000000"
        Me.mtxthasta.Name = "mtxthasta"
        Me.mtxthasta.Size = New System.Drawing.Size(151, 20)
        Me.mtxthasta.TabIndex = 124
        Me.mtxthasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdescripcionMaquina
        '
        Me.txtdescripcionMaquina.Location = New System.Drawing.Point(106, 149)
        Me.txtdescripcionMaquina.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcionMaquina.Name = "txtdescripcionMaquina"
        Me.txtdescripcionMaquina.ReadOnly = True
        Me.txtdescripcionMaquina.Size = New System.Drawing.Size(152, 20)
        Me.txtdescripcionMaquina.TabIndex = 127
        '
        'btnbuscarMaquinaLocal
        '
        Me.btnbuscarMaquinaLocal.BackColor = System.Drawing.Color.White
        Me.btnbuscarMaquinaLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarMaquinaLocal.FlatAppearance.BorderSize = 0
        Me.btnbuscarMaquinaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarMaquinaLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarMaquinaLocal.Location = New System.Drawing.Point(106, 149)
        Me.btnbuscarMaquinaLocal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbuscarMaquinaLocal.Name = "btnbuscarMaquinaLocal"
        Me.btnbuscarMaquinaLocal.Size = New System.Drawing.Size(22, 18)
        Me.btnbuscarMaquinaLocal.TabIndex = 126
        Me.btnbuscarMaquinaLocal.Text = "..."
        Me.btnbuscarMaquinaLocal.UseVisualStyleBackColor = False
        '
        'txtcodigoMaquina
        '
        Me.txtcodigoMaquina.Location = New System.Drawing.Point(106, 120)
        Me.txtcodigoMaquina.Margin = New System.Windows.Forms.Padding(2)
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 215)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CAI"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(351, 145)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(118, 17)
        Me.chkEstado.TabIndex = 125
        Me.chkEstado.Text = "Activar Facturación"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(166, 172)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(107, 28)
        Me.btnModificar.TabIndex = 130
        Me.btnModificar.Text = "Modificar Estado"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(523, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(39, 13)
        Me.lblCodigo.TabIndex = 131
        Me.lblCodigo.Text = "codigo"
        Me.lblCodigo.Visible = False
        '
        'M_CAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 230)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
