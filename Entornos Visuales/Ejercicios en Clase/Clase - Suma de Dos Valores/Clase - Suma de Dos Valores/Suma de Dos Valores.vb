Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Valor1 As Integer
        Dim Valor2 As Integer
        Dim Suma As Integer
        Dim Resta As Integer

        Valor1 = Val(txtValor1.Text)
        Valor2 = Val(txtValor2.Text)

        Suma = Valor1 + Valor2
        Resta = Valor1 - Valor2

        txtSuma.Text = Suma
        txtResta.Text = Resta

    End Sub
End Class
