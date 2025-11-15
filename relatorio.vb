Public Class form_relatorio
    Private Sub form_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_mes(mes_busca)
        Dim currentYear As Integer = DateTime.Now.Year ' Pega o ano atual
        Dim yearsBack As Integer = 10 ' quantos anos para trás
        ano_busca.Items.Clear() ' Limpa os itens existentes no ComboBox


        For y As Integer = currentYear To currentYear - yearsBack Step -1 ' Loop para adicionar os anos no ComboBox 
            ano_busca.Items.Add(y.ToString())
        Next
        mes_busca.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual
        ano_busca.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_relatorio.CellContentClick

    End Sub

    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        calc_receita_despesa = 0
        If mes_busca.Text = "" Or ano_busca.Text = "" Then
            MsgBox("Por favor, selecione o mês e o ano para gerar o relatório!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If
        Try
            sql = $"select * from orcamentos where usuario ='{usuario_logado}' AND mes='{mes_busca.Text}' AND ano='{ano_busca.Text}'" ' Consulta SQL para buscar os orçamentos do usuário logado no mês e ano selecionados"
            rs = db.Execute(sql)
            If Not rs.EOF Then
                dtg_relatorio.Rows.Clear() ' Limpa linhas anteriores
                Do While Not rs.EOF
                    dtg_relatorio.Rows.Add(
                        rs.Fields("mes").Value,
                        rs.Fields("ano").Value,
                        rs.Fields("tipo").Value,
                        rs.Fields("sub_tipo").Value,
                        rs.Fields("descricao").Value,
                        rs.Fields("valor").Value
                    )
                    rs.MoveNext()
                Loop
            Else
                MsgBox("Ainda não há registros para o mês e ano selecionados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
        Try
            receita = 0
            sql = $"SELECT SUM(valor) AS total FROM orcamentos WHERE usuario='{usuario_logado}' AND mes='{mes_busca.Text}' AND ano='{ano_busca.Text}' AND tipo='Receita'"
            rs = db.Execute(sql)
            If Not rs.EOF And Not IsDBNull(rs.Fields("total").Value) Then ' Verifica se o recordset não está vazio e se o valor não é nulo
                receita = Convert.ToDecimal(rs.Fields("total").Value) ' Converte o valor para decimal e atribui à variável receita
            End If
        Catch ex As Exception
            MsgBox("Erro ao calcular receita!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

        Try
            despesa = 0
            sql = $"SELECT SUM(valor) AS total FROM orcamentos WHERE usuario='{usuario_logado}' AND mes='{mes_busca.Text}' AND ano='{ano_busca.Text}' AND tipo='Gasto'" ' Consulta SQL para somar os valores dos gastos
            rs = db.Execute(sql)
            If Not rs.EOF And Not IsDBNull(rs.Fields("total").Value) Then ' Verifica se o recordset não está vazio e se o valor não é nulo
                despesa = Convert.ToDecimal(rs.Fields("total").Value) ' Converte o valor para decimal e atribui à variável despesa
            End If
        Catch ex As Exception
            MsgBox("Erro ao calcular despesa!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

        calc_receita_despesa = receita - despesa
        If calc_receita_despesa < 0 Then
            txt_saldo.ForeColor = Color.Red ' Define a cor do texto como vermelho para valores negativos
        Else
            txt_saldo.ForeColor = Color.Green ' Define a cor do texto como verde para valores positivos
        End If
        txt_saldo.Text = $"R$ {calc_receita_despesa.ToString("F2")}" ' Formata o valor com duas casas decimais e atribui ao TextBox
    End Sub

    Private Sub dtg_relatorio_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtg_relatorio.CellFormatting
        If dtg_relatorio.Columns(e.ColumnIndex).Name = "tipo" AndAlso e.Value IsNot Nothing Then ' Verifica se a coluna é "tipo" e se o valor não é nulo
            If e.Value.ToString() = "Receita" Then
                e.CellStyle.BackColor = Color.Green ' Define a cor do texto como verde para receitas
            ElseIf e.Value.ToString() = "Gasto" Then
                e.CellStyle.BackColor = Color.Red ' Define a cor do texto como vermelho para gastos
            End If
        End If
        If dtg_relatorio.Columns(e.ColumnIndex).Name = "valor" AndAlso e.Value IsNot Nothing Then ' Verifica se a coluna é "valor" e se o valor não é nulo
            Dim valor As Decimal
            Dim tipo As String = dtg_relatorio.Rows(e.RowIndex).Cells("tipo").Value.ToString() ' Obtém o valor da célula "tipo" na mesma linha
            If Decimal.TryParse(e.Value.ToString(), valor) Then ' Tenta converter o valor para decimal
                e.Value = $"R$ {valor:F2}" ' Formata o valor com duas casas decimais e o prefixo "R$"
                e.FormattingApplied = True ' Indica que a formatação foi aplicada
            End If
            If tipo = "Gasto" Then
                e.CellStyle.ForeColor = Color.Red ' Define a cor do texto como vermelho para valores negativos
            Else
                e.CellStyle.ForeColor = Color.Green ' Define a cor do texto como verde para valores positivos
            End If
        End If
    End Sub
End Class