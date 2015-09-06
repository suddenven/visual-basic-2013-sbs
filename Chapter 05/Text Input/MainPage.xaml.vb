' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub TestButton_Click(sender As Object, e As RoutedEventArgs) Handles TestButton.Click
        Dim sampleText As String
        sampleText = InputString.Text
        If sampleText.Contains("River") Then
            Output.Text = "The string 'River' was found"
        Else
            Output.Text = "The string 'River' was not found"
        End If
    End Sub
End Class
