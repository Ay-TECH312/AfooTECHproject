Module Module1

    Sub Main()
        Dim result, modules, c, number As Integer

        Console.WriteLine("SOFWARE FOR LOOP STATEMENT VERSION 2")
        Console.WriteLine("____________________________________")
        Console.WriteLine("  ")
        Do
            Console.WriteLine("Enter the nunber for modules")
            modules = Console.ReadLine()
            Console.WriteLine("Enter the maximum nunber for the multiplication table")
            number = Console.ReadLine()
            Console.WriteLine("____________________________________")
            Console.WriteLine("  ")
            For i = (1) To (number)

                result = i * modules
                Console.WriteLine(modules.ToString + ("*") + i.ToString + ("=") + result.ToString)
            Next

            Do
                Console.WriteLine("Press 1 to exit")
                Console.WriteLine("Press 2 to continue......")
                c = Console.ReadLine()
                If c <> 1 AndAlso c <> 2 Then
                    Console.WriteLine("Invalid input. Please press 1 or 2.")
                End If
            Loop Until c = 1 Or c = 2

        Loop Until c = 1


        Console.ReadLine()


    End Sub

End Module
