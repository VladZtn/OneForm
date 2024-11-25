<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        btnRefuel = New Button()
        btnCheckout = New Button()
        btnExit = New Button()
        pctGas = New PictureBox()
        lblSales = New Label()
        lblLitres = New Label()
        txtSales = New TextBox()
        txtLitres = New TextBox()
        rdoDiesel = New RadioButton()
        rdoUnleaded = New RadioButton()
        lblDPrice = New Label()
        lblUPrice = New Label()
        Button1 = New Button()
        CType(pctGas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRefuel
        ' 
        btnRefuel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnRefuel.Location = New Point(80, 238)
        btnRefuel.Name = "btnRefuel"
        btnRefuel.Size = New Size(143, 43)
        btnRefuel.TabIndex = 0
        btnRefuel.Text = "Refuel"
        btnRefuel.UseVisualStyleBackColor = True
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnCheckout.Location = New Point(268, 238)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(143, 43)
        btnCheckout.TabIndex = 1
        btnCheckout.Text = "Checkout"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnExit.Location = New Point(440, 238)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(143, 43)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' pctGas
        ' 
        pctGas.Image = CType(resources.GetObject("pctGas.Image"), Image)
        pctGas.Location = New Point(57, 36)
        pctGas.Name = "pctGas"
        pctGas.Size = New Size(180, 180)
        pctGas.SizeMode = PictureBoxSizeMode.StretchImage
        pctGas.TabIndex = 3
        pctGas.TabStop = False
        ' 
        ' lblSales
        ' 
        lblSales.AutoSize = True
        lblSales.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblSales.Location = New Point(293, 64)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(51, 21)
        lblSales.TabIndex = 4
        lblSales.Text = "Sales:"
        ' 
        ' lblLitres
        ' 
        lblLitres.AutoSize = True
        lblLitres.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblLitres.Location = New Point(293, 101)
        lblLitres.Name = "lblLitres"
        lblLitres.Size = New Size(54, 21)
        lblLitres.TabIndex = 5
        lblLitres.Text = "Litres:"
        ' 
        ' txtSales
        ' 
        txtSales.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtSales.Location = New Point(377, 61)
        txtSales.Name = "txtSales"
        txtSales.PlaceholderText = "£00.00"
        txtSales.Size = New Size(187, 29)
        txtSales.TabIndex = 6
        txtSales.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtLitres
        ' 
        txtLitres.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        txtLitres.Location = New Point(377, 98)
        txtLitres.Name = "txtLitres"
        txtLitres.PlaceholderText = "00.00"
        txtLitres.Size = New Size(187, 29)
        txtLitres.TabIndex = 7
        txtLitres.TextAlign = HorizontalAlignment.Center
        ' 
        ' rdoDiesel
        ' 
        rdoDiesel.AutoSize = True
        rdoDiesel.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        rdoDiesel.Location = New Point(320, 145)
        rdoDiesel.Name = "rdoDiesel"
        rdoDiesel.Size = New Size(82, 29)
        rdoDiesel.TabIndex = 12
        rdoDiesel.TabStop = True
        rdoDiesel.Text = "Diesel"
        rdoDiesel.UseVisualStyleBackColor = True
        ' 
        ' rdoUnleaded
        ' 
        rdoUnleaded.AutoSize = True
        rdoUnleaded.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        rdoUnleaded.Location = New Point(453, 145)
        rdoUnleaded.Name = "rdoUnleaded"
        rdoUnleaded.Size = New Size(111, 29)
        rdoUnleaded.TabIndex = 13
        rdoUnleaded.TabStop = True
        rdoUnleaded.Text = "Unleaded"
        rdoUnleaded.UseVisualStyleBackColor = True
        ' 
        ' lblDPrice
        ' 
        lblDPrice.AutoSize = True
        lblDPrice.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblDPrice.Location = New Point(338, 177)
        lblDPrice.Name = "lblDPrice"
        lblDPrice.Size = New Size(50, 21)
        lblDPrice.TabIndex = 14
        lblDPrice.Text = "00.00"
        ' 
        ' lblUPrice
        ' 
        lblUPrice.AutoSize = True
        lblUPrice.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblUPrice.Location = New Point(492, 177)
        lblUPrice.Name = "lblUPrice"
        lblUPrice.Size = New Size(50, 21)
        lblUPrice.TabIndex = 15
        lblUPrice.Text = "00.00"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(563, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 38)
        Button1.TabIndex = 16
        Button1.Text = "Report "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(668, 326)
        ControlBox = False
        Controls.Add(Button1)
        Controls.Add(lblUPrice)
        Controls.Add(lblDPrice)
        Controls.Add(rdoUnleaded)
        Controls.Add(rdoDiesel)
        Controls.Add(txtLitres)
        Controls.Add(txtSales)
        Controls.Add(lblLitres)
        Controls.Add(lblSales)
        Controls.Add(pctGas)
        Controls.Add(btnExit)
        Controls.Add(btnCheckout)
        Controls.Add(btnRefuel)
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Page"
        CType(pctGas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRefuel As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pctGas As PictureBox
    Friend WithEvents lblSales As Label
    Friend WithEvents lblLitres As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtLitres As TextBox
    Friend WithEvents rdoDiesel As RadioButton
    Friend WithEvents rdoUnleaded As RadioButton
    Friend WithEvents lblDPrice As Label
    Friend WithEvents lblUPrice As Label
    Friend WithEvents Button1 As Button

End Class