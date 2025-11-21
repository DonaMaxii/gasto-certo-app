<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_nova_despesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_nova_despesa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_valor_descricao_gasto = New System.Windows.Forms.TextBox()
        Me.cmb_box_tipo = New Guna.UI.WinForms.GunaComboBox()
        Me.txt_valor_gasto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_orcamento)
        Me.Panel1.Controls.Add(Me.btn_doc_anteriores)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 684)
        Me.Panel1.TabIndex = 40
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btn_inicio
        '
        Me.btn_inicio.BackColor = System.Drawing.Color.White
        Me.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inicio.FlatAppearance.BorderSize = 0
        Me.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicio.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_inicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_inicio.Location = New System.Drawing.Point(6, 170)
        Me.btn_inicio.Name = "btn_inicio"
        Me.btn_inicio.Size = New System.Drawing.Size(308, 100)
        Me.btn_inicio.TabIndex = 25
        Me.btn_inicio.Text = "INICIO"
        Me.btn_inicio.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.White
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.FlatAppearance.BorderSize = 0
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(6, 573)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(308, 100)
        Me.btn_sair.TabIndex = 24
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'btn_orcamento
        '
        Me.btn_orcamento.BackColor = System.Drawing.Color.White
        Me.btn_orcamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_orcamento.FlatAppearance.BorderSize = 0
        Me.btn_orcamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_orcamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orcamento.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_orcamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_orcamento.Location = New System.Drawing.Point(6, 275)
        Me.btn_orcamento.Name = "btn_orcamento"
        Me.btn_orcamento.Size = New System.Drawing.Size(308, 100)
        Me.btn_orcamento.TabIndex = 2
        Me.btn_orcamento.Text = "NOVO ORÇAMENTO"
        Me.btn_orcamento.UseVisualStyleBackColor = False
        '
        'btn_doc_anteriores
        '
        Me.btn_doc_anteriores.BackColor = System.Drawing.Color.White
        Me.btn_doc_anteriores.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_doc_anteriores.FlatAppearance.BorderSize = 0
        Me.btn_doc_anteriores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_doc_anteriores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_doc_anteriores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_doc_anteriores.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_doc_anteriores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_doc_anteriores.Location = New System.Drawing.Point(6, 380)
        Me.btn_doc_anteriores.Name = "btn_doc_anteriores"
        Me.btn_doc_anteriores.Size = New System.Drawing.Size(308, 100)
        Me.btn_doc_anteriores.TabIndex = 3
        Me.btn_doc_anteriores.Text = "DOCUMENTOS ANTERIORES"
        Me.btn_doc_anteriores.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(343, 582)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(15)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(220, 75)
        Me.btn_voltar.TabIndex = 47
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_registrar.FlatAppearance.BorderSize = 0
        Me.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_registrar.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_registrar.ForeColor = System.Drawing.Color.White
        Me.btn_registrar.Location = New System.Drawing.Point(980, 582)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(15)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(220, 75)
        Me.btn_registrar.TabIndex = 44
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(495, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(567, 41)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "INSERIR NOVO GASTO / DESPESA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(496, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(596, 24)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Por exemplo, contas de luz, gás ou água, telefone celular, aluguel, etc."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(494, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(264, 34)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Descrição (opcional):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(884, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 34)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Valor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(494, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 34)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Tipo:"
        '
        'txt_valor_descricao_gasto
        '
        Me.txt_valor_descricao_gasto.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic)
        Me.txt_valor_descricao_gasto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_valor_descricao_gasto.Location = New System.Drawing.Point(500, 382)
        Me.txt_valor_descricao_gasto.Name = "txt_valor_descricao_gasto"
        Me.txt_valor_descricao_gasto.Size = New System.Drawing.Size(547, 32)
        Me.txt_valor_descricao_gasto.TabIndex = 61
        '
        'cmb_box_tipo
        '
        Me.cmb_box_tipo.BackColor = System.Drawing.Color.Transparent
        Me.cmb_box_tipo.BaseColor = System.Drawing.Color.White
        Me.cmb_box_tipo.BorderColor = System.Drawing.Color.Silver
        Me.cmb_box_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_box_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_box_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_box_tipo.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_box_tipo.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic)
        Me.cmb_box_tipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmb_box_tipo.FormattingEnabled = True
        Me.cmb_box_tipo.ItemHeight = 28
        Me.cmb_box_tipo.Location = New System.Drawing.Point(500, 269)
        Me.cmb_box_tipo.Name = "cmb_box_tipo"
        Me.cmb_box_tipo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_box_tipo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_box_tipo.Size = New System.Drawing.Size(315, 34)
        Me.cmb_box_tipo.TabIndex = 62
        '
        'txt_valor_gasto
        '
        Me.txt_valor_gasto.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.2!, System.Drawing.FontStyle.Italic)
        Me.txt_valor_gasto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_valor_gasto.Location = New System.Drawing.Point(890, 271)
        Me.txt_valor_gasto.Name = "txt_valor_gasto"
        Me.txt_valor_gasto.Size = New System.Drawing.Size(157, 32)
        Me.txt_valor_gasto.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1065, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 26)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "USUÁRIO ATUAL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lbl_usuario.Location = New System.Drawing.Point(862, 47)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(350, 34)
        Me.lbl_usuario.TabIndex = 64
        Me.lbl_usuario.Text = "<USER>"
        Me.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(966, 568)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox3.TabIndex = 66
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(329, 568)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox2.TabIndex = 65
        Me.PictureBox2.TabStop = False
        '
        'Frm_nova_despesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_valor_descricao_gasto)
        Me.Controls.Add(Me.cmb_box_tipo)
        Me.Controls.Add(Me.txt_valor_gasto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_nova_despesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto Certo App - Inserir Gasto"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_inicio As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_valor_descricao_gasto As TextBox
    Friend WithEvents cmb_box_tipo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txt_valor_gasto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
