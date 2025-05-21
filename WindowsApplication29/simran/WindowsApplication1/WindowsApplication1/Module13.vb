Module Module13
    Public Class ab
        Public a, b As Integer
        Public Function sumab() As Integer
            Return (a + b)
        End Function
    End Class
    Public Class abc : Inherits ab
        Public c As Integer
        Public Function sumabc() As Integer
            Return (sumab() + c)
        End Function
    End Class
    Sub main()
        Dim obj As abc = New abc
        obj.a = Console.ReadLine
        obj.b = Console.ReadLine
        obj.c = Console.ReadLine
        Console.WriteLine("sum=" & obj.sumab())
        Console.WriteLine("sum=" & obj.sumabc())
        Console.ReadKey()
    End Sub
End Module
