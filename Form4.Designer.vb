<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_inicio = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_orcamento = New System.Windows.Forms.Button()
        Me.btn_doc_anteriores = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_proximo = New System.Windows.Forms.Button()
        Me.usuario = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_ano = New Guna.UI.WinForms.GunaComboBox()
        Me.cmb_meses = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel1.TabIndex = 24
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(580, 562)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(595, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Gasto Certo APP v.0.1 | Desenvolvido por Maxine ""DonaMaxi"" Santos e Rafael Olivei" &
    "ra."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Faça seu orçamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Selecione o mês do orçamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 26)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Selecione o ano do orçamento:"
        '
        'btn_proximo
        '
        Me.btn_proximo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_proximo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proximo.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.btn_proximo.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btn_proximo.Location = New System.Drawing.Point(463, 303)
        Me.btn_proximo.Name = "btn_proximo"
        Me.btn_proximo.Size = New System.Drawing.Size(131, 41)
        Me.btn_proximo.TabIndex = 31
        Me.btn_proximo.Text = "PRÓXIMO"
        Me.btn_proximo.UseVisualStyleBackColor = False
        '
        'usuario
        '
        Me.usuario.AutoSize = True
        Me.usuario.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Location = New System.Drawing.Point(1057, 40)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(54, 21)
        Me.usuario.TabIndex = 33
        Me.usuario.Text = "Usuario"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmb_ano)
        Me.Panel2.Controls.Add(Me.cmb_meses)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.btn_proximo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(428, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 367)
        Me.Panel2.TabIndex = 35
        '
        'cmb_ano
        '
        Me.cmb_ano.BackColor = System.Drawing.Color.Transparent
        Me.cmb_ano.BaseColor = System.Drawing.Color.White
        Me.cmb_ano.BorderColor = System.Drawing.Color.Silver
        Me.cmb_ano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ano.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_ano.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ano.ForeColor = System.Drawing.Color.Black
        Me.cmb_ano.FormattingEnabled = True
        Me.cmb_ano.Location = New System.Drawing.Point(354, 220)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_ano.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_ano.Radius = 2
        Me.cmb_ano.Size = New System.Drawing.Size(240, 27)
        Me.cmb_ano.TabIndex = 34
        '
        'cmb_meses
        '
        Me.cmb_meses.BackColor = System.Drawing.Color.Transparent
        Me.cmb_meses.BaseColor = System.Drawing.Color.White
        Me.cmb_meses.BorderColor = System.Drawing.Color.Silver
        Me.cmb_meses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_meses.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_meses.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_meses.ForeColor = System.Drawing.Color.Black
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(354, 151)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_meses.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_meses.Radius = 2
        Me.cmb_meses.Size = New System.Drawing.Size(240, 30)
        Me.cmb_meses.TabIndex = 33
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
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.usuario)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1235, 80)
        Me.Panel4.TabIndex = 36
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Gasto_certo.My.Resources.Resources.icons8_close_window_40
        Me.PictureBox4.Location = New System.Drawing.Point(1158, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox4.TabIndex = 34
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
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 627)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_orcamento As Button
    Friend WithEvents btn_doc_anteriores As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_proximo As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents usuario As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_inicio As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmb_ano As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_meses As Guna.UI.WinForms.GunaComboBox
End Class
