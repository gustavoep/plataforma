Imports System.Data
Imports System.Data.OleDb
Imports System.IO


Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data


Public Class Form1

    Dim strimgnome As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtTexto.Text.Length = 0 Then
            MsgBox("Por favor, preencha o campo texto para converter para QR Code!", MsgBoxStyle.Information, "Informação")
            txtTexto.Focus()
            Exit Sub
        End If

        Try

            Dim Qrenconder As New QRCodeEncoder()

            Dim Qrcode As Bitmap = Qrenconder.Encode(txtTexto.Text)

            PbImagem.Image = TryCast(Qrcode, Image)


        Catch ex As Exception
            MsgBox("Erro ao converter para QR Code!", MsgBoxStyle.Critical, "ERRO")
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Pegar a imagem da PictureBox, salvar na pasta QRCode e Armazenar na variável strimgnome para gravar no Banco de Dados
        Try

            Dim sfd As New SaveFileDialog()
            sfd.InitialDirectory = "c:\QrCode\"
            sfd.Filter = "PNG | *.png| JPEG| *.jpg | BMP| *.bmp"
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                PbImagem.Image.Save(sfd.FileName)
                strimgnome = sfd.FileName

            End If
        Catch ex As Exception
            MsgBox("Erro ao capturar a imagem da PictureBox" & ex.Message, MsgBoxStyle.Critical, "ERRO")
            Exit Sub
        End Try



        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()

                If strimgnome <> "" Then
                    Dim fs As FileStream
                    fs = New FileStream(strimgnome, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))


                    Dim sql As String = "INSERT INTO tabela1 (matricula,nome,[QRCode]) values (?,?,?)"

                    Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                    cmd.Parameters.Add(New OleDb.OleDbParameter("@matricula", TxtMatricula.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@nome", txtTexto.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@QRCode", OleDbType.Binary, picByte.Length)).Value = picByte

                    cmd.ExecuteNonQuery()
                    MsgBox("Imagem gravada com sucesso!", MsgBoxStyle.Information, "Sucesso")

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_recuperar.Show()
    End Sub

    Private Sub TxtMatricula_TextChanged(sender As Object, e As EventArgs) Handles TxtMatricula.TextChanged

    End Sub

    Private Sub txtTexto_TextChanged(sender As Object, e As EventArgs) Handles txtTexto.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
