Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b As Integer
        Dim c As String
        a = TextBox1.Text
        b = TextBox2.Text
        c = ComboBox1.Text
        Select Case c
            Case "addition"
                TextBox3.Text = a + b
            Case "subtraction"
                TextBox3.Text = a - b
            Case "multiplication"
                TextBox3.Text = b * a
            Case "division"
                TextBox3.Text = a / b
        End Select
    End Sub
End Class
