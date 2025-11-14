Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private senha_visivel As Boolean = False ' Controle do olho aberto ou fechado 
    Private Sub btn_logar_Click(sender As Object, e As EventArgs) Handles btn_logar.Click
        If String.IsNullOrEmpty(txt_user.Text) OrElse String.IsNullOrEmpty(txt_password.Text) Then ' "String.IsNullOrEmpty" verificar se é vazio, isso inclue espaços em brancos!
            MsgBox("Preencha todos os campos!", vbExclamation + vbOKOnly, "AVISO")
        Else
            sql = $"select * from usuarios where usuario='{txt_user.Text}' and senha='{txt_password.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then ' Se existir na tabela
                If String.Compare(rs.Fields(1).Value.ToString(), txt_user.Text, False) = 0 And String.Compare(rs.Fields(2).Value.ToString, txt_password.Text, False) = 0 Then
                    MsgBox("Logado com sucesso! Bem vindo " & rs.Fields(1).Value & " ✔️", vbInformation + vbOKOnly, "SUCESSO") ' Puxa o nome do usuario do banco de dados
                    txt_user.Clear()
                    txt_password.Clear()
                    usuario_logado = rs.Fields(1).Value ' Pega o nome do usuario logado
                    Me.Hide()
                    'tela_principal_test.ShowDialog()
                    form_tela_princ_prot.Show()

                End If
            Else
                MsgBox("Credenciais inválidas!", vbExclamation + vbOKOnly, "ATENÇÃO")
                txt_user.Clear()
                txt_password.Clear()
                txt_user.Focus()
            End If

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

    Private Sub Tela_Click(sender As Object, e As EventArgs) Handles Tela.Click

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Me.Hide()
        form_cadastro.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
    End Sub

    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged

    End Sub

    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_password.Focus()
        End If
    End Sub


    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_logar.PerformClick()
        End If
    End Sub
End Class
