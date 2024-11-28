Imports System.ComponentModel
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label
Imports Button = System.Windows.Forms.Button
Imports Windows.Win32.UI
Imports Windows.Win32.UI.Input

Public Class Hidee
    Public Shared Function clear(ByVal Name As Control)
        Debug.WriteLine(Name)

        For Each txt As TextBox In Name.Controls.OfType(Of TextBox)()
            txt.Visible = False
        Next

        For Each rdo As RadioButton In Name.Controls.OfType(Of RadioButton)()
            rdo.Visible = False
        Next

        For Each btn As Button In Name.Controls.OfType(Of Button)()
            btn.Visible = False
        Next

        For Each lbl As Label In Name.Controls.OfType(Of Label)()
            lbl.Visible = False
        Next

        'For Each img As Image In Name.Controls.OfType(Of Image)()
        'img.Height =
        'Next

    End Function
End Class