Imports KaisII.FormGenClasses

Public Class UcKaisDatePicker
    Implements UcKaisControl

    Public Property MinDays As Integer = KAISDate.MIN_DAYS
    Public Property MaxDays As Integer = KAISDate.MAX_DAYS
    Public Property UnknownDays As Integer = KAISDate.UNKNOWN_DAYS
    Public Property MinMonths As Integer = KAISDate.MIN_MONTHS
    Public Property MaxMonths As Integer = KAISDate.MAX_MONTHS
    Public Property UnknownMonths As Integer = KAISDate.UNKNOWN_MONTHS
    Public Property MinYears As Integer = KAISDate.MIN_YEARS
    Public Property MaxYears As Integer = KAISDate.MAX_YEARS
    Public Property UnknownYears As Integer = KAISDate.UNKNOWN_YEARS
    Private fld As Field

    Public Sub New()
        InitializeComponent()
        SetToDefault()
        Me.Size = New System.Drawing.Size(985, 65)
    End Sub

    Public Property Field As Field Implements UcKaisControl.Field
        Get
            Return fld
        End Get
        Set(ByVal value As FormGenClasses.Field)
            fld = value
        End Set
    End Property

    Public ReadOnly Property Label As System.Windows.Forms.Label Implements UcKaisControl.Label
        Get
            Return Me.vLabel
        End Get
    End Property

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
        If days <> UnknownDays Then
            If days < MinDays Then
                vDayNUD.Value = MinDays
            ElseIf days > MaxDays Then
                vDayNUD.Value = MaxDays
            End If
        End If
        Me.OnKeyPress(Nothing)
    End Sub

    Private Sub vMonthNUD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vMonthNUD.ValueChanged
        Dim months As Integer = vMonthNUD.Value
        If months <> UnknownMonths Then
            If months < MinMonths Then
                vMonthNUD.Value = MinMonths
            ElseIf months > MaxMonths Then
                vMonthNUD.Value = MaxMonths
            End If
        End If
        Me.OnKeyPress(Nothing)
    End Sub

    Private Sub vYearNUD_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vYearNUD.ValueChanged
        Dim years As Integer = vYearNUD.Value
        If years <> UnknownYears Then
            If years < MinYears Then
                vYearNUD.Value = MinYears
            ElseIf years > MaxYears Then
                vYearNUD.Value = MaxYears
            End If
        End If
        Me.OnKeyPress(Nothing)
    End Sub

    Public Sub SetDataSource(ByVal dataSource As Object) Implements UcKaisControl.SetDataSource
        'do nothing
    End Sub

    Public Sub SetLabelText(ByVal text As String) Implements UcKaisControl.SetLabelText
        vLabel.Text = text
    End Sub

    Public Sub SetToDefault() Implements UcKaisControl.SetToDefault
        vDayNUD.Minimum = IIf(MinDays < UnknownDays, MinDays, UnknownDays)
        vDayNUD.Maximum = IIf(MaxDays > UnknownDays, MaxDays, UnknownDays)
        vMonthNUD.Minimum = IIf(MinMonths < UnknownMonths, MinMonths, UnknownMonths)
        vMonthNUD.Maximum = IIf(MaxMonths > UnknownMonths, MaxMonths, UnknownMonths)
        vYearNUD.Minimum = IIf(MinYears < UnknownYears, MinYears, UnknownYears)
        vYearNUD.Maximum = IIf(MaxYears > UnknownYears, MaxYears, UnknownYears)
        vDayNUD.Value = UnknownDays
        vMonthNUD.Value = UnknownMonths
        vYearNUD.Value = UnknownYears
    End Sub


    Public Function GetRealValue() As Object Implements UcKaisControl.GetValue
        Return New KAISDate(vDayNUD.Value, vMonthNUD.Value, vYearNUD.Value)
    End Function

    Public Sub SetRealValue(ByVal value As Object) Implements UcKaisControl.SetValue
        Dim kd As KAISDate = TryCast(value, KAISDate)
        If kd IsNot Nothing Then
            vDayNUD.Value = kd.Day
            vMonthNUD.Value = kd.Month
            vYearNUD.Value = kd.Year
        End If
    End Sub
End Class
