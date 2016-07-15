Public Class Form5

    Private Sub HandleTimerTick()
        Me.Close()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Exorcist___Scream, AudioPlayMode.Background)
        Dim t As Timer = New Timer()
        t.Interval = 5000
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
    End Sub
End Class