Imports System.Xml
Public Class ucLineNumber
#Region "Properties"
    Public WriteOnly Property QuestionString As String
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property

    Public Property ptyResponse() As String
        Get
            Return txtAnswer.Text
        End Get
        Set(ByVal value As String)
            Dim sval() As String = value.Split("|")
            txtAnswer.Text = sval(0)
            'txtName.Text = sval(1)
            txtAnswer.ReadOnly = True
            txtName.ReadOnly = True
        End Set
    End Property
#Region "Methods"
    Public Sub ClearMe()

        txtAnswer.Text = String.Empty
        lblText.Text = String.Empty
    End Sub

    Public Function ValidateUI() As Boolean
        If Len(txtAnswer.Text) = 0 Then
            txtAnswer.BackColor = Color.Red
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#End Region


    Public Sub CleaMe()
        txtAnswer.Text = ""
        txtName.Text = ""
    End Sub
    'Public WriteOnly Property ptyResponse As String
    '    Set(ByVal value As String)
    '        Dim sVal() As String = value.Split("|")
    '        txtAnswer.Text = sVal(0)
    '        txtName.Text = sVal(1)
    '    End Set
    'End Property
End Class
