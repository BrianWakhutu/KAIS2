<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcLookupComboBox
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
        Me.vLabel = New System.Windows.Forms.Label()
        Me.vLookupComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'vLabel
        '
        Me.vLabel.AutoSize = True
        Me.vLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabel.Location = New System.Drawing.Point(3, 10)
        Me.vLabel.Name = "vLabel"
        Me.vLabel.Size = New System.Drawing.Size(112, 20)
        Me.vLabel.TabIndex = 2
        Me.vLabel.Text = "LookupLabel"
        '
        'vLookupComboBox
        '
        Me.vLookupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vLookupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vLookupComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLookupComboBox.FormattingEnabled = True
        Me.vLookupComboBox.Location = New System.Drawing.Point(3, 33)
        Me.vLookupComboBox.Name = "vLookupComboBox"
        Me.vLookupComboBox.Size = New System.Drawing.Size(579, 28)
        Me.vLookupComboBox.TabIndex = 3
        '
        'UcLookupComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.vLabel)
        Me.Controls.Add(Me.vLookupComboBox)
        Me.Name = "UcLookupComboBox"
        Me.Size = New System.Drawing.Size(585, 72)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vLabel As System.Windows.Forms.Label
    Friend WithEvents vLookupComboBox As System.Windows.Forms.ComboBox

End Class
