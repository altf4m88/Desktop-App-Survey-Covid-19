Public Class MainMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konek()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Survey.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hasil.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        About.Show()
        Me.Hide()

    End Sub
End Class
