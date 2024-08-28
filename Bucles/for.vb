Sub Main()
    ' FOR 
    For contador As Integer = 0 To 10
        Console.WriteLine("CONTADOR:" & contador)
    Next

    For i As Integer = 0 To 100 Step 5
        Console.WriteLine("CONTADOR:" & i)
    Next
    Console.ReadKey()
End Sub