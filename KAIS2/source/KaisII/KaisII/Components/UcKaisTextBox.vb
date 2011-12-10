Imports KaisII.FormGenClasses

Public Class UcKaisTextBox
    Implements UcKaisControl

    Private fld As Field
    Public Property UpperCase As Boolean = False

    Public Sub New()
        InitializeComponent()
        Me.Size = New System.Drawing.Size(985, 65)
    End Sub

    Public ReadOnly Property TextBox As TextBox
        Get
            Return vTextBox
        End Get
    End Property

    Public Property Field As FormGenClasses.Field Implements UcKaisControl.Field
        Get
            Return fld
        End Get
        Set(ByVal value As FormGenClasses.Field)
            fld = value
        End Set
    End Property

    Public ReadOnly Property TextLabel As Label
        Get
            Return vLabel
        End Get
    End Property

    Private Sub vTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vTextBox.TextChanged
        If UpperCase Then
            Dim selectionStart As Integer = vTextBox.SelectionStart
            vTextBox.Text = vTextBox.Text.ToUpper()
            vTextBox.SelectionStart = selectionStart
        End If
        Me.OnKeyPress(Nothing)
    End Sub

    Public ReadOnly Property Label As System.Windows.Forms.Label Implements UcKaisControl.Label
        Get
            Return vLabel
        End Get
    End Property

    Public Sub SetDataSource(ByVal dataSource As Object) Implements UcKaisControl.SetDataSource
        'do nothing
    End Sub

    Public Sub SetLabelText(ByVal text As String) Implements UcKaisControl.SetLabelText
        vLabel.Text = text
    End Sub

    Public Sub SetToDefault() Implements UcKaisControl.SetToDefault
        vTextBox.Clear()
    End Sub

    Public Function GetRealValue() As Object Implements UcKaisControl.GetValue
        Return IIf(vTextBox.Text.Equals(""), Nothing, vTextBox.Text)
    End Function

    Public Sub SetRealValue(ByVal value As Object) Implements UcKaisControl.SetValue
        If value IsNot Nothing Then
            vTextBox.Text = TryCast(value, String)
        End If
    End Sub
End Class
