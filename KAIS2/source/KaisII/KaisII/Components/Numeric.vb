Public Class Numeric

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

#Region "Properties"
    Public WriteOnly Property QuestionText As String
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property
#End Region
    Public Property ptyResponse() As String
        Get
            Return txtNumeric.Text
        End Get
        Set(ByVal value As String)

            txtNumeric.Text = value
        End Set
    End Property

    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeric.KeyPress
        txtNumeric.BackColor = Color.White
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Cr AndAlso e.KeyChar <> "." Then
            Beep()
            e.Handled = True
        End If
    End Sub

#Region "Methods"
    Public Sub ClearMe()

        txtNumeric.Text = String.Empty
        lblText.Text = String.Empty
    End Sub

    Public Function ValidateUI() As Boolean
        If Len(txtNumeric.Text) = 0 Then

            txtNumeric.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function
#End Region
End Class
