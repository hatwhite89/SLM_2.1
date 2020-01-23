<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnContabilidad = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxMenu = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFacturacion = New System.Windows.Forms.Button()
        Me.btnlaboratorio = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tcMenu = New System.Windows.Forms.TabControl()
        Me.tpCheque = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDepoBanc = New System.Windows.Forms.Button()
        Me.tpPagos = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnPagos = New System.Windows.Forms.Button()
        Me.tpPrecios = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TpMantenimiento = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBancos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCategoriaProveedor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCuentas = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxMenu.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.tcMenu.SuspendLayout()
        Me.tpCheque.SuspendLayout()
        Me.tpPagos.SuspendLayout()
        Me.tpPrecios.SuspendLayout()
        Me.TpMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContabilidad
        '
        Me.btnContabilidad.BackColor = System.Drawing.Color.LightGray
        Me.btnContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContabilidad.FlatAppearance.BorderSize = 0
        Me.btnContabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContabilidad.Location = New System.Drawing.Point(4, 40)
        Me.btnContabilidad.Name = "btnContabilidad"
        Me.btnContabilidad.Size = New System.Drawing.Size(92, 27)
        Me.btnContabilidad.TabIndex = 1
        Me.btnContabilidad.Text = "Contabilidad"
        Me.btnContabilidad.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(135, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 137)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'gbxMenu
        '
        Me.gbxMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.gbxMenu.Controls.Add(Me.btnCerrar)
        Me.gbxMenu.Controls.Add(Me.Button1)
        Me.gbxMenu.Controls.Add(Me.btnFacturacion)
        Me.gbxMenu.Controls.Add(Me.btnlaboratorio)
        Me.gbxMenu.Controls.Add(Me.btnContabilidad)
        Me.gbxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxMenu.Location = New System.Drawing.Point(-1, -13)
        Me.gbxMenu.Name = "gbxMenu"
        Me.gbxMenu.Size = New System.Drawing.Size(101, 405)
        Me.gbxMenu.TabIndex = 3
        Me.gbxMenu.TabStop = False
        Me.gbxMenu.Text = "Opciones"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(4, 365)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(93, 27)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(4, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Item Exámenes"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnFacturacion
        '
        Me.btnFacturacion.BackColor = System.Drawing.Color.Gray
        Me.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFacturacion.FlatAppearance.BorderSize = 0
        Me.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturacion.Location = New System.Drawing.Point(4, 74)
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Size = New System.Drawing.Size(92, 27)
        Me.btnFacturacion.TabIndex = 2
        Me.btnFacturacion.Text = "Facturación"
        Me.btnFacturacion.UseVisualStyleBackColor = False
        '
        'btnlaboratorio
        '
        Me.btnlaboratorio.BackColor = System.Drawing.Color.SlateGray
        Me.btnlaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlaboratorio.FlatAppearance.BorderSize = 0
        Me.btnlaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaboratorio.Location = New System.Drawing.Point(4, 107)
        Me.btnlaboratorio.Name = "btnlaboratorio"
        Me.btnlaboratorio.Size = New System.Drawing.Size(92, 27)
        Me.btnlaboratorio.TabIndex = 3
        Me.btnlaboratorio.Text = "Laboratorio"
        Me.btnlaboratorio.UseVisualStyleBackColor = False
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.White
        Me.panelMenu.Controls.Add(Me.btnCancelar)
        Me.panelMenu.Controls.Add(Me.tcMenu)
        Me.panelMenu.Location = New System.Drawing.Point(106, 6)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(324, 373)
        Me.panelMenu.TabIndex = 4
        Me.panelMenu.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Red
        Me.btnCancelar.Location = New System.Drawing.Point(287, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(20, 18)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "X"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'tcMenu
        '
        Me.tcMenu.Controls.Add(Me.tpCheque)
        Me.tcMenu.Controls.Add(Me.tpPagos)
        Me.tcMenu.Controls.Add(Me.tpPrecios)
        Me.tcMenu.Controls.Add(Me.TpMantenimiento)
        Me.tcMenu.Location = New System.Drawing.Point(24, 24)
        Me.tcMenu.Name = "tcMenu"
        Me.tcMenu.SelectedIndex = 0
        Me.tcMenu.Size = New System.Drawing.Size(290, 343)
        Me.tcMenu.TabIndex = 6
        '
        'tpCheque
        '
        Me.tpCheque.Controls.Add(Me.Label10)
        Me.tpCheque.Controls.Add(Me.Button3)
        Me.tpCheque.Controls.Add(Me.Label7)
        Me.tpCheque.Controls.Add(Me.Label6)
        Me.tpCheque.Controls.Add(Me.Button2)
        Me.tpCheque.Controls.Add(Me.btnDepoBanc)
        Me.tpCheque.Location = New System.Drawing.Point(4, 22)
        Me.tpCheque.Name = "tpCheque"
        Me.tpCheque.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCheque.Size = New System.Drawing.Size(282, 317)
        Me.tpCheque.TabIndex = 0
        Me.tpCheque.Text = "Cheque"
        Me.tpCheque.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(213, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Cheques"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(206, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 60)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Deposito Bancario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Chequera"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(14, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 66)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnDepoBanc
        '
        Me.btnDepoBanc.BackColor = System.Drawing.Color.Transparent
        Me.btnDepoBanc.BackgroundImage = CType(resources.GetObject("btnDepoBanc.BackgroundImage"), System.Drawing.Image)
        Me.btnDepoBanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDepoBanc.FlatAppearance.BorderSize = 0
        Me.btnDepoBanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepoBanc.ForeColor = System.Drawing.Color.White
        Me.btnDepoBanc.Location = New System.Drawing.Point(110, 12)
        Me.btnDepoBanc.Name = "btnDepoBanc"
        Me.btnDepoBanc.Size = New System.Drawing.Size(63, 60)
        Me.btnDepoBanc.TabIndex = 0
        Me.btnDepoBanc.UseVisualStyleBackColor = False
        '
        'tpPagos
        '
        Me.tpPagos.Controls.Add(Me.Label9)
        Me.tpPagos.Controls.Add(Me.Label8)
        Me.tpPagos.Controls.Add(Me.Button4)
        Me.tpPagos.Controls.Add(Me.btnPagos)
        Me.tpPagos.Location = New System.Drawing.Point(4, 22)
        Me.tpPagos.Name = "tpPagos"
        Me.tpPagos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPagos.Size = New System.Drawing.Size(282, 317)
        Me.tpPagos.TabIndex = 1
        Me.tpPagos.Text = "Pagos"
        Me.tpPagos.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Pagos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Factura Compra"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(11, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 67)
        Me.Button4.TabIndex = 1
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnPagos
        '
        Me.btnPagos.BackColor = System.Drawing.Color.Transparent
        Me.btnPagos.BackgroundImage = CType(resources.GetObject("btnPagos.BackgroundImage"), System.Drawing.Image)
        Me.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagos.FlatAppearance.BorderSize = 0
        Me.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagos.ForeColor = System.Drawing.Color.White
        Me.btnPagos.Location = New System.Drawing.Point(91, 3)
        Me.btnPagos.Name = "btnPagos"
        Me.btnPagos.Size = New System.Drawing.Size(71, 71)
        Me.btnPagos.TabIndex = 0
        Me.btnPagos.UseVisualStyleBackColor = False
        '
        'tpPrecios
        '
        Me.tpPrecios.Controls.Add(Me.Label15)
        Me.tpPrecios.Controls.Add(Me.Button8)
        Me.tpPrecios.Controls.Add(Me.Button7)
        Me.tpPrecios.Controls.Add(Me.Button6)
        Me.tpPrecios.Controls.Add(Me.Button5)
        Me.tpPrecios.Controls.Add(Me.Label14)
        Me.tpPrecios.Controls.Add(Me.Label13)
        Me.tpPrecios.Controls.Add(Me.Label12)
        Me.tpPrecios.Location = New System.Drawing.Point(4, 22)
        Me.tpPrecios.Name = "tpPrecios"
        Me.tpPrecios.Size = New System.Drawing.Size(282, 317)
        Me.tpPrecios.TabIndex = 3
        Me.tpPrecios.Text = "Precios y Descuentos"
        Me.tpPrecios.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Promociones"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(9, 116)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 67)
        Me.Button8.TabIndex = 18
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(195, 9)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 67)
        Me.Button7.TabIndex = 17
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(100, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 67)
        Me.Button6.TabIndex = 16
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(9, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 67)
        Me.Button5.TabIndex = 15
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(97, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Listas de Precio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(206, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Descuento"
        '
        'TpMantenimiento
        '
        Me.TpMantenimiento.Controls.Add(Me.Label17)
        Me.TpMantenimiento.Controls.Add(Me.Button10)
        Me.TpMantenimiento.Controls.Add(Me.Label16)
        Me.TpMantenimiento.Controls.Add(Me.Button9)
        Me.TpMantenimiento.Controls.Add(Me.Label5)
        Me.TpMantenimiento.Controls.Add(Me.btnBancos)
        Me.TpMantenimiento.Controls.Add(Me.Label4)
        Me.TpMantenimiento.Controls.Add(Me.btnProveedor)
        Me.TpMantenimiento.Controls.Add(Me.Label3)
        Me.TpMantenimiento.Controls.Add(Me.btnCategoriaProveedor)
        Me.TpMantenimiento.Controls.Add(Me.Label2)
        Me.TpMantenimiento.Controls.Add(Me.btnCuentas)
        Me.TpMantenimiento.Controls.Add(Me.Label11)
        Me.TpMantenimiento.Controls.Add(Me.btnFormaPago)
        Me.TpMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.TpMantenimiento.Name = "TpMantenimiento"
        Me.TpMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.TpMantenimiento.Size = New System.Drawing.Size(282, 317)
        Me.TpMantenimiento.TabIndex = 2
        Me.TpMantenimiento.Text = "Mantenimiento"
        Me.TpMantenimiento.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(118, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Asientos"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(120, 163)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(41, 38)
        Me.Button10.TabIndex = 12
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Período Contable"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(26, 164)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(41, 38)
        Me.Button9.TabIndex = 10
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bancos"
        '
        'btnBancos
        '
        Me.btnBancos.BackgroundImage = CType(resources.GetObject("btnBancos.BackgroundImage"), System.Drawing.Image)
        Me.btnBancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBancos.FlatAppearance.BorderSize = 0
        Me.btnBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBancos.Location = New System.Drawing.Point(120, 7)
        Me.btnBancos.Name = "btnBancos"
        Me.btnBancos.Size = New System.Drawing.Size(41, 38)
        Me.btnBancos.TabIndex = 8
        Me.btnBancos.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Proveedor"
        '
        'btnProveedor
        '
        Me.btnProveedor.BackgroundImage = CType(resources.GetObject("btnProveedor.BackgroundImage"), System.Drawing.Image)
        Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Location = New System.Drawing.Point(26, 238)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(41, 38)
        Me.btnProveedor.TabIndex = 6
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria Prove."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCategoriaProveedor
        '
        Me.btnCategoriaProveedor.BackgroundImage = CType(resources.GetObject("btnCategoriaProveedor.BackgroundImage"), System.Drawing.Image)
        Me.btnCategoriaProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoriaProveedor.FlatAppearance.BorderSize = 0
        Me.btnCategoriaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoriaProveedor.Location = New System.Drawing.Point(26, 88)
        Me.btnCategoriaProveedor.Name = "btnCategoriaProveedor"
        Me.btnCategoriaProveedor.Size = New System.Drawing.Size(41, 38)
        Me.btnCategoriaProveedor.TabIndex = 4
        Me.btnCategoriaProveedor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cuentas"
        '
        'btnCuentas
        '
        Me.btnCuentas.BackgroundImage = CType(resources.GetObject("btnCuentas.BackgroundImage"), System.Drawing.Image)
        Me.btnCuentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCuentas.FlatAppearance.BorderSize = 0
        Me.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuentas.Location = New System.Drawing.Point(120, 88)
        Me.btnCuentas.Name = "btnCuentas"
        Me.btnCuentas.Size = New System.Drawing.Size(41, 38)
        Me.btnCuentas.TabIndex = 2
        Me.btnCuentas.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Formas de Pago"
        '
        'btnFormaPago
        '
        Me.btnFormaPago.BackgroundImage = CType(resources.GetObject("btnFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFormaPago.FlatAppearance.BorderSize = 0
        Me.btnFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaPago.Location = New System.Drawing.Point(26, 7)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(41, 38)
        Me.btnFormaPago.TabIndex = 0
        Me.btnFormaPago.UseVisualStyleBackColor = True
        '
        'SkinEngine1
        '
        Me.SkinEngine1.DefaultButtonStyle = Sunisoft.IrisSkin.DefaultButtonStyle.Shadow
        Me.SkinEngine1.Enable3rdControl = True
        Me.SkinEngine1.ResSysMenuClose = ""
        Me.SkinEngine1.ResSysMenuMax = ""
        Me.SkinEngine1.ResSysMenuMin = ""
        Me.SkinEngine1.SerialNumber = "U4N2UjLguUZs33UR+Vy47JAZ81t2fjIFvut28vc5oHiVeivGb/NZMA=="
        Me.SkinEngine1.SkinFile = "C:\Users\Software 3\Desktop\Componentes Graficos Vb2\Componentes Graficos Vb2\SKI" &
    "N NET 2010 WIN 7\SkinVS.NET\MacOS\MacOS.ssk"
        Me.SkinEngine1.SkinStreamMain = CType(resources.GetObject("SkinEngine1.SkinStreamMain"), System.IO.Stream)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(437, 379)
        Me.Controls.Add(Me.gbxMenu)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Sistema Laboratorios Médicos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxMenu.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.tcMenu.ResumeLayout(False)
        Me.tpCheque.ResumeLayout(False)
        Me.tpCheque.PerformLayout()
        Me.tpPagos.ResumeLayout(False)
        Me.tpPagos.PerformLayout()
        Me.tpPrecios.ResumeLayout(False)
        Me.tpPrecios.PerformLayout()
        Me.TpMantenimiento.ResumeLayout(False)
        Me.TpMantenimiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnContabilidad As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbxMenu As GroupBox
    Friend WithEvents btnlaboratorio As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFacturacion As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tcMenu As TabControl
    Friend WithEvents tpCheque As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDepoBanc As Button
    Friend WithEvents tpPagos As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents tpPrecios As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TpMantenimiento As TabPage
    Friend WithEvents Label17 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBancos As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProveedor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCategoriaProveedor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCuentas As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnFormaPago As Button
End Class
