'Fallon Smith
'RCET 0265
'Spring 2022
'Better calculator
'

Option Explicit On
Option Strict On
Option Compare Text
Module BetterCalculator

    Sub Main()

        Dim userRespone As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim booleanSwitch As Boolean = True

        Do While booleanSwitch = True
            Console.WriteLine("Please enter two number. Enter 'Q' at any time to quit ")
            userRespone = Console.ReadLine()
            If userRespone = "Q" Then
                booleanSwitch = False
            End If


        Loop
    End Sub

End Module
