Public Class Form1

    Dim Randomico As New Random
    Dim valor(50) As Integer
    Dim numero As Integer

    Private Sub Btn_Chutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Chutar.Click

        For i = 1 To 50 Step 1
            numero = Randomico.Next(99)
            valor(i) = numero
        Next

        Label2.Text = valor(1)
        Label3.Text = valor(2)
        Label4.Text = valor(3)
        Label5.Text = valor(4)
        Label6.Text = valor(5)
        Label7.Text = valor(6)
        Label8.Text = valor(7)
        Label9.Text = valor(8)
        Label10.Text = valor(9)
        Label11.Text = valor(10)
        Label12.Text = valor(11)
        Label13.Text = valor(12)
        Label14.Text = valor(13)
        Label15.Text = valor(14)
        Label16.Text = valor(15)
        Label17.Text = valor(16)
        Label18.Text = valor(17)
        Label19.Text = valor(18)
        Label20.Text = valor(19)
        Label21.Text = valor(20)
        Label22.Text = valor(21)
        Label23.Text = valor(22)
        Label24.Text = valor(23)
        Label25.Text = valor(24)
        Label1.Text = valor(25)
        Label26.Text = valor(1)
        Label26.Text = valor(2)
        Label27.Text = valor(3)
        Label28.Text = valor(4)
        Label29.Text = valor(5)
        Label30.Text = valor(6)
        Label31.Text = valor(7)
        Label32.Text = valor(8)
        Label33.Text = valor(9)
        Label34.Text = valor(10)
        Label35.Text = valor(11)
        Label36.Text = valor(12)
        Label37.Text = valor(13)
        Label38.Text = valor(14)
        Label39.Text = valor(15)
        Label40.Text = valor(16)
        Label41.Text = valor(17)
        Label42.Text = valor(18)
        Label43.Text = valor(19)
        Label44.Text = valor(20)
        Label45.Text = valor(21)
        Label46.Text = valor(22)
        Label47.Text = valor(23)
        Label48.Text = valor(24)
        Label49.Text = valor(25)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
