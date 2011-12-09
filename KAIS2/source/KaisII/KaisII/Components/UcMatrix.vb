Imports KaisII.FormGenClasses
Imports System.Data.SqlClient

Public Class UcMatrix

    Private vMatrixField As Field
    Private vFkValue As String
    Private vDictionaryList As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))
    Private tabPageDictionary As Dictionary(Of Integer, TabPage) = New Dictionary(Of Integer, TabPage)
    Private Const INITIAL_Y_POSITION As Integer = 5
    Private Const STANDARD_X_POSITION As Integer = 5
    Private Const Y_POSITION_OFFSET As Integer = 75
    Public Property ControlsPerPage As Integer = 3
    Private selectedIndex As Integer = -1

    Public Sub New(ByVal pMatrixField As Field, ByVal pFkValue As String)
        'TODO throw exceptions if matrix field is nothing or empty or if proc is empty also
        InitializeComponent()
        'q203UcKaisDatePicker.MaxYears = Now().Year()
        'initialsUcKaisTextBox.UpperCase = True
        Me.vMatrixField = pMatrixField
        Me.vFkValue = pFkValue
        DisplayFieldControls()
        SetControlsToDefault(matrixTabControl.Controls)
        matrixFieldTextBox.Text = vMatrixField.Fld_QuestionEnglish
    End Sub

    Private vTabIndex As Integer = -1
    Private Sub DisplayFieldControls()
        For Each f As Field In vMatrixField.ChildList
            vTabIndex = vTabIndex + 1
            If f.Fld_Type = Fieldtypes.FieldType.Freetext Then
                LayKaisControl(CreateKaisTextBox(f))
            ElseIf f.Fld_Type = Fieldtypes.FieldType.Lookup Then
                LayKaisControl(CreateLookupComboBox(f))
            ElseIf f.Fld_Type = Fieldtypes.FieldType.OtheredLookup Then
                LayKaisControl(CreateOtheredLookupComboBox(f))
            ElseIf f.Fld_Type = Fieldtypes.FieldType.DateTime Then
                LayKaisControl(CreateKaisDatePicker(f))
            Else
                vTabIndex = vTabIndex - 1
            End If
        Next
        addButton.TabIndex = vTabIndex + 1
        removeButton.TabIndex = vTabIndex + 2
        clearButton.TabIndex = vTabIndex + 3
        matrixDataGridView.TabIndex = vTabIndex + 4
    End Sub

    Private Sub SetControlsToDefault(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                SetControlsToDefault(ctrl.Controls)
            ElseIf TypeOf ctrl Is UcKaisControl Then
                CType(ctrl, UcKaisControl).SetToDefault()
            End If
        Next
        addButton.Text = "Add"
        selectedIndex = -1
    End Sub

    Private Function CreateTabPage(ByVal index As Integer) As TabPage
        Dim tabPage As TabPage = New TabPage()
        tabPage.Location = New System.Drawing.Point(4, 22)
        tabPage.Name = "page" & (index + 1)
        tabPage.Padding = New System.Windows.Forms.Padding(3)
        tabPage.Size = New System.Drawing.Size(1000, 318)
        tabPage.TabIndex = vTabIndex
        tabPage.Text = "Page " & (index + 1)
        tabPage.UseVisualStyleBackColor = True
        matrixTabControl.Controls.Add(tabPage)
        tabPageDictionary.Add(index, tabPage)
        Return tabPage
    End Function

    Private Function CreateKaisTextBox(ByVal field As Field) As UcKaisTextBox
        Dim kaisTextBox As New UcKaisTextBox()
        kaisTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        kaisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        kaisTextBox.Name = field.Fld_QNo & "KaisTextBox"
        kaisTextBox.TabIndex = vTabIndex
        kaisTextBox.Tag = field.Fld_QNo
        kaisTextBox.UpperCase = True
        kaisTextBox.SetLabelText(field.Fld_QuestionEnglish)
        kaisTextBox.Field = field
        AddHandler kaisTextBox.KeyPress, AddressOf ExtractSkip
        Return kaisTextBox
    End Function

    Private Function CreateLookupComboBox(ByVal field As Field) As UcLookupComboBox
        Dim lookupComboBox As KaisII.UcLookupComboBox = New KaisII.UcLookupComboBox()
        lookupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lookupComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        lookupComboBox.Name = field.Fld_QNo & "LookupComboBox"
        lookupComboBox.TabIndex = vTabIndex
        lookupComboBox.Tag = field.Fld_QNo
        lookupComboBox.SetLabelText(field.Fld_QuestionEnglish)
        lookupComboBox.SetDataSource(field.fld_Lookups)
        lookupComboBox.Field = field
        AddHandler lookupComboBox.KeyPress, AddressOf ExtractSkip
        Return lookupComboBox
    End Function

    Private Function CreateOtheredLookupComboBox(ByVal field As Field) As UcOtheredComboBox
        Dim otheredComboBox As KaisII.UcOtheredComboBox = New KaisII.UcOtheredComboBox()
        otheredComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        otheredComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        otheredComboBox.Name = field.Fld_QNo & "OtheredComboBox"
        otheredComboBox.TabIndex = vTabIndex
        otheredComboBox.Tag = field.Fld_QNo
        otheredComboBox.SetLabelText(field.Fld_QuestionEnglish)
        otheredComboBox.SetDataSource(field.fld_Lookups)
        otheredComboBox.Field = field
        AddHandler otheredComboBox.KeyPress, AddressOf ExtractSkip
        Return otheredComboBox
    End Function

    Private Function CreateKaisDatePicker(ByVal field As Field) As UcKaisDatePicker
        Dim kaisDatePicker As KaisII.UcKaisDatePicker = New KaisII.UcKaisDatePicker()
        kaisDatePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        kaisDatePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        kaisDatePicker.Location = New System.Drawing.Point(6, 84)
        kaisDatePicker.MaxDays = 31
        kaisDatePicker.MaxMonths = 12
        kaisDatePicker.MaxYears = 9999
        kaisDatePicker.MinDays = 1
        kaisDatePicker.MinMonths = 1
        kaisDatePicker.MinYears = 1900
        kaisDatePicker.Name = "UcKaisDatePicker1"
        kaisDatePicker.TabIndex = 1
        kaisDatePicker.Tag = field.Fld_QNo
        kaisDatePicker.UnknownDays = 888
        kaisDatePicker.UnknownMonths = 888
        kaisDatePicker.UnknownYears = 888
        kaisDatePicker.SetLabelText(field.Fld_QuestionEnglish)
        kaisDatePicker.Field = field
        AddHandler kaisDatePicker.KeyPress, AddressOf ExtractSkip
        Return kaisDatePicker
    End Function

    Private Sub LayKaisControl(ByVal kaisCtrl As UcKaisControl)
        Dim nextAvailableTabPage As TabPage = GetNextAvailableTabPage()
        Dim ctrl As Control = CType(kaisCtrl, Control)
        ctrl.Location = New System.Drawing.Point(STANDARD_X_POSITION, GetNextAvailableYPosition(nextAvailableTabPage))
        nextAvailableTabPage.Controls.Add(kaisCtrl)
    End Sub

    Private Function GetNextAvailableTabPage() As TabPage
        Dim nextAvailableTabPage As TabPage = Nothing
        If tabPageDictionary.Count() <> 0 AndAlso tabPageDictionary.Last.Value.Controls.Count() < ControlsPerPage Then
            nextAvailableTabPage = tabPageDictionary.Last.Value
        Else
            nextAvailableTabPage = CreateTabPage(tabPageDictionary.Count())
        End If
        Return nextAvailableTabPage
    End Function

    Private Function GetNextAvailableYPosition(ByVal tabPage As TabPage) As Integer
        Dim nextY As Integer = INITIAL_Y_POSITION
        If tabPage.Controls.Count() > 0 Then
            nextY = tabPage.Controls.Item(tabPage.Controls.Count() - 1).Location.Y + Y_POSITION_OFFSET
        End If
        Return nextY
    End Function

    Dim currentTabpage As TabPage = Nothing
    Private Function ValidateControls(ByVal controls As ControlCollection) As Boolean
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                currentTabpage = CType(ctrl, TabPage)
                Return ValidateControls(ctrl.Controls)
            ElseIf TypeOf ctrl Is UcKaisControl Then
                If ctrl.Enabled Then
                    Dim kaisCtrl As UcKaisControl = CType(ctrl, UcKaisControl)
                    If kaisCtrl.Field.Fld_Mandatory And kaisCtrl.GetValue() Is Nothing Then
                        MessageBox.Show("Missing field value! '" & kaisCtrl.Field.Fld_QuestionEnglish & "'", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        If currentTabpage IsNot Nothing Then
                            matrixTabControl.SelectedTab = currentTabpage
                        End If
                        ctrl.Focus()
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function

    Private Function GetKaisControls(ByVal controls As ControlCollection) As List(Of UcKaisControl)
        Dim kaisControls As List(Of UcKaisControl) = New List(Of UcKaisControl)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                For Each c In ctrl.Controls
                    If TypeOf c Is UcKaisControl Then
                        kaisControls.Add(c)
                    End If
                Next
            ElseIf TypeOf ctrl Is UcKaisControl Then
                kaisControls.Add(ctrl)
            End If
        Next
        Return kaisControls
    End Function

    Private Sub RefreshDataGridView()
        If vDictionaryList IsNot Nothing Then
            matrixDataGridView.Rows.Clear()
            If vDictionaryList.Count() < 1 Then
                Return
            End If
            Dim firstRowDictionary As Dictionary(Of String, Object) = vDictionaryList.Item(0)
            Dim columnCount As Integer = firstRowDictionary.Count()
            matrixDataGridView.ColumnCount = columnCount
            Dim columnIndex As Integer = 0
            For Each key As String In firstRowDictionary.Keys
                matrixDataGridView.Columns(columnIndex).Name = key
                columnIndex = columnIndex + 1
            Next
            For Each dictionary As Dictionary(Of String, Object) In vDictionaryList
                Dim row As String() = New String(dictionary.Count()) {}
                Dim rowIndex As Integer = 0
                For Each key As String In dictionary.Keys
                    Dim displayValue As String = ExtractDisplayString(dictionary.Item(key))
                    row(rowIndex) = IIf(displayValue Is Nothing, "", displayValue)
                    rowIndex = rowIndex + 1
                Next
                matrixDataGridView.Rows.Add(row)
            Next
            matrixDataGridView.ClearSelection()
        End If
    End Sub

    Public Function SaveMatrix() As Boolean
        Dim success As Boolean = False
        If vDictionaryList.Count() > 0 Then
            Try
                Dim transaction As SqlTransaction = _AppLocalConn.BeginTransaction()
                Dim command As New SqlCommand()
                command.Connection = _AppLocalConn
                command.Transaction = transaction
                command.CommandType = CommandType.Text
                command.CommandText = "DELETE FROM " & vMatrixField.Fld_TableName & " WHERE " & vMatrixField.Fld_TableKeys & " = '" & vFkValue & "'"
                command.ExecuteNonQuery()
                command.CommandText = GenerateInsertSql()
                Dim firstRecord As Dictionary(Of String, Object) = vDictionaryList.First()
                For Each key As String In firstRecord.Keys
                    Dim parameter As SqlParameter = New SqlParameter("@" & key, SqlDbType.VarChar, "1000")
                    command.Parameters.Add(parameter)
                Next
                command.Parameters.Add(New SqlParameter("@" & vMatrixField.Fld_TableKeys, SqlDbType.VarChar, "1000"))
                For Each dictionary As Dictionary(Of String, Object) In vDictionaryList
                    Dim i As Integer = 0
                    For Each value As Object In dictionary.Values
                        Dim saveValue As String = ExtractSaveString(value)
                        command.Parameters(i).Value = IIf(saveValue Is Nothing, DBNull.Value, saveValue)
                        i = i + 1
                    Next
                    command.Parameters(i).Value = vFkValue
                    command.Prepare()
                    command.ExecuteNonQuery()
                Next
                transaction.Commit()
                success = True
            Catch ex As Exception
                Throw ex
            End Try
        End If
        Return success
    End Function

    Private Function GenerateInsertSql() As String
        Dim insertSql1 As String = "INSERT INTO " & vMatrixField.Fld_TableName & "("
        Dim insertSql2 As String = ") VALUES("
        Dim firstRecord As Dictionary(Of String, Object) = vDictionaryList.First()
        For Each key As String In firstRecord.Keys
            insertSql1 = insertSql1 & key
            insertSql2 = insertSql2 & "@" & key
            insertSql1 = insertSql1 & ", "
            insertSql2 = insertSql2 & ", "
        Next
        insertSql1 = insertSql1 & vMatrixField.Fld_TableKeys
        insertSql2 = insertSql2 & " @" & vMatrixField.Fld_TableKeys
        Return insertSql1 & insertSql2 & ")"
    End Function

    Public Sub ExtractSkip(ByVal sender As Object, ByVal e As EventArgs)
        Dim kaisCtrl As UcKaisControl = TryCast(sender, UcKaisControl)
        If kaisCtrl IsNot Nothing Then
            If kaisCtrl.Field.Fld_HasSkip Then
                If kaisCtrl.Field.fld_Skips IsNot Nothing Then
                    For Each skp As Skip In kaisCtrl.Field.fld_Skips
                        ExcecuteSkip(skp, ExtractSkipString(kaisCtrl.GetValue()), kaisCtrl)
                    Next
                Else
                    Debug.WriteLine("Field " & kaisCtrl.Field.Fld_QNo & " that is supposed to have skips has no skips.")
                End If
            End If
        End If
    End Sub

    Public Sub ExcecuteSkip(ByVal skp As Skip, ByVal selectedValue As String, ByVal affectingKaisControl As UcKaisControl)
        If EvaluateSkip(skp, selectedValue) Then
            Dim affectedKaisControl As UcKaisControl = TryCast(GetControlByTag(matrixTabControl.Controls, skp.Skp_ToField.Fld_QNo), UcKaisControl)
            If affectedKaisControl IsNot Nothing Then
                ImplementSkip(skp, affectedKaisControl, selectedValue)
            End If
        End If
    End Sub

    Public Function EvaluateSkip(ByVal skp As Skip, ByVal selectedValue As String) As Boolean
        Dim met As Boolean = False
        Dim skipValue As String = skp.Skp_FieldValue
        Select Case skp.Skp_Operator
            Case "="
                If skipValue Is Nothing AndAlso selectedValue Is Nothing Then
                    met = True
                Else
                    If skipValue IsNot Nothing Then
                        met = skipValue.Equals(selectedValue)
                    Else
                        met = selectedValue.Equals(skipValue)
                    End If
                End If
                Exit Select
            Case "<>"
                If skipValue Is Nothing AndAlso selectedValue Is Nothing Then
                    met = False
                Else
                    If skipValue IsNot Nothing Then
                        met = Not skipValue.Equals(selectedValue)
                    Else
                        met = Not selectedValue.Equals(skipValue)
                    End If
                End If
                Exit Select
        End Select
        Return met
    End Function

    Public Sub ImplementSkip(ByVal skp As Skip, ByVal affectedKaisControl As UcKaisControl, ByVal selectedValue As String)
        Dim affectedControl As Control = TryCast(affectedKaisControl, Control)
        If affectedControl IsNot Nothing Then
            Select Case skp.Skp_Action
                Case "Enable"
                    affectedControl.Enabled = True
                    Exit Select
                Case "Disable"
                    affectedControl.Enabled = False
                    Exit Select
                Case "Visible"
                    affectedControl.Visible = True
                    Exit Select
                Case "Invisible"
                    affectedControl.Visible = False
                    Exit Select
                Case "Cascade"
                    CascadeText(affectedControl, selectedValue)
                    Exit Select
            End Select
        End If
    End Sub

    'intended for cascading respondent initials in matrix question
    Private Sub CascadeText(ByVal kaisCtrl As UcKaisControl, ByVal cascadeValue As String)
        Dim label As Label = kaisCtrl.Label
        Dim split1Array As String() = label.Text.Split("(")
        If split1Array.Length <> 2 Then
            Return
        End If
        Dim split2Array As String() = split1Array(1).Split(")")
        If split2Array.Length <> 2 Then
            Return
        End If
        label.Text = split1Array(0) & "(" & cascadeValue & ")" & split2Array(1)
    End Sub

    Private Function GetControlByTag(ByVal controls As ControlCollection, ByVal tag As String) As Control
        If tag IsNot Nothing Then
            For Each ctrl As Control In controls
                If TypeOf ctrl Is TabPage Then
                    Dim c As Control = GetControlByTag(ctrl.Controls, tag)
                    If c Is Nothing Then
                        Continue For
                    Else
                        Return c
                    End If
                ElseIf TypeOf ctrl Is UcKaisControl Then
                    If ctrl.Tag.Equals(tag) Then
                        Return ctrl
                    End If
                End If
            Next
        End If
        Return Nothing
    End Function

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        Dim hasSelectedRows As Boolean = (matrixDataGridView.SelectedRows().Count() > 0)
        If hasSelectedRows Then
            For Each row As DataGridViewRow In matrixDataGridView.SelectedRows
                vDictionaryList.RemoveAt(row.Index)
            Next
            RefreshDataGridView()
            SetControlsToDefault(matrixTabControl.Controls)
        End If
    End Sub

    Public Sub DisplayRecord(ByVal record As Dictionary(Of String, Object))
        If record IsNot Nothing Then
            For Each key As String In record.Keys
                CType(GetControlByTag(matrixTabControl.Controls, key), UcKaisControl).SetValue(record.Item(key))
            Next
            addButton.Text = "Change"
            selectedIndex = vDictionaryList.IndexOf(record)
        End If
    End Sub

    Private Function ExtractSaveString(ByVal value As Object) As String
        If TypeOf value Is String Then
            Return CType(value, String)
        ElseIf TypeOf value Is Lookup Then
            Return CType(value, Lookup).Lkp_mapping
        ElseIf TypeOf value Is OtheredLookup Then
            Return CType(value, OtheredLookup).Lookup.Lkp_mapping
        ElseIf TypeOf value Is KAISDate Then
            Return CType(value, KAISDate).ToString()
        End If
        Return Nothing
    End Function

    Private Function ExtractDisplayString(ByVal value As Object) As String
        If TypeOf value Is String Then
            Return CType(value, String)
        ElseIf TypeOf value Is Lookup Then
            Dim l As Lookup = CType(value, Lookup)
            If l IsNot Nothing Then
                Return l.ToString()
            End If
            Return CType(value, Lookup).Lkp_EnglishPrompt
        ElseIf TypeOf value Is OtheredLookup Then
            Dim ol As OtheredLookup = CType(value, OtheredLookup)
            If ol IsNot Nothing Then
                Dim l As Lookup = ol.Lookup
                If l IsNot Nothing Then
                    Return l.ToString()
                End If
            End If
        ElseIf TypeOf value Is KAISDate Then
            Return CType(value, KAISDate).ToString()
        End If
        Return Nothing
    End Function

    Private Function ExtractSkipString(ByVal value As Object) As String
        If TypeOf value Is String Then
            Return CType(value, String)
        ElseIf TypeOf value Is Lookup Then
            Dim l As Lookup = CType(value, Lookup)
            If l IsNot Nothing Then
                Return l.Lkp_mapping
            End If
            Return CType(value, Lookup).Lkp_EnglishPrompt
        ElseIf TypeOf value Is OtheredLookup Then
            Dim ol As OtheredLookup = CType(value, OtheredLookup)
            If ol IsNot Nothing Then
                Dim l As Lookup = ol.Lookup
                If l IsNot Nothing Then
                    Return l.Lkp_mapping
                End If
            End If
        ElseIf TypeOf value Is KAISDate Then
            Return CType(value, KAISDate).ToString()
        End If
        Return Nothing
    End Function

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        SetControlsToDefault(matrixTabControl.Controls)
        matrixDataGridView.ClearSelection()
    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        If ValidateControls(matrixTabControl.Controls) Then
            Dim dictionary As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
            For Each kaisCtrl In GetKaisControls(matrixTabControl.Controls)
                dictionary.Add(kaisCtrl.Field.Fld_QNo, kaisCtrl.GetValue())
            Next
            If selectedIndex < 0 Then
                vDictionaryList.Add(dictionary)
            Else
                vDictionaryList.RemoveAt(selectedIndex)
                vDictionaryList.Insert(selectedIndex, dictionary)
            End If
            RefreshDataGridView()
            SetControlsToDefault(matrixTabControl.Controls)
        End If
    End Sub

    Private Sub matrixDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles matrixDataGridView.SelectionChanged
        Dim hasSelectedRows As Boolean = (matrixDataGridView.SelectedRows().Count() > 0)
        If hasSelectedRows Then
            Dim selectedRowIndex As Integer = matrixDataGridView.SelectedRows.Item(0).Index
            DisplayRecord(vDictionaryList.Item(selectedRowIndex))
        End If
    End Sub
End Class
