﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_BuscarClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_BuscarClientes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbxGenero = New System.Windows.Forms.ComboBox()
        Me.btnTerminoPago = New System.Windows.Forms.Button()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtRTN = New System.Windows.Forms.TextBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.lblcodigoTipoClasif = New System.Windows.Forms.Label()
        Me.btnTipoClasificacion = New System.Windows.Forms.Button()
        Me.txtnombreClasificacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCategoriaCliente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTermino = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtNombre1 = New System.Windows.Forms.TextBox()
        Me.lblEsado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lblnumeroB = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotalFacturas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.Controls.Add(Me.cmbxGenero)
        Me.GroupBox1.Controls.Add(Me.btnTerminoPago)
        Me.GroupBox1.Controls.Add(Me.txtApellido1)
        Me.GroupBox1.Controls.Add(Me.txtRTN)
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.lblcodigoTipoClasif)
        Me.GroupBox1.Controls.Add(Me.btnTipoClasificacion)
        Me.GroupBox1.Controls.Add(Me.txtnombreClasificacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnCategoriaCliente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTermino)
        Me.GroupBox1.Controls.Add(Me.txtApellido2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtNombre2)
        Me.GroupBox1.Controls.Add(Me.txtNombre1)
        Me.GroupBox1.Controls.Add(Me.lblEsado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblnombreB)
        Me.GroupBox1.Controls.Add(Me.lblForm)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.lblnumeroB)
        Me.GroupBox1.Controls.Add(Me.dgbtabla)
        Me.GroupBox1.Controls.Add(Me.lbltotalFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 29)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1420, 741)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda Avanzada de Clientes"
        '
        'cmbxGenero
        '
        Me.cmbxGenero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbxGenero.FormattingEnabled = True
        Me.cmbxGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "No Específicado"})
        Me.cmbxGenero.Location = New System.Drawing.Point(621, 114)
        Me.cmbxGenero.Name = "cmbxGenero"
        Me.cmbxGenero.Size = New System.Drawing.Size(279, 24)
        Me.cmbxGenero.TabIndex = 178
        '
        'btnTerminoPago
        '
        Me.btnTerminoPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTerminoPago.BackColor = System.Drawing.Color.White
        Me.btnTerminoPago.BackgroundImage = CType(resources.GetObject("btnTerminoPago.BackgroundImage"), System.Drawing.Image)
        Me.btnTerminoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTerminoPago.FlatAppearance.BorderSize = 0
        Me.btnTerminoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminoPago.Location = New System.Drawing.Point(860, 154)
        Me.btnTerminoPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTerminoPago.Name = "btnTerminoPago"
        Me.btnTerminoPago.Size = New System.Drawing.Size(40, 21)
        Me.btnTerminoPago.TabIndex = 177
        Me.btnTerminoPago.Text = "..."
        Me.btnTerminoPago.UseVisualStyleBackColor = False
        '
        'txtApellido1
        '
        Me.txtApellido1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido1.Location = New System.Drawing.Point(1075, 73)
        Me.txtApellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido1.MaxLength = 20
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(279, 22)
        Me.txtApellido1.TabIndex = 176
        '
        'txtRTN
        '
        Me.txtRTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRTN.Location = New System.Drawing.Point(1073, 36)
        Me.txtRTN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRTN.MaxLength = 20
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.Size = New System.Drawing.Size(279, 22)
        Me.txtRTN.TabIndex = 175
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Green
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExcel.Location = New System.Drawing.Point(1077, 156)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(115, 34)
        Me.btnExcel.TabIndex = 174
        Me.btnExcel.Text = "Generar Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'lblcodigoTipoClasif
        '
        Me.lblcodigoTipoClasif.AutoSize = True
        Me.lblcodigoTipoClasif.Location = New System.Drawing.Point(229, 179)
        Me.lblcodigoTipoClasif.Name = "lblcodigoTipoClasif"
        Me.lblcodigoTipoClasif.Size = New System.Drawing.Size(0, 17)
        Me.lblcodigoTipoClasif.TabIndex = 173
        Me.lblcodigoTipoClasif.Visible = False
        '
        'btnTipoClasificacion
        '
        Me.btnTipoClasificacion.BackColor = System.Drawing.Color.White
        Me.btnTipoClasificacion.BackgroundImage = CType(resources.GetObject("btnTipoClasificacion.BackgroundImage"), System.Drawing.Image)
        Me.btnTipoClasificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTipoClasificacion.FlatAppearance.BorderSize = 0
        Me.btnTipoClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoClasificacion.Location = New System.Drawing.Point(395, 155)
        Me.btnTipoClasificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTipoClasificacion.Name = "btnTipoClasificacion"
        Me.btnTipoClasificacion.Size = New System.Drawing.Size(40, 21)
        Me.btnTipoClasificacion.TabIndex = 172
        Me.btnTipoClasificacion.Text = "..."
        Me.btnTipoClasificacion.UseVisualStyleBackColor = False
        '
        'txtnombreClasificacion
        '
        Me.txtnombreClasificacion.Location = New System.Drawing.Point(157, 155)
        Me.txtnombreClasificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombreClasificacion.MaxLength = 20
        Me.txtnombreClasificacion.Name = "txtnombreClasificacion"
        Me.txtnombreClasificacion.Size = New System.Drawing.Size(232, 22)
        Me.txtnombreClasificacion.TabIndex = 171
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 170
        Me.Label8.Text = "Tipo Clasificación"
        '
        'btnCategoriaCliente
        '
        Me.btnCategoriaCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCategoriaCliente.BackColor = System.Drawing.Color.White
        Me.btnCategoriaCliente.BackgroundImage = CType(resources.GetObject("btnCategoriaCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnCategoriaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoriaCliente.FlatAppearance.BorderSize = 0
        Me.btnCategoriaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoriaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoriaCliente.Location = New System.Drawing.Point(1321, 114)
        Me.btnCategoriaCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCategoriaCliente.Name = "btnCategoriaCliente"
        Me.btnCategoriaCliente.Size = New System.Drawing.Size(40, 21)
        Me.btnCategoriaCliente.TabIndex = 169
        Me.btnCategoriaCliente.Text = "..."
        Me.btnCategoriaCliente.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(493, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Término de Pago"
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoria.Location = New System.Drawing.Point(1073, 114)
        Me.txtCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCategoria.MaxLength = 20
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(242, 22)
        Me.txtCategoria.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(951, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Categoría Cliente"
        '
        'txtTermino
        '
        Me.txtTermino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTermino.Location = New System.Drawing.Point(621, 153)
        Me.txtTermino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTermino.MaxLength = 20
        Me.txtTermino.Name = "txtTermino"
        Me.txtTermino.Size = New System.Drawing.Size(232, 22)
        Me.txtTermino.TabIndex = 137
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(157, 114)
        Me.txtApellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido2.MaxLength = 20
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(279, 22)
        Me.txtApellido2.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Segundo Apellido"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(1237, 156)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 34)
        Me.btnBuscar.TabIndex = 133
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNombre2
        '
        Me.txtNombre2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre2.Location = New System.Drawing.Point(621, 75)
        Me.txtNombre2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre2.MaxLength = 20
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(279, 22)
        Me.txtNombre2.TabIndex = 132
        '
        'txtNombre1
        '
        Me.txtNombre1.Location = New System.Drawing.Point(157, 75)
        Me.txtNombre1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre1.MaxLength = 20
        Me.txtNombre1.Name = "txtNombre1"
        Me.txtNombre1.Size = New System.Drawing.Size(279, 22)
        Me.txtNombre1.TabIndex = 131
        '
        'lblEsado
        '
        Me.lblEsado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEsado.AutoSize = True
        Me.lblEsado.Location = New System.Drawing.Point(964, 76)
        Me.lblEsado.Name = "lblEsado"
        Me.lblEsado.Size = New System.Drawing.Size(103, 17)
        Me.lblEsado.TabIndex = 129
        Me.lblEsado.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(491, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Segundo Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Primer Nombre"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(1030, 37)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 17)
        Me.lblFecha.TabIndex = 123
        Me.lblFecha.Text = "RTN"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(157, 37)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(279, 22)
        Me.txtCodigo.TabIndex = 122
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(544, 39)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(66, 17)
        Me.lblnombreB.TabIndex = 121
        Me.lblnombreB.Text = "Identidad"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(624, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(50, 17)
        Me.lblForm.TabIndex = 119
        Me.lblForm.Text = "lblform"
        Me.lblForm.Visible = False
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdentidad.Location = New System.Drawing.Point(621, 36)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdentidad.MaxLength = 20
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(279, 22)
        Me.txtIdentidad.TabIndex = 120
        '
        'lblcantidad
        '
        Me.lblcantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(389, 699)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 118
        Me.lblcantidad.Text = "000"
        '
        'lblnumeroB
        '
        Me.lblnumeroB.AutoSize = True
        Me.lblnumeroB.Location = New System.Drawing.Point(31, 39)
        Me.lblnumeroB.Name = "lblnumeroB"
        Me.lblnumeroB.Size = New System.Drawing.Size(52, 17)
        Me.lblnumeroB.TabIndex = 119
        Me.lblnumeroB.Text = "Código"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgbtabla.BackgroundColor = System.Drawing.Color.White
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(21, 215)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersVisible = False
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(1377, 467)
        Me.dgbtabla.TabIndex = 116
        '
        'lbltotalFacturas
        '
        Me.lbltotalFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbltotalFacturas.AutoSize = True
        Me.lbltotalFacturas.Location = New System.Drawing.Point(60, 699)
        Me.lbltotalFacturas.Name = "lbltotalFacturas"
        Me.lbltotalFacturas.Size = New System.Drawing.Size(170, 17)
        Me.lbltotalFacturas.TabIndex = 117
        Me.lbltotalFacturas.Text = "CANTIDAD DE CLIENTES"
        '
        'M_BuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1471, 798)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "M_BuscarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda Avanzada de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExcel As Button
    Friend WithEvents lblcodigoTipoClasif As Label
    Friend WithEvents btnTipoClasificacion As Button
    Friend WithEvents txtnombreClasificacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCategoriaCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTermino As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents lblEsado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lblForm As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lblnumeroB As Label
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lbltotalFacturas As Label
    Friend WithEvents cmbxGenero As ComboBox
    Friend WithEvents btnTerminoPago As Button
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtRTN As TextBox
End Class