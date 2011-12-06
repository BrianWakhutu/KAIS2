Imports KaisII.FormGenClasses
Imports System.Data.SqlClient

Module ModGlobalVars
    Public oCurField As Field
    Public _lookups As List(Of Lookup)
    'Public oCurstaff As New staff
    Public iHouseHoldID As Integer
    Public sHouseHoldGuid As Guid

    Public _iVisitID As Integer
    Public sckAnsweredQuestions As New Stack
    Public sckPoppedQuestions As New Stack
    Public _iSelectedForm As SelectedForm
    Public _Fields As List(Of Field)
    Public sAnswerValue As String
    Public sAppName As String = "KAIS Datac collection System"
    Public _AppLocalConn As New SqlConnection("Data Source=HP-PC\SQLEXPRESS;Initial Catalog=KaisII;Persist Security Info=True;User ID=sa;Password=Maun2806")
    Public Enum SelectedForm
        Household = 2
        Children = 3
    End Enum
End Module

