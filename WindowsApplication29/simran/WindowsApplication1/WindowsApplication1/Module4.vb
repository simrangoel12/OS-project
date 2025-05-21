Module addfunc
    Sub main()
        Dim a, b As Integer
        Console.WriteLine("enter a=")
        a = Console.ReadLine
        Console.WriteLine("enter b=")
        b = Console.ReadLine
        Console.WriteLine("sum of a and b=" & sum(a, b))
        Console.ReadKey()

    End Sub
    Public Function sum(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim c As Integer
        c = x + y
        Return c
    End Function
End Module
