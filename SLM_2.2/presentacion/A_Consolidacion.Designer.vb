<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_Consolidacion
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
        Me.dtTransferencia = New System.Windows.Forms.DataGridView()
        Me.gbxTransferencias = New System.Windows.Forms.GroupBox()
        Me.cbxTransferencia = New System.Windows.Forms.ComboBox()
        Me.txtCodBanco = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnBanco = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxConsolidacion = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarExcel = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.dtExcel = New System.Windows.Forms.DataGridView()
        Me.btnImportar = New System.Windows.Forms.Button()
        CType(Me.dtTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTransferencias.SuspendLayout()
        Me.gbxConsolidacion.SuspendLayout()
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTransferencia
        '
        Me.dtTransferencia.AllowUserToAddRows = False
        Me.dtTransferencia.AllowUserToDeleteRows = False
        Me.dtTransferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTransferencia.Location = New System.Drawing.Point(6, 83)
        Me.dtTransferencia.MultiSelect = False
        Me.dtTransferencia.Name = "dtTransferencia"
        Me.dtTransferencia.ReadOnly = True
        Me.dtTransferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtTransferencia.Size = New System.Drawing.Size(458, 458)
        Me.dtTransferencia.TabIndex = 0
        '
        'gbxTransferencias
        '
        Me.gbxTransferencias.Controls.Add(Me.cbxTransferencia)
        Me.gbxTransferencias.Controls.Add(Me.txtCodBanco)
        Me.gbxTransferencias.Controls.Add(Me.btnLimpiar)
        Me.gbxTransferencias.Controls.Add(Me.btnConsultar)
        Me.gbxTransferencias.Controls.Add(Me.btnBanco)
        Me.gbxTransferencias.Controls.Add(Me.Label2)
        Me.gbxTransferencias.Controls.Add(Me.txtBanco)
        Me.gbxTransferencias.Controls.Add(Me.Label1)
        Me.gbxTransferencias.Controls.Add(Me.dtTransferencia)
        Me.gbxTransferencias.Location = New System.Drawing.Point(12, 12)
        Me.gbxTransferencias.Name = "gbxTransferencias"
        Me.gbxTransferencias.Size = New System.Drawing.Size(470, 547)
        Me.gbxTransferencias.TabIndex = 1
        Me.gbxTransferencias.TabStop = False
        Me.gbxTransferencias.Text = "Transferencias Registradas"
        '
        'cbxTransferencia
        '
        Me.cbxTransferencia.FormattingEnabled = True
        Me.cbxTransferencia.Items.AddRange(New Object() {"Depositos", "Cheques"})
        Me.cbxTransferencia.Location = New System.Drawing.Point(91, 49)
        Me.cbxTransferencia.Name = "cbxTransferencia"
        Me.cbxTransferencia.Size = New System.Drawing.Size(176, 21)
        Me.cbxTransferencia.TabIndex = 11
        '
        'txtCodBanco
        '
        Me.txtCodBanco.Enabled = False
        Me.txtCodBanco.Location = New System.Drawing.Point(91, 23)
        Me.txtCodBanco.Name = "txtCodBanco"
        Me.txtCodBanco.Size = New System.Drawing.Size(36, 20)
        Me.txtCodBanco.TabIndex = 10
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(384, 47)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(303, 47)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnBanco
        '
        Me.btnBanco.Location = New System.Drawing.Point(273, 21)
        Me.btnBanco.Name = "btnBanco"
        Me.btnBanco.Size = New System.Drawing.Size(24, 23)
        Me.btnBanco.TabIndex = 5
        Me.btnBanco.Text = "..."
        Me.btnBanco.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transferencia:"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(132, 23)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(135, 20)
        Me.txtBanco.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco:"
        '
        'gbxConsolidacion
        '
        Me.gbxConsolidacion.Controls.Add(Me.btnLimpiarExcel)
        Me.gbxConsolidacion.Controls.Add(Me.btnProcesar)
        Me.gbxConsolidacion.Controls.Add(Me.dtExcel)
        Me.gbxConsolidacion.Controls.Add(Me.btnImportar)
        Me.gbxConsolidacion.Location = New System.Drawing.Point(498, 12)
        Me.gbxConsolidacion.Name = "gbxConsolidacion"
        Me.gbxConsolidacion.Size = New System.Drawing.Size(470, 547)
        Me.gbxConsolidacion.TabIndex = 2
        Me.gbxConsolidacion.TabStop = False
        Me.gbxConsolidacion.Text = "Consolidar"
        '
        'btnLimpiarExcel
        '
        Me.btnLimpiarExcel.Location = New System.Drawing.Point(190, 25)
        Me.btnLimpiarExcel.Name = "btnLimpiarExcel"
        Me.btnLimpiarExcel.Size = New System.Drawing.Size(84, 52)
        Me.btnLimpiarExcel.TabIndex = 5
        Me.btnLimpiarExcel.Text = "Limpiar"
        Me.btnLimpiarExcel.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(96, 23)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(88, 52)
        Me.btnProcesar.TabIndex = 4
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'dtExcel
        '
        Me.dtExcel.AllowUserToAddRows = False
        Me.dtExcel.AllowUserToDeleteRows = False
        Me.dtExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtExcel.Location = New System.Drawing.Point(6, 83)
        Me.dtExcel.MultiSelect = False
        Me.dtExcel.Name = "dtExcel"
        Me.dtExcel.ReadOnly = True
        Me.dtExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtExcel.Size = New System.Drawing.Size(458, 458)
        Me.dtExcel.TabIndex = 0
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(6, 23)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(84, 52)
        Me.btnImportar.TabIndex = 3
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'A_Consolidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 568)
        Me.Controls.Add(Me.gbxConsolidacion)
        Me.Controls.Add(Me.gbxTransferencias)
        Me.Name = "A_Consolidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidación"
        CType(Me.dtTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTransferencias.ResumeLayout(False)
        Me.gbxTransferencias.PerformLayout()
        Me.gbxConsolidacion.ResumeLayout(False)
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtTransferencia As DataGridView
    Friend WithEvents gbxTransferencias As GroupBox
    Friend WithEvents btnBanco As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbxConsolidacion As GroupBox
    Friend WithEvents btnProcesar As Button
    Friend WithEvents dtExcel As DataGridView
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnLimpiarExcel As Button
    Friend WithEvents txtCodBanco As TextBox
    Friend WithEvents cbxTransferencia As ComboBox
End Class
