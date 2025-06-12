Module Module1

    Sub Main()
        Dim firstNumber, secondNumber, result As Integer
        Console.WriteLine("THE DIFFERENCE OF TWO NUMBERS")
        Console.WriteLine("==============================")
        Console.WriteLine("  ")

        Console.WriteLine("Enter  firstNumber")
        firstNumber = Console.ReadLine()
        Console.WriteLine("Enter  secondNumber")
        secondNumber = Console.ReadLine()
        Console.WriteLine("==============================")
        Console.WriteLine("  ")

        result = firstNumber - secondNumber
        Console.WriteLine("result = " + result.ToString)
        Console.ReadLine()
    End Sub
End Module