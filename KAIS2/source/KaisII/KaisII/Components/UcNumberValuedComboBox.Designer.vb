﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcNumberValuedComboBox
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
        Me.vValueLabel = New System.Windows.Forms.Label()
        Me.vLookupComboBox = New System.Windows.Forms.ComboBox()
        Me.vValueNumericUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.vValueNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vLabel
        '
        Me.vLabel.AutoSize = True
        Me.vLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLabel.Location = New System.Drawing.Point(-1, 9)
        Me.vLabel.Name = "vLabel"
        Me.vLabel.Size = New System.Drawing.Size(112, 20)
        Me.vLabel.TabIndex = 4
        Me.vLabel.Text = "LookupLabel"
        '
        'vValueLabel
        '
        Me.vValueLabel.AutoSize = True
        Me.vValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vValueLabel.Location = New System.Drawing.Point(362, 37)
        Me.vValueLabel.Name = "vValueLabel"
        Me.vValueLabel.Size = New System.Drawing.Size(55, 20)
        Me.vValueLabel.TabIndex = 6
        Me.vValueLabel.Text = "Value"
        '
        'vLookupComboBox
        '
        Me.vLookupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vLookupComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vLookupComboBox.FormattingEnabled = True
        Me.vLookupComboBox.Location = New System.Drawing.Point(0, 32)
        Me.vLookupComboBox.Name = "vLookupComboBox"
        Me.vLookupComboBox.Size = New System.Drawing.Size(347, 28)
        Me.vLookupComboBox.TabIndex = 5
        '
        'vValueNumericUpDown
        '
        Me.vValueNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vValueNumericUpDown.Location = New System.Drawing.Point(423, 32)
        Me.vValueNumericUpDown.Name = "vValueNumericUpDown"
        Me.vValueNumericUpDown.Size = New System.Drawing.Size(195, 26)
        Me.vValueNumericUpDown.TabIndex = 8
        '
        'UcNumberValuedComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.vValueNumericUpDown)
        Me.Controls.Add(Me.vLabel)
        Me.Controls.Add(Me.vValueLabel)
        Me.Controls.Add(Me.vLookupComboBox)
        Me.Name = "UcNumberValuedComboBox"
        Me.Size = New System.Drawing.Size(866, 84)
        CType(Me.vValueNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vLabel As System.Windows.Forms.Label
    Friend WithEvents vValueLabel As System.Windows.Forms.Label
    Friend WithEvents vLookupComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents vValueNumericUpDown As System.Windows.Forms.NumericUpDown

End Class
