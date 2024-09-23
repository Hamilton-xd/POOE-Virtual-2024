Module Ejercicios
    Sub Main()
        Dim opcion As Integer

        Do
            Console.Clear()
            Console.WriteLine("Seleccione un ejercicio:")
            Console.WriteLine("1. Determinar si es mayor o menor de edad")
            Console.WriteLine("2. Determinar si un número es positivo o negativo")
            Console.WriteLine("3. Calcular descuento y total a pagar")
            Console.WriteLine("4. Calcular la suma de números naturales hasta n")
            Console.WriteLine("5. Escribir la tabla de multiplicar")
            Console.WriteLine("6. Salir")
            Console.Write("Ingrese su opción: ")

            ' Leer opción del usuario
            If Integer.TryParse(Console.ReadLine(), opcion) Then
                Select Case opcion
                    Case 1
                        Ejercicio1()
                    Case 2
                        Ejercicio2()
                    Case 3
                        Ejercicio3()
                    Case 4
                        Ejercicio4()
                    Case 5
                        Ejercicio5()
                    Case 6
                        Console.WriteLine("Saliendo del programa...")
                    Case Else
                        Console.WriteLine("Opción no válida.")
                End Select
            Else
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.")
            End If

            ' Pausa antes de mostrar el menú nuevamente
            If opcion <> 6 Then
                Console.WriteLine(vbCrLf & "Presione cualquier tecla para continuar...")
                Console.ReadKey()
            End If
        Loop While opcion <> 6

        ' Pausa antes de finalizar
        Console.WriteLine(vbCrLf & "Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

    ' Ejercicio 1: Mayor o menor de edad
    Sub Ejercicio1()
        Console.Clear()
        Dim edad As Integer
        Console.Write("Ingrese su edad: ")
        edad = Integer.Parse(Console.ReadLine())
        If edad >= 18 Then
            Console.WriteLine("Es mayor de edad.")
        Else
            Console.WriteLine("Es menor de edad.")
        End If
    End Sub

    ' Ejercicio 2: Número positivo o negativo
    Sub Ejercicio2()
        Console.Clear()
        Dim numero As Integer
        Console.Write("Ingrese un número: ")
        numero = Integer.Parse(Console.ReadLine())
        If numero >= 0 Then
            Console.WriteLine("El número es positivo.")
        Else
            Console.WriteLine("El número es negativo.")
        End If
    End Sub

    ' Ejercicio 3: Calcular descuento y total a pagar
    Sub Ejercicio3()
        Console.Clear()
        Dim monto As Decimal
        Dim descuento As Decimal
        Dim total As Decimal
        Console.Write("Ingrese el monto de la compra: ")
        monto = Decimal.Parse(Console.ReadLine())

        ' Determinar el descuento según el monto de la compra
        If monto >= 1000 Then
            descuento = 0.3
        ElseIf monto >= 500 Then
            descuento = 0.2
        ElseIf monto >= 250 Then
            descuento = 0.1
        Else
            descuento = 0.05
        End If

        ' Calcular el total
        total = monto - (monto * descuento)
        Console.WriteLine("Descuento aplicado: " & (descuento * 100) & "%")
        Console.WriteLine("Total a pagar: $" & total)
    End Sub

    ' Ejercicio 4: Suma de los números naturales hasta n
    Sub Ejercicio4()
        Console.Clear()
        Dim n As Integer
        Dim suma As Integer = 0
        Console.Write("Ingrese un número n: ")
        n = Integer.Parse(Console.ReadLine())

        ' Sumar los números naturales de 1 a n
        For i As Integer = 1 To n
            suma += i
        Next

        Console.WriteLine("La suma de los números naturales desde 1 hasta " & n & " es: " & suma)
    End Sub

    ' Ejercicio 5: Tabla de multiplicar
    Sub Ejercicio5()
        Console.Clear()
        Dim numero As Integer
        Console.Write("Ingrese un número para ver su tabla de multiplicar: ")
        numero = Integer.Parse(Console.ReadLine())

        ' Mostrar la tabla de multiplicar
        For i As Integer = 1 To 10
            Console.WriteLine(numero & " x " & i & " = " & numero * i)
        Next
    End Sub
End Module
