' COMENTAR CTRL + K - CTRL + C // DESCOMENTAR CTRL + K - CTRL + U
Sub Main()
    ' Operadores Aritméticos
    ' + Suma
    ' - Resta
    ' * Multiplicación
    ' / División
    ' \ División con resultado entero -> ALT + 92
    ' Mod Módulo - Resto de la división

    ' Operadores de Comparación
    ' = Comprueba si dos valores son iguales.
    ' <>: Comprueba si dos valores no son iguales.
    ' >: Comprueba si el valor de la izquierda es mayor que el de la derecha.
    ' <: Comprueba si el valor de la izquierda es menor que el de la derecha.
    ' >=: Comprueba si el valor de la izquierda es mayor o igual que el de la derecha.
    ' <=: Comprueba si el valor de la izquierda es menor o igual que el de la derecha.

    Dim num1 As Integer = 10
    Dim num2 As Integer = 5
    Dim resultado As Boolean

    resultado = (num1 > num2) ' resultado = True

    'Operadores Lógicos:

    'And Devuelve verdadero si ambas condiciones son verdaderas.
    'Or: Devuelve verdadero si al menos una de las condiciones es verdadera.
    'Not: Niega una condición, convierte verdadero en falso y viceversa.

    Dim edad As Integer = 25
    Dim licencia As Boolean = True

    Dim puedeConducir As Boolean = edad >= 18 And licencia 
    MsgBox("¿Puede conducir? "&puedeConducir)

    'Operadores de Asignación
    ' = Para asignar un valor a una variable
    Dim num as Integer
    num = 18

    'Operador de asignación con suma
    Dim resultado as Integer
    resultado += 5 ' Equivale a  resultado = resultado + 5

    'Operador de asignación con resta
    dim total as Integer
    total -= 10 'Equivale a  total = total - 10

    'Operador de Asignación con Multiplicación
    Dim cantidad As Integer
    cantidad *= 2 'Equivale a  cantidad = cantidad * 2

    'Operador de Asignación con División
    Dim result As Single
    result /= 5.0 'Equivale a  result = result / 5.0
End Sub