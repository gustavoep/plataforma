<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarioTrocarSenha
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
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.TxtSenhaNova = New System.Windows.Forms.TextBox()
        Me.TxtSenhaNova2 = New System.Windows.Forms.TextBox()
        Me.ChkMostrarSenha = New System.Windows.Forms.CheckBox()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Senha atual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nova senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Redigite a nova senha"
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(246, 87)
        Me.TxtSenha.MaxLength = 30
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(241, 20)
        Me.TxtSenha.TabIndex = 3
        '
        'TxtSenhaNova
        '
        Me.TxtSenhaNova.Location = New System.Drawing.Point(246, 145)
        Me.TxtSenhaNova.MaxLength = 30
        Me.TxtSenhaNova.Name = "TxtSenhaNova"
        Me.TxtSenhaNova.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenhaNova.Size = New System.Drawing.Size(241, 20)
        Me.TxtSenhaNova.TabIndex = 4
        '
        'TxtSenhaNova2
        '
        Me.TxtSenhaNova2.Location = New System.Drawing.Point(246, 208)
        Me.TxtSenhaNova2.MaxLength = 30
        Me.TxtSenhaNova2.Name = "TxtSenhaNova2"
        Me.TxtSenhaNova2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenhaNova2.Size = New System.Drawing.Size(241, 20)
        Me.TxtSenhaNova2.TabIndex = 5
        '
        'ChkMostrarSenha
        '
        Me.ChkMostrarSenha.AutoSize = True
        Me.ChkMostrarSenha.Location = New System.Drawing.Point(246, 261)
        Me.ChkMostrarSenha.Name = "ChkMostrarSenha"
        Me.ChkMostrarSenha.Size = New System.Drawing.Size(112, 17)
        Me.ChkMostrarSenha.TabIndex = 6
        Me.ChkMostrarSenha.Text = "Mostrar as senhas"
        Me.ChkMostrarSenha.UseVisualStyleBackColor = True
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Location = New System.Drawing.Point(283, 297)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(186, 39)
        Me.BtnAlterar.TabIndex = 7
        Me.BtnAlterar.Text = "Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'FormUsuarioTrocarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 407)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.ChkMostrarSenha)
        Me.Controls.Add(Me.TxtSenhaNova2)
        Me.Controls.Add(Me.TxtSenhaNova)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormUsuarioTrocarSenha"
        Me.Text = "FormUsuarioTrocarSenha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents TxtSenhaNova As TextBox
    Friend WithEvents TxtSenhaNova2 As TextBox
    Friend WithEvents ChkMostrarSenha As CheckBox
    Friend WithEvents BtnAlterar As Button
End Class
