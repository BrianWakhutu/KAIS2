Namespace FormGenClasses
    Public Class Field

        Private iFld_No As Integer
        Public AnswerValue As String
        Public Property Fld_No() As Integer
            Get
                Return iFld_No
            End Get
            Set(ByVal Value As Integer)
                iFld_No = Value
            End Set
        End Property
        Public Property fld_Maxlength As Integer
        Public Property fld_Minlength As Integer
        Private sFld_TableName As String
        Public Property Fld_TableName() As String
            Get
                Return sFld_TableName
            End Get
            Set(ByVal Value As String)
                sFld_TableName = Value
            End Set
        End Property
        Public Property fld_parentID As Integer

        Private sFld_ColumnName As String
        Public Property Fld_ColumnName() As String
            Get
                Return sFld_ColumnName
            End Get
            Set(ByVal Value As String)
                sFld_ColumnName = Value
            End Set
        End Property

        Private sFld_QNo As String
        Public Property Fld_QNo() As String
            Get
                Return sFld_QNo
            End Get
            Set(ByVal Value As String)
                sFld_QNo = Value
            End Set
        End Property

        Private sFld_QuestionEnglish As String
        Public Property Fld_QuestionEnglish() As String
            Get
                Return sFld_QuestionEnglish
            End Get
            Set(ByVal Value As String)
                sFld_QuestionEnglish = Value
            End Set
        End Property

        Private sFld_QuestionLocal As String
        Public Property Fld_QuestionLocal() As String
            Get
                Return sFld_QuestionLocal
            End Get
            Set(ByVal Value As String)
                sFld_QuestionLocal = Value
            End Set
        End Property

        Private sFld_QuestionAlt As String
        Public Property Fld_QuestionAlt() As String
            Get
                Return sFld_QuestionAlt
            End Get
            Set(ByVal Value As String)
                sFld_QuestionAlt = Value
            End Set
        End Property

        Private sFld_TypeText As String
        Public Property Fld_TypeText() As String
            Get
                Return sFld_TypeText
            End Get
            Set(ByVal Value As String)
                sFld_TypeText = Value
            End Set
        End Property

        Private iFld_Type As Integer
        Public Property Fld_Type() As Fieldtypes.FieldType
            Get
                Return iFld_Type
            End Get
            Set(ByVal Value As Fieldtypes.FieldType)
                iFld_Type = Value
            End Set
        End Property

        Private iFld_Index As Integer
        Public Property Fld_Index() As Integer
            Get
                Return iFld_Index
            End Get
            Set(ByVal Value As Integer)
                iFld_Index = Value
            End Set
        End Property

        Private iFld_FormId As Integer
        Public Property Fld_FormId() As Integer
            Get
                Return iFld_FormId
            End Get
            Set(ByVal Value As Integer)
                iFld_FormId = Value
            End Set
        End Property

        Private sFld_SQL As String
        Public Property Fld_SQL() As String
            Get
                Return sFld_SQL
            End Get
            Set(ByVal Value As String)
                sFld_SQL = Value
            End Set
        End Property

        Private sFld_Attributes As String
        Public Property Fld_Attributes() As String
            Get
                Return sFld_Attributes
            End Get
            Set(ByVal Value As String)
                sFld_Attributes = Value
            End Set
        End Property

        Private iFld_LookupID As Integer
        Public Property Fld_LookupID() As Integer
            Get
                Return iFld_LookupID
            End Get
            Set(ByVal Value As Integer)
                iFld_LookupID = Value
            End Set
        End Property

        Private bFld_Mandatory As Boolean
        Public Property Fld_Mandatory() As Boolean
            Get
                Return bFld_Mandatory
            End Get
            Set(ByVal Value As Boolean)
                bFld_Mandatory = Value
            End Set
        End Property

        Private iFld_Min As Integer
        Public Property Fld_Min() As Integer
            Get
                Return iFld_Min
            End Get
            Set(ByVal Value As Integer)
                iFld_Min = Value
            End Set
        End Property

        Private iFld_Max As Integer
        Public Property Fld_Max() As Integer
            Get
                Return iFld_Max
            End Get
            Set(ByVal Value As Integer)
                iFld_Max = Value
            End Set
        End Property

        Private sFld_Defaultvalue As String
        Public Property Fld_Defaultvalue() As String
            Get
                Return sFld_Defaultvalue
            End Get
            Set(ByVal Value As String)
                sFld_Defaultvalue = Value
            End Set
        End Property

        Private sFld_InstructionTextEnglish As String
        Public Property Fld_InstructionTextEnglish() As String
            Get
                Return sFld_InstructionTextEnglish
            End Get
            Set(ByVal Value As String)
                sFld_InstructionTextEnglish = Value
            End Set
        End Property

        Private sFld_InstructionTextLocal As String
        Public Property Fld_InstructionTextLocal() As String
            Get
                Return sFld_InstructionTextLocal
            End Get
            Set(ByVal Value As String)
                sFld_InstructionTextLocal = Value
            End Set
        End Property

        Private sFld_InstructionTextAlt As String
        Public Property Fld_InstructionTextAlt() As String
            Get
                Return sFld_InstructionTextAlt
            End Get
            Set(ByVal Value As String)
                sFld_InstructionTextAlt = Value
            End Set
        End Property

        Private bFld_isExistingValue As Boolean
        Public Property Fld_isExistingValue() As Boolean
            Get
                Return bFld_isExistingValue
            End Get
            Set(ByVal Value As Boolean)
                bFld_isExistingValue = Value
            End Set
        End Property

        Private iFld_ParentField As Integer
        Public Property Fld_ParentField() As Integer
            Get
                Return iFld_ParentField
            End Get
            Set(ByVal Value As Integer)
                iFld_ParentField = Value
            End Set
        End Property

        Private bFld_HasChildren As Boolean
        Public Property Fld_HasChildren() As Boolean
            Get
                Return bFld_HasChildren
            End Get
            Set(ByVal Value As Boolean)
                bFld_HasChildren = Value
            End Set
        End Property

        Private sFld_IntroTextEnglish As String
        Public Property Fld_IntroTextEnglish() As String
            Get
                Return sFld_IntroTextEnglish
            End Get
            Set(ByVal Value As String)
                sFld_IntroTextEnglish = Value
            End Set
        End Property

        Private sFld_IntroTextLocal As String
        Public Property Fld_IntroTextLocal() As String
            Get
                Return sFld_IntroTextLocal
            End Get
            Set(ByVal Value As String)
                sFld_IntroTextLocal = Value
            End Set
        End Property

        Private sFld_IntroTextAlt As String
        Public Property Fld_IntroTextAlt() As String
            Get
                Return sFld_IntroTextAlt
            End Get
            Set(ByVal Value As String)
                sFld_IntroTextAlt = Value
            End Set
        End Property

        Private sFld_CaptionEnglish As String
        Public Property Fld_CaptionEnglish() As String
            Get
                Return sFld_CaptionEnglish
            End Get
            Set(ByVal Value As String)
                sFld_CaptionEnglish = Value
            End Set
        End Property

        Private sFld_CaptionLocal As String
        Public Property Fld_CaptionLocal() As String
            Get
                Return sFld_CaptionLocal
            End Get
            Set(ByVal Value As String)
                sFld_CaptionLocal = Value
            End Set
        End Property

        Private sFld_CaptionAlt As String
        Public Property Fld_CaptionAlt() As String
            Get
                Return sFld_CaptionAlt
            End Get
            Set(ByVal Value As String)
                sFld_CaptionAlt = Value
            End Set
        End Property

        Private sFld_PostReq As String
        Public Property Fld_PostReq() As String
            Get
                Return sFld_PostReq
            End Get
            Set(ByVal Value As String)
                sFld_PostReq = Value
            End Set
        End Property

        Private sFld_PreReq As String
        Public Property Fld_PreReq() As String
            Get
                Return sFld_PreReq
            End Get
            Set(ByVal Value As String)
                sFld_PreReq = Value
            End Set
        End Property

        Private bFld_HasSkip As Boolean
        Public Property Fld_HasSkip() As Boolean
            Get
                Return bFld_HasSkip
            End Get
            Set(ByVal Value As Boolean)
                bFld_HasSkip = Value
            End Set
        End Property
        Private sAccessLevels As String
        Public Property AccessLevels() As String
            Get
                Return sAccessLevels
            End Get
            Set(ByVal value As String)
                sAccessLevels = value
            End Set
        End Property
        Private iFld_SecondaryLookupId As Integer
        Public Property Fld_SecondaryLookupId() As Integer
            Get
                Return iFld_SecondaryLookupId
            End Get
            Set(ByVal Value As Integer)
                iFld_SecondaryLookupId = Value
            End Set
        End Property

        Private sFld_Attachment As String
        Public Property Fld_Attachment() As String
            Get
                Return sFld_Attachment
            End Get
            Set(ByVal Value As String)
                sFld_Attachment = Value
            End Set
        End Property
        Private fSkips As List(Of Skip)
        Public Property fld_Skips() As List(Of Skip)
            Get
                Return fSkips
            End Get
            Set(ByVal value As List(Of Skip))
                fSkips = value
            End Set
        End Property
        Private fLookups As List(Of Lookup)
        Public Property fld_Lookups() As List(Of Lookup)
            Get
                Return fLookups
            End Get
            Set(ByVal value As List(Of Lookup))
                fLookups = value
            End Set
        End Property

        Private sFld_AnswerValue As String
        Public Property Fld_AnswerValue() As String
            Get
                Return sFld_AnswerValue
            End Get
            Set(ByVal value As String)
                sFld_AnswerValue = value
            End Set
        End Property
        Private sFld_OtherValues As String
        Public Property Fld_OtherValues() As String
            Get
                Return sFld_OtherValues
            End Get
            Set(ByVal value As String)
                sFld_OtherValues = value
            End Set
        End Property

        Private sFld_TableKeys As String
        Public Property Fld_TableKeys() As String
            Get
                Return sFld_TableKeys
            End Get
            Set(ByVal value As String)
                sFld_TableKeys = value
            End Set
        End Property


    End Class

    Public Class Lookup
        Private iLanguage As Integer
        Public Property ptyLanguage() As Integer
            Get
                Return iLanguage
            End Get
            Set(ByVal value As Integer)
                iLanguage = value
            End Set
        End Property

        Private iLkp_No As Integer
        Public Property Lkp_No() As Integer
            Get
                Return iLkp_No
            End Get
            Set(ByVal Value As Integer)
                iLkp_No = Value
            End Set
        End Property

        Private iLkp_ParentID As Integer
        Public Property Lkp_ParentID() As Integer
            Get
                Return iLkp_ParentID
            End Get
            Set(ByVal Value As Integer)
                iLkp_ParentID = Value
            End Set
        End Property

        Private sLkp_Code As String
        Public Property Lkp_Code() As String
            Get
                Return sLkp_Code
            End Get
            Set(ByVal Value As String)
                sLkp_Code = Value
            End Set
        End Property

        Private sLkp_mapping As String
        Public Property Lkp_mapping() As String
            Get
                Return sLkp_mapping
            End Get
            Set(ByVal Value As String)
                sLkp_mapping = Value
            End Set
        End Property

        Private iLkp_Index As Integer
        Public Property Lkp_Index() As Integer
            Get
                Return iLkp_Index
            End Get
            Set(ByVal Value As Integer)
                iLkp_Index = Value
            End Set
        End Property

        Private sLkp_Description As String
        Public Property Lkp_Description() As String
            Get
                Return sLkp_Description
            End Get
            Set(ByVal Value As String)
                sLkp_Description = Value
            End Set
        End Property

        Private sLkp_DescriptionLocal As String
        Public Property Lkp_DescriptionLocal() As String
            Get
                Return sLkp_DescriptionLocal
            End Get
            Set(ByVal Value As String)
                sLkp_DescriptionLocal = Value
            End Set
        End Property

        Private iLkp_TableId As Integer
        Public Property Lkp_TableId() As Integer
            Get
                Return iLkp_TableId
            End Get
            Set(ByVal Value As Integer)
                iLkp_TableId = Value
            End Set
        End Property

        Private bLkp_IsOtherSpecify As Boolean
        Public Property Lkp_IsOtherSpecify() As Boolean
            Get
                Return bLkp_IsOtherSpecify
            End Get
            Set(ByVal Value As Boolean)
                bLkp_IsOtherSpecify = Value
            End Set
        End Property

        Private sLkp_GUID As String
        Public Property Lkp_GUID() As String
            Get
                Return sLkp_GUID
            End Get
            Set(ByVal Value As String)
                sLkp_GUID = Value
            End Set
        End Property

        Private sLkp_SystemName As String
        Public Property Lkp_SystemName() As String
            Get
                Return sLkp_SystemName
            End Get
            Set(ByVal Value As String)
                sLkp_SystemName = Value
            End Set
        End Property

        Private sLkp_EnglishPrompt As String
        Public Property Lkp_EnglishPrompt() As String
            Get
                Return sLkp_EnglishPrompt
            End Get
            Set(ByVal Value As String)
                sLkp_EnglishPrompt = Value
            End Set
        End Property

        Private sLkp_LocalPrompt As String
        Public Property Lkp_LocalPrompt() As String
            Get
                Return sLkp_LocalPrompt
            End Get
            Set(ByVal Value As String)
                sLkp_LocalPrompt = Value
            End Set
        End Property


        Public Overrides Function ToString() As String
            If Lkp_Description <> "" Then
                If iLanguage = 0 Then
                    Return Lkp_Description
                Else
                    Return Lkp_DescriptionLocal
                End If
            Else
                Return Lkp_Code
            End If
        End Function

    End Class
    Public Class Skip
        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Private iSkp_No As Integer
        Private iSkp_FieldNo As Integer
        Private sSkp_FieldValue As String
        Private sSkp_Operator As String
        Private iSkp_SkipToField As Integer

        Public Property Skp_No() As Integer
            Get
                Return iSkp_No
            End Get
            Set(ByVal Value As Integer)
                iSkp_No = Value
            End Set
        End Property
        Public Property Skp_FieldNo() As Integer
            Get
                Return iSkp_FieldNo
            End Get
            Set(ByVal Value As Integer)
                iSkp_FieldNo = Value
            End Set
        End Property
        Public Property Skp_FieldValue() As String
            Get
                Return sSkp_FieldValue
            End Get
            Set(ByVal Value As String)
                sSkp_FieldValue = Value
            End Set
        End Property
        Public Property Skp_Operator() As String
            Get
                Return sSkp_Operator
            End Get
            Set(ByVal Value As String)
                sSkp_Operator = Value
            End Set
        End Property
        Public Property Skp_SkipToField() As Integer
            Get
                Return iSkp_SkipToField
            End Get
            Set(ByVal Value As Integer)
                iSkp_SkipToField = Value
            End Set
        End Property
    End Class
    Public Class Fieldtypes
        Public Enum FieldType
            Freetext = 1
            Numeric = 2
            [date] = 3
            Lookup = 5
            Multivalue = 7
            Time = 32
        End Enum
    End Class
End Namespace

