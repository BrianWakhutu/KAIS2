Imports System.Xml
Public Class ucDatevb


    Public ReadOnly Property ptyAnswer() As String
        Get
            Return String.Format("{0}/{1}/{2}", txtDay.Value, txtMonth.Value, txtYear.Value)
        End Get
    End Property

    Public WriteOnly Property PtyQuestionText() As String
        Set(ByVal value As String)
            lbltext.Text = value
        End Set
    End Property
    Private Sub chkDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDay.CheckedChanged
        If chkDay.Checked Then
            txtDay.Value = 98
        Else
            txtDay.Value = txtDay.Minimum
        End If
    End Sub

    Private Sub chkMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMonth.CheckedChanged
        If chkMonth.Checked Then

            txtMonth.Value = 98
        Else
            txtMonth.Value = txtMonth.Minimum
        End If
    End Sub

    Private Sub chkYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYear.CheckedChanged
        If chkYear.Checked Then

            txtYear.Value = 98
        Else
            txtYear.Value = txtMonth.Minimum
        End If
    End Sub
    Public Sub ValidateUI()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
