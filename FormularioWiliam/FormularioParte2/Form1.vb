Public Class Form1
    Public usuario As String
    Public contrasena As String


    Private Sub txusuraio_TextChanged(sender As Object, e As EventArgs) Handles txusuraio.TextChanged

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        usuario = "Juan"
        contrasena = "12345"
        If txusuraio.Text = usuario And txcontrasena.Text = contrasena Then

            MsgBox("Usuario y contraseñas correctas")
        Else
            MsgBox("Usuario o contraseña incorrectas")

        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        MsgBox("Seguro que desea salir?")

    End Sub
End Class
