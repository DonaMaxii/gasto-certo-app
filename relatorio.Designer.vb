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
        Me.cmb_meses = New Guna.UI.WinForms.GunaComboBox()
        Me.cmb_ano = New Guna.UI.WinForms.GunaComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(151, 38)
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
        Me.Panel1.Size = New System.Drawing.Size(440, 108)
        Me.Panel1.TabIndex = 1
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
        Me.cmb_meses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_meses.ForeColor = System.Drawing.Color.Black
        Me.cmb_meses.FormattingEnabled = True
        Me.cmb_meses.Location = New System.Drawing.Point(75, 181)
        Me.cmb_meses.Name = "cmb_meses"
        Me.cmb_meses.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_meses.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_meses.Radius = 2
        Me.cmb_meses.Size = New System.Drawing.Size(121, 26)
        Me.cmb_meses.TabIndex = 2
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
        Me.cmb_ano.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_ano.ForeColor = System.Drawing.Color.Black
        Me.cmb_ano.FormattingEnabled = True
        Me.cmb_ano.Location = New System.Drawing.Point(249, 181)
        Me.cmb_ano.Name = "cmb_ano"
        Me.cmb_ano.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_ano.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmb_ano.Radius = 2
        Me.cmb_ano.Size = New System.Drawing.Size(121, 26)
        Me.cmb_ano.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(70, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mês:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(244, 148)
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo, Me.descricao, Me.sub_tipo, Me.valor})
        Me.DataGridView1.Location = New System.Drawing.Point(36, 251)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(373, 407)
        Me.DataGridView1.TabIndex = 7
        '
        'tipo
        '
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Visible = False
        '
        'descricao
        '
        Me.descricao.HeaderText = "DESCRIÇÃO"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        Me.descricao.Visible = False
        '
        'sub_tipo
        '
        Me.sub_tipo.HeaderText = "SUB TIPO"
        Me.sub_tipo.Name = "sub_tipo"
        Me.sub_tipo.ReadOnly = True
        Me.sub_tipo.Visible = False
        '
        'valor
        '
        Me.valor.HeaderText = "VALOR"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Visible = False
        '
        'form_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 744)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_ano)
        Me.Controls.Add(Me.cmb_meses)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "form_relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmb_meses As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmb_ano As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents sub_tipo As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
End Class
