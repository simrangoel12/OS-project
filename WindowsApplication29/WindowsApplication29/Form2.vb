Imports System.Data.OleDb
Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles save.Click
        Dim comm As New OleDbCommand
        comm.CommandText = "insert into book(bid,bname) values(@id,@n)"
        comm.Connection = con
        comm.Parameters.AddWithValue("@id", TextBox1.Text)
        comm.Parameters.AddWithValue("@n", TextBox2.Text)
        comm.ExecuteNonQuery()
        MsgBox("record inserted successfully")
    End Sub

    Private Sub find_Click(sender As System.Object, e As System.EventArgs) Handles find.Click
        Dim comm As New OleDbCommand()
        comm.CommandText = "select bname from book where bid=@id"
        comm.Connection = con
        comm.Parameters.AddWithValue("@id", TextBox1.Text)
        Dim dr As OleDbDataReader
        dr = comm.ExecuteReader()
        If dr.Read() Then
            TextBox2.Text = dr(0)
        Else
            MsgBox("book id is not exist")
        End If
    End Sub

    Private Sub update_Click(sender As System.Object, e As System.EventArgs) Handles update.Click
        Dim comm As New OleDbCommand
        comm.CommandText = "update book set bname=@n where bid=@id"
        comm.Connection = con
        comm.Parameters.AddWithValue("@id", TextBox1.Text)
        comm.Parameters.AddWithValue("@n", TextBox2.Text)
        comm.ExecuteNonQuery()
        MsgBox("record updated seccessfully")
    End Sub
End Class