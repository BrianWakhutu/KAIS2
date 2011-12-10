Imports System.ComponentModel

Public Class KAISDate

    Public Const MIN_DAYS As Integer = 1
    Public Const MAX_DAYS As Integer = 31
    Public Const UNKNOWN_DAYS As Integer = 888
    Public Const MIN_MONTHS As Integer = 1
    Public Const MAX_MONTHS As Integer = 12
    Public Const UNKNOWN_MONTHS As Integer = 888
    Public Const MIN_YEARS As Integer = 1900
    Public Const MAX_YEARS As Integer = 9999
    Public Const UNKNOWN_YEARS As Integer = 888

    Public Sub New()
    End Sub

    Public Sub New(ByVal pDay As Integer, ByVal pMonth As Integer, ByVal pYear As Integer)
        Me.Day = pDay
        Me.Month = pMonth
        Me.Year = pYear
    End Sub

    Public Property Day As Integer
    Public Property Month As Integer
    Public Property Year As Integer


    Public Overrides Function ToString() As String
        Return Day & "/" & Month & "/" & Year
    End Function
End Class
