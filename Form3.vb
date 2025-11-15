Public Class form_tela_princ_prot
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_orcamento.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub form_tela_princ_prot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hora_atual As DateTime = DateTime.Now ' Pega a hora atual do sistema
        nome_user.Text = usuario_logado ' Exibe o nome do usuário logado no label "nome_user"
        usuario.Text = usuario_logado ' Exibe o nome do usuário logado no label "usuario"
        txt_hora_atual.Text = hora_atual.ToString("HH:mm") ' Exibe a hora atual no label "txt_hora_atual" no formato HH:mm
        Dim hora_saudacao As Integer = hora_atual.Hour ' Pega a hora atual em formato inteiro
        If hora_saudacao >= 0 And hora_saudacao < 12 Then
            txt_saudacao.Text = "Bom dia" ' Exibe "Bom dia," se a hora estiver entre 0 e 11
        ElseIf hora_saudacao >= 12 And hora_saudacao < 18 Then
            txt_saudacao.Text = "Boa tarde" ' Exibe "Boa tarde," se a hora estiver entre 12 e 17
        Else
            txt_saudacao.Text = "Boa noite" ' Exibe "Boa noite," se a hora estiver entre 18 e 23
        End If
        sql = "SELECT * FROM usuarios"
        rs = db.Execute(sql)
        cont = 0
        If rs.EOF = False Then
            Do While Not rs.EOF
                cont += 1
                rs.MoveNext()
            Loop
        End If
        txt_qtd_usuarios.Text = cont ' Exibe a quantidade de usuários cadastrados no label "txt_qtd_usuarios"
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Form1.Close()
        Else
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles usuario.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        resp = MsgBox("Desejá realmente sair da sua conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Me.Close()
            Form1.Show()
        Else
        End If
    End Sub

    Private Sub btn_doc_anteriores_Click(sender As Object, e As EventArgs) Handles btn_doc_anteriores.Click
        Me.Close()
        form_doc_anteriores.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click

    End Sub
End Class