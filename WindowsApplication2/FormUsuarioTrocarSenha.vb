Imports System.Data.OleDb


Public Class FormUsuarioTrocarSenha
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ChkMostrarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarSenha.CheckedChanged
        If ChkMostrarSenha.Checked Then
            TxtSenha.PasswordChar = ""
            TxtSenhaNova.PasswordChar = ""
            TxtSenhaNova2.PasswordChar = ""
        Else
            TxtSenha.PasswordChar = "*"
            TxtSenhaNova.PasswordChar = "*"
            TxtSenhaNova2.PasswordChar = "*"
        End If
    End Sub

    Private Sub FormUsuarioTrocarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        If ValidarForm() Then
            SalvarSenhaNova()
            MsgBox("Senha alterada!", vbExclamation, sistema)
            Me.Close()
        End If
    End Sub
    Private Function ValidarForm() As Boolean
        Dim result As Boolean

        If Not ValidarSenhaAtual() Then
            MsgBox("Senha atual inválida.", vbExclamation, sistema)
            TxtSenha.Focus()
            result = False
        ElseIf TxtSenhaNova.TextLength < 4 Then
            MsgBox("A nova senha deve ter pelo menos 4 caracteres.", vbExclamation, sistema)
            TxtSenhaNova.Focus()
            result = False
        ElseIf TxtSenhaNova2.Text = "" Then
            MsgBox("Informe novamente a nova senha.", vbExclamation, sistema)
            TxtSenhaNova2.Focus()
            result = False
        ElseIf TxtSenhaNova.Text <> TxtSenhaNova2.Text Then
            MsgBox("A primeira digitação da nova senha não coincide com a segunda digitação.", vbExclamation, sistema)
            TxtSenhaNova.Focus()
            result = False
        Else
            result = True
        End If
        Return result
    End Function



    Private Sub SalvarSenhaNova()
        Dim sql = ("UPDATE Usuarios SET senha=@senha WHERE id=" & pIdUsuario)

        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()
                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@senha", TxtSenhaNova.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, sistema)
        End Try
    End Sub

    Private Function ValidarSenhaAtual()
        Dim sql = "Select senha from Usuarios Where id=@id"
        Dim result As Boolean

        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()

                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", pIdUsuario)

                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                If TxtSenha.Text = dr("Senha") Then
                                    result = True
                                Else
                                    result = False
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, sistema)
            result = False
        End Try

        Return result
    End Function
End Class