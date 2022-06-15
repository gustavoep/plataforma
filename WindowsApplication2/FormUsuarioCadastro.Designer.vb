<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarioCadastro
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkAdministrador = New System.Windows.Forms.CheckBox()
        Me.ChkAtivo = New System.Windows.Forms.CheckBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome de login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Senha"
        '
        'ChkAdministrador
        '
        Me.ChkAdministrador.AutoSize = True
        Me.ChkAdministrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdministrador.Location = New System.Drawing.Point(129, 242)
        Me.ChkAdministrador.Name = "ChkAdministrador"
        Me.ChkAdministrador.Size = New System.Drawing.Size(114, 21)
        Me.ChkAdministrador.TabIndex = 5
        Me.ChkAdministrador.Text = "Administrador"
        Me.ChkAdministrador.UseVisualStyleBackColor = True
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAtivo.Location = New System.Drawing.Point(347, 242)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(58, 21)
        Me.ChkAtivo.TabIndex = 6
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Location = New System.Drawing.Point(129, 280)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(276, 52)
        Me.BtnSalvar.TabIndex = 7
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(129, 24)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(100, 23)
        Me.LblID.TabIndex = 8
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(129, 65)
        Me.TxtLogin.MaxLength = 15
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(276, 20)
        Me.TxtLogin.TabIndex = 9
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(129, 108)
        Me.TxtNome.MaxLength = 70
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(276, 20)
        Me.TxtNome.TabIndex = 10
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(129, 155)
        Me.TxtEmail.MaxLength = 70
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(276, 20)
        Me.TxtEmail.TabIndex = 11
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(129, 203)
        Me.TxtSenha.MaxLength = 30
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(276, 20)
        Me.TxtSenha.TabIndex = 12
        '
        'FormUsuarioCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 362)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.ChkAtivo)
        Me.Controls.Add(Me.ChkAdministrador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUsuarioCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de clientes - SensorGreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkAdministrador As CheckBox
    Friend WithEvents ChkAtivo As CheckBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents LblID As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtSenha As TextBox
End Class
