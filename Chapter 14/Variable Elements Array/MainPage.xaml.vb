' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim Temperatures() As Single
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

    Private Sub CreateArrayButton_Click(sender As Object, e As RoutedEventArgs) Handles CreateArrayButton.Click
        Dim days As Short = 0
        days = ArrayElements.Text
        If days > 0 Then ReDim Temperatures(days - 1)
        count = 0
        TempOutput.Text = ""
        Directions.Text = "Enter " & days & " temperatures (one at a time)"
        TempInput.Focus(Windows.UI.Xaml.FocusState.Programmatic)
        AddButton.IsEnabled = True
        DisplayButton.IsEnabled = True
    End Sub
End Class
