Public Class Form9
    Dim a(9), i As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s, k As Integer
        For k = 0 To a.Length - 1
            s += a(k)
        Next k
        TextBox3.Text = s
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode() = 13 Then
            If i < 9 Then
                a(i) = TextBox1.Text
                TextBox2.Text &= a(i) & vbNewLine
                TextBox1.Text = "  "
                i += 1
            Else
                MsgBox("array is full")
            End If
        End If
    End Sub

    Private Sub MsgBox(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

   

End Class