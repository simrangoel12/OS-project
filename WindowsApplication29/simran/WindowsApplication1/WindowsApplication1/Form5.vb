Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, r, s As Integer
        n = TextBox1.Text
        Do Until n = 0
            r = n Mod 10
            s += r
            n \= 10
        Loop
        TextBox2.Text = s
    End Sub
End Class