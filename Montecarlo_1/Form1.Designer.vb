<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea13 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend13 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea14 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend14 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea15 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend15 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea16 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend16 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.CienPuntos = New System.Windows.Forms.Button()
        Me.LimiteInferior = New System.Windows.Forms.TextBox()
        Me.LimiteSuperior = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart200 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart500 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1000 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PuntosDentro100 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CienPuntos
        '
        Me.CienPuntos.Location = New System.Drawing.Point(123, 128)
        Me.CienPuntos.Name = "CienPuntos"
        Me.CienPuntos.Size = New System.Drawing.Size(75, 23)
        Me.CienPuntos.TabIndex = 3
        Me.CienPuntos.Text = "Calcular"
        Me.CienPuntos.UseVisualStyleBackColor = True
        '
        'LimiteInferior
        '
        Me.LimiteInferior.Location = New System.Drawing.Point(53, 85)
        Me.LimiteInferior.Name = "LimiteInferior"
        Me.LimiteInferior.Size = New System.Drawing.Size(100, 20)
        Me.LimiteInferior.TabIndex = 7
        '
        'LimiteSuperior
        '
        Me.LimiteSuperior.Location = New System.Drawing.Point(171, 85)
        Me.LimiteSuperior.Name = "LimiteSuperior"
        Me.LimiteSuperior.Size = New System.Drawing.Size(100, 20)
        Me.LimiteSuperior.TabIndex = 8
        '
        'Chart1
        '
        ChartArea13.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea13)
        Legend13.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend13)
        Me.Chart1.Location = New System.Drawing.Point(307, 29)
        Me.Chart1.Name = "Chart1"
        Series13.ChartArea = "ChartArea1"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series13.Legend = "Legend1"
        Series13.Name = "Series1"
        Me.Chart1.Series.Add(Series13)
        Me.Chart1.Size = New System.Drawing.Size(464, 300)
        Me.Chart1.TabIndex = 9
        Me.Chart1.Text = "Chart1"
        '
        'Chart200
        '
        ChartArea14.Name = "ChartArea1"
        Me.Chart200.ChartAreas.Add(ChartArea14)
        Legend14.Name = "Legend1"
        Me.Chart200.Legends.Add(Legend14)
        Me.Chart200.Location = New System.Drawing.Point(777, 29)
        Me.Chart200.Name = "Chart200"
        Series14.ChartArea = "ChartArea1"
        Series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series14.Legend = "Legend1"
        Series14.Name = "Series2"
        Me.Chart200.Series.Add(Series14)
        Me.Chart200.Size = New System.Drawing.Size(447, 300)
        Me.Chart200.TabIndex = 10
        Me.Chart200.Text = "Chart2"
        '
        'Chart500
        '
        ChartArea15.Name = "ChartArea1"
        Me.Chart500.ChartAreas.Add(ChartArea15)
        Legend15.Name = "Legend1"
        Me.Chart500.Legends.Add(Legend15)
        Me.Chart500.Location = New System.Drawing.Point(307, 337)
        Me.Chart500.Name = "Chart500"
        Series15.ChartArea = "ChartArea1"
        Series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series15.Legend = "Legend1"
        Series15.Name = "Series1"
        Me.Chart500.Series.Add(Series15)
        Me.Chart500.Size = New System.Drawing.Size(464, 311)
        Me.Chart500.TabIndex = 11
        Me.Chart500.Text = "Chart3"
        '
        'Chart1000
        '
        ChartArea16.Name = "ChartArea1"
        Me.Chart1000.ChartAreas.Add(ChartArea16)
        Legend16.Name = "Legend1"
        Me.Chart1000.Legends.Add(Legend16)
        Me.Chart1000.Location = New System.Drawing.Point(777, 337)
        Me.Chart1000.Name = "Chart1000"
        Series16.ChartArea = "ChartArea1"
        Series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series16.Legend = "Legend1"
        Series16.Name = "Series1"
        Me.Chart1000.Series.Add(Series16)
        Me.Chart1000.Size = New System.Drawing.Size(447, 311)
        Me.Chart1000.TabIndex = 12
        Me.Chart1000.Text = "Chart4"
        '
        'PuntosDentro100
        '
        Me.PuntosDentro100.AutoSize = True
        Me.PuntosDentro100.Location = New System.Drawing.Point(50, 194)
        Me.PuntosDentro100.Name = "PuntosDentro100"
        Me.PuntosDentro100.Size = New System.Drawing.Size(76, 13)
        Me.PuntosDentro100.TabIndex = 13
        Me.PuntosDentro100.Text = "Puntos dentro:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero, Me.y})
        Me.DataGridView1.Location = New System.Drawing.Point(31, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 14
        '
        'Numero
        '
        Me.Numero.HeaderText = "x"
        Me.Numero.Name = "Numero"
        '
        'y
        '
        Me.y.HeaderText = "y"
        Me.y.Name = "y"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 649)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PuntosDentro100)
        Me.Controls.Add(Me.Chart1000)
        Me.Controls.Add(Me.Chart500)
        Me.Controls.Add(Me.Chart200)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.LimiteSuperior)
        Me.Controls.Add(Me.LimiteInferior)
        Me.Controls.Add(Me.CienPuntos)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CienPuntos As Button
    Friend WithEvents LimiteInferior As TextBox
    Friend WithEvents LimiteSuperior As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart200 As DataVisualization.Charting.Chart
    Friend WithEvents Chart500 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1000 As DataVisualization.Charting.Chart
    Friend WithEvents PuntosDentro100 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents y As DataGridViewTextBoxColumn
End Class
