<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_doc_anteriores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_doc_anteriores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtg_orc = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_relatorio = New System.Windows.Forms.Button()
        Me.btn_exibir_registros = New System.Windows.Forms.Button()
        Me.btn_data = New System.Windows.Forms.Button()
        Me.btn_alterar_reg = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gravar_alteracoes = New Guna.UI.WinForms.GunaButton()
        Me.btn_voltar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dtg_orc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(663, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orçamentos Realizados"
        '
        'dtg_orc
        '
        Me.dtg_orc.BackgroundColor = System.Drawing.Color.Beige
        Me.dtg_orc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtg_orc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_orc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.usuario, Me.mes, Me.ano, Me.tipo, Me.sub_tipo, Me.descricao, Me.valor})
        Me.dtg_orc.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dtg_orc.Location = New System.Drawing.Point(349, 133)
        Me.dtg_orc.Name = "dtg_orc"
        Me.dtg_orc.RowHeadersWidth = 51
        Me.dtg_orc.Size = New System.Drawing.Size(923, 256)
        Me.dtg_orc.TabIndex = 1
        '
        'id
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'usuario
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.usuario.HeaderText = "USUÁRIO"
        Me.usuario.MinimumWidth = 6
        Me.usuario.Name = "usuario"
        Me.usuario.Width = 125
        '
        'mes
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mes.DefaultCellStyle = DataGridViewCellStyle3
        Me.mes.HeaderText = "MÊS"
        Me.mes.MinimumWidth = 6
        Me.mes.Name = "mes"
        Me.mes.Width = 125
        '
        'ano
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ano.DefaultCellStyle = DataGridViewCellStyle4
        Me.ano.HeaderText = "ANO"
        Me.ano.MinimumWidth = 6
        Me.ano.Name = "ano"
        Me.ano.Width = 125
        '
        'tipo
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle5
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 125
        '
        'sub_tipo
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sub_tipo.DefaultCellStyle = DataGridViewCellStyle6
        Me.sub_tipo.HeaderText = "SUB TIPO"
        Me.sub_tipo.MinimumWidth = 6
        Me.sub_tipo.Name = "sub_tipo"
        Me.sub_tipo.Width = 125
        '
        'descricao
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.descricao.DefaultCellStyle = DataGridViewCellStyle7
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.MinimumWidth = 6
        Me.descricao.Name = "descricao"
        Me.descricao.Width = 125
        '
        'valor
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valor.DefaultCellStyle = DataGridViewCellStyle8
        Me.valor.HeaderText = "VALOR"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.Width = 125
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Location = New System.Drawing.Point(323, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 585)
        Me.Panel2.TabIndex = 7
        '
        'btn_relatorio
        '
        Me.btn_relatorio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_relatorio.BackColor = System.Drawing.Color.White
        Me.btn_relatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_relatorio.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_relatorio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_relatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_relatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_relatorio.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_relatorio.Location = New System.Drawing.Point(10, 449)
        Me.btn_relatorio.Name = "btn_relatorio"
        Me.btn_relatorio.Size = New System.Drawing.Size(308, 85)
        Me.btn_relatorio.TabIndex = 26
        Me.btn_relatorio.Text = "RELATÓRIO"
        Me.btn_relatorio.UseVisualStyleBackColor = True
        '
        'btn_exibir_registros
        '
        Me.btn_exibir_registros.BackColor = System.Drawing.Color.White
        Me.btn_exibir_registros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exibir_registros.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_exibir_registros.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_exibir_registros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_exibir_registros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_exibir_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exibir_registros.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exibir_registros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_exibir_registros.Location = New System.Drawing.Point(10, 174)
        Me.btn_exibir_registros.Name = "btn_exibir_registros"
        Me.btn_exibir_registros.Size = New System.Drawing.Size(308, 85)
        Me.btn_exibir_registros.TabIndex = 22
        Me.btn_exibir_registros.Text = "EXIBIR REGISTROS"
        Me.btn_exibir_registros.UseVisualStyleBackColor = False
        '
        'btn_data
        '
        Me.btn_data.BackColor = System.Drawing.Color.White
        Me.btn_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_data.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_data.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_data.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.btn_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_data.Location = New System.Drawing.Point(10, 358)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(308, 85)
        Me.btn_data.TabIndex = 24
        Me.btn_data.Text = "BUSCAR POR DATA"
        Me.btn_data.UseVisualStyleBackColor = False
        '
        'btn_alterar_reg
        '
        Me.btn_alterar_reg.BackColor = System.Drawing.Color.White
        Me.btn_alterar_reg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alterar_reg.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btn_alterar_reg.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_alterar_reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_alterar_reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_alterar_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alterar_reg.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.btn_alterar_reg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_alterar_reg.Location = New System.Drawing.Point(10, 266)
        Me.btn_alterar_reg.Name = "btn_alterar_reg"
        Me.btn_alterar_reg.Size = New System.Drawing.Size(308, 85)
        Me.btn_alterar_reg.TabIndex = 23
        Me.btn_alterar_reg.Text = "ALTERAR REGISTROS"
        Me.btn_alterar_reg.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "v0.5 - Todos os direitos reservados."
        '
        'gravar_alteracoes
        '
        Me.gravar_alteracoes.AnimationHoverSpeed = 0.07!
        Me.gravar_alteracoes.AnimationSpeed = 0.03!
        Me.gravar_alteracoes.BackColor = System.Drawing.Color.Transparent
        Me.gravar_alteracoes.BaseColor = System.Drawing.Color.White
        Me.gravar_alteracoes.BorderColor = System.Drawing.Color.Black
        Me.gravar_alteracoes.BorderSize = 1
        Me.gravar_alteracoes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gravar_alteracoes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gravar_alteracoes.FocusedColor = System.Drawing.Color.Empty
        Me.gravar_alteracoes.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gravar_alteracoes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.gravar_alteracoes.Image = Nothing
        Me.gravar_alteracoes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.gravar_alteracoes.ImageSize = New System.Drawing.Size(20, 20)
        Me.gravar_alteracoes.Location = New System.Drawing.Point(373, 409)
        Me.gravar_alteracoes.Name = "gravar_alteracoes"
        Me.gravar_alteracoes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.gravar_alteracoes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.gravar_alteracoes.OnHoverForeColor = System.Drawing.Color.White
        Me.gravar_alteracoes.OnHoverImage = Nothing
        Me.gravar_alteracoes.OnPressedColor = System.Drawing.Color.Black
        Me.gravar_alteracoes.Radius = 3
        Me.gravar_alteracoes.Size = New System.Drawing.Size(212, 52)
        Me.gravar_alteracoes.TabIndex = 28
        Me.gravar_alteracoes.Text = "GRAVAR ALTERAÇÕES"
        '
        'btn_voltar
        '
        Me.btn_voltar.AnimationHoverSpeed = 0.07!
        Me.btn_voltar.AnimationSpeed = 0.03!
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BaseColor = System.Drawing.Color.White
        Me.btn_voltar.BorderColor = System.Drawing.Color.Silver
        Me.btn_voltar.BorderSize = 1
        Me.btn_voltar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_voltar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_voltar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_voltar.CheckedImage = Nothing
        Me.btn_voltar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_voltar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_voltar.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_voltar.Image = Nothing
        Me.btn_voltar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_voltar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_voltar.Location = New System.Drawing.Point(1073, 515)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_voltar.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_voltar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_voltar.OnHoverImage = Nothing
        Me.btn_voltar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_voltar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_voltar.Radius = 2
        Me.btn_voltar.Size = New System.Drawing.Size(131, 41)
        Me.btn_voltar.TabIndex = 29
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'form_doc_anteriores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 585)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.gravar_alteracoes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_relatorio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_exibir_registros)
        Me.Controls.Add(Me.btn_data)
        Me.Controls.Add(Me.btn_alterar_reg)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dtg_orc)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_doc_anteriores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentos Anteriores"
        CType(Me.dtg_orc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtg_orc As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents ano As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents sub_tipo As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_relatorio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_exibir_registros As Button
    Friend WithEvents btn_data As Button
    Friend WithEvents btn_alterar_reg As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents gravar_alteracoes As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_voltar As Guna.UI.WinForms.GunaAdvenceButton
End Class
