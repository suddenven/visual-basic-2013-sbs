' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub NavigateButton_Click(sender As Object, e As RoutedEventArgs) Handles NavigateButton.Click
        Browser.Navigate(New Uri(URL.Text))
    End Sub
End Class
