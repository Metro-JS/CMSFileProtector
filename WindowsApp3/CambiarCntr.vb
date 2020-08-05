Public Class shangecntr

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim actual, aktual As String
        actual = Environment.GetEnvironmentVariable("pass", EnvironmentVariableTarget.User)
        aktual = antegiog.Text
        If aktual = actual Then
            Environment.SetEnvironmentVariable("pass", boxconfirm.Text, EnvironmentVariableTarget.User)
            MsgBox("Contraseña cambiada", MsgBoxStyle.Information)
            End
        Else
            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Finalize()
    End Sub

    Private Sub shangecntr_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim nova1, nova2 As String
        nova1 = boxneva.Text
        nova2 = boxconfirm.Text
        If nova1 = "" Then
            Button1.Enabled = False
            Label4.Text = "Escriba una nueva contraseña"
        ElseIf nova1 = nova2 Then
            Button1.Enabled = True
            Label4.Text = "Las contraseñas coinciden"
            Label4.ForeColor = Color.Green
        Else
            Button1.Enabled = False
            Label4.Text = "Las contraseñas NO coinciden"
            Label4.ForeColor = Color.Red
        End If
    End Sub
End Class