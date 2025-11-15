<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relatorio
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
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mes_busca = New Guna.UI.WinForms.GunaComboBox()
        Me.ano_busca = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.dtg_relatorio = New System.Windows.Forms.DataGridView()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_gerar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txt_saldo = New System.Windows.Forms.Label()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dtg_relatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(300, 37)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(135, 30)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "RELATORIO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 108)
        Me.Panel1.TabIndex = 1
        '
        'mes_busca
        '
        Me.mes_busca.BackColor = System.Drawing.Color.Transparent
        Me.mes_busca.BaseColor = System.Drawing.Color.White
        Me.mes_busca.BorderColor = System.Drawing.Color.Silver
        Me.mes_busca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mes_busca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.mes_busca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mes_busca.FocusedColor = System.Drawing.Color.Empty
        Me.mes_busca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mes_busca.ForeColor = System.Drawing.Color.Black
        Me.mes_busca.FormattingEnabled = True
        Me.mes_busca.Location = New System.Drawing.Point(213, 181)
        Me.mes_busca.Name = "mes_busca"
        Me.mes_busca.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mes_busca.OnHoverItemForeColor = System.Drawing.Color.White
        Me.mes_busca.Radius = 2
        Me.mes_busca.Size = New System.Drawing.Size(121, 26)
        Me.mes_busca.TabIndex = 2
        '
        'ano_busca
        '
        Me.ano_busca.BackColor = System.Drawing.Color.Transparent
        Me.ano_busca.BaseColor = System.Drawing.Color.White
        Me.ano_busca.BorderColor = System.Drawing.Color.Silver
        Me.ano_busca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ano_busca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ano_busca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ano_busca.FocusedColor = System.Drawing.Color.Empty
        Me.ano_busca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ano_busca.ForeColor = System.Drawing.Color.Black
        Me.ano_busca.FormattingEnabled = True
        Me.ano_busca.Location = New System.Drawing.Point(369, 181)
        Me.ano_busca.Name = "ano_busca"
        Me.ano_busca.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ano_busca.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ano_busca.Radius = 2
        Me.ano_busca.Size = New System.Drawing.Size(121, 26)
        Me.ano_busca.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(208, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mês:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(364, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ano:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(70, 693)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(91, 30)
        Me.GunaLabel2.TabIndex = 6
        Me.GunaLabel2.Text = "SALDO:"
        '
        'dtg_relatorio
        '
        Me.dtg_relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_relatorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mes, Me.ano, Me.tipo, Me.sub_tipo, Me.descricao, Me.valor})
        Me.dtg_relatorio.Location = New System.Drawing.Point(36, 251)
        Me.dtg_relatorio.Name = "dtg_relatorio"
        Me.dtg_relatorio.Size = New System.Drawing.Size(643, 407)
        Me.dtg_relatorio.TabIndex = 7
        '
        'mes
        '
        Me.mes.HeaderText = "MÊS"
        Me.mes.Name = "mes"
        '
        'ano
        '
        Me.ano.HeaderText = "ANO"
        Me.ano.Name = "ano"
        '
        'tipo
        '
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.Name = "tipo"
        '
        'sub_tipo
        '
        Me.sub_tipo.HeaderText = "sub_tipo"
        Me.sub_tipo.Name = "sub_tipo"
        '
        'descricao
        '
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.Name = "descricao"
        '
        'valor
        '
        Me.valor.HeaderText = "VALOR"
        Me.valor.Name = "valor"
        '
        'btn_gerar
        '
        Me.btn_gerar.AnimationHoverSpeed = 0.07!
        Me.btn_gerar.AnimationSpeed = 0.03!
        Me.btn_gerar.BackColor = System.Drawing.Color.Transparent
        Me.btn_gerar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_gerar.BorderColor = System.Drawing.Color.Black
        Me.btn_gerar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_gerar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_gerar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_gerar.CheckedImage = Nothing
        Me.btn_gerar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_gerar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_gerar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_gerar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_gerar.ForeColor = System.Drawing.Color.White
        Me.btn_gerar.Image = Nothing
        Me.btn_gerar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_gerar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_gerar.Location = New System.Drawing.Point(495, 181)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_gerar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_gerar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_gerar.OnHoverImage = Nothing
        Me.btn_gerar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_gerar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_gerar.Radius = 2
        Me.btn_gerar.Size = New System.Drawing.Size(52, 26)
        Me.btn_gerar.TabIndex = 8
        Me.btn_gerar.Text = "GERAR"
        '
        'txt_saldo
        '
        Me.txt_saldo.AutoSize = True
        Me.txt_saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_saldo.Location = New System.Drawing.Point(167, 696)
        Me.txt_saldo.Name = "txt_saldo"
        Me.txt_saldo.Size = New System.Drawing.Size(87, 25)
        Me.txt_saldo.TabIndex = 9
        Me.txt_saldo.Text = "R$ 0.00"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.BorderSize = 1
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(438, 697)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 2
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(68, 26)
        Me.GunaAdvenceButton1.TabIndex = 10
        Me.GunaAdvenceButton1.Text = "IMPRIMIR"
        '
        'GunaAdvenceButton2
        '
        Me.GunaAdvenceButton2.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton2.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton2.BaseColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.BorderSize = 1
        Me.GunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.CheckedImage = Nothing
        Me.GunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Image = Nothing
        Me.GunaAdvenceButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.Location = New System.Drawing.Point(622, 697)
        Me.GunaAdvenceButton2.Name = "GunaAdvenceButton2"
        Me.GunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton2.OnHoverImage = Nothing
        Me.GunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton2.Radius = 2
        Me.GunaAdvenceButton2.Size = New System.Drawing.Size(68, 26)
        Me.GunaAdvenceButton2.TabIndex = 11
        Me.GunaAdvenceButton2.Text = "SAIR"
        Me.GunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'form_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 744)
        Me.Controls.Add(Me.GunaAdvenceButton2)
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.txt_saldo)
        Me.Controls.Add(Me.btn_gerar)
        Me.Controls.Add(Me.dtg_relatorio)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ano_busca)
        Me.Controls.Add(Me.mes_busca)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "form_relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtg_relatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mes_busca As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents ano_busca As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dtg_relatorio As DataGridView
    Friend WithEvents btn_gerar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents ano As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents sub_tipo As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents txt_saldo As Label
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton2 As Guna.UI.WinForms.GunaAdvenceButton
End Class
