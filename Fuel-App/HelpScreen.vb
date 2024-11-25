Public Class HelpScreen
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Menu.Show()
    End Sub
End Class