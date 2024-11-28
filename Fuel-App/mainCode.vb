Imports Windows.Win32.UI
Imports Windows.Win32.UI.Input

Public Class mainForm
    Public Shared Function mainShow()
        For Each txt As TextBox In Main.Controls.OfType(Of TextBox)()
            txt.Visible = True
        Next

        For Each rdo As RadioButton In Main.Controls.OfType(Of RadioButton)()
            rdo.Visible = True
        Next

        For Each btn As Button In Main.Controls.OfType(Of Button)()
            btn.Visible = True
        Next

        For Each lbl As Label In Main.Controls.OfType(Of Label)()
            lbl.Visible = True
        Next

        Main.img.Visible = True

        Main.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Main.AutoScaleMode = AutoScaleMode.Font
        Main.BackColor = Color.SteelBlue
        Main.ClientSize = New Size(668, 326)
        Main.ControlBox = False
        Main.Controls.Add(Main.Button1)
        Main.Controls.Add(Main.lblUPrice)
        Main.Controls.Add(Main.lblDPrice)
        Main.Controls.Add(Main.rdoUnleaded)
        Main.Controls.Add(Main.rdoDiesel)
        Main.Controls.Add(Main.txtLitres)
        Main.Controls.Add(Main.txtSales)
        Main.Controls.Add(Main.lblLitres)
        Main.Controls.Add(Main.lblSales)
        Main.Controls.Add(Main.img)
        Main.Controls.Add(Main.btnExit)
        Main.Controls.Add(Main.btnCheckout)
        Main.Controls.Add(Main.btnRefuel)
        Main.Name = "Main"
        Main.StartPosition = FormStartPosition.CenterScreen
        Main.Text = "Main Page"
        CType(Main.img, ComponentModel.ISupportInitialize).EndInit()
        Main.ResumeLayout(False)
        Main.PerformLayout()

    End Function
End Class