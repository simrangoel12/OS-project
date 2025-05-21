Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, max As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        If a > b Then
            If a > c Then
                max = a
            Else
                max = c
            End If
        Else
            If b > c Then
                max = b
            Else
                max = c
            End If
        End If
        TextBox4.Text = max
    End Sub
End Class