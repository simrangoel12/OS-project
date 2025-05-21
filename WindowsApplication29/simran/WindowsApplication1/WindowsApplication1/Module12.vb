Module construct
    Sub New()
        Console.WriteLine("constructor called")
        Console.ReadKey()
    End Sub
    Public Class rectangle
        Public length As Single
        Public breadth As Single
        Public Function geta() As Single
            Return length * breadth
        End Function
        Public Function getp() As Single
            Return 2 * (length + breadth)
        End Function
        Protected Overrides Sub finalize()
            Console.WriteLine("destructor called")
            Console.ReadKey()
        End Sub
    End Class
    Sub main()
        Dim r As rectangle = New rectangle
        Console.WriteLine("enter length=")
        r.length = Console.ReadLine
        Console.WriteLine("enter breadth=")
        r.breadth = Console.ReadLine
        Console.WriteLine("area of rectangle=" & r.geta())
        Console.ReadKey()
        Console.WriteLine("perimeter of rectangle=" & r.getp())
        Console.ReadKey()
    End Sub

End Module
