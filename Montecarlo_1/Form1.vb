Public Class Form1
    Dim rnd As New Random()
    Dim mathArea As Double
    Dim totalArea As Double
    Dim ladoCuadrado As Double
    Dim AreaAproximada, Diferencia, Porcentaje, ErrorAprox, areaConocida As Double
    Dim limiteInferior1 As Double
    Dim limiteSuperior1 As Double
    Dim cantidadPuntosDentro, cantidadPuntosFuera As Integer
    Dim puntos As Integer

    Function hacerPuntos(ByRef chart As DataVisualization.Charting.Chart, cantidadPuntos As Integer, limiteInferior1 As Double, limiteSuperior1 As Double)
        ' Limpiar todas las series del chart
        chart.Series.Clear()
        ' Crear una nueva serie de datos para los puntos aleatorios
        Dim pasoFuncion As Double = (limiteSuperior1 - limiteInferior1) / (100 - 1)
        Dim seriesFuncion As New DataVisualization.Charting.Series()
        seriesFuncion.Name = "Valor Absoluto de x"
        seriesFuncion.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Dim seriesAleatorios As New DataVisualization.Charting.Series()
        seriesAleatorios.Name = "Puntos Aleatorios"
        seriesAleatorios.ChartType = DataVisualization.Charting.SeriesChartType.Point
        ' Calcular y agregar los puntos y sus valores del valor absoluto de x para la función original
        Dim x As Double = limiteInferior1
        For i As Integer = 0 To 100 - 1
            Dim y As Double = Math.Abs(x)
            ' Agregar el punto a la serie de la función original
            seriesFuncion.Points.AddXY(x, y)
            ' Incrementar el valor de x para el siguiente punto
            x += pasoFuncion
        Next

        ' Calcular el tamaño del cuadrado
        If limiteSuperior1 And limiteInferior1 > 0 Then
            ladoCuadrado = Math.Abs(limiteSuperior1) - Math.Abs(limiteInferior1)
        ElseIf limiteInferior1 < 0 Then
            ladoCuadrado = Math.Abs(limiteSuperior1) + Math.Abs(limiteInferior1)
        ElseIf limiteSuperior1 And limiteInferior1 < 0 Then
            ladoCuadrado = Math.Abs(limiteSuperior1) - Math.Abs(limiteInferior1)
        End If




        ' Generar 100 puntos aleatorios dentro del cuadrado y agregarlos a la serie de puntos aleatorios
        For i As Integer = 1 To cantidadPuntos
            Dim xAleatorio, yAleatorio As Double
            ' Generar coordenadas x e y aleatorias dentro del rango
            If limiteSuperior1 And limiteInferior1 > 0 Then
                xAleatorio = limiteInferior1 + (rnd.NextDouble() * (limiteSuperior1 - limiteInferior1))
                yAleatorio = limiteInferior1 + (rnd.NextDouble() * (limiteSuperior1 - limiteInferior1))
            Else
                xAleatorio = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio = limiteSuperior1 * rnd.NextDouble()
            End If


            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio < Math.Abs(xAleatorio) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio, yAleatorio) With {.Color = Color.Green})
                ' Sumar uno a la cantidad de puntos que se encuentran bajo el area
                cantidadPuntosDentro += 1

            Else
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de azul
                seriesAleatorios.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio, yAleatorio) With {.Color = Color.Blue})
                ' Sumar uno a la cantidad de puntos que se encuentran por encima de la gráfica
                cantidadPuntosFuera += 1
            End If
        Next

        ' Agregar ambas series al Chart
        chart.Series.Add(seriesFuncion)
        chart.Series.Add(seriesAleatorios)
        mathArea = AbsoluteValueArea(limiteInferior1, limiteSuperior1)
        areaConocida = ladoCuadrado * ladoCuadrado
        AreaAproximada = (areaConocida * cantidadPuntosDentro) / cantidadPuntos
        Diferencia = Math.Abs(AreaAproximada - mathArea)
        Porcentaje = (Math.Abs(Diferencia / mathArea)) * 100
        ErrorAprox = (1 / Math.Sqrt(cantidadPuntosDentro)) * 100


        DataGridView1.Rows.Add(cantidadPuntos, areaConocida, mathArea, cantidadPuntosDentro, AreaAproximada, Diferencia, Math.Round(Porcentaje, 2), Math.Round(ErrorAprox, 2))
        PintarFilasDiferentes(DataGridView1)
        mathArea = 0
        areaConocida = 0
        AreaAproximada = 0
        Diferencia = 0
        Porcentaje = 0
        ErrorAprox = 0
        cantidadPuntosDentro = 0
        cantidadPuntosFuera = 0
    End Function
    Private Sub CienPuntos_Click(sender As Object, e As EventArgs) Handles CienPuntos.Click
        ' Obtener el texto de lo que se ingresa en el text x0
        limiteInferior1 = Double.Parse(LimiteInferior.Text)
        ' Obtener el texto de lo que se ingresa en el text x1
        limiteSuperior1 = Double.Parse(LimiteSuperior.Text)
        ' Iteracion 1 100 puntos
        hacerPuntos(Chart1, 100, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart1, "Gráfico con 100 puntos")
        ' Iteracion 2 100 puntos
        hacerPuntos(Chart2, 100, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart2, "Gráfico con 100 puntos")
        ' Iteracion 3 100 puntos
        hacerPuntos(Chart6, 100, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart6, "Gráfico con 100 puntos")

        ' Iteracion 1 200 puntos
        hacerPuntos(Chart200, 200, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart200, "Gráfico con 200 puntos")
        ' Iteracion 2 200 puntos
        hacerPuntos(Chart3, 200, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart3, "Gráfico con 200 puntos")
        ' Iteracion 3 200 puntos
        hacerPuntos(Chart7, 200, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart7, "Gráfico con 200 puntos")

        ' Iteracion 1 500 puntos
        hacerPuntos(Chart500, 500, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart500, "Gráfico con 500 puntos")
        ' Iteracion 2 200 puntos
        hacerPuntos(Chart4, 500, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart4, "Gráfico con 500 puntos")
        ' Iteracion 3 200 puntos
        hacerPuntos(Chart8, 500, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart8, "Gráfico con 500 puntos")

        ' Iteracion 1 1000 puntos
        hacerPuntos(Chart1000, 1000, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart1000, "Gráfico con 1000 puntos")
        ' Iteracion 2 200 puntos
        hacerPuntos(Chart5, 1000, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart5, "Gráfico con 1000 puntos")
        ' Iteracion 3 200 puntos
        hacerPuntos(Chart9, 1000, limiteInferior1, limiteSuperior1)
        ConfigurarGrafico(Chart9, "Gráfico con 1000 puntos")

        PintarFilasDiferentes(DataGridView1)
    End Sub

    Function AbsoluteValueArea(limiteInferior As Double, limiteSuperior As Double) As Double
        Dim area1, area2 As Double

        If (limiteInferior And limiteSuperior) < 0 Then
            'area1 = -((limiteInferior) * (limiteInferior)) / 2
            area1 = -(Math.Pow(limiteInferior, 2)) / 2

            area2 = -(limiteSuperior * limiteSuperior) / 2
            totalArea = Math.Abs(area1 - area2)
        ElseIf (limiteInferior And limiteInferior) > 0 Then
            area1 = (limiteInferior * limiteInferior) / 2
            area2 = (limiteSuperior * limiteSuperior) / 2
            totalArea = area2 - area1
        ElseIf (limiteInferior < 0) And limiteSuperior > 0 Then
            area1 = -(-(limiteInferior * limiteInferior) / 2)
            area2 = (limiteSuperior * limiteSuperior) / 2
            totalArea = area2 + area1
        End If



        Return totalArea
    End Function


    Private Sub PintarFilasDiferentes(dataGridView As DataGridView)
        ' Se eligen los 3 colores para diferenciar cada una de las respuestas
        Dim color1 As Color = Color.LightGray
        Dim color2 As Color = Color.LightBlue
        Dim color3 As Color = Color.LightGreen

        ' Realizar un ciclo para recorrer todas las filas de la tabla
        For i As Integer = 0 To dataGridView.Rows.Count - 1
            ' Se verifica si el índice i de la fila actual está dentro del rango de 0 a 2
            If i Mod 9 < 3 Then
                ' Cambiar el color de la fila en i
                dataGridView.Rows(i).DefaultCellStyle.BackColor = color1
                ' Se verifica si el índice i de la fila actual está dentro del rango de 3 a 5
            ElseIf i Mod 9 < 6 Then
                ' Cambiar el color de la fila en i
                dataGridView.Rows(i).DefaultCellStyle.BackColor = color2
            Else
                ' Se verifica si el índice i de la fila actual está dentro del rango de 6 a 8 y Cambiar el color de la fila en i
                dataGridView.Rows(i).DefaultCellStyle.BackColor = color3
            End If
        Next
    End Sub


    Private Sub ConfigurarGrafico(chart As DataVisualization.Charting.Chart, titulo As String)
        chart.Titles.Clear()
        chart.Titles.Add(titulo)

        ' Configurar el eje X para mostrar solo los valores enteros
        chart.ChartAreas(0).AxisX.Interval = 1
        chart.ChartAreas(0).AxisX.LabelStyle.Format = "0"

        ' Aquí puedes agregar otras configuraciones adicionales al gráfico si lo deseas
        ' Por ejemplo, personalizar colores, estilos, leyendas, etc.
        ' chart.Series...
        ' chart.Legends...
    End Sub


End Class
