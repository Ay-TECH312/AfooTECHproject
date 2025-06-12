Module Module1

    'SOLUTION FOR FIRST SEMESTER HND 1 FULL TIME'

    Sub Main()
        Dim CTE313, CTE314, CTE315, CTE316, EEC313, EEC314, EEC315, EEC316, GNS311, MTH311 As Integer
        Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6, Gradepoint7, Gradepoint8, Gradepoint9, Gradepoint10, choose As Integer
        Dim GPA, TGP, TCU As Double



        Console.WriteLine("GAPOSA G.P.A CALCULATOR FOR COMPUTER ENGINEERING FULL TIME")
        Console.WriteLine("__________________________________________________________ ")
        Console.WriteLine("   ")

        Console.WriteLine("Press 1 for first semester HND I")
        Console.WriteLine("press 2 for second semester HND I")
        Console.WriteLine("press 3 for first semester HND II")
        Console.WriteLine("press 4 for second semester HND II")
        choose = Console.ReadLine()
        If (choose < 1) Or (choose > 4) Then
            Console.WriteLine("Inavalid Input, Pls enter the right digit")
            Console.ReadLine()
            End
        End If

        If choose = 1 Then


            Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- FIRST SEMESTER HND I")
            Console.WriteLine("________________________________________________________")
            Console.WriteLine("  ")


            Console.WriteLine("Enter score for (Computer Programming Using c/c++ Language) ---- CTE313")
            CTE313 = Console.ReadLine()
            If (CTE313 < 0) Or (CTE313 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Operating System II) ---- CTE314")
            CTE314 = Console.ReadLine()
            If (CTE314 < 0) Or (CTE314 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Electronic Design and Prototyping)--------- CTE315")
            CTE315 = Console.ReadLine()
            If (CTE315 < 0) Or (CTE315 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter  score for (Computer Installation and Maintenance)------- CTE316")
            CTE316 = Console.ReadLine()
            If (CTE316 < 0) Or (CTE316 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Electrical Circuit Theory III)--------- EEC313")
            EEC313 = Console.ReadLine()
            If (EEC313 < 0) Or (EEC313 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Electrical Measurement and Instrumentation)------ EEC314")
            EEC314 = Console.ReadLine()
            If (EEC314 < 0) Or (EEC314 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Electonics III)------ EEC315")
            EEC315 = Console.ReadLine()
            If (EEC315 < 0) Or (EEC315 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Telecommunications II)------ EEC316")
            EEC316 = Console.ReadLine()
            If (EEC316 < 0) Or (EEC316 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for Engineering In Society)------ GNS311")
            GNS311 = Console.ReadLine()
            If (GNS311 < 0) Or (GNS311 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Mathematics III(Advanced Algebra)------ MTH311")
            MTH311 = Console.ReadLine()
            If (MTH311 < 0) Or (MTH311 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("___________________________________________________________  ")
            Console.WriteLine("  ")



            If (CTE313 >= 75) And (CTE313 <= 100) Then
                Gradepoint1 = 2 * 4
            ElseIf (CTE313 >= 70) And (CTE313 <= 74) Then
                Gradepoint1 = 2 * 3.5
            ElseIf (CTE313 >= 65) And (CTE313 <= 69) Then
                Gradepoint1 = 2 * 3.25
            ElseIf (CTE313 >= 60) And (CTE313 <= 64) Then
                Gradepoint1 = 2 * 3.0
            ElseIf (CTE313 >= 55) And (CTE313 <= 59) Then
                Gradepoint1 = 2 * 2.75
            ElseIf (CTE313 >= 50) And (CTE313 <= 54) Then
                Gradepoint1 = 2 * 2.5
            ElseIf (CTE313 >= 45) And (CTE313 <= 49) Then
                Gradepoint1 = 2 * 2.25
            ElseIf (CTE313 >= 40) And (CTE313 <= 44) Then
                Gradepoint1 = 2 * 2.0
            ElseIf (CTE313 >= 0) And (CTE313 <= 39) Then
                Gradepoint1 = 2 * 0.0
            End If

            If (CTE314 >= 75) And (CTE314 <= 100) Then
                Gradepoint2 = 2 * 4
            ElseIf (CTE314 >= 70) And (CTE314 <= 74) Then
                Gradepoint2 = 2 * 3.5
            ElseIf (CTE314 >= 65) And (CTE314 <= 69) Then
                Gradepoint2 = 2 * 3.25
            ElseIf (CTE314 >= 60) And (CTE314 <= 64) Then
                Gradepoint2 = 2 * 3.0
            ElseIf (CTE314 >= 55) And (CTE314 <= 59) Then
                Gradepoint2 = 2 * 2.75
            ElseIf (CTE314 >= 50) And (CTE314 <= 54) Then
                Gradepoint2 = 2 * 2.5
            ElseIf (CTE314 >= 45) And (CTE314 <= 49) Then
                Gradepoint2 = 2 * 2.25
            ElseIf (CTE314 >= 40) And (CTE314 <= 44) Then
                Gradepoint2 = 2 * 2.0
            ElseIf (CTE314 >= 0) And (CTE314 <= 39) Then
                Gradepoint2 = 2 * 0.0
            End If

            If (CTE315 >= 75) And (CTE315 <= 100) Then
                Gradepoint3 = 2 * 4
            ElseIf (CTE315 >= 70) And (CTE315 <= 74) Then
                Gradepoint3 = 2 * 3.5
            ElseIf (CTE315 >= 65) And (CTE315 <= 69) Then
                Gradepoint3 = 2 * 3.25
            ElseIf (CTE315 >= 60) And (CTE315 <= 64) Then
                Gradepoint3 = 2 * 3.0
            ElseIf (CTE315 >= 55) And (CTE315 <= 59) Then
                Gradepoint3 = 2 * 2.75
            ElseIf (CTE315 >= 50) And (CTE315 <= 54) Then
                Gradepoint3 = 2 * 2.5
            ElseIf (CTE315 >= 45) And (CTE315 <= 49) Then
                Gradepoint3 = 2 * 2.25
            ElseIf (CTE315 >= 40) And (CTE315 <= 44) Then
                Gradepoint3 = 2 * 2.0
            ElseIf (CTE315 >= 0) And (CTE315 <= 39) Then
                Gradepoint3 = 2 * 0.0
            End If

            If (CTE316 >= 75) And (CTE316 <= 100) Then
                Gradepoint4 = 3 * 4
            ElseIf (CTE316 >= 70) And (CTE316 <= 74) Then
                Gradepoint4 = 3 * 3.5
            ElseIf (CTE316 >= 65) And (CTE316 <= 69) Then
                Gradepoint4 = 3 * 3.25
            ElseIf (CTE316 >= 60) And (CTE316 <= 64) Then
                Gradepoint4 = 3 * 3.0
            ElseIf (CTE316 >= 55) And (CTE316 <= 59) Then
                Gradepoint4 = 3 * 2.75
            ElseIf (CTE316 >= 50) And (CTE316 <= 54) Then
                Gradepoint4 = 3 * 2.5
            ElseIf (CTE316 >= 45) And (CTE316 <= 49) Then
                Gradepoint4 = 3 * 2.25
            ElseIf (CTE316 >= 40) And (CTE316 <= 44) Then
                Gradepoint4 = 3 * 2.0
            ElseIf (CTE316 >= 0) And (CTE316 <= 39) Then
                Gradepoint4 = 3 * 0.0
            End If

            If (EEC313 >= 75) And (EEC313 <= 100) Then
                Gradepoint5 = 2 * 4
            ElseIf (EEC313 >= 70) And (EEC313 <= 74) Then
                Gradepoint5 = 2 * 3.5
            ElseIf (EEC313 >= 65) And (EEC313 <= 69) Then
                Gradepoint5 = 2 * 3.25
            ElseIf (EEC313 >= 60) And (EEC313 <= 64) Then
                Gradepoint5 = 2 * 3.0
            ElseIf (EEC313 >= 55) And (EEC313 <= 59) Then
                Gradepoint5 = 2 * 2.75
            ElseIf (EEC313 >= 50) And (EEC313 <= 54) Then
                Gradepoint5 = 2 * 2.5
            ElseIf (EEC313 >= 45) And (EEC313 <= 49) Then
                Gradepoint5 = 2 * 2.25
            ElseIf (EEC313 >= 40) And (EEC313 <= 44) Then
                Gradepoint5 = 2 * 2.0
            ElseIf (EEC313 >= 0) And (EEC313 <= 39) Then
                Gradepoint5 = 2 * 0.0
            End If

            If (EEC314 >= 75) And (EEC314 <= 100) Then
                Gradepoint6 = 2 * 4
            ElseIf (EEC314 >= 70) And (EEC314 <= 74) Then
                Gradepoint6 = 2 * 3.5
            ElseIf (EEC314 >= 65) And (EEC314 <= 69) Then
                Gradepoint6 = 2 * 3.25
            ElseIf (EEC314 >= 60) And (EEC314 <= 64) Then
                Gradepoint6 = 2 * 3.0
            ElseIf (EEC314 >= 55) And (EEC314 <= 59) Then
                Gradepoint6 = 2 * 2.75
            ElseIf (EEC314 >= 50) And (EEC314 <= 54) Then
                Gradepoint6 = 2 * 2.5
            ElseIf (EEC314 >= 45) And (EEC314 <= 49) Then
                Gradepoint6 = 2 * 2.25
            ElseIf (EEC314 >= 40) And (EEC314 <= 44) Then
                Gradepoint6 = 2 * 2.0
            ElseIf (EEC314 >= 0) And (EEC314 <= 39) Then
                Gradepoint6 = 2 * 0.0
            End If

            If (EEC315 >= 75) And (EEC315 <= 100) Then
                Gradepoint7 = 2 * 4
            ElseIf (EEC315 >= 70) And (EEC315 <= 74) Then
                Gradepoint7 = 2 * 3.5
            ElseIf (EEC315 >= 65) And (EEC315 <= 69) Then
                Gradepoint7 = 2 * 3.25
            ElseIf (EEC315 >= 60) And (EEC315 <= 64) Then
                Gradepoint7 = 2 * 3.0
            ElseIf (EEC315 >= 55) And (EEC315 <= 59) Then
                Gradepoint7 = 2 * 2.75
            ElseIf (EEC315 >= 50) And (EEC315 <= 54) Then
                Gradepoint7 = 2 * 2.5
            ElseIf (EEC315 >= 45) And (EEC315 <= 49) Then
                Gradepoint7 = 2 * 2.25
            ElseIf (EEC315 >= 40) And (EEC315 <= 44) Then
                Gradepoint7 = 2 * 2.0
            ElseIf (EEC315 >= 0) And (EEC315 <= 39) Then
                Gradepoint7 = 2 * 0.0
            End If

            If (EEC316 >= 75) And (EEC316 <= 100) Then
                Gradepoint8 = 3 * 4
            ElseIf (EEC316 >= 70) And (EEC316 <= 74) Then
                Gradepoint8 = 3 * 3.5
            ElseIf (EEC316 >= 65) And (EEC316 <= 69) Then
                Gradepoint8 = 3 * 3.25
            ElseIf (EEC316 >= 60) And (EEC316 <= 64) Then
                Gradepoint8 = 3 * 3.0
            ElseIf (EEC316 >= 55) And (EEC316 <= 59) Then
                Gradepoint8 = 3 * 2.75
            ElseIf (EEC316 >= 50) And (EEC316 <= 54) Then
                Gradepoint8 = 3 * 2.5
            ElseIf (EEC316 >= 45) And (EEC316 <= 49) Then
                Gradepoint8 = 3 * 2.25
            ElseIf (EEC316 >= 40) And (EEC316 <= 44) Then
                Gradepoint8 = 3 * 2.0
            ElseIf (EEC316 >= 0) And (CTE313 <= 39) Then
                Gradepoint8 = 3 * 0.0
            End If

            If (GNS311 >= 75) And (GNS311 <= 100) Then
                Gradepoint9 = 2 * 4
            ElseIf (GNS311 >= 70) And (GNS311 <= 74) Then
                Gradepoint9 = 2 * 3.5
            ElseIf (GNS311 >= 65) And (GNS311 <= 69) Then
                Gradepoint9 = 2 * 3.25
            ElseIf (GNS311 >= 60) And (GNS311 <= 64) Then
                Gradepoint9 = 2 * 3.0
            ElseIf (GNS311 >= 55) And (GNS311 <= 59) Then
                Gradepoint9 = 2 * 2.75
            ElseIf (GNS311 >= 50) And (GNS311 <= 54) Then
                Gradepoint9 = 2 * 2.5
            ElseIf (GNS311 >= 45) And (GNS311 <= 49) Then
                Gradepoint9 = 2 * 2.25
            ElseIf (GNS311 >= 40) And (GNS311 <= 44) Then
                Gradepoint9 = 2 * 2.0
            ElseIf (GNS311 >= 0) And (GNS311 <= 39) Then
                Gradepoint9 = 2 * 0.0
            End If

            If (MTH311 >= 75) And (MTH311 <= 100) Then
                Gradepoint10 = 2 * 4
            ElseIf (MTH311 >= 70) And (MTH311 <= 74) Then
                Gradepoint10 = 2 * 3.5
            ElseIf (MTH311 >= 65) And (MTH311 <= 69) Then
                Gradepoint10 = 2 * 3.25
            ElseIf (MTH311 >= 60) And (MTH311 <= 64) Then
                Gradepoint10 = 2 * 3.0
            ElseIf (MTH311 >= 55) And (MTH311 <= 59) Then
                Gradepoint10 = 2 * 2.75
            ElseIf (MTH311 >= 50) And (MTH311 <= 54) Then
                Gradepoint10 = 2 * 2.5
            ElseIf (MTH311 >= 45) And (MTH311 <= 49) Then
                Gradepoint10 = 2 * 2.25
            ElseIf (MTH311 >= 40) And (MTH311 <= 44) Then
                Gradepoint10 = 2 * 2.0
            ElseIf (MTH311 >= 0) And (MTH311 <= 39) Then
                Gradepoint10 = 2 * 0.0
            End If

            TGP = Gradepoint1 + Gradepoint2 + Gradepoint3 + Gradepoint4 + Gradepoint5 + Gradepoint6 + Gradepoint7 + Gradepoint8 + Gradepoint9 + Gradepoint10
            TCU = 22
            GPA = TGP / TCU
            Console.WriteLine("GPA FOR FIRST SEMESTER  = " + GPA.ToString)

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

        End If

        Console.ReadLine()


        'SOLUTION FOR SECOND SEMESTER HND 1 FULL TIME'


        Dim CTE321, CTE322, CTE323, EEC323, EEC324, EEC328, EEC325, GNS322, GNS323, MTH322 As Integer
        Dim Gradepoint11, Gradepoint12, Gradepoint13, Gradepoint14, Gradepoint15, Gradepoint16, Gradepoint17, Gradepoint18, Gradepoint19, Gradepoint20 As Integer
        Dim GPA2, TGP2, TCU2 As Double


        If choose = 2 Then


            Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- SECOND SEMESTER HND I")
            Console.WriteLine("________________________________________________________")
            Console.WriteLine("  ")


            Console.WriteLine("Enter score for (Computer Hardware System Design) ---- CTE321")
            CTE321 = Console.ReadLine()
            If (CTE321 < 0) Or (CTE321 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Wireless and Wireless Communication) ---- CTE322")
            CTE322 = Console.ReadLine()
            If (CTE322 < 0) Or (CTE322 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Python Programming)--------- CTE323")
            CTE323 = Console.ReadLine()
            If (CTE323 < 0) Or (CTE323 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter  score for (Electrical Circuit Theory IV)------- EEC323")
            EEC323 = Console.ReadLine()
            If (EEC323 < 0) Or (EEC323 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Control Engineering I)--------- EEC324")
            EEC324 = Console.ReadLine()
            If (EEC324 < 0) Or (EEC324 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Testing Methods and Reliability)------ EEC328")
            EEC328 = Console.ReadLine()
            If (EEC328 < 0) Or (EEC328 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Electronics IV)------ EEC325")
            EEC325 = Console.ReadLine()
            If (EEC325 < 0) Or (EEC325 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Industrial Management)------ GNS322")
            GNS322 = Console.ReadLine()
            If (GNS322 < 0) Or (GNS322 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Communication In English II)------ GNS323")
            GNS323 = Console.ReadLine()
            If (GNS323 < 0) Or (GNS323 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Mathematics (Advanced Calculus)------ MTH322")
            MTH322 = Console.ReadLine()
            If (MTH322 < 0) Or (MTH322 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("___________________________________________________________  ")
            Console.WriteLine("  ")



            If (CTE321 >= 75) And (CTE321 <= 100) Then
                Gradepoint11 = 2 * 4
            ElseIf (CTE321 >= 70) And (CTE321 <= 74) Then
                Gradepoint11 = 2 * 3.5
            ElseIf (CTE321 >= 65) And (CTE321 <= 69) Then
                Gradepoint11 = 2 * 3.25
            ElseIf (CTE321 >= 60) And (CTE321 <= 64) Then
                Gradepoint11 = 2 * 3.0
            ElseIf (CTE321 >= 55) And (CTE321 <= 59) Then
                Gradepoint11 = 2 * 2.75
            ElseIf (CTE321 >= 50) And (CTE321 <= 54) Then
                Gradepoint11 = 2 * 2.5
            ElseIf (CTE321 >= 45) And (CTE321 <= 49) Then
                Gradepoint11 = 2 * 2.25
            ElseIf (CTE321 >= 40) And (CTE321 <= 44) Then
                Gradepoint11 = 2 * 2.0
            ElseIf (CTE321 >= 0) And (CTE321 <= 39) Then
                Gradepoint11 = 2 * 0.0
            End If

            If (CTE322 >= 75) And (CTE322 <= 100) Then
                Gradepoint12 = 2 * 4
            ElseIf (CTE322 >= 70) And (CTE322 <= 74) Then
                Gradepoint12 = 2 * 3.5
            ElseIf (CTE322 >= 65) And (CTE322 <= 69) Then
                Gradepoint12 = 2 * 3.25
            ElseIf (CTE322 >= 60) And (CTE322 <= 64) Then
                Gradepoint12 = 2 * 3.0
            ElseIf (CTE322 >= 55) And (CTE322 <= 59) Then
                Gradepoint12 = 2 * 2.75
            ElseIf (CTE322 >= 50) And (CTE322 <= 54) Then
                Gradepoint12 = 2 * 2.5
            ElseIf (CTE322 >= 45) And (CTE322 <= 49) Then
                Gradepoint12 = 2 * 2.25
            ElseIf (CTE322 >= 40) And (CTE322 <= 44) Then
                Gradepoint12 = 2 * 2.0
            ElseIf (CTE322 >= 0) And (CTE322 <= 39) Then
                Gradepoint12 = 2 * 0.0
            End If

            If (CTE323 >= 75) And (CTE323 <= 100) Then
                Gradepoint13 = 2 * 4
            ElseIf (CTE323 >= 70) And (CTE323 <= 74) Then
                Gradepoint13 = 2 * 3.5
            ElseIf (CTE323 >= 65) And (CTE323 <= 69) Then
                Gradepoint13 = 2 * 3.25
            ElseIf (CTE323 >= 60) And (CTE323 <= 64) Then
                Gradepoint13 = 2 * 3.0
            ElseIf (CTE323 >= 55) And (CTE323 <= 59) Then
                Gradepoint13 = 2 * 2.75
            ElseIf (CTE323 >= 50) And (CTE323 <= 54) Then
                Gradepoint13 = 2 * 2.5
            ElseIf (CTE323 >= 45) And (CTE323 <= 49) Then
                Gradepoint13 = 2 * 2.25
            ElseIf (CTE323 >= 40) And (CTE323 <= 44) Then
                Gradepoint13 = 2 * 2.0
            ElseIf (CTE323 >= 0) And (CTE323 <= 39) Then
                Gradepoint13 = 2 * 0.0
            End If

            If (EEC323 >= 75) And (EEC323 <= 100) Then
                Gradepoint14 = 3 * 4
            ElseIf (EEC323 >= 70) And (EEC323 <= 74) Then
                Gradepoint14 = 3 * 3.5
            ElseIf (EEC323 >= 65) And (EEC323 <= 69) Then
                Gradepoint14 = 3 * 3.25
            ElseIf (EEC323 >= 60) And (EEC323 <= 64) Then
                Gradepoint14 = 3 * 3.0
            ElseIf (EEC323 >= 55) And (EEC323 <= 59) Then
                Gradepoint14 = 3 * 2.75
            ElseIf (EEC323 >= 50) And (EEC323 <= 54) Then
                Gradepoint14 = 3 * 2.5
            ElseIf (EEC323 >= 45) And (EEC323 <= 49) Then
                Gradepoint14 = 3 * 2.25
            ElseIf (EEC323 >= 40) And (EEC323 <= 44) Then
                Gradepoint14 = 3 * 2.0
            ElseIf (EEC323 >= 0) And (EEC323 <= 39) Then
                Gradepoint14 = 3 * 0.0
            End If

            If (EEC324 >= 75) And (EEC324 <= 100) Then
                Gradepoint15 = 3 * 4
            ElseIf (EEC324 >= 70) And (EEC324 <= 74) Then
                Gradepoint15 = 3 * 3.5
            ElseIf (EEC324 >= 65) And (EEC324 <= 69) Then
                Gradepoint15 = 3 * 3.25
            ElseIf (EEC324 >= 60) And (EEC324 <= 64) Then
                Gradepoint15 = 3 * 3.0
            ElseIf (EEC324 >= 55) And (EEC324 <= 59) Then
                Gradepoint15 = 3 * 2.75
            ElseIf (EEC324 >= 50) And (EEC324 <= 54) Then
                Gradepoint15 = 3 * 2.5
            ElseIf (EEC324 >= 45) And (EEC324 <= 49) Then
                Gradepoint15 = 3 * 2.25
            ElseIf (EEC324 >= 40) And (EEC324 <= 44) Then
                Gradepoint15 = 3 * 2.0
            ElseIf (EEC324 >= 0) And (EEC324 <= 39) Then
                Gradepoint15 = 3 * 0.0
            End If

            If (EEC328 >= 75) And (EEC328 <= 100) Then
                Gradepoint16 = 2 * 4
            ElseIf (EEC328 >= 70) And (EEC328 <= 74) Then
                Gradepoint6 = 2 * 3.5
            ElseIf (EEC328 >= 65) And (EEC328 <= 69) Then
                Gradepoint16 = 2 * 3.25
            ElseIf (EEC328 >= 60) And (EEC328 <= 64) Then
                Gradepoint16 = 2 * 3.0
            ElseIf (EEC328 >= 55) And (EEC328 <= 59) Then
                Gradepoint16 = 2 * 2.75
            ElseIf (EEC328 >= 50) And (EEC328 <= 54) Then
                Gradepoint16 = 2 * 2.5
            ElseIf (EEC328 >= 45) And (EEC328 <= 49) Then
                Gradepoint16 = 2 * 2.25
            ElseIf (EEC328 >= 40) And (EEC328 <= 44) Then
                Gradepoint16 = 2 * 2.0
            ElseIf (EEC328 >= 0) And (EEC328 <= 39) Then
                Gradepoint16 = 2 * 0.0
            End If

            If (EEC325 >= 75) And (EEC325 <= 100) Then
                Gradepoint17 = 2 * 4
            ElseIf (EEC325 >= 70) And (EEC325 <= 74) Then
                Gradepoint17 = 2 * 3.5
            ElseIf (EEC325 >= 65) And (EEC325 <= 69) Then
                Gradepoint17 = 2 * 3.25
            ElseIf (EEC325 >= 60) And (EEC325 <= 64) Then
                Gradepoint17 = 2 * 3.0
            ElseIf (EEC325 >= 55) And (EEC325 <= 59) Then
                Gradepoint17 = 2 * 2.75
            ElseIf (EEC325 >= 50) And (EEC325 <= 54) Then
                Gradepoint17 = 2 * 2.5
            ElseIf (EEC325 >= 45) And (EEC325 <= 49) Then
                Gradepoint17 = 2 * 2.25
            ElseIf (EEC325 >= 40) And (EEC325 <= 44) Then
                Gradepoint17 = 2 * 2.0
            ElseIf (EEC325 >= 0) And (EEC325 <= 39) Then
                Gradepoint17 = 2 * 0.0
            End If

            If (GNS322 >= 75) And (GNS322 <= 100) Then
                Gradepoint18 = 2 * 4
            ElseIf (GNS322 >= 70) And (GNS322 <= 74) Then
                Gradepoint18 = 2 * 3.5
            ElseIf (GNS322 >= 65) And (GNS322 <= 69) Then
                Gradepoint18 = 2 * 3.25
            ElseIf (GNS322 >= 60) And (GNS322 <= 64) Then
                Gradepoint18 = 2 * 3.0
            ElseIf (GNS322 >= 55) And (GNS322 <= 59) Then
                Gradepoint18 = 2 * 2.75
            ElseIf (GNS322 >= 50) And (GNS322 <= 54) Then
                Gradepoint18 = 2 * 2.5
            ElseIf (GNS322 >= 45) And (GNS322 <= 49) Then
                Gradepoint18 = 2 * 2.25
            ElseIf (GNS322 >= 40) And (GNS322 <= 44) Then
                Gradepoint18 = 2 * 2.0
            ElseIf (GNS322 >= 0) And (GNS322 <= 39) Then
                Gradepoint18 = 2 * 0.0
            End If

            If (GNS323 >= 75) And (GNS323 <= 100) Then
                Gradepoint19 = 2 * 4
            ElseIf (GNS323 >= 70) And (GNS323 <= 74) Then
                Gradepoint19 = 2 * 3.5
            ElseIf (GNS323 >= 65) And (GNS323 <= 69) Then
                Gradepoint19 = 2 * 3.25
            ElseIf (GNS323 >= 60) And (GNS323 <= 64) Then
                Gradepoint19 = 2 * 3.0
            ElseIf (GNS323 >= 55) And (GNS323 <= 59) Then
                Gradepoint19 = 2 * 2.75
            ElseIf (GNS323 >= 50) And (GNS323 <= 54) Then
                Gradepoint19 = 2 * 2.5
            ElseIf (GNS323 >= 45) And (GNS323 <= 49) Then
                Gradepoint19 = 2 * 2.25
            ElseIf (GNS323 >= 40) And (GNS323 <= 44) Then
                Gradepoint19 = 2 * 2.0
            ElseIf (GNS323 >= 0) And (GNS323 <= 39) Then
                Gradepoint19 = 2 * 0.0
            End If

            If (MTH322 >= 75) And (MTH322 <= 100) Then
                Gradepoint20 = 2 * 4
            ElseIf (MTH322 >= 70) And (MTH322 <= 74) Then
                Gradepoint20 = 2 * 3.5
            ElseIf (MTH322 >= 65) And (MTH322 <= 69) Then
                Gradepoint20 = 2 * 3.25
            ElseIf (MTH322 >= 60) And (MTH322 <= 64) Then
                Gradepoint20 = 2 * 3.0
            ElseIf (MTH322 >= 55) And (MTH322 <= 59) Then
                Gradepoint20 = 2 * 2.75
            ElseIf (MTH322 >= 50) And (MTH322 <= 54) Then
                Gradepoint20 = 2 * 2.5
            ElseIf (MTH322 >= 45) And (MTH322 <= 49) Then
                Gradepoint20 = 2 * 2.25
            ElseIf (MTH322 >= 40) And (MTH322 <= 44) Then
                Gradepoint20 = 2 * 2.0
            ElseIf (MTH322 >= 0) And (MTH322 <= 39) Then
                Gradepoint20 = 2 * 0.0
            End If

            TGP2 = Gradepoint11 + Gradepoint12 + Gradepoint13 + Gradepoint14 + Gradepoint15 + Gradepoint16 + Gradepoint17 + Gradepoint18 + Gradepoint19 + Gradepoint20
            TCU2 = 22
            GPA2 = TGP2 / TCU2
            Console.WriteLine(" GPA FOR SECOND SEMESTER = " + GPA2.ToString)

            If (GPA2 >= 3.5) And (GPA2 <= 4.0) Then
                Console.WriteLine("DICTINCTION ")
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

        Console.ReadLine()


        'SOLUTION FOR FIRST SEMESTER HND 2 FULL TIME'



        Dim CTE3410, CTE411, CTE412, CTE413, CTE414, EEC415, EEC416, GNS417, MTH418, CTE419 As Integer
        Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF, GradepointG, GradepointH, Gradepoint19I, Gradepoint2J As Integer
        Dim GPA3, TGP3, TCU3 As Double


        If choose = 3 Then


            Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- FIRST SEMESTER HND 2")
            Console.WriteLine("________________________________________________________")
            Console.WriteLine("  ")


            Console.WriteLine("Enter score for (Computer Hardware System Design) ---- CTE3410")
            CTE3410 = Console.ReadLine()
            If (CTE3410 < 0) Or (CTE3410 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Wireless and Wireless Communication) ---- CTE411")
            CTE411 = Console.ReadLine()
            If (CTE411 < 0) Or (CTE411 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Python Programming)--------- CTE412")
            CTE412 = Console.ReadLine()
            If (CTE412 < 0) Or (CTE412 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter  score for (Electrical Circuit Theory IV)------- CTE413")
            CTE413 = Console.ReadLine()
            If (CTE413 < 0) Or (CTE413 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Control Engineering I)--------- CTE414")
            CTE414 = Console.ReadLine()
            If (CTE414 < 0) Or (CTE414 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Testing Methods and Reliability)------ EEC415")
            EEC415 = Console.ReadLine()
            If (EEC415 < 0) Or (EEC415 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Electronics IV)------ EEC416")
            EEC416 = Console.ReadLine()
            If (EEC416 < 0) Or (EEC416 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Industrial Management)------ GNS417")
            GNS417 = Console.ReadLine()
            If (GNS417 < 0) Or (GNS417 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Communication In English II)------ MTH418")
            MTH418 = Console.ReadLine()
            If (MTH418 < 0) Or (MTH418 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Mathematics (Advanced Calculus)------ CTE419")
            CTE419 = Console.ReadLine()
            If (CTE419 < 0) Or (CTE419 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("___________________________________________________________  ")
            Console.WriteLine("  ")



            If (CTE3410 >= 75) And (CTE3410 <= 100) Then
                GradepointA = 2 * 4
            ElseIf (CTE3410 >= 70) And (CTE3410 <= 74) Then
                GradepointA = 2 * 3.5
            ElseIf (CTE3410 >= 65) And (CTE3410 <= 69) Then
                GradepointA = 2 * 3.25
            ElseIf (CTE3410 >= 60) And (CTE3410 <= 64) Then
                GradepointA = 2 * 3.0
            ElseIf (CTE3410 >= 55) And (CTE3410 <= 59) Then
                GradepointA = 2 * 2.75
            ElseIf (CTE3410 >= 50) And (CTE3410 <= 54) Then
                GradepointA = 2 * 2.5
            ElseIf (CTE3410 >= 45) And (CTE3410 <= 49) Then
                GradepointA = 2 * 2.25
            ElseIf (CTE3410 >= 40) And (CTE3410 <= 44) Then
                GradepointA = 2 * 2.0
            ElseIf (CTE3410 >= 0) And (CTE3410 <= 39) Then
                GradepointA = 2 * 0.0
            End If

            If (CTE411 >= 75) And (CTE411 <= 100) Then
                GradepointB = 2 * 4
            ElseIf (CTE411 >= 70) And (CTE411 <= 74) Then
                GradepointB = 2 * 3.5
            ElseIf (CTE411 >= 65) And (CTE411 <= 69) Then
                GradepointB = 2 * 3.25
            ElseIf (CTE411 >= 60) And (CTE411 <= 64) Then
                GradepointB = 2 * 3.0
            ElseIf (CTE411 >= 55) And (CTE411 <= 59) Then
                GradepointB = 2 * 2.75
            ElseIf (CTE411 >= 50) And (CTE411 <= 54) Then
                GradepointB = 2 * 2.5
            ElseIf (CTE411 >= 45) And (CTE411 <= 49) Then
                GradepointB = 2 * 2.25
            ElseIf (CTE411 >= 40) And (CTE411 <= 44) Then
                GradepointB = 2 * 2.0
            ElseIf (CTE411 >= 0) And (CTE411 <= 39) Then
                GradepointB = 2 * 0.0
            End If

            If (CTE412 >= 75) And (CTE412 <= 100) Then
                GradepointC = 2 * 4
            ElseIf (CTE412 >= 70) And (CTE412 <= 74) Then
                GradepointC = 2 * 3.5
            ElseIf (CTE412 >= 65) And (CTE412 <= 69) Then
                GradepointC = 2 * 3.25
            ElseIf (CTE412 >= 60) And (CTE412 <= 64) Then
                GradepointC = 2 * 3.0
            ElseIf (CTE412 >= 55) And (CTE412 <= 59) Then
                GradepointC = 2 * 2.75
            ElseIf (CTE412 >= 50) And (CTE412 <= 54) Then
                GradepointC = 2 * 2.5
            ElseIf (CTE412 >= 45) And (CTE412 <= 49) Then
                GradepointC = 2 * 2.25
            ElseIf (CTE412 >= 40) And (CTE412 <= 44) Then
                GradepointC = 2 * 2.0
            ElseIf (CTE412 >= 0) And (CTE412 <= 39) Then
                GradepointC = 2 * 0.0
            End If

            If (CTE413 >= 75) And (CTE413 <= 100) Then
                GradepointD = 2 * 4
            ElseIf (CTE413 >= 70) And (CTE413 <= 74) Then
                GradepointD = 2 * 3.5
            ElseIf (CTE413 >= 65) And (CTE413 <= 69) Then
                GradepointD = 2 * 3.25
            ElseIf (CTE413 >= 60) And (CTE413 <= 64) Then
                GradepointD = 2 * 3.0
            ElseIf (CTE413 >= 55) And (CTE413 <= 59) Then
                GradepointD = 2 * 2.75
            ElseIf (CTE413 >= 50) And (CTE413 <= 54) Then
                GradepointD = 2 * 2.5
            ElseIf (CTE413 >= 45) And (CTE413 <= 49) Then
                GradepointD = 2 * 2.25
            ElseIf (CTE413 >= 40) And (CTE413 <= 44) Then
                GradepointD = 2 * 2.0
            ElseIf (CTE413 >= 0) And (CTE413 <= 39) Then
                GradepointD = 2 * 0.0
            End If

            If (CTE414 >= 75) And (CTE414 <= 100) Then
                GradepointE = 2 * 4
            ElseIf (CTE414 >= 70) And (CTE414 <= 74) Then
                GradepointE = 2 * 3.5
            ElseIf (CTE414 >= 65) And (CTE414 <= 69) Then
                GradepointE = 2 * 3.25
            ElseIf (CTE414 >= 60) And (CTE414 <= 64) Then
                GradepointE = 2 * 3.0
            ElseIf (CTE414 >= 55) And (CTE414 <= 59) Then
                GradepointE = 2 * 2.75
            ElseIf (CTE414 >= 50) And (CTE414 <= 54) Then
                GradepointE = 2 * 2.5
            ElseIf (CTE414 >= 45) And (CTE414 <= 49) Then
                GradepointE = 2 * 2.25
            ElseIf (CTE414 >= 40) And (CTE414 <= 44) Then
                GradepointE = 2 * 2.0
            ElseIf (CTE414 >= 0) And (CTE414 <= 39) Then
                GradepointE = 2 * 0.0
            End If

            If (EEC415 >= 75) And (EEC415 <= 100) Then
                GradepointF = 2 * 4
            ElseIf (EEC415 >= 70) And (EEC415 <= 74) Then
                GradepointF = 2 * 3.5
            ElseIf (EEC415 >= 65) And (EEC415 <= 69) Then
                GradepointF = 2 * 3.25
            ElseIf (EEC415 >= 60) And (EEC415 <= 64) Then
                GradepointF = 2 * 3.0
            ElseIf (EEC415 >= 55) And (EEC415 <= 59) Then
                GradepointF = 2 * 2.75
            ElseIf (EEC415 >= 50) And (EEC415 <= 54) Then
                GradepointF = 2 * 2.5
            ElseIf (EEC415 >= 45) And (EEC415 <= 49) Then
                GradepointF = 2 * 2.25
            ElseIf (EEC415 >= 40) And (EEC415 <= 44) Then
                GradepointF = 2 * 2.0
            ElseIf (EEC415 >= 0) And (EEC415 <= 39) Then
                GradepointF = 2 * 0.0
            End If

            If (EEC416 >= 75) And (EEC416 <= 100) Then
                GradepointG = 2 * 4
            ElseIf (EEC416 >= 70) And (EEC416 <= 74) Then
                GradepointG = 2 * 3.5
            ElseIf (EEC416 >= 65) And (EEC416 <= 69) Then
                GradepointG = 2 * 3.25
            ElseIf (EEC416 >= 60) And (EEC416 <= 64) Then
                GradepointG = 2 * 3.0
            ElseIf (EEC416 >= 55) And (EEC416 <= 59) Then
                GradepointG = 2 * 2.75
            ElseIf (EEC416 >= 50) And (EEC416 <= 54) Then
                GradepointG = 2 * 2.5
            ElseIf (EEC416 >= 45) And (EEC416 <= 49) Then
                GradepointG = 2 * 2.25
            ElseIf (EEC416 >= 40) And (EEC416 <= 44) Then
                GradepointG = 2 * 2.0
            ElseIf (EEC416 >= 0) And (EEC416 <= 39) Then
                GradepointG = 2 * 0.0
            End If

            If (GNS417 >= 75) And (GNS417 <= 100) Then
                GradepointH = 2 * 4
            ElseIf (GNS417 >= 70) And (GNS417 <= 74) Then
                GradepointH = 2 * 3.5
            ElseIf (GNS417 >= 65) And (GNS417 <= 69) Then
                GradepointH = 2 * 3.25
            ElseIf (GNS417 >= 60) And (GNS417 <= 64) Then
                GradepointH = 2 * 3.0
            ElseIf (GNS417 >= 55) And (GNS417 <= 59) Then
                GradepointH = 2 * 2.75
            ElseIf (GNS417 >= 50) And (GNS417 <= 54) Then
                GradepointH = 2 * 2.5
            ElseIf (GNS417 >= 45) And (GNS417 <= 49) Then
                GradepointH = 2 * 2.25
            ElseIf (GNS417 >= 40) And (GNS417 <= 44) Then
                GradepointH = 2 * 2.0
            ElseIf (GNS417 >= 0) And (GNS417 <= 39) Then
                GradepointH = 2 * 0.0
            End If

            If (MTH418 >= 75) And (MTH418 <= 100) Then
                Gradepoint19I = 2 * 4
            ElseIf (MTH418 >= 70) And (MTH418 <= 74) Then
                Gradepoint19I = 2 * 3.5
            ElseIf (MTH418 >= 65) And (MTH418 <= 69) Then
                Gradepoint19I = 2 * 3.25
            ElseIf (MTH418 >= 60) And (MTH418 <= 64) Then
                Gradepoint19I = 2 * 3.0
            ElseIf (MTH418 >= 55) And (MTH418 <= 59) Then
                Gradepoint19I = 2 * 2.75
            ElseIf (MTH418 >= 50) And (GNS323 <= 54) Then
                Gradepoint19I = 2 * 2.5
            ElseIf (MTH418 >= 45) And (MTH418 <= 49) Then
                Gradepoint19I = 2 * 2.25
            ElseIf (MTH418 >= 40) And (MTH418 <= 44) Then
                Gradepoint19I = 2 * 2.0
            ElseIf (MTH418 >= 0) And (MTH418 <= 39) Then
                Gradepoint19I = 2 * 0.0
            End If

            If (CTE419 >= 75) And (CTE419 <= 100) Then
                Gradepoint2J = 1 * 4
            ElseIf (CTE419 >= 70) And (CTE419 <= 74) Then
                Gradepoint2J = 1 * 3.5
            ElseIf (CTE419 >= 65) And (CTE419 <= 69) Then
                Gradepoint2J = 1 * 3.25
            ElseIf (CTE419 >= 60) And (CTE419 <= 64) Then
                Gradepoint2J = 1 * 3.0
            ElseIf (CTE419 >= 55) And (CTE419 <= 59) Then
                Gradepoint2J = 1 * 2.75
            ElseIf (CTE419 >= 50) And (CTE419 <= 54) Then
                Gradepoint2J = 1 * 2.5
            ElseIf (CTE419 >= 45) And (CTE419 <= 49) Then
                Gradepoint2J = 1 * 2.25
            ElseIf (CTE419 >= 40) And (CTE419 <= 44) Then
                Gradepoint2J = 1 * 2.0
            ElseIf (CTE419 >= 0) And (CTE419 <= 39) Then
                Gradepoint2J = 1 * 0.0
            End If

            TGP3 = GradepointA + GradepointB + GradepointC + GradepointD + GradepointE + GradepointF + GradepointG + GradepointH + Gradepoint19I + Gradepoint2J
            TCU3 = 19
            GPA3 = TGP3 / TCU3
            Console.WriteLine(" GPA FOR SECOND SEMESTER = " + GPA3.ToString)

            If (GPA3 >= 3.5) And (GPA3 <= 4.0) Then
                Console.WriteLine("DICTINCTION ")
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

        Console.ReadLine()


        'SOLUTION FOR SECOND SEMESTER HND 2 FULL TIME'



        Dim CTE421, CTE422, CTE423, CTE424, CTE428, CTE429, ICT425, MTH423 As Integer
        Dim Gradepoint01, Gradepoint02, Gradepoint03, Gradepoint04, Gradepoint05, Gradepoint06, Gradepoint07, Gradepoint08 As Integer
        Dim GPA4, TGP4, TCU4 As Double


        If choose = 4 Then
            Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- FIRST SEMESTER HND 2")
            Console.WriteLine("________________________________________________________")
            Console.WriteLine("  ")


            Console.WriteLine("Enter score for (Microprocessor In Control and Instrumentation) ---- CTE421")
            CTE421 = Console.ReadLine()
            If (CTE421 < 0) Or (CTE421 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Artificial Inteligence) ---- CTE422")
            CTE422 = Console.ReadLine()
            If (CTE422 < 0) Or (CTE422 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Seminar)--------- CTE423")
            CTE423 = Console.ReadLine()
            If (CTE423 < 0) Or (CTE423 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter  score for (Project Management)-------  CTE424")
            CTE424 = Console.ReadLine()
            If (CTE424 < 0) Or (CTE424 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Digital Signal Process)--------- CTE428")
            CTE428 = Console.ReadLine()
            If (CTE428 < 0) Or (CTE428 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Project II)------ CTE429")
            CTE429 = Console.ReadLine()
            If (CTE429 < 0) Or (CTE429 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Microcontroller Programming Pratical)------ ICT425")
            ICT425 = Console.ReadLine()
            If (ICT425 < 0) Or (ICT425 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("Enter score for (Mathematics iv(Statidtics method))------ MTH423")
            MTH423 = Console.ReadLine()
            If (MTH423 < 0) Or (MTH423 > 100) Then
                Console.WriteLine("Invalid Input ")
                Console.ReadLine()
                End
            End If

           
            
            Console.WriteLine("___________________________________________________________  ")
            Console.WriteLine("  ")



            If (CTE421 >= 75) And (CTE421 <= 100) Then
                Gradepoint01 = 3 * 4
            ElseIf (CTE421 >= 70) And (CTE421 <= 74) Then
                Gradepoint01 = 3 * 3.5
            ElseIf (CTE421 >= 65) And (CTE421 <= 69) Then
                Gradepoint01 = 3 * 3.25
            ElseIf (CTE421 >= 60) And (CTE421 <= 64) Then
                Gradepoint01 = 3 * 3.0
            ElseIf (CTE421 >= 55) And (CTE421 <= 59) Then
                Gradepoint01 = 3 * 2.75
            ElseIf (CTE421 >= 50) And (CTE421 <= 54) Then
                Gradepoint01 = 3 * 2.5
            ElseIf (CTE421 >= 45) And (CTE421 <= 49) Then
                Gradepoint01 = 3 * 2.25
            ElseIf (CTE421 >= 40) And (CTE421 <= 44) Then
                Gradepoint01 = 3 * 2.0
            ElseIf (CTE421 >= 0) And (CTE421 <= 39) Then
                Gradepoint01 = 3 * 0.0
            End If

            If (CTE422 >= 75) And (CTE422 <= 100) Then
                Gradepoint02 = 3 * 4
            ElseIf (CTE422 >= 70) And (CTE422 <= 74) Then
                Gradepoint02 = 3 * 3.5
            ElseIf (CTE422 >= 65) And (CTE422 <= 69) Then
                Gradepoint02 = 3 * 3.25
            ElseIf (CTE422 >= 60) And (CTE422 <= 64) Then
                Gradepoint02 = 3 * 3.0
            ElseIf (CTE422 >= 55) And (CTE422 <= 59) Then
                Gradepoint02 = 3 * 2.75
            ElseIf (CTE422 >= 50) And (CTE422 <= 54) Then
                Gradepoint02 = 3 * 2.5
            ElseIf (CTE422 >= 45) And (CTE422 <= 49) Then
                Gradepoint02 = 3 * 2.25
            ElseIf (CTE422 >= 40) And (CTE422 <= 44) Then
                Gradepoint02 = 3 * 2.0
            ElseIf (CTE422 >= 0) And (CTE422 <= 39) Then
                Gradepoint02 = 3 * 0.0
            End If

            If (CTE423 >= 75) And (CTE423 <= 100) Then
                Gradepoint03 = 2 * 4
            ElseIf (CTE423 >= 70) And (CTE423 <= 74) Then
                Gradepoint03 = 2 * 3.5
            ElseIf (CTE423 >= 65) And (CTE423 <= 69) Then
                Gradepoint03 = 2 * 3.25
            ElseIf (CTE423 >= 60) And (CTE423 <= 64) Then
                Gradepoint03 = 2 * 3.0
            ElseIf (CTE423 >= 55) And (CTE423 <= 59) Then
                Gradepoint03 = 2 * 2.75
            ElseIf (CTE423 >= 50) And (CTE423 <= 54) Then
                Gradepoint03 = 2 * 2.5
            ElseIf (CTE423 >= 45) And (CTE423 <= 49) Then
                Gradepoint03 = 2 * 2.25
            ElseIf (CTE423 >= 40) And (CTE423 <= 44) Then
                Gradepoint03 = 2 * 2.0
            ElseIf (CTE423 >= 0) And (CTE423 <= 39) Then
                Gradepoint03 = 2 * 0.0
            End If

            If (CTE424 >= 75) And (CTE424 <= 100) Then
                Gradepoint04 = 2 * 4
            ElseIf (CTE424 >= 70) And (CTE424 <= 74) Then
                Gradepoint04 = 2 * 3.5
            ElseIf (CTE424 >= 65) And (CTE424 <= 69) Then
                Gradepoint04 = 2 * 3.25
            ElseIf (CTE424 >= 60) And (CTE424 <= 64) Then
                Gradepoint04 = 2 * 3.0
            ElseIf (CTE424 >= 55) And (CTE424 <= 59) Then
                Gradepoint04 = 2 * 2.75
            ElseIf (CTE424 >= 50) And (CTE424 <= 54) Then
                Gradepoint04 = 2 * 2.5
            ElseIf (CTE424 >= 45) And (CTE424 <= 49) Then
                Gradepoint04 = 2 * 2.25
            ElseIf (CTE424 >= 40) And (CTE424 <= 44) Then
                Gradepoint04 = 2 * 2.0
            ElseIf (CTE424 >= 0) And (CTE424 <= 39) Then
                Gradepoint04 = 2 * 0.0
            End If

            If (CTE428 >= 75) And (CTE428 <= 100) Then
                Gradepoint05 = 3 * 4
            ElseIf (CTE428 >= 70) And (CTE428 <= 74) Then
                Gradepoint05 = 3 * 3.5
            ElseIf (CTE428 >= 65) And (CTE428 <= 69) Then
                Gradepoint05 = 3 * 3.25
            ElseIf (CTE428 >= 60) And (CTE428 <= 64) Then
                Gradepoint05 = 3 * 3.0
            ElseIf (CTE428 >= 55) And (CTE428 <= 59) Then
                Gradepoint05 = 3 * 2.75
            ElseIf (CTE428 >= 50) And (CTE428 <= 54) Then
                Gradepoint05 = 3 * 2.5
            ElseIf (CTE428 >= 45) And (CTE428 <= 49) Then
                Gradepoint05 = 3 * 2.25
            ElseIf (CTE428 >= 40) And (CTE428 <= 44) Then
                Gradepoint05 = 3 * 2.0
            ElseIf (CTE428 >= 0) And (CTE428 <= 39) Then
                Gradepoint05 = 3 * 0.0
            End If

            If (CTE429 >= 75) And (CTE429 <= 100) Then
                Gradepoint06 = 6 * 4
            ElseIf (CTE429 >= 70) And (CTE429 <= 74) Then
                Gradepoint06 = 6 * 3.5
            ElseIf (CTE429 >= 65) And (CTE429 <= 69) Then
                Gradepoint06 = 6 * 3.25
            ElseIf (CTE429 >= 60) And (CTE429 <= 64) Then
                Gradepoint06 = 6 * 3.0
            ElseIf (CTE429 >= 55) And (CTE429 <= 59) Then
                Gradepoint06 = 6 * 2.75
            ElseIf (CTE429 >= 50) And (CTE429 <= 54) Then
                Gradepoint06 = 6 * 2.5
            ElseIf (CTE429 >= 45) And (CTE429 <= 49) Then
                Gradepoint06 = 6 * 2.25
            ElseIf (CTE429 >= 40) And (CTE429 <= 44) Then
                Gradepoint06 = 6 * 2.0
            ElseIf (CTE429 >= 0) And (CTE429 <= 39) Then
                Gradepoint06 = 6 * 0.0
            End If

            If (ICT425 >= 75) And (ICT425 <= 100) Then
                Gradepoint07 = 1 * 4
            ElseIf (ICT425 >= 70) And (ICT425 <= 74) Then
                Gradepoint07 = 1 * 3.5
            ElseIf (ICT425 >= 65) And (ICT425 <= 69) Then
                Gradepoint07 = 1 * 3.25
            ElseIf (ICT425 >= 60) And (ICT425 <= 64) Then
                Gradepoint07 = 1 * 3.0
            ElseIf (ICT425 >= 55) And (ICT425 <= 59) Then
                Gradepoint07 = 1 * 2.75
            ElseIf (ICT425 >= 50) And (ICT425 <= 54) Then
                Gradepoint07 = 1 * 2.5
            ElseIf (ICT425 >= 45) And (ICT425 <= 49) Then
                Gradepoint07 = 1 * 2.25
            ElseIf (ICT425 >= 40) And (ICT425 <= 44) Then
                Gradepoint07 = 1 * 2.0
            ElseIf (ICT425 >= 0) And (EEC416 <= 39) Then
                Gradepoint07 = 1 * 0.0
            End If

            If (MTH423 >= 75) And (MTH423 <= 100) Then
                Gradepoint08 = 2 * 4
            ElseIf (MTH423 >= 70) And (MTH423 <= 74) Then
                Gradepoint08 = 2 * 3.5
            ElseIf (MTH423 >= 65) And (MTH423 <= 69) Then
                Gradepoint08 = 2 * 3.25
            ElseIf (MTH423 >= 60) And (MTH423 <= 64) Then
                Gradepoint08 = 2 * 3.0
            ElseIf (MTH423 >= 55) And (MTH423 <= 59) Then
                Gradepoint08 = 2 * 2.75
            ElseIf (MTH423 >= 50) And (MTH423 <= 54) Then
                Gradepoint08 = 2 * 2.5
            ElseIf (MTH423 >= 45) And (MTH423 <= 49) Then
                Gradepoint08 = 2 * 2.25
            ElseIf (MTH423 >= 40) And (MTH423 <= 44) Then
                Gradepoint08 = 2 * 2.0
            ElseIf (MTH423 >= 0) And (MTH423 <= 39) Then
                Gradepoint08 = 2 * 0.0
            End If

            TGP4 = Gradepoint01 + Gradepoint02 + Gradepoint03 + Gradepoint04 + Gradepoint05 + Gradepoint06 + Gradepoint07 + Gradepoint08
            TCU4 = 22
            GPA4 = TGP4 / TCU4
            Console.WriteLine("GPA FOR SECOND SEMESTER = " + GPA4.ToString)

            If (GPA4 >= 3.5) And (GPA4 <= 4.0) Then
                Console.WriteLine("DICTINCTION ")
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

            Console.ReadLine()

    End Sub

End Module


    