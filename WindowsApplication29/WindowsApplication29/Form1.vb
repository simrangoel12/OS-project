Public Class Form1

   

    Private Sub Form1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Form1ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        getconnection()
    End Sub
End Class
