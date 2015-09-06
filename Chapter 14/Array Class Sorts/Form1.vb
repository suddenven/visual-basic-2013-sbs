Public Class Form1
    Dim RandArray(0 To 499) As Long

    'Initialize the Progress bar object and display num of elements
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = RandArray.GetUpperBound(0)
        BarMax.Text = RandArray.GetUpperBound(0) + 1
    End Sub

    'Fill the array with random numbers and display in text box
    Private Sub FillButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillButton.Click
        Dim i As Integer
        For i = 0 To RandArray.GetUpperBound(0)
            RandArray(i) = Int(Rnd() * 1000000)
            Results.Text = Results.Text & RandArray(i) & vbCrLf
            ProgressBar.Value = i  'move progress bar
        Next i
    End Sub

    'Sort the array using the Array.Sort method and display
    Private Sub SortButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortButton.Click
        Dim i As Integer
        Results.Text = ""
        Array.Sort(RandArray)
        For i = 0 To RandArray.GetUpperBound(0)
            Results.Text = Results.Text & RandArray(i) & vbCrLf
            ProgressBar.Value = i  'move progress bar
        Next i
    End Sub

    'Reverse the order of array elements using Array.Reverse
    Private Sub ReverseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseButton.Click
        Dim i As Integer
        Results.Text = ""
        Array.Reverse(RandArray)
        For i = 0 To RandArray.GetUpperBound(0)
            Results.Text = Results.Text & RandArray(i) & vbCrLf
            ProgressBar.Value = i  'move progress bar
        Next i
    End Sub
End Class
