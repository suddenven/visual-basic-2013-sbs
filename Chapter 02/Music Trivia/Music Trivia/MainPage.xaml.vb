' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub AnswerButton_Click(sender As Object, e As RoutedEventArgs) Handles AnswerButton.Click
        AnswerBox.Visibility = Windows.UI.Xaml.Visibility.Visible
        AnswerBox.Text = "The Bass Guitar"
        GuitarImage.Visibility = Windows.UI.Xaml.Visibility.Visible

    End Sub
End Class
