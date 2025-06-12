Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Do Until c = "1"
            Console.WriteLine("THE LOOP STATEMENT")
            Console.WriteLine("____________________________________")
            Console.WriteLine("  ")

         
            Console.WriteLine("Enter the nunber")
            b = Console.ReadLine()
            For i = 1 To 12
                a = i * b
                Console.WriteLine(b.ToString + ("*") + i.ToString + ("=") + a.ToString)
            Next

            Console.WriteLine("Press 1 to exit...")
            Console.WriteLine("Press 2 to continue...")
            c = Console.ReadLine
        Loop



        Console.ReadLine()

    End Sub

End Module
