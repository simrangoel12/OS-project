Module jagged2
    Sub main()
        Dim jarray As Integer()(,) = New Integer(1)(,) {}
        Dim i, j, k As Integer
        jarray(0) = New Integer(1, 1) {{15, 24}, {42, 10}}
        jarray(1) = New Integer(1, 1) {{11, 24}, {33, 44}}
        Console.WriteLine("jagged array elements are")
        For i = 0 To jarray.GetUpperBound(0)
            For j = 0 To jarray.Length - 1
                For k = 0 To jarray.Length - 1
                    Console.Write(jarray(i)(j, k))
                    Console.WriteLine("  ")
                Next k
                Console.WriteLine()
                Console.ReadKey()
            Next j
        Next i
    End Sub

End Module
