Module Module1

    Sub Main()
        Dim firstnumber, secondnumber As Integer
        Console.WriteLine("THE SOFWARE TO CALCULATE COMPARISON OF TWO GREATER NUMBERS")
        Console.WriteLine("___________________________________________________________")
        Console.WriteLine(" ")


        Console.WriteLine("Enter the value for firstnumber ")
        firstnumber = Console.ReadLine()
        Console.WriteLine("Enter the value for secondnumber ")
        secondnumber = Console.ReadLine()

        If firstnumber > secondnumber Then
            Console.WriteLine("The greater number = " + firstnumber.ToString)
        ElseIf secondnumber > firstnumber Then
            Console.WriteLine("The greater number = " + secondnumber.ToString)
        Else
            Console.WriteLine("The both numbers are equal  ".ToString)

        End If


        Console.ReadLine()








    End Sub

End Module
