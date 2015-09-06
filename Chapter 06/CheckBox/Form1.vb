Public Class Form1

    Private Sub DisplayImageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DisplayImageCheckBox.CheckedChanged
        If DisplayImageCheckBox.CheckState = CheckState.Checked Then
            BirdPhoto.Visible = True
        Else
            BirdPhoto.Visible = False
        End If
    End Sub
End Class
