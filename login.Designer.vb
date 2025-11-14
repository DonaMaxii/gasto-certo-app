<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Tela = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_logar = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.visualizar = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.visualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Tela
        '
        Me.Tela.AutoSize = True
        Me.Tela.BackColor = System.Drawing.Color.Transparent
        Me.Tela.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Tela.Location = New System.Drawing.Point(598, 128)
        Me.Tela.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Tela.Name = "Tela"
        Me.Tela.Size = New System.Drawing.Size(233, 41)
        Me.Tela.TabIndex = 4
        Me.Tela.Text = "Tela de Login"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(598, 227)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(315, 32)
        Me.txt_user.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(598, 196)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nome do usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(598, 266)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Senha:"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(598, 297)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(283, 32)
        Me.txt_password.TabIndex = 8
        '
        'btn_logar
        '
        Me.btn_logar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btn_logar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_logar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logar.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_logar.Location = New System.Drawing.Point(740, 352)
        Me.btn_logar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_logar.Name = "btn_logar"
        Me.btn_logar.Size = New System.Drawing.Size(172, 49)
        Me.btn_logar.TabIndex = 9
        Me.btn_logar.Text = "ENTRAR"
        Me.btn_logar.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_cadastrar.Location = New System.Drawing.Point(68, 488)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(150, 45)
        Me.btn_cadastrar.TabIndex = 10
        Me.btn_cadastrar.Text = "CADASTRAR"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_sair.Location = New System.Drawing.Point(834, 488)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(109, 45)
        Me.btn_sair.TabIndex = 11
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'visualizar
        '
        Me.visualizar.BackColor = System.Drawing.Color.Transparent
        Me.visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.visualizar.Image = CType(resources.GetObject("visualizar.Image"), System.Drawing.Image)
        Me.visualizar.Location = New System.Drawing.Point(886, 297)
        Me.visualizar.Name = "visualizar"
        Me.visualizar.Size = New System.Drawing.Size(27, 29)
        Me.visualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.visualizar.TabIndex = 12
        Me.visualizar.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(79, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(443, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "O App que te ajuda a controlar suas finanças."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(386, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fácil e intuitivo. "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 176)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(422, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1011, 586)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.visualizar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.btn_logar)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Tela)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto Certo APP | LOGIN"
        CType(Me.visualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Tela As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_logar As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents visualizar As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
