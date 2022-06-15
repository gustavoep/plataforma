<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ControleToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'ControleToolStripMenuItem
        '
        Me.ControleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrocarSenhaToolStripMenuItem, Me.CadastrarUsuárioToolStripMenuItem, Me.ConsultarUsuárioToolStripMenuItem})
        Me.ControleToolStripMenuItem.Name = "ControleToolStripMenuItem"
        Me.ControleToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ControleToolStripMenuItem.Text = "Controle"
        '
        'TrocarSenhaToolStripMenuItem
        '
        Me.TrocarSenhaToolStripMenuItem.Name = "TrocarSenhaToolStripMenuItem"
        Me.TrocarSenhaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TrocarSenhaToolStripMenuItem.Text = "Trocar senha"
        '
        'CadastrarUsuárioToolStripMenuItem
        '
        Me.CadastrarUsuárioToolStripMenuItem.Name = "CadastrarUsuárioToolStripMenuItem"
        Me.CadastrarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CadastrarUsuárioToolStripMenuItem.Text = "Cadastrar usuário"
        '
        'ConsultarUsuárioToolStripMenuItem
        '
        Me.ConsultarUsuárioToolStripMenuItem.Name = "ConsultarUsuárioToolStripMenuItem"
        Me.ConsultarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ConsultarUsuárioToolStripMenuItem.Text = "Consultar usuário"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(709, 528)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrocarSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
