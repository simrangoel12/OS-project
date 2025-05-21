Module cd_inherits
    Class rectangle
        Public l, b As Single
        Public Sub New()
            l = 4
            b = 2

        End Sub
        Public Function area() As Single
            Return (l * b)
        End Function

    End Class
    Class square : Inherits rectangle
        Public s As Single
        Public Sub New()
            s = 3
        End Sub
        Protected Overrides Sub finalize()
            l = 0
            b = 0
            s = 0
        End Sub
        Public Function area1() As Single
            Return (s * s)
        End Function
    End Class
    Sub main()
        thismethod()
        GC.Collect()
        Console.ReadKey()
    End Sub
    Public Sub thismethod()
        Dim obj As square = New square
        Console.WriteLine("area of rectangle is=" & obj.area())
        Console.WriteLine("area of squareis=" & obj.area1())
    End Sub
End Module
