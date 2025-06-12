Module Module1

    Sub Main()
        'SOLUTION FOR FIRST SEMESTER STARTS HERE'
        Dim SDT101, MAD102, SDA103, WAD104, NS105, AGD106 As Integer
        Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6, choose As Integer
        Dim GPA, TGP, TCU As Double




        Console.WriteLine("AfooTECH G.P.A CALCULATOR  ")
        Console.WriteLine("____________________________  ")
        Console.WriteLine("   ")

        Console.WriteLine("Press 1 for first semester")
        Console.WriteLine("press 2 for second semester")
        choose = Console.ReadLine()
        If (choose < 1) Or (choose > 2) Then
            Console.WriteLine("Inavalid Input, Pls enter the right digit")
            Console.ReadLine()
            End
        End If

        If choose = 1 Then


            Console.WriteLine("AfooTECH G.P.A CALCULATOR ---- FIRST SEMESTER")
            Console.WriteLine("___________________________________________________________________")
            Console.WriteLine("  ")


            Console.WriteLine("Enter score for (Software Development Training) ---- SDT 101")
            SDT101 = Console.ReadLine()
            If (SDT101 < 0) Or (SDT101 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
             End
            End If

            Console.WriteLine("Enter score for (Mobile Application Development) ---- MAD 102")
            MAD102 = Console.ReadLine()
            If (MAD102 < 0) Or (MAD102 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Software & Data Analysis)--------- SDA 103  ")
            SDA103 = Console.ReadLine()
            If (SDA103 < 0) Or (SDA103 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If
            Console.WriteLine("Enter  score for (Website & WebApp Development)------- WAD 104 ")
            WAD104 = Console.ReadLine()
            If (WAD104 < 0) Or (WAD104 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If
            Console.WriteLine("Enter score for (Networking & Security)--------- NS 105")
            NS105 = Console.ReadLine()
            If (NS105 < 0) Or (NS105 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If
            Console.WriteLine("Enter score for (Advance Graphics Design)------ AGD 106 ")
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
                Gradepoint3 = 5 * 0
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
        End If



            'SOLUTION FOR SECOND SEMESTER STARTS HERE'
            If choose = 2 Then

                Dim DBMS201, UIUX202, AI203, SQT204, AA205, DevOps206 As Integer
                Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF As Integer
                Dim GPA2, TGP2, TCU2 As Double



            Console.WriteLine("AfooTECH G.P.A CALCULATOR----- SECOND SEMESTER")
            Console.WriteLine("___________________________________________________")
                Console.WriteLine("  ")
                Console.WriteLine("  ")
                Console.WriteLine("  ")


            Console.WriteLine("THE COURSE CODE--- COURSE NAME")
                Console.WriteLine("_____________________________________________________")
                Console.WriteLine("  ")

            Console.WriteLine("Enter score for (Database Management System)---- DBMS 201")
                DBMS201 = Console.ReadLine()
                If (DBMS201 < 0) Or (DBMS201 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
            End If

            Console.WriteLine("Enter  score for (Uiux Design)------ UIUX 202")
                UIUX202 = Console.ReadLine()
                If (UIUX202 < 0) Or (UIUX202 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
            End If

            Console.WriteLine("Enter score for (Artificial Inteligence)----- AI 203")
                AI203 = Console.ReadLine()
                If (AI203 < 0) Or (AI203 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
            End If

            Console.WriteLine("Enter score for (Software Quantity Testing)----- SQT 204")
                SQT204 = Console.ReadLine()
                If (SQT204 < 0) Or (SQT204 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
            End If

            Console.WriteLine("Enter score for (Argumented Analystics)AA 205")
                AA205 = Console.ReadLine()
                If (AA205 < 0) Or (AA205 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
            End If

            Console.WriteLine("Enter score for (Software Development & IT Operators)----- DevOps 206")
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

                TGP2 = GradepointA + GradepointB + GradepointC + GradepointD + GradepointE + GradepointF
                TCU2 = 24
                GPA2 = TGP2 / TCU2
                Console.WriteLine("The GPA = " + GPA2.ToString)

                If (GPA2 >= 3.5) And (GPA <= 4.0) Then
                    Console.WriteLine("DICTINCTION ")
                ElseIf (GPA2 >= 3.0) And (GPA <= 3.49) Then
                    Console.WriteLine("UPPER CREDIT ")
                ElseIf (GPA2 >= 2.5) And (GPA <= 2.99) Then
                    Console.WriteLine("LOWER CREDIT ")
                ElseIf (GPA2 >= 2.0) And (GPA <= 2.49) Then
                    Console.WriteLine("PASS ")
                Else
                    Console.WriteLine("FAIL ")
                End If

            End If

            Console.ReadLine()

    End Sub

End Module
