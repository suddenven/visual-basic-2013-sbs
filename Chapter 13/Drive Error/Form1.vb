Public Class Form1

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        TestImage.Image = System.Drawing.Bitmap.FromFile("e:\road.jpg")

    End Sub
End Class
