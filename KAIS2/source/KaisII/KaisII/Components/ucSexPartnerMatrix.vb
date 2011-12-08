Imports KaisII.FormGenClasses
Imports System.Data.SqlClient

Public Class ucSexPartnerMatrix
    Private vSexPartnerMatrix As List(Of SexPartnerMatrix)
    Private sexPartnerMatrixsField As Field

    Public Sub New(ByVal sexPartnerMatrixField As Field)
        InitializeComponent()
        Me.sexPartnerMatrixsField = sexPartnerMatrixField
        DisplayFields(sexMatrixTabControl.Controls)
    End Sub

    Private Sub DisplayFields(ByVal controls As ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TabPage Then
                DisplayFields(ctrl.Controls)
            ElseIf TypeOf ctrl Is Label Or TypeOf ctrl Is ComboBox Then
                For Each field As Field In sexPartnerMatrixsField.ChildList
                    If TypeOf ctrl Is Label Then
                        If field.Fld_No = ctrl.Tag Then
                            AssociateFields(field, ctrl)
                            Exit For
                        End If
                    ElseIf TypeOf ctrl Is ComboBox Then
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
        Dim comboBox As ComboBox = CType(ctrl, ComboBox)
        comboBox.DataSource = field.fld_Lookups
    End Sub

    Sub saveSexMatrix()
        Throw New NotImplementedException
    End Sub

End Class
