﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_ListarUnidades
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
        Me.gbxbusqueda = New System.Windows.Forms.GroupBox()
        Me.txtCodigoB = New System.Windows.Forms.TextBox()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lbltipoCta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtDescripcionB = New System.Windows.Forms.TextBox()
        Me.lblCodigoT = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.txtCodigoB)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lbltipoCta)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtDescripcionB)
        Me.gbxbusqueda.Controls.Add(Me.lblCodigoT)
        Me.gbxbusqueda.Location = New System.Drawing.Point(62, 21)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(624, 598)
        Me.gbxbusqueda.TabIndex = 121
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR UNIDADES"
        '
        'txtCodigoB
        '
        Me.txtCodigoB.Location = New System.Drawing.Point(111, 29)
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Size = New System.Drawing.Size(192, 22)
        Me.txtCodigoB.TabIndex = 120
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(43, 74)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(536, 476)
        Me.dgbtabla.TabIndex = 119
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(321, 32)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(58, 17)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Nombre"
        '
        'lbltipoCta
        '
        Me.lbltipoCta.AutoSize = True
        Me.lbltipoCta.Location = New System.Drawing.Point(285, 182)
        Me.lbltipoCta.Name = "lbltipoCta"
        Me.lbltipoCta.Size = New System.Drawing.Size(0, 17)
        Me.lbltipoCta.TabIndex = 116
        Me.lbltipoCta.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(434, 564)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(107, 564)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(151, 17)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE UNIDADES"
        '
        'txtDescripcionB
        '
        Me.txtDescripcionB.Location = New System.Drawing.Point(385, 29)
        Me.txtDescripcionB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcionB.MaxLength = 80
        Me.txtDescripcionB.Name = "txtDescripcionB"
        Me.txtDescripcionB.Size = New System.Drawing.Size(192, 22)
        Me.txtDescripcionB.TabIndex = 115
        '
        'lblCodigoT
        '
        Me.lblCodigoT.AutoSize = True
        Me.lblCodigoT.Location = New System.Drawing.Point(39, 33)
        Me.lblCodigoT.Name = "lblCodigoT"
        Me.lblCodigoT.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigoT.TabIndex = 114
        Me.lblCodigoT.Text = "Código"
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(12, 129)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(51, 17)
        Me.lblFila.TabIndex = 121
        Me.lblFila.Text = "Label1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 180)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 17)
        Me.lblNombre.TabIndex = 122
        Me.lblNombre.Text = "Label1"
        '
        'E_ListarUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 641)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblFila)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.Name = "E_ListarUnidades"
        Me.Text = "E_ListarUnidades"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents txtCodigoB As TextBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lbltipoCta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtDescripcionB As TextBox
    Friend WithEvents lblCodigoT As Label
    Friend WithEvents lblFila As Label
    Friend WithEvents lblNombre As Label
End Class