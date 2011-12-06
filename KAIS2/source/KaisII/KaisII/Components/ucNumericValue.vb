Imports KaisII.FormGenClasses
Public Class ucNumericValue

#Region "Properties"
    Public WriteOnly Property PtyLookupds As List(Of Lookup)
        Set(ByVal value As List(Of Lookup))
            If Not value Is Nothing Then
                For Each lkp As Lookup In value
                    cboValues.Items.Add(lkp)
                Next
            End If
        End Set
    End Property
    Public ReadOnly Property PtyGetValues As String
        Get

        End Get
    End Property
#End Region


    Private Sub cboValues_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboValues.KeyPress
        e.Handled = True
    End Sub


End Class
