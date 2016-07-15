Public Class Form2

    
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(85, 85)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Angry_Birds_Rio_Background_music, AudioPlayMode.BackgroundLoop)

    End Sub

End Class