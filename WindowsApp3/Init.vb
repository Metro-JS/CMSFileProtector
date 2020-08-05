Public Class Init
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Button1.Enabled = True
    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("C:\Program Files (x86)\CMSFD\Terminos.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Finalize()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Button1.Enabled = True
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class