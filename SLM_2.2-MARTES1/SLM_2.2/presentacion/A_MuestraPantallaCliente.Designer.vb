<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class A_MuestraPantallaCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_MuestraPantallaCliente))
        Me.dtPacientesEspera = New System.Windows.Forms.DataGridView()
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbxVideos = New System.Windows.Forms.ComboBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dtPacientesEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtPacientesEspera
        '
        Me.dtPacientesEspera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtPacientesEspera.BackgroundColor = System.Drawing.Color.White
        Me.dtPacientesEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtPacientesEspera.Location = New System.Drawing.Point(12, 109)
        Me.dtPacientesEspera.Name = "dtPacientesEspera"
        Me.dtPacientesEspera.Size = New System.Drawing.Size(445, 415)
        Me.dtPacientesEspera.TabIndex = 0
        '
        'WMP
        '
        Me.WMP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(463, 109)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(417, 415)
        Me.WMP.TabIndex = 2
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblHora.Location = New System.Drawing.Point(594, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(217, 73)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "HORA"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblFecha.Location = New System.Drawing.Point(595, 73)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(75, 24)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "FECHA"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'cbxVideos
        '
        Me.cbxVideos.FormattingEnabled = True
        Me.cbxVideos.Location = New System.Drawing.Point(349, 12)
        Me.cbxVideos.Name = "cbxVideos"
        Me.cbxVideos.Size = New System.Drawing.Size(121, 21)
        Me.cbxVideos.TabIndex = 6
        Me.cbxVideos.Visible = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'A_MuestraPantallaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 536)
        Me.Controls.Add(Me.cbxVideos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.dtPacientesEspera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_MuestraPantallaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtPacientesEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtPacientesEspera As DataGridView
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbxVideos As ComboBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
