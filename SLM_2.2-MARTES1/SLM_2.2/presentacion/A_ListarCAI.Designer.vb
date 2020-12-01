<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_ListarCAI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_ListarCAI))
        Me.gbxRegistros = New System.Windows.Forms.GroupBox()
        Me.dtCAIS = New System.Windows.Forms.DataGridView()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.gbxRegistros.SuspendLayout()
        CType(Me.dtCAIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRegistros
        '
        Me.gbxRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxRegistros.BackColor = System.Drawing.Color.AliceBlue
        Me.gbxRegistros.Controls.Add(Me.dtCAIS)
        Me.gbxRegistros.Location = New System.Drawing.Point(12, 12)
        Me.gbxRegistros.Name = "gbxRegistros"
        Me.gbxRegistros.Size = New System.Drawing.Size(515, 397)
        Me.gbxRegistros.TabIndex = 0
        Me.gbxRegistros.TabStop = False
        Me.gbxRegistros.Text = "Registros"
        '
        'dtCAIS
        '
        Me.dtCAIS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtCAIS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtCAIS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtCAIS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtCAIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCAIS.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtCAIS.Location = New System.Drawing.Point(6, 19)
        Me.dtCAIS.Name = "dtCAIS"
        Me.dtCAIS.ReadOnly = True
        Me.dtCAIS.RowHeadersWidth = 51
        Me.dtCAIS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtCAIS.Size = New System.Drawing.Size(503, 372)
        Me.dtCAIS.TabIndex = 0
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(366, 415)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(75, 23)
        Me.btnCrear.TabIndex = 1
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(452, 415)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 444)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(535, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'A_ListarCAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(535, 466)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.gbxRegistros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "A_ListarCAI"
        Me.Text = "Registros"
        Me.gbxRegistros.ResumeLayout(False)
        CType(Me.dtCAIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxRegistros As GroupBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents dtCAIS As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
