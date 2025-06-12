Module Module1

    Sub Main()
        Dim c As Integer
        Dim number As Integer
        Dim result As Long

        Do
            Console.WriteLine("THE SOFTWARE TO CALCULATE FACTORIAL OF A NUMBER")
            Console.WriteLine("________________________________________________")
            Console.WriteLine("  ")

            Console.WriteLine("Enter a number to calculate its factorial")
            number = Val(Console.ReadLine())
            If number < 1 Then
                Console.WriteLine("Invalid  Input")
            End If
                result = 1

                For a As Integer = 1 To number
                    result *= a
                    Console.WriteLine(a & "! " & "=" & " " & result)
                Next
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")

                Do
                    Console.WriteLine("Press 1 to exit")
                    Console.WriteLine("Press 2 to continue......")
                c = Val(Console.ReadLine())
                    If c <> 1 AndAlso c <> 2 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2.")
                End If
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")
                Loop Until c = 1 Or c = 2

        Loop Until c = 1

        Console.ReadLine()
    End Sub

End Module

