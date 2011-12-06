Public Class ucSplash
    Public WriteOnly Property QuestionText() As String
        Set(ByVal value As String)
            lblTitle.Text = String.Empty
            lblTitle.Text = value
        End Set
    End Property
    Public WriteOnly Property QuestionCation() As String
        Set(ByVal value As String)
            lblCaption.Text = String.Empty
            lblCaption.Text = value
        End Set
    End Property
End Class
