Module factorial
    Dim n, f As Integer
    Sub main()
        f = 1
        Console.WriteLine("enter no. to find factorial=")
        n = Console.ReadLine
        Console.WriteLine("factorial of given no is =" & fact(n))
        Console.ReadKey()
    End Sub
    Public Function fact(ByVal x As Integer) As Integer
        Do Until x = 0
            f *= x
            x -= 1
        Loop
        Return f
    End Function
End Module
