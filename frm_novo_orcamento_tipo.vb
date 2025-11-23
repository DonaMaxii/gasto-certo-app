Imports System.Drawing.Text

Public Class frm_novo_orcamento_tipo
    Private fecharPorBotao As Boolean = False ' Variável para controlar se o formulário foi fechado por um botão específico
    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        resp = MsgBox("Deseja ir para o menu principal?" & vbNewLine & "Todas as alterações não salvas serão perdidas.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SAIR")
        If resp = vbYes Then
            mes = ""
            ano = ""
            Me.Close()
            frm_tela_principal.Show()
        End If
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click ' Abre o formulário de documentos anteriores
        frm_docs_anteriores.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair do programa
        If resp = vbYes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair da conta
        If resp = vbYes Then
            fecharPorBotao = True
            frm_login.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btn_orcamento_Click(sender As Object, e As EventArgs) Handles btn_orcamento.Click
        resp = MsgBox("Deseja sair para o menu anterior?" & vbNewLine & "Todas as alterações não salvas serão perdidas.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SAIR")
        If resp = vbYes Then
            mes = ""
            ano = ""
            fecharPorBotao = True
            frm_novo_orcamento.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        fecharPorBotao = True
        frm_novo_orcamento.Show()
        Me.Close()
    End Sub

    Private Sub btn_inserir_receitas_Click(sender As Object, e As EventArgs) Handles btn_inserir_receitas.Click
        fecharPorBotao = True
        frm_nova_receita.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fecharPorBotao = True
        Frm_nova_despesa.Show()
        Me.Close()
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        MsgBox("Orçamento finalizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        fecharPorBotao = True
        frm_tela_principal.Show()
        Me.Close()
    End Sub


    Private Sub frm_novo_orcamento_tipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' img_simbolo.Text = "▲" ' Carrega o símbolo de alerta
        Try
            receita = 0
            sql = $"SELECT SUM(valor) AS total FROM orcamentos WHERE usuario='{usuario_logado}' AND mes='{mes}' AND ano='{ano}' AND tipo='Receita'"
            rs = db.Execute(sql)
            If Not rs.EOF And Not IsDBNull(rs.Fields("total").Value) Then ' Verifica se o recordset não está vazio e se o valor não é nulo
                receita = Convert.ToDecimal(rs.Fields("total").Value) ' Converte o valor para decimal e atribui à variável receita
            End If
        Catch ex As Exception
            MsgBox("Erro ao calcular receita!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

        Try
            despesa = 0
            sql = $"SELECT SUM(valor) AS total FROM orcamentos WHERE usuario='{usuario_logado}' AND mes='{mes}' AND ano='{ano}' AND tipo='Gasto'" ' Consulta SQL para somar os valores dos gastos
            rs = db.Execute(sql)
            If Not rs.EOF And Not IsDBNull(rs.Fields("total").Value) Then ' Verifica se o recordset não está vazio e se o valor não é nulo
                despesa = Convert.ToDecimal(rs.Fields("total").Value) ' Converte o valor para decimal e atribui à variável despesa
            End If
        Catch ex As Exception
            MsgBox("Erro ao calcular despesa!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

        calc_receita_despesa = receita - despesa
        If calc_receita_despesa < 0 Then
            txt_valor.ForeColor = Color.FromArgb(255, 48, 97) ' Define a cor do texto como vermelho para valores negativos
        Else
            txt_valor.ForeColor = Color.FromArgb(48, 180, 72) ' Define a cor do texto como verde para valores positivos
        End If
        txt_valor.Text = $"R$ {calc_receita_despesa.ToString("F2")}" ' Formata o valor com duas casas decimais e atribui ao TextBox

        If calc_receita_despesa < 0 Then
            img_simbolo.Text = "▼"
            img_simbolo.ForeColor = Color.FromArgb(255, 48, 97)
        Else
            img_simbolo.Text = "▲"
            img_simbolo.ForeColor = Color.FromArgb(48, 180, 72)
        End If

        nome_user_global(lbl_usuario)

        AddHandler btn_doc_anteriores.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_doc_anteriores.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_inicio.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_inicio.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_orcamento.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_orcamento.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_sair.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_sair.MouseLeave, AddressOf botao_MouseLeave

        'referência mês e ano na tela
        lbl_mes.Text = mes
        lbl_ano.Text = ano

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, lbl_mes.Click, Label4.Click, lbl_ano.Click

    End Sub

    Private Sub frm_novo_orcamento_tipo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If fecharPorBotao Then
            ' Não faz nada, apenas fecha o formulário
        Else
            MsgBox("Encerrando o aplicativo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Application.Exit() ' Fecha o aplicativo se o formulário for fechado por outros meios
        End If
    End Sub



    ''ALTERAÇÃO DE CORES DOS BOTÕES
    'Private Sub btn_sair_MouseEnter(sender As Object, e As EventArgs) Handles btn_sair.MouseEnter
    '    btn_sair.ForeColor = Color.White
    '    btn_sair.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_inicio_MouseEnter(sender As Object, e As EventArgs) Handles btn_inicio.MouseEnter
    '    btn_inicio.ForeColor = Color.White
    '    btn_inicio.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_orcamento_MouseEnter(sender As Object, e As EventArgs) Handles btn_orcamento.MouseEnter
    '    btn_orcamento.ForeColor = Color.White
    '    btn_orcamento.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_doc_anteriores_MouseEnter(sender As Object, e As EventArgs) Handles btn_doc_anteriores.MouseEnter
    '    btn_doc_anteriores.ForeColor = Color.White
    '    btn_doc_anteriores.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_inicio_MouseLeave(sender As Object, e As EventArgs) Handles btn_inicio.MouseLeave
    '    btn_inicio.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_inicio.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    'Private Sub btn_orcamento_MouseLeave(sender As Object, e As EventArgs) Handles btn_orcamento.MouseLeave
    '    btn_orcamento.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_orcamento.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    'Private Sub btn_doc_anteriores_MouseLeave(sender As Object, e As EventArgs) Handles btn_doc_anteriores.MouseLeave
    '    btn_doc_anteriores.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_doc_anteriores.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    'Private Sub btn_sair_MouseLeave(sender As Object, e As EventArgs) Handles btn_sair.MouseLeave
    '    btn_sair.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_sair.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub
End Class