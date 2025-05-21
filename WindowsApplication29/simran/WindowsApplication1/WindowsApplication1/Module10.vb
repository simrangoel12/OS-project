Module constructor
    Sub main()
        Dim obj1 As name = New name()
        Dim obj2 As name = New name("simmi", "sanya", "sakshi")
        Console.WriteLine("obj1=" & obj1.fname & vbTab & obj1.mnane & vbTab & obj1.sname)
        Console.WriteLine("obj2=" & obj2.fname & vbTab & obj2.mnane & vbTab & obj2.sname)
        Console.ReadKey()
    End Sub
    Public Class name
        Public fname, mnane, sname As String
        Public Sub New()
            sname = "goel"
            mnane = "simmi"
            fname = "simran"
        End Sub
        Public Sub New(ByVal f As String, ByVal m As String, ByVal s As String)
            fname = f
            mnane = m
            sname = s
        End Sub
    End Class
End Module
