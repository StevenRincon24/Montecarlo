Public Class Form1
    Dim rnd As New Random()
    Dim mathArea As Double
    Dim totalArea As Double
    Dim ladoCuadrado As Double
    Dim AreaAproximada, Diferencia, Porcentaje, ErrorAprox, areaConocida As Double
    Dim puntos As Integer
    Private Sub CienPuntos_Click(sender As Object, e As EventArgs) Handles CienPuntos.Click

        Dim cantidadPuntosDentro100, cantidadPuntosFuera100 As Integer
        Dim cantidadPuntosDentro200, cantidadPuntosFuera200 As Integer
        Dim cantidadPuntosDentro500, cantidadPuntosFuera500 As Integer
        Dim cantidadPuntosDentro1000, cantidadPuntosFuera1000 As Integer

        Dim limiteInferior1 As Double = Double.Parse(LimiteInferior.Text)
        Dim limiteSuperior1 As Double = Double.Parse(LimiteSuperior.Text)
        Dim seriesFuncion As New DataVisualization.Charting.Series()


        ' Limpiar las series anteriores (opcional)
        Chart1.Series.Clear()
        Chart200.Series.Clear()
        Chart500.Series.Clear()
        Chart1000.Series.Clear()

        ' Crear una nueva serie de datos para la función original

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
        seriesAleatorios1000.Name = "Puntos Aleatorios 1000"
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
        If limiteSuperior1 And limiteInferior1 > 0 Then
            ladoCuadrado = Math.Abs(limiteSuperior1) - Math.Abs(limiteInferior1)
        ElseIf limiteInferior1 < 0 Then
            ladoCuadrado = Math.Abs(limiteSuperior1) + Math.Abs(limiteInferior1)
        ElseIf limiteSuperior1 And limiteInferior1 < 0 Then
            ladoCuadrado = Math.Abs(limiteSuperior1) - Math.Abs(limiteInferior1)
        End If




        ' Generar 100 puntos aleatorios dentro del cuadrado y agregarlos a la serie de puntos aleatorios
        For i As Integer = 1 To 100
            Dim xAleatorio, yAleatorio As Double
            ' Generar coordenadas x e y aleatorias dentro del rango
            If limiteSuperior1 And limiteInferior1 > 0 Then
                xAleatorio = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Else
                xAleatorio = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio = ladoCuadrado * rnd.NextDouble()
            End If


            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio < Math.Abs(xAleatorio) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio, yAleatorio) With {.Color = Color.Green})
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
        puntos = 100
        Chart1.Series.Add(seriesFuncion)
        Chart1.Series.Add(seriesAleatorios)
        mathArea = AbsoluteValueArea(limiteInferior1, limiteSuperior1)
        areaConocida = ladoCuadrado * ladoCuadrado
        AreaAproximada = (areaConocida * cantidadPuntosDentro100) / puntos
        Diferencia = Math.Abs(AreaAproximada - mathArea)
        Porcentaje = (Math.Abs(Diferencia / mathArea)) * puntos
        ErrorAprox = (1 / Math.Sqrt(puntos)) * puntos


        DataGridView1.Rows.Add(puntos, areaConocida, mathArea, cantidadPuntosDentro100, AreaAproximada, Diferencia, Porcentaje, ErrorAprox)


        For i As Integer = 1 To 200
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio200, yAleatorio200 As Double
            ' Generar coordenadas x e y aleatorias dentro del rango
            If limiteSuperior1 And limiteInferior1 > 0 Then
                xAleatorio200 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio200 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Else
                xAleatorio200 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio200 = ladoCuadrado * rnd.NextDouble()
            End If

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
        puntos = 200
        mathArea = AbsoluteValueArea(limiteInferior1, limiteSuperior1)
        areaConocida = ladoCuadrado * ladoCuadrado
        AreaAproximada = (areaConocida * cantidadPuntosDentro200) / puntos
        Diferencia = Math.Abs(AreaAproximada - mathArea)
        Porcentaje = (Math.Abs(Diferencia / mathArea)) * puntos
        ErrorAprox = (1 / Math.Sqrt(puntos)) * puntos


        DataGridView2.Rows.Add(puntos, areaConocida, mathArea, cantidadPuntosDentro100, AreaAproximada, Diferencia, Porcentaje, ErrorAprox)

        For i As Integer = 1 To 500
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio500, yAleatorio500 As Double
            ' Generar coordenadas x e y aleatorias dentro del rango
            If limiteSuperior1 And limiteInferior1 > 0 Then
                xAleatorio500 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio500 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Else
                xAleatorio500 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio500 = ladoCuadrado * rnd.NextDouble()
            End If

            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio500 < Math.Abs(xAleatorio500) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios500.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio500, yAleatorio500) With {.Color = Color.Gold})
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
        puntos = 500
        mathArea = AbsoluteValueArea(limiteInferior1, limiteSuperior1)
        areaConocida = ladoCuadrado * ladoCuadrado
        AreaAproximada = (areaConocida * cantidadPuntosDentro500) / puntos
        Diferencia = Math.Abs(AreaAproximada - mathArea)
        Porcentaje = (Math.Abs(Diferencia / mathArea)) * puntos
        ErrorAprox = (1 / Math.Sqrt(puntos)) * puntos


        DataGridView3.Rows.Add(puntos, areaConocida, mathArea, cantidadPuntosDentro100, AreaAproximada, Diferencia, Porcentaje, ErrorAprox)


        For i As Integer = 1 To 1000
            ' Generar coordenadas x e y aleatorias dentro del rango
            Dim xAleatorio1000, yAleatorio1000 As Double
            ' Generar coordenadas x e y aleatorias dentro del rango
            If limiteSuperior1 And limiteInferior1 > 0 Then
                xAleatorio1000 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio1000 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
            Else
                xAleatorio1000 = limiteInferior1 + ladoCuadrado * rnd.NextDouble()
                yAleatorio1000 = ladoCuadrado * rnd.NextDouble()
            End If

            ' Verificar si el punto aleatorio está debajo de la curva de la función
            If yAleatorio1000 < Math.Abs(xAleatorio1000) Then
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de rojo
                seriesAleatorios1000.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio1000, yAleatorio1000) With {.Color = Color.Red})
                ' Sumar uno a la cantidad de puntos que se encuentran bajo el area
                cantidadPuntosDentro1000 += 1

            Else
                ' Agregar el punto a la serie de puntos aleatorios y pintarlo de azul
                seriesAleatorios1000.Points.Add(New DataVisualization.Charting.DataPoint(xAleatorio1000, yAleatorio1000) With {.Color = Color.Blue})
                ' Sumar uno a la cantidad de puntos que se encuentran por encima de la gráfica
                cantidadPuntosFuera1000 += 1
            End If
        Next
        Chart1000.Series.Add(seriesFuncion)
        Chart1000.Series.Add(seriesAleatorios1000)
        puntos = 1000
        mathArea = AbsoluteValueArea(limiteInferior1, limiteSuperior1)
        areaConocida = ladoCuadrado * ladoCuadrado
        AreaAproximada = (areaConocida * cantidadPuntosDentro1000) / puntos
        Diferencia = Math.Abs(AreaAproximada - mathArea)
        Porcentaje = (Math.Abs(Diferencia / mathArea)) * puntos
        ErrorAprox = (1 / Math.Sqrt(100)) * puntos


        DataGridView4.Rows.Add(puntos, areaConocida, mathArea, cantidadPuntosDentro1000, AreaAproximada, Diferencia, Porcentaje, ErrorAprox)


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

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Chart200_Click(sender As Object, e As EventArgs) Handles Chart200.Click

    End Sub

    Private Sub Chart1000_Click(sender As Object, e As EventArgs) Handles Chart1000.Click

    End Sub

    Private Sub Chart500_Click(sender As Object, e As EventArgs) Handles Chart500.Click

    End Sub
End Class
