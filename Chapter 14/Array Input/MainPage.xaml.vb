' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim Temperatures(0 To 6) As Single
    Dim count As Short = 0

    Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs) Handles AddButton.Click
        Temperatures(count) = TempInput.Text
        Directions.Text = "Enter " & _
            Temperatures.GetUpperBound(0) - count & " more temperatures"
        If count = Temperatures.GetUpperBound(0) Then
            AddButton.IsEnabled = False
        Else
            count = count + 1
        End If
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As RoutedEventArgs) Handles DisplayButton.Click
        Dim i As Short
        TempOutput.Text = ""
        For i = 0 To Temperatures.GetUpperBound(0)
            TempOutput.Text &= Temperatures(i) & vbCrLf
        Next
    End Sub
End Class
