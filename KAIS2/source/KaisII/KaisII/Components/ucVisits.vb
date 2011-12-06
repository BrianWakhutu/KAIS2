Imports System.Xml
Imports System.Data.SqlClient
Imports KaisII.FormGenClasses

Public Class ucVisits

    Private Sub cmdGetTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetTime.Click
        txtStartTime.Text = Mid(Now.TimeOfDay.ToString, 1, 5)
    End Sub

    Private Sub txtStartTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStartTime.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtStartTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStartTime.TextChanged

    End Sub

    Private Sub txtDateOfVisit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDateOfVisit.KeyPress
        e.Handled = True
    End Sub


    Private Sub txtDateOfVisit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDateOfVisit.TextChanged

    End Sub

    Private Sub txtVisitNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVisitNumber.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtVisitNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVisitNumber.TextChanged

    End Sub
    Public Sub initializeUI()
        txtDateOfVisit.Text = Now.Date.ToString
    End Sub
    Public Sub GetVisitNumber()
        Dim sql As String = String.Format("Select Max(Visit_Number) from Visit where HouseHoldID={0}", iHouseHoldID)
        Dim sqlcom As New SqlCommand(sql)
        sqlcom.CommandType = CommandType.Text
        sqlcom.Connection = _AppLocalConn
        Try
            Dim ds As DataSet = DataAccess.AppGetDataSet(sqlcom)
            If ds.Tables(0).Rows.Count > 0 Then
                txtVisitNumber.Text = ds.Tables(0).Rows.Count + 1
            ElseIf ds.Tables(0).Rows(0).Item(0) = 3 Then
                MsgBox("You cannot do more than 3 visits.", MsgBoxStyle.Information)
                Exit Sub
            Else
                txtVisitNumber = ds.Tables(0).Rows(0).Item(0) + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Error Getting Number of Visit")
        End Try

    End Sub
    Public Function SaveVisitis() As Boolean
        SaveVisitis = False
        Dim sqlcom As New SqlCommand("SaveVisit")
        With sqlcom
            .CommandType = CommandType.Text
            .Connection = _AppLocalConn
            .Parameters.AddWithValue("@VisitID", _iVisitID)
            .Parameters.AddWithValue("@Visit_Number", txtVisitNumber.Text)
            .Parameters.AddWithValue("@VisitTime", txtStartTime.Text)
            .Parameters.AddWithValue("@HouseholdID", iHouseHoldID)
            .Parameters.AddWithValue("@HouseHoldGuid", sHouseHoldGuid)
            .Parameters.AddWithValue("@Created_BY", 0)
            .Parameters.AddWithValue("@DeviceID", System.Net.Dns.GetHostName())
        End With
        Try
            If DataAccess.AppSaveData(sqlcom) Then
                _iVisitID = DataAccess.GetLastId("VisitID", "Visit")
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
End Class
