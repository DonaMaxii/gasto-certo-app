Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit

Public Class frm_docs_anteriores

    Private Sub btn_exibir_registros_Click(sender As Object, e As EventArgs)
        Try
            With dtg_orc
                sql = $"select * from orcamentos where BINARY usuario ='{usuario_logado}'" ' BINARY para diferenciar maiusculas e minusculas
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    dtg_orc.Rows.Clear() ' Limpa linhas anteriores

                    Do While Not rs.EOF
                        dtg_orc.Rows.Add(
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
                    MsgBox("Ainda não há registros!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub frm_docs_anteriores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtg_orc.ReadOnly = True
        If dtg_orc.Rows.Count = 0 OrElse dtg_orc.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then ' Verifica se há registros no DataGridView
            btn_gravar.Enabled = False
            'Exit Sub 'desabilitei o "exit sub" para permitir o estilo nos botões
        End If
        dtg_orc.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Italic)
        dtg_orc.DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)

        ' Personalização dos botões
        custom_buttons()
    End Sub

    Private Sub custom_buttons()
        AddHandler btn_exibir_registros.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_exibir_registros.MouseLeave, AddressOf botao_MouseLeave
        'AddHandler btn_relatorio.MouseEnter, AddressOf botao_MouseEnter
        'AddHandler btn_relatorio.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_data.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_data.MouseLeave, AddressOf botao_MouseLeave
        AddHandler btn_alterar_reg.MouseEnter, AddressOf botao_MouseEnter
        AddHandler btn_alterar_reg.MouseLeave, AddressOf botao_MouseLeave
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        form_buscar_data.Show() ' Formulario para inserir as datas desejadas

    End Sub



    'Private Sub btn_exibir_registros_MouseEnter(sender As Object, e As EventArgs) Handles btn_exibir_registros.MouseEnter
    '    btn_exibir_registros.ForeColor = Color.White
    '    btn_exibir_registros.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_exibir_registros_MouseLeave(sender As Object, e As EventArgs) Handles btn_exibir_registros.MouseLeave
    '    btn_exibir_registros.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_exibir_registros.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    'Private Sub btn_relatorio_MouseLeave(sender As Object, e As EventArgs) Handles btn_relatorio.MouseLeave
    '    btn_relatorio.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_relatorio.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    'Private Sub btn_relatorio_MouseEnter(sender As Object, e As EventArgs) Handles btn_relatorio.MouseEnter
    '    btn_relatorio.ForeColor = Color.White
    '    btn_relatorio.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_data_MouseEnter(sender As Object, e As EventArgs) Handles btn_data.MouseEnter
    '    btn_data.ForeColor = Color.White
    '    btn_data.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_data_MouseLeave(sender As Object, e As EventArgs) Handles btn_data.MouseLeave
    '    btn_data.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_data.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    'Private Sub btn_alterar_reg_MouseEnter(sender As Object, e As EventArgs) Handles btn_alterar_reg.MouseEnter
    '    btn_alterar_reg.ForeColor = Color.White
    '    btn_alterar_reg.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    'End Sub

    'Private Sub btn_alterar_reg_MouseLeave(sender As Object, e As EventArgs) Handles btn_alterar_reg.MouseLeave
    '    btn_alterar_reg.ForeColor = Color.FromArgb(65, 127, 88)
    '    btn_alterar_reg.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    'End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_exibir_registros_Click_1(sender As Object, e As EventArgs) Handles btn_exibir_registros.Click
        exibir_dados()
    End Sub

    Private Sub btn_alterar_reg_Click_1(sender As Object, e As EventArgs) Handles btn_alterar_reg.Click
        If habilitado = 0 Then ' Se estiver desabilitado, habilita a edição
            dtg_orc.ReadOnly = False ' Habilita a edição do DataGridView
            If dtg_orc.Rows.Count = 0 OrElse dtg_orc.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then ' Verifica se há registros no DataGridView
                dtg_orc.ReadOnly = True ' Mantém o DataGridView como somente leitura
                MsgBox("Não há registros para editar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            btn_gravar.Enabled = True
            MsgBox("Campos habilitado para edição", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            MsgBox("Após alterar os dados, selecione a coluna do ID que deseja alterar os valores e clique em 'Gravar Alterações'.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            dtg_orc.Columns("id").ReadOnly = True ' Mantém a coluna ID como somente leitura
            dtg_orc.Columns("usuario").ReadOnly = True ' Mantém a coluna USUÁRIO como somente leitura
            habilitado = 1

        Else ' Se estiver habilitado, desabilita a edição
            dtg_orc.ReadOnly = True
            habilitado = 0
        End If
    End Sub



    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click
        form_buscar_data.Show() ' Formulario para inserir as datas desejadas
    End Sub

    Private Sub btn_registros_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btn_relatorio_Click(sender As Object, e As EventArgs) 
        Me.Show() ' Abre o formulário de relatório
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs)
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
        If dtg_orc.CurrentCell.OwningColumn.Name <> "id" Then
            MsgBox("Selecione a coluna ID para gravar as alterações.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If


        If listaMeses.Contains(dtg_orc.CurrentRow.Cells("mes").Value.ToString()) = False Then
            MsgBox("Mês inválido. Por favor, insira um mês válido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        If Not IsNumeric(dtg_orc.CurrentRow.Cells("ano").Value) OrElse CInt(dtg_orc.CurrentRow.Cells("ano").Value) < 1900 OrElse CInt(dtg_orc.CurrentRow.Cells("ano").Value) > DateTime.Now.Year Then
            MsgBox("Ano inválido. Por favor, insira um ano válido entre 2015 e o ano atual.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        If dtg_orc.CurrentRow.Cells("tipo").Value.ToString() <> "Receita" AndAlso dtg_orc.CurrentRow.Cells("tipo").Value.ToString() <> "Gasto" Then
            MsgBox("Tipo inválido. Por favor, insira 'Receita' ou 'Gasto'.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If
        If tipo_gasto.Contains(dtg_orc.CurrentRow.Cells("sub_tipo").Value.ToString()) = False AndAlso tipo_receita.Contains(dtg_orc.CurrentRow.Cells("sub_tipo").Value.ToString()) = False Then
            MsgBox("Subtipo inválido. Por favor, insira um subtipo válido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            exibir_dados() ' Recarrega os dados originais
            Exit Sub
        End If

        sql = $"update orcamentos set usuario='{dtg_orc.CurrentRow.Cells("usuario").Value}', mes='{dtg_orc.CurrentRow.Cells("mes").Value}', ano='{dtg_orc.CurrentRow.Cells("ano").Value}', tipo='{dtg_orc.CurrentRow.Cells("tipo").Value}', sub_tipo='{dtg_orc.CurrentRow.Cells("sub_tipo").Value}', descricao='{dtg_orc.CurrentRow.Cells("descricao").Value}', valor='{dtg_orc.CurrentRow.Cells("valor").Value}' where id={dtg_orc.CurrentRow.Cells("id").Value}"
        rs = db.Execute(sql)
        MsgBox("Alterações gravadas com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        dtg_orc.ReadOnly = True
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        mes_busca = "" ' Limpa a variável global de mês
        ano_busca = "" ' Limpa a variável global de ano
        Me.Close()
        frm_tela_principal.Show() ' Volta para o formulário principal
    End Sub

    Private Sub dtg_orc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_orc.CellContentClick

    End Sub

    Private Sub frm_docs_anteriores_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If btn_voltar.Focused Then
            ' Fechado pelo botão Voltar, não faz nada
        Else
            ' Fechado por outro meio, fecha o programa
            Application.Exit()
        End If

    End Sub
End Class

