﻿' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    'Declare firstNum and secondNum as double-precision variables
    Dim firstNum, secondNum As Double

    Private Sub Calculate_Click(sender As Object, e As RoutedEventArgs) Handles Calculate.Click
        'Assign textbox values to variables
        firstNum = FirstTextBox.Text
        secondNum = SecondTextBox.Text

        'Determine checked button and calculate
        If IntDivision.IsChecked Then
            Result.Text = firstNum \ secondNum
        End If
        If RemainderDiv.IsChecked Then
            Result.Text = firstNum Mod secondNum
        End If
        If Exponent.IsChecked Then
            Result.Text = firstNum ^ secondNum
        End If
        If Concatenation.IsChecked Then
            Result.Text = firstNum & secondNum
        End If
    End Sub

End Class
