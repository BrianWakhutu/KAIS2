<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbContextMenu = New System.Windows.Forms.PictureBox()
        Me.MnuContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InterviewActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendInterviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionCommentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitInterviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UcMultivalue1 = New KaisII.ucMultivalue()
        Me.UcSingleDomain1 = New KaisII.ucSingleDomain()
        Me.UcVisits1 = New KaisII.ucVisits()
        Me.UcSplash1 = New KaisII.ucSplash()
        Me.UcOptionSingleDomain1 = New KaisII.ucOptionSingleDomain()
        Me.UcMonthYear1 = New KaisII.ucMonthYear()
        Me.UcLineNumber1 = New KaisII.ucLineNumber()
        Me.UcHouseholdMembers1 = New KaisII.ucHouseholdMembers()
        Me.UcEndInterview1 = New KaisII.ucEndInterview()
        Me.UcDatevb1 = New KaisII.ucDatevb()
        Me.Uc3011 = New KaisII.uc301()
        Me.Numeric1 = New KaisII.Numeric()
        Me.Freetext1 = New KaisII.Freetext()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuContextMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UcMultivalue1)
        Me.Panel1.Controls.Add(Me.UcSingleDomain1)
        Me.Panel1.Controls.Add(Me.UcVisits1)
        Me.Panel1.Controls.Add(Me.UcSplash1)
        Me.Panel1.Controls.Add(Me.UcOptionSingleDomain1)
        Me.Panel1.Controls.Add(Me.UcMonthYear1)
        Me.Panel1.Controls.Add(Me.UcLineNumber1)
        Me.Panel1.Controls.Add(Me.UcHouseholdMembers1)
        Me.Panel1.Controls.Add(Me.UcEndInterview1)
        Me.Panel1.Controls.Add(Me.UcDatevb1)
        Me.Panel1.Controls.Add(Me.Uc3011)
        Me.Panel1.Controls.Add(Me.Numeric1)
        Me.Panel1.Controls.Add(Me.Freetext1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 476)
        Me.Panel1.TabIndex = 0
        '
        'cmdBack
        '
        Me.cmdBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(33, 2)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(85, 39)
        Me.cmdBack.TabIndex = 1
        Me.cmdBack.Text = "<<BACK"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(667, 0)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 39)
        Me.cmdNext.TabIndex = 2
        Me.cmdNext.Text = "NEXT>>"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.pbContextMenu)
        Me.Panel2.Controls.Add(Me.cmdNext)
        Me.Panel2.Controls.Add(Me.cmdBack)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(747, 44)
        Me.Panel2.TabIndex = 3
        '
        'pbContextMenu
        '
        Me.pbContextMenu.ContextMenuStrip = Me.MnuContextMenu
        Me.pbContextMenu.InitialImage = Nothing
        Me.pbContextMenu.Location = New System.Drawing.Point(3, 3)
        Me.pbContextMenu.Name = "pbContextMenu"
        Me.pbContextMenu.Size = New System.Drawing.Size(24, 29)
        Me.pbContextMenu.TabIndex = 3
        Me.pbContextMenu.TabStop = False
        '
        'MnuContextMenu
        '
        Me.MnuContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InterviewActionsToolStripMenuItem, Me.ExitInterviewToolStripMenuItem})
        Me.MnuContextMenu.Name = "MnuContextMenu"
        Me.MnuContextMenu.Size = New System.Drawing.Size(166, 48)
        '
        'InterviewActionsToolStripMenuItem
        '
        Me.InterviewActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuspendInterviewToolStripMenuItem, Me.ChangeLanguageToolStripMenuItem, Me.QuestionCommentToolStripMenuItem})
        Me.InterviewActionsToolStripMenuItem.Name = "InterviewActionsToolStripMenuItem"
        Me.InterviewActionsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.InterviewActionsToolStripMenuItem.Text = "Interview Actions"
        '
        'SuspendInterviewToolStripMenuItem
        '
        Me.SuspendInterviewToolStripMenuItem.Name = "SuspendInterviewToolStripMenuItem"
        Me.SuspendInterviewToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SuspendInterviewToolStripMenuItem.Text = "Suspend Interview"
        '
        'ChangeLanguageToolStripMenuItem
        '
        Me.ChangeLanguageToolStripMenuItem.Name = "ChangeLanguageToolStripMenuItem"
        Me.ChangeLanguageToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ChangeLanguageToolStripMenuItem.Text = "Change Language"
        '
        'QuestionCommentToolStripMenuItem
        '
        Me.QuestionCommentToolStripMenuItem.Name = "QuestionCommentToolStripMenuItem"
        Me.QuestionCommentToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.QuestionCommentToolStripMenuItem.Text = "Question Comment"
        '
        'ExitInterviewToolStripMenuItem
        '
        Me.ExitInterviewToolStripMenuItem.Name = "ExitInterviewToolStripMenuItem"
        Me.ExitInterviewToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ExitInterviewToolStripMenuItem.Text = "Exit Interview"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 33)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'UcMultivalue1
        '
        Me.UcMultivalue1.Location = New System.Drawing.Point(187, 175)
        Me.UcMultivalue1.Name = "UcMultivalue1"
        Me.UcMultivalue1.OtherSpecify = ""
        Me.UcMultivalue1.Size = New System.Drawing.Size(397, 133)
        Me.UcMultivalue1.TabIndex = 12
        '
        'UcSingleDomain1
        '
        Me.UcSingleDomain1.Location = New System.Drawing.Point(119, 34)
        Me.UcSingleDomain1.Name = "UcSingleDomain1"
        Me.UcSingleDomain1.ptyInstructionText = Nothing
        Me.UcSingleDomain1.ptyInternalErrorText = Nothing
        Me.UcSingleDomain1.ptyLanguage = Nothing
        Me.UcSingleDomain1.ptyLookupsCol = Nothing
        Me.UcSingleDomain1.ptyOtherSpecify = ""
        Me.UcSingleDomain1.ptyQuestionText = Nothing
        Me.UcSingleDomain1.ptyRecordId = 0
        Me.UcSingleDomain1.ptySelectedValue = Nothing
        Me.UcSingleDomain1.Size = New System.Drawing.Size(285, 114)
        Me.UcSingleDomain1.TabIndex = 11
        '
        'UcVisits1
        '
        Me.UcVisits1.Location = New System.Drawing.Point(379, 12)
        Me.UcVisits1.Name = "UcVisits1"
        Me.UcVisits1.Size = New System.Drawing.Size(335, 136)
        Me.UcVisits1.TabIndex = 10
        '
        'UcSplash1
        '
        Me.UcSplash1.Location = New System.Drawing.Point(66, 153)
        Me.UcSplash1.Name = "UcSplash1"
        Me.UcSplash1.Size = New System.Drawing.Size(139, 98)
        Me.UcSplash1.TabIndex = 9
        '
        'UcOptionSingleDomain1
        '
        Me.UcOptionSingleDomain1.Location = New System.Drawing.Point(379, 200)
        Me.UcOptionSingleDomain1.Name = "UcOptionSingleDomain1"
        Me.UcOptionSingleDomain1.Size = New System.Drawing.Size(126, 51)
        Me.UcOptionSingleDomain1.TabIndex = 8
        '
        'UcMonthYear1
        '
        Me.UcMonthYear1.Location = New System.Drawing.Point(66, 257)
        Me.UcMonthYear1.Name = "UcMonthYear1"
        Me.UcMonthYear1.Size = New System.Drawing.Size(145, 59)
        Me.UcMonthYear1.TabIndex = 7
        '
        'UcLineNumber1
        '
        Me.UcLineNumber1.Location = New System.Drawing.Point(543, 159)
        Me.UcLineNumber1.Name = "UcLineNumber1"
        Me.UcLineNumber1.ptyResponse = ""
        Me.UcLineNumber1.Size = New System.Drawing.Size(171, 75)
        Me.UcLineNumber1.TabIndex = 6
        '
        'UcHouseholdMembers1
        '
        Me.UcHouseholdMembers1.Location = New System.Drawing.Point(256, 95)
        Me.UcHouseholdMembers1.Name = "UcHouseholdMembers1"
        Me.UcHouseholdMembers1.Size = New System.Drawing.Size(181, 74)
        Me.UcHouseholdMembers1.TabIndex = 5
        '
        'UcEndInterview1
        '
        Me.UcEndInterview1.Location = New System.Drawing.Point(282, 53)
        Me.UcEndInterview1.Name = "UcEndInterview1"
        Me.UcEndInterview1.Size = New System.Drawing.Size(164, 57)
        Me.UcEndInterview1.TabIndex = 4
        '
        'UcDatevb1
        '
        Me.UcDatevb1.Location = New System.Drawing.Point(282, 21)
        Me.UcDatevb1.Name = "UcDatevb1"
        Me.UcDatevb1.Size = New System.Drawing.Size(142, 23)
        Me.UcDatevb1.TabIndex = 3
        '
        'Uc3011
        '
        Me.Uc3011.Location = New System.Drawing.Point(23, 69)
        Me.Uc3011.Name = "Uc3011"
        Me.Uc3011.Size = New System.Drawing.Size(157, 41)
        Me.Uc3011.TabIndex = 2
        '
        'Numeric1
        '
        Me.Numeric1.Location = New System.Drawing.Point(143, 21)
        Me.Numeric1.Name = "Numeric1"
        Me.Numeric1.ptyResponse = ""
        Me.Numeric1.Size = New System.Drawing.Size(84, 32)
        Me.Numeric1.TabIndex = 1
        '
        'Freetext1
        '
        Me.Freetext1.Location = New System.Drawing.Point(23, 12)
        Me.Freetext1.Name = "Freetext1"
        Me.Freetext1.ptyResponse = ""
        Me.Freetext1.Size = New System.Drawing.Size(76, 41)
        Me.Freetext1.TabIndex = 0
        '
        'Interview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 476)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Interview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuContextMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcBirths1 As KaisII.UcBirths
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UcVisits1 As KaisII.ucVisits
    Friend WithEvents UcSplash1 As KaisII.ucSplash
    Friend WithEvents UcOptionSingleDomain1 As KaisII.ucOptionSingleDomain
    Friend WithEvents UcMonthYear1 As KaisII.ucMonthYear
    Friend WithEvents UcLineNumber1 As KaisII.ucLineNumber
    Friend WithEvents UcHouseholdMembers1 As KaisII.ucHouseholdMembers
    Friend WithEvents UcEndInterview1 As KaisII.ucEndInterview
    Friend WithEvents UcDatevb1 As KaisII.ucDatevb
    Friend WithEvents Uc3011 As KaisII.uc301
    Friend WithEvents Numeric1 As KaisII.Numeric
    Friend WithEvents Freetext1 As KaisII.Freetext
    Friend WithEvents UcSingleDomain1 As KaisII.ucSingleDomain
    Friend WithEvents UcMultivalue1 As KaisII.ucMultivalue
    Friend WithEvents MnuContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InterviewActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendInterviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionCommentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitInterviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbContextMenu As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
