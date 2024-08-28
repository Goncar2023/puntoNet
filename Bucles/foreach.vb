Sub Main()
    'FOREACH
    Dim nombres() As String = {"Juan", "Maria", "Erick"}

    For Each nombre As String In nombres
        Console.WriteLine("NOMBRE: " & nombre)
    Next
    Console.ReadKey()
End Sub