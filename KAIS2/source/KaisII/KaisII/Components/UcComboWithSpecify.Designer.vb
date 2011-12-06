<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcComboWithSpecify
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
        Me.SuspendLayout()
        '
        'vLookupComboBox
        '
        Me.vLookupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vLookupComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLookupComboBox.FormattingEnabled = True
        Me.vLookupComboBox.Location = New System.Drawing.Point(0, 3)
        Me.vLookupComboBox.Name = "vLookupComboBox"
        Me.vLookupComboBox.Size = New System.Drawing.Size(347, 28)
        Me.vLookupComboBox.TabIndex = 0
        '
        'vSpecifyLabel
        '
        Me.vSpecifyLabel.AutoSize = True
        Me.vSpecifyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSpecifyLabel.Location = New System.Drawing.Point(353, 7)
        Me.vSpecifyLabel.Name = "vSpecifyLabel"
        Me.vSpecifyLabel.Size = New System.Drawing.Size(68, 20)
        Me.vSpecifyLabel.TabIndex = 1
        Me.vSpecifyLabel.Text = "Specify"
        '
        'vSpecifyTextBox
        '
        Me.vSpecifyTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vSpecifyTextBox.Enabled = False
        Me.vSpecifyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vSpecifyTextBox.Location = New System.Drawing.Point(427, 4)
        Me.vSpecifyTextBox.Name = "vSpecifyTextBox"
        Me.vSpecifyTextBox.Size = New System.Drawing.Size(401, 26)
        Me.vSpecifyTextBox.TabIndex = 2
        '
        'UcComboWithSpecify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.vSpecifyTextBox)
        Me.Controls.Add(Me.vSpecifyLabel)
        Me.Controls.Add(Me.vLookupComboBox)
        Me.Name = "UcComboWithSpecify"
        Me.Size = New System.Drawing.Size(831, 33)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vLookupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents vSpecifyLabel As System.Windows.Forms.Label
    Friend WithEvents vSpecifyTextBox As System.Windows.Forms.TextBox

End Class
