<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orçamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orçamento))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_meses = New System.Windows.Forms.ComboBox()
        Me.cmb_ano = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tela = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(150, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selecione o mês do orçamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(150, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(337, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selecione o ano do orçamento:"
        '
        'cmb_meses
        '
        Me.cmb_meses.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(613, 243)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.Size = New System.Drawing.Size(240, 36)
        Me.cmb_meses.TabIndex = 4
        '
        'cmb_ano
        '
        Me.cmb_ano.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.2!)
        Me.cmb_ano.FormattingEnabled = True
        Me.cmb_ano.Location = New System.Drawing.Point(732, 303)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.Size = New System.Drawing.Size(121, 36)
        Me.cmb_ano.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(65, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SAIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Demi", 16.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(790, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "PRÓXIMO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(677, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 41)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Tela
        '
        Me.Tela.AutoSize = True
        Me.Tela.BackColor = System.Drawing.Color.Transparent
        Me.Tela.Font = New System.Drawing.Font("Franklin Gothic Heavy", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Tela.Location = New System.Drawing.Point(65, 62)
        Me.Tela.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Tela.Name = "Tela"
        Me.Tela.Size = New System.Drawing.Size(288, 41)
        Me.Tela.TabIndex = 19
        Me.Tela.Text = "Novo Orçamento"
        '
        'orçamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1011, 586)
        Me.Controls.Add(Me.Tela)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_ano)
        Me.Controls.Add(Me.cmb_meses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "orçamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gasto Certo APP | NOVO ORÇAMENTO | MÊS E ANO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_meses As ComboBox
    Friend WithEvents cmb_ano As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Tela As Label
End Class
