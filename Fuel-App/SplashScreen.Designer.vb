<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        lblGreeeting = New Label()
        Timer1 = New Timer(components)
        ErrorProvider1 = New ErrorProvider(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -4)
        PictureBox1.Margin = New Padding(3, 15, 3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1036, 585)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(364, 392)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(350, 23)
        ProgressBar1.Step = 5
        ProgressBar1.TabIndex = 1
        ' 
        ' lblGreeeting
        ' 
        lblGreeeting.AutoSize = True
        lblGreeeting.BackColor = Color.Transparent
        lblGreeeting.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold Or FontStyle.Italic)
        lblGreeeting.Location = New Point(339, 110)
        lblGreeeting.Name = "lblGreeeting"
        lblGreeeting.Size = New Size(416, 30)
        lblGreeeting.TabIndex = 2
        lblGreeeting.Text = "Welcome to BMC Fuel Pump Application!"
        ' 
        ' Timer1
        ' 
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1032, 581)
        ControlBox = False
        Controls.Add(lblGreeeting)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblGreeeting As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
