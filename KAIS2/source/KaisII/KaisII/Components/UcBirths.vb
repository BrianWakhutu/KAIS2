Imports KaisII.FormGenClasses
Imports System.Data.SqlClient

Public Class UcBirths

    Private vBirthList As List(Of Birth)
    Private vBirthsField As Field

    Public Sub New(ByVal pBirthsField As Field)
        InitializeComponent()
        q203UcKaisDatePicker.MaxYears = Now().Year()
        initialsUcKaisTextBox.UpperCase = True
        Me.vBirthsField = pBirthsField
        DisplayFields(birthsTabControl.Controls)
        SetControlsToDefault(birthsTabControl.Controls)
    End Sub

    Private Sub SetControlsToDefault(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                SetControlsToDefault(ctrl.Controls)
            ElseIf TypeOf ctrl Is UcKaisControl Then
                CType(ctrl, UcKaisControl).SetToDefault()
            End If
        Next
    End Sub

    Private Sub DisplayFields(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                DisplayFields(ctrl.Controls)
            ElseIf TypeOf ctrl Is UcKaisControl Then
                For Each field As Field In vBirthsField.ChildList
                    If field.Fld_QNo.Equals(ctrl.Tag) Then
                        AssociateControlWithField(ctrl, field)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub AssociateControlWithField(ByVal kaisCtrl As UcKaisControl, ByVal field As Field)
        kaisCtrl.SetDataSource(field.fld_Lookups)
        kaisCtrl.SetLabelText(field.Fld_QuestionEnglish)
        kaisCtrl.Field = field
    End Sub

    Dim currentTabpage As TabPage = Nothing
    Private Function ValidateControls(ByVal controls As ControlCollection) As Boolean
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                currentTabpage = CType(ctrl, TabPage)
                Return ValidateControls(ctrl.Controls)
            ElseIf TypeOf ctrl Is UcKaisControl Then
                If ctrl.Enabled Then
                    Dim kaisCtrl As UcKaisControl = CType(ctrl, UcKaisControl)
                    If kaisCtrl.Field.Fld_Mandatory And kaisCtrl.GetRealValue() Is Nothing Then
                        MessageBox.Show("Missing field value! '" & kaisCtrl.Field.Fld_QuestionEnglish & "'", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        If currentTabpage IsNot Nothing Then
                            birthsTabControl.SelectedTab = currentTabpage
                        End If
                        ctrl.Focus()
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        If ValidateControls(birthsTabControl.Controls) Then
            Dim birth As Birth = New Birth()
            birth.initials = CType(initialsUcKaisTextBox.GetRealValue(), String)
            birth.Q202 = CType(q202UcLookupComboBox.GetRealValue(), Lookup)
            birth.Q203 = CType(q203UcKaisDatePicker.GetRealValue(), KAISDate)
            birth.Q204 = CType(q204UcComboWithSpecify.GetRealValue(), OtheredLookup)
            birth.Q205 = CType(q202UcLookupComboBox.GetRealValue, Lookup)
            birth.Q206 = CType(q206UcKaisDatePicker.GetRealValue(), KAISDate)
            birth.Q206a = 1 'TODO: to be set properly later
            birth.Q207 = CType(q202UcLookupComboBox.GetRealValue, Lookup)
            birth.Q208 = CType(q208UcOtheredComboBox.GetRealValue(), OtheredLookup)
            birth.Q208a = CType(q208aComboBox.SelectedItem, Lookup)
            birth.Q209 = CType(q209UcOtheredComboBox.GetRealValue(), OtheredLookup)
            birth.Q210 = CType(q210UcOtheredComboBox.GetRealValue(), OtheredLookup)
            If vBirthList Is Nothing Then
                vBirthList = New List(Of Birth)
            End If
            vBirthList.Add(birth)
            birthsDataGridView.DataSource = Nothing
            birthsDataGridView.DataSource = vBirthList
            SetControlsToDefault(birthsTabControl.Controls)
        End If
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
                    .Parameters.AddWithValue("@q_202", b.Q202.Lkp_No)
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

    Private Sub UpdateLabelsWithInitials(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            Dim label As Label = Nothing
            If TypeOf ctrl Is TabPage Then
                UpdateLabelsWithInitials(ctrl.Controls)
                Continue For
            ElseIf TypeOf ctrl Is UcKaisControl Then
                label = CType(ctrl, UcKaisControl).Label
            Else
                Continue For
            End If
            Dim split1Array As String() = Label.Text.Split("(")
            If split1Array.Length <> 2 Then
                Continue For
            End If
            Dim split2Array As String() = split1Array(1).Split(")")
            If split2Array.Length <> 2 Then
                Continue For
            End If
            label.Text = split1Array(0) & "(" & CType(initialsUcKaisTextBox.GetRealValue(), String) & ")" & split2Array(1)
        Next
    End Sub

    Private Sub initialsUcKaisTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles initialsUcKaisTextBox.KeyPress
        UpdateLabelsWithInitials(birthsTabControl.Controls)
    End Sub

    Private Sub initialsUcKaisTextBox_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub q202UcLookupComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles q202UcLookupComboBox.KeyPress
        ExcecuteSkip(q202UcLookupComboBox)
    End Sub

    Private Sub ExcecuteSkip(ByVal ctrl As Control)
        Dim field As Field = Nothing
        Dim selectedValue As String = Nothing
        If TypeOf ctrl Is UcKaisControl Then
            Dim kaisCtrl As UcKaisControl = CType(ctrl, UcKaisControl)
            field = kaisCtrl.Field
            selectedValue = kaisCtrl.GetSkipValue()
        Else
            Return
        End If
        If field Is Nothing Then
            Return
        Else
            Dim skipList As List(Of Skip) = New List(Of Skip)
            For Each skp As Skip In field.fld_Skips
                Dim affectedControl As Control = GetControlByTag(birthsTabControl.Controls, GetFieldNoToSkipTo(skp, selectedValue))
                If affectedControl IsNot Nothing Then
                    affectedControl.Enabled = skp.Skp_Enabled
                End If
            Next
        End If
    End Sub

    Public Function GetFieldNoToSkipTo(ByVal skip As Skip, ByVal selectedValue As String) As String
        Dim fieldNoToSkipTo As String = Nothing
        Select Case skip.Skp_Operator
            Case "="
                If skip.Skp_FieldValue.Equals(selectedValue) Then
                    If skip.Skp_ToField IsNot Nothing Then
                        fieldNoToSkipTo = skip.Skp_ToField.Fld_QNo
                    End If
                End If
                Exit Select
            Case "Nothing"
                If selectedValue Is Nothing Then
                    If skip.Skp_ToField IsNot Nothing Then
                        fieldNoToSkipTo = skip.Skp_ToField.Fld_QNo
                    End If
                End If
                Exit Select
        End Select
        Return fieldNoToSkipTo
    End Function

    Private Function GetControlByTag(ByVal controls As ControlCollection, ByVal tag As String) As Control
        If tag Is Nothing Then
            Return Nothing
        End If
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                Return GetControlByTag(ctrl.Controls, tag)
            ElseIf TypeOf ctrl Is UcKaisControl Then
                If ctrl.Tag.Equals(tag) Then
                    Return ctrl
                End If
            End If
        Next
        Return Nothing
    End Function
End Class
