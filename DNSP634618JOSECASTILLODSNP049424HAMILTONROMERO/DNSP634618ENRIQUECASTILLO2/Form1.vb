Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DSNP634618 JOSE ENRIQUE CASTILLO BENAVIDES
        ' DSNP049424 HAMILTON DANIEL ROMERO PERLA
        ' Desactivar las listas de unidades hasta que se seleccione un tipo
        comboUnidadEntrada.Enabled = False
        comboUnidadSalida.Enabled = False
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        ' Obtener los valores de entrada
        Dim valorEntrada As Double = Double.Parse(txtValor.Text)
        Dim tipoUnidad As String = ComboTipounidad.SelectedItem.ToString()
        Dim unidadEntrada As String = comboUnidadEntrada.SelectedItem.ToString()
        Dim unidadSalida As String = comboUnidadSalida.SelectedItem.ToString()
        Dim resultado As Double = 0

        ' Método correspondiente según el tipo de unidad
        Select Case tipoUnidad
            Case "Longitud"
                resultado = ConvertirLongitud(valorEntrada, unidadEntrada, unidadSalida)
            Case "Masa"
                resultado = ConvertirMasa(valorEntrada, unidadEntrada, unidadSalida)
            Case "Tiempo"
                resultado = ConvertirTiempo(valorEntrada, unidadEntrada, unidadSalida)
            Case "Almacenamiento"
                resultado = ConvertirAlmacenamiento(valorEntrada, unidadEntrada, unidadSalida)
        End Select

        ' Resultado
        lblResultado.Text = $"Resultado: {resultado}"
    End Sub

    ' Evento para filtrar unidades según el tipo de unidad seleccionado
    Private Sub ComboTipounidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipounidad.SelectedIndexChanged
        Dim tipoUnidad As String = ComboTipounidad.SelectedItem.ToString()

        ' Limpiar las opciones previas de los ComboBox
        comboUnidadEntrada.Items.Clear()
        comboUnidadSalida.Items.Clear()

        ' Activar las listas de unidades al seleccionar un tipo
        comboUnidadEntrada.Enabled = True
        comboUnidadSalida.Enabled = True

        ' Agregar las unidades correspondientes al tipo de unidad seleccionado
        Select Case tipoUnidad
            Case "Longitud"
                comboUnidadEntrada.Items.AddRange({"Kilómetros", "Metros", "Centímetros", "Milímetros", "Pulgadas"})
                comboUnidadSalida.Items.AddRange({"Kilómetros", "Metros", "Centímetros", "Milímetros", "Pulgadas"})
            Case "Masa"
                comboUnidadEntrada.Items.AddRange({"Kilogramos", "Gramos", "Miligramos", "Libras"})
                comboUnidadSalida.Items.AddRange({"Kilogramos", "Gramos", "Miligramos", "Libras"})
            Case "Tiempo"
                comboUnidadEntrada.Items.AddRange({"Horas", "Minutos", "Segundos", "Milisegundos"})
                comboUnidadSalida.Items.AddRange({"Horas", "Minutos", "Segundos", "Milisegundos"})
            Case "Almacenamiento"
                comboUnidadEntrada.Items.AddRange({"Kilobytes", "Megabytes", "Gigabytes", "Terabytes"})
                comboUnidadSalida.Items.AddRange({"Kilobytes", "Megabytes", "Gigabytes", "Terabytes"})
        End Select
    End Sub

    ' Métodos de conversión

    Private Function ConvertirLongitud(ByVal valor As Double, ByVal entrada As String, ByVal salida As String) As Double
        Dim metros As Double = valor

        ' Convertir a metros primero
        Select Case entrada
            Case "Kilómetros"
                metros = valor * 1000
            Case "Metros"
                metros = valor
            Case "Centímetros"
                metros = valor / 100
            Case "Milímetros"
                metros = valor / 1000
            Case "Pulgadas"
                metros = valor * 0.0254
        End Select

        ' Convertir de metros a la unidad de salida
        Select Case salida
            Case "Kilómetros"
                Return metros / 1000
            Case "Metros"
                Return metros
            Case "Centímetros"
                Return metros * 100
            Case "Milímetros"
                Return metros * 1000
            Case "Pulgadas"
                Return metros / 0.0254
            Case Else
                Return metros
        End Select
    End Function

    Private Function ConvertirMasa(ByVal valor As Double, ByVal entrada As String, ByVal salida As String) As Double
        Dim gramos As Double = valor

        ' Convertir a gramos primero
        Select Case entrada
            Case "Kilogramos"
                gramos = valor * 1000
            Case "Gramos"
                gramos = valor
            Case "Miligramos"
                gramos = valor / 1000
            Case "Libras"
                gramos = valor * 453.592
        End Select

        ' Convertir de gramos a la unidad de salida
        Select Case salida
            Case "Kilogramos"
                Return gramos / 1000
            Case "Gramos"
                Return gramos
            Case "Miligramos"
                Return gramos * 1000
            Case "Libras"
                Return gramos / 453.592
            Case Else
                Return gramos
        End Select
    End Function

    Private Function ConvertirTiempo(ByVal valor As Double, ByVal entrada As String, ByVal salida As String) As Double
        Dim segundos As Double = valor

        ' Convertir a segundos primero
        Select Case entrada
            Case "Horas"
                segundos = valor * 3600
            Case "Minutos"
                segundos = valor * 60
            Case "Segundos"
                segundos = valor
            Case "Milisegundos"
                segundos = valor / 1000
        End Select

        ' Convertir de segundos a la unidad de salida
        Select Case salida
            Case "Horas"
                Return segundos / 3600
            Case "Minutos"
                Return segundos / 60
            Case "Segundos"
                Return segundos
            Case "Milisegundos"
                Return segundos * 1000
            Case Else
                Return segundos
        End Select
    End Function

    Private Function ConvertirAlmacenamiento(ByVal valor As Double, ByVal entrada As String, ByVal salida As String) As Double
        Dim bytes As Double = valor

        ' Convertir a bytes primero
        Select Case entrada
            Case "Kilobytes"
                bytes = valor * 1024
            Case "Megabytes"
                bytes = valor * 1024 * 1024
            Case "Gigabytes"
                bytes = valor * 1024 * 1024 * 1024
            Case "Terabytes"
                bytes = valor * 1024 * 1024 * 1024 * 1024
        End Select

        ' Convertir de bytes a la unidad de salida
        Select Case salida
            Case "Kilobytes"
                Return bytes / 1024
            Case "Megabytes"
                Return bytes / (1024 ^ 2)
            Case "Gigabytes"
                Return bytes / (1024 ^ 3)
            Case "Terabytes"
                Return bytes / (1024 ^ 4)
            Case Else
                Return bytes
        End Select
    End Function

End Class
