<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payForm
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
        txtCardNum = New TextBox()
        txtCardDate = New TextBox()
        txtCardCVV = New TextBox()
        Label1 = New Label()
        btnPay = New Button()
        txtCardName = New TextBox()
        SuspendLayout()
        ' 
        ' txtCardNum
        ' 
        txtCardNum.Location = New Point(36, 113)
        txtCardNum.MaxLength = 16
        txtCardNum.Name = "txtCardNum"
        txtCardNum.PlaceholderText = "Card number"
        txtCardNum.Size = New Size(194, 23)
        txtCardNum.TabIndex = 0
        ' 
        ' txtCardDate
        ' 
        txtCardDate.Location = New Point(36, 142)
        txtCardDate.MaxLength = 5
        txtCardDate.Name = "txtCardDate"
        txtCardDate.PlaceholderText = "10/27"
        txtCardDate.Size = New Size(81, 23)
        txtCardDate.TabIndex = 1
        ' 
        ' txtCardCVV
        ' 
        txtCardCVV.Location = New Point(159, 142)
        txtCardCVV.MaxLength = 3
        txtCardCVV.Name = "txtCardCVV"
        txtCardCVV.PlaceholderText = "CVV "
        txtCardCVV.Size = New Size(71, 23)
        txtCardCVV.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(36, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 29)
        Label1.TabIndex = 3
        Label1.Text = "Checkout Form"
        ' 
        ' btnPay
        ' 
        btnPay.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPay.Location = New Point(36, 182)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(190, 34)
        btnPay.TabIndex = 4
        btnPay.Text = "Pay now"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' txtCardName
        ' 
        txtCardName.Location = New Point(36, 84)
        txtCardName.MaxLength = 16
        txtCardName.Name = "txtCardName"
        txtCardName.PlaceholderText = "Holder's name"
        txtCardName.Size = New Size(194, 23)
        txtCardName.TabIndex = 5
        ' 
        ' payForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(283, 268)
        ControlBox = False
        Controls.Add(txtCardName)
        Controls.Add(btnPay)
        Controls.Add(Label1)
        Controls.Add(txtCardCVV)
        Controls.Add(txtCardDate)
        Controls.Add(txtCardNum)
        Name = "payForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents txtCardDate As TextBox
    Friend WithEvents txtCardCVV As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents txtCardName As TextBox
End Class
