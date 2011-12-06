<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHouseholdMembers
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.plQuestintext = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnAns = New System.Windows.Forms.Panel()
        Me.cboEmancipated = New System.Windows.Forms.ComboBox()
        Me.cboAgeYear = New System.Windows.Forms.ComboBox()
        Me.cboStayHerelastNight = New System.Windows.Forms.ComboBox()
        Me.cboLivehere = New System.Windows.Forms.ComboBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.cboRelationship = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lvMembers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmdAddToList = New System.Windows.Forms.Button()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdMoveUp = New System.Windows.Forms.Button()
        Me.cmdMoveDown = New System.Windows.Forms.Button()
        Me.plQuestintext.SuspendLayout()
        Me.pnAns.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'plQuestintext
        '
        Me.plQuestintext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plQuestintext.Controls.Add(Me.Label1)
        Me.plQuestintext.Location = New System.Drawing.Point(3, 4)
        Me.plQuestintext.Name = "plQuestintext"
        Me.plQuestintext.Size = New System.Drawing.Size(625, 29)
        Me.plQuestintext.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(623, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KAIS HOUSEHOLD MEMBERS LISTING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnAns
        '
        Me.pnAns.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnAns.Controls.Add(Me.cboEmancipated)
        Me.pnAns.Controls.Add(Me.cboAgeYear)
        Me.pnAns.Controls.Add(Me.cboStayHerelastNight)
        Me.pnAns.Controls.Add(Me.cboLivehere)
        Me.pnAns.Controls.Add(Me.cboSex)
        Me.pnAns.Controls.Add(Me.cboRelationship)
        Me.pnAns.Controls.Add(Me.txtName)
        Me.pnAns.Controls.Add(Me.txtAge)
        Me.pnAns.Controls.Add(Me.Label9)
        Me.pnAns.Controls.Add(Me.Label8)
        Me.pnAns.Controls.Add(Me.Label7)
        Me.pnAns.Controls.Add(Me.Label6)
        Me.pnAns.Controls.Add(Me.Label5)
        Me.pnAns.Controls.Add(Me.Label4)
        Me.pnAns.Controls.Add(Me.Label3)
        Me.pnAns.Controls.Add(Me.Label2)
        Me.pnAns.Location = New System.Drawing.Point(8, 40)
        Me.pnAns.Name = "pnAns"
        Me.pnAns.Size = New System.Drawing.Size(623, 153)
        Me.pnAns.TabIndex = 1
        '
        'cboEmancipated
        '
        Me.cboEmancipated.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboEmancipated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmancipated.FormattingEnabled = True
        Me.cboEmancipated.Location = New System.Drawing.Point(485, 56)
        Me.cboEmancipated.Name = "cboEmancipated"
        Me.cboEmancipated.Size = New System.Drawing.Size(121, 21)
        Me.cboEmancipated.TabIndex = 5
        Me.cboEmancipated.Tag = "83"
        '
        'cboAgeYear
        '
        Me.cboAgeYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboAgeYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgeYear.FormattingEnabled = True
        Me.cboAgeYear.Location = New System.Drawing.Point(485, 32)
        Me.cboAgeYear.Name = "cboAgeYear"
        Me.cboAgeYear.Size = New System.Drawing.Size(121, 21)
        Me.cboAgeYear.TabIndex = 5
        Me.cboAgeYear.Tag = "38"
        '
        'cboStayHerelastNight
        '
        Me.cboStayHerelastNight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStayHerelastNight.FormattingEnabled = True
        Me.cboStayHerelastNight.Location = New System.Drawing.Point(107, 115)
        Me.cboStayHerelastNight.Name = "cboStayHerelastNight"
        Me.cboStayHerelastNight.Size = New System.Drawing.Size(121, 21)
        Me.cboStayHerelastNight.TabIndex = 5
        Me.cboStayHerelastNight.Tag = "83"
        '
        'cboLivehere
        '
        Me.cboLivehere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLivehere.FormattingEnabled = True
        Me.cboLivehere.Location = New System.Drawing.Point(107, 90)
        Me.cboLivehere.Name = "cboLivehere"
        Me.cboLivehere.Size = New System.Drawing.Size(121, 21)
        Me.cboLivehere.TabIndex = 5
        Me.cboLivehere.Tag = "83"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(107, 63)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(121, 21)
        Me.cboSex.TabIndex = 5
        Me.cboSex.Tag = "109"
        '
        'cboRelationship
        '
        Me.cboRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRelationship.FormattingEnabled = True
        Me.cboRelationship.Location = New System.Drawing.Point(107, 36)
        Me.cboRelationship.Name = "cboRelationship"
        Me.cboRelationship.Size = New System.Drawing.Size(248, 21)
        Me.cboRelationship.TabIndex = 4
        Me.cboRelationship.Tag = "41"
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(107, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 22)
        Me.txtName.TabIndex = 3
        '
        'txtAge
        '
        Me.txtAge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAge.Location = New System.Drawing.Point(485, 9)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(75, 20)
        Me.txtAge.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(369, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Emancipated"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(363, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Age Month / Year"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Age"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Slept Last Night"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Live Here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RelationShip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lvMembers)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(631, 147)
        Me.Panel2.TabIndex = 2
        '
        'lvMembers
        '
        Me.lvMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvMembers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMembers.FullRowSelect = True
        Me.lvMembers.GridLines = True
        Me.lvMembers.Location = New System.Drawing.Point(0, 0)
        Me.lvMembers.MultiSelect = False
        Me.lvMembers.Name = "lvMembers"
        Me.lvMembers.Size = New System.Drawing.Size(629, 145)
        Me.lvMembers.TabIndex = 0
        Me.lvMembers.UseCompatibleStateImageBehavior = False
        Me.lvMembers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "RelationShip"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sex"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Live Here"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Slept here"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Age"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "AgeType"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Emancipated"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Parent/G"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CohabA"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CohabB"
        Me.ColumnHeader11.Width = 100
        '
        'CmdAddToList
        '
        Me.CmdAddToList.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CmdAddToList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToList.Location = New System.Drawing.Point(529, 199)
        Me.CmdAddToList.Name = "CmdAddToList"
        Me.CmdAddToList.Size = New System.Drawing.Size(98, 23)
        Me.CmdAddToList.TabIndex = 3
        Me.CmdAddToList.Text = "Add To List"
        Me.CmdAddToList.UseVisualStyleBackColor = True
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.Location = New System.Drawing.Point(448, 199)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(75, 23)
        Me.cmdRemove.TabIndex = 4
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = True
        '
        'cmdMoveUp
        '
        Me.cmdMoveUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdMoveUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveUp.Location = New System.Drawing.Point(276, 200)
        Me.cmdMoveUp.Name = "cmdMoveUp"
        Me.cmdMoveUp.Size = New System.Drawing.Size(75, 23)
        Me.cmdMoveUp.TabIndex = 5
        Me.cmdMoveUp.Text = "Move Up"
        Me.cmdMoveUp.UseVisualStyleBackColor = True
        '
        'cmdMoveDown
        '
        Me.cmdMoveDown.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdMoveDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveDown.Location = New System.Drawing.Point(357, 200)
        Me.cmdMoveDown.Name = "cmdMoveDown"
        Me.cmdMoveDown.Size = New System.Drawing.Size(75, 23)
        Me.cmdMoveDown.TabIndex = 6
        Me.cmdMoveDown.Text = "Move Down"
        Me.cmdMoveDown.UseVisualStyleBackColor = True
        '
        'ucHouseholdMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdMoveDown)
        Me.Controls.Add(Me.cmdMoveUp)
        Me.Controls.Add(Me.cmdRemove)
        Me.Controls.Add(Me.CmdAddToList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnAns)
        Me.Controls.Add(Me.plQuestintext)
        Me.Name = "ucHouseholdMembers"
        Me.Size = New System.Drawing.Size(631, 375)
        Me.plQuestintext.ResumeLayout(False)
        Me.pnAns.ResumeLayout(False)
        Me.pnAns.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents plQuestintext As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnAns As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdAddToList As System.Windows.Forms.Button
    Friend WithEvents cmdRemove As System.Windows.Forms.Button
    Friend WithEvents lvMembers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdMoveUp As System.Windows.Forms.Button
    Friend WithEvents cmdMoveDown As System.Windows.Forms.Button
    Friend WithEvents cboEmancipated As System.Windows.Forms.ComboBox
    Friend WithEvents cboAgeYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboStayHerelastNight As System.Windows.Forms.ComboBox
    Friend WithEvents cboLivehere As System.Windows.Forms.ComboBox
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents cboRelationship As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
