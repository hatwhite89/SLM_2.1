﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_BuscarRecibo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.txtReferenciaB = New System.Windows.Forms.TextBox()
        Me.txtNumeroB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblReferencia)
        Me.GroupBox1.Controls.Add(Me.lblNumero)
        Me.GroupBox1.Controls.Add(Me.lblcantidad)
        Me.GroupBox1.Controls.Add(Me.btnnueva)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.dgbtabla)
        Me.GroupBox1.Controls.Add(Me.txtReferenciaB)
        Me.GroupBox1.Controls.Add(Me.txtNumeroB)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(928, 630)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda Recibo"
        '
        'lblReferencia
        '
        Me.lblReferencia.AutoSize = True
        Me.lblReferencia.Location = New System.Drawing.Point(308, 33)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(77, 17)
        Me.lblReferencia.TabIndex = 123
        Me.lblReferencia.Text = "Referencia"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(17, 33)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(58, 17)
        Me.lblNumero.TabIndex = 122
        Me.lblNumero.Text = "Número"
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(295, 612)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(32, 17)
        Me.lblcantidad.TabIndex = 117
        Me.lblcantidad.Text = "000"
        '
        'btnnueva
        '
        Me.btnnueva.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnnueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueva.ForeColor = System.Drawing.Color.White
        Me.btnnueva.Location = New System.Drawing.Point(704, 31)
        Me.btnnueva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(219, 34)
        Me.btnnueva.TabIndex = 121
        Me.btnnueva.Text = "Nuevo Recibo"
        Me.btnnueva.UseVisualStyleBackColor = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(5, 612)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(141, 17)
        Me.lbltotal.TabIndex = 116
        Me.lbltotal.Text = "TOTAL DE RECIBOS"
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(5, 87)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.Size = New System.Drawing.Size(917, 497)
        Me.dgbtabla.TabIndex = 2
        '
        'txtReferenciaB
        '
        Me.txtReferenciaB.Location = New System.Drawing.Point(392, 31)
        Me.txtReferenciaB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReferenciaB.Name = "txtReferenciaB"
        Me.txtReferenciaB.Size = New System.Drawing.Size(192, 22)
        Me.txtReferenciaB.TabIndex = 1
        '
        'txtNumeroB
        '
        Me.txtNumeroB.Location = New System.Drawing.Point(83, 31)
        Me.txtNumeroB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumeroB.Name = "txtNumeroB"
        Me.txtNumeroB.Size = New System.Drawing.Size(192, 22)
        Me.txtNumeroB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "Fecha Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Fecha Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Comentario"
        '
        'M_BuscarRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(957, 657)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "M_BuscarRecibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Recibos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents txtReferenciaB As TextBox
    Friend WithEvents txtNumeroB As TextBox
    Friend WithEvents btnnueva As Button
    Friend WithEvents lblReferencia As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class