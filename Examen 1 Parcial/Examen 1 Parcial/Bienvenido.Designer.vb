<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenido
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.ckbxPositivo = New System.Windows.Forms.CheckBox()
        Me.ckbxNegativo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtxtStatusSalud = New System.Windows.Forms.RichTextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.mktxEdad = New System.Windows.Forms.MaskedTextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbHistorial = New System.Windows.Forms.GroupBox()
        Me.LBHistory = New System.Windows.Forms.ListBox()
        Me.gbCasos = New System.Windows.Forms.GroupBox()
        Me.cmbReporteDepa = New System.Windows.Forms.ComboBox()
        Me.txtRecuperado = New System.Windows.Forms.TextBox()
        Me.txtMuerto = New System.Windows.Forms.TextBox()
        Me.txtActivo = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbDatos.SuspendLayout()
        Me.gbHistorial.SuspendLayout()
        Me.gbCasos.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Municipio"
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombre.Location = New System.Drawing.Point(89, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(109, 20)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.Text = "Ingrese su nombre"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(306, 49)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(112, 20)
        Me.txtMunicipio.TabIndex = 7
        Me.txtMunicipio.Text = "Ingrese su municipio"
        '
        'ckbxPositivo
        '
        Me.ckbxPositivo.AutoSize = True
        Me.ckbxPositivo.Location = New System.Drawing.Point(17, 98)
        Me.ckbxPositivo.Name = "ckbxPositivo"
        Me.ckbxPositivo.Size = New System.Drawing.Size(63, 17)
        Me.ckbxPositivo.TabIndex = 8
        Me.ckbxPositivo.Text = "Positivo"
        Me.ckbxPositivo.UseVisualStyleBackColor = True
        '
        'ckbxNegativo
        '
        Me.ckbxNegativo.AutoSize = True
        Me.ckbxNegativo.Location = New System.Drawing.Point(86, 98)
        Me.ckbxNegativo.Name = "ckbxNegativo"
        Me.ckbxNegativo.Size = New System.Drawing.Size(69, 17)
        Me.ckbxNegativo.TabIndex = 9
        Me.ckbxNegativo.Text = "Negativo"
        Me.ckbxNegativo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Resultado de Prueba"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Descripcion de su estado de salud"
        '
        'rtxtStatusSalud
        '
        Me.rtxtStatusSalud.Location = New System.Drawing.Point(17, 161)
        Me.rtxtStatusSalud.Name = "rtxtStatusSalud"
        Me.rtxtStatusSalud.Size = New System.Drawing.Size(417, 146)
        Me.rtxtStatusSalud.TabIndex = 12
        Me.rtxtStatusSalud.Text = ""
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"Atlantida", "Choluteca", "Colon", "Comayagua", "Copan", "Cortes", "El Paraiso", "Francismo Morazan", "Gracias a Dios", "Intibuca", "Islas de la Bahia", "La Paz", "Lempira", "Ocotepeque", "Olancho", "Santa Barbara", "Valle", "Yoro"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(89, 46)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(141, 21)
        Me.cmbDepartamento.TabIndex = 13
        Me.cmbDepartamento.Text = "Escoga su departamento"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.cmbEstado)
        Me.gbDatos.Controls.Add(Me.mktxEdad)
        Me.gbDatos.Controls.Add(Me.btnEnviar)
        Me.gbDatos.Controls.Add(Me.Label7)
        Me.gbDatos.Controls.Add(Me.cmbDepartamento)
        Me.gbDatos.Controls.Add(Me.rtxtStatusSalud)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.ckbxNegativo)
        Me.gbDatos.Controls.Add(Me.ckbxPositivo)
        Me.gbDatos.Controls.Add(Me.txtMunicipio)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Location = New System.Drawing.Point(22, 11)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(446, 345)
        Me.gbDatos.TabIndex = 14
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Positivo", "Negativo", "Recuperado"})
        Me.cmbEstado.Location = New System.Drawing.Point(215, 96)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstado.TabIndex = 20
        '
        'mktxEdad
        '
        Me.mktxEdad.Location = New System.Drawing.Point(306, 19)
        Me.mktxEdad.Mask = "__"
        Me.mktxEdad.Name = "mktxEdad"
        Me.mktxEdad.Size = New System.Drawing.Size(112, 20)
        Me.mktxEdad.TabIndex = 19
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(193, 313)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 18
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Estado del Paciente"
        '
        'gbHistorial
        '
        Me.gbHistorial.Controls.Add(Me.LBHistory)
        Me.gbHistorial.Location = New System.Drawing.Point(482, 137)
        Me.gbHistorial.Name = "gbHistorial"
        Me.gbHistorial.Size = New System.Drawing.Size(256, 219)
        Me.gbHistorial.TabIndex = 15
        Me.gbHistorial.TabStop = False
        Me.gbHistorial.Text = "Historial"
        '
        'LBHistory
        '
        Me.LBHistory.FormattingEnabled = True
        Me.LBHistory.Location = New System.Drawing.Point(11, 19)
        Me.LBHistory.Name = "LBHistory"
        Me.LBHistory.Size = New System.Drawing.Size(239, 186)
        Me.LBHistory.TabIndex = 0
        '
        'gbCasos
        '
        Me.gbCasos.Controls.Add(Me.cmbReporteDepa)
        Me.gbCasos.Controls.Add(Me.txtRecuperado)
        Me.gbCasos.Controls.Add(Me.txtMuerto)
        Me.gbCasos.Controls.Add(Me.txtActivo)
        Me.gbCasos.Location = New System.Drawing.Point(482, 12)
        Me.gbCasos.Name = "gbCasos"
        Me.gbCasos.Size = New System.Drawing.Size(256, 119)
        Me.gbCasos.TabIndex = 16
        Me.gbCasos.TabStop = False
        Me.gbCasos.Text = "Control de Reportes"
        '
        'cmbReporteDepa
        '
        Me.cmbReporteDepa.FormattingEnabled = True
        Me.cmbReporteDepa.Items.AddRange(New Object() {"Comayagua", "Francisco Morazan"})
        Me.cmbReporteDepa.Location = New System.Drawing.Point(8, 22)
        Me.cmbReporteDepa.Name = "cmbReporteDepa"
        Me.cmbReporteDepa.Size = New System.Drawing.Size(121, 21)
        Me.cmbReporteDepa.TabIndex = 3
        '
        'txtRecuperado
        '
        Me.txtRecuperado.Location = New System.Drawing.Point(73, 53)
        Me.txtRecuperado.Name = "txtRecuperado"
        Me.txtRecuperado.Size = New System.Drawing.Size(58, 20)
        Me.txtRecuperado.TabIndex = 2
        '
        'txtMuerto
        '
        Me.txtMuerto.Location = New System.Drawing.Point(137, 53)
        Me.txtMuerto.Name = "txtMuerto"
        Me.txtMuerto.Size = New System.Drawing.Size(58, 20)
        Me.txtMuerto.TabIndex = 1
        '
        'txtActivo
        '
        Me.txtActivo.Location = New System.Drawing.Point(8, 53)
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.Size = New System.Drawing.Size(59, 20)
        Me.txtActivo.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(393, 373)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Bienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 486)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbCasos)
        Me.Controls.Add(Me.gbHistorial)
        Me.Controls.Add(Me.gbDatos)
        Me.Name = "Bienvenido"
        Me.Text = "Bienvenido"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbHistorial.ResumeLayout(False)
        Me.gbCasos.ResumeLayout(False)
        Me.gbCasos.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents ckbxPositivo As CheckBox
    Friend WithEvents ckbxNegativo As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rtxtStatusSalud As RichTextBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbHistorial As GroupBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents gbCasos As GroupBox
    Friend WithEvents cmbReporteDepa As ComboBox
    Friend WithEvents txtRecuperado As TextBox
    Friend WithEvents txtMuerto As TextBox
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents mktxEdad As MaskedTextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents LBHistory As ListBox
End Class
