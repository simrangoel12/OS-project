Module arrayoutofrange
    Class arrayoutofrange : Inherits AggregateException
        Public Sub New(ByVal msg As String)
            MyBase.new(msg)
        End Sub
    End Class
    Sub main()
        Dim a(4), i, n As Integer
        Console.WriteLine("enter size of array=")
        n = Console.ReadLine
        Console.WriteLine("read array elements")
        For i = 0 To n
            If i >= n Then
                Throw New arrayoutofrange("array out of range")
                Console.WriteLine("out of range")
            Else
                a(i) = Console.ReadLine
            End If

        Next i
        Console.WriteLine("array elements are=")
        For i = 0 To n
            Console.WriteLine(a(i))

        Next i
        Console.ReadKey()
    End Sub
End Module
