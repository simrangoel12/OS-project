Module palindrome
    Sub main()
        Dim num, t, k As Integer
        Console.WriteLine("enter any number")
        num = Console.ReadLine
        k = num
        t = Reverse(num)
        isplaindrome(t, k)
        Console.ReadKey()
    End Sub
    Public Function reverse(ByVal num As Integer) As Integer
        Dim r, s As Integer
        While (num <> 0)
            r = num Mod 10
            s = r + s * 10
            num = num \ 10
        End While
        Return s
    End Function
    Public Sub isplaindrome(ByVal t As Integer, ByVal k As Integer)
        If t = k Then
            Console.WriteLine("given no. is palimdrome")
        Else
            Console.WriteLine("given no. is not palindrome")
        End If
    End Sub
End Module
