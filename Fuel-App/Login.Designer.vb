<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(88, 68)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter your login"
        txtUsername.Size = New Size(177, 23)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(88, 106)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Enter your password"
        txtPassword.Size = New Size(177, 23)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        btnLogin.Location = New Point(77, 155)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(102, 31)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(43, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 32)
        Label1.TabIndex = 3
        Label1.Text = "Login"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Button1.Location = New Point(196, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 30)
        Button1.TabIndex = 4
        Button1.Text = "Clear form"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(361, 228)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
