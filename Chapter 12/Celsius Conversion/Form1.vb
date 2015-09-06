Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fahrenTemp, celsius As Single
        Dim fTempInput As String
        Dim prompt As String = "Enter a Fahrenheit temperature."
        Do
            fTempInput = InputBox(prompt, "Fahrenheit to Celsius")
            If IsNumeric(fTempInput) Then
                fahrenTemp = CSng(fTempInput)
                celsius = Int((fahrenTemp + 40) * 5 / 9 - 40)
                MsgBox(celsius, , "Temperature in Celsius")
            End If
        Loop While fTempInput <> ""
        End

    End Sub
End Class
