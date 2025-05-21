Module jagged
    Sub main()
        Dim jarray As Integer()() = New Integer(3)() {}
        Dim i, j As Integer
        jarray(0) = New Integer() {1}
        jarray(1) = New Integer() {1, 2}
        jarray(2) = New Integer() {1, 2, 3}
        jarray(3) = New Integer() {1, 2, 3, 4}
        Console.WriteLine("jagged array elements are")
        For i = 0 To jarray.GetUpperBound(0)
            For j = 0 To jarray(i).Length - 1
                Console.WriteLine(jarray(i)(j))
            Next j
            Console.WriteLine()
        Next i
        Console.ReadKey()
    End Sub
End Module
