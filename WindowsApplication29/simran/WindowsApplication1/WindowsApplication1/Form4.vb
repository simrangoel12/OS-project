Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c, v, d, i, s As Integer
        Dim str As String
        str = TextBox1.Text
        For i = 0 To str.Length - 1
            Select Case str.Substring(i, 1)
                Case "b" To "d", "f" To "h", "j" To "n", "p" To "t", "v" To "z"
                    c += 1
                Case "a", "e", "i", "o", "u"
                    v += 1
                Case "0" To "9"
                    d += 1
                Case Else
                    s += 1
            End Select
        Next
        TextBox2.Text = c
        TextBox3.Text = v
        TextBox4.Text = d
        TextBox5.Text = s
    End Sub
End Class