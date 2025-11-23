Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button


Public Class frm_login

    'Variáveis para animação. Me deseje sorte!
    Private animationTimer As Timer
    Private alpha As Single = 0.0F
    Private targetY As Integer
    Private progressY As Single = 0.0F
    Private startY As Integer
    Private StepY As Single = 0.05F
    Private alphaStep As Single = 0.05F
    Private logo As Image

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        ' Carregando o logo por aqui
        logo = PictureBox_logo.Image
        PictureBox_logo.Image = Nothing

        ' Guarda a posição original definida no Designer
        targetY = PictureBox_logo.Top
        startY = targetY - 50

        ' Configuração inicial, move o logo para fora da tela inicialmente
        PictureBox_logo.Top = targetY

        'Timer
        animationTimer = New Timer()
        animationTimer.Interval = 70
        AddHandler animationTimer.Tick, AddressOf AnimationTimer_Tick

        'Evento paint para desenhar com alpha
        AddHandler PictureBox_logo.Paint, AddressOf PictureBox_logo_Paint

    End Sub

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
        animationTimer.Start()
    End Sub
    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs)
        ' Atualiza progresso
        If progressY < 1.0F Then
            progressY += StepY
        End If

        ' Ease in quadrático: começa lento e acelera
        Dim eased As Single = 1 - (1 - progressY) * (1 - progressY)

        ' Calcula posição interpolada
        PictureBox_logo.Top = CInt((targetY - startY) * eased + startY)

        ' Fade in também pode usar easing
        alpha = eased

        PictureBox_logo.Invalidate()

        ' Finaliza
        If progressY >= 1.0F Then
            animationTimer.Stop()
        End If
    End Sub
    Private Sub PictureBox_logo_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox_logo.Paint
        If logo Is Nothing Then Return

        ' Configura matriz de cor com alpha
        Dim cm As New ColorMatrix
        cm.Matrix33 = alpha 'controla transparência

        Dim ia As New ImageAttributes()
        ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)

        ' Desenha a imagem com alpha
        e.Graphics.DrawImage(
            logo,
            New Rectangle(0, 0, PictureBox_logo.Width, PictureBox_logo.Height),
            0, 0, logo.Width, logo.Height,
            GraphicsUnit.Pixel,
            ia
        )

    End Sub

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
                    'frm_tela_principal.ShowDialog()
                    frm_tela_principal.Show()

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
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ALERTA")
        If resp = vbYes Then
            Application.Exit()
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

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        txt_user.Clear()
        txt_password.Clear()
        Me.Hide()
        form_cadastro.Show()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_mysql()
        Me.Visible = True ' Garante que o formulário esteja visível ao carregar
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

    Private Sub frm_login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
