Public Class Form1

  
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OutlookBar1.Buttons("Journal").Selected = True
        Me.OutlookBar2.Buttons("Calendar").Selected = True
    End Sub

 
End Class
