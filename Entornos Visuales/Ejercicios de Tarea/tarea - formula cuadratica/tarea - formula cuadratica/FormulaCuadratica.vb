Public Class FormulaCuadratica

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c, d As Double
        a = Val(txtA.Text)
        b = Val(txtB.Text)
        c = Val(txtC.Text)
        d = ((b ^ 2) - 4 * a * c)

        If (a <> 0) Then
            If ((d) < 0) Then
                txtResultado.Text = "No hay solucion real para esta ecuacion"
                txtX1.Text = ""
                txtX2.Text = ""
            Else
                txtX1.Text = (-b + (d) ^ (1 / 2)) / (2 * a)
                txtResultado.Text = ""
                txtX2.Text = (-b - (d) ^ (1 / 2)) / (2 * a)
                txtResultado.Text = ""

            End If
        Else
            txtResultado.Text = "(a) debe ser diferente de cero y contener valores"
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtA.ResetText()
        txtB.ResetText()
        txtC.ResetText()
        txtX1.ResetText()
        txtX2.ResetText()
        txtResultado.ResetText()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
