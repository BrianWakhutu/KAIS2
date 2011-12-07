<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcOtheredComboBox
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
        Me.vLookupComboBox = New System.Windows.Forms.ComboBox()
        Me.vSpecifyLabel = New System.Windows.Forms.Label()
        Me.vSpecifyTextBox = New System.Windows.Forms.TextBox()
        Me.vLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'vLookupComboBox
        '
        Me.vLookupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vLookupComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLookupComboBox.FormattingEnabled = True
        Me.vLookupComboBox.Location = New System.Drawing.Point(7, 32)
        Me.vLookupComboBox.Name = "vLookupComboBox"
        Me.vLookupComboBox.Size = New System.Drawing.Size(347, 28)
        Me.vLookupComboBox.TabIndex = 1
        '
        'vSpecifyLabel
        '
        Me.vSpecifyLabel.AutoSize = True
        Me.vSpecifyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSpecifyLabel.Location = New System.Drawing.Point(360, 35)
        Me.vSpecifyLabel.Name = "vSpecifyLabel"
        Me.vSpecifyLabel.Size = New System.Drawing.Size(68, 20)
        Me.vSpecifyLabel.TabIndex = 2
        Me.vSpecifyLabel.Text = "Specify"
        '
        'vSpecifyTextBox
        '
        Me.vSpecifyTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vSpecifyTextBox.Enabled = False
        Me.vSpecifyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSpecifyTextBox.Location = New System.Drawing.Point(427, 34)
        Me.vSpecifyTextBox.Name = "vSpecifyTextBox"
        Me.vSpecifyTextBox.Size = New System.Drawing.Size(442, 26)
        Me.vSpecifyTextBox.TabIndex = 3
        '
        'vLabel
        '
        Me.vLabel.AutoSize = True
        Me.vLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabel.Location = New System.Drawing.Point(3, 9)
        Me.vLabel.Name = "vLabel"
        Me.vLabel.Size = New System.Drawing.Size(112, 20)
        Me.vLabel.TabIndex = 0
        Me.vLabel.Text = "LookupLabel"
        '
        'UcOtheredComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.vLabel)
        Me.Controls.Add(Me.vSpecifyTextBox)
        Me.Controls.Add(Me.vSpecifyLabel)
        Me.Controls.Add(Me.vLookupComboBox)
        Me.Name = "UcOtheredComboBox"
        Me.Size = New System.Drawing.Size(872, 70)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vLookupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents vSpecifyLabel As System.Windows.Forms.Label
    Friend WithEvents vSpecifyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vLabel As System.Windows.Forms.Label

End Class
