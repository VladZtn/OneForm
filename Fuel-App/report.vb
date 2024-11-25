Public Class Report
    Private Sub q_Click(sender As Object, e As EventArgs) Handles q.Click
        If txtName.Text <= 3 Or txtSurname.Text <= 3 Or txtEmail.Text <= 3 Then
            MessageBox.Show("Your details are incorrect!")
            txtName.Text = ""
            txtSurname.Text = ""
            txtNumber.Text = ""
            txtEmail.Text = ""
            Exit Sub
        Else
            For Each ch In txtNumber.Text
                If Not Char.IsDigit(ch) Then
                    txtNumber.Text = ""
                    MessageBox.Show("Incorrect phone number format!")
                    Exit Sub
                Else
                    Me.Hide()
                    Menu.Show()
                End If
            Next
            MessageBox.Show("Your report successfully sent, thanks!")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Menu.Show()
    End Sub
End Class