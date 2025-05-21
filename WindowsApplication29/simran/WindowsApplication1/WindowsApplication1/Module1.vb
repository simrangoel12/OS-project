Module dynamic
    Sub main()
        Dim a() As Integer
        ReDim a(3)
        Console.WriteLine("enter elements")
        a(0) = Console.ReadLine()
        a(1) = Console.ReadLine()
        a(2) = Console.ReadLine()
        a(3) = Console.ReadLine()
        Console.WriteLine("array")
        For i As Integer = 0 To a.GetUpperBound(0)
            Console.WriteLine(a(i))
        Next i
        Console.WriteLine("re-dimension array")
        ReDim Preserve a(5)
        a(4) = 50
        a(5) = 60
        For i As Integer = 0 To a.GetUpperBound(0)
            Console.WriteLine(a(i))
        Next i
        Console.ReadKey()
    End Sub
End Module
