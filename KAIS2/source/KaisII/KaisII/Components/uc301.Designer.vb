<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc301
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.lvLogoTypes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboLogoType = New System.Windows.Forms.ComboBox()
        Me.cboTakenPart = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdremove = New System.Windows.Forms.Button()
        Me.cmdADD = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 82)
        Me.Panel1.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(462, 80)
        Me.lblText.TabIndex = 0
        '
        'lvLogoTypes
        '
        Me.lvLogoTypes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvLogoTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvLogoTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvLogoTypes.FullRowSelect = True
        Me.lvLogoTypes.GridLines = True
        Me.lvLogoTypes.Location = New System.Drawing.Point(3, 226)
        Me.lvLogoTypes.Name = "lvLogoTypes"
        Me.lvLogoTypes.Size = New System.Drawing.Size(458, 174)
        Me.lvLogoTypes.TabIndex = 1
        Me.lvLogoTypes.UseCompatibleStateImageBehavior = False
        Me.lvLogoTypes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Logo Type"
        Me.ColumnHeader1.Width = 209
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Taken Part"
        Me.ColumnHeader2.Width = 232
        '
        'cboLogoType
        '
        Me.cboLogoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLogoType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLogoType.FormattingEnabled = True
        Me.cboLogoType.Location = New System.Drawing.Point(90, 112)
        Me.cboLogoType.Name = "cboLogoType"
        Me.cboLogoType.Size = New System.Drawing.Size(367, 24)
        Me.cboLogoType.TabIndex = 2
        '
        'cboTakenPart
        '
        Me.cboTakenPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTakenPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTakenPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTakenPart.FormattingEnabled = True
        Me.cboTakenPart.Location = New System.Drawing.Point(95, 154)
        Me.cboTakenPart.Name = "cboTakenPart"
        Me.cboTakenPart.Size = New System.Drawing.Size(246, 24)
        Me.cboTakenPart.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Logo Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Taken Part?"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmdremove)
        Me.Panel2.Controls.Add(Me.cmdADD)
        Me.Panel2.Location = New System.Drawing.Point(3, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(458, 44)
        Me.Panel2.TabIndex = 5
        '
        'cmdremove
        '
        Me.cmdremove.Location = New System.Drawing.Point(283, 16)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(75, 23)
        Me.cmdremove.TabIndex = 1
        Me.cmdremove.Text = "Remove"
        Me.cmdremove.UseVisualStyleBackColor = True
        '
        'cmdADD
        '
        Me.cmdADD.Location = New System.Drawing.Point(378, 16)
        Me.cmdADD.Name = "cmdADD"
        Me.cmdADD.Size = New System.Drawing.Size(75, 23)
        Me.cmdADD.TabIndex = 0
        Me.cmdADD.Text = "Add"
        Me.cmdADD.UseVisualStyleBackColor = True
        '
        'uc301
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTakenPart)
        Me.Controls.Add(Me.cboLogoType)
        Me.Controls.Add(Me.lvLogoTypes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "uc301"
        Me.Size = New System.Drawing.Size(464, 403)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lvLogoTypes As System.Windows.Forms.ListView
    Friend WithEvents cboLogoType As System.Windows.Forms.ComboBox
    Friend WithEvents cboTakenPart As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdremove As System.Windows.Forms.Button
    Friend WithEvents cmdADD As System.Windows.Forms.Button

End Class
