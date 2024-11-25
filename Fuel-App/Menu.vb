Public Class Menu
    Private Sub btnFuelForm_Click(sender As Object, e As EventArgs) Handles btnFuelForm.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Close()
        HelpScreen.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class