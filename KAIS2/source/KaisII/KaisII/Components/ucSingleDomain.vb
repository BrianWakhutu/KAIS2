Imports KaisII.FormGenClasses
Imports System.Text.RegularExpressions
Imports System.Xml
Public Class ucSingleDomain
    Private bHasOtherSpecLookups As Boolean
#Region "Properties"


    Private iLanguage As String
    Public Property ptyLanguage() As String
        Get
            Return iLanguage
        End Get
        Set(ByVal value As String)
            iLanguage = value
        End Set
    End Property
    Private sAttahcment As String
    Public WriteOnly Property ptyAttachement() As String
        Set(ByVal value As String)
            Dim s() As String
            sAttahcment = value
            If value <> "" Then
                s = sAttahcment.Split("|")
         
                bHasOtherSpecLookups = (s(0) = "OtherLookups")
            Else
                bHasOtherSpecLookups = False
            End If

        End Set
    End Property

    Public WriteOnly Property ptyCaption() As String
        Set(ByVal value As String)
            If value = "" Then
                lblSelect.Text = "Select Response"
            Else
                lblSelect.Text = value
            End If
        End Set
    End Property

    Private colLookups As List(Of Lookup)
    Public Property ptyLookupsCol() As List(Of Lookup)
        Get
            Return colLookups
        End Get
        Set(ByVal value As List(Of Lookup))
            colLookups = value
            ''Put the Values in the ComboBox 
            cmbAnsValues.Items.Clear() '
            If Not value Is Nothing Then
                For Each lkp As Lookup In value
                    cmbAnsValues.Items.Add(lkp)
                Next
            End If



        End Set
    End Property

    Public Property ptySelectedValue() As Lookup
        Get
            Return CType(cmbAnsValues.SelectedItem, Lookup)
        End Get
        Set(ByVal value As Lookup)
            For Each obj As Lookup In cmbAnsValues.Items
                If obj.Lkp_Code = value.Lkp_Code Then
                    cmbAnsValues.SelectedItem = obj
                    Exit For
                End If
            Next
        End Set
    End Property

    Private sQuestionText As String
    Public Property ptyQuestionText() As String
        Get
            Return sQuestionText
        End Get
        Set(ByVal value As String)
            sQuestionText = value
            TxtQuestionText.Text = value
        End Set
    End Property

    Private sInstructionText As String
    Public Property ptyInstructionText() As String
        Get
            Return sInstructionText
        End Get
        Set(ByVal value As String)
            sInstructionText = value
            If Len(sInstructionText) > 0 Then
        
            Else
            End If
        End Set
    End Property

    Private iRecordId As Integer
    Public Property ptyRecordId() As Integer
        Get
            Return iRecordId
        End Get
        Set(ByVal value As Integer)
            iRecordId = value
        End Set
    End Property

    Private InternalErrorText As String
    Public Property ptyInternalErrorText() As String
        Get
            Return InternalErrorText
        End Get
        Set(ByVal value As String)
            InternalErrorText = value
        End Set
    End Property


    Private sOtherSpecify As String
    Public Property ptyOtherSpecify() As String
        Get
            Return txtOtherSpecify.Text.Replace("'", "''")
        End Get
        Set(ByVal value As String)
            sOtherSpecify = value
            txtOtherSpecify.Text = value
            If value <> "" Then
                EnableOtherSpecify(True)
            Else
                EnableOtherSpecify(False)
            End If
        End Set
    End Property

#End Region


#Region "Constructor"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
    Private Sub cmbAnsValues_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnsValues.SelectedIndexChanged
        If Len(cmbAnsValues.Text) > 0 Then
            EnableOtherSpecify(TryCast(cmbAnsValues.SelectedItem, Lookup).Lkp_IsOtherSpecify)
        End If
    End Sub


#Region "Functions & Methods"
    Private Sub EnableOtherSpecify(ByVal bState As Boolean)

        If bState Then
            pnlOtherSpecify.Visible = bState
            pnlOtherSpecify.BringToFront()

        Else
            pnlOtherSpecify.Visible = bState
            pnlOtherSpecify.SendToBack()
            txtOtherSpecify.Text = ""
        End If

    End Sub
#End Region

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Len(txtOtherSpecify.Text) = 0 Then
            txtOtherSpecify.BackColor = Color.Red
            Dim qms As MsgBoxResult = MsgBox("You have not entered in value for Other Specify." & _
                                             vbCrLf + vbCrLf & "Are you sure you want to proceed ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If qms = MsgBoxResult.Yes Then
                cmbAnsValues.SelectedIndex = -1
                pnlOtherSpecify.Visible = False
            Else
                txtOtherSpecify.Focus()
            End If
        Else
            pnlOtherSpecify.Visible = False

        End If

    End Sub

    Private Sub txtOtherSpecify_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtherSpecify.KeyPress
        txtOtherSpecify.BackColor = Color.White
    End Sub

    Private Sub txtOtherSpecify_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherSpecify.TextChanged

    End Sub
    Public Function ValidateUI() As Boolean
        If Len(cmbAnsValues.Text) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub ClearMe()
        cmbAnsValues.SelectedIndex = -1
        txtOtherSpecify.Text = String.Empty
        TxtQuestionText.Text = String.Empty
    End Sub
End Class
