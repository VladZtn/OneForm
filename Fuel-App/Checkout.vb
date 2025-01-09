Imports Windows.Win32.UI
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label
Imports Button = System.Windows.Forms.Button

Public Class Checkout
    Inherits Form

    Private lblByeText As Label
    Private Label3 As Label
    Private lblTotalCost As Label
    Private lblTotalPrice As Label
    Private lblLitre As Label
    Private lblTotalLitres As Label
    Private WithEvents btnPay As Button
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        lblByeText = New Label()
        Label3 = New Label()
        lblTotalCost = New Label()
        lblTotalPrice = New Label()
        lblLitre = New Label()
        lblTotalLitres = New Label()
        btnPay = New Button()
        SuspendLayout()
        ' 
        ' lblByeText
        ' 
        lblByeText.FlatStyle = FlatStyle.Flat
        lblByeText.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        lblByeText.Location = New Point(3, 155)
        lblByeText.Name = "lblByeText"
        lblByeText.Size = New Size(350, 94)
        lblByeText.TabIndex = 1
        lblByeText.Text = "Thank you for using BMC Fuel Pump Application. Please, press pay now button to pay for your fuel. Have a good day!"
        lblByeText.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(127, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.TabIndex = 2
        Label3.Text = "Checkout:"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
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
        lblTotalPrice.TabIndex = 4
        lblTotalPrice.Text = "00.00"
        ' 
        ' lblLitre
        ' 
        lblLitre.AutoSize = True
        lblLitre.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblLitre.Location = New Point(77, 59)
        lblLitre.Name = "lblLitre"
        lblLitre.Size = New Size(126, 30)
        lblLitre.TabIndex = 5
        lblLitre.Text = "Total Litres:"
        ' 
        ' lblTotalLitres
        ' 
        lblTotalLitres.AutoSize = True
        lblTotalLitres.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTotalLitres.Location = New Point(209, 59)
        lblTotalLitres.Name = "lblTotalLitres"
        lblTotalLitres.Size = New Size(58, 30)
        lblTotalLitres.TabIndex = 6
        lblTotalLitres.Text = "0.00"
        ' 
        ' btnPay
        ' 
        btnPay.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        btnPay.Location = New Point(84, 252)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(196, 41)
        btnPay.TabIndex = 0
        btnPay.Text = "Pay now"
        ' 
        ' Checkout
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(355, 305)
        ControlBox = False
        Controls.Add(btnPay)
        Controls.Add(lblByeText)
        Controls.Add(Label3)
        Controls.Add(lblTotalCost)
        Controls.Add(lblTotalPrice)
        Controls.Add(lblLitre)
        Controls.Add(lblTotalLitres)
        Name = "Checkout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checkout"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Shared method for handling the Pay button click

    Public Shared Sub payment()
        Dim checkoutForm As New Checkout()
        checkoutForm.Show()
    End Sub

    Private Sub btnPay_Click_1(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim activeForm As Form = Form.ActiveForm

        Hidee.cleaning(activeForm)
        Shows.showee(Main)
    End Sub
End Class
