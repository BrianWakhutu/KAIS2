Imports KaisII.FormGenClasses

Public Class UcLookupComboBox
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

    Public ReadOnly Property Label As Label Implements UcKaisControl.Label
        Get
            Return vLabel
        End Get
    End Property

    Public ReadOnly Property LookupComboBox As ComboBox
        Get
            Return vLookupComboBox
        End Get
    End Property

    Public ReadOnly Property LookupLabel As Label
        Get
            Return vLabel
        End Get
    End Property

    Private Sub vLookupComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vLookupComboBox.SelectedValueChanged
        Me.OnKeyPress(Nothing)
    End Sub

    Public Sub SetToDefault() Implements UcKaisControl.SetToDefault
        vLookupComboBox.SelectedItem = Nothing
    End Sub

    Public Function GetRealValue() As Object Implements UcKaisControl.GetRealValue
        Return CType(vLookupComboBox.SelectedItem, Lookup)
    End Function

    Public Function GetSkipValue() As String Implements UcKaisControl.GetSkipValue
        Dim l As Lookup = CType(GetRealValue(), Lookup)
        Dim selectedValue As String = Nothing
        If l IsNot Nothing Then
            selectedValue = l.Lkp_mapping
        End If
        Return selectedValue
    End Function

    Public Sub SetDataSource(ByVal dataSource As Object) Implements UcKaisControl.SetDataSource
        vLookupComboBox.DataSource = dataSource
    End Sub

    Public Sub SetLabelText(ByVal text As String) Implements UcKaisControl.SetLabelText
        vLabel.Text = text
    End Sub
End Class
