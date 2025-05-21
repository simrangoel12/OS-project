Module rfact
    Sub main()
        Dim n As Integer
        Console.WriteLine("enter number")
        n = Console.ReadLine
        Console.WriteLine("factorial of given no. is =" & fact(n))
        Console.ReadKey()
    End Sub
    Public Function fact(ByVal num As Integer) As Integer
        If (num = 0) Then
            Return 0
        Else
            Return num * fact(num - 1)
        End If
    End Function
End Module
