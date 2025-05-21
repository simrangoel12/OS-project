Public Class Form12
    Dim a(9), i As Integer
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = 13 Then
            If i < 9 Then
                a(i) = TextBox1.Text
                TextBox2.Text &= a(i) & vbNewLine
                TextBox1.Text = "  "
                i += 1
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r, p, flag, loc As Integer
        r = TextBox3.Text
        For p = 0 To a.Length - 1
            If a(p) = r Then
                flag = 1
                loc = p
            End If
        Next p
        If flag = 1 Then
            TextBox4.Text = "found"
            TextBox5.Text = loc
        Else
            TextBox4.Text = "not found"
        End If
    End Sub
End Class