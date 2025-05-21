Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text
        Select Case n Mod 2
            Case 0
                TextBox2.Text = "even"
            Case 1
                TextBox2.Text = "odd"
            Case Else
                TextBox2.Text = "wrong input"
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "   "
        TextBox2.Text = "  "

    End Sub
End Class