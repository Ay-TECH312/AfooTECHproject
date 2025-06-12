Module Module1

    Sub Main()
        Dim loan_amount, loan_duration, repayment, monthly_repayment, interest_on_loan, total_interest, total_monthly_repayment As Double
        Dim c As Integer
        Console.WriteLine("SOFTWARE TO CALCULATE LOAN APPLICATION")
        Console.WriteLine("_______________________________________")
        Console.WriteLine("  ")
        Do
            Console.WriteLine("Enter the loan amount:")
            loan_amount = Val(Console.ReadLine())
            Console.WriteLine("Enter the loan duration (in months):")
            loan_duration = Val(Console.ReadLine())
            Console.WriteLine("Month | Repayment | Interest | Monthly Repayment")
            Console.WriteLine("___________________________________________________")
            For month As Integer = 1 To loan_duration
                repayment = loan_amount / loan_duration
                interest_on_loan = (1.5 / 100) * (loan_amount - ((month - 1) * repayment))
                monthly_repayment = repayment + interest_on_loan
                total_interest += interest_on_loan
                total_monthly_repayment += monthly_repayment

                Console.WriteLine(month.ToString().PadRight(6) & "|" & repayment.ToString("n2").PadRight(11) & "|" & interest_on_loan.ToString("n2").PadRight(10) & "|" & monthly_repayment.ToString("n2").PadRight(10))
            Next
            Console.WriteLine("___________________________________________________")
            Console.WriteLine("Total interest = " & ("#") & total_interest.ToString("n2"))
            Console.WriteLine("Total monthly repayment = " & ("#") & total_monthly_repayment.ToString("n2"))
            Console.WriteLine("  ")

            Do
                Console.WriteLine("Press 1 to exit")
                Console.WriteLine("Press 2 to continue...")
                c = Val(Console.ReadLine())
                If c <> 1 AndAlso c <> 2 Then
                    Console.WriteLine("Invalid input. Please press 1 or 2.")
                End If
                Console.WriteLine("________________________________________________")
                Console.WriteLine("  ")
            Loop Until c = 1 Or c = 2


        Loop Until c = 1

        Console.ReadLine()

    End Sub

End Module