Module Module1

    Sub Main()
        Dim result, modules, number, c, choose As Double

        Console.WriteLine("THE LOOP STATEMENT")
        Console.WriteLine("____________________________________")
        Console.WriteLine("  ")
        Do
            Console.WriteLine("press 1 for multiplications")
            Console.WriteLine("press 2 for additions")
            Console.WriteLine("press 3 for subtractions")
            Console.WriteLine("press 4 for divisions")
            Console.WriteLine("  ")
            Console.WriteLine("Enter number for Arithemetic operators")
            choose = Val(Console.ReadLine())
            If (choose < 1) Or (choose > 4) Then
                Console.WriteLine("Invalid number Input, Pls enter the right digit")
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")
            End If

            If choose = 1 Then
                Console.WriteLine("Enter the nunber for modules")
                modules = Console.ReadLine()
                Console.WriteLine("Enter the maximum nunber for multiplication table")
                number = Console.ReadLine()
                Console.WriteLine("____________________________________")
                Console.WriteLine("  ")
                For i = (1) To (number)

                    result = modules * i
                    Console.WriteLine(modules.ToString + ("*") + i.ToString + ("=") + result.ToString)
                Next
            ElseIf choose = 2 Then
                Console.WriteLine("Enter the nunber for modules")
                modules = Console.ReadLine()
                Console.WriteLine("Enter the maximum nunber for Addition table")
                number = Console.ReadLine()
                Console.WriteLine("____________________________________")
                Console.WriteLine("  ")
                For i = (1) To (number)
                    result = modules + i
                    Console.WriteLine(modules.ToString + ("+") + i.ToString + ("=") + result.ToString)
                Next
            ElseIf choose = 3 Then
                Console.WriteLine("Enter the nunber for modules")
                modules = Console.ReadLine()
                Console.WriteLine("Enter the maximum nunber for Subtraction table")
                number = Console.ReadLine()
                Console.WriteLine("____________________________________")
                Console.WriteLine("  ")
                For i = (1) To (number)
                    result = modules - i
                    Console.WriteLine(modules.ToString + ("-") + i.ToString + ("=") + result.ToString)
                Next
            ElseIf choose = 4 Then
                Console.WriteLine("Enter the nunber for modules")
                modules = Console.ReadLine()
                Console.WriteLine("Enter the maximum nunber for  Division table")
                number = Console.ReadLine()
                Console.WriteLine("____________________________________")
                Console.WriteLine("  ")
                For i = (1) To (number)
                    result = modules / i
                    Console.WriteLine(modules.ToString + ("/") + i.ToString + ("=") + result.ToString)
                Next
            End If
           
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
