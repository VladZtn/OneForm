Imports Windows.Win32.UI
Imports Windows.Win32.UI.Input
Imports Label = System.Windows.Forms.Label
Imports Button = System.Windows.Forms.Button

Public Class mainForm
    Inherits Form
    Public Shared Sub mainShow(mainFormInstance As mainForm)
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

        For Each pcbx As PictureBox In Main.Controls.OfType(Of PictureBox)()
            pcbx.Visible = True
        Next


        Main.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Main.AutoScaleMode = AutoScaleMode.Font
        Main.BackColor = Color.SteelBlue
        Main.ClientSize = New Size(668, 326)
        Main.ControlBox = False
        Main.Name = "Main"
        Main.StartPosition = FormStartPosition.CenterScreen
        Main.Text = "Main Page"
        CType(Main.pctBox, ComponentModel.ISupportInitialize).EndInit()
        Main.ResumeLayout(False)
        Main.PerformLayout()
    End Sub
End Class