Public Class Idadade
    Dim Nome As String
    Dim Nascimento As Integer
    Dim AnoAtual As Integer
    Dim Total As Integer
    Dim Idade As String
    Private Sub Idadade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Nome = InputBox(" Qual é o seu nome?", "Nome")
        Txt_Hoje.Text = Date.Today.Year

    End Sub

    Private Sub Btn_Caucular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Caucular.Click
        Nascimento = Txt_Nascimento.Text
        AnoAtual = Txt_Hoje.Text
        Total = AnoAtual - Nascimento
        Idade = Total
        MessageBox.Show("Olá " + Nome + ", esse é o ano em que você faz " + Idade + " anos.", "Resultado", MessageBoxButtons.OK)
    End Sub

    Private Sub btn_Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpar.Click
        Txt_Nascimento.Text = ""

    End Sub
End Class
