<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpScreen))
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(266, 248)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(233, 56)
        btnBack.TabIndex = 0
        btnBack.Text = "Back to menu"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(228, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 29)
        Label1.TabIndex = 1
        Label1.Text = "How to work with App?"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(776, 135)
        Label2.TabIndex = 2
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' HelpScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(800, 322)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Name = "HelpScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HelpScreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
