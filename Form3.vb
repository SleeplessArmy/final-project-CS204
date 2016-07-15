Public Class Form3

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
