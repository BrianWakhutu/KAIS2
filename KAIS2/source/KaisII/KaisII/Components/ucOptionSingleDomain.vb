Imports KaisII.FormGenClasses
Public Class ucOptionSingleDomain
    Private rdList As List(Of RadioButton)
#Region "Properties"
    Public WriteOnly Property PtyLookups() As List(Of Lookup)
        Set(ByVal value As List(Of Lookup))


            rdList = New List(Of RadioButton)
            If Not value Is Nothing Then
                Dim flw As New FlowLayoutPanel
                'With flw
                '    .Name = "flwLayout"
                '    '.Width = 455
                '    '.Height = 235
                '    .Dock = DockStyle.Fill
                '    Me.PanelControl1.Controls.Add(flw)
                'End With
                Dim iCount As Integer = value.Count
                Dim iHeight As Integer = (Panel3.Height - lblCaption.Height) / iCount
                Dim iTop As Integer = lblCaption.Height + lblCaption.Top
                For Each lkp As Lookup In value
                    Dim rd As New RadioButton

                    With rd
                        .Text = lkp.Lkp_Description
                        .Name = lkp.Lkp_Description & lkp.Lkp_No
                        .Tag = lkp
                        .AutoSize = False
                        .Font = New Font(.Font.FontFamily, 20, FontStyle.Regular, .Font.Unit)
                        rdList.Add(rd)
                        'SetRadioButtonEvents(lkp)

                        rd.Font = New Font("Arial", 18, FontStyle.Bold)
                        rd.Height = iHeight - 5
                        rd.Top = iTop
                        rd.Width = Panel3.Width
                        Panel3.Controls.Add(rd)
                        iTop = iTop + iHeight
                        .BackColor = Color.Gainsboro
                    End With
                Next
            End If
        End Set
    End Property
    Public Property ptyResponse() As Lookup
        Get
            ptyResponse = Nothing
            For Each rd As RadioButton In rdList
                If rd.Checked Then
                    Return TryCast(rd.Tag, Lookup)
                    Exit For
                End If
            Next
        End Get
        Set(ByVal value As Lookup)
            If Not value Is Nothing Then
                For Each rd As RadioButton In rdList
                    If TryCast(rd.Tag, Lookup).Lkp_No = value.Lkp_No Then
                        rd.Checked = True

                        Exit For
                    End If
                Next
            End If

        End Set
    End Property
    Public WriteOnly Property ptyCaption() As String
        Set(ByVal value As String)
            If value = "" Then
                lblCaption.Text = "Select Response"
            Else
                lblCaption.Text = value
            End If
        End Set
    End Property
    Public WriteOnly Property QuestionText()
        Set(ByVal value)
            lblText.Text = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Function ValidateUI() As Boolean
        For Each rd As RadioButton In rdList
            If rd.Checked Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub ClearMe()
        'rdList.Clear()

        'For Each rd As RadioButton In rdList
        '    rd.Checked = False
        'Next
        lblText.Text = vbNullString
        'Me.Controls.Clear()
        Panel3.Controls.Clear()
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is FlowLayoutPanel Then
                ctl.Controls.Clear()
            End If
        Next
    End Sub
#End Region

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
