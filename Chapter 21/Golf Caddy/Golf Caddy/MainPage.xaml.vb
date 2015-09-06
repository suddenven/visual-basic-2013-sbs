Imports System
Imports System.Threading
Imports System.Windows.Controls
Imports Microsoft.Phone.Controls
Imports Microsoft.Phone.Shell

Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()

        SupportedOrientations = SupportedPageOrientation.Portrait Or SupportedPageOrientation.Landscape

        ' Sample code to localize the ApplicationBar
        'BuildLocalizedApplicationBar()

        'Update the Golf Caddy UI using global variables (important if app was tombstoned)
        TotalTextBlock.Text = TotalScore
        CurrentHoleTextBlock.Text = "Hole: " & CurrentHole
    End Sub

    ' Sample code for building a localized ApplicationBar
    'Private Sub BuildLocalizedApplicationBar()
    '    ' Set the page's ApplicationBar to a new instance of ApplicationBar.
    '    ApplicationBar = New ApplicationBar()

    '    ' Create a new button and set the text value to the localized string from AppResources.
    '    Dim appBarButton As New ApplicationBarIconButton(New Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative))
    '    appBarButton.Text = AppResources.AppBarButtonText
    '    ApplicationBar.Buttons.Add(appBarButton)

    '    ' Create a new menu item with the localized string from AppResources.
    '    Dim appBarMenuItem As New ApplicationBarMenuItem(AppResources.AppBarMenuItemText)
    '    ApplicationBar.MenuItems.Add(appBarMenuItem)
    'End Sub

    Private Sub RecordScoreButton_Click(sender As Object, e As RoutedEventArgs) Handles RecordScoreButton.Click
        'add score from current hole to total and display
        TotalScore = TotalScore + HoleScoreTextBox.Text
        TotalTextBlock.Text = TotalScore

        'determine if there are any holes left to play
        If CurrentHole = 18 Then
            'stop if 18th hole finished; disable Score Hole button, await new round
            RecordScoreButton.IsEnabled = False
        Else
            'if not finished yet, move to next hole and await a new score
            CurrentHole = CurrentHole + 1
            CurrentHoleTextBlock.Text = "Hole: " & CurrentHole
        End If

    End Sub

    Private Sub NewRoundButton_Click(sender As Object, e As RoutedEventArgs) Handles NewRoundButton.Click
        'reset the game, variables, and user interface
        TotalScore = 0
        TotalTextBlock.Text = TotalScore
        CurrentHole = 1
        CurrentHoleTextBlock.Text = "Hole: 1"
        RecordScoreButton.IsEnabled = True

    End Sub

    Shared Function Grid() As Object
        Throw New NotImplementedException
    End Function

End Class