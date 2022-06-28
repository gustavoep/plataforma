<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_recuperar
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
        Me.BtnRecuperar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.PbImagem = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        CType(Me.PbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRecuperar
        '
        Me.BtnRecuperar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecuperar.Location = New System.Drawing.Point(21, 359)
        Me.BtnRecuperar.Name = "BtnRecuperar"
        Me.BtnRecuperar.Size = New System.Drawing.Size(211, 27)
        Me.BtnRecuperar.TabIndex = 13
        Me.BtnRecuperar.Text = "Buscar"
        Me.BtnRecuperar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ID do Laboratório"
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMatricula.Location = New System.Drawing.Point(21, 317)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(210, 23)
        Me.TxtMatricula.TabIndex = 11
        '
        'PbImagem
        '
        Me.PbImagem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PbImagem.Location = New System.Drawing.Point(21, 12)
        Me.PbImagem.Name = "PbImagem"
        Me.PbImagem.Size = New System.Drawing.Size(211, 204)
        Me.PbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbImagem.TabIndex = 10
        Me.PbImagem.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Código da amostra"
        '
        'txtTexto
        '
        Me.txtTexto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(21, 254)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(210, 23)
        Me.txtTexto.TabIndex = 14
        '
        'Form_recuperar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 424)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.BtnRecuperar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMatricula)
        Me.Controls.Add(Me.PbImagem)
        Me.Name = "Form_recuperar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar QR Code"
        CType(Me.PbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRecuperar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents PbImagem As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTexto As System.Windows.Forms.TextBox
End Class
