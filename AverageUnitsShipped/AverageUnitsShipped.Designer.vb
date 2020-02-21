<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnitsEntered = New System.Windows.Forms.TextBox()
        Me.txtEnteredValues = New System.Windows.Forms.RichTextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtDisplay = New System.Windows.Forms.RichTextBox()
        Me.ToolTipEnter = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipExit = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipValues = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipResult = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(321, 320)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTipExit.SetToolTip(Me.btnExit, "Adds entered units to units shipped list")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(109, 320)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 2
        Me.btnAccept.Text = "E&nter"
        Me.ToolTipEnter.SetToolTip(Me.btnAccept, "Exits the Application")
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(211, 320)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.ToolTipReset.SetToolTip(Me.btnReset, "Resets the Form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(119, 48)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitsEntered
        '
        Me.txtUnitsEntered.Location = New System.Drawing.Point(175, 45)
        Me.txtUnitsEntered.Name = "txtUnitsEntered"
        Me.txtUnitsEntered.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitsEntered.TabIndex = 1
        Me.ToolTipValues.SetToolTip(Me.txtUnitsEntered, "Enter the units to be added ")
        '
        'txtEnteredValues
        '
        Me.txtEnteredValues.DetectUrls = False
        Me.txtEnteredValues.Location = New System.Drawing.Point(109, 84)
        Me.txtEnteredValues.Name = "txtEnteredValues"
        Me.txtEnteredValues.ReadOnly = True
        Me.txtEnteredValues.Size = New System.Drawing.Size(287, 157)
        Me.txtEnteredValues.TabIndex = 6
        Me.txtEnteredValues.Text = ""
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(296, 48)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(38, 13)
        Me.lblDay.TabIndex = 5
        Me.lblDay.Text = "Day 1:"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(109, 260)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(287, 34)
        Me.txtDisplay.TabIndex = 7
        Me.txtDisplay.Text = ""
        Me.ToolTipResult.SetToolTip(Me.txtDisplay, "Displays the Average Units Shipped")
        '
        'ToolTipEnter
        '
        Me.ToolTipEnter.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipEnter.ToolTipTitle = "Enter Button"
        '
        'ToolTipExit
        '
        Me.ToolTipExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipExit.ToolTipTitle = "Exit Button"
        '
        'ToolTipReset
        '
        Me.ToolTipReset.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipReset.ToolTipTitle = "Reset Button"
        '
        'ToolTipValues
        '
        Me.ToolTipValues.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipValues.ToolTipTitle = "Units Textbox"
        '
        'ToolTipResult
        '
        Me.ToolTipResult.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipResult.ToolTipTitle = "Result Display Textbox"
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnAccept
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(515, 384)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtEnteredValues)
        Me.Controls.Add(Me.txtUnitsEntered)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnitsEntered As TextBox
    Friend WithEvents txtEnteredValues As RichTextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents txtDisplay As RichTextBox
    Friend WithEvents ToolTipEnter As ToolTip
    Friend WithEvents ToolTipExit As ToolTip
    Friend WithEvents ToolTipReset As ToolTip
    Friend WithEvents ToolTipValues As ToolTip
    Friend WithEvents ToolTipResult As ToolTip
End Class
