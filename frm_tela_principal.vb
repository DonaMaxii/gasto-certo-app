Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Windows.Forms.AxHost

Public Class frm_tela_principal

    'Variáveis para animação. Me deseje sorte!
    Private animationTimer As Timer
    Private alpha As Single = 0.0F
    Private targetY As Integer
    Private progressY As Single = 0.0F
    Private startY As Integer
    Private StepY As Single = 0.05F
    Private alphaStep As Single = 0.05F
    Private logo As Image
    Private fecharPorBotao As Boolean = False ' Variável para controlar se o formulário foi fechado por um botão específico


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

    Private Sub frm_tela_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        fecharPorBotao = True
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub btn_docs_anteriores_Click(sender As Object, e As EventArgs) Handles btn_docs_anteriores.Click
        fecharPorBotao = True
        frm_docs_anteriores.Show()
        Me.Close()

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja realmente sair do aplicativo?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btn_novo_orcamento_Click(sender As Object, e As EventArgs) Handles btn_novo_orcamento.Click
        fecharPorBotao = True
        frm_novo_orcamento.Show()
        Me.Close()
    End Sub

    Private Sub frm_tela_principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If fecharPorBotao Then
            ' Não faz nada, apenas fecha o formulário
        Else
            MsgBox("Encerrando o aplicativo.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Application.Exit() ' Fecha o aplicativo se o formulário for fechado por outros meios
        End If
    End Sub
End Class