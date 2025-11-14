<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_tela_princ_prot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_tela_princ_prot))
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nome_user = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usuario = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_qtd_usuarios = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_hora_atual = New System.Windows.Forms.Label()
        Me.txt_saudacao = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_orcamento
        '
        Me.btn_orcamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_orcamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orcamento.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.2!)
        Me.btn_orcamento.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_orcamento.Location = New System.Drawing.Point(-4, 217)
        Me.btn_orcamento.Name = "btn_orcamento"
        Me.btn_orcamento.Size = New System.Drawing.Size(297, 46)
        Me.btn_orcamento.TabIndex = 2
        Me.btn_orcamento.Text = "NOVO ORÇAMENTO"
        Me.btn_orcamento.UseVisualStyleBackColor = False
        '
        'btn_doc_anteriores
        '
        Me.btn_doc_anteriores.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_doc_anteriores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_doc_anteriores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_doc_anteriores.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.2!)
        Me.btn_doc_anteriores.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_doc_anteriores.Location = New System.Drawing.Point(-2, 260)
        Me.btn_doc_anteriores.Name = "btn_doc_anteriores"
        Me.btn_doc_anteriores.Size = New System.Drawing.Size(297, 46)
        Me.btn_doc_anteriores.TabIndex = 3
        Me.btn_doc_anteriores.Text = "DOCUMENTOS ANTERIORES"
        Me.btn_doc_anteriores.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(580, 562)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(595, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Gasto Certo APP v.0.1 | Desenvolvido por Maxine ""DonaMaxi"" Santos e Rafael Olivei" &
    "ra."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_orcamento)
        Me.Panel1.Controls.Add(Me.btn_doc_anteriores)
        Me.Panel1.Location = New System.Drawing.Point(0, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 640)
        Me.Panel1.TabIndex = 23
        '
        'btn_inicio
        '
        Me.btn_inicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.2!)
        Me.btn_inicio.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_inicio.Location = New System.Drawing.Point(-2, 175)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(297, 46)
        Me.btn_inicio.TabIndex = 26
        Me.btn_inicio.Text = "INICIO"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_sair.Location = New System.Drawing.Point(-2, 596)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(297, 42)
        Me.btn_sair.TabIndex = 23
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(601, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 26)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Olá"
        '
        'nome_user
        '
        Me.nome_user.AutoSize = True
        Me.nome_user.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nome_user.Location = New System.Drawing.Point(657, 120)
        Me.nome_user.Name = "nome_user"
        Me.nome_user.Size = New System.Drawing.Size(72, 26)
        Me.nome_user.TabIndex = 25
        Me.nome_user.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(735, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 26)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Seja Bem Vindo ao Sistema"
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(1057, 40)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(54, 21)
        Me.usuario.TabIndex = 29
        Me.usuario.Text = "Usuario"
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Gasto_certo.My.Resources.Resources.icons8_close_window_40
        Me.PictureBox4.Location = New System.Drawing.Point(1158, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1107, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.usuario)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1235, 80)
        Me.Panel2.TabIndex = 32
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(532, 272)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(487, 137)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_qtd_usuarios)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 129)
        Me.Panel3.TabIndex = 0
        '
        'txt_qtd_usuarios
        '
        Me.txt_qtd_usuarios.AutoSize = True
        Me.txt_qtd_usuarios.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_usuarios.Location = New System.Drawing.Point(100, 54)
        Me.txt_qtd_usuarios.Name = "txt_qtd_usuarios"
        Me.txt_qtd_usuarios.Size = New System.Drawing.Size(97, 37)
        Me.txt_qtd_usuarios.TabIndex = 1
        Me.txt_qtd_usuarios.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Usuários no sistema:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(613, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(330, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Gerêncie suas finâncias de forma simplificada"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_saudacao)
        Me.Panel4.Controls.Add(Me.txt_hora_atual)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(247, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(236, 129)
        Me.Panel4.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Hora Atual:"
        '
        'txt_hora_atual
        '
        Me.txt_hora_atual.AutoSize = True
        Me.txt_hora_atual.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hora_atual.Location = New System.Drawing.Point(88, 54)
        Me.txt_hora_atual.Name = "txt_hora_atual"
        Me.txt_hora_atual.Size = New System.Drawing.Size(94, 26)
        Me.txt_hora_atual.TabIndex = 2
        Me.txt_hora_atual.Text = "Hora Atual"
        '
        'txt_saudacao
        '
        Me.txt_saudacao.AutoSize = True
        Me.txt_saudacao.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_saudacao.Location = New System.Drawing.Point(76, 90)
        Me.txt_saudacao.Name = "txt_saudacao"
        Me.txt_saudacao.Size = New System.Drawing.Size(92, 26)
        Me.txt_saudacao.TabIndex = 3
        Me.txt_saudacao.Text = "Saudação"
        '
        'form_tela_princ_prot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 627)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nome_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_tela_princ_prot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Principal - MENU"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents nome_user As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents usuario As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_inicio As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_qtd_usuarios As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_saudacao As Label
    Friend WithEvents txt_hora_atual As Label
    Friend WithEvents Label6 As Label
End Class
