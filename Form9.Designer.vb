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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_ok = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn_canc = New Guna.UI.WinForms.GunaButton()
        Me.btn_okk = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_meses = New Guna.UI.WinForms.GunaComboBox()
        Me.cmb_ano = New Guna.UI.WinForms.GunaComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escolha a o mês e o ano do orçamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(93, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 26)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Ano:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 26)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Mês:"
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
        'btn_canc
        '
        Me.btn_canc.AnimationHoverSpeed = 0.07!
        Me.btn_canc.AnimationSpeed = 0.03!
        Me.btn_canc.BackColor = System.Drawing.Color.Transparent
        Me.btn_canc.BaseColor = System.Drawing.Color.White
        Me.btn_canc.BorderColor = System.Drawing.Color.Silver
        Me.btn_canc.BorderSize = 1
        Me.btn_canc.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_canc.FocusedColor = System.Drawing.Color.Empty
        Me.btn_canc.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!)
        Me.btn_canc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_canc.Image = Nothing
        Me.btn_canc.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_canc.Location = New System.Drawing.Point(148, 239)
        Me.btn_canc.Name = "btn_canc"
        Me.btn_canc.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_canc.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_canc.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_canc.OnHoverImage = Nothing
        Me.btn_canc.OnPressedColor = System.Drawing.Color.Black
        Me.btn_canc.Radius = 2
        Me.btn_canc.Size = New System.Drawing.Size(121, 42)
        Me.btn_canc.TabIndex = 39
        Me.btn_canc.Text = "CANCELAR"
        Me.btn_canc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_okk
        '
        Me.btn_okk.AnimationHoverSpeed = 0.07!
        Me.btn_okk.AnimationSpeed = 0.03!
        Me.btn_okk.BackColor = System.Drawing.Color.Transparent
        Me.btn_okk.BaseColor = System.Drawing.Color.White
        Me.btn_okk.BorderColor = System.Drawing.Color.Silver
        Me.btn_okk.BorderSize = 1
        Me.btn_okk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_okk.FocusedColor = System.Drawing.Color.Empty
        Me.btn_okk.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!)
        Me.btn_okk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_okk.Image = Nothing
        Me.btn_okk.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_okk.Location = New System.Drawing.Point(275, 239)
        Me.btn_okk.Name = "btn_okk"
        Me.btn_okk.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btn_okk.OnHoverBorderColor = System.Drawing.Color.Silver
        Me.btn_okk.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_okk.OnHoverImage = Nothing
        Me.btn_okk.OnPressedColor = System.Drawing.Color.Black
        Me.btn_okk.Radius = 2
        Me.btn_okk.Size = New System.Drawing.Size(113, 42)
        Me.btn_okk.TabIndex = 40
        Me.btn_okk.Text = "OK"
        Me.btn_okk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'cmb_meses
        '
        Me.cmb_meses.BackColor = System.Drawing.Color.Transparent
        Me.cmb_meses.BaseColor = System.Drawing.Color.White
        Me.cmb_meses.BorderColor = System.Drawing.Color.Silver
        Me.cmb_meses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_meses.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_meses.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.cmb_meses.ForeColor = System.Drawing.Color.Black
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(148, 129)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_meses.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_meses.Size = New System.Drawing.Size(240, 30)
        Me.cmb_meses.TabIndex = 41
        '
        'cmb_ano
        '
        Me.cmb_ano.BackColor = System.Drawing.Color.Transparent
        Me.cmb_ano.BaseColor = System.Drawing.Color.White
        Me.cmb_ano.BorderColor = System.Drawing.Color.Silver
        Me.cmb_ano.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ano.FocusedColor = System.Drawing.Color.Empty
        Me.cmb_ano.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 14.25!)
        Me.cmb_ano.ForeColor = System.Drawing.Color.Black
        Me.cmb_ano.FormattingEnabled = True
        Me.cmb_ano.Location = New System.Drawing.Point(146, 189)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cmb_ano.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_ano.Size = New System.Drawing.Size(121, 30)
        Me.cmb_ano.TabIndex = 42
        '
        'form_buscar_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 321)
        Me.Controls.Add(Me.cmb_ano)
        Me.Controls.Add(Me.cmb_meses)
        Me.Controls.Add(Me.btn_okk)
        Me.Controls.Add(Me.btn_canc)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_buscar_data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de orçamentos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cancelar As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_ok As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn_canc As Guna.UI.WinForms.GunaButton
    Friend WithEvents btn_okk As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmb_meses As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_ano As Guna.UI.WinForms.GunaComboBox
End Class
