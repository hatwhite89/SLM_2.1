<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_Alertas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_Alertas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtNotificaciones = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnVerificado = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtNotificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtNotificaciones)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 241)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notificaciones "
        '
        'dtNotificaciones
        '
        Me.dtNotificaciones.AllowUserToAddRows = False
        Me.dtNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtNotificaciones.Location = New System.Drawing.Point(3, 16)
        Me.dtNotificaciones.Name = "dtNotificaciones"
        Me.dtNotificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtNotificaciones.Size = New System.Drawing.Size(554, 222)
        Me.dtNotificaciones.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(418, 256)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnVerificado
        '
        Me.btnVerificado.Location = New System.Drawing.Point(497, 256)
        Me.btnVerificado.Name = "btnVerificado"
        Me.btnVerificado.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificado.TabIndex = 2
        Me.btnVerificado.Text = "Verificado"
        Me.btnVerificado.UseVisualStyleBackColor = True
        '
        'A_Alertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 298)
        Me.Controls.Add(Me.btnVerificado)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_Alertas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notificaciones del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtNotificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtNotificaciones As DataGridView
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnVerificado As Button
End Class
