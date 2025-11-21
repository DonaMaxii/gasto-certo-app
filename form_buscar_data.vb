Public Class form_buscar_data
    Private Sub form_buscar_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_meses.Items.Add("Janeiro") ' Adiciona os meses ao ComboBox
        cmb_meses.Items.Add("Fevereiro")
        cmb_meses.Items.Add("Março")
        cmb_meses.Items.Add("Abril")
        cmb_meses.Items.Add("Maio")
        cmb_meses.Items.Add("Junho")
        cmb_meses.Items.Add("Julho")
        cmb_meses.Items.Add("Agosto")
        cmb_meses.Items.Add("Setembro")
        cmb_meses.Items.Add("Outubro")
        cmb_meses.Items.Add("Novembro")
        cmb_meses.Items.Add("Dezembro")

        Dim currentYear As Integer = DateTime.Now.Year ' Pega o ano atual
        Dim yearsBack As Integer = 10 ' quantos anos para trás
        cmb_ano.Items.Clear() ' Limpa os itens existentes no ComboBox

        For y As Integer = currentYear To currentYear - yearsBack Step -1 ' Loop para adicionar os anos no ComboBox
            cmb_ano.Items.Add(y.ToString())
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        frm_docs_anteriores.Show()
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        If cmb_meses.Text = "" Or cmb_ano.Text = "" Then ' Verifica se o usuário selecionou um mês e um ano
            MsgBox("Por favor, selecione o mês e o ano para continuar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        mes_busca = cmb_meses.Text ' Armazena o mês selecionado na variável global "mes"
        ano_busca = cmb_ano.Text ' Armazena o ano selecionado na variável global "ano"
        Me.Close()
        frm_docs_anteriores.Show() ' Formulario de exibição
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub form_buscar_data_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If btn_consultar.Focused Or btn_cancelar.Focused Then
            ' Não faz nada, pois o fechamento foi intencional
            Exit Sub
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class