Public Class Form1

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        ClockOutput.Text = TimeString

    End Sub

    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        ClockOutput.Text = DateString

    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.Filter = "JPEG (*.jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenImage.Image = System.Drawing.Image.FromFile _
                (OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ColorDialog1.ShowDialog()
        ClockOutput.ForeColor = ColorDialog1.Color

    End Sub
End Class
