Public Class Form1

    Private Sub BrowserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserBtn.Click

        OpenFileDialog1.ShowDialog()
        Filepathlabel.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub ExcelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelBtn.Click

        Process.Start("excel", Filepathlabel.Text)

    End Sub

    Private Sub NotepadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadBtn.Click

        Process.Start("notepad", Filepathlabel.Text)

    End Sub

    Private Sub NotepadplusplusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadplusplusBtn.Click

        Process.Start("notepad++", Filepathlabel.Text)

    End Sub

    Private Sub WorldBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorldBtn.Click

        Process.Start("world")


    End Sub
End Class
