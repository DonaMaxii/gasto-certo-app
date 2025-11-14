Public Class form_inserir_gasto
    Private Sub form_gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_box_tipo.Items.Add("Alimentação")
        cmb_box_tipo.Items.Add("Transporte")
        cmb_box_tipo.Items.Add("Saúde")
        cmb_box_tipo.Items.Add("Educação")
        cmb_box_tipo.Items.Add("Lazer")
        cmb_box_tipo.Items.Add("Moradia")
        cmb_box_tipo.Items.Add("Outros")
        cmb_box_tipo.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual 
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_valor_gasto.Text = "" Or cmb_box_tipo.Text = "" Then ' Verifica se o usuário preencheu todos os campos
            MsgBox("Por favor, preencha o tipo e o valor do gasto.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        If Not IsNumeric(txt_valor_gasto.Text) Then ' Verifica se o valor inserido é numérico
            MsgBox("Por favor, insira um valor numérico válido para o gasto.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            txt_valor_gasto.Clear()
            txt_valor_gasto.Focus()
            Exit Sub
        End If
        ' Armazena os valores inseridos nas variáveis globais
        gasto_valor = txt_valor_gasto.Text
        gasto_valor = CDbl(gasto_valor)

        'gasto_valor = (gasto_valor) ' Converte o valor para Double
        gasto_tipo = cmb_box_tipo.Text
        gasto_descricao = txt_valor_descricao_gasto.Text
        Dim receita = "Gasto"
        Try
            ' Força o formato do número com ponto decimal (invariante)
            Dim valorTexto As String = txt_valor_gasto.Text.Trim()

            ' Substitui vírgula por ponto
            valorTexto = valorTexto.Replace(",", ".")

            ' Converte para Double usando InvariantCulture
            Dim valorSQL As Double = Double.Parse(valorTexto, System.Globalization.CultureInfo.InvariantCulture)

            sql = "INSERT INTO orcamentos (usuario, mes, ano, sub_tipo, tipo, descricao, valor) VALUES ('" &
      usuario_logado & "', '" & mes & "', '" & ano & "', '" & gasto_tipo & "', '" & receita & "', '" &
      gasto_descricao & "', " & valorSQL.ToString(System.Globalization.CultureInfo.InvariantCulture) & ")"


            rs = db.Execute(sql)
            MsgBox("Receita registrada com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Me.Close()
            form_tipo_orcamento.Show()
        Catch ex As Exception
            MsgBox("Erro ao registrar a receita!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA") ' Pergunta se o usuário deseja sair do programa
        If resp = vbYes Then
            Form1.Close()
        Else
        End If
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

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        form_tipo_orcamento.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class