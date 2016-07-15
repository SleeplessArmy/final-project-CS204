Public Class Form3

    

    Private Sub FINISH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FINISH.Click
        MessageBox.Show("Next Level!", "Nice One")
        Dim a As New Form4
        Me.Hide()
        a.Show()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(StartingPoint)

    End Sub
End Class
