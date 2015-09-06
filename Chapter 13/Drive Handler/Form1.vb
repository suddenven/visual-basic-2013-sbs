
Public Class Form1
    Dim Retries As Short = 0

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Try
            If TestImage.Enabled = False Then Exit Try
            TestImage.Image = System.Drawing.Bitmap.FromFile("e:\road.jpg")
        Catch
            Retries += 1
            If Retries <= 2 Then
                MsgBox("Please insert the flash drive in drive E!")
            Else
                MsgBox("File Load feature disabled")
                CheckButton.Enabled = False
            End If
        End Try

    End Sub
End Class
