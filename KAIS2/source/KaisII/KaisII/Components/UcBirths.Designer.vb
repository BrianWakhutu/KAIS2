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
        Me.q204Label = New System.Windows.Forms.Label()
        Me.q203Label = New System.Windows.Forms.Label()
        Me.q202ComboBox = New System.Windows.Forms.ComboBox()
        Me.q202Label = New System.Windows.Forms.Label()
        Me.initialsTextBox = New System.Windows.Forms.TextBox()
        Me.initialsLabel = New System.Windows.Forms.Label()
        Me.page2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.birthsDataGridView = New System.Windows.Forms.DataGridView()
        Me.q204UcComboWithSpecify = New KaisII.UcComboWithSpecify()
        Me.q203UcKaisDatePicker = New KaisII.UcKAISDobPicker()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.birthsTabControl.SuspendLayout()
        Me.page1.SuspendLayout()
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
        Me.birthsTabControl.Size = New System.Drawing.Size(1018, 318)
        Me.birthsTabControl.TabIndex = 0
        '
        'page1
        '
        Me.page1.Controls.Add(Me.q204UcComboWithSpecify)
        Me.page1.Controls.Add(Me.q203UcKaisDatePicker)
        Me.page1.Controls.Add(Me.q204Label)
        Me.page1.Controls.Add(Me.q203Label)
        Me.page1.Controls.Add(Me.q202ComboBox)
        Me.page1.Controls.Add(Me.q202Label)
        Me.page1.Controls.Add(Me.initialsTextBox)
        Me.page1.Controls.Add(Me.initialsLabel)
        Me.page1.Controls.Add(Me.ShapeContainer1)
        Me.page1.Location = New System.Drawing.Point(4, 22)
        Me.page1.Name = "page1"
        Me.page1.Padding = New System.Windows.Forms.Padding(3)
        Me.page1.Size = New System.Drawing.Size(1010, 292)
        Me.page1.TabIndex = 0
        Me.page1.Text = "Page 1"
        Me.page1.UseVisualStyleBackColor = True
        '
        'q204Label
        '
        Me.q204Label.AutoSize = True
        Me.q204Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q204Label.Location = New System.Drawing.Point(7, 228)
        Me.q204Label.Name = "q204Label"
        Me.q204Label.Size = New System.Drawing.Size(49, 20)
        Me.q204Label.TabIndex = 4
        Me.q204Label.Tag = "49"
        Me.q204Label.Text = "q204"
        '
        'q203Label
        '
        Me.q203Label.AutoSize = True
        Me.q203Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q203Label.Location = New System.Drawing.Point(7, 152)
        Me.q203Label.Name = "q203Label"
        Me.q203Label.Size = New System.Drawing.Size(49, 20)
        Me.q203Label.TabIndex = 4
        Me.q203Label.Tag = "48"
        Me.q203Label.Text = "q203"
        '
        'q202ComboBox
        '
        Me.q202ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q202ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.q202ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q202ComboBox.FormattingEnabled = True
        Me.q202ComboBox.Location = New System.Drawing.Point(11, 100)
        Me.q202ComboBox.Name = "q202ComboBox"
        Me.q202ComboBox.Size = New System.Drawing.Size(993, 28)
        Me.q202ComboBox.TabIndex = 3
        Me.q202ComboBox.Tag = "39"
        '
        'q202Label
        '
        Me.q202Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q202Label.AutoSize = True
        Me.q202Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q202Label.Location = New System.Drawing.Point(7, 77)
        Me.q202Label.Name = "q202Label"
        Me.q202Label.Size = New System.Drawing.Size(49, 20)
        Me.q202Label.TabIndex = 2
        Me.q202Label.Tag = "39"
        Me.q202Label.Text = "q202"
        '
        'initialsTextBox
        '
        Me.initialsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.initialsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialsTextBox.Location = New System.Drawing.Point(11, 26)
        Me.initialsTextBox.Name = "initialsTextBox"
        Me.initialsTextBox.Size = New System.Drawing.Size(993, 26)
        Me.initialsTextBox.TabIndex = 1
        Me.initialsTextBox.Tag = "38"
        '
        'initialsLabel
        '
        Me.initialsLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.initialsLabel.AutoSize = True
        Me.initialsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialsLabel.Location = New System.Drawing.Point(7, 3)
        Me.initialsLabel.Name = "initialsLabel"
        Me.initialsLabel.Size = New System.Drawing.Size(60, 20)
        Me.initialsLabel.TabIndex = 0
        Me.initialsLabel.Tag = "38"
        Me.initialsLabel.Text = "initials"
        '
        'page2
        '
        Me.page2.Location = New System.Drawing.Point(4, 22)
        Me.page2.Name = "page2"
        Me.page2.Padding = New System.Windows.Forms.Padding(3)
        Me.page2.Size = New System.Drawing.Size(1010, 292)
        Me.page2.TabIndex = 1
        Me.page2.Text = "Page 2"
        Me.page2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1010, 292)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Page 3"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1010, 292)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Page 4"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1010, 292)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Page 5"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1010, 292)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Page 6"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1010, 292)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Page 7"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1010, 292)
        Me.TabPage6.TabIndex = 7
        Me.TabPage6.Text = "Page 8"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.Location = New System.Drawing.Point(815, 327)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(100, 30)
        Me.saveButton.TabIndex = 1
        Me.saveButton.Text = "Add"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(921, 327)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(100, 30)
        Me.deleteButton.TabIndex = 1
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'birthsDataGridView
        '
        Me.birthsDataGridView.AllowUserToAddRows = False
        Me.birthsDataGridView.AllowUserToDeleteRows = False
        Me.birthsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.birthsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.birthsDataGridView.Location = New System.Drawing.Point(3, 365)
        Me.birthsDataGridView.Name = "birthsDataGridView"
        Me.birthsDataGridView.ReadOnly = True
        Me.birthsDataGridView.Size = New System.Drawing.Size(1018, 127)
        Me.birthsDataGridView.TabIndex = 2
        '
        'q204UcComboWithSpecify
        '
        Me.q204UcComboWithSpecify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q204UcComboWithSpecify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q204UcComboWithSpecify.Location = New System.Drawing.Point(11, 251)
        Me.q204UcComboWithSpecify.Name = "q204UcComboWithSpecify"
        Me.q204UcComboWithSpecify.Size = New System.Drawing.Size(993, 35)
        Me.q204UcComboWithSpecify.TabIndex = 6
        Me.q204UcComboWithSpecify.Tag = "49"
        '
        'q203UcKaisDatePicker
        '
        Me.q203UcKaisDatePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.q203UcKaisDatePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q203UcKaisDatePicker.Location = New System.Drawing.Point(11, 175)
        Me.q203UcKaisDatePicker.Name = "q203UcKaisDatePicker"
        Me.q203UcKaisDatePicker.Size = New System.Drawing.Size(993, 32)
        Me.q203UcKaisDatePicker.TabIndex = 5
        Me.q203UcKaisDatePicker.Tag = "48"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1004, 286)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 998
        Me.LineShape1.Y1 = 62
        Me.LineShape1.Y2 = 62
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Cursor = System.Windows.Forms.Cursors.Default
        Me.LineShape2.Name = "LineShape1"
        Me.LineShape2.X1 = 7
        Me.LineShape2.X2 = 995
        Me.LineShape2.Y1 = 139
        Me.LineShape2.Y2 = 139
        '
        'LineShape3
        '
        Me.LineShape3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LineShape3.Name = "LineShape1"
        Me.LineShape3.X1 = 7
        Me.LineShape3.X2 = 995
        Me.LineShape3.Y1 = 221
        Me.LineShape3.Y2 = 221
        '
        'UcBirths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.birthsDataGridView)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.birthsTabControl)
        Me.Name = "UcBirths"
        Me.Size = New System.Drawing.Size(1024, 495)
        Me.birthsTabControl.ResumeLayout(False)
        Me.page1.ResumeLayout(False)
        Me.page1.PerformLayout()
        CType(Me.birthsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents birthsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents page1 As System.Windows.Forms.TabPage
    Friend WithEvents page2 As System.Windows.Forms.TabPage
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents birthsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents initialsLabel As System.Windows.Forms.Label
    Friend WithEvents initialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents q202ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents q202Label As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents q203Label As System.Windows.Forms.Label
    Friend WithEvents q203UcKaisDatePicker As KaisII.UcKAISDobPicker
    Friend WithEvents q204Label As System.Windows.Forms.Label
    Friend WithEvents q204UcComboWithSpecify As KaisII.UcComboWithSpecify
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
