Imports System
Imports System.IO
'Copyright (C) 2020 Jorge Jiménez, todos los derechos reservados. Diseños de íconos: Yaello 5187. Todos los derechos reservados
'El nombre de "CMS File Protector" es propiedad registrada de JISA Tech Company SA. de CV.
'Form 1, petición de contraseña
Public Class CarpBloqueda
    Private Const Path As String = "C:\CMSFG018K"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim contrasenya As String
        Dim imput As String
        Dim hide_file_info As IO.FileInfo = My.Computer.FileSystem.GetFileInfo("C:\CMSFG018K")
        imput = InsCNTR.Text
        contrasenya = Environment.GetEnvironmentVariable("pass")
        If imput = contrasenya Then
            IO.File.SetAttributes(Path, IO.FileAttributes.Normal)
            MsgBox("Carpeta Desbloqueada", MsgBoxStyle.Information, "Carpeta desbloqueada")
            Hide()
            CarpDesbloq.Show()
        ElseIf atemps.Text = 3 Then
            MsgBox("Vuelva a iniciar la aplicación para seguir intentando", MsgBoxStyle.Critical, "ERROR")
            End
        Else
            atemps.Text = atemps.Text + 1
            MsgBox("Contraseña incorrecta, intente otra vez", MsgBoxStyle.Exclamation, "Contraseña incorrecta")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load 'Carga del Form
        Dim imput As String
        If Directory.Exists(Path) = False Then 'verificacion de existencia de carpeta
            MkDir(Path)
            MsgBox("Bienvenido a CMS File Protector, unos últimos pasos para iniciar. :)", MsgBoxStyle.DefaultButton1, "CMS File Protector")
            Init.Show()
            imput = InputBox("Por favor ingrese una contraseña", "Ingresar contraseña")
            Environment.SetEnvironmentVariable("pass", imput, EnvironmentVariableTarget.User)
            MsgBox("Puede cambiar su contraseña más adelante", MsgBoxStyle.DefaultButton1, "Ingresar contraseña")
        End If
        If (File.GetAttributes(CMSFD.CarpBloqueda.Path) _
         And FileAttributes.Hidden) _
         = FileAttributes.Hidden Then 'Verificación de atributos de contraseña
        Else
            Me.Finalize()
            CarpDesbloq.Show()
        End If
    End Sub

    Private Sub InsCNTR_Click(sender As Object, e As EventArgs) Handles InsCNTR.Click
        If InsCNTR.Text = "Insertar contraseña" Then
            InsCNTR.Text = ""
        End If
    End Sub
End Class
