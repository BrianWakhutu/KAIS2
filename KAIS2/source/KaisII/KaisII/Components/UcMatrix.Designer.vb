<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMatrix
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
        Me.matrixTabControl = New System.Windows.Forms.TabControl()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.matrixDataGridView = New System.Windows.Forms.DataGridView()
        Me.matrixFieldTextBox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        CType(Me.matrixDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'matrixTabControl
        '
        Me.matrixTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.matrixTabControl.Location = New System.Drawing.Point(3, 94)
        Me.matrixTabControl.Name = "matrixTabControl"
        Me.matrixTabControl.SelectedIndex = 0
        Me.matrixTabControl.Size = New System.Drawing.Size(1008, 253)
        Me.matrixTabControl.TabIndex = 0
        '
        'addButton
        '
        Me.addButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.Location = New System.Drawing.Point(695, 353)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(100, 30)
        Me.addButton.TabIndex = 1
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeButton.Location = New System.Drawing.Point(801, 353)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(100, 30)
        Me.removeButton.TabIndex = 1
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'matrixDataGridView
        '
        Me.matrixDataGridView.AllowUserToAddRows = False
        Me.matrixDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.matrixDataGridView.Location = New System.Drawing.Point(3, 389)
        Me.matrixDataGridView.Name = "matrixDataGridView"
        Me.matrixDataGridView.ReadOnly = True
        Me.matrixDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.matrixDataGridView.Size = New System.Drawing.Size(1008, 95)
        Me.matrixDataGridView.TabIndex = 2
        '
        'matrixFieldTextBox
        '
        Me.matrixFieldTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.matrixFieldTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixFieldTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.matrixFieldTextBox.Location = New System.Drawing.Point(3, 3)
        Me.matrixFieldTextBox.Multiline = True
        Me.matrixFieldTextBox.Name = "matrixFieldTextBox"
        Me.matrixFieldTextBox.ReadOnly = True
        Me.matrixFieldTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.matrixFieldTextBox.Size = New System.Drawing.Size(1004, 85)
        Me.matrixFieldTextBox.TabIndex = 3
        Me.matrixFieldTextBox.TabStop = False
        '
        'clearButton
        '
        Me.clearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(907, 353)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(100, 30)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'UcMatrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.matrixFieldTextBox)
        Me.Controls.Add(Me.matrixDataGridView)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.matrixTabControl)
        Me.Name = "UcMatrix"
        Me.Size = New System.Drawing.Size(1014, 487)
        CType(Me.matrixDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents matrixTabControl As System.Windows.Forms.TabControl
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents matrixDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents matrixFieldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents clearButton As System.Windows.Forms.Button

End Class
