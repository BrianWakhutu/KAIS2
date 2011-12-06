Public Class UcKAISDobPicker

    Private Const MAX_DAYS_ALLOWED As Integer = 31
    Private Const MAX_MONTHS_ALLOWED As Integer = 12
    Private MAX_YEARS_ALLOWED As Integer = Now().Year()
    Private Const UNKNOWN_INDICATOR As Integer = 888

    Public Sub New()
        InitializeComponent()
        vDayNUD.Minimum = 0
        vMonthNUD.Minimum = 0
        vYearNUD.Minimum = 0
        vDayNUD.Maximum = IIf(MAX_DAYS_ALLOWED < UNKNOWN_INDICATOR, UNKNOWN_INDICATOR, MAX_DAYS_ALLOWED)
        vMonthNUD.Maximum = IIf(MAX_MONTHS_ALLOWED < UNKNOWN_INDICATOR, UNKNOWN_INDICATOR, MAX_DAYS_ALLOWED)
        vYearNUD.Maximum = IIf(MAX_YEARS_ALLOWED < UNKNOWN_INDICATOR, UNKNOWN_INDICATOR, MAX_DAYS_ALLOWED)
    End Sub

    Public ReadOnly Property DayNUD() As NumericUpDown
        Get
            Return Me.vDayNUD
        End Get
    End Property

    Public ReadOnly Property MonthNUD() As NumericUpDown
        Get
            Return Me.vMonthNUD
        End Get
    End Property

    Public ReadOnly Property YearNUD() As NumericUpDown
        Get
            Return Me.vYearNUD
        End Get
    End Property

    Public ReadOnly Property DayLabel() As Label
        Get
            Return Me.vDayLabel
        End Get
    End Property

    Public ReadOnly Property MonthLabel() As Label
        Get
            Return Me.vMonthLabel
        End Get
    End Property

    Public ReadOnly Property YearLabel() As Label
        Get
            Return Me.vYearLabel
        End Get
    End Property

    Private Sub vDayNUD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vDayNUD.ValueChanged
        Dim days As Integer = vDayNUD.Value
        If days > MAX_DAYS_ALLOWED And days <> UNKNOWN_INDICATOR Then
            vDayNUD.Value = MAX_DAYS_ALLOWED
        End If
    End Sub

    Private Sub vMonthNUD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vMonthNUD.ValueChanged
        Dim months As Integer = vMonthNUD.Value
        If months > MAX_MONTHS_ALLOWED And months <> UNKNOWN_INDICATOR Then
            vMonthNUD.Value = MAX_MONTHS_ALLOWED
        End If
    End Sub

    Private Sub vYearNUD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vYearNUD.ValueChanged
        Dim years As Integer = vMonthNUD.Value
        If years > MAX_YEARS_ALLOWED And years <> UNKNOWN_INDICATOR Then
            vMonthNUD.Value = MAX_YEARS_ALLOWED
        End If
    End Sub
End Class
