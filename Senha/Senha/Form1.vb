Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click

        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            MsgBox("Logou se com sucesso", vbInformation, "Permitido")
            FrmCriandoSenha.show()
        ElseIf MsgBox("Login ou senha errada!", vbCritical, "Negado!") Then

        End If

    End Sub
End Class
