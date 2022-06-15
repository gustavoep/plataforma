<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarioConsulta
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(781, 482)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.Location = New System.Drawing.Point(109, 544)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(200, 23)
        Me.BtnAdicionar.TabIndex = 1
        Me.BtnAdicionar.Text = "Adicionar"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        Me.BtnAdicionar.Visible = False
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.Location = New System.Drawing.Point(539, 544)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(200, 23)
        Me.BtnAlterar.TabIndex = 2
        Me.BtnAlterar.Text = "Alterar"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        Me.BtnAlterar.Visible = False
        '
        'FormUsuarioConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 581)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormUsuarioConsulta"
        Me.Text = "FormUsuarioConsulta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents BtnAlterar As Button
End Class
