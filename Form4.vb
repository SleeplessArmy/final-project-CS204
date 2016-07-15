Public Class Form4

   
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Wall_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter, Panel1.MouseEnter, Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label96.MouseEnter, Label95.MouseEnter, Label94.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label91.MouseEnter, Label90.MouseEnter, Label9.MouseEnter, Label89.MouseEnter, Label88.MouseEnter, Label87.MouseEnter, Label86.MouseEnter, Label85.MouseEnter, Label83.MouseEnter, Label82.MouseEnter, Label81.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label133.MouseEnter, Label132.MouseEnter, Label131.MouseEnter, Label130.MouseEnter, Label13.MouseEnter, Label129.MouseEnter, Label128.MouseEnter, Label127.MouseEnter, Label126.MouseEnter, Label125.MouseEnter, Label124.MouseEnter, Label123.MouseEnter, Label122.MouseEnter, Label121.MouseEnter, Label120.MouseEnter, Label12.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label116.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label11.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label101.MouseEnter, Label100.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MoveToStart()

    End Sub
    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(StartingPoint)

    End Sub
End Class