Public Class frm_novo_orcamento
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frm_tela_principal.Show()
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_ano.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual
        cmb_meses.DropDownStyle = ComboBoxStyle.DropDownList '  Define o ComboBox para não permitir edição manual
        cmb_mes(cmb_meses) ' Chama a sub rotina para adicionar os meses ao ComboBox
        Dim currentYear As Integer = DateTime.Now.Year ' Pega o ano atual
        Dim yearsBack As Integer = 10 ' quantos anos para trás
        cmb_ano.Items.Clear() ' Limpa os itens existentes no ComboBox

        For y As Integer = currentYear To currentYear - yearsBack Step -1 ' Loop para adicionar os anos no ComboBox 
            cmb_ano.Items.Add(y.ToString())
        Next
        lbl_usuario.Text = usuario_logado ' Exibe o nome do usuário logado no label "usuario"

        ' Personalização dos botões
        AddHandler btn_doc_anteriores.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_doc_anteriores.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_inicio.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_inicio.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_orcamento.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_orcamento.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_sair.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_sair.MouseLeave, AddressOf botao_MouseLeave

        nome_user_global(lbl_usuario)

    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Me.Close()
            frm_login.Show()
        Else
        End If
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Me.Close()
        frm_tela_principal.Show()
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click
        frm_docs_anteriores.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub btn_proximo_Click(sender As Object, e As EventArgs) Handles btn_proximo.Click
        If cmb_meses.Text = "" Or cmb_ano.Text = "" Then ' Verifica se o usuário selecionou um mês e um ano
            MsgBox("Por favor, selecione o mês e o ano para continuar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        mes = cmb_meses.Text ' Armazena o mês selecionado na variável global "mes"
        ano = cmb_ano.Text ' Armazena o ano selecionado na variável global "ano"
        ano = CInt(ano) ' Converte o ano para inteiro
        Me.Close()
        frm_novo_orcamento_tipo.Show()
    End Sub

    Private Sub frm_novo_orcamento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If btn_inicio.Focused Then
            ' Fechar para o formulário inicial
        ElseIf btn_proximo.Focused Then
            ' Fechar para o próximo formulário
        Else
            Application.Exit()
        End If

    End Sub
End Class