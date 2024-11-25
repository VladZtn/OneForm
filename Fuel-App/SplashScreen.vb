Public NotInheritable Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        If (ProgressBar1.Value = 100) Then
            Me.Hide()
            Menu.Show()
            Timer1.Enabled = False
            Timer1.Stop()
        End If
    End Sub
End Class
