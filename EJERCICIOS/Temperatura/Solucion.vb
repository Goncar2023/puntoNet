 Sub Main()
    Dim temperatura As String
    Dim temperaturaNumero As Double
    Console.WriteLine("INGRESE TEMPERATURA")
    temperatura = Console.ReadLine()
    'temperatura = InputBox("INGRESE TEMPERATURA")

    If IsNumeric(temperatura) Then
        Console.WriteLine("ES NUMERICO")
        temperaturaNumero = Convert.ToDouble(temperatura)
        Console.WriteLine(temperaturaNumero)
    Else
        MsgBox("EL NUMERO INGRESADO ES INVALIDO")
    End If
    Console.ReadKey()

End Sub