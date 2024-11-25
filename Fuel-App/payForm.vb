Public Class payForm
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If Len(txtCardNum.Text) <= 0 Or Len(txtCardDate.Text) <= 0 Or Len(txtCardCVV.Text) <= 0 Then
            MessageBox.Show("You can't leave this field empty!")
        Else
            MessageBox.Show("Thanks for your payment, you will redirect back!")
            Me.Hide()
            Menu.Show()
        End If
    End Sub
End Class