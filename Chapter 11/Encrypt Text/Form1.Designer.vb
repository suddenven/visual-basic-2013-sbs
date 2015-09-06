<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDateItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.NoteLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenItem, Me.CloseItem, Me.SaveAsItem, Me.InsertDateItem, Me.ExitItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenItem
        '
        Me.OpenItem.Name = "OpenItem"
        Me.OpenItem.Size = New System.Drawing.Size(200, 22)
        Me.OpenItem.Text = "Open encrypted File..."
        '
        'CloseItem
        '
        Me.CloseItem.Enabled = false
        Me.CloseItem.Name = "CloseItem"
        Me.CloseItem.Size = New System.Drawing.Size(200, 22)
        Me.CloseItem.Text = "Close"
        '
        'SaveAsItem
        '
        Me.SaveAsItem.Name = "SaveAsItem"
        Me.SaveAsItem.Size = New System.Drawing.Size(200, 22)
        Me.SaveAsItem.Text = "Save encrypted File As..."
        '
        'InsertDateItem
        '
        Me.InsertDateItem.Name = "InsertDateItem"
        Me.InsertDateItem.Size = New System.Drawing.Size(200, 22)
        Me.InsertDateItem.Text = "Insert Date"
        '
        'ExitItem
        '
        Me.ExitItem.Name = "ExitItem"
        Me.ExitItem.Size = New System.Drawing.Size(200, 22)
        Me.ExitItem.Text = "Exit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Location = New System.Drawing.Point(24, 61)
        Me.NoteTextBox.Multiline = true
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(319, 225)
        Me.NoteTextBox.TabIndex = 1
        '
        'NoteLabel
        '
        Me.NoteLabel.AutoSize = true
        Me.NoteLabel.Location = New System.Drawing.Point(21, 33)
        Me.NoteLabel.Name = "NoteLabel"
        Me.NoteLabel.Size = New System.Drawing.Size(253, 13)
        Me.NoteLabel.TabIndex = 2
        Me.NoteLabel.Text = "Type some text and then use encryption commands."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 321)
        Me.Controls.Add(Me.NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Encrypt Text"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertDateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteLabel As System.Windows.Forms.Label
    Friend WithEvents OpenItem As System.Windows.Forms.ToolStripMenuItem

End Class
