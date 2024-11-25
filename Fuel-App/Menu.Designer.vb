<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        btnFuelForm = New Button()
        btnHelp = New Button()
        btnExit = New Button()
        lblMenu = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' btnFuelForm
        ' 
        btnFuelForm.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFuelForm.Location = New Point(72, 88)
        btnFuelForm.Name = "btnFuelForm"
        btnFuelForm.Size = New Size(135, 42)
        btnFuelForm.TabIndex = 0
        btnFuelForm.Text = "Car Fueling"
        btnFuelForm.UseVisualStyleBackColor = True
        ' 
        ' btnHelp
        ' 
        btnHelp.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnHelp.Location = New Point(72, 136)
        btnHelp.Name = "btnHelp"
        btnHelp.Size = New Size(135, 42)
        btnHelp.TabIndex = 1
        btnHelp.Text = "Help"
        btnHelp.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.Location = New Point(85, 261)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(106, 31)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblMenu
        ' 
        lblMenu.AutoSize = True
        lblMenu.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        lblMenu.ForeColor = Color.WhiteSmoke
        lblMenu.Location = New Point(99, 34)
        lblMenu.Name = "lblMenu"
        lblMenu.Size = New Size(80, 32)
        lblMenu.TabIndex = 3
        lblMenu.Text = "Menu"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.Location = New Point(72, 184)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(135, 59)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login " & vbCrLf & "(only for admins)"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(267, 304)
        ControlBox = False
        Controls.Add(btnLogin)
        Controls.Add(lblMenu)
        Controls.Add(btnExit)
        Controls.Add(btnHelp)
        Controls.Add(btnFuelForm)
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnFuelForm As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnLogin As Button
End Class
