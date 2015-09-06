<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Results = New System.Windows.Forms.TextBox()
        Me.FillButton = New System.Windows.Forms.Button()
        Me.SortButton = New System.Windows.Forms.Button()
        Me.ReverseButton = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.BarMin = New System.Windows.Forms.Label()
        Me.BarMax = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Results
        '
        Me.Results.Location = New System.Drawing.Point(25, 14)
        Me.Results.Multiline = True
        Me.Results.Name = "Results"
        Me.Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Results.Size = New System.Drawing.Size(235, 192)
        Me.Results.TabIndex = 3
        '
        'FillButton
        '
        Me.FillButton.Location = New System.Drawing.Point(25, 222)
        Me.FillButton.Name = "FillButton"
        Me.FillButton.Size = New System.Drawing.Size(73, 23)
        Me.FillButton.TabIndex = 0
        Me.FillButton.Text = "Fill Array "
        '
        'SortButton
        '
        Me.SortButton.Location = New System.Drawing.Point(104, 222)
        Me.SortButton.Name = "SortButton"
        Me.SortButton.Size = New System.Drawing.Size(73, 23)
        Me.SortButton.TabIndex = 1
        Me.SortButton.Text = "Sort Array"
        '
        'ReverseButton
        '
        Me.ReverseButton.Location = New System.Drawing.Point(187, 222)
        Me.ReverseButton.Name = "ReverseButton"
        Me.ReverseButton.Size = New System.Drawing.Size(73, 23)
        Me.ReverseButton.TabIndex = 2
        Me.ReverseButton.Text = "Reverse"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(46, 252)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(179, 18)
        Me.ProgressBar.TabIndex = 4
        '
        'BarMin
        '
        Me.BarMin.AutoSize = True
        Me.BarMin.Location = New System.Drawing.Point(27, 254)
        Me.BarMin.Name = "BarMin"
        Me.BarMin.Size = New System.Drawing.Size(13, 13)
        Me.BarMin.TabIndex = 5
        Me.BarMin.Text = "0"
        '
        'BarMax
        '
        Me.BarMax.AutoSize = True
        Me.BarMax.Location = New System.Drawing.Point(231, 254)
        Me.BarMax.Name = "BarMax"
        Me.BarMax.Size = New System.Drawing.Size(13, 13)
        Me.BarMax.TabIndex = 6
        Me.BarMax.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 282)
        Me.Controls.Add(Me.BarMax)
        Me.Controls.Add(Me.BarMin)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.ReverseButton)
        Me.Controls.Add(Me.SortButton)
        Me.Controls.Add(Me.FillButton)
        Me.Controls.Add(Me.Results)
        Me.Name = "Form1"
        Me.Text = "Array Class Sorts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Results As System.Windows.Forms.TextBox
    Friend WithEvents FillButton As System.Windows.Forms.Button
    Friend WithEvents SortButton As System.Windows.Forms.Button
    Friend WithEvents ReverseButton As System.Windows.Forms.Button
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents BarMin As System.Windows.Forms.Label
    Friend WithEvents BarMax As System.Windows.Forms.Label

End Class
