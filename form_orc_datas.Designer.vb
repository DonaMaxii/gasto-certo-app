<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_orc_datas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_orc_datas))
        Me.dtg_orc_data = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_mes = New System.Windows.Forms.Label()
        Me.txt_ano = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_sair = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_editar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_gravar = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.dtg_orc_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtg_orc_data
        '
        Me.dtg_orc_data.BackgroundColor = System.Drawing.Color.Beige
        Me.dtg_orc_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtg_orc_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_orc_data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.usuario, Me.mes, Me.ano, Me.tipo, Me.sub_tipo, Me.descricao, Me.valor})
        Me.dtg_orc_data.Location = New System.Drawing.Point(70, 145)
        Me.dtg_orc_data.Name = "dtg_orc_data"
        Me.dtg_orc_data.ReadOnly = True
        Me.dtg_orc_data.Size = New System.Drawing.Size(845, 256)
        Me.dtg_orc_data.TabIndex = 2
        '
        'id
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.id.DefaultCellStyle = DataGridViewCellStyle1
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'usuario
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.usuario.HeaderText = "USUÁRIO"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'mes
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mes.DefaultCellStyle = DataGridViewCellStyle3
        Me.mes.HeaderText = "MÊS"
        Me.mes.Name = "mes"
        Me.mes.ReadOnly = True
        '
        'ano
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ano.DefaultCellStyle = DataGridViewCellStyle4
        Me.ano.HeaderText = "ANO"
        Me.ano.Name = "ano"
        Me.ano.ReadOnly = True
        '
        'tipo
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tipo.DefaultCellStyle = DataGridViewCellStyle5
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'sub_tipo
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sub_tipo.DefaultCellStyle = DataGridViewCellStyle6
        Me.sub_tipo.HeaderText = "SUB TIPO"
        Me.sub_tipo.Name = "sub_tipo"
        Me.sub_tipo.ReadOnly = True
        '
        'descricao
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.descricao.DefaultCellStyle = DataGridViewCellStyle7
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        '
        'valor
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.valor.DefaultCellStyle = DataGridViewCellStyle8
        Me.valor.HeaderText = "VALOR"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        '
        'txt_mes
        '
        Me.txt_mes.AutoSize = True
        Me.txt_mes.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_mes.Location = New System.Drawing.Point(480, 49)
        Me.txt_mes.Name = "txt_mes"
        Me.txt_mes.Size = New System.Drawing.Size(73, 41)
        Me.txt_mes.TabIndex = 3
        Me.txt_mes.Text = "Mês"
        '
        'txt_ano
        '
        Me.txt_ano.AutoSize = True
        Me.txt_ano.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txt_ano.Location = New System.Drawing.Point(667, 49)
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(67, 41)
        Me.txt_ano.TabIndex = 4
        Me.txt_ano.Text = "Ano"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(610, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 41)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "de"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 41)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Orçamento -->"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btn_sair
        '
        Me.btn_sair.AnimationHoverSpeed = 0.07!
        Me.btn_sair.AnimationSpeed = 0.03!
        Me.btn_sair.BackColor = System.Drawing.Color.Transparent
        Me.btn_sair.BaseColor = System.Drawing.Color.White
        Me.btn_sair.BorderColor = System.Drawing.Color.Silver
        Me.btn_sair.BorderSize = 1
        Me.btn_sair.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_sair.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_sair.CheckedForeColor = System.Drawing.Color.White
        Me.btn_sair.CheckedImage = Nothing
        Me.btn_sair.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sair.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_sair.FocusedColor = System.Drawing.Color.Empty
        Me.btn_sair.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_sair.Image = Nothing
        Me.btn_sair.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_sair.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_sair.Location = New System.Drawing.Point(784, 440)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_sair.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_sair.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_sair.OnHoverImage = Nothing
        Me.btn_sair.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_sair.OnPressedColor = System.Drawing.Color.Black
        Me.btn_sair.Radius = 3
        Me.btn_sair.Size = New System.Drawing.Size(131, 42)
        Me.btn_sair.TabIndex = 42
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_editar
        '
        Me.btn_editar.AnimationHoverSpeed = 0.07!
        Me.btn_editar.AnimationSpeed = 0.03!
        Me.btn_editar.BackColor = System.Drawing.Color.Transparent
        Me.btn_editar.BaseColor = System.Drawing.Color.White
        Me.btn_editar.BorderColor = System.Drawing.Color.Silver
        Me.btn_editar.BorderSize = 1
        Me.btn_editar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_editar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_editar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_editar.CheckedImage = Nothing
        Me.btn_editar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_editar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_editar.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.btn_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_editar.Image = Nothing
        Me.btn_editar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_editar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_editar.Location = New System.Drawing.Point(101, 440)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_editar.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_editar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_editar.OnHoverImage = Nothing
        Me.btn_editar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_editar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_editar.Radius = 3
        Me.btn_editar.Size = New System.Drawing.Size(131, 42)
        Me.btn_editar.TabIndex = 43
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_gravar
        '
        Me.btn_gravar.AnimationHoverSpeed = 0.07!
        Me.btn_gravar.AnimationSpeed = 0.03!
        Me.btn_gravar.BackColor = System.Drawing.Color.Transparent
        Me.btn_gravar.BaseColor = System.Drawing.Color.White
        Me.btn_gravar.BorderColor = System.Drawing.Color.Silver
        Me.btn_gravar.BorderSize = 1
        Me.btn_gravar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_gravar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_gravar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_gravar.CheckedImage = Nothing
        Me.btn_gravar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gravar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_gravar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_gravar.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.btn_gravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_gravar.Image = Nothing
        Me.btn_gravar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_gravar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_gravar.Location = New System.Drawing.Point(261, 440)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_gravar.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_gravar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_gravar.OnHoverImage = Nothing
        Me.btn_gravar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_gravar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_gravar.Radius = 3
        Me.btn_gravar.Size = New System.Drawing.Size(131, 42)
        Me.btn_gravar.TabIndex = 44
        Me.btn_gravar.Text = "GRAVAR"
        Me.btn_gravar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'form_orc_datas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(983, 515)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ano)
        Me.Controls.Add(Me.txt_mes)
        Me.Controls.Add(Me.dtg_orc_data)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_orc_datas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orçamento por DATA"
        CType(Me.dtg_orc_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtg_orc_data As DataGridView
    Friend WithEvents txt_mes As Label
    Friend WithEvents txt_ano As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents mes As DataGridViewTextBoxColumn
    Friend WithEvents ano As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents sub_tipo As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents btn_sair As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_editar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_gravar As Guna.UI.WinForms.GunaAdvenceButton
End Class
