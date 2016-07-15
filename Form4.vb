Public Class Form4

    Private Sub Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finish.Click
        MessageBox.Show("Congratulations!", "Nice One")
        Dim a As New Form5
        Me.Hide()
        a.Show()

    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(StartingPoint)

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Angry_Birds_Rio_Background_music, AudioPlayMode.BackgroundLoop)
    End Sub
End Class