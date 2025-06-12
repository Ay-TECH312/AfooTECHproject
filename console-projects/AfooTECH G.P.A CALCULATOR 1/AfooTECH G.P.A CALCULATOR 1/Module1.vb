Module Module1

    Sub Main()
        Dim SDT101, MAD102, SDA103, WAD104, NS105, AGD106 As Integer
        Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6 As Integer
        Dim GPA, TGP, TCU As Double



        Console.WriteLine("THE SOFTWARE TO CALCULATE AfooTECH G.P.A CALCULATOR FIRST SEMESTER")
        Console.WriteLine("___________________________________________________________________")
        Console.WriteLine("  ")
        Console.WriteLine("  ")
        Console.WriteLine("  ")


        Console.WriteLine("THE COURSE CODE/ COURSE NAME")
        Console.WriteLine("_____________________________________________________")
        Console.WriteLine("  ")

        Console.WriteLine("Enter  grade score for (SDT 101/Software Development Training)")
        SDT101 = Console.ReadLine()
        If (SDT101 < 0) Or (SDT101 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (MAD 102/Mobile Application Development)  ")
        MAD102 = Console.ReadLine()
        If (MAD102 < 0) Or (MAD102 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (SDA 103/Software & Data Analysis)  ")
        SDA103 = Console.ReadLine()
        If (SDA103 < 0) Or (SDA103 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (WAD 104/Website & WebApp Development)  ")
        WAD104 = Console.ReadLine()
        If (WAD104 < 0) Or (WAD104 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (NS 105 / Networking & Security)  ")
        NS105 = Console.ReadLine()
        If (NS105 < 0) Or (NS105 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (AGD 106/Advance Graphics Design)  ")
        AGD106 = Console.ReadLine()
        If (AGD106 < 0) Or (AGD106 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("___________________________________________________________  ")
        Console.WriteLine("  ")



        If (SDT101 >= 80) And (SDT101 <= 100) Then
            Gradepoint1 = 4 * 4
        ElseIf (SDT101 >= 70) And (SDT101 <= 79.9) Then
            Gradepoint1 = 4 * 3.5
        ElseIf (SDT101 >= 60) And (SDT101 <= 69.9) Then
            Gradepoint1 = 4 * 3
        ElseIf (SDT101 >= 50) And (SDT101 <= 59.9) Then
            Gradepoint1 = 4 * 2.5
        ElseIf (SDT101 >= 40) And (SDT101 <= 49.9) Then
            Gradepoint1 = 4 * 2
        ElseIf (SDT101 >= 0) And (SDT101 <= 39.9) Then
            Gradepoint1 = 4 * 0
        End If

        If (MAD102 >= 80) And (MAD102 <= 100) Then
            Gradepoint2 = 4 * 4

        ElseIf (MAD102 >= 70) And (MAD102 <= 79.9) Then
            Gradepoint2 = 4 * 3.5
        ElseIf (MAD102 >= 60) And (MAD102 <= 69.9) Then
            Gradepoint2 = 4 * 3
        ElseIf (MAD102 >= 50) And (MAD102 <= 59.9) Then
            Gradepoint2 = 4 * 2.5
        ElseIf (MAD102 >= 40) And (MAD102 <= 49.9) Then
            Gradepoint2 = 4 * 2
        ElseIf (MAD102 >= 0) And (MAD102 <= 39.9) Then
            Gradepoint2 = 4 * 0
        End If

        If (SDA103 >= 80) And (SDA103 <= 100) Then
            Gradepoint3 = 5 * 4
        ElseIf (SDA103 >= 70) And (SDA103 <= 79.9) Then
            Gradepoint3 = 5 * 3.5
        ElseIf (SDA103 >= 60) And (SDA103 <= 69.9) Then
            Gradepoint3 = 5 * 3
        ElseIf (SDA103 >= 50) And (SDA103 <= 59.9) Then
            Gradepoint3 = 5 * 2.5
        ElseIf (SDA103 >= 40) And (SDA103 <= 49.9) Then
            Gradepoint3 = 5 * 2
        ElseIf (SDA103 >= 0) And (SDA103 <= 39.9) Then
            Gradepoint3 = 4 * 0
        End If

        If (WAD104 >= 80) And (WAD104 <= 100) Then
            Gradepoint4 = 4 * 4
        ElseIf (WAD104 >= 70) And (WAD104 <= 79.9) Then
            Gradepoint4 = 4 * 3.5
        ElseIf (WAD104 >= 60) And (WAD104 <= 69.9) Then
            Gradepoint4 = 4 * 3
        ElseIf (WAD104 >= 50) And (WAD104 <= 59.9) Then
            Gradepoint4 = 4 * 2.5
        ElseIf (WAD104 >= 40) And (WAD104 <= 49.9) Then
            Gradepoint4 = 4 * 2
        ElseIf (WAD104 >= 0) And (WAD104 <= 39.9) Then
            Gradepoint4 = 4 * 0
        End If

        If (NS105 >= 80) And (NS105 <= 100) Then
            Gradepoint5 = 4 * 4
        ElseIf (NS105 >= 70) And (NS105 <= 79.9) Then
            Gradepoint5 = 4 * 3.5
        ElseIf (NS105 >= 60) And (NS105 <= 69.9) Then
            Gradepoint5 = 4 * 3
        ElseIf (NS105 >= 50) And (NS105 <= 59.9) Then
            Gradepoint5 = 4 * 2.5
        ElseIf (NS105 >= 40) And (NS105 <= 49.9) Then
            Gradepoint5 = 4 * 2
        ElseIf (NS105 >= 0) And (NS105 <= 39.9) Then
            Gradepoint5 = 4 * 0
        End If

        If (AGD106 >= 80) And (AGD106 <= 100) Then
            Gradepoint6 = 4 * 4
        ElseIf (AGD106 >= 70) And (AGD106 <= 79.9) Then
            Gradepoint6 = 4 * 3.5
        ElseIf (AGD106 >= 60) And (AGD106 <= 69.9) Then
            Gradepoint6 = 4 * 3
        ElseIf (AGD106 >= 50) And (AGD106 <= 59.9) Then
            Gradepoint6 = 4 * 2.5
        ElseIf (AGD106 >= 40) And (AGD106 <= 49.9) Then
            Gradepoint6 = 4 * 2
        ElseIf (AGD106 >= 0) And (AGD106 <= 39.9) Then
            Gradepoint6 = 4 * 0
        End If


        TGP = Gradepoint1 + Gradepoint2 + Gradepoint3 + Gradepoint4 + Gradepoint5 + Gradepoint6
        TCU = 25
        GPA = TGP / TCU
        Console.WriteLine("The GPA = " + GPA.ToString)

        If (GPA >= 3.5) And (GPA <= 4.0) Then
            Console.WriteLine("DICTINCTION ")
        ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
            Console.WriteLine("UPPER CREDIT ")
        ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
            Console.WriteLine("LOWER CREDIT ")
        ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
            Console.WriteLine("PASS ")
        Else
            Console.WriteLine("FAIL ")
        End If
        Console.ReadLine()


    End Sub

End Module
