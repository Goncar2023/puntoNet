Sub Main()
    'LISTAS
    'SON ESTRUCTURAS QUE PERMITEN ALMACENAR DATOS
    'SON DINAMICAS, PUEDEN CRECER O REDUCIRSE

    'DECLARACION DE UNA LISTA
    Dim numeros As New List(Of Integer)()
    'SE RECOMIENDA UTILIZAR NOMBRES EN PLURAL

    'AGREGAR ELEMENTOS A LA LISTA
    numeros.Add(10)
    numeros.Add(40)
    numeros.Add(80)
    numeros.Add(20)
    numeros.Add(15)

    'Obtener la cantidad de elementos existentes en la lista
    Dim longitud As Integer = numeros.Count
    Console.WriteLine("LONGITUD: " & longitud)

    'ACCEDER A LOS DATOS DE LA LISTA
    'Console.WriteLine("n°: " & numeros(0))
    'Console.WriteLine("n°: " & numeros(1))
    'Console.WriteLine("n°: " & numeros(2))
    'Console.WriteLine("n°: " & numeros(3))
    'Console.WriteLine("n°: " & numeros(4))

    'RECORRER UNA LISTA UTILIZANDO FOREACH

    For Each numero As Integer In numeros
        Console.WriteLine("n°: " & numero)
    Next

    'Console.WriteLine("posicion 3 antes: " & numeros(3))
    'numeros.Remove(40) 'elimina la primera coincidencia
    'Console.WriteLine("posicion 3 despues: " & numeros(3))
    'numeros.RemoveAt(0) 'elimina el dato del indice indicado
    'Console.WriteLine("posicion 0 despues: " & numeros(0))
    'longitud = numeros.Count
    'Console.WriteLine("longitud: " & longitud)

    Console.WriteLine("--------------------------")
    numeros.Sort() 'ORDENA DE MENOR A MAYOR

    For Each numero As Integer In numeros
        Console.WriteLine("n°: " & numero)
    Next

    Console.WriteLine("--------------------------")
    numeros.Reverse() 'ORDENA DE MAYOR A MENOR
    For Each numero As Integer In numeros
        Console.WriteLine("n°: " & numero)
    Next
    Console.WriteLine("--------------------------")

    'CONTAINS PERMITE VERIFICAR SI UN DATO EXISTE EN LA LISTA
    If (numeros.Contains(100)) Then
        Console.WriteLine("EL NUMERO COINCIDE")
    Else
        Console.WriteLine("NUMERO NO ENCONTRADO")

    End If
    Console.ReadKey()

End Sub