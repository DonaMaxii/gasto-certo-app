Public Class form_relatorio
    Private Sub form_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_mes(cmb_meses)
        Dim currentYear As Integer = DateTime.Now.Year ' Pega o ano atual
        Dim yearsBack As Integer = 10 ' quantos anos para trás
        cmb_ano.Items.Clear() ' Limpa os itens existentes no ComboBox

        For y As Integer = currentYear To currentYear - yearsBack Step -1 ' Loop para adicionar os anos no ComboBox 
            cmb_ano.Items.Add(y.ToString())
        Next
        cmb_meses.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual
        cmb_ano.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual
    End Sub
End Class