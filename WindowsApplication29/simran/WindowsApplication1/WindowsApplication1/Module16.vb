Module ageoutofrange
    Class ageoutofrange : Inherits AggregateException
        Public Sub New(ByVal msg As String)
            MyBase.new(msg)
        End Sub
        Sub main()
            Dim age As Integer
            Console.WriteLine("enter age=")
            age = Console.ReadLine
            If age < 18 Or age > 120 Then
                Throw New ageoutofrange("invalid age")
            Else
                Console.WriteLine("you are eligible")
            End If
            Console.ReadKey()
        End Sub
    End Class
End Module
