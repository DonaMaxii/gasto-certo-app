<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_tipo_orcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_tipo_orcamento))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.usuario = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_inserir_receitas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_finalizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_valor = New Guna.UI.WinForms.GunaLabel()
        Me.img_simbolo = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.btn_orcamento)
        Me.Panel1.Controls.Add(Me.btn_doc_anteriores)
        Me.Panel1.Location = New System.Drawing.Point(0, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 640)
        Me.Panel1.TabIndex = 0
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
        Me.btn_sair.TabIndex = 29
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
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
        Me.btn_inicio.TabIndex = 28
        Me.btn_inicio.Text = "INICIO"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'btn_orcamento
        '
        Me.btn_orcamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_orcamento.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orcamento.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.2!)
        Me.btn_orcamento.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_orcamento.Location = New System.Drawing.Point(-4, 217)
        Me.btn_orcamento.Name = "btn_orcamento"
        Me.btn_orcamento.Size = New System.Drawing.Size(297, 46)
        Me.btn_orcamento.TabIndex = 26
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
        Me.btn_doc_anteriores.TabIndex = 27
        Me.btn_doc_anteriores.Text = "DOCUMENTOS ANTERIORES"
        Me.btn_doc_anteriores.UseVisualStyleBackColor = False
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
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Gasto_certo.My.Resources.Resources.icons8_close_window_40
        Me.PictureBox4.Location = New System.Drawing.Point(1158, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(1057, 40)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(54, 21)
        Me.usuario.TabIndex = 36
        Me.usuario.Text = "Usuario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1107, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.btn_voltar)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_inserir_receitas)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_finalizar)
        Me.Panel2.Location = New System.Drawing.Point(428, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 367)
        Me.Panel2.TabIndex = 38
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
        Me.btn_voltar.TabIndex = 35
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.Button1.Location = New System.Drawing.Point(219, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 46)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "GASTOS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_inserir_receitas
        '
        Me.btn_inserir_receitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_inserir_receitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inserir_receitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inserir_receitas.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inserir_receitas.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_inserir_receitas.Location = New System.Drawing.Point(219, 131)
        Me.btn_inserir_receitas.Name = "btn_inserir_receitas"
        Me.btn_inserir_receitas.Size = New System.Drawing.Size(222, 46)
        Me.btn_inserir_receitas.TabIndex = 33
        Me.btn_inserir_receitas.Text = "RECEITAS"
        Me.btn_inserir_receitas.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(26, 19)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 45)
        Me.Panel3.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Escolha o tipo de orçamento:"
        '
        'btn_finalizar
        '
        Me.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_finalizar.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_finalizar.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_finalizar.Location = New System.Drawing.Point(463, 303)
        Me.btn_finalizar.Name = "btn_finalizar"
        Me.btn_finalizar.Size = New System.Drawing.Size(131, 41)
        Me.btn_finalizar.TabIndex = 31
        Me.btn_finalizar.Text = "FINALIZAR"
        Me.btn_finalizar.UseVisualStyleBackColor = False
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
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Gasto Certo APP v.0.1 | Desenvolvido por Maxine ""DonaMaxi"" Santos e Rafael Olivei" &
    "ra."
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.usuario)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1235, 80)
        Me.Panel4.TabIndex = 40
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.img_simbolo)
        Me.Panel5.Controls.Add(Me.txt_valor)
        Me.Panel5.Controls.Add(Me.GunaLabel1)
        Me.Panel5.Location = New System.Drawing.Point(463, 46)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(143, 131)
        Me.Panel5.TabIndex = 36
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(8, 37)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(50, 21)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "TOTAL:"
        '
        'txt_valor
        '
        Me.txt_valor.AutoSize = True
        Me.txt_valor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(54, 36)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(58, 21)
        Me.txt_valor.TabIndex = 1
        Me.txt_valor.Text = "VALOR"
        '
        'img_simbolo
        '
        Me.img_simbolo.AutoSize = True
        Me.img_simbolo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.img_simbolo.Location = New System.Drawing.Point(9, 73)
        Me.img_simbolo.Name = "img_simbolo"
        Me.img_simbolo.Size = New System.Drawing.Size(71, 20)
        Me.img_simbolo.TabIndex = 2
        Me.img_simbolo.Text = "SIMBOLO"
        '
        'form_tipo_orcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 627)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_tipo_orcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto Certo App - Novo Orçamento"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_inicio As Button
    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents usuario As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_inserir_receitas As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents img_simbolo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_valor As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
