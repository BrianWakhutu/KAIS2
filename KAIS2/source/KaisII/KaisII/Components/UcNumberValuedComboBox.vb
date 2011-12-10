Imports KaisII.FormGenClasses

Public Class UcNumberValuedComboBox
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

    Public Function GetRealValue() As Object Implements UcKaisControl.GetValue
        Return New NumberValuedComboBox(CType(vLookupComboBox.SelectedItem, Lookup), vValueNumericUpDown.Value)
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
        vValueNumericUpDown.Value = 0

    End Sub
    Public Sub SetRealValue(ByVal value As Object) Implements UcKaisControl.SetValue
        Dim nl As NumberValuedComboBox = TryCast(value, NumberValuedComboBox)
        If nl IsNot Nothing Then
            vLookupComboBox.SelectedItem = nl.LookUpValue
            vValueNumericUpDown.Value = nl.NumberLookUpValue

        End If
    End Sub

    Private Sub vLookupComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vLookupComboBox.SelectedIndexChanged
        Me.OnKeyPress(Nothing)
    End Sub
End Class
