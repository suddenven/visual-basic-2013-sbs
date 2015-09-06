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
        Me.DisplayImageCheckBox = New System.Windows.Forms.CheckBox()
        Me.BirdPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.BirdPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DisplayImageCheckBox
        '
        Me.DisplayImageCheckBox.AutoSize = True
        Me.DisplayImageCheckBox.Checked = True
        Me.DisplayImageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DisplayImageCheckBox.Location = New System.Drawing.Point(22, 363)
        Me.DisplayImageCheckBox.Name = "DisplayImageCheckBox"
        Me.DisplayImageCheckBox.Size = New System.Drawing.Size(113, 17)
        Me.DisplayImageCheckBox.TabIndex = 0
        Me.DisplayImageCheckBox.Text = "Display Bird Image"
        Me.DisplayImageCheckBox.UseVisualStyleBackColor = True
        '
        'BirdPhoto
        '
        Me.BirdPhoto.Image = Global.CheckBox.My.Resources.Resources.Swan
        Me.BirdPhoto.Location = New System.Drawing.Point(12, 12)
        Me.BirdPhoto.Name = "BirdPhoto"
        Me.BirdPhoto.Size = New System.Drawing.Size(564, 345)
        Me.BirdPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BirdPhoto.TabIndex = 1
        Me.BirdPhoto.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 392)
        Me.Controls.Add(Me.BirdPhoto)
        Me.Controls.Add(Me.DisplayImageCheckBox)
        Me.Name = "Form1"
        Me.Text = "Check Box Sample"
        CType(Me.BirdPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DisplayImageCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BirdPhoto As System.Windows.Forms.PictureBox

End Class
