' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    'declare array of type Double to hold a week's worth of ski school revenue
    Dim WeekRevenue() As Double = {842.55, 340.05, 725.25, 680.43, 1120.38, 2675.99, 2175.64}
    'declare two string arrays with instructor names
    Dim WeekdayInstructors() As String = {"Bart", "Ken", "Maria", "Eve", "Claude", "Nikki"}
    Dim WeekendInstructors() As String = {"Eve", "Allen", "Juan", "Larry", "Kim", "Al"}
    'declare a generic collection list to hold student names input by user
    Dim StudentNames As New Generic.List(Of String)

    Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs) Handles AddButton.Click
        'add the name from the InputTextBox object to the collection
        StudentNames.Add(InputTextBox.Text.TrimEnd)
        'clear the new name from the text box and keep cursor there
        InputTextBox.Text = ""
        InputTextBox.Focus(Windows.UI.Xaml.FocusState.Programmatic)
    End Sub

    Private Sub RunQuery_Click(sender As Object, e As RoutedEventArgs) Handles RunQuery.Click
        
    End Sub
End Class
