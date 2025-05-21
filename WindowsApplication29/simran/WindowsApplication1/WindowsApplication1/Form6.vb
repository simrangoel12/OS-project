Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, n, t As Integer
        n = TextBox1.Text
        i = 1
        While i <= 10
            t = n * i
            i += 1
            TextBox2.Text &= t & vbNewLine
        End While
    End Sub
End Class