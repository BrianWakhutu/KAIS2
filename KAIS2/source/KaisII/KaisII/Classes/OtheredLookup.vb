Imports KaisII.FormGenClasses

Public Class OtheredLookup

    Private vLookup As Lookup
    Private vOther As String

    Public Sub New(ByVal pLookup As Lookup, ByVal pOther As String)
        Me.vLookup = pLookup
        Me.vOther = pOther
    End Sub

    Public ReadOnly Property Lookup As Lookup
        Get
            Return vLookup
        End Get
    End Property
    Public ReadOnly Property Other As String
        Get
            Return vOther
        End Get
    End Property

    Public Overrides Function ToString() As String
        If vLookup Is Nothing Then
            Return ""
        End If
        Return vLookup.ToString()
    End Function

End Class
