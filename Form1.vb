Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private senha_visivel As Boolean = False ' Controle do olho aberto ou fechado 
    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        If String.IsNullOrEmpty(txt_user.Text) OrElse String.IsNullOrEmpty(txt_password.Text) Then ' "String.IsNullOrEmpty" verificar se é vazio, isso inclue espaços em brancos!
            MsgBox("Preencha todos os campos!", vbExclamation + vbOKOnly, "AVISO")

        ElseIf txt_user.Text = "rafael123" And txt_password.Text = "123" Then        ' Uma pequena validação de username e password, Claro que é só um exemplo já que puxaremos
            MsgBox("Logado com sucesso! ✔️", vbInformation + vbOKOnly, "SUCESSO")                                                                    'Do banco de dados
            Me.Hide()
            'menu_principal.ShowDialog()     ' Chama o formulário menu_principal, podemos fazer de outra forma!
            tela_principal_test.ShowDialog()
        Else
            MsgBox("Credenciais inválidas!", vbExclamation + vbOKOnly, "ATENÇÃO")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Close()
        Else

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles visualizar.Click
        If senha_visivel Then ' Se senha_visivel então True, significa que o olho está aberto
            txt_password.PasswordChar = "*"c ' Colocar os asteriscos
            visualizar.Image = My.Resources.ocultar_senha ' Mudar a imagem para ocultar_senha
            senha_visivel = False ' Atribuir false na variavel senha_visivel, significa que senha não é mais visivel e na proxima vez ira para o else
        Else
            txt_password.PasswordChar = ControlChars.NullChar 'Tira os * e deixa a senha visivel
            visualizar.Image = My.Resources.mostrar_senha
            senha_visivel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' Carregamento da página
        img_login_financas.Image = My.Resources.login_financas_imagem
        conecta_banco_mysql()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        form_cadastro.Show()
    End Sub
End Class
