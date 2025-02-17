﻿Imports System.ComponentModel

Public Class Hidee
    Public Shared Sub cleaning(ByVal container As Control)

        If container Is Nothing Then
            MessageBox.Show("Container is Nothing.")
            Return '
        End If

        For Each txt As TextBox In container.Controls.OfType(Of TextBox)()
            txt.Visible = False
        Next

        For Each rdo As RadioButton In container.Controls.OfType(Of RadioButton)()
            rdo.Visible = False
        Next

        For Each btn As Button In container.Controls.OfType(Of Button)()
            btn.Visible = False
        Next

        For Each lbl As Label In container.Controls.OfType(Of Label)()
            lbl.Visible = False
        Next

        For Each pcbx As PictureBox In container.Controls.OfType(Of PictureBox)()
            pcbx.Visible = False
        Next

        Form.ActiveForm.Hide()
    End Sub
End Class