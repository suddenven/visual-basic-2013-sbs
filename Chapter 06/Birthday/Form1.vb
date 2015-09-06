Public Class Form1

    Private Sub DateButton_Click(sender As Object, e As EventArgs) Handles DateButton.Click
        MsgBox("Your birth date was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " & DateTimePicker1.Value.DayOfYear.ToString())

    End Sub
End Class
