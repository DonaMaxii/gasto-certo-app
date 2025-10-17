Public Class form_cadastro
    Private senha_visivel As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txt_usuario.Text) OrElse String.IsNullOrEmpty(txt_senha.Text) OrElse String.IsNullOrEmpty(txt_confirmar_senha.Text) Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
        Else
            If txt_senha.Text = txt_confirmar_senha.Text Then
                Try
                    sql = $"select * from usuarios where usuario='{txt_usuario.Text}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then ' Se existir na tabela
                        MsgBox("Usuário já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                    Else
                        sql = $"insert into usuarios (usuario,senha) values ('{txt_usuario.Text}','{txt_senha.Text}')"
                        rs = db.Execute(UCase(sql))
                        MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "AVISO")
                    End If

                Catch ex As Exception

                End Try
            Else
                MsgBox("Senhas diferentes!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ALERTA")
            End If
        End If

    End Sub
End Class