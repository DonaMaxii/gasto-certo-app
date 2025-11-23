
Module Module1
    Public resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public cont As Integer ' Variável de controle para loops e contagens
    Public usuario_logado, mes, ano As String
    Public receita_valor, gasto_valor As Double
    Public receita_tipo, receita_descricao, gasto_tipo, gasto_descricao As String ' Variáveis para armazenar os tipos e descrições de receitas e gastos
    Public mes_busca, ano_busca As String ' Variáveis para armazenar o mês e ano selecionados na busca'
    Public habilitado As Integer = 0 ' Variável para controlar se a edição está habilitada ou não no DataGridView principal
    Public calc_receita_despesa, receita, despesa As Double ' Variável para armazenar o resultado do cálculo de receitas menos despesas
    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={Mysql ODBC 3.51 Driver};SERVER=localhost;DATABASE=gasto_certo;UID=root;PWD=usbw;port=3307;option=3;")
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Application.Exit()
        End Try
    End Sub
    Sub exibir_dados()
        Dim dtg_orc = frm_docs_anteriores.dtg_orc
        If mes_busca = "" Or ano_busca = "" Then
            MsgBox("Mês ou ano não selecionados!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Exit Sub
        End If
        MsgBox("Buscando dados para " & mes_busca & " de " & ano_busca, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO") ' Mensagem de confirmação da busca
        Try
            With dtg_orc
                sql = $"select * from orcamentos where BINARY usuario ='{usuario_logado}' and mes = '{mes_busca}' and ano = '{ano_busca}'" ' BINARY para diferenciar maiusculas e minusculas
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    dtg_orc.Rows.Clear() ' Limpa linhas anteriores

                    Do While Not rs.EOF
                        dtg_orc.Rows.Add(
                            rs.Fields("id").Value,
                            rs.Fields("usuario").Value,
                            rs.Fields("mes").Value,
                            rs.Fields("ano").Value,
                            rs.Fields("tipo").Value,
                            rs.Fields("sub_tipo").Value,
                            rs.Fields("descricao").Value,
                            rs.Fields("valor").Value
                        )
                        rs.MoveNext()
                    Loop
                Else
                    MsgBox("Ainda não há registros!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub nome_user_global(lbl_usuario)
        If usuario_logado = "" Then
            lbl_usuario.Text = "MOQUIDESIA MARIA" ' Exibe o nome gerérico"
        Else
            lbl_usuario.Text = usuario_logado ' Exibe o nome do usuário logado no label "usuario"
        End If
    End Sub
    Sub cmb_mes(cmb_meses)
        cmb_meses.Items.Add("Janeiro") ' Adiciona os meses ao ComboBox
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

    'Estilo dos botões brancos sobre fundo verde
    Public Sub botao_MouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.White
        btn.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Bold)
    End Sub

    Public Sub botao_MouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.ForeColor = Color.FromArgb(65, 127, 88)
        btn.Font = New Font("Franklin Gothic Demi", 20, FontStyle.Regular)
    End Sub

End Module
