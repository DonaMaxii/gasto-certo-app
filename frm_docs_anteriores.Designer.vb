<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_docs_anteriores
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_docs_anteriores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exibir_registros = New System.Windows.Forms.Button()
        Me.btn_data = New System.Windows.Forms.Button()
        Me.btn_alterar_reg = New System.Windows.Forms.Button()
        Me.dtg_orc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_valor = New Guna.UI.WinForms.GunaLabel()
        Me.img_simbolo = New Guna.UI.WinForms.GunaLabel()
        Me.cmb_selecao_receita_despesa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dtg_orc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(350, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECEITAS E DESPESAS REGISTRADAS:"
        '
        'btn_exibir_registros
        '
        Me.btn_exibir_registros.BackColor = System.Drawing.Color.White
        Me.btn_exibir_registros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exibir_registros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_exibir_registros.FlatAppearance.BorderSize = 0
        Me.btn_exibir_registros.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_exibir_registros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_exibir_registros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_exibir_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exibir_registros.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_exibir_registros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_exibir_registros.Location = New System.Drawing.Point(14, 89)
        Me.btn_exibir_registros.Name = "btn_exibir_registros"
        Me.btn_exibir_registros.Size = New System.Drawing.Size(394, 100)
        Me.btn_exibir_registros.TabIndex = 22
        Me.btn_exibir_registros.Text = "EXIBIR REGISTROS"
        Me.btn_exibir_registros.UseVisualStyleBackColor = False
        '
        'btn_data
        '
        Me.btn_data.BackColor = System.Drawing.Color.White
        Me.btn_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_data.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_data.FlatAppearance.BorderSize = 0
        Me.btn_data.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_data.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_data.Location = New System.Drawing.Point(418, 89)
        Me.btn_data.Margin = New System.Windows.Forms.Padding(15)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(394, 100)
        Me.btn_data.TabIndex = 24
        Me.btn_data.Text = "BUSCAR POR DATA"
        Me.btn_data.UseVisualStyleBackColor = False
        '
        'btn_alterar_reg
        '
        Me.btn_alterar_reg.BackColor = System.Drawing.Color.White
        Me.btn_alterar_reg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alterar_reg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_alterar_reg.FlatAppearance.BorderSize = 0
        Me.btn_alterar_reg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_alterar_reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_alterar_reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_alterar_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alterar_reg.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_alterar_reg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_alterar_reg.Location = New System.Drawing.Point(820, 89)
        Me.btn_alterar_reg.Margin = New System.Windows.Forms.Padding(15)
        Me.btn_alterar_reg.Name = "btn_alterar_reg"
        Me.btn_alterar_reg.Size = New System.Drawing.Size(394, 100)
        Me.btn_alterar_reg.TabIndex = 23
        Me.btn_alterar_reg.Text = "ALTERAR REGISTROS"
        Me.btn_alterar_reg.UseVisualStyleBackColor = False
        '
        'dtg_orc
        '
        Me.dtg_orc.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtg_orc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_orc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtg_orc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_orc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.usuario, Me.mes, Me.ano, Me.tipo, Me.sub_tipo, Me.descricao, Me.valor})
        Me.dtg_orc.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dtg_orc.Location = New System.Drawing.Point(22, 229)
        Me.dtg_orc.Name = "dtg_orc"
        Me.dtg_orc.RowHeadersWidth = 51
        Me.dtg_orc.Size = New System.Drawing.Size(1182, 304)
        Me.dtg_orc.TabIndex = 1
        '
        'id
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        Me.id.DefaultCellStyle = DataGridViewCellStyle17
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'usuario
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usuario.DefaultCellStyle = DataGridViewCellStyle18
        Me.usuario.HeaderText = "USUÁRIO"
        Me.usuario.MinimumWidth = 6
        Me.usuario.Name = "usuario"
        Me.usuario.Width = 125
        '
        'mes
        '
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mes.DefaultCellStyle = DataGridViewCellStyle19
        Me.mes.HeaderText = "MÊS"
        Me.mes.MinimumWidth = 6
        Me.mes.Name = "mes"
        Me.mes.Width = 125
        '
        'ano
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ano.DefaultCellStyle = DataGridViewCellStyle20
        Me.ano.HeaderText = "ANO"
        Me.ano.MinimumWidth = 6
        Me.ano.Name = "ano"
        Me.ano.Width = 125
        '
        'tipo
        '
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle21
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 125
        '
        'sub_tipo
        '
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sub_tipo.DefaultCellStyle = DataGridViewCellStyle22
        Me.sub_tipo.HeaderText = "SUB TIPO"
        Me.sub_tipo.MinimumWidth = 6
        Me.sub_tipo.Name = "sub_tipo"
        Me.sub_tipo.Width = 125
        '
        'descricao
        '
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        Me.descricao.DefaultCellStyle = DataGridViewCellStyle23
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.MinimumWidth = 6
        Me.descricao.Name = "descricao"
        Me.descricao.Width = 125
        '
        'valor
        '
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valor.DefaultCellStyle = DataGridViewCellStyle24
        Me.valor.HeaderText = "VALOR"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_exibir_registros)
        Me.Panel1.Controls.Add(Me.btn_alterar_reg)
        Me.Panel1.Controls.Add(Me.btn_data)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1251, 204)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 41)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ALTERAR ORÇAMENTO:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(994, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(12, 572)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(220, 75)
        Me.btn_voltar.TabIndex = 33
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_gravar.Cursor = System.Windows.Forms.Cursors.No
        Me.btn_gravar.FlatAppearance.BorderSize = 0
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_gravar.ForeColor = System.Drawing.Color.White
        Me.btn_gravar.Location = New System.Drawing.Point(992, 572)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(220, 75)
        Me.btn_gravar.TabIndex = 35
        Me.btn_gravar.Text = "GRAVAR"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(978, 558)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 558)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaLinePanel1.Controls.Add(Me.txt_valor)
        Me.GunaLinePanel1.Controls.Add(Me.img_simbolo)
        Me.GunaLinePanel1.LineBottom = 2
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaLinePanel1.LineLeft = 2
        Me.GunaLinePanel1.LineRight = 2
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.LineTop = 2
        Me.GunaLinePanel1.Location = New System.Drawing.Point(443, 558)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(338, 81)
        Me.GunaLinePanel1.TabIndex = 57
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(54, 25)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(94, 34)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "TOTAL:"
        '
        'txt_valor
        '
        Me.txt_valor.AutoSize = True
        Me.txt_valor.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.Location = New System.Drawing.Point(158, 25)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(175, 34)
        Me.txt_valor.TabIndex = 1
        Me.txt_valor.Text = "R$ 00000,00"
        Me.txt_valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'img_simbolo
        '
        Me.img_simbolo.AutoSize = True
        Me.img_simbolo.Font = New System.Drawing.Font("Franklin Gothic Demi", 26.0!)
        Me.img_simbolo.Location = New System.Drawing.Point(12, 20)
        Me.img_simbolo.Name = "img_simbolo"
        Me.img_simbolo.Size = New System.Drawing.Size(38, 41)
        Me.img_simbolo.TabIndex = 2
        Me.img_simbolo.Text = "S"
        '
        'cmb_selecao_receita_despesa
        '
        Me.cmb_selecao_receita_despesa.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_selecao_receita_despesa.FormattingEnabled = True
        Me.cmb_selecao_receita_despesa.Location = New System.Drawing.Point(273, 578)
        Me.cmb_selecao_receita_despesa.Name = "cmb_selecao_receita_despesa"
        Me.cmb_selecao_receita_despesa.Size = New System.Drawing.Size(154, 29)
        Me.cmb_selecao_receita_despesa.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Escolha um tipo:"
        '
        'frm_docs_anteriores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 681)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_selecao_receita_despesa)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.dtg_orc)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_docs_anteriores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Anteriores"
        CType(Me.dtg_orc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_exibir_registros As Button
    Friend WithEvents btn_data As Button
    Friend WithEvents btn_alterar_reg As Button
    Friend WithEvents dtg_orc As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents ano As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents sub_tipo As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents btn_gravar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_valor As Guna.UI.WinForms.GunaLabel
    Friend WithEvents img_simbolo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmb_selecao_receita_despesa As ComboBox
    Friend WithEvents Label3 As Label
End Class
