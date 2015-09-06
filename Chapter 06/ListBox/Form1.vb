Public Class Form1

    Private Sub PhotosListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PhotosListBox.SelectedIndexChanged
        Select Case PhotosListBox.SelectedIndex
            Case 0
                PhotosPictureBox.Image = My.Resources.Fern
            Case 1
                PhotosPictureBox.Image = My.Resources.Squash
            Case 2
                PhotosPictureBox.Image = My.Resources.Swan
            Case 3
                PhotosPictureBox.Image = My.Resources.Thistle
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add items to a list box like this:
        PhotosListBox.Items.Add("Fern")
        PhotosListBox.Items.Add("Squash")
        PhotosListBox.Items.Add("Swan")
        PhotosListBox.Items.Add("Thistle")

    End Sub
End Class
