﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Medico))
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.txtcelular = New System.Windows.Forms.TextBox()
        Me.lblcelular = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.txtcorreo2 = New System.Windows.Forms.TextBox()
        Me.lblcorreo2 = New System.Windows.Forms.Label()
        Me.btnbuscarEspecialidad = New System.Windows.Forms.Button()
        Me.txtcodigoEspecialidad = New System.Windows.Forms.TextBox()
        Me.lblespecialidad = New System.Windows.Forms.Label()
        Me.txtnombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblnombreCompleto = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.gbxmedico = New System.Windows.Forms.GroupBox()
        Me.txtnombreEspecialidad = New System.Windows.Forms.TextBox()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtnombreB = New System.Windows.Forms.TextBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.gbxmedico.SuspendLayout()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(109, 29)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(135, 20)
        Me.txtcodigo.TabIndex = 88
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(64, 29)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblcodigo.TabIndex = 87
        Me.lblcodigo.Text = "Código"
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(302, 99)
        Me.txtcelular.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcelular.MaxLength = 20
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(135, 20)
        Me.txtcelular.TabIndex = 92
        Me.txtcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcelular
        '
        Me.lblcelular.AutoSize = True
        Me.lblcelular.Location = New System.Drawing.Point(257, 102)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(39, 13)
        Me.lblcelular.TabIndex = 91
        Me.lblcelular.Text = "Celular"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(302, 76)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttelefono.MaxLength = 20
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(135, 20)
        Me.txttelefono.TabIndex = 90
        Me.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(248, 79)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbltelefono.TabIndex = 89
        Me.lbltelefono.Text = "Teléfono"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(108, 75)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcorreo.MaxLength = 50
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(135, 20)
        Me.txtcorreo.TabIndex = 94
        Me.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Location = New System.Drawing.Point(64, 75)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblcorreo.TabIndex = 93
        Me.lblcorreo.Text = "Correo"
        '
        'txtcorreo2
        '
        Me.txtcorreo2.Location = New System.Drawing.Point(109, 98)
        Me.txtcorreo2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcorreo2.MaxLength = 50
        Me.txtcorreo2.Name = "txtcorreo2"
        Me.txtcorreo2.Size = New System.Drawing.Size(135, 20)
        Me.txtcorreo2.TabIndex = 96
        Me.txtcorreo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblcorreo2
        '
        Me.lblcorreo2.AutoSize = True
        Me.lblcorreo2.Location = New System.Drawing.Point(56, 100)
        Me.lblcorreo2.Name = "lblcorreo2"
        Me.lblcorreo2.Size = New System.Drawing.Size(47, 13)
        Me.lblcorreo2.TabIndex = 95
        Me.lblcorreo2.Text = "Correo 2"
        '
        'btnbuscarEspecialidad
        '
        Me.btnbuscarEspecialidad.BackColor = System.Drawing.Color.White
        Me.btnbuscarEspecialidad.BackgroundImage = CType(resources.GetObject("btnbuscarEspecialidad.BackgroundImage"), System.Drawing.Image)
        Me.btnbuscarEspecialidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbuscarEspecialidad.FlatAppearance.BorderSize = 0
        Me.btnbuscarEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarEspecialidad.Location = New System.Drawing.Point(107, 120)
        Me.btnbuscarEspecialidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscarEspecialidad.Name = "btnbuscarEspecialidad"
        Me.btnbuscarEspecialidad.Size = New System.Drawing.Size(37, 18)
        Me.btnbuscarEspecialidad.TabIndex = 105
        Me.btnbuscarEspecialidad.Text = "..."
        Me.btnbuscarEspecialidad.UseVisualStyleBackColor = False
        '
        'txtcodigoEspecialidad
        '
        Me.txtcodigoEspecialidad.Location = New System.Drawing.Point(149, 122)
        Me.txtcodigoEspecialidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigoEspecialidad.MaxLength = 20
        Me.txtcodigoEspecialidad.Name = "txtcodigoEspecialidad"
        Me.txtcodigoEspecialidad.Size = New System.Drawing.Size(95, 20)
        Me.txtcodigoEspecialidad.TabIndex = 104
        Me.txtcodigoEspecialidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblespecialidad
        '
        Me.lblespecialidad.AutoSize = True
        Me.lblespecialidad.Location = New System.Drawing.Point(36, 123)
        Me.lblespecialidad.Name = "lblespecialidad"
        Me.lblespecialidad.Size = New System.Drawing.Size(67, 13)
        Me.lblespecialidad.TabIndex = 103
        Me.lblespecialidad.Text = "Especialidad"
        '
        'txtnombreCompleto
        '
        Me.txtnombreCompleto.Location = New System.Drawing.Point(109, 52)
        Me.txtnombreCompleto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreCompleto.MaxLength = 100
        Me.txtnombreCompleto.Name = "txtnombreCompleto"
        Me.txtnombreCompleto.Size = New System.Drawing.Size(327, 20)
        Me.txtnombreCompleto.TabIndex = 107
        Me.txtnombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnombreCompleto
        '
        Me.lblnombreCompleto.AutoSize = True
        Me.lblnombreCompleto.Location = New System.Drawing.Point(13, 54)
        Me.lblnombreCompleto.Name = "lblnombreCompleto"
        Me.lblnombreCompleto.Size = New System.Drawing.Size(91, 13)
        Me.lblnombreCompleto.TabIndex = 106
        Me.lblnombreCompleto.Text = "Nombre Completo"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncancelar.Location = New System.Drawing.Point(250, 167)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(68, 28)
        Me.btncancelar.TabIndex = 109
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnguardar.Location = New System.Drawing.Point(99, 167)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(72, 28)
        Me.btnguardar.TabIndex = 108
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnnuevo.Location = New System.Drawing.Point(16, 167)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(79, 28)
        Me.btnnuevo.TabIndex = 110
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'gbxmedico
        '
        Me.gbxmedico.Controls.Add(Me.txtnombreEspecialidad)
        Me.gbxmedico.Controls.Add(Me.btnmodificar)
        Me.gbxmedico.Controls.Add(Me.lblcodigo)
        Me.gbxmedico.Controls.Add(Me.btnnuevo)
        Me.gbxmedico.Controls.Add(Me.txtcodigo)
        Me.gbxmedico.Controls.Add(Me.btncancelar)
        Me.gbxmedico.Controls.Add(Me.lbltelefono)
        Me.gbxmedico.Controls.Add(Me.btnguardar)
        Me.gbxmedico.Controls.Add(Me.txttelefono)
        Me.gbxmedico.Controls.Add(Me.txtnombreCompleto)
        Me.gbxmedico.Controls.Add(Me.lblcelular)
        Me.gbxmedico.Controls.Add(Me.lblnombreCompleto)
        Me.gbxmedico.Controls.Add(Me.txtcelular)
        Me.gbxmedico.Controls.Add(Me.btnbuscarEspecialidad)
        Me.gbxmedico.Controls.Add(Me.lblcorreo2)
        Me.gbxmedico.Controls.Add(Me.txtcodigoEspecialidad)
        Me.gbxmedico.Controls.Add(Me.txtcorreo2)
        Me.gbxmedico.Controls.Add(Me.lblespecialidad)
        Me.gbxmedico.Controls.Add(Me.lblcorreo)
        Me.gbxmedico.Controls.Add(Me.txtcorreo)
        Me.gbxmedico.Location = New System.Drawing.Point(17, 18)
        Me.gbxmedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxmedico.Name = "gbxmedico"
        Me.gbxmedico.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxmedico.Size = New System.Drawing.Size(690, 211)
        Me.gbxmedico.TabIndex = 111
        Me.gbxmedico.TabStop = False
        Me.gbxmedico.Text = "REGISTRAR MÉDICO"
        '
        'txtnombreEspecialidad
        '
        Me.txtnombreEspecialidad.Location = New System.Drawing.Point(250, 122)
        Me.txtnombreEspecialidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreEspecialidad.Name = "txtnombreEspecialidad"
        Me.txtnombreEspecialidad.ReadOnly = True
        Me.txtnombreEspecialidad.Size = New System.Drawing.Size(186, 20)
        Me.txtnombreEspecialidad.TabIndex = 114
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnmodificar.Location = New System.Drawing.Point(175, 167)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 28)
        Me.btnmodificar.TabIndex = 111
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblnombre)
        Me.gbxbusqueda.Location = New System.Drawing.Point(17, 234)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(690, 245)
        Me.gbxbusqueda.TabIndex = 112
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR MÉDICO"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(129, 221)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 46)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(682, 173)
        Me.dgbtabla.TabIndex = 22
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(13, 221)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(112, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE MÉDICOS"
        '
        'txtnombreB
        '
        Me.txtnombreB.Location = New System.Drawing.Point(52, 22)
        Me.txtnombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombreB.MaxLength = 100
        Me.txtnombreB.Name = "txtnombreB"
        Me.txtnombreB.Size = New System.Drawing.Size(634, 20)
        Me.txtnombreB.TabIndex = 115
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(4, 24)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 114
        Me.lblnombre.Text = "Nombre"
        '
        'M_Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 505)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Controls.Add(Me.gbxmedico)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_Medico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Médico"
        Me.gbxmedico.ResumeLayout(False)
        Me.gbxmedico.PerformLayout()
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents lblcodigo As Label
    Friend WithEvents txtcelular As TextBox
    Friend WithEvents lblcelular As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents lbltelefono As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents lblcorreo As Label
    Friend WithEvents txtcorreo2 As TextBox
    Friend WithEvents lblcorreo2 As Label
    Friend WithEvents btnbuscarEspecialidad As Button
    Friend WithEvents txtcodigoEspecialidad As TextBox
    Friend WithEvents lblespecialidad As Label
    Friend WithEvents txtnombreCompleto As TextBox
    Friend WithEvents lblnombreCompleto As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents gbxmedico As GroupBox
    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtnombreB As TextBox
    Friend WithEvents lblnombre As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents btnmodificar As Button
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtnombreEspecialidad As TextBox
End Class
