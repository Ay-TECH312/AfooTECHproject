Module Module1

    Sub Main()
        Dim P1, P2, V1, V2, TPV, TPV2, TPV3, TPV4, V, P, PP, VV, result As Double
        Dim choose As Integer

        Console.WriteLine("BOYLES LAW CALCULATOR")
        Console.WriteLine("_____________________")
        Console.WriteLine(" ")

        Console.WriteLine("Press 1 for --Initial pressure ----p1 ")
        Console.WriteLine("Press 2 for--Initial Volume ---- V1 ")
        Console.WriteLine("Press 3 for--Final pressure ---- P2 ")
        Console.WriteLine("Press 4 for--Final Volume ----v2 ")

        choose = Val(Console.ReadLine())
        Console.WriteLine("_____________________")
        Console.WriteLine(" ")

        If (choose < 1) Or (choose > 4) Then
            Console.WriteLine("Invalid input value ")
            Console.ReadLine()
            End

        End If

        'SOLUTION_FOR P1'
        If choose = 1 Then
            Console.WriteLine("Find p1 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Final pressure)----p2 ")
            P2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Final Volume)----v2 ")
            V2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Volume)----v1 ")
            V1 = Console.ReadLine()

            TPV = (P2 * V2)
            V = V1
            result = TPV / V

            Console.WriteLine("P1 = " + result.ToString("n2") + (" ") + ("atm"))
        End If
        'SOLUTION_FOR V1'
        If choose = 2 Then
            Console.WriteLine("Find v1 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Final pressure)----p2 ")
            P2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Final Volume)----v2 ")
            V2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial pressure)----p1 ")
            P1 = Console.ReadLine()

            TPV2 = (P2 * V2)
            P = P1
            result = TPV2 / P
            Console.WriteLine("V1 = " + result.ToString("n2") + (" ") + ("mL"))
        End If

        'SOLUTION_FOR P2'
        If choose = 3 Then
            Console.WriteLine("Find p2 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Initial pressure)----p1 ")
            P1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Volume)----v1 ")
            V1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Final Volume)----v2 ")
            V2 = Console.ReadLine()

            TPV3 = (P1 * V1)
            PP = V2
            result = TPV3 / PP

            Console.WriteLine("P2 = " + result.ToString("n2") + (" ") + ("atm"))
        End If
        'SOLUTION_FOR V2'

        If choose = 4 Then
            Console.WriteLine("Find v2 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Initial pressure)----p1 ")
            P1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Volume)----v1 ")
            V1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (final pressure)----p2 ")
            P2 = Console.ReadLine()

            TPV4 = (P1 * V1)
            VV = P2
            result = TPV4 / VV
            Console.WriteLine("V2 = " + result.ToString("n2") + (" ") + ("mL"))

        End If

        Console.ReadLine()

    End Sub

End Module
