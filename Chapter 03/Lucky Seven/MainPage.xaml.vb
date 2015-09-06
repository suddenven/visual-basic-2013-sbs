' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub SpinButton_Click(sender As Object, e As RoutedEventArgs) Handles SpinButton.Click
        Dim generator As New Random
        CoinImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed

        FirstNum.Text = generator.Next(0, 9)
        SecondNum.Text = generator.Next(0, 9)
        ThirdNum.Text = generator.Next(0, 9)

        If (FirstNum.Text = "7") Or (SecondNum.Text = "7") Or
            (ThirdNum.Text = "7") Then
            CoinImage.Visibility = Windows.UI.Xaml.Visibility.Visible
            CoinSound.Play()
        End If
    End Sub
End Class
