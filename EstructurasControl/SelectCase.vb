Sub Main()
    Dim dia As Integer = 7
    Select Case dia
        Case 1
            Console.WriteLine("LUNES")
        Case 2
            Console.WriteLine("MARTES")
        Case 3
            Console.WriteLine("MIERCOLES")
        Case 4
            Console.WriteLine("JUEVES")
        Case 5
            Console.WriteLine("VIERNES")
        Case 6, 7
            Console.WriteLine("FIN DE SEMANA")
        Case Else
            Console.WriteLine("DIA INVALIDO")
    End Select

    'SELECT CASE CON STRINGS
    Dim diaSemana As String = "Sábado"
    Dim mensajeDos As String

    Select Case diaSemana
        Case "Lunes", "Martes", "Miércoles", "Jueves", "Viernes"
            mensajeDos = "Es un día laboral."
        Case "Sábado", "Domingo"
            mensajeDos = "Es fin de semana."
        Case Else
            mensajeDos = "Día no reconocido."
    End Select

    MsgBox(mensajeDos)

    'SELECT CASE CON RANGOS
    Dim edad As Integer = 18
    Dim mensajeTres As String

    Select Case edad
        Case Is < 13
            mensajeTres = "Eres un niño."
        Case Is >= 13, Is <= 19
            mensajeTres = "Eres un adolescente."
        Case Is >= 20, Is <= 29
            mensajeTres = "Eres un adulto joven."
        Case Is >= 30, Is <= 64
            mensajeTres = "Eres un adulto."
        Case Is >= 65
            mensajeTres = "Eres un adulto mayor."
    End Select

    MsgBox(mensajeTres)

End Sub