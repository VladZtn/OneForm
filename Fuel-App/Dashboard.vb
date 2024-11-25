Public Class Dashboard
    Public Shared newDPrice As Double
    Public Shared newUPrice As Double
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentD.Text = "£" + Main.dieselPrice.ToString("F2")
        lblCurrentU.Text = "£" + Main.unleadedPrice.ToString("F2")

        lblS.Text = "£" & Main.totalCost.ToString("F2")
        lblL.Text = Main.totalLitres.ToString("F2") & " L"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MessageBox.Show("Successfully changed!")
        Main.dieselPrice = txtNewDiesel.Text
        Main.unleadedPrice = txtNewUnleaded.Text
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Menu.Show()
    End Sub
End Class