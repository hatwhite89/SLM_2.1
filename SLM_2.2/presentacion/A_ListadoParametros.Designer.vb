﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoParametros
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtParametros = New System.Windows.Forms.DataGridView()
        Me.lblFormulario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodExamen = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCodExamen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblFormulario)
        Me.GroupBox1.Controls.Add(Me.dtParametros)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro de Parámetros"
        '
        'dtParametros
        '
        Me.dtParametros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtParametros.BackgroundColor = System.Drawing.Color.White
        Me.dtParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtParametros.Location = New System.Drawing.Point(6, 54)
        Me.dtParametros.MultiSelect = False
        Me.dtParametros.Name = "dtParametros"
        Me.dtParametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtParametros.Size = New System.Drawing.Size(576, 227)
        Me.dtParametros.TabIndex = 0
        '
        'lblFormulario
        '
        Me.lblFormulario.AutoSize = True
        Me.lblFormulario.Location = New System.Drawing.Point(436, -3)
        Me.lblFormulario.Name = "lblFormulario"
        Me.lblFormulario.Size = New System.Drawing.Size(27, 13)
        Me.lblFormulario.TabIndex = 1
        Me.lblFormulario.Text = "form"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cod. Exámen"
        '
        'txtCodExamen
        '
        Me.txtCodExamen.Location = New System.Drawing.Point(82, 24)
        Me.txtCodExamen.MaxLength = 10
        Me.txtCodExamen.Name = "txtCodExamen"
        Me.txtCodExamen.Size = New System.Drawing.Size(100, 20)
        Me.txtCodExamen.TabIndex = 3
        '
        'A_ListadoParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "A_ListadoParametros"
        Me.Text = "A_ListadoParametros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtParametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtParametros As DataGridView
    Friend WithEvents lblFormulario As Label
    Friend WithEvents txtCodExamen As TextBox
    Friend WithEvents Label1 As Label
End Class
