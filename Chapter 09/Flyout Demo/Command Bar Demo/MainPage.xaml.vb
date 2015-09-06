' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Sub StopButton_Click()
        MediaTool.Stop()
    End Sub

    Sub PlayButton_Click()
        MediaTool.Play()
    End Sub

    Sub PauseButton_Click()
        MediaTool.Pause()
    End Sub

    Sub LoopButton_Click()
        MediaTool.IsLooping = Not MediaTool.IsLooping
    End Sub

    Sub MuteButton_Click()
        MediaTool.IsMuted = Not MediaTool.IsMuted
    End Sub

    Sub DisplayPhoto_Click()
        Image.Visibility = Windows.UI.Xaml.Visibility.Visible
        Button.Flyout.Hide()
    End Sub
End Class
