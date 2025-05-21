Module destruct
    Sub New()
        Console.WriteLine("constructor called")
    End Sub
    Public Class abc
        Protected Overrides Sub finalize()
            Console.WriteLine("destructor called")
        End Sub
    End Class
    Sub main()
        thismethod()
        GC.Collect()
        Console.ReadKey()
    End Sub
    Sub thismethod()
        Dim obj As abc = New abc()
    End Sub
End Module
