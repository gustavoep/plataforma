Imports System.Data
Imports System.Data.OleDb
Imports System.IO


Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data

Public Class Form_recuperar

    Private Sub Form_recuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRecuperar_Click(sender As Object, e As EventArgs) Handles BtnRecuperar.Click

        Dim dr As OleDbDataReader = Nothing


        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()

                Dim sql As String = "SELECT nome, QrCode FROM tabela1 where matricula= " & TxtMatricula.Text
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()


                    txtTexto.Text = dr.Item("nome")

                    If PbImagem.Image IsNot Nothing Then
                        PbImagem.Image.Dispose()
                    End If



                    Dim fsmagem As New FileStream("image.jpg", FileMode.Create)
                    Dim blob As Byte() = DirectCast(dr.Item("QrCode"), Byte())

                    fsmagem.Write(blob, 0, blob.Length)
                    fsmagem.Close()
                    fsmagem = Nothing

                    PbImagem.Image = Image.FromFile("image.jpg")
                    PbImagem.Refresh()

                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using


    End Sub
End Class