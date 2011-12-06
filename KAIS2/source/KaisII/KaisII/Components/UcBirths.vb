Imports KaisII.FormGenClasses
Imports System.Data.SqlClient

Public Class UcBirths

    Private vBirthList As List(Of Birth)
    Private birthsField As Field

    Public Sub New(ByVal birthsField As Field)
        InitializeComponent()
        Me.birthsField = birthsField
        DisplayFields(birthsTabControl.Controls)
    End Sub

    Private Sub DisplayFields(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                DisplayFields(ctrl.Controls)
            ElseIf TypeOf ctrl Is Label Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is UcComboWithSpecify Then
                For Each field As Field In birthsField.ChildList
                    If TypeOf ctrl Is Label Then
                        If field.Fld_No = ctrl.Tag Then
                            AssociateFields(field, ctrl)
                            Exit For
                        End If
                    ElseIf TypeOf ctrl Is ComboBox Or TypeOf ctrl Is UcComboWithSpecify Then
                        If field.Fld_No = ctrl.Tag Then
                            AssociateLookups(field, ctrl)
                            Exit For
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub AssociateFields(ByVal field As Field, ByVal ctrl As Control)
        Dim label As Label = CType(ctrl, Label)
        label.Text = field.Fld_QuestionEnglish
    End Sub

    Private Sub AssociateLookups(ByVal field As Field, ByVal ctrl As Control)
        If TypeOf ctrl Is ComboBox Then
            Dim comboBox As ComboBox = CType(ctrl, ComboBox)
            comboBox.DataSource = field.fld_Lookups
        ElseIf TypeOf ctrl Is UcComboWithSpecify Then
            Dim ucComboWithSpecify As UcComboWithSpecify = CType(ctrl, UcComboWithSpecify)
            ucComboWithSpecify.LookupComboBox.DataSource = field.fld_Lookups
        End If
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        Dim birth As Birth = New Birth()
        birth.initials = initialsTextBox.Text
        birth.Q_202 = CType(q202ComboBox.SelectedItem, Lookup)
        birth.Q_203_day = q203UcKaisDatePicker.DayNUD.Value
        birth.Q_203_month = q203UcKaisDatePicker.MonthNUD.Value
        birth.Q_203_year = q203UcKaisDatePicker.YearNUD.Value
        birth.Q_204 = CType(q204UcComboWithSpecify.LookupComboBox.SelectedItem, Lookup)
        birth.Q_204_other = q204UcComboWithSpecify.SpecifyTextBox.Text
        If vBirthList Is Nothing Then
            vBirthList = New List(Of Birth)
        End If
        vBirthList.Add(birth)
        birthsDataGridView.DataSource = Nothing
        birthsDataGridView.DataSource = vBirthList
    End Sub

    Public Function SaveBirths() As Boolean
        Dim success As Boolean = False
        Try
            Dim sqlCom As New SqlCommand("SaveBirths")
            For Each b As Birth In vBirthList
                With sqlCom
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _AppLocalConn
                    .Parameters.AddWithValue("@initials", b.initials)
                    .Parameters.AddWithValue("@q_202", b.Q_202.Lkp_No)
                    .Parameters.AddWithValue("@female_id", b.foreignKey)

                End With
                DataAccess.AppSaveData(sqlCom)
                sqlCom.Parameters.Clear()
            Next
            success = True
        Catch ex As Exception
            Throw ex
        End Try
        Return success
    End Function

    Private Sub initialsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles initialsTextBox.TextChanged
        UpdateLabelsWithInitials(birthsTabControl.Controls)
    End Sub

    Private Sub UpdateLabelsWithInitials(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                UpdateLabelsWithInitials(ctrl.Controls)
            ElseIf TypeOf ctrl Is Label Then
                Dim label As Label = CType(ctrl, Label)
                Dim split1Array As String() = label.Text.Split("(")
                If split1Array.Length <> 2 Then
                    Continue For
                End If
                Dim split2Array As String() = split1Array(1).Split(")")
                If split2Array.Length <> 2 Then
                    Continue For
                End If
                label.Text = split1Array(0) & "(" & initialsTextBox.Text & ")" & split2Array(1)
            End If
        Next
    End Sub
End Class
