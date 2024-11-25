Imports System.ComponentModel

Public Class Main
    Private counter As Double = 0
    Public Shared totalCost As Double = 0
    Public Shared totalLitres As Double
    Public Shared fuelPrice As Double = 0
    Private WithEvents timer As New Timer()
    Private isFilling As Boolean = False
    Public Shared dieselPrice As Double = 1.5
    Public Shared unleadedPrice As Double = 1.45

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalCost = counter * fuelPrice

        lblDPrice.Text = "£" + dieselPrice.ToString("F2") + "/ L"
        lblUPrice.Text = "£" + unleadedPrice.ToString("F2") + "/ L"
    End Sub

    Private Sub rbFuelType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUnleaded.CheckedChanged, rdoDiesel.CheckedChanged
        If rdoDiesel.Checked Then
            fuelPrice = dieselPrice
            rdoUnleaded.Enabled = False
        ElseIf rdoUnleaded.Checked Then
            fuelPrice = unleadedPrice
            rdoDiesel.Enabled = False
        End If
    End Sub

    Private Sub btnRefuel_Click(sender As Object, e As EventArgs) Handles btnRefuel.MouseDown
        If rdoDiesel.Checked = False And rdoUnleaded.Checked = False Then
            MessageBox.Show("You must choose a fuel type!")
            Return '
        End If

        pctGas.BackColor = Color.FromArgb(0, 255, 0)

        isFilling = True
        timer.Start()
    End Sub

    Private Sub btnRefuel_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRefuel.MouseUp
        isFilling = False
        timer.Stop()
        pctGas.BackColor = Color.FromArgb(70, 130, 180)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If isFilling Then
            counter += 0.1
            totalCost = counter * fuelPrice
            totalLitres = counter
            txtSales.Text = "£" + totalCost.ToString("F2")
            txtLitres.Text = counter.ToString("F2")
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        timer.Interval = 100
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Checkout.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        report.show()
    End Sub
End Class