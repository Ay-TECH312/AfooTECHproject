Module Module1

    Sub Main()
        Dim Grosssalary, Percentage, Totalamount, Deductiontax, result As Decimal
        Console.WriteLine("THE SOFTWARE SOLUTION TO CALCULATE STAFF SALARY OF ANY TAXRATE")
        Console.WriteLine(" ______________________________________________________________")
        Console.WriteLine(" ")
        
        'INPUT'
        Console.WriteLine("Enter the value for gross salary")
        Grosssalary = Console.ReadLine() 'access inputs for  Grosssalary'
        Console.WriteLine("Enter the value for percentage")
        Percentage = Console.ReadLine() 'access inputs for Percentage'
        Console.WriteLine("   ")


        Percentage = Percentage / 100
        Deductiontax = Grosssalary * Percentage
        Totalamount = Grosssalary - Deductiontax

        Console.WriteLine("   ")
        result = Deductiontax

        Console.WriteLine("The TaxDeduction amount   = " + ("#") + result.ToString("n2"))
        result = Totalamount
        Console.WriteLine("  ")
        Console.WriteLine("The Balance salary = " + ("#") + result.ToString("n2"))
        Console.ReadLine()


    End Sub

End Module
