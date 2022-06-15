Imports System.Data.OleDb


Public Class FormUsuarioConsulta
    Private Sub FormUsuarioConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pAdministrador Then
            BtnAdicionar.Visible = True
            BtnAlterar.Visible = True
        End If
        MostrarUsuarios()
        ConfigurarGrade()
    End Sub

    Private Sub ConfigurarGrade()
        With DataGridView1
            .Columns("Id").Visible = False

            .Columns("login").HeaderText = "Nome de login"
            .Columns("login").Width = 120

            .Columns("nome").HeaderText = "Nome pessoal"
            .Columns("nome").Width = 200

            .Columns("email").HeaderText = "Email"
            .Columns("email").Width = 200

            .Columns("administrador").HeaderText = "Adm"
            .Columns("administrador").Width = 50
            .Columns("administrador").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("administrador").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("ativo").HeaderText = "Ativo"
            .Columns("ativo").Width = 50
            .Columns("ativo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("ativo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub MostrarUsuarios()
        Try
            Using cn = New OleDbConnection(conn)
                cn.Open()

                Dim sql = "Select id, login, nome, email, administrador, ativo from Usuarios Order by Login"

                Using da = New OleDbDataAdapter(sql, cn)
                    Using dt = New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Falha ao tentar conectar" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        With DataGridView1
            pId = .Rows(.CurrentCell.RowIndex).Cells("Id").Value
        End With
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        FormUsuarioCadastro.Show()
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        pId = 0
        FormUsuarioCadastro.Show()
    End Sub
End Class