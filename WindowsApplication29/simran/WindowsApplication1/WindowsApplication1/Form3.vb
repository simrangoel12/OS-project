Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim marks1, marks2, marks3, total As Integer
        Dim per As Single
        Dim grade As String
        marks1 = TextBox1.Text
        marks2 = TextBox2.Text
        marks3 = TextBox3.Text
        total = marks1 + marks2 + marks3
        per = (total * 100) / 300
        If per >= 90 Then
            grade = "o"
        ElseIf per >= 80 Then
            grade = "a+"
        ElseIf per >= 70 Then
            grade = "a"
        ElseIf per >= 60 Then
            grade = "b"
        ElseIf per >= 50 Then
            grade = "c"
        ElseIf per >= 40 Then
            grade = "d"
        Else
            grade = "f"
        End If
        TextBox4.Text = total
        TextBox5.Text = per
        TextBox6.Text = grade
    End Sub
End Class