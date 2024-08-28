Sub Main()
    'WHILE Y DO WHILE - DO LOOP WHILE
    Dim contador As Integer = 0

    While contador < 5
        Console.WriteLine("CONTADOR: " & contador)
        contador += 1
    End While

    contador = 0

    Do While contador < 5
        Console.WriteLine("DO WHILE CONTADOR: " & contador)
        contador += 1
    Loop

    Do
        Console.WriteLine("CONTADOR DO LOOP WHILE: " & contador)
        contador += 1
    Loop While contador < 5
    Console.ReadKey()
End Sub