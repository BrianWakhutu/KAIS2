<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSingleDomain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlOtherSpecify = New System.Windows.Forms.Panel()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtOtherSpecify = New System.Windows.Forms.TextBox()
        Me.cmbAnsValues = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtQuestionText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlOtherSpecify.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnlOtherSpecify)
        Me.Panel1.Controls.Add(Me.cmbAnsValues)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 346)
        Me.Panel1.TabIndex = 0
        '
        'pnlOtherSpecify
        '
        Me.pnlOtherSpecify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOtherSpecify.Controls.Add(Me.cmdOK)
        Me.pnlOtherSpecify.Controls.Add(Me.txtOtherSpecify)
        Me.pnlOtherSpecify.Location = New System.Drawing.Point(0, 158)
        Me.pnlOtherSpecify.Name = "pnlOtherSpecify"
        Me.pnlOtherSpecify.Size = New System.Drawing.Size(402, 121)
        Me.pnlOtherSpecify.TabIndex = 3
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Location = New System.Drawing.Point(325, 95)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'txtOtherSpecify
        '
        Me.txtOtherSpecify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOtherSpecify.Location = New System.Drawing.Point(3, 5)
        Me.txtOtherSpecify.Multiline = True
        Me.txtOtherSpecify.Name = "txtOtherSpecify"
        Me.txtOtherSpecify.Size = New System.Drawing.Size(396, 86)
        Me.txtOtherSpecify.TabIndex = 0
        '
        'cmbAnsValues
        '
        Me.cmbAnsValues.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbAnsValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnsValues.FormattingEnabled = True
        Me.cmbAnsValues.Location = New System.Drawing.Point(0, 125)
        Me.cmbAnsValues.Name = "cmbAnsValues"
        Me.cmbAnsValues.Size = New System.Drawing.Size(402, 33)
        Me.cmbAnsValues.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lblSelect)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(402, 41)
        Me.Panel3.TabIndex = 1
        '
        'lblSelect
        '
        Me.lblSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.Color.Blue
        Me.lblSelect.Location = New System.Drawing.Point(0, 0)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(402, 41)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtQuestionText)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 84)
        Me.Panel2.TabIndex = 0
        '
        'TxtQuestionText
        '
        Me.TxtQuestionText.BackColor = System.Drawing.SystemColors.Control
        Me.TxtQuestionText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtQuestionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQuestionText.ForeColor = System.Drawing.Color.Blue
        Me.TxtQuestionText.Location = New System.Drawing.Point(0, 0)
        Me.TxtQuestionText.Name = "TxtQuestionText"
        Me.TxtQuestionText.Size = New System.Drawing.Size(400, 82)
        Me.TxtQuestionText.TabIndex = 0
        Me.TxtQuestionText.Text = "Question Text"
        Me.TxtQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Visible = False
        '
        'ucSingleDomain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ucSingleDomain"
        Me.Size = New System.Drawing.Size(404, 346)
        Me.Panel1.ResumeLayout(False)
        Me.pnlOtherSpecify.ResumeLayout(False)
        Me.pnlOtherSpecify.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbAnsValues As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtQuestionText As System.Windows.Forms.Label
    Friend WithEvents pnlOtherSpecify As System.Windows.Forms.Panel
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents txtOtherSpecify As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
