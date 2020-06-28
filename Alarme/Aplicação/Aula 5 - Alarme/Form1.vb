Public Class FrmAlarme

    Dim alarme As Date

    Private Sub FrmAlarme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Hora.Text = TimeOfDay

        If alarme = Hora.Text Then
            Timer1.Enabled = False
            MessageBox.Show("Vamos que Vamos", "Despertando!")

        End If

    End Sub

    Private Sub Btn_Desl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Desl.Click
        End

    End Sub


    Private Sub Btn_Capturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Capturar.Click

        alarme = MaskedTextBox.Text
        Timer1.Enabled = (True)

    End Sub
End Class
