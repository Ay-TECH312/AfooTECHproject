Module Module1

    Sub Main()
        Dim firstnumber, secondnumber, result As Integer
        Dim operators As String

        Console.WriteLine("THE SOFTWARE FOR SIMPLE CALCULATOR")
        Console.WriteLine("__________________________________")
        Console.WriteLine("  ")


        Console.WriteLine("Enter value for firstnumber")
        firstnumber = Console.ReadLine()
        Console.WriteLine("Enter value for operators")
        operators = Console.ReadLine()
        Console.WriteLine("Enter value for secondnumber")
        secondnumber = Console.ReadLine()

        Console.WriteLine("  ")
        Console.WriteLine("__________________________________")


        If operators = "+" Then
            result = firstnumber + secondnumber
            Console.WriteLine("result = " + result.ToString)

        ElseIf operators = "-" Then
            result = firstnumber - secondnumber
            Console.WriteLine("result = " + result.ToString)

        ElseIf operators = "*" Then
            result = firstnumber * secondnumber
            Console.WriteLine("result = " + result.ToString)

        Else
            operators = "/"
            result = firstnumber / secondnumber
            Console.WriteLine("result = " + result.ToString)



        End If



        Console.ReadLine()


    End Sub

End Module
