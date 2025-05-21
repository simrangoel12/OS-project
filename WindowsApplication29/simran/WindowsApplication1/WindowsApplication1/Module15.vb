Module dividebyzero
    Sub main()
        Dim x, y As Integer
        Dim valid As Boolean
        Do While valid = False
            Try
                Console.WriteLine("enter x=")
                x = Console.ReadLine
                Console.WriteLine("enter y=")
                y = Console.ReadLine
                Console.WriteLine("division=" & x \ y)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        Loop
        Console.ReadKey()
    End Sub
End Module
