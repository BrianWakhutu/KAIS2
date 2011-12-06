Imports System.Data.SqlClient
Imports KaisII.FormGenClasses
Imports System.Text

Public Class Interview
    Private _FromSearch As Boolean = False
    Private sName As String
    Private iLineNumber As String

    Public Property ptyCurrentControl() As String
    Private sTablename As String

    Public Property ptyTableName() As String
        Get
            Return sTablename
        End Get
        Set(ByVal value As String)
            sTablename = value
        End Set
    End Property
#Region "Method"
    Private Function ReturnQuestionNumber(ByVal sQNo As String) As String
        ReturnQuestionNumber = String.Empty
        If sQNo.Contains("Splash") Then
            Return ""
            Exit Function
        End If
        If sQNo.Contains("_") Then
            ReturnQuestionNumber = String.Empty
            Dim Sval() As String = sQNo.Split("_")
            Return Sval(1)
        End If
    End Function
    Public Sub LoadData()
        sckAnsweredQuestions.Clear() ''forward stack to store the already passed question
        sckPoppedQuestions.Clear() '' back stack to store backed to question
        _iSelectedForm = SelectedForm.Household
        If _iSelectedForm = SelectedForm.Household Then
            sTablename = "dbo.HousedChar"
        ElseIf _iSelectedForm = SelectedForm.Children Then
            sTablename = "Children"
        End If
        _lookups = DataAccess.LoadLookUps()
        _Fields = DataAccess.LoadFields(_iSelectedForm) '(iSelectedForm)

        InsertDummyRecord()
        GetNextQuestion()

    End Sub

    Private Sub InsertDummyRecord()
        Dim sqlComm As New SqlCommand("GetHHID")
        With sqlComm
            .Connection = _AppLocalConn
            .CommandType = CommandType.StoredProcedure
        End With
        Try
            Dim ds As DataSet = DataAccess.AppGetDataSet(sqlComm)
            If Not ds Is Nothing Then
                iHouseHoldID = ds.Tables(0).Rows(0).Item("HouseholdID")
                sHouseHoldGuid = ds.Tables(0).Rows(0).Item("HouseHoldGuid")
            End If
        Catch ex As Exception
            MsgBox("Error Loading Household Main IDs- " & ex.Message, , sAppName)
        End Try
    End Sub

    Private Function ReturnValuesFromStack(ByVal scStack As Stack, ByVal scBack As Stack) As String
        'SM returs a string of field numbers in the stack
        ReturnValuesFromStack = String.Empty
        Dim strBuilder As New StringBuilder

        Try
            If scBack.Count > 0 Then
                'For i As Integer = 0 To scBack.Count - 1

                'Next
                For Each ofield As Field In scBack
                    'Debug.Print()
                    scStack.Push(ofield)
                Next
            End If
            scBack.Clear()
            'SM 
            sckPoppedQuestions.Clear()
            'sckAnsweredQuestions.Clear()
            For Each ofld As Field In scStack
                If Len(strBuilder.ToString) = 0 Then
                    strBuilder.Append(ofld.Fld_No)
                Else
                    strBuilder.Append("," & ofld.Fld_No)
                End If
                Debug.Print(strBuilder.ToString)
            Next
            Return strBuilder.ToString

        Catch ex As Exception
            MsgBox(ex.Message & " Error loading interview")

            'With xFrmErrorLog
            '    .ptyErrorMessage = ex.Message
            '    .ShowDialog()
            'End With
            'LogError(ex.Message & ex.StackTrace, sUserActions, gsDeviceId)
        Finally
            strBuilder = Nothing
        End Try

    End Function
    Public Function GetLastId(ByVal sColumn As String, ByVal sTable As String) As Integer
        GetLastId = 0
        Dim strSql As String = String.Format("SELECT Max({0}) as [Max_recordId] FROM   {1}", sColumn, sTable)
        Dim SqlCom As New SqlCommand()
        Dim ds As New DataSet
        With SqlCom
            .CommandText = strSql
            .CommandType = CommandType.Text
            .Connection = _AppLocalConn
        End With
        ds = DataAccess.AppGetDataSet(SqlCom, "LastId")
        If ds.Tables.Count > 0 Then
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("Max_recordId")) Then
                Return CInt(ds.Tables(0).Rows(0).Item("Max_recordId"))
            Else
                Return 0
            End If
        End If

    End Function
    Private Sub HideControls()
        Freetext1.Visible = False
        UcMultivalue1.Visible = False
        Numeric1.Visible = False
        UcOptionSingleDomain1.Visible = False
        UcSingleDomain1.Visible = False
        'TimeControl1.Visible = False
        UcDatevb1.Visible = False
        UcSplash1.Visible = False
        UcEndInterview1.Visible = False
        UcVisits1.Visible = False
        UcMonthYear1.Visible = False
        Uc3011.Visible = False
        UcLineNumber1.Visible = False
        UcHouseholdMembers1.Visible = False
        'new code
        If UcBirths1 IsNot Nothing Then
            UcBirths1.Visible = False
        End If

    End Sub
    Public Sub GetNextQuestion()
        'Return LoadNextQuestion(ptyCurrentQuestion, CalculateSkip(ptyCurrentQuestion)) 'this will load the next field.
        LoadNextQuestion()
        If Not oCurField Is Nothing Then
            DisplayNextControl(oCurField.Fld_Type)
        End If

        'SetNavigationMenus()
    End Sub
    Private Function ReturnCurrentFiend(ByVal fldNo As Integer, ByVal Byindex As Boolean) As Field
        Dim ofld As New Field
        If Byindex Then
            ofld = _Fields.Find(Function(x) x.Fld_Index = fldNo)
        Else
            ofld = _Fields.Find(Function(x) x.Fld_No = fldNo)
        End If
        Return ofld
    End Function
    Private Sub LoadNextQuestion()
        'Load the next question
        'Check if the stack has question If blank Load the First Question.
        Dim iFieldSkip As Integer
        If sckAnsweredQuestions.Count = 0 Then ' Loading the first Question in the questionaire.
            If sckPoppedQuestions.Count > 0 Then
                'Load the first item on the Back stack
                oCurField = CType(sckPoppedQuestions.Peek, Field) '
            Else
                oCurField = ReturnCurrentFiend(29, True)
                'oCurField = LoadField(117, True, iFormId)
            End If
            Exit Sub
        Else
            If oCurField Is Nothing Then 'This when you come from search
                sckPoppedQuestions.Push(sckAnsweredQuestions.Peek)
                oCurField = CType(sckAnsweredQuestions.Pop, Field)
                Exit Sub
            End If

            If sckPoppedQuestions.Count = 0 Then
                'We Have Not Moved Back 
                iFieldSkip = CalculateSkip(oCurField) 'Calculate Skip
                If iFieldSkip > 0 Then ''Skip has Evaluated 
                    'OcurField = CType(sckPoppedQuestions.Pop(), Field) 'Load the field to skip to
                    oCurField = ReturnCurrentFiend(iFieldSkip, False) ''Load the Next Question
                Else
                    oCurField = ReturnCurrentFiend(oCurField.Fld_Index + 1, True) ''Load the Next Question
                End If
            Else 'We Had Moved Back
                iFieldSkip = CalculateSkip(oCurField) 'Recalculate the Skip to check if the skip Pattern has been affected.
                If iFieldSkip > 0 Then ''Skip has Evaluated 
                    ''Check if Field in Back Stack (sckPoppedQuestions) is the same as this one 
                    If iFieldSkip <> CType(sckPoppedQuestions.Peek, Field).Fld_No Then
                        'Then Skip has been changed.
                        'Delete all the Subsequently answered questions before skipping.
                        While sckPoppedQuestions.Count > 0
                            DeleteQuestionsAffectedBySkip(CType(sckPoppedQuestions.Pop, Field).Fld_No) 'Delete all affected by the skip.
                        End While
                        oCurField = ReturnCurrentFiend(iFieldSkip, False) 'Load the field to skip to
                    Else
                        oCurField = CType(sckPoppedQuestions.Peek(), Field)
                    End If
                Else
                    If oCurField.Fld_HasSkip Then
                        'Means the skip evaluated but the Value may have changed
                        'Compare the in the Back stack with the next one to come are they the same?
                        If CType(sckPoppedQuestions.Peek(), Field).Fld_No <> ReturnCurrentFiend(oCurField.Fld_Index + 1, True).Fld_No Then
                            ''We are supposed to move to the Next Question But we must clear the tree built by the earlier skip
                            While sckPoppedQuestions.Count > 0
                                DeleteQuestionsAffectedBySkip(CType(sckPoppedQuestions.Pop, Field).Fld_No) 'Delete all affected by the skip.
                            End While
                            oCurField = ReturnCurrentFiend(oCurField.Fld_Index + 1, True) 'Load the field to skip to
                        Else
                            ''The question in the Back Stack is the correct one
                            oCurField = CType(sckPoppedQuestions.Peek(), Field)
                        End If
                    Else
                        ''Means Skip Failed to evaluate and hence we move to the next question in the stack 
                        oCurField = CType(sckPoppedQuestions.Peek(), Field)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub DeleteQuestionsAffectedBySkip(ByVal ifld_No As Integer)
        'Dim sSQl As String = ""
        'Try
        '    sSQl = String.Format("DELETE OtherAnswers WHERE oa_qaId in (SELECT qa_RowId FROM QuestionnaireAnswers WHERE  qa_FieldId={0} AND qa_MainRecordId ={1})", ifld_No, iHouseholdID)
        '    Using SQLceCom As New SqlCeCommand(sSQl)
        '        If AppDeleteData(SQLceCom) Then
        '            sSQl = String.Format("DELETE [QuestionnaireAnswers] WHERE qa_FieldId={0} AND qa_MainRecordId={1}", ifld_No, iHouseholdID)
        '            SQLceCom.CommandText = sSQl
        '            AppDeleteData(SQLceCom)
        '        End If
        '    End Using

        'Catch ex As Exception
        '    Dim retValue As DialogResult
        '    With frmErrorLog
        '        .ptyErrorMessage = ex.Message
        '        retValue = .ShowDialog()
        '    End With
        '    LogError(ex.Message & ex.StackTrace, sUserActions, gsDeviceId)
        'End Try
    End Sub
    Private Function CalculateSkip(ByVal oField As Field) As Integer
        'This method returns the next skip of a question
        'We assume at this point we have the field loaded.
        Dim oSkip As Skip = Nothing

        If oCurField.Fld_Type = 5 Then ''Current control is a Lookup
            'sAnswerValue = oCurField.fld_Lookups.FindLookup(oCurField.Fld_AnswerValue).Lkp_Code
            Dim Temp() As String
            Temp = oCurField.Fld_AnswerValue.Split("|")
            sAnswerValue = Temp(0)
        End If

        If oCurField.Fld_Type = 9 Then
            Dim temp() As String
            temp = oCurField.Fld_AnswerValue.Split("|")
            sAnswerValue = temp(0)
        End If

        If oCurField.Fld_Type = 6 Then
            sAnswerValue = oCurField.Fld_AnswerValue
        End If

        If Not oField.fld_Skips Is Nothing Then

            For Each skp As Skip In oField.fld_Skips
                If skp.Skp_Operator = "*" Then 'Mandatory Skip
                    CalculateSkip = skp.Skp_SkipToField
                    Exit For
                ElseIf skp.Skp_Operator = "=" Then ''Equal To
                    If sAnswerValue = skp.Skp_FieldValue Then
                        CalculateSkip = skp.Skp_SkipToField
                        Exit For
                    Else
                        CalculateSkip = -1
                    End If
                ElseIf skp.Skp_Operator.ToUpper = "IN" Then
                    Dim sAllowedSkipValues() As String = skp.Skp_FieldValue.Split(",")
                    For Each s As String In sAllowedSkipValues
                        If s = sAnswerValue Then
                            CalculateSkip = skp.Skp_SkipToField
                            Exit Function
                        Else
                            CalculateSkip = -1
                        End If
                    Next
                ElseIf skp.Skp_Operator = "<>" Then
                    If sAnswerValue <> skp.Skp_FieldValue Then
                        CalculateSkip = skp.Skp_SkipToField
                        Exit For
                    Else
                        CalculateSkip = -1
                    End If
                ElseIf skp.Skp_Operator = "CONTAINS" Then
                    If sAnswerValue.Contains(skp.Skp_FieldValue) Then
                        CalculateSkip = skp.Skp_SkipToField
                        Exit For
                    Else
                        CalculateSkip = -1
                    End If
                Else
                    Return -1 'Skip Failed to Validate
                End If
            Next
        Else ''No Skip
            Return -1 'No Skip on this Field
        End If
    End Function

    Private Function DoesLookupContainOtherSpy() As Boolean
        DoesLookupContainOtherSpy = False
        For Each lkp As Lookup In oCurField.fld_Lookups
            If lkp.Lkp_IsOtherSpecify Then
                Return True
                Exit Function
            End If
        Next
    End Function

    Private Sub DisplayNextControl(ByVal iFieldType As Integer)
        Select Case iFieldType
            Case 1 ''"FreeText"
                PopulateFreeTextUI()
            Case 2 ''"numeric"
                PopulateDateUI()
            Case 3
                PopulateNumericUI()

            Case 4 ''"Splash"
                PopulateSplashUI()
            Case 5 ''"Lookup"
                If oCurField.fld_Lookups.Count <= 5 And DoesLookupContainOtherSpy() = False Then
                    PopulateOptionSingleDomainUI()
                Else
                    PopulateSingleDomainUI()
                End If
            Case 6

            Case 7 ''MultivaluedLookup 
                PopulateMultivalueUI()

            Case 35
                'PopulateInterviewCode()
            Case 18
                PopulateEndInterview()
            Case 11
                PopulateUCHHMembers()
            Case 9
                PopulateUCVisits()
            Case 10
                PopulateEndInterview()
                'new code
            Case 30
                PopulateBirthsUI()
        End Select

    End Sub
    Private Sub PopulateSingleDomainUI()
        HideControls()
        With UcSingleDomain1
            .ClearMe()
            .Visible = True
            .Dock = DockStyle.Fill
            .BringToFront()
            .ptyLookupsCol = oCurField.fld_Lookups

            '.pbContextmenu.ContextMenuStrip = Me.cnContextMenu
            'Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
            Me.ptyCurrentControl = .Name ''Set Current Control

            .ptyQuestionText = String.Format("{0}. {1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
            .ptyCaption = oCurField.Fld_CaptionEnglish
            '.ptyInstructionText = oCurField.Fld_InstructionTextEnglish

            If oCurField.Fld_AnswerValue <> "" Then
                Dim str() As String
                str = oCurField.Fld_AnswerValue.Split("|")
                'Dim obj As Lookup = oCurField.fld_Lookups.FindLookupByCode(str(0))
                Dim obj As Lookup = oCurField.fld_Lookups.Find(Function(x) x.Lkp_Code = str(0))
                .ptySelectedValue = obj
                If obj.Lkp_IsOtherSpecify Then
                    .ptyOtherSpecify = str(1)
                End If
            End If
        End With
    End Sub
    Private Sub GetPreviousQuestion()
        Dim oField As New Field
        If sckAnsweredQuestions.Count > 0 Then
            'Returns the question number to move back to.
            oCurField = CType(sckAnsweredQuestions.Peek, Field)

            sckPoppedQuestions.Push(oCurField)
            sckAnsweredQuestions.Pop()
        Else 'We are at the Interview Start. 
            Dim retVal As MsgBoxResult = MsgBox(String.Format("Moving Back from this screen will close the current interview.{0}{0} Do you want to Proceed?.", vbCrLf), MsgBoxStyle.Information + MsgBoxStyle.YesNo, sAppName)
            If retVal = MsgBoxResult.Yes Then
                _Fields = Nothing
                _lookups = Nothing
                sHouseHoldGuid = Nothing
                Me.Close()
            End If

            Exit Sub
        End If
        DisplayPreviousControl()
    End Sub
    Private Sub DisplayPreviousControl()
        'If oCurField Is Nothing Then Exit Sub
        Select Case oCurField.Fld_Type
            Case 1 ''"FreeText"
                PopulateFreeTextUI()
            Case 2 '"numeric"
                PopulateNumericUI()
            Case 3
                PopulateDateUI()
            Case 4 ''"Splash"
                PopulateSplashUI()
            Case 5 ''"Lookup"
                If oCurField.fld_Lookups.Count > 4 Then
                    PopulateSingleDomainUI()
                Else
                    PopulateOptionSingleDomainUI()
                End If
            Case 7 '"MultiValueLookup"
                PopulateMultivalueUI()
            Case 6
                'Just get the Pre Que
                GetPreviousQuestion()
                'Case 32
                '    PopulateTimeUI()
            Case 35
                'PopulateInterviewCode()
                'Case 36, 37
                '    'Just get the Prev Que
                '    GetPreviousQuestion()
        End Select
    End Sub
    Private Sub PopulateFreeTextUI()
        HideControls()
        'Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        With Freetext1
            .ClearMe()
            .Visible = True
            .Dock = DockStyle.Fill
            .Visible = True
            .BringToFront()
            .txtFreetext.ReadOnly = False
            '.pbContextmenu.ContextMenu = Me.cnContextMenu
            .QuestionString = String.Format("{0}.{1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
            Me.ptyCurrentControl = .Name
            .txtFreetext.Focus()
            If Len(oCurField.Fld_AnswerValue) > 0 Then
                .ptyResponse = oCurField.Fld_AnswerValue
            End If

        End With
    End Sub

    Private Sub PopulateEndInterview()
        HideControls()
        Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        With UcEndInterview1
            .Visible = True
            .Dock = DockStyle.Fill
            .Visible = True
            .BringToFront()
            'cmdNext.Enabled = False
            '.pbContextmenu.ContextMenu = Me.cnContextMenu
            Me.ptyCurrentControl = .Name
            .Quetiontext = oCurField.Fld_QuestionEnglish
        End With
    End Sub
    Private Sub PopulateNumericUI()
        HideControls()
        'Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        With Numeric1
            .ClearMe()
            .Visible = True
            .Dock = DockStyle.Fill
            .BringToFront()
            ' .pbContextmenu.ContextMenuStrip = Me.cnContextMenu
            '.pbContextMenu.ContextMenu = Me.cntxMnuMain
            Me.ptyCurrentControl = .Name
            .QuestionText = String.Format("{0}. {1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
            'If iLanguage = Language.English Then
            '    .ptyQuestionText = oCurField.Fld_QuestionEnglish
            '    .ptyInstructionText = oCurField.Fld_InstructionTextEnglish
            '    .ptyCaption = oCurField.Fld_CaptionEnglish
            'Else
            '    .ptyQuestionText = oCurField.Fld_QuestionLocal
            '    .ptyInstructionText = oCurField.Fld_InstructionTextLocal
            '    .ptyCaption = oCurField.Fld_CaptionLocal
            'End If
            If Len(oCurField.Fld_AnswerValue) > 0 Then
                .ptyResponse = oCurField.Fld_AnswerValue
            End If

            .txtNumeric.Focus()
        End With
    End Sub
    'Private Sub PopulateInterviewCode()
    '    HideControls()
    '    'Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
    '    With InterviewerCode1

    '        .Visible = True
    '        .Dock = DockStyle.Fill
    '        .BringToFront()
    '        ' .pbContextmenu.ContextMenuStrip = Me.cnContextMenu
    '        '.pbContextMenu.ContextMenu = Me.cntxMnuMain
    '        Me.ptyCurrentControl = .Name
    '        .QuestionText = String.Format("{0}. {1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
    '        'If iLanguage = Language.English Then
    '        '    .ptyQuestionText = oCurField.Fld_QuestionEnglish
    '        '    .ptyInstructionText = oCurField.Fld_InstructionTextEnglish
    '        '    .ptyCaption = oCurField.Fld_CaptionEnglish
    '        'Else
    '        '    .ptyQuestionText = oCurField.Fld_QuestionLocal
    '        '    .ptyInstructionText = oCurField.Fld_InstructionTextLocal
    '        '    .ptyCaption = oCurField.Fld_CaptionLocal
    '        'End If
    '        .txtInterviewerCode.Properties.ReadOnly = True
    '        If Len(oCurField.Fld_AnswerValue) > 0 Then
    '            .ptyResponse = oCurField.Fld_AnswerValue
    '        Else
    '            .ptyResponse = _curUser.code
    '        End If

    '        .txtInterviewerCode.Focus()
    '    End With
    'End Sub

    Private Sub PopulateSplashUI()
        HideControls()
        'Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        'With Splash1
        '    .ClearMe()
        '    .Visible = True
        '    .Dock = DockStyle.Fill
        '    .BringToFront()
        '    .QuestionText = oCurField.Fld_QuestionEnglish
        '    ''.ContextMenu = Me.cntxMnuMaina
        '    'If iLanguage = Language.English Then
        '    '    .txtBodytext.Text = Replace(oCurField.Fld_InstructionTextEnglish.ToUpper, "[FWNAME]", "[ " & oCurStaff.stf_Names & "]") '& " : " & oCurField.Fld_InstructionText.ToUpper
        '    '    .lblHeaderText.Text = oCurField.Fld_QuestionEnglish.ToUpper
        '    'Else
        '    '    .txtBodytext.Text = Replace(oCurField.Fld_InstructionTextLocal.ToUpper, "[FWNAME]", "[ " & oCurStaff.stf_Names & "]") '& " : " & oCurField.Fld_InstructionText.ToUpper
        '    '    .lblHeaderText.Text = oCurField.Fld_QuestionLocal.ToUpper
        '    'End If
        '    Me.ptyCurrentControl = .Name
        'End With
    End Sub

    Public Sub PopulateUCVisits()
        With UcVisits1
            .initializeUI()
            .GetVisitNumber()
            .Visible = True
            .Dock = DockStyle.Fill
            Me.ptyCurrentControl = .Name
        End With
    End Sub

    'new code
    Public Sub PopulateBirthsUI()
        Me.UcBirths1 = New UcBirths(oCurField)
        Me.Panel1.Controls.Add(Me.UcBirths1)
        With UcBirths1
            .Visible = True
            .BringToFront()
            .Dock = DockStyle.Fill
            Me.ptyCurrentControl = .Name
        End With
    End Sub

    Public Sub PopulateucLineNumber()
        With UcLineNumber1
            .CleaMe()
            .Visible = True
            .Dock = DockStyle.Fill
            .ptyResponse = String.Format("{0}|{1}", iLineNumber, sName)
            Me.ptyCurrentControl = .Name
        End With
    End Sub
    Public Sub PopulateUCHHMembers()
        With UcHouseholdMembers1
            .Visible = True
            .Dock = DockStyle.Fill
            .PopulateCombo()
            Me.ptyCurrentControl = .Name
        End With
    End Sub
    Private Sub PopulateDateUI()
        HideControls()
        Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        With UcDatevb1
            .Visible = True
            .Dock = DockStyle.Fill
            .BringToFront()
            '.pbContextMenu.ContextMenu = Me.cntxMnuMain
            Me.ptyCurrentControl = .Name
            .PtyQuestionText = String.Format("{0}.{1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
            '.pbContextmenu.ContextMenuStrip = Me.cnContextMenu
            'If iLanguage = Language.English Then
            '    .ptyQuestionText = oCurField.Fld_QuestionEnglish
            '    .ptyInstructionText = oCurField.Fld_InstructionTextEnglish
            '    .ptyCaption = oCurField.Fld_CaptionEnglish
            'Else
            '    .ptyQuestionText = oCurField.Fld_QuestionLocal
            '    .ptyInstructionText = oCurField.Fld_InstructionTextLocal
            '    .ptyCaption = oCurField.Fld_CaptionLocal
            'End If
            'If Len(oCurField.Fld_AnswerValue) = 0 Then
            '    .ptyAnswer = Format(Today.Date, "dd/MM/yyyy")
            'Else
            '    .ptyAnswer = oCurField.Fld_AnswerValue
            'End If

            '.txtDate.Focus()
        End With
    End Sub

    Private Sub PopulateOptionSingleDomainUI()
        HideControls()
        Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        With UcOptionSingleDomain1
            .ClearMe()
            .Visible = True
            .Dock = DockStyle.Fill
            .BringToFront()
            '.flwLayout.Items.Clear()
            '.pbContextMenu.ContextMenu = Me.cntxMnuMain
            Me.ptyCurrentControl = .Name
            .QuestionText = String.Format("{0}. {1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
            .PtyLookups = oCurField.fld_Lookups
            .ptyCaption = oCurField.Fld_CaptionEnglish
            '.pbContextmenu.ContextMenuStrip = Me.cnContextMenu
            'If iLanguage = Language.English Then
            '    .ptyQuestionText = oCurField.Fld_QuestionEnglish
            '    .ptyInstructionText = oCurField.Fld_InstructionTextEnglish
            '    .ptyCaption = oCurField.Fld_CaptionEnglish
            'Else
            '    .ptyQuestionText = oCurField.Fld_QuestionLocal
            '    .ptyInstructionText = oCurField.Fld_InstructionTextLocal
            '    .ptyCaption = oCurField.Fld_CaptionLocal
            'End If
            .ptyResponse = oCurField.fld_Lookups.Find(Function(x) x.Lkp_Code = oCurField.Fld_AnswerValue)

        End With
    End Sub
    Private Sub PopulateMultivalueUI()
        HideControls()
        'Me.Text = ReturnQuestionNumber(oCurField.Fld_QNo)
        Dim oth() As String = Nothing
        Dim opt() As String = Nothing
        With UcMultivalue1
            .BackColor = Color.White
            .ClearMe()
            '.pbContextmenu.ContextMenu = Me.cntxMnuMain
            .Visible = True
            .BringToFront()
            .Dock = DockStyle.Fill
            '.ptyLanguage = iLanguage
            .ptyLookups = oCurField.fld_Lookups

            'If iLanguage = Language.English Then
            '    .txtQuestionText.Text = oCurField.Fld_QuestionEnglish
            '    .ptyInstructionText = oCurField.Fld_InstructionTextEnglish
            'Else
            '    .txtQuestionText.Text = oCurField.Fld_QuestionLocal
            '    .ptyInstructionText = oCurField.Fld_InstructionTextLocal
            'End If
            .QuestionText = String.Format("{0}. {1}", oCurField.Fld_QNo, oCurField.Fld_QuestionEnglish)
            Me.ptyCurrentControl = .Name

            If Len(oCurField.Fld_AnswerValue) > 0 Then
                opt = oCurField.Fld_AnswerValue.Split("|")
                If Not opt Is Nothing Then
                    For i = 0 To .lstOptions.Items.Count - 1
                        If Not CType(.lstOptions.Items.Item(i).Tag, Lookup).Lkp_IsOtherSpecify Then
                            MsgBox(.lstOptions.Items.Item(i).Text)
                            If Len(opt(i)) > 1 Then
                                .lstOptions.Items.Item(i).Checked = (1 = opt(i + 1))
                            Else
                                .lstOptions.Items.Item(i).Checked = (1 = opt(i))
                            End If

                        Else
                            .lstOptions.Items.Item(i).Checked = (1 = opt(i)) 'Check The box 
                            If (1 = opt(i)) Then ' Other Specify was Checked  then 
                                'i = i + 1 'Move Counter ahead to get the text
                                .lstOptions.Items.Item(i).SubItems(1).Text = opt(i + 1) 'Put the text in the sub Item 
                                'i = i - 1
                            End If
                        End If
                    Next
                End If
            End If
            .EnableOtherSpecify(False)
        End With
    End Sub
    Private Function SaveAnsValues(ByVal sAnsValue As String, ByVal iPk As Integer) As Boolean
        'Assumptions: The Splitted Ans is equivalent to the number of colums.
        SaveAnsValues = False
        Dim sTempAns() As String
        Dim sSql As String = String.Empty
        Dim sSQL2 As String = String.Empty
        Dim sSQLWhere As String = String.Empty
        '' Dim dbcon As New SqlConnection(sConnectionString)
        Dim strSqlBUilder As New StringBuilder
        If Len(sAnsValue) = 0 Then 'No Ans
            ' SM: check If Not Mandatory and just push it into Stack as Is 
            If Not oCurField.Fld_Mandatory Then
                If IsFieldInPoppedStack(sckPoppedQuestions) Then ' We may be coming from Back
                    sckPoppedQuestions.Pop()
                End If
                sckAnsweredQuestions.Push(oCurField) 'Add the question to the stack.
                SaveAnsValues = True
            End If
            Exit Function
        End If
        Dim sColum() As String

        sSql = String.Format("UPDATE {0} SET ", oCurField.Fld_TableName)
     
        sSQLWhere = String.Format(" WHERE {0}='{1}'", oCurField.Fld_TableKeys, iHouseHoldID)
        sTempAns = sAnsValue.Split("|") 'Split any ans value even if it does not have "|"
        sColum = oCurField.Fld_ColumnName.Split("|") 'Get all the columns
        For i As Integer = 0 To sColum.Length - 1
            If Len(sSQL2) = 0 Then ' first Ilem on the list
                sSQL2 = String.Format("{0} ='{1}'", sColum(i), sTempAns(i))
            Else
                sSQL2 = String.Format("{0} , {1} ='{2}'", sSQL2, sColum(i), sTempAns(i))
            End If
        Next
        'Concatenate
        strSqlBUilder.Append(sSql)
        strSqlBUilder.Append(sSQL2)
        strSqlBUilder.Append(sSQLWhere)
        'always save locally ...
        Using sqlCom As New SqlCommand("Up_SaveData")
            Try
                With sqlCom
                    .Parameters.Add("@Sql", SqlDbType.VarChar, 1000).Value = strSqlBUilder.ToString
                    .CommandType = CommandType.StoredProcedure
                    .Connection = _AppLocalConn
                End With
                If DataAccess.AppSaveData(sqlCom) Then
                    SaveAnsValues = True
                End If
            Catch ex As Exception
                ShowException(ex, "Error saving data")

            End Try
        End Using
    End Function

    Public Function SaveQuestionnaireValues() As Boolean
        SaveQuestionnaireValues = False

        If _FromSearch = False Then
            If SaveAnsValues(oCurField.Fld_AnswerValue, iHouseHoldID) Then
                If IsFieldInPoppedStack(sckPoppedQuestions) Then ' We may be coming from Back
                    sckPoppedQuestions.Pop()
                End If
                sckAnsweredQuestions.Push(oCurField) 'Add
                Return True
            End If
        Else
            If IsFieldInPoppedStack(sckPoppedQuestions) Then ' We may be coming from Back
                sckPoppedQuestions.Pop()
            End If
            sckAnsweredQuestions.Push(oCurField) 'Add
            Return True
        End If
    End Function
    Private Function IsFieldInPoppedStack(ByVal sck As Stack) As Boolean
        IsFieldInPoppedStack = False
        If sck.Count > 0 Then
            If CType(sck.Peek, Field).Fld_No = oCurField.Fld_No Then
                Return True
            End If
        End If
    End Function
    Private Function SaveDummyRecord() As Guid
        SaveDummyRecord = Nothing

        Dim sqlcom As New SqlCommand
        Try
            With sqlcom
                .CommandType = CommandType.StoredProcedure
                .CommandText = "up_SaveDummyRecord"
                .Connection = _AppLocalConn
                .Parameters.Add("@TableName", SqlDbType.VarChar, 20).Value = sTablename
                .Parameters.Add("@StaffId", SqlDbType.Int, 2).Value = 0
                '.Parameters.Add("@Sitecode", SqlDbType.VarChar, 20).Value = _SiteCode
                .Parameters.Add("@@KeyValue", SqlDbType.UniqueIdentifier, 16).Direction = ParameterDirection.Output
                .Parameters.Add("@@iHouseholdID", SqlDbType.Int, 4).Direction = ParameterDirection.Output
                If DataAccess.AppSaveData(sqlcom) Then
                    If Not IsDBNull((.Parameters("@@KeyValue").Value)) Then
                        sHouseHoldGuid = (.Parameters("@@KeyValue").Value) 'Get the guid from the server
                        iHouseHoldID = (.Parameters("@@iHouseholdID").Value)
                    End If
                End If
                Return sHouseHoldGuid
            End With
        Catch ex As Exception
            ShowException(ex, "Not able to save Dummy Record")
            Return Nothing
        End Try
    End Function
#End Region

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Select Case Me.ptyCurrentControl
            Case UcHouseholdMembers1.Name
                With UcHouseholdMembers1
                    If .lvMembers.Items.Count = 0 Then
                        .lvMembers.BackColor = Color.Red
                        MsgBox("No Data in the list .", , sAppName)
                        Exit Sub
                    End If
                    .SaveHHMember()
                    sckAnsweredQuestions.Push(oCurField)
                    GetNextQuestion()
                End With
            Case UcDatevb1.Name
                With UcDatevb1

                End With
            Case UcVisits1.Name
                With UcVisits1
                    .SaveVisitis()
                    sckAnsweredQuestions.Push(oCurField)
                    GetNextQuestion()
                End With
            Case UcSingleDomain1.Name
                'Validate Control
                If Not UcSingleDomain1.ValidateUI Then
                    MsgBox("Information Is Missing. Please Select a Response", MsgBoxStyle.OkOnly)
                    Cursor.Current = Cursors.Default
                    Exit Sub
                Else
                    ''Get Answer Value
                    With UcSingleDomain1
                        oCurField.Fld_OtherValues = .ptyOtherSpecify
                        oCurField.Fld_AnswerValue = String.Format("{0}|{1}", TryCast(.ptySelectedValue, Lookup).Lkp_mapping, oCurField.Fld_OtherValues)
                        If Len(oCurField.Fld_TableName) > 0 Then
                            If SaveQuestionnaireValues() Then 'Save and Push to Stack 
                                .ClearMe()
                                GetNextQuestion()
                            Else
                                MsgBox("An Error occured while Saving the record. Contact Administrator", MsgBoxStyle.Critical, sAppName)
                                Cursor.Current = Cursors.Default
                            End If
                        Else
                            'Record Is not Saved to Tables
                            .ClearMe()
                            GetNextQuestion()
                        End If
                    End With
                End If
            Case UcSplash1.Name
                'sAnswerValue = "-SPLASH-"
                If IsFieldInPoppedStack(sckPoppedQuestions) Then ' We may be coming from Back
                    sckPoppedQuestions.Pop()
                End If
                sckAnsweredQuestions.Push(oCurField)

                GetNextQuestion()
            Case Freetext1.Name
                'If oCurField.Fld_Mandatory Then 'Validate
                If Not Freetext1.ValidateUI Then
                    MsgBox("Information Is Missing. Please Select a Response", 2)
                    Cursor.Current = Cursors.Default
                    Exit Sub
                End If
                'End If
                With Freetext1
                    .Visible = False
                    oCurField.Fld_AnswerValue = .ptyResponse
                    If SaveQuestionnaireValues() Then
                        Freetext1.ClearMe()
                        GetNextQuestion()
                    End If
                End With
     
            Case UcDatevb1.Name
                With UcDatevb1

                    oCurField.Fld_AnswerValue = .ptyAnswer
                    If SaveQuestionnaireValues() Then
                        '.ClearMe()
                        'If oCurField.Fld_No = 379 Or oCurField.Fld_No = 321 Then
                        '    'same attendance
                        '    SaveCurrentAttendance()
                        'End If
                        GetNextQuestion()

                    End If

                End With
            Case Numeric1.Name
                With Numeric1
                    If Numeric1.ValidateUI Then
                        oCurField.Fld_AnswerValue = .ptyResponse
                        If oCurField.fld_Minlength > 0 Then
                            If oCurField.fld_Minlength < Len(.ptyResponse) Or oCurField.fld_Maxlength > Len(.ptyResponse) Then
                                MsgBox("The length is out of range.", vbOK, sAppName)
                                .txtNumeric.BackColor = Color.Red
                                Exit Sub
                            End If
                        End If
                        If oCurField.Fld_Max > 0 Then
                            If oCurField.Fld_Min > (.ptyResponse) Or (.ptyResponse) > oCurField.Fld_Max Then
                                MsgBox("The value is out of range.", vbOK, sAppName)
                                .txtNumeric.BackColor = Color.Red
                                Exit Sub
                            End If
                        End If

                        If SaveQuestionnaireValues() Then
                            .ClearMe()
                            GetNextQuestion()
                        End If
                    Else
                        MsgBox("Information Is Missing. Please Select a Response!", 2)
                        Cursor.Current = Cursors.Default
                        Exit Sub
                    End If
                End With

            Case UcMultivalue1.Name
                With UcMultivalue1
                    oCurField.Fld_AnswerValue = .ptyGetValues
                    If Not oCurField.Fld_AnswerValue.Contains("1") Then
                        MsgBox("No option has been selected. Select a value before you proceed.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, sAppName)
                        Exit Sub
                    End If
                    'Continues with the code 
                    If SaveQuestionnaireValues() Then
                        .ClearMe()
                        GetNextQuestion()
                    End If
                End With
            Case UcOptionSingleDomain1.Name
                'Validate Control
                If Not UcOptionSingleDomain1.ValidateUI Then
                    MsgBox("Information Is Missing. Please Select a Response", 2)
                    Cursor.Current = Cursors.Default
                    Exit Sub
                Else
                    ''Get Answer Value
                    With UcOptionSingleDomain1
                        .Hide()
                        oCurField.Fld_AnswerValue = .ptyResponse.Lkp_Code ' CType(.ptySelectedValue, Lookup).Lkp_Code & "|" & oCurField.Fld_OtherValues
                        If oCurField.Fld_TableName <> "" Then
                            If SaveQuestionnaireValues() Then 'Save and Push to Stack 
                                .Panel3.Controls.Clear()
                                .ClearMe()
                                GetNextQuestion()
                            Else
                                MsgBox("An Error occured while Saving the record. Contact Administrator", MsgBoxStyle.Critical, sAppName)
                                Cursor.Current = Cursors.Default
                            End If
                        Else
                            'Record Is not Saved to Tables
                            .ClearMe()
                            GetNextQuestion()
                        End If
                    End With
                End If
            Case UcEndInterview1.Name

                _Fields = Nothing
                _lookups = Nothing
                sHouseHoldGuid = Nothing

                Me.DialogResult = Windows.Forms.DialogResult.OK

            Case UcBirths1.Name
                With UcBirths1
                    'If .lvMembers.Items.Count = 0 Then
                    '    .lvMembers.BackColor = Color.Red
                    '    MsgBox("No Data in the list .", , sAppName)
                    '    Exit Sub
                    'End If
                    .SaveBirths()
                    sckAnsweredQuestions.Push(oCurField)
                    GetNextQuestion()
                End With

        End Select
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Select Case Me.ptyCurrentControl
            'Case StartUP1.Name
            '    Dim retVal As MsgBoxResult = MsgBox(String.Format("Moving Back from this screen will close the current interview.{0}{0} Do you want to Proceed?.", vbCrLf), MsgBoxStyle.Information + MsgBoxStyle.YesNo, sAppName)
            '    If retVal = MsgBoxResult.Yes Then
            '        _Fields = Nothing
            '        _lookups = Nothing
            '        sHouseHoldGuid = Nothing
            '        Me.Close()
            '    End If
            Case Else
                GetPreviousQuestion()
        End Select
    End Sub

    Private Sub Interview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HideControls()
        LoadData()
    End Sub
End Class
