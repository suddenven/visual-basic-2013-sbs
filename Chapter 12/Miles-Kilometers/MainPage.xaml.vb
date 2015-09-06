' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub CreateButton_Click(sender As Object, e As RoutedEventArgs) Handles CreateButton.Click
        Dim miles As Single
        Dim kilometers As Single
        Const milesToKM As Single = 1.609344
        DataTextBox.Text = "Miles" & vbTab & "Kilometers" & vbCrLf
        For miles = 0.1 To 6.3 Step 0.1  'loop 63 times; display every tenth mile
            kilometers = milesToKM * miles
            'display miles and kilometers separated by a Tab character
            'format output with ToString; 1 numeric decimal place for miles
            'and 5 numeric decimal places for kilometers
            DataTextBox.Text &= miles.ToString("N1") & vbTab _
               & kilometers.ToString("N5") & vbCrLf
        Next miles
    End Sub
End Class