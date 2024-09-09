Sub Main()
    'MÉTODOS
    'Un método es una función o procedimiento que realiza una tarea específica en una clase.
    'Para declarar un método se utiliza la palabra clave Sub para procedimientos o
    ' Function para funciones.

    Dim numberOne = 12, numberTwo = 13
    Dim nombre = "lLeandro"

    'LLAMANDO A PROCEDIMIENTOS
    Saludar()
    Saludar(nombre)

    'LLAMANDO A UNA FUNCIÓN
    Dim resultado As Integer = Sumar(numberOne, numberTwo)
    MsgBox("SUMA " & resultado)

End Sub

Public Sub Saludar(nombre As String)
    'EL SIGNO $ PERMITE INCRUSTAR VALORES DE
    'VARIABLES DENTRO DE CADENAS UTILIZANDO {}
    MsgBox($"Hola, {nombre}")
End Sub

Public Sub Saludar() 'LOS PROCEDIMIENTOS NO DEVUELVEN UN VALOR
    MsgBox("¡Hola!")
End Sub

'LAS FUNCIONES DEVUELVEN UN VALOR
Public Function Sumar(numberOne As Integer, numberTwo As Integer) As Integer
    Return numberOne + numberTwo
End Function