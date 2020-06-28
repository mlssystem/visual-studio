Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked = True Then
            Timer2.Interval = (1)
        End If

        If RadioButton2.Checked = True Then
            Timer2.Interval = (100)
        End If

        If RadioButton3.Checked = True Then
            Timer2.Interval = (200)
        End If

        If RadioButton4.Checked = True Then
            Timer2.Interval = (300)
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Timer2.Start()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Timer2.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SendKeys.Send(TextBox1.Text)
    End Sub
End Class
