﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblcontabilidad = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCotizacion = New System.Windows.Forms.Button()
        Me.lblfacturacion = New System.Windows.Forms.Label()
        Me.btnFacturacion = New System.Windows.Forms.Button()
        Me.lblcotizacion = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContabilidad
        '
        Me.btnContabilidad.BackColor = System.Drawing.Color.Transparent
        Me.btnContabilidad.BackgroundImage = CType(resources.GetObject("btnContabilidad.BackgroundImage"), System.Drawing.Image)
        Me.btnContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContabilidad.FlatAppearance.BorderSize = 0
        Me.btnContabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContabilidad.Location = New System.Drawing.Point(9, 22)
        Me.btnContabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContabilidad.Name = "btnContabilidad"
        Me.btnContabilidad.Size = New System.Drawing.Size(80, 70)
        Me.btnContabilidad.TabIndex = 0
        Me.btnContabilidad.UseVisualStyleBackColor = False
        '
        'lblcontabilidad
        '
        Me.lblcontabilidad.AutoSize = True
        Me.lblcontabilidad.Location = New System.Drawing.Point(8, 94)
        Me.lblcontabilidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontabilidad.Name = "lblcontabilidad"
        Me.lblcontabilidad.Size = New System.Drawing.Size(86, 17)
        Me.lblcontabilidad.TabIndex = 1
        Me.lblcontabilidad.Text = "Contabilidad"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(168, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 80)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcotizacion)
        Me.GroupBox1.Controls.Add(Me.btnCotizacion)
        Me.GroupBox1.Controls.Add(Me.lblfacturacion)
        Me.GroupBox1.Controls.Add(Me.btnFacturacion)
        Me.GroupBox1.Controls.Add(Me.btnContabilidad)
        Me.GroupBox1.Controls.Add(Me.lblcontabilidad)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(491, 336)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu de Opciones"
        '
        'btnCotizacion
        '
        Me.btnCotizacion.BackgroundImage = CType(resources.GetObject("btnCotizacion.BackgroundImage"), System.Drawing.Image)
        Me.btnCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCotizacion.FlatAppearance.BorderSize = 0
        Me.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizacion.Location = New System.Drawing.Point(216, 22)
        Me.btnCotizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCotizacion.Name = "btnCotizacion"
        Me.btnCotizacion.Size = New System.Drawing.Size(80, 70)
        Me.btnCotizacion.TabIndex = 4
        Me.btnCotizacion.UseVisualStyleBackColor = True
        '
        'lblfacturacion
        '
        Me.lblfacturacion.AutoSize = True
        Me.lblfacturacion.Location = New System.Drawing.Point(108, 94)
        Me.lblfacturacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfacturacion.Name = "lblfacturacion"
        Me.lblfacturacion.Size = New System.Drawing.Size(82, 17)
        Me.lblfacturacion.TabIndex = 3
        Me.lblfacturacion.Text = "Facturación"
        '
        'btnFacturacion
        '
        Me.btnFacturacion.BackgroundImage = CType(resources.GetObject("btnFacturacion.BackgroundImage"), System.Drawing.Image)
        Me.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFacturacion.FlatAppearance.BorderSize = 0
        Me.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturacion.Location = New System.Drawing.Point(109, 22)
        Me.btnFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Size = New System.Drawing.Size(80, 70)
        Me.btnFacturacion.TabIndex = 2
        Me.btnFacturacion.UseVisualStyleBackColor = True
        '
        'lblcotizacion
        '
        Me.lblcotizacion.AutoSize = True
        Me.lblcotizacion.Location = New System.Drawing.Point(222, 94)
        Me.lblcotizacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcotizacion.Name = "lblcotizacion"
        Me.lblcotizacion.Size = New System.Drawing.Size(73, 17)
        Me.lblcotizacion.TabIndex = 5
        Me.lblcotizacion.Text = "Cotización"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(523, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnContabilidad As Button
    Friend WithEvents lblcontabilidad As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblfacturacion As Label
    Friend WithEvents btnFacturacion As Button
    Friend WithEvents btnCotizacion As Button
    Friend WithEvents lblcotizacion As Label
End Class
