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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.TestImage = New System.Windows.Forms.PictureBox()
        CType(Me.TestImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(867, 249)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This error handler checks E:\ for the image Road.jpg. If the file does not exist " & _
    "or if the drive is unready, a run-time error occurs. Click Check Drive when read" & _
    "y."
        '
        'CheckButton
        '
        Me.CheckButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckButton.Location = New System.Drawing.Point(38, 395)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(197, 82)
        Me.CheckButton.TabIndex = 1
        Me.CheckButton.Text = "Check Drive"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'TestImage
        '
        Me.TestImage.Location = New System.Drawing.Point(289, 270)
        Me.TestImage.Name = "TestImage"
        Me.TestImage.Size = New System.Drawing.Size(575, 399)
        Me.TestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TestImage.TabIndex = 2
        Me.TestImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 694)
        Me.Controls.Add(Me.TestImage)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Drive Handler"
        CType(Me.TestImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckButton As System.Windows.Forms.Button
    Friend WithEvents TestImage As System.Windows.Forms.PictureBox

End Class
