﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListadoBancos
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
        Me.dtBancos = New System.Windows.Forms.DataGridView()
        Me.lblFormBanco = New System.Windows.Forms.Label()
        CType(Me.dtBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtBancos
        '
        Me.dtBancos.AllowUserToAddRows = False
        Me.dtBancos.AllowUserToDeleteRows = False
        Me.dtBancos.BackgroundColor = System.Drawing.Color.White
        Me.dtBancos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtBancos.GridColor = System.Drawing.Color.White
        Me.dtBancos.Location = New System.Drawing.Point(12, 25)
        Me.dtBancos.Name = "dtBancos"
        Me.dtBancos.ReadOnly = True
        Me.dtBancos.RowHeadersVisible = False
        Me.dtBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtBancos.Size = New System.Drawing.Size(694, 264)
        Me.dtBancos.TabIndex = 3
        '
        'lblFormBanco
        '
        Me.lblFormBanco.AutoSize = True
        Me.lblFormBanco.Location = New System.Drawing.Point(12, 9)
        Me.lblFormBanco.Name = "lblFormBanco"
        Me.lblFormBanco.Size = New System.Drawing.Size(27, 13)
        Me.lblFormBanco.TabIndex = 4
        Me.lblFormBanco.Text = "LblF"
        Me.lblFormBanco.Visible = False
        '
        'A_ListadoBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 298)
        Me.Controls.Add(Me.lblFormBanco)
        Me.Controls.Add(Me.dtBancos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "A_ListadoBancos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione un banco"
        CType(Me.dtBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtBancos As DataGridView
    Friend WithEvents lblFormBanco As Label
End Class
