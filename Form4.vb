﻿Public Class Form4

    Private Sub Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finish.Click
        MessageBox.Show("Congratulations!", "Nice One")
        Dim a As New Form5
        Me.Hide()
        a.Show()

    End Sub


End Class