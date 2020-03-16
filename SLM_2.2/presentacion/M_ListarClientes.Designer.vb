<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_ListarClientes
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
        Me.txtIdentidadB = New System.Windows.Forms.TextBox()
        Me.dgbtabla = New System.Windows.Forms.DataGridView()
        Me.lblnombreB = New System.Windows.Forms.Label()
        Me.lbltipoCta = New System.Windows.Forms.Label()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtNombreB = New System.Windows.Forms.TextBox()
        Me.lblIdentidadB = New System.Windows.Forms.Label()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.gbxbusqueda.SuspendLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxbusqueda
        '
        Me.gbxbusqueda.Controls.Add(Me.txtIdentidadB)
        Me.gbxbusqueda.Controls.Add(Me.dgbtabla)
        Me.gbxbusqueda.Controls.Add(Me.lblnombreB)
        Me.gbxbusqueda.Controls.Add(Me.lbltipoCta)
        Me.gbxbusqueda.Controls.Add(Me.lblcantidad)
        Me.gbxbusqueda.Controls.Add(Me.lbltotal)
        Me.gbxbusqueda.Controls.Add(Me.txtNombreB)
        Me.gbxbusqueda.Controls.Add(Me.lblIdentidadB)
        Me.gbxbusqueda.Location = New System.Drawing.Point(11, 11)
        Me.gbxbusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Name = "gbxbusqueda"
        Me.gbxbusqueda.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbxbusqueda.Size = New System.Drawing.Size(696, 500)
        Me.gbxbusqueda.TabIndex = 119
        Me.gbxbusqueda.TabStop = False
        Me.gbxbusqueda.Text = "BUSCAR CLIENTES"
        '
        'txtIdentidadB
        '
        Me.txtIdentidadB.Location = New System.Drawing.Point(83, 24)
        Me.txtIdentidadB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdentidadB.Name = "txtIdentidadB"
        Me.txtIdentidadB.Size = New System.Drawing.Size(145, 20)
        Me.txtIdentidadB.TabIndex = 120
        '
        'dgbtabla
        '
        Me.dgbtabla.AllowUserToAddRows = False
        Me.dgbtabla.AllowUserToDeleteRows = False
        Me.dgbtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbtabla.Location = New System.Drawing.Point(4, 60)
        Me.dgbtabla.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgbtabla.Name = "dgbtabla"
        Me.dgbtabla.ReadOnly = True
        Me.dgbtabla.RowHeadersWidth = 51
        Me.dgbtabla.RowTemplate.Height = 24
        Me.dgbtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbtabla.Size = New System.Drawing.Size(688, 404)
        Me.dgbtabla.TabIndex = 119
        '
        'lblnombreB
        '
        Me.lblnombreB.AutoSize = True
        Me.lblnombreB.Location = New System.Drawing.Point(241, 26)
        Me.lblnombreB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombreB.Name = "lblnombreB"
        Me.lblnombreB.Size = New System.Drawing.Size(44, 13)
        Me.lblnombreB.TabIndex = 117
        Me.lblnombreB.Text = "Nombre"
        '
        'lbltipoCta
        '
        Me.lbltipoCta.AutoSize = True
        Me.lbltipoCta.Location = New System.Drawing.Point(214, 148)
        Me.lbltipoCta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltipoCta.Name = "lbltipoCta"
        Me.lbltipoCta.Size = New System.Drawing.Size(0, 13)
        Me.lbltipoCta.TabIndex = 116
        Me.lbltipoCta.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(264, 476)
        Me.lblcantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(25, 13)
        Me.lblcantidad.TabIndex = 115
        Me.lblcantidad.Text = "000"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(18, 476)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(115, 13)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "TOTAL DE CLIENTES"
        '
        'txtNombreB
        '
        Me.txtNombreB.Location = New System.Drawing.Point(289, 24)
        Me.txtNombreB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombreB.MaxLength = 80
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Size = New System.Drawing.Size(403, 20)
        Me.txtNombreB.TabIndex = 115
        '
        'lblIdentidadB
        '
        Me.lblIdentidadB.AutoSize = True
        Me.lblIdentidadB.Location = New System.Drawing.Point(29, 27)
        Me.lblIdentidadB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdentidadB.Name = "lblIdentidadB"
        Me.lblIdentidadB.Size = New System.Drawing.Size(51, 13)
        Me.lblIdentidadB.TabIndex = 114
        Me.lblIdentidadB.Text = "Identidad"
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Location = New System.Drawing.Point(226, 7)
        Me.lblForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(0, 13)
        Me.lblForm.TabIndex = 120
        '
        'M_ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 526)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.gbxbusqueda)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "M_ListarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.gbxbusqueda.ResumeLayout(False)
        Me.gbxbusqueda.PerformLayout()
        CType(Me.dgbtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxbusqueda As GroupBox
    Friend WithEvents dgbtabla As DataGridView
    Friend WithEvents lblnombreB As Label
    Friend WithEvents lbltipoCta As Label
    Friend WithEvents lblcantidad As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtNombreB As TextBox
    Friend WithEvents lblIdentidadB As Label
    Friend WithEvents txtIdentidadB As TextBox
    Friend WithEvents lblForm As Label
End Class
