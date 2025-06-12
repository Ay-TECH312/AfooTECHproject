Module Module1

    Sub Main()
        Dim DBMS201, UIUX202, AI203, SQT204, AA205, DevOps206 As Integer
        Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF As Integer
        Dim GPA, TGP, TCU As Double



        Console.WriteLine("THE SOFTWARE TO CALCULATE AfooTECH G.P.A CALCULATOR SECOND SEMESTER")
        Console.WriteLine("___________________________________________________________________")
        Console.WriteLine("  ")
        Console.WriteLine("  ")
        Console.WriteLine("  ")


        Console.WriteLine("THE COURSE CODE/ COURSE NAME")
        Console.WriteLine("_____________________________________________________")
        Console.WriteLine("  ")

        Console.WriteLine("Enter  grade score for (DBMS 201/Database Management System)")
        DBMS201 = Console.ReadLine()
        If (DBMS201 < 0) Or (DBMS201 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (UIUX 202/Uiux Design)")
        UIUX202 = Console.ReadLine()
        If (UIUX202 < 0) Or (UIUX202 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (AI 203/Artificial Inteligence)")
        AI203 = Console.ReadLine()
        If (AI203 < 0) Or (AI203 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (SQT 204/Software Quantity Testing)  ")
        SQT204 = Console.ReadLine()
        If (SQT204 < 0) Or (SQT204 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (AA 205 / Argumented Analystics)")
        AA205 = Console.ReadLine()
        If (AA205 < 0) Or (AA205 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("Enter  grade score for (DevOps 206/Software Development & IT Operators)  ")
        DevOps206 = Console.ReadLine()
        If (DevOps206 < 0) Or (DevOps206 > 100) Then
            Console.WriteLine("Invalid Input ")
            Console.ReadLine()
            End
        End If
        Console.WriteLine("___________________________________________________________  ")
        Console.WriteLine("  ")



        If (DBMS201 >= 80) And (DBMS201 <= 100) Then
            GradepointA = 5 * 4
        ElseIf (DBMS201 >= 70) And (DBMS201 <= 79.9) Then
            GradepointA = 5 * 3.5
        ElseIf (DBMS201 >= 60) And (DBMS201 <= 69.9) Then
            GradepointA = 5 * 3
        ElseIf (DBMS201 >= 50) And (DBMS201 <= 59.9) Then
            GradepointA = 5 * 2.5
        ElseIf (DBMS201 >= 40) And (DBMS201 <= 49.9) Then
            GradepointA = 5 * 2
        ElseIf (DBMS201 >= 0) And (DBMS201 <= 39.9) Then
            GradepointA = 5 * 0
        End If

        If (UIUX202 >= 80) And (UIUX202 <= 100) Then
            GradepointB = 3 * 4
        ElseIf (UIUX202 >= 70) And (UIUX202 <= 79.9) Then
            GradepointB = 3 * 3.5
        ElseIf (UIUX202 >= 60) And (UIUX202 <= 69.9) Then
            GradepointB = 3 * 3
        ElseIf (UIUX202 >= 50) And (UIUX202 <= 59.9) Then
            GradepointB = 3 * 2.5
        ElseIf (UIUX202 >= 40) And (UIUX202 <= 49.9) Then
            GradepointB = 3 * 2
        ElseIf (UIUX202 >= 0) And (UIUX202 <= 39.9) Then
            GradepointB = 3 * 0
        End If

        If (AI203 >= 80) And (AI203 <= 100) Then
            GradepointC = 5 * 4
        ElseIf (AI203 >= 70) And (AI203 <= 79.9) Then
            GradepointC = 5 * 3.5
        ElseIf (AI203 >= 60) And (AI203 <= 69.9) Then
            GradepointC = 5 * 3
        ElseIf (AI203 >= 50) And (AI203 <= 59.9) Then
            GradepointC = 5 * 2.5
        ElseIf (AI203 >= 40) And (AI203 <= 49.9) Then
            GradepointC = 5 * 2
        ElseIf (AI203 >= 0) And (AI203 <= 39.9) Then
            GradepointC = 5 * 0
        End If

        If (SQT204 >= 80) And (SQT204 <= 100) Then
            GradepointD = 3 * 4
        ElseIf (SQT204 >= 70) And (SQT204 <= 79.9) Then
            GradepointD = 3 * 3.5
        ElseIf (SQT204 >= 60) And (SQT204 <= 69.9) Then
            GradepointD = 3 * 3
        ElseIf (SQT204 >= 50) And (SQT204 <= 59.9) Then
            GradepointD = 3 * 2.5
        ElseIf (SQT204 >= 40) And (SQT204 <= 49.9) Then
            GradepointD = 3 * 2
        ElseIf (SQT204 >= 0) And (SQT204 <= 39.9) Then
            GradepointD = 3 * 0
        End If

        If (AA205 >= 80) And (AA205 <= 100) Then
            GradepointE = 4 * 4
        ElseIf (AA205 >= 70) And (AA205 <= 79.9) Then
            GradepointE = 4 * 3.5
        ElseIf (AA205 >= 60) And (AA205 <= 69.9) Then
            GradepointE = 4 * 3
        ElseIf (AA205 >= 50) And (AA205 <= 59.9) Then
            GradepointE = 4 * 2.5
        ElseIf (AA205 >= 40) And (AA205 <= 49.9) Then
            GradepointE = 4 * 2
        ElseIf (AA205 >= 0) And (AA205 <= 39.9) Then
            GradepointE = 4 * 0
        End If

        If (DevOps206 >= 80) And (DevOps206 <= 100) Then
            GradepointF = 4 * 4
        ElseIf (DevOps206 >= 70) And (DevOps206 <= 79.9) Then
            GradepointF = 4 * 3.5
        ElseIf (DevOps206 >= 60) And (DevOps206 <= 69.9) Then
            GradepointF = 4 * 3
        ElseIf (DevOps206 >= 50) And (DevOps206 <= 59.9) Then
            GradepointF = 4 * 2.5
        ElseIf (DevOps206 >= 40) And (DevOps206 <= 49.9) Then
            GradepointF = 4 * 2
        ElseIf (DevOps206 >= 0) And (DevOps206 <= 39.9) Then
            GradepointF = 4 * 0
        End If

        TGP = GradepointA + GradepointB + GradepointC + GradepointD + GradepointE + GradepointF
        TCU = 24
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
