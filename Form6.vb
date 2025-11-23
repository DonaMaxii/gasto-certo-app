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
            txt_valor.ForeColor = Color.Red ' Define a cor do texto como vermelho para valores negativos
        Else
            txt_valor.ForeColor = Color.Green ' Define a cor do texto como verde para valores positivos
        End If
        txt_valor.Text = $"R$ {calc_receita_despesa.ToString("F2")}" ' Formata o valor com duas casas decimais e atribui ao TextBox

        If calc_receita_despesa < 0 Then
            img_simbolo.Text = "▼ Negativo"
            img_simbolo.ForeColor = Color.Red
        Else
            img_simbolo.Text = "▲ Positivo"
            img_simbolo.ForeColor = Color.Green
        End If

    End Sub
End Class