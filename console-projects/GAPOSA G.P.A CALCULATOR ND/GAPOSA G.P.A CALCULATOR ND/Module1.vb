Module Module1
    'SOLUTION FOR FIRST SEMESTER ND 1 FULL TIME'

    Sub Main()
        Dim GNS101, GNS102, MTH112, STA111, MEC101, MEC107, MEC113, EEC113, EEC116, COM111, pick As Integer
        Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6, Gradepoint7, Gradepoint8, Gradepoint9, Gradepoint10, choose As Double
        Dim GPA, TGP, TCU As Double

        Console.WriteLine("GAPOSA G.P.A CALCULATOR FOR COMPUTER ENGINEERING FULL TIME ND")
        Console.WriteLine("______________________________________________________________ ")
        Console.WriteLine("   ")

        Console.WriteLine("Press 1 for  ND I")
        Console.WriteLine("press 2 for  ND II")
        choose = Val(Console.ReadLine())
        If (choose < 1) Or (choose > 2) Then
            Console.WriteLine("Invalid Input, Pls enter the right digit")
            Console.ReadLine()
            End
        End If

        If choose = 1 Then
            Console.WriteLine("press 1 for first semester ND I")
            Console.WriteLine("press 2 for second semester ND I")
            pick = Val(Console.ReadLine())
            If (pick < 1) Or (pick > 2) Then
                Console.WriteLine("Invalid Input, Pls enter the right digit")
                Console.ReadLine()
                End
            End If

            If pick = 1 Then
                Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- FIRST SEMESTER ND I")
                Console.WriteLine("________________________________________________________")
                Console.WriteLine("  ")


                Console.WriteLine("Enter score for (Use Of English) ---- GNS101 ----(2 Units )")
                GNS101 = Console.ReadLine()
                If (GNS101 < 0) Or (GNS101 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Citizenship Education I) ---- GNS102----(2 Units )")
                GNS102 = Console.ReadLine()
                If (GNS102 < 0) Or (GNS102 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Algebra And Elementary Trigonometry)--------- MTH112----(2 Units )")
                MTH112 = Console.ReadLine()
                If (MTH112 < 0) Or (MTH112 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter  score for (Introduction To Statistics)------- STA111----(2 Units )")
                STA111 = Console.ReadLine()
                If (STA111 < 0) Or (STA111 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Technical Drawing)--------- MEC101----(2 Units )")
                MEC101 = Console.ReadLine()
                If (MEC101 < 0) Or (MEC101 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Mechanical Engineering Science)------ MEC107----(3 Units )")
                MEC107 = Console.ReadLine()
                If (MEC107 < 0) Or (MEC107 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Basic Workshop Technology and Practice)------ MEC113----(3 Units )")
                MEC113 = Console.ReadLine()
                If (MEC113 < 0) Or (MEC113 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Electrical Engineering Science I)------ EEC113----(2 Units )")
                EEC113 = Console.ReadLine()
                If (EEC113 < 0) Or (EEC113 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Electrical Workshop Practice I)------ EEC116----(2 Units )")
                EEC116 = Console.ReadLine()
                If (EEC116 < 0) Or (EEC116 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Mathematics III(Introduction To Computer)------ COM111----(2 Units )")
                COM111 = Console.ReadLine()
                If (COM111 < 0) Or (COM111 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("___________________________________________________________  ")
                Console.WriteLine("  ")

                If (GNS101 >= 75) And (GNS101 <= 100) Then
                    Gradepoint1 = 2 * 4.0
                ElseIf (GNS101 >= 70) And (GNS101 <= 74) Then
                    Gradepoint1 = 2 * 3.5
                ElseIf (GNS101 >= 65) And (GNS101 <= 69) Then
                    Gradepoint1 = 2 * 3.25
                ElseIf (GNS101 >= 60) And (GNS101 <= 64) Then
                    Gradepoint1 = 2 * 3.0
                ElseIf (GNS101 >= 55) And (GNS101 <= 59) Then
                    Gradepoint1 = 2 * 2.75
                ElseIf (GNS101 >= 50) And (GNS101 <= 54) Then
                    Gradepoint1 = 2 * 2.5
                ElseIf (GNS101 >= 45) And (GNS101 <= 49) Then
                    Gradepoint1 = 2 * 2.25
                ElseIf (GNS101 >= 40) And (GNS101 <= 44) Then
                    Gradepoint1 = 2 * 2.0
                ElseIf (GNS101 >= 0) And (GNS101 <= 39) Then
                    Gradepoint1 = 2 * 0.0
                End If

                If (GNS102 >= 75) And (GNS102 <= 100) Then
                    Gradepoint2 = 2 * 4
                ElseIf (GNS102 >= 70) And (GNS102 <= 74) Then
                    Gradepoint2 = 2 * 3.5
                ElseIf (GNS102 >= 65) And (GNS102 <= 69) Then
                    Gradepoint2 = 2 * 3.25
                ElseIf (GNS102 >= 60) And (GNS102 <= 64) Then
                    Gradepoint2 = 2 * 3.0
                ElseIf (GNS102 >= 55) And (GNS102 <= 59) Then
                    Gradepoint2 = 2 * 2.75
                ElseIf (GNS102 >= 50) And (GNS102 <= 54) Then
                    Gradepoint2 = 2 * 2.5
                ElseIf (GNS102 >= 45) And (GNS102 <= 49) Then
                    Gradepoint2 = 2 * 2.25
                ElseIf (GNS102 >= 40) And (GNS102 <= 44) Then
                    Gradepoint2 = 2 * 2.0
                ElseIf (GNS102 >= 0) And (GNS102 <= 39) Then
                    Gradepoint2 = 2 * 0.0
                End If

                If (MTH112 >= 75) And (MTH112 <= 100) Then
                    Gradepoint3 = 2 * 4
                ElseIf (MTH112 >= 70) And (MTH112 <= 74) Then
                    Gradepoint3 = 2 * 3.5
                ElseIf (MTH112 >= 65) And (MTH112 <= 69) Then
                    Gradepoint3 = 2 * 3.25
                ElseIf (MTH112 >= 60) And (MTH112 <= 64) Then
                    Gradepoint3 = 2 * 3.0
                ElseIf (MTH112 >= 55) And (MTH112 <= 59) Then
                    Gradepoint3 = 2 * 2.75
                ElseIf (MTH112 >= 50) And (MTH112 <= 54) Then
                    Gradepoint3 = 2 * 2.5
                ElseIf (MTH112 >= 45) And (MTH112 <= 49) Then
                    Gradepoint3 = 2 * 2.25
                ElseIf (MTH112 >= 40) And (MTH112 <= 44) Then
                    Gradepoint3 = 2 * 2.0
                ElseIf (MTH112 >= 0) And (MTH112 <= 39) Then
                    Gradepoint3 = 2 * 0.0
                End If

                If (STA111 >= 75) And (STA111 <= 100) Then
                    Gradepoint4 = 2 * 4
                ElseIf (STA111 >= 70) And (STA111 <= 74) Then
                    Gradepoint4 = 2 * 3.5
                ElseIf (STA111 >= 65) And (STA111 <= 69) Then
                    Gradepoint4 = 2 * 3.25
                ElseIf (STA111 >= 60) And (STA111 <= 64) Then
                    Gradepoint4 = 2 * 3.0
                ElseIf (STA111 >= 55) And (STA111 <= 59) Then
                    Gradepoint4 = 2 * 2.75
                ElseIf (STA111 >= 50) And (STA111 <= 54) Then
                    Gradepoint4 = 2 * 2.5
                ElseIf (STA111 >= 45) And (STA111 <= 49) Then
                    Gradepoint4 = 2 * 2.25
                ElseIf (STA111 >= 40) And (STA111 <= 44) Then
                    Gradepoint4 = 2 * 2.0
                ElseIf (STA111 >= 0) And (STA111 <= 39) Then
                    Gradepoint4 = 2 * 0.0
                End If

                If (MEC101 >= 75) And (MEC101 <= 100) Then
                    Gradepoint5 = 2 * 4
                ElseIf (MEC101 >= 70) And (MEC101 <= 74) Then
                    Gradepoint5 = 2 * 3.5
                ElseIf (MEC101 >= 65) And (MEC101 <= 69) Then
                    Gradepoint5 = 2 * 3.25
                ElseIf (MEC101 >= 60) And (MEC101 <= 64) Then
                    Gradepoint5 = 2 * 3.0
                ElseIf (MEC101 >= 55) And (MEC101 <= 59) Then
                    Gradepoint5 = 2 * 2.75
                ElseIf (MEC101 >= 50) And (MEC101 <= 54) Then
                    Gradepoint5 = 2 * 2.5
                ElseIf (MEC101 >= 45) And (MEC101 <= 49) Then
                    Gradepoint5 = 2 * 2.25
                ElseIf (MEC101 >= 40) And (MEC101 <= 44) Then
                    Gradepoint5 = 2 * 2.0
                ElseIf (MEC101 >= 0) And (MEC101 <= 39) Then
                    Gradepoint5 = 2 * 0.0
                End If

                If (MEC107 >= 75) And (MEC107 <= 100) Then
                    Gradepoint6 = 3 * 4
                ElseIf (MEC107 >= 70) And (MEC107 <= 74) Then
                    Gradepoint6 = 3 * 3.5
                ElseIf (MEC107 >= 65) And (MEC107 <= 69) Then
                    Gradepoint6 = 3 * 3.25
                ElseIf (MEC107 >= 60) And (MEC107 <= 64) Then
                    Gradepoint6 = 3 * 3.0
                ElseIf (MEC107 >= 55) And (MEC107 <= 59) Then
                    Gradepoint6 = 3 * 2.75
                ElseIf (MEC107 >= 50) And (MEC107 <= 54) Then
                    Gradepoint6 = 3 * 2.5
                ElseIf (MEC107 >= 45) And (MEC107 <= 49) Then
                    Gradepoint6 = 3 * 2.25
                ElseIf (MEC107 >= 40) And (MEC107 <= 44) Then
                    Gradepoint6 = 3 * 2.0
                ElseIf (MEC107 >= 0) And (MEC107 <= 39) Then
                    Gradepoint6 = 3 * 0.0
                End If

                If (MEC113 >= 75) And (MEC113 <= 100) Then
                    Gradepoint7 = 3 * 4
                ElseIf (MEC113 >= 70) And (MEC113 <= 74) Then
                    Gradepoint7 = 3 * 3.5
                ElseIf (MEC113 >= 65) And (MEC113 <= 69) Then
                    Gradepoint7 = 3 * 3.25
                ElseIf (MEC113 >= 60) And (MEC113 <= 64) Then
                    Gradepoint7 = 3 * 3.0
                ElseIf (MEC113 >= 55) And (MEC113 <= 59) Then
                    Gradepoint7 = 3 * 2.75
                ElseIf (MEC113 >= 50) And (MEC113 <= 54) Then
                    Gradepoint7 = 3 * 2.5
                ElseIf (MEC113 >= 45) And (MEC113 <= 49) Then
                    Gradepoint7 = 3 * 2.25
                ElseIf (MEC113 >= 40) And (MEC113 <= 44) Then
                    Gradepoint7 = 3 * 2.0
                ElseIf (MEC113 >= 0) And (MEC113 <= 39) Then
                    Gradepoint7 = 3 * 0.0
                End If

                If (EEC113 >= 75) And (EEC113 <= 100) Then
                    Gradepoint8 = 2 * 4
                ElseIf (EEC113 >= 70) And (EEC113 <= 74) Then
                    Gradepoint8 = 2 * 3.5
                ElseIf (EEC113 >= 65) And (EEC113 <= 69) Then
                    Gradepoint8 = 2 * 3.25
                ElseIf (EEC113 >= 60) And (EEC113 <= 64) Then
                    Gradepoint8 = 2 * 3.0
                ElseIf (EEC113 >= 55) And (EEC113 <= 59) Then
                    Gradepoint8 = 2 * 2.75
                ElseIf (EEC113 >= 50) And (EEC113 <= 54) Then
                    Gradepoint8 = 2 * 2.5
                ElseIf (EEC113 >= 45) And (EEC113 <= 49) Then
                    Gradepoint8 = 2 * 2.25
                ElseIf (EEC113 >= 40) And (EEC113 <= 44) Then
                    Gradepoint8 = 2 * 2.0
                ElseIf (EEC113 >= 0) And (EEC113 <= 39) Then
                    Gradepoint8 = 2 * 0.0
                End If

                If (EEC116 >= 75) And (EEC116 <= 100) Then
                    Gradepoint9 = 2 * 4
                ElseIf (EEC116 >= 70) And (EEC116 <= 74) Then
                    Gradepoint9 = 2 * 3.5
                ElseIf (EEC116 >= 65) And (EEC116 <= 69) Then
                    Gradepoint9 = 2 * 3.25
                ElseIf (EEC116 >= 60) And (EEC116 <= 64) Then
                    Gradepoint9 = 2 * 3.0
                ElseIf (EEC116 >= 55) And (EEC116 <= 59) Then
                    Gradepoint9 = 2 * 2.75
                ElseIf (EEC116 >= 50) And (EEC116 <= 54) Then
                    Gradepoint9 = 2 * 2.5
                ElseIf (EEC116 >= 45) And (EEC116 <= 49) Then
                    Gradepoint9 = 2 * 2.25
                ElseIf (EEC116 >= 40) And (EEC116 <= 44) Then
                    Gradepoint9 = 2 * 2.0
                ElseIf (EEC116 >= 0) And (EEC116 <= 39) Then
                    Gradepoint9 = 2 * 0.0
                End If

                If (COM111 >= 75) And (COM111 <= 100) Then
                    Gradepoint10 = 2 * 4
                ElseIf (COM111 >= 70) And (COM111 <= 74) Then
                    Gradepoint10 = 2 * 3.5
                ElseIf (COM111 >= 65) And (COM111 <= 69) Then
                    Gradepoint10 = 2 * 3.25
                ElseIf (COM111 >= 60) And (COM111 <= 64) Then
                    Gradepoint10 = 2 * 3.0
                ElseIf (COM111 >= 55) And (COM111 <= 59) Then
                    Gradepoint10 = 2 * 2.75
                ElseIf (COM111 >= 50) And (COM111 <= 54) Then
                    Gradepoint10 = 2 * 2.5
                ElseIf (COM111 >= 45) And (COM111 <= 49) Then
                    Gradepoint10 = 2 * 2.25
                ElseIf (COM111 >= 40) And (COM111 <= 44) Then
                    Gradepoint10 = 2 * 2.0
                ElseIf (COM111 >= 0) And (COM111 <= 39) Then
                    Gradepoint10 = 2 * 0.0
                End If

                TGP = Gradepoint1 + Gradepoint2 + Gradepoint3 + Gradepoint4 + Gradepoint5 + Gradepoint6 + Gradepoint7 + Gradepoint8 + Gradepoint9 + Gradepoint10
                TCU = 22
                GPA = TGP / TCU
                Console.WriteLine("GPA FOR FIRST SEMESTER  = " + GPA.ToString("n2"))

                If (GPA >= 3.5) And (GPA <= 4.0) Then
                    Console.WriteLine("DISTINCTION ")
                ElseIf (GPA >= 3.0) And (GPA <= 3.49) Then
                    Console.WriteLine("UPPER CREDIT ")
                ElseIf (GPA >= 2.5) And (GPA <= 2.99) Then
                    Console.WriteLine("LOWER CREDIT ")
                ElseIf (GPA >= 2.0) And (GPA <= 2.49) Then
                    Console.WriteLine("PASS ")
                Else
                    Console.WriteLine("FAIL ")
                End If
            End If

            'SOLUTION FOR SECOND SEMESTER ND 1 FULL TIME'

            Dim GNS202, GNS128, MTH211, MEC102, MEC108, EEC124, EEC126, COM122, COM221, CTE121, CTE122 As Integer
            Dim Gradepoint11, Gradepoint12, Gradepoint13, Gradepoint14, Gradepoint15, Gradepoint16, Gradepoint17, Gradepoint18, Gradepoint19, Gradepoint20, Gradepoint201 As Double
            Dim GPA2, TGP2, TCU2 As Double

            If pick = 2 Then
                Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- SECOND SEMESTER ND I")
                Console.WriteLine("________________________________________________________")
                Console.WriteLine("  ")

                Console.WriteLine("Enter score for (Communication In English) ---- GNS202----(2 Units )")
                GNS202 = Console.ReadLine()
                If (GNS202 < 0) Or (GNS202 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Citizenship Education II) ---- GNS128----(2 Units )")
                GNS128 = Console.ReadLine()
                If (GNS128 < 0) Or (GNS128 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Calculus)--------- MTH211----(2 Units )")
                MTH211 = Console.ReadLine()
                If (MTH211 < 0) Or (MTH211 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter  score for (Descriptive Geometry)------- MEC102----(2 Units )")
                MEC102 = Console.ReadLine()
                If (MEC102 < 0) Or (MEC102 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Introduction To Thermodynomics)--------- MEC108----(2 Units )")
                MEC108 = Console.ReadLine()
                If (MEC108 < 0) Or (MEC108 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Electronics I)------ EEC124----(3 Units )")
                EEC124 = Console.ReadLine()
                If (EEC124 < 0) Or (EEC124 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Electrical Workshop Practics II)------ EEC126----(1 Units )")
                EEC126 = Console.ReadLine()
                If (EEC126 < 0) Or (EEC126 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Computer Operations)------ COM122----(2 Units )")
                COM122 = Console.ReadLine()
                If (COM122 < 0) Or (COM122 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Computer Programming(FORTRAN))------ COM221----(3 Units )")
                COM221 = Console.ReadLine()
                If (COM221 < 0) Or (COM221 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Mathematics (Digital Computer Fundamentals I)------ CTE121----(2 Units )")
                CTE121 = Console.ReadLine()
                If (CTE121 < 0) Or (CTE121 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Mathematics (Electrical Measrement and Intrumentation I)------ CTE122----(2 Units )")
                CTE122 = Console.ReadLine()
                If (CTE122 < 0) Or (CTE122 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("___________________________________________________________  ")
                Console.WriteLine("  ")

                If (GNS202 >= 75) And (GNS202 <= 100) Then
                    Gradepoint11 = 2 * 4
                ElseIf (GNS202 >= 70) And (GNS202 <= 74) Then
                    Gradepoint11 = 2 * 3.5
                ElseIf (GNS202 >= 65) And (GNS202 <= 69) Then
                    Gradepoint11 = 2 * 3.25
                ElseIf (GNS202 >= 60) And (GNS202 <= 64) Then
                    Gradepoint11 = 2 * 3.0
                ElseIf (GNS202 >= 55) And (GNS202 <= 59) Then
                    Gradepoint11 = 2 * 2.75
                ElseIf (GNS202 >= 50) And (GNS202 <= 54) Then
                    Gradepoint11 = 2 * 2.5
                ElseIf (GNS202 >= 45) And (GNS202 <= 49) Then
                    Gradepoint11 = 2 * 2.25
                ElseIf (GNS202 >= 40) And (GNS202 <= 44) Then
                    Gradepoint11 = 2 * 2.0
                ElseIf (GNS202 >= 0) And (GNS202 <= 39) Then
                    Gradepoint11 = 2 * 0.0
                End If

                If (GNS128 >= 75) And (GNS128 <= 100) Then
                    Gradepoint12 = 2 * 4
                ElseIf (GNS128 >= 70) And (GNS128 <= 74) Then
                    Gradepoint12 = 2 * 3.5
                ElseIf (GNS128 >= 65) And (GNS128 <= 69) Then
                    Gradepoint12 = 2 * 3.25
                ElseIf (GNS128 >= 60) And (GNS128 <= 64) Then
                    Gradepoint12 = 2 * 3.0
                ElseIf (GNS128 >= 55) And (GNS128 <= 59) Then
                    Gradepoint12 = 2 * 2.75
                ElseIf (GNS128 >= 50) And (GNS128 <= 54) Then
                    Gradepoint12 = 2 * 2.5
                ElseIf (GNS128 >= 45) And (GNS128 <= 49) Then
                    Gradepoint12 = 2 * 2.25
                ElseIf (GNS128 >= 40) And (GNS128 <= 44) Then
                    Gradepoint12 = 2 * 2.0
                ElseIf (GNS128 >= 0) And (GNS128 <= 39) Then
                    Gradepoint12 = 2 * 0.0
                End If

                If (MTH211 >= 75) And (MTH211 <= 100) Then
                    Gradepoint13 = 2 * 4
                ElseIf (MTH211 >= 70) And (MTH211 <= 74) Then
                    Gradepoint13 = 2 * 3.5
                ElseIf (MTH211 >= 65) And (MTH211 <= 69) Then
                    Gradepoint13 = 2 * 3.25
                ElseIf (MTH211 >= 60) And (MTH211 <= 64) Then
                    Gradepoint13 = 2 * 3.0
                ElseIf (MTH211 >= 55) And (MTH211 <= 59) Then
                    Gradepoint13 = 2 * 2.75
                ElseIf (MTH211 >= 50) And (MTH211 <= 54) Then
                    Gradepoint13 = 2 * 2.5
                ElseIf (MTH211 >= 45) And (MTH211 <= 49) Then
                    Gradepoint13 = 2 * 2.25
                ElseIf (MTH211 >= 40) And (MTH211 <= 44) Then
                    Gradepoint13 = 2 * 2.0
                ElseIf (MTH211 >= 0) And (MTH211 <= 39) Then
                    Gradepoint13 = 2 * 0.0
                End If

                If (MEC102 >= 75) And (MEC102 <= 100) Then
                    Gradepoint14 = 2 * 4
                ElseIf (MEC102 >= 70) And (MEC102 <= 74) Then
                    Gradepoint14 = 2 * 3.5
                ElseIf (MEC102 >= 65) And (MEC102 <= 69) Then
                    Gradepoint14 = 2 * 3.25
                ElseIf (MEC102 >= 60) And (MEC102 <= 64) Then
                    Gradepoint14 = 2 * 3.0
                ElseIf (MEC102 >= 55) And (MEC102 <= 59) Then
                    Gradepoint14 = 2 * 2.75
                ElseIf (MEC102 >= 50) And (MEC102 <= 54) Then
                    Gradepoint14 = 2 * 2.5
                ElseIf (MEC102 >= 45) And (MEC102 <= 49) Then
                    Gradepoint14 = 2 * 2.25
                ElseIf (MEC102 >= 40) And (MEC102 <= 44) Then
                    Gradepoint14 = 2 * 2.0
                ElseIf (MEC102 >= 0) And (MEC102 <= 39) Then
                    Gradepoint14 = 2 * 0.0
                End If

                If (MEC108 >= 75) And (MEC108 <= 100) Then
                    Gradepoint15 = 2 * 4
                ElseIf (MEC108 >= 70) And (MEC108 <= 74) Then
                    Gradepoint15 = 2 * 3.5
                ElseIf (MEC108 >= 65) And (MEC108 <= 69) Then
                    Gradepoint15 = 2 * 3.25
                ElseIf (MEC108 >= 60) And (MEC108 <= 64) Then
                    Gradepoint15 = 2 * 3.0
                ElseIf (MEC108 >= 55) And (MEC108 <= 59) Then
                    Gradepoint15 = 2 * 2.75
                ElseIf (MEC108 >= 50) And (MEC108 <= 54) Then
                    Gradepoint15 = 2 * 2.5
                ElseIf (MEC108 >= 45) And (MEC108 <= 49) Then
                    Gradepoint15 = 2 * 2.25
                ElseIf (MEC108 >= 40) And (MEC108 <= 44) Then
                    Gradepoint15 = 2 * 2.0
                ElseIf (MEC108 >= 0) And (MEC108 <= 39) Then
                    Gradepoint15 = 2 * 0.0
                End If

                If (EEC124 >= 75) And (EEC124 <= 100) Then
                    Gradepoint16 = 3 * 4
                ElseIf (EEC124 >= 70) And (EEC124 <= 74) Then
                    Gradepoint6 = 3 * 3.5
                ElseIf (EEC124 >= 65) And (EEC124 <= 69) Then
                    Gradepoint16 = 3 * 3.25
                ElseIf (EEC124 >= 60) And (EEC124 <= 64) Then
                    Gradepoint16 = 3 * 3.0
                ElseIf (EEC124 >= 55) And (EEC124 <= 59) Then
                    Gradepoint16 = 3 * 2.75
                ElseIf (EEC124 >= 50) And (EEC124 <= 54) Then
                    Gradepoint16 = 3 * 2.5
                ElseIf (EEC124 >= 45) And (EEC124 <= 49) Then
                    Gradepoint16 = 3 * 2.25
                ElseIf (EEC124 >= 40) And (EEC124 <= 44) Then
                    Gradepoint16 = 3 * 2.0
                ElseIf (EEC124 >= 0) And (EEC124 <= 39) Then
                    Gradepoint16 = 3 * 0.0
                End If

                If (EEC126 >= 75) And (EEC126 <= 100) Then
                    Gradepoint17 = 1 * 4
                ElseIf (EEC126 >= 70) And (EEC126 <= 74) Then
                    Gradepoint17 = 1 * 3.5
                ElseIf (EEC126 >= 65) And (EEC126 <= 69) Then
                    Gradepoint17 = 1 * 3.25
                ElseIf (EEC126 >= 60) And (EEC126 <= 64) Then
                    Gradepoint17 = 1 * 3.0
                ElseIf (EEC126 >= 55) And (EEC126 <= 59) Then
                    Gradepoint17 = 1 * 2.75
                ElseIf (EEC126 >= 50) And (EEC126 <= 54) Then
                    Gradepoint17 = 1 * 2.5
                ElseIf (EEC126 >= 45) And (EEC126 <= 49) Then
                    Gradepoint17 = 1 * 2.25
                ElseIf (EEC126 >= 40) And (EEC126 <= 44) Then
                    Gradepoint17 = 1 * 2.0
                ElseIf (EEC126 >= 0) And (EEC126 <= 39) Then
                    Gradepoint17 = 1 * 0.0
                End If

                If (COM122 >= 75) And (COM122 <= 100) Then
                    Gradepoint18 = 2 * 4
                ElseIf (COM122 >= 70) And (COM122 <= 74) Then
                    Gradepoint18 = 2 * 3.5
                ElseIf (COM122 >= 65) And (COM122 <= 69) Then
                    Gradepoint18 = 2 * 3.25
                ElseIf (COM122 >= 60) And (COM122 <= 64) Then
                    Gradepoint18 = 2 * 3.0
                ElseIf (COM122 >= 55) And (COM122 <= 59) Then
                    Gradepoint18 = 2 * 2.75
                ElseIf (COM122 >= 50) And (COM122 <= 54) Then
                    Gradepoint18 = 2 * 2.5
                ElseIf (COM122 >= 45) And (COM122 <= 49) Then
                    Gradepoint18 = 2 * 2.25
                ElseIf (COM122 >= 40) And (COM122 <= 44) Then
                    Gradepoint18 = 2 * 2.0
                ElseIf (COM122 >= 0) And (COM122 <= 39) Then
                    Gradepoint18 = 2 * 0.0
                End If

                If (COM221 >= 75) And (COM221 <= 100) Then
                    Gradepoint19 = 3 * 4
                ElseIf (COM221 >= 70) And (COM221 <= 74) Then
                    Gradepoint19 = 3 * 3.5
                ElseIf (COM221 >= 65) And (COM221 <= 69) Then
                    Gradepoint19 = 3 * 3.25
                ElseIf (COM221 >= 60) And (COM221 <= 64) Then
                    Gradepoint19 = 3 * 3.0
                ElseIf (COM221 >= 55) And (COM221 <= 59) Then
                    Gradepoint19 = 3 * 2.75
                ElseIf (COM221 >= 50) And (COM221 <= 54) Then
                    Gradepoint19 = 3 * 2.5
                ElseIf (COM221 >= 45) And (COM221 <= 49) Then
                    Gradepoint19 = 3 * 2.25
                ElseIf (COM221 >= 40) And (COM221 <= 44) Then
                    Gradepoint19 = 3 * 2.0
                ElseIf (COM221 >= 0) And (COM221 <= 39) Then
                    Gradepoint19 = 3 * 0.0
                End If

                If (CTE121 >= 75) And (CTE121 <= 100) Then
                    Gradepoint20 = 2 * 4
                ElseIf (CTE121 >= 70) And (CTE121 <= 74) Then
                    Gradepoint20 = 2 * 3.5
                ElseIf (CTE121 >= 65) And (CTE121 <= 69) Then
                    Gradepoint20 = 2 * 3.25
                ElseIf (CTE121 >= 60) And (CTE121 <= 64) Then
                    Gradepoint20 = 2 * 3.0
                ElseIf (CTE121 >= 55) And (CTE121 <= 59) Then
                    Gradepoint20 = 2 * 2.75
                ElseIf (CTE121 >= 50) And (CTE121 <= 54) Then
                    Gradepoint20 = 2 * 2.5
                ElseIf (CTE121 >= 45) And (CTE121 <= 49) Then
                    Gradepoint20 = 2 * 2.25
                ElseIf (CTE121 >= 40) And (CTE121 <= 44) Then
                    Gradepoint20 = 2 * 2.0
                ElseIf (CTE121 >= 0) And (CTE121 <= 39) Then
                    Gradepoint20 = 2 * 0.0
                End If


                If (CTE122 >= 75) And (CTE122 <= 100) Then
                    Gradepoint201 = 2 * 4
                ElseIf (CTE122 >= 70) And (CTE122 <= 74) Then
                    Gradepoint201 = 2 * 3.5
                ElseIf (CTE122 >= 65) And (CTE122 <= 69) Then
                    Gradepoint201 = 2 * 3.25
                ElseIf (CTE122 >= 60) And (CTE122 <= 64) Then
                    Gradepoint201 = 2 * 3.0
                ElseIf (CTE122 >= 55) And (CTE122 <= 59) Then
                    Gradepoint201 = 2 * 2.75
                ElseIf (CTE122 >= 50) And (CTE122 <= 54) Then
                    Gradepoint201 = 2 * 2.5
                ElseIf (CTE122 >= 45) And (CTE122 <= 49) Then
                    Gradepoint201 = 2 * 2.25
                ElseIf (CTE122 >= 40) And (CTE122 <= 44) Then
                    Gradepoint201 = 2 * 2.0
                ElseIf (CTE122 >= 0) And (CTE122 <= 39) Then
                    Gradepoint201 = 2 * 0.0
                End If

                TGP2 = Gradepoint11 + Gradepoint12 + Gradepoint13 + Gradepoint14 + Gradepoint15 + Gradepoint16 + Gradepoint17 + Gradepoint18 + Gradepoint19 + Gradepoint20 + Gradepoint201
                TCU2 = 23
                GPA2 = TGP2 / TCU2
                Console.WriteLine("GPA FOR SECOND SEMESTER = " + GPA2.ToString("N2"))

                If (GPA2 >= 3.5) And (GPA2 <= 4.0) Then
                    Console.WriteLine("DISTINCTION ")
                ElseIf (GPA2 >= 3.0) And (GPA2 <= 3.49) Then
                    Console.WriteLine("UPPER CREDIT ")
                ElseIf (GPA2 >= 2.5) And (GPA2 <= 2.99) Then
                    Console.WriteLine("LOWER CREDIT ")
                ElseIf (GPA2 >= 2.0) And (GPA2 <= 2.49) Then
                    Console.WriteLine("PASS ")
                Else
                    Console.WriteLine("FAIL ")
                End If

            End If

        End If

        'SOLUTION FOR FIRST SEMESTER ND 2 FULL TIME'

        Dim GNS201, MTH202, EEC239, EEC234, CTE231, CTE232, CTE233, CTE234, CTE235, CTE236 As Integer
        Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF, GradepointG, GradepointH, Gradepoint19I, Gradepoint2J As Double
        Dim GPA3, TGP3, TCU3 As Double

        If choose = 2 Then
            If (choose < 1) Or (choose > 2) Then
                Console.WriteLine("Inavalid Input, Pls enter the right digit")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("press 1 for first semester ND II")
            Console.WriteLine("press 2 for second semester ND II")
            pick = Val(Console.ReadLine())
            If (pick < 1) Or (pick > 2) Then
                Console.WriteLine("Inavalid Input, Pls enter the right digit")
                Console.ReadLine()
                End
            End If

            If pick = 1 Then
                Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- FIRST SEMESTER ND 2")
                Console.WriteLine("________________________________________________________")
                Console.WriteLine("  ")

                Console.WriteLine("Enter score for (Use Of English II) ---- GNS201----(2 Units )")
                GNS201 = Console.ReadLine()
                If (GNS201 < 0) Or (GNS201 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Logic and Linear Algebra) ---- MTH202----(2 Units )")
                MTH202 = Console.ReadLine()
                If (MTH202 < 0) Or (MTH202 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Electrical Circuit Theory I)--------- EEEC239----(2 Units )")
                EEC239 = Console.ReadLine()
                If (EEC239 < 0) Or (EEC239 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter  score for (Electronics II)------- EEC234----(3 Units )")
                EEC234 = Console.ReadLine()
                If (EEC234 < 0) Or (EEC234 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Micro Computer Fundamentals)--------- CTE231----(3 Units )")
                CTE231 = Console.ReadLine()
                If (CTE231 < 0) Or (CTE231 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Computer Workshop Practices I)------CTE232----(2 Units )")
                CTE232 = Console.ReadLine()
                If (CTE232 < 0) Or (CTE232 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Digital Computer Fundamentals II)------ CTE233----(3 Units )")
                CTE233 = Console.ReadLine()
                If (CTE233 < 0) Or (CTE233 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Computer Architecture)------ CTE234----(1 Units )")
                CTE234 = Console.ReadLine()
                If (CTE234 < 0) Or (CTE234 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Electrical Measurement and Instrumentation II)------ MTH418----(2 Units )")
                CTE235 = Console.ReadLine()
                If (CTE235 < 0) Or (CTE235 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Mathematics (Electronic Computer Maintenance and Repair)------ CTE236----(2 Units )")
                CTE236 = Console.ReadLine()
                If (CTE236 < 0) Or (CTE236 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("___________________________________________________________  ")
                Console.WriteLine("  ")

                If (GNS201 >= 75) And (GNS201 <= 100) Then
                    GradepointA = 2 * 4
                ElseIf (GNS201 >= 70) And (GNS201 <= 74) Then
                    GradepointA = 2 * 3.5
                ElseIf (GNS201 >= 65) And (GNS201 <= 69) Then
                    GradepointA = 2 * 3.25
                ElseIf (GNS201 >= 60) And (GNS201 <= 64) Then
                    GradepointA = 2 * 3.0
                ElseIf (GNS201 >= 55) And (GNS201 <= 59) Then
                    GradepointA = 2 * 2.75
                ElseIf (GNS201 >= 50) And (GNS201 <= 54) Then
                    GradepointA = 2 * 2.5
                ElseIf (GNS201 >= 45) And (GNS201 <= 49) Then
                    GradepointA = 2 * 2.25
                ElseIf (GNS201 >= 40) And (GNS201 <= 44) Then
                    GradepointA = 2 * 2.0
                ElseIf (GNS201 >= 0) And (GNS201 <= 39) Then
                    GradepointA = 2 * 0.0
                End If

                If (MTH202 >= 75) And (MTH202 <= 100) Then
                    GradepointB = 2 * 4
                ElseIf (MTH202 >= 70) And (MTH202 <= 74) Then
                    GradepointB = 2 * 3.5
                ElseIf (MTH202 >= 65) And (MTH202 <= 69) Then
                    GradepointB = 2 * 3.25
                ElseIf (MTH202 >= 60) And (MTH202 <= 64) Then
                    GradepointB = 2 * 3.0
                ElseIf (MTH202 >= 55) And (MTH202 <= 59) Then
                    GradepointB = 2 * 2.75
                ElseIf (MTH202 >= 50) And (MTH202 <= 54) Then
                    GradepointB = 2 * 2.5
                ElseIf (MTH202 >= 45) And (MTH202 <= 49) Then
                    GradepointB = 2 * 2.25
                ElseIf (MTH202 >= 40) And (MTH202 <= 44) Then
                    GradepointB = 2 * 2.0
                ElseIf (MTH202 >= 0) And (MTH202 <= 39) Then
                    GradepointB = 2 * 0.0
                End If

                If (EEC239 >= 75) And (EEC239 <= 100) Then
                    GradepointC = 2 * 4
                ElseIf (EEC239 >= 70) And (EEC239 <= 74) Then
                    GradepointC = 2 * 3.5
                ElseIf (EEC239 >= 65) And (EEC239 <= 69) Then
                    GradepointC = 2 * 3.25
                ElseIf (EEC239 >= 60) And (EEC239 <= 64) Then
                    GradepointC = 2 * 3.0
                ElseIf (EEC239 >= 55) And (EEC239 <= 59) Then
                    GradepointC = 2 * 2.75
                ElseIf (EEC239 >= 50) And (EEC239 <= 54) Then
                    GradepointC = 2 * 2.5
                ElseIf (EEC239 >= 45) And (EEC239 <= 49) Then
                    GradepointC = 2 * 2.25
                ElseIf (EEC239 >= 40) And (EEC239 <= 44) Then
                    GradepointC = 2 * 2.0
                ElseIf (EEC239 >= 0) And (EEC239 <= 39) Then
                    GradepointC = 2 * 0.0
                End If

                If (EEC234 >= 75) And (EEC234 <= 100) Then
                    GradepointD = 3 * 4
                ElseIf (EEC234 >= 70) And (EEC234 <= 74) Then
                    GradepointD = 3 * 3.5
                ElseIf (EEC234 >= 65) And (EEC234 <= 69) Then
                    GradepointD = 3 * 3.25
                ElseIf (EEC234 >= 60) And (EEC234 <= 64) Then
                    GradepointD = 3 * 3.0
                ElseIf (EEC234 >= 55) And (EEC234 <= 59) Then
                    GradepointD = 3 * 2.75
                ElseIf (EEC234 >= 50) And (EEC234 <= 54) Then
                    GradepointD = 3 * 2.5
                ElseIf (EEC234 >= 45) And (EEC234 <= 49) Then
                    GradepointD = 3 * 2.25
                ElseIf (EEC234 >= 40) And (EEC234 <= 44) Then
                    GradepointD = 3 * 2.0
                ElseIf (EEC234 >= 0) And (EEC234 <= 39) Then
                    GradepointD = 3 * 0.0
                End If

                If (CTE231 >= 75) And (CTE231 <= 100) Then
                    GradepointE = 3 * 4
                ElseIf (CTE231 >= 70) And (CTE231 <= 74) Then
                    GradepointE = 3 * 3.5
                ElseIf (CTE231 >= 65) And (CTE231 <= 69) Then
                    GradepointE = 3 * 3.25
                ElseIf (CTE231 >= 60) And (CTE231 <= 64) Then
                    GradepointE = 3 * 3.0
                ElseIf (CTE231 >= 55) And (CTE231 <= 59) Then
                    GradepointE = 3 * 2.75
                ElseIf (CTE231 >= 50) And (CTE231 <= 54) Then
                    GradepointE = 3 * 2.5
                ElseIf (CTE231 >= 45) And (CTE231 <= 49) Then
                    GradepointE = 3 * 2.25
                ElseIf (CTE231 >= 40) And (CTE231 <= 44) Then
                    GradepointE = 3 * 2.0
                ElseIf (CTE231 >= 0) And (CTE231 <= 39) Then
                    GradepointE = 3 * 0.0
                End If

                If (CTE232 >= 75) And (CTE232 <= 100) Then
                    GradepointF = 2 * 4
                ElseIf (CTE232 >= 70) And (CTE232 <= 74) Then
                    GradepointF = 2 * 3.5
                ElseIf (CTE232 >= 65) And (CTE232 <= 69) Then
                    GradepointF = 2 * 3.25
                ElseIf (CTE232 >= 60) And (CTE232 <= 64) Then
                    GradepointF = 2 * 3.0
                ElseIf (CTE232 >= 55) And (CTE232 <= 59) Then
                    GradepointF = 2 * 2.75
                ElseIf (CTE232 >= 50) And (CTE232 <= 54) Then
                    GradepointF = 2 * 2.5
                ElseIf (CTE232 >= 45) And (CTE232 <= 49) Then
                    GradepointF = 2 * 2.25
                ElseIf (CTE232 >= 40) And (CTE232 <= 44) Then
                    GradepointF = 2 * 2.0
                ElseIf (CTE232 >= 0) And (CTE232 <= 39) Then
                    GradepointF = 2 * 0.0
                End If

                If (CTE233 >= 75) And (CTE233 <= 100) Then
                    GradepointG = 3 * 4
                ElseIf (CTE233 >= 70) And (CTE233 <= 74) Then
                    GradepointG = 3 * 3.5
                ElseIf (CTE233 >= 65) And (CTE233 <= 69) Then
                    GradepointG = 3 * 3.25
                ElseIf (CTE233 >= 60) And (CTE233 <= 64) Then
                    GradepointG = 3 * 3.0
                ElseIf (CTE233 >= 55) And (CTE233 <= 59) Then
                    GradepointG = 3 * 2.75
                ElseIf (CTE233 >= 50) And (CTE233 <= 54) Then
                    GradepointG = 3 * 2.5
                ElseIf (CTE233 >= 45) And (CTE233 <= 49) Then
                    GradepointG = 3 * 2.25
                ElseIf (CTE233 >= 40) And (CTE233 <= 44) Then
                    GradepointG = 3 * 2.0
                ElseIf (CTE233 >= 0) And (CTE233 <= 39) Then
                    GradepointG = 3 * 0.0
                End If

                If (CTE234 >= 75) And (CTE234 <= 100) Then
                    GradepointH = 1 * 4
                ElseIf (CTE234 >= 70) And (CTE234 <= 74) Then
                    GradepointH = 1 * 3.5
                ElseIf (CTE234 >= 65) And (CTE234 <= 69) Then
                    GradepointH = 1 * 3.25
                ElseIf (CTE234 >= 60) And (CTE234 <= 64) Then
                    GradepointH = 1 * 3.0
                ElseIf (CTE234 >= 55) And (CTE234 <= 59) Then
                    GradepointH = 1 * 2.75
                ElseIf (CTE234 >= 50) And (CTE234 <= 54) Then
                    GradepointH = 1 * 2.5
                ElseIf (CTE234 >= 45) And (CTE234 <= 49) Then
                    GradepointH = 1 * 2.25
                ElseIf (CTE234 >= 40) And (CTE234 <= 44) Then
                    GradepointH = 1 * 2.0
                ElseIf (CTE234 >= 0) And (CTE234 <= 39) Then
                    GradepointH = 1 * 0.0
                End If

                If (CTE235 >= 75) And (CTE235 <= 100) Then
                    Gradepoint19I = 2 * 4
                ElseIf (CTE235 >= 70) And (CTE235 <= 74) Then
                    Gradepoint19I = 2 * 3.5
                ElseIf (CTE235 >= 65) And (CTE235 <= 69) Then
                    Gradepoint19I = 2 * 3.25
                ElseIf (CTE235 >= 60) And (CTE235 <= 64) Then
                    Gradepoint19I = 2 * 3.0
                ElseIf (CTE235 >= 55) And (CTE235 <= 59) Then
                    Gradepoint19I = 2 * 2.75
                ElseIf (CTE235 >= 50) And (CTE235 <= 54) Then
                    Gradepoint19I = 2 * 2.5
                ElseIf (CTE235 >= 45) And (CTE235 <= 49) Then
                    Gradepoint19I = 2 * 2.25
                ElseIf (CTE235 >= 40) And (CTE235 <= 44) Then
                    Gradepoint19I = 2 * 2.0
                ElseIf (CTE235 >= 0) And (CTE235 <= 39) Then
                    Gradepoint19I = 2 * 0.0
                End If

                If (CTE236 >= 75) And (CTE236 <= 100) Then
                    Gradepoint2J = 2 * 4
                ElseIf (CTE236 >= 70) And (CTE236 <= 74) Then
                    Gradepoint2J = 2 * 3.5
                ElseIf (CTE236 >= 65) And (CTE236 <= 69) Then
                    Gradepoint2J = 2 * 3.25
                ElseIf (CTE236 >= 60) And (CTE236 <= 64) Then
                    Gradepoint2J = 2 * 3.0
                ElseIf (CTE236 >= 55) And (CTE236 <= 59) Then
                    Gradepoint2J = 2 * 2.75
                ElseIf (CTE236 >= 50) And (CTE236 <= 54) Then
                    Gradepoint2J = 2 * 2.5
                ElseIf (CTE236 >= 45) And (CTE236 <= 49) Then
                    Gradepoint2J = 2 * 2.25
                ElseIf (CTE236 >= 40) And (CTE236 <= 44) Then
                    Gradepoint2J = 2 * 2.0
                ElseIf (CTE236 >= 0) And (CTE236 <= 39) Then
                    Gradepoint2J = 1 * 0.0
                End If

                TGP3 = GradepointA + GradepointB + GradepointC + GradepointD + GradepointE + GradepointF + GradepointG + GradepointH + Gradepoint19I + Gradepoint2J
                TCU3 = 22
                GPA3 = TGP3 / TCU3
                Console.WriteLine(" GPA FOR SECOND SEMESTER = " + GPA3.ToString("N2"))

                If (GPA3 >= 3.5) And (GPA3 <= 4.0) Then
                    Console.WriteLine("DISTINCTION ")
                ElseIf (GPA3 >= 3.0) And (GPA3 <= 3.49) Then
                    Console.WriteLine("UPPER CREDIT ")
                ElseIf (GPA3 >= 2.5) And (GPA3 <= 2.99) Then
                    Console.WriteLine("LOWER CREDIT ")
                ElseIf (GPA3 >= 2.0) And (GPA3 <= 2.49) Then
                    Console.WriteLine("PASS ")
                Else
                    Console.WriteLine("FAIL ")
                End If

            End If

            'SOLUTION FOR SECOND SEMESTER ND 2 FULL TIME'

            Dim GNS202, MTH122, EEC249, CTE245, CTE241, CTE242, CTE243, CTE244, CTE246 As Integer
            Dim Gradepoint01, Gradepoint02, Gradepoint03, Gradepoint04, Gradepoint05, Gradepoint06, Gradepoint07, Gradepoint08, Gradepoint09 As Double
            Dim GPA4, TGP4, TCU4 As Double

            If pick = 2 Then
                Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- SECOND SEMESTER ND 2")
                Console.WriteLine("________________________________________________________")
                Console.WriteLine("  ")

                Console.WriteLine("Enter score for (Communication In English II) ---- GNS202----(2 Units )")
                GNS202 = Console.ReadLine()
                If (GNS202 < 0) Or (GNS202 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Trigonomentry and Analytical Geometry) ---- MTH122----(2 Units )")
                MTH122 = Console.ReadLine()
                If (MTH122 < 0) Or (MTH122 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Electrical Circuit Theory II)--------- EEC249----(2 Units )")
                EEC249 = Console.ReadLine()
                If (EEC249 < 0) Or (EEC249 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter  score for (Telecommunication Engineering)-------  CTE245----(3 Units )")
                CTE245 = Console.ReadLine()
                If (CTE245 < 0) Or (CTE245 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Introduction To Micro-processor and Micro-programming)---- CTE241----(2 Units )")
                CTE241 = Console.ReadLine()
                If (CTE241 < 0) Or (CTE241 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Computer Workshop Pratice II)------ CTE242----(1 Units )")
                CTE242 = Console.ReadLine()
                If (CTE242 < 0) Or (CTE242 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Operating Systems)------ CTE243----(2 Units )")
                CTE243 = Console.ReadLine()
                If (CTE243 < 0) Or (CTE243 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Compter Power System (Introduction to Control))------ CTE244----(2 Units )")
                CTE244 = Console.ReadLine()
                If (CTE244 < 0) Or (CTE244 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("Enter score for (Poject)------ CTE246----(6 Units )")
                CTE246 = Console.ReadLine()
                If (CTE246 < 0) Or (CTE246 > 100) Then
                    Console.WriteLine("Invalid Input ")
                    Console.ReadLine()
                    End
                End If

                Console.WriteLine("___________________________________________________________  ")
                Console.WriteLine("  ")

                If (GNS202 >= 75) And (GNS202 <= 100) Then
                    Gradepoint01 = 2 * 4
                ElseIf (GNS202 >= 70) And (GNS202 <= 74) Then
                    Gradepoint01 = 2 * 3.5
                ElseIf (GNS202 >= 65) And (GNS202 <= 69) Then
                    Gradepoint01 = 2 * 3.25
                ElseIf (GNS202 >= 60) And (GNS202 <= 64) Then
                    Gradepoint01 = 2 * 3.0
                ElseIf (GNS202 >= 55) And (GNS202 <= 59) Then
                    Gradepoint01 = 2 * 2.75
                ElseIf (GNS202 >= 50) And (GNS202 <= 54) Then
                    Gradepoint01 = 2 * 2.5
                ElseIf (GNS202 >= 45) And (GNS202 <= 49) Then
                    Gradepoint01 = 2 * 2.25
                ElseIf (GNS202 >= 40) And (GNS202 <= 44) Then
                    Gradepoint01 = 2 * 2.0
                ElseIf (GNS202 >= 0) And (GNS202 <= 39) Then
                    Gradepoint01 = 2 * 0.0
                End If

                If (MTH122 >= 75) And (MTH122 <= 100) Then
                    Gradepoint02 = 2 * 4
                ElseIf (MTH122 >= 70) And (MTH122 <= 74) Then
                    Gradepoint02 = 2 * 3.5
                ElseIf (MTH122 >= 65) And (MTH122 <= 69) Then
                    Gradepoint02 = 2 * 3.25
                ElseIf (MTH122 >= 60) And (MTH122 <= 64) Then
                    Gradepoint02 = 2 * 3.0
                ElseIf (MTH122 >= 55) And (MTH122 <= 59) Then
                    Gradepoint02 = 2 * 2.75
                ElseIf (MTH122 >= 50) And (MTH122 <= 54) Then
                    Gradepoint02 = 2 * 2.5
                ElseIf (MTH122 >= 45) And (MTH122 <= 49) Then
                    Gradepoint02 = 2 * 2.25
                ElseIf (MTH122 >= 40) And (MTH122 <= 44) Then
                    Gradepoint02 = 2 * 2.0
                ElseIf (MTH122 >= 0) And (MTH122 <= 39) Then
                    Gradepoint02 = 2 * 0.0
                End If

                If (EEC249 >= 75) And (EEC249 <= 100) Then
                    Gradepoint03 = 2 * 4
                ElseIf (EEC249 >= 70) And (EEC249 <= 74) Then
                    Gradepoint03 = 2 * 3.5
                ElseIf (EEC249 >= 65) And (EEC249 <= 69) Then
                    Gradepoint03 = 2 * 3.25
                ElseIf (EEC249 >= 60) And (EEC249 <= 64) Then
                    Gradepoint03 = 2 * 3.0
                ElseIf (EEC249 >= 55) And (EEC249 <= 59) Then
                    Gradepoint03 = 2 * 2.75
                ElseIf (EEC249 >= 50) And (EEC249 <= 54) Then
                    Gradepoint03 = 2 * 2.5
                ElseIf (EEC249 >= 45) And (EEC249 <= 49) Then
                    Gradepoint03 = 2 * 2.25
                ElseIf (EEC249 >= 40) And (EEC249 <= 44) Then
                    Gradepoint03 = 2 * 2.0
                ElseIf (EEC249 >= 0) And (EEC249 <= 39) Then
                    Gradepoint03 = 2 * 0.0
                End If

                If (CTE245 >= 75) And (CTE245 <= 100) Then
                    Gradepoint04 = 3 * 4
                ElseIf (CTE245 >= 70) And (CTE245 <= 74) Then
                    Gradepoint04 = 3 * 3.5
                ElseIf (CTE245 >= 65) And (CTE245 <= 69) Then
                    Gradepoint04 = 3 * 3.25
                ElseIf (CTE245 >= 60) And (CTE245 <= 64) Then
                    Gradepoint04 = 3 * 3.0
                ElseIf (CTE245 >= 55) And (CTE245 <= 59) Then
                    Gradepoint04 = 3 * 2.75
                ElseIf (CTE245 >= 50) And (CTE245 <= 54) Then
                    Gradepoint04 = 3 * 2.5
                ElseIf (CTE245 >= 45) And (CTE245 <= 49) Then
                    Gradepoint04 = 3 * 2.25
                ElseIf (CTE245 >= 40) And (CTE245 <= 44) Then
                    Gradepoint04 = 3 * 2.0
                ElseIf (CTE245 >= 0) And (CTE245 <= 39) Then
                    Gradepoint04 = 3 * 0.0
                End If

                If (CTE241 >= 75) And (CTE241 <= 100) Then
                    Gradepoint05 = 2 * 4
                ElseIf (CTE241 >= 70) And (CTE241 <= 74) Then
                    Gradepoint05 = 2 * 3.5
                ElseIf (CTE241 >= 65) And (CTE241 <= 69) Then
                    Gradepoint05 = 2 * 3.25
                ElseIf (CTE241 >= 60) And (CTE241 <= 64) Then
                    Gradepoint05 = 2 * 3.0
                ElseIf (CTE241 >= 55) And (CTE241 <= 59) Then
                    Gradepoint05 = 2 * 2.75
                ElseIf (CTE241 >= 50) And (CTE241 <= 54) Then
                    Gradepoint05 = 2 * 2.5
                ElseIf (CTE241 >= 45) And (CTE241 <= 49) Then
                    Gradepoint05 = 2 * 2.25
                ElseIf (CTE241 >= 40) And (CTE241 <= 44) Then
                    Gradepoint05 = 2 * 2.0
                ElseIf (CTE241 >= 0) And (CTE241 <= 39) Then
                    Gradepoint05 = 2 * 0.0
                End If

                If (CTE242 >= 75) And (CTE242 <= 100) Then
                    Gradepoint06 = 1 * 4
                ElseIf (CTE242 >= 70) And (CTE242 <= 74) Then
                    Gradepoint06 = 1 * 3.5
                ElseIf (CTE242 >= 65) And (CTE242 <= 69) Then
                    Gradepoint06 = 1 * 3.25
                ElseIf (CTE242 >= 60) And (CTE242 <= 64) Then
                    Gradepoint06 = 1 * 3.0
                ElseIf (CTE242 >= 55) And (CTE242 <= 59) Then
                    Gradepoint06 = 1 * 2.75
                ElseIf (CTE242 >= 50) And (CTE242 <= 54) Then
                    Gradepoint06 = 1 * 2.5
                ElseIf (CTE242 >= 45) And (CTE242 <= 49) Then
                    Gradepoint06 = 1 * 2.25
                ElseIf (CTE242 >= 40) And (CTE242 <= 44) Then
                    Gradepoint06 = 1 * 2.0
                ElseIf (CTE242 >= 0) And (CTE242 <= 39) Then
                    Gradepoint06 = 1 * 0.0
                End If

                If (CTE243 >= 75) And (CTE243 <= 100) Then
                    Gradepoint07 = 2 * 4
                ElseIf (CTE243 >= 70) And (CTE243 <= 74) Then
                    Gradepoint07 = 2 * 3.5
                ElseIf (CTE243 >= 65) And (CTE243 <= 69) Then
                    Gradepoint07 = 2 * 3.25
                ElseIf (CTE243 >= 60) And (CTE243 <= 64) Then
                    Gradepoint07 = 2 * 3.0
                ElseIf (CTE243 >= 55) And (CTE243 <= 59) Then
                    Gradepoint07 = 2 * 2.75
                ElseIf (CTE243 >= 50) And (CTE243 <= 54) Then
                    Gradepoint07 = 2 * 2.5
                ElseIf (CTE243 >= 45) And (CTE243 <= 49) Then
                    Gradepoint07 = 2 * 2.25
                ElseIf (CTE243 >= 40) And (CTE243 <= 44) Then
                    Gradepoint07 = 2 * 2.0
                ElseIf (CTE243 >= 0) And (CTE243 <= 39) Then
                    Gradepoint07 = 2 * 0.0
                End If

                If (CTE244 >= 75) And (CTE244 <= 100) Then
                    Gradepoint08 = 2 * 4
                ElseIf (CTE244 >= 70) And (CTE244 <= 74) Then
                    Gradepoint08 = 2 * 3.5
                ElseIf (CTE244 >= 65) And (CTE244 <= 69) Then
                    Gradepoint08 = 2 * 3.25
                ElseIf (CTE244 >= 60) And (CTE244 <= 64) Then
                    Gradepoint08 = 2 * 3.0
                ElseIf (CTE244 >= 55) And (CTE244 <= 59) Then
                    Gradepoint08 = 2 * 2.75
                ElseIf (CTE244 >= 50) And (CTE244 <= 54) Then
                    Gradepoint08 = 2 * 2.5
                ElseIf (CTE244 >= 45) And (CTE244 <= 49) Then
                    Gradepoint08 = 2 * 2.25
                ElseIf (CTE244 >= 40) And (CTE244 <= 44) Then
                    Gradepoint08 = 2 * 2.0
                ElseIf (CTE244 >= 0) And (CTE244 <= 39) Then
                    Gradepoint08 = 2 * 0.0
                End If


                If (CTE246 >= 75) And (CTE246 <= 100) Then
                    Gradepoint09 = 6 * 4
                ElseIf (CTE246 >= 70) And (CTE246 <= 74) Then
                    Gradepoint09 = 6 * 3.5
                ElseIf (CTE246 >= 65) And (CTE246 <= 69) Then
                    Gradepoint09 = 6 * 3.25
                ElseIf (CTE246 >= 60) And (CTE246 <= 64) Then
                    Gradepoint09 = 6 * 3.0
                ElseIf (CTE246 >= 55) And (CTE246 <= 59) Then
                    Gradepoint09 = 6 * 2.75
                ElseIf (CTE246 >= 50) And (CTE246 <= 54) Then
                    Gradepoint09 = 6 * 2.5
                ElseIf (CTE246 >= 45) And (CTE246 <= 49) Then
                    Gradepoint09 = 6 * 2.25
                ElseIf (CTE246 >= 40) And (CTE246 <= 44) Then
                    Gradepoint09 = 6 * 2.0
                ElseIf (CTE246 >= 0) And (CTE246 <= 39) Then
                    Gradepoint09 = 6 * 0.0
                End If

                TGP4 = Gradepoint01 + Gradepoint02 + Gradepoint03 + Gradepoint04 + Gradepoint05 + Gradepoint06 + Gradepoint07 + Gradepoint08 + Gradepoint09
                TCU4 = 22
                GPA4 = TGP4 / TCU4
                Console.WriteLine("GPA FOR SECOND SEMESTER = " + GPA4.ToString("N2"))

                If (GPA4 >= 3.5) And (GPA4 <= 4.0) Then
                    Console.WriteLine("DISTINCTION ")
                ElseIf (GPA4 >= 3.0) And (GPA4 <= 3.49) Then
                    Console.WriteLine("UPPER CREDIT ")
                ElseIf (GPA4 >= 2.5) And (GPA4 <= 2.99) Then
                    Console.WriteLine("LOWER CREDIT ")
                ElseIf (GPA4 >= 2.0) And (GPA4 <= 2.49) Then
                    Console.WriteLine("PASS ")
                Else
                    Console.WriteLine("FAIL ")
                End If
            End If
        End If

        Console.ReadLine()





    End Sub

End Module


