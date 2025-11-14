<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_cadastro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.visualizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.visualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(596, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(596, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome de usuário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(596, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha de usuário:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic)
        Me.txt_usuario.Location = New System.Drawing.Point(596, 202)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(329, 32)
        Me.txt_usuario.TabIndex = 0
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic)
        Me.txt_senha.Location = New System.Drawing.Point(596, 272)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(296, 32)
        Me.txt_senha.TabIndex = 1
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic)
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(596, 348)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(329, 32)
        Me.txt_confirmar_senha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(596, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Confirme a senha:"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_cadastrar.Location = New System.Drawing.Point(751, 411)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(172, 49)
        Me.btn_cadastrar.TabIndex = 4
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_voltar.Location = New System.Drawing.Point(65, 488)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(125, 45)
        Me.btn_voltar.TabIndex = 10
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'visualizar
        '
        Me.visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.visualizar.Image = CType(resources.GetObject("visualizar.Image"), System.Drawing.Image)
        Me.visualizar.Location = New System.Drawing.Point(896, 273)
        Me.visualizar.Name = "visualizar"
        Me.visualizar.Size = New System.Drawing.Size(27, 29)
        Me.visualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.visualizar.TabIndex = 14
        Me.visualizar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(88, 106)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 41)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Franklin Gothic Book", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(88, 176)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(349, 293)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = "Nesta tela, você irá cadastrar suas credenciais para entrar no sistema." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Isso gar" &
    "ante a segurança dos seus dados, e permite que só você tenha acesso!"
        '
        'form_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1011, 586)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.visualizar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto Certo APP | CADASTRO DE NOVO USUÁRIO"
        CType(Me.visualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents visualizar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
