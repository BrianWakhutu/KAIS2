Imports KaisII.FormGenClasses


Public Class NumberValuedComboBox
    Private vLookup As Lookup
    Private vNumberLookUpValue As Integer

    Public Sub New(ByVal pLookup As Lookup, ByVal NumberLookUpValue As Integer)
        Me.vLookup = pLookup
        Me.vNumberLookUpValue = NumberLookUpValue
    End Sub

    Public ReadOnly Property LookUpValue As Lookup
        Get
            Return vLookup
        End Get
    End Property
    Public ReadOnly Property NumberLookUpValue As String
        Get
            Return vNumberLookUpValue
        End Get
    End Property
End Class
