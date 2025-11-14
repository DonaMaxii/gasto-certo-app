Public Class orçamento
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_meses.SelectedIndexChanged

    End Sub

    Private Sub orçamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_meses.Items.Add("Janeiro")
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

    Private Sub cmb_ano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ano.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class