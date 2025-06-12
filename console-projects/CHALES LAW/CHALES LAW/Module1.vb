Module Module1

    Sub Main()
        Dim T1, T2, V1, V2, TPV, TPV2, TPV3, TPV4, V, P, PP, VV, result As Double
        Dim choose As Integer

        Console.WriteLine("CHARLES LAW CALCULATOR")
        Console.WriteLine("_____________________")
        Console.WriteLine(" ")

        Console.WriteLine("Press 1 for --Initial Temperature ----T1 ")
        Console.WriteLine("Press 2 for--Initial Volume ---- V1 ")
        Console.WriteLine("Press 3 for--Final Temperature ---- T2 ")
        Console.WriteLine("Press 4 for--Final Volume ----v2 ")

        choose = Val(Console.ReadLine())
        Console.WriteLine("_____________________")
        Console.WriteLine(" ")

        If (choose < 1) Or (choose > 4) Then
            Console.WriteLine("Invalid input value ")
            Console.ReadLine()
            End

        End If

        'SOLUTION_FOR T1'
        If choose = 1 Then
            Console.WriteLine("Find T1 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Final Temperature)----T2 ")
            T2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Final Temperature)----v2 ")
            V2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Volume)----v1 ")
            V1 = Console.ReadLine()

            TPV = (T2 * V1)
            V = V2
            result = TPV / V

            Console.WriteLine("T1 = " + result.ToString("n2") + (" ") + ("K"))
        End If
        'SOLUTION_FOR V1'
        If choose = 2 Then
            Console.WriteLine("Find v1 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Final Temperature)----T2 ")
            T2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Final Volume)----v2 ")
            V2 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Temperature)----T1 ")
            T1 = Console.ReadLine()

            TPV2 = (V2 * T1)
            P = T2
            result = TPV2 / P
            Console.WriteLine("V1 = " + result.ToString("n2") + (" ") + ("mL"))
        End If

        'SOLUTION_FOR T2'
        If choose = 3 Then
            Console.WriteLine("Find T2 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Initial Temperature)----T1 ")
            T1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Volume)----v1 ")
            V1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Final Volume)----v2 ")
            V2 = Console.ReadLine()

            TPV3 = (T1 * V2)
            PP = V1
            result = TPV3 / PP

            Console.WriteLine("T2 = " + result.ToString("n2") + (" ") + ("K"))
        End If
        'SOLUTION_FOR V2'

        If choose = 4 Then
            Console.WriteLine("Find v2 ")
            Console.WriteLine(" ")

            Console.WriteLine("Enter the value for (Initial Temperature)----T1 ")
            T1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (Initial Volume)----v1 ")
            V1 = Console.ReadLine()
            Console.WriteLine("Enter the value for (final Temperature)----T2 ")
            T2 = Console.ReadLine()

            TPV4 = (T2 * V1)
            VV = T1
            result = TPV4 / VV
            Console.WriteLine("V2 = " + result.ToString("n2") + (" ") + ("mL"))

        End If

        Console.ReadLine()

    End Sub

End Module
