Imports KaisII.FormGenClasses
Imports System.Xml
Imports System.Data.SqlClient

Public Class ucHouseholdMembers

    Public Sub PopulateCombo()
        ClearControls()
        For Each ctl As Control In pnAns.Controls
            If TypeOf ctl Is ComboBox Then
                If Len(ctl.Tag) > 0 Then
                    Dim ctl2 As New ComboBox
                    ctl2 = ctl
                    ctl2.Items.Clear()
                    AddItemsToCombo(ctl, _lookups.FindAll(Function(x) x.Lkp_ParentID = ctl2.Tag))
                End If
            End If
        Next
    End Sub
    Private Sub AddItemsToCombo(ByVal cbo As ComboBox, ByVal lkps As List(Of Lookup))
        'cbo.Items.Clear()
        For Each lkp As Lookup In lkps
            cbo.Items.Add(lkp)
        Next
    End Sub
    Private Sub ClearControls()
        Try
            For Each ctl As Control In pnAns.Controls

                If TypeOf ctl Is TextBox Then
                    ctl.Text = String.Empty
                End If
            Next
            cboRelationship.SelectedIndex = -1
            'cboAgeYear.SelectedIndex = -1
            cboEmancipated.SelectedIndex = -1
            cboLivehere.SelectedIndex = -1
            cboStayHerelastNight.SelectedIndex = -1
            cboSex.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(String.Format("Error Clearing controls {0}", ex.Message), , sAppName)
        End Try


    End Sub


    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        txtAge.BackColor = Color.White
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Cr AndAlso e.KeyChar <> "." Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtAge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub txtParent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'txtParent.BackColor = Color.White
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Cr AndAlso e.KeyChar <> "." Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtParent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCohabitingA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'txtCohabitingA.BackColor = Color.White
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Cr AndAlso e.KeyChar <> "." Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtCohabitingA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCohabitingB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'txtCohabitingB.BackColor = Color.White
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Cr AndAlso e.KeyChar <> "." Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtCohabitingB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function ValidateBeforeAdd() As Boolean
        ValidateBeforeAdd = False
        Dim bValidate As Boolean = True
        Try
            For Each ctl As Control In pnAns.Controls
                If Len(ctl.Text) = 0 Then
                    If (ctl.Enabled) Then
                        Debug.Print(ctl.Name)
                        ctl.BackColor = Color.Red
                        bValidate = False
                    End If
                End If
            Next
         
            Return bValidate
        Catch ex As Exception
            MsgBox(String.Format("Error Validating UI Before adding to list: - {0}", ex.Message), vbExclamation)
        End Try

    End Function
    Private Sub CmdAddToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAddToList.Click
        'If Not ValidateBeforeAdd() Then
        '    Exit Sub
        'End If
        Dim iCount As Integer = lvMembers.Items.Count + 1
        Dim lst As New ListViewItem(String.Format("{0}-{1}", iCount, txtName.Text))
        Try

            With lst.SubItems
                .Add(TryCast(cboRelationship.SelectedItem, Lookup).Lkp_Code)
                .Add(TryCast(cboSex.SelectedItem, Lookup).Lkp_Code)
                .Add(TryCast(cboLivehere.SelectedItem, Lookup).Lkp_Code)
                .Add(TryCast(cboStayHerelastNight.SelectedItem, Lookup).Lkp_Code)
                .Add(txtAge.Text)
                .Add(TryCast(cboAgeYear.SelectedItem, Lookup).Lkp_Code)
                .Add(TryCast(cboEmancipated.SelectedItem, Lookup).Lkp_Code)

            End With
            lvMembers.Items.Add(lst)
            ClearControls()
        Catch ex As Exception
            MsgBox(String.Format("Error adding Member to list:-  {0}", ex.Message.ToString), MsgBoxStyle.Information, "Kais II")
        Finally
            lst = Nothing
        End Try

    End Sub

    Private Sub cboAgeYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAgeYear.SelectedIndexChanged
        cboAgeYear.BackColor = Color.White
        If TryCast(cboAgeYear.SelectedItem, Lookup).Lkp_Code = 2 Then
            If Len(txtAge.Text) > 0 Then
                'If txtAge.Text >= 18 Then
                '    cboEmancipated.SelectedIndex = -1
                '    cboEmancipated.Enabled = False
                '    txtParent.Text = String.Empty
                '    txtParent.Enabled = False
                'Else
                '    cboEmancipated.SelectedIndex = -1
                '    cboEmancipated.Enabled = True
                '    txtParent.Text = String.Empty
                '    txtParent.Enabled = True
                'End If
            End If
        End If
    End Sub

    Public Sub SaveHHMember()
        Dim sqlCom As New SqlCommand("SaveHHMembers")

        For Each lst As ListViewItem In lvMembers.Items
            'MsgBox(lst.Index)
            With sqlCom
                .CommandType = CommandType.StoredProcedure
                .Connection = _AppLocalConn
                .Parameters.AddWithValue("@LineNumber", lst.Index + 1)
                .Parameters.AddWithValue("@Name", lst.SubItems(0).Text)
                .Parameters.AddWithValue("@Relation", lst.SubItems(1).Text)
                .Parameters.AddWithValue("@Sex", lst.SubItems(2).Text)
                .Parameters.AddWithValue("@Live_Here", lst.SubItems(3).Text)
                .Parameters.AddWithValue("@Last_Night", lst.SubItems(4).Text)
                .Parameters.AddWithValue("@Age", lst.SubItems(5).Text)
                .Parameters.AddWithValue("@Age_MY", lst.SubItems(6).Text)
                .Parameters.AddWithValue("@Emancipated", lst.SubItems(7).Text)
                '.Parameters.AddWithValue("@Lno_of_PG", lst.SubItems(8).Text)
                '.Parameters.AddWithValue("@Lno_CohabitA", lst.SubItems(9).Text)
                '.Parameters.AddWithValue("@Lno_CohabitB", lst.SubItems(10).Text)
                '.Parameters.AddWithValue("@HouseHoldGuid", sHouseHoldGuid)
                '.Parameters.AddWithValue("@HouseHoldID", iHouseHoldID)
                '.Parameters.AddWithValue("@CreatedBy", 0)
            End With

            DataAccess.AppSaveData(sqlCom)
        Next

    End Sub

    Private Sub cboRelationship_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRelationship.SelectedIndexChanged
        cboRelationship.BackColor = Color.White
    End Sub

    Private Sub cboSex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSex.SelectedIndexChanged
        cboSex.BackColor = Color.White
    End Sub

    Private Sub cboLivehere_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLivehere.SelectedIndexChanged
        cboLivehere.BackColor = Color.White
    End Sub

    Private Sub cboStayHerelastNight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStayHerelastNight.SelectedIndexChanged
        cboStayHerelastNight.BackColor = Color.White
    End Sub

    Private Sub cboEmancipated_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmancipated.SelectedIndexChanged
        cboEmancipated.BackColor = Color.White
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        txtName.BackColor = Color.White
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class
