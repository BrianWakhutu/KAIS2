<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMultivalue
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
        Me.plnAnswer = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlOtherSpecify = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtOtherspecify = New System.Windows.Forms.TextBox()
        Me.lstOptions = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblQuestionText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plnAnswer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlOtherSpecify.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'plnAnswer
        '
        Me.plnAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plnAnswer.Controls.Add(Me.Panel2)
        Me.plnAnswer.Controls.Add(Me.Panel1)
        Me.plnAnswer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plnAnswer.Location = New System.Drawing.Point(0, 0)
        Me.plnAnswer.Name = "plnAnswer"
        Me.plnAnswer.Size = New System.Drawing.Size(579, 346)
        Me.plnAnswer.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlOtherSpecify)
        Me.Panel2.Controls.Add(Me.lstOptions)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 270)
        Me.Panel2.TabIndex = 1
        '
        'pnlOtherSpecify
        '
        Me.pnlOtherSpecify.Controls.Add(Me.Panel3)
        Me.pnlOtherSpecify.Controls.Add(Me.txtOtherspecify)
        Me.pnlOtherSpecify.Location = New System.Drawing.Point(77, 58)
        Me.pnlOtherSpecify.Name = "pnlOtherSpecify"
        Me.pnlOtherSpecify.Size = New System.Drawing.Size(380, 192)
        Me.pnlOtherSpecify.TabIndex = 1
        Me.pnlOtherSpecify.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdOK)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 27)
        Me.Panel3.TabIndex = 1
        '
        'cmdOK
        '
        Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(328, 4)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(49, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'txtOtherspecify
        '
        Me.txtOtherspecify.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOtherspecify.Location = New System.Drawing.Point(3, 3)
        Me.txtOtherspecify.Multiline = True
        Me.txtOtherspecify.Name = "txtOtherspecify"
        Me.txtOtherspecify.Size = New System.Drawing.Size(374, 156)
        Me.txtOtherspecify.TabIndex = 0
        '
        'lstOptions
        '
        Me.lstOptions.CheckBoxes = True
        Me.lstOptions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOptions.FullRowSelect = True
        Me.lstOptions.GridLines = True
        Me.lstOptions.Location = New System.Drawing.Point(0, 0)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(577, 270)
        Me.lstOptions.TabIndex = 0
        Me.lstOptions.UseCompatibleStateImageBehavior = False
        Me.lstOptions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Responses"
        Me.ColumnHeader1.Width = 332
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Other Specify"
        Me.ColumnHeader2.Width = 222
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblQuestionText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 74)
        Me.Panel1.TabIndex = 0
        '
        'lblQuestionText
        '
        Me.lblQuestionText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQuestionText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblQuestionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionText.Location = New System.Drawing.Point(0, 0)
        Me.lblQuestionText.Name = "lblQuestionText"
        Me.lblQuestionText.Size = New System.Drawing.Size(575, 72)
        Me.lblQuestionText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'ucMultivalue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.plnAnswer)
        Me.Name = "ucMultivalue"
        Me.Size = New System.Drawing.Size(579, 346)
        Me.plnAnswer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlOtherSpecify.ResumeLayout(False)
        Me.pnlOtherSpecify.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents plnAnswer As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lstOptions As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblQuestionText As System.Windows.Forms.Label
    Friend WithEvents pnlOtherSpecify As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents txtOtherspecify As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
