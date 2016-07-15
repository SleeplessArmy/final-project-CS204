Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Dim t As Timer = New Timer()
        t.Interval = 5000
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
    End Sub

    Private Sub HandleTimerTick()
        Me.Close()
    End Sub
End Class