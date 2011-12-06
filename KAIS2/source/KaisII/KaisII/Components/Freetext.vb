Public Class Freetext

    Private Sub Freetext_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

#Region "Properties"
    Public WriteOnly Property QuestionString As String
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property

    Public Property ptyResponse() As String
        Get
            Return txtFreetext.Text
        End Get
        Set(ByVal value As String)
            txtFreetext.Text = value
            txtFreetext.Focus()
        End Set
    End Property
#Region "Methods"
    Public Sub ClearMe()

        txtFreetext.Text = String.Empty
        lblText.Text = String.Empty
    End Sub

    Public Function ValidateUI() As Boolean
        If Len(txtFreetext.Text) = 0 Then
            txtFreetext.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#End Region

    Private Sub txtFreetext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreetext.TextChanged
        txtFreetext.BackColor = Color.White
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
