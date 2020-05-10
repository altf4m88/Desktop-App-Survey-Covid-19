Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        Label3.Text = "% " & ProgressBar1.Value
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
            Me.Hide()
            MainMenu.Show()
        End If

    End Sub
End Class