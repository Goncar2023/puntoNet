Sub Main()
    'ARREGLOS
    'Son estructuras que permitenalmacenar multiples valores

    'DECLARAR ARREGLOS
    'Dim nombreArreglo(longitud) as tipoDato

    'Arreglo con 5 elementos
    Dim numeros(4) As Integer

    'INICIALIZACION
    numeros(0) = 1
    numeros(1) = 2
    numeros(2) = 3
    numeros(3) = 4
    numeros(4) = 5

    'MOSTRAR LOS ELEMENTOS DEL ARREGLO
    Console.WriteLine("N° " & numeros(0))
    Console.WriteLine("N° " & numeros(1))
    Console.WriteLine("N° " & numeros(2))
    Console.WriteLine("N° " & numeros(3))
    Console.WriteLine("N° " & numeros(4))

    'ARREGLOS DINAMICOS
    Dim numbers() As Integer
    ReDim numbers(10) 'Redimensionando
    'Redimensionar preservando los datos
    ReDim Preserve numbers(15)

    'Declarando e inicializando
    Dim nombres() As String = {"Juanita", "Jonathan", "Paloma", "Leandro"}
    'PARA LEER LOS DATOS DEL ARREGLO
    For Each nombre As String In nombres
        'MsgBox("Hola, " & nombre)
    Next

    For i As Integer = 0 To nombres.Length - 1
        Console.WriteLine("POSICION: " & i & ": " & nombres(i))
    Next
    Console.WriteLine("PRESIONE TECLA PARA CONTINUAR")
    Console.ReadKey()
End Sub