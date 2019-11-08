<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarDepositos
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
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTipoDep = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtnID = New System.Windows.Forms.RadioButton()
        Me.rbtnTipo = New System.Windows.Forms.RadioButton()
        Me.rbtnFormaP = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(185, 9)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(75, 13)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar por ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(277, 6)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(80, 20)
        Me.txtID.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(430, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'lblTipoDep
        '
        Me.lblTipoDep.AutoSize = True
        Me.lblTipoDep.Location = New System.Drawing.Point(185, 29)
        Me.lblTipoDep.Name = "lblTipoDep"
        Me.lblTipoDep.Size = New System.Drawing.Size(91, 13)
        Me.lblTipoDep.TabIndex = 3
        Me.lblTipoDep.Text = "Tipo de Deposito:"
        '
        'cbxTipo
        '
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Tarjeta", "Dep. Bancario"})
        Me.cbxTipo.Location = New System.Drawing.Point(277, 27)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(80, 21)
        Me.cbxTipo.TabIndex = 4
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.ForeColor = System.Drawing.Color.White
        Me.btnCargar.Location = New System.Drawing.Point(363, 49)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Forma de Pago:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(277, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Buscar por:"
        '
        'rbtnID
        '
        Me.rbtnID.AutoSize = True
        Me.rbtnID.Location = New System.Drawing.Point(72, 9)
        Me.rbtnID.Name = "rbtnID"
        Me.rbtnID.Size = New System.Drawing.Size(58, 17)
        Me.rbtnID.TabIndex = 9
        Me.rbtnID.TabStop = True
        Me.rbtnID.Text = "Código"
        Me.rbtnID.UseVisualStyleBackColor = True
        '
        'rbtnTipo
        '
        Me.rbtnTipo.AutoSize = True
        Me.rbtnTipo.Location = New System.Drawing.Point(72, 27)
        Me.rbtnTipo.Name = "rbtnTipo"
        Me.rbtnTipo.Size = New System.Drawing.Size(106, 17)
        Me.rbtnTipo.TabIndex = 10
        Me.rbtnTipo.TabStop = True
        Me.rbtnTipo.Text = "Tipo de Deposito"
        Me.rbtnTipo.UseVisualStyleBackColor = True
        '
        'rbtnFormaP
        '
        Me.rbtnFormaP.AutoSize = True
        Me.rbtnFormaP.Location = New System.Drawing.Point(72, 46)
        Me.rbtnFormaP.Name = "rbtnFormaP"
        Me.rbtnFormaP.Size = New System.Drawing.Size(97, 17)
        Me.rbtnFormaP.TabIndex = 11
        Me.rbtnFormaP.TabStop = True
        Me.rbtnFormaP.Text = "Forma de Pago"
        Me.rbtnFormaP.UseVisualStyleBackColor = True
        '
        'ListarDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 234)
        Me.Controls.Add(Me.rbtnFormaP)
        Me.Controls.Add(Me.rbtnTipo)
        Me.Controls.Add(Me.rbtnID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.lblTipoDep)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblBuscar)
        Me.Name = "ListarDepositos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListarDepositos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTipoDep As Label
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtnID As RadioButton
    Friend WithEvents rbtnTipo As RadioButton
    Friend WithEvents rbtnFormaP As RadioButton
End Class
