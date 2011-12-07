<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcBirths
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
        Me.birthsTabControl = New System.Windows.Forms.TabControl()
        Me.page1 = New System.Windows.Forms.TabPage()
        Me.page2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.q210Label = New System.Windows.Forms.Label()
        Me.q209Label = New System.Windows.Forms.Label()
        Me.q208aComboBox = New System.Windows.Forms.ComboBox()
        Me.q208aLabel = New System.Windows.Forms.Label()
        Me.q208Label = New System.Windows.Forms.Label()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.birthsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.initialsUcKaisTextBox = New KaisII.UcKaisTextBox()
        Me.q202UcLookupComboBox = New KaisII.UcLookupComboBox()
        Me.q204UcComboWithSpecify = New KaisII.UcOtheredComboBox()
        Me.q203UcKaisDatePicker = New KaisII.UcKaisDatePicker()
        Me.q207UcLookupComboBox = New KaisII.UcLookupComboBox()
        Me.q206aUcKaisTextBox = New KaisII.UcKaisTextBox()
        Me.q205UcLookupComboBox = New KaisII.UcLookupComboBox()
        Me.q206UcKaisDatePicker = New KaisII.UcKaisDatePicker()
        Me.q210UcOtheredComboBox = New KaisII.UcOtheredComboBox()
        Me.q209UcOtheredComboBox = New KaisII.UcOtheredComboBox()
        Me.q208UcOtheredComboBox = New KaisII.UcOtheredComboBox()
        Me.UcOtheredComboBox2 = New KaisII.UcOtheredComboBox()
        Me.UcOtheredComboBox3 = New KaisII.UcOtheredComboBox()
        Me.birthsTabControl.SuspendLayout()
        Me.page1.SuspendLayout()
        Me.page2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.birthsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'birthsTabControl
        '
        Me.birthsTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.birthsTabControl.Controls.Add(Me.page1)
        Me.birthsTabControl.Controls.Add(Me.page2)
        Me.birthsTabControl.Controls.Add(Me.TabPage1)
        Me.birthsTabControl.Controls.Add(Me.TabPage2)
        Me.birthsTabControl.Controls.Add(Me.TabPage3)
        Me.birthsTabControl.Controls.Add(Me.TabPage4)
        Me.birthsTabControl.Controls.Add(Me.TabPage5)
        Me.birthsTabControl.Controls.Add(Me.TabPage6)
        Me.birthsTabControl.Location = New System.Drawing.Point(3, 3)
        Me.birthsTabControl.Name = "birthsTabControl"
        Me.birthsTabControl.SelectedIndex = 0
        Me.birthsTabControl.Size = New System.Drawing.Size(1008, 344)
        Me.birthsTabControl.TabIndex = 0
        '
        'page1
        '
        Me.page1.Controls.Add(Me.initialsUcKaisTextBox)
        Me.page1.Controls.Add(Me.q202UcLookupComboBox)
        Me.page1.Controls.Add(Me.q204UcComboWithSpecify)
        Me.page1.Controls.Add(Me.q203UcKaisDatePicker)
        Me.page1.Location = New System.Drawing.Point(4, 22)
        Me.page1.Name = "page1"
        Me.page1.Padding = New System.Windows.Forms.Padding(3)
        Me.page1.Size = New System.Drawing.Size(1000, 318)
        Me.page1.TabIndex = 0
        Me.page1.Text = "Page 1"
        Me.page1.UseVisualStyleBackColor = True
        '
        'page2
        '
        Me.page2.Controls.Add(Me.q207UcLookupComboBox)
        Me.page2.Controls.Add(Me.q206aUcKaisTextBox)
        Me.page2.Controls.Add(Me.q205UcLookupComboBox)
        Me.page2.Controls.Add(Me.q206UcKaisDatePicker)
        Me.page2.Location = New System.Drawing.Point(4, 22)
        Me.page2.Name = "page2"
        Me.page2.Padding = New System.Windows.Forms.Padding(3)
        Me.page2.Size = New System.Drawing.Size(1000, 318)
        Me.page2.TabIndex = 1
        Me.page2.Text = "Page 2"
        Me.page2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.q210UcOtheredComboBox)
        Me.TabPage1.Controls.Add(Me.q210Label)
        Me.TabPage1.Controls.Add(Me.q209Label)
        Me.TabPage1.Controls.Add(Me.q208aComboBox)
        Me.TabPage1.Controls.Add(Me.q208aLabel)
        Me.TabPage1.Controls.Add(Me.q208Label)
        Me.TabPage1.Controls.Add(Me.ShapeContainer3)
        Me.TabPage1.Controls.Add(Me.q209UcOtheredComboBox)
        Me.TabPage1.Controls.Add(Me.q208UcOtheredComboBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1000, 318)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Page 3"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'q210Label
        '
        Me.q210Label.AutoSize = True
        Me.q210Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q210Label.Location = New System.Drawing.Point(8, 219)
        Me.q210Label.Name = "q210Label"
        Me.q210Label.Size = New System.Drawing.Size(49, 20)
        Me.q210Label.TabIndex = 7
        Me.q210Label.Tag = "49"
        Me.q210Label.Text = "q210"
        '
        'q209Label
        '
        Me.q209Label.AutoSize = True
        Me.q209Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q209Label.Location = New System.Drawing.Point(7, 157)
        Me.q209Label.Name = "q209Label"
        Me.q209Label.Size = New System.Drawing.Size(49, 20)
        Me.q209Label.TabIndex = 7
        Me.q209Label.Tag = "49"
        Me.q209Label.Text = "q209"
        '
        'q208aComboBox
        '
        Me.q208aComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q208aComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.q208aComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q208aComboBox.FormattingEnabled = True
        Me.q208aComboBox.Location = New System.Drawing.Point(13, 106)
        Me.q208aComboBox.Name = "q208aComboBox"
        Me.q208aComboBox.Size = New System.Drawing.Size(993, 28)
        Me.q208aComboBox.TabIndex = 11
        Me.q208aComboBox.Tag = "39"
        '
        'q208aLabel
        '
        Me.q208aLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q208aLabel.AutoSize = True
        Me.q208aLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q208aLabel.Location = New System.Drawing.Point(9, 83)
        Me.q208aLabel.Name = "q208aLabel"
        Me.q208aLabel.Size = New System.Drawing.Size(59, 20)
        Me.q208aLabel.TabIndex = 10
        Me.q208aLabel.Tag = "38"
        Me.q208aLabel.Text = "q208a"
        '
        'q208Label
        '
        Me.q208Label.AutoSize = True
        Me.q208Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q208Label.Location = New System.Drawing.Point(7, 7)
        Me.q208Label.Name = "q208Label"
        Me.q208Label.Size = New System.Drawing.Size(49, 20)
        Me.q208Label.TabIndex = 7
        Me.q208Label.Tag = "49"
        Me.q208Label.Text = "q208"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7})
        Me.ShapeContainer3.Size = New System.Drawing.Size(994, 312)
        Me.ShapeContainer3.TabIndex = 9
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape8.BorderWidth = 2
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 9
        Me.LineShape8.X2 = 987
        Me.LineShape8.Y1 = 142
        Me.LineShape8.Y2 = 142
        '
        'LineShape7
        '
        Me.LineShape7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape7.BorderWidth = 2
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 10
        Me.LineShape7.X2 = 988
        Me.LineShape7.Y1 = 70
        Me.LineShape7.Y2 = 70
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1000, 318)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Page 4"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1000, 318)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Page 5"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1000, 318)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Page 6"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1000, 318)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Page 7"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1000, 318)
        Me.TabPage6.TabIndex = 7
        Me.TabPage6.Text = "Page 8"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(805, 353)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(100, 30)
        Me.saveButton.TabIndex = 1
        Me.saveButton.Text = "Add"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeButton.Location = New System.Drawing.Point(907, 353)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(100, 30)
        Me.removeButton.TabIndex = 1
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'birthsDataGridView
        '
        Me.birthsDataGridView.AllowUserToAddRows = False
        Me.birthsDataGridView.AllowUserToDeleteRows = False
        Me.birthsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.birthsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.birthsDataGridView.Location = New System.Drawing.Point(3, 389)
        Me.birthsDataGridView.Name = "birthsDataGridView"
        Me.birthsDataGridView.ReadOnly = True
        Me.birthsDataGridView.Size = New System.Drawing.Size(1008, 95)
        Me.birthsDataGridView.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Tag = "49"
        Me.Label3.Text = "q204"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Tag = "49"
        Me.Label4.Text = "q204"
        '
        'initialsUcKaisTextBox
        '
        Me.initialsUcKaisTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.initialsUcKaisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.initialsUcKaisTextBox.Location = New System.Drawing.Point(11, 6)
        Me.initialsUcKaisTextBox.Name = "initialsUcKaisTextBox"
        Me.initialsUcKaisTextBox.Size = New System.Drawing.Size(983, 66)
        Me.initialsUcKaisTextBox.TabIndex = 8
        Me.initialsUcKaisTextBox.Tag = "initials"
        Me.initialsUcKaisTextBox.UpperCase = False
        '
        'q202UcLookupComboBox
        '
        Me.q202UcLookupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q202UcLookupComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q202UcLookupComboBox.Field = Nothing
        Me.q202UcLookupComboBox.Location = New System.Drawing.Point(11, 78)
        Me.q202UcLookupComboBox.Name = "q202UcLookupComboBox"
        Me.q202UcLookupComboBox.Size = New System.Drawing.Size(983, 72)
        Me.q202UcLookupComboBox.TabIndex = 7
        Me.q202UcLookupComboBox.Tag = "q_202"
        '
        'q204UcComboWithSpecify
        '
        Me.q204UcComboWithSpecify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q204UcComboWithSpecify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q204UcComboWithSpecify.Location = New System.Drawing.Point(11, 235)
        Me.q204UcComboWithSpecify.Name = "q204UcComboWithSpecify"
        Me.q204UcComboWithSpecify.Size = New System.Drawing.Size(983, 73)
        Me.q204UcComboWithSpecify.TabIndex = 6
        Me.q204UcComboWithSpecify.Tag = "q_204"
        '
        'q203UcKaisDatePicker
        '
        Me.q203UcKaisDatePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q203UcKaisDatePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q203UcKaisDatePicker.Location = New System.Drawing.Point(11, 156)
        Me.q203UcKaisDatePicker.MaxDays = 31
        Me.q203UcKaisDatePicker.MaxMonths = 12
        Me.q203UcKaisDatePicker.MaxYears = 9999
        Me.q203UcKaisDatePicker.MinDays = 1
        Me.q203UcKaisDatePicker.MinMonths = 1
        Me.q203UcKaisDatePicker.MinYears = 1900
        Me.q203UcKaisDatePicker.Name = "q203UcKaisDatePicker"
        Me.q203UcKaisDatePicker.Size = New System.Drawing.Size(983, 73)
        Me.q203UcKaisDatePicker.TabIndex = 5
        Me.q203UcKaisDatePicker.Tag = "q_203"
        Me.q203UcKaisDatePicker.UnknownDays = 888
        Me.q203UcKaisDatePicker.UnknownMonths = 888
        Me.q203UcKaisDatePicker.UnknownYears = 888
        '
        'q207UcLookupComboBox
        '
        Me.q207UcLookupComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q207UcLookupComboBox.Field = Nothing
        Me.q207UcLookupComboBox.Location = New System.Drawing.Point(13, 231)
        Me.q207UcLookupComboBox.Name = "q207UcLookupComboBox"
        Me.q207UcLookupComboBox.Size = New System.Drawing.Size(991, 72)
        Me.q207UcLookupComboBox.TabIndex = 14
        Me.q207UcLookupComboBox.Tag = "q_207"
        '
        'q206aUcKaisTextBox
        '
        Me.q206aUcKaisTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q206aUcKaisTextBox.Location = New System.Drawing.Point(13, 159)
        Me.q206aUcKaisTextBox.Name = "q206aUcKaisTextBox"
        Me.q206aUcKaisTextBox.Size = New System.Drawing.Size(991, 66)
        Me.q206aUcKaisTextBox.TabIndex = 13
        Me.q206aUcKaisTextBox.Tag = "q_206_a"
        Me.q206aUcKaisTextBox.UpperCase = False
        '
        'q205UcLookupComboBox
        '
        Me.q205UcLookupComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q205UcLookupComboBox.Field = Nothing
        Me.q205UcLookupComboBox.Location = New System.Drawing.Point(13, 6)
        Me.q205UcLookupComboBox.Name = "q205UcLookupComboBox"
        Me.q205UcLookupComboBox.Size = New System.Drawing.Size(991, 72)
        Me.q205UcLookupComboBox.TabIndex = 12
        Me.q205UcLookupComboBox.Tag = "q_205"
        '
        'q206UcKaisDatePicker
        '
        Me.q206UcKaisDatePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q206UcKaisDatePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q206UcKaisDatePicker.Location = New System.Drawing.Point(13, 84)
        Me.q206UcKaisDatePicker.MaxDays = 31
        Me.q206UcKaisDatePicker.MaxMonths = 12
        Me.q206UcKaisDatePicker.MaxYears = 9999
        Me.q206UcKaisDatePicker.MinDays = 1
        Me.q206UcKaisDatePicker.MinMonths = 1
        Me.q206UcKaisDatePicker.MinYears = 1900
        Me.q206UcKaisDatePicker.Name = "q206UcKaisDatePicker"
        Me.q206UcKaisDatePicker.Size = New System.Drawing.Size(991, 68)
        Me.q206UcKaisDatePicker.TabIndex = 7
        Me.q206UcKaisDatePicker.Tag = "48"
        Me.q206UcKaisDatePicker.UnknownDays = 888
        Me.q206UcKaisDatePicker.UnknownMonths = 888
        Me.q206UcKaisDatePicker.UnknownYears = 888
        '
        'q210UcOtheredComboBox
        '
        Me.q210UcOtheredComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q210UcOtheredComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q210UcOtheredComboBox.Location = New System.Drawing.Point(12, 242)
        Me.q210UcOtheredComboBox.Name = "q210UcOtheredComboBox"
        Me.q210UcOtheredComboBox.Size = New System.Drawing.Size(993, 35)
        Me.q210UcOtheredComboBox.TabIndex = 8
        Me.q210UcOtheredComboBox.Tag = "49"
        '
        'q209UcOtheredComboBox
        '
        Me.q209UcOtheredComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q209UcOtheredComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q209UcOtheredComboBox.Location = New System.Drawing.Point(11, 180)
        Me.q209UcOtheredComboBox.Name = "q209UcOtheredComboBox"
        Me.q209UcOtheredComboBox.Size = New System.Drawing.Size(993, 35)
        Me.q209UcOtheredComboBox.TabIndex = 8
        Me.q209UcOtheredComboBox.Tag = "49"
        '
        'q208UcOtheredComboBox
        '
        Me.q208UcOtheredComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q208UcOtheredComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q208UcOtheredComboBox.Location = New System.Drawing.Point(11, 30)
        Me.q208UcOtheredComboBox.Name = "q208UcOtheredComboBox"
        Me.q208UcOtheredComboBox.Size = New System.Drawing.Size(993, 35)
        Me.q208UcOtheredComboBox.TabIndex = 8
        Me.q208UcOtheredComboBox.Tag = "49"
        '
        'UcOtheredComboBox2
        '
        Me.UcOtheredComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcOtheredComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcOtheredComboBox2.Location = New System.Drawing.Point(14, 178)
        Me.UcOtheredComboBox2.Name = "UcOtheredComboBox2"
        Me.UcOtheredComboBox2.Size = New System.Drawing.Size(993, 35)
        Me.UcOtheredComboBox2.TabIndex = 8
        Me.UcOtheredComboBox2.Tag = "49"
        '
        'UcOtheredComboBox3
        '
        Me.UcOtheredComboBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcOtheredComboBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcOtheredComboBox3.Location = New System.Drawing.Point(13, 242)
        Me.UcOtheredComboBox3.Name = "UcOtheredComboBox3"
        Me.UcOtheredComboBox3.Size = New System.Drawing.Size(993, 35)
        Me.UcOtheredComboBox3.TabIndex = 8
        Me.UcOtheredComboBox3.Tag = "49"
        '
        'UcBirths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.birthsDataGridView)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.birthsTabControl)
        Me.Name = "UcBirths"
        Me.Size = New System.Drawing.Size(1014, 487)
        Me.birthsTabControl.ResumeLayout(False)
        Me.page1.ResumeLayout(False)
        Me.page2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.birthsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents birthsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents page1 As System.Windows.Forms.TabPage
    Friend WithEvents page2 As System.Windows.Forms.TabPage
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents birthsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents q203UcKaisDatePicker As KaisII.UcKaisDatePicker
    Friend WithEvents q204UcComboWithSpecify As KaisII.UcOtheredComboBox
    Friend WithEvents q206UcKaisDatePicker As KaisII.UcKaisDatePicker
    Friend WithEvents q208UcOtheredComboBox As KaisII.UcOtheredComboBox
    Friend WithEvents q208Label As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents q208aComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents q208aLabel As System.Windows.Forms.Label
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents q210UcOtheredComboBox As KaisII.UcOtheredComboBox
    Friend WithEvents q210Label As System.Windows.Forms.Label
    Friend WithEvents q209UcOtheredComboBox As KaisII.UcOtheredComboBox
    Friend WithEvents q209Label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UcOtheredComboBox2 As KaisII.UcOtheredComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UcOtheredComboBox3 As KaisII.UcOtheredComboBox
    Friend WithEvents q202UcLookupComboBox As KaisII.UcLookupComboBox
    Friend WithEvents initialsUcKaisTextBox As KaisII.UcKaisTextBox
    Friend WithEvents q205UcLookupComboBox As KaisII.UcLookupComboBox
    Friend WithEvents q206aUcKaisTextBox As KaisII.UcKaisTextBox
    Friend WithEvents q207UcLookupComboBox As KaisII.UcLookupComboBox

End Class
