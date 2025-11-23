Imports System.Reflection.Emit

Public Class frm_nova_receita
    Private fecharPorBotao As Boolean = False ' Variável para controlar se o formulário foi fechado por um botão específico
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        fecharPorBotao = True
        frm_novo_orcamento_tipo.Show()
        Me.Close()
    End Sub


    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_box_tipo.Items.Add("Salário") ' Adiciona os tipos de receitas ao ComboBox
        cmb_box_tipo.Items.Add("Freelance")
        cmb_box_tipo.Items.Add("Investimentos")
        cmb_box_tipo.Items.Add("Presente")
        cmb_box_tipo.Items.Add("Outros Rendimentos")
        cmb_box_tipo.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual

        AddHandler btn_doc_anteriores.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_doc_anteriores.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_inicio.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_inicio.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_orcamento.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_orcamento.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_sair.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_sair.MouseLeave, AddressOf botao_MouseLeave


        ' Evento para desenhar o tooltip
        AddHandler ToolTip1.Draw, Sub(s, eArgs)
                                      Dim fonteGrande As New Font("Franklin Gothic Demi", 18, FontStyle.Regular)
                                      eArgs.Graphics.FillRectangle(Brushes.BlanchedAlmond, eArgs.Bounds)
                                      eArgs.Graphics.DrawRectangle(Pens.Blue, eArgs.Bounds)
                                      eArgs.Graphics.DrawString(eArgs.ToolTipText, fonteGrande, Brushes.Black, eArgs.Bounds)
                                  End Sub

        'Balõezinhos de ajuda
        ToolTip1.SetToolTip(Label1, "informe o tipo de receita, p.ex. salário recebido ou pagamento por serviço prestado.")
        ToolTip1.SetToolTip(cmb_box_tipo, "informe o tipo de receita, p.ex. salário recebido ou pagamento por serviço prestado.")
        ToolTip1.SetToolTip(Label2, "Informe o valor do lançamento, p.ex. R$ 1520,00")
        ToolTip1.SetToolTip(txt_valor_receita, "Informe o valor do lançamento, p.ex. R$ 1520,00")
        ToolTip1.SetToolTip(Label13, "Insira uma desscrição breve do lançamento, p. ex. 'Salário referente ao mês de agosto'.")
        ToolTip1.SetToolTip(txt_valor_descricao_receita, "Insira uma desscrição breve do lançamento, p. ex. 'Salário referente ao mês de agosto'.")
        nome_user_global(lbl_usuario)
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair do programa
        If resp = vbYes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub usuario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_valor_receita.Text = "" Or cmb_box_tipo.Text = "" Then ' Verifica se o usuário preencheu todos os campos
            MsgBox("Por favor, preencha o tipo e o valor da receita.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        If Not IsNumeric(txt_valor_receita.Text) Then ' Verifica se o valor inserido é numérico
            MsgBox("Por favor, insira um valor numérico válido para a receita.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            txt_valor_receita.Clear()
            txt_valor_receita.Focus()
            Exit Sub
        End If
        ' Armazena os valores inseridos nas variáveis globais
        receita_valor = txt_valor_receita.Text
        receita_valor = CDbl(receita_valor) ' Converte o valor para Double
        receita_tipo = cmb_box_tipo.Text
        receita_descricao = txt_valor_descricao_receita.Text
        Dim receita = "Receita"
        Try
            ' Força o formato do número com ponto decimal (invariante)
            Dim valorTexto As String = txt_valor_receita.Text.Trim()

            ' Substitui vírgula por ponto
            valorTexto = valorTexto.Replace(",", ".") ' Substitui vírgula por ponto

            ' Converte para Double usando InvariantCulture
            Dim valorSQL As Double = Double.Parse(valorTexto, System.Globalization.CultureInfo.InvariantCulture)

            sql = "INSERT INTO orcamentos (usuario, mes, ano, sub_tipo, tipo, descricao, valor) VALUES ('" &
      usuario_logado & "', '" & mes & "', '" & ano & "', '" & receita_tipo & "', '" & receita & "', '" &
      receita_descricao & "', " & valorSQL.ToString(System.Globalization.CultureInfo.InvariantCulture) & ")"


            rs = db.Execute(sql)
            MsgBox("Receita registrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            fecharPorBotao = True
            frm_novo_orcamento_tipo.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao registrar a receita!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click
        frm_docs_anteriores.Show()
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        fecharPorBotao = True
        frm_tela_principal.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            fecharPorBotao = True
            frm_login.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub txt_valor_descricao_receita_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_valor_descricao_receita.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_registrar.PerformClick()
        End If
    End Sub
    Private Sub txt_valor_receita_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_valor_receita.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_valor_descricao_receita.Focus()
        End If
    End Sub

    Private Sub frm_nova_receita_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If fecharPorBotao Then
        Else
            MsgBox("Encerrando o programa.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Application.Exit()

        End If
    End Sub
End Class