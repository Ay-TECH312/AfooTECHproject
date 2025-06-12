Module Module1

    Sub Main()
        Dim x1, x2, a, b, c, d, e, f, g, h, j, k, l, m, n, result As Decimal

        Console.WriteLine("QUADRATIC FORMULAR")
        Console.WriteLine("===================")
        Console.WriteLine("  ")

        Console.WriteLine("Enter the value for a")
        a = Console.ReadLine()
        Console.WriteLine("Enter the value for b")
        b = Console.ReadLine()
        Console.WriteLine("Enter the value for c")
        c = Console.ReadLine()

        d = b * b
        e = 4 * a
        f = e * c
        g = d - f
        h = Math.Sqrt(g)
        j = -b + h
        k = -b - h
        l = 2 * a
        m = j / l
        n = k / l
        x1 = m
        x2 = n
        result = x1
        Console.WriteLine("x1  =" + result.ToString)
        result = x2
        Console.WriteLine("x2  =" + result.ToString)

        
        Console.ReadLine()

    End Sub

End Module
