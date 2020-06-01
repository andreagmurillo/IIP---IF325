<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Precio = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.ckbxDescuento = New System.Windows.Forms.CheckBox()
        Me.ckbxISV = New System.Windows.Forms.CheckBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cbDescuento = New System.Windows.Forms.ComboBox()
        Me.cbISV = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtISV15 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.ForeColor = System.Drawing.Color.LimeGreen
        Me.Precio.Location = New System.Drawing.Point(13, 58)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(76, 13)
        Me.Precio.TabIndex = 1
        Me.Precio.Text = "Precio Unitario"
        '
        'Cantidad
        '
        Me.Cantidad.AutoSize = True
        Me.Cantidad.ForeColor = System.Drawing.Color.LimeGreen
        Me.Cantidad.Location = New System.Drawing.Point(13, 88)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.Cantidad.TabIndex = 2
        Me.Cantidad.Text = "Cantidad"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.BackColor = System.Drawing.Color.LimeGreen
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(95, 51)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(26, 20)
        Me.txtPrecioUnitario.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.LimeGreen
        Me.txtCantidad.Location = New System.Drawing.Point(95, 81)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(26, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'ckbxDescuento
        '
        Me.ckbxDescuento.AutoSize = True
        Me.ckbxDescuento.Location = New System.Drawing.Point(16, 126)
        Me.ckbxDescuento.Name = "ckbxDescuento"
        Me.ckbxDescuento.Size = New System.Drawing.Size(113, 17)
        Me.ckbxDescuento.TabIndex = 5
        Me.ckbxDescuento.Text = "Aplicar Descuento"
        Me.ckbxDescuento.UseVisualStyleBackColor = True
        '
        'ckbxISV
        '
        Me.ckbxISV.AutoSize = True
        Me.ckbxISV.Location = New System.Drawing.Point(149, 126)
        Me.ckbxISV.Name = "ckbxISV"
        Me.ckbxISV.Size = New System.Drawing.Size(78, 17)
        Me.ckbxISV.TabIndex = 7
        Me.ckbxISV.Text = "Aplicar ISV"
        Me.ckbxISV.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Location = New System.Drawing.Point(315, 58)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(66, 25)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'cbDescuento
        '
        Me.cbDescuento.BackColor = System.Drawing.Color.LimeGreen
        Me.cbDescuento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbDescuento.FormattingEnabled = True
        Me.cbDescuento.Items.AddRange(New Object() {"Descuento por volumen", "Descuento de estudiante", "Descuento de la tercera edad", "Descuento promocional", "Descuento de temporada", "Descuento Particular"})
        Me.cbDescuento.Location = New System.Drawing.Point(16, 149)
        Me.cbDescuento.Name = "cbDescuento"
        Me.cbDescuento.Size = New System.Drawing.Size(105, 21)
        Me.cbDescuento.TabIndex = 10
        '
        'cbISV
        '
        Me.cbISV.BackColor = System.Drawing.Color.LimeGreen
        Me.cbISV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbISV.FormattingEnabled = True
        Me.cbISV.Items.AddRange(New Object() {"15%", "17%"})
        Me.cbISV.Location = New System.Drawing.Point(149, 149)
        Me.cbISV.Name = "cbISV"
        Me.cbISV.Size = New System.Drawing.Size(105, 21)
        Me.cbISV.TabIndex = 11
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.LimeGreen
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Location = New System.Drawing.Point(315, 88)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(66, 25)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(315, 119)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(66, 25)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.Color.LimeGreen
        Me.txtSubtotal.Location = New System.Drawing.Point(66, 21)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(88, 20)
        Me.txtSubtotal.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Descuento"
        '
        'txtDescuento
        '
        Me.txtDescuento.BackColor = System.Drawing.Color.LimeGreen
        Me.txtDescuento.Location = New System.Drawing.Point(66, 47)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(88, 20)
        Me.txtDescuento.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ISV 15%"
        '
        'txtISV15
        '
        Me.txtISV15.BackColor = System.Drawing.Color.LimeGreen
        Me.txtISV15.Location = New System.Drawing.Point(66, 75)
        Me.txtISV15.Name = "txtISV15"
        Me.txtISV15.Size = New System.Drawing.Size(88, 20)
        Me.txtISV15.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.LimeGreen
        Me.txtTotal.Location = New System.Drawing.Point(66, 102)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(88, 20)
        Me.txtTotal.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Precio)
        Me.GroupBox1.Controls.Add(Me.ckbxDescuento)
        Me.GroupBox1.Controls.Add(Me.ckbxISV)
        Me.GroupBox1.Controls.Add(Me.cbDescuento)
        Me.GroupBox1.Controls.Add(Me.cbISV)
        Me.GroupBox1.ForeColor = System.Drawing.Color.LimeGreen
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 209)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtISV15)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.LimeGreen
        Me.GroupBox2.Location = New System.Drawing.Point(12, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 147)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(488, 396)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Precio As Label
    Friend WithEvents Cantidad As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents ckbxDescuento As CheckBox
    Friend WithEvents ckbxISV As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents cbDescuento As ComboBox
    Friend WithEvents cbISV As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtISV15 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Friend WithEvents GroupBox2 As GroupBox

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pUnitario, cantidad As Integer
        Dim descuento, subTotal, total As Double
        Dim aplicarDescuento As Boolean

        If txtPrecioUnitario.Text = "" Or Not IsNumeric(txtPrecioUnitario.Text) Then
            MsgBox("Por favor ingrese un valor numerico en el Precio Unitario", vbInformation)
        End If
        If txtCantidad.Text = "" Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Por favor escriba un valor numerico en Cantidad", vbInformation)
        End If
        If ckbxDescuento.Checked = False And ckbxISV.Checked = False Then
            MsgBox("Por favor escoja una opcion", vbInformation)
        End If

        pUnitario = Val(txtPrecioUnitario.Text)
        cantidad = Val(txtCantidad.Text)

        'chkDescuento.Checked = false
        aplicarDescuento = ckbxDescuento.Checked
        descuento = 0
        subTotal = pUnitario * cantidad
        If aplicarDescuento = True Then
            descuento = subTotal * 0.15
        Else
            descuento = subTotal * 0.17
        End If
        total = subTotal - descuento

        txtSubtotal.Text = subTotal
        txtDescuento.Text = descuento
        txtTotal.Text = total

    End Sub

    Private Sub ckbxDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxDescuento.CheckedChanged
        If ckbxDescuento.Checked = False Then
            cbDescuento.Enabled = False
            ckbxISV.Enabled = True
            cbDescuento.SelectedItem = ""
            txtDescuento.ResetText()

        Else
            cbDescuento.Enabled = True
            cbISV.Enabled = False
            cbISV.SelectedItem = ""
            ckbxISV.Enabled = False
        End If
        If ckbxISV.Checked = False Then
            cbISV.Enabled = False
            ckbxDescuento.Enabled = True
            cbISV.SelectedItem = ""
            txtISV15.ResetText()
        Else
            cbISV.Enabled = True
            cbDescuento.Enabled = False
            cbDescuento.SelectedItem = ""
            ckbxDescuento.Enabled = False
        End If
    End Sub

    Private Sub ckbxISV_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxISV.CheckedChanged
        If ckbxISV.Checked = False Then
            cbISV.Enabled = False
            ckbxDescuento.Enabled = True
            cbISV.SelectedItem = ""
            txtISV15.ResetText()
        Else
            cbISV.Enabled = True
            cbDescuento.Enabled = False
            cbDescuento.SelectedItem = ""
            ckbxDescuento.Enabled = False
        End If
        If ckbxDescuento.Checked = False Then
            cbDescuento.Enabled = False
            ckbxISV.Enabled = True
            cbDescuento.SelectedItem = ""
            txtDescuento.ResetText()
        Else
            cbDescuento.Enabled = True
            cbISV.Enabled = False
            cbISV.SelectedItem = ""
            ckbxISV.Enabled = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantidad.ResetText()
        txtDescuento.ResetText()
        txtISV15.ResetText()
        txtPrecioUnitario.ResetText()
        txtSubtotal.ResetText()
        txtTotal.ResetText()
        ckbxDescuento.ResetText()
        ckbxISV.ResetText()
        cbDescuento.ResetText()
        cbISV.ResetText()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class