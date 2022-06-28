Imports System.Data.OleDb




Public Class FormUsuarioCadastro
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ChkAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAdministrador.CheckedChanged

    End Sub

    Private Sub ChkAtivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAtivo.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If ValidarForm() Then
            SalvarUsuario()
            LimparForm()
            TxtLogin.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub LimparForm()
        LblID.Text = ""
        TxtLogin.Clear()
        TxtNome.Clear()
        TxtEmail.Clear()
        TxtSenha.Clear()
        ChkAdministrador.Checked = False
        ChkAtivo.Checked = False

    End Sub

    Private Function ValidarForm() As Boolean
        Dim result As Boolean
        If TxtLogin.Text = "" Then
            MsgBox("Informe o nome de login do usuário.", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        ElseIf TxtNome.Text = "" Then
            MsgBox("Informe o nome pessoal.", vbExclamation, sistema)
            TxtNome.Focus()
            result = False
        ElseIf TxtEmail.Text = "" Then
            MsgBox("Informe o email do usuário.", vbExclamation, sistema)
            TxtEmail.Focus()
            result = False
        ElseIf TxtSenha.TextLength < 4 And TxtSenha.Text <> "" Then
            MsgBox("A senha deve ter ao menos 4 caracteres.", vbExclamation, sistema)
            TxtSenha.Focus()
            result = False
        Else
            result = True
        End If
        Return result
    End Function

    Private Sub SalvarUsuario()
        Dim Sql = ""

        If CLng(0 & LblID.Text) = 0 Then
            Sql = "INSERT INTO Usuarios (login, nome, email, senha, administrador, ativo) VALUES(@login, @nome, @email, @senha, @administrador, @ativo)"

        Else
            Sql = ("UPDATE Usuarios SET login=@login, nome=@nome, email=@email, administrador=@administrador, ativo=@ativo WHERE id=" & LblID.Text)
        End If

        Using cn = New OleDbConnection(conn)
            cn.Open()
            Using cmd = New OleDbCommand(Sql, cn)
                cmd.Parameters.AddWithValue("@login", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@nome", TxtNome.Text)
                cmd.Parameters.AddWithValue("@email", TxtEmail.Text)
                cmd.Parameters.AddWithValue("@senha", TxtSenha.Text)
                cmd.Parameters.AddWithValue("@Administrador", IIf(ChkAdministrador.Checked, "S", "N"))
                cmd.Parameters.AddWithValue("@Ativo", IIf(ChkAtivo.Checked, "S", "N"))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub FormUsuarioCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pId > 0 Then
            MostrarUsuario(pId)
        End If
    End Sub

    Private Sub MostrarUsuario(id As Long)
        Dim sql = "Select * from Usuarios Where id=@id"

        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()

                Using cmd = New OleDbCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@id", id)

                    Using dr = cmd.ExecuteReader()
                        If dr.HasRows Then
                            If dr.Read() Then
                                LblID.Text = dr("id")
                                TxtLogin.Text = dr("login")
                                TxtNome.Text = dr("nome")
                                TxtEmail.Text = dr("email")
                                ' TxtSenha.Text = dr("senha")
                                If dr("administrador") = "S" Then
                                    ChkAdministrador.Checked = True
                                Else
                                    ChkAdministrador.Checked = False
                                End If
                                If dr("ativo") = "S" Then
                                    ChkAtivo.Checked = True
                                Else
                                    ChkAtivo.Checked = False
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha:" & ex.Message, vbExclamation, sistema)
        End Try
    End Sub

    Private Sub LblID_Click(sender As Object, e As EventArgs) Handles LblID.Click

    End Sub
End Class