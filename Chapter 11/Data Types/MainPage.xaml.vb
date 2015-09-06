' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    'Declare variables for data type samples
    Dim birds As Short
    Dim insects As Integer
    Dim worldPop As Long
    Dim price As Single
    Dim pi As Double
    Dim debt As Decimal
    Dim retKey As Byte
    Dim unicodeChar As Char
    Dim dog As String
    Dim flag As Boolean
    Dim birthday As Date

    Private Sub DataTypeListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles DataTypeListBox.SelectionChanged
        Select Case DataTypeListBox.SelectedIndex 'process the user's list box selection
            Case 0
                birds = 12500
                SampleTextBox.Text = birds
            Case 1
                insects = 37500000
                SampleTextBox.Text = insects
            Case 2
                worldPop = 7100000000
                SampleTextBox.Text = worldPop
            Case 3
                price = 899.99
                SampleTextBox.Text = price
            Case 4
                pi = 3.1415926535
                SampleTextBox.Text = pi
            Case 5
                debt = 7600300.5D
                SampleTextBox.Text = debt
            Case 6
                retKey = 13
                SampleTextBox.Text = retKey
            Case 7
                unicodeChar = "Ä"c
                SampleTextBox.Text = unicodeChar
            Case 8
                dog = "pointer"
                SampleTextBox.Text = dog
            Case 9
                flag = True
                SampleTextBox.Text = flag
            Case 10
                birthday = #11/19/1985#
                SampleTextBox.Text = birthday
        End Select
    End Sub

End Class
