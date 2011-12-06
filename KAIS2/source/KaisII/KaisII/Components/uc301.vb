Imports System.Text
Imports System.Data.SqlClient
Imports KaisII.FormGenClasses
Public Class uc301
#Region "Properties"
    Public WriteOnly Property QuestionText As String
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property
    Public ReadOnly Property GetAnsValue() As String
        Get
            Dim strBUilder As New StringBuilder
            If lvLogoTypes.Items.Count > 0 Then
                For Each lst As ListViewItem In lvLogoTypes.Items
                    If Len(strBUilder.ToString) = 0 Then
                        strBUilder.Append(lst.SubItems(0))
                        strBUilder.Append("|")
                        strBUilder.Append(lst.SubItems(1))
                    Else
                        strBUilder.Append("*")
                        strBUilder.Append(lst.SubItems(0))
                        strBUilder.Append("|")
                        strBUilder.Append(lst.SubItems(1))
                    End If
                Next

            End If
            Return strBUilder.ToString
        End Get
    End Property
#End Region


    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove.Click
        If Not lvLogoTypes.FocusedItem Is Nothing Then
            lvLogoTypes.FocusedItem.Remove()
        End If
    End Sub
    Public Function SaveQ301() As Boolean
        SaveQ301 = False
        Dim SqlCom As New SqlCommand("SaveQ301")
        SqlCom.CommandType = CommandType.StoredProcedure
        For Each lst As ListViewItem In lvLogoTypes.Items
            With SqlCom
                .Parameters.AddWithValue("@LogoType", lst.SubItems(0).ToString)
                .Parameters.AddWithValue("@TakenPart", lst.SubItems(0).ToString)
                .Parameters.AddWithValue("@HouseholdID", iHouseHoldID)
                .Parameters.AddWithValue("@HouseholdGuid", sHouseHoldGuid)
                .Parameters.AddWithValue("@CreatedBy", 0)
            End With
            DataAccess.AppSaveData(SqlCom) 'Save each Item at a time ..
        Next

    End Function

    Private Sub cmdADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADD.Click
        If Len(cboLogoType.Text) = 0 Then
            cboLogoType.BackColor = Color.Red
            Exit Sub
        ElseIf Len(cboTakenPart.Text) = 0 Then
            cboTakenPart.BackColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub cboLogoType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLogoType.SelectedIndexChanged
        cboLogoType.BackColor = Color.White
    End Sub

    Private Sub cboTakenPart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTakenPart.SelectedIndexChanged
        cboTakenPart.BackColor = Color.White
    End Sub
End Class
