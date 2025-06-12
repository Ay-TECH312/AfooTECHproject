Module Module1

    Sub Main()
        Dim sel, d As Integer
        Console.WriteLine("SOFTWARE FOR MULTIPURPOSE")
        Console.WriteLine("__________________________")
        Console.WriteLine("  ")
        Do
            Console.WriteLine("Press 1 For Sum of two numbers ")
            Console.WriteLine("Press 2 For Product of two numbers")
            Console.WriteLine("Press 3 For Division of two numbers")
            Console.WriteLine("Press 4 For Difference of two numbers")
            Console.WriteLine("Press 5 For Quadratic formular")
            Console.WriteLine("Press 6 For Area of circule")
            Console.WriteLine("Press 7 For Circumference of a circle")
            Console.WriteLine("Press 8 For Staff salary of 5%")
            Console.WriteLine("Press 9 For Staff salary of any rate")
            Console.WriteLine("Press 10 For Comparison of two greather number")
            Console.WriteLine("Press 11 For Comparison of three greathest number")
            Console.WriteLine("Press 12 For Simple calculator ")
            Console.WriteLine("Press 13 For Simple calculator version 2")
            Console.WriteLine("Press 14 For AfooTECH G.P.A Calculator")
            Console.WriteLine("Press 15 For GAPOSA G.P.A Calculator for ND COMPUTER ENGINEERING")
            Console.WriteLine("Press 16 For GAPOSA G.P.A Calculator for HND COMPUTER ENGINEERING")
            Console.WriteLine("Press 17 For Chales law")
            Console.WriteLine("Press 18 For Boyles law")
            Console.WriteLine("Press 19 For Age calculator")
            Console.WriteLine("Press 20 For Loop for multiplication")
            Console.WriteLine("Press 21 For Loop for arithemetic")
            Console.WriteLine("Press 22 For Loop for factorial")
            Console.WriteLine("Press 23 For Loan application")
            sel = Val(Console.ReadLine())

            If sel = 1 Then
                    Do
                        Dim firstNumber, secondNumber, result As Integer
                        Console.WriteLine("THE SUM OF TWO NUMBERS")
                        Console.WriteLine("========================")
                        Console.WriteLine("  ")

                        Console.WriteLine("Enter the value of firstNumber")
                        firstNumber = Console.ReadLine()
                        Console.WriteLine("Enter the value of secondNumber")
                        secondNumber = Console.ReadLine()
                        Console.WriteLine("========================")
                        Console.WriteLine("  ")
                        result = firstNumber + secondNumber
                        Console.WriteLine("result =" + result.ToString)

                        ' Loop to get valid input for continuation or exit or exit home
                        Do
                            Console.WriteLine("Press 1 to exit home")
                            Console.WriteLine("Press 2 to exit this solution")
                            Console.WriteLine("Press 3 to continue...")
                            d = Val(Console.ReadLine())
                            If d <> 1 AndAlso d <> 3 Then
                                Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                                Console.WriteLine("________________________________________________")
                                Console.WriteLine("  ")
                            ElseIf d = 1 Then
                                Exit Sub
                            End If
                    Loop Until d = 3 Or d = 2
                    Loop Until d = 2

                ElseIf sel = 2 Then
                    Do
                        Dim firstNumber, secondNumber, result As Integer
                        Console.WriteLine("THE PRODUCT OF TWO NUMBERS")
                        Console.WriteLine("========================")
                        Console.WriteLine("  ")

                        Console.WriteLine("Enter the value of firstNumber")
                        firstNumber = Console.ReadLine()
                        Console.WriteLine("Enter the value of secondNumber")
                        secondNumber = Console.ReadLine()
                        Console.WriteLine("========================")
                        Console.WriteLine("  ")
                        result = firstNumber * secondNumber
                        Console.WriteLine("result =" + result.ToString)

                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 3 Then
                Do
                    Dim firstNumber, secondNumber, result As Integer
                    Console.WriteLine("THE DIVISION OF TWO NUMBERS")
                    Console.WriteLine("========================")
                    Console.WriteLine("  ")

                    Console.WriteLine("Enter the value of firstNumber")
                    firstNumber = Console.ReadLine()
                    Console.WriteLine("Enter the value of secondNumber")
                    secondNumber = Console.ReadLine()
                    Console.WriteLine("========================")
                    Console.WriteLine("  ")
                    result = firstNumber / secondNumber
                    Console.WriteLine("result =" + result.ToString)

                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 4 Then
                Do
                    Dim firstNumber, secondNumber, result As Integer
                    Console.WriteLine("THE DIFFERENCE OF TWO NUMBERS")
                    Console.WriteLine("========================")
                    Console.WriteLine("  ")

                    Console.WriteLine("Enter the value of firstNumber")
                    firstNumber = Console.ReadLine()
                    Console.WriteLine("Enter the value of secondNumber")
                    secondNumber = Console.ReadLine()
                    Console.WriteLine("========================")
                    Console.WriteLine("  ")
                    result = firstNumber - secondNumber
                    Console.WriteLine("result =" + result.ToString)
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 5 Then
                Do
                    Dim x1, x2, a, b, c, w, e, f, g, h, j, k, l, m, n, result As Decimal

                    Console.WriteLine("QUADRATIC FORMULAR")
                    Console.WriteLine("===================")
                    Console.WriteLine("  ")
                    Console.WriteLine("Enter the value for a")
                    a = Console.ReadLine()
                    Console.WriteLine("Enter the value for b")
                    b = Console.ReadLine()
                    Console.WriteLine("Enter the value for c")
                    c = Console.ReadLine()

                    w = b * b
                    e = 4 * a
                    f = e * c
                    g = w - f
                    h = Math.Sqrt(g)
                    j = -b + h
                    k = -b - h
                    l = 2 * a
                    m = j / l
                    n = k / l
                    x1 = m
                    x2 = n
                    result = x1
                    Console.WriteLine("x1  =" + result.ToString("N"))
                    result = x2
                    Console.WriteLine("x2  =" + result.ToString("N"))

                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 6 Then
                Do
                    Dim pi, r, b, c, Area As Decimal
                    Console.WriteLine("AREA OF A CIRCLE")
                    Console.WriteLine("_________________")
                    Console.WriteLine("  ")

                    Console.WriteLine("Enter the value for r  ")
                    r = Console.ReadLine()
                    pi = 22 / 7
                    b = r * r
                    c = pi * b
                    Area = c
                    Console.WriteLine("Area = " + Area.ToString("n"))

                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 7 Then
                Do
                    Dim a, b, r, pi, result As Decimal
                    Console.WriteLine("THE SOFTWARE TO CALCULATE CIRCUMFEREN OF A CIRCLE")
                    Console.WriteLine("_________________________________________________")
                    Console.WriteLine("  ")
                    Console.WriteLine("Enter the value for radiu  ")
                    r = Console.ReadLine()
                    pi = 22 / 7
                    a = 2 * pi
                    b = a * r
                    result = b
                    Console.WriteLine("CIRCUMFEREN  =  " + result.ToString("n"))
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 8 Then
                Do
                    Dim Grosssalary, Percentage, Totalamount, Deductiontax, result As Decimal
                    Console.WriteLine("THE SOFTWARE SOLUTION TO CALCULATE STAFF SALARY OF 5% TAXRATE")
                    Console.WriteLine(" _____________________________________________________________")
                    Console.WriteLine("   ")

                    'INPUT'
                    Console.WriteLine("Enter the value for gross salary")
                    Grosssalary = Console.ReadLine() 'access inputs for Grosssalary'
                    Console.WriteLine("   ")
                    Percentage = 5 / 100
                    Deductiontax = Grosssalary * Percentage
                    Totalamount = Grosssalary - Deductiontax
                    result = Deductiontax
                    Console.WriteLine("The Tax Deduction amount  = " + "#" + result.ToString("n2"))
                    result = Totalamount
                    Console.WriteLine("  ")
                    Console.WriteLine("The Balance salary  = " + "#" + result.ToString("n2"))

                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 9 Then
                Do
                    Dim Grosssalary, Percentage, Totalamount, Deductiontax, result As Decimal
                    Console.WriteLine("THE SOFTWARE SOLUTION TO CALCULATE STAFF SALARY OF ANY TAXRATE")
                    Console.WriteLine(" ______________________________________________________________")
                    Console.WriteLine(" ")

                    'INPUT'
                    Console.WriteLine("Enter the value for gross salary")
                    Grosssalary = Console.ReadLine() 'access inputs for  Grosssalary'
                    Console.WriteLine("Enter the value for percentage")
                    Percentage = Console.ReadLine() 'access inputs for Percentage'
                    Percentage = Percentage / 100
                    Deductiontax = Grosssalary * Percentage
                    Totalamount = Grosssalary - Deductiontax
                    result = Deductiontax

                    Console.WriteLine("The TaxDeduction amount   = " + ("#") + result.ToString("n2"))
                    result = Totalamount
                    Console.WriteLine("  ")
                    Console.WriteLine("The Balance salary = " + ("#") + result.ToString("n2"))
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

            ElseIf sel = 10 Then

                Do
                    Dim firstnumber, secondnumber As Integer
                    Console.WriteLine("THE SOFWARE TO CALCULATE COMPARISON OF TWO GREATER NUMBERS")
                    Console.WriteLine("___________________________________________________________")
                    Console.WriteLine(" ")

                    Console.WriteLine("Enter the value for firstnumber ")
                    firstnumber = Console.ReadLine()
                    Console.WriteLine("Enter the value for secondnumber ")
                    secondnumber = Console.ReadLine()

                    If firstnumber > secondnumber Then
                        Console.WriteLine("The greater number = " + firstnumber.ToString)
                    ElseIf secondnumber > firstnumber Then
                        Console.WriteLine("The greater number = " + secondnumber.ToString)
                    Else
                        Console.WriteLine("The both numbers are equal  ".ToString)
                    End If


                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 11 Then
                Do
                    Dim firstnumber, secondnumber, thirdnumber As Integer
                    Console.WriteLine("SOFTWARE TO CALCULATE COMPARISON OF THREE GREATEST NUMBERS")
                    Console.WriteLine("_______________________________________________________________")
                    Console.WriteLine("  ")

                    Console.WriteLine("Enter the value for firstnumber  ")
                    firstnumber = Console.ReadLine()
                    Console.WriteLine("Enter the value for secondnumber  ")
                    secondnumber = Console.ReadLine()
                    Console.WriteLine("Enter the value for thirdnumber  ")
                    thirdnumber = Console.ReadLine()

                    If (firstnumber > secondnumber) And (firstnumber > thirdnumber) Then
                        Console.WriteLine("The greatest number =   " + firstnumber.ToString)
                    ElseIf (secondnumber > firstnumber And secondnumber > thirdnumber) Then
                        Console.WriteLine("The greatest number =   " + secondnumber.ToString)
                    Else
                        Console.WriteLine("The greatest number =   " + thirdnumber.ToString)
                    End If
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 12 Then
                Do
                    Dim firstnumber, secondnumber, operators, result As Integer

                    Console.WriteLine("THE SOFTWARE FOR SIMPLE CALCULATOR")
                    Console.WriteLine("__________________________________")
                    Console.WriteLine("  ")

                    Console.WriteLine("Pres 1  for addition")
                    Console.WriteLine("Pres 2  for subtraction")
                    Console.WriteLine("Pres 3  for multiplication")
                    Console.WriteLine("Pres 4  for division")

                    Console.WriteLine("Enter value for operators")
                    operators = Console.ReadLine()
                    Console.WriteLine("__________________________________")
                    Console.WriteLine("  ")

                    If operators = 1 Then
                        Console.WriteLine("Enter the value for fisrtnumber")
                        firstnumber = Console.ReadLine()
                        Console.WriteLine("Enter the value for secondnumber")
                        secondnumber = Console.ReadLine()
                        result = firstnumber + secondnumber
                        Console.WriteLine("result = " + result.ToString)

                    ElseIf operators = 2 Then
                        Console.WriteLine("Enter the value for fisrtnumber")
                        firstnumber = Console.ReadLine()
                        Console.WriteLine("Enter the value for secondnumber")
                        secondnumber = Console.ReadLine()
                        result = firstnumber - secondnumber
                        Console.WriteLine("result = " + result.ToString)

                    ElseIf operators = 3 Then
                        Console.WriteLine("Enter the value for fisrtnumber")
                        firstnumber = Console.ReadLine()
                        Console.WriteLine("Enter the value for secondnumber")
                        secondnumber = Console.ReadLine()
                        result = firstnumber * secondnumber
                        Console.WriteLine("result = " + result.ToString)

                    Else
                        operators = 4
                        Console.WriteLine("Enter the value for fisrtnumber")
                        firstnumber = Console.ReadLine()
                        Console.WriteLine("Enter the value for secondnumber")
                        secondnumber = Console.ReadLine()
                        result = firstnumber / secondnumber
                        Console.WriteLine("result = " + result.ToString)
                    End If
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 13 Then
                Do
                    Dim firstnumber, secondnumber, result As Integer
                    Dim operators As String

                    Console.WriteLine("THE SOFTWARE FOR SIMPLE CALCULATOR")
                    Console.WriteLine("__________________________________")
                    Console.WriteLine("  ")

                    Console.WriteLine("Enter value for firstnumber")
                    firstnumber = Console.ReadLine()
                    Console.WriteLine("Enter value for operators")
                    operators = Console.ReadLine()
                    Console.WriteLine("Enter value for secondnumber")
                    secondnumber = Console.ReadLine()

                    Console.WriteLine("  ")
                    Console.WriteLine("__________________________________")

                    If operators = "+" Then
                        result = firstnumber + secondnumber
                        Console.WriteLine("result = " + result.ToString)
                    ElseIf operators = "-" Then
                        result = firstnumber - secondnumber
                        Console.WriteLine("result = " + result.ToString)
                    ElseIf operators = "*" Then
                        result = firstnumber * secondnumber
                        Console.WriteLine("result = " + result.ToString)
                    Else
                        operators = "/"
                        result = firstnumber / secondnumber
                        Console.WriteLine("result = " + result.ToString)
                    End If
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d <> 1 AndAlso d <> 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2

                ElseIf sel = 14 Then
                Do
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



                        'SOLUTION FOR SECOND SEMESTER STARTS HERE'
                    ElseIf choose = 2 Then

                        Dim DBMS201, UIUX202, AI203, SQT204, AA205, DevOps206 As Integer
                        Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF As Integer
                        Dim GPA2, TGP2, TCU2 As Double

                        Console.WriteLine("AfooTECH G.P.A CALCULATOR----- SECOND SEMESTER")
                        Console.WriteLine("___________________________________________________")
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
                    ' Loop to get valid input for continuation or exit or exit home
                    Do
                        Console.WriteLine("Press 1 to exit home")
                        Console.WriteLine("Press 2 to exit this solution")
                        Console.WriteLine("Press 3 to continue...")
                        d = Val(Console.ReadLine())
                        If d < 1 And d > 3 Then
                            Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                            Console.WriteLine("________________________________________________")
                            Console.WriteLine("  ")
                        ElseIf d = 1 Then
                            Exit Sub
                        End If
                    Loop Until d = 3 Or d = 2
                Loop Until d = 2
         

            ElseIf sel = 15 Then
            Do
                'SOLUTION FOR FIRST SEMESTER ND 1 FULL TIME'

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

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d < 1 And d > 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 16 Then
            Do
                'SOLUTION FOR FIRST SEMESTER HND 1 FULL TIME'

                Dim CTE313, CTE314, CTE315, CTE316, EEC313, EEC314, EEC315, EEC316, GNS311, MTH311, pick As Integer
                Dim Gradepoint1, Gradepoint2, Gradepoint3, Gradepoint4, Gradepoint5, Gradepoint6, Gradepoint7, Gradepoint8, Gradepoint9, Gradepoint10, choose As Integer
                Dim GPA, TGP, TCU As Double

                Console.WriteLine("GAPOSA G.P.A CALCULATOR FOR COMPUTER ENGINEERING FULL TIME")
                Console.WriteLine("__________________________________________________________ ")
                Console.WriteLine("   ")

                Console.WriteLine("Press 1 for  HND I")
                Console.WriteLine("press 2 for  HND II")
                choose = Console.ReadLine()
                If choose = 1 Then
                    If (choose < 1) Or (choose > 2) Then
                        Console.WriteLine("Inavalid Input, Pls enter the right digit")
                        Console.ReadLine()
                        End
                    End If

                    Console.WriteLine("press 1 for first semester HND I")
                    Console.WriteLine("press 2 for second semester HND I")
                    pick = Console.ReadLine()
                    If pick = 1 Then

                        If (pick < 1) Or (pick > 2) Then
                            Console.WriteLine("Inavalid Input, Pls enter the right digit")
                            Console.ReadLine()
                            End
                        End If

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

                    'SOLUTION FOR SECOND SEMESTER HND 1 FULL TIME'

                    Dim CTE321, CTE322, CTE323, EEC323, EEC324, EEC328, EEC325, GNS322, GNS323, MTH322 As Integer
                    Dim Gradepoint11, Gradepoint12, Gradepoint13, Gradepoint14, Gradepoint15, Gradepoint16, Gradepoint17, Gradepoint18, Gradepoint19, Gradepoint20 As Integer
                    Dim GPA2, TGP2, TCU2 As Double

                    If pick = 2 Then
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
                        Console.WriteLine("GPA FOR SECOND SEMESTER = " + GPA2.ToString)

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

                'SOLUTION FOR FIRST SEMESTER HND 2 FULL TIME'

                Dim CTE3410, CTE411, CTE412, CTE413, CTE414, EEC415, EEC416, GNS417, MTH418, CTE419 As Integer
                Dim GradepointA, GradepointB, GradepointC, GradepointD, GradepointE, GradepointF, GradepointG, GradepointH, Gradepoint19I, Gradepoint2J As Integer
                Dim GPA3, TGP3, TCU3 As Double

                If choose = 2 Then
                    If (choose < 1) Or (choose > 2) Then
                        Console.WriteLine("Inavalid Input, Pls enter the right digit")
                        Console.ReadLine()
                        End
                    End If

                    Console.WriteLine("press 1 for first semester HND II")
                    Console.WriteLine("press 2 for second semester HND II")
                    pick = Console.ReadLine()
                    If pick = 1 Then

                        If (pick < 1) Or (pick > 2) Then
                            Console.WriteLine("Inavalid Input, Pls enter the right digit")
                            Console.ReadLine()
                            End
                        End If

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
                        ElseIf (MTH418 >= 50) And (MTH418 <= 54) Then
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

                    'SOLUTION FOR SECOND SEMESTER HND 2 FULL TIME'

                    Dim CTE421, CTE422, CTE423, CTE424, CTE428, CTE429, ICT425, MTH423 As Integer
                    Dim Gradepoint01, Gradepoint02, Gradepoint03, Gradepoint04, Gradepoint05, Gradepoint06, Gradepoint07, Gradepoint08 As Integer
                    Dim GPA4, TGP4, TCU4 As Double

                    If pick = 2 Then
                        Console.WriteLine("SCORES FOR COMPUTER ENGINEERING---- SECOND SEMESTER HND 2")
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

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d < 1 And d > 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 17 Then
            Do
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

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 18 Then
            Do
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

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 19 Then
            Do
                Dim Birth_year, Current_year, Age_year, Birth_month, Current_month, Age_month, Birth_day, Current_day, Age_day As Integer
                Console.WriteLine("SOFTWARE TO CALCULATE AGES")
                Console.WriteLine("_____________________________")
                Console.WriteLine(" ")

                Current_day = DateTime.Now.Day
                Current_month = DateTime.Now.Month
                Current_year = DateTime.Now.Year
                Console.WriteLine("THE TODAY'S DATE IS " + DateTime.Now.Day.ToString + ("|") + DateTime.Now.Month.ToString + ("|") + DateTime.Now.Year.ToString + ("|"))
                Console.WriteLine("____________________________")
                Console.WriteLine(" ")

                'SOLUTION FOR DAYS
                Console.WriteLine("Enter the value for  Birth_day")
                Birth_day = Console.ReadLine()
                Console.WriteLine("____________________________")
                Console.WriteLine(" ")

                If (Birth_day > 31) Or (Birth_day < 1) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                End If

                'SOLUTION FOR MONTHS
                Console.WriteLine("Enter the value for  Birth_month")
                Birth_month = Console.ReadLine()
                Console.WriteLine("____________________________")
                Console.WriteLine(" ")

                If (Birth_month = 1) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 2) And (Birth_day > 29) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 3) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 4) And (Birth_day > 30) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 5) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 6) And (Birth_day > 30) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 7) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 8) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 9) And (Birth_day > 30) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 10) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 11) And (Birth_day > 30) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month = 12) And (Birth_day > 31) Then
                    Console.WriteLine("Invalid Days Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_month > 12) Or (Birth_month < 1) Then
                    Console.WriteLine("Invalid Month Input")
                    Console.ReadLine()
                    End
                End If
                'SOLUTION FOR YEARS
                Console.WriteLine("Enter the value for  Birth_year")
                Birth_year = Console.ReadLine()
                Console.WriteLine("____________________________")
                Console.WriteLine(" ")

                If (DateTime.IsLeapYear(Birth_year) And (Birth_month = 2) And (Birth_day > 29)) Then
                    Console.WriteLine("Invalid Years input ")
                    Console.ReadLine()
                    End
                ElseIf (Not DateTime.IsLeapYear(Birth_year) And (Birth_month = 2) And (Birth_day > 28)) Then
                    Console.WriteLine("Invalid Years Input")
                    Console.ReadLine()
                    End
                End If

                If (Birth_year > Current_year) Then
                    Console.WriteLine("Invalid Years Input")
                    Console.ReadLine()
                    End
                ElseIf (Birth_year < 0) Then
                    Console.WriteLine("Invalid Years Input")
                    Console.ReadLine()
                    End
                End If

                If Birth_year <= Current_year Then
                    Age_year = Current_year - Birth_year
                End If

                If Current_month >= Birth_month Then
                    Age_month = Current_month - Birth_month
                ElseIf Current_month < Birth_month Then
                    Age_year -= 1
                    Age_month = 12 + (Current_month - Birth_month)
                Else
                    Console.WriteLine("Invalid Input")
                    Console.ReadLine()
                    End
                End If

                If (Current_day >= Birth_day) Then
                    Age_day = (Current_day - Birth_day)
                ElseIf (Current_day - Birth_day) Then
                    Age_month -= 1
                    Age_day = DateTime.DaysInMonth(Birth_year, Birth_month) + (Current_day) - (Birth_day)
                Else
                    Console.WriteLine("Invalid Input")
                    Console.ReadLine()
                    End
                End If

                If Age_month < 0 Then
                    Age_month = 11
                    Age_year -= 1
                End If

                If Age_year < 0 Then
                    Console.WriteLine("Invalid Input")
                    Console.ReadLine()
                    End
                End If
                Console.WriteLine("THE AGE  is " + Age_year.ToString + ("years ") + (", ") + Age_month.ToString + ("month") + (", ") + Age_day.ToString + ("days "))

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 20 Then

            Dim result, modules, number As Integer

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


                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2


            ElseIf sel = 21 Then

            Dim result, modules, number, choose As Double

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
                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 22 Then
            Dim number As Integer
            Dim result As Long

            Do
                Console.WriteLine("THE SOFTWARE TO CALCULATE FACTORIAL OF A NUMBER")
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")

                Console.WriteLine("Enter a number to calculate its factorial")
                number = Val(Console.ReadLine())
                If number < 1 Then
                    Console.WriteLine("Invalid  Input")
                End If
                result = 1

                For a As Integer = 1 To number
                    result *= a
                    Console.WriteLine(a & "! " & "=" & " " & result)
                Next
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            ElseIf sel = 23 Then
            Dim loan_amount, loan_duration, repayment, monthly_repayment, interest_on_loan, total_interest, total_monthly_repayment As Double
            Console.WriteLine("SOFTWARE TO CALCULATE LOAN APPLICATION")
            Console.WriteLine("_______________________________________")
            Console.WriteLine("  ")

            Do
                ' Reset totals for each new calculation
                total_interest = 0
                total_monthly_repayment = 0

                Console.WriteLine("Enter the loan amount:")
                loan_amount = Val(Console.ReadLine())
                Console.WriteLine("Enter the loan duration (in months):")
                loan_duration = Val(Console.ReadLine())
                If (loan_amount < 1) Or (loan_duration < 1) Then
                    Console.WriteLine("Invalid input")

                Else
                    Console.WriteLine("Month | Repayment              | Interest                | Monthly Repayment")
                    Console.WriteLine("_____________________________________________________________________________")
                    For month As Integer = 1 To loan_duration
                        repayment = loan_amount / loan_duration
                        interest_on_loan = (1.5 / 100) * (loan_amount - ((month - 1) * repayment))
                        monthly_repayment = repayment + interest_on_loan
                        total_interest += interest_on_loan
                        total_monthly_repayment += monthly_repayment

                        Console.WriteLine(month.ToString().PadRight(6) & "|" & repayment.ToString("n2").PadRight(24) & "|" & interest_on_loan.ToString("n2").PadRight(25) & "|" & monthly_repayment.ToString("n2").PadRight(18))
                    Next
                    Console.WriteLine("_____________________________________________________________________________")
                    Console.WriteLine("Total interest = " & total_interest.ToString("n2"))
                    Console.WriteLine("Total monthly repayment = " & total_monthly_repayment.ToString("n2"))
                    Console.WriteLine("  ")
                End If

                ' Loop to get valid input for continuation or exit or exit home
                Do
                    Console.WriteLine("Press 1 to exit home")
                    Console.WriteLine("Press 2 to exit this solution")
                    Console.WriteLine("Press 3 to continue...")
                    d = Val(Console.ReadLine())
                    If d <> 1 AndAlso d <> 3 Then
                        Console.WriteLine("Invalid input. Please press 1 or 2 or 3.")
                        Console.WriteLine("________________________________________________")
                        Console.WriteLine("  ")
                    ElseIf d = 1 Then
                        Exit Sub
                    End If
                Loop Until d = 3 Or d = 2
            Loop Until d = 2

            Else
            Console.WriteLine("Invalid input. Please press 1 or 2 .")
            Console.WriteLine("__________________________")
            Console.WriteLine("  ")


            ' Loop to get valid input for continuation or exit or exit home
            Do
                Console.WriteLine("Press 1 to exit home")
                Console.WriteLine("Press 2 to continue...")
                d = Val(Console.ReadLine())
                If d <> 1 AndAlso d <> 2 Then
                    Console.WriteLine("Invalid input. Please press 1 or 2 .")
                ElseIf d = 1 Then
                    Exit Sub
                End If
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")
            Loop Until d = 1 Or d = 2
            End If

        Loop Until d = 1

        Console.ReadLine()

    End Sub

End Module

