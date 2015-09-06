' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub DisplayToggleBtn_Click(sender As Object, e As RoutedEventArgs) Handles DisplayToggleBtn.Click
        If DisplayToggleBtn.IsChecked Then
            AutumnImage.Visibility = Windows.UI.Xaml.Visibility.Visible
        Else
            AutumnImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed
        End If
    End Sub
End Class
