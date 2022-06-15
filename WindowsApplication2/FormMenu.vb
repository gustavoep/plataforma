Public Class FormMenu
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CadastrarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarUsuárioToolStripMenuItem.Click
        If pAdministrador Then
            FormUsuarioConsulta.Show()
        Else
            MsgBox("Acesso não permitido!", vbExclamation, sistema)
        End If

    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using frm = New FormLogin
            frm.ShowDialog()
            If Not pAcessoPermitido Then
                Application.Exit()
            End If
        End Using
    End Sub

    Private Sub ConsultarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarUsuárioToolStripMenuItem.Click
        FormUsuarioConsulta.Show()
    End Sub

    Private Sub TrocarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrocarSenhaToolStripMenuItem.Click
        FormUsuarioTrocarSenha.Show()
    End Sub
End Class
