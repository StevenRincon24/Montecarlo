Public Class Form1
    Dim rnd As New Random()

    Private Sub CienPuntos_Click(sender As Object, e As EventArgs) Handles CienPuntos.Click

        Dim cantidadPuntosDentro100, cantidadPuntosFuera100 As Integer
        Dim cantidadPuntosDentro200, cantidadPuntosFuera200 As Integer
        Dim cantidadPuntosDentro500, cantidadPuntosFuera500 As Integer
        Dim cantidadPuntosDentro1000, cantidadPuntosFuera1000 As Integer

        Dim limiteInferior1 As Double = Double.Parse(LimiteInferior.Text)
        Dim limiteSuperior1 As Double = Double.Parse(LimiteSuperior.Text)

        ' Limpiar las series anteriores (opcional)
        Chart1.Series.Clear()

        ' Crear una nueva serie de datos para la función original
        Dim seriesFuncion As New DataVisualization.Charting.Series()
        seriesFuncion.Name = "Valor Absoluto de x"
        seriesFuncion.ChartType = DataVisualization.Charting.SeriesChartType.Line

        ' Crear una nueva serie de datos para los puntos aleatorios
        Dim seriesAleatorios As New DataVisualization.Charting.Series()
        seriesAleatorios.Name = "Puntos Aleatorios"
        seriesAleatorios.ChartType = DataVisualization.Charting.SeriesChartType.Point

        Dim seriesAleatorios200 As New DataVisualization.Charting.Series()
        seriesAleatorios200.Name = "Puntos Aleatorios 200"
        seriesAleatorios200.ChartType = DataVisualization.Charting.SeriesChartType.Point

        Dim seriesAleatorios500 As New DataVisualization.Charting.Series()
        seriesAleatorios500.Name = "Puntos Aleatorios 500"
        seriesAleatorios500.ChartType = DataVisualization.Charting.SeriesChartType.Point

        Dim seriesAleatorios1000 As New DataVisualization.Charting.Series()
        seriesAleatorios1000.Name = "Puntos Aleatorios 500"
        seriesAleatorios1000.ChartType = DataVisualization.Charting.SeriesChartType.Point

        ' Calcular el paso entre cada punto para la función original
        Dim pasoFuncion As Double = (limiteSuperior1 - limiteInferior1) / (100 - 1)

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
        Dim ladoCuadrado As Double = Math.Abs(limiteSuperior1) + Math.Abs(limiteInferior1)

        ' Generar 100 puntos aleatorios dentro del cuadrado y agregarlos a la serie de puntos aleatorios
        For i As Integer = 1 To 10
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Dim yAleatorio As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Console.WriteLine("H")
            DataGridView1.Rows.Add(xAleatorio, yAleatorio)


            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio < Math.Abs(xAleatorio) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio, yAleatorio) With {.Color = Color.Red})
                ' Sumar uno a la cantidad de puntos que se encuentran bajo el area
                cantidadPuntosDentro100 += 1

            Else
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de azul
                seriesAleatorios.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio, yAleatorio) With {.Color = Color.Blue})
                ' Sumar uno a la cantidad de puntos que se encuentran por encima de la gráfica
                cantidadPuntosFuera100 += 1
            End If
        Next

        ' Agregar ambas series al Chart
        Chart1.Series.Add(seriesFuncion)
        Chart1.Series.Add(seriesAleatorios)
        PuntosDentro100.Text = "La cantidad de puntos son: " & cantidadPuntosDentro100

        For i As Integer = 1 To 200
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio200 As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Dim yAleatorio200 As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()

            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio200 < Math.Abs(xAleatorio200) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios200.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio200, yAleatorio200) With {.Color = Color.Red})
                ' Sumar uno a la cantidad de puntos que se encuentran bajo el area
                cantidadPuntosDentro200 += 1

            Else
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de azul
                seriesAleatorios200.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio200, yAleatorio200) With {.Color = Color.Blue})
                ' Sumar uno a la cantidad de puntos que se encuentran por encima de la gráfica
                cantidadPuntosFuera200 += 1
            End If
        Next
        Chart200.Series.Add(seriesFuncion)
        Chart200.Series.Add(seriesAleatorios200)

        For i As Integer = 1 To 500
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio500 As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Dim yAleatorio500 As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()

            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio500 < Math.Abs(xAleatorio500) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios500.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio500, yAleatorio500) With {.Color = Color.Red})
                ' Sumar uno a la cantidad de puntos que se encuentran bajo el area
                cantidadPuntosDentro500 += 1

            Else
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de azul
                seriesAleatorios500.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio500, yAleatorio500) With {.Color = Color.Blue})
                ' Sumar uno a la cantidad de puntos que se encuentran por encima de la gráfica
                cantidadPuntosFuera500 += 1
            End If
        Next
        Chart500.Series.Add(seriesFuncion)
        Chart500.Series.Add(seriesAleatorios500)


        For i As Integer = 1 To 1000
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio1000 As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Dim yAleatorio1000 As Double = limiteInferior1 + ladoCuadrado * rnd.NextDouble()

            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio1000 < Math.Abs(xAleatorio1000) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios500.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio1000, yAleatorio1000) With {.Color = Color.Red})
                ' Sumar uno a la cantidad de puntos que se encuentran bajo el area
                cantidadPuntosDentro500 += 1

            Else
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de azul
                seriesAleatorios1000.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio1000, yAleatorio1000) With {.Color = Color.Blue})
                ' Sumar uno a la cantidad de puntos que se encuentran por encima de la gráfica
                cantidadPuntosFuera500 += 1
            End If
        Next
        Chart1000.Series.Add(seriesFuncion)
        Chart1000.Series.Add(seriesAleatorios1000)



    End Sub

End Class
