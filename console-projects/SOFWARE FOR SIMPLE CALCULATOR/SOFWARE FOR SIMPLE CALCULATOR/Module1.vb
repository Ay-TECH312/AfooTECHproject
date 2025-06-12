Module Module1

    Sub Main()
        Dim firstnumber, secondnumber, operators, result As Integer

        Console.WriteLine("THE SOFTWARE FOR SIMPLE CALCULATOR")
        Console.WriteLine("__________________________________")
        Console.WriteLine("  ")


        Console.WriteLine("Pres 1  for addition")

        Console.WriteLine("Pres 2  for subtraction")

        Console.WriteLine("Pres 3  for multiplication")

        Console.WriteLine("Pres 4  for division")

        Console.WriteLine("Enter value for operators")
        operators = Console.ReadLine()

        Console.WriteLine("  ")

        Console.WriteLine("__________________________________")




        If operators = 1 Then
            Console.WriteLine("Enter the value for fisrtnumber")
            firstnumber = Console.ReadLine()
            Console.WriteLine("Enter the value for secondnumber")
            secondnumber = Console.ReadLine()
            result = firstnumber + secondnumber
            Console.WriteLine("result = " + result.ToString)

        ElseIf operators = 2 Then
            Console.WriteLine("Enter the value for fisrtnumber")
            firstnumber = Console.ReadLine()
            Console.WriteLine("Enter the value for secondnumber")
            secondnumber = Console.ReadLine()
            result = firstnumber - secondnumber
            Console.WriteLine("result = " + result.ToString)

        ElseIf operators = 3 Then
            Console.WriteLine("Enter the value for fisrtnumber")
            firstnumber = Console.ReadLine()
            Console.WriteLine("Enter the value for secondnumber")
            secondnumber = Console.ReadLine()
            result = firstnumber * secondnumber
            Console.WriteLine("result = " + result.ToString)

        Else
            operators = 4
            Console.WriteLine("Enter the value for fisrtnumber")
            firstnumber = Console.ReadLine()
            Console.WriteLine("Enter the value for secondnumber")
            secondnumber = Console.ReadLine()
            result = firstnumber / secondnumber
            Console.WriteLine("result = " + result.ToString)



        End If



        Console.ReadLine()

    End Sub

End Module
