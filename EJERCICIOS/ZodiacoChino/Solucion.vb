Sub Main()
    Dim fechatxt As String
    Dim fechaNac As Integer

    fechatxt = InputBox("INGRESE SU FECHA DE NACIMIENTO")

    If IsNumeric(fechatxt) Then
        'CONVERSION DE CADENA A ENTERO
        fechaNac = Convert.ToInt64(fechatxt)

        If fechaNac > 1000 And fechaNac <= 2024 Then
            Dim mensaje As String

            Select Case fechaNac Mod 12
                Case 0
                    mensaje = "Mono"
                Case 1
                    mensaje = "Gallo"
                Case 2
                    mensaje = "Perro"
                Case 3
                    mensaje = "Cerdo"
                Case 4
                    mensaje = "Rata"
                Case 5
                    mensaje = "Buey"
                Case 6
                    mensaje = "Tigre"
                Case 7
                    mensaje = "Conejo"
                Case 8
                    mensaje = "Dragón"
                Case 9
                    mensaje = "Serpiente"
                Case 10
                    mensaje = "Caballo"
                Case 11
                    mensaje = "Cabra"
            End Select
            MsgBox("SU SIGNO ZODIACAL CHINO ES: " & mensaje)

        Else
            MsgBox("EL AÑO INGRESADO FUERA DE RANGO")
        End If

    Else
        MsgBox("LA FECHA NO ES VALIDA")
    End If
End Sub