<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.txtMulti = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtDivi = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor 2"
        '
        'txtValor1
        '
        Me.txtValor1.BackColor = System.Drawing.Color.LightCoral
        Me.txtValor1.Location = New System.Drawing.Point(80, 29)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(62, 20)
        Me.txtValor1.TabIndex = 2
        '
        'txtValor2
        '
        Me.txtValor2.BackColor = System.Drawing.Color.LightCoral
        Me.txtValor2.Location = New System.Drawing.Point(80, 62)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(62, 20)
        Me.txtValor2.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.MistyRose
        Me.btnCalcular.Location = New System.Drawing.Point(165, 45)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(56, 25)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Salmon
        Me.Label3.Location = New System.Drawing.Point(161, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Suma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Multiplicacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Resta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Division"
        '
        'txtSuma
        '
        Me.txtSuma.BackColor = System.Drawing.Color.RosyBrown
        Me.txtSuma.Location = New System.Drawing.Point(80, 128)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(62, 20)
        Me.txtSuma.TabIndex = 10
        '
        'txtMulti
        '
        Me.txtMulti.BackColor = System.Drawing.Color.RosyBrown
        Me.txtMulti.Location = New System.Drawing.Point(113, 157)
        Me.txtMulti.Name = "txtMulti"
        Me.txtMulti.Size = New System.Drawing.Size(62, 20)
        Me.txtMulti.TabIndex = 11
        '
        'txtResta
        '
        Me.txtResta.BackColor = System.Drawing.Color.RosyBrown
        Me.txtResta.Location = New System.Drawing.Point(227, 127)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(62, 20)
        Me.txtResta.TabIndex = 12
        '
        'txtDivi
        '
        Me.txtDivi.BackColor = System.Drawing.Color.RosyBrown
        Me.txtDivi.Location = New System.Drawing.Point(249, 157)
        Me.txtDivi.Name = "txtDivi"
        Me.txtDivi.Size = New System.Drawing.Size(62, 20)
        Me.txtDivi.TabIndex = 13
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.MistyRose
        Me.btnSalir.Location = New System.Drawing.Point(165, 195)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 25)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 288)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtDivi)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtMulti)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Cuatro Operaciones Matematicas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents txtMulti As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtDivi As TextBox
    Friend WithEvents btnSalir As Button
End Class
