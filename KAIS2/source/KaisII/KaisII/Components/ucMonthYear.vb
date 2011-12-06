Imports System.Xml
Public Class ucMonthYear
    Public ReadOnly Property ptyAnswer()
        Get
            Return String.Format("{0}/{1}", txtMonth.Value, txtYear.Value)
        End Get
    End Property

    Private Sub chkMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMonth.CheckedChanged
        If chkMonth.Checked Then
            txtMonth.Value = 98
        Else
            txtMonth.Value = txtMonth.Minimum
        End If
    End Sub

    Private Sub chkYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYear.CheckedChanged
        If chkYear.Checked Then
            txtYear.Value = 9898
        Else
            txtYear.Value = txtYear.Minimum
        End If
    End Sub
End Class
