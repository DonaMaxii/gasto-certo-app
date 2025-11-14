Public Class form_tipo_orcamento
    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Me.Close() ' Fecha o formulário atual
        form_tela_princ_prot.Show() ' Abre o formulário de tela principal
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click ' Abre o formulário de documentos anteriores
        Me.Close()
        form_doc_anteriores.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair do programa
        If resp = vbYes Then
            Form1.Close()
        Else
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair da conta
        If resp = vbYes Then
            Me.Close()
            Form1.Show()
        Else
        End If
    End Sub

    Private Sub btn_orcamento_Click(sender As Object, e As EventArgs) Handles btn_orcamento.Click

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub btn_inserir_receitas_Click(sender As Object, e As EventArgs) Handles btn_inserir_receitas.Click
        Me.Close()
        form_inserir_receita.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        form_inserir_gasto.Show()
    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click
        MsgBox("Orçamento finalizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Me.Close()
        form_tela_princ_prot.Show()
    End Sub

    Private Sub btn_visualizar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub form_tipo_orcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class