' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    'declare new generic collection of type String to hold names
    Dim FrenchNames As New Generic.List(Of String)

    Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs) Handles AddButton.Click
        'add the name from the NameInput text box to the collection
        FrenchNames.Add(NameInput.Text)
        'clear the new name from the text box and keep cursor there
        NameInput.Text = ""
        NameInput.Focus(Windows.UI.Xaml.FocusState.Programmatic)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As RoutedEventArgs) Handles ShowButton.Click
        'determine how many names are in the collection and display a message
        If FrenchNames.Count > 1 Then
            OutputTextBox.Text = "There are " & FrenchNames.Count & " names: " & vbCrLf
            'sort names in alphabetical order
            FrenchNames.Sort()
        ElseIf FrenchNames.Count = 1 Then
            OutputTextBox.Text = "There is 1 name:" & vbCrLf
        End If
        'then loop through collection, trim trailing spaces, and display
        For Each Name As String In FrenchNames
            OutputTextBox.Text = OutputTextBox.Text & Name.TrimEnd & vbCrLf
        Next
    End Sub

End Class
