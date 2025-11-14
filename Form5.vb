Imports System.Drawing.Drawing2D
Imports System.Reflection.Emit

Public Class form_doc_anteriores
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_orc.CellContentClick

    End Sub

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

    Private Sub form_doc_anteriores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtg_orc.ReadOnly = True
        If dtg_orc.Rows.Count = 0 OrElse dtg_orc.Rows.Cast(Of DataGridViewRow)().All(Function(r) r.IsNewRow) Then ' Verifica se há registros no DataGridView
            gravar_alteracoes.Enabled = False
            Exit Sub
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        form_buscar_data.Show() ' Formulario para inserir as datas desejadas

    End Sub



    Private Sub btn_exibir_registros_MouseEnter(sender As Object, e As EventArgs) Handles btn_exibir_registros.MouseEnter
        btn_exibir_registros.ForeColor = Color.White
        btn_exibir_registros.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Bold)
    End Sub

    Private Sub btn_exibir_registros_MouseLeave(sender As Object, e As EventArgs) Handles btn_exibir_registros.MouseLeave
        btn_exibir_registros.ForeColor = Color.FromArgb(50, 120, 59)
        btn_exibir_registros.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Regular)
    End Sub

    Private Sub btn_relatorio_MouseLeave(sender As Object, e As EventArgs) Handles btn_relatorio.MouseLeave
        btn_relatorio.ForeColor = Color.FromArgb(50, 120, 59)
        btn_relatorio.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Regular)
    End Sub

    Private Sub btn_relatorio_MouseEnter(sender As Object, e As EventArgs) Handles btn_relatorio.MouseEnter
        btn_relatorio.ForeColor = Color.White
        btn_relatorio.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Bold)
    End Sub

    Private Sub btn_data_MouseEnter(sender As Object, e As EventArgs) Handles btn_data.MouseEnter
        btn_data.ForeColor = Color.White
        btn_data.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Bold)
    End Sub

    Private Sub btn_data_MouseLeave(sender As Object, e As EventArgs) Handles btn_data.MouseLeave
        btn_data.ForeColor = Color.FromArgb(50, 120, 59)
        btn_data.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Regular)
    End Sub

    Private Sub btn_alterar_reg_MouseEnter(sender As Object, e As EventArgs) Handles btn_alterar_reg.MouseEnter
        btn_alterar_reg.ForeColor = Color.White
        btn_alterar_reg.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Bold)
    End Sub

    Private Sub btn_alterar_reg_MouseLeave(sender As Object, e As EventArgs) Handles btn_alterar_reg.MouseLeave
        btn_alterar_reg.ForeColor = Color.FromArgb(50, 120, 59)
        btn_alterar_reg.Font = New Font("Franklin Gothic Demi", 18, FontStyle.Regular)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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
            gravar_alteracoes.Enabled = True
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

    Private Sub gravar_alteracoes_Click(sender As Object, e As EventArgs) Handles gravar_alteracoes.Click
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
        sql = $"update orcamentos set usuario='{dtg_orc.CurrentRow.Cells("usuario").Value}', mes='{dtg_orc.CurrentRow.Cells("mes").Value}', ano='{dtg_orc.CurrentRow.Cells("ano").Value}', tipo='{dtg_orc.CurrentRow.Cells("tipo").Value}', sub_tipo='{dtg_orc.CurrentRow.Cells("sub_tipo").Value}', descricao='{dtg_orc.CurrentRow.Cells("descricao").Value}', valor='{dtg_orc.CurrentRow.Cells("valor").Value}' where id={dtg_orc.CurrentRow.Cells("id").Value}"
        rs = db.Execute(sql)
        MsgBox("Alterações gravadas com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        dtg_orc.ReadOnly = True
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click
        form_buscar_data.Show() ' Formulario para inserir as datas desejadas
    End Sub

    Private Sub btn_registros_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click ' Botão voltar
        Me.Close()
        form_tela_princ_prot.Show() ' Volta para o formulário principal
    End Sub

    Private Sub btn_relatorio_Click(sender As Object, e As EventArgs) Handles btn_relatorio.Click
        form_relatorio.Show() ' Abre o formulário de relatório
    End Sub
End Class