Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, fact As Integer
        n = TextBox1.Text
        fact = 1
        For n = TextBox1.Text To 1 Step -1
            fact = fact * n
        Next n
        TextBox2.Text = fact
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "  "
        TextBox2.Text = " "
    End Sub
End Class