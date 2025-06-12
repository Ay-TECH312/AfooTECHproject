Module Module1

    Sub Main()
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
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 3) And (Birth_day > 31) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 4) And (Birth_day > 30) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 5) And (Birth_day > 31) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 6) And (Birth_day > 30) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 7) And (Birth_day > 31) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 8) And (Birth_day > 31) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 9) And (Birth_day > 30) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 10) And (Birth_day > 31) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 11) And (Birth_day > 30) Then
            Console.WriteLine("Invalid Month Input")
                Console.ReadLine()
                End
            ElseIf (Birth_month = 12) And (Birth_day > 31) Then
            Console.WriteLine("Invalid Month Input")
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

        If Current_year >= Birth_year Then
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
        ElseIf (Current_day < Birth_day) Then
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
        Console.ReadLine()

    End Sub

End Module
