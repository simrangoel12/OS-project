Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, sum As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        sum = a + b
        TextBox3.Text = sum

    End Sub
End Class
