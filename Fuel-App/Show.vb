Imports System.ComponentModel

Public Class Shows
    Public Shared Sub showee(ByVal container As Control)

        For Each txt As TextBox In container.Controls.OfType(Of TextBox)()
            txt.Visible = True
        Next

        For Each rdo As RadioButton In container.Controls.OfType(Of RadioButton)()
            rdo.Visible = True
        Next

        For Each btn As Button In container.Controls.OfType(Of Button)()
            btn.Visible = True
        Next

        For Each lbl As Label In container.Controls.OfType(Of Label)()
            lbl.Visible = True
        Next

        For Each pcbx As PictureBox In container.Controls.OfType(Of PictureBox)()
            pcbx.Visible = True
        Next

        container.Show()

    End Sub
End Class