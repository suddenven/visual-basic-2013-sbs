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
        Me.PhotosListBox = New System.Windows.Forms.ListBox()
        Me.PhotosPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PhotosPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PhotosListBox
        '
        Me.PhotosListBox.FormattingEnabled = True
        Me.PhotosListBox.Location = New System.Drawing.Point(34, 21)
        Me.PhotosListBox.Name = "PhotosListBox"
        Me.PhotosListBox.Size = New System.Drawing.Size(254, 108)
        Me.PhotosListBox.TabIndex = 0
        '
        'PhotosPictureBox
        '
        Me.PhotosPictureBox.Location = New System.Drawing.Point(34, 151)
        Me.PhotosPictureBox.Name = "PhotosPictureBox"
        Me.PhotosPictureBox.Size = New System.Drawing.Size(439, 277)
        Me.PhotosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotosPictureBox.TabIndex = 1
        Me.PhotosPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 444)
        Me.Controls.Add(Me.PhotosPictureBox)
        Me.Controls.Add(Me.PhotosListBox)
        Me.Name = "Form1"
        Me.Text = "List Box Sample"
        CType(Me.PhotosPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PhotosListBox As System.Windows.Forms.ListBox
    Friend WithEvents PhotosPictureBox As System.Windows.Forms.PictureBox

End Class
