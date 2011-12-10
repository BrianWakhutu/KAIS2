Imports KaisII.FormGenClasses

Public Class UcLookupComboBox
    Implements UcKaisControl

    Private fld As Field

    Public Sub New()
        InitializeComponent()
        Me.Size = New System.Drawing.Size(985, 65)
    End Sub

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

    Public Sub SetToDefault() Implements UcKaisControl.SetToDefault
        vLookupComboBox.SelectedItem = Nothing
    End Sub

    Public Sub SetDataSource(ByVal dataSource As Object) Implements UcKaisControl.SetDataSource
        vLookupComboBox.DataSource = dataSource
    End Sub

    Public Sub SetLabelText(ByVal text As String) Implements UcKaisControl.SetLabelText
        vLabel.Text = text
    End Sub

    Public Function GetRealValue() As Object Implements UcKaisControl.GetValue
        Return CType(vLookupComboBox.SelectedItem, Lookup)
    End Function

    Private Sub vLookupComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vLookupComboBox.SelectedIndexChanged
        Me.OnKeyPress(Nothing)
    End Sub

    Public Sub SetRealValue(ByVal value As Object) Implements UcKaisControl.SetValue
        Dim l As Lookup = TryCast(value, Lookup)
        If l IsNot Nothing Then
            vLookupComboBox.SelectedItem = l
        End If
    End Sub
End Class
