Imports System.Data.OleDb


Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        If Not ValidarUsuario() Then
            MsgBox("Usuário ou senha inválidos ou usuário inativo.", vbExclamation, sistema)
        Else
            Me.Close()
        End If
    End Sub

    Private Function ValidarUsuario() As Boolean
        Dim sql = "Select * from Usuarios where login=@login AND senha=@senha"
        Dim result = False

        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()

                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@login", TxtLogin.Text)
                    cmd.Parameters.AddWithValue("@senha", TxtSenha.Text)

                    Using dr = cmd.ExecuteReader()

                        If dr.HasRows Then
                            If dr.Read() Then
                                pIdUsuario = dr("id")
                                pNomeUsuario = dr("login")
                                pAdministrador = IIf(dr("administrador") = "S", True, False)
                                If dr("ativo") = "S" Then
                                    pAcessoPermitido = True
                                    result = True
                                Else
                                    pAcessoPermitido = False
                                    result = False

                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha: " & ex.Message, vbExclamation, sistema)
        End Try
        Return result

    End Function

    Private Sub TxtSenha_TextChanged(sender As Object, e As EventArgs) Handles TxtSenha.TextChanged

    End Sub
End Class