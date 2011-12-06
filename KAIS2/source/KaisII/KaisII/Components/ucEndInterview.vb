Public Class ucEndInterview
    Public WriteOnly Property Quetiontext As String
        Set(ByVal value As String)
            lblCaption.Text = value
        End Set
    End Property
    Private Sub lblCaption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaption.Click

    End Sub
End Class
