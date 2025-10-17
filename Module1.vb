
Module Module1
    Public resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={Mysql ODBC 3.51 Driver};SERVER=localhost;DATABASE=gasto_certo;UID=root;PWD=usbw;port=3307;option=3;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Form1.Close()
        End Try
    End Sub
End Module
