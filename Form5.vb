Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Exorcist___Scream, AudioPlayMode.Background)
        Dim t As Timer = New Timer()
        t.Interval = 5000
        t.Start()
    End Sub
End Class