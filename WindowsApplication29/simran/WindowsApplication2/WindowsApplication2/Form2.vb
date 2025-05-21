Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j, n As Integer
        Dim s As String
        s = ComboBox1.Text
        n = TextBox1.Text
        Select Case s
            Case "stars"
                i = 1
                Do While (i <= n)
                    j = 1
                    Do While (j <= i)
                        TextBox3.Text = TextBox3.Text & " * "
                        j = j + 1
                    Loop
                    TextBox3.Text = TextBox3.Text & vbNewLine
                    i = i + 1
                Loop

            Case "digit patterns"
                i = 1
                Do While (i <= n)
                    j = 1
                    Do While (j <= i)
                        TextBox3.Text = TextBox3.Text & " " & j
                        j = j + 1
                    Loop
                    TextBox3.Text = TextBox3.Text & vbNewLine
                    i = i + 1
                Loop
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Text = " "
    End Sub
End Class
