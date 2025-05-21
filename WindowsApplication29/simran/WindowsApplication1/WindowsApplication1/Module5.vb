Module swap
    Sub main()
        Dim a, b As Integer
        Console.WriteLine("enter a=")
        a = Console.ReadLine
        Console.WriteLine("enter b=")
        b = Console.ReadLine
        Console.WriteLine("value of a and b before swapping =")
        Console.WriteLine(a)
        Console.WriteLine(b)
        Console.WriteLine("value of a and b after swapping =" & vbNewLine & swap(a, b))
        Console.ReadKey()
    End Sub
    Public Function swap(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim t As Integer
        t = x
        x = y
        y = t
        Return (x & y)
    End Function
End Module
