Public Class Login
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As String
        Dim contraseña As String
        Dim admin As String = "administrador"
        usuario = txtUsuario.Text
        contraseña = txtContra.Text
        If (usuario = "Administrador" Or usuario = "administrador") And (contraseña = "SinHacer2020") Then
            Bienvenido.Show()
        Else
            MsgBox("Usuario o Contraseña Incorrecta")
        End If
        txtUsuario.Text = ""
        txtContra.Text = ""

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim opc As DialogResult
        opc = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opc = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
