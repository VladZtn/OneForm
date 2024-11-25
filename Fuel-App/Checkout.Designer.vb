<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTotalLitres = New Label()
        lblLitre = New Label()
        lblTotalCost = New Label()
        lblTotalPrice = New Label()
        btnPay = New Button()
        Label3 = New Label()
        lblByeText = New Label()
        SuspendLayout()
        ' 
        ' lblTotalLitres
        ' 
        lblTotalLitres.AutoSize = True
        lblTotalLitres.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTotalLitres.Location = New Point(209, 59)
        lblTotalLitres.Name = "lblTotalLitres"
        lblTotalLitres.Size = New Size(71, 30)
        lblTotalLitres.TabIndex = 0
        lblTotalLitres.Text = "00.00"
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
        lblTotalPrice.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTotalPrice.Location = New Point(209, 112)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(71, 30)
        lblTotalPrice.TabIndex = 2
        lblTotalPrice.Text = "00.00"
        ' 
        ' btnPay
        ' 
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
        lblByeText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(204))
        lblByeText.Location = New Point(3, 155)
        lblByeText.Name = "lblByeText"
        lblByeText.Size = New Size(350, 94)
        lblByeText.TabIndex = 6
        lblByeText.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Checkout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(355, 305)
        ControlBox = False
        Controls.Add(lblByeText)
        Controls.Add(Label3)
        Controls.Add(btnPay)
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

    Friend WithEvents lblTotalLitres As Label
    Friend WithEvents lblLitre As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblByeText As Label
End Class
