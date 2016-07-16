Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Enabled = True Then
            ProgressBar1.Value = ProgressBar1.Value + 3
        End If
        If ProgressBar1.Value = 99 Then
            Timer1.Enabled = False
           
        End If

    End Sub
End Class
