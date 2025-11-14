Public Class Form4
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
        form_tela_princ_prot.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Form1.Close()
        Else
        End If
    End Sub

    Private Sub cmb_meses_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_ano.DropDownStyle = ComboBoxStyle.DropDownList ' Define o ComboBox para não permitir edição manual
        cmb_meses.DropDownStyle = ComboBoxStyle.DropDownList '  Define o ComboBox para não permitir edição manual
        cmb_mes(cmb_meses) ' Chama a sub rotina para adicionar os meses ao ComboBox
        Dim currentYear As Integer = DateTime.Now.Year ' Pega o ano atual
        Dim yearsBack As Integer = 10 ' quantos anos para trás
        cmb_ano.Items.Clear() ' Limpa os itens existentes no ComboBox

        For y As Integer = currentYear To currentYear - yearsBack Step -1 ' Loop para adicionar os anos no ComboBox 
            cmb_ano.Items.Add(y.ToString())
        Next
        usuario.Text = usuario_logado ' Exibe o nome do usuário logado no label "usuario"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_proximo.Click
        If cmb_meses.Text = "" Or cmb_ano.Text = "" Then ' Verifica se o usuário selecionou um mês e um ano
            MsgBox("Por favor, selecione o mês e o ano para continuar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        mes = cmb_meses.Text ' Armazena o mês selecionado na variável global "mes"
        ano = cmb_ano.Text ' Armazena o ano selecionado na variável global "ano"
        ano = CInt(ano) ' Converte o ano para inteiro
        Me.Close()
        form_tipo_orcamento.Show()
    End Sub

    Private Sub usuario_Click(sender As Object, e As EventArgs) Handles usuario.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Me.Close()
            Form1.Show()
        Else
        End If
    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Me.Close()
        form_tela_princ_prot.Show()
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click
        Me.Close()
        form_doc_anteriores.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_KeyDown(sender As Object, e As KeyEventArgs) Handles Panel2.KeyDown

    End Sub

    Private Sub cmb_meses_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_meses.SelectedIndexChanged

    End Sub

    Private Sub cmb_meses_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_meses.SelectedValueChanged
        cmb_ano.Focus()
    End Sub

End Class