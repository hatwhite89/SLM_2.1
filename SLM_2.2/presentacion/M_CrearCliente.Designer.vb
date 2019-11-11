<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_CrearCliente
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
        Me.gbxinformacion = New System.Windows.Forms.GroupBox()
        Me.btncrearCliente = New System.Windows.Forms.Button()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.cbxtipo = New System.Windows.Forms.ComboBox()
        Me.mtxtid = New System.Windows.Forms.MaskedTextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.rtxtdireccion = New System.Windows.Forms.RichTextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.cbxestadoCivil = New System.Windows.Forms.ComboBox()
        Me.lblestadoCivil = New System.Windows.Forms.Label()
        Me.rbtnfemenino = New System.Windows.Forms.RadioButton()
        Me.rbtnmasculino = New System.Windows.Forms.RadioButton()
        Me.lblgenero = New System.Windows.Forms.Label()
        Me.lbltipo = New System.Windows.Forms.Label()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.lblidentidadCliente = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.gbxinformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxinformacion
        '
        Me.gbxinformacion.BackColor = System.Drawing.Color.Transparent
        Me.gbxinformacion.Controls.Add(Me.TextBox4)
        Me.gbxinformacion.Controls.Add(Me.TextBox3)
        Me.gbxinformacion.Controls.Add(Me.Button1)
        Me.gbxinformacion.Controls.Add(Me.btncrearCliente)
        Me.gbxinformacion.Controls.Add(Me.txtcorreo)
        Me.gbxinformacion.Controls.Add(Me.txttelefono)
        Me.gbxinformacion.Controls.Add(Me.cbxtipo)
        Me.gbxinformacion.Controls.Add(Me.mtxtid)
        Me.gbxinformacion.Controls.Add(Me.txtnombre)
        Me.gbxinformacion.Controls.Add(Me.rtxtdireccion)
        Me.gbxinformacion.Controls.Add(Me.lbldireccion)
        Me.gbxinformacion.Controls.Add(Me.cbxestadoCivil)
        Me.gbxinformacion.Controls.Add(Me.lblestadoCivil)
        Me.gbxinformacion.Controls.Add(Me.rbtnfemenino)
        Me.gbxinformacion.Controls.Add(Me.rbtnmasculino)
        Me.gbxinformacion.Controls.Add(Me.lblgenero)
        Me.gbxinformacion.Controls.Add(Me.lbltipo)
        Me.gbxinformacion.Controls.Add(Me.lbltelefono)
        Me.gbxinformacion.Controls.Add(Me.lblcorreo)
        Me.gbxinformacion.Controls.Add(Me.lblidentidadCliente)
        Me.gbxinformacion.Controls.Add(Me.lblnombre)
        Me.gbxinformacion.Location = New System.Drawing.Point(68, 30)
        Me.gbxinformacion.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxinformacion.Name = "gbxinformacion"
        Me.gbxinformacion.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxinformacion.Size = New System.Drawing.Size(850, 489)
        Me.gbxinformacion.TabIndex = 12
        Me.gbxinformacion.TabStop = False
        Me.gbxinformacion.Text = "Información de Cliente/Paciente"
        '
        'btncrearCliente
        '
        Me.btncrearCliente.BackColor = System.Drawing.Color.SkyBlue
        Me.btncrearCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncrearCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncrearCliente.Location = New System.Drawing.Point(142, 390)
        Me.btncrearCliente.Name = "btncrearCliente"
        Me.btncrearCliente.Size = New System.Drawing.Size(204, 57)
        Me.btncrearCliente.TabIndex = 19
        Me.btncrearCliente.Text = "Crear y Seleccionar"
        Me.btncrearCliente.UseVisualStyleBackColor = False
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(142, 183)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(179, 22)
        Me.txtcorreo.TabIndex = 18
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(142, 140)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(179, 22)
        Me.txttelefono.TabIndex = 17
        '
        'cbxtipo
        '
        Me.cbxtipo.FormattingEnabled = True
        Me.cbxtipo.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cbxtipo.Location = New System.Drawing.Point(142, 223)
        Me.cbxtipo.Name = "cbxtipo"
        Me.cbxtipo.Size = New System.Drawing.Size(179, 24)
        Me.cbxtipo.TabIndex = 16
        '
        'mtxtid
        '
        Me.mtxtid.Location = New System.Drawing.Point(142, 49)
        Me.mtxtid.Mask = "0000-0000-00000"
        Me.mtxtid.Name = "mtxtid"
        Me.mtxtid.Size = New System.Drawing.Size(179, 22)
        Me.mtxtid.TabIndex = 15
        Me.mtxtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(142, 96)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(179, 22)
        Me.txtnombre.TabIndex = 14
        '
        'rtxtdireccion
        '
        Me.rtxtdireccion.Location = New System.Drawing.Point(483, 152)
        Me.rtxtdireccion.Name = "rtxtdireccion"
        Me.rtxtdireccion.Size = New System.Drawing.Size(202, 95)
        Me.rtxtdireccion.TabIndex = 13
        Me.rtxtdireccion.Text = ""
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(381, 152)
        Me.lbldireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(71, 17)
        Me.lbldireccion.TabIndex = 12
        Me.lbldireccion.Text = "Dirección:"
        '
        'cbxestadoCivil
        '
        Me.cbxestadoCivil.FormattingEnabled = True
        Me.cbxestadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cbxestadoCivil.Location = New System.Drawing.Point(483, 96)
        Me.cbxestadoCivil.Name = "cbxestadoCivil"
        Me.cbxestadoCivil.Size = New System.Drawing.Size(202, 24)
        Me.cbxestadoCivil.TabIndex = 11
        '
        'lblestadoCivil
        '
        Me.lblestadoCivil.AutoSize = True
        Me.lblestadoCivil.Location = New System.Drawing.Point(367, 101)
        Me.lblestadoCivil.Name = "lblestadoCivil"
        Me.lblestadoCivil.Size = New System.Drawing.Size(85, 17)
        Me.lblestadoCivil.TabIndex = 10
        Me.lblestadoCivil.Text = "Estado Civil:"
        '
        'rbtnfemenino
        '
        Me.rbtnfemenino.AutoSize = True
        Me.rbtnfemenino.Location = New System.Drawing.Point(594, 50)
        Me.rbtnfemenino.Name = "rbtnfemenino"
        Me.rbtnfemenino.Size = New System.Drawing.Size(91, 21)
        Me.rbtnfemenino.TabIndex = 9
        Me.rbtnfemenino.TabStop = True
        Me.rbtnfemenino.Text = "Femenino"
        Me.rbtnfemenino.UseVisualStyleBackColor = True
        '
        'rbtnmasculino
        '
        Me.rbtnmasculino.AutoSize = True
        Me.rbtnmasculino.Location = New System.Drawing.Point(483, 50)
        Me.rbtnmasculino.Name = "rbtnmasculino"
        Me.rbtnmasculino.Size = New System.Drawing.Size(92, 21)
        Me.rbtnmasculino.TabIndex = 8
        Me.rbtnmasculino.TabStop = True
        Me.rbtnmasculino.Text = "Masculino"
        Me.rbtnmasculino.UseVisualStyleBackColor = True
        '
        'lblgenero
        '
        Me.lblgenero.AutoSize = True
        Me.lblgenero.Location = New System.Drawing.Point(392, 54)
        Me.lblgenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgenero.Name = "lblgenero"
        Me.lblgenero.Size = New System.Drawing.Size(60, 17)
        Me.lblgenero.TabIndex = 7
        Me.lblgenero.Text = "Género:"
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(77, 230)
        Me.lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(40, 17)
        Me.lbltipo.TabIndex = 6
        Me.lbltipo.Text = "Tipo:"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(49, 140)
        Me.lbltelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(68, 17)
        Me.lbltelefono.TabIndex = 5
        Me.lbltelefono.Text = "Teléfono:"
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(62, 183)
        Me.lblcorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(55, 17)
        Me.lblcorreo.TabIndex = 4
        Me.lblcorreo.Text = "Correo:"
        '
        'lblidentidadCliente
        '
        Me.lblidentidadCliente.AutoSize = True
        Me.lblidentidadCliente.Location = New System.Drawing.Point(47, 52)
        Me.lblidentidadCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidentidadCliente.Name = "lblidentidadCliente"
        Me.lblidentidadCliente.Size = New System.Drawing.Size(70, 17)
        Me.lblidentidadCliente.TabIndex = 2
        Me.lblidentidadCliente.Text = "Identidad:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(55, 96)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(62, 17)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(481, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 57)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(142, 306)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(179, 22)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(142, 267)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(179, 22)
        Me.TextBox4.TabIndex = 24
        '
        'CrearCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 546)
        Me.Controls.Add(Me.gbxinformacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CrearCliente"
        Me.Text = "CrearCliente"
        Me.gbxinformacion.ResumeLayout(False)
        Me.gbxinformacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxinformacion As GroupBox
    Friend WithEvents btncrearCliente As Button
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents cbxtipo As ComboBox
    Friend WithEvents mtxtid As MaskedTextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents rtxtdireccion As RichTextBox
    Friend WithEvents lbldireccion As Label
    Friend WithEvents cbxestadoCivil As ComboBox
    Friend WithEvents lblestadoCivil As Label
    Friend WithEvents rbtnfemenino As RadioButton
    Friend WithEvents rbtnmasculino As RadioButton
    Friend WithEvents lblgenero As Label
    Friend WithEvents lbltipo As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lblcorreo As Label
    Friend WithEvents lblidentidadCliente As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
End Class
