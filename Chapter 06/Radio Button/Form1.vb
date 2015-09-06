Public Class Form1

    Private Sub FernButton_CheckedChanged(sender As Object, e As EventArgs) Handles FernButton.CheckedChanged
        If (FernButton.Checked) Then PlantPictureBox.Image = My.Resources.Fern

    End Sub

    Private Sub SquashButton_CheckedChanged(sender As Object, e As EventArgs) Handles SquashButton.CheckedChanged
        If (SquashButton.Checked) Then PlantPictureBox.Image = My.Resources.Squash

    End Sub

    Private Sub ThistleButton_CheckedChanged(sender As Object, e As EventArgs) Handles ThistleButton.CheckedChanged
        If (ThistleButton.Checked) Then PlantPictureBox.Image = My.Resources.Thistle

    End Sub
End Class
