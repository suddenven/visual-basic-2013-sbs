' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub PlayButton_Click(sender As Object, e As RoutedEventArgs) Handles PlayButton.Click
        MediaTool.Play()

    End Sub

    Private Sub PauseButton_Click(sender As Object, e As RoutedEventArgs) Handles PauseButton.Click
        MediaTool.Pause()

    End Sub

    Private Sub StopButton_Click(sender As Object, e As RoutedEventArgs) Handles StopButton.Click
        MediaTool.Stop()

    End Sub

    Private Sub MuteButton_Click(sender As Object, e As RoutedEventArgs) Handles MuteButton.Click
        MediaTool.IsMuted = Not MediaTool.IsMuted

    End Sub
End Class
