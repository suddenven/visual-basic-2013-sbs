' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub CountryListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles CountryListBox.SelectionChanged
        Select Case CountryListBox.SelectedIndex
            Case 0
                Country.Text = "Australia"
                GreetingTextBox.Text = "How ya goin' programmer?"
            Case 1
                Country.Text = "Germany"
                GreetingTextBox.Text = "Hallo, programmierer"
            Case 2
                Country.Text = "Italy"
                GreetingTextBox.Text = "Ciao, programmatore"
            Case 3
                Country.Text = "Mexico"
                GreetingTextBox.Text = "Hola, programador"
        End Select
    End Sub
End Class
