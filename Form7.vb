Public Class form_inserir_receita
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        form_tipo_orcamento.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_box_tipo.Items.Add("Salário") ' Adiciona os tipos de receitas ao ComboBox
        cmb_box_tipo.Items.Add("Freelance")
        cmb_box_tipo.Items.Add("Investimentos")
        cmb_box_tipo.Items.Add("Presente")
        cmb_box_tipo.Items.Add("Outros Rendimentos")
        cmb_box_tipo.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair do programa
        If resp = vbYes Then
            Form1.Close()
        Else
        End If
    End Sub

    Private Sub usuario_Click(sender As Object, e As EventArgs) Handles usuario.Click

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
            Me.Close()
            form_tipo_orcamento.Show()
        Catch ex As Exception
            MsgBox("Erro ao registrar a receita!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click
        Me.Close()
        form_doc_anteriores.Show()
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Me.Close()
        form_tela_princ_prot.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Me.Close()
            Form1.Show()
        Else
        End If
    End Sub


    Private Sub txt_valor_receita_TextChanged(sender As Object, e As EventArgs) Handles txt_valor_receita.TextChanged

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

    Private Sub cmb_box_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_box_tipo.SelectedIndexChanged

    End Sub

    Private Sub cmb_box_tipo_LostFocus(sender As Object, e As EventArgs) Handles cmb_box_tipo.LostFocus

    End Sub

    Private Sub cmb_box_tipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_box_tipo.SelectedValueChanged
        txt_valor_receita.Focus()

    End Sub
End Class