Imports KaisII.FormGenClasses

Public Class UcOtheredComboBox
    Implements UcKaisControl

    Private fld As Field

    Public Property Field As FormGenClasses.Field Implements UcKaisControl.Field
        Get
            Return fld
        End Get
        Set(ByVal value As FormGenClasses.Field)
            fld = value
        End Set
    End Property

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

    Public Function GetRealValue() As Object Implements UcKaisControl.GetRealValue
        Return New OtheredLookup(CType(vLookupComboBox.SelectedItem, Lookup), vSpecifyTextBox.Text)
    End Function

    Public Function GetSkipValue() As String Implements UcKaisControl.GetSkipValue
        Dim l As Lookup = CType(GetRealValue(), Lookup)
        Dim selectedValue As String = Nothing
        If l IsNot Nothing Then
            selectedValue = l.Lkp_mapping
        End If
        Return selectedValue
    End Function

    Public ReadOnly Property Label As System.Windows.Forms.Label Implements UcKaisControl.Label
        Get
            Return vLabel
        End Get
    End Property

    Public Sub SetDataSource(ByVal dataSource As Object) Implements UcKaisControl.SetDataSource
        vLookupComboBox.DataSource = dataSource
    End Sub

    Public Sub SetLabelText(ByVal text As String) Implements UcKaisControl.SetLabelText
        vLabel.Text = text
    End Sub

    Public Sub SetToDefault() Implements UcKaisControl.SetToDefault
        vLookupComboBox.SelectedItem = Nothing
        vSpecifyTextBox.Clear()
    End Sub
End Class
