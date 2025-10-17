Public Class tela_principal_test
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Desejá realmente sair do programa ?", vbQuestion + vbYesNo, "ATENÇÃO")
        If resp = vbYes Then
            Form1.close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        orçamento.ShowDialog()
    End Sub
End Class