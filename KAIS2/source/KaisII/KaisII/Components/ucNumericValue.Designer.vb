<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNumericValue
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboValues = New System.Windows.Forms.ComboBox()
        Me.txtNumeric = New System.Windows.Forms.NumericUpDown()
        Me.chkDontKnow = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.txtNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 93)
        Me.Panel1.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Location = New System.Drawing.Point(0, 0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(534, 91)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Label1"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Value"
        '
        'cboValues
        '
        Me.cboValues.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cboValues.Enabled = False
        Me.cboValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboValues.FormattingEnabled = True
        Me.cboValues.Location = New System.Drawing.Point(185, 134)
        Me.cboValues.Name = "cboValues"
        Me.cboValues.Size = New System.Drawing.Size(348, 33)
        Me.cboValues.TabIndex = 3
        '
        'txtNumeric
        '
        Me.txtNumeric.Location = New System.Drawing.Point(185, 212)
        Me.txtNumeric.Name = "txtNumeric"
        Me.txtNumeric.Size = New System.Drawing.Size(348, 26)
        Me.txtNumeric.TabIndex = 4
        '
        'chkDontKnow
        '
        Me.chkDontKnow.AutoSize = True
        Me.chkDontKnow.Location = New System.Drawing.Point(185, 260)
        Me.chkDontKnow.Name = "chkDontKnow"
        Me.chkDontKnow.Size = New System.Drawing.Size(119, 24)
        Me.chkDontKnow.TabIndex = 5
        Me.chkDontKnow.Text = "Don't Know"
        Me.chkDontKnow.UseVisualStyleBackColor = True
        '
        'ucNumericValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.chkDontKnow)
        Me.Controls.Add(Me.txtNumeric)
        Me.Controls.Add(Me.cboValues)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ucNumericValue"
        Me.Size = New System.Drawing.Size(536, 371)
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboValues As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDontKnow As System.Windows.Forms.CheckBox

End Class
