<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_frmGraficaEstatica
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series25 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series26 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series27 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series28 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series29 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series30 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Slm_testDataSet3 = New SLM_2._2.slm_testDataSet3()
        Me.Slm_testDataSet = New SLM_2._2.slm_testDataSet()
        Me.SlmtestDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DATOS_TableAdapter = New SLM_2._2.slm_testDataSet3TableAdapters.DATOS_TableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.save_btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DATOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slm_testDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Slm_testDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SlmtestDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.save_btn)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(893, 392)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(885, 366)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Grafico"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(810, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 13)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox1.Location = New System.Drawing.Point(810, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 13)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(810, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "______"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(808, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "............"
        '
        'Chart1
        '
        ChartArea5.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea5)
        Me.Chart1.Location = New System.Drawing.Point(6, 119)
        Me.Chart1.Name = "Chart1"
        Series25.ChartArea = "ChartArea1"
        Series25.IsVisibleInLegend = False
        Series25.MarkerSize = 10
        Series25.Name = "Series1"
        Series26.ChartArea = "ChartArea1"
        Series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series26.MarkerBorderWidth = 5
        Series26.MarkerSize = 10
        Series26.Name = "Series2"
        Series27.ChartArea = "ChartArea1"
        Series27.Name = "Series3"
        Series28.ChartArea = "ChartArea1"
        Series28.Name = "Series4"
        Series29.ChartArea = "ChartArea1"
        Series29.Name = "Series5"
        Series30.ChartArea = "ChartArea1"
        Series30.Name = "Series6"
        Me.Chart1.Series.Add(Series25)
        Me.Chart1.Series.Add(Series26)
        Me.Chart1.Series.Add(Series27)
        Me.Chart1.Series.Add(Series28)
        Me.Chart1.Series.Add(Series29)
        Me.Chart1.Series.Add(Series30)
        Me.Chart1.Size = New System.Drawing.Size(536, 260)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(635, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PACIENTE, SANGRE INCUBADA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(648, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PACIENTE, SANGRE FRESCA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "INTERVALO NORMAL DE LA SANGRE FRESCA INCUBADA A 37 ºC, 24hrs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(547, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INTERVALO NORMAL DE LA SANGRE FRESCA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEDICO:"
        '
        'save_btn
        '
        Me.save_btn.Controls.Add(Me.Button1)
        Me.save_btn.Controls.Add(Me.DataGridView1)
        Me.save_btn.Location = New System.Drawing.Point(4, 22)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Padding = New System.Windows.Forms.Padding(3)
        Me.save_btn.Size = New System.Drawing.Size(885, 366)
        Me.save_btn.TabIndex = 1
        Me.save_btn.Text = "Datos"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(804, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guardar Datos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.f1, Me.f2, Me.f22, Me.f4, Me.f5, Me.f6, Me.f8})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(795, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'f1
        '
        Me.f1.DataPropertyName = "f1"
        Me.f1.HeaderText = "ESCALA"
        Me.f1.Name = "f1"
        '
        'f2
        '
        Me.f2.DataPropertyName = "f2"
        Me.f2.HeaderText = "INTERVALO NORMAL SANGRE INCUBADA"
        Me.f2.Name = "f2"
        '
        'f22
        '
        Me.f22.DataPropertyName = "f3"
        Me.f22.HeaderText = "INTERVALO NORMAL SANGRE FRESCA"
        Me.f22.Name = "f22"
        '
        'f4
        '
        Me.f4.DataPropertyName = "f4"
        Me.f4.HeaderText = "INTERVALO NORMAL SANGRE FRESCA"
        Me.f4.Name = "f4"
        '
        'f5
        '
        Me.f5.DataPropertyName = "f5"
        Me.f5.HeaderText = "INTERVALO NORMAL SANGRE INCUBADA"
        Me.f5.Name = "f5"
        '
        'f6
        '
        Me.f6.DataPropertyName = "f6"
        Me.f6.HeaderText = "PACIENTE SANGRE FRESCA"
        Me.f6.Name = "f6"
        '
        'f8
        '
        Me.f8.DataPropertyName = "f7"
        Me.f8.HeaderText = "PACIENTE SANGRE ENCUBADA"
        Me.f8.Name = "f8"
        '
        'DATOSBindingSource
        '
        Me.DATOSBindingSource.DataMember = "DATOS$"
        Me.DATOSBindingSource.DataSource = Me.Slm_testDataSet3
        '
        'Slm_testDataSet3
        '
        Me.Slm_testDataSet3.DataSetName = "slm_testDataSet3"
        Me.Slm_testDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Slm_testDataSet
        '
        Me.Slm_testDataSet.DataSetName = "slm_testDataSet"
        Me.Slm_testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SlmtestDataSetBindingSource
        '
        Me.SlmtestDataSetBindingSource.DataSource = Me.Slm_testDataSet
        Me.SlmtestDataSetBindingSource.Position = 0
        '
        'DATOS_TableAdapter
        '
        Me.DATOS_TableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(160, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(284, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(710, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Firma"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 455)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(917, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 52)
        Me.Panel1.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Ingrese la orden de trabajo"
        '
        'E_frmGraficaEstatica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(917, 477)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "E_frmGraficaEstatica"
        Me.Text = "E_frmGraficaEstatica"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.save_btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DATOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slm_testDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Slm_testDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SlmtestDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents save_btn As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Slm_testDataSet As slm_testDataSet
    Friend WithEvents SlmtestDataSetBindingSource As BindingSource
    Friend WithEvents Slm_testDataSet3 As slm_testDataSet3
    Friend WithEvents DATOSBindingSource As BindingSource
    Friend WithEvents DATOS_TableAdapter As slm_testDataSet3TableAdapters.DATOS_TableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents f2 As DataGridViewTextBoxColumn
    Friend WithEvents f22 As DataGridViewTextBoxColumn
    Friend WithEvents f4 As DataGridViewTextBoxColumn
    Friend WithEvents f5 As DataGridViewTextBoxColumn
    Friend WithEvents f6 As DataGridViewTextBoxColumn
    Friend WithEvents f8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
