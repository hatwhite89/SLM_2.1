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
        Me.lblCodChequera = New System.Windows.Forms.Label()
        Me.lblNombreBanc = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mtxtNumInicio = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCtaDestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodChequera = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtChequeras = New System.Windows.Forms.DataGridView()
        Me.gbxInfoChequeras.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtChequeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxInfoChequeras
        '
        Me.gbxInfoChequeras.Controls.Add(Me.lblCodChequera)
        Me.gbxInfoChequeras.Controls.Add(Me.lblNombreBanc)
        Me.gbxInfoChequeras.Controls.Add(Me.Button1)
        Me.gbxInfoChequeras.Controls.Add(Me.mtxtNumInicio)
        Me.gbxInfoChequeras.Controls.Add(Me.btnBuscar)
        Me.gbxInfoChequeras.Controls.Add(Me.btnGuardar)
        Me.gbxInfoChequeras.Controls.Add(Me.btnCrear)
        Me.gbxInfoChequeras.Controls.Add(Me.txtBanco)
        Me.gbxInfoChequeras.Controls.Add(Me.Label5)
        Me.gbxInfoChequeras.Controls.Add(Me.txtCantidad)
        Me.gbxInfoChequeras.Controls.Add(Me.Label4)
        Me.gbxInfoChequeras.Controls.Add(Me.Label3)
        Me.gbxInfoChequeras.Controls.Add(Me.txtCtaDestino)
        Me.gbxInfoChequeras.Controls.Add(Me.Label2)
        Me.gbxInfoChequeras.Controls.Add(Me.txtCodChequera)
        Me.gbxInfoChequeras.Controls.Add(Me.Label1)
        Me.gbxInfoChequeras.Location = New System.Drawing.Point(12, 12)
        Me.gbxInfoChequeras.Name = "gbxInfoChequeras"
        Me.gbxInfoChequeras.Size = New System.Drawing.Size(694, 150)
        Me.gbxInfoChequeras.TabIndex = 0
        Me.gbxInfoChequeras.TabStop = False
        Me.gbxInfoChequeras.Text = "Información de Chequera"
        '
        'lblCodChequera
        '
        Me.lblCodChequera.AutoSize = True
        Me.lblCodChequera.Location = New System.Drawing.Point(540, 16)
        Me.lblCodChequera.Name = "lblCodChequera"
        Me.lblCodChequera.Size = New System.Drawing.Size(39, 13)
        Me.lblCodChequera.TabIndex = 16
        Me.lblCodChequera.Text = "Label6"
        Me.lblCodChequera.Visible = False
        '
        'lblNombreBanc
        '
        Me.lblNombreBanc.AutoSize = True
        Me.lblNombreBanc.Location = New System.Drawing.Point(258, 82)
        Me.lblNombreBanc.Name = "lblNombreBanc"
        Me.lblNombreBanc.Size = New System.Drawing.Size(85, 13)
        Me.lblNombreBanc.TabIndex = 16
        Me.lblNombreBanc.Text = "lblNombreBanco"
        Me.lblNombreBanc.Visible = False
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
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(92, 121)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.FlatAppearance.BorderSize = 0
        Me.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrear.ForeColor = System.Drawing.Color.White
        Me.btnCrear.Location = New System.Drawing.Point(11, 121)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 10
        Me.btnCrear.Text = "Crear Nuevo"
        Me.btnCrear.UseVisualStyleBackColor = False
        Me.btnCrear.Visible = False
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtChequeras)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 236)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Chequeras"
        '
        'dtChequeras
        '
        Me.dtChequeras.AllowUserToAddRows = False
        Me.dtChequeras.AllowUserToDeleteRows = False
        Me.dtChequeras.BackgroundColor = System.Drawing.Color.White
        Me.dtChequeras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtChequeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtChequeras.GridColor = System.Drawing.Color.White
        Me.dtChequeras.Location = New System.Drawing.Point(6, 19)
        Me.dtChequeras.Name = "dtChequeras"
        Me.dtChequeras.ReadOnly = True
        Me.dtChequeras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtChequeras.Size = New System.Drawing.Size(682, 211)
        Me.dtChequeras.TabIndex = 0
        '
        'A_Chequera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 416)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxInfoChequeras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "A_Chequera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chequera"
        Me.gbxInfoChequeras.ResumeLayout(False)
        Me.gbxInfoChequeras.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtChequeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbxInfoChequeras As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtChequeras As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCrear As Button
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
    Friend WithEvents lblCodChequera As Label
    Friend WithEvents lblNombreBanc As Label
End Class
