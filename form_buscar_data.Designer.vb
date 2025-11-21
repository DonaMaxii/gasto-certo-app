<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_buscar_data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_buscar_data))
        Me.btn_cancelar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_ok = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cmb_meses = New Guna.UI.WinForms.GunaComboBox()
        Me.cmb_ano = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.AnimationHoverSpeed = 0.07!
        Me.btn_cancelar.AnimationSpeed = 0.03!
        Me.btn_cancelar.BackColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.BaseColor = System.Drawing.Color.White
        Me.btn_cancelar.BorderColor = System.Drawing.Color.Silver
        Me.btn_cancelar.BorderSize = 1
        Me.btn_cancelar.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_cancelar.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_cancelar.CheckedForeColor = System.Drawing.Color.White
        Me.btn_cancelar.CheckedImage = Nothing
        Me.btn_cancelar.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_cancelar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_cancelar.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_cancelar.Image = Nothing
        Me.btn_cancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_cancelar.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(148, 242)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_cancelar.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_cancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_cancelar.OnHoverImage = Nothing
        Me.btn_cancelar.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_cancelar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_cancelar.Radius = 2
        Me.btn_cancelar.Size = New System.Drawing.Size(113, 37)
        Me.btn_cancelar.TabIndex = 39
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ok
        '
        Me.btn_ok.AnimationHoverSpeed = 0.07!
        Me.btn_ok.AnimationSpeed = 0.03!
        Me.btn_ok.BackColor = System.Drawing.Color.Transparent
        Me.btn_ok.BaseColor = System.Drawing.Color.White
        Me.btn_ok.BorderColor = System.Drawing.Color.Silver
        Me.btn_ok.BorderSize = 1
        Me.btn_ok.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_ok.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_ok.CheckedForeColor = System.Drawing.Color.White
        Me.btn_ok.CheckedImage = Nothing
        Me.btn_ok.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_ok.FocusedColor = System.Drawing.Color.Empty
        Me.btn_ok.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!)
        Me.btn_ok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_ok.Image = Nothing
        Me.btn_ok.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_ok.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ok.Location = New System.Drawing.Point(275, 242)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_ok.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_ok.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_ok.OnHoverImage = Nothing
        Me.btn_ok.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_ok.OnPressedColor = System.Drawing.Color.Black
        Me.btn_ok.Radius = 2
        Me.btn_ok.Size = New System.Drawing.Size(113, 37)
        Me.btn_ok.TabIndex = 40
        Me.btn_ok.Text = "OK"
        Me.btn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmb_meses.Location = New System.Drawing.Point(891, 278)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_meses.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_meses.Size = New System.Drawing.Size(240, 33)
        Me.cmb_meses.TabIndex = 41
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
        Me.cmb_ano.Location = New System.Drawing.Point(891, 338)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_ano.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_ano.Size = New System.Drawing.Size(240, 33)
        Me.cmb_ano.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btn_inicio)
        Me.Panel1.Controls.Add(Me.btn_sair)
        Me.Panel1.Controls.Add(Me.btn_orcamento)
        Me.Panel1.Controls.Add(Me.btn_doc_anteriores)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 684)
        Me.Panel1.TabIndex = 43
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
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
        Me.btn_orcamento.Location = New System.Drawing.Point(6, 274)
        Me.btn_orcamento.Name = "btn_orcamento"
        Me.btn_orcamento.Size = New System.Drawing.Size(308, 100)
        Me.btn_orcamento.TabIndex = 2
        Me.btn_orcamento.Text = "NOVO ORÇAMENTO"
        Me.btn_orcamento.UseVisualStyleBackColor = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(441, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 41)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "CONSULTAR ORÇAMENTO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(442, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(385, 34)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Selecione o ANO do orçamento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(442, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(389, 34)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Selecione o MÊS do orçamento:"
        '
        'btn_consultar
        '
        Me.btn_consultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_consultar.FlatAppearance.BorderSize = 0
        Me.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_consultar.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_consultar.ForeColor = System.Drawing.Color.White
        Me.btn_consultar.Location = New System.Drawing.Point(983, 575)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(220, 75)
        Me.btn_consultar.TabIndex = 47
        Me.btn_consultar.Text = "CONSULTAR"
        Me.btn_consultar.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Franklin Gothic Demi", 20.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(352, 575)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(220, 75)
        Me.btn_cancel.TabIndex = 47
        Me.btn_cancel.Text = "CANCELAR"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(338, 561)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(969, 561)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 103)
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'form_buscar_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 681)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_ano)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_meses)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_buscar_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de orçamentos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_ok As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents cmb_meses As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_ano As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_inicio As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_consultar As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
