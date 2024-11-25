Imports System.Reflection.Emit

Public Class Checkout
    Private Sub Checkout(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalLitres.Text = Main.totalLitres.ToString("F2")
        lblTotalPrice.Text = "£" + Main.totalCost.ToString("F2")

        lblByeText.Text = "Thank you for using BMC Fuel Pump Application. Please, press pay now button to pay for your fuel.Have a good day!"
        lblByeText.AutoSize = False
        lblByeText.Width = 350
        lblByeText.Height = 85
        lblByeText.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Me.Hide()
        payForm.Show()
    End Sub
End Class