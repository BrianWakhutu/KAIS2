<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcKAISDobPicker
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
        Me.vDayNUD = New System.Windows.Forms.NumericUpDown()
        Me.vMonthNUD = New System.Windows.Forms.NumericUpDown()
        Me.vYearNUD = New System.Windows.Forms.NumericUpDown()
        Me.vDayLabel = New System.Windows.Forms.Label()
        Me.vMonthLabel = New System.Windows.Forms.Label()
        Me.vYearLabel = New System.Windows.Forms.Label()
        CType(Me.vDayNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vMonthNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vYearNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vDayNUD
        '
        Me.vDayNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vDayNUD.Location = New System.Drawing.Point(49, 3)
        Me.vDayNUD.Maximum = New Decimal(New Integer() {888, 0, 0, 0})
        Me.vDayNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vDayNUD.Name = "vDayNUD"
        Me.vDayNUD.Size = New System.Drawing.Size(59, 26)
        Me.vDayNUD.TabIndex = 0
        Me.vDayNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'vMonthNUD
        '
        Me.vMonthNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMonthNUD.Location = New System.Drawing.Point(179, 3)
        Me.vMonthNUD.Maximum = New Decimal(New Integer() {888, 0, 0, 0})
        Me.vMonthNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vMonthNUD.Name = "vMonthNUD"
        Me.vMonthNUD.Size = New System.Drawing.Size(59, 26)
        Me.vMonthNUD.TabIndex = 0
        Me.vMonthNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'vYearNUD
        '
        Me.vYearNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vYearNUD.Location = New System.Drawing.Point(297, 3)
        Me.vYearNUD.Maximum = New Decimal(New Integer() {888, 0, 0, 0})
        Me.vYearNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vYearNUD.Name = "vYearNUD"
        Me.vYearNUD.Size = New System.Drawing.Size(59, 26)
        Me.vYearNUD.TabIndex = 0
        Me.vYearNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'vDayLabel
        '
        Me.vDayLabel.AutoSize = True
        Me.vDayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vDayLabel.Location = New System.Drawing.Point(3, 5)
        Me.vDayLabel.Name = "vDayLabel"
        Me.vDayLabel.Size = New System.Drawing.Size(40, 20)
        Me.vDayLabel.TabIndex = 1
        Me.vDayLabel.Text = "Day"
        '
        'vMonthLabel
        '
        Me.vMonthLabel.AutoSize = True
        Me.vMonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vMonthLabel.Location = New System.Drawing.Point(114, 5)
        Me.vMonthLabel.Name = "vMonthLabel"
        Me.vMonthLabel.Size = New System.Drawing.Size(59, 20)
        Me.vMonthLabel.TabIndex = 1
        Me.vMonthLabel.Text = "Month"
        '
        'vYearLabel
        '
        Me.vYearLabel.AutoSize = True
        Me.vYearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vYearLabel.Location = New System.Drawing.Point(244, 5)
        Me.vYearLabel.Name = "vYearLabel"
        Me.vYearLabel.Size = New System.Drawing.Size(47, 20)
        Me.vYearLabel.TabIndex = 1
        Me.vYearLabel.Text = "Year"
        '
        'UcKAISDatePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.vYearLabel)
        Me.Controls.Add(Me.vMonthLabel)
        Me.Controls.Add(Me.vDayLabel)
        Me.Controls.Add(Me.vYearNUD)
        Me.Controls.Add(Me.vMonthNUD)
        Me.Controls.Add(Me.vDayNUD)
        Me.Name = "UcKAISDatePicker"
        Me.Size = New System.Drawing.Size(357, 30)
        CType(Me.vDayNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vMonthNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vYearNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vDayNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents vMonthNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents vYearNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents vDayLabel As System.Windows.Forms.Label
    Friend WithEvents vMonthLabel As System.Windows.Forms.Label
    Friend WithEvents vYearLabel As System.Windows.Forms.Label

End Class
