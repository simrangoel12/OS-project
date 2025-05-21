Module Module1
    Public con As New OleDb.OleDbConnection


    Public Sub getconnection()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\library.accdb"
        con.Open()
    End Sub
End Module
