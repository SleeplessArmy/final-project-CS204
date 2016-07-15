Public Class Form2

    
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(85, 85)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub


End Class