Imports System.IO
Public Class CarpDesbloq
    Private Const Path As String = "c:\CMSFG018K"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IO.File.SetAttributes(Path, IO.FileAttributes.Hidden Or
                                  IO.FileAttributes.System)
        MsgBox("Carpeta bloqueada", MsgBoxStyle.Information)
        End
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim esplorer As Boolean = Directory.Exists("C:\Program Files (x86)\CMSFD")
        If esplorer = True Then 'verificacion de existencia de carpeta
            Process.Start("C:\Program Files (x86)\CMSFD\CMSE.exe")
        Else
            MsgBox("Error al abrir el explorador, por favor reinstale la aplicación o póngase en contacto con el desarrollador", MsgBoxStyle.Critical, "Error al abrir el explorador")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        shangecntr.Show()
        Dim finish As Integer
        If finish = 1 Then
            End
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("CMS File Protector V 1.1. (C) 2020 JISA T.CO. Diseño de íconos: Yaello 5187", MsgBoxStyle.DefaultButton1, "Acerca de")
    End Sub
End Class