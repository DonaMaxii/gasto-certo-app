<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_inserir_receita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_inserir_receita))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_valor_descricao_receita = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_valor_receita = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_box_tipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.btn_orcamento)
        Me.Panel1.Controls.Add(Me.btn_doc_anteriores)
        Me.Panel1.Location = New System.Drawing.Point(0, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 640)
        Me.Panel1.TabIndex = 25
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
        Me.btn_inicio.TabIndex = 25
        Me.btn_inicio.Text = "INICIO"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!)
        Me.Button4.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Button4.Location = New System.Drawing.Point(-2, 596)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(297, 42)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "SAIR"
        Me.Button4.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btn_voltar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_registrar)
        Me.Panel2.Location = New System.Drawing.Point(428, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 367)
        Me.Panel2.TabIndex = 36
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txt_valor_descricao_receita)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txt_valor_receita)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.cmb_box_tipo)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(209, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(226, 206)
        Me.Panel4.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(117, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "(Opcional)"
        '
        'txt_valor_descricao_receita
        '
        Me.txt_valor_descricao_receita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_valor_descricao_receita.Location = New System.Drawing.Point(39, 152)
        Me.txt_valor_descricao_receita.Name = "txt_valor_descricao_receita"
        Me.txt_valor_descricao_receita.Size = New System.Drawing.Size(136, 26)
        Me.txt_valor_descricao_receita.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 24)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Descrição:"
        '
        'txt_valor_receita
        '
        Me.txt_valor_receita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_valor_receita.Location = New System.Drawing.Point(38, 98)
        Me.txt_valor_receita.Name = "txt_valor_receita"
        Me.txt_valor_receita.Size = New System.Drawing.Size(136, 26)
        Me.txt_valor_receita.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Valor:"
        '
        'cmb_box_tipo
        '
        Me.cmb_box_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_box_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_box_tipo.FormattingEnabled = True
        Me.cmb_box_tipo.Location = New System.Drawing.Point(37, 33)
        Me.cmb_box_tipo.Name = "cmb_box_tipo"
        Me.cmb_box_tipo.Size = New System.Drawing.Size(138, 28)
        Me.cmb_box_tipo.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tipo:"
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_voltar.Location = New System.Drawing.Point(38, 303)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(131, 41)
        Me.btn_voltar.TabIndex = 36
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(35, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Por exemplo:salários, pensões, rendimentos, etc."
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(26, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 45)
        Me.Panel3.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Inserir nova receita:"
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_registrar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_registrar.Location = New System.Drawing.Point(463, 303)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(134, 41)
        Me.btn_registrar.TabIndex = 31
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(1057, 40)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(54, 21)
        Me.usuario.TabIndex = 39
        Me.usuario.Text = "Usuario"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Controls.Add(Me.usuario)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Location = New System.Drawing.Point(0, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1235, 80)
        Me.Panel5.TabIndex = 41
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Gasto_certo.My.Resources.Resources.icons8_close_window_40
        Me.PictureBox4.Location = New System.Drawing.Point(1158, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox4.TabIndex = 40
        Me.PictureBox4.TabStop = False
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1107, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(558, 562)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(595, 21)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Gasto Certo APP v.0.1 | Desenvolvido por Maxine ""DonaMaxi"" Santos e Rafael Olivei" &
    "ra."
        '
        'form_inserir_receita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 627)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_inserir_receita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto Certo App - Inserir receitas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_inicio As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_valor_descricao_receita As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_valor_receita As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_box_tipo As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents usuario As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
End Class
