Imports KaisII.FormGenClasses

Public Class UcOtheredComboBox
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
        Me.OnKeyPress(Nothing)
    End Sub

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

    Public Function GetRealValue() As Object Implements UcKaisControl.GetValue
        Return New OtheredLookup(CType(vLookupComboBox.SelectedItem, Lookup), vSpecifyTextBox.Text)
    End Function

    Private Sub vSpecifyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vSpecifyTextBox.TextChanged
        Me.OnKeyPress(Nothing)
    End Sub

    Public Sub SetRealValue(ByVal value As Object) Implements UcKaisControl.SetValue
        Dim ol As OtheredLookup = TryCast(value, OtheredLookup)
        If ol IsNot Nothing Then
            vLookupComboBox.SelectedItem = ol.Lookup
            SpecifyTextBox.Text = ol.Other
        End If
    End Sub
End Class
