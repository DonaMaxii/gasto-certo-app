<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_novo_orcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_novo_orcamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_proximo = New System.Windows.Forms.Button()
        Me.cmb_ano = New Guna.UI.WinForms.GunaComboBox()
        Me.cmb_meses = New Guna.UI.WinForms.GunaComboBox()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(422, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 41)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "NOVO ORÇAMENTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(423, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(389, 34)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Selecione o MÊS do orçamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(423, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 34)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Selecione o ANO do orçamento:"
        '
        'btn_proximo
        '
        Me.btn_proximo.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_proximo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_proximo.FlatAppearance.BorderSize = 0
        Me.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proximo.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_proximo.ForeColor = System.Drawing.Color.White
        Me.btn_proximo.Location = New System.Drawing.Point(983, 575)
        Me.btn_proximo.Name = "btn_proximo"
        Me.btn_proximo.Size = New System.Drawing.Size(220, 75)
        Me.btn_proximo.TabIndex = 31
        Me.btn_proximo.Text = "PRÓXIMO"
        Me.btn_proximo.UseVisualStyleBackColor = False
        '
        'cmb_ano
        '
        Me.cmb_ano.BackColor = System.Drawing.Color.Transparent
        Me.cmb_ano.BaseColor = System.Drawing.Color.White
        Me.cmb_ano.BorderColor = System.Drawing.Color.Silver
        Me.cmb_ano.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_ano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ano.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_ano.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.cmb_ano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmb_ano.FormattingEnabled = True
        Me.cmb_ano.ItemHeight = 35
        Me.cmb_ano.Location = New System.Drawing.Point(886, 336)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_ano.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_ano.Radius = 2
        Me.cmb_ano.Size = New System.Drawing.Size(240, 41)
        Me.cmb_ano.TabIndex = 34
        '
        'cmb_meses
        '
        Me.cmb_meses.BackColor = System.Drawing.Color.Transparent
        Me.cmb_meses.BaseColor = System.Drawing.Color.White
        Me.cmb_meses.BorderColor = System.Drawing.Color.Silver
        Me.cmb_meses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_meses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_meses.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_meses.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.cmb_meses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.ItemHeight = 35
        Me.cmb_meses.Location = New System.Drawing.Point(886, 263)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_meses.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_meses.Radius = 2
        Me.cmb_meses.Size = New System.Drawing.Size(240, 41)
        Me.cmb_meses.TabIndex = 33
        '
        'btn_doc_anteriores
        '
        Me.btn_doc_anteriores.BackColor = System.Drawing.Color.White
        Me.btn_doc_anteriores.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.btn_orcamento.Location = New System.Drawing.Point(6, 274)
        Me.btn_orcamento.Name = "btn_orcamento"
        Me.btn_orcamento.Size = New System.Drawing.Size(308, 100)
        Me.btn_orcamento.TabIndex = 2
        Me.btn_orcamento.Text = "NOVO ORÇAMENTO"
        Me.btn_orcamento.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1056, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 26)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "USUÁRIO ATUAL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lbl_usuario.Location = New System.Drawing.Point(853, 52)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(350, 34)
        Me.lbl_usuario.TabIndex = 42
        Me.lbl_usuario.Text = "<USER>"
        Me.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(969, 561)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'frm_novo_orcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 681)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.cmb_ano)
        Me.Controls.Add(Me.btn_proximo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_meses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_novo_orcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_proximo As Button
    Friend WithEvents cmb_ano As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_meses As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_inicio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
