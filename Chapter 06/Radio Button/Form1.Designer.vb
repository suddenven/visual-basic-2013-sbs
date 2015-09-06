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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FernButton = New System.Windows.Forms.RadioButton()
        Me.SquashButton = New System.Windows.Forms.RadioButton()
        Me.ThistleButton = New System.Windows.Forms.RadioButton()
        Me.PlantPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PlantPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ThistleButton)
        Me.GroupBox1.Controls.Add(Me.SquashButton)
        Me.GroupBox1.Controls.Add(Me.FernButton)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an Image Type"
        '
        'FernButton
        '
        Me.FernButton.AutoSize = True
        Me.FernButton.Checked = True
        Me.FernButton.Location = New System.Drawing.Point(20, 19)
        Me.FernButton.Name = "FernButton"
        Me.FernButton.Size = New System.Drawing.Size(46, 17)
        Me.FernButton.TabIndex = 0
        Me.FernButton.TabStop = True
        Me.FernButton.Text = "Fern"
        Me.FernButton.UseVisualStyleBackColor = True
        '
        'SquashButton
        '
        Me.SquashButton.AutoSize = True
        Me.SquashButton.Location = New System.Drawing.Point(20, 42)
        Me.SquashButton.Name = "SquashButton"
        Me.SquashButton.Size = New System.Drawing.Size(61, 17)
        Me.SquashButton.TabIndex = 1
        Me.SquashButton.Text = "Squash"
        Me.SquashButton.UseVisualStyleBackColor = True
        '
        'ThistleButton
        '
        Me.ThistleButton.AutoSize = True
        Me.ThistleButton.Location = New System.Drawing.Point(20, 65)
        Me.ThistleButton.Name = "ThistleButton"
        Me.ThistleButton.Size = New System.Drawing.Size(56, 17)
        Me.ThistleButton.TabIndex = 2
        Me.ThistleButton.Text = "Thistle"
        Me.ThistleButton.UseVisualStyleBackColor = True
        '
        'PlantPictureBox
        '
        Me.PlantPictureBox.Image = Global.Radio_Button.My.Resources.Resources.Fern
        Me.PlantPictureBox.Location = New System.Drawing.Point(36, 150)
        Me.PlantPictureBox.Name = "PlantPictureBox"
        Me.PlantPictureBox.Size = New System.Drawing.Size(221, 186)
        Me.PlantPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlantPictureBox.TabIndex = 1
        Me.PlantPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 372)
        Me.Controls.Add(Me.PlantPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Radio Button Sample"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PlantPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ThistleButton As System.Windows.Forms.RadioButton
    Friend WithEvents SquashButton As System.Windows.Forms.RadioButton
    Friend WithEvents FernButton As System.Windows.Forms.RadioButton
    Friend WithEvents PlantPictureBox As System.Windows.Forms.PictureBox

End Class
