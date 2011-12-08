Imports KaisII.FormGenClasses

Public Class SexPartnerMatrix
    Public Property initials As String
    Public Property Q_421 As Lookup
    Public Property Q_422 As Lookup
    Public Property Q_422Value As String
    Public Property Q_423 As Lookup
    Public Property Q_423Value As String
    Public Property Q_424 As Lookup
    Public Property Q_425 As Lookup
    Public Property Q_426 As Lookup
    Public Property Q_427 As Lookup
    Public Property Q_428 As Lookup
    Public Property Q_429 As Lookup
    Public Property Q_430 As Lookup
    Public Property Q_431 As Lookup
    Public Property Q_432 As Lookup
    Public Property Q_433 As Lookup
    'Explore capability of Loading Line number from DataBase
    Public Property Q_433LineNumber As Integer ' Default 00
    Public Property Q_433LivingTogetherAsMarried As Lookup
    Public Property Q_433Value As String
    Public Property Q_434 As Lookup
    Public Property Q_435 As Lookup
    Public Property Q_436 As Lookup
    Public Property Q_436Value As String
    Public Property Q_437 As Lookup
    Public Property Q_438 As Lookup
    Public Property Q_439 As Lookup
    Public Property Q_440 As Lookup
    Public Property Q_441 As Lookup
    Public Property Q_442 As Lookup
    Public Property vParentforeignKey As Integer
    Public Sub New()
    End Sub
    Public Sub New(ByVal parentForeignKey As Integer)
        Me.vParentforeignKey = parentForeignKey
    End Sub


End Class
