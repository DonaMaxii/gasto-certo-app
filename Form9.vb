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




    Private Sub btn_canc_Click(sender As Object, e As EventArgs) Handles btn_canc.Click
        Me.Close()
        form_doc_anteriores.Show()
    End Sub

    Private Sub btn_okk_Click(sender As Object, e As EventArgs) Handles btn_okk.Click
        If cmb_meses.Text = "" Or cmb_ano.Text = "" Then ' Verifica se o usuário selecionou um mês e um ano
            MsgBox("Por favor, selecione o mês e o ano para continuar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        mes_busca = cmb_meses.Text ' Armazena o mês selecionado na variável global "mes"
        ano_busca = cmb_ano.Text ' Armazena o ano selecionado na variável global "ano"
        Me.Close()
        form_orc_datas.Show() ' Formulario de exibição
    End Sub
End Class