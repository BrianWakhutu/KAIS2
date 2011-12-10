<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcKaisTextBox
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
        Me.vTextBox = New System.Windows.Forms.TextBox()
        Me.vLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'vTextBox
        '
        Me.vTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vTextBox.Location = New System.Drawing.Point(3, 30)
        Me.vTextBox.Name = "vTextBox"
        Me.vTextBox.Size = New System.Drawing.Size(711, 26)
        Me.vTextBox.TabIndex = 3
        Me.vTextBox.Tag = "38"
        '
        'vLabel
        '
        Me.vLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vLabel.AutoSize = True
        Me.vLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabel.Location = New System.Drawing.Point(-1, 7)
        Me.vLabel.Name = "vLabel"
        Me.vLabel.Size = New System.Drawing.Size(87, 20)
        Me.vLabel.TabIndex = 2
        Me.vLabel.Tag = "38"
        Me.vLabel.Text = "TextLabel"
        '
        'UcKaisTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.vTextBox)
        Me.Controls.Add(Me.vLabel)
        Me.Name = "UcKaisTextBox"
        Me.Size = New System.Drawing.Size(717, 66)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vLabel As System.Windows.Forms.Label

End Class
