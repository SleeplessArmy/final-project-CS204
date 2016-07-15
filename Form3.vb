Public Class Form3

    

    Private Sub FINISH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINISH.Click
        MessageBox.Show("Next Level!", "Nice One")
        Dim a As New Form4
        Me.Hide()
        a.Show()
    End Sub
    
End Class
