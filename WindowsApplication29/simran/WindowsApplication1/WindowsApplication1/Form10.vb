Public Class Form10
    Dim i, a(9) As Integer
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode() = 13 Then
            If i < 9 Then
                a(i) = TextBox1.Text
                TextBox2.Text &= a(i) & vbNewLine
                TextBox1.Text = "  "
                i += 1
            Else
                msgbox("array is full")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m, k As Integer
        m = a(0)
        For k = 0 To a.Length - 1
            If m < a(k) Then
                m = a(k)
            End If
        Next k
        TextBox3.Text = m
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t, v As Integer
        t = a(0)
        For v = 0 To a.Length - 1
            If t > a(v) Then
                t = a(v)
            End If
        Next v
        TextBox4.Text = t
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim s, p As Integer
        For p = 0 To a.Length - 1
            s += a(p)
        Next p
        TextBox5.Text = s
    End Sub

    Private Sub msgbox(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub

   

End Class