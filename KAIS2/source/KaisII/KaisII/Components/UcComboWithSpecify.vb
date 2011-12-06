Imports KaisII.FormGenClasses

Public Class UcComboWithSpecify

    Public ReadOnly Property SpecifyLabel As Label
        Get
            Return vSpecifyLabel
        End Get
    End Property

    Public ReadOnly Property LookupComboBox As ComboBox
        Get
            Return vLookupComboBox
        End Get
    End Property

    Public ReadOnly Property SpecifyTextBox As TextBox
        Get
            Return vSpecifyTextBox
        End Get
    End Property

    Private Sub vLookupComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vLookupComboBox.SelectedIndexChanged
        Dim selectedLookup = CType(vLookupComboBox.SelectedItem, Lookup)
        If selectedLookup IsNot Nothing Then
            If selectedLookup.Lkp_IsOtherSpecify Then
                vSpecifyTextBox.Enabled = True
            Else
                vSpecifyTextBox.Enabled = False
                vSpecifyTextBox.Text = String.Empty
            End If
        End If
    End Sub
End Class
