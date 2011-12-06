Imports KaisII.FormGenClasses
Imports System.Text
Imports System.Xml

Public Class ucMultivalue
    Private oCurOption As Lookup
    Public WriteOnly Property QuestionText() As String
        Set(ByVal value As String)
            lblQuestionText.Text = value
        End Set
    End Property
    'Sm Changed Declaration
    Public WriteOnly Property ptyLookups() As List(Of Lookup)
        Set(ByVal value As List(Of Lookup))
            If Not value Is Nothing Then
                Dim lstItem As ListViewItem
                For Each obj As Lookup In value
                    lstItem = New ListViewItem(obj.ToString)
                    lstItem.SubItems.Add("")
                    lstItem.Tag = obj
                    lstOptions.Items.Add(lstItem)
                Next
                lstOptions.FocusedItem = Nothing
            End If
        End Set
    End Property

    Public ReadOnly Property ptyGetValues() As String
        Get
            Dim Ansbuilder As New StringBuilder


            For Each lst As ListViewItem In lstOptions.Items
                If lst.Checked Then
                    If Len(Ansbuilder.ToString) = 0 Then
                        Ansbuilder.Append("1")
                    Else
                        Ansbuilder.Append("|" & "1")
                        If TryCast(lst.Tag, Lookup).Lkp_IsOtherSpecify Then
                            If Len(lst.SubItems(1).Text) > 0 Then
                                Ansbuilder.Append("|" & lst.SubItems(1).Text)
                            Else
                                Ansbuilder.Append("|" & 95)
                            End If
                        End If
                    End If
                Else
                    If Len(Ansbuilder.ToString) = 0 Then
                        Ansbuilder.Append("0")
                    Else

                        Ansbuilder.Append("|" & "0")
                        If TryCast(lst.Tag, Lookup).Lkp_IsOtherSpecify Then
                            If Len(lst.SubItems(1).Text) > 0 Then
                                Ansbuilder.Append("|" & lst.SubItems(1).Text)
                            Else
                                Ansbuilder.Append("|" & 95)
                            End If
                        End If
                    End If
                End If
            Next
            Return Ansbuilder.ToString
        End Get
    End Property
    Private sOtherspecify As String
    Public Property OtherSpecify() As String
        Get
            Return txtOtherspecify.Text
        End Get
        Set(ByVal value As String)
            sOtherspecify = value
            If Len(value) > 0 Then
                txtOtherspecify.Text = value
            End If
        End Set
    End Property
    Private Sub ShowOtherSpecify(ByVal bShow As Boolean)
        'lstOptions.Enabled = Not (bShow)

        If bShow Then
            pnlOtherSpecify.Visible = bShow
            pnlOtherSpecify.BringToFront()
            txtOtherspecify.Visible = bShow
            txtOtherspecify.Focus()
            cmdOK.Visible = bShow
            lstOptions.SendToBack()
        Else
            lstOptions.BringToFront()
            pnlOtherSpecify.Visible = bShow
            txtOtherspecify.Visible = bShow
            cmdOK.Visible = bShow
        End If
        txtOtherspecify.Text = ""
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(txtOtherspecify.Text) = 0 Then
            MsgBox("Text missing.", MsgBoxStyle.Exclamation, "")
            txtOtherspecify.Focus()
            Exit Sub
        End If
        cmdOK.Visible = False
        txtOtherspecify.Visible = False
    End Sub


#Region "Methods"
    Public Sub ClearMe()
        lstOptions.Items.Clear()
        txtOtherspecify.Text = String.Empty
        lblQuestionText.Text = String.Empty
    End Sub
    Public Sub EnableOtherSpecify(ByVal bState As Boolean)

        lstOptions.Enabled = Not (bState)

        If bState Then
            pnlOtherSpecify.BringToFront()
            pnlOtherSpecify.Visible = bState
            pnlOtherSpecify.Dock = DockStyle.Fill
        Else
            pnlOtherSpecify.SendToBack()
            pnlOtherSpecify.Visible = bState
            pnlOtherSpecify.Dock = DockStyle.None
        End If
        txtOtherspecify.Text = ""
    End Sub

#End Region

    Private Sub lstOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If lstOptions.Items.Count > 0 Then
            If lstOptions.SelectedItems.Count > 0 Then
                lstOptions.SelectedItems(0).Checked = True
            End If
        End If

    End Sub



    Private Sub lstOptions_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Dim oTemp As Lookup = CType(lstOptions.Items.Item(e.Index).Tag, Lookup)
        If e.NewValue = CheckState.Checked Then
            ShowOtherSpecify(oTemp.Lkp_IsOtherSpecify)
            If oTemp.Lkp_IsOtherSpecify Then
                oCurOption = oTemp
            Else
                oCurOption = Nothing
            End If
        Else
            If oTemp.Lkp_IsOtherSpecify Then
                lstOptions.Items.Item(e.Index).SubItems(1).Text = ""
            End If
        End If
    End Sub


    Private Sub cmdOK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Len(txtOtherspecify.Text) = 0 Then
            txtOtherspecify.BackColor = Color.Red
            Dim qms As MsgBoxResult = MsgBox("You have not entered in value for Other Specify." & _
                                             vbCrLf + vbCrLf & "Are you sure you want to proceed ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If qms = MsgBoxResult.Yes Then
                lstOptions.FocusedItem.Checked = False
                pnlOtherSpecify.Visible = False
            Else
                txtOtherspecify.Focus()
            End If
        Else
            If oCurOption IsNot Nothing Then
                If lstOptions.Items.Count <> 0 Then
                    For Each lst As ListViewItem In lstOptions.Items
                        If CType(lst.Tag, Lookup).Lkp_Code = oCurOption.Lkp_Code Then
                            lst.SubItems(1).Text = txtOtherspecify.Text
                            EnableOtherSpecify(False)
                            Exit For
                        End If
                    Next
                Else
                    MsgBox("Some Information is Missing", 2)
                End If
                pnlOtherSpecify.Visible = False
            End If
        End If
    End Sub

    Private Sub lstOptions_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOptions.Click
        If lstOptions.Items.Count > 0 Then
            If Not lstOptions.FocusedItem Is Nothing Then
                If lstOptions.FocusedItem.Checked Then
                    lstOptions.FocusedItem.Checked = False
                Else
                    lstOptions.FocusedItem.Checked = True
                End If
            End If
     
        End If
    End Sub

    Private Sub lstOptions_ItemCheck1(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstOptions.ItemCheck
        Dim oTemp As Lookup = CType(lstOptions.Items.Item(e.Index).Tag, Lookup)
        If e.NewValue = CheckState.Checked Then
            ShowOtherSpecify(oTemp.Lkp_IsOtherSpecify)
            If oTemp.Lkp_IsOtherSpecify Then
                oCurOption = oTemp
            Else
                oCurOption = Nothing
            End If
        Else
            If oTemp.Lkp_IsOtherSpecify Then
                lstOptions.Items.Item(e.Index).SubItems(1).Text = ""
            End If
        End If
    End Sub

    Private Sub lstOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOptions.SelectedIndexChanged

    End Sub
End Class
