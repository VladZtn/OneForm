<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        lblCurrentD = New Label()
        lblCurrentU = New Label()
        txtNewUnleaded = New TextBox()
        txtNewDiesel = New TextBox()
        lblDieselU = New Label()
        lblUnleadedU = New Label()
        lblNewDiesel = New Label()
        lblNewUnleaded = New Label()
        btnSubmit = New Button()
        Label1 = New Label()
        btnBack = New Button()
        lblS = New Label()
        lblL = New Label()
        lblTotalF = New Label()
        lblTotalS = New Label()
        SuspendLayout()
        ' 
        ' lblCurrentD
        ' 
        lblCurrentD.AutoSize = True
        lblCurrentD.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCurrentD.Location = New Point(246, 61)
        lblCurrentD.Name = "lblCurrentD"
        lblCurrentD.Size = New Size(50, 21)
        lblCurrentD.TabIndex = 0
        lblCurrentD.Text = "00.00"
        ' 
        ' lblCurrentU
        ' 
        lblCurrentU.AutoSize = True
        lblCurrentU.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblCurrentU.Location = New Point(246, 95)
        lblCurrentU.Name = "lblCurrentU"
        lblCurrentU.Size = New Size(50, 21)
        lblCurrentU.TabIndex = 1
        lblCurrentU.Text = "00.00"
        ' 
        ' txtNewUnleaded
        ' 
        txtNewUnleaded.Location = New Point(202, 169)
        txtNewUnleaded.Name = "txtNewUnleaded"
        txtNewUnleaded.PlaceholderText = "00.00"
        txtNewUnleaded.Size = New Size(100, 23)
        txtNewUnleaded.TabIndex = 9
        txtNewUnleaded.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtNewDiesel
        ' 
        txtNewDiesel.Location = New Point(202, 134)
        txtNewDiesel.Name = "txtNewDiesel"
        txtNewDiesel.PlaceholderText = "00.00"
        txtNewDiesel.Size = New Size(100, 23)
        txtNewDiesel.TabIndex = 8
        txtNewDiesel.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblDieselU
        ' 
        lblDieselU.AutoSize = True
        lblDieselU.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblDieselU.Location = New Point(36, 61)
        lblDieselU.Name = "lblDieselU"
        lblDieselU.Size = New Size(158, 21)
        lblDieselU.TabIndex = 4
        lblDieselU.Text = "Current Diesel price:"
        ' 
        ' lblUnleadedU
        ' 
        lblUnleadedU.AutoSize = True
        lblUnleadedU.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblUnleadedU.Location = New Point(36, 90)
        lblUnleadedU.Name = "lblUnleadedU"
        lblUnleadedU.Size = New Size(184, 21)
        lblUnleadedU.TabIndex = 5
        lblUnleadedU.Text = "Current Unleaded price:"
        ' 
        ' lblNewDiesel
        ' 
        lblNewDiesel.AutoSize = True
        lblNewDiesel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblNewDiesel.Location = New Point(24, 134)
        lblNewDiesel.Name = "lblNewDiesel"
        lblNewDiesel.Size = New Size(135, 21)
        lblNewDiesel.TabIndex = 6
        lblNewDiesel.Text = "New Diesel Price:"
        ' 
        ' lblNewUnleaded
        ' 
        lblNewUnleaded.AutoSize = True
        lblNewUnleaded.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblNewUnleaded.Location = New Point(24, 169)
        lblNewUnleaded.Name = "lblNewUnleaded"
        lblNewUnleaded.Size = New Size(161, 21)
        lblNewUnleaded.TabIndex = 7
        lblNewUnleaded.Text = "New Unleaded Price:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(104, 208)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(139, 34)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        Label1.Location = New Point(123, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 30)
        Label1.TabIndex = 11
        Label1.Text = "Dashboard"
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(59, 360)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(218, 34)
        btnBack.TabIndex = 12
        btnBack.Text = "Back to main menu"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblS
        ' 
        lblS.AutoSize = True
        lblS.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblS.Location = New Point(227, 320)
        lblS.Name = "lblS"
        lblS.Size = New Size(50, 21)
        lblS.TabIndex = 16
        lblS.Text = "00.00"
        ' 
        ' lblL
        ' 
        lblL.AutoSize = True
        lblL.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblL.Location = New Point(227, 286)
        lblL.Name = "lblL"
        lblL.Size = New Size(50, 21)
        lblL.TabIndex = 15
        lblL.Text = "00.00"
        ' 
        ' lblTotalF
        ' 
        lblTotalF.AutoSize = True
        lblTotalF.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblTotalF.Location = New Point(58, 316)
        lblTotalF.Name = "lblTotalF"
        lblTotalF.Size = New Size(147, 25)
        lblTotalF.TabIndex = 14
        lblTotalF.Text = "Today's income:"
        ' 
        ' lblTotalS
        ' 
        lblTotalS.AutoSize = True
        lblTotalS.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        lblTotalS.Location = New Point(12, 282)
        lblTotalS.Name = "lblTotalS"
        lblTotalS.Size = New Size(193, 25)
        lblTotalS.TabIndex = 13
        lblTotalS.Text = "Today's Solded Litres:"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(325, 424)
        Controls.Add(lblS)
        Controls.Add(lblL)
        Controls.Add(lblTotalF)
        Controls.Add(lblTotalS)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(lblNewUnleaded)
        Controls.Add(lblNewDiesel)
        Controls.Add(lblUnleadedU)
        Controls.Add(lblDieselU)
        Controls.Add(txtNewDiesel)
        Controls.Add(txtNewUnleaded)
        Controls.Add(lblCurrentU)
        Controls.Add(lblCurrentD)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCurrentD As Label
    Friend WithEvents lblCurrentU As Label
    Friend WithEvents txtNewUnleaded As TextBox
    Friend WithEvents txtNewDiesel As TextBox
    Friend WithEvents lblDieselU As Label
    Friend WithEvents lblUnleadedU As Label
    Friend WithEvents lblNewDiesel As Label
    Friend WithEvents lblNewUnleaded As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblS As Label
    Friend WithEvents lblL As Label
    Friend WithEvents lblTotalF As Label
    Friend WithEvents lblTotalS As Label
End Class
