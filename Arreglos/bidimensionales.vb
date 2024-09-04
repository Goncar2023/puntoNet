Sub Main()
    'ARREGLOS BIDIMENSIONALES
    Dim edades(,) As Integer = New Integer(1, 1) {}

    'OBTENER EL N° DE FILAS
    Dim filas As Integer = edades.GetLength(0)

    'OBTENER EL N° DE COLUMNAS
    Dim columnas As Integer = edades.GetLength(1)

    'AGREGAR ELEMENTOS A LA MATRIZ
    For i As Integer = 0 To filas - 1
        For t As Integer = 0 To columnas - 1
            Console.WriteLine("Fila " & i & " - Col " & t & " Ingrese edad: ")
            edades(i, t) = Console.ReadLine()
        Next
    Next
    
    Console.WriteLine("PRESIONE TECLA PARA CONTINUAR")
    Console.ReadKey()
    'MOSTRAR LOS ELEMENTOS DEL ARREGLO BIDIMENSIONAL
    For i As Integer = 0 To filas - 1
        For t As Integer = 0 To columnas - 1
            Console.WriteLine("Fila " & i & " - Col " & t & " Edad: " & edades(i, t))
        Next
    Next
    Console.WriteLine("PRESIONE TECLA PARA CONTINUAR")
    Console.ReadKey()

End Sub