Public Class form_orc_datas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles txt_mes.Click

    End Sub

    Private Sub form_orc_datas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_mes.Text = mes_busca
        txt_ano.Text = ano_busca
        habilitado = 0
        Try
            With dtg_orc_data
                sql = $"select * from orcamentos where BINARY usuario ='{usuario_logado}' and mes='{mes_busca}' and ano='{ano_busca}'" ' BINARY para diferenciar maiusculas e minusculas
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    dtg_orc_data.Rows.Clear() ' Limpa linhas anteriores

                    Do While Not rs.EOF
                        dtg_orc_data.Rows.Add(
                            rs.Fields("id").Value,
                            rs.Fields("usuario").Value,
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
                    MsgBox("Nenhum registro encontrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    Me.Close()
                    form_doc_anteriores.Show()
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dtg_orc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_orc_data.CellContentClick

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
        form_doc_anteriores.Show()
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If habilitado = 0 Then
            dtg_orc_data.ReadOnly = False
            habilitado = 1
            dtg_orc_data.Columns("id").ReadOnly = True ' Mantém a coluna ID como somente leitura
            dtg_orc_data.Columns("usuario").ReadOnly = True ' Mantém a coluna USUÁRIO como somente leitura
            MsgBox("Edição habilitada! Lembre-se de clicar em 'Gravar Alterações' após editar os dados.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            dtg_orc_data.ReadOnly = True
            habilitado = 0
            MsgBox("Edição desabilitada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim listaMeses As New List(Of String) From {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
            }
        Dim tipo_gasto As New List(Of String) From {
            "Alimentação",
            "Transporte",
            "Saúde",
            "Educação",
            "Lazer",
            "Moradia",
            "Outros"
            }
        Dim tipo_receita As New List(Of String) From {
            "Salário",
            "Freelance",
            "Investimentos",
            "Presente",
            "Outros Rendimentos"
            }
        If dtg_orc_data.CurrentCell.OwningColumn.Name <> "id" Then
            MsgBox("Selecione a coluna ID para gravar as alterações.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If


        If listaMeses.Contains(dtg_orc_data.CurrentRow.Cells("mes").Value.ToString()) = False Then
            MsgBox("Mês inválido. Por favor, insira um mês válido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        If Not IsNumeric(dtg_orc_data.CurrentRow.Cells("ano").Value) OrElse CInt(dtg_orc_data.CurrentRow.Cells("ano").Value) < 1900 OrElse CInt(dtg_orc_data.CurrentRow.Cells("ano").Value) > DateTime.Now.Year Then
            MsgBox("Ano inválido. Por favor, insira um ano válido entre 2015 e o ano atual.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        If dtg_orc_data.CurrentRow.Cells("tipo").Value.ToString() <> "Receita" AndAlso dtg_orc_data.CurrentRow.Cells("tipo").Value.ToString() <> "Gasto" Then
            MsgBox("Tipo inválido. Por favor, insira 'Receita' ou 'Gasto'.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        If tipo_gasto.Contains(dtg_orc_data.CurrentRow.Cells("sub_tipo").Value.ToString()) = False AndAlso tipo_receita.Contains(dtg_orc_data.CurrentRow.Cells("sub_tipo").Value.ToString()) = False Then
            MsgBox("Subtipo inválido. Por favor, insira um subtipo válido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        sql = $"update orcamentos set usuario='{dtg_orc_data.CurrentRow.Cells("usuario").Value}', mes='{dtg_orc_data.CurrentRow.Cells("mes").Value}', ano='{dtg_orc_data.CurrentRow.Cells("ano").Value}', tipo='{dtg_orc_data.CurrentRow.Cells("tipo").Value}', sub_tipo='{dtg_orc_data.CurrentRow.Cells("sub_tipo").Value}', descricao='{dtg_orc_data.CurrentRow.Cells("descricao").Value}', valor='{dtg_orc_data.CurrentRow.Cells("valor").Value}' where id={dtg_orc_data.CurrentRow.Cells("id").Value}"
        rs = db.Execute(sql)
        MsgBox("Alterações gravadas com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        dtg_orc_data.ReadOnly = True
    End Sub
End Class