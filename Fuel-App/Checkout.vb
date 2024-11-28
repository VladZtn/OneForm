Imports Windows.Win32.UI
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label
Imports Button = System.Windows.Forms.Button

Public Class checkout
    Public Shared Function payment()
        Dim lblByeText As New Label
        Dim Label3 As New Label
        Dim lblTotalCost As New Label
        Dim lblTotalPrice As New Label
        Dim lblLitre As New Label
        Dim lblTotalLitres As New Label
        Dim btnPay As New Button



        lblTotalLitres.AutoSize = True
        lblTotalLitres.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTotalLitres.Location = New Point(209, 59)
        lblTotalLitres.Name = "lblTotalLitres"
        lblTotalLitres.Size = New Size(71, 30)
        lblTotalLitres.TabIndex = 0
        lblTotalLitres.Text = Main.totalLitres.ToString("F2")
        ' 
        ' lblLitre
        ' 
        lblLitre.AutoSize = True
        lblLitre.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lblLitre.Location = New Point(77, 59)
        lblLitre.Name = "lblLitre"
        lblLitre.Size = New Size(126, 30)
        lblLitre.TabIndex = 1
        lblLitre.Text = "Total Litres:"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lblTotalCost.Location = New Point(81, 112)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(122, 30)
        lblTotalCost.TabIndex = 3
        lblTotalCost.Text = "Total Sales:"
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTotalPrice.Location = New Point(209, 112)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(71, 30)
        lblTotalPrice.TabIndex = 2
        lblTotalPrice.Text = "00.00"
        ' 
        ' btnPay
        ' 
        AddHandler btnPay.Click, AddressOf btnPay_Click

        btnPay.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnPay.Location = New Point(84, 252)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(196, 41)
        btnPay.TabIndex = 4
        btnPay.Text = "Pay now"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(127, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 5
        Label3.Text = "Checkout:"
        ' 
        ' lblByeText
        ' 
        lblByeText.FlatStyle = FlatStyle.Flat
        lblByeText.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(204))
        lblByeText.Location = New Point(3, 155)
        lblByeText.Name = "lblByeText"
        lblByeText.Size = New Size(350, 94)
        lblByeText.TabIndex = 6
        lblByeText.TextAlign = ContentAlignment.TopCenter
        lblByeText.Text = "Thank you for using BMC Fuel Pump Application. Please, press pay now button to pay for your fuel.Have a good day!"

        ' Checkout
        ' 
        Main.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Main.AutoScaleMode = AutoScaleMode.Font
        Main.BackColor = Color.SteelBlue
        Main.ClientSize = New Size(355, 305)
        Main.ControlBox = False
        Main.Controls.Add(lblByeText)
        Main.Controls.Add(Label3)
        Main.Controls.Add(btnPay)
        Main.Controls.Add(lblTotalCost)
        Main.Controls.Add(lblTotalPrice)
        Main.Controls.Add(lblLitre)
        Main.Controls.Add(lblTotalLitres)
        Main.Name = "Checkout"
        Main.StartPosition = FormStartPosition.CenterScreen
        Main.Text = "Checkout"
        Main.ResumeLayout(False)
        Main.PerformLayout()



    End Function

    Shared Sub btnPay_Click(sender As Object, e As EventArgs)
        Dim afForm As Form = Form.ActiveForm
        MessageBox.Show("Thanks for your payment!")
        Hidee.clear(afForm)
        mainForm.mainShow()

        Debug.WriteLine(afForm)
    End Sub

End Class