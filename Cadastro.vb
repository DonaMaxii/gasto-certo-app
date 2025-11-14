Public Class form_cadastro
    Private senha_visivel As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form1.Show()
        Close()

    End Sub

    Private Sub visualizar_Click(sender As Object, e As EventArgs) Handles visualizar.Click
        If senha_visivel Then ' Se senha_visivel então True, significa que o olho está aberto
            txt_senha.PasswordChar = "*"c ' Colocar os asteriscos
            txt_confirmar_senha.PasswordChar = "*"c
            visualizar.Image = My.Resources.ocultar_senha ' Mudar a imagem para ocultar_senha
            senha_visivel = False ' Atribuir false na variavel senha_visivel, significa que senha não é mais visivel e na proxima vez ira para o else
        Else
            txt_confirmar_senha.PasswordChar = ControlChars.NullChar 'Tira os * e deixa a senha visivel
            txt_senha.PasswordChar = ControlChars.NullChar
            visualizar.Image = My.Resources.mostrar_senha
            senha_visivel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click ' Botão cadastrar usuário
        If String.IsNullOrEmpty(txt_usuario.Text) OrElse String.IsNullOrEmpty(txt_senha.Text) OrElse String.IsNullOrEmpty(txt_confirmar_senha.Text) Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        Else
            If txt_senha.Text = txt_confirmar_senha.Text Then
                Try
                    sql = $"select * from usuarios where usuario='{txt_usuario.Text}'" ' Verificar se o usuário já existe
                    rs = db.Execute(sql)
                    If rs.EOF = False Then ' Se existir na tabela
                        MsgBox("Usuário já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                        txt_usuario.Clear()
                        txt_senha.Clear()
                        txt_confirmar_senha.Clear()
                        txt_usuario.Focus()
                    Else
                        sql = $"insert into usuarios (usuario,senha) values ('{txt_usuario.Text}','{txt_senha.Text}')" ' Cadastrar novo usuário
                        rs = db.Execute(sql)
                        MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                        txt_usuario.Clear()
                        txt_senha.Clear()
                        txt_confirmar_senha.Clear()
                    End If

                Catch ex As Exception

                End Try
            Else
                txt_senha.Clear()
                txt_confirmar_senha.Clear()
                txt_senha.Focus()
                MsgBox("Senhas diferentes!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
            End If
        End If

    End Sub


    Private Sub txt_usuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_senha.Focus()
        End If
    End Sub

    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged

    End Sub

    Private Sub txt_senha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_confirmar_senha.Focus()
        End If
    End Sub

    Private Sub txt_confirmar_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_confirmar_senha.TextChanged

    End Sub

    Private Sub txt_confirmar_senha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_confirmar_senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_cadastrar.PerformClick()
        End If
    End Sub

    Private Sub form_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub form_cadastro_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()
    End Sub
End Class