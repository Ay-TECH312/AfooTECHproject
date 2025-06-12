Module Module1

    Sub Main()
        Dim firstnumber, secondnumber, thirdnumber As Integer
        Console.WriteLine("THE SOFTWARE TO CALCULATE COMPARISON OF THREE GREATEST NUMBERS")
        Console.WriteLine("_______________________________________________________________")
        Console.WriteLine("  ")


        Console.WriteLine("Enter the value for firstnumber  ")
        firstnumber = Console.ReadLine()
        Console.WriteLine("Enter the value for secondnumber  ")
        secondnumber = Console.ReadLine()
        Console.WriteLine("Enter the value for thirdnumber  ")
        thirdnumber = Console.ReadLine()


        If (firstnumber > secondnumber) And (firstnumber > thirdnumber) Then
            Console.WriteLine("The greatest number =   " + firstnumber.ToString)
        ElseIf (secondnumber > firstnumber And secondnumber > thirdnumber) Then
            Console.WriteLine("The greatest number =   " + secondnumber.ToString)
        Else
            Console.WriteLine("The greatest number =   " + thirdnumber.ToString)


        End If



        Console.ReadLine()


    End Sub

End Module
