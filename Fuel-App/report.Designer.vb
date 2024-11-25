<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        q = New Button()
        lblReport = New Label()
        txtMessage = New RichTextBox()
        txtName = New TextBox()
        txtSurname = New TextBox()
        txtEmail = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNumber = New TextBox()
        Label4 = New Label()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' q
        ' 
        q.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        q.Location = New Point(60, 243)
        q.Name = "q"
        q.Size = New Size(222, 31)
        q.TabIndex = 2
        q.Text = "Report"
        q.UseVisualStyleBackColor = True
        ' 
        ' lblReport
        ' 
        lblReport.AutoSize = True
        lblReport.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblReport.Location = New Point(12, 9)
        lblReport.Name = "lblReport"
        lblReport.Size = New Size(122, 25)
        lblReport.TabIndex = 3
        lblReport.Text = "Report form "
        ' 
        ' txtMessage
        ' 
        txtMessage.BorderStyle = BorderStyle.None
        txtMessage.Location = New Point(85, 110)
        txtMessage.Name = "txtMessage"
        txtMessage.Size = New Size(413, 118)
        txtMessage.TabIndex = 4
        txtMessage.Text = "Enter your message here:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(85, 52)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Jame"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 6
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(375, 52)
        txtSurname.Name = "txtSurname"
        txtSurname.PlaceholderText = "Smith"
        txtSurname.Size = New Size(100, 23)
        txtSurname.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(85, 81)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "example@gmail.com"
        txtEmail.Size = New Size(163, 23)
        txtEmail.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(35, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 17)
        Label1.TabIndex = 9
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(37, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 17)
        Label2.TabIndex = 10
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(304, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 17)
        Label3.TabIndex = 11
        Label3.Text = "Surname:"
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(375, 81)
        txtNumber.Name = "txtNumber"
        txtNumber.PlaceholderText = "+44 7911 123456"
        txtNumber.Size = New Size(163, 23)
        txtNumber.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(264, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 17)
        Label4.TabIndex = 13
        Label4.Text = "Mobile number:"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnBack.Location = New Point(331, 243)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(222, 31)
        btnBack.TabIndex = 14
        btnBack.Text = "Back to menu"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Report
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(579, 289)
        ControlBox = False
        Controls.Add(btnBack)
        Controls.Add(Label4)
        Controls.Add(txtNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEmail)
        Controls.Add(txtSurname)
        Controls.Add(txtName)
        Controls.Add(txtMessage)
        Controls.Add(lblReport)
        Controls.Add(q)
        Name = "Report"
        StartPosition = FormStartPosition.CenterParent
        Text = "Report "
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents q As Button
    Friend WithEvents lblReport As Label
    Friend WithEvents txtMessage As RichTextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
End Class
