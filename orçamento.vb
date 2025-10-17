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
    End Sub
End Class