Public Class Bienvenido
    Dim departamento(3, 18), absoluto(3) As Int16
    Private Sub Bienvenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbReporteDepa.SelectedIndex = 0
        cmbReporteDepa.SelectedIndex = 0
        cmbEstado.SelectedIndex = 0
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Login.Close()
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese por favor su nombre")
        End If
    End Sub

    Private Sub mktxEdad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mktxEdad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese por favor su edad")
        End If
    End Sub

    Private Sub rtxtStatusSalud_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rtxtStatusSalud.Validating
        If DirectCast(sender, RichTextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Por favor llene este campo")
        End If
    End Sub

    Private Sub cmbDepartamento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbDepartamento.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Escoja una opcion")
        End If
    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbEstado.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
    Private Sub ckbxPositivo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ckbxPositivo.Validating
        If DirectCast(sender, CheckBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Escoja un Resultado")
        End If
    End Sub




    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim itemID As Int16
        Dim index As Int16
        Dim espacio As String
        espacio = ""


        Try
            If Me.ValidateChildren And IsNumeric(txtNombre) = False And txtNombre.TextLength > 0 And mktxEdad.TextLength > 0 Then
                LBHistory.Items.Add(txtNombre.Text + espacio + cmbEstado.Text)
                itemID = cmbEstado.SelectedIndex
                index = cmbDepartamento.SelectedIndex
                absoluto(itemID, index)
                acumulador(itemID, index)
            Else
                MsgBox("Por favor ingresar los datos requeridos", "Datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtNombre.Clear()
        mktxEdad.Clear()
        rtxtStatusSalud.Clear()
    End Sub

    Private Sub cmbReporteDepa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReporteDepa.SelectedIndexChanged
        Select Case cmbReporteDepa.SelectedIndex
            Case 0
                txtActivo.Text = absoluto(0)
                txtRecuperado.Text = absoluto(1)
                txtMuerto.Text = absoluto(2)
            Case 1
                txtActivo.Text = departamento(0, 0)
                txtRecuperado.Text = departamento(0, 1)
                txtMuerto.Text = departamento(0, 2)
            Case 2
                txtActivo.Text = departamento(1, 0)
                txtRecuperado.Text = departamento(1, 1)
                txtMuerto.Text = departamento(1, 2)
            Case 3
                txtActivo.Text = departamento(2, 0)
                txtRecuperado.Text = departamento(2, 1)
                txtMuerto.Text = departamento(2, 2)
            Case 4
                txtActivo.Text = departamento(3, 0)
                txtRecuperado.Text = departamento(3, 1)
                txtMuerto.Text = departamento(3, 2)
            Case 5
                txtActivo.Text = departamento(4, 0)
                txtRecuperado.Text = departamento(4, 1)
                txtMuerto.Text = departamento(4, 2)
            Case 6
                txtActivo.Text = departamento(5, 0)
                txtRecuperado.Text = departamento(5, 1)
                txtMuerto.Text = departamento(5, 2)
            Case 7
                txtActivo.Text = departamento(6, 0)
                txtRecuperado.Text = departamento(6, 1)
                txtMuerto.Text = departamento(6, 2)
            Case 8
                txtActivo.Text = departamento(7, 0)
                txtRecuperado.Text = departamento(7, 1)
                txtMuerto.Text = departamento(7, 2)
            Case 9
                txtActivo.Text = departamento(8, 0)
                txtRecuperado.Text = departamento(8, 1)
                txtMuerto.Text = departamento(8, 2)
            Case 10
                txtActivo.Text = departamento(9, 0)
                txtRecuperado.Text = departamento(9, 1)
                txtMuerto.Text = departamento(9, 2)
            Case 11
                txtActivo.Text = departamento(10, 0)
                txtRecuperado.Text = departamento(10, 1)
                txtMuerto.Text = departamento(10, 2)
            Case 12
                txtActivo.Text = departamento(11, 0)
                txtRecuperado.Text = departamento(11, 1)
                txtMuerto.Text = departamento(11, 2)
            Case 13
                txtActivo.Text = departamento(12, 0)
                txtRecuperado.Text = departamento(12, 1)
                txtMuerto.Text = departamento(12, 2)
            Case 14
                txtActivo.Text = departamento(13, 0)
                txtRecuperado.Text = departamento(13, 1)
                txtMuerto.Text = departamento(13, 2)
            Case 15
                txtActivo.Text = departamento(14, 0)
                txtRecuperado.Text = departamento(14, 1)
                txtMuerto.Text = departamento(14, 2)
            Case 16
                txtActivo.Text = departamento(15, 0)
                txtRecuperado.Text = departamento(15, 1)
                txtMuerto.Text = departamento(15, 2)
            Case 17
                txtActivo.Text = departamento(16, 0)
                txtRecuperado.Text = departamento(16, 1)
                txtMuerto.Text = departamento(16, 2)
            Case 18
                txtActivo.Text = departamento(17, 0)
                txtRecuperado.Text = departamento(17, 1)
                txtMuerto.Text = departamento(17, 2)
        End Select
    End Sub

    Public Sub absoluto(ByVal itemID)
        Select Case itemID
            Case 0
                txtActivo.Text = Val(txtActivo.Text) + 1
                abs(0) += 1
            Case 1
                txtRecuperado.Text = Val(txtRecuperado.Text) + 1
                abs(1) += 1
            Case 2
                txtMuerto.Text = Val(txtMuerto.Text) + 1
                abs(2) += 1
        End Select
    End Sub

    Public Sub acumulador(ByVal ItemID, ByVal indexID)
        Select Case indexID
            Case 0
                If ItemID = 0 Then
                    departamento(0, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(0, 1) += 1
                Else
                    departamento(0, 2) += 1
                End If
            Case 1
                If ItemID = 0 Then
                    departamento(1, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(1, 1) += 1
                Else
                    departamento(1, 2) += 1
                End If
            Case 2
                If ItemID = 0 Then
                    departamento(2, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(2, 1) += 1
                Else
                    departamento(2, 2) += 1
                End If
            Case 3
                If ItemID = 0 Then
                    departamento(3, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(3, 1) += 1
                Else
                    departamento(3, 2) += 1
                End If
            Case 4
                If ItemID = 0 Then
                    departamento(4, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(4, 1) += 1
                Else
                    departamento(4, 2) += 1
                End If
            Case 5
                If ItemID = 0 Then
                    departamento(5, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(5, 1) += 1
                Else
                    departamento(5, 2) += 1
                End If
            Case 6
                If ItemID = 0 Then
                    departamento(6, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(6, 1) += 1
                Else
                    departamento(6, 2) += 1
                End If
            Case 7
                If ItemID = 0 Then
                    departamento(7, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(7, 1) += 1
                Else
                    departamento(7, 2) += 1
                End If
            Case 8
                If ItemID = 0 Then
                    departamento(8, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(8, 1) += 1
                Else
                    departamento(8, 2) += 1
                End If
            Case 9
                If ItemID = 0 Then
                    departamento(9, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(9, 1) += 1
                Else
                    departamento(9, 2) += 1
                End If
            Case 10
                If ItemID = 0 Then
                    departamento(10, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(10, 1) += 1
                Else
                    departamento(10, 2) += 1
                End If
            Case 11
                If ItemID = 0 Then
                    departamento(11, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(11, 1) += 1
                Else
                    departamento(11, 2) += 1
                End If
            Case 12
                If ItemID = 0 Then
                    departamento(12, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(12, 1) += 1
                Else
                    departamento(12, 2) += 1
                End If
            Case 13
                If ItemID = 0 Then
                    departamento(13, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(13, 1) += 1
                Else
                    departamento(13, 2) += 1
                End If
            Case 14
                If ItemID = 0 Then
                    departamento(14, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(14, 1) += 1
                Else
                    departamento(15, 2) += 1
                End If
            Case 15
                If ItemID = 0 Then
                    departamento(15, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(15, 1) += 1
                Else
                    departamento(15, 2) += 1
                End If
            Case 16
                If ItemID = 0 Then
                    departamento(16, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(16, 1) += 1
                Else
                    departamento(16, 2) += 1
                End If
            Case 17
                If ItemID = 0 Then
                    departamento(17, 0) += 1
                ElseIf ItemID = 1 Then
                    departamento(17, 1) += 1
                Else
                    departamento(17, 2) += 1
                End If
        End Select
    End Sub

End Class